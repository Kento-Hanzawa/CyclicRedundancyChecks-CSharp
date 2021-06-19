//
// CyclicRedundancyChecks
// 
// このコードはテキストテンプレートファイル (.tt) によって作成されています。
// 変更をおこなう場合は、テキストテンプレートファイル (.tt) を編集してください。
//

using System;

namespace CyclicRedundancyChecks
{
    internal static partial class CRCUtility
    {
#pragma warning disable CS0675 // 符号拡張されたオペランドでビットごとの or 演算子が使用されました
        /// <summary>
        /// <see cref="global::System.Byte"/> のビット順序を反転させます。
        /// </summary>
        /// <param name="value">反転処理の対象となる値。</param>
        /// <returns><paramref name="value"/> のビット順が反転された値。</returns>
        public static global::System.Byte BitReverse(global::System.Byte value)
        {
            const int BitSize = 8; // sizeof(global::System.Byte) * 8

            global::System.Byte result = 0;
            for (int i = 0; i < BitSize; i++)
            {
                if ((value & 1) == 1)
                {
                    result |= (global::System.Byte)((global::System.Byte)1 << (BitSize - 1 - i));
                }
                value = (global::System.Byte)(value >> 1);
            }
            return result;
        }

        /// <summary>
        /// <see cref="global::System.UInt16"/> のビット順序を反転させます。
        /// </summary>
        /// <param name="value">反転処理の対象となる値。</param>
        /// <returns><paramref name="value"/> のビット順が反転された値。</returns>
        public static global::System.UInt16 BitReverse(global::System.UInt16 value)
        {
            const int BitSize = 16; // sizeof(global::System.UInt16) * 8

            global::System.UInt16 result = 0;
            for (int i = 0; i < BitSize; i++)
            {
                if ((value & 1) == 1)
                {
                    result |= (global::System.UInt16)((global::System.UInt16)1 << (BitSize - 1 - i));
                }
                value = (global::System.UInt16)(value >> 1);
            }
            return result;
        }

        /// <summary>
        /// <see cref="global::System.UInt32"/> のビット順序を反転させます。
        /// </summary>
        /// <param name="value">反転処理の対象となる値。</param>
        /// <returns><paramref name="value"/> のビット順が反転された値。</returns>
        public static global::System.UInt32 BitReverse(global::System.UInt32 value)
        {
            const int BitSize = 32; // sizeof(global::System.UInt32) * 8

            global::System.UInt32 result = 0;
            for (int i = 0; i < BitSize; i++)
            {
                if ((value & 1) == 1)
                {
                    result |= (global::System.UInt32)((global::System.UInt32)1 << (BitSize - 1 - i));
                }
                value = (global::System.UInt32)(value >> 1);
            }
            return result;
        }

        /// <summary>
        /// <see cref="global::System.UInt64"/> のビット順序を反転させます。
        /// </summary>
        /// <param name="value">反転処理の対象となる値。</param>
        /// <returns><paramref name="value"/> のビット順が反転された値。</returns>
        public static global::System.UInt64 BitReverse(global::System.UInt64 value)
        {
            const int BitSize = 64; // sizeof(global::System.UInt64) * 8

            global::System.UInt64 result = 0;
            for (int i = 0; i < BitSize; i++)
            {
                if ((value & 1) == 1)
                {
                    result |= (global::System.UInt64)((global::System.UInt64)1 << (BitSize - 1 - i));
                }
                value = (global::System.UInt64)(value >> 1);
            }
            return result;
        }

#pragma warning restore CS0675 // 符号拡張されたオペランドでビットごとの or 演算子が使用されました


        /// <summary>
        /// CRC計算用の LookupTable 値を <paramref name="table"/> に格納します。
        /// </summary>
        /// <param name="table">LookupTable の値を格納するシーケンス。</param>
        /// <param name="polynomial">生成多項式。</param>
        /// <param name="reversedData">反転を行う場合は <see langword="true"/>。しない場合は <see langword="false"/>。</param>
        public static void TableFill(Span<global::System.Byte> table, global::System.Byte polynomial, bool reversedData)
        {
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = Obtener((byte)(i & 0xFF));
            }

            global::System.Byte Obtener(byte position)
            {
                const int BitSize = 8; // sizeof(global::System.Byte) * 8;
                const global::System.Byte TopBit = 0x80; // (global::System.Byte)1 << (BitSize - 1);

                global::System.Byte result;
                if (reversedData)
                    result = (global::System.Byte)((global::System.Byte)(BitReverse(position) & 0xFF) << (BitSize - 8));
                else
                    result = (global::System.Byte)((global::System.Byte)            position          << (BitSize - 8));

                for (var i = 0; i < 8; i++)
                {
                    if ((result & TopBit) == 0)
                        result = (global::System.Byte)(result << 1);
                    else
                        result = (global::System.Byte)((result << 1) ^ polynomial);
                }

                if (reversedData)
                    return BitReverse(result);
                else
                    return result;
            }
        }

        /// <summary>
        /// CRC計算用の LookupTable 値を <paramref name="table"/> に格納します。
        /// </summary>
        /// <param name="table">LookupTable の値を格納するシーケンス。</param>
        /// <param name="polynomial">生成多項式。</param>
        /// <param name="reversedData">反転を行う場合は <see langword="true"/>。しない場合は <see langword="false"/>。</param>
        public static void TableFill(Span<global::System.UInt16> table, global::System.UInt16 polynomial, bool reversedData)
        {
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = Obtener((byte)(i & 0xFF));
            }

            global::System.UInt16 Obtener(byte position)
            {
                const int BitSize = 16; // sizeof(global::System.UInt16) * 8;
                const global::System.UInt16 TopBit = 0x8000; // (global::System.UInt16)1 << (BitSize - 1);

                global::System.UInt16 result;
                if (reversedData)
                    result = (global::System.UInt16)((global::System.UInt16)(BitReverse(position) & 0xFF) << (BitSize - 8));
                else
                    result = (global::System.UInt16)((global::System.UInt16)            position          << (BitSize - 8));

                for (var i = 0; i < 8; i++)
                {
                    if ((result & TopBit) == 0)
                        result = (global::System.UInt16)(result << 1);
                    else
                        result = (global::System.UInt16)((result << 1) ^ polynomial);
                }

                if (reversedData)
                    return BitReverse(result);
                else
                    return result;
            }
        }

        /// <summary>
        /// CRC計算用の LookupTable 値を <paramref name="table"/> に格納します。
        /// </summary>
        /// <param name="table">LookupTable の値を格納するシーケンス。</param>
        /// <param name="polynomial">生成多項式。</param>
        /// <param name="reversedData">反転を行う場合は <see langword="true"/>。しない場合は <see langword="false"/>。</param>
        public static void TableFill(Span<global::System.UInt32> table, global::System.UInt32 polynomial, bool reversedData)
        {
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = Obtener((byte)(i & 0xFF));
            }

            global::System.UInt32 Obtener(byte position)
            {
                const int BitSize = 32; // sizeof(global::System.UInt32) * 8;
                const global::System.UInt32 TopBit = 0x80000000; // (global::System.UInt32)1 << (BitSize - 1);

                global::System.UInt32 result;
                if (reversedData)
                    result = (global::System.UInt32)((global::System.UInt32)(BitReverse(position) & 0xFF) << (BitSize - 8));
                else
                    result = (global::System.UInt32)((global::System.UInt32)            position          << (BitSize - 8));

                for (var i = 0; i < 8; i++)
                {
                    if ((result & TopBit) == 0)
                        result = (global::System.UInt32)(result << 1);
                    else
                        result = (global::System.UInt32)((result << 1) ^ polynomial);
                }

                if (reversedData)
                    return BitReverse(result);
                else
                    return result;
            }
        }

        /// <summary>
        /// CRC計算用の LookupTable 値を <paramref name="table"/> に格納します。
        /// </summary>
        /// <param name="table">LookupTable の値を格納するシーケンス。</param>
        /// <param name="polynomial">生成多項式。</param>
        /// <param name="reversedData">反転を行う場合は <see langword="true"/>。しない場合は <see langword="false"/>。</param>
        public static void TableFill(Span<global::System.UInt64> table, global::System.UInt64 polynomial, bool reversedData)
        {
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = Obtener((byte)(i & 0xFF));
            }

            global::System.UInt64 Obtener(byte position)
            {
                const int BitSize = 64; // sizeof(global::System.UInt64) * 8;
                const global::System.UInt64 TopBit = 0x8000000000000000; // (global::System.UInt64)1 << (BitSize - 1);

                global::System.UInt64 result;
                if (reversedData)
                    result = (global::System.UInt64)((global::System.UInt64)(BitReverse(position) & 0xFF) << (BitSize - 8));
                else
                    result = (global::System.UInt64)((global::System.UInt64)            position          << (BitSize - 8));

                for (var i = 0; i < 8; i++)
                {
                    if ((result & TopBit) == 0)
                        result = (global::System.UInt64)(result << 1);
                    else
                        result = (global::System.UInt64)((result << 1) ^ polynomial);
                }

                if (reversedData)
                    return BitReverse(result);
                else
                    return result;
            }
        }


    }
}