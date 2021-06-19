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
            return CryptoConfig.CreateFromName(algorithmName) as CRC;
        }
    }
}
