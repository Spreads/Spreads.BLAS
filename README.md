# Spreads.BLAS

This library contains CBLAS and LAPACKE API bindings to OpenBLAS and MKL and OpenBLAS binaries 
for Windows, Linux and MacOS included in it's [NuGet package](https://www.nuget.org/packages/Spreads.BLAS).

[OpenBLAS](https://github.com/xianyi/OpenBLAS) (OB) binaries have reasonable size and are included in this library's NuGet package for Windows, Linux and MacOS.
OB has performance very close to MKL, especially for large matrices. It is a good default, because 
more often the main question is whether to use an optimized library or use a managed one. The existing
.NET libraries are just too slow and it makes no sense to avoid small OB dependency as default.

[MKL](https://en.wikipedia.org/wiki/Math_Kernel_Library) is still moderately faster for dimensions up to N=250 (square NxN matrices Sgemm).
This library exposes MKL native bindings but does not include binaries in the NuGet package.
However, there is official MKL NuGet package for Windows [intelmkl.redist.win-x64](https://www.nuget.org/packages/intelmkl.redist.win-x64/)
that you can install in the final application and it will be picked up. On other platforms
MKL could be easily installed from [Intel web site](https://software.intel.com/en-us/mkl/choose-download) 
and the binaries should be in native libraries search path for the bindings to work.   

MKL is free (as in beer, it's not OSS) for a long time, but it's redistribution is bulky (on Windows, NuGet compressed package is 173 MB 
and uncompressed binaries size is 481 MB) and downloads from Intel web site require stupid registration
(and they do spam with marketing bullshit afterwards even if you had unchecked the boxes and then unsubscribed after the first email). 
Also, MKL could be slower on AMD processors because Intel artificially de-optimizes MKL on non-Intel hardware
even if it is capable of running the very optimized code. Therefore, usage of MKL is discouraged
unless BLAS routines are the main bottleneck in your application. And in that case, MKL should be 
added as the very last step after profiling and confirming the bottleneck.

## Low-level native API

The native bindings are generated using CppSharp and exposed directly (non-wrapped P/Invokes calls).

The `Spreads.Native` namespace has two static classed `OpenBLAS` and `MKL`. Each of them has 
static subclasses `CBLAS` and `LAPACKE` with all corresponding APIs.

The parent classes have `IsSupported` property that follows the .NET Intrinsics pattern: it's a JIT-time 
constant and false branches from these properties are zero-cost and completely eliminated by JIT.
The `IsSupported` property means that a native library could be correctly loaded. It should be always
true for OpenBLAS (otherwise NuGet packaging is not working correctly, please report this).

The usage might be:

```csharp
public static void Sgemm(...params)
    if(Spreads.Native.MKL.IsSupported)
    {
        Spreads.Native.MKL.CBLAS.Sgemm(...params);
    }
    else if(Spreads.Native.OpenBLAS.IsSupported)  
    {
        // this should be always true and we 
        // could have just else followed by
        // Debug.Assert(Spreads.Native.OpenBLAS.IsSupported);
        Spreads.Native.OpenBLAS.CBLAS.Sgemm(...params);
    }
    throw new NotSupportedException();
```    


The parent classes expose their specific service methods, e.g. `OpenBLAS.OpenblasSetNumThreads` or `MKL.MKL_SetThreadingLayer`.

There is a setting `Spreads.Native.BLASSettings.UseMKLIfAvailable: bool` that could be set to false, 
in which case `MKL.IsSupported` will be false even when MKL is present, but only if the setting is set before calling
any method from this library (including `IsSupported` property itself, after it is accessed and initialized 
it becomes a constant). Despite comments on MKL above, `UseMKLIfAvailable` is set to true because 
usually its presence on the system already indicates the user preference. Disabling MKL using this 
setting could be useful for benchmarking a final application (and to delete MKL after that if 
it is not substantially better for a particular case).

## Higher-level API

A static class `Spreads.BLAS` exposes a unified API with methods implemented exactly like in the low-level usage example above. E.g.

```csharp
public static void Saxpby(int n, float alpha, float* x, int incX, float beta, float* y, int incY)
{
    if (MKL.IsSupoprted)
    {
        MKL.CBLAS.Saxpby(n, alpha, x, incX, beta, y, incY);
        return;
    }

    OpenBLAS.CBLAS.Saxpby(n, alpha, x, incX, beta, y, incY);
}

```

Such API hides selection of native libraries and allows to add new native bindings or alternative implementation without changing code.
E.g. some BLAS routines may be implemented using .NET intrinsics in the future.
This could remove native calls overheads for small-dimension operations with scalars and 1-dimensional vector math.

Instead of using `Spreads.Native.OpenBLAS.CBLAS.XXX` or `Spreads.Native.MKL.CBLAS.XXX` you could use `Spreads.BLAS.CBLAS.XXX` 
(same with `Spreads.BLAS.LAPACKE`). It is convenient to import `Spreads.BLAS` statically because that allows to remove `BLAS.` 
prefix in many places.


```csharp
using static Spreads.BLAS; // allows to remove all BLAS. prefixes

namespace Spreads.Tests
{
    public class HigherLevelUsage
    {
        public static unsafe void Sample()
        {
            BlasNumThreads = 1;

            var mnk = 2;
            var x = new float[mnk * mnk];
            var c = new float[mnk * mnk];

            for (int i = 0; i < mnk * mnk; i++)
            {
                x[i] = (i + 1);
            }

            fixed (float* xP = &x[0])
            fixed (float* cP = &c[0])
            {
                CBLAS.Sgemm(LAYOUT.RowMajor, TRANSPOSE.NoTrans, TRANSPOSE.NoTrans,
                    mnk, mnk, mnk, alpha: 1f, xP, mnk, xP, mnk, beta: 0, cP, mnk);
            }
        }
    }
}

```

Documentation for [CBLAS](https://www.netlib.org/blas/#_blas_routines) and [LAPACKE](https://www.netlib.org/lapack/lapacke.html) at netlib.org.

[Intel documentation](https://software.intel.com/en-us/mkl-developer-reference-fortran-overview).

[LAPACK Function Finding Advisor](https://software.intel.com/en-us/articles/intel-mkl-function-finding-advisor)

## Building

Bindings are generated using [CppSharp](https://github.com/mono/CppSharp) and then manually copied to appropriate places in the static classes.

Binaries for OpenBLAS are not committed and could be taken from [conda-forge distribution](https://anaconda.org/conda-forge/libopenblas/files)
(Fortran runtime and OpenMP dependencies must be included from relevant conda packages, as well as C runtime for Windows must be present).

The first version of Spreads.BLAS has binaries from conda-forge because they just work.

In the next versions, OpenMP will be disabled (not used on .NET) and the C runtime will be linked statically on Windows.

OpenBLAS [build from source](https://github.com/xianyi/OpenBLAS#installation-from-source) [instructions](https://github.com/xianyi/OpenBLAS/wiki/How-to-use-OpenBLAS-in-Microsoft-Visual-Studio) work fine.

## License

MPL 2.0. See the [license file](https://github.com/Spreads/Spreads.BLAS/blob/master/LICENSE.txt) and [third-party licenses](https://github.com/Spreads/Spreads.BLAS/blob/master/LICENSE.Dependencies.txt).
