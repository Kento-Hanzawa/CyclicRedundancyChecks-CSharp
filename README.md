CyclicRedundancyChecks for .NET
===

[![GitHub Actions](https://github.com/Kento-Hanzawa/CyclicRedundancyChecks-CSharp/workflows/Build-Debug/badge.svg)](https://github.com/Kento-Hanzawa/CyclicRedundancyChecks-CSharp/actions)
[![Build Status](https://dev.azure.com/k-hanzawa/CyclicRedundancyChecks-CSharp/_apis/build/status/Kento-Hanzawa.CyclicRedundancyChecks-CSharp?branchName=main)](https://dev.azure.com/k-hanzawa/CyclicRedundancyChecks-CSharp/_build/latest?definitionId=8&branchName=main)
[![Releases](https://img.shields.io/github/release/Kento-Hanzawa/CyclicRedundancyChecks-CSharp.svg)](https://github.com/Kento-Hanzawa/CyclicRedundancyChecks-CSharp/releases)
[![NuGet](https://img.shields.io/nuget/v/CyclicRedundancyChecks.svg)](https://www.nuget.org/packages/CyclicRedundancyChecks)


CRC (Cyclic Redundancy Checks) の C# (.NET) 向け実装です。

## インストール
このライブラリは NuGet からインストールすることが出来ます。
```ps1
Install-Package CyclicRedundancyChecks
```

## 使い方
基本的なクラスとして `CRC8`、`CRC16`、`CRC32`、`CRC64`、`CRCAny` クラスを用意しています。  
これらのクラスはすべて .NET 標準の対象アルゴリズム基底クラスである `HashAlgorithm` クラス (`System.Security.Cryptography` 名前空間) を継承しています。  
そのため、基本的には `HashAlgorithm` クラスと同じような形で使用することが出来ます。

以下のコードは基本的な CRC32 の計算を行う場合のサンプルです。
```csharp
using System.Text;
using CyclicRedundancyChecks;

byte[] data = Encoding.ASCII.GetBytes("123456789");
using (CRC algorithm = new CRC32(0x004c11db7, 0x0ffffffff, 0x0ffffffff, false, false))
{
    byte[] hash = algorithm.ComputeHash(data);
}
```

各クラスのコンストラクターには以下のパラメータを指定できます。
| パラメータ | 概要 |
| --- | --- |
| `polynomial` | 生成多項式。 |
| `initialValue` | 初期値。 |
| `finalXorValue` | 計算の最後におこなう XOR 演算で使用する値。 |
| `reflectInput` | 計算時に入力データのビット順反転をするかどうか。  |
| `reflectOutput` | 計算の最後にビット順反転をするかどうか。 |


`CRCAny` は任意のビットサイズの計算が可能な実装になっており、このクラスに限りコンストラクターに `bitWidth` を指定することができます。
`CRCAny` を使用すると CRC64 を超えるビット幅の CRC 計算なども可能になります。
以下は CRC82 の計算を行うサンプルです。
```csharp
using System.Globalization;
using System.Numerics;
using System.Text;
using CyclicRedundancyChecks;

byte[] data = Encoding.ASCII.GetBytes("123456789");
BigInteger polynomial = BigInteger.Parse("00308c0111011401440411", NumberStyles.AllowHexSpecifier);
BigInteger initialValue = BigInteger.Parse("0000000000000000000000", NumberStyles.AllowHexSpecifier);
BigInteger finalXorValue = BigInteger.Parse("0000000000000000000000", NumberStyles.AllowHexSpecifier);
using (CRC algorithm = new CRCAny(82, polynomial, initialValue, finalXorValue, true, true))
{
    byte[] hash = algorithm.ComputeHash(data);
}
```

`CRCAny` は計算処理に BigInteger を使用しているため、`CRC8`、`CRC16`、`CRC32`、`CRC64` クラスに比べるとパフォーマンスは劣ります。
可能であれば CRC32 や CRC64 を使用することを検討して下さい。

## カタログ
このライブラリでは [`Catalogue of parametrised CRC algorithms`](https://reveng.sourceforge.io/crc-catalogue/) ページに記載されている `CRC` 仕様が `Catalog` クラス内に実装されています。  
CRCの仕様は `CRCSpec` という構造体で定義されており、`CRC.Create()` メソッドに渡すことで、その仕様に適した CRC 実装を作成することができます。
```csharp
using CyclicRedundancyChecks;

using (CRC crc = CRC.Create(Catalog.CRC32_BZIP2))
{
    byte[] hash = crc.ComputeHash(data);
}
```

`CRCSpec` 自体は、前述の `polynomial` などをラップしているだけの構造体なので、  
自前の `CRCSpec` インスタンスを用意しておき、それをプロジェクト内で使用するということも可能です。
```csharp
CRCSpec MySpec = new CRCSpec(32, 0x004c11db7, 0x0ffffffff, 0x0ffffffff, false, false);

using (CRC crc = CRC.Create(MySpec))
{
    byte[] hash = crc.ComputeHash(data);
}
```

## ライセンス
MIT License

## 参考サイト
[`Catalogue of parametrised CRC algorithms`](https://reveng.sourceforge.io/crc-catalogue/)
[`巡回冗長検査 - Wikipedia`](https://ja.wikipedia.org/wiki/%E5%B7%A1%E5%9B%9E%E5%86%97%E9%95%B7%E6%A4%9C%E6%9F%BB)
