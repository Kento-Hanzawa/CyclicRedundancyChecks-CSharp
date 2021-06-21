 
//
// CyclicRedundancyChecks
// 
// このコードはテキストテンプレートファイル (.tt) によって作成されています。
// 変更をおこなう場合は、テキストテンプレートファイル (.tt) を編集してください。
//

using System;

namespace CyclicRedundancyChecks.Underlying
{
    /// <summary>
    /// 最大 8 ビットサイズまでの CRC 値を計算する機能を提供します。
    /// </summary>
    public class CRCUInt8 : CRC
    {
        private global::System.Byte result;
        private readonly global::System.Byte bitMask;
        private readonly int byteSize;
        private readonly global::System.Byte[] lookupTableBuffer;

        public global::System.Byte Polynomial { get; }
        public global::System.Byte InitialValue { get; }
        public global::System.Byte FinalXorValue { get; }
        public bool ReflectInput { get; }
        public bool ReflectOutput { get; }
        public bool IsBigEndianResult { get; set; }

        public ReadOnlySpan<global::System.Byte> LookupTable { get { return lookupTableBuffer.AsSpan(0, LookupTableSize); } }

        public CRCUInt8(int bitWidth, global::System.Byte polynomial, global::System.Byte initialValue, global::System.Byte finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
        {
            const int MaxBitWidth = sizeof(global::System.Byte) * 8;
            if (MaxBitWidth < bitWidth)
            {
                bitWidth = MaxBitWidth;
            }

            this.HashSizeValue = bitWidth;

            this.result = initialValue;
            this.bitMask = (bitWidth == MaxBitWidth) ? (global::System.Byte)0xFF : (global::System.Byte)(((global::System.Byte)1 << bitWidth) - 1);
            this.byteSize = sizeof(global::System.Byte);
            this.lookupTableBuffer = System.Buffers.ArrayPool<global::System.Byte>.Shared.Rent(LookupTableSize);

            this.Polynomial = polynomial;
            this.InitialValue = initialValue;
            this.FinalXorValue = finalXorValue;
            this.ReflectInput = reflectInput;
            this.ReflectOutput = reflectOutput;
            this.IsBigEndianResult = isBigEndianResult;

            LookupTableFill();
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
            for (var i = 0; i < source.Length; i++)
            {
                if (ReflectInput)
                {
                    var tableIndex = (int)((result ^ source[i]) & 0xFF);
                    result = (global::System.Byte)((result >> 8) ^ LookupTable[tableIndex]);
                }
                else
                {
                    var tableIndex = (int)(((result >> (HashSizeValue - 8)) ^ source[i]) & 0xFF);
                    result = (global::System.Byte)((result << 8) ^ LookupTable[tableIndex]);
                }
                result &= bitMask;
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
           
            result = (global::System.Byte)(result & bitMask);
            if (ReflectInput)
            {
                result = CRCUtility.BitReflect(result, HashSizeValue);
            }
            if (ReflectOutput)
            {
                result = CRCUtility.BitReflect(result, HashSizeValue);
            }
            result ^= FinalXorValue;

            for (var i = 0; i < byteSize; i++)
            {
                if (IsBigEndianResult)
                {
                    destination[i] = (byte)(result >> (HashSizeValue - ((i * 8) + 8)));
                }
                else
                {
                    destination[i] = (byte)(result >> (i * 8));
                }
            }
            bytesWritten = byteSize;
            return true;
        }

        private void LookupTableFill()
        {
            var polynomial = ReflectInput ? CRCUtility.BitReflect(Polynomial, HashSizeValue) : Polynomial;

            for (int i = 0; i < LookupTableSize; i++)
            {
                lookupTableBuffer[i] = Obtener((byte)(i & 0xFF));
            }

            global::System.Byte Obtener(byte position)
            {
                global::System.Byte result;
                if (ReflectInput)
                {
                    result = (global::System.Byte)position;
                    for (var i = 0; i < 8; i++)
                    {
                        if ((result & 1) == 0)
                            result = (global::System.Byte)(result >> 1);
                        else
                            result = (global::System.Byte)((result >> 1) ^ polynomial);
                        result &= bitMask;
                    }
                }
                else
                {
                    global::System.Byte TopBit = (global::System.Byte)((global::System.Byte)1 << (HashSizeValue - 1));
                    result = (global::System.Byte)((global::System.Byte)position << (HashSizeValue - 8));
                    for (var i = 0; i < 8; i++)
                    {
                        if ((result & TopBit) == 0)
                        {
                            result = (global::System.Byte)(result << 1);
                        }
                        else
                        {
                            result = (global::System.Byte)((result << 1) ^ polynomial);
                        }
                        result &= bitMask;
                    }
                }
                return result;
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
        private readonly global::System.UInt16 bitMask;
        private readonly int byteSize;
        private readonly global::System.UInt16[] lookupTableBuffer;

        public global::System.UInt16 Polynomial { get; }
        public global::System.UInt16 InitialValue { get; }
        public global::System.UInt16 FinalXorValue { get; }
        public bool ReflectInput { get; }
        public bool ReflectOutput { get; }
        public bool IsBigEndianResult { get; set; }

        public ReadOnlySpan<global::System.UInt16> LookupTable { get { return lookupTableBuffer.AsSpan(0, LookupTableSize); } }

        public CRCUInt16(int bitWidth, global::System.UInt16 polynomial, global::System.UInt16 initialValue, global::System.UInt16 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
        {
            const int MaxBitWidth = sizeof(global::System.UInt16) * 8;
            if (MaxBitWidth < bitWidth)
            {
                bitWidth = MaxBitWidth;
            }

            this.HashSizeValue = bitWidth;

            this.result = initialValue;
            this.bitMask = (bitWidth == MaxBitWidth) ? (global::System.UInt16)0xFFFF : (global::System.UInt16)(((global::System.UInt16)1 << bitWidth) - 1);
            this.byteSize = sizeof(global::System.UInt16);
            this.lookupTableBuffer = System.Buffers.ArrayPool<global::System.UInt16>.Shared.Rent(LookupTableSize);

            this.Polynomial = polynomial;
            this.InitialValue = initialValue;
            this.FinalXorValue = finalXorValue;
            this.ReflectInput = reflectInput;
            this.ReflectOutput = reflectOutput;
            this.IsBigEndianResult = isBigEndianResult;

            LookupTableFill();
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
            for (var i = 0; i < source.Length; i++)
            {
                if (ReflectInput)
                {
                    var tableIndex = (int)((result ^ source[i]) & 0xFF);
                    result = (global::System.UInt16)((result >> 8) ^ LookupTable[tableIndex]);
                }
                else
                {
                    var tableIndex = (int)(((result >> (HashSizeValue - 8)) ^ source[i]) & 0xFF);
                    result = (global::System.UInt16)((result << 8) ^ LookupTable[tableIndex]);
                }
                result &= bitMask;
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
           
            result = (global::System.UInt16)(result & bitMask);
            if (ReflectInput)
            {
                result = CRCUtility.BitReflect(result, HashSizeValue);
            }
            if (ReflectOutput)
            {
                result = CRCUtility.BitReflect(result, HashSizeValue);
            }
            result ^= FinalXorValue;

            for (var i = 0; i < byteSize; i++)
            {
                if (IsBigEndianResult)
                {
                    destination[i] = (byte)(result >> (HashSizeValue - ((i * 8) + 8)));
                }
                else
                {
                    destination[i] = (byte)(result >> (i * 8));
                }
            }
            bytesWritten = byteSize;
            return true;
        }

        private void LookupTableFill()
        {
            var polynomial = ReflectInput ? CRCUtility.BitReflect(Polynomial, HashSizeValue) : Polynomial;

            for (int i = 0; i < LookupTableSize; i++)
            {
                lookupTableBuffer[i] = Obtener((byte)(i & 0xFF));
            }

            global::System.UInt16 Obtener(byte position)
            {
                global::System.UInt16 result;
                if (ReflectInput)
                {
                    result = (global::System.UInt16)position;
                    for (var i = 0; i < 8; i++)
                    {
                        if ((result & 1) == 0)
                            result = (global::System.UInt16)(result >> 1);
                        else
                            result = (global::System.UInt16)((result >> 1) ^ polynomial);
                        result &= bitMask;
                    }
                }
                else
                {
                    global::System.UInt16 TopBit = (global::System.UInt16)((global::System.UInt16)1 << (HashSizeValue - 1));
                    result = (global::System.UInt16)((global::System.UInt16)position << (HashSizeValue - 8));
                    for (var i = 0; i < 8; i++)
                    {
                        if ((result & TopBit) == 0)
                        {
                            result = (global::System.UInt16)(result << 1);
                        }
                        else
                        {
                            result = (global::System.UInt16)((result << 1) ^ polynomial);
                        }
                        result &= bitMask;
                    }
                }
                return result;
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
        private readonly global::System.UInt32 bitMask;
        private readonly int byteSize;
        private readonly global::System.UInt32[] lookupTableBuffer;

        public global::System.UInt32 Polynomial { get; }
        public global::System.UInt32 InitialValue { get; }
        public global::System.UInt32 FinalXorValue { get; }
        public bool ReflectInput { get; }
        public bool ReflectOutput { get; }
        public bool IsBigEndianResult { get; set; }

        public ReadOnlySpan<global::System.UInt32> LookupTable { get { return lookupTableBuffer.AsSpan(0, LookupTableSize); } }

        public CRCUInt32(int bitWidth, global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
        {
            const int MaxBitWidth = sizeof(global::System.UInt32) * 8;
            if (MaxBitWidth < bitWidth)
            {
                bitWidth = MaxBitWidth;
            }

            this.HashSizeValue = bitWidth;

            this.result = initialValue;
            this.bitMask = (bitWidth == MaxBitWidth) ? (global::System.UInt32)0xFFFFFFFF : (global::System.UInt32)(((global::System.UInt32)1 << bitWidth) - 1);
            this.byteSize = sizeof(global::System.UInt32);
            this.lookupTableBuffer = System.Buffers.ArrayPool<global::System.UInt32>.Shared.Rent(LookupTableSize);

            this.Polynomial = polynomial;
            this.InitialValue = initialValue;
            this.FinalXorValue = finalXorValue;
            this.ReflectInput = reflectInput;
            this.ReflectOutput = reflectOutput;
            this.IsBigEndianResult = isBigEndianResult;

            LookupTableFill();
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
            for (var i = 0; i < source.Length; i++)
            {
                if (ReflectInput)
                {
                    var tableIndex = (int)((result ^ source[i]) & 0xFF);
                    result = (global::System.UInt32)((result >> 8) ^ LookupTable[tableIndex]);
                }
                else
                {
                    var tableIndex = (int)(((result >> (HashSizeValue - 8)) ^ source[i]) & 0xFF);
                    result = (global::System.UInt32)((result << 8) ^ LookupTable[tableIndex]);
                }
                result &= bitMask;
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
           
            result = (global::System.UInt32)(result & bitMask);
            if (ReflectInput)
            {
                result = CRCUtility.BitReflect(result, HashSizeValue);
            }
            if (ReflectOutput)
            {
                result = CRCUtility.BitReflect(result, HashSizeValue);
            }
            result ^= FinalXorValue;

            for (var i = 0; i < byteSize; i++)
            {
                if (IsBigEndianResult)
                {
                    destination[i] = (byte)(result >> (HashSizeValue - ((i * 8) + 8)));
                }
                else
                {
                    destination[i] = (byte)(result >> (i * 8));
                }
            }
            bytesWritten = byteSize;
            return true;
        }

        private void LookupTableFill()
        {
            var polynomial = ReflectInput ? CRCUtility.BitReflect(Polynomial, HashSizeValue) : Polynomial;

            for (int i = 0; i < LookupTableSize; i++)
            {
                lookupTableBuffer[i] = Obtener((byte)(i & 0xFF));
            }

            global::System.UInt32 Obtener(byte position)
            {
                global::System.UInt32 result;
                if (ReflectInput)
                {
                    result = (global::System.UInt32)position;
                    for (var i = 0; i < 8; i++)
                    {
                        if ((result & 1) == 0)
                            result = (global::System.UInt32)(result >> 1);
                        else
                            result = (global::System.UInt32)((result >> 1) ^ polynomial);
                        result &= bitMask;
                    }
                }
                else
                {
                    global::System.UInt32 TopBit = (global::System.UInt32)((global::System.UInt32)1 << (HashSizeValue - 1));
                    result = (global::System.UInt32)((global::System.UInt32)position << (HashSizeValue - 8));
                    for (var i = 0; i < 8; i++)
                    {
                        if ((result & TopBit) == 0)
                        {
                            result = (global::System.UInt32)(result << 1);
                        }
                        else
                        {
                            result = (global::System.UInt32)((result << 1) ^ polynomial);
                        }
                        result &= bitMask;
                    }
                }
                return result;
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
        private readonly global::System.UInt64 bitMask;
        private readonly int byteSize;
        private readonly global::System.UInt64[] lookupTableBuffer;

        public global::System.UInt64 Polynomial { get; }
        public global::System.UInt64 InitialValue { get; }
        public global::System.UInt64 FinalXorValue { get; }
        public bool ReflectInput { get; }
        public bool ReflectOutput { get; }
        public bool IsBigEndianResult { get; set; }

        public ReadOnlySpan<global::System.UInt64> LookupTable { get { return lookupTableBuffer.AsSpan(0, LookupTableSize); } }

        public CRCUInt64(int bitWidth, global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
        {
            const int MaxBitWidth = sizeof(global::System.UInt64) * 8;
            if (MaxBitWidth < bitWidth)
            {
                bitWidth = MaxBitWidth;
            }

            this.HashSizeValue = bitWidth;

            this.result = initialValue;
            this.bitMask = (bitWidth == MaxBitWidth) ? (global::System.UInt64)0xFFFFFFFFFFFFFFFF : (global::System.UInt64)(((global::System.UInt64)1 << bitWidth) - 1);
            this.byteSize = sizeof(global::System.UInt64);
            this.lookupTableBuffer = System.Buffers.ArrayPool<global::System.UInt64>.Shared.Rent(LookupTableSize);

            this.Polynomial = polynomial;
            this.InitialValue = initialValue;
            this.FinalXorValue = finalXorValue;
            this.ReflectInput = reflectInput;
            this.ReflectOutput = reflectOutput;
            this.IsBigEndianResult = isBigEndianResult;

            LookupTableFill();
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
            for (var i = 0; i < source.Length; i++)
            {
                if (ReflectInput)
                {
                    var tableIndex = (int)((result ^ source[i]) & 0xFF);
                    result = (global::System.UInt64)((result >> 8) ^ LookupTable[tableIndex]);
                }
                else
                {
                    var tableIndex = (int)(((result >> (HashSizeValue - 8)) ^ source[i]) & 0xFF);
                    result = (global::System.UInt64)((result << 8) ^ LookupTable[tableIndex]);
                }
                result &= bitMask;
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
           
            result = (global::System.UInt64)(result & bitMask);
            if (ReflectInput)
            {
                result = CRCUtility.BitReflect(result, HashSizeValue);
            }
            if (ReflectOutput)
            {
                result = CRCUtility.BitReflect(result, HashSizeValue);
            }
            result ^= FinalXorValue;

            for (var i = 0; i < byteSize; i++)
            {
                if (IsBigEndianResult)
                {
                    destination[i] = (byte)(result >> (HashSizeValue - ((i * 8) + 8)));
                }
                else
                {
                    destination[i] = (byte)(result >> (i * 8));
                }
            }
            bytesWritten = byteSize;
            return true;
        }

        private void LookupTableFill()
        {
            var polynomial = ReflectInput ? CRCUtility.BitReflect(Polynomial, HashSizeValue) : Polynomial;

            for (int i = 0; i < LookupTableSize; i++)
            {
                lookupTableBuffer[i] = Obtener((byte)(i & 0xFF));
            }

            global::System.UInt64 Obtener(byte position)
            {
                global::System.UInt64 result;
                if (ReflectInput)
                {
                    result = (global::System.UInt64)position;
                    for (var i = 0; i < 8; i++)
                    {
                        if ((result & 1) == 0)
                            result = (global::System.UInt64)(result >> 1);
                        else
                            result = (global::System.UInt64)((result >> 1) ^ polynomial);
                        result &= bitMask;
                    }
                }
                else
                {
                    global::System.UInt64 TopBit = (global::System.UInt64)((global::System.UInt64)1 << (HashSizeValue - 1));
                    result = (global::System.UInt64)((global::System.UInt64)position << (HashSizeValue - 8));
                    for (var i = 0; i < 8; i++)
                    {
                        if ((result & TopBit) == 0)
                        {
                            result = (global::System.UInt64)(result << 1);
                        }
                        else
                        {
                            result = (global::System.UInt64)((result << 1) ^ polynomial);
                        }
                        result &= bitMask;
                    }
                }
                return result;
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
    /// 64 ビットサイズ以上の CRC 値を計算する機能を提供します。
    /// </summary>
    public class CRCBigInteger : CRC
    {
        private global::System.Numerics.BigInteger result;
        private readonly global::System.Numerics.BigInteger bitMask;
        private readonly int byteSize;
        private readonly global::System.Numerics.BigInteger[] lookupTableBuffer;

        public global::System.Numerics.BigInteger Polynomial { get; }
        public global::System.Numerics.BigInteger InitialValue { get; }
        public global::System.Numerics.BigInteger FinalXorValue { get; }
        public bool ReflectInput { get; }
        public bool ReflectOutput { get; }
        public bool IsBigEndianResult { get; set; }

        public ReadOnlySpan<global::System.Numerics.BigInteger> LookupTable { get { return lookupTableBuffer.AsSpan(0, LookupTableSize); } }

        public CRCBigInteger(int bitWidth, global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
        {
            this.HashSizeValue = bitWidth;

            this.result = initialValue;
            this.bitMask = (global::System.Numerics.BigInteger)(((global::System.Numerics.BigInteger)1 << bitWidth) - 1);
            this.byteSize = (HashSizeValue / 8) + (HashSizeValue % 8 == 0 ? 0 : 1);
            this.lookupTableBuffer = System.Buffers.ArrayPool<global::System.Numerics.BigInteger>.Shared.Rent(LookupTableSize);

            this.Polynomial = polynomial;
            this.InitialValue = initialValue;
            this.FinalXorValue = finalXorValue;
            this.ReflectInput = reflectInput;
            this.ReflectOutput = reflectOutput;
            this.IsBigEndianResult = isBigEndianResult;

            LookupTableFill();
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
            for (var i = 0; i < source.Length; i++)
            {
                if (ReflectInput)
                {
                    var tableIndex = (int)((result ^ source[i]) & 0xFF);
                    result = (global::System.Numerics.BigInteger)((result >> 8) ^ LookupTable[tableIndex]);
                }
                else
                {
                    var tableIndex = (int)(((result >> (HashSizeValue - 8)) ^ source[i]) & 0xFF);
                    result = (global::System.Numerics.BigInteger)((result << 8) ^ LookupTable[tableIndex]);
                }
                result &= bitMask;
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
           
            result = (global::System.Numerics.BigInteger)(result & bitMask);
            if (ReflectInput)
            {
                result = CRCUtility.BitReflect(result, HashSizeValue);
            }
            if (ReflectOutput)
            {
                result = CRCUtility.BitReflect(result, HashSizeValue);
            }
            result ^= FinalXorValue;

            return result.TryWriteBytes(destination, out bytesWritten, true, IsBigEndianResult);
        }

        private void LookupTableFill()
        {
            var polynomial = ReflectInput ? CRCUtility.BitReflect(Polynomial, HashSizeValue) : Polynomial;

            for (int i = 0; i < LookupTableSize; i++)
            {
                lookupTableBuffer[i] = Obtener((byte)(i & 0xFF));
            }

            global::System.Numerics.BigInteger Obtener(byte position)
            {
                global::System.Numerics.BigInteger result;
                if (ReflectInput)
                {
                    result = (global::System.Numerics.BigInteger)position;
                    for (var i = 0; i < 8; i++)
                    {
                        if ((result & 1) == 0)
                            result = (global::System.Numerics.BigInteger)(result >> 1);
                        else
                            result = (global::System.Numerics.BigInteger)((result >> 1) ^ polynomial);
                        result &= bitMask;
                    }
                }
                else
                {
                    global::System.Numerics.BigInteger TopBit = (global::System.Numerics.BigInteger)((global::System.Numerics.BigInteger)1 << (HashSizeValue - 1));
                    result = (global::System.Numerics.BigInteger)((global::System.Numerics.BigInteger)position << (HashSizeValue - 8));
                    for (var i = 0; i < 8; i++)
                    {
                        if ((result & TopBit) == 0)
                        {
                            result = (global::System.Numerics.BigInteger)(result << 1);
                        }
                        else
                        {
                            result = (global::System.Numerics.BigInteger)((result << 1) ^ polynomial);
                        }
                        result &= bitMask;
                    }
                }
                return result;
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
