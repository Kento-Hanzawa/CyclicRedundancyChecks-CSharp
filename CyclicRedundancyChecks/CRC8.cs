//
// CyclicRedundancyChecks
// 
// このコードはテキストテンプレートファイル (.tt) によって作成されています。
// 変更をおこなう場合は、テキストテンプレートファイル (.tt) を編集してください。
//

namespace CyclicRedundancyChecks
{
    /// <summary>
    /// 入力データの CRC8 ハッシュを計算します。
    /// </summary>
    public sealed class CRC8_STANDARD : CRC8
    {
        /// <summary>
        /// <see cref="CRC8_STANDARD"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC8" />
        /// (
        ///     polynomial   : 0x07, 
        ///     initialValue : 0x00, 
        ///     finalXorValue: 0x00, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC8_STANDARD() 
            : base(0x07, 0x00, 0x00, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC8/CDMA2000 ハッシュを計算します。
    /// </summary>
    public sealed class CRC8_CDMA2000 : CRC8
    {
        /// <summary>
        /// <see cref="CRC8_CDMA2000"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC8" />
        /// (
        ///     polynomial   : 0x9B, 
        ///     initialValue : 0xFF, 
        ///     finalXorValue: 0x00, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC8_CDMA2000() 
            : base(0x9B, 0xFF, 0x00, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC8/DARC ハッシュを計算します。
    /// </summary>
    public sealed class CRC8_DARC : CRC8
    {
        /// <summary>
        /// <see cref="CRC8_DARC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC8" />
        /// (
        ///     polynomial   : 0x39, 
        ///     initialValue : 0x00, 
        ///     finalXorValue: 0x00, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC8_DARC() 
            : base(0x39, 0x00, 0x00, true, true)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC8/DVB-S2 ハッシュを計算します。
    /// </summary>
    public sealed class CRC8_DVB_S2 : CRC8
    {
        /// <summary>
        /// <see cref="CRC8_DVB_S2"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC8" />
        /// (
        ///     polynomial   : 0xD5, 
        ///     initialValue : 0x00, 
        ///     finalXorValue: 0x00, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC8_DVB_S2() 
            : base(0xD5, 0x00, 0x00, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC8/EBU ハッシュを計算します。
    /// </summary>
    public sealed class CRC8_EBU : CRC8
    {
        /// <summary>
        /// <see cref="CRC8_EBU"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC8" />
        /// (
        ///     polynomial   : 0x1D, 
        ///     initialValue : 0xFF, 
        ///     finalXorValue: 0x00, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC8_EBU() 
            : base(0x1D, 0xFF, 0x00, true, true)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC8/I-CODE ハッシュを計算します。
    /// </summary>
    public sealed class CRC8_I_CODE : CRC8
    {
        /// <summary>
        /// <see cref="CRC8_I_CODE"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC8" />
        /// (
        ///     polynomial   : 0x1D, 
        ///     initialValue : 0xFD, 
        ///     finalXorValue: 0x00, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC8_I_CODE() 
            : base(0x1D, 0xFD, 0x00, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC8/ITU ハッシュを計算します。
    /// </summary>
    public sealed class CRC8_ITU : CRC8
    {
        /// <summary>
        /// <see cref="CRC8_ITU"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC8" />
        /// (
        ///     polynomial   : 0x07, 
        ///     initialValue : 0x00, 
        ///     finalXorValue: 0x55, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC8_ITU() 
            : base(0x07, 0x00, 0x55, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC8/MAXIM ハッシュを計算します。
    /// </summary>
    public sealed class CRC8_MAXIM : CRC8
    {
        /// <summary>
        /// <see cref="CRC8_MAXIM"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC8" />
        /// (
        ///     polynomial   : 0x31, 
        ///     initialValue : 0x00, 
        ///     finalXorValue: 0x00, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC8_MAXIM() 
            : base(0x31, 0x00, 0x00, true, true)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC8/ROHC ハッシュを計算します。
    /// </summary>
    public sealed class CRC8_ROHC : CRC8
    {
        /// <summary>
        /// <see cref="CRC8_ROHC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC8" />
        /// (
        ///     polynomial   : 0x07, 
        ///     initialValue : 0xFF, 
        ///     finalXorValue: 0x00, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC8_ROHC() 
            : base(0x07, 0xFF, 0x00, true, true)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC8/WCDMA ハッシュを計算します。
    /// </summary>
    public sealed class CRC8_WCDMA : CRC8
    {
        /// <summary>
        /// <see cref="CRC8_WCDMA"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC8" />
        /// (
        ///     polynomial   : 0x9B, 
        ///     initialValue : 0x00, 
        ///     finalXorValue: 0x00, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC8_WCDMA() 
            : base(0x9B, 0x00, 0x00, true, true)
        {
        }
    }

}