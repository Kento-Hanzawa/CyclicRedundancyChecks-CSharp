using System;
using System.Numerics;

namespace CyclicRedundancyChecks.Internal
{
    internal static partial class CRCUtility
    {
        /// <summary>
        /// <see cref="byte"/> のビット順序を反転させます。
        /// </summary>
        /// <param name="value">反転処理の対象となる値。</param>
        /// <param name="bitWidth">反転対象のビット桁幅。</param>
        /// <returns><paramref name="value"/> の反転対象桁のビット順が反転された値。</returns>
        public static byte BitReflect(byte value, int bitWidth = sizeof(byte) * 8)
        {
            if (bitWidth < 0)
            {
                return value;
            }

            const int MaxWidth = sizeof(byte) * 8;
            if (MaxWidth < bitWidth)
            {
                bitWidth = MaxWidth;
            }

            // byte用のコードを使用するより、
            // uintにキャストして変換したほうが高速。
            return unchecked((byte)BitReflect((uint)value, bitWidth));

            //unchecked
            //{
            //    const byte Mask4 = 0x0F;
            //    const byte Mask2 = 0x33;
            //    const byte Mask1 = 0x55;
            //    value = (byte)(((value & Mask4) << 4) | ((value >> 4) & Mask4));
            //    value = (byte)(((value & Mask2) << 2) | ((value >> 2) & Mask2));
            //    value = (byte)(((value & Mask1) << 1) | ((value >> 1) & Mask1));
            //}

            //if (bitWidth < MaxWidth)
            //    return unchecked((byte)(value >> (MaxWidth - bitWidth)));
            //return value;
        }

        /// <summary>
        /// <see cref="ushort"/> のビット順序を反転させます。
        /// </summary>
        /// <param name="value">反転処理の対象となる値。</param>
        /// <param name="bitWidth">反転対象のビット桁幅。</param>
        /// <returns><paramref name="value"/> の反転対象桁のビット順が反転された値。</returns>
        public static ushort BitReflect(ushort value, int bitWidth = sizeof(ushort) * 8)
        {
            if (bitWidth < 0)
            {
                return value;
            }

            const int MaxWidth = sizeof(ushort) * 8;
            if (MaxWidth < bitWidth)
            {
                bitWidth = MaxWidth;
            }

            // ushort用のコードを使用するより、
            // uintにキャストして変換したほうが高速。
            return unchecked((ushort)BitReflect((uint)value, bitWidth));

            //unchecked
            //{
            //    const ushort Mask8 = 0x00FF;
            //    const ushort Mask4 = 0x0F0F;
            //    const ushort Mask2 = 0x3333;
            //    const ushort Mask1 = 0x5555;
            //    value = (ushort)(((value & Mask8) << 8) | ((value >> 8) & Mask8));
            //    value = (ushort)(((value & Mask4) << 4) | ((value >> 4) & Mask4));
            //    value = (ushort)(((value & Mask2) << 2) | ((value >> 2) & Mask2));
            //    value = (ushort)(((value & Mask1) << 1) | ((value >> 1) & Mask1));
            //}

            //if (bitWidth < MaxWidth)
            //    return unchecked((ushort)(value >> (MaxWidth - bitWidth)));
            //return value;
        }

        /// <summary>
        /// <see cref="uint"/> のビット順序を反転させます。
        /// </summary>
        /// <param name="value">反転処理の対象となる値。</param>
        /// <param name="bitWidth">反転対象のビット桁幅。</param>
        /// <returns><paramref name="value"/> の反転対象桁のビット順が反転された値。</returns>
        public static uint BitReflect(uint value, int bitWidth = sizeof(uint) * 8)
        {
            if (bitWidth < 0)
            {
                return value;
            }

            unchecked
            {
                const uint Mask16 = 0x0000_FFFFU;
                const uint Mask08 = 0x00FF_00FFU;
                const uint Mask04 = 0x0F0F_0F0FU;
                const uint Mask02 = 0x3333_3333U;
                const uint Mask01 = 0x5555_5555U;
                value = ((value & Mask16) << 16) | ((value >> 16) & Mask16);
                value = ((value & Mask08) << 08) | ((value >> 08) & Mask08);
                value = ((value & Mask04) << 04) | ((value >> 04) & Mask04);
                value = ((value & Mask02) << 02) | ((value >> 02) & Mask02);
                value = ((value & Mask01) << 01) | ((value >> 01) & Mask01);
            }

            const int MaxWidth = sizeof(uint) * 8;
            if (bitWidth < MaxWidth)
            {
                return value >> (MaxWidth - bitWidth);
            }
            return value;
        }

        /// <summary>
        /// <see cref="ulong"/> のビット順序を反転させます。
        /// </summary>
        /// <param name="value">反転処理の対象となる値。</param>
        /// <param name="bitWidth">反転対象のビット桁幅。</param>
        /// <returns><paramref name="value"/> の反転対象桁のビット順が反転された値。</returns>
        public static ulong BitReflect(ulong value, int bitWidth = sizeof(ulong) * 8)
        {
            if (bitWidth < 0)
            {
                return value;
            }

            unchecked
            {
                const ulong Mask32 = 0x0000_0000_FFFF_FFFFUL;
                const ulong Mask16 = 0x0000_FFFF_0000_FFFFUL;
                const ulong Mask08 = 0x00FF_00FF_00FF_00FFUL;
                const ulong Mask04 = 0x0F0F_0F0F_0F0F_0F0FUL;
                const ulong Mask02 = 0x3333_3333_3333_3333UL;
                const ulong Mask01 = 0x5555_5555_5555_5555UL;
                value = ((value & Mask32) << 32) | ((value >> 32) & Mask32);
                value = ((value & Mask16) << 16) | ((value >> 16) & Mask16);
                value = ((value & Mask08) << 08) | ((value >> 08) & Mask08);
                value = ((value & Mask04) << 04) | ((value >> 04) & Mask04);
                value = ((value & Mask02) << 02) | ((value >> 02) & Mask02);
                value = ((value & Mask01) << 01) | ((value >> 01) & Mask01);
            }

            const int MaxWidth = sizeof(ulong) * 8;
            if (bitWidth < MaxWidth)
            {
                return value >> (MaxWidth - bitWidth);
            }
            return value;
        }

        /// <summary>
        /// <see cref="BigInteger"/> のビット順序を反転させます。
        /// </summary>
        /// <param name="value">反転処理の対象となる値。</param>
        /// <param name="bitWidth">反転対象のビット桁幅。</param>
        /// <returns><paramref name="value"/> の反転対象桁のビット順が反転された値。</returns>
        public static BigInteger BitReflect(BigInteger value, int bitWidth = sizeof(ulong) * 8)
        {
            if (bitWidth < 0)
            {
                return value;
            }

            int ceilingLog2 = (int)Math.Ceiling(BigInteger.Log(bitWidth, 2));
            int exponent = ceilingLog2 - 1;
            BigInteger mask = ((BigInteger)1U << (int)Math.Pow(2, exponent)) - 1;
            while (0 <= exponent)
            {
                int pow = (int)Math.Pow(2, exponent);
                value = ((value & mask) << pow) | ((value >> pow) & mask);
                mask ^= (mask << (pow / 2));
                exponent--;
            }

            var powWidth = (int)Math.Pow(2, ceilingLog2);
            if (bitWidth < powWidth)
            {
                return value >> (powWidth - bitWidth);
            }
            return value;
        }
    }
}
