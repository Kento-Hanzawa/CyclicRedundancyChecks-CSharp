//
// CyclicRedundancyChecks
// 
// このコードはテキストテンプレートファイル (.tt) によって作成されています。
// 変更をおこなう場合は、テキストテンプレートファイル (.tt) を編集してください。
//

using System;

namespace CyclicRedundancyChecks
{
    /// <summary>
    /// CRC (Cyclic Redundancy Check) のすべての実装が継承する必要のある抽象基底クラスを表します。
    /// </summary>
    public abstract partial class CRC : System.Security.Cryptography.HashAlgorithm
    {
        protected const int TableSize = 256;

        public static void RegisterAlgorithm()
        {
            // CRC8
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_STANDARD), "CRC-8");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_CDMA2000), "CRC-8-CDMA2000");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_DARC), "CRC-8-DARC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_DVB_S2), "CRC-8-DVB-S2");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_EBU), "CRC-8-EBU");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_I_CODE), "CRC-8-I-CODE");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_ITU), "CRC-8-ITU");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_MAXIM), "CRC-8-MAXIM");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_ROHC), "CRC-8-ROHC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_WCDMA), "CRC-8-WCDMA");
            // CRC16
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_CCITT_FALSE), "CRC-16-CCITT-FALSE");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_ARC), "CRC-16-ARC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_AUG_CCITT), "CRC-16-AUG-CCITT");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_BUYPASS), "CRC-16-BUYPASS");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_CDMA2000), "CRC-16-CDMA2000");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_DDS_110), "CRC-16-DDS-110");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_DECT_R), "CRC-16-DECT-R");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_DECT_X), "CRC-16-DECT-X");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_DNP), "CRC-16-DNP");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_EN_13757), "CRC-16-EN-13757");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_GENIBUS), "CRC-16-GENIBUS");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_MAXIM), "CRC-16-MAXIM");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_MCRF4XX), "CRC-16-MCRF4XX");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_RIELLO), "CRC-16-RIELLO");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_T10_DIF), "CRC-16-T10-DIF");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_TELEDISK), "CRC-16-TELEDISK");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_TMS37157), "CRC-16-TMS37157");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_USB), "CRC-16-USB");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_A), "CRC-16-A");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_KERMIT), "CRC-16-KERMIT");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_MODBUS), "CRC-16-MODBUS");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_X_25), "CRC-16-X-25");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_XMODEM), "CRC-16-XMODEM");
            // CRC32
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_STANDARD), "CRC-32");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_BZIP2), "CRC-32-BZIP2");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_C), "CRC-32-C");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_D), "CRC-32-D");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_MPEG_2), "CRC-32-MPEG-2");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_POSIX), "CRC-32-POSIX");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_Q), "CRC-32-Q");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_JAMCRC), "CRC-32-JAMCRC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_XFER), "CRC-32-XFER");
            // CRC64
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC64_ECMA_182), "CRC-64-ECMA-182");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC64_GO_ISO), "CRC-64-GO-ISO");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC64_WE), "CRC-64-WE");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC64_XZ), "CRC-64-XZ");
        }
    }

    /// <summary>
    /// 入力データの <see cref="CyclicRedundancyChecks.CRC8"/> ハッシュを計算します。
    /// </summary>
    public class CRC8 : CRC
    {
        private const int ByteSize = sizeof(global::System.Byte);
        private const int BitSize = ByteSize * 8;

        public global::System.Byte result;
        private readonly global::System.Byte[] lookupTableBuffer;

        public global::System.Byte Polynomial { get; }
        public global::System.Byte InitialValue { get; }
        public global::System.Byte FinalXorValue { get; }
        public bool ReversedData { get; }
        public bool ReversedOut { get; }
        public ReadOnlySpan<global::System.Byte> LookupTable { get { return lookupTableBuffer.AsSpan(0, TableSize); } }

        public CRC8(global::System.Byte polynomial, global::System.Byte initialValue, global::System.Byte finalXorValue, bool reversedData, bool reversedOut)
        {
            this.HashSizeValue = BitSize;

            this.result = initialValue;
            this.lookupTableBuffer = System.Buffers.ArrayPool<global::System.Byte>.Shared.Rent(TableSize);
            this.Polynomial = polynomial;
            this.InitialValue = initialValue;
            this.FinalXorValue = finalXorValue;
            this.ReversedData = reversedData;
            this.ReversedOut = reversedOut;

            CRCUtility.TableFill(lookupTableBuffer.AsSpan(0, TableSize), Polynomial, reversedData);
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
                if (ReversedData)
                {
                    var tableIndex = (int)((result ^ source[i]) & 0xFF);
                    result = (global::System.Byte)((result >> 8) ^ LookupTable[tableIndex]);
                }
                else
                {
                    var tableIndex = (int)(((result >> (BitSize - 8)) ^ source[i]) & 0xFF);
                    result = (global::System.Byte)((result << 8) ^ LookupTable[tableIndex]);
                }
            }
        }

        protected override byte[] HashFinal()
        {
            Span<byte> span = stackalloc byte[ByteSize];
            TryHashFinal(span, out _);
            return span.ToArray();
        }

        protected override bool TryHashFinal(Span<byte> destination, out int bytesWritten)
        {
            if (destination.Length < ByteSize)
            {
                bytesWritten = 0;
                return false;
            }

            // 参考にしたコードでこういった記述があるが、
            // この条件が true になることはなさそうです。
            if ((sizeof(global::System.Byte) * 8) > BitSize)
            {
                result = (global::System.Byte)(result & ((global::System.Byte)1 << BitSize) - 1);
            }

            if (ReversedData)
                result = CRCUtility.BitReverse(result);
            if (ReversedOut)
                result = CRCUtility.BitReverse(result);
            result ^= FinalXorValue;

            destination[0] = (byte)(result >> 0);
            bytesWritten = ByteSize;
            return true;
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
                        System.Buffers.ArrayPool<global::System.Byte>.Shared.Return(lookupTableBuffer);
                }
                disposedValue = true;
            }
            base.Dispose(disposing);
        }
        #endregion
    }

    /// <summary>
    /// 入力データの <see cref="CyclicRedundancyChecks.CRC16"/> ハッシュを計算します。
    /// </summary>
    public class CRC16 : CRC
    {
        private const int ByteSize = sizeof(global::System.UInt16);
        private const int BitSize = ByteSize * 8;

        public global::System.UInt16 result;
        private readonly global::System.UInt16[] lookupTableBuffer;

        public global::System.UInt16 Polynomial { get; }
        public global::System.UInt16 InitialValue { get; }
        public global::System.UInt16 FinalXorValue { get; }
        public bool ReversedData { get; }
        public bool ReversedOut { get; }
        public ReadOnlySpan<global::System.UInt16> LookupTable { get { return lookupTableBuffer.AsSpan(0, TableSize); } }

        public CRC16(global::System.UInt16 polynomial, global::System.UInt16 initialValue, global::System.UInt16 finalXorValue, bool reversedData, bool reversedOut)
        {
            this.HashSizeValue = BitSize;

            this.result = initialValue;
            this.lookupTableBuffer = System.Buffers.ArrayPool<global::System.UInt16>.Shared.Rent(TableSize);
            this.Polynomial = polynomial;
            this.InitialValue = initialValue;
            this.FinalXorValue = finalXorValue;
            this.ReversedData = reversedData;
            this.ReversedOut = reversedOut;

            CRCUtility.TableFill(lookupTableBuffer.AsSpan(0, TableSize), Polynomial, reversedData);
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
                if (ReversedData)
                {
                    var tableIndex = (int)((result ^ source[i]) & 0xFF);
                    result = (global::System.UInt16)((result >> 8) ^ LookupTable[tableIndex]);
                }
                else
                {
                    var tableIndex = (int)(((result >> (BitSize - 8)) ^ source[i]) & 0xFF);
                    result = (global::System.UInt16)((result << 8) ^ LookupTable[tableIndex]);
                }
            }
        }

        protected override byte[] HashFinal()
        {
            Span<byte> span = stackalloc byte[ByteSize];
            TryHashFinal(span, out _);
            return span.ToArray();
        }

        protected override bool TryHashFinal(Span<byte> destination, out int bytesWritten)
        {
            if (destination.Length < ByteSize)
            {
                bytesWritten = 0;
                return false;
            }

            // 参考にしたコードでこういった記述があるが、
            // この条件が true になることはなさそうです。
            if ((sizeof(global::System.UInt16) * 8) > BitSize)
            {
                result = (global::System.UInt16)(result & ((global::System.UInt16)1 << BitSize) - 1);
            }

            if (ReversedData)
                result = CRCUtility.BitReverse(result);
            if (ReversedOut)
                result = CRCUtility.BitReverse(result);
            result ^= FinalXorValue;

            destination[0] = (byte)(result >> 0);
            destination[1] = (byte)(result >> 8);
            bytesWritten = ByteSize;
            return true;
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
                        System.Buffers.ArrayPool<global::System.UInt16>.Shared.Return(lookupTableBuffer);
                }
                disposedValue = true;
            }
            base.Dispose(disposing);
        }
        #endregion
    }

    /// <summary>
    /// 入力データの <see cref="CyclicRedundancyChecks.CRC32"/> ハッシュを計算します。
    /// </summary>
    public class CRC32 : CRC
    {
        private const int ByteSize = sizeof(global::System.UInt32);
        private const int BitSize = ByteSize * 8;

        public global::System.UInt32 result;
        private readonly global::System.UInt32[] lookupTableBuffer;

        public global::System.UInt32 Polynomial { get; }
        public global::System.UInt32 InitialValue { get; }
        public global::System.UInt32 FinalXorValue { get; }
        public bool ReversedData { get; }
        public bool ReversedOut { get; }
        public ReadOnlySpan<global::System.UInt32> LookupTable { get { return lookupTableBuffer.AsSpan(0, TableSize); } }

        public CRC32(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reversedData, bool reversedOut)
        {
            this.HashSizeValue = BitSize;

            this.result = initialValue;
            this.lookupTableBuffer = System.Buffers.ArrayPool<global::System.UInt32>.Shared.Rent(TableSize);
            this.Polynomial = polynomial;
            this.InitialValue = initialValue;
            this.FinalXorValue = finalXorValue;
            this.ReversedData = reversedData;
            this.ReversedOut = reversedOut;

            CRCUtility.TableFill(lookupTableBuffer.AsSpan(0, TableSize), Polynomial, reversedData);
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
                if (ReversedData)
                {
                    var tableIndex = (int)((result ^ source[i]) & 0xFF);
                    result = (global::System.UInt32)((result >> 8) ^ LookupTable[tableIndex]);
                }
                else
                {
                    var tableIndex = (int)(((result >> (BitSize - 8)) ^ source[i]) & 0xFF);
                    result = (global::System.UInt32)((result << 8) ^ LookupTable[tableIndex]);
                }
            }
        }

        protected override byte[] HashFinal()
        {
            Span<byte> span = stackalloc byte[ByteSize];
            TryHashFinal(span, out _);
            return span.ToArray();
        }

        protected override bool TryHashFinal(Span<byte> destination, out int bytesWritten)
        {
            if (destination.Length < ByteSize)
            {
                bytesWritten = 0;
                return false;
            }

            // 参考にしたコードでこういった記述があるが、
            // この条件が true になることはなさそうです。
            if ((sizeof(global::System.UInt32) * 8) > BitSize)
            {
                result = (global::System.UInt32)(result & ((global::System.UInt32)1 << BitSize) - 1);
            }

            if (ReversedData)
                result = CRCUtility.BitReverse(result);
            if (ReversedOut)
                result = CRCUtility.BitReverse(result);
            result ^= FinalXorValue;

            destination[0] = (byte)(result >> 0);
            destination[1] = (byte)(result >> 8);
            destination[2] = (byte)(result >> 16);
            destination[3] = (byte)(result >> 24);
            bytesWritten = ByteSize;
            return true;
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
                        System.Buffers.ArrayPool<global::System.UInt32>.Shared.Return(lookupTableBuffer);
                }
                disposedValue = true;
            }
            base.Dispose(disposing);
        }
        #endregion
    }

    /// <summary>
    /// 入力データの <see cref="CyclicRedundancyChecks.CRC64"/> ハッシュを計算します。
    /// </summary>
    public class CRC64 : CRC
    {
        private const int ByteSize = sizeof(global::System.UInt64);
        private const int BitSize = ByteSize * 8;

        public global::System.UInt64 result;
        private readonly global::System.UInt64[] lookupTableBuffer;

        public global::System.UInt64 Polynomial { get; }
        public global::System.UInt64 InitialValue { get; }
        public global::System.UInt64 FinalXorValue { get; }
        public bool ReversedData { get; }
        public bool ReversedOut { get; }
        public ReadOnlySpan<global::System.UInt64> LookupTable { get { return lookupTableBuffer.AsSpan(0, TableSize); } }

        public CRC64(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reversedData, bool reversedOut)
        {
            this.HashSizeValue = BitSize;

            this.result = initialValue;
            this.lookupTableBuffer = System.Buffers.ArrayPool<global::System.UInt64>.Shared.Rent(TableSize);
            this.Polynomial = polynomial;
            this.InitialValue = initialValue;
            this.FinalXorValue = finalXorValue;
            this.ReversedData = reversedData;
            this.ReversedOut = reversedOut;

            CRCUtility.TableFill(lookupTableBuffer.AsSpan(0, TableSize), Polynomial, reversedData);
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
                if (ReversedData)
                {
                    var tableIndex = (int)((result ^ source[i]) & 0xFF);
                    result = (global::System.UInt64)((result >> 8) ^ LookupTable[tableIndex]);
                }
                else
                {
                    var tableIndex = (int)(((result >> (BitSize - 8)) ^ source[i]) & 0xFF);
                    result = (global::System.UInt64)((result << 8) ^ LookupTable[tableIndex]);
                }
            }
        }

        protected override byte[] HashFinal()
        {
            Span<byte> span = stackalloc byte[ByteSize];
            TryHashFinal(span, out _);
            return span.ToArray();
        }

        protected override bool TryHashFinal(Span<byte> destination, out int bytesWritten)
        {
            if (destination.Length < ByteSize)
            {
                bytesWritten = 0;
                return false;
            }

            // 参考にしたコードでこういった記述があるが、
            // この条件が true になることはなさそうです。
            if ((sizeof(global::System.UInt64) * 8) > BitSize)
            {
                result = (global::System.UInt64)(result & ((global::System.UInt64)1 << BitSize) - 1);
            }

            if (ReversedData)
                result = CRCUtility.BitReverse(result);
            if (ReversedOut)
                result = CRCUtility.BitReverse(result);
            result ^= FinalXorValue;

            destination[0] = (byte)(result >> 0);
            destination[1] = (byte)(result >> 8);
            destination[2] = (byte)(result >> 16);
            destination[3] = (byte)(result >> 24);
            destination[4] = (byte)(result >> 32);
            destination[5] = (byte)(result >> 40);
            destination[6] = (byte)(result >> 48);
            destination[7] = (byte)(result >> 56);
            bytesWritten = ByteSize;
            return true;
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
                        System.Buffers.ArrayPool<global::System.UInt64>.Shared.Return(lookupTableBuffer);
                }
                disposedValue = true;
            }
            base.Dispose(disposing);
        }
        #endregion
    }

}
