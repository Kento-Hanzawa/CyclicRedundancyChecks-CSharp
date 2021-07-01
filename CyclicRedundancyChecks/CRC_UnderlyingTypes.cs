 
//
// CyclicRedundancyChecks
// 
// このコードはテキストテンプレートファイル (.tt) によって作成されています。
// 変更をおこなう場合は、テキストテンプレートファイル (.tt) を編集してください。
//

using System;

namespace CyclicRedundancyChecks.UnderlyingTypes
{
    /// <summary>
    /// 最大 8 ビットサイズまでの CRC 値を計算する機能を提供します。
    /// </summary>
    public class CRCByte : CRC
    {
        private global::System.Byte result;
        private global::System.Byte[] lookupTableBuffer;

        private readonly global::System.Byte bitMask;
        private readonly int byteSize;

        public global::System.Byte Polynomial { get; }
        public global::System.Byte InitialValue { get; }
        public global::System.Byte FinalXorValue { get; }
        public bool ReflectInput { get; }
        public bool ReflectOutput { get; }
        public bool IsLookupTable { get; set; }
        public bool IsBigEndianResult { get; set; }

        public virtual ReadOnlySpan<global::System.Byte> LookupTable
        {
            get
            {
                if (lookupTableBuffer == null)
                {
                    lookupTableBuffer = System.Buffers.ArrayPool<global::System.Byte>.Shared.Rent(LookupTableSize);
                    LookupTableFill(lookupTableBuffer, HashSizeValue, Polynomial);
                }
                return lookupTableBuffer.AsSpan(0, LookupTableSize);
            } 
        }



        public CRCByte(int bitWidth, global::System.Byte polynomial, global::System.Byte initialValue, global::System.Byte finalXorValue, bool reflectInput, bool reflectOutput, bool isLookupTable = true, bool isBigEndianResult = false)
        {
            const int MaxBitWidth = sizeof(global::System.Byte) * 8;
            bitWidth = Math.Clamp(bitWidth, 0, MaxBitWidth);

            this.HashSizeValue = bitWidth;
            this.Polynomial = polynomial;
            this.InitialValue = initialValue;
            this.FinalXorValue = finalXorValue;
            this.ReflectInput = reflectInput;
            this.ReflectOutput = reflectOutput;
            this.IsLookupTable = isLookupTable;
            this.IsBigEndianResult = isBigEndianResult;

            this.result = initialValue;
            this.bitMask = (bitWidth == MaxBitWidth) ? (global::System.Byte)0xFF : (global::System.Byte)(((global::System.Byte)1 << bitWidth) - 1);
            this.byteSize = sizeof(global::System.Byte);
        }



        public override void Initialize()
        {
            result = InitialValue;
        }



        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            HashCore(array.AsSpan(ibStart, cbSize));
        }

        protected override void HashCore(ReadOnlySpan<byte> source)
        {
            if (IsLookupTable)
            {
                Calculate(ref result, source, HashSizeValue, LookupTable, ReflectInput);
            }
            else
            {
                Calculate(ref result, source, HashSizeValue, Polynomial, ReflectInput);
            }
        }



        protected override byte[] HashFinal()
        {
            Span<byte> span = stackalloc byte[byteSize];
            TryHashFinal(span, out _);
            return span.ToArray();
        }

        protected override bool TryHashFinal(Span<byte> destination, out int bytesWritten)
        {
            if (destination.Length < byteSize)
            {
                bytesWritten = 0;
                return false;
            }
           
            if (ReflectOutput)
            {
                result = CRCUtility.BitReflect(result, HashSizeValue);
            }
            result ^= FinalXorValue;
            result = (global::System.Byte)(result & bitMask);

            for (var i = 0; i < byteSize; i++)
            {
                if (IsBigEndianResult)
                {
                    destination[i] = (byte)(result >> ((byteSize * 8) - ((i * 8) + 8)));
                }
                else
                {
                    destination[i] = (byte)(result >> (i * 8));
                }
            }
            bytesWritten = byteSize;
            return true;
        }



        protected static void LookupTableFill(Span<global::System.Byte> table, in int bitWidth, global::System.Byte polynomial)
        {
            for (int i = 0; i < LookupTableSize; i++)
            {
                byte dividend = (byte)(i & byte.MaxValue);
                table[i] = PolynomialDivRem(dividend, bitWidth, polynomial);
            }
        }



        private static void Calculate(ref global::System.Byte crc, in ReadOnlySpan<byte> bytes, in int bitWidth, in global::System.Byte polynomial, in bool reflectInput)
        {
            const int InputBits = sizeof(byte) * 8;
            for (var i = 0; i < bytes.Length; i++)
            {
                var input = reflectInput ? CRCUtility.BitReflect(bytes[i]) : bytes[i];

                // crc と input を、元々一つの連続したデータとして計算したときと同じ結果になるようにマージします。
                byte dividend;
                if (bitWidth < 8)
                {
                    // input: aaaa bbbb (8ビット)
                    // crc  : 0aaa bbbb (7ビット以下)
                    // crc  : aaab bbb0 (ビット全体を左詰めする)
                    var leftJustified = (crc << (InputBits - bitWidth)) & byte.MaxValue;
                    // aaaa bbbb ^ aaab bbb0 (XOR!)
                    dividend = (byte)(leftJustified ^ input);
                }
                else
                {
                    // input:               aaaa bbbb (8ビット)
                    // crc  : aaaa bbbb ... yyyy zzzz (8ビット以上)
                    // crc  : aaaa bbbb (先頭 8 ビットを抽出)
                    var top8 = (crc >> (bitWidth - InputBits)) & byte.MaxValue;
                    // aaaa bbbb ^ aaaa bbbb (XOR!)
                    dividend = (byte)(top8 ^ input);
                }

                // 先頭 8 ビットを除去するように左へビットシフトし、PolynomialDivRem で得られた剰余と XOR 演算します。
                // この値が現在の input までの CRC となります。これをデータの長さ分繰り返します。
                // crc      : aaaa bbbb cccc ... xxxx yyyy zzzz
                // crc      : cccc dddd eeee ... zzzz 0000 0000 ( << 8 )
                // remainder: aaaa bbbb cccc ... xxxx yyyy zzzz (剰余。長さは crc と同じ)
                global::System.Byte remainder = PolynomialDivRem(dividend, bitWidth, polynomial);
                // cccc dddd eeee ... zzzz 0000 0000 ^ aaaa bbbb cccc ... xxxx yyyy zzzz (XOR!)
                crc = (global::System.Byte)((crc << InputBits) ^ remainder);
            }
        }

        private static void Calculate(ref global::System.Byte crc, in ReadOnlySpan<byte> bytes, in int bitWidth, in ReadOnlySpan<global::System.Byte> table, in bool reflectInput)
        {
            const int InputBits = sizeof(byte) * 8;
            for (var i = 0; i < bytes.Length; i++)
            {
                var input = reflectInput ? CRCUtility.BitReflect(bytes[i]) : bytes[i];

                // crc と input を、元々一つの連続したデータとして計算したときと同じ結果になるようにマージします。
                byte dividend;
                if (bitWidth < 8)
                {
                    // input: aaaa bbbb (8ビット)
                    // crc  : 0aaa bbbb (7ビット以下)
                    // crc  : aaab bbb0 (ビット全体を左詰めする)
                    var leftJustified = (crc << (InputBits - bitWidth)) & byte.MaxValue;
                    // aaaa bbbb ^ aaab bbb0 (XOR!)
                    dividend = (byte)(leftJustified ^ input);
                }
                else
                {
                    // input:               aaaa bbbb (8ビット)
                    // crc  : aaaa bbbb ... yyyy zzzz (8ビット以上)
                    // crc  : aaaa bbbb (先頭 8 ビットを抽出)
                    var top8 = (crc >> (bitWidth - InputBits)) & byte.MaxValue;
                    // aaaa bbbb ^ aaaa bbbb (XOR!)
                    dividend = (byte)(top8 ^ input);
                }

                // 先頭 8 ビットを除去するように左へビットシフトし、PolynomialDivRem で得られた剰余と XOR 演算します。
                // この値が現在の input までの CRC となります。これをデータの長さ分繰り返します。
                // crc      : aaaa bbbb cccc ... xxxx yyyy zzzz
                // crc      : cccc dddd eeee ... zzzz 0000 0000 ( << 8 )
                // remainder: aaaa bbbb cccc ... xxxx yyyy zzzz (剰余。長さは crc と同じ)
                global::System.Byte remainder = table[dividend];
                // cccc dddd eeee ... zzzz 0000 0000 ^ aaaa bbbb cccc ... xxxx yyyy zzzz (XOR!)
                crc = (global::System.Byte)((crc << InputBits) ^ remainder);
            }
        }



        private static global::System.Byte PolynomialDivRem(in byte dividend, in int bitWidth, global::System.Byte polynomial)
        {
            const int InputBits = sizeof(byte) * 8; // dividend のサイズ。

            if (bitWidth < 8)
            {
                // remainder: aaaa bbbb
                global::System.Byte remainder = (global::System.Byte)dividend;
                // polynomial の先頭ビット (bitWidth の位置) が、remainder の先頭ビット (8) に合うようにシフト演算します。
                // polynomial: 0aaa bbbb (7ビット以下)
                // polynomial: aaab bbb0
                polynomial = (global::System.Byte)(polynomial << (InputBits - bitWidth));

                // remainder の先頭ビットが 0 の場合は remainder を 1 だけ左シフト、
                // 1 の場合は remainder を 1 だけ左シフトした後に polynomial と XOR 演算します。
                // これを dividend のビット長分だけ繰り返して剰余を計算します。
                // dividend: aaaa bbbb
                //           ^ (ここを見る)
                const int LoopCount = InputBits;
                for (int i = 0; i < LoopCount; i++)
                {
                    global::System.Byte TopBit = (global::System.Byte)(0x80);
                    if ((remainder & TopBit) == 0)
                    {
                        remainder <<= 1;
                    }
                    else
                    {
                        remainder <<= 1;
                        remainder ^= polynomial;
                    }
                }

                // 最初に polynomial をシフトした影響で、remainder の値が左に寄った感じになっています。
                // remainder: aaab bbb0
                // なので、polynomial のシフトと逆方向に同じ分だけシフトし直して、正しい位置に戻します。
                // remainder: 0aaa bbbb
                return (global::System.Byte)(remainder >> (InputBits - bitWidth));
            }
            else
            {
                // dividend の先頭ビット位置を polynomial の先頭ビット (bitWidth の位置) に合わせます。
                // polynomial: 00aa bbbb cccc ... yyyy zzzz
                // dividend  :                    aaaa bbbb
                // dividend  :   aa aabb bb00 ... 0000 0000
                global::System.Byte remainder = (global::System.Byte)((global::System.Byte)dividend << (bitWidth - InputBits));

                // remainder の先頭ビットが 0 の場合は remainder を 1 だけ左シフト、
                // 1 の場合は remainder を 1 だけ左シフトした後に polynomial と XOR 演算します。
                // これを dividend のビット長分だけ繰り返して剰余を計算します。
                // dividend: aaaa bbbb
                //           ^ (ここを見る)
                const int LoopCount = InputBits;
                for (int i = 0; i < LoopCount; i++)
                {
                    global::System.Byte TopBit = (global::System.Byte)((global::System.Byte)1U << (bitWidth - 1));

                    if ((remainder & TopBit) == 0)
                    {
                        remainder <<= 1;
                    }
                    else
                    {
                        remainder <<= 1;
                        remainder ^= polynomial;
                    }
                }

                return remainder;
            }
        }



        #region IDisposable

        private bool disposedValue = false;

        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (lookupTableBuffer != null)
                    {
                        System.Buffers.ArrayPool<global::System.Byte>.Shared.Return(lookupTableBuffer);
                    }
                }
                disposedValue = true;
            }
            base.Dispose(disposing);
        }

        #endregion
    }

    /// <summary>
    /// 最大 16 ビットサイズまでの CRC 値を計算する機能を提供します。
    /// </summary>
    public class CRCUInt16 : CRC
    {
        private global::System.UInt16 result;
        private global::System.UInt16[] lookupTableBuffer;

        private readonly global::System.UInt16 bitMask;
        private readonly int byteSize;

        public global::System.UInt16 Polynomial { get; }
        public global::System.UInt16 InitialValue { get; }
        public global::System.UInt16 FinalXorValue { get; }
        public bool ReflectInput { get; }
        public bool ReflectOutput { get; }
        public bool IsLookupTable { get; set; }
        public bool IsBigEndianResult { get; set; }

        public virtual ReadOnlySpan<global::System.UInt16> LookupTable
        {
            get
            {
                if (lookupTableBuffer == null)
                {
                    lookupTableBuffer = System.Buffers.ArrayPool<global::System.UInt16>.Shared.Rent(LookupTableSize);
                    LookupTableFill(lookupTableBuffer, HashSizeValue, Polynomial);
                }
                return lookupTableBuffer.AsSpan(0, LookupTableSize);
            } 
        }



        public CRCUInt16(int bitWidth, global::System.UInt16 polynomial, global::System.UInt16 initialValue, global::System.UInt16 finalXorValue, bool reflectInput, bool reflectOutput, bool isLookupTable = true, bool isBigEndianResult = false)
        {
            const int MaxBitWidth = sizeof(global::System.UInt16) * 8;
            bitWidth = Math.Clamp(bitWidth, 0, MaxBitWidth);

            this.HashSizeValue = bitWidth;
            this.Polynomial = polynomial;
            this.InitialValue = initialValue;
            this.FinalXorValue = finalXorValue;
            this.ReflectInput = reflectInput;
            this.ReflectOutput = reflectOutput;
            this.IsLookupTable = isLookupTable;
            this.IsBigEndianResult = isBigEndianResult;

            this.result = initialValue;
            this.bitMask = (bitWidth == MaxBitWidth) ? (global::System.UInt16)0xFFFF : (global::System.UInt16)(((global::System.UInt16)1 << bitWidth) - 1);
            this.byteSize = sizeof(global::System.UInt16);
        }



        public override void Initialize()
        {
            result = InitialValue;
        }



        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            HashCore(array.AsSpan(ibStart, cbSize));
        }

        protected override void HashCore(ReadOnlySpan<byte> source)
        {
            if (IsLookupTable)
            {
                Calculate(ref result, source, HashSizeValue, LookupTable, ReflectInput);
            }
            else
            {
                Calculate(ref result, source, HashSizeValue, Polynomial, ReflectInput);
            }
        }



        protected override byte[] HashFinal()
        {
            Span<byte> span = stackalloc byte[byteSize];
            TryHashFinal(span, out _);
            return span.ToArray();
        }

        protected override bool TryHashFinal(Span<byte> destination, out int bytesWritten)
        {
            if (destination.Length < byteSize)
            {
                bytesWritten = 0;
                return false;
            }
           
            if (ReflectOutput)
            {
                result = CRCUtility.BitReflect(result, HashSizeValue);
            }
            result ^= FinalXorValue;
            result = (global::System.UInt16)(result & bitMask);

            for (var i = 0; i < byteSize; i++)
            {
                if (IsBigEndianResult)
                {
                    destination[i] = (byte)(result >> ((byteSize * 8) - ((i * 8) + 8)));
                }
                else
                {
                    destination[i] = (byte)(result >> (i * 8));
                }
            }
            bytesWritten = byteSize;
            return true;
        }



        protected static void LookupTableFill(Span<global::System.UInt16> table, in int bitWidth, global::System.UInt16 polynomial)
        {
            for (int i = 0; i < LookupTableSize; i++)
            {
                byte dividend = (byte)(i & byte.MaxValue);
                table[i] = PolynomialDivRem(dividend, bitWidth, polynomial);
            }
        }



        private static void Calculate(ref global::System.UInt16 crc, in ReadOnlySpan<byte> bytes, in int bitWidth, in global::System.UInt16 polynomial, in bool reflectInput)
        {
            const int InputBits = sizeof(byte) * 8;
            for (var i = 0; i < bytes.Length; i++)
            {
                var input = reflectInput ? CRCUtility.BitReflect(bytes[i]) : bytes[i];

                // crc と input を、元々一つの連続したデータとして計算したときと同じ結果になるようにマージします。
                byte dividend;
                if (bitWidth < 8)
                {
                    // input: aaaa bbbb (8ビット)
                    // crc  : 0aaa bbbb (7ビット以下)
                    // crc  : aaab bbb0 (ビット全体を左詰めする)
                    var leftJustified = (crc << (InputBits - bitWidth)) & byte.MaxValue;
                    // aaaa bbbb ^ aaab bbb0 (XOR!)
                    dividend = (byte)(leftJustified ^ input);
                }
                else
                {
                    // input:               aaaa bbbb (8ビット)
                    // crc  : aaaa bbbb ... yyyy zzzz (8ビット以上)
                    // crc  : aaaa bbbb (先頭 8 ビットを抽出)
                    var top8 = (crc >> (bitWidth - InputBits)) & byte.MaxValue;
                    // aaaa bbbb ^ aaaa bbbb (XOR!)
                    dividend = (byte)(top8 ^ input);
                }

                // 先頭 8 ビットを除去するように左へビットシフトし、PolynomialDivRem で得られた剰余と XOR 演算します。
                // この値が現在の input までの CRC となります。これをデータの長さ分繰り返します。
                // crc      : aaaa bbbb cccc ... xxxx yyyy zzzz
                // crc      : cccc dddd eeee ... zzzz 0000 0000 ( << 8 )
                // remainder: aaaa bbbb cccc ... xxxx yyyy zzzz (剰余。長さは crc と同じ)
                global::System.UInt16 remainder = PolynomialDivRem(dividend, bitWidth, polynomial);
                // cccc dddd eeee ... zzzz 0000 0000 ^ aaaa bbbb cccc ... xxxx yyyy zzzz (XOR!)
                crc = (global::System.UInt16)((crc << InputBits) ^ remainder);
            }
        }

        private static void Calculate(ref global::System.UInt16 crc, in ReadOnlySpan<byte> bytes, in int bitWidth, in ReadOnlySpan<global::System.UInt16> table, in bool reflectInput)
        {
            const int InputBits = sizeof(byte) * 8;
            for (var i = 0; i < bytes.Length; i++)
            {
                var input = reflectInput ? CRCUtility.BitReflect(bytes[i]) : bytes[i];

                // crc と input を、元々一つの連続したデータとして計算したときと同じ結果になるようにマージします。
                byte dividend;
                if (bitWidth < 8)
                {
                    // input: aaaa bbbb (8ビット)
                    // crc  : 0aaa bbbb (7ビット以下)
                    // crc  : aaab bbb0 (ビット全体を左詰めする)
                    var leftJustified = (crc << (InputBits - bitWidth)) & byte.MaxValue;
                    // aaaa bbbb ^ aaab bbb0 (XOR!)
                    dividend = (byte)(leftJustified ^ input);
                }
                else
                {
                    // input:               aaaa bbbb (8ビット)
                    // crc  : aaaa bbbb ... yyyy zzzz (8ビット以上)
                    // crc  : aaaa bbbb (先頭 8 ビットを抽出)
                    var top8 = (crc >> (bitWidth - InputBits)) & byte.MaxValue;
                    // aaaa bbbb ^ aaaa bbbb (XOR!)
                    dividend = (byte)(top8 ^ input);
                }

                // 先頭 8 ビットを除去するように左へビットシフトし、PolynomialDivRem で得られた剰余と XOR 演算します。
                // この値が現在の input までの CRC となります。これをデータの長さ分繰り返します。
                // crc      : aaaa bbbb cccc ... xxxx yyyy zzzz
                // crc      : cccc dddd eeee ... zzzz 0000 0000 ( << 8 )
                // remainder: aaaa bbbb cccc ... xxxx yyyy zzzz (剰余。長さは crc と同じ)
                global::System.UInt16 remainder = table[dividend];
                // cccc dddd eeee ... zzzz 0000 0000 ^ aaaa bbbb cccc ... xxxx yyyy zzzz (XOR!)
                crc = (global::System.UInt16)((crc << InputBits) ^ remainder);
            }
        }



        private static global::System.UInt16 PolynomialDivRem(in byte dividend, in int bitWidth, global::System.UInt16 polynomial)
        {
            const int InputBits = sizeof(byte) * 8; // dividend のサイズ。

            if (bitWidth < 8)
            {
                // remainder: aaaa bbbb
                global::System.UInt16 remainder = (global::System.UInt16)dividend;
                // polynomial の先頭ビット (bitWidth の位置) が、remainder の先頭ビット (8) に合うようにシフト演算します。
                // polynomial: 0aaa bbbb (7ビット以下)
                // polynomial: aaab bbb0
                polynomial = (global::System.UInt16)(polynomial << (InputBits - bitWidth));

                // remainder の先頭ビットが 0 の場合は remainder を 1 だけ左シフト、
                // 1 の場合は remainder を 1 だけ左シフトした後に polynomial と XOR 演算します。
                // これを dividend のビット長分だけ繰り返して剰余を計算します。
                // dividend: aaaa bbbb
                //           ^ (ここを見る)
                const int LoopCount = InputBits;
                for (int i = 0; i < LoopCount; i++)
                {
                    global::System.UInt16 TopBit = (global::System.UInt16)(0x80);
                    if ((remainder & TopBit) == 0)
                    {
                        remainder <<= 1;
                    }
                    else
                    {
                        remainder <<= 1;
                        remainder ^= polynomial;
                    }
                }

                // 最初に polynomial をシフトした影響で、remainder の値が左に寄った感じになっています。
                // remainder: aaab bbb0
                // なので、polynomial のシフトと逆方向に同じ分だけシフトし直して、正しい位置に戻します。
                // remainder: 0aaa bbbb
                return (global::System.UInt16)(remainder >> (InputBits - bitWidth));
            }
            else
            {
                // dividend の先頭ビット位置を polynomial の先頭ビット (bitWidth の位置) に合わせます。
                // polynomial: 00aa bbbb cccc ... yyyy zzzz
                // dividend  :                    aaaa bbbb
                // dividend  :   aa aabb bb00 ... 0000 0000
                global::System.UInt16 remainder = (global::System.UInt16)((global::System.UInt16)dividend << (bitWidth - InputBits));

                // remainder の先頭ビットが 0 の場合は remainder を 1 だけ左シフト、
                // 1 の場合は remainder を 1 だけ左シフトした後に polynomial と XOR 演算します。
                // これを dividend のビット長分だけ繰り返して剰余を計算します。
                // dividend: aaaa bbbb
                //           ^ (ここを見る)
                const int LoopCount = InputBits;
                for (int i = 0; i < LoopCount; i++)
                {
                    global::System.UInt16 TopBit = (global::System.UInt16)((global::System.UInt16)1U << (bitWidth - 1));

                    if ((remainder & TopBit) == 0)
                    {
                        remainder <<= 1;
                    }
                    else
                    {
                        remainder <<= 1;
                        remainder ^= polynomial;
                    }
                }

                return remainder;
            }
        }



        #region IDisposable

        private bool disposedValue = false;

        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (lookupTableBuffer != null)
                    {
                        System.Buffers.ArrayPool<global::System.UInt16>.Shared.Return(lookupTableBuffer);
                    }
                }
                disposedValue = true;
            }
            base.Dispose(disposing);
        }

        #endregion
    }

    /// <summary>
    /// 最大 32 ビットサイズまでの CRC 値を計算する機能を提供します。
    /// </summary>
    public class CRCUInt32 : CRC
    {
        private global::System.UInt32 result;
        private global::System.UInt32[] lookupTableBuffer;

        private readonly global::System.UInt32 bitMask;
        private readonly int byteSize;

        public global::System.UInt32 Polynomial { get; }
        public global::System.UInt32 InitialValue { get; }
        public global::System.UInt32 FinalXorValue { get; }
        public bool ReflectInput { get; }
        public bool ReflectOutput { get; }
        public bool IsLookupTable { get; set; }
        public bool IsBigEndianResult { get; set; }

        public virtual ReadOnlySpan<global::System.UInt32> LookupTable
        {
            get
            {
                if (lookupTableBuffer == null)
                {
                    lookupTableBuffer = System.Buffers.ArrayPool<global::System.UInt32>.Shared.Rent(LookupTableSize);
                    LookupTableFill(lookupTableBuffer, HashSizeValue, Polynomial);
                }
                return lookupTableBuffer.AsSpan(0, LookupTableSize);
            } 
        }



        public CRCUInt32(int bitWidth, global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isLookupTable = true, bool isBigEndianResult = false)
        {
            const int MaxBitWidth = sizeof(global::System.UInt32) * 8;
            bitWidth = Math.Clamp(bitWidth, 0, MaxBitWidth);

            this.HashSizeValue = bitWidth;
            this.Polynomial = polynomial;
            this.InitialValue = initialValue;
            this.FinalXorValue = finalXorValue;
            this.ReflectInput = reflectInput;
            this.ReflectOutput = reflectOutput;
            this.IsLookupTable = isLookupTable;
            this.IsBigEndianResult = isBigEndianResult;

            this.result = initialValue;
            this.bitMask = (bitWidth == MaxBitWidth) ? (global::System.UInt32)0xFFFFFFFF : (global::System.UInt32)(((global::System.UInt32)1 << bitWidth) - 1);
            this.byteSize = sizeof(global::System.UInt32);
        }



        public override void Initialize()
        {
            result = InitialValue;
        }



        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            HashCore(array.AsSpan(ibStart, cbSize));
        }

        protected override void HashCore(ReadOnlySpan<byte> source)
        {
            if (IsLookupTable)
            {
                Calculate(ref result, source, HashSizeValue, LookupTable, ReflectInput);
            }
            else
            {
                Calculate(ref result, source, HashSizeValue, Polynomial, ReflectInput);
            }
        }



        protected override byte[] HashFinal()
        {
            Span<byte> span = stackalloc byte[byteSize];
            TryHashFinal(span, out _);
            return span.ToArray();
        }

        protected override bool TryHashFinal(Span<byte> destination, out int bytesWritten)
        {
            if (destination.Length < byteSize)
            {
                bytesWritten = 0;
                return false;
            }
           
            if (ReflectOutput)
            {
                result = CRCUtility.BitReflect(result, HashSizeValue);
            }
            result ^= FinalXorValue;
            result = (global::System.UInt32)(result & bitMask);

            for (var i = 0; i < byteSize; i++)
            {
                if (IsBigEndianResult)
                {
                    destination[i] = (byte)(result >> ((byteSize * 8) - ((i * 8) + 8)));
                }
                else
                {
                    destination[i] = (byte)(result >> (i * 8));
                }
            }
            bytesWritten = byteSize;
            return true;
        }



        protected static void LookupTableFill(Span<global::System.UInt32> table, in int bitWidth, global::System.UInt32 polynomial)
        {
            for (int i = 0; i < LookupTableSize; i++)
            {
                byte dividend = (byte)(i & byte.MaxValue);
                table[i] = PolynomialDivRem(dividend, bitWidth, polynomial);
            }
        }



        private static void Calculate(ref global::System.UInt32 crc, in ReadOnlySpan<byte> bytes, in int bitWidth, in global::System.UInt32 polynomial, in bool reflectInput)
        {
            const int InputBits = sizeof(byte) * 8;
            for (var i = 0; i < bytes.Length; i++)
            {
                var input = reflectInput ? CRCUtility.BitReflect(bytes[i]) : bytes[i];

                // crc と input を、元々一つの連続したデータとして計算したときと同じ結果になるようにマージします。
                byte dividend;
                if (bitWidth < 8)
                {
                    // input: aaaa bbbb (8ビット)
                    // crc  : 0aaa bbbb (7ビット以下)
                    // crc  : aaab bbb0 (ビット全体を左詰めする)
                    var leftJustified = (crc << (InputBits - bitWidth)) & byte.MaxValue;
                    // aaaa bbbb ^ aaab bbb0 (XOR!)
                    dividend = (byte)(leftJustified ^ input);
                }
                else
                {
                    // input:               aaaa bbbb (8ビット)
                    // crc  : aaaa bbbb ... yyyy zzzz (8ビット以上)
                    // crc  : aaaa bbbb (先頭 8 ビットを抽出)
                    var top8 = (crc >> (bitWidth - InputBits)) & byte.MaxValue;
                    // aaaa bbbb ^ aaaa bbbb (XOR!)
                    dividend = (byte)(top8 ^ input);
                }

                // 先頭 8 ビットを除去するように左へビットシフトし、PolynomialDivRem で得られた剰余と XOR 演算します。
                // この値が現在の input までの CRC となります。これをデータの長さ分繰り返します。
                // crc      : aaaa bbbb cccc ... xxxx yyyy zzzz
                // crc      : cccc dddd eeee ... zzzz 0000 0000 ( << 8 )
                // remainder: aaaa bbbb cccc ... xxxx yyyy zzzz (剰余。長さは crc と同じ)
                global::System.UInt32 remainder = PolynomialDivRem(dividend, bitWidth, polynomial);
                // cccc dddd eeee ... zzzz 0000 0000 ^ aaaa bbbb cccc ... xxxx yyyy zzzz (XOR!)
                crc = (global::System.UInt32)((crc << InputBits) ^ remainder);
            }
        }

        private static void Calculate(ref global::System.UInt32 crc, in ReadOnlySpan<byte> bytes, in int bitWidth, in ReadOnlySpan<global::System.UInt32> table, in bool reflectInput)
        {
            const int InputBits = sizeof(byte) * 8;
            for (var i = 0; i < bytes.Length; i++)
            {
                var input = reflectInput ? CRCUtility.BitReflect(bytes[i]) : bytes[i];

                // crc と input を、元々一つの連続したデータとして計算したときと同じ結果になるようにマージします。
                byte dividend;
                if (bitWidth < 8)
                {
                    // input: aaaa bbbb (8ビット)
                    // crc  : 0aaa bbbb (7ビット以下)
                    // crc  : aaab bbb0 (ビット全体を左詰めする)
                    var leftJustified = (crc << (InputBits - bitWidth)) & byte.MaxValue;
                    // aaaa bbbb ^ aaab bbb0 (XOR!)
                    dividend = (byte)(leftJustified ^ input);
                }
                else
                {
                    // input:               aaaa bbbb (8ビット)
                    // crc  : aaaa bbbb ... yyyy zzzz (8ビット以上)
                    // crc  : aaaa bbbb (先頭 8 ビットを抽出)
                    var top8 = (crc >> (bitWidth - InputBits)) & byte.MaxValue;
                    // aaaa bbbb ^ aaaa bbbb (XOR!)
                    dividend = (byte)(top8 ^ input);
                }

                // 先頭 8 ビットを除去するように左へビットシフトし、PolynomialDivRem で得られた剰余と XOR 演算します。
                // この値が現在の input までの CRC となります。これをデータの長さ分繰り返します。
                // crc      : aaaa bbbb cccc ... xxxx yyyy zzzz
                // crc      : cccc dddd eeee ... zzzz 0000 0000 ( << 8 )
                // remainder: aaaa bbbb cccc ... xxxx yyyy zzzz (剰余。長さは crc と同じ)
                global::System.UInt32 remainder = table[dividend];
                // cccc dddd eeee ... zzzz 0000 0000 ^ aaaa bbbb cccc ... xxxx yyyy zzzz (XOR!)
                crc = (global::System.UInt32)((crc << InputBits) ^ remainder);
            }
        }



        private static global::System.UInt32 PolynomialDivRem(in byte dividend, in int bitWidth, global::System.UInt32 polynomial)
        {
            const int InputBits = sizeof(byte) * 8; // dividend のサイズ。

            if (bitWidth < 8)
            {
                // remainder: aaaa bbbb
                global::System.UInt32 remainder = (global::System.UInt32)dividend;
                // polynomial の先頭ビット (bitWidth の位置) が、remainder の先頭ビット (8) に合うようにシフト演算します。
                // polynomial: 0aaa bbbb (7ビット以下)
                // polynomial: aaab bbb0
                polynomial = (global::System.UInt32)(polynomial << (InputBits - bitWidth));

                // remainder の先頭ビットが 0 の場合は remainder を 1 だけ左シフト、
                // 1 の場合は remainder を 1 だけ左シフトした後に polynomial と XOR 演算します。
                // これを dividend のビット長分だけ繰り返して剰余を計算します。
                // dividend: aaaa bbbb
                //           ^ (ここを見る)
                const int LoopCount = InputBits;
                for (int i = 0; i < LoopCount; i++)
                {
                    global::System.UInt32 TopBit = (global::System.UInt32)(0x80);
                    if ((remainder & TopBit) == 0)
                    {
                        remainder <<= 1;
                    }
                    else
                    {
                        remainder <<= 1;
                        remainder ^= polynomial;
                    }
                }

                // 最初に polynomial をシフトした影響で、remainder の値が左に寄った感じになっています。
                // remainder: aaab bbb0
                // なので、polynomial のシフトと逆方向に同じ分だけシフトし直して、正しい位置に戻します。
                // remainder: 0aaa bbbb
                return (global::System.UInt32)(remainder >> (InputBits - bitWidth));
            }
            else
            {
                // dividend の先頭ビット位置を polynomial の先頭ビット (bitWidth の位置) に合わせます。
                // polynomial: 00aa bbbb cccc ... yyyy zzzz
                // dividend  :                    aaaa bbbb
                // dividend  :   aa aabb bb00 ... 0000 0000
                global::System.UInt32 remainder = (global::System.UInt32)((global::System.UInt32)dividend << (bitWidth - InputBits));

                // remainder の先頭ビットが 0 の場合は remainder を 1 だけ左シフト、
                // 1 の場合は remainder を 1 だけ左シフトした後に polynomial と XOR 演算します。
                // これを dividend のビット長分だけ繰り返して剰余を計算します。
                // dividend: aaaa bbbb
                //           ^ (ここを見る)
                const int LoopCount = InputBits;
                for (int i = 0; i < LoopCount; i++)
                {
                    global::System.UInt32 TopBit = (global::System.UInt32)((global::System.UInt32)1U << (bitWidth - 1));

                    if ((remainder & TopBit) == 0)
                    {
                        remainder <<= 1;
                    }
                    else
                    {
                        remainder <<= 1;
                        remainder ^= polynomial;
                    }
                }

                return remainder;
            }
        }



        #region IDisposable

        private bool disposedValue = false;

        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (lookupTableBuffer != null)
                    {
                        System.Buffers.ArrayPool<global::System.UInt32>.Shared.Return(lookupTableBuffer);
                    }
                }
                disposedValue = true;
            }
            base.Dispose(disposing);
        }

        #endregion
    }

    /// <summary>
    /// 最大 64 ビットサイズまでの CRC 値を計算する機能を提供します。
    /// </summary>
    public class CRCUInt64 : CRC
    {
        private global::System.UInt64 result;
        private global::System.UInt64[] lookupTableBuffer;

        private readonly global::System.UInt64 bitMask;
        private readonly int byteSize;

        public global::System.UInt64 Polynomial { get; }
        public global::System.UInt64 InitialValue { get; }
        public global::System.UInt64 FinalXorValue { get; }
        public bool ReflectInput { get; }
        public bool ReflectOutput { get; }
        public bool IsLookupTable { get; set; }
        public bool IsBigEndianResult { get; set; }

        public virtual ReadOnlySpan<global::System.UInt64> LookupTable
        {
            get
            {
                if (lookupTableBuffer == null)
                {
                    lookupTableBuffer = System.Buffers.ArrayPool<global::System.UInt64>.Shared.Rent(LookupTableSize);
                    LookupTableFill(lookupTableBuffer, HashSizeValue, Polynomial);
                }
                return lookupTableBuffer.AsSpan(0, LookupTableSize);
            } 
        }



        public CRCUInt64(int bitWidth, global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isLookupTable = true, bool isBigEndianResult = false)
        {
            const int MaxBitWidth = sizeof(global::System.UInt64) * 8;
            bitWidth = Math.Clamp(bitWidth, 0, MaxBitWidth);

            this.HashSizeValue = bitWidth;
            this.Polynomial = polynomial;
            this.InitialValue = initialValue;
            this.FinalXorValue = finalXorValue;
            this.ReflectInput = reflectInput;
            this.ReflectOutput = reflectOutput;
            this.IsLookupTable = isLookupTable;
            this.IsBigEndianResult = isBigEndianResult;

            this.result = initialValue;
            this.bitMask = (bitWidth == MaxBitWidth) ? (global::System.UInt64)0xFFFFFFFFFFFFFFFF : (global::System.UInt64)(((global::System.UInt64)1 << bitWidth) - 1);
            this.byteSize = sizeof(global::System.UInt64);
        }



        public override void Initialize()
        {
            result = InitialValue;
        }



        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            HashCore(array.AsSpan(ibStart, cbSize));
        }

        protected override void HashCore(ReadOnlySpan<byte> source)
        {
            if (IsLookupTable)
            {
                Calculate(ref result, source, HashSizeValue, LookupTable, ReflectInput);
            }
            else
            {
                Calculate(ref result, source, HashSizeValue, Polynomial, ReflectInput);
            }
        }



        protected override byte[] HashFinal()
        {
            Span<byte> span = stackalloc byte[byteSize];
            TryHashFinal(span, out _);
            return span.ToArray();
        }

        protected override bool TryHashFinal(Span<byte> destination, out int bytesWritten)
        {
            if (destination.Length < byteSize)
            {
                bytesWritten = 0;
                return false;
            }
           
            if (ReflectOutput)
            {
                result = CRCUtility.BitReflect(result, HashSizeValue);
            }
            result ^= FinalXorValue;
            result = (global::System.UInt64)(result & bitMask);

            for (var i = 0; i < byteSize; i++)
            {
                if (IsBigEndianResult)
                {
                    destination[i] = (byte)(result >> ((byteSize * 8) - ((i * 8) + 8)));
                }
                else
                {
                    destination[i] = (byte)(result >> (i * 8));
                }
            }
            bytesWritten = byteSize;
            return true;
        }



        protected static void LookupTableFill(Span<global::System.UInt64> table, in int bitWidth, global::System.UInt64 polynomial)
        {
            for (int i = 0; i < LookupTableSize; i++)
            {
                byte dividend = (byte)(i & byte.MaxValue);
                table[i] = PolynomialDivRem(dividend, bitWidth, polynomial);
            }
        }



        private static void Calculate(ref global::System.UInt64 crc, in ReadOnlySpan<byte> bytes, in int bitWidth, in global::System.UInt64 polynomial, in bool reflectInput)
        {
            const int InputBits = sizeof(byte) * 8;
            for (var i = 0; i < bytes.Length; i++)
            {
                var input = reflectInput ? CRCUtility.BitReflect(bytes[i]) : bytes[i];

                // crc と input を、元々一つの連続したデータとして計算したときと同じ結果になるようにマージします。
                byte dividend;
                if (bitWidth < 8)
                {
                    // input: aaaa bbbb (8ビット)
                    // crc  : 0aaa bbbb (7ビット以下)
                    // crc  : aaab bbb0 (ビット全体を左詰めする)
                    var leftJustified = (crc << (InputBits - bitWidth)) & byte.MaxValue;
                    // aaaa bbbb ^ aaab bbb0 (XOR!)
                    dividend = (byte)(leftJustified ^ input);
                }
                else
                {
                    // input:               aaaa bbbb (8ビット)
                    // crc  : aaaa bbbb ... yyyy zzzz (8ビット以上)
                    // crc  : aaaa bbbb (先頭 8 ビットを抽出)
                    var top8 = (crc >> (bitWidth - InputBits)) & byte.MaxValue;
                    // aaaa bbbb ^ aaaa bbbb (XOR!)
                    dividend = (byte)(top8 ^ input);
                }

                // 先頭 8 ビットを除去するように左へビットシフトし、PolynomialDivRem で得られた剰余と XOR 演算します。
                // この値が現在の input までの CRC となります。これをデータの長さ分繰り返します。
                // crc      : aaaa bbbb cccc ... xxxx yyyy zzzz
                // crc      : cccc dddd eeee ... zzzz 0000 0000 ( << 8 )
                // remainder: aaaa bbbb cccc ... xxxx yyyy zzzz (剰余。長さは crc と同じ)
                global::System.UInt64 remainder = PolynomialDivRem(dividend, bitWidth, polynomial);
                // cccc dddd eeee ... zzzz 0000 0000 ^ aaaa bbbb cccc ... xxxx yyyy zzzz (XOR!)
                crc = (global::System.UInt64)((crc << InputBits) ^ remainder);
            }
        }

        private static void Calculate(ref global::System.UInt64 crc, in ReadOnlySpan<byte> bytes, in int bitWidth, in ReadOnlySpan<global::System.UInt64> table, in bool reflectInput)
        {
            const int InputBits = sizeof(byte) * 8;
            for (var i = 0; i < bytes.Length; i++)
            {
                var input = reflectInput ? CRCUtility.BitReflect(bytes[i]) : bytes[i];

                // crc と input を、元々一つの連続したデータとして計算したときと同じ結果になるようにマージします。
                byte dividend;
                if (bitWidth < 8)
                {
                    // input: aaaa bbbb (8ビット)
                    // crc  : 0aaa bbbb (7ビット以下)
                    // crc  : aaab bbb0 (ビット全体を左詰めする)
                    var leftJustified = (crc << (InputBits - bitWidth)) & byte.MaxValue;
                    // aaaa bbbb ^ aaab bbb0 (XOR!)
                    dividend = (byte)(leftJustified ^ input);
                }
                else
                {
                    // input:               aaaa bbbb (8ビット)
                    // crc  : aaaa bbbb ... yyyy zzzz (8ビット以上)
                    // crc  : aaaa bbbb (先頭 8 ビットを抽出)
                    var top8 = (crc >> (bitWidth - InputBits)) & byte.MaxValue;
                    // aaaa bbbb ^ aaaa bbbb (XOR!)
                    dividend = (byte)(top8 ^ input);
                }

                // 先頭 8 ビットを除去するように左へビットシフトし、PolynomialDivRem で得られた剰余と XOR 演算します。
                // この値が現在の input までの CRC となります。これをデータの長さ分繰り返します。
                // crc      : aaaa bbbb cccc ... xxxx yyyy zzzz
                // crc      : cccc dddd eeee ... zzzz 0000 0000 ( << 8 )
                // remainder: aaaa bbbb cccc ... xxxx yyyy zzzz (剰余。長さは crc と同じ)
                global::System.UInt64 remainder = table[dividend];
                // cccc dddd eeee ... zzzz 0000 0000 ^ aaaa bbbb cccc ... xxxx yyyy zzzz (XOR!)
                crc = (global::System.UInt64)((crc << InputBits) ^ remainder);
            }
        }



        private static global::System.UInt64 PolynomialDivRem(in byte dividend, in int bitWidth, global::System.UInt64 polynomial)
        {
            const int InputBits = sizeof(byte) * 8; // dividend のサイズ。

            if (bitWidth < 8)
            {
                // remainder: aaaa bbbb
                global::System.UInt64 remainder = (global::System.UInt64)dividend;
                // polynomial の先頭ビット (bitWidth の位置) が、remainder の先頭ビット (8) に合うようにシフト演算します。
                // polynomial: 0aaa bbbb (7ビット以下)
                // polynomial: aaab bbb0
                polynomial = (global::System.UInt64)(polynomial << (InputBits - bitWidth));

                // remainder の先頭ビットが 0 の場合は remainder を 1 だけ左シフト、
                // 1 の場合は remainder を 1 だけ左シフトした後に polynomial と XOR 演算します。
                // これを dividend のビット長分だけ繰り返して剰余を計算します。
                // dividend: aaaa bbbb
                //           ^ (ここを見る)
                const int LoopCount = InputBits;
                for (int i = 0; i < LoopCount; i++)
                {
                    global::System.UInt64 TopBit = (global::System.UInt64)(0x80);
                    if ((remainder & TopBit) == 0)
                    {
                        remainder <<= 1;
                    }
                    else
                    {
                        remainder <<= 1;
                        remainder ^= polynomial;
                    }
                }

                // 最初に polynomial をシフトした影響で、remainder の値が左に寄った感じになっています。
                // remainder: aaab bbb0
                // なので、polynomial のシフトと逆方向に同じ分だけシフトし直して、正しい位置に戻します。
                // remainder: 0aaa bbbb
                return (global::System.UInt64)(remainder >> (InputBits - bitWidth));
            }
            else
            {
                // dividend の先頭ビット位置を polynomial の先頭ビット (bitWidth の位置) に合わせます。
                // polynomial: 00aa bbbb cccc ... yyyy zzzz
                // dividend  :                    aaaa bbbb
                // dividend  :   aa aabb bb00 ... 0000 0000
                global::System.UInt64 remainder = (global::System.UInt64)((global::System.UInt64)dividend << (bitWidth - InputBits));

                // remainder の先頭ビットが 0 の場合は remainder を 1 だけ左シフト、
                // 1 の場合は remainder を 1 だけ左シフトした後に polynomial と XOR 演算します。
                // これを dividend のビット長分だけ繰り返して剰余を計算します。
                // dividend: aaaa bbbb
                //           ^ (ここを見る)
                const int LoopCount = InputBits;
                for (int i = 0; i < LoopCount; i++)
                {
                    global::System.UInt64 TopBit = (global::System.UInt64)((global::System.UInt64)1U << (bitWidth - 1));

                    if ((remainder & TopBit) == 0)
                    {
                        remainder <<= 1;
                    }
                    else
                    {
                        remainder <<= 1;
                        remainder ^= polynomial;
                    }
                }

                return remainder;
            }
        }



        #region IDisposable

        private bool disposedValue = false;

        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (lookupTableBuffer != null)
                    {
                        System.Buffers.ArrayPool<global::System.UInt64>.Shared.Return(lookupTableBuffer);
                    }
                }
                disposedValue = true;
            }
            base.Dispose(disposing);
        }

        #endregion
    }

    /// <summary>
    /// 任意のビットサイズの CRC 値を計算する機能を提供します。
    /// </summary>
    public class CRCBigInteger : CRC
    {
        private global::System.Numerics.BigInteger result;
        private global::System.Numerics.BigInteger[] lookupTableBuffer;

        private readonly global::System.Numerics.BigInteger bitMask;
        private readonly int byteSize;

        public global::System.Numerics.BigInteger Polynomial { get; }
        public global::System.Numerics.BigInteger InitialValue { get; }
        public global::System.Numerics.BigInteger FinalXorValue { get; }
        public bool ReflectInput { get; }
        public bool ReflectOutput { get; }
        public bool IsLookupTable { get; set; }
        public bool IsBigEndianResult { get; set; }

        public virtual ReadOnlySpan<global::System.Numerics.BigInteger> LookupTable
        {
            get
            {
                if (lookupTableBuffer == null)
                {
                    lookupTableBuffer = System.Buffers.ArrayPool<global::System.Numerics.BigInteger>.Shared.Rent(LookupTableSize);
                    LookupTableFill(lookupTableBuffer, HashSizeValue, Polynomial);
                }
                return lookupTableBuffer.AsSpan(0, LookupTableSize);
            } 
        }



        public CRCBigInteger(int bitWidth, global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isLookupTable = true, bool isBigEndianResult = false)
        {

            this.HashSizeValue = bitWidth;
            this.Polynomial = polynomial;
            this.InitialValue = initialValue;
            this.FinalXorValue = finalXorValue;
            this.ReflectInput = reflectInput;
            this.ReflectOutput = reflectOutput;
            this.IsLookupTable = isLookupTable;
            this.IsBigEndianResult = isBigEndianResult;

            this.result = initialValue;
            this.bitMask = (global::System.Numerics.BigInteger)(((global::System.Numerics.BigInteger)1U << bitWidth) - 1);
            this.byteSize = (HashSizeValue / 8) + (HashSizeValue % 8 == 0 ? 0 : 1);
        }



        public override void Initialize()
        {
            result = InitialValue;
        }



        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            HashCore(array.AsSpan(ibStart, cbSize));
        }

        protected override void HashCore(ReadOnlySpan<byte> source)
        {
            if (IsLookupTable)
            {
                Calculate(ref result, source, HashSizeValue, LookupTable, ReflectInput);
            }
            else
            {
                Calculate(ref result, source, HashSizeValue, Polynomial, ReflectInput);
            }
        }



        protected override byte[] HashFinal()
        {
            Span<byte> span = stackalloc byte[byteSize];
            TryHashFinal(span, out _);
            return span.ToArray();
        }

        protected override bool TryHashFinal(Span<byte> destination, out int bytesWritten)
        {
            if (destination.Length < byteSize)
            {
                bytesWritten = 0;
                return false;
            }
           
            if (ReflectOutput)
            {
                result = CRCUtility.BitReflect(result, HashSizeValue);
            }
            result ^= FinalXorValue;
            result = (global::System.Numerics.BigInteger)(result & bitMask);

            return result.TryWriteBytes(destination, out bytesWritten, true, IsBigEndianResult);
        }



        protected static void LookupTableFill(Span<global::System.Numerics.BigInteger> table, in int bitWidth, global::System.Numerics.BigInteger polynomial)
        {
            for (int i = 0; i < LookupTableSize; i++)
            {
                byte dividend = (byte)(i & byte.MaxValue);
                table[i] = PolynomialDivRem(dividend, bitWidth, polynomial);
            }
        }



        private static void Calculate(ref global::System.Numerics.BigInteger crc, in ReadOnlySpan<byte> bytes, in int bitWidth, in global::System.Numerics.BigInteger polynomial, in bool reflectInput)
        {
            const int InputBits = sizeof(byte) * 8;
            for (var i = 0; i < bytes.Length; i++)
            {
                var input = reflectInput ? CRCUtility.BitReflect(bytes[i]) : bytes[i];

                // crc と input を、元々一つの連続したデータとして計算したときと同じ結果になるようにマージします。
                byte dividend;
                if (bitWidth < 8)
                {
                    // input: aaaa bbbb (8ビット)
                    // crc  : 0aaa bbbb (7ビット以下)
                    // crc  : aaab bbb0 (ビット全体を左詰めする)
                    var leftJustified = (crc << (InputBits - bitWidth)) & byte.MaxValue;
                    // aaaa bbbb ^ aaab bbb0 (XOR!)
                    dividend = (byte)(leftJustified ^ input);
                }
                else
                {
                    // input:               aaaa bbbb (8ビット)
                    // crc  : aaaa bbbb ... yyyy zzzz (8ビット以上)
                    // crc  : aaaa bbbb (先頭 8 ビットを抽出)
                    var top8 = (crc >> (bitWidth - InputBits)) & byte.MaxValue;
                    // aaaa bbbb ^ aaaa bbbb (XOR!)
                    dividend = (byte)(top8 ^ input);
                }

                // 先頭 8 ビットを除去するように左へビットシフトし、PolynomialDivRem で得られた剰余と XOR 演算します。
                // この値が現在の input までの CRC となります。これをデータの長さ分繰り返します。
                // crc      : aaaa bbbb cccc ... xxxx yyyy zzzz
                // crc      : cccc dddd eeee ... zzzz 0000 0000 ( << 8 )
                // remainder: aaaa bbbb cccc ... xxxx yyyy zzzz (剰余。長さは crc と同じ)
                global::System.Numerics.BigInteger remainder = PolynomialDivRem(dividend, bitWidth, polynomial);
                // cccc dddd eeee ... zzzz 0000 0000 ^ aaaa bbbb cccc ... xxxx yyyy zzzz (XOR!)
                crc = (global::System.Numerics.BigInteger)((crc << InputBits) ^ remainder);
            }
        }

        private static void Calculate(ref global::System.Numerics.BigInteger crc, in ReadOnlySpan<byte> bytes, in int bitWidth, in ReadOnlySpan<global::System.Numerics.BigInteger> table, in bool reflectInput)
        {
            const int InputBits = sizeof(byte) * 8;
            for (var i = 0; i < bytes.Length; i++)
            {
                var input = reflectInput ? CRCUtility.BitReflect(bytes[i]) : bytes[i];

                // crc と input を、元々一つの連続したデータとして計算したときと同じ結果になるようにマージします。
                byte dividend;
                if (bitWidth < 8)
                {
                    // input: aaaa bbbb (8ビット)
                    // crc  : 0aaa bbbb (7ビット以下)
                    // crc  : aaab bbb0 (ビット全体を左詰めする)
                    var leftJustified = (crc << (InputBits - bitWidth)) & byte.MaxValue;
                    // aaaa bbbb ^ aaab bbb0 (XOR!)
                    dividend = (byte)(leftJustified ^ input);
                }
                else
                {
                    // input:               aaaa bbbb (8ビット)
                    // crc  : aaaa bbbb ... yyyy zzzz (8ビット以上)
                    // crc  : aaaa bbbb (先頭 8 ビットを抽出)
                    var top8 = (crc >> (bitWidth - InputBits)) & byte.MaxValue;
                    // aaaa bbbb ^ aaaa bbbb (XOR!)
                    dividend = (byte)(top8 ^ input);
                }

                // 先頭 8 ビットを除去するように左へビットシフトし、PolynomialDivRem で得られた剰余と XOR 演算します。
                // この値が現在の input までの CRC となります。これをデータの長さ分繰り返します。
                // crc      : aaaa bbbb cccc ... xxxx yyyy zzzz
                // crc      : cccc dddd eeee ... zzzz 0000 0000 ( << 8 )
                // remainder: aaaa bbbb cccc ... xxxx yyyy zzzz (剰余。長さは crc と同じ)
                global::System.Numerics.BigInteger remainder = table[dividend];
                // cccc dddd eeee ... zzzz 0000 0000 ^ aaaa bbbb cccc ... xxxx yyyy zzzz (XOR!)
                crc = (global::System.Numerics.BigInteger)((crc << InputBits) ^ remainder);
            }
        }



        private static global::System.Numerics.BigInteger PolynomialDivRem(in byte dividend, in int bitWidth, global::System.Numerics.BigInteger polynomial)
        {
            const int InputBits = sizeof(byte) * 8; // dividend のサイズ。

            if (bitWidth < 8)
            {
                // remainder: aaaa bbbb
                global::System.Numerics.BigInteger remainder = (global::System.Numerics.BigInteger)dividend;
                // polynomial の先頭ビット (bitWidth の位置) が、remainder の先頭ビット (8) に合うようにシフト演算します。
                // polynomial: 0aaa bbbb (7ビット以下)
                // polynomial: aaab bbb0
                polynomial = (global::System.Numerics.BigInteger)(polynomial << (InputBits - bitWidth));

                // remainder の先頭ビットが 0 の場合は remainder を 1 だけ左シフト、
                // 1 の場合は remainder を 1 だけ左シフトした後に polynomial と XOR 演算します。
                // これを dividend のビット長分だけ繰り返して剰余を計算します。
                // dividend: aaaa bbbb
                //           ^ (ここを見る)
                const int LoopCount = InputBits;
                for (int i = 0; i < LoopCount; i++)
                {
                    global::System.Numerics.BigInteger TopBit = (global::System.Numerics.BigInteger)(0x80);
                    if ((remainder & TopBit) == 0)
                    {
                        remainder <<= 1;
                    }
                    else
                    {
                        remainder <<= 1;
                        remainder ^= polynomial;
                    }
                }

                // 最初に polynomial をシフトした影響で、remainder の値が左に寄った感じになっています。
                // remainder: aaab bbb0
                // なので、polynomial のシフトと逆方向に同じ分だけシフトし直して、正しい位置に戻します。
                // remainder: 0aaa bbbb
                return (global::System.Numerics.BigInteger)(remainder >> (InputBits - bitWidth));
            }
            else
            {
                // dividend の先頭ビット位置を polynomial の先頭ビット (bitWidth の位置) に合わせます。
                // polynomial: 00aa bbbb cccc ... yyyy zzzz
                // dividend  :                    aaaa bbbb
                // dividend  :   aa aabb bb00 ... 0000 0000
                global::System.Numerics.BigInteger remainder = (global::System.Numerics.BigInteger)((global::System.Numerics.BigInteger)dividend << (bitWidth - InputBits));

                // remainder の先頭ビットが 0 の場合は remainder を 1 だけ左シフト、
                // 1 の場合は remainder を 1 だけ左シフトした後に polynomial と XOR 演算します。
                // これを dividend のビット長分だけ繰り返して剰余を計算します。
                // dividend: aaaa bbbb
                //           ^ (ここを見る)
                const int LoopCount = InputBits;
                for (int i = 0; i < LoopCount; i++)
                {
                    global::System.Numerics.BigInteger TopBit = (global::System.Numerics.BigInteger)((global::System.Numerics.BigInteger)1U << (bitWidth - 1));

                    if ((remainder & TopBit) == 0)
                    {
                        remainder <<= 1;
                    }
                    else
                    {
                        remainder <<= 1;
                        remainder ^= polynomial;
                    }
                }

                return remainder;
            }
        }



        #region IDisposable

        private bool disposedValue = false;

        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (lookupTableBuffer != null)
                    {
                        System.Buffers.ArrayPool<global::System.Numerics.BigInteger>.Shared.Return(lookupTableBuffer);
                    }
                }
                disposedValue = true;
            }
            base.Dispose(disposing);
        }

        #endregion
    }

}
