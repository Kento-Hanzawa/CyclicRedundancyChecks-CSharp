//
// CyclicRedundancyChecks
// 
// このコードはテキストテンプレートファイル (.tt) によって作成されています。
// 変更をおこなう場合は、テキストテンプレートファイル (.tt) を編集してください。
//

using System;
using System.Buffers;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Text;
using Xunit;
using CyclicRedundancyChecks.Catalogs;

namespace CyclicRedundancyChecks.Tests
{
    public class CatalogTests
    {
        private static readonly byte[] TestData = Encoding.ASCII.GetBytes("123456789");

        #region ComputeHash()

        [Fact]
        public void CRC_3_GSM_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("004", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_3_GSM(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x1");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_3_GSM_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("004", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_3_GSM(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x1");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_3_ROHC_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("006", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_3_ROHC(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x1");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_3_ROHC_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("006", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_3_ROHC(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x1");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_4_G_704_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("007", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_4_G_704(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x1");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_4_G_704_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("007", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_4_G_704(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x1");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_4_INTERLAKEN_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00b", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_4_INTERLAKEN(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x1");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_4_INTERLAKEN_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00b", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_4_INTERLAKEN(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x1");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_5_EPC_C1G2_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0000", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_5_EPC_C1G2(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_5_EPC_C1G2_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0000", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_5_EPC_C1G2(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_5_G_704_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0007", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_5_G_704(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_5_G_704_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0007", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_5_G_704(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_5_USB_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0019", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_5_USB(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_5_USB_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0019", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_5_USB(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_6_CDMA2000_A_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("000d", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_CDMA2000_A(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_6_CDMA2000_A_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("000d", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_CDMA2000_A(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_6_CDMA2000_B_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("003b", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_CDMA2000_B(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_6_CDMA2000_B_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("003b", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_CDMA2000_B(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_6_DARC_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0026", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_DARC(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_6_DARC_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0026", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_DARC(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_6_G_704_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0006", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_G_704(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_6_G_704_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0006", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_G_704(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_6_GSM_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0013", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_GSM(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_6_GSM_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0013", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_GSM(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_7_MMC_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0075", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_7_MMC(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_7_MMC_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0075", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_7_MMC(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_7_ROHC_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0053", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_7_ROHC(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_7_ROHC_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0053", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_7_ROHC(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_7_UMTS_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0061", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_7_UMTS(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_7_UMTS_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0061", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_7_UMTS(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_AUTOSAR_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00df", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_AUTOSAR(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_AUTOSAR_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00df", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_AUTOSAR(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_BLUETOOTH_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0026", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_BLUETOOTH(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_BLUETOOTH_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0026", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_BLUETOOTH(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_CDMA2000_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00da", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_CDMA2000(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_CDMA2000_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00da", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_CDMA2000(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_DARC_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0015", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_DARC(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_DARC_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0015", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_DARC(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_DVB_S2_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00bc", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_DVB_S2(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_DVB_S2_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00bc", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_DVB_S2(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_GSM_A_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0037", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_GSM_A(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_GSM_A_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0037", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_GSM_A(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_GSM_B_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0094", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_GSM_B(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_GSM_B_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0094", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_GSM_B(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_I_432_1_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00a1", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_I_432_1(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_I_432_1_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00a1", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_I_432_1(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_I_CODE_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("007e", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_I_CODE(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_I_CODE_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("007e", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_I_CODE(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_LTE_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00ea", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_LTE(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_LTE_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00ea", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_LTE(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_MAXIM_DOW_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00a1", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_MAXIM_DOW(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_MAXIM_DOW_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00a1", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_MAXIM_DOW(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_MIFARE_MAD_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0099", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_MIFARE_MAD(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_MIFARE_MAD_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0099", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_MIFARE_MAD(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_NRSC_5_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00f7", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_NRSC_5(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_NRSC_5_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00f7", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_NRSC_5(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_OPENSAFETY_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("003e", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_OPENSAFETY(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_OPENSAFETY_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("003e", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_OPENSAFETY(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_ROHC_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00d0", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_ROHC(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_ROHC_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00d0", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_ROHC(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_SAE_J1850_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("004b", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_SAE_J1850(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_SAE_J1850_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("004b", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_SAE_J1850(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_SMBUS_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00f4", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_SMBUS(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_SMBUS_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00f4", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_SMBUS(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_TECH_3250_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0097", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_TECH_3250(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_TECH_3250_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0097", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_TECH_3250(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_WCDMA_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0025", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_WCDMA(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_WCDMA_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0025", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_WCDMA(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_10_ATM_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00199", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_10_ATM(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_10_ATM_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00199", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_10_ATM(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_10_CDMA2000_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00233", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_10_CDMA2000(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_10_CDMA2000_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00233", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_10_CDMA2000(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_10_GSM_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0012a", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_10_GSM(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_10_GSM_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0012a", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_10_GSM(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_11_FLEXRAY_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("005a3", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_11_FLEXRAY(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_11_FLEXRAY_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("005a3", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_11_FLEXRAY(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_11_UMTS_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00061", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_11_UMTS(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_11_UMTS_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00061", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_11_UMTS(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_12_CDMA2000_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00d4d", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_CDMA2000(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_12_CDMA2000_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00d4d", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_CDMA2000(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_12_DECT_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00f5b", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_DECT(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_12_DECT_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00f5b", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_DECT(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_12_GSM_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00b34", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_GSM(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_12_GSM_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00b34", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_GSM(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_12_UMTS_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00daf", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_UMTS(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_12_UMTS_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00daf", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_UMTS(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_13_BBC_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0004fa", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_13_BBC(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_13_BBC_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0004fa", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_13_BBC(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_14_DARC_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00082d", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_14_DARC(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_14_DARC_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00082d", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_14_DARC(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_14_GSM_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0030ae", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_14_GSM(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_14_GSM_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0030ae", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_14_GSM(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_15_CAN_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00059e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_15_CAN(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_15_CAN_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00059e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_15_CAN(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_15_MPT1327_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("002566", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_15_MPT1327(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_15_MPT1327_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("002566", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_15_MPT1327(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_ARC_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00bb3d", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_ARC(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_ARC_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00bb3d", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_ARC(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_CDMA2000_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("004c06", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_CDMA2000(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_CDMA2000_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("004c06", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_CDMA2000(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_CMS_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00aee7", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_CMS(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_CMS_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00aee7", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_CMS(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_DDS_110_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("009ecf", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DDS_110(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_DDS_110_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("009ecf", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DDS_110(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_DECT_R_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00007e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DECT_R(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_DECT_R_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00007e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DECT_R(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_DECT_X_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00007f", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DECT_X(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_DECT_X_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00007f", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DECT_X(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_DNP_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00ea82", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DNP(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_DNP_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00ea82", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DNP(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_EN_13757_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00c2b7", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_EN_13757(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_EN_13757_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00c2b7", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_EN_13757(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_GENIBUS_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00d64e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_GENIBUS(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_GENIBUS_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00d64e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_GENIBUS(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_GSM_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00ce3c", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_GSM(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_GSM_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00ce3c", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_GSM(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_IBM_3740_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0029b1", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_IBM_3740(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_IBM_3740_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0029b1", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_IBM_3740(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_IBM_SDLC_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00906e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_IBM_SDLC(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_IBM_SDLC_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00906e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_IBM_SDLC(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_ISO_IEC_14443_3_A_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00bf05", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_ISO_IEC_14443_3_A(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_ISO_IEC_14443_3_A_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00bf05", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_ISO_IEC_14443_3_A(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_KERMIT_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("002189", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_KERMIT(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_KERMIT_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("002189", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_KERMIT(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_LJ1200_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00bdf4", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_LJ1200(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_LJ1200_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00bdf4", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_LJ1200(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_MAXIM_DOW_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0044c2", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_MAXIM_DOW(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_MAXIM_DOW_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0044c2", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_MAXIM_DOW(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_MCRF4XX_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("006f91", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_MCRF4XX(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_MCRF4XX_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("006f91", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_MCRF4XX(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_MODBUS_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("004b37", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_MODBUS(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_MODBUS_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("004b37", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_MODBUS(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_NRSC_5_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00a066", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_NRSC_5(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_NRSC_5_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00a066", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_NRSC_5(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_OPENSAFETY_A_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("005d38", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_OPENSAFETY_A(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_OPENSAFETY_A_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("005d38", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_OPENSAFETY_A(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_OPENSAFETY_B_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0020fe", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_OPENSAFETY_B(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_OPENSAFETY_B_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0020fe", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_OPENSAFETY_B(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_PROFIBUS_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00a819", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_PROFIBUS(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_PROFIBUS_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00a819", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_PROFIBUS(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_RIELLO_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0063d0", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_RIELLO(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_RIELLO_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0063d0", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_RIELLO(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_SPI_FUJITSU_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00e5cc", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_SPI_FUJITSU(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_SPI_FUJITSU_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00e5cc", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_SPI_FUJITSU(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_T10_DIF_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00d0db", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_T10_DIF(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_T10_DIF_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00d0db", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_T10_DIF(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_TELEDISK_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("000fb3", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_TELEDISK(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_TELEDISK_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("000fb3", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_TELEDISK(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_TMS37157_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0026b1", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_TMS37157(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_TMS37157_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0026b1", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_TMS37157(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_UMTS_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00fee8", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_UMTS(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_UMTS_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00fee8", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_UMTS(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_USB_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00b4c8", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_USB(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_USB_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00b4c8", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_USB(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_XMODEM_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0031c3", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_XMODEM(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_XMODEM_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0031c3", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_XMODEM(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_17_CAN_FD_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0004f03", NumberStyles.AllowHexSpecifier).ToString("x5");
            using (var algorithm = new CRC_17_CAN_FD(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x5");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_17_CAN_FD_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0004f03", NumberStyles.AllowHexSpecifier).ToString("x5");
            using (var algorithm = new CRC_17_CAN_FD(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x5");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_21_CAN_FD_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("000ed841", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_21_CAN_FD(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_21_CAN_FD_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("000ed841", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_21_CAN_FD(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_BLE_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00c25a56", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_BLE(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_BLE_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00c25a56", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_BLE(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_FLEXRAY_A_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("007979bd", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_FLEXRAY_A(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_FLEXRAY_A_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("007979bd", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_FLEXRAY_A(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_FLEXRAY_B_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("001f23b8", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_FLEXRAY_B(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_FLEXRAY_B_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("001f23b8", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_FLEXRAY_B(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_INTERLAKEN_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00b4f3e6", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_INTERLAKEN(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_INTERLAKEN_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00b4f3e6", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_INTERLAKEN(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_LTE_A_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00cde703", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_LTE_A(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_LTE_A_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00cde703", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_LTE_A(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_LTE_B_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0023ef52", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_LTE_B(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_LTE_B_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0023ef52", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_LTE_B(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_OPENPGP_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0021cf02", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_OPENPGP(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_OPENPGP_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0021cf02", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_OPENPGP(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_OS_9_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00200fa5", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_OS_9(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_OS_9_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00200fa5", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_OS_9(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_30_CDMA_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0004c34abf", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_30_CDMA(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_30_CDMA_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0004c34abf", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_30_CDMA(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_31_PHILIPS_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("000ce9e46c", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_31_PHILIPS(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_31_PHILIPS_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("000ce9e46c", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_31_PHILIPS(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_AIXM_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("003010bf7f", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_AIXM(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_AIXM_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("003010bf7f", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_AIXM(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_AUTOSAR_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("001697d06a", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_AUTOSAR(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_AUTOSAR_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("001697d06a", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_AUTOSAR(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_BASE91_D_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0087315576", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_BASE91_D(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_BASE91_D_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0087315576", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_BASE91_D(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_BZIP2_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00fc891918", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_BZIP2(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_BZIP2_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00fc891918", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_BZIP2(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_CD_ROM_EDC_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("006ec2edc4", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_CD_ROM_EDC(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_CD_ROM_EDC_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("006ec2edc4", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_CD_ROM_EDC(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_CKSUM_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00765e7680", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_CKSUM(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_CKSUM_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00765e7680", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_CKSUM(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_ISCSI_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00e3069283", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_ISCSI(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_ISCSI_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00e3069283", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_ISCSI(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_ISO_HDLC_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00cbf43926", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_ISO_HDLC(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_ISO_HDLC_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00cbf43926", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_ISO_HDLC(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_JAMCRC_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00340bc6d9", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_JAMCRC(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_JAMCRC_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00340bc6d9", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_JAMCRC(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_MPEG_2_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("000376e6e7", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_MPEG_2(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_MPEG_2_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("000376e6e7", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_MPEG_2(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_XFER_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00bd0be338", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_XFER(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_XFER_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00bd0be338", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_XFER(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_40_GSM_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00d4164fc646", NumberStyles.AllowHexSpecifier).ToString("x10");
            using (var algorithm = new CRC_40_GSM(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x10");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_40_GSM_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00d4164fc646", NumberStyles.AllowHexSpecifier).ToString("x10");
            using (var algorithm = new CRC_40_GSM(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x10");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_64_ECMA_182_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("006c40df5f0b497347", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_ECMA_182(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x16");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_64_ECMA_182_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("006c40df5f0b497347", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_ECMA_182(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x16");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_64_GO_ISO_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00b90956c775a41001", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_GO_ISO(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x16");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_64_GO_ISO_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00b90956c775a41001", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_GO_ISO(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x16");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_64_WE_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0062ec59e3f1a4f00a", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_WE(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x16");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_64_WE_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0062ec59e3f1a4f00a", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_WE(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x16");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_64_XZ_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00995dc9bbdf1939fa", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_XZ(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x16");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_64_XZ_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("00995dc9bbdf1939fa", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_XZ(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x16");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_82_DARC_NotTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0009ea83f625023801fd612", NumberStyles.AllowHexSpecifier).ToString("x21");
            using (var algorithm = new CRC_82_DARC(isLookupTable: false))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x21");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_82_DARC_UseTable_ComputeHash()
        {
            var expected = "0x" + BigInteger.Parse("0009ea83f625023801fd612", NumberStyles.AllowHexSpecifier).ToString("x21");
            using (var algorithm = new CRC_82_DARC(isLookupTable: true))
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = "0x" + new BigInteger(hash, isUnsigned: true).ToString("x21");
                Assert.Equal(expected, actual);
            }
        }


        #endregion

        #region TransformBlock()

        [Fact]
        public void CRC_3_GSM_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("004", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_3_GSM(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x1");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_3_GSM_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("004", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_3_GSM(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x1");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_3_ROHC_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("006", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_3_ROHC(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x1");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_3_ROHC_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("006", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_3_ROHC(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x1");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_4_G_704_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("007", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_4_G_704(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x1");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_4_G_704_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("007", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_4_G_704(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x1");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_4_INTERLAKEN_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00b", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_4_INTERLAKEN(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x1");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_4_INTERLAKEN_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00b", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_4_INTERLAKEN(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x1");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_5_EPC_C1G2_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0000", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_5_EPC_C1G2(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_5_EPC_C1G2_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0000", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_5_EPC_C1G2(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_5_G_704_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0007", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_5_G_704(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_5_G_704_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0007", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_5_G_704(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_5_USB_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0019", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_5_USB(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_5_USB_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0019", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_5_USB(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_6_CDMA2000_A_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("000d", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_CDMA2000_A(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_6_CDMA2000_A_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("000d", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_CDMA2000_A(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_6_CDMA2000_B_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("003b", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_CDMA2000_B(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_6_CDMA2000_B_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("003b", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_CDMA2000_B(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_6_DARC_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0026", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_DARC(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_6_DARC_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0026", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_DARC(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_6_G_704_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0006", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_G_704(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_6_G_704_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0006", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_G_704(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_6_GSM_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0013", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_GSM(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_6_GSM_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0013", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_GSM(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_7_MMC_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0075", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_7_MMC(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_7_MMC_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0075", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_7_MMC(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_7_ROHC_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0053", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_7_ROHC(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_7_ROHC_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0053", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_7_ROHC(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_7_UMTS_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0061", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_7_UMTS(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_7_UMTS_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0061", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_7_UMTS(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_AUTOSAR_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00df", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_AUTOSAR(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_AUTOSAR_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00df", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_AUTOSAR(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_BLUETOOTH_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0026", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_BLUETOOTH(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_BLUETOOTH_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0026", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_BLUETOOTH(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_CDMA2000_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00da", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_CDMA2000(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_CDMA2000_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00da", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_CDMA2000(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_DARC_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0015", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_DARC(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_DARC_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0015", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_DARC(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_DVB_S2_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00bc", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_DVB_S2(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_DVB_S2_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00bc", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_DVB_S2(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_GSM_A_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0037", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_GSM_A(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_GSM_A_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0037", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_GSM_A(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_GSM_B_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0094", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_GSM_B(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_GSM_B_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0094", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_GSM_B(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_I_432_1_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00a1", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_I_432_1(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_I_432_1_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00a1", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_I_432_1(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_I_CODE_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("007e", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_I_CODE(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_I_CODE_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("007e", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_I_CODE(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_LTE_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00ea", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_LTE(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_LTE_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00ea", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_LTE(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_MAXIM_DOW_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00a1", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_MAXIM_DOW(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_MAXIM_DOW_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00a1", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_MAXIM_DOW(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_MIFARE_MAD_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0099", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_MIFARE_MAD(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_MIFARE_MAD_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0099", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_MIFARE_MAD(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_NRSC_5_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00f7", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_NRSC_5(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_NRSC_5_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00f7", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_NRSC_5(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_OPENSAFETY_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("003e", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_OPENSAFETY(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_OPENSAFETY_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("003e", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_OPENSAFETY(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_ROHC_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00d0", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_ROHC(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_ROHC_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00d0", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_ROHC(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_SAE_J1850_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("004b", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_SAE_J1850(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_SAE_J1850_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("004b", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_SAE_J1850(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_SMBUS_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00f4", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_SMBUS(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_SMBUS_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00f4", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_SMBUS(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_TECH_3250_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0097", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_TECH_3250(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_TECH_3250_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0097", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_TECH_3250(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_WCDMA_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0025", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_WCDMA(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_WCDMA_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0025", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_WCDMA(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_10_ATM_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00199", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_10_ATM(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_10_ATM_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00199", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_10_ATM(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_10_CDMA2000_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00233", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_10_CDMA2000(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_10_CDMA2000_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00233", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_10_CDMA2000(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_10_GSM_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0012a", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_10_GSM(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_10_GSM_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0012a", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_10_GSM(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_11_FLEXRAY_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("005a3", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_11_FLEXRAY(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_11_FLEXRAY_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("005a3", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_11_FLEXRAY(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_11_UMTS_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00061", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_11_UMTS(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_11_UMTS_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00061", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_11_UMTS(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_12_CDMA2000_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00d4d", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_CDMA2000(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_12_CDMA2000_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00d4d", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_CDMA2000(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_12_DECT_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00f5b", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_DECT(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_12_DECT_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00f5b", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_DECT(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_12_GSM_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00b34", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_GSM(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_12_GSM_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00b34", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_GSM(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_12_UMTS_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00daf", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_UMTS(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_12_UMTS_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00daf", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_UMTS(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_13_BBC_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0004fa", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_13_BBC(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_13_BBC_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0004fa", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_13_BBC(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_14_DARC_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00082d", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_14_DARC(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_14_DARC_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00082d", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_14_DARC(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_14_GSM_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0030ae", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_14_GSM(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_14_GSM_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0030ae", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_14_GSM(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_15_CAN_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00059e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_15_CAN(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_15_CAN_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00059e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_15_CAN(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_15_MPT1327_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("002566", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_15_MPT1327(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_15_MPT1327_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("002566", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_15_MPT1327(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_ARC_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00bb3d", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_ARC(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_ARC_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00bb3d", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_ARC(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_CDMA2000_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("004c06", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_CDMA2000(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_CDMA2000_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("004c06", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_CDMA2000(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_CMS_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00aee7", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_CMS(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_CMS_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00aee7", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_CMS(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_DDS_110_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("009ecf", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DDS_110(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_DDS_110_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("009ecf", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DDS_110(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_DECT_R_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00007e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DECT_R(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_DECT_R_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00007e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DECT_R(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_DECT_X_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00007f", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DECT_X(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_DECT_X_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00007f", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DECT_X(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_DNP_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00ea82", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DNP(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_DNP_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00ea82", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DNP(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_EN_13757_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00c2b7", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_EN_13757(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_EN_13757_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00c2b7", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_EN_13757(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_GENIBUS_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00d64e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_GENIBUS(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_GENIBUS_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00d64e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_GENIBUS(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_GSM_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00ce3c", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_GSM(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_GSM_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00ce3c", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_GSM(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_IBM_3740_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0029b1", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_IBM_3740(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_IBM_3740_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0029b1", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_IBM_3740(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_IBM_SDLC_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00906e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_IBM_SDLC(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_IBM_SDLC_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00906e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_IBM_SDLC(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_ISO_IEC_14443_3_A_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00bf05", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_ISO_IEC_14443_3_A(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_ISO_IEC_14443_3_A_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00bf05", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_ISO_IEC_14443_3_A(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_KERMIT_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("002189", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_KERMIT(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_KERMIT_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("002189", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_KERMIT(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_LJ1200_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00bdf4", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_LJ1200(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_LJ1200_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00bdf4", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_LJ1200(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_MAXIM_DOW_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0044c2", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_MAXIM_DOW(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_MAXIM_DOW_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0044c2", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_MAXIM_DOW(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_MCRF4XX_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("006f91", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_MCRF4XX(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_MCRF4XX_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("006f91", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_MCRF4XX(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_MODBUS_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("004b37", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_MODBUS(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_MODBUS_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("004b37", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_MODBUS(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_NRSC_5_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00a066", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_NRSC_5(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_NRSC_5_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00a066", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_NRSC_5(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_OPENSAFETY_A_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("005d38", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_OPENSAFETY_A(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_OPENSAFETY_A_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("005d38", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_OPENSAFETY_A(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_OPENSAFETY_B_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0020fe", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_OPENSAFETY_B(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_OPENSAFETY_B_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0020fe", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_OPENSAFETY_B(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_PROFIBUS_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00a819", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_PROFIBUS(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_PROFIBUS_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00a819", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_PROFIBUS(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_RIELLO_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0063d0", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_RIELLO(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_RIELLO_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0063d0", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_RIELLO(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_SPI_FUJITSU_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00e5cc", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_SPI_FUJITSU(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_SPI_FUJITSU_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00e5cc", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_SPI_FUJITSU(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_T10_DIF_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00d0db", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_T10_DIF(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_T10_DIF_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00d0db", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_T10_DIF(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_TELEDISK_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("000fb3", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_TELEDISK(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_TELEDISK_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("000fb3", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_TELEDISK(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_TMS37157_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0026b1", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_TMS37157(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_TMS37157_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0026b1", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_TMS37157(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_UMTS_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00fee8", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_UMTS(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_UMTS_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00fee8", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_UMTS(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_USB_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00b4c8", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_USB(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_USB_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00b4c8", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_USB(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_XMODEM_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0031c3", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_XMODEM(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_XMODEM_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0031c3", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_XMODEM(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_17_CAN_FD_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0004f03", NumberStyles.AllowHexSpecifier).ToString("x5");
            using (var algorithm = new CRC_17_CAN_FD(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x5");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_17_CAN_FD_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0004f03", NumberStyles.AllowHexSpecifier).ToString("x5");
            using (var algorithm = new CRC_17_CAN_FD(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x5");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_21_CAN_FD_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("000ed841", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_21_CAN_FD(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_21_CAN_FD_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("000ed841", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_21_CAN_FD(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_BLE_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00c25a56", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_BLE(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_BLE_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00c25a56", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_BLE(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_FLEXRAY_A_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("007979bd", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_FLEXRAY_A(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_FLEXRAY_A_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("007979bd", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_FLEXRAY_A(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_FLEXRAY_B_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("001f23b8", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_FLEXRAY_B(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_FLEXRAY_B_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("001f23b8", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_FLEXRAY_B(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_INTERLAKEN_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00b4f3e6", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_INTERLAKEN(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_INTERLAKEN_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00b4f3e6", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_INTERLAKEN(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_LTE_A_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00cde703", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_LTE_A(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_LTE_A_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00cde703", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_LTE_A(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_LTE_B_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0023ef52", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_LTE_B(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_LTE_B_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0023ef52", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_LTE_B(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_OPENPGP_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0021cf02", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_OPENPGP(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_OPENPGP_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0021cf02", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_OPENPGP(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_OS_9_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00200fa5", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_OS_9(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_OS_9_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00200fa5", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_OS_9(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_30_CDMA_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0004c34abf", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_30_CDMA(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_30_CDMA_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0004c34abf", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_30_CDMA(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_31_PHILIPS_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("000ce9e46c", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_31_PHILIPS(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_31_PHILIPS_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("000ce9e46c", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_31_PHILIPS(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_AIXM_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("003010bf7f", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_AIXM(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_AIXM_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("003010bf7f", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_AIXM(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_AUTOSAR_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("001697d06a", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_AUTOSAR(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_AUTOSAR_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("001697d06a", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_AUTOSAR(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_BASE91_D_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0087315576", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_BASE91_D(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_BASE91_D_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0087315576", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_BASE91_D(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_BZIP2_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00fc891918", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_BZIP2(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_BZIP2_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00fc891918", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_BZIP2(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_CD_ROM_EDC_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("006ec2edc4", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_CD_ROM_EDC(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_CD_ROM_EDC_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("006ec2edc4", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_CD_ROM_EDC(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_CKSUM_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00765e7680", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_CKSUM(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_CKSUM_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00765e7680", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_CKSUM(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_ISCSI_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00e3069283", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_ISCSI(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_ISCSI_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00e3069283", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_ISCSI(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_ISO_HDLC_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00cbf43926", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_ISO_HDLC(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_ISO_HDLC_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00cbf43926", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_ISO_HDLC(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_JAMCRC_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00340bc6d9", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_JAMCRC(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_JAMCRC_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00340bc6d9", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_JAMCRC(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_MPEG_2_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("000376e6e7", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_MPEG_2(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_MPEG_2_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("000376e6e7", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_MPEG_2(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_XFER_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00bd0be338", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_XFER(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_XFER_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00bd0be338", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_XFER(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_40_GSM_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00d4164fc646", NumberStyles.AllowHexSpecifier).ToString("x10");
            using (var algorithm = new CRC_40_GSM(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x10");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_40_GSM_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00d4164fc646", NumberStyles.AllowHexSpecifier).ToString("x10");
            using (var algorithm = new CRC_40_GSM(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x10");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_64_ECMA_182_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("006c40df5f0b497347", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_ECMA_182(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x16");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_64_ECMA_182_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("006c40df5f0b497347", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_ECMA_182(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x16");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_64_GO_ISO_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00b90956c775a41001", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_GO_ISO(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x16");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_64_GO_ISO_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00b90956c775a41001", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_GO_ISO(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x16");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_64_WE_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0062ec59e3f1a4f00a", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_WE(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x16");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_64_WE_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0062ec59e3f1a4f00a", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_WE(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x16");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_64_XZ_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00995dc9bbdf1939fa", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_XZ(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x16");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_64_XZ_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("00995dc9bbdf1939fa", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_XZ(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x16");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_82_DARC_NotTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0009ea83f625023801fd612", NumberStyles.AllowHexSpecifier).ToString("x21");
            using (var algorithm = new CRC_82_DARC(isLookupTable: false))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x21");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_82_DARC_UseTable_TransformBlock()
        {
            var expected = "0x" + BigInteger.Parse("0009ea83f625023801fd612", NumberStyles.AllowHexSpecifier).ToString("x21");
            using (var algorithm = new CRC_82_DARC(isLookupTable: true))
            using (var stream = new MemoryStream(TestData))
            {
                var buffer = ArrayPool<byte>.Shared.Rent(1);
                try
                {
                    Span<byte> span = buffer.AsSpan(0, 1);
                    var readSize = 0;
                    while (0 < (readSize = stream.Read(span)))
                    {
                        algorithm.TransformBlock(buffer, 0, readSize, null, 0);
                    }
                    algorithm.TransformFinalBlock(buffer, 0, readSize);
                    var actual = "0x" + new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x21");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }


        #endregion
    }
}
