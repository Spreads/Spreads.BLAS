// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System.Runtime.InteropServices;
using System.Security;

// ReSharper disable InconsistentNaming

namespace Spreads.Native
{
    public static unsafe partial class OpenBLAS
    {
        public static class CBLAS
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sdsdot")]
            internal static extern float Sdsdot(int n, float alpha, float* x, int incx, float* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dsdot")]
            internal static extern double Dsdot(int n, float* x, int incx, float* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sdot")]
            internal static extern float Sdot(int n, float* x, int incx, float* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ddot")]
            internal static extern double Ddot(int n, double* x, int incx, double* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cdotu_sub")]
            internal static extern void CdotuSub(int n, System.IntPtr x, int incx, System.IntPtr y, int incy, System.IntPtr ret);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cdotc_sub")]
            internal static extern void CdotcSub(int n, System.IntPtr x, int incx, System.IntPtr y, int incy, System.IntPtr ret);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zdotu_sub")]
            internal static extern void ZdotuSub(int n, System.IntPtr x, int incx, System.IntPtr y, int incy, System.IntPtr ret);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zdotc_sub")]
            internal static extern void ZdotcSub(int n, System.IntPtr x, int incx, System.IntPtr y, int incy, System.IntPtr ret);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sasum")]
            internal static extern float Sasum(int n, float* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dasum")]
            internal static extern double Dasum(int n, double* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_scasum")]
            internal static extern float Scasum(int n, System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dzasum")]
            internal static extern double Dzasum(int n, System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ssum")]
            internal static extern float Ssum(int n, float* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dsum")]
            internal static extern double Dsum(int n, double* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_scsum")]
            internal static extern float Scsum(int n, System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dzsum")]
            internal static extern double Dzsum(int n, System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_snrm2")]
            internal static extern float Snrm2(int N, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dnrm2")]
            internal static extern double Dnrm2(int N, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_scnrm2")]
            internal static extern float Scnrm2(int N, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dznrm2")]
            internal static extern double Dznrm2(int N, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_isamax")]
            internal static extern ulong Isamax(int n, float* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_idamax")]
            internal static extern ulong Idamax(int n, double* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_icamax")]
            internal static extern ulong Icamax(int n, System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_izamax")]
            internal static extern ulong Izamax(int n, System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_isamin")]
            internal static extern ulong Isamin(int n, float* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_idamin")]
            internal static extern ulong Idamin(int n, double* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_icamin")]
            internal static extern ulong Icamin(int n, System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_izamin")]
            internal static extern ulong Izamin(int n, System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ismax")]
            internal static extern ulong Ismax(int n, float* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_idmax")]
            internal static extern ulong Idmax(int n, double* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_icmax")]
            internal static extern ulong Icmax(int n, System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_izmax")]
            internal static extern ulong Izmax(int n, System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ismin")]
            internal static extern ulong Ismin(int n, float* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_idmin")]
            internal static extern ulong Idmin(int n, double* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_icmin")]
            internal static extern ulong Icmin(int n, System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_izmin")]
            internal static extern ulong Izmin(int n, System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_saxpy")]
            internal static extern void Saxpy(int n, float alpha, float* x, int incx, float* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_daxpy")]
            internal static extern void Daxpy(int n, double alpha, double* x, int incx, double* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_caxpy")]
            internal static extern void Caxpy(int n, System.IntPtr alpha, System.IntPtr x, int incx, System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zaxpy")]
            internal static extern void Zaxpy(int n, System.IntPtr alpha, System.IntPtr x, int incx, System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_scopy")]
            internal static extern void Scopy(int n, float* x, int incx, float* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dcopy")]
            internal static extern void Dcopy(int n, double* x, int incx, double* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ccopy")]
            internal static extern void Ccopy(int n, System.IntPtr x, int incx, System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zcopy")]
            internal static extern void Zcopy(int n, System.IntPtr x, int incx, System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sswap")]
            internal static extern void Sswap(int n, float* x, int incx, float* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dswap")]
            internal static extern void Dswap(int n, double* x, int incx, double* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cswap")]
            internal static extern void Cswap(int n, System.IntPtr x, int incx, System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zswap")]
            internal static extern void Zswap(int n, System.IntPtr x, int incx, System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_srot")]
            internal static extern void Srot(int N, float* X, int incX, float* Y, int incY, float c, float s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_drot")]
            internal static extern void Drot(int N, double* X, int incX, double* Y, int incY, double c, double s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_srotg")]
            internal static extern void Srotg(float* a, float* b, float* c, float* s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_drotg")]
            internal static extern void Drotg(double* a, double* b, double* c, double* s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_srotm")]
            internal static extern void Srotm(int N, float* X, int incX, float* Y, int incY, float* P);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_drotm")]
            internal static extern void Drotm(int N, double* X, int incX, double* Y, int incY, double* P);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_srotmg")]
            internal static extern void Srotmg(float* d1, float* d2, float* b1, float b2, float* P);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_drotmg")]
            internal static extern void Drotmg(double* d1, double* d2, double* b1, double b2, double* P);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sscal")]
            internal static extern void Sscal(int N, float alpha, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dscal")]
            internal static extern void Dscal(int N, double alpha, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cscal")]
            internal static extern void Cscal(int N, System.IntPtr alpha, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zscal")]
            internal static extern void Zscal(int N, System.IntPtr alpha, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_csscal")]
            internal static extern void Csscal(int N, float alpha, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zdscal")]
            internal static extern void Zdscal(int N, double alpha, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sgemv")]
            internal static extern void Sgemv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE trans, int m, int n, float alpha, float* a, int lda, float* x, int incx, float beta, float* y,
                int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dgemv")]
            internal static extern void Dgemv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE trans, int m, int n, double alpha, double* a, int lda, double* x, int incx, double beta, double* y,
                int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cgemv")]
            internal static extern void Cgemv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE trans, int m, int n, System.IntPtr alpha, System.IntPtr a, int lda, System.IntPtr x, int incx,
                System.IntPtr beta, System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zgemv")]
            internal static extern void Zgemv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE trans, int m, int n, System.IntPtr alpha, System.IntPtr a, int lda, System.IntPtr x, int incx,
                System.IntPtr beta, System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sger")]
            internal static extern void Sger(BLAS.LAYOUT Layout, int M, int N, float alpha, float* X, int incX, float* Y, int incY, float* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dger")]
            internal static extern void Dger(BLAS.LAYOUT Layout, int M, int N, double alpha, double* X, int incX, double* Y, int incY, double* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cgeru")]
            internal static extern void Cgeru(BLAS.LAYOUT Layout, int M, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr A,
                int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cgerc")]
            internal static extern void Cgerc(BLAS.LAYOUT Layout, int M, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr A,
                int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zgeru")]
            internal static extern void Zgeru(BLAS.LAYOUT Layout, int M, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr A,
                int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zgerc")]
            internal static extern void Zgerc(BLAS.LAYOUT Layout, int M, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr A,
                int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_strsv")]
            internal static extern void Strsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dtrsv")]
            internal static extern void Dtrsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ctrsv")]
            internal static extern void Ctrsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr A, int lda, System.IntPtr X,
                int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ztrsv")]
            internal static extern void Ztrsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr A, int lda, System.IntPtr X,
                int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_strmv")]
            internal static extern void Strmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dtrmv")]
            internal static extern void Dtrmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ctrmv")]
            internal static extern void Ctrmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr A, int lda, System.IntPtr X,
                int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ztrmv")]
            internal static extern void Ztrmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr A, int lda, System.IntPtr X,
                int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ssyr")]
            internal static extern void Ssyr(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, float* X, int incX, float* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dsyr")]
            internal static extern void Dsyr(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, double* X, int incX, double* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cher")]
            internal static extern void Cher(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, System.IntPtr X, int incX, System.IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zher")]
            internal static extern void Zher(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, System.IntPtr X, int incX, System.IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ssyr2")]
            internal static extern void Ssyr2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, float* X, int incX, float* Y, int incY, float* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dsyr2")]
            internal static extern void Dsyr2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, double* X, int incX, double* Y, int incY, double* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cher2")]
            internal static extern void Cher2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr A,
                int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zher2")]
            internal static extern void Zher2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr A,
                int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sgbmv")]
            internal static extern void Sgbmv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, int M, int N, int KL, int KU, float alpha, float* A, int lda, float* X, int incX,
                float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dgbmv")]
            internal static extern void Dgbmv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, int M, int N, int KL, int KU, double alpha, double* A, int lda, double* X, int incX,
                double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cgbmv")]
            internal static extern void Cgbmv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, int M, int N, int KL, int KU, System.IntPtr alpha, System.IntPtr A, int lda,
                System.IntPtr X, int incX, System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zgbmv")]
            internal static extern void Zgbmv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, int M, int N, int KL, int KU, System.IntPtr alpha, System.IntPtr A, int lda,
                System.IntPtr X, int incX, System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ssbmv")]
            internal static extern void Ssbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, int K, float alpha, float* A, int lda, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dsbmv")]
            internal static extern void Dsbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, int K, double alpha, double* A, int lda, double* X, int incX, double beta, double* Y,
                int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_stbmv")]
            internal static extern void Stbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dtbmv")]
            internal static extern void Dtbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ctbmv")]
            internal static extern void Ctbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, System.IntPtr A, int lda, System.IntPtr X,
                int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ztbmv")]
            internal static extern void Ztbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, System.IntPtr A, int lda, System.IntPtr X,
                int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_stbsv")]
            internal static extern void Stbsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dtbsv")]
            internal static extern void Dtbsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ctbsv")]
            internal static extern void Ctbsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, System.IntPtr A, int lda, System.IntPtr X,
                int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ztbsv")]
            internal static extern void Ztbsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, System.IntPtr A, int lda, System.IntPtr X,
                int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_stpmv")]
            internal static extern void Stpmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, float* Ap, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dtpmv")]
            internal static extern void Dtpmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, double* Ap, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ctpmv")]
            internal static extern void Ctpmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr Ap, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ztpmv")]
            internal static extern void Ztpmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr Ap, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_stpsv")]
            internal static extern void Stpsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, float* Ap, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dtpsv")]
            internal static extern void Dtpsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, double* Ap, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ctpsv")]
            internal static extern void Ctpsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr Ap, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ztpsv")]
            internal static extern void Ztpsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr Ap, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ssymv")]
            internal static extern void Ssymv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, float* A, int lda, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dsymv")]
            internal static extern void Dsymv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, double* A, int lda, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_chemv")]
            internal static extern void Chemv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr X, int incX,
                System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zhemv")]
            internal static extern void Zhemv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr X, int incX,
                System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sspmv")]
            internal static extern void Sspmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, float* Ap, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dspmv")]
            internal static extern void Dspmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, double* Ap, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sspr")]
            internal static extern void Sspr(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, float* X, int incX, float* Ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dspr")]
            internal static extern void Dspr(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, double* X, int incX, double* Ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_chpr")]
            internal static extern void Chpr(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, System.IntPtr X, int incX, System.IntPtr A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zhpr")]
            internal static extern void Zhpr(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, System.IntPtr X, int incX, System.IntPtr A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sspr2")]
            internal static extern void Sspr2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, float* X, int incX, float* Y, int incY, float* A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dspr2")]
            internal static extern void Dspr2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, double* X, int incX, double* Y, int incY, double* A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_chpr2")]
            internal static extern void Chpr2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY,
                System.IntPtr Ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zhpr2")]
            internal static extern void Zhpr2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY,
                System.IntPtr Ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_chbmv")]
            internal static extern void Chbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr X, int incX,
                System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zhbmv")]
            internal static extern void Zhbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr X, int incX,
                System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_chpmv")]
            internal static extern void Chpmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr Ap, System.IntPtr X, int incX, System.IntPtr beta,
                System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zhpmv")]
            internal static extern void Zhpmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr Ap, System.IntPtr X, int incX, System.IntPtr beta,
                System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sgemm")]
            internal static extern void Sgemm(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int M, int N, int K, float alpha, float* A, int lda, float* B,
                int ldb, float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dgemm")]
            internal static extern void Dgemm(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int M, int N, int K, double alpha, double* A, int lda, double* B,
                int ldb, double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cgemm")]
            internal static extern void Cgemm(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int M, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda,
                System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cgemm3m")]
            internal static extern void Cgemm3m(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int M, int N, int K, System.IntPtr alpha, System.IntPtr A,
                int lda, System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zgemm")]
            internal static extern void Zgemm(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int M, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda,
                System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zgemm3m")]
            internal static extern void Zgemm3m(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int M, int N, int K, System.IntPtr alpha, System.IntPtr A,
                int lda, System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ssymm")]
            internal static extern void Ssymm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, int M, int N, float alpha, float* A, int lda, float* B, int ldb, float beta,
                float* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dsymm")]
            internal static extern void Dsymm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, int M, int N, double alpha, double* A, int lda, double* B, int ldb, double beta,
                double* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_csymm")]
            internal static extern void Csymm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, int M, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B,
                int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zsymm")]
            internal static extern void Zsymm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, int M, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B,
                int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ssyrk")]
            internal static extern void Ssyrk(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, float alpha, float* A, int lda, float beta, float* C,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dsyrk")]
            internal static extern void Dsyrk(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, double alpha, double* A, int lda, double beta, double* C,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_csyrk")]
            internal static extern void Csyrk(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda,
                System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zsyrk")]
            internal static extern void Zsyrk(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda,
                System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ssyr2k")]
            internal static extern void Ssyr2k(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, float alpha, float* A, int lda, float* B, int ldb,
                float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dsyr2k")]
            internal static extern void Dsyr2k(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, double alpha, double* A, int lda, double* B, int ldb,
                double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_csyr2k")]
            internal static extern void Csyr2k(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda,
                System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zsyr2k")]
            internal static extern void Zsyr2k(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda,
                System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_strmm")]
            internal static extern void Strmm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, float alpha, float* A,
                int lda, float* B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dtrmm")]
            internal static extern void Dtrmm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, double alpha, double* A,
                int lda, double* B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ctrmm")]
            internal static extern void Ctrmm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, System.IntPtr alpha,
                System.IntPtr A, int lda, System.IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ztrmm")]
            internal static extern void Ztrmm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, System.IntPtr alpha,
                System.IntPtr A, int lda, System.IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_strsm")]
            internal static extern void Strsm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, float alpha, float* A,
                int lda, float* B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dtrsm")]
            internal static extern void Dtrsm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, double alpha, double* A,
                int lda, double* B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ctrsm")]
            internal static extern void Ctrsm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, System.IntPtr alpha,
                System.IntPtr A, int lda, System.IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ztrsm")]
            internal static extern void Ztrsm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, System.IntPtr alpha,
                System.IntPtr A, int lda, System.IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_chemm")]
            internal static extern void Chemm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, int M, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B,
                int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zhemm")]
            internal static extern void Zhemm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, int M, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B,
                int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cherk")]
            internal static extern void Cherk(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, float alpha, System.IntPtr A, int lda, float beta,
                System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zherk")]
            internal static extern void Zherk(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, double alpha, System.IntPtr A, int lda, double beta,
                System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cher2k")]
            internal static extern void Cher2k(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda,
                System.IntPtr B, int ldb, float beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zher2k")]
            internal static extern void Zher2k(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda,
                System.IntPtr B, int ldb, double beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_xerbla")]
            internal static extern void Xerbla(int p, sbyte* rout, sbyte* form);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_saxpby")]
            internal static extern void Saxpby(int n, float alpha, float* x, int incx, float beta, float* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_daxpby")]
            internal static extern void Daxpby(int n, double alpha, double* x, int incx, double beta, double* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_caxpby")]
            internal static extern void Caxpby(int n, System.IntPtr alpha, System.IntPtr x, int incx, System.IntPtr beta, System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zaxpby")]
            internal static extern void Zaxpby(int n, System.IntPtr alpha, System.IntPtr x, int incx, System.IntPtr beta, System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_somatcopy")]
            internal static extern void Somatcopy(BLAS.LAYOUT Layout, BLAS.TRANSPOSE Trans, int crows, int ccols, float calpha, float* a, int clda, float* b, int cldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_domatcopy")]
            internal static extern void Domatcopy(BLAS.LAYOUT Layout, BLAS.TRANSPOSE Trans, int crows, int ccols, double calpha, double* a, int clda, double* b, int cldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_comatcopy")]
            internal static extern void Comatcopy(BLAS.LAYOUT Layout, BLAS.TRANSPOSE Trans, int crows, int ccols, float* calpha, float* a, int clda, float* b, int cldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zomatcopy")]
            internal static extern void Zomatcopy(BLAS.LAYOUT Layout, BLAS.TRANSPOSE Trans, int crows, int ccols, double* calpha, double* a, int clda, double* b, int cldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_simatcopy")]
            internal static extern void Simatcopy(BLAS.LAYOUT Layout, BLAS.TRANSPOSE Trans, int crows, int ccols, float calpha, float* a, int clda, int cldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dimatcopy")]
            internal static extern void Dimatcopy(BLAS.LAYOUT Layout, BLAS.TRANSPOSE Trans, int crows, int ccols, double calpha, double* a, int clda, int cldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cimatcopy")]
            internal static extern void Cimatcopy(BLAS.LAYOUT Layout, BLAS.TRANSPOSE Trans, int crows, int ccols, float* calpha, float* a, int clda, int cldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zimatcopy")]
            internal static extern void Zimatcopy(BLAS.LAYOUT Layout, BLAS.TRANSPOSE Trans, int crows, int ccols, double* calpha, double* a, int clda, int cldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sgeadd")]
            internal static extern void Sgeadd(BLAS.LAYOUT Layout, int crows, int ccols, float calpha, float* a, int clda, float cbeta, float* c, int cldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dgeadd")]
            internal static extern void Dgeadd(BLAS.LAYOUT Layout, int crows, int ccols, double calpha, double* a, int clda, double cbeta, double* c, int cldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cgeadd")]
            internal static extern void Cgeadd(BLAS.LAYOUT Layout, int crows, int ccols, float* calpha, float* a, int clda, float* cbeta, float* c, int cldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zgeadd")]
            internal static extern void Zgeadd(BLAS.LAYOUT Layout, int crows, int ccols, double* calpha, double* a, int clda, double* cbeta, double* c, int cldc);
        }
    }
}