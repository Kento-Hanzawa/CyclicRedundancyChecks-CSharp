 
//
// CyclicRedundancyChecks
// 
// このコードはテキストテンプレートファイル (.tt) によって作成されています。
// 変更をおこなう場合は、テキストテンプレートファイル (.tt) を編集してください。
//

using System;
using System.Numerics;

namespace CyclicRedundancyChecks
{
    partial class CRCUtility
    {
        /// <summary>
        /// <see cref="global::System.Byte"/> のビット順序を反転させます。
        /// </summary>
        /// <param name="value">反転処理の対象となる値。</param>
        /// <param name="bitWidth">反転対象のビット桁幅。</param>
        /// <returns><paramref name="value"/> の反転対象桁のビット順が反転された値。</returns>
        public static global::System.Byte BitReflect(global::System.Byte value, int bitWidth = 8)
        {
            if (8 < bitWidth)
            {
                bitWidth = 8;
            }

            global::System.Byte result = 0;
            for (int i = 0; i < bitWidth; i++)
            {
                if ((value & 1) == 1)
                {
                    result |= unchecked((global::System.Byte)((global::System.Byte)1 << (bitWidth - 1 - i)));
                }
                value = unchecked((global::System.Byte)(value >> 1));
            }
            return result;
        }

        /// <summary>
        /// <see cref="global::System.UInt16"/> のビット順序を反転させます。
        /// </summary>
        /// <param name="value">反転処理の対象となる値。</param>
        /// <param name="bitWidth">反転対象のビット桁幅。</param>
        /// <returns><paramref name="value"/> の反転対象桁のビット順が反転された値。</returns>
        public static global::System.UInt16 BitReflect(global::System.UInt16 value, int bitWidth = 16)
        {
            if (16 < bitWidth)
            {
                bitWidth = 16;
            }

            global::System.UInt16 result = 0;
            for (int i = 0; i < bitWidth; i++)
            {
                if ((value & 1) == 1)
                {
                    result |= unchecked((global::System.UInt16)((global::System.UInt16)1 << (bitWidth - 1 - i)));
                }
                value = unchecked((global::System.UInt16)(value >> 1));
            }
            return result;
        }

        /// <summary>
        /// <see cref="global::System.UInt32"/> のビット順序を反転させます。
        /// </summary>
        /// <param name="value">反転処理の対象となる値。</param>
        /// <param name="bitWidth">反転対象のビット桁幅。</param>
        /// <returns><paramref name="value"/> の反転対象桁のビット順が反転された値。</returns>
        public static global::System.UInt32 BitReflect(global::System.UInt32 value, int bitWidth = 32)
        {
            if (32 < bitWidth)
            {
                bitWidth = 32;
            }

            global::System.UInt32 result = 0;
            for (int i = 0; i < bitWidth; i++)
            {
                if ((value & 1) == 1)
                {
                    result |= unchecked((global::System.UInt32)((global::System.UInt32)1 << (bitWidth - 1 - i)));
                }
                value = unchecked((global::System.UInt32)(value >> 1));
            }
            return result;
        }

        /// <summary>
        /// <see cref="global::System.UInt64"/> のビット順序を反転させます。
        /// </summary>
        /// <param name="value">反転処理の対象となる値。</param>
        /// <param name="bitWidth">反転対象のビット桁幅。</param>
        /// <returns><paramref name="value"/> の反転対象桁のビット順が反転された値。</returns>
        public static global::System.UInt64 BitReflect(global::System.UInt64 value, int bitWidth = 64)
        {
            if (64 < bitWidth)
            {
                bitWidth = 64;
            }

            global::System.UInt64 result = 0;
            for (int i = 0; i < bitWidth; i++)
            {
                if ((value & 1) == 1)
                {
                    result |= unchecked((global::System.UInt64)((global::System.UInt64)1 << (bitWidth - 1 - i)));
                }
                value = unchecked((global::System.UInt64)(value >> 1));
            }
            return result;
        }

        /// <summary>
        /// <see cref="global::System.Numerics.BigInteger"/> のビット順序を反転させます。
        /// </summary>
        /// <param name="value">反転処理の対象となる値。</param>
        /// <param name="bitWidth">反転対象のビット桁幅。</param>
        /// <returns><paramref name="value"/> の反転対象桁のビット順が反転された値。</returns>
        public static global::System.Numerics.BigInteger BitReflect(global::System.Numerics.BigInteger value, int bitWidth = 64)
        {
            global::System.Numerics.BigInteger result = 0;
            for (int i = 0; i < bitWidth; i++)
            {
                if ((value & 1) == 1)
                {
                    result |= unchecked((global::System.Numerics.BigInteger)((global::System.Numerics.BigInteger)1 << (bitWidth - 1 - i)));
                }
                value = unchecked((global::System.Numerics.BigInteger)(value >> 1));
            }
            return result;
        }

    }
}
