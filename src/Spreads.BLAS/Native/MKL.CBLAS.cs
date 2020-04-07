﻿// This Source Code Form is subject to the terms of the Mozilla Public
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
                EntryPoint = "cblas_dcabs1")]
            public static extern double Dcabs1(System.IntPtr z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_scabs1")]
            public static extern float Scabs1(System.IntPtr c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sdot")]
            public static extern float Sdot(int N, float* X, int incX, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sdoti")]
            public static extern float Sdoti(int N, float* X, int* indx, float* Y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ddot")]
            public static extern double Ddot(int N, double* X, int incX, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ddoti")]
            public static extern double Ddoti(int N, double* X, int* indx, double* Y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dsdot")]
            public static extern double Dsdot(int N, float* X, int incX, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sdsdot")]
            public static extern float Sdsdot(int N, float sb, float* X, int incX, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cdotu_sub")]
            public static extern void CdotuSub(int N, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr dotu);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cdotui_sub")]
            public static extern void CdotuiSub(int N, System.IntPtr X, int* indx, System.IntPtr Y, System.IntPtr dotui);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cdotc_sub")]
            public static extern void CdotcSub(int N, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr dotc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cdotci_sub")]
            public static extern void CdotciSub(int N, System.IntPtr X, int* indx, System.IntPtr Y, System.IntPtr dotui);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zdotu_sub")]
            public static extern void ZdotuSub(int N, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr dotu);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zdotui_sub")]
            public static extern void ZdotuiSub(int N, System.IntPtr X, int* indx, System.IntPtr Y, System.IntPtr dotui);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zdotc_sub")]
            public static extern void ZdotcSub(int N, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr dotc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zdotci_sub")]
            public static extern void ZdotciSub(int N, System.IntPtr X, int* indx, System.IntPtr Y, System.IntPtr dotui);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_snrm2")]
            public static extern float Snrm2(int N, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sasum")]
            public static extern float Sasum(int N, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dnrm2")]
            public static extern double Dnrm2(int N, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dasum")]
            public static extern double Dasum(int N, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_scnrm2")]
            public static extern float Scnrm2(int N, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_scasum")]
            public static extern float Scasum(int N, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dznrm2")]
            public static extern double Dznrm2(int N, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dzasum")]
            public static extern double Dzasum(int N, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_isamax")]
            public static extern ulong Isamax(int N, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_idamax")]
            public static extern ulong Idamax(int N, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_icamax")]
            public static extern ulong Icamax(int N, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_izamax")]
            public static extern ulong Izamax(int N, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_isamin")]
            public static extern ulong Isamin(int N, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_idamin")]
            public static extern ulong Idamin(int N, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_icamin")]
            public static extern ulong Icamin(int N, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_izamin")]
            public static extern ulong Izamin(int N, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sswap")]
            public static extern void Sswap(int N, float* X, int incX, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_scopy")]
            public static extern void Scopy(int N, float* X, int incX, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_saxpy")]
            public static extern void Saxpy(int N, float alpha, float* X, int incX, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_saxpby")]
            public static extern void Saxpby(int N, float alpha, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_saxpyi")]
            public static extern void Saxpyi(int N, float alpha, float* X, int* indx, float* Y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sgthr")]
            public static extern void Sgthr(int N, float* Y, float* X, int* indx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sgthrz")]
            public static extern void Sgthrz(int N, float* Y, float* X, int* indx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ssctr")]
            public static extern void Ssctr(int N, float* X, int* indx, float* Y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_srotg")]
            public static extern void Srotg(float* a, float* b, float* c, float* s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dswap")]
            public static extern void Dswap(int N, double* X, int incX, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dcopy")]
            public static extern void Dcopy(int N, double* X, int incX, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_daxpy")]
            public static extern void Daxpy(int N, double alpha, double* X, int incX, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_daxpby")]
            public static extern void Daxpby(int N, double alpha, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_daxpyi")]
            public static extern void Daxpyi(int N, double alpha, double* X, int* indx, double* Y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dgthr")]
            public static extern void Dgthr(int N, double* Y, double* X, int* indx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dgthrz")]
            public static extern void Dgthrz(int N, double* Y, double* X, int* indx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dsctr")]
            public static extern void Dsctr(int N, double* X, int* indx, double* Y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_drotg")]
            public static extern void Drotg(double* a, double* b, double* c, double* s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cswap")]
            public static extern void Cswap(int N, System.IntPtr X, int incX, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ccopy")]
            public static extern void Ccopy(int N, System.IntPtr X, int incX, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_caxpy")]
            public static extern void Caxpy(int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_caxpby")]
            public static extern void Caxpby(int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_caxpyi")]
            public static extern void Caxpyi(int N, System.IntPtr alpha, System.IntPtr X, int* indx, System.IntPtr Y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cgthr")]
            public static extern void Cgthr(int N, System.IntPtr Y, System.IntPtr X, int* indx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cgthrz")]
            public static extern void Cgthrz(int N, System.IntPtr Y, System.IntPtr X, int* indx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_csctr")]
            public static extern void Csctr(int N, System.IntPtr X, int* indx, System.IntPtr Y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_crotg")]
            public static extern void Crotg(System.IntPtr a, System.IntPtr b, float* c, System.IntPtr s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zswap")]
            public static extern void Zswap(int N, System.IntPtr X, int incX, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zcopy")]
            public static extern void Zcopy(int N, System.IntPtr X, int incX, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zaxpy")]
            public static extern void Zaxpy(int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zaxpby")]
            public static extern void Zaxpby(int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zaxpyi")]
            public static extern void Zaxpyi(int N, System.IntPtr alpha, System.IntPtr X, int* indx, System.IntPtr Y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zgthr")]
            public static extern void Zgthr(int N, System.IntPtr Y, System.IntPtr X, int* indx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zgthrz")]
            public static extern void Zgthrz(int N, System.IntPtr Y, System.IntPtr X, int* indx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zsctr")]
            public static extern void Zsctr(int N, System.IntPtr X, int* indx, System.IntPtr Y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zrotg")]
            public static extern void Zrotg(System.IntPtr a, System.IntPtr b, double* c, System.IntPtr s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_srotmg")]
            public static extern void Srotmg(float* d1, float* d2, float* b1, float b2, float* P);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_srot")]
            public static extern void Srot(int N, float* X, int incX, float* Y, int incY, float c, float s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sroti")]
            public static extern void Sroti(int N, float* X, int* indx, float* Y, float c, float s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_srotm")]
            public static extern void Srotm(int N, float* X, int incX, float* Y, int incY, float* P);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_drotmg")]
            public static extern void Drotmg(double* d1, double* d2, double* b1, double b2, double* P);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_drot")]
            public static extern void Drot(int N, double* X, int incX, double* Y, int incY, double c, double s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_drotm")]
            public static extern void Drotm(int N, double* X, int incX, double* Y, int incY, double* P);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_droti")]
            public static extern void Droti(int N, double* X, int* indx, double* Y, double c, double s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_csrot")]
            public static extern void Csrot(int N, System.IntPtr X, int incX, System.IntPtr Y, int incY, float c, float s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zdrot")]
            public static extern void Zdrot(int N, System.IntPtr X, int incX, System.IntPtr Y, int incY, double c, double s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sscal")]
            public static extern void Sscal(int N, float alpha, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dscal")]
            public static extern void Dscal(int N, double alpha, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cscal")]
            public static extern void Cscal(int N, System.IntPtr alpha, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zscal")]
            public static extern void Zscal(int N, System.IntPtr alpha, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_csscal")]
            public static extern void Csscal(int N, float alpha, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zdscal")]
            public static extern void Zdscal(int N, double alpha, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sgemv")]
            public static extern void Sgemv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, int M, int N, float alpha, float* A, int lda, float* X, int incX, float beta, float* Y,
                int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sgbmv")]
            public static extern void Sgbmv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, int M, int N, int KL, int KU, float alpha, float* A, int lda, float* X, int incX,
                float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_strmv")]
            public static extern void Strmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_stbmv")]
            public static extern void Stbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_stpmv")]
            public static extern void Stpmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, float* Ap, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_strsv")]
            public static extern void Strsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_stbsv")]
            public static extern void Stbsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_stpsv")]
            public static extern void Stpsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, float* Ap, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dgemv")]
            public static extern void Dgemv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, int M, int N, double alpha, double* A, int lda, double* X, int incX, double beta,
                double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dgbmv")]
            public static extern void Dgbmv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, int M, int N, int KL, int KU, double alpha, double* A, int lda, double* X, int incX,
                double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dtrmv")]
            public static extern void Dtrmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dtbmv")]
            public static extern void Dtbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dtpmv")]
            public static extern void Dtpmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, double* Ap, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dtrsv")]
            public static extern void Dtrsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dtbsv")]
            public static extern void Dtbsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dtpsv")]
            public static extern void Dtpsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, double* Ap, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cgemv")]
            public static extern void Cgemv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, int M, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr X, int incX,
                System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cgbmv")]
            public static extern void Cgbmv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, int M, int N, int KL, int KU, System.IntPtr alpha, System.IntPtr A, int lda,
                System.IntPtr X, int incX, System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ctrmv")]
            public static extern void Ctrmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr A, int lda, System.IntPtr X,
                int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ctbmv")]
            public static extern void Ctbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, System.IntPtr A, int lda, System.IntPtr X,
                int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ctpmv")]
            public static extern void Ctpmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr Ap, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ctrsv")]
            public static extern void Ctrsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr A, int lda, System.IntPtr X,
                int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ctbsv")]
            public static extern void Ctbsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, System.IntPtr A, int lda, System.IntPtr X,
                int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ctpsv")]
            public static extern void Ctpsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr Ap, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zgemv")]
            public static extern void Zgemv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, int M, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr X, int incX,
                System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zgbmv")]
            public static extern void Zgbmv(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, int M, int N, int KL, int KU, System.IntPtr alpha, System.IntPtr A, int lda,
                System.IntPtr X, int incX, System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ztrmv")]
            public static extern void Ztrmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr A, int lda, System.IntPtr X,
                int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ztbmv")]
            public static extern void Ztbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, System.IntPtr A, int lda, System.IntPtr X,
                int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ztpmv")]
            public static extern void Ztpmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr Ap, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ztrsv")]
            public static extern void Ztrsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr A, int lda, System.IntPtr X,
                int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ztbsv")]
            public static extern void Ztbsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, int K, System.IntPtr A, int lda, System.IntPtr X,
                int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ztpsv")]
            public static extern void Ztpsv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int N, System.IntPtr Ap, System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ssymv")]
            public static extern void Ssymv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, float* A, int lda, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ssbmv")]
            public static extern void Ssbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, int K, float alpha, float* A, int lda, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sspmv")]
            public static extern void Sspmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, float* Ap, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sger")]
            public static extern void Sger(BLAS.LAYOUT Layout, int M, int N, float alpha, float* X, int incX, float* Y, int incY, float* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ssyr")]
            public static extern void Ssyr(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, float* X, int incX, float* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sspr")]
            public static extern void Sspr(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, float* X, int incX, float* Ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ssyr2")]
            public static extern void Ssyr2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, float* X, int incX, float* Y, int incY, float* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sspr2")]
            public static extern void Sspr2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, float* X, int incX, float* Y, int incY, float* A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dsymv")]
            public static extern void Dsymv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, double* A, int lda, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dsbmv")]
            public static extern void Dsbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, int K, double alpha, double* A, int lda, double* X, int incX, double beta, double* Y,
                int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dspmv")]
            public static extern void Dspmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, double* Ap, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dger")]
            public static extern void Dger(BLAS.LAYOUT Layout, int M, int N, double alpha, double* X, int incX, double* Y, int incY, double* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dsyr")]
            public static extern void Dsyr(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, double* X, int incX, double* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dspr")]
            public static extern void Dspr(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, double* X, int incX, double* Ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dsyr2")]
            public static extern void Dsyr2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, double* X, int incX, double* Y, int incY, double* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dspr2")]
            public static extern void Dspr2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, double* X, int incX, double* Y, int incY, double* A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_chemv")]
            public static extern void Chemv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr X, int incX,
                System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_chbmv")]
            public static extern void Chbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr X, int incX,
                System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_chpmv")]
            public static extern void Chpmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr Ap, System.IntPtr X, int incX, System.IntPtr beta,
                System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cgeru")]
            public static extern void Cgeru(BLAS.LAYOUT Layout, int M, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr A,
                int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cgerc")]
            public static extern void Cgerc(BLAS.LAYOUT Layout, int M, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr A,
                int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cher")]
            public static extern void Cher(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, System.IntPtr X, int incX, System.IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_chpr")]
            public static extern void Chpr(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, float alpha, System.IntPtr X, int incX, System.IntPtr A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cher2")]
            public static extern void Cher2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr A,
                int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_chpr2")]
            public static extern void Chpr2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY,
                System.IntPtr Ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zhemv")]
            public static extern void Zhemv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr X, int incX,
                System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zhbmv")]
            public static extern void Zhbmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr X, int incX,
                System.IntPtr beta, System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zhpmv")]
            public static extern void Zhpmv(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr Ap, System.IntPtr X, int incX, System.IntPtr beta,
                System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zgeru")]
            public static extern void Zgeru(BLAS.LAYOUT Layout, int M, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr A,
                int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zgerc")]
            public static extern void Zgerc(BLAS.LAYOUT Layout, int M, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr A,
                int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zher")]
            public static extern void Zher(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, System.IntPtr X, int incX, System.IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zhpr")]
            public static extern void Zhpr(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, double alpha, System.IntPtr X, int incX, System.IntPtr A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zher2")]
            public static extern void Zher2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY, System.IntPtr A,
                int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zhpr2")]
            public static extern void Zhpr2(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, int N, System.IntPtr alpha, System.IntPtr X, int incX, System.IntPtr Y, int incY,
                System.IntPtr Ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sgemm")]
            public static extern void Sgemm(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int M, int N, int K, float alpha, float* A, int lda, float* B,
                int ldb, float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_sgemmt")]
            public static extern void Sgemmt(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int N, int K, float alpha, float* A, int lda,
                float* B, int ldb, float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ssymm")]
            public static extern void Ssymm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, int M, int N, float alpha, float* A, int lda, float* B, int ldb, float beta,
                float* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ssyrk")]
            public static extern void Ssyrk(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, float alpha, float* A, int lda, float beta, float* C,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ssyr2k")]
            public static extern void Ssyr2k(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, float alpha, float* A, int lda, float* B, int ldb,
                float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_strmm")]
            public static extern void Strmm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, float alpha, float* A,
                int lda, float* B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_strsm")]
            public static extern void Strsm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, float alpha, float* A,
                int lda, float* B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dgemm")]
            public static extern void Dgemm(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int M, int N, int K, double alpha, double* A, int lda, double* B,
                int ldb, double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dgemmt")]
            public static extern void Dgemmt(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int N, int K, double alpha, double* A, int lda,
                double* B, int ldb, double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dsymm")]
            public static extern void Dsymm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, int M, int N, double alpha, double* A, int lda, double* B, int ldb, double beta,
                double* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dsyrk")]
            public static extern void Dsyrk(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, double alpha, double* A, int lda, double beta, double* C,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dsyr2k")]
            public static extern void Dsyr2k(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, double alpha, double* A, int lda, double* B, int ldb,
                double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dtrmm")]
            public static extern void Dtrmm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, double alpha, double* A,
                int lda, double* B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_dtrsm")]
            public static extern void Dtrsm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, double alpha, double* A,
                int lda, double* B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cgemm")]
            public static extern void Cgemm(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int M, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda,
                System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cgemm3m")]
            public static extern void Cgemm3m(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int M, int N, int K, System.IntPtr alpha, System.IntPtr A,
                int lda, System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cgemmt")]
            public static extern void Cgemmt(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int N, int K, System.IntPtr alpha, System.IntPtr A,
                int lda, System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_csymm")]
            public static extern void Csymm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, int M, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B,
                int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_csyrk")]
            public static extern void Csyrk(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda,
                System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_csyr2k")]
            public static extern void Csyr2k(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda,
                System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ctrmm")]
            public static extern void Ctrmm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, System.IntPtr alpha,
                System.IntPtr A, int lda, System.IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ctrsm")]
            public static extern void Ctrsm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, System.IntPtr alpha,
                System.IntPtr A, int lda, System.IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zgemm")]
            public static extern void Zgemm(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int M, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda,
                System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zgemm3m")]
            public static extern void Zgemm3m(BLAS.LAYOUT Layout, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int M, int N, int K, System.IntPtr alpha, System.IntPtr A,
                int lda, System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zgemmt")]
            public static extern void Zgemmt(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.TRANSPOSE TransB, int N, int K, System.IntPtr alpha, System.IntPtr A,
                int lda, System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zsymm")]
            public static extern void Zsymm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, int M, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B,
                int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zsyrk")]
            public static extern void Zsyrk(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda,
                System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zsyr2k")]
            public static extern void Zsyr2k(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda,
                System.IntPtr B, int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ztrmm")]
            public static extern void Ztrmm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, System.IntPtr alpha,
                System.IntPtr A, int lda, System.IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_ztrsm")]
            public static extern void Ztrsm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, BLAS.TRANSPOSE TransA, BLAS.DIAG Diag, int M, int N, System.IntPtr alpha,
                System.IntPtr A, int lda, System.IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_chemm")]
            public static extern void Chemm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, int M, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B,
                int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cherk")]
            public static extern void Cherk(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, float alpha, System.IntPtr A, int lda, float beta,
                System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_cher2k")]
            public static extern void Cher2k(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda,
                System.IntPtr B, int ldb, float beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zhemm")]
            public static extern void Zhemm(BLAS.LAYOUT Layout, BLAS.SIDE Side, BLAS.UPLO Uplo, int M, int N, System.IntPtr alpha, System.IntPtr A, int lda, System.IntPtr B,
                int ldb, System.IntPtr beta, System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zherk")]
            public static extern void Zherk(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, double alpha, System.IntPtr A, int lda, double beta,
                System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "cblas_zher2k")]
            public static extern void Zher2k(BLAS.LAYOUT Layout, BLAS.UPLO Uplo, BLAS.TRANSPOSE Trans, int N, int K, System.IntPtr alpha, System.IntPtr A, int lda,
                System.IntPtr B, int ldb, double beta, System.IntPtr C, int ldc);
        }
    }
}