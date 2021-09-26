using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Environments;

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
