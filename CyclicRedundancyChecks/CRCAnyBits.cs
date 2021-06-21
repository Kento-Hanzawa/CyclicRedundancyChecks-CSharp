 
//
// CyclicRedundancyChecks
// 
// このコードはテキストテンプレートファイル (.tt) によって作成されています。
// 変更をおこなう場合は、テキストテンプレートファイル (.tt) を編集してください。
//

using System;

namespace CyclicRedundancyChecks
{
    /// <summary>
    /// 入力データの <see cref="CRC1"/> チェックサムを計算します。
    /// </summary>
    public class CRC1 : CyclicRedundancyChecks.Underlying.CRCUInt8
    {
        public CRC1(global::System.Byte polynomial, global::System.Byte initialValue, global::System.Byte finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(1, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC2"/> チェックサムを計算します。
    /// </summary>
    public class CRC2 : CyclicRedundancyChecks.Underlying.CRCUInt8
    {
        public CRC2(global::System.Byte polynomial, global::System.Byte initialValue, global::System.Byte finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(2, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC3"/> チェックサムを計算します。
    /// </summary>
    public class CRC3 : CyclicRedundancyChecks.Underlying.CRCUInt8
    {
        public CRC3(global::System.Byte polynomial, global::System.Byte initialValue, global::System.Byte finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(3, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC4"/> チェックサムを計算します。
    /// </summary>
    public class CRC4 : CyclicRedundancyChecks.Underlying.CRCUInt8
    {
        public CRC4(global::System.Byte polynomial, global::System.Byte initialValue, global::System.Byte finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(4, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC5"/> チェックサムを計算します。
    /// </summary>
    public class CRC5 : CyclicRedundancyChecks.Underlying.CRCUInt8
    {
        public CRC5(global::System.Byte polynomial, global::System.Byte initialValue, global::System.Byte finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(5, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC6"/> チェックサムを計算します。
    /// </summary>
    public class CRC6 : CyclicRedundancyChecks.Underlying.CRCUInt8
    {
        public CRC6(global::System.Byte polynomial, global::System.Byte initialValue, global::System.Byte finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(6, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC7"/> チェックサムを計算します。
    /// </summary>
    public class CRC7 : CyclicRedundancyChecks.Underlying.CRCUInt8
    {
        public CRC7(global::System.Byte polynomial, global::System.Byte initialValue, global::System.Byte finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(7, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC8"/> チェックサムを計算します。
    /// </summary>
    public class CRC8 : CyclicRedundancyChecks.Underlying.CRCUInt8
    {
        public CRC8(global::System.Byte polynomial, global::System.Byte initialValue, global::System.Byte finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(8, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC9"/> チェックサムを計算します。
    /// </summary>
    public class CRC9 : CyclicRedundancyChecks.Underlying.CRCUInt16
    {
        public CRC9(global::System.UInt16 polynomial, global::System.UInt16 initialValue, global::System.UInt16 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(9, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC10"/> チェックサムを計算します。
    /// </summary>
    public class CRC10 : CyclicRedundancyChecks.Underlying.CRCUInt16
    {
        public CRC10(global::System.UInt16 polynomial, global::System.UInt16 initialValue, global::System.UInt16 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(10, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC11"/> チェックサムを計算します。
    /// </summary>
    public class CRC11 : CyclicRedundancyChecks.Underlying.CRCUInt16
    {
        public CRC11(global::System.UInt16 polynomial, global::System.UInt16 initialValue, global::System.UInt16 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(11, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC12"/> チェックサムを計算します。
    /// </summary>
    public class CRC12 : CyclicRedundancyChecks.Underlying.CRCUInt16
    {
        public CRC12(global::System.UInt16 polynomial, global::System.UInt16 initialValue, global::System.UInt16 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(12, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC13"/> チェックサムを計算します。
    /// </summary>
    public class CRC13 : CyclicRedundancyChecks.Underlying.CRCUInt16
    {
        public CRC13(global::System.UInt16 polynomial, global::System.UInt16 initialValue, global::System.UInt16 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(13, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC14"/> チェックサムを計算します。
    /// </summary>
    public class CRC14 : CyclicRedundancyChecks.Underlying.CRCUInt16
    {
        public CRC14(global::System.UInt16 polynomial, global::System.UInt16 initialValue, global::System.UInt16 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(14, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC15"/> チェックサムを計算します。
    /// </summary>
    public class CRC15 : CyclicRedundancyChecks.Underlying.CRCUInt16
    {
        public CRC15(global::System.UInt16 polynomial, global::System.UInt16 initialValue, global::System.UInt16 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(15, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC16"/> チェックサムを計算します。
    /// </summary>
    public class CRC16 : CyclicRedundancyChecks.Underlying.CRCUInt16
    {
        public CRC16(global::System.UInt16 polynomial, global::System.UInt16 initialValue, global::System.UInt16 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(16, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC17"/> チェックサムを計算します。
    /// </summary>
    public class CRC17 : CyclicRedundancyChecks.Underlying.CRCUInt32
    {
        public CRC17(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(17, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC18"/> チェックサムを計算します。
    /// </summary>
    public class CRC18 : CyclicRedundancyChecks.Underlying.CRCUInt32
    {
        public CRC18(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(18, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC19"/> チェックサムを計算します。
    /// </summary>
    public class CRC19 : CyclicRedundancyChecks.Underlying.CRCUInt32
    {
        public CRC19(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(19, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC20"/> チェックサムを計算します。
    /// </summary>
    public class CRC20 : CyclicRedundancyChecks.Underlying.CRCUInt32
    {
        public CRC20(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(20, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC21"/> チェックサムを計算します。
    /// </summary>
    public class CRC21 : CyclicRedundancyChecks.Underlying.CRCUInt32
    {
        public CRC21(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(21, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC22"/> チェックサムを計算します。
    /// </summary>
    public class CRC22 : CyclicRedundancyChecks.Underlying.CRCUInt32
    {
        public CRC22(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(22, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC23"/> チェックサムを計算します。
    /// </summary>
    public class CRC23 : CyclicRedundancyChecks.Underlying.CRCUInt32
    {
        public CRC23(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(23, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC24"/> チェックサムを計算します。
    /// </summary>
    public class CRC24 : CyclicRedundancyChecks.Underlying.CRCUInt32
    {
        public CRC24(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(24, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC25"/> チェックサムを計算します。
    /// </summary>
    public class CRC25 : CyclicRedundancyChecks.Underlying.CRCUInt32
    {
        public CRC25(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(25, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC26"/> チェックサムを計算します。
    /// </summary>
    public class CRC26 : CyclicRedundancyChecks.Underlying.CRCUInt32
    {
        public CRC26(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(26, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC27"/> チェックサムを計算します。
    /// </summary>
    public class CRC27 : CyclicRedundancyChecks.Underlying.CRCUInt32
    {
        public CRC27(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(27, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC28"/> チェックサムを計算します。
    /// </summary>
    public class CRC28 : CyclicRedundancyChecks.Underlying.CRCUInt32
    {
        public CRC28(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(28, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC29"/> チェックサムを計算します。
    /// </summary>
    public class CRC29 : CyclicRedundancyChecks.Underlying.CRCUInt32
    {
        public CRC29(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(29, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC30"/> チェックサムを計算します。
    /// </summary>
    public class CRC30 : CyclicRedundancyChecks.Underlying.CRCUInt32
    {
        public CRC30(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(30, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC31"/> チェックサムを計算します。
    /// </summary>
    public class CRC31 : CyclicRedundancyChecks.Underlying.CRCUInt32
    {
        public CRC31(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(31, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC32"/> チェックサムを計算します。
    /// </summary>
    public class CRC32 : CyclicRedundancyChecks.Underlying.CRCUInt32
    {
        public CRC32(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(32, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC33"/> チェックサムを計算します。
    /// </summary>
    public class CRC33 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC33(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(33, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC34"/> チェックサムを計算します。
    /// </summary>
    public class CRC34 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC34(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(34, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC35"/> チェックサムを計算します。
    /// </summary>
    public class CRC35 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC35(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(35, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC36"/> チェックサムを計算します。
    /// </summary>
    public class CRC36 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC36(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(36, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC37"/> チェックサムを計算します。
    /// </summary>
    public class CRC37 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC37(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(37, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC38"/> チェックサムを計算します。
    /// </summary>
    public class CRC38 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC38(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(38, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC39"/> チェックサムを計算します。
    /// </summary>
    public class CRC39 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC39(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(39, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC40"/> チェックサムを計算します。
    /// </summary>
    public class CRC40 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC40(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(40, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC41"/> チェックサムを計算します。
    /// </summary>
    public class CRC41 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC41(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(41, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC42"/> チェックサムを計算します。
    /// </summary>
    public class CRC42 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC42(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(42, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC43"/> チェックサムを計算します。
    /// </summary>
    public class CRC43 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC43(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(43, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC44"/> チェックサムを計算します。
    /// </summary>
    public class CRC44 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC44(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(44, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC45"/> チェックサムを計算します。
    /// </summary>
    public class CRC45 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC45(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(45, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC46"/> チェックサムを計算します。
    /// </summary>
    public class CRC46 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC46(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(46, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC47"/> チェックサムを計算します。
    /// </summary>
    public class CRC47 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC47(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(47, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC48"/> チェックサムを計算します。
    /// </summary>
    public class CRC48 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC48(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(48, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC49"/> チェックサムを計算します。
    /// </summary>
    public class CRC49 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC49(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(49, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC50"/> チェックサムを計算します。
    /// </summary>
    public class CRC50 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC50(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(50, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC51"/> チェックサムを計算します。
    /// </summary>
    public class CRC51 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC51(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(51, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC52"/> チェックサムを計算します。
    /// </summary>
    public class CRC52 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC52(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(52, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC53"/> チェックサムを計算します。
    /// </summary>
    public class CRC53 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC53(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(53, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC54"/> チェックサムを計算します。
    /// </summary>
    public class CRC54 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC54(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(54, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC55"/> チェックサムを計算します。
    /// </summary>
    public class CRC55 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC55(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(55, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC56"/> チェックサムを計算します。
    /// </summary>
    public class CRC56 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC56(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(56, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC57"/> チェックサムを計算します。
    /// </summary>
    public class CRC57 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC57(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(57, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC58"/> チェックサムを計算します。
    /// </summary>
    public class CRC58 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC58(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(58, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC59"/> チェックサムを計算します。
    /// </summary>
    public class CRC59 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC59(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(59, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC60"/> チェックサムを計算します。
    /// </summary>
    public class CRC60 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC60(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(60, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC61"/> チェックサムを計算します。
    /// </summary>
    public class CRC61 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC61(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(61, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC62"/> チェックサムを計算します。
    /// </summary>
    public class CRC62 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC62(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(62, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC63"/> チェックサムを計算します。
    /// </summary>
    public class CRC63 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC63(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(63, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC64"/> チェックサムを計算します。
    /// </summary>
    public class CRC64 : CyclicRedundancyChecks.Underlying.CRCUInt64
    {
        public CRC64(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(64, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC65"/> チェックサムを計算します。
    /// </summary>
    public class CRC65 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC65(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(65, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC66"/> チェックサムを計算します。
    /// </summary>
    public class CRC66 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC66(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(66, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC67"/> チェックサムを計算します。
    /// </summary>
    public class CRC67 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC67(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(67, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC68"/> チェックサムを計算します。
    /// </summary>
    public class CRC68 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC68(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(68, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC69"/> チェックサムを計算します。
    /// </summary>
    public class CRC69 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC69(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(69, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC70"/> チェックサムを計算します。
    /// </summary>
    public class CRC70 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC70(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(70, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC71"/> チェックサムを計算します。
    /// </summary>
    public class CRC71 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC71(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(71, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC72"/> チェックサムを計算します。
    /// </summary>
    public class CRC72 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC72(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(72, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC73"/> チェックサムを計算します。
    /// </summary>
    public class CRC73 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC73(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(73, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC74"/> チェックサムを計算します。
    /// </summary>
    public class CRC74 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC74(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(74, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC75"/> チェックサムを計算します。
    /// </summary>
    public class CRC75 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC75(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(75, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC76"/> チェックサムを計算します。
    /// </summary>
    public class CRC76 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC76(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(76, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC77"/> チェックサムを計算します。
    /// </summary>
    public class CRC77 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC77(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(77, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC78"/> チェックサムを計算します。
    /// </summary>
    public class CRC78 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC78(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(78, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC79"/> チェックサムを計算します。
    /// </summary>
    public class CRC79 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC79(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(79, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC80"/> チェックサムを計算します。
    /// </summary>
    public class CRC80 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC80(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(80, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC81"/> チェックサムを計算します。
    /// </summary>
    public class CRC81 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC81(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(81, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC82"/> チェックサムを計算します。
    /// </summary>
    public class CRC82 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC82(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(82, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC83"/> チェックサムを計算します。
    /// </summary>
    public class CRC83 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC83(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(83, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC84"/> チェックサムを計算します。
    /// </summary>
    public class CRC84 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC84(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(84, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC85"/> チェックサムを計算します。
    /// </summary>
    public class CRC85 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC85(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(85, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC86"/> チェックサムを計算します。
    /// </summary>
    public class CRC86 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC86(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(86, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC87"/> チェックサムを計算します。
    /// </summary>
    public class CRC87 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC87(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(87, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC88"/> チェックサムを計算します。
    /// </summary>
    public class CRC88 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC88(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(88, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC89"/> チェックサムを計算します。
    /// </summary>
    public class CRC89 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC89(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(89, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC90"/> チェックサムを計算します。
    /// </summary>
    public class CRC90 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC90(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(90, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC91"/> チェックサムを計算します。
    /// </summary>
    public class CRC91 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC91(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(91, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC92"/> チェックサムを計算します。
    /// </summary>
    public class CRC92 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC92(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(92, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC93"/> チェックサムを計算します。
    /// </summary>
    public class CRC93 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC93(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(93, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC94"/> チェックサムを計算します。
    /// </summary>
    public class CRC94 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC94(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(94, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC95"/> チェックサムを計算します。
    /// </summary>
    public class CRC95 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC95(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(95, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC96"/> チェックサムを計算します。
    /// </summary>
    public class CRC96 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC96(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(96, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC97"/> チェックサムを計算します。
    /// </summary>
    public class CRC97 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC97(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(97, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC98"/> チェックサムを計算します。
    /// </summary>
    public class CRC98 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC98(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(98, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC99"/> チェックサムを計算します。
    /// </summary>
    public class CRC99 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC99(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(99, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC100"/> チェックサムを計算します。
    /// </summary>
    public class CRC100 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC100(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(100, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC101"/> チェックサムを計算します。
    /// </summary>
    public class CRC101 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC101(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(101, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC102"/> チェックサムを計算します。
    /// </summary>
    public class CRC102 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC102(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(102, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC103"/> チェックサムを計算します。
    /// </summary>
    public class CRC103 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC103(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(103, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC104"/> チェックサムを計算します。
    /// </summary>
    public class CRC104 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC104(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(104, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC105"/> チェックサムを計算します。
    /// </summary>
    public class CRC105 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC105(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(105, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC106"/> チェックサムを計算します。
    /// </summary>
    public class CRC106 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC106(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(106, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC107"/> チェックサムを計算します。
    /// </summary>
    public class CRC107 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC107(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(107, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC108"/> チェックサムを計算します。
    /// </summary>
    public class CRC108 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC108(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(108, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC109"/> チェックサムを計算します。
    /// </summary>
    public class CRC109 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC109(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(109, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC110"/> チェックサムを計算します。
    /// </summary>
    public class CRC110 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC110(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(110, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC111"/> チェックサムを計算します。
    /// </summary>
    public class CRC111 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC111(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(111, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC112"/> チェックサムを計算します。
    /// </summary>
    public class CRC112 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC112(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(112, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC113"/> チェックサムを計算します。
    /// </summary>
    public class CRC113 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC113(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(113, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC114"/> チェックサムを計算します。
    /// </summary>
    public class CRC114 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC114(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(114, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC115"/> チェックサムを計算します。
    /// </summary>
    public class CRC115 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC115(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(115, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC116"/> チェックサムを計算します。
    /// </summary>
    public class CRC116 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC116(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(116, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC117"/> チェックサムを計算します。
    /// </summary>
    public class CRC117 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC117(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(117, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC118"/> チェックサムを計算します。
    /// </summary>
    public class CRC118 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC118(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(118, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC119"/> チェックサムを計算します。
    /// </summary>
    public class CRC119 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC119(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(119, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC120"/> チェックサムを計算します。
    /// </summary>
    public class CRC120 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC120(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(120, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC121"/> チェックサムを計算します。
    /// </summary>
    public class CRC121 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC121(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(121, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC122"/> チェックサムを計算します。
    /// </summary>
    public class CRC122 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC122(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(122, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC123"/> チェックサムを計算します。
    /// </summary>
    public class CRC123 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC123(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(123, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC124"/> チェックサムを計算します。
    /// </summary>
    public class CRC124 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC124(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(124, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC125"/> チェックサムを計算します。
    /// </summary>
    public class CRC125 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC125(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(125, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC126"/> チェックサムを計算します。
    /// </summary>
    public class CRC126 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC126(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(126, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC127"/> チェックサムを計算します。
    /// </summary>
    public class CRC127 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC127(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(127, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC128"/> チェックサムを計算します。
    /// </summary>
    public class CRC128 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC128(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(128, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC129"/> チェックサムを計算します。
    /// </summary>
    public class CRC129 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC129(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(129, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC130"/> チェックサムを計算します。
    /// </summary>
    public class CRC130 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC130(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(130, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC131"/> チェックサムを計算します。
    /// </summary>
    public class CRC131 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC131(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(131, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC132"/> チェックサムを計算します。
    /// </summary>
    public class CRC132 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC132(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(132, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC133"/> チェックサムを計算します。
    /// </summary>
    public class CRC133 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC133(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(133, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC134"/> チェックサムを計算します。
    /// </summary>
    public class CRC134 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC134(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(134, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC135"/> チェックサムを計算します。
    /// </summary>
    public class CRC135 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC135(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(135, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC136"/> チェックサムを計算します。
    /// </summary>
    public class CRC136 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC136(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(136, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC137"/> チェックサムを計算します。
    /// </summary>
    public class CRC137 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC137(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(137, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC138"/> チェックサムを計算します。
    /// </summary>
    public class CRC138 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC138(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(138, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC139"/> チェックサムを計算します。
    /// </summary>
    public class CRC139 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC139(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(139, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC140"/> チェックサムを計算します。
    /// </summary>
    public class CRC140 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC140(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(140, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC141"/> チェックサムを計算します。
    /// </summary>
    public class CRC141 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC141(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(141, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC142"/> チェックサムを計算します。
    /// </summary>
    public class CRC142 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC142(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(142, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC143"/> チェックサムを計算します。
    /// </summary>
    public class CRC143 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC143(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(143, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC144"/> チェックサムを計算します。
    /// </summary>
    public class CRC144 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC144(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(144, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC145"/> チェックサムを計算します。
    /// </summary>
    public class CRC145 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC145(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(145, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC146"/> チェックサムを計算します。
    /// </summary>
    public class CRC146 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC146(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(146, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC147"/> チェックサムを計算します。
    /// </summary>
    public class CRC147 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC147(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(147, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC148"/> チェックサムを計算します。
    /// </summary>
    public class CRC148 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC148(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(148, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC149"/> チェックサムを計算します。
    /// </summary>
    public class CRC149 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC149(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(149, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC150"/> チェックサムを計算します。
    /// </summary>
    public class CRC150 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC150(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(150, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC151"/> チェックサムを計算します。
    /// </summary>
    public class CRC151 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC151(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(151, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC152"/> チェックサムを計算します。
    /// </summary>
    public class CRC152 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC152(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(152, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC153"/> チェックサムを計算します。
    /// </summary>
    public class CRC153 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC153(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(153, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC154"/> チェックサムを計算します。
    /// </summary>
    public class CRC154 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC154(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(154, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC155"/> チェックサムを計算します。
    /// </summary>
    public class CRC155 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC155(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(155, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC156"/> チェックサムを計算します。
    /// </summary>
    public class CRC156 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC156(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(156, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC157"/> チェックサムを計算します。
    /// </summary>
    public class CRC157 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC157(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(157, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC158"/> チェックサムを計算します。
    /// </summary>
    public class CRC158 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC158(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(158, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC159"/> チェックサムを計算します。
    /// </summary>
    public class CRC159 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC159(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(159, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC160"/> チェックサムを計算します。
    /// </summary>
    public class CRC160 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC160(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(160, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC161"/> チェックサムを計算します。
    /// </summary>
    public class CRC161 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC161(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(161, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC162"/> チェックサムを計算します。
    /// </summary>
    public class CRC162 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC162(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(162, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC163"/> チェックサムを計算します。
    /// </summary>
    public class CRC163 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC163(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(163, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC164"/> チェックサムを計算します。
    /// </summary>
    public class CRC164 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC164(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(164, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC165"/> チェックサムを計算します。
    /// </summary>
    public class CRC165 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC165(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(165, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC166"/> チェックサムを計算します。
    /// </summary>
    public class CRC166 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC166(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(166, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC167"/> チェックサムを計算します。
    /// </summary>
    public class CRC167 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC167(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(167, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC168"/> チェックサムを計算します。
    /// </summary>
    public class CRC168 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC168(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(168, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC169"/> チェックサムを計算します。
    /// </summary>
    public class CRC169 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC169(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(169, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC170"/> チェックサムを計算します。
    /// </summary>
    public class CRC170 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC170(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(170, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC171"/> チェックサムを計算します。
    /// </summary>
    public class CRC171 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC171(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(171, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC172"/> チェックサムを計算します。
    /// </summary>
    public class CRC172 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC172(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(172, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC173"/> チェックサムを計算します。
    /// </summary>
    public class CRC173 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC173(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(173, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC174"/> チェックサムを計算します。
    /// </summary>
    public class CRC174 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC174(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(174, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC175"/> チェックサムを計算します。
    /// </summary>
    public class CRC175 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC175(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(175, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC176"/> チェックサムを計算します。
    /// </summary>
    public class CRC176 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC176(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(176, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC177"/> チェックサムを計算します。
    /// </summary>
    public class CRC177 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC177(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(177, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC178"/> チェックサムを計算します。
    /// </summary>
    public class CRC178 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC178(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(178, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC179"/> チェックサムを計算します。
    /// </summary>
    public class CRC179 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC179(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(179, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC180"/> チェックサムを計算します。
    /// </summary>
    public class CRC180 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC180(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(180, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC181"/> チェックサムを計算します。
    /// </summary>
    public class CRC181 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC181(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(181, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC182"/> チェックサムを計算します。
    /// </summary>
    public class CRC182 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC182(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(182, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC183"/> チェックサムを計算します。
    /// </summary>
    public class CRC183 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC183(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(183, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC184"/> チェックサムを計算します。
    /// </summary>
    public class CRC184 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC184(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(184, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC185"/> チェックサムを計算します。
    /// </summary>
    public class CRC185 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC185(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(185, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC186"/> チェックサムを計算します。
    /// </summary>
    public class CRC186 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC186(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(186, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC187"/> チェックサムを計算します。
    /// </summary>
    public class CRC187 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC187(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(187, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC188"/> チェックサムを計算します。
    /// </summary>
    public class CRC188 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC188(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(188, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC189"/> チェックサムを計算します。
    /// </summary>
    public class CRC189 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC189(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(189, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC190"/> チェックサムを計算します。
    /// </summary>
    public class CRC190 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC190(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(190, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC191"/> チェックサムを計算します。
    /// </summary>
    public class CRC191 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC191(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(191, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC192"/> チェックサムを計算します。
    /// </summary>
    public class CRC192 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC192(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(192, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC193"/> チェックサムを計算します。
    /// </summary>
    public class CRC193 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC193(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(193, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC194"/> チェックサムを計算します。
    /// </summary>
    public class CRC194 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC194(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(194, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC195"/> チェックサムを計算します。
    /// </summary>
    public class CRC195 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC195(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(195, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC196"/> チェックサムを計算します。
    /// </summary>
    public class CRC196 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC196(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(196, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC197"/> チェックサムを計算します。
    /// </summary>
    public class CRC197 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC197(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(197, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC198"/> チェックサムを計算します。
    /// </summary>
    public class CRC198 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC198(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(198, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC199"/> チェックサムを計算します。
    /// </summary>
    public class CRC199 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC199(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(199, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC200"/> チェックサムを計算します。
    /// </summary>
    public class CRC200 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC200(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(200, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC201"/> チェックサムを計算します。
    /// </summary>
    public class CRC201 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC201(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(201, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC202"/> チェックサムを計算します。
    /// </summary>
    public class CRC202 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC202(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(202, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC203"/> チェックサムを計算します。
    /// </summary>
    public class CRC203 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC203(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(203, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC204"/> チェックサムを計算します。
    /// </summary>
    public class CRC204 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC204(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(204, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC205"/> チェックサムを計算します。
    /// </summary>
    public class CRC205 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC205(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(205, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC206"/> チェックサムを計算します。
    /// </summary>
    public class CRC206 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC206(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(206, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC207"/> チェックサムを計算します。
    /// </summary>
    public class CRC207 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC207(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(207, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC208"/> チェックサムを計算します。
    /// </summary>
    public class CRC208 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC208(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(208, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC209"/> チェックサムを計算します。
    /// </summary>
    public class CRC209 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC209(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(209, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC210"/> チェックサムを計算します。
    /// </summary>
    public class CRC210 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC210(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(210, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC211"/> チェックサムを計算します。
    /// </summary>
    public class CRC211 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC211(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(211, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC212"/> チェックサムを計算します。
    /// </summary>
    public class CRC212 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC212(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(212, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC213"/> チェックサムを計算します。
    /// </summary>
    public class CRC213 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC213(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(213, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC214"/> チェックサムを計算します。
    /// </summary>
    public class CRC214 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC214(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(214, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC215"/> チェックサムを計算します。
    /// </summary>
    public class CRC215 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC215(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(215, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC216"/> チェックサムを計算します。
    /// </summary>
    public class CRC216 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC216(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(216, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC217"/> チェックサムを計算します。
    /// </summary>
    public class CRC217 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC217(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(217, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC218"/> チェックサムを計算します。
    /// </summary>
    public class CRC218 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC218(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(218, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC219"/> チェックサムを計算します。
    /// </summary>
    public class CRC219 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC219(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(219, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC220"/> チェックサムを計算します。
    /// </summary>
    public class CRC220 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC220(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(220, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC221"/> チェックサムを計算します。
    /// </summary>
    public class CRC221 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC221(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(221, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC222"/> チェックサムを計算します。
    /// </summary>
    public class CRC222 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC222(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(222, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC223"/> チェックサムを計算します。
    /// </summary>
    public class CRC223 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC223(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(223, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC224"/> チェックサムを計算します。
    /// </summary>
    public class CRC224 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC224(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(224, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC225"/> チェックサムを計算します。
    /// </summary>
    public class CRC225 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC225(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(225, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC226"/> チェックサムを計算します。
    /// </summary>
    public class CRC226 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC226(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(226, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC227"/> チェックサムを計算します。
    /// </summary>
    public class CRC227 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC227(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(227, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC228"/> チェックサムを計算します。
    /// </summary>
    public class CRC228 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC228(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(228, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC229"/> チェックサムを計算します。
    /// </summary>
    public class CRC229 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC229(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(229, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC230"/> チェックサムを計算します。
    /// </summary>
    public class CRC230 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC230(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(230, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC231"/> チェックサムを計算します。
    /// </summary>
    public class CRC231 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC231(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(231, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC232"/> チェックサムを計算します。
    /// </summary>
    public class CRC232 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC232(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(232, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC233"/> チェックサムを計算します。
    /// </summary>
    public class CRC233 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC233(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(233, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC234"/> チェックサムを計算します。
    /// </summary>
    public class CRC234 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC234(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(234, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC235"/> チェックサムを計算します。
    /// </summary>
    public class CRC235 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC235(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(235, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC236"/> チェックサムを計算します。
    /// </summary>
    public class CRC236 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC236(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(236, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC237"/> チェックサムを計算します。
    /// </summary>
    public class CRC237 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC237(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(237, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC238"/> チェックサムを計算します。
    /// </summary>
    public class CRC238 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC238(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(238, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC239"/> チェックサムを計算します。
    /// </summary>
    public class CRC239 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC239(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(239, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC240"/> チェックサムを計算します。
    /// </summary>
    public class CRC240 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC240(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(240, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC241"/> チェックサムを計算します。
    /// </summary>
    public class CRC241 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC241(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(241, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC242"/> チェックサムを計算します。
    /// </summary>
    public class CRC242 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC242(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(242, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC243"/> チェックサムを計算します。
    /// </summary>
    public class CRC243 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC243(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(243, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC244"/> チェックサムを計算します。
    /// </summary>
    public class CRC244 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC244(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(244, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC245"/> チェックサムを計算します。
    /// </summary>
    public class CRC245 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC245(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(245, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC246"/> チェックサムを計算します。
    /// </summary>
    public class CRC246 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC246(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(246, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC247"/> チェックサムを計算します。
    /// </summary>
    public class CRC247 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC247(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(247, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC248"/> チェックサムを計算します。
    /// </summary>
    public class CRC248 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC248(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(248, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC249"/> チェックサムを計算します。
    /// </summary>
    public class CRC249 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC249(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(249, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC250"/> チェックサムを計算します。
    /// </summary>
    public class CRC250 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC250(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(250, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC251"/> チェックサムを計算します。
    /// </summary>
    public class CRC251 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC251(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(251, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC252"/> チェックサムを計算します。
    /// </summary>
    public class CRC252 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC252(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(252, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC253"/> チェックサムを計算します。
    /// </summary>
    public class CRC253 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC253(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(253, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC254"/> チェックサムを計算します。
    /// </summary>
    public class CRC254 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC254(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(254, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC255"/> チェックサムを計算します。
    /// </summary>
    public class CRC255 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC255(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(255, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC256"/> チェックサムを計算します。
    /// </summary>
    public class CRC256 : CyclicRedundancyChecks.Underlying.CRCBigInteger
    {
        public CRC256(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(256, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

}
