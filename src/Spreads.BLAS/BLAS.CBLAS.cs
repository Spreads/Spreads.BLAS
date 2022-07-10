// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using Spreads.Native;

// ReSharper disable InconsistentNaming
// ReSharper disable ConvertIfStatementToReturnStatement

namespace Spreads
{
    public static unsafe partial class BLAS
    {
        public static class CBLAS
        {
            public static float Sasum(int n, float* x, int incX)
            {
                if (MKL.IsSupoprted)
                    return MKL.CBLAS.Sasum(n, x, incX);

                return OpenBLAS.CBLAS.Sasum(n, x, incX);
            }

            public static double Dasum(int n, double* x, int incX)
            {
                if (MKL.IsSupoprted)
                    return MKL.CBLAS.Dasum(n, x, incX);

                return OpenBLAS.CBLAS.Dasum(n, x, incX);
            }

            public static void Saxpby(int n, float alpha, float* x, int incX, float beta, float* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Saxpby(n, alpha, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Saxpby(n, alpha, x, incX, beta, y, incY);
            }

            public static void Daxpby(int n, double alpha, double* x, int incX, double beta, double* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Daxpby(n, alpha, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Daxpby(n, alpha, x, incX, beta, y, incY);
            }

            public static void Caxpby(int n, System.IntPtr alpha, System.IntPtr x, int incX, System.IntPtr beta, System.IntPtr y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Caxpby(n, alpha, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Caxpby(n, alpha, x, incX, beta, y, incY);
            }

            public static void Zaxpby(int n, System.IntPtr alpha, System.IntPtr x, int incX, System.IntPtr beta, System.IntPtr y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zaxpby(n, alpha, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Zaxpby(n, alpha, x, incX, beta, y, incY);
            }

            public static void Saxpy(int n, float alpha, float* x, int incX, float* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Saxpy(n, alpha, x, incX, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Saxpy(n, alpha, x, incX, y, incY);
            }

            public static void Daxpy(int n, double alpha, double* x, int incX, double* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Daxpy(n, alpha, x, incX, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Daxpy(n, alpha, x, incX, y, incY);
            }

            public static void Caxpy(int n, System.IntPtr alpha, System.IntPtr x, int incX, System.IntPtr y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Caxpy(n, alpha, x, incX, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Caxpy(n, alpha, x, incX, y, incY);
            }

            public static void Zaxpy(int n, System.IntPtr alpha, System.IntPtr x, int incX, System.IntPtr y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zaxpy(n, alpha, x, incX, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Zaxpy(n, alpha, x, incX, y, incY);
            }

            public static ulong Icamax(int n, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                    return MKL.CBLAS.Icamax(n, x, incX);

                return OpenBLAS.CBLAS.Icamax(n, x, incX);
            }

            public static ulong Icamin(int n, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                    return MKL.CBLAS.Icamin(n, x, incX);

                return OpenBLAS.CBLAS.Icamin(n, x, incX);
            }

            public static float Scasum(int n, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                    return MKL.CBLAS.Scasum(n, x, incX);

                return OpenBLAS.CBLAS.Scasum(n, x, incX);
            }

            public static float Scnrm2(int n, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                    return MKL.CBLAS.Scnrm2(n, x, incX);

                return OpenBLAS.CBLAS.Scnrm2(n, x, incX);
            }

            public static void Scopy(int n, float* x, int incX, float* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Scopy(n, x, incX, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Scopy(n, x, incX, y, incY);
            }

            public static void Dcopy(int n, double* x, int incX, double* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dcopy(n, x, incX, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Dcopy(n, x, incX, y, incY);
            }

            public static void Ccopy(int n, System.IntPtr x, int incX, System.IntPtr y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ccopy(n, x, incX, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Ccopy(n, x, incX, y, incY);
            }

            public static void Zcopy(int n, System.IntPtr x, int incX, System.IntPtr y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zcopy(n, x, incX, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Zcopy(n, x, incX, y, incY);
            }

            public static ulong Idamax(int n, double* x, int incX)
            {
                if (MKL.IsSupoprted)
                    return MKL.CBLAS.Idamax(n, x, incX);

                return OpenBLAS.CBLAS.Idamax(n, x, incX);
            }

            public static ulong Idamin(int n, double* x, int incX)
            {
                if (MKL.IsSupoprted)
                    return MKL.CBLAS.Idamin(n, x, incX);

                return OpenBLAS.CBLAS.Idamin(n, x, incX);
            }

            public static float Sdot(int n, float* x, int incX, float* y, int incY)
            {
                if (MKL.IsSupoprted)
                    return MKL.CBLAS.Sdot(n, x, incX, y, incY);

                return OpenBLAS.CBLAS.Sdot(n, x, incX, y, incY);
            }

            public static double Ddot(int n, double* x, int incX, double* y, int incY)
            {
                if (MKL.IsSupoprted)
                    return MKL.CBLAS.Ddot(n, x, incX, y, incY);

                return OpenBLAS.CBLAS.Ddot(n, x, incX, y, incY);
            }

            public static void CdotcSub(int n, System.IntPtr x, int incX, System.IntPtr y, int incY, System.IntPtr dotc)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.CdotcSub(n, x, incX, y, incY, dotc);
                    return;
                }

                OpenBLAS.CBLAS.CdotcSub(n, x, incX, y, incY, dotc);
            }

            public static void ZdotcSub(int n, System.IntPtr x, int incX, System.IntPtr y, int incY, System.IntPtr dotc)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.ZdotcSub(n, x, incX, y, incY, dotc);
                    return;
                }

                OpenBLAS.CBLAS.ZdotcSub(n, x, incX, y, incY, dotc);
            }

            public static void CdotuSub(int n, System.IntPtr x, int incX, System.IntPtr y, int incY, System.IntPtr dotu)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.CdotuSub(n, x, incX, y, incY, dotu);
                    return;
                }

                OpenBLAS.CBLAS.CdotuSub(n, x, incX, y, incY, dotu);
            }

            public static void ZdotuSub(int n, System.IntPtr x, int incX, System.IntPtr y, int incY, System.IntPtr dotu)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.ZdotuSub(n, x, incX, y, incY, dotu);
                    return;
                }

                OpenBLAS.CBLAS.ZdotuSub(n, x, incX, y, incY, dotu);
            }

            public static void Zdscal(int n, double alpha, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zdscal(n, alpha, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Zdscal(n, alpha, x, incX);
            }

            public static float Sdsdot(int n, float sb, float* x, int incX, float* y, int incY)
            {
                if (MKL.IsSupoprted)
                    return MKL.CBLAS.Sdsdot(n, sb, x, incX, y, incY);

                return OpenBLAS.CBLAS.Sdsdot(n, sb, x, incX, y, incY);
            }

            public static void Sgbmv(MatrixLayout matrixLayout, TransCblas transA, int m, int n, int kL, int kU, float alpha, float* a, int ldA, float* x, int incX, float beta, float* y,
                int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Sgbmv(matrixLayout, transA, m, n, kL, kU, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Sgbmv(matrixLayout, transA, m, n, kL, kU, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Dgbmv(MatrixLayout matrixLayout, TransCblas transA, int m, int n, int kL, int kU, double alpha, double* a, int ldA, double* x, int incX, double beta, double* y,
                int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dgbmv(matrixLayout, transA, m, n, kL, kU, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Dgbmv(matrixLayout, transA, m, n, kL, kU, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Cgbmv(MatrixLayout matrixLayout, TransCblas transA, int m, int n, int kL, int kU, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr x, int incX,
                System.IntPtr beta, System.IntPtr y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cgbmv(matrixLayout, transA, m, n, kL, kU, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Cgbmv(matrixLayout, transA, m, n, kL, kU, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Zgbmv(MatrixLayout matrixLayout, TransCblas transA, int m, int n, int kL, int kU, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr x, int incX,
                System.IntPtr beta, System.IntPtr y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zgbmv(matrixLayout, transA, m, n, kL, kU, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Zgbmv(matrixLayout, transA, m, n, kL, kU, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Sgemm(MatrixLayout matrixLayout, TransCblas transA, TransCblas transB, int m, int n, int k, float alpha, float* a, int ldA, float* b, int ldB, float beta,
                float* c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Sgemm(matrixLayout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Sgemm(matrixLayout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Dgemm(MatrixLayout matrixLayout, TransCblas transA, TransCblas transB, int m, int n, int k, double alpha, double* a, int ldA, double* b, int ldB, double beta,
                double* c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dgemm(matrixLayout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Dgemm(matrixLayout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Cgemm(MatrixLayout matrixLayout, TransCblas transA, TransCblas transB, int m, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b,
                int ldB, System.IntPtr beta, System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cgemm(matrixLayout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Cgemm(matrixLayout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Zgemm(MatrixLayout matrixLayout, TransCblas transA, TransCblas transB, int m, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b,
                int ldB, System.IntPtr beta, System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zgemm(matrixLayout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Zgemm(matrixLayout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Cgemm3m(MatrixLayout matrixLayout, TransCblas transA, TransCblas transB, int m, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b,
                int ldB, System.IntPtr beta, System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cgemm3m(matrixLayout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Cgemm3m(matrixLayout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Zgemm3m(MatrixLayout matrixLayout, TransCblas transA, TransCblas transB, int m, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b,
                int ldB, System.IntPtr beta, System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zgemm3m(matrixLayout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Zgemm3m(matrixLayout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Sgemv(MatrixLayout matrixLayout, TransCblas transA, int m, int n, float alpha, float* a, int ldA, float* x, int incX, float beta, float* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Sgemv(matrixLayout, transA, m, n, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Sgemv(matrixLayout, transA, m, n, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Dgemv(MatrixLayout matrixLayout, TransCblas transA, int m, int n, double alpha, double* a, int ldA, double* x, int incX, double beta, double* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dgemv(matrixLayout, transA, m, n, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Dgemv(matrixLayout, transA, m, n, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Cgemv(MatrixLayout matrixLayout, TransCblas transA, int m, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr x, int incX, System.IntPtr beta,
                System.IntPtr y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cgemv(matrixLayout, transA, m, n, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Cgemv(matrixLayout, transA, m, n, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Zgemv(MatrixLayout matrixLayout, TransCblas transA, int m, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr x, int incX, System.IntPtr beta,
                System.IntPtr y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zgemv(matrixLayout, transA, m, n, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Zgemv(matrixLayout, transA, m, n, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Sger(MatrixLayout matrixLayout, int m, int n, float alpha, float* x, int incX, float* y, int incY, float* a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Sger(matrixLayout, m, n, alpha, x, incX, y, incY, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Sger(matrixLayout, m, n, alpha, x, incX, y, incY, a, ldA);
            }

            public static void Dger(MatrixLayout matrixLayout, int m, int n, double alpha, double* x, int incX, double* y, int incY, double* a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dger(matrixLayout, m, n, alpha, x, incX, y, incY, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Dger(matrixLayout, m, n, alpha, x, incX, y, incY, a, ldA);
            }

            public static void Cgerc(MatrixLayout matrixLayout, int m, int n, System.IntPtr alpha, System.IntPtr x, int incX, System.IntPtr y, int incY, System.IntPtr a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cgerc(matrixLayout, m, n, alpha, x, incX, y, incY, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Cgerc(matrixLayout, m, n, alpha, x, incX, y, incY, a, ldA);
            }

            public static void Zgerc(MatrixLayout matrixLayout, int m, int n, System.IntPtr alpha, System.IntPtr x, int incX, System.IntPtr y, int incY, System.IntPtr a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zgerc(matrixLayout, m, n, alpha, x, incX, y, incY, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Zgerc(matrixLayout, m, n, alpha, x, incX, y, incY, a, ldA);
            }

            public static void Cgeru(MatrixLayout matrixLayout, int m, int n, System.IntPtr alpha, System.IntPtr x, int incX, System.IntPtr y, int incY, System.IntPtr a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cgeru(matrixLayout, m, n, alpha, x, incX, y, incY, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Cgeru(matrixLayout, m, n, alpha, x, incX, y, incY, a, ldA);
            }

            public static void Zgeru(MatrixLayout matrixLayout, int m, int n, System.IntPtr alpha, System.IntPtr x, int incX, System.IntPtr y, int incY, System.IntPtr a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zgeru(matrixLayout, m, n, alpha, x, incX, y, incY, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Zgeru(matrixLayout, m, n, alpha, x, incX, y, incY, a, ldA);
            }

            public static void Chbmv(MatrixLayout matrixLayout, UpLoCblas uplo, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr x, int incX, System.IntPtr beta,
                System.IntPtr y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Chbmv(matrixLayout, uplo, n, k, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Chbmv(matrixLayout, uplo, n, k, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Zhbmv(MatrixLayout matrixLayout, UpLoCblas uplo, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr x, int incX, System.IntPtr beta,
                System.IntPtr y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zhbmv(matrixLayout, uplo, n, k, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Zhbmv(matrixLayout, uplo, n, k, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Chemm(MatrixLayout matrixLayout, SIDE side, UpLoCblas uplo, int m, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b, int ldB, System.IntPtr beta,
                System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Chemm(matrixLayout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Chemm(matrixLayout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Zhemm(MatrixLayout matrixLayout, SIDE side, UpLoCblas uplo, int m, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b, int ldB, System.IntPtr beta,
                System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zhemm(matrixLayout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Zhemm(matrixLayout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Chemv(MatrixLayout matrixLayout, UpLoCblas uplo, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr x, int incX, System.IntPtr beta, System.IntPtr y,
                int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Chemv(matrixLayout, uplo, n, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Chemv(matrixLayout, uplo, n, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Zhemv(MatrixLayout matrixLayout, UpLoCblas uplo, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr x, int incX, System.IntPtr beta, System.IntPtr y,
                int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zhemv(matrixLayout, uplo, n, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Zhemv(matrixLayout, uplo, n, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Cher(MatrixLayout matrixLayout, UpLoCblas uplo, int n, float alpha, System.IntPtr x, int incX, System.IntPtr a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cher(matrixLayout, uplo, n, alpha, x, incX, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Cher(matrixLayout, uplo, n, alpha, x, incX, a, ldA);
            }

            public static void Zher(MatrixLayout matrixLayout, UpLoCblas uplo, int n, double alpha, System.IntPtr x, int incX, System.IntPtr a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zher(matrixLayout, uplo, n, alpha, x, incX, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Zher(matrixLayout, uplo, n, alpha, x, incX, a, ldA);
            }

            public static void Cher2(MatrixLayout matrixLayout, UpLoCblas uplo, int n, System.IntPtr alpha, System.IntPtr x, int incX, System.IntPtr y, int incY, System.IntPtr a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cher2(matrixLayout, uplo, n, alpha, x, incX, y, incY, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Cher2(matrixLayout, uplo, n, alpha, x, incX, y, incY, a, ldA);
            }

            public static void Zher2(MatrixLayout matrixLayout, UpLoCblas uplo, int n, System.IntPtr alpha, System.IntPtr x, int incX, System.IntPtr y, int incY, System.IntPtr a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zher2(matrixLayout, uplo, n, alpha, x, incX, y, incY, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Zher2(matrixLayout, uplo, n, alpha, x, incX, y, incY, a, ldA);
            }

            public static void Cher2k(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas trans, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b, int ldB, float beta,
                System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cher2k(matrixLayout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Cher2k(matrixLayout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Zher2k(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas trans, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b, int ldB, double beta,
                System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zher2k(matrixLayout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Zher2k(matrixLayout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Cherk(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas trans, int n, int k, float alpha, System.IntPtr a, int ldA, float beta, System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cherk(matrixLayout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Cherk(matrixLayout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
            }

            public static void Zherk(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas trans, int n, int k, double alpha, System.IntPtr a, int ldA, double beta, System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zherk(matrixLayout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Zherk(matrixLayout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
            }

            public static void Chpmv(MatrixLayout matrixLayout, UpLoCblas uplo, int n, System.IntPtr alpha, System.IntPtr ap, System.IntPtr x, int incX, System.IntPtr beta, System.IntPtr y,
                int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Chpmv(matrixLayout, uplo, n, alpha, ap, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Chpmv(matrixLayout, uplo, n, alpha, ap, x, incX, beta, y, incY);
            }

            public static void Zhpmv(MatrixLayout matrixLayout, UpLoCblas uplo, int n, System.IntPtr alpha, System.IntPtr ap, System.IntPtr x, int incX, System.IntPtr beta, System.IntPtr y,
                int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zhpmv(matrixLayout, uplo, n, alpha, ap, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Zhpmv(matrixLayout, uplo, n, alpha, ap, x, incX, beta, y, incY);
            }

            public static void Chpr(MatrixLayout matrixLayout, UpLoCblas uplo, int n, float alpha, System.IntPtr x, int incX, System.IntPtr a)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Chpr(matrixLayout, uplo, n, alpha, x, incX, a);
                    return;
                }

                OpenBLAS.CBLAS.Chpr(matrixLayout, uplo, n, alpha, x, incX, a);
            }

            public static void Zhpr(MatrixLayout matrixLayout, UpLoCblas uplo, int n, double alpha, System.IntPtr x, int incX, System.IntPtr a)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zhpr(matrixLayout, uplo, n, alpha, x, incX, a);
                    return;
                }

                OpenBLAS.CBLAS.Zhpr(matrixLayout, uplo, n, alpha, x, incX, a);
            }

            public static void Chpr2(MatrixLayout matrixLayout, UpLoCblas uplo, int n, System.IntPtr alpha, System.IntPtr x, int incX, System.IntPtr y, int incY, System.IntPtr ap)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Chpr2(matrixLayout, uplo, n, alpha, x, incX, y, incY, ap);
                    return;
                }

                OpenBLAS.CBLAS.Chpr2(matrixLayout, uplo, n, alpha, x, incX, y, incY, ap);
            }

            public static void Zhpr2(MatrixLayout matrixLayout, UpLoCblas uplo, int n, System.IntPtr alpha, System.IntPtr x, int incX, System.IntPtr y, int incY, System.IntPtr ap)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zhpr2(matrixLayout, uplo, n, alpha, x, incX, y, incY, ap);
                    return;
                }

                OpenBLAS.CBLAS.Zhpr2(matrixLayout, uplo, n, alpha, x, incX, y, incY, ap);
            }

            public static float Snrm2(int n, float* x, int incX)
            {
                if (MKL.IsSupoprted)
                    return MKL.CBLAS.Snrm2(n, x, incX);

                return OpenBLAS.CBLAS.Snrm2(n, x, incX);
            }

            public static double Dnrm2(int n, double* x, int incX)
            {
                if (MKL.IsSupoprted)
                    return MKL.CBLAS.Dnrm2(n, x, incX);

                return OpenBLAS.CBLAS.Dnrm2(n, x, incX);
            }

            public static void Srot(int n, float* x, int incX, float* y, int incY, float c, float s)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Srot(n, x, incX, y, incY, c, s);
                    return;
                }

                OpenBLAS.CBLAS.Srot(n, x, incX, y, incY, c, s);
            }

            public static void Drot(int n, double* x, int incX, double* y, int incY, double c, double s)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Drot(n, x, incX, y, incY, c, s);
                    return;
                }

                OpenBLAS.CBLAS.Drot(n, x, incX, y, incY, c, s);
            }

            public static void Srotg(float* a, float* b, float* c, float* s)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Srotg(a, b, c, s);
                    return;
                }

                OpenBLAS.CBLAS.Srotg(a, b, c, s);
            }

            public static void Drotg(double* a, double* b, double* c, double* s)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Drotg(a, b, c, s);
                    return;
                }

                OpenBLAS.CBLAS.Drotg(a, b, c, s);
            }

            public static void Srotm(int n, float* x, int incX, float* y, int incY, float* p)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Srotm(n, x, incX, y, incY, p);
                    return;
                }

                OpenBLAS.CBLAS.Srotm(n, x, incX, y, incY, p);
            }

            public static void Drotm(int n, double* x, int incX, double* y, int incY, double* p)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Drotm(n, x, incX, y, incY, p);
                    return;
                }

                OpenBLAS.CBLAS.Drotm(n, x, incX, y, incY, p);
            }

            public static void Srotmg(float* d1, float* d2, float* b1, float b2, float* p)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Srotmg(d1, d2, b1, b2, p);
                    return;
                }

                OpenBLAS.CBLAS.Srotmg(d1, d2, b1, b2, p);
            }

            public static void Drotmg(double* d1, double* d2, double* b1, double b2, double* p)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Drotmg(d1, d2, b1, b2, p);
                    return;
                }

                OpenBLAS.CBLAS.Drotmg(d1, d2, b1, b2, p);
            }

            public static ulong Isamax(int n, float* x, int incX)
            {
                if (MKL.IsSupoprted)
                    return MKL.CBLAS.Isamax(n, x, incX);

                return OpenBLAS.CBLAS.Isamax(n, x, incX);
            }

            public static ulong Isamin(int n, float* x, int incX)
            {
                if (MKL.IsSupoprted)
                    return MKL.CBLAS.Isamin(n, x, incX);

                return OpenBLAS.CBLAS.Isamin(n, x, incX);
            }

            public static void Ssbmv(MatrixLayout matrixLayout, UpLoCblas uplo, int n, int k, float alpha, float* a, int ldA, float* x, int incX, float beta, float* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ssbmv(matrixLayout, uplo, n, k, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Ssbmv(matrixLayout, uplo, n, k, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Dsbmv(MatrixLayout matrixLayout, UpLoCblas uplo, int n, int k, double alpha, double* a, int ldA, double* x, int incX, double beta, double* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dsbmv(matrixLayout, uplo, n, k, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Dsbmv(matrixLayout, uplo, n, k, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Sscal(int n, float alpha, float* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Sscal(n, alpha, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Sscal(n, alpha, x, incX);
            }

            public static void Dscal(int n, double alpha, double* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dscal(n, alpha, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Dscal(n, alpha, x, incX);
            }

            public static void Cscal(int n, System.IntPtr alpha, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cscal(n, alpha, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Cscal(n, alpha, x, incX);
            }

            public static void Zscal(int n, System.IntPtr alpha, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zscal(n, alpha, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Zscal(n, alpha, x, incX);
            }

            public static double Dsdot(int n, float* x, int incX, float* y, int incY)
            {
                if (MKL.IsSupoprted)
                    return MKL.CBLAS.Dsdot(n, x, incX, y, incY);

                return OpenBLAS.CBLAS.Dsdot(n, x, incX, y, incY);
            }

            public static void Sspmv(MatrixLayout matrixLayout, UpLoCblas uplo, int n, float alpha, float* ap, float* x, int incX, float beta, float* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Sspmv(matrixLayout, uplo, n, alpha, ap, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Sspmv(matrixLayout, uplo, n, alpha, ap, x, incX, beta, y, incY);
            }

            public static void Dspmv(MatrixLayout matrixLayout, UpLoCblas uplo, int n, double alpha, double* ap, double* x, int incX, double beta, double* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dspmv(matrixLayout, uplo, n, alpha, ap, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Dspmv(matrixLayout, uplo, n, alpha, ap, x, incX, beta, y, incY);
            }

            public static void Sspr(MatrixLayout matrixLayout, UpLoCblas uplo, int n, float alpha, float* x, int incX, float* ap)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Sspr(matrixLayout, uplo, n, alpha, x, incX, ap);
                    return;
                }

                OpenBLAS.CBLAS.Sspr(matrixLayout, uplo, n, alpha, x, incX, ap);
            }

            public static void Dspr(MatrixLayout matrixLayout, UpLoCblas uplo, int n, double alpha, double* x, int incX, double* ap)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dspr(matrixLayout, uplo, n, alpha, x, incX, ap);
                    return;
                }

                OpenBLAS.CBLAS.Dspr(matrixLayout, uplo, n, alpha, x, incX, ap);
            }

            public static void Sspr2(MatrixLayout matrixLayout, UpLoCblas uplo, int n, float alpha, float* x, int incX, float* y, int incY, float* a)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Sspr2(matrixLayout, uplo, n, alpha, x, incX, y, incY, a);
                    return;
                }

                OpenBLAS.CBLAS.Sspr2(matrixLayout, uplo, n, alpha, x, incX, y, incY, a);
            }

            public static void Dspr2(MatrixLayout matrixLayout, UpLoCblas uplo, int n, double alpha, double* x, int incX, double* y, int incY, double* a)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dspr2(matrixLayout, uplo, n, alpha, x, incX, y, incY, a);
                    return;
                }

                OpenBLAS.CBLAS.Dspr2(matrixLayout, uplo, n, alpha, x, incX, y, incY, a);
            }

            public static void Csscal(int n, float alpha, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Csscal(n, alpha, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Csscal(n, alpha, x, incX);
            }

            public static void Sswap(int n, float* x, int incX, float* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Sswap(n, x, incX, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Sswap(n, x, incX, y, incY);
            }

            public static void Dswap(int n, double* x, int incX, double* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dswap(n, x, incX, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Dswap(n, x, incX, y, incY);
            }

            public static void Cswap(int n, System.IntPtr x, int incX, System.IntPtr y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cswap(n, x, incX, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Cswap(n, x, incX, y, incY);
            }

            public static void Zswap(int n, System.IntPtr x, int incX, System.IntPtr y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zswap(n, x, incX, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Zswap(n, x, incX, y, incY);
            }

            public static void Ssymm(MatrixLayout matrixLayout, SIDE side, UpLoCblas uplo, int m, int n, float alpha, float* a, int ldA, float* b, int ldB, float beta, float* c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ssymm(matrixLayout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Ssymm(matrixLayout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Dsymm(MatrixLayout matrixLayout, SIDE side, UpLoCblas uplo, int m, int n, double alpha, double* a, int ldA, double* b, int ldB, double beta, double* c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dsymm(matrixLayout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Dsymm(matrixLayout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Csymm(MatrixLayout matrixLayout, SIDE side, UpLoCblas uplo, int m, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b, int ldB, System.IntPtr beta,
                System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Csymm(matrixLayout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Csymm(matrixLayout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Zsymm(MatrixLayout matrixLayout, SIDE side, UpLoCblas uplo, int m, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b, int ldB, System.IntPtr beta,
                System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zsymm(matrixLayout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Zsymm(matrixLayout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Ssymv(MatrixLayout matrixLayout, UpLoCblas uplo, int n, float alpha, float* a, int ldA, float* x, int incX, float beta, float* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ssymv(matrixLayout, uplo, n, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Ssymv(matrixLayout, uplo, n, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Dsymv(MatrixLayout matrixLayout, UpLoCblas uplo, int n, double alpha, double* a, int ldA, double* x, int incX, double beta, double* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dsymv(matrixLayout, uplo, n, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Dsymv(matrixLayout, uplo, n, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Ssyr(MatrixLayout matrixLayout, UpLoCblas uplo, int n, float alpha, float* x, int incX, float* a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ssyr(matrixLayout, uplo, n, alpha, x, incX, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Ssyr(matrixLayout, uplo, n, alpha, x, incX, a, ldA);
            }

            public static void Dsyr(MatrixLayout matrixLayout, UpLoCblas uplo, int n, double alpha, double* x, int incX, double* a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dsyr(matrixLayout, uplo, n, alpha, x, incX, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Dsyr(matrixLayout, uplo, n, alpha, x, incX, a, ldA);
            }

            public static void Ssyr2(MatrixLayout matrixLayout, UpLoCblas uplo, int n, float alpha, float* x, int incX, float* y, int incY, float* a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ssyr2(matrixLayout, uplo, n, alpha, x, incX, y, incY, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Ssyr2(matrixLayout, uplo, n, alpha, x, incX, y, incY, a, ldA);
            }

            public static void Dsyr2(MatrixLayout matrixLayout, UpLoCblas uplo, int n, double alpha, double* x, int incX, double* y, int incY, double* a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dsyr2(matrixLayout, uplo, n, alpha, x, incX, y, incY, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Dsyr2(matrixLayout, uplo, n, alpha, x, incX, y, incY, a, ldA);
            }

            public static void Ssyr2k(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas trans, int n, int k, float alpha, float* a, int ldA, float* b, int ldB, float beta, float* c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ssyr2k(matrixLayout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Ssyr2k(matrixLayout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Dsyr2k(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas trans, int n, int k, double alpha, double* a, int ldA, double* b, int ldB, double beta, double* c,
                int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dsyr2k(matrixLayout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Dsyr2k(matrixLayout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Csyr2k(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas trans, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b, int ldB,
                System.IntPtr beta, System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Csyr2k(matrixLayout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Csyr2k(matrixLayout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Zsyr2k(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas trans, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b, int ldB,
                System.IntPtr beta, System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zsyr2k(matrixLayout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Zsyr2k(matrixLayout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Ssyrk(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas trans, int n, int k, float alpha, float* a, int ldA, float beta, float* c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ssyrk(matrixLayout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Ssyrk(matrixLayout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
            }

            public static void Dsyrk(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas trans, int n, int k, double alpha, double* a, int ldA, double beta, double* c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dsyrk(matrixLayout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Dsyrk(matrixLayout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
            }

            public static void Csyrk(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas trans, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr beta, System.IntPtr c,
                int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Csyrk(matrixLayout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Csyrk(matrixLayout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
            }

            public static void Zsyrk(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas trans, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr beta, System.IntPtr c,
                int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zsyrk(matrixLayout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Zsyrk(matrixLayout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
            }

            public static void Stbmv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, int k, float* a, int ldA, float* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Stbmv(matrixLayout, uplo, transA, diag, n, k, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Stbmv(matrixLayout, uplo, transA, diag, n, k, a, ldA, x, incX);
            }

            public static void Dtbmv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, int k, double* a, int ldA, double* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dtbmv(matrixLayout, uplo, transA, diag, n, k, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Dtbmv(matrixLayout, uplo, transA, diag, n, k, a, ldA, x, incX);
            }

            public static void Ctbmv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, int k, System.IntPtr a, int ldA, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ctbmv(matrixLayout, uplo, transA, diag, n, k, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ctbmv(matrixLayout, uplo, transA, diag, n, k, a, ldA, x, incX);
            }

            public static void Ztbmv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, int k, System.IntPtr a, int ldA, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ztbmv(matrixLayout, uplo, transA, diag, n, k, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ztbmv(matrixLayout, uplo, transA, diag, n, k, a, ldA, x, incX);
            }

            public static void Stbsv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, int k, float* a, int ldA, float* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Stbsv(matrixLayout, uplo, transA, diag, n, k, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Stbsv(matrixLayout, uplo, transA, diag, n, k, a, ldA, x, incX);
            }

            public static void Dtbsv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, int k, double* a, int ldA, double* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dtbsv(matrixLayout, uplo, transA, diag, n, k, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Dtbsv(matrixLayout, uplo, transA, diag, n, k, a, ldA, x, incX);
            }

            public static void Ctbsv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, int k, System.IntPtr a, int ldA, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ctbsv(matrixLayout, uplo, transA, diag, n, k, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ctbsv(matrixLayout, uplo, transA, diag, n, k, a, ldA, x, incX);
            }

            public static void Ztbsv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, int k, System.IntPtr a, int ldA, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ztbsv(matrixLayout, uplo, transA, diag, n, k, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ztbsv(matrixLayout, uplo, transA, diag, n, k, a, ldA, x, incX);
            }

            public static void Stpmv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, float* ap, float* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Stpmv(matrixLayout, uplo, transA, diag, n, ap, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Stpmv(matrixLayout, uplo, transA, diag, n, ap, x, incX);
            }

            public static void Dtpmv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, double* ap, double* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dtpmv(matrixLayout, uplo, transA, diag, n, ap, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Dtpmv(matrixLayout, uplo, transA, diag, n, ap, x, incX);
            }

            public static void Ctpmv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, System.IntPtr ap, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ctpmv(matrixLayout, uplo, transA, diag, n, ap, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ctpmv(matrixLayout, uplo, transA, diag, n, ap, x, incX);
            }

            public static void Ztpmv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, System.IntPtr ap, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ztpmv(matrixLayout, uplo, transA, diag, n, ap, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ztpmv(matrixLayout, uplo, transA, diag, n, ap, x, incX);
            }

            public static void Stpsv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, float* ap, float* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Stpsv(matrixLayout, uplo, transA, diag, n, ap, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Stpsv(matrixLayout, uplo, transA, diag, n, ap, x, incX);
            }

            public static void Dtpsv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, double* ap, double* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dtpsv(matrixLayout, uplo, transA, diag, n, ap, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Dtpsv(matrixLayout, uplo, transA, diag, n, ap, x, incX);
            }

            public static void Ctpsv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, System.IntPtr ap, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ctpsv(matrixLayout, uplo, transA, diag, n, ap, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ctpsv(matrixLayout, uplo, transA, diag, n, ap, x, incX);
            }

            public static void Ztpsv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, System.IntPtr ap, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ztpsv(matrixLayout, uplo, transA, diag, n, ap, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ztpsv(matrixLayout, uplo, transA, diag, n, ap, x, incX);
            }

            public static void Strmm(MatrixLayout matrixLayout, SIDE side, UpLoCblas uplo, TransCblas transA, DIAG diag, int m, int n, float alpha, float* a, int ldA, float* b, int ldB)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Strmm(matrixLayout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
                    return;
                }

                OpenBLAS.CBLAS.Strmm(matrixLayout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
            }

            public static void Dtrmm(MatrixLayout matrixLayout, SIDE side, UpLoCblas uplo, TransCblas transA, DIAG diag, int m, int n, double alpha, double* a, int ldA, double* b, int ldB)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dtrmm(matrixLayout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
                    return;
                }

                OpenBLAS.CBLAS.Dtrmm(matrixLayout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
            }

            public static void Ctrmm(MatrixLayout matrixLayout, SIDE side, UpLoCblas uplo, TransCblas transA, DIAG diag, int m, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b,
                int ldB)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ctrmm(matrixLayout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
                    return;
                }

                OpenBLAS.CBLAS.Ctrmm(matrixLayout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
            }

            public static void Ztrmm(MatrixLayout matrixLayout, SIDE side, UpLoCblas uplo, TransCblas transA, DIAG diag, int m, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b,
                int ldB)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ztrmm(matrixLayout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
                    return;
                }

                OpenBLAS.CBLAS.Ztrmm(matrixLayout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
            }

            public static void Strmv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, float* a, int ldA, float* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Strmv(matrixLayout, uplo, transA, diag, n, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Strmv(matrixLayout, uplo, transA, diag, n, a, ldA, x, incX);
            }

            public static void Dtrmv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, double* a, int ldA, double* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dtrmv(matrixLayout, uplo, transA, diag, n, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Dtrmv(matrixLayout, uplo, transA, diag, n, a, ldA, x, incX);
            }

            public static void Ctrmv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, System.IntPtr a, int ldA, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ctrmv(matrixLayout, uplo, transA, diag, n, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ctrmv(matrixLayout, uplo, transA, diag, n, a, ldA, x, incX);
            }

            public static void Ztrmv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, System.IntPtr a, int ldA, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ztrmv(matrixLayout, uplo, transA, diag, n, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ztrmv(matrixLayout, uplo, transA, diag, n, a, ldA, x, incX);
            }

            public static void Strsm(MatrixLayout matrixLayout, SIDE side, UpLoCblas uplo, TransCblas transA, DIAG diag, int m, int n, float alpha, float* a, int ldA, float* b, int ldB)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Strsm(matrixLayout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
                    return;
                }

                OpenBLAS.CBLAS.Strsm(matrixLayout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
            }

            public static void Dtrsm(MatrixLayout matrixLayout, SIDE side, UpLoCblas uplo, TransCblas transA, DIAG diag, int m, int n, double alpha, double* a, int ldA, double* b, int ldB)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dtrsm(matrixLayout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
                    return;
                }

                OpenBLAS.CBLAS.Dtrsm(matrixLayout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
            }

            public static void Ctrsm(MatrixLayout matrixLayout, SIDE side, UpLoCblas uplo, TransCblas transA, DIAG diag, int m, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b,
                int ldB)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ctrsm(matrixLayout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
                    return;
                }

                OpenBLAS.CBLAS.Ctrsm(matrixLayout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
            }

            public static void Ztrsm(MatrixLayout matrixLayout, SIDE side, UpLoCblas uplo, TransCblas transA, DIAG diag, int m, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b,
                int ldB)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ztrsm(matrixLayout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
                    return;
                }

                OpenBLAS.CBLAS.Ztrsm(matrixLayout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
            }

            public static void Strsv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, float* a, int ldA, float* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Strsv(matrixLayout, uplo, transA, diag, n, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Strsv(matrixLayout, uplo, transA, diag, n, a, ldA, x, incX);
            }

            public static void Dtrsv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, double* a, int ldA, double* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dtrsv(matrixLayout, uplo, transA, diag, n, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Dtrsv(matrixLayout, uplo, transA, diag, n, a, ldA, x, incX);
            }

            public static void Ctrsv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, System.IntPtr a, int ldA, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ctrsv(matrixLayout, uplo, transA, diag, n, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ctrsv(matrixLayout, uplo, transA, diag, n, a, ldA, x, incX);
            }

            public static void Ztrsv(MatrixLayout matrixLayout, UpLoCblas uplo, TransCblas transA, DIAG diag, int n, System.IntPtr a, int ldA, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ztrsv(matrixLayout, uplo, transA, diag, n, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ztrsv(matrixLayout, uplo, transA, diag, n, a, ldA, x, incX);
            }

            public static ulong Izamax(int n, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                    return MKL.CBLAS.Izamax(n, x, incX);

                return OpenBLAS.CBLAS.Izamax(n, x, incX);
            }

            public static ulong Izamin(int n, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                    return MKL.CBLAS.Izamin(n, x, incX);

                return OpenBLAS.CBLAS.Izamin(n, x, incX);
            }

            public static double Dzasum(int n, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                    return MKL.CBLAS.Dzasum(n, x, incX);

                return OpenBLAS.CBLAS.Dzasum(n, x, incX);
            }

            public static double Dznrm2(int n, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                    return MKL.CBLAS.Dznrm2(n, x, incX);

                return OpenBLAS.CBLAS.Dznrm2(n, x, incX);
            }
        }
    }
}