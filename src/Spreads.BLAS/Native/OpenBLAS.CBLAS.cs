// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System;
using System.Runtime.InteropServices;
using System.Security;

// ReSharper disable InconsistentNaming

namespace Spreads.Native
{
    public static unsafe partial class OpenBLAS
    {
        public static class CBLAS
        {
            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_sdsdot")]
            public static extern float Sdsdot(int n, float alpha, float* x, int incx, float* y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dsdot")]
            public static extern double Dsdot(int n, float* x, int incx, float* y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_sdot")]
            public static extern float Sdot(int n, float* x, int incx, float* y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ddot")]
            public static extern double Ddot(int n, double* x, int incx, double* y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cdotu_sub")]
            public static extern void CdotuSub(int n, IntPtr x, int incx, IntPtr y, int incy, IntPtr ret);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cdotc_sub")]
            public static extern void CdotcSub(int n, IntPtr x, int incx, IntPtr y, int incy, IntPtr ret);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zdotu_sub")]
            public static extern void ZdotuSub(int n, IntPtr x, int incx, IntPtr y, int incy, IntPtr ret);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zdotc_sub")]
            public static extern void ZdotcSub(int n, IntPtr x, int incx, IntPtr y, int incy, IntPtr ret);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_sasum")]
            public static extern float Sasum(int n, float* x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dasum")]
            public static extern double Dasum(int n, double* x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_scasum")]
            public static extern float Scasum(int n, IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dzasum")]
            public static extern double Dzasum(int n, IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ssum")]
            public static extern float Ssum(int n, float* x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dsum")]
            public static extern double Dsum(int n, double* x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_scsum")]
            public static extern float Scsum(int n, IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dzsum")]
            public static extern double Dzsum(int n, IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_snrm2")]
            public static extern float Snrm2(int N, float* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dnrm2")]
            public static extern double Dnrm2(int N, double* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_scnrm2")]
            public static extern float Scnrm2(int N, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dznrm2")]
            public static extern double Dznrm2(int N, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_isamax")]
            public static extern ulong Isamax(int n, float* x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_idamax")]
            public static extern ulong Idamax(int n, double* x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_icamax")]
            public static extern ulong Icamax(int n, IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_izamax")]
            public static extern ulong Izamax(int n, IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_isamin")]
            public static extern ulong Isamin(int n, float* x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_idamin")]
            public static extern ulong Idamin(int n, double* x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_icamin")]
            public static extern ulong Icamin(int n, IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_izamin")]
            public static extern ulong Izamin(int n, IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ismax")]
            public static extern ulong Ismax(int n, float* x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_idmax")]
            public static extern ulong Idmax(int n, double* x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_icmax")]
            public static extern ulong Icmax(int n, IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_izmax")]
            public static extern ulong Izmax(int n, IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ismin")]
            public static extern ulong Ismin(int n, float* x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_idmin")]
            public static extern ulong Idmin(int n, double* x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_icmin")]
            public static extern ulong Icmin(int n, IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_izmin")]
            public static extern ulong Izmin(int n, IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_saxpy")]
            public static extern void Saxpy(int n, float alpha, float* x, int incx, float* y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_daxpy")]
            public static extern void Daxpy(int n, double alpha, double* x, int incx, double* y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_caxpy")]
            public static extern void Caxpy(int n, IntPtr alpha, IntPtr x, int incx, IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zaxpy")]
            public static extern void Zaxpy(int n, IntPtr alpha, IntPtr x, int incx, IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_scopy")]
            public static extern void Scopy(int n, float* x, int incx, float* y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dcopy")]
            public static extern void Dcopy(int n, double* x, int incx, double* y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ccopy")]
            public static extern void Ccopy(int n, IntPtr x, int incx, IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zcopy")]
            public static extern void Zcopy(int n, IntPtr x, int incx, IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_sswap")]
            public static extern void Sswap(int n, float* x, int incx, float* y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dswap")]
            public static extern void Dswap(int n, double* x, int incx, double* y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cswap")]
            public static extern void Cswap(int n, IntPtr x, int incx, IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zswap")]
            public static extern void Zswap(int n, IntPtr x, int incx, IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_srot")]
            public static extern void Srot(int N, float* X, int incX, float* Y, int incY, float c, float s);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_drot")]
            public static extern void Drot(int N, double* X, int incX, double* Y, int incY, double c, double s);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_srotg")]
            public static extern void Srotg(float* a, float* b, float* c, float* s);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_drotg")]
            public static extern void Drotg(double* a, double* b, double* c, double* s);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_srotm")]
            public static extern void Srotm(int N, float* X, int incX, float* Y, int incY, float* P);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_drotm")]
            public static extern void Drotm(int N, double* X, int incX, double* Y, int incY, double* P);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_srotmg")]
            public static extern void Srotmg(float* d1, float* d2, float* b1, float b2, float* P);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_drotmg")]
            public static extern void Drotmg(double* d1, double* d2, double* b1, double b2, double* P);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_sscal")]
            public static extern void Sscal(int N, float alpha, float* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dscal")]
            public static extern void Dscal(int N, double alpha, double* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cscal")]
            public static extern void Cscal(int N, IntPtr alpha, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zscal")]
            public static extern void Zscal(int N, IntPtr alpha, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_csscal")]
            public static extern void Csscal(int N, float alpha, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zdscal")]
            public static extern void Zdscal(int N, double alpha, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_sgemv")]
            public static extern void Sgemv(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas trans, int m, int n, float alpha, float* a, int lda, float* x, int incx, float beta, float* y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dgemv")]
            public static extern void Dgemv(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas trans, int m, int n, double alpha, double* a, int lda, double* x, int incx, double beta, double* y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cgemv")]
            public static extern void Cgemv(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas trans, int m, int n, IntPtr alpha, IntPtr a, int lda, IntPtr x, int incx, IntPtr beta, IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zgemv")]
            public static extern void Zgemv(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas trans, int m, int n, IntPtr alpha, IntPtr a, int lda, IntPtr x, int incx, IntPtr beta, IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_sger")]
            public static extern void Sger(BLAS.MatrixLayout matrixLayout, int M, int N, float alpha, float* X, int incX, float* Y, int incY, float* A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dger")]
            public static extern void Dger(BLAS.MatrixLayout matrixLayout, int M, int N, double alpha, double* X, int incX, double* Y, int incY, double* A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cgeru")]
            public static extern void Cgeru(BLAS.MatrixLayout matrixLayout, int M, int N, IntPtr alpha, IntPtr X, int incX, IntPtr Y, int incY, IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cgerc")]
            public static extern void Cgerc(BLAS.MatrixLayout matrixLayout, int M, int N, IntPtr alpha, IntPtr X, int incX, IntPtr Y, int incY, IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zgeru")]
            public static extern void Zgeru(BLAS.MatrixLayout matrixLayout, int M, int N, IntPtr alpha, IntPtr X, int incX, IntPtr Y, int incY, IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zgerc")]
            public static extern void Zgerc(BLAS.MatrixLayout matrixLayout, int M, int N, IntPtr alpha, IntPtr X, int incX, IntPtr Y, int incY, IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_strsv")]
            public static extern void Strsv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dtrsv")]
            public static extern void Dtrsv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ctrsv")]
            public static extern void Ctrsv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, IntPtr A, int lda, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ztrsv")]
            public static extern void Ztrsv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, IntPtr A, int lda, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_strmv")]
            public static extern void Strmv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dtrmv")]
            public static extern void Dtrmv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ctrmv")]
            public static extern void Ctrmv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, IntPtr A, int lda, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ztrmv")]
            public static extern void Ztrmv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, IntPtr A, int lda, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ssyr")]
            public static extern void Ssyr(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, float alpha, float* X, int incX, float* A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dsyr")]
            public static extern void Dsyr(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, double alpha, double* X, int incX, double* A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cher")]
            public static extern void Cher(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, float alpha, IntPtr X, int incX, IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zher")]
            public static extern void Zher(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, double alpha, IntPtr X, int incX, IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ssyr2")]
            public static extern void Ssyr2(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, float alpha, float* X, int incX, float* Y, int incY, float* A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dsyr2")]
            public static extern void Dsyr2(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, double alpha, double* X, int incX, double* Y, int incY, double* A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cher2")]
            public static extern void Cher2(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, IntPtr alpha, IntPtr X, int incX, IntPtr Y, int incY, IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zher2")]
            public static extern void Zher2(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, IntPtr alpha, IntPtr X, int incX, IntPtr Y, int incY, IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_sgbmv")]
            public static extern void Sgbmv(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas TransA, int M, int N, int KL, int KU, float alpha, float* A, int lda, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dgbmv")]
            public static extern void Dgbmv(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas TransA, int M, int N, int KL, int KU, double alpha, double* A, int lda, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cgbmv")]
            public static extern void Cgbmv(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas TransA, int M, int N, int KL, int KU, IntPtr alpha, IntPtr A, int lda, IntPtr X, int incX, IntPtr beta, IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zgbmv")]
            public static extern void Zgbmv(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas TransA, int M, int N, int KL, int KU, IntPtr alpha, IntPtr A, int lda, IntPtr X, int incX, IntPtr beta, IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ssbmv")]
            public static extern void Ssbmv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, int K, float alpha, float* A, int lda, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dsbmv")]
            public static extern void Dsbmv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, int K, double alpha, double* A, int lda, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_stbmv")]
            public static extern void Stbmv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, int K, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dtbmv")]
            public static extern void Dtbmv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, int K, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ctbmv")]
            public static extern void Ctbmv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, int K, IntPtr A, int lda, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ztbmv")]
            public static extern void Ztbmv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, int K, IntPtr A, int lda, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_stbsv")]
            public static extern void Stbsv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, int K, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dtbsv")]
            public static extern void Dtbsv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, int K, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ctbsv")]
            public static extern void Ctbsv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, int K, IntPtr A, int lda, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ztbsv")]
            public static extern void Ztbsv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, int K, IntPtr A, int lda, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_stpmv")]
            public static extern void Stpmv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, float* Ap, float* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dtpmv")]
            public static extern void Dtpmv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, double* Ap, double* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ctpmv")]
            public static extern void Ctpmv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, IntPtr Ap, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ztpmv")]
            public static extern void Ztpmv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, IntPtr Ap, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_stpsv")]
            public static extern void Stpsv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, float* Ap, float* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dtpsv")]
            public static extern void Dtpsv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, double* Ap, double* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ctpsv")]
            public static extern void Ctpsv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, IntPtr Ap, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ztpsv")]
            public static extern void Ztpsv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int N, IntPtr Ap, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ssymv")]
            public static extern void Ssymv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, float alpha, float* A, int lda, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dsymv")]
            public static extern void Dsymv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, double alpha, double* A, int lda, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_chemv")]
            public static extern void Chemv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, IntPtr alpha, IntPtr A, int lda, IntPtr X, int incX, IntPtr beta, IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zhemv")]
            public static extern void Zhemv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, IntPtr alpha, IntPtr A, int lda, IntPtr X, int incX, IntPtr beta, IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_sspmv")]
            public static extern void Sspmv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, float alpha, float* Ap, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dspmv")]
            public static extern void Dspmv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, double alpha, double* Ap, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_sspr")]
            public static extern void Sspr(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, float alpha, float* X, int incX, float* Ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dspr")]
            public static extern void Dspr(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, double alpha, double* X, int incX, double* Ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_chpr")]
            public static extern void Chpr(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, float alpha, IntPtr X, int incX, IntPtr A);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zhpr")]
            public static extern void Zhpr(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, double alpha, IntPtr X, int incX, IntPtr A);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_sspr2")]
            public static extern void Sspr2(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, float alpha, float* X, int incX, float* Y, int incY, float* A);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dspr2")]
            public static extern void Dspr2(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, double alpha, double* X, int incX, double* Y, int incY, double* A);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_chpr2")]
            public static extern void Chpr2(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, IntPtr alpha, IntPtr X, int incX, IntPtr Y, int incY, IntPtr Ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zhpr2")]
            public static extern void Zhpr2(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, IntPtr alpha, IntPtr X, int incX, IntPtr Y, int incY, IntPtr Ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_chbmv")]
            public static extern void Chbmv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr X, int incX, IntPtr beta, IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zhbmv")]
            public static extern void Zhbmv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr X, int incX, IntPtr beta, IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_chpmv")]
            public static extern void Chpmv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, IntPtr alpha, IntPtr Ap, IntPtr X, int incX, IntPtr beta, IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zhpmv")]
            public static extern void Zhpmv(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, int N, IntPtr alpha, IntPtr Ap, IntPtr X, int incX, IntPtr beta, IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_sgemm")]
            public static extern void Sgemm(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas TransA, BLAS.TransCblas TransB, int M, int N, int K, float alpha, float* A, int lda, float* B, int ldb, float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dgemm")]
            public static extern void Dgemm(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas TransA, BLAS.TransCblas TransB, int M, int N, int K, double alpha, double* A, int lda, double* B, int ldb, double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cgemm")]
            public static extern void Cgemm(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas TransA, BLAS.TransCblas TransB, int M, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cgemm3m")]
            public static extern void Cgemm3m(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas TransA, BLAS.TransCblas TransB, int M, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zgemm")]
            public static extern void Zgemm(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas TransA, BLAS.TransCblas TransB, int M, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zgemm3m")]
            public static extern void Zgemm3m(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas TransA, BLAS.TransCblas TransB, int M, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ssymm")]
            public static extern void Ssymm(BLAS.MatrixLayout matrixLayout, BLAS.SIDE Side, BLAS.UpLoCblas Uplo, int M, int N, float alpha, float* A, int lda, float* B, int ldb, float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dsymm")]
            public static extern void Dsymm(BLAS.MatrixLayout matrixLayout, BLAS.SIDE Side, BLAS.UpLoCblas Uplo, int M, int N, double alpha, double* A, int lda, double* B, int ldb, double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_csymm")]
            public static extern void Csymm(BLAS.MatrixLayout matrixLayout, BLAS.SIDE Side, BLAS.UpLoCblas Uplo, int M, int N, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zsymm")]
            public static extern void Zsymm(BLAS.MatrixLayout matrixLayout, BLAS.SIDE Side, BLAS.UpLoCblas Uplo, int M, int N, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ssyrk")]
            public static extern void Ssyrk(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas Trans, int N, int K, float alpha, float* A, int lda, float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dsyrk")]
            public static extern void Dsyrk(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas Trans, int N, int K, double alpha, double* A, int lda, double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_csyrk")]
            public static extern void Csyrk(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas Trans, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zsyrk")]
            public static extern void Zsyrk(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas Trans, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ssyr2k")]
            public static extern void Ssyr2k(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas Trans, int N, int K, float alpha, float* A, int lda, float* B, int ldb, float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dsyr2k")]
            public static extern void Dsyr2k(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas Trans, int N, int K, double alpha, double* A, int lda, double* B, int ldb, double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_csyr2k")]
            public static extern void Csyr2k(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas Trans, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zsyr2k")]
            public static extern void Zsyr2k(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas Trans, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_strmm")]
            public static extern void Strmm(BLAS.MatrixLayout matrixLayout, BLAS.SIDE Side, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int M, int N, float alpha, float* A, int lda, float* B, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dtrmm")]
            public static extern void Dtrmm(BLAS.MatrixLayout matrixLayout, BLAS.SIDE Side, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int M, int N, double alpha, double* A, int lda, double* B, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ctrmm")]
            public static extern void Ctrmm(BLAS.MatrixLayout matrixLayout, BLAS.SIDE Side, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int M, int N, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ztrmm")]
            public static extern void Ztrmm(BLAS.MatrixLayout matrixLayout, BLAS.SIDE Side, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int M, int N, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_strsm")]
            public static extern void Strsm(BLAS.MatrixLayout matrixLayout, BLAS.SIDE Side, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int M, int N, float alpha, float* A, int lda, float* B, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dtrsm")]
            public static extern void Dtrsm(BLAS.MatrixLayout matrixLayout, BLAS.SIDE Side, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int M, int N, double alpha, double* A, int lda, double* B, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ctrsm")]
            public static extern void Ctrsm(BLAS.MatrixLayout matrixLayout, BLAS.SIDE Side, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int M, int N, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ztrsm")]
            public static extern void Ztrsm(BLAS.MatrixLayout matrixLayout, BLAS.SIDE Side, BLAS.UpLoCblas Uplo, BLAS.TransCblas TransA, BLAS.DIAG Diag, int M, int N, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_chemm")]
            public static extern void Chemm(BLAS.MatrixLayout matrixLayout, BLAS.SIDE Side, BLAS.UpLoCblas Uplo, int M, int N, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zhemm")]
            public static extern void Zhemm(BLAS.MatrixLayout matrixLayout, BLAS.SIDE Side, BLAS.UpLoCblas Uplo, int M, int N, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cherk")]
            public static extern void Cherk(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas Trans, int N, int K, float alpha, IntPtr A, int lda, float beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zherk")]
            public static extern void Zherk(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas Trans, int N, int K, double alpha, IntPtr A, int lda, double beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cher2k")]
            public static extern void Cher2k(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas Trans, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, float beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zher2k")]
            public static extern void Zher2k(BLAS.MatrixLayout matrixLayout, BLAS.UpLoCblas Uplo, BLAS.TransCblas Trans, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, double beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_xerbla")]
            public static extern void Xerbla(int p, sbyte* rout, sbyte* form);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_saxpby")]
            public static extern void Saxpby(int n, float alpha, float* x, int incx, float beta, float* y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_daxpby")]
            public static extern void Daxpby(int n, double alpha, double* x, int incx, double beta, double* y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_caxpby")]
            public static extern void Caxpby(int n, IntPtr alpha, IntPtr x, int incx, IntPtr beta, IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zaxpby")]
            public static extern void Zaxpby(int n, IntPtr alpha, IntPtr x, int incx, IntPtr beta, IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_somatcopy")]
            public static extern void Somatcopy(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas Trans, int crows, int ccols, float calpha, float* a, int clda, float* b, int cldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_domatcopy")]
            public static extern void Domatcopy(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas Trans, int crows, int ccols, double calpha, double* a, int clda, double* b, int cldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_comatcopy")]
            public static extern void Comatcopy(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas Trans, int crows, int ccols, float* calpha, float* a, int clda, float* b, int cldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zomatcopy")]
            public static extern void Zomatcopy(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas Trans, int crows, int ccols, double* calpha, double* a, int clda, double* b, int cldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_simatcopy")]
            public static extern void Simatcopy(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas Trans, int crows, int ccols, float calpha, float* a, int clda, int cldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dimatcopy")]
            public static extern void Dimatcopy(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas Trans, int crows, int ccols, double calpha, double* a, int clda, int cldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cimatcopy")]
            public static extern void Cimatcopy(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas Trans, int crows, int ccols, float* calpha, float* a, int clda, int cldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zimatcopy")]
            public static extern void Zimatcopy(BLAS.MatrixLayout matrixLayout, BLAS.TransCblas Trans, int crows, int ccols, double* calpha, double* a, int clda, int cldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_sgeadd")]
            public static extern void Sgeadd(BLAS.MatrixLayout matrixLayout, int crows, int ccols, float calpha, float* a, int clda, float cbeta, float* c, int cldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dgeadd")]
            public static extern void Dgeadd(BLAS.MatrixLayout matrixLayout, int crows, int ccols, double calpha, double* a, int clda, double cbeta, double* c, int cldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cgeadd")]
            public static extern void Cgeadd(BLAS.MatrixLayout matrixLayout, int crows, int ccols, float* calpha, float* a, int clda, float* cbeta, float* c, int cldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zgeadd")]
            public static extern void Zgeadd(BLAS.MatrixLayout matrixLayout, int crows, int ccols, double* calpha, double* a, int clda, double* cbeta, double* c, int cldc);
        }
    }
}