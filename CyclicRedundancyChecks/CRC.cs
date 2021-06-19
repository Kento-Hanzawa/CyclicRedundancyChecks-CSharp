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
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_STANDARD), "CRC8");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_CDMA2000), "CRC8/CDMA2000");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_DARC), "CRC8/DARC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_DVB_S2), "CRC8/DVB-S2");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_EBU), "CRC8/EBU");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_I_CODE), "CRC8/I-CODE");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_ITU), "CRC8/ITU");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_MAXIM), "CRC8/MAXIM");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_ROHC), "CRC8/ROHC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_WCDMA), "CRC8/WCDMA");
            // CRC16
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_CCITT_FALSE), "CRC16/CCITT-FALSE");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_ARC), "CRC16/ARC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_AUG_CCITT), "CRC16/AUG-CCITT");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_BUYPASS), "CRC16/BUYPASS");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_CDMA2000), "CRC16/CDMA2000");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_DDS_110), "CRC16/DDS-110");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_DECT_R), "CRC16/DECT-R");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_DECT_X), "CRC16/DECT-X");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_DNP), "CRC16/DNP");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_EN_13757), "CRC16/EN-13757");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_GENIBUS), "CRC16/GENIBUS");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_MAXIM), "CRC16/MAXIM");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_MCRF4XX), "CRC16/MCRF4XX");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_RIELLO), "CRC16/RIELLO");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_T10_DIF), "CRC16/T10-DIF");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_TELEDISK), "CRC16/TELEDISK");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_TMS37157), "CRC16/TMS37157");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_USB), "CRC16/USB");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_A), "CRCA");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_KERMIT), "CRC16/KERMIT");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_MODBUS), "CRC16/MODBUS");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_X_25), "CRC16/X-25");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_XMODEM), "CRC16/XMODEM");
            // CRC32
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_STANDARD), "CRC32");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_BZIP2), "CRC32/BZIP2");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32C), "CRC32C");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32D), "CRC32D");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_MPEG_2), "CRC32/MPEG-2");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_POSIX), "CRC32/POSIX");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32Q), "CRC32Q");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_JAMCRC), "CRC32/JAMCRC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_XFER), "CRC32/XFER");
            // CRC64
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC64_ECMA_182), "CRC64/ECMA-182");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC64_GO_ISO), "CRC64/GO-ISO");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC64_WE), "CRC64/WE");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC64_XZ), "CRC64/XZ");
        }
    }

    /// <summary>
    /// 入力データの <see cref="CyclicRedundancyChecks.CRC8"/> ハッシュを計算します。
    /// </summary>
    public class CRC8 : CRC
    {
        private const int ByteSize = sizeof(global::System.Byte);
        private const int BitSize = ByteSize * 8;

        private global::System.Byte result;
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
                    var tableIndex = (int)((result & 0xFF) ^ source[i]);
                    result = (global::System.Byte)((result >> 8) ^ LookupTable[tableIndex]);
                }
                else
                {
                    var tableIndex = (int)(((result >> (BitSize - 8)) & 0xFF) ^ source[i]);
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

            if (ReversedOut)
                result = (global::System.Byte)(~result ^ FinalXorValue);
            else
                result = (global::System.Byte)(result ^ FinalXorValue);

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

        private global::System.UInt16 result;
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
                    var tableIndex = (int)((result & 0xFF) ^ source[i]);
                    result = (global::System.UInt16)((result >> 8) ^ LookupTable[tableIndex]);
                }
                else
                {
                    var tableIndex = (int)(((result >> (BitSize - 8)) & 0xFF) ^ source[i]);
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

            if (ReversedOut)
                result = (global::System.UInt16)(~result ^ FinalXorValue);
            else
                result = (global::System.UInt16)(result ^ FinalXorValue);

            destination[0] = (byte)(result >> 8);
            destination[1] = (byte)(result >> 0);
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

        private global::System.UInt32 result;
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
                    var tableIndex = (int)((result & 0xFF) ^ source[i]);
                    result = (global::System.UInt32)((result >> 8) ^ LookupTable[tableIndex]);
                }
                else
                {
                    var tableIndex = (int)(((result >> (BitSize - 8)) & 0xFF) ^ source[i]);
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

            if (ReversedOut)
                result = (global::System.UInt32)(~result ^ FinalXorValue);
            else
                result = (global::System.UInt32)(result ^ FinalXorValue);

            destination[0] = (byte)(result >> 24);
            destination[1] = (byte)(result >> 16);
            destination[2] = (byte)(result >> 8);
            destination[3] = (byte)(result >> 0);
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

        private global::System.UInt64 result;
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
                    var tableIndex = (int)((result & 0xFF) ^ source[i]);
                    result = (global::System.UInt64)((result >> 8) ^ LookupTable[tableIndex]);
                }
                else
                {
                    var tableIndex = (int)(((result >> (BitSize - 8)) & 0xFF) ^ source[i]);
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

            if (ReversedOut)
                result = (global::System.UInt64)(~result ^ FinalXorValue);
            else
                result = (global::System.UInt64)(result ^ FinalXorValue);

            destination[0] = (byte)(result >> 56);
            destination[1] = (byte)(result >> 48);
            destination[2] = (byte)(result >> 40);
            destination[3] = (byte)(result >> 32);
            destination[4] = (byte)(result >> 24);
            destination[5] = (byte)(result >> 16);
            destination[6] = (byte)(result >> 8);
            destination[7] = (byte)(result >> 0);
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
