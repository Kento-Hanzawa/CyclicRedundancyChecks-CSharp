using System;
using System.Numerics;

namespace CyclicRedundancyChecks
{
    /// <summary>
    /// CRCアルゴリズムで使用されるパラメータをラップする構造体。
    /// </summary>
    public readonly partial struct CRCSpec : IEquatable<CRCSpec>
    {
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
        /// 各パラメータを指定して、<see cref="CRCSpec"/> 構造体の新しいインスタンスを作成します。
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="bitWidth"/> が 1 未満です。</exception>
        /// <param name="bitWidth">ビットサイズ。</param>
        /// <param name="polynomial">生成多項式。</param>
        /// <param name="initialValue">初期値。</param>
        /// <param name="finalXorValue">計算の最後に実装される XOR 演算で使用する値。</param>
        /// <param name="reflectInput">計算時に入力データのビット順反転をするかどうか。反転する場合は <see langword="true"/>、反転しない場合は <see langword="false"/>。</param>
        /// <param name="reflectOutput">計算の最後にビット順反転をするかどうか。反転する場合は <see langword="true"/>、反転しない場合は <see langword="false"/>。</param>
        public CRCSpec(int bitWidth, ulong polynomial, ulong initialValue, ulong finalXorValue, bool reflectInput, bool reflectOutput)
        {
            if (bitWidth is < 1)
                throw new ArgumentOutOfRangeException(nameof(bitWidth), $"{nameof(bitWidth)} は 1 以上である必要があります。");

            BitWidth = bitWidth;
            Polynomial = polynomial;
            InitialValue = initialValue;
            FinalXorValue = finalXorValue;
            ReflectInput = reflectInput;
            ReflectOutput = reflectOutput;
        }

        /// <summary>
        /// 各パラメータを指定して、<see cref="CRCSpec"/> 構造体の新しいインスタンスを作成します。
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="bitWidth"/> が 1 未満です。</exception>
        /// <param name="bitWidth">ビットサイズ。</param>
        /// <param name="polynomial">生成多項式。</param>
        /// <param name="initialValue">初期値。</param>
        /// <param name="finalXorValue">計算の最後に実装される XOR 演算で使用する値。</param>
        /// <param name="reflectInput">計算時に入力データのビット順反転をするかどうか。反転する場合は <see langword="true"/>、反転しない場合は <see langword="false"/>。</param>
        /// <param name="reflectOutput">計算の最後にビット順反転をするかどうか。反転する場合は <see langword="true"/>、反転しない場合は <see langword="false"/>。</param>
        public CRCSpec(int bitWidth, BigInteger polynomial, BigInteger initialValue, BigInteger finalXorValue, bool reflectInput, bool reflectOutput)
        {
            if (bitWidth is < 1)
                throw new ArgumentOutOfRangeException(nameof(bitWidth), $"{nameof(bitWidth)} は 1 以上である必要があります。");

            BitWidth = bitWidth;
            Polynomial = polynomial;
            InitialValue = initialValue;
            FinalXorValue = finalXorValue;
            ReflectInput = reflectInput;
            ReflectOutput = reflectOutput;
        }

#pragma warning disable CS1591

        public override bool Equals(object obj)
        {
            return obj is CRCSpec spec && Equals(spec);
        }

        public bool Equals(CRCSpec other)
        {
            return BitWidth == other.BitWidth &&
                   Polynomial.Equals(other.Polynomial) &&
                   InitialValue.Equals(other.InitialValue) &&
                   FinalXorValue.Equals(other.FinalXorValue) &&
                   ReflectInput == other.ReflectInput &&
                   ReflectOutput == other.ReflectOutput;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(BitWidth, Polynomial, InitialValue, FinalXorValue, ReflectInput, ReflectOutput);
        }

        public static bool operator ==(CRCSpec left, CRCSpec right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(CRCSpec left, CRCSpec right)
        {
            return !(left == right);
        }

#pragma warning restore CS1591
    }
}
