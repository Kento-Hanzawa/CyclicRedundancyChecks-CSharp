using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;

namespace CyclicRedundancyChecks.Benchmark
{
    public class BenchmarkConfig : ManualConfig
    {
        public BenchmarkConfig()
        {
            var job = Job.ShortRun.WithWarmupCount(1)
                                  .WithIterationCount(1)
                                  .WithRuntime(CoreRuntime.Core50)
                                  .WithJit(Jit.RyuJit)
                                  .WithPlatform(Platform.X64);
            AddJob(job);
            AddExporter(MarkdownExporter.GitHub);
            AddDiagnoser(MemoryDiagnoser.Default);
        }
    }
}
