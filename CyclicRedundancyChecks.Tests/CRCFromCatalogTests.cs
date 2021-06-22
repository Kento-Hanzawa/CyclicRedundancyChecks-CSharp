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

namespace CyclicRedundancyChecks.Tests
{
    public class CRCFromCatalogTests
    {
        private static readonly byte[] TestData = Encoding.ASCII.GetBytes("123456789");

        #region ComputeHash()

        [Fact]
        public void CRC_3_GSM_ComputeHash()
        {
            var expected = BigInteger.Parse("04", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_3_GSM())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x1");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_3_ROHC_ComputeHash()
        {
            var expected = BigInteger.Parse("06", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_3_ROHC())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x1");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_4_G_704_ComputeHash()
        {
            var expected = BigInteger.Parse("07", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_4_G_704())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x1");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_4_INTERLAKEN_ComputeHash()
        {
            var expected = BigInteger.Parse("0b", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_4_INTERLAKEN())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x1");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_5_EPC_C1G2_ComputeHash()
        {
            var expected = BigInteger.Parse("000", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_5_EPC_C1G2())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_5_G_704_ComputeHash()
        {
            var expected = BigInteger.Parse("007", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_5_G_704())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_5_USB_ComputeHash()
        {
            var expected = BigInteger.Parse("019", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_5_USB())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_6_CDMA2000_A_ComputeHash()
        {
            var expected = BigInteger.Parse("00d", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_CDMA2000_A())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_6_CDMA2000_B_ComputeHash()
        {
            var expected = BigInteger.Parse("03b", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_CDMA2000_B())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_6_DARC_ComputeHash()
        {
            var expected = BigInteger.Parse("026", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_DARC())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_6_G_704_ComputeHash()
        {
            var expected = BigInteger.Parse("006", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_G_704())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_6_GSM_ComputeHash()
        {
            var expected = BigInteger.Parse("013", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_GSM())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_7_MMC_ComputeHash()
        {
            var expected = BigInteger.Parse("075", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_7_MMC())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_7_ROHC_ComputeHash()
        {
            var expected = BigInteger.Parse("053", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_7_ROHC())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_7_UMTS_ComputeHash()
        {
            var expected = BigInteger.Parse("061", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_7_UMTS())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_AUTOSAR_ComputeHash()
        {
            var expected = BigInteger.Parse("0df", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_AUTOSAR())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_BLUETOOTH_ComputeHash()
        {
            var expected = BigInteger.Parse("026", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_BLUETOOTH())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_CDMA2000_ComputeHash()
        {
            var expected = BigInteger.Parse("0da", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_CDMA2000())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_DARC_ComputeHash()
        {
            var expected = BigInteger.Parse("015", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_DARC())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_DVB_S2_ComputeHash()
        {
            var expected = BigInteger.Parse("0bc", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_DVB_S2())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_GSM_A_ComputeHash()
        {
            var expected = BigInteger.Parse("037", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_GSM_A())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_GSM_B_ComputeHash()
        {
            var expected = BigInteger.Parse("094", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_GSM_B())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_I_432_1_ComputeHash()
        {
            var expected = BigInteger.Parse("0a1", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_I_432_1())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_I_CODE_ComputeHash()
        {
            var expected = BigInteger.Parse("07e", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_I_CODE())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_LTE_ComputeHash()
        {
            var expected = BigInteger.Parse("0ea", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_LTE())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_MAXIM_DOW_ComputeHash()
        {
            var expected = BigInteger.Parse("0a1", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_MAXIM_DOW())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_MIFARE_MAD_ComputeHash()
        {
            var expected = BigInteger.Parse("099", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_MIFARE_MAD())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_NRSC_5_ComputeHash()
        {
            var expected = BigInteger.Parse("0f7", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_NRSC_5())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_OPENSAFETY_ComputeHash()
        {
            var expected = BigInteger.Parse("03e", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_OPENSAFETY())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_ROHC_ComputeHash()
        {
            var expected = BigInteger.Parse("0d0", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_ROHC())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_SAE_J1850_ComputeHash()
        {
            var expected = BigInteger.Parse("04b", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_SAE_J1850())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_SMBUS_ComputeHash()
        {
            var expected = BigInteger.Parse("0f4", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_SMBUS())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_TECH_3250_ComputeHash()
        {
            var expected = BigInteger.Parse("097", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_TECH_3250())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_8_WCDMA_ComputeHash()
        {
            var expected = BigInteger.Parse("025", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_WCDMA())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x2");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_10_ATM_ComputeHash()
        {
            var expected = BigInteger.Parse("0199", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_10_ATM())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_10_CDMA2000_ComputeHash()
        {
            var expected = BigInteger.Parse("0233", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_10_CDMA2000())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_10_GSM_ComputeHash()
        {
            var expected = BigInteger.Parse("012a", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_10_GSM())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_11_FLEXRAY_ComputeHash()
        {
            var expected = BigInteger.Parse("05a3", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_11_FLEXRAY())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_11_UMTS_ComputeHash()
        {
            var expected = BigInteger.Parse("0061", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_11_UMTS())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_12_CDMA2000_ComputeHash()
        {
            var expected = BigInteger.Parse("0d4d", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_CDMA2000())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_12_DECT_ComputeHash()
        {
            var expected = BigInteger.Parse("0f5b", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_DECT())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_12_GSM_ComputeHash()
        {
            var expected = BigInteger.Parse("0b34", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_GSM())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_12_UMTS_ComputeHash()
        {
            var expected = BigInteger.Parse("0daf", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_UMTS())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x3");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_13_BBC_ComputeHash()
        {
            var expected = BigInteger.Parse("004fa", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_13_BBC())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_14_DARC_ComputeHash()
        {
            var expected = BigInteger.Parse("0082d", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_14_DARC())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_14_GSM_ComputeHash()
        {
            var expected = BigInteger.Parse("030ae", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_14_GSM())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_15_CAN_ComputeHash()
        {
            var expected = BigInteger.Parse("0059e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_15_CAN())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_15_MPT1327_ComputeHash()
        {
            var expected = BigInteger.Parse("02566", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_15_MPT1327())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_ARC_ComputeHash()
        {
            var expected = BigInteger.Parse("0bb3d", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_ARC())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_CDMA2000_ComputeHash()
        {
            var expected = BigInteger.Parse("04c06", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_CDMA2000())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_CMS_ComputeHash()
        {
            var expected = BigInteger.Parse("0aee7", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_CMS())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_DDS_110_ComputeHash()
        {
            var expected = BigInteger.Parse("09ecf", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DDS_110())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_DECT_R_ComputeHash()
        {
            var expected = BigInteger.Parse("0007e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DECT_R())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_DECT_X_ComputeHash()
        {
            var expected = BigInteger.Parse("0007f", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DECT_X())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_DNP_ComputeHash()
        {
            var expected = BigInteger.Parse("0ea82", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DNP())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_EN_13757_ComputeHash()
        {
            var expected = BigInteger.Parse("0c2b7", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_EN_13757())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_GENIBUS_ComputeHash()
        {
            var expected = BigInteger.Parse("0d64e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_GENIBUS())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_GSM_ComputeHash()
        {
            var expected = BigInteger.Parse("0ce3c", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_GSM())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_IBM_3740_ComputeHash()
        {
            var expected = BigInteger.Parse("029b1", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_IBM_3740())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_IBM_SDLC_ComputeHash()
        {
            var expected = BigInteger.Parse("0906e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_IBM_SDLC())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_ISO_IEC_14443_3_A_ComputeHash()
        {
            var expected = BigInteger.Parse("0bf05", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_ISO_IEC_14443_3_A())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_KERMIT_ComputeHash()
        {
            var expected = BigInteger.Parse("02189", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_KERMIT())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_LJ1200_ComputeHash()
        {
            var expected = BigInteger.Parse("0bdf4", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_LJ1200())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_MAXIM_DOW_ComputeHash()
        {
            var expected = BigInteger.Parse("044c2", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_MAXIM_DOW())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_MCRF4XX_ComputeHash()
        {
            var expected = BigInteger.Parse("06f91", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_MCRF4XX())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_MODBUS_ComputeHash()
        {
            var expected = BigInteger.Parse("04b37", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_MODBUS())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_NRSC_5_ComputeHash()
        {
            var expected = BigInteger.Parse("0a066", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_NRSC_5())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_OPENSAFETY_A_ComputeHash()
        {
            var expected = BigInteger.Parse("05d38", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_OPENSAFETY_A())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_OPENSAFETY_B_ComputeHash()
        {
            var expected = BigInteger.Parse("020fe", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_OPENSAFETY_B())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_PROFIBUS_ComputeHash()
        {
            var expected = BigInteger.Parse("0a819", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_PROFIBUS())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_RIELLO_ComputeHash()
        {
            var expected = BigInteger.Parse("063d0", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_RIELLO())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_SPI_FUJITSU_ComputeHash()
        {
            var expected = BigInteger.Parse("0e5cc", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_SPI_FUJITSU())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_T10_DIF_ComputeHash()
        {
            var expected = BigInteger.Parse("0d0db", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_T10_DIF())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_TELEDISK_ComputeHash()
        {
            var expected = BigInteger.Parse("00fb3", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_TELEDISK())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_TMS37157_ComputeHash()
        {
            var expected = BigInteger.Parse("026b1", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_TMS37157())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_UMTS_ComputeHash()
        {
            var expected = BigInteger.Parse("0fee8", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_UMTS())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_USB_ComputeHash()
        {
            var expected = BigInteger.Parse("0b4c8", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_USB())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_16_XMODEM_ComputeHash()
        {
            var expected = BigInteger.Parse("031c3", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_XMODEM())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x4");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_17_CAN_FD_ComputeHash()
        {
            var expected = BigInteger.Parse("004f03", NumberStyles.AllowHexSpecifier).ToString("x5");
            using (var algorithm = new CRC_17_CAN_FD())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x5");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_21_CAN_FD_ComputeHash()
        {
            var expected = BigInteger.Parse("00ed841", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_21_CAN_FD())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_BLE_ComputeHash()
        {
            var expected = BigInteger.Parse("0c25a56", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_BLE())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_FLEXRAY_A_ComputeHash()
        {
            var expected = BigInteger.Parse("07979bd", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_FLEXRAY_A())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_FLEXRAY_B_ComputeHash()
        {
            var expected = BigInteger.Parse("01f23b8", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_FLEXRAY_B())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_INTERLAKEN_ComputeHash()
        {
            var expected = BigInteger.Parse("0b4f3e6", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_INTERLAKEN())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_LTE_A_ComputeHash()
        {
            var expected = BigInteger.Parse("0cde703", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_LTE_A())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_LTE_B_ComputeHash()
        {
            var expected = BigInteger.Parse("023ef52", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_LTE_B())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_OPENPGP_ComputeHash()
        {
            var expected = BigInteger.Parse("021cf02", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_OPENPGP())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_24_OS_9_ComputeHash()
        {
            var expected = BigInteger.Parse("0200fa5", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_OS_9())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x6");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_30_CDMA_ComputeHash()
        {
            var expected = BigInteger.Parse("004c34abf", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_30_CDMA())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_31_PHILIPS_ComputeHash()
        {
            var expected = BigInteger.Parse("00ce9e46c", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_31_PHILIPS())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_AIXM_ComputeHash()
        {
            var expected = BigInteger.Parse("03010bf7f", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_AIXM())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_AUTOSAR_ComputeHash()
        {
            var expected = BigInteger.Parse("01697d06a", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_AUTOSAR())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_BASE91_D_ComputeHash()
        {
            var expected = BigInteger.Parse("087315576", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_BASE91_D())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_BZIP2_ComputeHash()
        {
            var expected = BigInteger.Parse("0fc891918", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_BZIP2())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_CD_ROM_EDC_ComputeHash()
        {
            var expected = BigInteger.Parse("06ec2edc4", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_CD_ROM_EDC())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_CKSUM_ComputeHash()
        {
            var expected = BigInteger.Parse("0765e7680", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_CKSUM())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_ISCSI_ComputeHash()
        {
            var expected = BigInteger.Parse("0e3069283", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_ISCSI())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_ISO_HDLC_ComputeHash()
        {
            var expected = BigInteger.Parse("0cbf43926", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_ISO_HDLC())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_JAMCRC_ComputeHash()
        {
            var expected = BigInteger.Parse("0340bc6d9", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_JAMCRC())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_MPEG_2_ComputeHash()
        {
            var expected = BigInteger.Parse("00376e6e7", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_MPEG_2())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_32_XFER_ComputeHash()
        {
            var expected = BigInteger.Parse("0bd0be338", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_XFER())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x8");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_40_GSM_ComputeHash()
        {
            var expected = BigInteger.Parse("0d4164fc646", NumberStyles.AllowHexSpecifier).ToString("x10");
            using (var algorithm = new CRC_40_GSM())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x10");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_64_ECMA_182_ComputeHash()
        {
            var expected = BigInteger.Parse("06c40df5f0b497347", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_ECMA_182())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x16");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_64_GO_ISO_ComputeHash()
        {
            var expected = BigInteger.Parse("0b90956c775a41001", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_GO_ISO())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x16");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_64_WE_ComputeHash()
        {
            var expected = BigInteger.Parse("062ec59e3f1a4f00a", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_WE())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x16");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_64_XZ_ComputeHash()
        {
            var expected = BigInteger.Parse("0995dc9bbdf1939fa", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_XZ())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x16");
                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CRC_82_DARC_ComputeHash()
        {
            var expected = BigInteger.Parse("0009ea83f625023801fd612", NumberStyles.AllowHexSpecifier).ToString("x21");
            using (var algorithm = new CRC_82_DARC())
            {
                var hash = algorithm.ComputeHash(TestData);
                var actual = new BigInteger(hash, isUnsigned: true).ToString("x21");
                Assert.Equal(expected, actual);
            }
        }


        #endregion

        #region TransformBlock()

        [Fact]
        public void CRC_3_GSM_TransformBlock()
        {
            var expected = BigInteger.Parse("04", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_3_GSM())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x1");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_3_ROHC_TransformBlock()
        {
            var expected = BigInteger.Parse("06", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_3_ROHC())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x1");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_4_G_704_TransformBlock()
        {
            var expected = BigInteger.Parse("07", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_4_G_704())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x1");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_4_INTERLAKEN_TransformBlock()
        {
            var expected = BigInteger.Parse("0b", NumberStyles.AllowHexSpecifier).ToString("x1");
            using (var algorithm = new CRC_4_INTERLAKEN())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x1");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_5_EPC_C1G2_TransformBlock()
        {
            var expected = BigInteger.Parse("000", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_5_EPC_C1G2())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_5_G_704_TransformBlock()
        {
            var expected = BigInteger.Parse("007", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_5_G_704())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_5_USB_TransformBlock()
        {
            var expected = BigInteger.Parse("019", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_5_USB())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_6_CDMA2000_A_TransformBlock()
        {
            var expected = BigInteger.Parse("00d", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_CDMA2000_A())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_6_CDMA2000_B_TransformBlock()
        {
            var expected = BigInteger.Parse("03b", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_CDMA2000_B())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_6_DARC_TransformBlock()
        {
            var expected = BigInteger.Parse("026", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_DARC())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_6_G_704_TransformBlock()
        {
            var expected = BigInteger.Parse("006", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_G_704())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_6_GSM_TransformBlock()
        {
            var expected = BigInteger.Parse("013", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_6_GSM())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_7_MMC_TransformBlock()
        {
            var expected = BigInteger.Parse("075", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_7_MMC())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_7_ROHC_TransformBlock()
        {
            var expected = BigInteger.Parse("053", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_7_ROHC())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_7_UMTS_TransformBlock()
        {
            var expected = BigInteger.Parse("061", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_7_UMTS())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_AUTOSAR_TransformBlock()
        {
            var expected = BigInteger.Parse("0df", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_AUTOSAR())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_BLUETOOTH_TransformBlock()
        {
            var expected = BigInteger.Parse("026", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_BLUETOOTH())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_CDMA2000_TransformBlock()
        {
            var expected = BigInteger.Parse("0da", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_CDMA2000())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_DARC_TransformBlock()
        {
            var expected = BigInteger.Parse("015", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_DARC())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_DVB_S2_TransformBlock()
        {
            var expected = BigInteger.Parse("0bc", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_DVB_S2())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_GSM_A_TransformBlock()
        {
            var expected = BigInteger.Parse("037", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_GSM_A())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_GSM_B_TransformBlock()
        {
            var expected = BigInteger.Parse("094", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_GSM_B())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_I_432_1_TransformBlock()
        {
            var expected = BigInteger.Parse("0a1", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_I_432_1())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_I_CODE_TransformBlock()
        {
            var expected = BigInteger.Parse("07e", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_I_CODE())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_LTE_TransformBlock()
        {
            var expected = BigInteger.Parse("0ea", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_LTE())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_MAXIM_DOW_TransformBlock()
        {
            var expected = BigInteger.Parse("0a1", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_MAXIM_DOW())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_MIFARE_MAD_TransformBlock()
        {
            var expected = BigInteger.Parse("099", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_MIFARE_MAD())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_NRSC_5_TransformBlock()
        {
            var expected = BigInteger.Parse("0f7", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_NRSC_5())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_OPENSAFETY_TransformBlock()
        {
            var expected = BigInteger.Parse("03e", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_OPENSAFETY())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_ROHC_TransformBlock()
        {
            var expected = BigInteger.Parse("0d0", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_ROHC())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_SAE_J1850_TransformBlock()
        {
            var expected = BigInteger.Parse("04b", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_SAE_J1850())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_SMBUS_TransformBlock()
        {
            var expected = BigInteger.Parse("0f4", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_SMBUS())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_TECH_3250_TransformBlock()
        {
            var expected = BigInteger.Parse("097", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_TECH_3250())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_8_WCDMA_TransformBlock()
        {
            var expected = BigInteger.Parse("025", NumberStyles.AllowHexSpecifier).ToString("x2");
            using (var algorithm = new CRC_8_WCDMA())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x2");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_10_ATM_TransformBlock()
        {
            var expected = BigInteger.Parse("0199", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_10_ATM())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_10_CDMA2000_TransformBlock()
        {
            var expected = BigInteger.Parse("0233", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_10_CDMA2000())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_10_GSM_TransformBlock()
        {
            var expected = BigInteger.Parse("012a", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_10_GSM())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_11_FLEXRAY_TransformBlock()
        {
            var expected = BigInteger.Parse("05a3", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_11_FLEXRAY())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_11_UMTS_TransformBlock()
        {
            var expected = BigInteger.Parse("0061", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_11_UMTS())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_12_CDMA2000_TransformBlock()
        {
            var expected = BigInteger.Parse("0d4d", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_CDMA2000())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_12_DECT_TransformBlock()
        {
            var expected = BigInteger.Parse("0f5b", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_DECT())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_12_GSM_TransformBlock()
        {
            var expected = BigInteger.Parse("0b34", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_GSM())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_12_UMTS_TransformBlock()
        {
            var expected = BigInteger.Parse("0daf", NumberStyles.AllowHexSpecifier).ToString("x3");
            using (var algorithm = new CRC_12_UMTS())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x3");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_13_BBC_TransformBlock()
        {
            var expected = BigInteger.Parse("004fa", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_13_BBC())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_14_DARC_TransformBlock()
        {
            var expected = BigInteger.Parse("0082d", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_14_DARC())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_14_GSM_TransformBlock()
        {
            var expected = BigInteger.Parse("030ae", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_14_GSM())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_15_CAN_TransformBlock()
        {
            var expected = BigInteger.Parse("0059e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_15_CAN())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_15_MPT1327_TransformBlock()
        {
            var expected = BigInteger.Parse("02566", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_15_MPT1327())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_ARC_TransformBlock()
        {
            var expected = BigInteger.Parse("0bb3d", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_ARC())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_CDMA2000_TransformBlock()
        {
            var expected = BigInteger.Parse("04c06", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_CDMA2000())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_CMS_TransformBlock()
        {
            var expected = BigInteger.Parse("0aee7", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_CMS())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_DDS_110_TransformBlock()
        {
            var expected = BigInteger.Parse("09ecf", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DDS_110())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_DECT_R_TransformBlock()
        {
            var expected = BigInteger.Parse("0007e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DECT_R())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_DECT_X_TransformBlock()
        {
            var expected = BigInteger.Parse("0007f", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DECT_X())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_DNP_TransformBlock()
        {
            var expected = BigInteger.Parse("0ea82", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_DNP())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_EN_13757_TransformBlock()
        {
            var expected = BigInteger.Parse("0c2b7", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_EN_13757())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_GENIBUS_TransformBlock()
        {
            var expected = BigInteger.Parse("0d64e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_GENIBUS())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_GSM_TransformBlock()
        {
            var expected = BigInteger.Parse("0ce3c", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_GSM())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_IBM_3740_TransformBlock()
        {
            var expected = BigInteger.Parse("029b1", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_IBM_3740())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_IBM_SDLC_TransformBlock()
        {
            var expected = BigInteger.Parse("0906e", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_IBM_SDLC())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_ISO_IEC_14443_3_A_TransformBlock()
        {
            var expected = BigInteger.Parse("0bf05", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_ISO_IEC_14443_3_A())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_KERMIT_TransformBlock()
        {
            var expected = BigInteger.Parse("02189", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_KERMIT())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_LJ1200_TransformBlock()
        {
            var expected = BigInteger.Parse("0bdf4", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_LJ1200())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_MAXIM_DOW_TransformBlock()
        {
            var expected = BigInteger.Parse("044c2", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_MAXIM_DOW())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_MCRF4XX_TransformBlock()
        {
            var expected = BigInteger.Parse("06f91", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_MCRF4XX())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_MODBUS_TransformBlock()
        {
            var expected = BigInteger.Parse("04b37", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_MODBUS())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_NRSC_5_TransformBlock()
        {
            var expected = BigInteger.Parse("0a066", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_NRSC_5())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_OPENSAFETY_A_TransformBlock()
        {
            var expected = BigInteger.Parse("05d38", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_OPENSAFETY_A())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_OPENSAFETY_B_TransformBlock()
        {
            var expected = BigInteger.Parse("020fe", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_OPENSAFETY_B())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_PROFIBUS_TransformBlock()
        {
            var expected = BigInteger.Parse("0a819", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_PROFIBUS())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_RIELLO_TransformBlock()
        {
            var expected = BigInteger.Parse("063d0", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_RIELLO())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_SPI_FUJITSU_TransformBlock()
        {
            var expected = BigInteger.Parse("0e5cc", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_SPI_FUJITSU())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_T10_DIF_TransformBlock()
        {
            var expected = BigInteger.Parse("0d0db", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_T10_DIF())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_TELEDISK_TransformBlock()
        {
            var expected = BigInteger.Parse("00fb3", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_TELEDISK())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_TMS37157_TransformBlock()
        {
            var expected = BigInteger.Parse("026b1", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_TMS37157())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_UMTS_TransformBlock()
        {
            var expected = BigInteger.Parse("0fee8", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_UMTS())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_USB_TransformBlock()
        {
            var expected = BigInteger.Parse("0b4c8", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_USB())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_16_XMODEM_TransformBlock()
        {
            var expected = BigInteger.Parse("031c3", NumberStyles.AllowHexSpecifier).ToString("x4");
            using (var algorithm = new CRC_16_XMODEM())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x4");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_17_CAN_FD_TransformBlock()
        {
            var expected = BigInteger.Parse("004f03", NumberStyles.AllowHexSpecifier).ToString("x5");
            using (var algorithm = new CRC_17_CAN_FD())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x5");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_21_CAN_FD_TransformBlock()
        {
            var expected = BigInteger.Parse("00ed841", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_21_CAN_FD())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_BLE_TransformBlock()
        {
            var expected = BigInteger.Parse("0c25a56", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_BLE())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_FLEXRAY_A_TransformBlock()
        {
            var expected = BigInteger.Parse("07979bd", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_FLEXRAY_A())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_FLEXRAY_B_TransformBlock()
        {
            var expected = BigInteger.Parse("01f23b8", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_FLEXRAY_B())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_INTERLAKEN_TransformBlock()
        {
            var expected = BigInteger.Parse("0b4f3e6", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_INTERLAKEN())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_LTE_A_TransformBlock()
        {
            var expected = BigInteger.Parse("0cde703", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_LTE_A())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_LTE_B_TransformBlock()
        {
            var expected = BigInteger.Parse("023ef52", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_LTE_B())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_OPENPGP_TransformBlock()
        {
            var expected = BigInteger.Parse("021cf02", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_OPENPGP())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_24_OS_9_TransformBlock()
        {
            var expected = BigInteger.Parse("0200fa5", NumberStyles.AllowHexSpecifier).ToString("x6");
            using (var algorithm = new CRC_24_OS_9())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x6");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_30_CDMA_TransformBlock()
        {
            var expected = BigInteger.Parse("004c34abf", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_30_CDMA())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_31_PHILIPS_TransformBlock()
        {
            var expected = BigInteger.Parse("00ce9e46c", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_31_PHILIPS())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_AIXM_TransformBlock()
        {
            var expected = BigInteger.Parse("03010bf7f", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_AIXM())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_AUTOSAR_TransformBlock()
        {
            var expected = BigInteger.Parse("01697d06a", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_AUTOSAR())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_BASE91_D_TransformBlock()
        {
            var expected = BigInteger.Parse("087315576", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_BASE91_D())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_BZIP2_TransformBlock()
        {
            var expected = BigInteger.Parse("0fc891918", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_BZIP2())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_CD_ROM_EDC_TransformBlock()
        {
            var expected = BigInteger.Parse("06ec2edc4", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_CD_ROM_EDC())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_CKSUM_TransformBlock()
        {
            var expected = BigInteger.Parse("0765e7680", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_CKSUM())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_ISCSI_TransformBlock()
        {
            var expected = BigInteger.Parse("0e3069283", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_ISCSI())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_ISO_HDLC_TransformBlock()
        {
            var expected = BigInteger.Parse("0cbf43926", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_ISO_HDLC())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_JAMCRC_TransformBlock()
        {
            var expected = BigInteger.Parse("0340bc6d9", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_JAMCRC())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_MPEG_2_TransformBlock()
        {
            var expected = BigInteger.Parse("00376e6e7", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_MPEG_2())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_32_XFER_TransformBlock()
        {
            var expected = BigInteger.Parse("0bd0be338", NumberStyles.AllowHexSpecifier).ToString("x8");
            using (var algorithm = new CRC_32_XFER())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x8");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_40_GSM_TransformBlock()
        {
            var expected = BigInteger.Parse("0d4164fc646", NumberStyles.AllowHexSpecifier).ToString("x10");
            using (var algorithm = new CRC_40_GSM())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x10");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_64_ECMA_182_TransformBlock()
        {
            var expected = BigInteger.Parse("06c40df5f0b497347", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_ECMA_182())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x16");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_64_GO_ISO_TransformBlock()
        {
            var expected = BigInteger.Parse("0b90956c775a41001", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_GO_ISO())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x16");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_64_WE_TransformBlock()
        {
            var expected = BigInteger.Parse("062ec59e3f1a4f00a", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_WE())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x16");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_64_XZ_TransformBlock()
        {
            var expected = BigInteger.Parse("0995dc9bbdf1939fa", NumberStyles.AllowHexSpecifier).ToString("x16");
            using (var algorithm = new CRC_64_XZ())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x16");
                    Assert.Equal(expected, actual);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
        }

        [Fact]
        public void CRC_82_DARC_TransformBlock()
        {
            var expected = BigInteger.Parse("0009ea83f625023801fd612", NumberStyles.AllowHexSpecifier).ToString("x21");
            using (var algorithm = new CRC_82_DARC())
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
                    var actual = new BigInteger(algorithm.Hash, isUnsigned: true).ToString("x21");
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
