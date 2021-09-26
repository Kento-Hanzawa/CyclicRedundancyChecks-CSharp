using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

[assembly: InternalsVisibleTo("CyclicRedundancyChecks.Run")]
[assembly: InternalsVisibleTo("CyclicRedundancyChecks.Tests")]
[assembly: InternalsVisibleTo("CyclicRedundancyChecks.Benchmark")]
namespace CyclicRedundancyChecks
{
    /// <summary>
    /// CRC (Cyclic Redundancy Check) のすべての実装が継承する必要のある抽象基底クラスを表します。
    /// </summary>
    public abstract partial class CRC : HashAlgorithm
    {
        protected const int LookupTableSize = 256;
    }
}
