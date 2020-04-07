using System;
using System.Runtime.InteropServices;
using NumSharp;
using NUnit.Framework;
using Spreads.Native;
using static Spreads.BLAS;

// ReSharper disable InconsistentNaming
// ReSharper disable HeapView.BoxingAllocation

namespace Spreads.Tests
{
    [Category("CI")]
    [TestFixture]
    public class OpenBLASTests
    {
        [Test]
        public void OpenBlasCallsWork()
        {
            Assert.AreEqual(Environment.ProcessorCount, OpenBLAS.OpenblasGetNumThreads());
            var threads = Math.Min(Environment.ProcessorCount, 3);
            OpenBLAS.OpenblasSetNumThreads(threads);
            Assert.AreEqual(threads, OpenBLAS.OpenblasGetNumThreads());
            Assert.AreEqual(Environment.ProcessorCount, OpenBLAS.OpenblasGetNumProcs());
            Console.WriteLine(OpenBLAS.OpenblasGetNumProcs());
        }

        [Test, Explicit("depends on MKL")]
        public void MklCallsWork()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Assert.IsTrue(MKL.MKL_GetMaxThreads() == Environment.ProcessorCount || MKL.MKL_GetMaxThreads() == Environment.ProcessorCount / 2);
            }
            else
            {
                Assert.Inconclusive();
            }
        }

        [Test, Explicit("Bench")]
        public unsafe void SgemmBenchmark()
        {
            var sizes = new[] {2, 3, 5, 7, 10, 20, 30, 40,}; // 
            foreach (var mnk in sizes)
            {
                var count = 100;
                var rounds = 5;
                var x = new float[mnk * mnk];

                for (int i = 0; i < mnk * mnk; i++)
                {
                    x[i] = (i + 1);
                }

                OpenBLAS.OpenblasSetNumThreads(1);
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
                            OpenBLAS.CBLAS.Sgemm(LAYOUT.RowMajor, TRANSPOSE.NoTrans, TRANSPOSE.NoTrans,
                                mnk, mnk, mnk, alpha: 1f, (float*) h.Pointer, mnk, (float*) h.Pointer, mnk, beta: 0, (float*) hc.Pointer, mnk);
                        }
                    }

                    using (Benchmark.Run($"MKL_Sgemm_{mnk}", count * 2L * mnk * mnk * mnk))
                    {
                        for (int i = 0; i < count; i++)
                        {
                            MKL.CBLAS.Sgemm(LAYOUT.RowMajor, TRANSPOSE.NoTrans, TRANSPOSE.NoTrans,
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

        [Test, Explicit("Bench")]
        public unsafe void CouldCallSgemm()
        {
            var mnk = 2;
            var count = 100;
            var rounds = 5;
            var x = new float[mnk * mnk];

            for (int i = 0; i < mnk * mnk; i++)
            {
                x[i] = (i + 1);
            }

            OpenBLAS.OpenblasSetNumThreads(1);
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
                        OpenBLAS.CBLAS.Sgemm(LAYOUT.RowMajor, TRANSPOSE.NoTrans, TRANSPOSE.NoTrans,
                            mnk, mnk, mnk, alpha: 1f, (float*) h.Pointer, mnk, (float*) h.Pointer, mnk, beta: 0, (float*) hc.Pointer, mnk);
                    }
                }

                using (Benchmark.Run($"MKL_Sgemm_{mnk}", count * 2L * mnk * mnk * mnk))
                {
                    for (int i = 0; i < count; i++)
                    {
                        MKL.CBLAS.Sgemm(LAYOUT.RowMajor, TRANSPOSE.NoTrans, TRANSPOSE.NoTrans,
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
    }
}