using System.Runtime.CompilerServices;
using Spreads.Native;

namespace Spreads
{
    public static unsafe partial class BLAS
    {
        public static class CBLAS
        {
            // TODO Generate this stuff
            
            public static void Sgemm(LAYOUT layout, TRANSPOSE transA, TRANSPOSE transB, int m, int n, int k, float alpha, float* a, int lda, float* b,
                int ldb, float beta, float* c, int ldc)
            {
                if (MKL.IsSupoprted)
                    MKL.CBLAS.Sgemm(layout, transA, transB, m, n, k, alpha, a, lda, b, ldb, beta, c, ldc);
                else
                    OpenBLAS.CBLAS.Sgemm(layout, transA, transB, m, n, k, alpha, a, lda, b, ldb, beta, c, ldc);
            }

            public static void Dgemm(LAYOUT layout, TRANSPOSE transA, TRANSPOSE transB, int m, int n, int k, double alpha, double* a, int lda, double* b,
                int ldb, double beta, double* c, int ldc)
            {
                if (MKL.IsSupoprted)
                    MKL.CBLAS.Dgemm(layout, transA, transB, m, n, k, alpha, a, lda, b, ldb, beta, c, ldc);
                else
                    OpenBLAS.CBLAS.Dgemm(layout, transA, transB, m, n, k, alpha, a, lda, b, ldb, beta, c, ldc);
            }
        }
    }
}