//
// CyclicRedundancyChecks
// 
// このコードはテキストテンプレートファイル (.tt) によって作成されています。
// 変更をおこなう場合は、テキストテンプレートファイル (.tt) を編集してください。
//

using System;
using System.Globalization;
using System.Numerics;

namespace CyclicRedundancyChecks
{
    /// <summary>
    /// <para>入力データの CRC-3/GSM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC3"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x03</b></para>
    /// <para><i>InitialValue </i>: <b>0x00</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x07</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_3_GSM : CRC3
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_3_GSM()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 3, 0x03);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_3_GSM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_3_GSM(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x03, 0x00, 0x07, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-3/ROHC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC3"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x03</b></para>
    /// <para><i>InitialValue </i>: <b>0x07</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_3_ROHC : CRC3
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_3_ROHC()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 3, 0x03);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_3_ROHC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_3_ROHC(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x03, 0x07, 0x00, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-4/G-704 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC4"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x03</b></para>
    /// <para><i>InitialValue </i>: <b>0x00</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_4_G_704 : CRC4
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_4_G_704()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 4, 0x03);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_4_G_704"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_4_G_704(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x03, 0x00, 0x00, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-4/INTERLAKEN ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC4"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x03</b></para>
    /// <para><i>InitialValue </i>: <b>0x0f</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0f</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_4_INTERLAKEN : CRC4
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_4_INTERLAKEN()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 4, 0x03);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_4_INTERLAKEN"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_4_INTERLAKEN(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x03, 0x0f, 0x0f, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-5/EPC-C1G2 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC5"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x009</b></para>
    /// <para><i>InitialValue </i>: <b>0x009</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_5_EPC_C1G2 : CRC5
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_5_EPC_C1G2()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 5, 0x009);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_5_EPC_C1G2"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_5_EPC_C1G2(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x009, 0x009, 0x000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-5/G-704 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC5"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x015</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_5_G_704 : CRC5
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_5_G_704()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 5, 0x015);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_5_G_704"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_5_G_704(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x015, 0x000, 0x000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-5/USB ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC5"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x005</b></para>
    /// <para><i>InitialValue </i>: <b>0x01f</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x01f</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_5_USB : CRC5
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_5_USB()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 5, 0x005);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_5_USB"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_5_USB(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x005, 0x01f, 0x01f, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-6/CDMA2000-A ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC6"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x027</b></para>
    /// <para><i>InitialValue </i>: <b>0x03f</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_6_CDMA2000_A : CRC6
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_6_CDMA2000_A()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 6, 0x027);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_6_CDMA2000_A"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_6_CDMA2000_A(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x027, 0x03f, 0x000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-6/CDMA2000-B ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC6"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x007</b></para>
    /// <para><i>InitialValue </i>: <b>0x03f</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_6_CDMA2000_B : CRC6
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_6_CDMA2000_B()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 6, 0x007);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_6_CDMA2000_B"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_6_CDMA2000_B(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x007, 0x03f, 0x000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-6/DARC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC6"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x019</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_6_DARC : CRC6
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_6_DARC()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 6, 0x019);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_6_DARC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_6_DARC(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x019, 0x000, 0x000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-6/G-704 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC6"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x003</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_6_G_704 : CRC6
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_6_G_704()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 6, 0x003);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_6_G_704"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_6_G_704(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x003, 0x000, 0x000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-6/GSM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC6"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x02f</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x03f</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_6_GSM : CRC6
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_6_GSM()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 6, 0x02f);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_6_GSM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_6_GSM(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x02f, 0x000, 0x03f, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-7/MMC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC7"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x009</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_7_MMC : CRC7
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_7_MMC()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 7, 0x009);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_7_MMC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_7_MMC(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x009, 0x000, 0x000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-7/ROHC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC7"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x04f</b></para>
    /// <para><i>InitialValue </i>: <b>0x07f</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_7_ROHC : CRC7
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_7_ROHC()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 7, 0x04f);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_7_ROHC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_7_ROHC(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x04f, 0x07f, 0x000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-7/UMTS ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC7"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x045</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_7_UMTS : CRC7
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_7_UMTS()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 7, 0x045);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_7_UMTS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_7_UMTS(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x045, 0x000, 0x000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/AUTOSAR ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x02f</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_AUTOSAR : CRC8
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_8_AUTOSAR()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 8, 0x02f);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_8_AUTOSAR"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_AUTOSAR(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x02f, 0x0ff, 0x0ff, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/BLUETOOTH ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0a7</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_8_BLUETOOTH : CRC8
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_8_BLUETOOTH()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 8, 0x0a7);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_8_BLUETOOTH"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_BLUETOOTH(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0a7, 0x000, 0x000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/CDMA2000 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x09b</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_CDMA2000 : CRC8
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_8_CDMA2000()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 8, 0x09b);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_8_CDMA2000"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_CDMA2000(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x09b, 0x0ff, 0x000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/DARC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x039</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_8_DARC : CRC8
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_8_DARC()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 8, 0x039);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_8_DARC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_DARC(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x039, 0x000, 0x000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/DVB-S2 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0d5</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_DVB_S2 : CRC8
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_8_DVB_S2()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 8, 0x0d5);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_8_DVB_S2"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_DVB_S2(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0d5, 0x000, 0x000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/GSM-A ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x01d</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_GSM_A : CRC8
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_8_GSM_A()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 8, 0x01d);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_8_GSM_A"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_GSM_A(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x01d, 0x000, 0x000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/GSM-B ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x049</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_GSM_B : CRC8
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_8_GSM_B()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 8, 0x049);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_8_GSM_B"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_GSM_B(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x049, 0x000, 0x0ff, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/I-432-1 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x007</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x055</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_I_432_1 : CRC8
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_8_I_432_1()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 8, 0x007);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_8_I_432_1"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_I_432_1(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x007, 0x000, 0x055, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/I-CODE ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x01d</b></para>
    /// <para><i>InitialValue </i>: <b>0x0fd</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_I_CODE : CRC8
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_8_I_CODE()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 8, 0x01d);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_8_I_CODE"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_I_CODE(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x01d, 0x0fd, 0x000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/LTE ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x09b</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_LTE : CRC8
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_8_LTE()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 8, 0x09b);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_8_LTE"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_LTE(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x09b, 0x000, 0x000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/MAXIM-DOW ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x031</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_8_MAXIM_DOW : CRC8
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_8_MAXIM_DOW()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 8, 0x031);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_8_MAXIM_DOW"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_MAXIM_DOW(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x031, 0x000, 0x000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/MIFARE-MAD ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x01d</b></para>
    /// <para><i>InitialValue </i>: <b>0x0c7</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_MIFARE_MAD : CRC8
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_8_MIFARE_MAD()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 8, 0x01d);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_8_MIFARE_MAD"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_MIFARE_MAD(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x01d, 0x0c7, 0x000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/NRSC-5 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x031</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_NRSC_5 : CRC8
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_8_NRSC_5()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 8, 0x031);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_8_NRSC_5"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_NRSC_5(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x031, 0x0ff, 0x000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/OPENSAFETY ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x02f</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_OPENSAFETY : CRC8
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_8_OPENSAFETY()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 8, 0x02f);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_8_OPENSAFETY"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_OPENSAFETY(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x02f, 0x000, 0x000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/ROHC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x007</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_8_ROHC : CRC8
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_8_ROHC()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 8, 0x007);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_8_ROHC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_ROHC(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x007, 0x0ff, 0x000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/SAE-J1850 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x01d</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_SAE_J1850 : CRC8
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_8_SAE_J1850()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 8, 0x01d);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_8_SAE_J1850"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_SAE_J1850(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x01d, 0x0ff, 0x0ff, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/SMBUS ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x007</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_8_SMBUS : CRC8
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_8_SMBUS()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 8, 0x007);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_8_SMBUS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_SMBUS(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x007, 0x000, 0x000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/TECH-3250 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x01d</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_8_TECH_3250 : CRC8
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_8_TECH_3250()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 8, 0x01d);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_8_TECH_3250"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_TECH_3250(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x01d, 0x0ff, 0x000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-8/WCDMA ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC8"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x09b</b></para>
    /// <para><i>InitialValue </i>: <b>0x000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_8_WCDMA : CRC8
    {
        private static readonly global::System.Byte[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Byte> LookupTable { get { return LookupTableBuffer; } }

        static CRC_8_WCDMA()
        {
            Span<global::System.Byte> table = stackalloc global::System.Byte[LookupTableSize];
            LookupTableFill(table, 8, 0x09b);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_8_WCDMA"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_8_WCDMA(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x09b, 0x000, 0x000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-10/ATM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC10"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0233</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_10_ATM : CRC10
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_10_ATM()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 10, 0x0233);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_10_ATM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_10_ATM(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0233, 0x0000, 0x0000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-10/CDMA2000 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC10"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x03d9</b></para>
    /// <para><i>InitialValue </i>: <b>0x03ff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_10_CDMA2000 : CRC10
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_10_CDMA2000()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 10, 0x03d9);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_10_CDMA2000"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_10_CDMA2000(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x03d9, 0x03ff, 0x0000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-10/GSM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC10"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0175</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x03ff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_10_GSM : CRC10
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_10_GSM()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 10, 0x0175);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_10_GSM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_10_GSM(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0175, 0x0000, 0x03ff, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-11/FLEXRAY ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC11"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0385</b></para>
    /// <para><i>InitialValue </i>: <b>0x001a</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_11_FLEXRAY : CRC11
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_11_FLEXRAY()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 11, 0x0385);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_11_FLEXRAY"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_11_FLEXRAY(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0385, 0x001a, 0x0000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-11/UMTS ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC11"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0307</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_11_UMTS : CRC11
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_11_UMTS()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 11, 0x0307);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_11_UMTS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_11_UMTS(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0307, 0x0000, 0x0000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-12/CDMA2000 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC12"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0f13</b></para>
    /// <para><i>InitialValue </i>: <b>0x0fff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_12_CDMA2000 : CRC12
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_12_CDMA2000()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 12, 0x0f13);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_12_CDMA2000"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_12_CDMA2000(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0f13, 0x0fff, 0x0000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-12/DECT ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC12"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x080f</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_12_DECT : CRC12
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_12_DECT()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 12, 0x080f);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_12_DECT"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_12_DECT(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x080f, 0x0000, 0x0000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-12/GSM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC12"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0d31</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0fff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_12_GSM : CRC12
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_12_GSM()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 12, 0x0d31);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_12_GSM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_12_GSM(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0d31, 0x0000, 0x0fff, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-12/UMTS ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC12"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x080f</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_12_UMTS : CRC12
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_12_UMTS()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 12, 0x080f);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_12_UMTS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_12_UMTS(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x080f, 0x0000, 0x0000, false, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-13/BBC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC13"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x01cf5</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_13_BBC : CRC13
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_13_BBC()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 13, 0x01cf5);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_13_BBC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_13_BBC(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x01cf5, 0x00000, 0x00000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-14/DARC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC14"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x00805</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_14_DARC : CRC14
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_14_DARC()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 14, 0x00805);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_14_DARC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_14_DARC(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x00805, 0x00000, 0x00000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-14/GSM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC14"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0202d</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x03fff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_14_GSM : CRC14
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_14_GSM()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 14, 0x0202d);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_14_GSM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_14_GSM(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0202d, 0x00000, 0x03fff, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-15/CAN ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC15"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x04599</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_15_CAN : CRC15
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_15_CAN()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 15, 0x04599);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_15_CAN"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_15_CAN(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x04599, 0x00000, 0x00000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-15/MPT1327 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC15"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x06815</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00001</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_15_MPT1327 : CRC15
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_15_MPT1327()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 15, 0x06815);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_15_MPT1327"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_15_MPT1327(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x06815, 0x00000, 0x00001, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/ARC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x08005</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_ARC : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_ARC()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x08005);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_ARC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_ARC(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x08005, 0x00000, 0x00000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/CDMA2000 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0c867</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_CDMA2000 : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_CDMA2000()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x0c867);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_CDMA2000"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_CDMA2000(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0c867, 0x0ffff, 0x00000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/CMS ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x08005</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_CMS : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_CMS()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x08005);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_CMS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_CMS(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x08005, 0x0ffff, 0x00000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/DDS-110 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x08005</b></para>
    /// <para><i>InitialValue </i>: <b>0x0800d</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_DDS_110 : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_DDS_110()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x08005);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_DDS_110"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_DDS_110(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x08005, 0x0800d, 0x00000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/DECT-R ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x00589</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00001</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_DECT_R : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_DECT_R()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x00589);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_DECT_R"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_DECT_R(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x00589, 0x00000, 0x00001, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/DECT-X ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x00589</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_DECT_X : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_DECT_X()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x00589);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_DECT_X"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_DECT_X(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x00589, 0x00000, 0x00000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/DNP ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x03d65</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ffff</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_DNP : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_DNP()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x03d65);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_DNP"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_DNP(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x03d65, 0x00000, 0x0ffff, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/EN-13757 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x03d65</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_EN_13757 : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_EN_13757()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x03d65);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_EN_13757"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_EN_13757(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x03d65, 0x00000, 0x0ffff, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/GENIBUS ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x01021</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_GENIBUS : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_GENIBUS()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x01021);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_GENIBUS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_GENIBUS(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x01021, 0x0ffff, 0x0ffff, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/GSM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x01021</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_GSM : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_GSM()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x01021);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_GSM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_GSM(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x01021, 0x00000, 0x0ffff, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/IBM-3740 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x01021</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_IBM_3740 : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_IBM_3740()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x01021);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_IBM_3740"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_IBM_3740(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x01021, 0x0ffff, 0x00000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/IBM-SDLC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x01021</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ffff</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_IBM_SDLC : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_IBM_SDLC()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x01021);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_IBM_SDLC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_IBM_SDLC(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x01021, 0x0ffff, 0x0ffff, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/ISO-IEC-14443-3-A ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x01021</b></para>
    /// <para><i>InitialValue </i>: <b>0x0c6c6</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_ISO_IEC_14443_3_A : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_ISO_IEC_14443_3_A()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x01021);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_ISO_IEC_14443_3_A"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_ISO_IEC_14443_3_A(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x01021, 0x0c6c6, 0x00000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/KERMIT ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x01021</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_KERMIT : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_KERMIT()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x01021);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_KERMIT"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_KERMIT(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x01021, 0x00000, 0x00000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/LJ1200 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x06f63</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_LJ1200 : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_LJ1200()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x06f63);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_LJ1200"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_LJ1200(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x06f63, 0x00000, 0x00000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/MAXIM-DOW ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x08005</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ffff</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_MAXIM_DOW : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_MAXIM_DOW()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x08005);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_MAXIM_DOW"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_MAXIM_DOW(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x08005, 0x00000, 0x0ffff, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/MCRF4XX ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x01021</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_MCRF4XX : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_MCRF4XX()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x01021);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_MCRF4XX"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_MCRF4XX(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x01021, 0x0ffff, 0x00000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/MODBUS ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x08005</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_MODBUS : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_MODBUS()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x08005);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_MODBUS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_MODBUS(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x08005, 0x0ffff, 0x00000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/NRSC-5 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0080b</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_NRSC_5 : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_NRSC_5()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x0080b);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_NRSC_5"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_NRSC_5(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0080b, 0x0ffff, 0x00000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/OPENSAFETY-A ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x05935</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_OPENSAFETY_A : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_OPENSAFETY_A()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x05935);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_OPENSAFETY_A"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_OPENSAFETY_A(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x05935, 0x00000, 0x00000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/OPENSAFETY-B ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0755b</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_OPENSAFETY_B : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_OPENSAFETY_B()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x0755b);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_OPENSAFETY_B"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_OPENSAFETY_B(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0755b, 0x00000, 0x00000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/PROFIBUS ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x01dcf</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_PROFIBUS : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_PROFIBUS()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x01dcf);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_PROFIBUS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_PROFIBUS(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x01dcf, 0x0ffff, 0x0ffff, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/RIELLO ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x01021</b></para>
    /// <para><i>InitialValue </i>: <b>0x0b2aa</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_RIELLO : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_RIELLO()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x01021);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_RIELLO"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_RIELLO(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x01021, 0x0b2aa, 0x00000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/SPI-FUJITSU ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x01021</b></para>
    /// <para><i>InitialValue </i>: <b>0x01d0f</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_SPI_FUJITSU : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_SPI_FUJITSU()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x01021);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_SPI_FUJITSU"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_SPI_FUJITSU(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x01021, 0x01d0f, 0x00000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/T10-DIF ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x08bb7</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_T10_DIF : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_T10_DIF()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x08bb7);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_T10_DIF"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_T10_DIF(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x08bb7, 0x00000, 0x00000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/TELEDISK ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0a097</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_TELEDISK : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_TELEDISK()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x0a097);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_TELEDISK"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_TELEDISK(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0a097, 0x00000, 0x00000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/TMS37157 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x01021</b></para>
    /// <para><i>InitialValue </i>: <b>0x089ec</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_TMS37157 : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_TMS37157()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x01021);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_TMS37157"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_TMS37157(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x01021, 0x089ec, 0x00000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/UMTS ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x08005</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_UMTS : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_UMTS()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x08005);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_UMTS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_UMTS(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x08005, 0x00000, 0x00000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/USB ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x08005</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ffff</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_16_USB : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_USB()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x08005);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_USB"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_USB(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x08005, 0x0ffff, 0x0ffff, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-16/XMODEM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC16"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x01021</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_16_XMODEM : CRC16
    {
        private static readonly global::System.UInt16[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt16> LookupTable { get { return LookupTableBuffer; } }

        static CRC_16_XMODEM()
        {
            Span<global::System.UInt16> table = stackalloc global::System.UInt16[LookupTableSize];
            LookupTableFill(table, 16, 0x01021);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_16_XMODEM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_16_XMODEM(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x01021, 0x00000, 0x00000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-17/CAN-FD ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC17"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x01685b</b></para>
    /// <para><i>InitialValue </i>: <b>0x000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_17_CAN_FD : CRC17
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_17_CAN_FD()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 17, 0x01685b);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_17_CAN_FD"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_17_CAN_FD(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x01685b, 0x000000, 0x000000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-21/CAN-FD ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC21"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0102899</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_21_CAN_FD : CRC21
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_21_CAN_FD()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 21, 0x0102899);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_21_CAN_FD"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_21_CAN_FD(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0102899, 0x0000000, 0x0000000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-24/BLE ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC24"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x000065b</b></para>
    /// <para><i>InitialValue </i>: <b>0x0555555</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_24_BLE : CRC24
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_24_BLE()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 24, 0x000065b);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_24_BLE"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_24_BLE(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x000065b, 0x0555555, 0x0000000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-24/FLEXRAY-A ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC24"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x05d6dcb</b></para>
    /// <para><i>InitialValue </i>: <b>0x0fedcba</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_24_FLEXRAY_A : CRC24
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_24_FLEXRAY_A()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 24, 0x05d6dcb);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_24_FLEXRAY_A"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_24_FLEXRAY_A(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x05d6dcb, 0x0fedcba, 0x0000000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-24/FLEXRAY-B ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC24"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x05d6dcb</b></para>
    /// <para><i>InitialValue </i>: <b>0x0abcdef</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_24_FLEXRAY_B : CRC24
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_24_FLEXRAY_B()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 24, 0x05d6dcb);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_24_FLEXRAY_B"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_24_FLEXRAY_B(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x05d6dcb, 0x0abcdef, 0x0000000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-24/INTERLAKEN ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC24"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0328b63</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_24_INTERLAKEN : CRC24
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_24_INTERLAKEN()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 24, 0x0328b63);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_24_INTERLAKEN"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_24_INTERLAKEN(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0328b63, 0x0ffffff, 0x0ffffff, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-24/LTE-A ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC24"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0864cfb</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_24_LTE_A : CRC24
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_24_LTE_A()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 24, 0x0864cfb);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_24_LTE_A"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_24_LTE_A(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0864cfb, 0x0000000, 0x0000000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-24/LTE-B ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC24"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0800063</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_24_LTE_B : CRC24
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_24_LTE_B()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 24, 0x0800063);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_24_LTE_B"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_24_LTE_B(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0800063, 0x0000000, 0x0000000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-24/OPENPGP ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC24"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0864cfb</b></para>
    /// <para><i>InitialValue </i>: <b>0x0b704ce</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_24_OPENPGP : CRC24
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_24_OPENPGP()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 24, 0x0864cfb);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_24_OPENPGP"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_24_OPENPGP(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0864cfb, 0x0b704ce, 0x0000000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-24/OS-9 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC24"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0800063</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_24_OS_9 : CRC24
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_24_OS_9()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 24, 0x0800063);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_24_OS_9"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_24_OS_9(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0800063, 0x0ffffff, 0x0ffffff, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-30/CDMA ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC30"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x02030b9c7</b></para>
    /// <para><i>InitialValue </i>: <b>0x03fffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x03fffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_30_CDMA : CRC30
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_30_CDMA()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 30, 0x02030b9c7);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_30_CDMA"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_30_CDMA(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x02030b9c7, 0x03fffffff, 0x03fffffff, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-31/PHILIPS ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC31"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x004c11db7</b></para>
    /// <para><i>InitialValue </i>: <b>0x07fffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x07fffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_31_PHILIPS : CRC31
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_31_PHILIPS()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 31, 0x004c11db7);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_31_PHILIPS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_31_PHILIPS(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x004c11db7, 0x07fffffff, 0x07fffffff, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/AIXM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0814141ab</b></para>
    /// <para><i>InitialValue </i>: <b>0x000000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_32_AIXM : CRC32
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_32_AIXM()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 32, 0x0814141ab);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_32_AIXM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_AIXM(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0814141ab, 0x000000000, 0x000000000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/AUTOSAR ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0f4acfb13</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ffffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_32_AUTOSAR : CRC32
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_32_AUTOSAR()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 32, 0x0f4acfb13);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_32_AUTOSAR"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_AUTOSAR(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0f4acfb13, 0x0ffffffff, 0x0ffffffff, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/BASE91-D ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0a833982b</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ffffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_32_BASE91_D : CRC32
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_32_BASE91_D()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 32, 0x0a833982b);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_32_BASE91_D"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_BASE91_D(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0a833982b, 0x0ffffffff, 0x0ffffffff, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/BZIP2 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x004c11db7</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ffffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_32_BZIP2 : CRC32
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_32_BZIP2()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 32, 0x004c11db7);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_32_BZIP2"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_BZIP2(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x004c11db7, 0x0ffffffff, 0x0ffffffff, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/CD-ROM-EDC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x08001801b</b></para>
    /// <para><i>InitialValue </i>: <b>0x000000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000000000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_32_CD_ROM_EDC : CRC32
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_32_CD_ROM_EDC()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 32, 0x08001801b);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_32_CD_ROM_EDC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_CD_ROM_EDC(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x08001801b, 0x000000000, 0x000000000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/CKSUM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x004c11db7</b></para>
    /// <para><i>InitialValue </i>: <b>0x000000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ffffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_32_CKSUM : CRC32
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_32_CKSUM()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 32, 0x004c11db7);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_32_CKSUM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_CKSUM(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x004c11db7, 0x000000000, 0x0ffffffff, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/ISCSI ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x01edc6f41</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ffffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_32_ISCSI : CRC32
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_32_ISCSI()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 32, 0x01edc6f41);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_32_ISCSI"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_ISCSI(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x01edc6f41, 0x0ffffffff, 0x0ffffffff, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/ISO-HDLC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x004c11db7</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ffffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_32_ISO_HDLC : CRC32
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_32_ISO_HDLC()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 32, 0x004c11db7);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_32_ISO_HDLC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_ISO_HDLC(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x004c11db7, 0x0ffffffff, 0x0ffffffff, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/JAMCRC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x004c11db7</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000000000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_32_JAMCRC : CRC32
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_32_JAMCRC()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 32, 0x004c11db7);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_32_JAMCRC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_JAMCRC(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x004c11db7, 0x0ffffffff, 0x000000000, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/MPEG-2 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x004c11db7</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_32_MPEG_2 : CRC32
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_32_MPEG_2()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 32, 0x004c11db7);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_32_MPEG_2"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_MPEG_2(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x004c11db7, 0x0ffffffff, 0x000000000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-32/XFER ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC32"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0000000af</b></para>
    /// <para><i>InitialValue </i>: <b>0x000000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x000000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_32_XFER : CRC32
    {
        private static readonly global::System.UInt32[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt32> LookupTable { get { return LookupTableBuffer; } }

        static CRC_32_XFER()
        {
            Span<global::System.UInt32> table = stackalloc global::System.UInt32[LookupTableSize];
            LookupTableFill(table, 32, 0x0000000af);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_32_XFER"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_32_XFER(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0000000af, 0x000000000, 0x000000000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-40/GSM ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC40"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x00004820009</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ffffffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_40_GSM : CRC40
    {
        private static readonly global::System.UInt64[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt64> LookupTable { get { return LookupTableBuffer; } }

        static CRC_40_GSM()
        {
            Span<global::System.UInt64> table = stackalloc global::System.UInt64[LookupTableSize];
            LookupTableFill(table, 40, 0x00004820009);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_40_GSM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_40_GSM(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x00004820009, 0x00000000000, 0x0ffffffffff, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-64/ECMA-182 ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC64"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x042f0e1eba9ea3693</b></para>
    /// <para><i>InitialValue </i>: <b>0x00000000000000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x00000000000000000</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_64_ECMA_182 : CRC64
    {
        private static readonly global::System.UInt64[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt64> LookupTable { get { return LookupTableBuffer; } }

        static CRC_64_ECMA_182()
        {
            Span<global::System.UInt64> table = stackalloc global::System.UInt64[LookupTableSize];
            LookupTableFill(table, 64, 0x042f0e1eba9ea3693);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_64_ECMA_182"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_64_ECMA_182(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x042f0e1eba9ea3693, 0x00000000000000000, 0x00000000000000000, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-64/GO-ISO ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC64"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x0000000000000001b</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffffffffffffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ffffffffffffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_64_GO_ISO : CRC64
    {
        private static readonly global::System.UInt64[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt64> LookupTable { get { return LookupTableBuffer; } }

        static CRC_64_GO_ISO()
        {
            Span<global::System.UInt64> table = stackalloc global::System.UInt64[LookupTableSize];
            LookupTableFill(table, 64, 0x0000000000000001b);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_64_GO_ISO"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_64_GO_ISO(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x0000000000000001b, 0x0ffffffffffffffff, 0x0ffffffffffffffff, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-64/WE ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC64"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x042f0e1eba9ea3693</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffffffffffffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ffffffffffffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>false</b></para>
    /// <para><i>ReflectOutput</i>: <b>false</b></para>
    /// </remarks>
    public sealed class CRC_64_WE : CRC64
    {
        private static readonly global::System.UInt64[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt64> LookupTable { get { return LookupTableBuffer; } }

        static CRC_64_WE()
        {
            Span<global::System.UInt64> table = stackalloc global::System.UInt64[LookupTableSize];
            LookupTableFill(table, 64, 0x042f0e1eba9ea3693);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_64_WE"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_64_WE(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x042f0e1eba9ea3693, 0x0ffffffffffffffff, 0x0ffffffffffffffff, false, false, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-64/XZ ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC64"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x042f0e1eba9ea3693</b></para>
    /// <para><i>InitialValue </i>: <b>0x0ffffffffffffffff</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0ffffffffffffffff</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_64_XZ : CRC64
    {
        private static readonly global::System.UInt64[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.UInt64> LookupTable { get { return LookupTableBuffer; } }

        static CRC_64_XZ()
        {
            Span<global::System.UInt64> table = stackalloc global::System.UInt64[LookupTableSize];
            LookupTableFill(table, 64, 0x042f0e1eba9ea3693);
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_64_XZ"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_64_XZ(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(0x042f0e1eba9ea3693, 0x0ffffffffffffffff, 0x0ffffffffffffffff, true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// <para>入力データの CRC-82/DARC ハッシュを計算します。</para>
    /// </summary>
    /// <remarks>
    /// <para>このアルゴリズムは <see cref="CRC82"/> に基づいており、以下のパラメータが割り当てられています。</para>
    /// <para><i>Polynomial   </i>: <b>0x00308c0111011401440411</b></para>
    /// <para><i>InitialValue </i>: <b>0x0000000000000000000000</b></para>
    /// <para><i>FinalXorValue</i>: <b>0x0000000000000000000000</b></para>
    /// <para><i>ReflectInput </i>: <b>true</b></para>
    /// <para><i>ReflectOutput</i>: <b>true</b></para>
    /// </remarks>
    public sealed class CRC_82_DARC : CRC82
    {
        private static readonly global::System.Numerics.BigInteger[] LookupTableBuffer;
        public override ReadOnlySpan<global::System.Numerics.BigInteger> LookupTable { get { return LookupTableBuffer; } }

        static CRC_82_DARC()
        {
            Span<global::System.Numerics.BigInteger> table = new global::System.Numerics.BigInteger[LookupTableSize];
            LookupTableFill(table, 82, BigInteger.Parse("00308c0111011401440411", NumberStyles.AllowHexSpecifier));
            LookupTableBuffer = table.ToArray();
        }

        /// <summary>
        /// <see cref="CRC_82_DARC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="isLookupTable">
        /// 計算用テーブルを使用する場合は <see langword="true"/>、使用しない場合は <see langword="false"/> を指定します。
        /// 使用する場合、事前に全 Byte ビットパターン (255) の計算テーブルを生成し、CRC 計算時の手順をいくつかスキップすることでパフォーマンスが向上する場合があります。
        /// しかし、テーブル生成にはコストが発生するので、インプットデータサイズが合計 255 バイト以下の場合は、テーブルを使用しない方がパフォーマンスが向上する可能性が高くなります。
        /// </param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC_82_DARC(bool isLookupTable = true, bool isBigEndianResult = false)
            : base(BigInteger.Parse("00308c0111011401440411", NumberStyles.AllowHexSpecifier), BigInteger.Parse("0000000000000000000000", NumberStyles.AllowHexSpecifier), BigInteger.Parse("0000000000000000000000", NumberStyles.AllowHexSpecifier), true, true, isLookupTable, isBigEndianResult)
        {
        }
    }

}