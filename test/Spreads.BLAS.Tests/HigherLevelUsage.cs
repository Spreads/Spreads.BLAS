using Spreads.Native;
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
                CBLAS.Sgemm(MatrixLayout.RowMajor, TransCblas.NoTrans, TransCblas.NoTrans,
                    mnk, mnk, mnk, alpha: 1f, xP, mnk, xP, mnk, beta: 0, cP, mnk);
            }
        }
    }
}