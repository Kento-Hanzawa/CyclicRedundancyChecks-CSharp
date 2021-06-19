 
//
// CyclicRedundancyChecks
// 
// このコードはテキストテンプレートファイル (.tt) によって作成されています。
// 変更をおこなう場合は、テキストテンプレートファイル (.tt) を編集してください。
//

namespace CyclicRedundancyChecks
{
    /// <summary>
    /// 入力データの CRC16/CCITT-FALSE ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_CCITT_FALSE : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_CCITT_FALSE"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x1021, 
        ///     initialValue : 0xFFFF, 
        ///     finalXorValue: 0x0000, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC16_CCITT_FALSE() 
            : base(0x1021, 0xFFFF, 0x0000, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/ARC ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_ARC : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_ARC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x8005, 
        ///     initialValue : 0x0000, 
        ///     finalXorValue: 0x0000, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC16_ARC() 
            : base(0x8005, 0x0000, 0x0000, true, true)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/AUG-CCITT ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_AUG_CCITT : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_AUG_CCITT"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x1021, 
        ///     initialValue : 0x1D0F, 
        ///     finalXorValue: 0x0000, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC16_AUG_CCITT() 
            : base(0x1021, 0x1D0F, 0x0000, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/BUYPASS ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_BUYPASS : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_BUYPASS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x8005, 
        ///     initialValue : 0x0000, 
        ///     finalXorValue: 0x0000, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC16_BUYPASS() 
            : base(0x8005, 0x0000, 0x0000, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/CDMA2000 ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_CDMA2000 : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_CDMA2000"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0xC867, 
        ///     initialValue : 0xFFFF, 
        ///     finalXorValue: 0x0000, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC16_CDMA2000() 
            : base(0xC867, 0xFFFF, 0x0000, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/DDS-110 ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_DDS_110 : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_DDS_110"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x8005, 
        ///     initialValue : 0x800D, 
        ///     finalXorValue: 0x0000, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC16_DDS_110() 
            : base(0x8005, 0x800D, 0x0000, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/DECT-R ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_DECT_R : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_DECT_R"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x0589, 
        ///     initialValue : 0x0000, 
        ///     finalXorValue: 0x0001, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC16_DECT_R() 
            : base(0x0589, 0x0000, 0x0001, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/DECT-X ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_DECT_X : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_DECT_X"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x0589, 
        ///     initialValue : 0x0000, 
        ///     finalXorValue: 0x0000, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC16_DECT_X() 
            : base(0x0589, 0x0000, 0x0000, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/DNP ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_DNP : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_DNP"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x3D65, 
        ///     initialValue : 0x0000, 
        ///     finalXorValue: 0xFFFF, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC16_DNP() 
            : base(0x3D65, 0x0000, 0xFFFF, true, true)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/EN-13757 ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_EN_13757 : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_EN_13757"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x3D65, 
        ///     initialValue : 0x0000, 
        ///     finalXorValue: 0xFFFF, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC16_EN_13757() 
            : base(0x3D65, 0x0000, 0xFFFF, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/GENIBUS ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_GENIBUS : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_GENIBUS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x1021, 
        ///     initialValue : 0xFFFF, 
        ///     finalXorValue: 0xFFFF, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC16_GENIBUS() 
            : base(0x1021, 0xFFFF, 0xFFFF, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/MAXIM ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_MAXIM : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_MAXIM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x8005, 
        ///     initialValue : 0x0000, 
        ///     finalXorValue: 0xFFFF, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC16_MAXIM() 
            : base(0x8005, 0x0000, 0xFFFF, true, true)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/MCRF4XX ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_MCRF4XX : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_MCRF4XX"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x1021, 
        ///     initialValue : 0xFFFF, 
        ///     finalXorValue: 0x0000, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC16_MCRF4XX() 
            : base(0x1021, 0xFFFF, 0x0000, true, true)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/RIELLO ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_RIELLO : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_RIELLO"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x1021, 
        ///     initialValue : 0xB2AA, 
        ///     finalXorValue: 0x0000, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC16_RIELLO() 
            : base(0x1021, 0xB2AA, 0x0000, true, true)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/T10-DIF ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_T10_DIF : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_T10_DIF"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x8BB7, 
        ///     initialValue : 0x0000, 
        ///     finalXorValue: 0x0000, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC16_T10_DIF() 
            : base(0x8BB7, 0x0000, 0x0000, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/TELEDISK ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_TELEDISK : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_TELEDISK"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0xA097, 
        ///     initialValue : 0x0000, 
        ///     finalXorValue: 0x0000, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC16_TELEDISK() 
            : base(0xA097, 0x0000, 0x0000, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/TMS37157 ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_TMS37157 : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_TMS37157"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x1021, 
        ///     initialValue : 0x89EC, 
        ///     finalXorValue: 0x0000, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC16_TMS37157() 
            : base(0x1021, 0x89EC, 0x0000, true, true)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/USB ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_USB : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_USB"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x8005, 
        ///     initialValue : 0xFFFF, 
        ///     finalXorValue: 0xFFFF, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC16_USB() 
            : base(0x8005, 0xFFFF, 0xFFFF, true, true)
        {
        }
    }

    /// <summary>
    /// 入力データの CRCA ハッシュを計算します。
    /// </summary>
    public sealed class CRC_A : CRC16
    {
        /// <summary>
        /// <see cref="CRC_A"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x1021, 
        ///     initialValue : 0xC6C6, 
        ///     finalXorValue: 0x0000, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC_A() 
            : base(0x1021, 0xC6C6, 0x0000, true, true)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/KERMIT ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_KERMIT : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_KERMIT"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x1021, 
        ///     initialValue : 0x0000, 
        ///     finalXorValue: 0x0000, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC16_KERMIT() 
            : base(0x1021, 0x0000, 0x0000, true, true)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/MODBUS ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_MODBUS : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_MODBUS"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x8005, 
        ///     initialValue : 0xFFFF, 
        ///     finalXorValue: 0x0000, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC16_MODBUS() 
            : base(0x8005, 0xFFFF, 0x0000, true, true)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/X-25 ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_X_25 : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_X_25"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x1021, 
        ///     initialValue : 0xFFFF, 
        ///     finalXorValue: 0xFFFF, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC16_X_25() 
            : base(0x1021, 0xFFFF, 0xFFFF, true, true)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC16/XMODEM ハッシュを計算します。
    /// </summary>
    public sealed class CRC16_XMODEM : CRC16
    {
        /// <summary>
        /// <see cref="CRC16_XMODEM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC16" />
        /// (
        ///     polynomial   : 0x1021, 
        ///     initialValue : 0x0000, 
        ///     finalXorValue: 0x0000, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC16_XMODEM() 
            : base(0x1021, 0x0000, 0x0000, false, false)
        {
        }
    }

}