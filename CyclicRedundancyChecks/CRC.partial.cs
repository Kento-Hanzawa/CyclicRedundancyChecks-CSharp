using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

[assembly: InternalsVisibleTo("CyclicRedundancyChecks.Run")]
[assembly: InternalsVisibleTo("CyclicRedundancyChecks.Tests")]
namespace CyclicRedundancyChecks
{
    partial class CRC
    {
        public static new CRC Create()
        {
            return new CRC32_STANDARD();
        }

        public static new CRC? Create(string algorithmName)
        {
            RegisterAlgorithm();
            return CryptoConfig.CreateFromName(algorithmName) as CRC;
        }
    }

    partial class CRC8
    {
        public static new CRC8 Create()
        {
            return new CRC8_STANDARD();
        }

        public static new CRC8? Create(string algorithmName)
        {
            RegisterAlgorithm();
            return CryptoConfig.CreateFromName(algorithmName) as CRC8;
        }
    }

    partial class CRC16
    {
        public static new CRC16 Create()
        {
            return new CRC16_USB();
        }

        public static new CRC16? Create(string algorithmName)
        {
            RegisterAlgorithm();
            return CryptoConfig.CreateFromName(algorithmName) as CRC16;
        }
    }

    partial class CRC32
    {
        public static new CRC32 Create()
        {
            return new CRC32_STANDARD();
        }

        public static new CRC32? Create(string algorithmName)
        {
            RegisterAlgorithm();
            return CryptoConfig.CreateFromName(algorithmName) as CRC32;
        }
    }

    partial class CRC64
    {
        public static new CRC64 Create()
        {
            return new CRC64_ECMA_182();
        }

        public static new CRC64? Create(string algorithmName)
        {
            RegisterAlgorithm();
            return CryptoConfig.CreateFromName(algorithmName) as CRC64;
        }
    }
}
