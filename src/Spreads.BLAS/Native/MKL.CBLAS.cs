// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System.Runtime.InteropServices;
using System.Security;
// ReSharper disable InconsistentNaming

namespace Spreads.Native
{
    public static unsafe partial class MKL
    {
        public static class CBLAS
        {
                   [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dcabs1")]
            internal static extern double Dcabs1(System.IntPtr z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_scabs1")]
            internal static extern float Scabs1(System.IntPtr c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_sdot")]
            internal static extern float Sdot(int N, float* X, int incX, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_sdoti")]
            internal static extern float Sdoti(int N, float* X, int* indx, float* Y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ddot")]
            internal static extern double Ddot(int N, double* X, int incX, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ddoti")]
            internal static extern double Ddoti(int N, double* X, int* indx, double* Y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dsdot")]
            internal static extern double Dsdot(int N, float* X, int incX, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_sdsdot")]
            internal static extern float Sdsdot(int N, float sb, float* X, int incX, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_cdotu_sub")]
            internal static extern void CdotuSub(int N, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr dotu);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_cdotui_sub")]
            internal static extern void CdotuiSub(int N, System.IntPtr X, int* indx, System.IntPtr Y, System.IntPtr dotui);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_cdotc_sub")]
            internal static extern void CdotcSub(int N, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr dotc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_cdotci_sub")]
            internal static extern void CdotciSub(int N, System.IntPtr X, int* indx, System.IntPtr Y, System.IntPtr dotui);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zdotu_sub")]
            internal static extern void ZdotuSub(int N, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr dotu);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zdotui_sub")]
            internal static extern void ZdotuiSub(int N, System.IntPtr X, int* indx, System.IntPtr Y, System.IntPtr dotui);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zdotc_sub")]
            internal static extern void ZdotcSub(int N, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr dotc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zdotci_sub")]
            internal static extern void ZdotciSub(int N, System.IntPtr X, int* indx, System.IntPtr Y, System.IntPtr dotui);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_snrm2")]
            internal static extern float Snrm2(int N, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_sasum")]
            internal static extern float Sasum(int N, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dnrm2")]
            internal static extern double Dnrm2(int N, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dasum")]
            internal static extern double Dasum(int N, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_scnrm2")]
            internal static extern float Scnrm2(int N, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_scasum")]
            internal static extern float Scasum(int N, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dznrm2")]
            internal static extern double Dznrm2(int N, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dzasum")]
            internal static extern double Dzasum(int N, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_isamax")]
            internal static extern ulong Isamax(int N, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_idamax")]
            internal static extern ulong Idamax(int N, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_icamax")]
            internal static extern ulong Icamax(int N, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_izamax")]
            internal static extern ulong Izamax(int N, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_isamin")]
            internal static extern ulong Isamin(int N, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_idamin")]
            internal static extern ulong Idamin(int N, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_icamin")]
            internal static extern ulong Icamin(int N, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_izamin")]
            internal static extern ulong Izamin(int N, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_sswap")]
            internal static extern void Sswap(int N, float* X, int incX, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_scopy")]
            internal static extern void Scopy(int N, float* X, int incX, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_saxpy")]
            internal static extern void Saxpy(int N, float alpha, float* X, int incX, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_saxpby")]
            internal static extern void Saxpby(int N, float alpha, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_saxpyi")]
            internal static extern void Saxpyi(int N, float alpha, float* X, int* indx, float* Y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_sgthr")]
            internal static extern void Sgthr(int N, float* Y, float* X, int* indx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_sgthrz")]
            internal static extern void Sgthrz(int N, float* Y, float* X, int* indx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ssctr")]
            internal static extern void Ssctr(int N, float* X, int* indx, float* Y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_srotg")]
            internal static extern void Srotg(float* a, float* b, float* c, float* s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dswap")]
            internal static extern void Dswap(int N, double* X, int incX, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dcopy")]
            internal static extern void Dcopy(int N, double* X, int incX, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_daxpy")]
            internal static extern void Daxpy(int N, double alpha, double* X, int incX, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_daxpby")]
            internal static extern void Daxpby(int N, double alpha, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_daxpyi")]
            internal static extern void Daxpyi(int N, double alpha, double* X, int* indx, double* Y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dgthr")]
            internal static extern void Dgthr(int N, double* Y, double* X, int* indx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dgthrz")]
            internal static extern void Dgthrz(int N, double* Y, double* X, int* indx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dsctr")]
            internal static extern void Dsctr(int N, double* X, int* indx, double* Y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_drotg")]
            internal static extern void Drotg(double* a, double* b, double* c, double* s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_cswap")]
            internal static extern void Cswap(int N, System.IntPtr X, int incX, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ccopy")]
            internal static extern void Ccopy(int N, System.IntPtr X, int incX, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_caxpy")]
            internal static extern void Caxpy(int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_caxpby")]
            internal static extern void Caxpby(int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_caxpyi")]
            internal static extern void Caxpyi(int N, System.IntPtr alpha, System.IntPtr X, int* indx, System.IntPtr Y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_cgthr")]
            internal static extern void Cgthr(int N, System.IntPtr Y, System.IntPtr X, int* indx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_cgthrz")]
            internal static extern void Cgthrz(int N, System.IntPtr Y, System.IntPtr X, int* indx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_csctr")]
            internal static extern void Csctr(int N, System.IntPtr X, int* indx, System.IntPtr Y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_crotg")]
            internal static extern void Crotg(System.IntPtr a, System.IntPtr b, float* c, System.IntPtr s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zswap")]
            internal static extern void Zswap(int N, System.IntPtr X, int incX, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zcopy")]
            internal static extern void Zcopy(int N, System.IntPtr X, int incX, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zaxpy")]
            internal static extern void Zaxpy(int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zaxpby")]
            internal static extern void Zaxpby(int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zaxpyi")]
            internal static extern void Zaxpyi(int N, System.IntPtr alpha, System.IntPtr X, int* indx, System.IntPtr Y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zgthr")]
            internal static extern void Zgthr(int N, System.IntPtr Y, System.IntPtr X, int* indx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zgthrz")]
            internal static extern void Zgthrz(int N, System.IntPtr Y, System.IntPtr X, int* indx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zsctr")]
            internal static extern void Zsctr(int N, System.IntPtr X, int* indx, System.IntPtr Y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zrotg")]
            internal static extern void Zrotg(System.IntPtr a, System.IntPtr b, double* c, System.IntPtr s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_srotmg")]
            internal static extern void Srotmg(float* d1, float* d2, float* b1, float b2, float* P);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_srot")]
            internal static extern void Srot(int N, float* X, int incX, float* Y, int incY, float c, float s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_sroti")]
            internal static extern void Sroti(int N, float* X, int* indx, float* Y, float c, float s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_srotm")]
            internal static extern void Srotm(int N, float* X, int incX, float* Y, int incY, float* P);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_drotmg")]
            internal static extern void Drotmg(double* d1, double* d2, double* b1, double b2, double* P);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_drot")]
            internal static extern void Drot(int N, double* X, int incX, double* Y, int incY, double c, double s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_drotm")]
            internal static extern void Drotm(int N, double* X, int incX, double* Y, int incY, double* P);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_droti")]
            internal static extern void Droti(int N, double* X, int* indx, double* Y, double c, double s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_csrot")]
            internal static extern void Csrot(int N, System.IntPtr X, int incX, System.IntPtr Y, int incY, float c, float s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zdrot")]
            internal static extern void Zdrot(int N, System.IntPtr X, int incX, System.IntPtr Y, int incY, double c, double s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_sscal")]
            internal static extern void Sscal(int N, float alpha, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dscal")]
            internal static extern void Dscal(int N, double alpha, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_cscal")]
            internal static extern void Cscal(int N, System.IntPtr alpha, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zscal")]
            internal static extern void Zscal(int N, System.IntPtr alpha, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_csscal")]
            internal static extern void Csscal(int N, float alpha, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zdscal")]
            internal static extern void Zdscal(int N, double alpha, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_sgemv")]
            internal static extern void Sgemv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, int M, int N, float alpha, float* A, int lda, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_sgbmv")]
            internal static extern void Sgbmv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, int M, int N, int KL, int KU, float alpha, float* A, int lda, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_strmv")]
            internal static extern void Strmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_stbmv")]
            internal static extern void Stbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_stpmv")]
            internal static extern void Stpmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, float* Ap, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_strsv")]
            internal static extern void Strsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_stbsv")]
            internal static extern void Stbsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_stpsv")]
            internal static extern void Stpsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, float* Ap, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dgemv")]
            internal static extern void Dgemv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, int M, int N, double alpha, double* A, int lda, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dgbmv")]
            internal static extern void Dgbmv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, int M, int N, int KL, int KU, double alpha, double* A, int lda, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dtrmv")]
            internal static extern void Dtrmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dtbmv")]
            internal static extern void Dtbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dtpmv")]
            internal static extern void Dtpmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, double* Ap, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dtrsv")]
            internal static extern void Dtrsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dtbsv")]
            internal static extern void Dtbsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dtpsv")]
            internal static extern void Dtpsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, double* Ap, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_cgemv")]
            internal static extern void Cgemv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, int M, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr X, int incX, System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_cgbmv")]
            internal static extern void Cgbmv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, int M, int N, int KL, int KU, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr X, int incX, System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ctrmv")]
            internal static extern void Ctrmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr A, int lda, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ctbmv")]
            internal static extern void Ctbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, System.IntPtr A, int lda, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ctpmv")]
            internal static extern void Ctpmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr Ap, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ctrsv")]
            internal static extern void Ctrsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr A, int lda, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ctbsv")]
            internal static extern void Ctbsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, System.IntPtr A, int lda, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ctpsv")]
            internal static extern void Ctpsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr Ap, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zgemv")]
            internal static extern void Zgemv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, int M, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr X, int incX, System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zgbmv")]
            internal static extern void Zgbmv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, int M, int N, int KL, int KU, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr X, int incX, System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ztrmv")]
            internal static extern void Ztrmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr A, int lda, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ztbmv")]
            internal static extern void Ztbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, System.IntPtr A, int lda, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ztpmv")]
            internal static extern void Ztpmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr Ap, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ztrsv")]
            internal static extern void Ztrsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr A, int lda, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ztbsv")]
            internal static extern void Ztbsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, System.IntPtr A, int lda, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ztpsv")]
            internal static extern void Ztpsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr Ap, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ssymv")]
            internal static extern void Ssymv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, float* A, int lda, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ssbmv")]
            internal static extern void Ssbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, int K, float alpha, float* A, int lda, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_sspmv")]
            internal static extern void Sspmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, float* Ap, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_sger")]
            internal static extern void Sger(BLAS.LAYOUT Layout, int M, int N, float alpha, float* X, int incX, float* Y, int incY, float* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ssyr")]
            internal static extern void Ssyr(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, float* X, int incX, float* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_sspr")]
            internal static extern void Sspr(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, float* X, int incX, float* Ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ssyr2")]
            internal static extern void Ssyr2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, float* X, int incX, float* Y, int incY, float* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_sspr2")]
            internal static extern void Sspr2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, float* X, int incX, float* Y, int incY, float* A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dsymv")]
            internal static extern void Dsymv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, double* A, int lda, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dsbmv")]
            internal static extern void Dsbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, int K, double alpha, double* A, int lda, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dspmv")]
            internal static extern void Dspmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, double* Ap, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dger")]
            internal static extern void Dger(BLAS.LAYOUT Layout, int M, int N, double alpha, double* X, int incX, double* Y, int incY, double* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dsyr")]
            internal static extern void Dsyr(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, double* X, int incX, double* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dspr")]
            internal static extern void Dspr(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, double* X, int incX, double* Ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dsyr2")]
            internal static extern void Dsyr2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, double* X, int incX, double* Y, int incY, double* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dspr2")]
            internal static extern void Dspr2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, double* X, int incX, double* Y, int incY, double* A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_chemv")]
            internal static extern void Chemv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr X, int incX, System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_chbmv")]
            internal static extern void Chbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr X, int incX, System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_chpmv")]
            internal static extern void Chpmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr Ap, System.IntPtr X, int incX, System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_cgeru")]
            internal static extern void Cgeru(BLAS.LAYOUT Layout, int M, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_cgerc")]
            internal static extern void Cgerc(BLAS.LAYOUT Layout, int M, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_cher")]
            internal static extern void Cher(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, System.IntPtr X, int incX, System.IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_chpr")]
            internal static extern void Chpr(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, System.IntPtr X, int incX, System.IntPtr A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_cher2")]
            internal static extern void Cher2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_chpr2")]
            internal static extern void Chpr2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr Ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zhemv")]
            internal static extern void Zhemv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr X, int incX, System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zhbmv")]
            internal static extern void Zhbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr X, int incX, System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zhpmv")]
            internal static extern void Zhpmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr Ap, System.IntPtr X, int incX, System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zgeru")]
            internal static extern void Zgeru(BLAS.LAYOUT Layout, int M, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zgerc")]
            internal static extern void Zgerc(BLAS.LAYOUT Layout, int M, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zher")]
            internal static extern void Zher(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, System.IntPtr X, int incX, System.IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zhpr")]
            internal static extern void Zhpr(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, System.IntPtr X, int incX, System.IntPtr A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zher2")]
            internal static extern void Zher2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zhpr2")]
            internal static extern void Zhpr2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr Ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_sgemm")]
            internal static extern void Sgemm(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int M, int N, int K, float alpha, float* A, int lda, float* B, int ldb, float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_sgemmt")]
            internal static extern void Sgemmt(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int N, int K, float alpha, float* A, int lda, float* B, int ldb, float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ssymm")]
            internal static extern void Ssymm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, int M, int N, float alpha, float* A, int lda, float* B, int ldb, float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ssyrk")]
            internal static extern void Ssyrk(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, float alpha, float* A, int lda, float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ssyr2k")]
            internal static extern void Ssyr2k(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, float alpha, float* A, int lda, float* B, int ldb, float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_strmm")]
            internal static extern void Strmm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, float alpha, float* A, int lda, float* B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_strsm")]
            internal static extern void Strsm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, float alpha, float* A, int lda, float* B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dgemm")]
            internal static extern void Dgemm(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int M, int N, int K, double alpha, double* A, int lda, double* B, int ldb, double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dgemmt")]
            internal static extern void Dgemmt(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int N, int K, double alpha, double* A, int lda, double* B, int ldb, double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dsymm")]
            internal static extern void Dsymm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, int M, int N, double alpha, double* A, int lda, double* B, int ldb, double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dsyrk")]
            internal static extern void Dsyrk(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, double alpha, double* A, int lda, double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dsyr2k")]
            internal static extern void Dsyr2k(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, double alpha, double* A, int lda, double* B, int ldb, double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dtrmm")]
            internal static extern void Dtrmm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, double alpha, double* A, int lda, double* B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_dtrsm")]
            internal static extern void Dtrsm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, double alpha, double* A, int lda, double* B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_cgemm")]
            internal static extern void Cgemm(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int M, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_cgemm3m")]
            internal static extern void Cgemm3m(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int M, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_cgemmt")]
            internal static extern void Cgemmt(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_csymm")]
            internal static extern void Csymm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, int M, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_csyrk")]
            internal static extern void Csyrk(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_csyr2k")]
            internal static extern void Csyr2k(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ctrmm")]
            internal static extern void Ctrmm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ctrsm")]
            internal static extern void Ctrsm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zgemm")]
            internal static extern void Zgemm(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int M, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zgemm3m")]
            internal static extern void Zgemm3m(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int M, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zgemmt")]
            internal static extern void Zgemmt(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zsymm")]
            internal static extern void Zsymm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, int M, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zsyrk")]
            internal static extern void Zsyrk(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zsyr2k")]
            internal static extern void Zsyr2k(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ztrmm")]
            internal static extern void Ztrmm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_ztrsm")]
            internal static extern void Ztrsm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_chemm")]
            internal static extern void Chemm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, int M, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_cherk")]
            internal static extern void Cherk(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, float alpha, System.IntPtr A, int lda, float beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_cher2k")]
            internal static extern void Cher2k(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B, int ldb, float beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zhemm")]
            internal static extern void Zhemm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, int M, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zherk")]
            internal static extern void Zherk(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, double alpha, System.IntPtr A, int lda, double beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="cblas_zher2k")]
            internal static extern void Zher2k(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B, int ldb, double beta, System.IntPtr C, int ldc);
        
        }
    }
}