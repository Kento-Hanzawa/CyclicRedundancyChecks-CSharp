 
//
// CyclicRedundancyChecks
// 
// このコードはテキストテンプレートファイル (.tt) によって作成されています。
// 変更をおこなう場合は、テキストテンプレートファイル (.tt) を編集してください。
//

using System;
using CyclicRedundancyChecks.Underlying;

namespace CyclicRedundancyChecks
{
    /// <summary>
    /// 入力データの <see cref="CRC1"/> チェックサムを計算します。
    /// </summary>
    public class CRC1 : CRCByte
    {
        /// <summary>
        /// <see cref="CRC1"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC1(global::System.Byte polynomial, global::System.Byte initialValue, global::System.Byte finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(1, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC2"/> チェックサムを計算します。
    /// </summary>
    public class CRC2 : CRCByte
    {
        /// <summary>
        /// <see cref="CRC2"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC2(global::System.Byte polynomial, global::System.Byte initialValue, global::System.Byte finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(2, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC3"/> チェックサムを計算します。
    /// </summary>
    public class CRC3 : CRCByte
    {
        /// <summary>
        /// <see cref="CRC3"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC3(global::System.Byte polynomial, global::System.Byte initialValue, global::System.Byte finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(3, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC4"/> チェックサムを計算します。
    /// </summary>
    public class CRC4 : CRCByte
    {
        /// <summary>
        /// <see cref="CRC4"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC4(global::System.Byte polynomial, global::System.Byte initialValue, global::System.Byte finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(4, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC5"/> チェックサムを計算します。
    /// </summary>
    public class CRC5 : CRCByte
    {
        /// <summary>
        /// <see cref="CRC5"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC5(global::System.Byte polynomial, global::System.Byte initialValue, global::System.Byte finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(5, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC6"/> チェックサムを計算します。
    /// </summary>
    public class CRC6 : CRCByte
    {
        /// <summary>
        /// <see cref="CRC6"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC6(global::System.Byte polynomial, global::System.Byte initialValue, global::System.Byte finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(6, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC7"/> チェックサムを計算します。
    /// </summary>
    public class CRC7 : CRCByte
    {
        /// <summary>
        /// <see cref="CRC7"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC7(global::System.Byte polynomial, global::System.Byte initialValue, global::System.Byte finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(7, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC8"/> チェックサムを計算します。
    /// </summary>
    public class CRC8 : CRCByte
    {
        /// <summary>
        /// <see cref="CRC8"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC8(global::System.Byte polynomial, global::System.Byte initialValue, global::System.Byte finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(8, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC9"/> チェックサムを計算します。
    /// </summary>
    public class CRC9 : CRCUInt16
    {
        /// <summary>
        /// <see cref="CRC9"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC9(global::System.UInt16 polynomial, global::System.UInt16 initialValue, global::System.UInt16 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(9, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC10"/> チェックサムを計算します。
    /// </summary>
    public class CRC10 : CRCUInt16
    {
        /// <summary>
        /// <see cref="CRC10"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC10(global::System.UInt16 polynomial, global::System.UInt16 initialValue, global::System.UInt16 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(10, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC11"/> チェックサムを計算します。
    /// </summary>
    public class CRC11 : CRCUInt16
    {
        /// <summary>
        /// <see cref="CRC11"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC11(global::System.UInt16 polynomial, global::System.UInt16 initialValue, global::System.UInt16 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(11, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC12"/> チェックサムを計算します。
    /// </summary>
    public class CRC12 : CRCUInt16
    {
        /// <summary>
        /// <see cref="CRC12"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC12(global::System.UInt16 polynomial, global::System.UInt16 initialValue, global::System.UInt16 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(12, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC13"/> チェックサムを計算します。
    /// </summary>
    public class CRC13 : CRCUInt16
    {
        /// <summary>
        /// <see cref="CRC13"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC13(global::System.UInt16 polynomial, global::System.UInt16 initialValue, global::System.UInt16 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(13, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC14"/> チェックサムを計算します。
    /// </summary>
    public class CRC14 : CRCUInt16
    {
        /// <summary>
        /// <see cref="CRC14"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC14(global::System.UInt16 polynomial, global::System.UInt16 initialValue, global::System.UInt16 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(14, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC15"/> チェックサムを計算します。
    /// </summary>
    public class CRC15 : CRCUInt16
    {
        /// <summary>
        /// <see cref="CRC15"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC15(global::System.UInt16 polynomial, global::System.UInt16 initialValue, global::System.UInt16 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(15, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC16"/> チェックサムを計算します。
    /// </summary>
    public class CRC16 : CRCUInt16
    {
        /// <summary>
        /// <see cref="CRC16"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC16(global::System.UInt16 polynomial, global::System.UInt16 initialValue, global::System.UInt16 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(16, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC17"/> チェックサムを計算します。
    /// </summary>
    public class CRC17 : CRCUInt32
    {
        /// <summary>
        /// <see cref="CRC17"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC17(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(17, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC18"/> チェックサムを計算します。
    /// </summary>
    public class CRC18 : CRCUInt32
    {
        /// <summary>
        /// <see cref="CRC18"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC18(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(18, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC19"/> チェックサムを計算します。
    /// </summary>
    public class CRC19 : CRCUInt32
    {
        /// <summary>
        /// <see cref="CRC19"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC19(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(19, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC20"/> チェックサムを計算します。
    /// </summary>
    public class CRC20 : CRCUInt32
    {
        /// <summary>
        /// <see cref="CRC20"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC20(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(20, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC21"/> チェックサムを計算します。
    /// </summary>
    public class CRC21 : CRCUInt32
    {
        /// <summary>
        /// <see cref="CRC21"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC21(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(21, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC22"/> チェックサムを計算します。
    /// </summary>
    public class CRC22 : CRCUInt32
    {
        /// <summary>
        /// <see cref="CRC22"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC22(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(22, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC23"/> チェックサムを計算します。
    /// </summary>
    public class CRC23 : CRCUInt32
    {
        /// <summary>
        /// <see cref="CRC23"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC23(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(23, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC24"/> チェックサムを計算します。
    /// </summary>
    public class CRC24 : CRCUInt32
    {
        /// <summary>
        /// <see cref="CRC24"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC24(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(24, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC25"/> チェックサムを計算します。
    /// </summary>
    public class CRC25 : CRCUInt32
    {
        /// <summary>
        /// <see cref="CRC25"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC25(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(25, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC26"/> チェックサムを計算します。
    /// </summary>
    public class CRC26 : CRCUInt32
    {
        /// <summary>
        /// <see cref="CRC26"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC26(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(26, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC27"/> チェックサムを計算します。
    /// </summary>
    public class CRC27 : CRCUInt32
    {
        /// <summary>
        /// <see cref="CRC27"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC27(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(27, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC28"/> チェックサムを計算します。
    /// </summary>
    public class CRC28 : CRCUInt32
    {
        /// <summary>
        /// <see cref="CRC28"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC28(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(28, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC29"/> チェックサムを計算します。
    /// </summary>
    public class CRC29 : CRCUInt32
    {
        /// <summary>
        /// <see cref="CRC29"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC29(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(29, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC30"/> チェックサムを計算します。
    /// </summary>
    public class CRC30 : CRCUInt32
    {
        /// <summary>
        /// <see cref="CRC30"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC30(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(30, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC31"/> チェックサムを計算します。
    /// </summary>
    public class CRC31 : CRCUInt32
    {
        /// <summary>
        /// <see cref="CRC31"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC31(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(31, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC32"/> チェックサムを計算します。
    /// </summary>
    public class CRC32 : CRCUInt32
    {
        /// <summary>
        /// <see cref="CRC32"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC32(global::System.UInt32 polynomial, global::System.UInt32 initialValue, global::System.UInt32 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(32, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC33"/> チェックサムを計算します。
    /// </summary>
    public class CRC33 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC33"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC33(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(33, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC34"/> チェックサムを計算します。
    /// </summary>
    public class CRC34 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC34"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC34(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(34, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC35"/> チェックサムを計算します。
    /// </summary>
    public class CRC35 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC35"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC35(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(35, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC36"/> チェックサムを計算します。
    /// </summary>
    public class CRC36 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC36"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC36(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(36, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC37"/> チェックサムを計算します。
    /// </summary>
    public class CRC37 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC37"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC37(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(37, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC38"/> チェックサムを計算します。
    /// </summary>
    public class CRC38 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC38"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC38(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(38, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC39"/> チェックサムを計算します。
    /// </summary>
    public class CRC39 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC39"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC39(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(39, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC40"/> チェックサムを計算します。
    /// </summary>
    public class CRC40 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC40"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC40(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(40, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC41"/> チェックサムを計算します。
    /// </summary>
    public class CRC41 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC41"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC41(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(41, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC42"/> チェックサムを計算します。
    /// </summary>
    public class CRC42 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC42"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC42(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(42, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC43"/> チェックサムを計算します。
    /// </summary>
    public class CRC43 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC43"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC43(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(43, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC44"/> チェックサムを計算します。
    /// </summary>
    public class CRC44 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC44"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC44(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(44, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC45"/> チェックサムを計算します。
    /// </summary>
    public class CRC45 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC45"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC45(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(45, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC46"/> チェックサムを計算します。
    /// </summary>
    public class CRC46 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC46"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC46(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(46, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC47"/> チェックサムを計算します。
    /// </summary>
    public class CRC47 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC47"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC47(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(47, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC48"/> チェックサムを計算します。
    /// </summary>
    public class CRC48 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC48"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC48(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(48, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC49"/> チェックサムを計算します。
    /// </summary>
    public class CRC49 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC49"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC49(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(49, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC50"/> チェックサムを計算します。
    /// </summary>
    public class CRC50 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC50"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC50(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(50, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC51"/> チェックサムを計算します。
    /// </summary>
    public class CRC51 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC51"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC51(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(51, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC52"/> チェックサムを計算します。
    /// </summary>
    public class CRC52 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC52"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC52(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(52, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC53"/> チェックサムを計算します。
    /// </summary>
    public class CRC53 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC53"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC53(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(53, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC54"/> チェックサムを計算します。
    /// </summary>
    public class CRC54 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC54"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC54(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(54, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC55"/> チェックサムを計算します。
    /// </summary>
    public class CRC55 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC55"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC55(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(55, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC56"/> チェックサムを計算します。
    /// </summary>
    public class CRC56 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC56"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC56(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(56, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC57"/> チェックサムを計算します。
    /// </summary>
    public class CRC57 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC57"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC57(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(57, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC58"/> チェックサムを計算します。
    /// </summary>
    public class CRC58 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC58"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC58(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(58, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC59"/> チェックサムを計算します。
    /// </summary>
    public class CRC59 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC59"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC59(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(59, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC60"/> チェックサムを計算します。
    /// </summary>
    public class CRC60 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC60"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC60(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(60, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC61"/> チェックサムを計算します。
    /// </summary>
    public class CRC61 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC61"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC61(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(61, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC62"/> チェックサムを計算します。
    /// </summary>
    public class CRC62 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC62"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC62(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(62, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC63"/> チェックサムを計算します。
    /// </summary>
    public class CRC63 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC63"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC63(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(63, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC64"/> チェックサムを計算します。
    /// </summary>
    public class CRC64 : CRCUInt64
    {
        /// <summary>
        /// <see cref="CRC64"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC64(global::System.UInt64 polynomial, global::System.UInt64 initialValue, global::System.UInt64 finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(64, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC65"/> チェックサムを計算します。
    /// </summary>
    public class CRC65 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC65"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC65(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(65, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC66"/> チェックサムを計算します。
    /// </summary>
    public class CRC66 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC66"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC66(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(66, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC67"/> チェックサムを計算します。
    /// </summary>
    public class CRC67 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC67"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC67(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(67, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC68"/> チェックサムを計算します。
    /// </summary>
    public class CRC68 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC68"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC68(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(68, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC69"/> チェックサムを計算します。
    /// </summary>
    public class CRC69 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC69"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC69(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(69, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC70"/> チェックサムを計算します。
    /// </summary>
    public class CRC70 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC70"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC70(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(70, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC71"/> チェックサムを計算します。
    /// </summary>
    public class CRC71 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC71"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC71(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(71, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC72"/> チェックサムを計算します。
    /// </summary>
    public class CRC72 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC72"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC72(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(72, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC73"/> チェックサムを計算します。
    /// </summary>
    public class CRC73 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC73"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC73(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(73, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC74"/> チェックサムを計算します。
    /// </summary>
    public class CRC74 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC74"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC74(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(74, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC75"/> チェックサムを計算します。
    /// </summary>
    public class CRC75 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC75"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC75(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(75, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC76"/> チェックサムを計算します。
    /// </summary>
    public class CRC76 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC76"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC76(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(76, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC77"/> チェックサムを計算します。
    /// </summary>
    public class CRC77 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC77"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC77(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(77, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC78"/> チェックサムを計算します。
    /// </summary>
    public class CRC78 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC78"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC78(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(78, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC79"/> チェックサムを計算します。
    /// </summary>
    public class CRC79 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC79"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC79(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(79, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC80"/> チェックサムを計算します。
    /// </summary>
    public class CRC80 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC80"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC80(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(80, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC81"/> チェックサムを計算します。
    /// </summary>
    public class CRC81 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC81"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC81(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(81, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC82"/> チェックサムを計算します。
    /// </summary>
    public class CRC82 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC82"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC82(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(82, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC83"/> チェックサムを計算します。
    /// </summary>
    public class CRC83 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC83"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC83(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(83, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC84"/> チェックサムを計算します。
    /// </summary>
    public class CRC84 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC84"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC84(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(84, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC85"/> チェックサムを計算します。
    /// </summary>
    public class CRC85 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC85"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC85(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(85, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC86"/> チェックサムを計算します。
    /// </summary>
    public class CRC86 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC86"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC86(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(86, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC87"/> チェックサムを計算します。
    /// </summary>
    public class CRC87 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC87"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC87(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(87, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC88"/> チェックサムを計算します。
    /// </summary>
    public class CRC88 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC88"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC88(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(88, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC89"/> チェックサムを計算します。
    /// </summary>
    public class CRC89 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC89"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC89(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(89, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC90"/> チェックサムを計算します。
    /// </summary>
    public class CRC90 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC90"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC90(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(90, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC91"/> チェックサムを計算します。
    /// </summary>
    public class CRC91 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC91"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC91(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(91, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC92"/> チェックサムを計算します。
    /// </summary>
    public class CRC92 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC92"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC92(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(92, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC93"/> チェックサムを計算します。
    /// </summary>
    public class CRC93 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC93"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC93(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(93, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC94"/> チェックサムを計算します。
    /// </summary>
    public class CRC94 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC94"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC94(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(94, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC95"/> チェックサムを計算します。
    /// </summary>
    public class CRC95 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC95"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC95(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(95, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC96"/> チェックサムを計算します。
    /// </summary>
    public class CRC96 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC96"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC96(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(96, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC97"/> チェックサムを計算します。
    /// </summary>
    public class CRC97 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC97"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC97(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(97, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC98"/> チェックサムを計算します。
    /// </summary>
    public class CRC98 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC98"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC98(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(98, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC99"/> チェックサムを計算します。
    /// </summary>
    public class CRC99 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC99"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC99(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(99, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC100"/> チェックサムを計算します。
    /// </summary>
    public class CRC100 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC100"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC100(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(100, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC101"/> チェックサムを計算します。
    /// </summary>
    public class CRC101 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC101"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC101(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(101, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC102"/> チェックサムを計算します。
    /// </summary>
    public class CRC102 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC102"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC102(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(102, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC103"/> チェックサムを計算します。
    /// </summary>
    public class CRC103 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC103"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC103(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(103, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC104"/> チェックサムを計算します。
    /// </summary>
    public class CRC104 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC104"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC104(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(104, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC105"/> チェックサムを計算します。
    /// </summary>
    public class CRC105 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC105"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC105(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(105, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC106"/> チェックサムを計算します。
    /// </summary>
    public class CRC106 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC106"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC106(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(106, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC107"/> チェックサムを計算します。
    /// </summary>
    public class CRC107 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC107"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC107(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(107, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC108"/> チェックサムを計算します。
    /// </summary>
    public class CRC108 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC108"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC108(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(108, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC109"/> チェックサムを計算します。
    /// </summary>
    public class CRC109 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC109"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC109(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(109, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC110"/> チェックサムを計算します。
    /// </summary>
    public class CRC110 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC110"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC110(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(110, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC111"/> チェックサムを計算します。
    /// </summary>
    public class CRC111 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC111"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC111(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(111, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC112"/> チェックサムを計算します。
    /// </summary>
    public class CRC112 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC112"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC112(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(112, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC113"/> チェックサムを計算します。
    /// </summary>
    public class CRC113 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC113"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC113(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(113, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC114"/> チェックサムを計算します。
    /// </summary>
    public class CRC114 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC114"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC114(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(114, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC115"/> チェックサムを計算します。
    /// </summary>
    public class CRC115 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC115"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC115(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(115, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC116"/> チェックサムを計算します。
    /// </summary>
    public class CRC116 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC116"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC116(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(116, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC117"/> チェックサムを計算します。
    /// </summary>
    public class CRC117 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC117"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC117(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(117, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC118"/> チェックサムを計算します。
    /// </summary>
    public class CRC118 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC118"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC118(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(118, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC119"/> チェックサムを計算します。
    /// </summary>
    public class CRC119 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC119"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC119(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(119, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC120"/> チェックサムを計算します。
    /// </summary>
    public class CRC120 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC120"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC120(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(120, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC121"/> チェックサムを計算します。
    /// </summary>
    public class CRC121 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC121"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC121(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(121, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC122"/> チェックサムを計算します。
    /// </summary>
    public class CRC122 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC122"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC122(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(122, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC123"/> チェックサムを計算します。
    /// </summary>
    public class CRC123 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC123"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC123(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(123, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC124"/> チェックサムを計算します。
    /// </summary>
    public class CRC124 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC124"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC124(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(124, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC125"/> チェックサムを計算します。
    /// </summary>
    public class CRC125 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC125"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC125(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(125, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC126"/> チェックサムを計算します。
    /// </summary>
    public class CRC126 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC126"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC126(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(126, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC127"/> チェックサムを計算します。
    /// </summary>
    public class CRC127 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC127"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC127(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(127, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC128"/> チェックサムを計算します。
    /// </summary>
    public class CRC128 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC128"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC128(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(128, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC129"/> チェックサムを計算します。
    /// </summary>
    public class CRC129 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC129"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC129(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(129, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC130"/> チェックサムを計算します。
    /// </summary>
    public class CRC130 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC130"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC130(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(130, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC131"/> チェックサムを計算します。
    /// </summary>
    public class CRC131 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC131"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC131(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(131, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC132"/> チェックサムを計算します。
    /// </summary>
    public class CRC132 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC132"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC132(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(132, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC133"/> チェックサムを計算します。
    /// </summary>
    public class CRC133 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC133"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC133(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(133, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC134"/> チェックサムを計算します。
    /// </summary>
    public class CRC134 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC134"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC134(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(134, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC135"/> チェックサムを計算します。
    /// </summary>
    public class CRC135 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC135"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC135(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(135, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC136"/> チェックサムを計算します。
    /// </summary>
    public class CRC136 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC136"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC136(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(136, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC137"/> チェックサムを計算します。
    /// </summary>
    public class CRC137 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC137"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC137(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(137, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC138"/> チェックサムを計算します。
    /// </summary>
    public class CRC138 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC138"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC138(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(138, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC139"/> チェックサムを計算します。
    /// </summary>
    public class CRC139 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC139"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC139(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(139, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC140"/> チェックサムを計算します。
    /// </summary>
    public class CRC140 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC140"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC140(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(140, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC141"/> チェックサムを計算します。
    /// </summary>
    public class CRC141 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC141"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC141(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(141, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC142"/> チェックサムを計算します。
    /// </summary>
    public class CRC142 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC142"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC142(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(142, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC143"/> チェックサムを計算します。
    /// </summary>
    public class CRC143 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC143"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC143(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(143, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC144"/> チェックサムを計算します。
    /// </summary>
    public class CRC144 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC144"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC144(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(144, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC145"/> チェックサムを計算します。
    /// </summary>
    public class CRC145 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC145"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC145(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(145, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC146"/> チェックサムを計算します。
    /// </summary>
    public class CRC146 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC146"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC146(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(146, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC147"/> チェックサムを計算します。
    /// </summary>
    public class CRC147 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC147"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC147(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(147, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC148"/> チェックサムを計算します。
    /// </summary>
    public class CRC148 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC148"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC148(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(148, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC149"/> チェックサムを計算します。
    /// </summary>
    public class CRC149 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC149"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC149(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(149, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC150"/> チェックサムを計算します。
    /// </summary>
    public class CRC150 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC150"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC150(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(150, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC151"/> チェックサムを計算します。
    /// </summary>
    public class CRC151 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC151"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC151(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(151, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC152"/> チェックサムを計算します。
    /// </summary>
    public class CRC152 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC152"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC152(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(152, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC153"/> チェックサムを計算します。
    /// </summary>
    public class CRC153 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC153"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC153(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(153, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC154"/> チェックサムを計算します。
    /// </summary>
    public class CRC154 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC154"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC154(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(154, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC155"/> チェックサムを計算します。
    /// </summary>
    public class CRC155 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC155"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC155(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(155, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC156"/> チェックサムを計算します。
    /// </summary>
    public class CRC156 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC156"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC156(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(156, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC157"/> チェックサムを計算します。
    /// </summary>
    public class CRC157 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC157"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC157(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(157, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC158"/> チェックサムを計算します。
    /// </summary>
    public class CRC158 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC158"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC158(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(158, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC159"/> チェックサムを計算します。
    /// </summary>
    public class CRC159 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC159"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC159(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(159, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC160"/> チェックサムを計算します。
    /// </summary>
    public class CRC160 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC160"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC160(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(160, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC161"/> チェックサムを計算します。
    /// </summary>
    public class CRC161 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC161"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC161(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(161, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC162"/> チェックサムを計算します。
    /// </summary>
    public class CRC162 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC162"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC162(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(162, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC163"/> チェックサムを計算します。
    /// </summary>
    public class CRC163 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC163"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC163(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(163, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC164"/> チェックサムを計算します。
    /// </summary>
    public class CRC164 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC164"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC164(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(164, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC165"/> チェックサムを計算します。
    /// </summary>
    public class CRC165 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC165"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC165(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(165, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC166"/> チェックサムを計算します。
    /// </summary>
    public class CRC166 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC166"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC166(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(166, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC167"/> チェックサムを計算します。
    /// </summary>
    public class CRC167 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC167"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC167(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(167, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC168"/> チェックサムを計算します。
    /// </summary>
    public class CRC168 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC168"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC168(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(168, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC169"/> チェックサムを計算します。
    /// </summary>
    public class CRC169 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC169"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC169(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(169, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC170"/> チェックサムを計算します。
    /// </summary>
    public class CRC170 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC170"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC170(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(170, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC171"/> チェックサムを計算します。
    /// </summary>
    public class CRC171 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC171"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC171(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(171, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC172"/> チェックサムを計算します。
    /// </summary>
    public class CRC172 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC172"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC172(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(172, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC173"/> チェックサムを計算します。
    /// </summary>
    public class CRC173 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC173"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC173(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(173, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC174"/> チェックサムを計算します。
    /// </summary>
    public class CRC174 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC174"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC174(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(174, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC175"/> チェックサムを計算します。
    /// </summary>
    public class CRC175 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC175"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC175(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(175, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC176"/> チェックサムを計算します。
    /// </summary>
    public class CRC176 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC176"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC176(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(176, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC177"/> チェックサムを計算します。
    /// </summary>
    public class CRC177 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC177"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC177(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(177, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC178"/> チェックサムを計算します。
    /// </summary>
    public class CRC178 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC178"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC178(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(178, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC179"/> チェックサムを計算します。
    /// </summary>
    public class CRC179 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC179"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC179(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(179, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC180"/> チェックサムを計算します。
    /// </summary>
    public class CRC180 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC180"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC180(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(180, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC181"/> チェックサムを計算します。
    /// </summary>
    public class CRC181 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC181"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC181(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(181, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC182"/> チェックサムを計算します。
    /// </summary>
    public class CRC182 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC182"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC182(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(182, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC183"/> チェックサムを計算します。
    /// </summary>
    public class CRC183 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC183"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC183(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(183, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC184"/> チェックサムを計算します。
    /// </summary>
    public class CRC184 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC184"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC184(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(184, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC185"/> チェックサムを計算します。
    /// </summary>
    public class CRC185 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC185"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC185(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(185, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC186"/> チェックサムを計算します。
    /// </summary>
    public class CRC186 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC186"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC186(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(186, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC187"/> チェックサムを計算します。
    /// </summary>
    public class CRC187 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC187"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC187(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(187, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC188"/> チェックサムを計算します。
    /// </summary>
    public class CRC188 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC188"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC188(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(188, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC189"/> チェックサムを計算します。
    /// </summary>
    public class CRC189 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC189"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC189(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(189, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC190"/> チェックサムを計算します。
    /// </summary>
    public class CRC190 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC190"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC190(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(190, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC191"/> チェックサムを計算します。
    /// </summary>
    public class CRC191 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC191"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC191(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(191, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC192"/> チェックサムを計算します。
    /// </summary>
    public class CRC192 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC192"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC192(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(192, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC193"/> チェックサムを計算します。
    /// </summary>
    public class CRC193 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC193"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC193(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(193, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC194"/> チェックサムを計算します。
    /// </summary>
    public class CRC194 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC194"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC194(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(194, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC195"/> チェックサムを計算します。
    /// </summary>
    public class CRC195 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC195"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC195(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(195, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC196"/> チェックサムを計算します。
    /// </summary>
    public class CRC196 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC196"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC196(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(196, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC197"/> チェックサムを計算します。
    /// </summary>
    public class CRC197 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC197"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC197(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(197, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC198"/> チェックサムを計算します。
    /// </summary>
    public class CRC198 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC198"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC198(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(198, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC199"/> チェックサムを計算します。
    /// </summary>
    public class CRC199 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC199"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC199(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(199, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC200"/> チェックサムを計算します。
    /// </summary>
    public class CRC200 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC200"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC200(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(200, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC201"/> チェックサムを計算します。
    /// </summary>
    public class CRC201 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC201"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC201(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(201, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC202"/> チェックサムを計算します。
    /// </summary>
    public class CRC202 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC202"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC202(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(202, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC203"/> チェックサムを計算します。
    /// </summary>
    public class CRC203 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC203"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC203(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(203, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC204"/> チェックサムを計算します。
    /// </summary>
    public class CRC204 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC204"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC204(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(204, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC205"/> チェックサムを計算します。
    /// </summary>
    public class CRC205 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC205"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC205(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(205, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC206"/> チェックサムを計算します。
    /// </summary>
    public class CRC206 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC206"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC206(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(206, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC207"/> チェックサムを計算します。
    /// </summary>
    public class CRC207 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC207"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC207(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(207, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC208"/> チェックサムを計算します。
    /// </summary>
    public class CRC208 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC208"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC208(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(208, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC209"/> チェックサムを計算します。
    /// </summary>
    public class CRC209 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC209"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC209(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(209, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC210"/> チェックサムを計算します。
    /// </summary>
    public class CRC210 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC210"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC210(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(210, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC211"/> チェックサムを計算します。
    /// </summary>
    public class CRC211 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC211"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC211(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(211, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC212"/> チェックサムを計算します。
    /// </summary>
    public class CRC212 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC212"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC212(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(212, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC213"/> チェックサムを計算します。
    /// </summary>
    public class CRC213 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC213"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC213(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(213, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC214"/> チェックサムを計算します。
    /// </summary>
    public class CRC214 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC214"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC214(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(214, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC215"/> チェックサムを計算します。
    /// </summary>
    public class CRC215 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC215"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC215(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(215, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC216"/> チェックサムを計算します。
    /// </summary>
    public class CRC216 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC216"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC216(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(216, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC217"/> チェックサムを計算します。
    /// </summary>
    public class CRC217 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC217"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC217(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(217, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC218"/> チェックサムを計算します。
    /// </summary>
    public class CRC218 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC218"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC218(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(218, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC219"/> チェックサムを計算します。
    /// </summary>
    public class CRC219 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC219"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC219(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(219, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC220"/> チェックサムを計算します。
    /// </summary>
    public class CRC220 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC220"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC220(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(220, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC221"/> チェックサムを計算します。
    /// </summary>
    public class CRC221 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC221"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC221(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(221, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC222"/> チェックサムを計算します。
    /// </summary>
    public class CRC222 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC222"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC222(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(222, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC223"/> チェックサムを計算します。
    /// </summary>
    public class CRC223 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC223"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC223(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(223, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC224"/> チェックサムを計算します。
    /// </summary>
    public class CRC224 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC224"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC224(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(224, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC225"/> チェックサムを計算します。
    /// </summary>
    public class CRC225 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC225"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC225(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(225, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC226"/> チェックサムを計算します。
    /// </summary>
    public class CRC226 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC226"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC226(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(226, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC227"/> チェックサムを計算します。
    /// </summary>
    public class CRC227 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC227"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC227(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(227, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC228"/> チェックサムを計算します。
    /// </summary>
    public class CRC228 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC228"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC228(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(228, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC229"/> チェックサムを計算します。
    /// </summary>
    public class CRC229 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC229"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC229(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(229, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC230"/> チェックサムを計算します。
    /// </summary>
    public class CRC230 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC230"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC230(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(230, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC231"/> チェックサムを計算します。
    /// </summary>
    public class CRC231 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC231"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC231(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(231, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC232"/> チェックサムを計算します。
    /// </summary>
    public class CRC232 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC232"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC232(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(232, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC233"/> チェックサムを計算します。
    /// </summary>
    public class CRC233 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC233"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC233(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(233, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC234"/> チェックサムを計算します。
    /// </summary>
    public class CRC234 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC234"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC234(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(234, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC235"/> チェックサムを計算します。
    /// </summary>
    public class CRC235 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC235"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC235(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(235, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC236"/> チェックサムを計算します。
    /// </summary>
    public class CRC236 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC236"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC236(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(236, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC237"/> チェックサムを計算します。
    /// </summary>
    public class CRC237 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC237"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC237(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(237, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC238"/> チェックサムを計算します。
    /// </summary>
    public class CRC238 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC238"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC238(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(238, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC239"/> チェックサムを計算します。
    /// </summary>
    public class CRC239 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC239"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC239(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(239, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC240"/> チェックサムを計算します。
    /// </summary>
    public class CRC240 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC240"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC240(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(240, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC241"/> チェックサムを計算します。
    /// </summary>
    public class CRC241 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC241"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC241(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(241, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC242"/> チェックサムを計算します。
    /// </summary>
    public class CRC242 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC242"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC242(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(242, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC243"/> チェックサムを計算します。
    /// </summary>
    public class CRC243 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC243"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC243(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(243, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC244"/> チェックサムを計算します。
    /// </summary>
    public class CRC244 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC244"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC244(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(244, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC245"/> チェックサムを計算します。
    /// </summary>
    public class CRC245 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC245"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC245(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(245, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC246"/> チェックサムを計算します。
    /// </summary>
    public class CRC246 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC246"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC246(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(246, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC247"/> チェックサムを計算します。
    /// </summary>
    public class CRC247 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC247"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC247(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(247, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC248"/> チェックサムを計算します。
    /// </summary>
    public class CRC248 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC248"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC248(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(248, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC249"/> チェックサムを計算します。
    /// </summary>
    public class CRC249 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC249"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC249(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(249, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC250"/> チェックサムを計算します。
    /// </summary>
    public class CRC250 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC250"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC250(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(250, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC251"/> チェックサムを計算します。
    /// </summary>
    public class CRC251 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC251"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC251(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(251, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC252"/> チェックサムを計算します。
    /// </summary>
    public class CRC252 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC252"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC252(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(252, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC253"/> チェックサムを計算します。
    /// </summary>
    public class CRC253 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC253"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC253(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(253, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC254"/> チェックサムを計算します。
    /// </summary>
    public class CRC254 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC254"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC254(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(254, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC255"/> チェックサムを計算します。
    /// </summary>
    public class CRC255 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC255"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC255(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(255, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

    /// <summary>
    /// 入力データの <see cref="CRC256"/> チェックサムを計算します。
    /// </summary>
    public class CRC256 : CRCBigInteger
    {
        /// <summary>
        /// <see cref="CRC256"/> クラスの新しいインスタンスを作成します。
        /// </summary>
        /// <param name="polynomial"></param>
        /// <param name="initialValue"></param>
        /// <param name="finalXorValue"></param>
        /// <param name="reflectInput"></param>
        /// <param name="reflectOutput"></param>
        /// <param name="isBigEndianResult">計算結果のCRC値をビッグエンディアン順に <see cref="byte"/> 配列に格納する場合は <see langword="true"/>、リトルエンディアン順に格納する場合は <see langword="false"/> を指定します。</param>
        public CRC256(global::System.Numerics.BigInteger polynomial, global::System.Numerics.BigInteger initialValue, global::System.Numerics.BigInteger finalXorValue, bool reflectInput, bool reflectOutput, bool isBigEndianResult = false)
            : base(256, polynomial, initialValue, finalXorValue, reflectInput, reflectOutput, isBigEndianResult)
        {
        }
    }

}