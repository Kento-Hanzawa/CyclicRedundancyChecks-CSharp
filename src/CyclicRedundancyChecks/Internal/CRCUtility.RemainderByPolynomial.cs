﻿// <auto-generated>
// この .cs ファイルはT4によって自動的に生成されています。直接編集はせず、代わりに .tt ファイルを編集してください。
// </auto-generated>

namespace CyclicRedundancyChecks.Internal
{
    partial class CRCUtility
    {
        public static global::System.Byte RemainderByPolynomial(in byte dividend, in int bitWidth, in global::System.Byte polynomial)
        {
            const int byteSizeInBits = sizeof(byte) * 8; // dividend のサイズ。

            if (bitWidth < 8)
            {
                // remainder: aaaa bbbb
                global::System.Byte remainder = (global::System.Byte)dividend;

                // remainder の先頭ビットが 0 の場合は remainder を 1 だけ左シフト、
                // 1 の場合は remainder を 1 だけ左シフトした後に polynomial と XOR 演算します。
                // これを dividend のビット長分だけ繰り返して剰余を計算します。
                // dividend: aaaa bbbb
                //           ^ (ここを見る)
                for (int i = 0; i < byteSizeInBits; i++)
                {
                    global::System.Byte topBit = (global::System.Byte)(0x80);

                    if ((remainder & topBit) == 0)
                    {
                        remainder <<= 1;
                    }
                    else
                    {
                        remainder <<= 1;
                        // polynomial の先頭ビット (bitWidth の位置) が、remainder の先頭ビット (8) に合うようにシフト演算します。
                        // polynomial: 0aaa bbbb (7ビット以下)
                        // polynomial: aaab bbb0
                        remainder ^= (global::System.Byte)(polynomial << (byteSizeInBits - bitWidth));
                    }
                }

                // 最初に polynomial をシフトした影響で、remainder の値が左に寄った感じになっています。
                // remainder: aaab bbb0
                // なので、polynomial のシフトと逆方向に同じ分だけシフトし直して、正しい位置に戻します。
                // remainder: 0aaa bbbb
                return (global::System.Byte)(remainder >> (byteSizeInBits - bitWidth));
            }
            else
            {
                // dividend の先頭ビット位置を polynomial の先頭ビット (bitWidth の位置) に合わせます。
                // polynomial: 00aa bbbb cccc ... yyyy zzzz
                // dividend  :                    aaaa bbbb
                // dividend  :   aa aabb bb00 ... 0000 0000
                global::System.Byte remainder = (global::System.Byte)((global::System.Byte)dividend << (bitWidth - byteSizeInBits));

                // remainder の先頭ビットが 0 の場合は remainder を 1 だけ左シフト、
                // 1 の場合は remainder を 1 だけ左シフトした後に polynomial と XOR 演算します。
                // これを dividend のビット長分だけ繰り返して剰余を計算します。
                // dividend: aaaa bbbb
                //           ^ (ここを見る)
                for (int i = 0; i < byteSizeInBits; i++)
                {
                    global::System.Byte topBit = (global::System.Byte)((global::System.Byte)1UL << (bitWidth - 1));

                    if ((remainder & topBit) == 0)
                    {
                        remainder <<= 1;
                    }
                    else
                    {
                        remainder <<= 1;
                        remainder ^= polynomial;
                    }
                }

                return remainder;
            }
        }
    }

    partial class CRCUtility
    {
        public static global::System.UInt16 RemainderByPolynomial(in byte dividend, in int bitWidth, in global::System.UInt16 polynomial)
        {
            const int byteSizeInBits = sizeof(byte) * 8; // dividend のサイズ。

            if (bitWidth < 8)
            {
                // remainder: aaaa bbbb
                global::System.UInt16 remainder = (global::System.UInt16)dividend;

                // remainder の先頭ビットが 0 の場合は remainder を 1 だけ左シフト、
                // 1 の場合は remainder を 1 だけ左シフトした後に polynomial と XOR 演算します。
                // これを dividend のビット長分だけ繰り返して剰余を計算します。
                // dividend: aaaa bbbb
                //           ^ (ここを見る)
                for (int i = 0; i < byteSizeInBits; i++)
                {
                    global::System.UInt16 topBit = (global::System.UInt16)(0x80);

                    if ((remainder & topBit) == 0)
                    {
                        remainder <<= 1;
                    }
                    else
                    {
                        remainder <<= 1;
                        // polynomial の先頭ビット (bitWidth の位置) が、remainder の先頭ビット (8) に合うようにシフト演算します。
                        // polynomial: 0aaa bbbb (7ビット以下)
                        // polynomial: aaab bbb0
                        remainder ^= (global::System.UInt16)(polynomial << (byteSizeInBits - bitWidth));
                    }
                }

                // 最初に polynomial をシフトした影響で、remainder の値が左に寄った感じになっています。
                // remainder: aaab bbb0
                // なので、polynomial のシフトと逆方向に同じ分だけシフトし直して、正しい位置に戻します。
                // remainder: 0aaa bbbb
                return (global::System.UInt16)(remainder >> (byteSizeInBits - bitWidth));
            }
            else
            {
                // dividend の先頭ビット位置を polynomial の先頭ビット (bitWidth の位置) に合わせます。
                // polynomial: 00aa bbbb cccc ... yyyy zzzz
                // dividend  :                    aaaa bbbb
                // dividend  :   aa aabb bb00 ... 0000 0000
                global::System.UInt16 remainder = (global::System.UInt16)((global::System.UInt16)dividend << (bitWidth - byteSizeInBits));

                // remainder の先頭ビットが 0 の場合は remainder を 1 だけ左シフト、
                // 1 の場合は remainder を 1 だけ左シフトした後に polynomial と XOR 演算します。
                // これを dividend のビット長分だけ繰り返して剰余を計算します。
                // dividend: aaaa bbbb
                //           ^ (ここを見る)
                for (int i = 0; i < byteSizeInBits; i++)
                {
                    global::System.UInt16 topBit = (global::System.UInt16)((global::System.UInt16)1UL << (bitWidth - 1));

                    if ((remainder & topBit) == 0)
                    {
                        remainder <<= 1;
                    }
                    else
                    {
                        remainder <<= 1;
                        remainder ^= polynomial;
                    }
                }

                return remainder;
            }
        }
    }

    partial class CRCUtility
    {
        public static global::System.UInt32 RemainderByPolynomial(in byte dividend, in int bitWidth, in global::System.UInt32 polynomial)
        {
            const int byteSizeInBits = sizeof(byte) * 8; // dividend のサイズ。

            if (bitWidth < 8)
            {
                // remainder: aaaa bbbb
                global::System.UInt32 remainder = (global::System.UInt32)dividend;

                // remainder の先頭ビットが 0 の場合は remainder を 1 だけ左シフト、
                // 1 の場合は remainder を 1 だけ左シフトした後に polynomial と XOR 演算します。
                // これを dividend のビット長分だけ繰り返して剰余を計算します。
                // dividend: aaaa bbbb
                //           ^ (ここを見る)
                for (int i = 0; i < byteSizeInBits; i++)
                {
                    global::System.UInt32 topBit = (global::System.UInt32)(0x80);

                    if ((remainder & topBit) == 0)
                    {
                        remainder <<= 1;
                    }
                    else
                    {
                        remainder <<= 1;
                        // polynomial の先頭ビット (bitWidth の位置) が、remainder の先頭ビット (8) に合うようにシフト演算します。
                        // polynomial: 0aaa bbbb (7ビット以下)
                        // polynomial: aaab bbb0
                        remainder ^= (global::System.UInt32)(polynomial << (byteSizeInBits - bitWidth));
                    }
                }

                // 最初に polynomial をシフトした影響で、remainder の値が左に寄った感じになっています。
                // remainder: aaab bbb0
                // なので、polynomial のシフトと逆方向に同じ分だけシフトし直して、正しい位置に戻します。
                // remainder: 0aaa bbbb
                return (global::System.UInt32)(remainder >> (byteSizeInBits - bitWidth));
            }
            else
            {
                // dividend の先頭ビット位置を polynomial の先頭ビット (bitWidth の位置) に合わせます。
                // polynomial: 00aa bbbb cccc ... yyyy zzzz
                // dividend  :                    aaaa bbbb
                // dividend  :   aa aabb bb00 ... 0000 0000
                global::System.UInt32 remainder = (global::System.UInt32)((global::System.UInt32)dividend << (bitWidth - byteSizeInBits));

                // remainder の先頭ビットが 0 の場合は remainder を 1 だけ左シフト、
                // 1 の場合は remainder を 1 だけ左シフトした後に polynomial と XOR 演算します。
                // これを dividend のビット長分だけ繰り返して剰余を計算します。
                // dividend: aaaa bbbb
                //           ^ (ここを見る)
                for (int i = 0; i < byteSizeInBits; i++)
                {
                    global::System.UInt32 topBit = (global::System.UInt32)((global::System.UInt32)1UL << (bitWidth - 1));

                    if ((remainder & topBit) == 0)
                    {
                        remainder <<= 1;
                    }
                    else
                    {
                        remainder <<= 1;
                        remainder ^= polynomial;
                    }
                }

                return remainder;
            }
        }
    }

    partial class CRCUtility
    {
        public static global::System.UInt64 RemainderByPolynomial(in byte dividend, in int bitWidth, in global::System.UInt64 polynomial)
        {
            const int byteSizeInBits = sizeof(byte) * 8; // dividend のサイズ。

            if (bitWidth < 8)
            {
                // remainder: aaaa bbbb
                global::System.UInt64 remainder = (global::System.UInt64)dividend;

                // remainder の先頭ビットが 0 の場合は remainder を 1 だけ左シフト、
                // 1 の場合は remainder を 1 だけ左シフトした後に polynomial と XOR 演算します。
                // これを dividend のビット長分だけ繰り返して剰余を計算します。
                // dividend: aaaa bbbb
                //           ^ (ここを見る)
                for (int i = 0; i < byteSizeInBits; i++)
                {
                    global::System.UInt64 topBit = (global::System.UInt64)(0x80);

                    if ((remainder & topBit) == 0)
                    {
                        remainder <<= 1;
                    }
                    else
                    {
                        remainder <<= 1;
                        // polynomial の先頭ビット (bitWidth の位置) が、remainder の先頭ビット (8) に合うようにシフト演算します。
                        // polynomial: 0aaa bbbb (7ビット以下)
                        // polynomial: aaab bbb0
                        remainder ^= (global::System.UInt64)(polynomial << (byteSizeInBits - bitWidth));
                    }
                }

                // 最初に polynomial をシフトした影響で、remainder の値が左に寄った感じになっています。
                // remainder: aaab bbb0
                // なので、polynomial のシフトと逆方向に同じ分だけシフトし直して、正しい位置に戻します。
                // remainder: 0aaa bbbb
                return (global::System.UInt64)(remainder >> (byteSizeInBits - bitWidth));
            }
            else
            {
                // dividend の先頭ビット位置を polynomial の先頭ビット (bitWidth の位置) に合わせます。
                // polynomial: 00aa bbbb cccc ... yyyy zzzz
                // dividend  :                    aaaa bbbb
                // dividend  :   aa aabb bb00 ... 0000 0000
                global::System.UInt64 remainder = (global::System.UInt64)((global::System.UInt64)dividend << (bitWidth - byteSizeInBits));

                // remainder の先頭ビットが 0 の場合は remainder を 1 だけ左シフト、
                // 1 の場合は remainder を 1 だけ左シフトした後に polynomial と XOR 演算します。
                // これを dividend のビット長分だけ繰り返して剰余を計算します。
                // dividend: aaaa bbbb
                //           ^ (ここを見る)
                for (int i = 0; i < byteSizeInBits; i++)
                {
                    global::System.UInt64 topBit = (global::System.UInt64)((global::System.UInt64)1UL << (bitWidth - 1));

                    if ((remainder & topBit) == 0)
                    {
                        remainder <<= 1;
                    }
                    else
                    {
                        remainder <<= 1;
                        remainder ^= polynomial;
                    }
                }

                return remainder;
            }
        }
    }

    partial class CRCUtility
    {
        public static global::System.Numerics.BigInteger RemainderByPolynomial(in byte dividend, in int bitWidth, in global::System.Numerics.BigInteger polynomial)
        {
            const int byteSizeInBits = sizeof(byte) * 8; // dividend のサイズ。

            if (bitWidth < 8)
            {
                // remainder: aaaa bbbb
                global::System.Numerics.BigInteger remainder = (global::System.Numerics.BigInteger)dividend;

                // remainder の先頭ビットが 0 の場合は remainder を 1 だけ左シフト、
                // 1 の場合は remainder を 1 だけ左シフトした後に polynomial と XOR 演算します。
                // これを dividend のビット長分だけ繰り返して剰余を計算します。
                // dividend: aaaa bbbb
                //           ^ (ここを見る)
                for (int i = 0; i < byteSizeInBits; i++)
                {
                    global::System.Numerics.BigInteger topBit = (global::System.Numerics.BigInteger)(0x80);

                    if ((remainder & topBit) == 0)
                    {
                        remainder <<= 1;
                    }
                    else
                    {
                        remainder <<= 1;
                        // polynomial の先頭ビット (bitWidth の位置) が、remainder の先頭ビット (8) に合うようにシフト演算します。
                        // polynomial: 0aaa bbbb (7ビット以下)
                        // polynomial: aaab bbb0
                        remainder ^= (global::System.Numerics.BigInteger)(polynomial << (byteSizeInBits - bitWidth));
                    }
                }

                // 最初に polynomial をシフトした影響で、remainder の値が左に寄った感じになっています。
                // remainder: aaab bbb0
                // なので、polynomial のシフトと逆方向に同じ分だけシフトし直して、正しい位置に戻します。
                // remainder: 0aaa bbbb
                return (global::System.Numerics.BigInteger)(remainder >> (byteSizeInBits - bitWidth));
            }
            else
            {
                // dividend の先頭ビット位置を polynomial の先頭ビット (bitWidth の位置) に合わせます。
                // polynomial: 00aa bbbb cccc ... yyyy zzzz
                // dividend  :                    aaaa bbbb
                // dividend  :   aa aabb bb00 ... 0000 0000
                global::System.Numerics.BigInteger remainder = (global::System.Numerics.BigInteger)((global::System.Numerics.BigInteger)dividend << (bitWidth - byteSizeInBits));

                // remainder の先頭ビットが 0 の場合は remainder を 1 だけ左シフト、
                // 1 の場合は remainder を 1 だけ左シフトした後に polynomial と XOR 演算します。
                // これを dividend のビット長分だけ繰り返して剰余を計算します。
                // dividend: aaaa bbbb
                //           ^ (ここを見る)
                for (int i = 0; i < byteSizeInBits; i++)
                {
                    global::System.Numerics.BigInteger topBit = (global::System.Numerics.BigInteger)((global::System.Numerics.BigInteger)1UL << (bitWidth - 1));

                    if ((remainder & topBit) == 0)
                    {
                        remainder <<= 1;
                    }
                    else
                    {
                        remainder <<= 1;
                        remainder ^= polynomial;
                    }
                }

                return remainder;
            }
        }
    }

}