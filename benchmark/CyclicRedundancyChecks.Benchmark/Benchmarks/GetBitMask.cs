using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace CyclicRedundancyChecks.Benchmark.Benchmarks
{
    [Config(typeof(BenchmarkConfig))]
    public class GetBitMask
    {
        int bitWidth;

        [GlobalSetup]
        public void Setup()
        {
            var r = new Random().Next(1, 8);
            bitWidth = r;
        }

        [Benchmark]
        public byte GetBitMask_1()
        {
            var result = GetBitMask_1(bitWidth);
            return result;
        }

        [Benchmark]
        public byte GetBitMask_2()
        {
            var result = GetBitMask_2(bitWidth);
            return result;
        }

        [Benchmark]
        public byte GetBitMask_3()
        {
            var result = GetBitMask_3<byte>(bitWidth);
            return result;
        }

        [Benchmark]
        public byte GetBitMask_4()
        {
            GetBitMask_4(bitWidth, out var result);
            return result;
        }

        public static byte GetBitMask_1(int bitWidth)
        {
            if (bitWidth < 1) return 0;

            switch (bitWidth)
            {
                case 1: return 0b0000_0001;
                case 2: return 0b0000_0011;
                case 3: return 0b0000_0111;
                case 4: return 0b0000_1111;
                case 5: return 0b0001_1111;
                case 6: return 0b0011_1111;
                case 7: return 0b0111_1111;
                case 8: return 0b1111_1111;
            }

            return 0xFF;
        }

        public static byte GetBitMask_2(int bitWidth)
        {
            if (bitWidth < 1) return 0;
            if (8 <= bitWidth) return 0xFF;

            return unchecked((byte)(((byte)1 << bitWidth) - 1));
        }

        public static T GetBitMask_3<T>(int bitWidth)
        {
            if (bitWidth < 1)
            {
                var result = 0;
                return Unsafe.As<int, T>(ref result);
            }

            if (bitWidth < 65)
            {
                ulong result;
                if (bitWidth == 64)
                {
                    result = 0xFFFF_FFFF_FFFF_FFFFUL;
                    return Unsafe.As<ulong, T>(ref result);
                }
                result = (1UL << bitWidth) - 1;
                return Unsafe.As<ulong, T>(ref result);
            }

            {
                BigInteger result = ((BigInteger)1U << bitWidth) - 1;
                return Unsafe.As<BigInteger, T>(ref result);
            }
        }

        public static void GetBitMask_4(int bitWidth, out byte result)
        {
            if (bitWidth < 1)
            {
                result = 0;
                return;
            }
            if (8 <= bitWidth)
            {
                result = 0xFF;
                return;
            }
            result = unchecked((byte)((1 << bitWidth) - 1));
        }



    }
}
