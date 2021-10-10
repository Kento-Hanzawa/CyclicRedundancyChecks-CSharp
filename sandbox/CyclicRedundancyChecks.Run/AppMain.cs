using System;
using ConsoleAppFramework;
using ZLogger;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Linq;
using System.Text;

using CyclicRedundancyChecks;
using System.Security.Cryptography;

namespace CyclicRedundancyChecks.Run
{
    #region Filters
    // NOTE: 処理実行前後のイベントをフックするためのフィルターを設定します。Order パラメータが低いものが先に実行されます。
    // フィルターは Swagger 上で使用することが出来ないため、ビルド構成が Debug の場合は無効になります。
    // 詳しくは ConsoleAppFramework: Filter からも確認することが出来ます。（https://github.com/Cysharp/ConsoleAppFramework#filter）
#if !DEBUG
    [ConsoleAppFilter(typeof(Filters.Log_AssemblyInfoFilter), Order = 0)]
    //[ConsoleAppFilter(typeof(Filters.MutexFilter), Order = 1)]
    [ConsoleAppFilter(typeof(Filters.Log_RunningTimeFilter), Order = 2)]
#endif
    #endregion
    partial class AppMain
    {
        public void Main()
        {
            byte[] data = Encoding.ASCII.GetBytes("123456789");

            using (CRC crc = CRC.Create(Catalog.CRC32_BZIP2))
            {
                byte[] hash = crc.ComputeHash(data);
            }

            using (CRC crc = CRC.Create(32, 0x004c11db7, 0x0ffffffff, 0x0ffffffff, true, false))
            {
                byte[] hash = crc.ComputeHash(data);
            }

            using (HashAlgorithm crc = new CRC32(0x004c11db7, 0x0ffffffff, 0x0ffffffff, true, false))
            {
                byte[] hash = crc.ComputeHash(data);
            }

            // var crc = new CRC8((byte)0, (byte)0, (byte)0, (byte)0, true, true);
            // var crc = new CRC16(0, 0, 0, 0, true, true);
            // var crc = new CRC32(0, 0, 0, 0, true, true);
            // var crc = new CRC64(0, 0, 0, 0, true, true);

            // var crc = new CRC(0, 0, 0, 0, 0, true, true);
            // var crc = new CRC(Spec.CRC10_ATM);



            //var bytes = new byte[] { 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46, 0x47, 0x48, 0x49, 0x4A, 0x4B, 0x4C, 0x4D, 0x4E, 0x4F, 0x50, 0x51, 0x52, 0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5A };
            //using (var algorithm = CRC32.Create())
            //{
            //    var hash = algorithm.ComputeHash(bytes);
            //    var crc = BitConverter.ToUInt64(hash);
            //}
        }

        public static string Base2(uint value)
        {
            return value.ToString("X8");
            const int BitSize = sizeof(uint) * 8;
            Span<char> result = stackalloc char[BitSize];
            for (var i = 0; i < BitSize; i++)
            {
                result[i] = ((value >> (BitSize - 1 - i)) & 1) == 1 ? '1' : '0';
            }
            return new string(result);
        }
    }
}

#region 既定実装
namespace CyclicRedundancyChecks.Run
{
    internal sealed partial class AppMain : ConsoleAppBase
    {
        // NOTE: ビルド構成が Debug の場合、Swagger によるデバッグが可能になります。
        // F5 からデバッグを開始したのち、この URL にアクセスすることで Swagger ページを開くことができます。
        // 詳しくは ConsoleAppFramework: Web Interface with Swagger からも確認することが出来ます。（https://github.com/Cysharp/ConsoleAppFramework#web-interface-with-swagger）
        public const string SwaggerUrl = "http://localhost:12345";

        public static AppMain? Current { get; private set; }

        // NOTE: インスタンスプロパティはアクセスレベルを internal にしておかないと、引数なし実行で Main() が呼び出せなくなります。(ConsoleAppFramework の仕様？) 
        internal IOptions<AppSettings> Config { get; }
        internal ILogger<AppMain> Logger { get; }

        public AppMain(IOptions<AppSettings> config, ILogger<AppMain> logger)
        {
            this.Config = config;
            this.Logger = logger;
            AppMain.Current = this;
            Logger.ZLogTrace("AppSettings: {0}", JsonSerializer.Serialize(config.Value, new JsonSerializerOptions() { WriteIndented = true, Encoder = JavaScriptEncoder.Create(UnicodeRanges.All) }));
        }
    }
}
#endregion
