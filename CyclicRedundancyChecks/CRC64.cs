 
//
// CyclicRedundancyChecks
// 
// このコードはテキストテンプレートファイル (.tt) によって作成されています。
// 変更をおこなう場合は、テキストテンプレートファイル (.tt) を編集してください。
//

namespace CyclicRedundancyChecks
{
    /// <summary>
    /// 入力データの CRC64/ECMA-182 ハッシュを計算します。
    /// </summary>
    public sealed class CRC64_ECMA_182 : CRC64
    {
        /// <summary>
        /// <see cref="CRC64_ECMA_182"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC64" />
        /// (
        ///     polynomial   : 0x42F0E1EBA9EA3693, 
        ///     initialValue : 0x0000000000000000, 
        ///     finalXorValue: 0x0000000000000000, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC64_ECMA_182() 
            : base(0x42F0E1EBA9EA3693, 0x0000000000000000, 0x0000000000000000, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC64/GO-ISO ハッシュを計算します。
    /// </summary>
    public sealed class CRC64_GO_ISO : CRC64
    {
        /// <summary>
        /// <see cref="CRC64_GO_ISO"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC64" />
        /// (
        ///     polynomial   : 0x000000000000001B, 
        ///     initialValue : 0xFFFFFFFFFFFFFFFF, 
        ///     finalXorValue: 0xFFFFFFFFFFFFFFFF, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC64_GO_ISO() 
            : base(0x000000000000001B, 0xFFFFFFFFFFFFFFFF, 0xFFFFFFFFFFFFFFFF, true, true)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC64/WE ハッシュを計算します。
    /// </summary>
    public sealed class CRC64_WE : CRC64
    {
        /// <summary>
        /// <see cref="CRC64_WE"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC64" />
        /// (
        ///     polynomial   : 0x42F0E1EBA9EA3693, 
        ///     initialValue : 0xFFFFFFFFFFFFFFFF, 
        ///     finalXorValue: 0xFFFFFFFFFFFFFFFF, 
        ///     reversedData : false, 
        ///     reversedOut  : false
        /// )
        /// </remarks>
        public CRC64_WE() 
            : base(0x42F0E1EBA9EA3693, 0xFFFFFFFFFFFFFFFF, 0xFFFFFFFFFFFFFFFF, false, false)
        {
        }
    }

    /// <summary>
    /// 入力データの CRC64/XZ ハッシュを計算します。
    /// </summary>
    public sealed class CRC64_XZ : CRC64
    {
        /// <summary>
        /// <see cref="CRC64_XZ"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <remarks>
        /// <para>以下のインスタンス作成と同じです。</para>
        /// <see langword="new" /> <see cref="CRC64" />
        /// (
        ///     polynomial   : 0x42F0E1EBA9EA3693, 
        ///     initialValue : 0xFFFFFFFFFFFFFFFF, 
        ///     finalXorValue: 0xFFFFFFFFFFFFFFFF, 
        ///     reversedData : true, 
        ///     reversedOut  : true
        /// )
        /// </remarks>
        public CRC64_XZ() 
            : base(0x42F0E1EBA9EA3693, 0xFFFFFFFFFFFFFFFF, 0xFFFFFFFFFFFFFFFF, true, true)
        {
        }
    }

}
