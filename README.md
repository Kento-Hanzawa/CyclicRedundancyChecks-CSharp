# CyclicRedundancyChecks for .NET

[![NuGet](https://img.shields.io/nuget/v/CyclicRedundancyChecks.svg)](https://www.nuget.org/packages/CyclicRedundancyChecks)
[![Build Status](https://dev.azure.com/k-hanzawa/CyclicRedundancyChecks-CSharp/_apis/build/status/Kento-Hanzawa.CyclicRedundancyChecks-CSharp?branchName=main)](https://dev.azure.com/k-hanzawa/CyclicRedundancyChecks-CSharp/_build/latest?definitionId=8&branchName=main)

CRC (Cyclic Redundancy Checks) の C# 実装です。
個人的に何かと CRC を使う機会が多かったので、せっかくなのでライブラリとして作成してみました。

## インストール
このライブラリは NuGet からインストールすることが出来ます。
```ps1
Install-Package CyclicRedundancyChecks
```

## 使い方
このライブラリ内のすべての `CRC` 派生クラスは `HashAlgorithm` を継承しています。
そのため、基本的には `HashAlgorithm` クラスと同じような形で使用することが出来ます。

基本的な `CRC32` の計算を行う場合の例は以下の通りです。
```csharp
using CyclicRedundancyChecks;

void Main()
{
    byte[] data = Encoding.ASCII.GetBytes("123456789");
    using (var algorithm = new CRC32(polynomial: 0x004c11db7, initialValue: 0x0ffffffff, finalXorValue: 0x0ffffffff, reflectInput: false, reflectOutput: false))
    {
        byte[] hash = algorithm.ComputeHash(data);
    }
}
```


`CRCxx` クラスは、そのビット幅の `CRC` を計算する際に使用する最も基本的なクラスになります。
以下のパラメータを指定することができ、`CRC` 計算の動作をカスタマイズ出来ます。
| パラメータ | 概要 |
| --- | --- |
| `polynomial` | CRC計算に使用する生成多項式。 |
| `initialValue` | CRCの初期値。 |
| `initialValue` | CRC計算の最後におこなう XOR 演算で使用する値。 |
| `reflectInput` | CRC計算時に入力データのビット順反映をするかどうか。  |
| `reflectOutput` | CRC計算の最後にビット順反映をするかどうか。 |

現在は `CRC1` ～ `CRC256` までサポートしています。
ただし、`CRC65` 以上は `BigInteger` 型を使用するため、パフォーマンスが著しく低下します。

## もっと簡易的に使いたい
このライブラリでは [`Catalogue of parametrised CRC algorithms`](https://reveng.sourceforge.io/crc-catalogue/) ページに記載されている全 `CRC` の既定実装クラスが用意されています。
これらのクラスは `CyclicRedundancyChecks.Catalogs` 名前空間内に配置されています。
```csharp
using CyclicRedundancyChecks.Catalogs;

void Main()
{
    byte[] data = Encoding.ASCII.GetBytes("123456789");
    using (var algorithm = new CRC_32_BZIP2())
    {
        byte[] hash = algorithm.ComputeHash(data);
    }
}
```

このコードは、先程の `CRC32` クラスを使用したものと同じ結果になります。
使用したい `CRC` アルゴリズムが決まっているのであれば `CyclicRedundancyChecks.Catalogs` 名前空間内のクラスを使用したほうが便利ですし楽です。
また、 `CyclicRedundancyChecks.Catalogs` 名前空間内のクラスは静的空間に計算用テーブルを保持しており、パフォーマンスが少しだけ良いです。

## `System.Security.CryptographyCryptoConfig` への登録
既定では `System.Security.CryptographyCryptoConfig` クラスへの登録がされていませんが、`CRC.RegisterAlgorithm()` というメソッドを呼び出すことで登録がされます。
| クラス名 | 登録名 |
| --- | --- |
| `CRC1` | CRC1 |
| `CRC2` | CRC2 |
| `CRC3` | CRC3 |
| `CRC4` | CRC4 |
| `CRC5` | CRC5 |
| `CRC6` | CRC6 |
| `CRC7` | CRC7 |
| `CRC8` | CRC8 |
| `CRC9` | CRC9 |
| `CRC10` | CRC10 |
| `CRC11` | CRC11 |
| `CRC12` | CRC12 |
| `CRC13` | CRC13 |
| `CRC14` | CRC14 |
| `CRC15` | CRC15 |
| `CRC16` | CRC16 |
| `CRC17` | CRC17 |
| `CRC18` | CRC18 |
| `CRC19` | CRC19 |
| `CRC20` | CRC20 |
| `CRC21` | CRC21 |
| `CRC22` | CRC22 |
| `CRC23` | CRC23 |
| `CRC24` | CRC24 |
| `CRC25` | CRC25 |
| `CRC26` | CRC26 |
| `CRC27` | CRC27 |
| `CRC28` | CRC28 |
| `CRC29` | CRC29 |
| `CRC30` | CRC30 |
| `CRC31` | CRC31 |
| `CRC32` | CRC32 |
| `CRC33` | CRC33 |
| `CRC34` | CRC34 |
| `CRC35` | CRC35 |
| `CRC36` | CRC36 |
| `CRC37` | CRC37 |
| `CRC38` | CRC38 |
| `CRC39` | CRC39 |
| `CRC40` | CRC40 |
| `CRC41` | CRC41 |
| `CRC42` | CRC42 |
| `CRC43` | CRC43 |
| `CRC44` | CRC44 |
| `CRC45` | CRC45 |
| `CRC46` | CRC46 |
| `CRC47` | CRC47 |
| `CRC48` | CRC48 |
| `CRC49` | CRC49 |
| `CRC50` | CRC50 |
| `CRC51` | CRC51 |
| `CRC52` | CRC52 |
| `CRC53` | CRC53 |
| `CRC54` | CRC54 |
| `CRC55` | CRC55 |
| `CRC56` | CRC56 |
| `CRC57` | CRC57 |
| `CRC58` | CRC58 |
| `CRC59` | CRC59 |
| `CRC60` | CRC60 |
| `CRC61` | CRC61 |
| `CRC62` | CRC62 |
| `CRC63` | CRC63 |
| `CRC64` | CRC64 |
| `CRC65` | CRC65 |
| `CRC66` | CRC66 |
| `CRC67` | CRC67 |
| `CRC68` | CRC68 |
| `CRC69` | CRC69 |
| `CRC70` | CRC70 |
| `CRC71` | CRC71 |
| `CRC72` | CRC72 |
| `CRC73` | CRC73 |
| `CRC74` | CRC74 |
| `CRC75` | CRC75 |
| `CRC76` | CRC76 |
| `CRC77` | CRC77 |
| `CRC78` | CRC78 |
| `CRC79` | CRC79 |
| `CRC80` | CRC80 |
| `CRC81` | CRC81 |
| `CRC82` | CRC82 |
| `CRC83` | CRC83 |
| `CRC84` | CRC84 |
| `CRC85` | CRC85 |
| `CRC86` | CRC86 |
| `CRC87` | CRC87 |
| `CRC88` | CRC88 |
| `CRC89` | CRC89 |
| `CRC90` | CRC90 |
| `CRC91` | CRC91 |
| `CRC92` | CRC92 |
| `CRC93` | CRC93 |
| `CRC94` | CRC94 |
| `CRC95` | CRC95 |
| `CRC96` | CRC96 |
| `CRC97` | CRC97 |
| `CRC98` | CRC98 |
| `CRC99` | CRC99 |
| `CRC100` | CRC100 |
| `CRC101` | CRC101 |
| `CRC102` | CRC102 |
| `CRC103` | CRC103 |
| `CRC104` | CRC104 |
| `CRC105` | CRC105 |
| `CRC106` | CRC106 |
| `CRC107` | CRC107 |
| `CRC108` | CRC108 |
| `CRC109` | CRC109 |
| `CRC110` | CRC110 |
| `CRC111` | CRC111 |
| `CRC112` | CRC112 |
| `CRC113` | CRC113 |
| `CRC114` | CRC114 |
| `CRC115` | CRC115 |
| `CRC116` | CRC116 |
| `CRC117` | CRC117 |
| `CRC118` | CRC118 |
| `CRC119` | CRC119 |
| `CRC120` | CRC120 |
| `CRC121` | CRC121 |
| `CRC122` | CRC122 |
| `CRC123` | CRC123 |
| `CRC124` | CRC124 |
| `CRC125` | CRC125 |
| `CRC126` | CRC126 |
| `CRC127` | CRC127 |
| `CRC128` | CRC128 |
| `CRC129` | CRC129 |
| `CRC130` | CRC130 |
| `CRC131` | CRC131 |
| `CRC132` | CRC132 |
| `CRC133` | CRC133 |
| `CRC134` | CRC134 |
| `CRC135` | CRC135 |
| `CRC136` | CRC136 |
| `CRC137` | CRC137 |
| `CRC138` | CRC138 |
| `CRC139` | CRC139 |
| `CRC140` | CRC140 |
| `CRC141` | CRC141 |
| `CRC142` | CRC142 |
| `CRC143` | CRC143 |
| `CRC144` | CRC144 |
| `CRC145` | CRC145 |
| `CRC146` | CRC146 |
| `CRC147` | CRC147 |
| `CRC148` | CRC148 |
| `CRC149` | CRC149 |
| `CRC150` | CRC150 |
| `CRC151` | CRC151 |
| `CRC152` | CRC152 |
| `CRC153` | CRC153 |
| `CRC154` | CRC154 |
| `CRC155` | CRC155 |
| `CRC156` | CRC156 |
| `CRC157` | CRC157 |
| `CRC158` | CRC158 |
| `CRC159` | CRC159 |
| `CRC160` | CRC160 |
| `CRC161` | CRC161 |
| `CRC162` | CRC162 |
| `CRC163` | CRC163 |
| `CRC164` | CRC164 |
| `CRC165` | CRC165 |
| `CRC166` | CRC166 |
| `CRC167` | CRC167 |
| `CRC168` | CRC168 |
| `CRC169` | CRC169 |
| `CRC170` | CRC170 |
| `CRC171` | CRC171 |
| `CRC172` | CRC172 |
| `CRC173` | CRC173 |
| `CRC174` | CRC174 |
| `CRC175` | CRC175 |
| `CRC176` | CRC176 |
| `CRC177` | CRC177 |
| `CRC178` | CRC178 |
| `CRC179` | CRC179 |
| `CRC180` | CRC180 |
| `CRC181` | CRC181 |
| `CRC182` | CRC182 |
| `CRC183` | CRC183 |
| `CRC184` | CRC184 |
| `CRC185` | CRC185 |
| `CRC186` | CRC186 |
| `CRC187` | CRC187 |
| `CRC188` | CRC188 |
| `CRC189` | CRC189 |
| `CRC190` | CRC190 |
| `CRC191` | CRC191 |
| `CRC192` | CRC192 |
| `CRC193` | CRC193 |
| `CRC194` | CRC194 |
| `CRC195` | CRC195 |
| `CRC196` | CRC196 |
| `CRC197` | CRC197 |
| `CRC198` | CRC198 |
| `CRC199` | CRC199 |
| `CRC200` | CRC200 |
| `CRC201` | CRC201 |
| `CRC202` | CRC202 |
| `CRC203` | CRC203 |
| `CRC204` | CRC204 |
| `CRC205` | CRC205 |
| `CRC206` | CRC206 |
| `CRC207` | CRC207 |
| `CRC208` | CRC208 |
| `CRC209` | CRC209 |
| `CRC210` | CRC210 |
| `CRC211` | CRC211 |
| `CRC212` | CRC212 |
| `CRC213` | CRC213 |
| `CRC214` | CRC214 |
| `CRC215` | CRC215 |
| `CRC216` | CRC216 |
| `CRC217` | CRC217 |
| `CRC218` | CRC218 |
| `CRC219` | CRC219 |
| `CRC220` | CRC220 |
| `CRC221` | CRC221 |
| `CRC222` | CRC222 |
| `CRC223` | CRC223 |
| `CRC224` | CRC224 |
| `CRC225` | CRC225 |
| `CRC226` | CRC226 |
| `CRC227` | CRC227 |
| `CRC228` | CRC228 |
| `CRC229` | CRC229 |
| `CRC230` | CRC230 |
| `CRC231` | CRC231 |
| `CRC232` | CRC232 |
| `CRC233` | CRC233 |
| `CRC234` | CRC234 |
| `CRC235` | CRC235 |
| `CRC236` | CRC236 |
| `CRC237` | CRC237 |
| `CRC238` | CRC238 |
| `CRC239` | CRC239 |
| `CRC240` | CRC240 |
| `CRC241` | CRC241 |
| `CRC242` | CRC242 |
| `CRC243` | CRC243 |
| `CRC244` | CRC244 |
| `CRC245` | CRC245 |
| `CRC246` | CRC246 |
| `CRC247` | CRC247 |
| `CRC248` | CRC248 |
| `CRC249` | CRC249 |
| `CRC250` | CRC250 |
| `CRC251` | CRC251 |
| `CRC252` | CRC252 |
| `CRC253` | CRC253 |
| `CRC254` | CRC254 |
| `CRC255` | CRC255 |
| `CRC256` | CRC256 |
| `CRC_3_GSM` | CRC-3/GSM |
| `CRC_3_ROHC` | CRC-3/ROHC |
| `CRC_4_G_704` | CRC-4/G-704, CRC-4/ITU |
| `CRC_4_INTERLAKEN` | CRC-4/INTERLAKEN |
| `CRC_5_EPC_C1G2` | CRC-5/EPC-C1G2, CRC-5/EPC |
| `CRC_5_G_704` | CRC-5/G-704, CRC-5/ITU |
| `CRC_5_USB` | CRC-5/USB |
| `CRC_6_CDMA2000_A` | CRC-6/CDMA2000-A |
| `CRC_6_CDMA2000_B` | CRC-6/CDMA2000-B |
| `CRC_6_DARC` | CRC-6/DARC |
| `CRC_6_G_704` | CRC-6/G-704, CRC-6/ITU |
| `CRC_6_GSM` | CRC-6/GSM |
| `CRC_7_MMC` | CRC-7/MMC, CRC-7 |
| `CRC_7_ROHC` | CRC-7/ROHC |
| `CRC_7_UMTS` | CRC-7/UMTS |
| `CRC_8_AUTOSAR` | CRC-8/AUTOSAR |
| `CRC_8_BLUETOOTH` | CRC-8/BLUETOOTH |
| `CRC_8_CDMA2000` | CRC-8/CDMA2000 |
| `CRC_8_DARC` | CRC-8/DARC |
| `CRC_8_DVB_S2` | CRC-8/DVB-S2 |
| `CRC_8_GSM_A` | CRC-8/GSM-A |
| `CRC_8_GSM_B` | CRC-8/GSM-B |
| `CRC_8_I_432_1` | CRC-8/I-432-1, CRC-8/ITU |
| `CRC_8_I_CODE` | CRC-8/I-CODE |
| `CRC_8_LTE` | CRC-8/LTE |
| `CRC_8_MAXIM_DOW` | CRC-8/MAXIM-DOW, CRC-8/MAXIM, DOW-CRC |
| `CRC_8_MIFARE_MAD` | CRC-8/MIFARE-MAD |
| `CRC_8_NRSC_5` | CRC-8/NRSC-5 |
| `CRC_8_OPENSAFETY` | CRC-8/OPENSAFETY |
| `CRC_8_ROHC` | CRC-8/ROHC |
| `CRC_8_SAE_J1850` | CRC-8/SAE-J1850 |
| `CRC_8_SMBUS` | CRC-8/SMBUS, CRC-8 |
| `CRC_8_TECH_3250` | CRC-8/TECH-3250, CRC-8/AES, CRC-8/EBU |
| `CRC_8_WCDMA` | CRC-8/WCDMA |
| `CRC_10_ATM` | CRC-10/ATM, CRC-10, CRC-10/I-610 |
| `CRC_10_CDMA2000` | CRC-10/CDMA2000 |
| `CRC_10_GSM` | CRC-10/GSM |
| `CRC_11_FLEXRAY` | CRC-11/FLEXRAY, CRC-11 |
| `CRC_11_UMTS` | CRC-11/UMTS |
| `CRC_12_CDMA2000` | CRC-12/CDMA2000 |
| `CRC_12_DECT` | CRC-12/DECT, X-CRC-12 |
| `CRC_12_GSM` | CRC-12/GSM |
| `CRC_12_UMTS` | CRC-12/UMTS, CRC-12/3GPP |
| `CRC_13_BBC` | CRC-13/BBC |
| `CRC_14_DARC` | CRC-14/DARC |
| `CRC_14_GSM` | CRC-14/GSM |
| `CRC_15_CAN` | CRC-15/CAN, CRC-15 |
| `CRC_15_MPT1327` | CRC-15/MPT1327 |
| `CRC_16_ARC` | CRC-16/ARC, ARC, CRC-16, CRC-16/LHA, CRC-IBM |
| `CRC_16_CDMA2000` | CRC-16/CDMA2000 |
| `CRC_16_CMS` | CRC-16/CMS |
| `CRC_16_DDS_110` | CRC-16/DDS-110 |
| `CRC_16_DECT_R` | CRC-16/DECT-R, R-CRC-16 |
| `CRC_16_DECT_X` | CRC-16/DECT-X, X-CRC-16 |
| `CRC_16_DNP` | CRC-16/DNP |
| `CRC_16_EN_13757` | CRC-16/EN-13757 |
| `CRC_16_GENIBUS` | CRC-16/GENIBUS, CRC-16/DARC, CRC-16/EPC, CRC-16/EPC-C1G2, CRC-16/I-CODE |
| `CRC_16_GSM` | CRC-16/GSM |
| `CRC_16_IBM_3740` | CRC-16/IBM-3740, CRC-16/AUTOSAR, CRC-16/CCITT-FALSE |
| `CRC_16_IBM_SDLC` | CRC-16/IBM-SDLC, CRC-16/ISO-HDLC, CRC-16/ISO-IEC-14443-3-B, CRC-16/X-25, CRC-B, X-25 |
| `CRC_16_ISO_IEC_14443_3_A` | CRC-16/ISO-IEC-14443-3-A, CRC-A |
| `CRC_16_KERMIT` | CRC-16/KERMIT, CRC-16/CCITT, CRC-16/CCITT-TRUE, CRC-16/V-41-LSB, CRC-CCITT, KERMIT |
| `CRC_16_LJ1200` | CRC-16/LJ1200 |
| `CRC_16_MAXIM_DOW` | CRC-16/MAXIM-DOW, CRC-16/MAXIM |
| `CRC_16_MCRF4XX` | CRC-16/MCRF4XX |
| `CRC_16_MODBUS` | CRC-16/MODBUS, MODBUS |
| `CRC_16_NRSC_5` | CRC-16/NRSC-5 |
| `CRC_16_OPENSAFETY_A` | CRC-16/OPENSAFETY-A |
| `CRC_16_OPENSAFETY_B` | CRC-16/OPENSAFETY-B |
| `CRC_16_PROFIBUS` | CRC-16/PROFIBUS, CRC-16/IEC-61158-2 |
| `CRC_16_RIELLO` | CRC-16/RIELLO |
| `CRC_16_SPI_FUJITSU` | CRC-16/SPI-FUJITSU, CRC-16/AUG-CCITT |
| `CRC_16_T10_DIF` | CRC-16/T10-DIF |
| `CRC_16_TELEDISK` | CRC-16/TELEDISK |
| `CRC_16_TMS37157` | CRC-16/TMS37157 |
| `CRC_16_UMTS` | CRC-16/UMTS, CRC-16/BUYPASS, CRC-16/VERIFONE |
| `CRC_16_USB` | CRC-16/USB |
| `CRC_16_XMODEM` | CRC-16/XMODEM, CRC-16/ACORN, CRC-16/LTE, CRC-16/V-41-MSB, XMODEM, ZMODEM |
| `CRC_17_CAN_FD` | CRC-17/CAN-FD |
| `CRC_21_CAN_FD` | CRC-21/CAN-FD |
| `CRC_24_BLE` | CRC-24/BLE |
| `CRC_24_FLEXRAY_A` | CRC-24/FLEXRAY-A |
| `CRC_24_FLEXRAY_B` | CRC-24/FLEXRAY-B |
| `CRC_24_INTERLAKEN` | CRC-24/INTERLAKEN |
| `CRC_24_LTE_A` | CRC-24/LTE-A |
| `CRC_24_LTE_B` | CRC-24/LTE-B |
| `CRC_24_OPENPGP` | CRC-24/OPENPGP, CRC-24 |
| `CRC_24_OS_9` | CRC-24/OS-9 |
| `CRC_30_CDMA` | CRC-30/CDMA |
| `CRC_31_PHILIPS` | CRC-31/PHILIPS |
| `CRC_32_AIXM` | CRC-32/AIXM, CRC-32Q |
| `CRC_32_AUTOSAR` | CRC-32/AUTOSAR |
| `CRC_32_BASE91_D` | CRC-32/BASE91-D, CRC-32D |
| `CRC_32_BZIP2` | CRC-32/BZIP2, CRC-32/AAL5, CRC-32/DECT-B, B-CRC-32 |
| `CRC_32_CD_ROM_EDC` | CRC-32/CD-ROM-EDC |
| `CRC_32_CKSUM` | CRC-32/CKSUM, CKSUM, CRC-32/POSIX |
| `CRC_32_ISCSI` | CRC-32/ISCSI, CRC-32/BASE91-C, CRC-32/CASTAGNOLI, CRC-32/INTERLAKEN, CRC-32C |
| `CRC_32_ISO_HDLC` | CRC-32/ISO-HDLC, CRC-32, CRC-32/ADCCP, CRC-32/V-42, CRC-32/XZ, PKZIP |
| `CRC_32_JAMCRC` | CRC-32/JAMCRC, JAMCRC |
| `CRC_32_MPEG_2` | CRC-32/MPEG-2 |
| `CRC_32_XFER` | CRC-32/XFER, XFER |
| `CRC_40_GSM` | CRC-40/GSM |
| `CRC_64_ECMA_182` | CRC-64/ECMA-182, CRC-64 |
| `CRC_64_GO_ISO` | CRC-64/GO-ISO |
| `CRC_64_WE` | CRC-64/WE |
| `CRC_64_XZ` | CRC-64/XZ, CRC-64/GO-ECMA |
| `CRC_82_DARC` | CRC-82/DARC |

## ライセンス
MIT License

## 参考サイト
[`Catalogue of parametrised CRC algorithms`](https://reveng.sourceforge.io/crc-catalogue/)
[`巡回冗長検査 - Wikipedia`](https://ja.wikipedia.org/wiki/%E5%B7%A1%E5%9B%9E%E5%86%97%E9%95%B7%E6%A4%9C%E6%9F%BB)
