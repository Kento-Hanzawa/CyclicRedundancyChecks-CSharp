using System;
using System.Numerics;
using System.Security.Cryptography;

namespace CyclicRedundancyChecks
{
    /// <summary>
    /// CRC (Cyclic Redundancy Check) のすべての実装が継承する必要のある抽象基底クラスを表します。
    /// </summary>
    public abstract partial class CRC : HashAlgorithm
    {
        internal const int LookupTableSize = 256;

        /// <summary>
        /// CRC アルゴリズムで使用する各パラメータに適した <see cref="CRC"/> の実装のインスタンスを作成します。
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="bitWidth"/> が 1 未満です。</exception>
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
        /// <returns><see cref="CRC"/> の実装のインスタンス。</returns>
        public static CRC Create(int bitWidth, ulong polynomial, ulong initialValue, ulong finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndian = false, bool useLookupTable = true)
        {
            return bitWidth switch
            {
                (<= 0) => throw new ArgumentOutOfRangeException(nameof(bitWidth), $"{nameof(bitWidth)} は 1 以上である必要があります。"),
                (<= 8) => new CRC8((byte)polynomial, (byte)initialValue, (byte)finalXorValue, reflectInput, reflectOutput, bitWidth, isBigEndian, useLookupTable),
                (<= 16) => new CRC16((ushort)polynomial, (ushort)initialValue, (ushort)finalXorValue, reflectInput, reflectOutput, bitWidth, isBigEndian, useLookupTable),
                (<= 32) => new CRC32((uint)polynomial, (uint)initialValue, (uint)finalXorValue, reflectInput, reflectOutput, bitWidth, isBigEndian, useLookupTable),
                (<= 64) => new CRC64(polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, bitWidth, isBigEndian, useLookupTable),
                (_) => new CRCAny(bitWidth, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndian, useLookupTable),
            };
        }

        /// <summary>
        /// CRC アルゴリズムで使用する各パラメータに適した <see cref="CRC"/> の実装のインスタンスを作成します。
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="bitWidth"/> が 1 未満です。</exception>
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
        /// <returns><see cref="CRC"/> の実装のインスタンス。</returns>
        public static CRC Create(int bitWidth, BigInteger polynomial, BigInteger initialValue, BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndian = false, bool useLookupTable = true)
        {
            return bitWidth switch
            {
                (<= 0) => throw new ArgumentOutOfRangeException(nameof(bitWidth), $"{nameof(bitWidth)} は 1 以上である必要があります。"),
                (<= 8) => new CRC8((byte)polynomial, (byte)initialValue, (byte)finalXorValue, reflectInput, reflectOutput, bitWidth, isBigEndian, useLookupTable),
                (<= 16) => new CRC16((ushort)polynomial, (ushort)initialValue, (ushort)finalXorValue, reflectInput, reflectOutput, bitWidth, isBigEndian, useLookupTable),
                (<= 32) => new CRC32((uint)polynomial, (uint)initialValue, (uint)finalXorValue, reflectInput, reflectOutput, bitWidth, isBigEndian, useLookupTable),
                (<= 64) => new CRC64((ulong)polynomial, (ulong)initialValue, (ulong)finalXorValue, reflectInput, reflectOutput, bitWidth, isBigEndian, useLookupTable),
                (_) => new CRCAny(bitWidth, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndian, useLookupTable),
            };
        }

        /// <summary>
        /// 指定した <see cref="CRCSpec"/> に適した <see cref="CRC"/> の実装のインスタンスを作成します。
        /// </summary>
        /// <param name="spec"><see cref="CRCSpec"/> のインスタンス。</param>
        /// <param name="isBigEndian">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        /// <param name="useLookupTable">
        /// <para>ルックアップテーブルを使用した計算をする場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。</para>
        /// <para>使用する場合、事前にビットパターンの計算テーブルを生成します。これにより計算手順の簡略化が行われ、パフォーマンスが向上する場合があります。</para>
        /// <para>入力データサイズが合計 255 バイト以下の場合に限り、テーブルを使用しない方がパフォーマンスの期待値は高くなります。</para>
        /// </param>
        /// <returns><see cref="CRC"/> の実装のインスタンス。</returns>
        public static CRC Create(CRCSpec spec, bool isBigEndian = false, bool useLookupTable = true)
        {
            return Create(spec.BitWidth, spec.Polynomial, spec.InitialValue, spec.FinalXorValue, spec.ReflectInput, spec.ReflectOutput, isBigEndian, useLookupTable);
        }
    }
}
