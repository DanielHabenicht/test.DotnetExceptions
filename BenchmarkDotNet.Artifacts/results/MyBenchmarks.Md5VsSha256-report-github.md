```

BenchmarkDotNet v0.13.12, Ubuntu 20.04.6 LTS (Focal Fossa)
AMD EPYC 7763, 1 CPU, 2 logical cores and 1 physical core
.NET SDK 7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
| Method | Mean      | Error     | StdDev    |
|------- |----------:|----------:|----------:|
| Sha256 |  6.669 μs | 0.0887 μs | 0.0786 μs |
| Md5    | 15.443 μs | 0.2754 μs | 0.2576 μs |
