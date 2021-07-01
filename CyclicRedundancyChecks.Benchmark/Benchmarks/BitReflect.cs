using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace CyclicRedundancyChecks.Benchmark.Benchmarks
{
    [Config(typeof(BenchmarkConfig))]
    public class BitReflect
    {
        byte value1;
        ushort value2;
        uint value3;
        ulong value4;
        BigInteger value5;

        [GlobalSetup]
        public void Setup()
        {
            uint r = (uint)new Random().Next();
            value1 = (byte)r;
            value2 = (ushort)r;
            value3 = (uint)r;
            value4 = (ulong)r;
            value5 = (BigInteger)r;
        }

        [Benchmark]
        public byte Reflect_Byte()
        {
            return CRCUtility.BitReflect(value1);
        }

        [Benchmark]
        public ushort Reflect_UInt16()
        {
            return CRCUtility.BitReflect(value2);
        }

        [Benchmark]
        public uint Reflect_UInt32()
        {
            return CRCUtility.BitReflect(value3);
        }

        [Benchmark]
        public ulong Reflect_UInt64()
        {
            return CRCUtility.BitReflect(value4);
        }

        [Benchmark]
        public BigInteger Reflect_BigInteger()
        {
            return CRCUtility.BitReflect(value5);
        }
    }
}
