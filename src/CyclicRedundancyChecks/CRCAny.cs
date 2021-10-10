using System;
using System.Buffers;
using System.Numerics;
using CyclicRedundancyChecks.Internal;

namespace CyclicRedundancyChecks
{
    /// <summary>
    /// 任意のビットサイズの CRC を計算する機能を提供します。
    /// </summary>
    public sealed class CRCAny : CRC
    {
        private const int MinBitWidth = 1;

        private BigInteger _result;
        private BigInteger[] _lookupTableBuffer;

        /// <summary>
        /// ビットサイズ。
        /// </summary>
        public int BitWidth { get; }

        /// <summary>
        /// 生成多項式。
        /// </summary>
        public BigInteger Polynomial { get; }

        /// <summary>
        /// 初期値。
        /// </summary>
        public BigInteger InitialValue { get; }

        /// <summary>
        /// 計算の最後に行う XOR 演算で使用する値。
        /// </summary>
        public BigInteger FinalXorValue { get; }

        /// <summary>
        /// 計算時に入力データのビット順反転をするかどうか。
        /// </summary>
        public bool ReflectInput { get; }

        /// <summary>
        /// 計算の最後にビット順反転をするかどうか。
        /// </summary>
        public bool ReflectOutput { get; }

        /// <summary>
        /// 計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納するかどうか。
        /// </summary>
        public bool IsBigEndianResult { get; }

        /// <summary>
        /// ルックアップテーブルを使用した計算をするかどうか。
        /// </summary>
        public bool UseLookupTable { get; }

        private BigInteger BitMask => ((BigInteger)1UL << BitWidth) - 1;
        private int BitWidthInBytes => (BitWidth / 8) + (BitWidth % 8 == 0 ? 0 : 1);

        private ReadOnlySpan<BigInteger> LookupTable
        {
            get
            {
                if (_lookupTableBuffer is null)
                {
                    _lookupTableBuffer = ArrayPool<BigInteger>.Shared.Rent(LookupTableSize);
                    CRCUtility.LookupTableFill(_lookupTableBuffer, BitWidth, Polynomial);
                }
                return _lookupTableBuffer.AsSpan(0, LookupTableSize);
            }
        }

        /// <summary>
        /// 各パラメータを指定して、<see cref="CRC16"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="bitWidth">ビットサイズ。</param>
        /// <param name="polynomial">生成多項式。</param>
        /// <param name="initialValue">初期値。</param>
        /// <param name="finalXorValue">計算の最後に実装される XOR 演算で使用する値。</param>
        /// <param name="reflectInput">計算時に入力データのビット順反転をするかどうか。反転する場合は <see langword="true"/>、反転しない場合は <see langword="false"/>。</param>
        /// <param name="reflectOutput">計算の最後にビット順反転をするかどうか。反転する場合は <see langword="true"/>、反転しない場合は <see langword="false"/>。</param>
        /// <param name="isBigEndian">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        /// <param name="useLookupTable">
        /// <para>ルックアップテーブルを使用した計算をする場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。</para>
        /// <para>使用する場合、事前にビットパターンの計算テーブルを生成します。これにより計算手順の簡略化が行われ、パフォーマンスが向上する場合があります。</para>
        /// <para>入力データサイズが合計 255 バイト以下の場合に限り、テーブルを使用しない方がパフォーマンスの期待値は高くなります。</para>
        /// </param>
        public CRCAny(int bitWidth, BigInteger polynomial, BigInteger initialValue, BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndian = false, bool useLookupTable = true)
        {
            if (bitWidth is < MinBitWidth)
                throw new ArgumentOutOfRangeException(nameof(bitWidth), $"{nameof(bitWidth)} は {MinBitWidth} 以上である必要があります。");

            HashSizeValue = BitWidth = bitWidth;
            Polynomial = polynomial;
            InitialValue = initialValue;
            FinalXorValue = finalXorValue;
            ReflectInput = reflectInput;
            ReflectOutput = reflectOutput;

            IsBigEndianResult = isBigEndian;
            UseLookupTable = useLookupTable;

            Initialize();
        }

#pragma warning disable CS1591

        public sealed override void Initialize()
        {
            _result = InitialValue;
        }

        protected sealed override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            HashCore(array.AsSpan(ibStart, cbSize));
        }

        protected sealed override void HashCore(ReadOnlySpan<byte> source)
        {
            if (UseLookupTable)
            {
                CRCUtility.AppendData(ref _result, source, HashSizeValue, LookupTable, ReflectInput);
            }
            else
            {
                CRCUtility.AppendData(ref _result, source, HashSizeValue, Polynomial, ReflectInput);
            }
        }

        protected sealed override byte[] HashFinal()
        {
            Span<byte> span = stackalloc byte[BitWidthInBytes];
            TryHashFinal(span, out _);
            return span.ToArray();
        }

        protected sealed override bool TryHashFinal(Span<byte> destination, out int bytesWritten)
        {
            if (destination.Length < BitWidthInBytes)
            {
                bytesWritten = 0;
                return false;
            }

            if (ReflectOutput)
            {
                _result = CRCUtility.BitReflect(_result, HashSizeValue);
            }
            _result ^= FinalXorValue;
            _result &= BitMask;

            return _result.TryWriteBytes(destination, out bytesWritten, true, IsBigEndianResult);
        }

        protected sealed override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_lookupTableBuffer is not null)
                {
                    ArrayPool<BigInteger>.Shared.Return(_lookupTableBuffer);
                    _lookupTableBuffer = null;
                }
            }
            base.Dispose(disposing);
        }

#pragma warning restore CS1591
    }
}
