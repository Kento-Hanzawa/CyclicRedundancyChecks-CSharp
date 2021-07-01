﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using CyclicRedundancyChecks.Catalogs;

namespace CyclicRedundancyChecks.Benchmark.Benchmarks
{
    [Config(typeof(BenchmarkConfig))]
    public class Unders
    {
        byte[] verySmallBytes;
        byte[] smallBytes;
        byte[] bigBytes;

        [GlobalSetup]
        public void Setup()
        {
            verySmallBytes = Encoding.ASCII.GetBytes("123456789");

            smallBytes = new byte[65536]; // 64KB
            System.Security.Cryptography.RandomNumberGenerator.Fill(smallBytes);

            bigBytes = new byte[67108864]; // 64MB
            System.Security.Cryptography.RandomNumberGenerator.Fill(bigBytes);
        }

        [Benchmark(Baseline = true)]
        public byte[] CRC_8_SMBUS_Small()
        {
            // 0x07, 0x00, 0x00, false, false
            using (var algorithm = new CRC_8_SMBUS())
            {
                return algorithm.ComputeHash(smallBytes);
            }
        }

        [Benchmark]
        public byte[] CRC_8_SMBUS_Big()
        {
            // 0x07, 0x00, 0x00, false, false
            using (var algorithm = new CRC_8_SMBUS())
            {
                return algorithm.ComputeHash(bigBytes);
            }
        }

        [Benchmark]
        public byte[] CRC_8_SMBUS_VSmall()
        {
            // 0x07, 0x00, 0x00, false, false
            using (var algorithm = new CRC_8_SMBUS())
            {
                return algorithm.ComputeHash(verySmallBytes);
            }
        }

        [Benchmark]
        public byte[] CRC_8_SMBUS_CRCUInt16_Small()
        {
            using (var algorithm = new UnderlyingTypes.CRCUInt16(8, 0x07, 0x00, 0x00, false, false))
            {
                return algorithm.ComputeHash(smallBytes);
            }
        }

        [Benchmark]
        public byte[] CRC_8_SMBUS_CRCUInt16_Big()
        {
            using (var algorithm = new UnderlyingTypes.CRCUInt16(8, 0x07, 0x00, 0x00, false, false))
            {
                return algorithm.ComputeHash(bigBytes);
            }
        }

        [Benchmark]
        public byte[] CRC_8_SMBUS_CRCUInt16_VSmall()
        {
            using (var algorithm = new UnderlyingTypes.CRCUInt16(8, 0x07, 0x00, 0x00, false, false))
            {
                return algorithm.ComputeHash(verySmallBytes);
            }
        }

        [Benchmark]
        public byte[] CRC_8_SMBUS_CRCUInt32_Small()
        {
            using (var algorithm = new UnderlyingTypes.CRCUInt32(8, 0x07, 0x00, 0x00, false, false))
            {
                return algorithm.ComputeHash(smallBytes);
            }
        }

        [Benchmark]
        public byte[] CRC_8_SMBUS_CRCUInt32_Big()
        {
            using (var algorithm = new UnderlyingTypes.CRCUInt32(8, 0x07, 0x00, 0x00, false, false))
            {
                return algorithm.ComputeHash(bigBytes);
            }
        }

        [Benchmark]
        public byte[] CRC_8_SMBUS_CRCUInt32_VSmall()
        {
            using (var algorithm = new UnderlyingTypes.CRCUInt32(8, 0x07, 0x00, 0x00, false, false))
            {
                return algorithm.ComputeHash(verySmallBytes);
            }
        }

        [Benchmark]
        public byte[] CRC_8_SMBUS_CRCUInt64_Small()
        {
            using (var algorithm = new UnderlyingTypes.CRCUInt64(8, 0x07, 0x00, 0x00, false, false))
            {
                return algorithm.ComputeHash(smallBytes);
            }
        }

        [Benchmark]
        public byte[] CRC_8_SMBUS_CRCUInt64_Big()
        {
            using (var algorithm = new UnderlyingTypes.CRCUInt64(8, 0x07, 0x00, 0x00, false, false))
            {
                return algorithm.ComputeHash(bigBytes);
            }
        }

        [Benchmark]
        public byte[] CRC_8_SMBUS_CRCUInt64_VSmall()
        {
            using (var algorithm = new UnderlyingTypes.CRCUInt64(8, 0x07, 0x00, 0x00, false, false))
            {
                return algorithm.ComputeHash(verySmallBytes);
            }
        }
    }
}