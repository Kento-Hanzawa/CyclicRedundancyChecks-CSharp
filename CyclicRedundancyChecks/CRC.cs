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
        private static bool isRegistered = false;

        /// <summary>
        /// CRC の実装を <see cref="System.Security.Cryptography.CryptoConfig.AddAlgorithm(Type, string[])"/> を使用して登録します。
        /// </summary>
        public static void RegisterAlgorithm()
        {
            if (isRegistered) return;

            // CRC8
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_STANDARD), "CRC-8", "CRC8");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_CDMA2000), "CRC-8-CDMA2000", "CRC8-CDMA2000");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_DARC), "CRC-8-DARC", "CRC8-DARC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_DVB_S2), "CRC-8-DVB-S2", "CRC8-DVB-S2");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_EBU), "CRC-8-EBU", "CRC8-EBU");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_I_CODE), "CRC-8-I-CODE", "CRC8-I-CODE");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_ITU), "CRC-8-ITU", "CRC8-ITU");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_MAXIM), "CRC-8-MAXIM", "CRC8-MAXIM");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_ROHC), "CRC-8-ROHC", "CRC8-ROHC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC8_WCDMA), "CRC-8-WCDMA", "CRC8-WCDMA");
            // CRC16
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_CCITT_FALSE), "CRC-16-CCITT-FALSE", "CRC16-CCITT-FALSE");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_ARC), "CRC-16-ARC", "CRC16-ARC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_AUG_CCITT), "CRC-16-AUG-CCITT", "CRC16-AUG-CCITT");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_BUYPASS), "CRC-16-BUYPASS", "CRC16-BUYPASS");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_CDMA2000), "CRC-16-CDMA2000", "CRC16-CDMA2000");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_DDS_110), "CRC-16-DDS-110", "CRC16-DDS-110");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_DECT_R), "CRC-16-DECT-R", "CRC16-DECT-R");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_DECT_X), "CRC-16-DECT-X", "CRC16-DECT-X");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_DNP), "CRC-16-DNP", "CRC16-DNP");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_EN_13757), "CRC-16-EN-13757", "CRC16-EN-13757");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_GENIBUS), "CRC-16-GENIBUS", "CRC16-GENIBUS");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_MAXIM), "CRC-16-MAXIM", "CRC16-MAXIM");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_MCRF4XX), "CRC-16-MCRF4XX", "CRC16-MCRF4XX");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_RIELLO), "CRC-16-RIELLO", "CRC16-RIELLO");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_T10_DIF), "CRC-16-T10-DIF", "CRC16-T10-DIF");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_TELEDISK), "CRC-16-TELEDISK", "CRC16-TELEDISK");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_TMS37157), "CRC-16-TMS37157", "CRC16-TMS37157");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_USB), "CRC-16-USB", "CRC16-USB", "CRC-16", "CRC16");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_A), "CRC-16-A", "CRC16-A");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_KERMIT), "CRC-16-KERMIT", "CRC16-KERMIT");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_MODBUS), "CRC-16-MODBUS", "CRC16-MODBUS");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_X_25), "CRC-16-X-25", "CRC16-X-25");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC16_XMODEM), "CRC-16-XMODEM", "CRC16-XMODEM");
            // CRC32
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_STANDARD), "CRC-32", "CRC32");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_BZIP2), "CRC-32-BZIP2", "CRC32-BZIP2");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_C), "CRC-32-C", "CRC32-C");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_D), "CRC-32-D", "CRC32-D");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_MPEG_2), "CRC-32-MPEG-2", "CRC32-MPEG-2");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_POSIX), "CRC-32-POSIX", "CRC32-POSIX");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_Q), "CRC-32-Q", "CRC32-Q");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_JAMCRC), "CRC-32-JAMCRC", "CRC32-JAMCRC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC32_XFER), "CRC-32-XFER", "CRC32-XFER");
            // CRC64
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC64_ECMA_182), "CRC-64-ECMA-182", "CRC64-ECMA-182", "CRC-64", "CRC64");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC64_GO_ISO), "CRC-64-GO-ISO", "CRC64-GO-ISO");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC64_WE), "CRC-64-WE", "CRC64-WE");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC64_XZ), "CRC-64-XZ", "CRC64-XZ");

            isRegistered = true;
        }
    }

    /// <summary>
    /// 入力データの <see cref="CyclicRedundancyChecks.CRC8"/> ハッシュを計算します。
    /// </summary>
    public partial class CRC8 : CRC
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

        /// <summary>
        /// バイトシーケンスから CRC の値へ変換します。
        /// </summary>
        /// <remarks><see cref="System.Security.Cryptography.HashAlgorithm.ComputeHash(byte[])"/> などから受け取ったバイト配列を CRC 値へ変換する際などに使用します。</remarks>
        /// <param name="hash">変換を行うバイトシーケンス。</param>
        /// <exception cref="ArgumentOutOfRangeException">バイトシーケンスの長さが 1 未満です。</exception>
        /// <returns>バイトシーケンスから変換された CRC 値。</returns>
        public static global::System.Byte ToRawValue(System.ReadOnlySpan<byte> hash)
        {
            if (hash.Length < 1)
                throw new ArgumentOutOfRangeException(nameof(hash), 1, "バイトシーケンスから CRC 値を取得するには、シーケンスの長さが 1 以上である必要があります。");
            return hash[0];
        }

        /// <summary>
        /// CRC 値をバイト配列へ変換します。
        /// </summary>
        /// <param name="crc">変換を行う CRC 値。</param>
        /// <returns>CRC 値を変換したバイト配列。</returns>
        public static byte[] ToBytes(global::System.Byte crc)
        {
            Span<byte> result = stackalloc byte[ByteSize];
            result[0] = (byte)(crc >> 0);
            return result.ToArray();
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
    public partial class CRC16 : CRC
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

        /// <summary>
        /// バイトシーケンスから CRC の値へ変換します。
        /// </summary>
        /// <remarks><see cref="System.Security.Cryptography.HashAlgorithm.ComputeHash(byte[])"/> などから受け取ったバイト配列を CRC 値へ変換する際などに使用します。</remarks>
        /// <param name="hash">変換を行うバイトシーケンス。</param>
        /// <exception cref="ArgumentOutOfRangeException">バイトシーケンスの長さが 2 未満です。</exception>
        /// <returns>バイトシーケンスから変換された CRC 値。</returns>
        public static global::System.UInt16 ToRawValue(System.ReadOnlySpan<byte> hash)
        {
            if (hash.Length < 2)
                throw new ArgumentOutOfRangeException(nameof(hash), 2, "バイトシーケンスから CRC 値を取得するには、シーケンスの長さが 2 以上である必要があります。");
            return BitConverter.ToUInt16(hash);
        }

        /// <summary>
        /// CRC 値をバイト配列へ変換します。
        /// </summary>
        /// <param name="crc">変換を行う CRC 値。</param>
        /// <returns>CRC 値を変換したバイト配列。</returns>
        public static byte[] ToBytes(global::System.UInt16 crc)
        {
            Span<byte> result = stackalloc byte[ByteSize];
            result[0] = (byte)(crc >> 0);
            result[1] = (byte)(crc >> 8);
            return result.ToArray();
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
    public partial class CRC32 : CRC
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

        /// <summary>
        /// バイトシーケンスから CRC の値へ変換します。
        /// </summary>
        /// <remarks><see cref="System.Security.Cryptography.HashAlgorithm.ComputeHash(byte[])"/> などから受け取ったバイト配列を CRC 値へ変換する際などに使用します。</remarks>
        /// <param name="hash">変換を行うバイトシーケンス。</param>
        /// <exception cref="ArgumentOutOfRangeException">バイトシーケンスの長さが 4 未満です。</exception>
        /// <returns>バイトシーケンスから変換された CRC 値。</returns>
        public static global::System.UInt32 ToRawValue(System.ReadOnlySpan<byte> hash)
        {
            if (hash.Length < 4)
                throw new ArgumentOutOfRangeException(nameof(hash), 4, "バイトシーケンスから CRC 値を取得するには、シーケンスの長さが 4 以上である必要があります。");
            return BitConverter.ToUInt32(hash);
        }

        /// <summary>
        /// CRC 値をバイト配列へ変換します。
        /// </summary>
        /// <param name="crc">変換を行う CRC 値。</param>
        /// <returns>CRC 値を変換したバイト配列。</returns>
        public static byte[] ToBytes(global::System.UInt32 crc)
        {
            Span<byte> result = stackalloc byte[ByteSize];
            result[0] = (byte)(crc >> 0);
            result[1] = (byte)(crc >> 8);
            result[2] = (byte)(crc >> 16);
            result[3] = (byte)(crc >> 24);
            return result.ToArray();
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
    public partial class CRC64 : CRC
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

        /// <summary>
        /// バイトシーケンスから CRC の値へ変換します。
        /// </summary>
        /// <remarks><see cref="System.Security.Cryptography.HashAlgorithm.ComputeHash(byte[])"/> などから受け取ったバイト配列を CRC 値へ変換する際などに使用します。</remarks>
        /// <param name="hash">変換を行うバイトシーケンス。</param>
        /// <exception cref="ArgumentOutOfRangeException">バイトシーケンスの長さが 8 未満です。</exception>
        /// <returns>バイトシーケンスから変換された CRC 値。</returns>
        public static global::System.UInt64 ToRawValue(System.ReadOnlySpan<byte> hash)
        {
            if (hash.Length < 8)
                throw new ArgumentOutOfRangeException(nameof(hash), 8, "バイトシーケンスから CRC 値を取得するには、シーケンスの長さが 8 以上である必要があります。");
            return BitConverter.ToUInt64(hash);
        }

        /// <summary>
        /// CRC 値をバイト配列へ変換します。
        /// </summary>
        /// <param name="crc">変換を行う CRC 値。</param>
        /// <returns>CRC 値を変換したバイト配列。</returns>
        public static byte[] ToBytes(global::System.UInt64 crc)
        {
            Span<byte> result = stackalloc byte[ByteSize];
            result[0] = (byte)(crc >> 0);
            result[1] = (byte)(crc >> 8);
            result[2] = (byte)(crc >> 16);
            result[3] = (byte)(crc >> 24);
            result[4] = (byte)(crc >> 32);
            result[5] = (byte)(crc >> 40);
            result[6] = (byte)(crc >> 48);
            result[7] = (byte)(crc >> 56);
            return result.ToArray();
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
