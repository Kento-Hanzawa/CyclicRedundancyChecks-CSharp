//
// CyclicRedundancyChecks
// 
// このコードはテキストテンプレートファイル (.tt) によって作成されています。
// 変更をおこなう場合は、テキストテンプレートファイル (.tt) を編集してください。
//

using System.Globalization;
using System.Numerics;

namespace CyclicRedundancyChecks
{
    /// <summary>
    /// <para>入力データの CRC-3/GSM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC3"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x3</b></para>
    /// <para><i>InitialValue </i>: <b>0x0</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x7</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_3_GSM : CRC3
    {
        /// <summary>
        /// <see cref="CRC_3_GSM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_3_GSM(bool isBigEndianResult = false)
            : base(0x3, 0x0, 0x7, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-3/ROHC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC3"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x3</b></para>
    /// <para><i>InitialValue </i>: <b>0x7</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_3_ROHC : CRC3
    {
        /// <summary>
        /// <see cref="CRC_3_ROHC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_3_ROHC(bool isBigEndianResult = false)
            : base(0x3, 0x7, 0x0, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-4/G-704 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC4"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x3</b></para>
    /// <para><i>InitialValue </i>: <b>0x0</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_4_G_704 : CRC4
    {
        /// <summary>
        /// <see cref="CRC_4_G_704"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_4_G_704(bool isBigEndianResult = false)
            : base(0x3, 0x0, 0x0, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-4/INTERLAKEN ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC4"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x3</b></para>
    /// <para><i>InitialValue </i>: <b>0xf</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xf</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_4_INTERLAKEN : CRC4
    {
        /// <summary>
        /// <see cref="CRC_4_INTERLAKEN"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_4_INTERLAKEN(bool isBigEndianResult = false)
            : base(0x3, 0xf, 0xf, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-5/EPC-C1G2 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC5"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x09</b></para>
    /// <para><i>InitialValue </i>: <b>0x09</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_5_EPC_C1G2 : CRC5
    {
        /// <summary>
        /// <see cref="CRC_5_EPC_C1G2"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_5_EPC_C1G2(bool isBigEndianResult = false)
            : base(0x09, 0x09, 0x00, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-5/G-704 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC5"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x15</b></para>
    /// <para><i>InitialValue </i>: <b>0x00</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_5_G_704 : CRC5
    {
        /// <summary>
        /// <see cref="CRC_5_G_704"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_5_G_704(bool isBigEndianResult = false)
            : base(0x15, 0x00, 0x00, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-5/USB ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC5"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x05</b></para>
    /// <para><i>InitialValue </i>: <b>0x1f</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x1f</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_5_USB : CRC5
    {
        /// <summary>
        /// <see cref="CRC_5_USB"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_5_USB(bool isBigEndianResult = false)
            : base(0x05, 0x1f, 0x1f, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-6/CDMA2000-A ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC6"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x27</b></para>
    /// <para><i>InitialValue </i>: <b>0x3f</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_6_CDMA2000_A : CRC6
    {
        /// <summary>
        /// <see cref="CRC_6_CDMA2000_A"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_6_CDMA2000_A(bool isBigEndianResult = false)
            : base(0x27, 0x3f, 0x00, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-6/CDMA2000-B ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC6"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x07</b></para>
    /// <para><i>InitialValue </i>: <b>0x3f</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_6_CDMA2000_B : CRC6
    {
        /// <summary>
        /// <see cref="CRC_6_CDMA2000_B"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_6_CDMA2000_B(bool isBigEndianResult = false)
            : base(0x07, 0x3f, 0x00, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-6/DARC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC6"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x19</b></para>
    /// <para><i>InitialValue </i>: <b>0x00</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_6_DARC : CRC6
    {
        /// <summary>
        /// <see cref="CRC_6_DARC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_6_DARC(bool isBigEndianResult = false)
            : base(0x19, 0x00, 0x00, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-6/G-704 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC6"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x03</b></para>
    /// <para><i>InitialValue </i>: <b>0x00</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_6_G_704 : CRC6
    {
        /// <summary>
        /// <see cref="CRC_6_G_704"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_6_G_704(bool isBigEndianResult = false)
            : base(0x03, 0x00, 0x00, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-6/GSM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC6"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x2f</b></para>
    /// <para><i>InitialValue </i>: <b>0x00</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x3f</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_6_GSM : CRC6
    {
        /// <summary>
        /// <see cref="CRC_6_GSM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_6_GSM(bool isBigEndianResult = false)
            : base(0x2f, 0x00, 0x3f, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-7/MMC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC7"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x09</b></para>
    /// <para><i>InitialValue </i>: <b>0x00</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_7_MMC : CRC7
    {
        /// <summary>
        /// <see cref="CRC_7_MMC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_7_MMC(bool isBigEndianResult = false)
            : base(0x09, 0x00, 0x00, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-7/ROHC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC7"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x4f</b></para>
    /// <para><i>InitialValue </i>: <b>0x7f</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_7_ROHC : CRC7
    {
        /// <summary>
        /// <see cref="CRC_7_ROHC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_7_ROHC(bool isBigEndianResult = false)
            : base(0x4f, 0x7f, 0x00, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-7/UMTS ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC7"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x45</b></para>
    /// <para><i>InitialValue </i>: <b>0x00</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_7_UMTS : CRC7
    {
        /// <summary>
        /// <see cref="CRC_7_UMTS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_7_UMTS(bool isBigEndianResult = false)
            : base(0x45, 0x00, 0x00, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/AUTOSAR ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x2f</b></para>
    /// <para><i>InitialValue </i>: <b>0xff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_AUTOSAR : CRC8
    {
        /// <summary>
        /// <see cref="CRC_8_AUTOSAR"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_AUTOSAR(bool isBigEndianResult = false)
            : base(0x2f, 0xff, 0xff, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/BLUETOOTH ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0xa7</b></para>
    /// <para><i>InitialValue </i>: <b>0x00</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_8_BLUETOOTH : CRC8
    {
        /// <summary>
        /// <see cref="CRC_8_BLUETOOTH"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_BLUETOOTH(bool isBigEndianResult = false)
            : base(0xa7, 0x00, 0x00, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/CDMA2000 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x9b</b></para>
    /// <para><i>InitialValue </i>: <b>0xff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_CDMA2000 : CRC8
    {
        /// <summary>
        /// <see cref="CRC_8_CDMA2000"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_CDMA2000(bool isBigEndianResult = false)
            : base(0x9b, 0xff, 0x00, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/DARC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x39</b></para>
    /// <para><i>InitialValue </i>: <b>0x00</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_8_DARC : CRC8
    {
        /// <summary>
        /// <see cref="CRC_8_DARC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_DARC(bool isBigEndianResult = false)
            : base(0x39, 0x00, 0x00, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/DVB-S2 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0xd5</b></para>
    /// <para><i>InitialValue </i>: <b>0x00</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_DVB_S2 : CRC8
    {
        /// <summary>
        /// <see cref="CRC_8_DVB_S2"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_DVB_S2(bool isBigEndianResult = false)
            : base(0xd5, 0x00, 0x00, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/GSM-A ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x1d</b></para>
    /// <para><i>InitialValue </i>: <b>0x00</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_GSM_A : CRC8
    {
        /// <summary>
        /// <see cref="CRC_8_GSM_A"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_GSM_A(bool isBigEndianResult = false)
            : base(0x1d, 0x00, 0x00, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/GSM-B ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x49</b></para>
    /// <para><i>InitialValue </i>: <b>0x00</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_GSM_B : CRC8
    {
        /// <summary>
        /// <see cref="CRC_8_GSM_B"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_GSM_B(bool isBigEndianResult = false)
            : base(0x49, 0x00, 0xff, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/I-432-1 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x07</b></para>
    /// <para><i>InitialValue </i>: <b>0x00</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x55</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_I_432_1 : CRC8
    {
        /// <summary>
        /// <see cref="CRC_8_I_432_1"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_I_432_1(bool isBigEndianResult = false)
            : base(0x07, 0x00, 0x55, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/I-CODE ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x1d</b></para>
    /// <para><i>InitialValue </i>: <b>0xfd</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_I_CODE : CRC8
    {
        /// <summary>
        /// <see cref="CRC_8_I_CODE"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_I_CODE(bool isBigEndianResult = false)
            : base(0x1d, 0xfd, 0x00, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/LTE ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x9b</b></para>
    /// <para><i>InitialValue </i>: <b>0x00</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_LTE : CRC8
    {
        /// <summary>
        /// <see cref="CRC_8_LTE"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_LTE(bool isBigEndianResult = false)
            : base(0x9b, 0x00, 0x00, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/MAXIM-DOW ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x31</b></para>
    /// <para><i>InitialValue </i>: <b>0x00</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_8_MAXIM_DOW : CRC8
    {
        /// <summary>
        /// <see cref="CRC_8_MAXIM_DOW"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_MAXIM_DOW(bool isBigEndianResult = false)
            : base(0x31, 0x00, 0x00, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/MIFARE-MAD ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x1d</b></para>
    /// <para><i>InitialValue </i>: <b>0xc7</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_MIFARE_MAD : CRC8
    {
        /// <summary>
        /// <see cref="CRC_8_MIFARE_MAD"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_MIFARE_MAD(bool isBigEndianResult = false)
            : base(0x1d, 0xc7, 0x00, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/NRSC-5 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x31</b></para>
    /// <para><i>InitialValue </i>: <b>0xff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_NRSC_5 : CRC8
    {
        /// <summary>
        /// <see cref="CRC_8_NRSC_5"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_NRSC_5(bool isBigEndianResult = false)
            : base(0x31, 0xff, 0x00, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/OPENSAFETY ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x2f</b></para>
    /// <para><i>InitialValue </i>: <b>0x00</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_OPENSAFETY : CRC8
    {
        /// <summary>
        /// <see cref="CRC_8_OPENSAFETY"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_OPENSAFETY(bool isBigEndianResult = false)
            : base(0x2f, 0x00, 0x00, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/ROHC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x07</b></para>
    /// <para><i>InitialValue </i>: <b>0xff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_8_ROHC : CRC8
    {
        /// <summary>
        /// <see cref="CRC_8_ROHC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_ROHC(bool isBigEndianResult = false)
            : base(0x07, 0xff, 0x00, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/SAE-J1850 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x1d</b></para>
    /// <para><i>InitialValue </i>: <b>0xff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_SAE_J1850 : CRC8
    {
        /// <summary>
        /// <see cref="CRC_8_SAE_J1850"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_SAE_J1850(bool isBigEndianResult = false)
            : base(0x1d, 0xff, 0xff, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/SMBUS ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x07</b></para>
    /// <para><i>InitialValue </i>: <b>0x00</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_SMBUS : CRC8
    {
        /// <summary>
        /// <see cref="CRC_8_SMBUS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_SMBUS(bool isBigEndianResult = false)
            : base(0x07, 0x00, 0x00, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/TECH-3250 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x1d</b></para>
    /// <para><i>InitialValue </i>: <b>0xff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_8_TECH_3250 : CRC8
    {
        /// <summary>
        /// <see cref="CRC_8_TECH_3250"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_TECH_3250(bool isBigEndianResult = false)
            : base(0x1d, 0xff, 0x00, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/WCDMA ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x9b</b></para>
    /// <para><i>InitialValue </i>: <b>0x00</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_8_WCDMA : CRC8
    {
        /// <summary>
        /// <see cref="CRC_8_WCDMA"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_WCDMA(bool isBigEndianResult = false)
            : base(0x9b, 0x00, 0x00, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-10/ATM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC10"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x233</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_10_ATM : CRC10
    {
        /// <summary>
        /// <see cref="CRC_10_ATM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_10_ATM(bool isBigEndianResult = false)
            : base(0x233, 0x000, 0x000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-10/CDMA2000 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC10"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x3d9</b></para>
    /// <para><i>InitialValue </i>: <b>0x3ff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_10_CDMA2000 : CRC10
    {
        /// <summary>
        /// <see cref="CRC_10_CDMA2000"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_10_CDMA2000(bool isBigEndianResult = false)
            : base(0x3d9, 0x3ff, 0x000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-10/GSM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC10"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x175</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x3ff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_10_GSM : CRC10
    {
        /// <summary>
        /// <see cref="CRC_10_GSM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_10_GSM(bool isBigEndianResult = false)
            : base(0x175, 0x000, 0x3ff, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-11/FLEXRAY ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC11"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x385</b></para>
    /// <para><i>InitialValue </i>: <b>0x01a</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_11_FLEXRAY : CRC11
    {
        /// <summary>
        /// <see cref="CRC_11_FLEXRAY"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_11_FLEXRAY(bool isBigEndianResult = false)
            : base(0x385, 0x01a, 0x000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-11/UMTS ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC11"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x307</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_11_UMTS : CRC11
    {
        /// <summary>
        /// <see cref="CRC_11_UMTS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_11_UMTS(bool isBigEndianResult = false)
            : base(0x307, 0x000, 0x000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-12/CDMA2000 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC12"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0xf13</b></para>
    /// <para><i>InitialValue </i>: <b>0xfff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_12_CDMA2000 : CRC12
    {
        /// <summary>
        /// <see cref="CRC_12_CDMA2000"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_12_CDMA2000(bool isBigEndianResult = false)
            : base(0xf13, 0xfff, 0x000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-12/DECT ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC12"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x80f</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_12_DECT : CRC12
    {
        /// <summary>
        /// <see cref="CRC_12_DECT"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_12_DECT(bool isBigEndianResult = false)
            : base(0x80f, 0x000, 0x000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-12/GSM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC12"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0xd31</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xfff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_12_GSM : CRC12
    {
        /// <summary>
        /// <see cref="CRC_12_GSM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_12_GSM(bool isBigEndianResult = false)
            : base(0xd31, 0x000, 0xfff, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-12/UMTS ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC12"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x80f</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_12_UMTS : CRC12
    {
        /// <summary>
        /// <see cref="CRC_12_UMTS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_12_UMTS(bool isBigEndianResult = false)
            : base(0x80f, 0x000, 0x000, false, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-13/BBC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC13"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x1cf5</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_13_BBC : CRC13
    {
        /// <summary>
        /// <see cref="CRC_13_BBC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_13_BBC(bool isBigEndianResult = false)
            : base(0x1cf5, 0x0000, 0x0000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-14/DARC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC14"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0805</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_14_DARC : CRC14
    {
        /// <summary>
        /// <see cref="CRC_14_DARC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_14_DARC(bool isBigEndianResult = false)
            : base(0x0805, 0x0000, 0x0000, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-14/GSM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC14"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x202d</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x3fff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_14_GSM : CRC14
    {
        /// <summary>
        /// <see cref="CRC_14_GSM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_14_GSM(bool isBigEndianResult = false)
            : base(0x202d, 0x0000, 0x3fff, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-15/CAN ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC15"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x4599</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_15_CAN : CRC15
    {
        /// <summary>
        /// <see cref="CRC_15_CAN"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_15_CAN(bool isBigEndianResult = false)
            : base(0x4599, 0x0000, 0x0000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-15/MPT1327 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC15"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x6815</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0001</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_15_MPT1327 : CRC15
    {
        /// <summary>
        /// <see cref="CRC_15_MPT1327"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_15_MPT1327(bool isBigEndianResult = false)
            : base(0x6815, 0x0000, 0x0001, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/ARC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x8005</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_ARC : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_ARC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_ARC(bool isBigEndianResult = false)
            : base(0x8005, 0x0000, 0x0000, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/CDMA2000 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0xc867</b></para>
    /// <para><i>InitialValue </i>: <b>0xffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_CDMA2000 : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_CDMA2000"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_CDMA2000(bool isBigEndianResult = false)
            : base(0xc867, 0xffff, 0x0000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/CMS ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x8005</b></para>
    /// <para><i>InitialValue </i>: <b>0xffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_CMS : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_CMS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_CMS(bool isBigEndianResult = false)
            : base(0x8005, 0xffff, 0x0000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/DDS-110 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x8005</b></para>
    /// <para><i>InitialValue </i>: <b>0x800d</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_DDS_110 : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_DDS_110"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_DDS_110(bool isBigEndianResult = false)
            : base(0x8005, 0x800d, 0x0000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/DECT-R ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0589</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0001</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_DECT_R : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_DECT_R"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_DECT_R(bool isBigEndianResult = false)
            : base(0x0589, 0x0000, 0x0001, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/DECT-X ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0589</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_DECT_X : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_DECT_X"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_DECT_X(bool isBigEndianResult = false)
            : base(0x0589, 0x0000, 0x0000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/DNP ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x3d65</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xffff</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_DNP : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_DNP"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_DNP(bool isBigEndianResult = false)
            : base(0x3d65, 0x0000, 0xffff, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/EN-13757 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x3d65</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_EN_13757 : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_EN_13757"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_EN_13757(bool isBigEndianResult = false)
            : base(0x3d65, 0x0000, 0xffff, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/GENIBUS ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x1021</b></para>
    /// <para><i>InitialValue </i>: <b>0xffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_GENIBUS : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_GENIBUS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_GENIBUS(bool isBigEndianResult = false)
            : base(0x1021, 0xffff, 0xffff, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/GSM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x1021</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_GSM : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_GSM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_GSM(bool isBigEndianResult = false)
            : base(0x1021, 0x0000, 0xffff, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/IBM-3740 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x1021</b></para>
    /// <para><i>InitialValue </i>: <b>0xffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_IBM_3740 : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_IBM_3740"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_IBM_3740(bool isBigEndianResult = false)
            : base(0x1021, 0xffff, 0x0000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/IBM-SDLC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x1021</b></para>
    /// <para><i>InitialValue </i>: <b>0xffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xffff</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_IBM_SDLC : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_IBM_SDLC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_IBM_SDLC(bool isBigEndianResult = false)
            : base(0x1021, 0xffff, 0xffff, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/ISO-IEC-14443-3-A ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x1021</b></para>
    /// <para><i>InitialValue </i>: <b>0xc6c6</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_ISO_IEC_14443_3_A : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_ISO_IEC_14443_3_A"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_ISO_IEC_14443_3_A(bool isBigEndianResult = false)
            : base(0x1021, 0xc6c6, 0x0000, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/KERMIT ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x1021</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_KERMIT : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_KERMIT"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_KERMIT(bool isBigEndianResult = false)
            : base(0x1021, 0x0000, 0x0000, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/LJ1200 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x6f63</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_LJ1200 : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_LJ1200"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_LJ1200(bool isBigEndianResult = false)
            : base(0x6f63, 0x0000, 0x0000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/MAXIM-DOW ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x8005</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xffff</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_MAXIM_DOW : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_MAXIM_DOW"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_MAXIM_DOW(bool isBigEndianResult = false)
            : base(0x8005, 0x0000, 0xffff, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/MCRF4XX ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x1021</b></para>
    /// <para><i>InitialValue </i>: <b>0xffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_MCRF4XX : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_MCRF4XX"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_MCRF4XX(bool isBigEndianResult = false)
            : base(0x1021, 0xffff, 0x0000, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/MODBUS ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x8005</b></para>
    /// <para><i>InitialValue </i>: <b>0xffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_MODBUS : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_MODBUS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_MODBUS(bool isBigEndianResult = false)
            : base(0x8005, 0xffff, 0x0000, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/NRSC-5 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x080b</b></para>
    /// <para><i>InitialValue </i>: <b>0xffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_NRSC_5 : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_NRSC_5"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_NRSC_5(bool isBigEndianResult = false)
            : base(0x080b, 0xffff, 0x0000, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/OPENSAFETY-A ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x5935</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_OPENSAFETY_A : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_OPENSAFETY_A"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_OPENSAFETY_A(bool isBigEndianResult = false)
            : base(0x5935, 0x0000, 0x0000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/OPENSAFETY-B ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x755b</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_OPENSAFETY_B : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_OPENSAFETY_B"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_OPENSAFETY_B(bool isBigEndianResult = false)
            : base(0x755b, 0x0000, 0x0000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/PROFIBUS ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x1dcf</b></para>
    /// <para><i>InitialValue </i>: <b>0xffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_PROFIBUS : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_PROFIBUS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_PROFIBUS(bool isBigEndianResult = false)
            : base(0x1dcf, 0xffff, 0xffff, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/RIELLO ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x1021</b></para>
    /// <para><i>InitialValue </i>: <b>0xb2aa</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_RIELLO : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_RIELLO"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_RIELLO(bool isBigEndianResult = false)
            : base(0x1021, 0xb2aa, 0x0000, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/SPI-FUJITSU ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x1021</b></para>
    /// <para><i>InitialValue </i>: <b>0x1d0f</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_SPI_FUJITSU : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_SPI_FUJITSU"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_SPI_FUJITSU(bool isBigEndianResult = false)
            : base(0x1021, 0x1d0f, 0x0000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/T10-DIF ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x8bb7</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_T10_DIF : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_T10_DIF"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_T10_DIF(bool isBigEndianResult = false)
            : base(0x8bb7, 0x0000, 0x0000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/TELEDISK ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0xa097</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_TELEDISK : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_TELEDISK"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_TELEDISK(bool isBigEndianResult = false)
            : base(0xa097, 0x0000, 0x0000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/TMS37157 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x1021</b></para>
    /// <para><i>InitialValue </i>: <b>0x89ec</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_TMS37157 : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_TMS37157"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_TMS37157(bool isBigEndianResult = false)
            : base(0x1021, 0x89ec, 0x0000, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/UMTS ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x8005</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_UMTS : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_UMTS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_UMTS(bool isBigEndianResult = false)
            : base(0x8005, 0x0000, 0x0000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/USB ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x8005</b></para>
    /// <para><i>InitialValue </i>: <b>0xffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xffff</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_USB : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_USB"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_USB(bool isBigEndianResult = false)
            : base(0x8005, 0xffff, 0xffff, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/XMODEM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x1021</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_XMODEM : CRC16
    {
        /// <summary>
        /// <see cref="CRC_16_XMODEM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_XMODEM(bool isBigEndianResult = false)
            : base(0x1021, 0x0000, 0x0000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-17/CAN-FD ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC17"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x1685b</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_17_CAN_FD : CRC17
    {
        /// <summary>
        /// <see cref="CRC_17_CAN_FD"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_17_CAN_FD(bool isBigEndianResult = false)
            : base(0x1685b, 0x00000, 0x00000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-21/CAN-FD ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC21"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x102899</b></para>
    /// <para><i>InitialValue </i>: <b>0x000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_21_CAN_FD : CRC21
    {
        /// <summary>
        /// <see cref="CRC_21_CAN_FD"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_21_CAN_FD(bool isBigEndianResult = false)
            : base(0x102899, 0x000000, 0x000000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-24/BLE ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC24"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x00065b</b></para>
    /// <para><i>InitialValue </i>: <b>0x555555</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_24_BLE : CRC24
    {
        /// <summary>
        /// <see cref="CRC_24_BLE"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_24_BLE(bool isBigEndianResult = false)
            : base(0x00065b, 0x555555, 0x000000, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-24/FLEXRAY-A ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC24"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x5d6dcb</b></para>
    /// <para><i>InitialValue </i>: <b>0xfedcba</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_24_FLEXRAY_A : CRC24
    {
        /// <summary>
        /// <see cref="CRC_24_FLEXRAY_A"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_24_FLEXRAY_A(bool isBigEndianResult = false)
            : base(0x5d6dcb, 0xfedcba, 0x000000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-24/FLEXRAY-B ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC24"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x5d6dcb</b></para>
    /// <para><i>InitialValue </i>: <b>0xabcdef</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_24_FLEXRAY_B : CRC24
    {
        /// <summary>
        /// <see cref="CRC_24_FLEXRAY_B"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_24_FLEXRAY_B(bool isBigEndianResult = false)
            : base(0x5d6dcb, 0xabcdef, 0x000000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-24/INTERLAKEN ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC24"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x328b63</b></para>
    /// <para><i>InitialValue </i>: <b>0xffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_24_INTERLAKEN : CRC24
    {
        /// <summary>
        /// <see cref="CRC_24_INTERLAKEN"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_24_INTERLAKEN(bool isBigEndianResult = false)
            : base(0x328b63, 0xffffff, 0xffffff, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-24/LTE-A ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC24"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x864cfb</b></para>
    /// <para><i>InitialValue </i>: <b>0x000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_24_LTE_A : CRC24
    {
        /// <summary>
        /// <see cref="CRC_24_LTE_A"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_24_LTE_A(bool isBigEndianResult = false)
            : base(0x864cfb, 0x000000, 0x000000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-24/LTE-B ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC24"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x800063</b></para>
    /// <para><i>InitialValue </i>: <b>0x000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_24_LTE_B : CRC24
    {
        /// <summary>
        /// <see cref="CRC_24_LTE_B"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_24_LTE_B(bool isBigEndianResult = false)
            : base(0x800063, 0x000000, 0x000000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-24/OPENPGP ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC24"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x864cfb</b></para>
    /// <para><i>InitialValue </i>: <b>0xb704ce</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_24_OPENPGP : CRC24
    {
        /// <summary>
        /// <see cref="CRC_24_OPENPGP"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_24_OPENPGP(bool isBigEndianResult = false)
            : base(0x864cfb, 0xb704ce, 0x000000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-24/OS-9 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC24"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x800063</b></para>
    /// <para><i>InitialValue </i>: <b>0xffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_24_OS_9 : CRC24
    {
        /// <summary>
        /// <see cref="CRC_24_OS_9"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_24_OS_9(bool isBigEndianResult = false)
            : base(0x800063, 0xffffff, 0xffffff, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-30/CDMA ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC30"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x2030b9c7</b></para>
    /// <para><i>InitialValue </i>: <b>0x3fffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x3fffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_30_CDMA : CRC30
    {
        /// <summary>
        /// <see cref="CRC_30_CDMA"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_30_CDMA(bool isBigEndianResult = false)
            : base(0x2030b9c7, 0x3fffffff, 0x3fffffff, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-31/PHILIPS ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC31"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x04c11db7</b></para>
    /// <para><i>InitialValue </i>: <b>0x7fffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x7fffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_31_PHILIPS : CRC31
    {
        /// <summary>
        /// <see cref="CRC_31_PHILIPS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_31_PHILIPS(bool isBigEndianResult = false)
            : base(0x04c11db7, 0x7fffffff, 0x7fffffff, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/AIXM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x814141ab</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_32_AIXM : CRC32
    {
        /// <summary>
        /// <see cref="CRC_32_AIXM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_AIXM(bool isBigEndianResult = false)
            : base(0x814141ab, 0x00000000, 0x00000000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/AUTOSAR ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0xf4acfb13</b></para>
    /// <para><i>InitialValue </i>: <b>0xffffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xffffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_32_AUTOSAR : CRC32
    {
        /// <summary>
        /// <see cref="CRC_32_AUTOSAR"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_AUTOSAR(bool isBigEndianResult = false)
            : base(0xf4acfb13, 0xffffffff, 0xffffffff, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/BASE91-D ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0xa833982b</b></para>
    /// <para><i>InitialValue </i>: <b>0xffffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xffffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_32_BASE91_D : CRC32
    {
        /// <summary>
        /// <see cref="CRC_32_BASE91_D"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_BASE91_D(bool isBigEndianResult = false)
            : base(0xa833982b, 0xffffffff, 0xffffffff, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/BZIP2 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x04c11db7</b></para>
    /// <para><i>InitialValue </i>: <b>0xffffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xffffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_32_BZIP2 : CRC32
    {
        /// <summary>
        /// <see cref="CRC_32_BZIP2"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_BZIP2(bool isBigEndianResult = false)
            : base(0x04c11db7, 0xffffffff, 0xffffffff, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/CD-ROM-EDC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x8001801b</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_32_CD_ROM_EDC : CRC32
    {
        /// <summary>
        /// <see cref="CRC_32_CD_ROM_EDC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_CD_ROM_EDC(bool isBigEndianResult = false)
            : base(0x8001801b, 0x00000000, 0x00000000, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/CKSUM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x04c11db7</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xffffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_32_CKSUM : CRC32
    {
        /// <summary>
        /// <see cref="CRC_32_CKSUM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_CKSUM(bool isBigEndianResult = false)
            : base(0x04c11db7, 0x00000000, 0xffffffff, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/ISCSI ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x1edc6f41</b></para>
    /// <para><i>InitialValue </i>: <b>0xffffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xffffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_32_ISCSI : CRC32
    {
        /// <summary>
        /// <see cref="CRC_32_ISCSI"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_ISCSI(bool isBigEndianResult = false)
            : base(0x1edc6f41, 0xffffffff, 0xffffffff, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/ISO-HDLC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x04c11db7</b></para>
    /// <para><i>InitialValue </i>: <b>0xffffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xffffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_32_ISO_HDLC : CRC32
    {
        /// <summary>
        /// <see cref="CRC_32_ISO_HDLC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_ISO_HDLC(bool isBigEndianResult = false)
            : base(0x04c11db7, 0xffffffff, 0xffffffff, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/JAMCRC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x04c11db7</b></para>
    /// <para><i>InitialValue </i>: <b>0xffffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_32_JAMCRC : CRC32
    {
        /// <summary>
        /// <see cref="CRC_32_JAMCRC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_JAMCRC(bool isBigEndianResult = false)
            : base(0x04c11db7, 0xffffffff, 0x00000000, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/MPEG-2 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x04c11db7</b></para>
    /// <para><i>InitialValue </i>: <b>0xffffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_32_MPEG_2 : CRC32
    {
        /// <summary>
        /// <see cref="CRC_32_MPEG_2"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_MPEG_2(bool isBigEndianResult = false)
            : base(0x04c11db7, 0xffffffff, 0x00000000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/XFER ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x000000af</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_32_XFER : CRC32
    {
        /// <summary>
        /// <see cref="CRC_32_XFER"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_XFER(bool isBigEndianResult = false)
            : base(0x000000af, 0x00000000, 0x00000000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-40/GSM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC40"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0004820009</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xffffffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_40_GSM : CRC40
    {
        /// <summary>
        /// <see cref="CRC_40_GSM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_40_GSM(bool isBigEndianResult = false)
            : base(0x0004820009, 0x0000000000, 0xffffffffff, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-64/ECMA-182 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC64"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x42f0e1eba9ea3693</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000000000000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000000000000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_64_ECMA_182 : CRC64
    {
        /// <summary>
        /// <see cref="CRC_64_ECMA_182"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_64_ECMA_182(bool isBigEndianResult = false)
            : base(0x42f0e1eba9ea3693, 0x0000000000000000, 0x0000000000000000, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-64/GO-ISO ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC64"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x000000000000001b</b></para>
    /// <para><i>InitialValue </i>: <b>0xffffffffffffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xffffffffffffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_64_GO_ISO : CRC64
    {
        /// <summary>
        /// <see cref="CRC_64_GO_ISO"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_64_GO_ISO(bool isBigEndianResult = false)
            : base(0x000000000000001b, 0xffffffffffffffff, 0xffffffffffffffff, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-64/WE ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC64"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x42f0e1eba9ea3693</b></para>
    /// <para><i>InitialValue </i>: <b>0xffffffffffffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xffffffffffffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_64_WE : CRC64
    {
        /// <summary>
        /// <see cref="CRC_64_WE"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_64_WE(bool isBigEndianResult = false)
            : base(0x42f0e1eba9ea3693, 0xffffffffffffffff, 0xffffffffffffffff, false, false, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-64/XZ ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC64"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x42f0e1eba9ea3693</b></para>
    /// <para><i>InitialValue </i>: <b>0xffffffffffffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0xffffffffffffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_64_XZ : CRC64
    {
        /// <summary>
        /// <see cref="CRC_64_XZ"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_64_XZ(bool isBigEndianResult = false)
            : base(0x42f0e1eba9ea3693, 0xffffffffffffffff, 0xffffffffffffffff, true, true, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-82/DARC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC82"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0308c0111011401440411</b></para>
    /// <para><i>InitialValue </i>: <b>0x000000000000000000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000000000000000000000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_82_DARC : CRC82
    {
        /// <summary>
        /// <see cref="CRC_82_DARC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_82_DARC(bool isBigEndianResult = false)
            : base(BigInteger.Parse("0308c0111011401440411", NumberStyles.AllowHexSpecifier), BigInteger.Parse("000000000000000000000", NumberStyles.AllowHexSpecifier), BigInteger.Parse("000000000000000000000", NumberStyles.AllowHexSpecifier), true, true, isBigEndianResult)
        {
        }
    }

}