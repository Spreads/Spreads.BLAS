using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using NUnit.Framework;
using Spreads.Native;
using static Spreads.BLAS;

// ReSharper disable InconsistentNaming

namespace Spreads.Tests.LinAlg
{
    [TestFixture]
    public unsafe class ShermanMorrison
    {
        //   N
        // K x
        private int Rows = 1_000_000;
        private int Columns = 100;

        private double* Data;

        [SetUp]
        public void SetUp()
        {
#if DEBUG
            Rows = 10;
            Columns = 2;
            Data = (double*) Marshal.AllocHGlobal(Rows * Columns * 8);

            // from PanelMMult.xlsx
            var arr = new[]
            {
                0.613077764136449, 1.30653888206822,
                0.452017450026296, 1.22600872501315,
                0.895214774294235, 1.44760738714712,
                0.214079324867381, 1.10703966243369,
                0.524884962628586, 1.26244248131429,
                0.934841614876884, 1.46742080743844,
                0.115584240522701, 1.564864131848,
                0.636147872291917, 1.31807393614596,
                0.711662059324224, 1.35583102966211,
                0.759243733534484, 1.37962186676724,
            };

            for (int i = 0; i < arr.Length; i++)
            {
                Data[i] = arr[i];
            }
#else
            var rng = new Random(42);
            Data = (double*) Marshal.AllocHGlobal(Rows * Columns * 8);
            for (int i = 0; i < Rows * Columns; i++)
            {
                Data[i] = rng.NextDouble() - 0.5;
            }
#endif
        }

        [Test]
        public void CouldUseSMFormulaCorrectly()
        {
            BLAS.BlasNumThreads = 1;
            // Calculate (X'X)^-1 for M and M-1

            var dataSpan = new Span<double>(Data, Columns * Rows);

            var rounds = 3;
            var count = 20;

            var rows = new[] {2, 4, 6, 8, 10, 15, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500};
            var columns = new[] {2, 4, 6, 8, 10, 15, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500};
            var syrkVsGemm = new bool[rows.Length, columns.Length];

            Console.Write($"     ");
            foreach (var co in columns)
            {
                Console.Write($"{co} ");
            }
            Console.WriteLine();
            
            foreach (var ro in rows)
            {
                Console.Write($"{ro}: ");
                foreach (var co in columns)
                {
                    Rows = ro;
                    Columns = co;
                    Marshal.FreeHGlobal((IntPtr) Data);
                    SetUp();
                    var xxN = (double*) Marshal.AllocHGlobal(Columns * Columns * 8);
                    var xxN1 = (double*) Marshal.AllocHGlobal(Columns * Columns * 8);

                    var xxNSpan = new Span<double>(xxN, Columns * Columns);
                    var xxN1Span = new Span<double>(xxN1, Columns * Columns);

                    var flopsMult = 1L * Columns * Columns * Rows * 2;

                    for (int r = 0; r < rounds; r++)
                    {
                        var statGemm = Benchmark.Run($"Dgemm_{ro}x{co}", count * flopsMult, silent: true);
                        {
                            for (int i = 0; i < count; i++)
                            {
                                var data = Data;
                                CBLAS.Dgemm(LAYOUT.RowMajor, TRANSPOSE.Trans, TRANSPOSE.NoTrans, Columns, Columns, Rows, alpha: 1.0,
                                    data, Columns,
                                    data, Columns,
                                    beta: 0.0,
                                    xxN, Columns);
                            }
                        }
                        statGemm.Dispose();
                        
                        var starSyrk = Benchmark.Run($"Dsyrk_{ro}x{co}", count * flopsMult, silent: true);
                        {
                            for (int i = 0; i < count; i++)
                            {
                                var data = Data;
                                CBLAS.Dsyrk(LAYOUT.RowMajor, UPLO.Upper, TRANSPOSE.Trans, Columns, Rows, 1.0,
                                    data, Columns, 0.0, xxN, Columns);
                            }
                        }
                        starSyrk.Dispose();

                        if (r == rounds - 1)
                        {
                            // Console.WriteLine($"starSyrk.MOPS {starSyrk.MOPS} - starGemm.MOPS {statGemm.MOPS}");
                            if (starSyrk.MOPS > statGemm.MOPS)
                            {
                                // syrkVsGemm[ro, co] = true;
                                Console.Write(1 + " ");
                            }
                            else
                            {
                                Console.Write(0 + " ");
                            }
                        }
                    }
                }

                Console.WriteLine();
            }

            // Benchmark.Dump();

            // CBLAS.Dsyrk(LAYOUT.RowMajor, UPLO.Lower, TRANSPOSE.Trans, Columns, Rows - 1, 1.0, Data, Rows, 0.0, xxN1, Columns);
        }
    }
}