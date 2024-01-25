```

BenchmarkDotNet v0.13.12, Ubuntu 20.04.6 LTS (Focal Fossa)
AMD EPYC 7763, 1 CPU, 2 logical cores and 1 physical core
.NET SDK 7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
| Method                      | Mean           | Error       | StdDev      | Median         |
|---------------------------- |---------------:|------------:|------------:|---------------:|
| CatchedExceptions           | 12,002.9480 ns | 282.5141 ns | 828.5650 ns | 11,950.8282 ns |
| CatchedTestExceptionsLevel1 | 12,020.1168 ns | 257.9380 ns | 760.5362 ns | 11,923.0727 ns |
| CatchedTestExceptionsLevel2 | 12,138.8765 ns | 283.0780 ns | 830.2187 ns | 11,934.5763 ns |
| NoException                 |      0.0785 ns |   0.0342 ns |   0.1007 ns |      0.0265 ns |
