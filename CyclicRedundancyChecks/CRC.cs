using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

[assembly: InternalsVisibleTo("CyclicRedundancyChecks.Run")]
[assembly: InternalsVisibleTo("CyclicRedundancyChecks.Tests")]
namespace CyclicRedundancyChecks
{
    /// <summary>
    /// CRC (Cyclic Redundancy Check) のすべての実装が継承する必要のある抽象基底クラスを表します。
    /// </summary>
    public abstract class CRC : HashAlgorithm
    {
        protected const int TableSize = 256;

        public static new CRC Create()
        {
            return Create("CRC32");
        }

        public static new CRC? Create(string algorithmName)
        {
            return CryptoConfig.CreateFromName("CRC32") as CRC;
        }

        public static void RegisterAlgorithm()
        {
            CryptoConfig.AddAlgorithm(typeof(CRC8), "CRC8");
            CryptoConfig.AddAlgorithm(typeof(CRC16), "CRC16");
            CryptoConfig.AddAlgorithm(typeof(CRC32), "CRC32");
            CryptoConfig.AddAlgorithm(typeof(CRC64), "CRC64");
        }
    }
}
