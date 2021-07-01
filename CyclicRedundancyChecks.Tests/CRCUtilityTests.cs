using System;
using System.Text;
using Xunit;

namespace CyclicRedundancyChecks.Tests
{
    public class CRCUtilityTests
    {
        #region CRCUtility.BitReverse()

        [Theory]
        [InlineData((byte)0b_10110111, (byte)0b_11101101)]
        [InlineData((byte)0b_11001100, (byte)0b_00110011)]
        [InlineData((byte)0b_01010101, (byte)0b_10101010)]
        public void BitReverse(byte value, byte expected)
        {
            Assert.Equal(expected, CRCUtility.BitReflect(value));
        }

        #endregion
    }
}
