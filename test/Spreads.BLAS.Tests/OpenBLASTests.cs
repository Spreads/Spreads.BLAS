using System;
using NumSharp;
using NUnit.Framework;
using Spreads.Native;

// ReSharper disable HeapView.BoxingAllocation

namespace Spreads.BLAS.Tests
{
    [TestFixture]
    public class OpenBLASTests
    {
        [Test]
        public void OpenBlasCallsWork()
        {
            Assert.AreEqual(Environment.ProcessorCount, Native.OpenBLAS.CBLAS.OpenblasGetNumThreads());
            var threads = Math.Min(Environment.ProcessorCount, 3);
            Native.OpenBLAS.CBLAS.OpenblasSetNumThreads(threads);
            Assert.AreEqual(threads, Native.OpenBLAS.CBLAS.OpenblasGetNumThreads());
            Assert.AreEqual(Environment.ProcessorCount, Native.OpenBLAS.CBLAS.OpenblasGetNumProcs());
        }

        [Test]
        public void MklCallsWork()
        {
            Assert.IsTrue(MKL.MKL_GetMaxThreads() == Environment.ProcessorCount || MKL.MKL_GetMaxThreads() == Environment.ProcessorCount / 2);
            // var threads = Math.Min(Environment.ProcessorCount, 3);
            // OpenBLAS.CBLAS.OpenblasSetNumThreads(threads);
            // Assert.AreEqual(threads, OpenBLAS.CBLAS.OpenblasGetNumThreads());
            // Assert.AreEqual(Environment.ProcessorCount, OpenBLAS.CBLAS.OpenblasGetNumProcs());
        }

        [Test]
        public unsafe void SgemmBenchmark()
        {
            var sizes = new[] { 2, 3, 5, 7, 10, 20, 30, 40,}; // 
            foreach (var mnk in sizes)
            {
                var count = 100;
                var rounds = 5;
                var x = new float[mnk * mnk];

                for (int i = 0; i < mnk * mnk; i++)
                {
                    x[i] = (i + 1);
                }

                Native.OpenBLAS.CBLAS.OpenblasSetNumThreads(1);
                MKL.MKL_SetThreadingLayer(1);
                MathNet.Numerics.Control.UseSingleThread();
                var nd = np.arange(mnk * mnk).reshape(mnk, mnk);
                
                var h = x.AsMemory().Pin();
                var c = new float[mnk * mnk];
                var hc = c.AsMemory().Pin();

                var mdnX = MathNet.Numerics.LinearAlgebra.Matrix<float>.Build.Dense(mnk, mnk, x);
                var mdnC = MathNet.Numerics.LinearAlgebra.Matrix<float>.Build.Dense(mnk, mnk);

                for (int _ = 0; _ < rounds; _++)
                {
                    using (Benchmark.Run($"OB__Sgemm_{mnk}", count * 2L * mnk * mnk * mnk))
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Native.OpenBLAS.CBLAS.CblasSgemm(Native.OpenBLAS.CBLAS_ORDER.CblasRowMajor, Native.OpenBLAS.CBLAS_TRANSPOSE.CblasNoTrans, Native.OpenBLAS.CBLAS_TRANSPOSE.CblasNoTrans,
                                mnk, mnk, mnk, alpha: 1f, (float*) h.Pointer, mnk, (float*) h.Pointer, mnk, beta: 0, (float*) hc.Pointer, mnk);
                        }
                    }
                    
                    using (Benchmark.Run($"MKL_Sgemm_{mnk}", count * 2L * mnk * mnk * mnk))
                    {
                        for (int i = 0; i < count; i++)
                        {
                            MKL.CblasSgemm(MKL.CBLAS_LAYOUT.CblasRowMajor, MKL.CBLAS_TRANSPOSE.CblasNoTrans, MKL.CBLAS_TRANSPOSE.CblasNoTrans,
                                mnk, mnk, mnk, alpha: 1f, (float*) h.Pointer, mnk, (float*) h.Pointer, mnk, beta: 0, (float*) hc.Pointer, mnk);
                        }
                    }

                    GC.Collect(2, GCCollectionMode.Forced);
                    using (Benchmark.Run($"M.N_Sgemm_{mnk}", (count / 50) * 2L * mnk * mnk * mnk))
                    {
                        for (int i = 0; i < count / 50; i++)
                        {
                            mdnX.Multiply(mdnX, mdnC);
                        }
                    }
                    
                    GC.Collect(2, GCCollectionMode.Forced);
                    using (Benchmark.Run($"N#_Sgemm_{mnk}", (count / 50) * 2L * mnk * mnk * mnk))
                    {
                        for (int i = 0; i < count / 50; i++)
                        {
                            
                            np.matmul(nd, nd);
                        }
                    }
                    
                    GC.Collect(2, GCCollectionMode.Forced);
                }
            }

            Benchmark.Dump();
        }
    }
}