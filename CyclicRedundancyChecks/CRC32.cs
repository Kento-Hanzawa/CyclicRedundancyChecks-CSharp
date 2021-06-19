 
//
// CyclicRedundancyChecks
// 
// このコードはテキストテンプレートファイル (.tt) によって作成されています。
// 変更をおこなう場合は、テキストテンプレートファイル (.tt) を編集してください。
//

namespace CyclicRedundancyChecks
{
    /// <summary>
    /// 入力データの CRC32 ハッシュを計算します。
    /// </summary>
    public sealed class CRC32_STANDARD : CRC32
    {
        /// <summary>
        /// <see cref="CRC32_STANDARD"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC32" />
        /// (
        ///     polynomial   : 0x04C11DB7, 
        ///     initialValue : 0xFFFFFFFF, 
        ///     finalXorValue: 0xFFFFFFFF, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC32_STANDARD() 
            : base(0x04C11DB7, 0xFFFFFFFF, 0xFFFFFFFF, true, true)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC32/BZIP2 ハッシュを計算します。
    /// </summary>
    public sealed class CRC32_BZIP2 : CRC32
    {
        /// <summary>
        /// <see cref="CRC32_BZIP2"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC32" />
        /// (
        ///     polynomial   : 0x04C11DB7, 
        ///     initialValue : 0xFFFFFFFF, 
        ///     finalXorValue: 0xFFFFFFFF, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC32_BZIP2() 
            : base(0x04C11DB7, 0xFFFFFFFF, 0xFFFFFFFF, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC32C ハッシュを計算します。
    /// </summary>
    public sealed class CRC32C : CRC32
    {
        /// <summary>
        /// <see cref="CRC32C"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC32" />
        /// (
        ///     polynomial   : 0x1EDC6F41, 
        ///     initialValue : 0xFFFFFFFF, 
        ///     finalXorValue: 0xFFFFFFFF, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC32C() 
            : base(0x1EDC6F41, 0xFFFFFFFF, 0xFFFFFFFF, true, true)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC32D ハッシュを計算します。
    /// </summary>
    public sealed class CRC32D : CRC32
    {
        /// <summary>
        /// <see cref="CRC32D"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC32" />
        /// (
        ///     polynomial   : 0xA833982B, 
        ///     initialValue : 0xFFFFFFFF, 
        ///     finalXorValue: 0xFFFFFFFF, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC32D() 
            : base(0xA833982B, 0xFFFFFFFF, 0xFFFFFFFF, true, true)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC32/MPEG-2 ハッシュを計算します。
    /// </summary>
    public sealed class CRC32_MPEG_2 : CRC32
    {
        /// <summary>
        /// <see cref="CRC32_MPEG_2"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC32" />
        /// (
        ///     polynomial   : 0x04C11DB7, 
        ///     initialValue : 0xFFFFFFFF, 
        ///     finalXorValue: 0x00000000, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC32_MPEG_2() 
            : base(0x04C11DB7, 0xFFFFFFFF, 0x00000000, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC32/POSIX ハッシュを計算します。
    /// </summary>
    public sealed class CRC32_POSIX : CRC32
    {
        /// <summary>
        /// <see cref="CRC32_POSIX"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC32" />
        /// (
        ///     polynomial   : 0x04C11DB7, 
        ///     initialValue : 0x00000000, 
        ///     finalXorValue: 0xFFFFFFFF, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC32_POSIX() 
            : base(0x04C11DB7, 0x00000000, 0xFFFFFFFF, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC32Q ハッシュを計算します。
    /// </summary>
    public sealed class CRC32Q : CRC32
    {
        /// <summary>
        /// <see cref="CRC32Q"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC32" />
        /// (
        ///     polynomial   : 0x814141AB, 
        ///     initialValue : 0x00000000, 
        ///     finalXorValue: 0x00000000, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC32Q() 
            : base(0x814141AB, 0x00000000, 0x00000000, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC32/JAMCRC ハッシュを計算します。
    /// </summary>
    public sealed class CRC32_JAMCRC : CRC32
    {
        /// <summary>
        /// <see cref="CRC32_JAMCRC"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC32" />
        /// (
        ///     polynomial   : 0x04C11DB7, 
        ///     initialValue : 0xFFFFFFFF, 
        ///     finalXorValue: 0x00000000, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC32_JAMCRC() 
            : base(0x04C11DB7, 0xFFFFFFFF, 0x00000000, true, true)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC32/XFER ハッシュを計算します。
    /// </summary>
    public sealed class CRC32_XFER : CRC32
    {
        /// <summary>
        /// <see cref="CRC32_XFER"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC32" />
        /// (
        ///     polynomial   : 0x000000AF, 
        ///     initialValue : 0x00000000, 
        ///     finalXorValue: 0x00000000, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC32_XFER() 
            : base(0x000000AF, 0x00000000, 0x00000000, false, false)
        {
        }
    }

}
