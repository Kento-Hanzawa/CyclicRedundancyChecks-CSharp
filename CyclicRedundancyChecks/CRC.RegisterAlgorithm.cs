//
// CyclicRedundancyChecks
// 
// このコードはテキストテンプレートファイル (.tt) によって作成されています。
// 変更をおこなう場合は、テキストテンプレートファイル (.tt) を編集してください。
//

using System;

namespace CyclicRedundancyChecks
{
    partial class CRC
    {
        private static bool isRegistered = false;

        /// <summary>
        /// CRC の実装を <see cref="System.Security.Cryptography.CryptoConfig.AddAlgorithm(Type, string[])"/> を使用して登録します。
        /// </summary>
        public static void RegisterAlgorithm()
        {
            if (isRegistered) return;

            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_3_GSM), "CRC-3/GSM");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_3_ROHC), "CRC-3/ROHC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_4_G_704), "CRC-4/G-704", "CRC-4/ITU");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_4_INTERLAKEN), "CRC-4/INTERLAKEN");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_5_EPC_C1G2), "CRC-5/EPC-C1G2", "CRC-5/EPC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_5_G_704), "CRC-5/G-704", "CRC-5/ITU");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_5_USB), "CRC-5/USB");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_6_CDMA2000_A), "CRC-6/CDMA2000-A");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_6_CDMA2000_B), "CRC-6/CDMA2000-B");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_6_DARC), "CRC-6/DARC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_6_G_704), "CRC-6/G-704", "CRC-6/ITU");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_6_GSM), "CRC-6/GSM");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_7_MMC), "CRC-7/MMC", "CRC-7");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_7_ROHC), "CRC-7/ROHC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_7_UMTS), "CRC-7/UMTS");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_8_AUTOSAR), "CRC-8/AUTOSAR");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_8_BLUETOOTH), "CRC-8/BLUETOOTH");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_8_CDMA2000), "CRC-8/CDMA2000");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_8_DARC), "CRC-8/DARC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_8_DVB_S2), "CRC-8/DVB-S2");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_8_GSM_A), "CRC-8/GSM-A");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_8_GSM_B), "CRC-8/GSM-B");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_8_I_432_1), "CRC-8/I-432-1", "CRC-8/ITU");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_8_I_CODE), "CRC-8/I-CODE");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_8_LTE), "CRC-8/LTE");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_8_MAXIM_DOW), "CRC-8/MAXIM-DOW", "CRC-8/MAXIM", "DOW-CRC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_8_MIFARE_MAD), "CRC-8/MIFARE-MAD");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_8_NRSC_5), "CRC-8/NRSC-5");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_8_OPENSAFETY), "CRC-8/OPENSAFETY");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_8_ROHC), "CRC-8/ROHC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_8_SAE_J1850), "CRC-8/SAE-J1850");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_8_SMBUS), "CRC-8/SMBUS", "CRC-8");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_8_TECH_3250), "CRC-8/TECH-3250", "CRC-8/AES", "CRC-8/EBU");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_8_WCDMA), "CRC-8/WCDMA");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_10_ATM), "CRC-10/ATM", "CRC-10", "CRC-10/I-610");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_10_CDMA2000), "CRC-10/CDMA2000");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_10_GSM), "CRC-10/GSM");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_11_FLEXRAY), "CRC-11/FLEXRAY", "CRC-11");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_11_UMTS), "CRC-11/UMTS");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_12_CDMA2000), "CRC-12/CDMA2000");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_12_DECT), "CRC-12/DECT", "X-CRC-12");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_12_GSM), "CRC-12/GSM");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_12_UMTS), "CRC-12/UMTS", "CRC-12/3GPP");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_13_BBC), "CRC-13/BBC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_14_DARC), "CRC-14/DARC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_14_GSM), "CRC-14/GSM");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_15_CAN), "CRC-15/CAN", "CRC-15");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_15_MPT1327), "CRC-15/MPT1327");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_ARC), "CRC-16/ARC", "ARC", "CRC-16", "CRC-16/LHA", "CRC-IBM");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_CDMA2000), "CRC-16/CDMA2000");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_CMS), "CRC-16/CMS");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_DDS_110), "CRC-16/DDS-110");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_DECT_R), "CRC-16/DECT-R", "R-CRC-16");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_DECT_X), "CRC-16/DECT-X", "X-CRC-16");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_DNP), "CRC-16/DNP");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_EN_13757), "CRC-16/EN-13757");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_GENIBUS), "CRC-16/GENIBUS", "CRC-16/DARC", "CRC-16/EPC", "CRC-16/EPC-C1G2", "CRC-16/I-CODE");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_GSM), "CRC-16/GSM");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_IBM_3740), "CRC-16/IBM-3740", "CRC-16/AUTOSAR", "CRC-16/CCITT-FALSE");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_IBM_SDLC), "CRC-16/IBM-SDLC", "CRC-16/ISO-HDLC", "CRC-16/ISO-IEC-14443-3-B", "CRC-16/X-25", "CRC-B", "X-25");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_ISO_IEC_14443_3_A), "CRC-16/ISO-IEC-14443-3-A", "CRC-A");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_KERMIT), "CRC-16/KERMIT", "CRC-16/CCITT", "CRC-16/CCITT-TRUE", "CRC-16/V-41-LSB", "CRC-CCITT", "KERMIT");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_LJ1200), "CRC-16/LJ1200");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_MAXIM_DOW), "CRC-16/MAXIM-DOW", "CRC-16/MAXIM");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_MCRF4XX), "CRC-16/MCRF4XX");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_MODBUS), "CRC-16/MODBUS", "MODBUS");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_NRSC_5), "CRC-16/NRSC-5");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_OPENSAFETY_A), "CRC-16/OPENSAFETY-A");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_OPENSAFETY_B), "CRC-16/OPENSAFETY-B");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_PROFIBUS), "CRC-16/PROFIBUS", "CRC-16/IEC-61158-2");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_RIELLO), "CRC-16/RIELLO");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_SPI_FUJITSU), "CRC-16/SPI-FUJITSU", "CRC-16/AUG-CCITT");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_T10_DIF), "CRC-16/T10-DIF");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_TELEDISK), "CRC-16/TELEDISK");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_TMS37157), "CRC-16/TMS37157");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_UMTS), "CRC-16/UMTS", "CRC-16/BUYPASS", "CRC-16/VERIFONE");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_USB), "CRC-16/USB");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_16_XMODEM), "CRC-16/XMODEM", "CRC-16/ACORN", "CRC-16/LTE", "CRC-16/V-41-MSB", "XMODEM", "ZMODEM");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_17_CAN_FD), "CRC-17/CAN-FD");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_21_CAN_FD), "CRC-21/CAN-FD");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_24_BLE), "CRC-24/BLE");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_24_FLEXRAY_A), "CRC-24/FLEXRAY-A");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_24_FLEXRAY_B), "CRC-24/FLEXRAY-B");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_24_INTERLAKEN), "CRC-24/INTERLAKEN");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_24_LTE_A), "CRC-24/LTE-A");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_24_LTE_B), "CRC-24/LTE-B");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_24_OPENPGP), "CRC-24/OPENPGP", "CRC-24");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_24_OS_9), "CRC-24/OS-9");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_30_CDMA), "CRC-30/CDMA");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_31_PHILIPS), "CRC-31/PHILIPS");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_32_AIXM), "CRC-32/AIXM", "CRC-32Q");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_32_AUTOSAR), "CRC-32/AUTOSAR");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_32_BASE91_D), "CRC-32/BASE91-D", "CRC-32D");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_32_BZIP2), "CRC-32/BZIP2", "CRC-32/AAL5", "CRC-32/DECT-B", "B-CRC-32");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_32_CD_ROM_EDC), "CRC-32/CD-ROM-EDC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_32_CKSUM), "CRC-32/CKSUM", "CKSUM", "CRC-32/POSIX");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_32_ISCSI), "CRC-32/ISCSI", "CRC-32/BASE91-C", "CRC-32/CASTAGNOLI", "CRC-32/INTERLAKEN", "CRC-32C");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_32_ISO_HDLC), "CRC-32/ISO-HDLC", "CRC-32", "CRC-32/ADCCP", "CRC-32/V-42", "CRC-32/XZ", "PKZIP");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_32_JAMCRC), "CRC-32/JAMCRC", "JAMCRC");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_32_MPEG_2), "CRC-32/MPEG-2");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_32_XFER), "CRC-32/XFER", "XFER");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_40_GSM), "CRC-40/GSM");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_64_ECMA_182), "CRC-64/ECMA-182", "CRC-64");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_64_GO_ISO), "CRC-64/GO-ISO");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_64_WE), "CRC-64/WE");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_64_XZ), "CRC-64/XZ", "CRC-64/GO-ECMA");
            System.Security.Cryptography.CryptoConfig.AddAlgorithm(typeof(global::CyclicRedundancyChecks.CRC_82_DARC), "CRC-82/DARC");

            isRegistered = true;
        }
    }
}
