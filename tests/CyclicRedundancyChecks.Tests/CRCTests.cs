using System;
using System.Text;
using Xunit;

namespace CyclicRedundancyChecks.Tests
{
    public class CRCTests
    {
        [Theory]
        [InlineData("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ")]
        public void CRC32_RefIn_RefOut(string source)
        {
            var data = Encoding.ASCII.GetBytes(source);
            using (var crc = new CRC32(0x04C11DB7, 0xFFFFFFFF, 0xFFFFFFFF, true, true))
            {
                var hash = crc.ComputeHash(data);
                Assert.Equal((uint)0x1A657BE2, BitConverter.ToUInt32(hash));
            }
        }

        [Theory]
        [InlineData("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ")]
        public void CRC32_RefIn(string source)
        {
            var data = Encoding.ASCII.GetBytes(source);
            using (var crc = new CRC32(0x04C11DB7, 0xFFFFFFFF, 0xFFFFFFFF, true, false))
            {
                var hash = crc.ComputeHash(data);
                Assert.Equal((uint)0x47DEA658, BitConverter.ToUInt32(hash));
            }
        }

        [Theory]
        [InlineData("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ")]
        public void CRC32_RefOut(string source)
        {
            var data = Encoding.ASCII.GetBytes(source);
            using (var crc = new CRC32(0x04C11DB7, 0xFFFFFFFF, 0xFFFFFFFF, false, true))
            {
                var hash = crc.ComputeHash(data);
                Assert.Equal((uint)0xE7485EDD, BitConverter.ToUInt32(hash));
            }
        }

        [Theory]
        [InlineData("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ")]
        public void CRC32(string source)
        {
            var data = Encoding.ASCII.GetBytes(source);
            using (var crc = new CRC32(0x04C11DB7, 0xFFFFFFFF, 0xFFFFFFFF, false, false))
            {
                var hash = crc.ComputeHash(data);
                Assert.Equal((uint)0xBB7A12E7, BitConverter.ToUInt32(hash));
            }
        }
    }
}
