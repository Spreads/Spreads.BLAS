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
            public static extern void Sgemv(MatrixLayout matrixLayout, TransCblas trans, int m, int n, float alpha, float* a, int lda, float* x, int incx, float beta, float* y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dgemv")]
            public static extern void Dgemv(MatrixLayout matrixLayout, TransCblas trans, int m, int n, double alpha, double* a, int lda, double* x, int incx, double beta, double* y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cgemv")]
            public static extern void Cgemv(MatrixLayout matrixLayout, TransCblas trans, int m, int n, IntPtr alpha, IntPtr a, int lda, IntPtr x, int incx, IntPtr beta, IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zgemv")]
            public static extern void Zgemv(MatrixLayout matrixLayout, TransCblas trans, int m, int n, IntPtr alpha, IntPtr a, int lda, IntPtr x, int incx, IntPtr beta, IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_sger")]
            public static extern void Sger(MatrixLayout matrixLayout, int M, int N, float alpha, float* X, int incX, float* Y, int incY, float* A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dger")]
            public static extern void Dger(MatrixLayout matrixLayout, int M, int N, double alpha, double* X, int incX, double* Y, int incY, double* A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cgeru")]
            public static extern void Cgeru(MatrixLayout matrixLayout, int M, int N, IntPtr alpha, IntPtr X, int incX, IntPtr Y, int incY, IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cgerc")]
            public static extern void Cgerc(MatrixLayout matrixLayout, int M, int N, IntPtr alpha, IntPtr X, int incX, IntPtr Y, int incY, IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zgeru")]
            public static extern void Zgeru(MatrixLayout matrixLayout, int M, int N, IntPtr alpha, IntPtr X, int incX, IntPtr Y, int incY, IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zgerc")]
            public static extern void Zgerc(MatrixLayout matrixLayout, int M, int N, IntPtr alpha, IntPtr X, int incX, IntPtr Y, int incY, IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_strsv")]
            public static extern void Strsv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dtrsv")]
            public static extern void Dtrsv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ctrsv")]
            public static extern void Ctrsv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, IntPtr A, int lda, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ztrsv")]
            public static extern void Ztrsv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, IntPtr A, int lda, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_strmv")]
            public static extern void Strmv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dtrmv")]
            public static extern void Dtrmv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ctrmv")]
            public static extern void Ctrmv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, IntPtr A, int lda, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ztrmv")]
            public static extern void Ztrmv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, IntPtr A, int lda, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ssyr")]
            public static extern void Ssyr(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, float alpha, float* X, int incX, float* A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dsyr")]
            public static extern void Dsyr(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, double alpha, double* X, int incX, double* A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cher")]
            public static extern void Cher(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, float alpha, IntPtr X, int incX, IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zher")]
            public static extern void Zher(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, double alpha, IntPtr X, int incX, IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ssyr2")]
            public static extern void Ssyr2(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, float alpha, float* X, int incX, float* Y, int incY, float* A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dsyr2")]
            public static extern void Dsyr2(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, double alpha, double* X, int incX, double* Y, int incY, double* A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cher2")]
            public static extern void Cher2(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, IntPtr alpha, IntPtr X, int incX, IntPtr Y, int incY, IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zher2")]
            public static extern void Zher2(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, IntPtr alpha, IntPtr X, int incX, IntPtr Y, int incY, IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_sgbmv")]
            public static extern void Sgbmv(MatrixLayout matrixLayout, TransCblas TransA, int M, int N, int KL, int KU, float alpha, float* A, int lda, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dgbmv")]
            public static extern void Dgbmv(MatrixLayout matrixLayout, TransCblas TransA, int M, int N, int KL, int KU, double alpha, double* A, int lda, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cgbmv")]
            public static extern void Cgbmv(MatrixLayout matrixLayout, TransCblas TransA, int M, int N, int KL, int KU, IntPtr alpha, IntPtr A, int lda, IntPtr X, int incX, IntPtr beta, IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zgbmv")]
            public static extern void Zgbmv(MatrixLayout matrixLayout, TransCblas TransA, int M, int N, int KL, int KU, IntPtr alpha, IntPtr A, int lda, IntPtr X, int incX, IntPtr beta, IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ssbmv")]
            public static extern void Ssbmv(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, int K, float alpha, float* A, int lda, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dsbmv")]
            public static extern void Dsbmv(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, int K, double alpha, double* A, int lda, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_stbmv")]
            public static extern void Stbmv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, int K, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dtbmv")]
            public static extern void Dtbmv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, int K, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ctbmv")]
            public static extern void Ctbmv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, int K, IntPtr A, int lda, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ztbmv")]
            public static extern void Ztbmv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, int K, IntPtr A, int lda, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_stbsv")]
            public static extern void Stbsv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, int K, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dtbsv")]
            public static extern void Dtbsv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, int K, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ctbsv")]
            public static extern void Ctbsv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, int K, IntPtr A, int lda, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ztbsv")]
            public static extern void Ztbsv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, int K, IntPtr A, int lda, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_stpmv")]
            public static extern void Stpmv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, float* Ap, float* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dtpmv")]
            public static extern void Dtpmv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, double* Ap, double* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ctpmv")]
            public static extern void Ctpmv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, IntPtr Ap, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ztpmv")]
            public static extern void Ztpmv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, IntPtr Ap, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_stpsv")]
            public static extern void Stpsv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, float* Ap, float* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dtpsv")]
            public static extern void Dtpsv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, double* Ap, double* X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ctpsv")]
            public static extern void Ctpsv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, IntPtr Ap, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ztpsv")]
            public static extern void Ztpsv(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int N, IntPtr Ap, IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ssymv")]
            public static extern void Ssymv(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, float alpha, float* A, int lda, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dsymv")]
            public static extern void Dsymv(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, double alpha, double* A, int lda, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_chemv")]
            public static extern void Chemv(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, IntPtr alpha, IntPtr A, int lda, IntPtr X, int incX, IntPtr beta, IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zhemv")]
            public static extern void Zhemv(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, IntPtr alpha, IntPtr A, int lda, IntPtr X, int incX, IntPtr beta, IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_sspmv")]
            public static extern void Sspmv(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, float alpha, float* Ap, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dspmv")]
            public static extern void Dspmv(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, double alpha, double* Ap, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_sspr")]
            public static extern void Sspr(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, float alpha, float* X, int incX, float* Ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dspr")]
            public static extern void Dspr(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, double alpha, double* X, int incX, double* Ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_chpr")]
            public static extern void Chpr(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, float alpha, IntPtr X, int incX, IntPtr A);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zhpr")]
            public static extern void Zhpr(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, double alpha, IntPtr X, int incX, IntPtr A);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_sspr2")]
            public static extern void Sspr2(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, float alpha, float* X, int incX, float* Y, int incY, float* A);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dspr2")]
            public static extern void Dspr2(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, double alpha, double* X, int incX, double* Y, int incY, double* A);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_chpr2")]
            public static extern void Chpr2(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, IntPtr alpha, IntPtr X, int incX, IntPtr Y, int incY, IntPtr Ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zhpr2")]
            public static extern void Zhpr2(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, IntPtr alpha, IntPtr X, int incX, IntPtr Y, int incY, IntPtr Ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_chbmv")]
            public static extern void Chbmv(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr X, int incX, IntPtr beta, IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zhbmv")]
            public static extern void Zhbmv(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr X, int incX, IntPtr beta, IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_chpmv")]
            public static extern void Chpmv(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, IntPtr alpha, IntPtr Ap, IntPtr X, int incX, IntPtr beta, IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zhpmv")]
            public static extern void Zhpmv(MatrixLayout matrixLayout, UpLoCblas Uplo, int N, IntPtr alpha, IntPtr Ap, IntPtr X, int incX, IntPtr beta, IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_sgemm")]
            public static extern void Sgemm(MatrixLayout matrixLayout, TransCblas TransA, TransCblas TransB, int M, int N, int K, float alpha, float* A, int lda, float* B, int ldb, float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dgemm")]
            public static extern void Dgemm(MatrixLayout matrixLayout, TransCblas TransA, TransCblas TransB, int M, int N, int K, double alpha, double* A, int lda, double* B, int ldb, double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cgemm")]
            public static extern void Cgemm(MatrixLayout matrixLayout, TransCblas TransA, TransCblas TransB, int M, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cgemm3m")]
            public static extern void Cgemm3m(MatrixLayout matrixLayout, TransCblas TransA, TransCblas TransB, int M, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zgemm")]
            public static extern void Zgemm(MatrixLayout matrixLayout, TransCblas TransA, TransCblas TransB, int M, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zgemm3m")]
            public static extern void Zgemm3m(MatrixLayout matrixLayout, TransCblas TransA, TransCblas TransB, int M, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ssymm")]
            public static extern void Ssymm(MatrixLayout matrixLayout, BLAS.SIDE Side, UpLoCblas Uplo, int M, int N, float alpha, float* A, int lda, float* B, int ldb, float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dsymm")]
            public static extern void Dsymm(MatrixLayout matrixLayout, BLAS.SIDE Side, UpLoCblas Uplo, int M, int N, double alpha, double* A, int lda, double* B, int ldb, double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_csymm")]
            public static extern void Csymm(MatrixLayout matrixLayout, BLAS.SIDE Side, UpLoCblas Uplo, int M, int N, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zsymm")]
            public static extern void Zsymm(MatrixLayout matrixLayout, BLAS.SIDE Side, UpLoCblas Uplo, int M, int N, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ssyrk")]
            public static extern void Ssyrk(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas Trans, int N, int K, float alpha, float* A, int lda, float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dsyrk")]
            public static extern void Dsyrk(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas Trans, int N, int K, double alpha, double* A, int lda, double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_csyrk")]
            public static extern void Csyrk(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas Trans, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zsyrk")]
            public static extern void Zsyrk(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas Trans, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ssyr2k")]
            public static extern void Ssyr2k(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas Trans, int N, int K, float alpha, float* A, int lda, float* B, int ldb, float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dsyr2k")]
            public static extern void Dsyr2k(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas Trans, int N, int K, double alpha, double* A, int lda, double* B, int ldb, double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_csyr2k")]
            public static extern void Csyr2k(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas Trans, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zsyr2k")]
            public static extern void Zsyr2k(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas Trans, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_strmm")]
            public static extern void Strmm(MatrixLayout matrixLayout, BLAS.SIDE Side, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int M, int N, float alpha, float* A, int lda, float* B, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dtrmm")]
            public static extern void Dtrmm(MatrixLayout matrixLayout, BLAS.SIDE Side, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int M, int N, double alpha, double* A, int lda, double* B, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ctrmm")]
            public static extern void Ctrmm(MatrixLayout matrixLayout, BLAS.SIDE Side, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int M, int N, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ztrmm")]
            public static extern void Ztrmm(MatrixLayout matrixLayout, BLAS.SIDE Side, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int M, int N, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_strsm")]
            public static extern void Strsm(MatrixLayout matrixLayout, BLAS.SIDE Side, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int M, int N, float alpha, float* A, int lda, float* B, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dtrsm")]
            public static extern void Dtrsm(MatrixLayout matrixLayout, BLAS.SIDE Side, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int M, int N, double alpha, double* A, int lda, double* B, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ctrsm")]
            public static extern void Ctrsm(MatrixLayout matrixLayout, BLAS.SIDE Side, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int M, int N, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_ztrsm")]
            public static extern void Ztrsm(MatrixLayout matrixLayout, BLAS.SIDE Side, UpLoCblas Uplo, TransCblas TransA, BLAS.DIAG Diag, int M, int N, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_chemm")]
            public static extern void Chemm(MatrixLayout matrixLayout, BLAS.SIDE Side, UpLoCblas Uplo, int M, int N, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zhemm")]
            public static extern void Zhemm(MatrixLayout matrixLayout, BLAS.SIDE Side, UpLoCblas Uplo, int M, int N, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, IntPtr beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cherk")]
            public static extern void Cherk(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas Trans, int N, int K, float alpha, IntPtr A, int lda, float beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zherk")]
            public static extern void Zherk(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas Trans, int N, int K, double alpha, IntPtr A, int lda, double beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cher2k")]
            public static extern void Cher2k(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas Trans, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, float beta, IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zher2k")]
            public static extern void Zher2k(MatrixLayout matrixLayout, UpLoCblas Uplo, TransCblas Trans, int N, int K, IntPtr alpha, IntPtr A, int lda, IntPtr B, int ldb, double beta, IntPtr C, int ldc);

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
            public static extern void Somatcopy(MatrixLayout matrixLayout, TransCblas Trans, int crows, int ccols, float calpha, float* a, int clda, float* b, int cldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_domatcopy")]
            public static extern void Domatcopy(MatrixLayout matrixLayout, TransCblas Trans, int crows, int ccols, double calpha, double* a, int clda, double* b, int cldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_comatcopy")]
            public static extern void Comatcopy(MatrixLayout matrixLayout, TransCblas Trans, int crows, int ccols, float* calpha, float* a, int clda, float* b, int cldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zomatcopy")]
            public static extern void Zomatcopy(MatrixLayout matrixLayout, TransCblas Trans, int crows, int ccols, double* calpha, double* a, int clda, double* b, int cldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_simatcopy")]
            public static extern void Simatcopy(MatrixLayout matrixLayout, TransCblas Trans, int crows, int ccols, float calpha, float* a, int clda, int cldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dimatcopy")]
            public static extern void Dimatcopy(MatrixLayout matrixLayout, TransCblas Trans, int crows, int ccols, double calpha, double* a, int clda, int cldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cimatcopy")]
            public static extern void Cimatcopy(MatrixLayout matrixLayout, TransCblas Trans, int crows, int ccols, float* calpha, float* a, int clda, int cldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zimatcopy")]
            public static extern void Zimatcopy(MatrixLayout matrixLayout, TransCblas Trans, int crows, int ccols, double* calpha, double* a, int clda, int cldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_sgeadd")]
            public static extern void Sgeadd(MatrixLayout matrixLayout, int crows, int ccols, float calpha, float* a, int clda, float cbeta, float* c, int cldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_dgeadd")]
            public static extern void Dgeadd(MatrixLayout matrixLayout, int crows, int ccols, double calpha, double* a, int clda, double cbeta, double* c, int cldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_cgeadd")]
            public static extern void Cgeadd(MatrixLayout matrixLayout, int crows, int ccols, float* calpha, float* a, int clda, float* cbeta, float* c, int cldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "cblas_zgeadd")]
            public static extern void Zgeadd(MatrixLayout matrixLayout, int crows, int ccols, double* calpha, double* a, int clda, double* cbeta, double* c, int cldc);
        }
    }
}