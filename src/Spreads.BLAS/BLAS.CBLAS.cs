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

            public static void Sgbmv(LAYOUT layout, TRANSPOSE transA, int m, int n, int kL, int kU, float alpha, float* a, int ldA, float* x, int incX, float beta, float* y,
                int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Sgbmv(layout, transA, m, n, kL, kU, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Sgbmv(layout, transA, m, n, kL, kU, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Dgbmv(LAYOUT layout, TRANSPOSE transA, int m, int n, int kL, int kU, double alpha, double* a, int ldA, double* x, int incX, double beta, double* y,
                int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dgbmv(layout, transA, m, n, kL, kU, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Dgbmv(layout, transA, m, n, kL, kU, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Cgbmv(LAYOUT layout, TRANSPOSE transA, int m, int n, int kL, int kU, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr x, int incX,
                System.IntPtr beta, System.IntPtr y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cgbmv(layout, transA, m, n, kL, kU, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Cgbmv(layout, transA, m, n, kL, kU, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Zgbmv(LAYOUT layout, TRANSPOSE transA, int m, int n, int kL, int kU, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr x, int incX,
                System.IntPtr beta, System.IntPtr y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zgbmv(layout, transA, m, n, kL, kU, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Zgbmv(layout, transA, m, n, kL, kU, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Sgemm(LAYOUT layout, TRANSPOSE transA, TRANSPOSE transB, int m, int n, int k, float alpha, float* a, int ldA, float* b, int ldB, float beta,
                float* c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Sgemm(layout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Sgemm(layout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Dgemm(LAYOUT layout, TRANSPOSE transA, TRANSPOSE transB, int m, int n, int k, double alpha, double* a, int ldA, double* b, int ldB, double beta,
                double* c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dgemm(layout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Dgemm(layout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Cgemm(LAYOUT layout, TRANSPOSE transA, TRANSPOSE transB, int m, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b,
                int ldB, System.IntPtr beta, System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cgemm(layout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Cgemm(layout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Zgemm(LAYOUT layout, TRANSPOSE transA, TRANSPOSE transB, int m, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b,
                int ldB, System.IntPtr beta, System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zgemm(layout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Zgemm(layout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Cgemm3m(LAYOUT layout, TRANSPOSE transA, TRANSPOSE transB, int m, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b,
                int ldB, System.IntPtr beta, System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cgemm3m(layout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Cgemm3m(layout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Zgemm3m(LAYOUT layout, TRANSPOSE transA, TRANSPOSE transB, int m, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b,
                int ldB, System.IntPtr beta, System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zgemm3m(layout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Zgemm3m(layout, transA, transB, m, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Sgemv(LAYOUT layout, TRANSPOSE transA, int m, int n, float alpha, float* a, int ldA, float* x, int incX, float beta, float* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Sgemv(layout, transA, m, n, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Sgemv(layout, transA, m, n, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Dgemv(LAYOUT layout, TRANSPOSE transA, int m, int n, double alpha, double* a, int ldA, double* x, int incX, double beta, double* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dgemv(layout, transA, m, n, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Dgemv(layout, transA, m, n, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Cgemv(LAYOUT layout, TRANSPOSE transA, int m, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr x, int incX, System.IntPtr beta,
                System.IntPtr y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cgemv(layout, transA, m, n, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Cgemv(layout, transA, m, n, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Zgemv(LAYOUT layout, TRANSPOSE transA, int m, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr x, int incX, System.IntPtr beta,
                System.IntPtr y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zgemv(layout, transA, m, n, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Zgemv(layout, transA, m, n, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Sger(LAYOUT layout, int m, int n, float alpha, float* x, int incX, float* y, int incY, float* a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Sger(layout, m, n, alpha, x, incX, y, incY, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Sger(layout, m, n, alpha, x, incX, y, incY, a, ldA);
            }

            public static void Dger(LAYOUT layout, int m, int n, double alpha, double* x, int incX, double* y, int incY, double* a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dger(layout, m, n, alpha, x, incX, y, incY, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Dger(layout, m, n, alpha, x, incX, y, incY, a, ldA);
            }

            public static void Cgerc(LAYOUT layout, int m, int n, System.IntPtr alpha, System.IntPtr x, int incX, System.IntPtr y, int incY, System.IntPtr a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cgerc(layout, m, n, alpha, x, incX, y, incY, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Cgerc(layout, m, n, alpha, x, incX, y, incY, a, ldA);
            }

            public static void Zgerc(LAYOUT layout, int m, int n, System.IntPtr alpha, System.IntPtr x, int incX, System.IntPtr y, int incY, System.IntPtr a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zgerc(layout, m, n, alpha, x, incX, y, incY, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Zgerc(layout, m, n, alpha, x, incX, y, incY, a, ldA);
            }

            public static void Cgeru(LAYOUT layout, int m, int n, System.IntPtr alpha, System.IntPtr x, int incX, System.IntPtr y, int incY, System.IntPtr a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cgeru(layout, m, n, alpha, x, incX, y, incY, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Cgeru(layout, m, n, alpha, x, incX, y, incY, a, ldA);
            }

            public static void Zgeru(LAYOUT layout, int m, int n, System.IntPtr alpha, System.IntPtr x, int incX, System.IntPtr y, int incY, System.IntPtr a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zgeru(layout, m, n, alpha, x, incX, y, incY, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Zgeru(layout, m, n, alpha, x, incX, y, incY, a, ldA);
            }

            public static void Chbmv(LAYOUT layout, UPLO uplo, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr x, int incX, System.IntPtr beta,
                System.IntPtr y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Chbmv(layout, uplo, n, k, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Chbmv(layout, uplo, n, k, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Zhbmv(LAYOUT layout, UPLO uplo, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr x, int incX, System.IntPtr beta,
                System.IntPtr y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zhbmv(layout, uplo, n, k, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Zhbmv(layout, uplo, n, k, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Chemm(LAYOUT layout, SIDE side, UPLO uplo, int m, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b, int ldB, System.IntPtr beta,
                System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Chemm(layout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Chemm(layout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Zhemm(LAYOUT layout, SIDE side, UPLO uplo, int m, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b, int ldB, System.IntPtr beta,
                System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zhemm(layout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Zhemm(layout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Chemv(LAYOUT layout, UPLO uplo, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr x, int incX, System.IntPtr beta, System.IntPtr y,
                int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Chemv(layout, uplo, n, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Chemv(layout, uplo, n, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Zhemv(LAYOUT layout, UPLO uplo, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr x, int incX, System.IntPtr beta, System.IntPtr y,
                int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zhemv(layout, uplo, n, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Zhemv(layout, uplo, n, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Cher(LAYOUT layout, UPLO uplo, int n, float alpha, System.IntPtr x, int incX, System.IntPtr a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cher(layout, uplo, n, alpha, x, incX, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Cher(layout, uplo, n, alpha, x, incX, a, ldA);
            }

            public static void Zher(LAYOUT layout, UPLO uplo, int n, double alpha, System.IntPtr x, int incX, System.IntPtr a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zher(layout, uplo, n, alpha, x, incX, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Zher(layout, uplo, n, alpha, x, incX, a, ldA);
            }

            public static void Cher2(LAYOUT layout, UPLO uplo, int n, System.IntPtr alpha, System.IntPtr x, int incX, System.IntPtr y, int incY, System.IntPtr a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cher2(layout, uplo, n, alpha, x, incX, y, incY, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Cher2(layout, uplo, n, alpha, x, incX, y, incY, a, ldA);
            }

            public static void Zher2(LAYOUT layout, UPLO uplo, int n, System.IntPtr alpha, System.IntPtr x, int incX, System.IntPtr y, int incY, System.IntPtr a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zher2(layout, uplo, n, alpha, x, incX, y, incY, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Zher2(layout, uplo, n, alpha, x, incX, y, incY, a, ldA);
            }

            public static void Cher2k(LAYOUT layout, UPLO uplo, TRANSPOSE trans, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b, int ldB, float beta,
                System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cher2k(layout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Cher2k(layout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Zher2k(LAYOUT layout, UPLO uplo, TRANSPOSE trans, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b, int ldB, double beta,
                System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zher2k(layout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Zher2k(layout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Cherk(LAYOUT layout, UPLO uplo, TRANSPOSE trans, int n, int k, float alpha, System.IntPtr a, int ldA, float beta, System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Cherk(layout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Cherk(layout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
            }

            public static void Zherk(LAYOUT layout, UPLO uplo, TRANSPOSE trans, int n, int k, double alpha, System.IntPtr a, int ldA, double beta, System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zherk(layout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Zherk(layout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
            }

            public static void Chpmv(LAYOUT layout, UPLO uplo, int n, System.IntPtr alpha, System.IntPtr ap, System.IntPtr x, int incX, System.IntPtr beta, System.IntPtr y,
                int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Chpmv(layout, uplo, n, alpha, ap, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Chpmv(layout, uplo, n, alpha, ap, x, incX, beta, y, incY);
            }

            public static void Zhpmv(LAYOUT layout, UPLO uplo, int n, System.IntPtr alpha, System.IntPtr ap, System.IntPtr x, int incX, System.IntPtr beta, System.IntPtr y,
                int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zhpmv(layout, uplo, n, alpha, ap, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Zhpmv(layout, uplo, n, alpha, ap, x, incX, beta, y, incY);
            }

            public static void Chpr(LAYOUT layout, UPLO uplo, int n, float alpha, System.IntPtr x, int incX, System.IntPtr a)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Chpr(layout, uplo, n, alpha, x, incX, a);
                    return;
                }

                OpenBLAS.CBLAS.Chpr(layout, uplo, n, alpha, x, incX, a);
            }

            public static void Zhpr(LAYOUT layout, UPLO uplo, int n, double alpha, System.IntPtr x, int incX, System.IntPtr a)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zhpr(layout, uplo, n, alpha, x, incX, a);
                    return;
                }

                OpenBLAS.CBLAS.Zhpr(layout, uplo, n, alpha, x, incX, a);
            }

            public static void Chpr2(LAYOUT layout, UPLO uplo, int n, System.IntPtr alpha, System.IntPtr x, int incX, System.IntPtr y, int incY, System.IntPtr ap)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Chpr2(layout, uplo, n, alpha, x, incX, y, incY, ap);
                    return;
                }

                OpenBLAS.CBLAS.Chpr2(layout, uplo, n, alpha, x, incX, y, incY, ap);
            }

            public static void Zhpr2(LAYOUT layout, UPLO uplo, int n, System.IntPtr alpha, System.IntPtr x, int incX, System.IntPtr y, int incY, System.IntPtr ap)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zhpr2(layout, uplo, n, alpha, x, incX, y, incY, ap);
                    return;
                }

                OpenBLAS.CBLAS.Zhpr2(layout, uplo, n, alpha, x, incX, y, incY, ap);
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

            public static void Ssbmv(LAYOUT layout, UPLO uplo, int n, int k, float alpha, float* a, int ldA, float* x, int incX, float beta, float* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ssbmv(layout, uplo, n, k, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Ssbmv(layout, uplo, n, k, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Dsbmv(LAYOUT layout, UPLO uplo, int n, int k, double alpha, double* a, int ldA, double* x, int incX, double beta, double* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dsbmv(layout, uplo, n, k, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Dsbmv(layout, uplo, n, k, alpha, a, ldA, x, incX, beta, y, incY);
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

            public static void Sspmv(LAYOUT layout, UPLO uplo, int n, float alpha, float* ap, float* x, int incX, float beta, float* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Sspmv(layout, uplo, n, alpha, ap, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Sspmv(layout, uplo, n, alpha, ap, x, incX, beta, y, incY);
            }

            public static void Dspmv(LAYOUT layout, UPLO uplo, int n, double alpha, double* ap, double* x, int incX, double beta, double* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dspmv(layout, uplo, n, alpha, ap, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Dspmv(layout, uplo, n, alpha, ap, x, incX, beta, y, incY);
            }

            public static void Sspr(LAYOUT layout, UPLO uplo, int n, float alpha, float* x, int incX, float* ap)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Sspr(layout, uplo, n, alpha, x, incX, ap);
                    return;
                }

                OpenBLAS.CBLAS.Sspr(layout, uplo, n, alpha, x, incX, ap);
            }

            public static void Dspr(LAYOUT layout, UPLO uplo, int n, double alpha, double* x, int incX, double* ap)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dspr(layout, uplo, n, alpha, x, incX, ap);
                    return;
                }

                OpenBLAS.CBLAS.Dspr(layout, uplo, n, alpha, x, incX, ap);
            }

            public static void Sspr2(LAYOUT layout, UPLO uplo, int n, float alpha, float* x, int incX, float* y, int incY, float* a)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Sspr2(layout, uplo, n, alpha, x, incX, y, incY, a);
                    return;
                }

                OpenBLAS.CBLAS.Sspr2(layout, uplo, n, alpha, x, incX, y, incY, a);
            }

            public static void Dspr2(LAYOUT layout, UPLO uplo, int n, double alpha, double* x, int incX, double* y, int incY, double* a)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dspr2(layout, uplo, n, alpha, x, incX, y, incY, a);
                    return;
                }

                OpenBLAS.CBLAS.Dspr2(layout, uplo, n, alpha, x, incX, y, incY, a);
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

            public static void Ssymm(LAYOUT layout, SIDE side, UPLO uplo, int m, int n, float alpha, float* a, int ldA, float* b, int ldB, float beta, float* c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ssymm(layout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Ssymm(layout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Dsymm(LAYOUT layout, SIDE side, UPLO uplo, int m, int n, double alpha, double* a, int ldA, double* b, int ldB, double beta, double* c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dsymm(layout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Dsymm(layout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Csymm(LAYOUT layout, SIDE side, UPLO uplo, int m, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b, int ldB, System.IntPtr beta,
                System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Csymm(layout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Csymm(layout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Zsymm(LAYOUT layout, SIDE side, UPLO uplo, int m, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b, int ldB, System.IntPtr beta,
                System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zsymm(layout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Zsymm(layout, side, uplo, m, n, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Ssymv(LAYOUT layout, UPLO uplo, int n, float alpha, float* a, int ldA, float* x, int incX, float beta, float* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ssymv(layout, uplo, n, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Ssymv(layout, uplo, n, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Dsymv(LAYOUT layout, UPLO uplo, int n, double alpha, double* a, int ldA, double* x, int incX, double beta, double* y, int incY)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dsymv(layout, uplo, n, alpha, a, ldA, x, incX, beta, y, incY);
                    return;
                }

                OpenBLAS.CBLAS.Dsymv(layout, uplo, n, alpha, a, ldA, x, incX, beta, y, incY);
            }

            public static void Ssyr(LAYOUT layout, UPLO uplo, int n, float alpha, float* x, int incX, float* a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ssyr(layout, uplo, n, alpha, x, incX, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Ssyr(layout, uplo, n, alpha, x, incX, a, ldA);
            }

            public static void Dsyr(LAYOUT layout, UPLO uplo, int n, double alpha, double* x, int incX, double* a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dsyr(layout, uplo, n, alpha, x, incX, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Dsyr(layout, uplo, n, alpha, x, incX, a, ldA);
            }

            public static void Ssyr2(LAYOUT layout, UPLO uplo, int n, float alpha, float* x, int incX, float* y, int incY, float* a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ssyr2(layout, uplo, n, alpha, x, incX, y, incY, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Ssyr2(layout, uplo, n, alpha, x, incX, y, incY, a, ldA);
            }

            public static void Dsyr2(LAYOUT layout, UPLO uplo, int n, double alpha, double* x, int incX, double* y, int incY, double* a, int ldA)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dsyr2(layout, uplo, n, alpha, x, incX, y, incY, a, ldA);
                    return;
                }

                OpenBLAS.CBLAS.Dsyr2(layout, uplo, n, alpha, x, incX, y, incY, a, ldA);
            }

            public static void Ssyr2k(LAYOUT layout, UPLO uplo, TRANSPOSE trans, int n, int k, float alpha, float* a, int ldA, float* b, int ldB, float beta, float* c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ssyr2k(layout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Ssyr2k(layout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Dsyr2k(LAYOUT layout, UPLO uplo, TRANSPOSE trans, int n, int k, double alpha, double* a, int ldA, double* b, int ldB, double beta, double* c,
                int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dsyr2k(layout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Dsyr2k(layout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Csyr2k(LAYOUT layout, UPLO uplo, TRANSPOSE trans, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b, int ldB,
                System.IntPtr beta, System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Csyr2k(layout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Csyr2k(layout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Zsyr2k(LAYOUT layout, UPLO uplo, TRANSPOSE trans, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b, int ldB,
                System.IntPtr beta, System.IntPtr c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zsyr2k(layout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Zsyr2k(layout, uplo, trans, n, k, alpha, a, ldA, b, ldB, beta, c, ldC);
            }

            public static void Ssyrk(LAYOUT layout, UPLO uplo, TRANSPOSE trans, int n, int k, float alpha, float* a, int ldA, float beta, float* c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ssyrk(layout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Ssyrk(layout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
            }

            public static void Dsyrk(LAYOUT layout, UPLO uplo, TRANSPOSE trans, int n, int k, double alpha, double* a, int ldA, double beta, double* c, int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dsyrk(layout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Dsyrk(layout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
            }

            public static void Csyrk(LAYOUT layout, UPLO uplo, TRANSPOSE trans, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr beta, System.IntPtr c,
                int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Csyrk(layout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Csyrk(layout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
            }

            public static void Zsyrk(LAYOUT layout, UPLO uplo, TRANSPOSE trans, int n, int k, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr beta, System.IntPtr c,
                int ldC)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Zsyrk(layout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
                    return;
                }

                OpenBLAS.CBLAS.Zsyrk(layout, uplo, trans, n, k, alpha, a, ldA, beta, c, ldC);
            }

            public static void Stbmv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, int k, float* a, int ldA, float* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Stbmv(layout, uplo, transA, diag, n, k, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Stbmv(layout, uplo, transA, diag, n, k, a, ldA, x, incX);
            }

            public static void Dtbmv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, int k, double* a, int ldA, double* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dtbmv(layout, uplo, transA, diag, n, k, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Dtbmv(layout, uplo, transA, diag, n, k, a, ldA, x, incX);
            }

            public static void Ctbmv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, int k, System.IntPtr a, int ldA, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ctbmv(layout, uplo, transA, diag, n, k, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ctbmv(layout, uplo, transA, diag, n, k, a, ldA, x, incX);
            }

            public static void Ztbmv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, int k, System.IntPtr a, int ldA, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ztbmv(layout, uplo, transA, diag, n, k, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ztbmv(layout, uplo, transA, diag, n, k, a, ldA, x, incX);
            }

            public static void Stbsv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, int k, float* a, int ldA, float* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Stbsv(layout, uplo, transA, diag, n, k, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Stbsv(layout, uplo, transA, diag, n, k, a, ldA, x, incX);
            }

            public static void Dtbsv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, int k, double* a, int ldA, double* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dtbsv(layout, uplo, transA, diag, n, k, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Dtbsv(layout, uplo, transA, diag, n, k, a, ldA, x, incX);
            }

            public static void Ctbsv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, int k, System.IntPtr a, int ldA, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ctbsv(layout, uplo, transA, diag, n, k, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ctbsv(layout, uplo, transA, diag, n, k, a, ldA, x, incX);
            }

            public static void Ztbsv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, int k, System.IntPtr a, int ldA, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ztbsv(layout, uplo, transA, diag, n, k, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ztbsv(layout, uplo, transA, diag, n, k, a, ldA, x, incX);
            }

            public static void Stpmv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, float* ap, float* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Stpmv(layout, uplo, transA, diag, n, ap, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Stpmv(layout, uplo, transA, diag, n, ap, x, incX);
            }

            public static void Dtpmv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, double* ap, double* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dtpmv(layout, uplo, transA, diag, n, ap, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Dtpmv(layout, uplo, transA, diag, n, ap, x, incX);
            }

            public static void Ctpmv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, System.IntPtr ap, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ctpmv(layout, uplo, transA, diag, n, ap, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ctpmv(layout, uplo, transA, diag, n, ap, x, incX);
            }

            public static void Ztpmv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, System.IntPtr ap, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ztpmv(layout, uplo, transA, diag, n, ap, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ztpmv(layout, uplo, transA, diag, n, ap, x, incX);
            }

            public static void Stpsv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, float* ap, float* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Stpsv(layout, uplo, transA, diag, n, ap, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Stpsv(layout, uplo, transA, diag, n, ap, x, incX);
            }

            public static void Dtpsv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, double* ap, double* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dtpsv(layout, uplo, transA, diag, n, ap, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Dtpsv(layout, uplo, transA, diag, n, ap, x, incX);
            }

            public static void Ctpsv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, System.IntPtr ap, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ctpsv(layout, uplo, transA, diag, n, ap, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ctpsv(layout, uplo, transA, diag, n, ap, x, incX);
            }

            public static void Ztpsv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, System.IntPtr ap, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ztpsv(layout, uplo, transA, diag, n, ap, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ztpsv(layout, uplo, transA, diag, n, ap, x, incX);
            }

            public static void Strmm(LAYOUT layout, SIDE side, UPLO uplo, TRANSPOSE transA, DIAG diag, int m, int n, float alpha, float* a, int ldA, float* b, int ldB)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Strmm(layout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
                    return;
                }

                OpenBLAS.CBLAS.Strmm(layout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
            }

            public static void Dtrmm(LAYOUT layout, SIDE side, UPLO uplo, TRANSPOSE transA, DIAG diag, int m, int n, double alpha, double* a, int ldA, double* b, int ldB)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dtrmm(layout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
                    return;
                }

                OpenBLAS.CBLAS.Dtrmm(layout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
            }

            public static void Ctrmm(LAYOUT layout, SIDE side, UPLO uplo, TRANSPOSE transA, DIAG diag, int m, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b,
                int ldB)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ctrmm(layout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
                    return;
                }

                OpenBLAS.CBLAS.Ctrmm(layout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
            }

            public static void Ztrmm(LAYOUT layout, SIDE side, UPLO uplo, TRANSPOSE transA, DIAG diag, int m, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b,
                int ldB)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ztrmm(layout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
                    return;
                }

                OpenBLAS.CBLAS.Ztrmm(layout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
            }

            public static void Strmv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, float* a, int ldA, float* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Strmv(layout, uplo, transA, diag, n, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Strmv(layout, uplo, transA, diag, n, a, ldA, x, incX);
            }

            public static void Dtrmv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, double* a, int ldA, double* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dtrmv(layout, uplo, transA, diag, n, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Dtrmv(layout, uplo, transA, diag, n, a, ldA, x, incX);
            }

            public static void Ctrmv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, System.IntPtr a, int ldA, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ctrmv(layout, uplo, transA, diag, n, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ctrmv(layout, uplo, transA, diag, n, a, ldA, x, incX);
            }

            public static void Ztrmv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, System.IntPtr a, int ldA, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ztrmv(layout, uplo, transA, diag, n, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ztrmv(layout, uplo, transA, diag, n, a, ldA, x, incX);
            }

            public static void Strsm(LAYOUT layout, SIDE side, UPLO uplo, TRANSPOSE transA, DIAG diag, int m, int n, float alpha, float* a, int ldA, float* b, int ldB)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Strsm(layout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
                    return;
                }

                OpenBLAS.CBLAS.Strsm(layout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
            }

            public static void Dtrsm(LAYOUT layout, SIDE side, UPLO uplo, TRANSPOSE transA, DIAG diag, int m, int n, double alpha, double* a, int ldA, double* b, int ldB)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dtrsm(layout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
                    return;
                }

                OpenBLAS.CBLAS.Dtrsm(layout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
            }

            public static void Ctrsm(LAYOUT layout, SIDE side, UPLO uplo, TRANSPOSE transA, DIAG diag, int m, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b,
                int ldB)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ctrsm(layout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
                    return;
                }

                OpenBLAS.CBLAS.Ctrsm(layout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
            }

            public static void Ztrsm(LAYOUT layout, SIDE side, UPLO uplo, TRANSPOSE transA, DIAG diag, int m, int n, System.IntPtr alpha, System.IntPtr a, int ldA, System.IntPtr b,
                int ldB)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ztrsm(layout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
                    return;
                }

                OpenBLAS.CBLAS.Ztrsm(layout, side, uplo, transA, diag, m, n, alpha, a, ldA, b, ldB);
            }

            public static void Strsv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, float* a, int ldA, float* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Strsv(layout, uplo, transA, diag, n, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Strsv(layout, uplo, transA, diag, n, a, ldA, x, incX);
            }

            public static void Dtrsv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, double* a, int ldA, double* x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Dtrsv(layout, uplo, transA, diag, n, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Dtrsv(layout, uplo, transA, diag, n, a, ldA, x, incX);
            }

            public static void Ctrsv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, System.IntPtr a, int ldA, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ctrsv(layout, uplo, transA, diag, n, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ctrsv(layout, uplo, transA, diag, n, a, ldA, x, incX);
            }

            public static void Ztrsv(LAYOUT layout, UPLO uplo, TRANSPOSE transA, DIAG diag, int n, System.IntPtr a, int ldA, System.IntPtr x, int incX)
            {
                if (MKL.IsSupoprted)
                {
                    MKL.CBLAS.Ztrsv(layout, uplo, transA, diag, n, a, ldA, x, incX);
                    return;
                }

                OpenBLAS.CBLAS.Ztrsv(layout, uplo, transA, diag, n, a, ldA, x, incX);
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