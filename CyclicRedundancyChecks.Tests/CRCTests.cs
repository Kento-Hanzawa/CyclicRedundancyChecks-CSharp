using System;
using System.IO;
using System.Text;
using Xunit;

namespace CyclicRedundancyChecks.Tests
{
    public class CRCTests
    {
        [Theory]
        [InlineData("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ")]
        public void Test1(string source)
        {
            var data = Encoding.ASCII.GetBytes(source);
            using (var crc = new CRC32(0x04C11DB7, 0xFFFFFFFF, 0xFFFFFFFF, true, true))
            {
                var hash = crc.ComputeHash(data);
                Assert.Equal(0x1A657BE2.ToString("X8"), BitConverter.ToUInt32(hash).ToString("X8"));
            }
        }
    }
}
