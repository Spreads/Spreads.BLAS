﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System.Runtime.InteropServices;
using System.Security;
using Spreads.DataTypes;

// ReSharper disable InconsistentNaming

namespace Spreads.Native
{
    public static unsafe partial class MKL
    {
        public static class LAPACKE
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlamch")]
            public static extern double Dlamch(sbyte cmach);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlamch_work")]
            public static extern double DlamchWork(sbyte cmach);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlange")]
            public static extern double Dlange(BLAS.LAYOUT matrixLayout, sbyte norm, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlange_work")]
            public static extern double DlangeWork(BLAS.LAYOUT matrixLayout, sbyte norm, int m, int n, double* a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlansy")]
            public static extern double Dlansy(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlansy_work")]
            public static extern double DlansyWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, double* a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlantr")]
            public static extern double Dlantr(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlantr_work")]
            public static extern double DlantrWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, double* a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlapy2")]
            public static extern double Dlapy2(double x, double y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlapy2_work")]
            public static extern double Dlapy2Work(double x, double y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlapy3")]
            public static extern double Dlapy3(double x, double y, double z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlapy3_work")]
            public static extern double Dlapy3Work(double x, double y, double z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlange")]
            public static extern double Zlange(BLAS.LAYOUT matrixLayout, sbyte norm, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlange_work")]
            public static extern double ZlangeWork(BLAS.LAYOUT matrixLayout, sbyte norm, int m, int n, System.IntPtr a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlanhe")]
            public static extern double Zlanhe(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlanhe_work")]
            public static extern double ZlanheWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, System.IntPtr a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlarcm")]
            public static extern int Zlarcm(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, System.IntPtr b, int ldb, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlarcm_work")]
            public static extern int ZlarcmWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, System.IntPtr b, int ldb, System.IntPtr c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlacrm")]
            public static extern int Zlacrm(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, double* b, int ldb, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlacrm_work")]
            public static extern int ZlacrmWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, double* b, int ldb, System.IntPtr c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlansy")]
            public static extern double Zlansy(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlansy_work")]
            public static extern double ZlansyWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, System.IntPtr a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlantr")]
            public static extern double Zlantr(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlantr_work")]
            public static extern double ZlantrWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, System.IntPtr a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clange")]
            public static extern float Clange(BLAS.LAYOUT matrixLayout, sbyte norm, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clange_work")]
            public static extern float ClangeWork(BLAS.LAYOUT matrixLayout, sbyte norm, int m, int n, System.IntPtr a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clanhe")]
            public static extern float Clanhe(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clanhe_work")]
            public static extern float ClanheWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, System.IntPtr a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clarcm")]
            public static extern int Clarcm(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, System.IntPtr b, int ldb, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clarcm_work")]
            public static extern int ClarcmWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, System.IntPtr b, int ldb, System.IntPtr c, int ldc, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clacrm")]
            public static extern int Clacrm(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, float* b, int ldb, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clacrm_work")]
            public static extern int ClacrmWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, float* b, int ldb, System.IntPtr c, int ldc, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clansy")]
            public static extern float Clansy(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clansy_work")]
            public static extern float ClansyWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, System.IntPtr a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clantr")]
            public static extern float Clantr(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clantr_work")]
            public static extern float ClantrWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, System.IntPtr a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slamch")]
            public static extern float Slamch(sbyte cmach);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slamch_work")]
            public static extern float SlamchWork(sbyte cmach);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slange")]
            public static extern float Slange(BLAS.LAYOUT matrixLayout, sbyte norm, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slange_work")]
            public static extern float SlangeWork(BLAS.LAYOUT matrixLayout, sbyte norm, int m, int n, float* a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slansy")]
            public static extern float Slansy(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slansy_work")]
            public static extern float SlansyWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, float* a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slantr")]
            public static extern float Slantr(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slantr_work")]
            public static extern float SlantrWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, float* a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slapy2")]
            public static extern float Slapy2(float x, float y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slapy2_work")]
            public static extern float Slapy2Work(float x, float y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slapy3")]
            public static extern float Slapy3(float x, float y, float z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slapy3_work")]
            public static extern float Slapy3Work(float x, float y, float z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cbbcsd")]
            public static extern int Cbbcsd(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, float* theta,
                float* phi, System.IntPtr u1, int ldu1, System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t, System.IntPtr v2t, int ldv2t, float* b11d, float* b11e,
                float* b12d, float* b12e, float* b21d, float* b21e, float* b22d, float* b22e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cbbcsd_work")]
            public static extern int CbbcsdWork(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, float* theta,
                float* phi, System.IntPtr u1, int ldu1, System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t, System.IntPtr v2t, int ldv2t, float* b11d, float* b11e,
                float* b12d, float* b12e, float* b21d, float* b21e, float* b22d, float* b22e, float* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cbdsqr")]
            public static extern int Cbdsqr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, float* d, float* e, System.IntPtr vt, int ldvt,
                System.IntPtr u, int ldu, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cbdsqr_work")]
            public static extern int CbdsqrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, float* d, float* e, System.IntPtr vt, int ldvt,
                System.IntPtr u, int ldu, System.IntPtr c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbbrd")]
            public static extern int Cgbbrd(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, System.IntPtr ab, int ldab, float* d, float* e,
                System.IntPtr q, int ldq, System.IntPtr pt, int ldpt, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbbrd_work")]
            public static extern int CgbbrdWork(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, System.IntPtr ab, int ldab, float* d, float* e,
                System.IntPtr q, int ldq, System.IntPtr pt, int ldpt, System.IntPtr c, int ldc, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbcon")]
            public static extern int Cgbcon(BLAS.LAYOUT matrixLayout, sbyte norm, int n, int kl, int ku, System.IntPtr ab, int ldab, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbcon_work")]
            public static extern int CgbconWork(BLAS.LAYOUT matrixLayout, sbyte norm, int n, int kl, int ku, System.IntPtr ab, int ldab, int* ipiv, float anorm, float* rcond,
                System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbequ")]
            public static extern int Cgbequ(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd,
                float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbequ_work")]
            public static extern int CgbequWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, float* r, float* c, float* rowcnd,
                float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbequb")]
            public static extern int Cgbequb(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd,
                float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbequb_work")]
            public static extern int CgbequbWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, float* r, float* c, float* rowcnd,
                float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbrfs")]
            public static extern int Cgbrfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb,
                int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbrfs_work")]
            public static extern int CgbrfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb,
                int ldafb, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbrfsx")]
            public static extern int Cgbrfsx(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab,
                System.IntPtr afb, int ldafb, int* ipiv, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds,
                float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbrfsx_work")]
            public static extern int CgbrfsxWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab,
                System.IntPtr afb, int ldafb, int* ipiv, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds,
                float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbsv")]
            public static extern int Cgbsv(BLAS.LAYOUT matrixLayout, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbsv_work")]
            public static extern int CgbsvWork(BLAS.LAYOUT matrixLayout, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbsvx")]
            public static extern int Cgbsvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb,
                int ldafb, int* ipiv, sbyte* equed, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, float* rpivot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbsvx_work")]
            public static extern int CgbsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab,
                System.IntPtr afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr,
                float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbsvxx")]
            public static extern int Cgbsvxx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb,
                int ldafb, int* ipiv, sbyte* equed, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr,
                int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbsvxx_work")]
            public static extern int CgbsvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab,
                System.IntPtr afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* rpvgrw,
                float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbtrf")]
            public static extern int Cgbtrf(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbtrf_work")]
            public static extern int CgbtrfWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbtrs")]
            public static extern int Cgbtrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, int* ipiv, System.IntPtr b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgbtrs_work")]
            public static extern int CgbtrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, int* ipiv, System.IntPtr b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgebak")]
            public static extern int Cgebak(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* scale, int m, System.IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgebak_work")]
            public static extern int CgebakWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* scale, int m, System.IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgebal")]
            public static extern int Cgebal(BLAS.LAYOUT matrixLayout, sbyte job, int n, System.IntPtr a, int lda, int* ilo, int* ihi, float* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgebal_work")]
            public static extern int CgebalWork(BLAS.LAYOUT matrixLayout, sbyte job, int n, System.IntPtr a, int lda, int* ilo, int* ihi, float* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgebrd")]
            public static extern int Cgebrd(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, float* d, float* e, System.IntPtr tauq, System.IntPtr taup);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgebrd_work")]
            public static extern int CgebrdWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, float* d, float* e, System.IntPtr tauq, System.IntPtr taup,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgecon")]
            public static extern int Cgecon(BLAS.LAYOUT matrixLayout, sbyte norm, int n, System.IntPtr a, int lda, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgecon_work")]
            public static extern int CgeconWork(BLAS.LAYOUT matrixLayout, sbyte norm, int n, System.IntPtr a, int lda, float anorm, float* rcond, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeequ")]
            public static extern int Cgeequ(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeequ_work")]
            public static extern int CgeequWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeequb")]
            public static extern int Cgeequb(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeequb_work")]
            public static extern int CgeequbWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgees")]
            public static extern int Cgees(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, int n, System.IntPtr a, int lda, int* sdim, System.IntPtr w,
                System.IntPtr vs, int ldvs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgees_work")]
            public static extern int CgeesWork(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, int n, System.IntPtr a, int lda, int* sdim, System.IntPtr w,
                System.IntPtr vs, int ldvs, System.IntPtr work, int lwork, float* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeesx")]
            public static extern int Cgeesx(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, sbyte sense, int n, System.IntPtr a, int lda, int* sdim,
                System.IntPtr w, System.IntPtr vs, int ldvs, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeesx_work")]
            public static extern int CgeesxWork(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, sbyte sense, int n, System.IntPtr a, int lda, int* sdim,
                System.IntPtr w, System.IntPtr vs, int ldvs, float* rconde, float* rcondv, System.IntPtr work, int lwork, float* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeev")]
            public static extern int Cgeev(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr w, System.IntPtr vl, int ldvl,
                System.IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeev_work")]
            public static extern int CgeevWork(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr w, System.IntPtr vl, int ldvl,
                System.IntPtr vr, int ldvr, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeevx")]
            public static extern int Cgeevx(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, System.IntPtr a, int lda, System.IntPtr w,
                System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int* ilo, int* ihi, float* scale, float* abnrm, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeevx_work")]
            public static extern int CgeevxWork(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, System.IntPtr a, int lda, System.IntPtr w,
                System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int* ilo, int* ihi, float* scale, float* abnrm, float* rconde, float* rcondv, System.IntPtr work, int lwork,
                float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgehrd")]
            public static extern int Cgehrd(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgehrd_work")]
            public static extern int CgehrdWork(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgejsv")]
            public static extern int Cgejsv(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, System.IntPtr a,
                int lda, float* sva, System.IntPtr u, int ldu, System.IntPtr v, int ldv, float* stat, int* istat);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgejsv_work")]
            public static extern int CgejsvWork(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, System.IntPtr a,
                int lda, float* sva, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr cwork, int lwork, float* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgelq2")]
            public static extern int Cgelq2(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgelq2_work")]
            public static extern int Cgelq2Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgelqf")]
            public static extern int Cgelqf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgelqf_work")]
            public static extern int CgelqfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgels")]
            public static extern int Cgels(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgels_work")]
            public static extern int CgelsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgelsd")]
            public static extern int Cgelsd(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* s, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgelsd_work")]
            public static extern int CgelsdWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* s, float rcond,
                int* rank, System.IntPtr work, int lwork, float* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgelss")]
            public static extern int Cgelss(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* s, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgelss_work")]
            public static extern int CgelssWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* s, float rcond,
                int* rank, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgelsy")]
            public static extern int Cgelsy(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* jpvt, float rcond,
                int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgelsy_work")]
            public static extern int CgelsyWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* jpvt, float rcond,
                int* rank, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgemqrt")]
            public static extern int Cgemqrt(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, System.IntPtr v, int ldv, System.IntPtr t,
                int ldt, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgemqrt_work")]
            public static extern int CgemqrtWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, System.IntPtr v, int ldv, System.IntPtr t,
                int ldt, System.IntPtr c, int ldc, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeqlf")]
            public static extern int Cgeqlf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeqlf_work")]
            public static extern int CgeqlfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeqp3")]
            public static extern int Cgeqp3(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* jpvt, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeqp3_work")]
            public static extern int Cgeqp3Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* jpvt, System.IntPtr tau, System.IntPtr work, int lwork,
                float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeqpf")]
            public static extern int Cgeqpf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* jpvt, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeqpf_work")]
            public static extern int CgeqpfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* jpvt, System.IntPtr tau, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeqr2")]
            public static extern int Cgeqr2(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeqr2_work")]
            public static extern int Cgeqr2Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeqrf")]
            public static extern int Cgeqrf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeqrf_work")]
            public static extern int CgeqrfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeqrfp")]
            public static extern int Cgeqrfp(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeqrfp_work")]
            public static extern int CgeqrfpWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeqrt")]
            public static extern int Cgeqrt(BLAS.LAYOUT matrixLayout, int m, int n, int nb, System.IntPtr a, int lda, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeqrt2")]
            public static extern int Cgeqrt2(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeqrt2_work")]
            public static extern int Cgeqrt2Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeqrt3")]
            public static extern int Cgeqrt3(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeqrt3_work")]
            public static extern int Cgeqrt3Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeqrt_work")]
            public static extern int CgeqrtWork(BLAS.LAYOUT matrixLayout, int m, int n, int nb, System.IntPtr a, int lda, System.IntPtr t, int ldt, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgerfs")]
            public static extern int Cgerfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgerfs_work")]
            public static extern int CgerfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgerfsx")]
            public static extern int Cgerfsx(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                int* ipiv, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm,
                float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgerfsx_work")]
            public static extern int CgerfsxWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                int* ipiv, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm,
                float* err_bnds_comp, int nparams, float* @params, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgerqf")]
            public static extern int Cgerqf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgerqf_work")]
            public static extern int CgerqfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgesdd")]
            public static extern int Cgesdd(BLAS.LAYOUT matrixLayout, sbyte jobz, int m, int n, System.IntPtr a, int lda, float* s, System.IntPtr u, int ldu, System.IntPtr vt,
                int ldvt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgesdd_work")]
            public static extern int CgesddWork(BLAS.LAYOUT matrixLayout, sbyte jobz, int m, int n, System.IntPtr a, int lda, float* s, System.IntPtr u, int ldu, System.IntPtr vt,
                int ldvt, System.IntPtr work, int lwork, float* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgesv")]
            public static extern int Cgesv(BLAS.LAYOUT matrixLayout, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgesv_work")]
            public static extern int CgesvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgesvd")]
            public static extern int Cgesvd(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, System.IntPtr a, int lda, float* s, System.IntPtr u, int ldu,
                System.IntPtr vt, int ldvt, float* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgesvd_work")]
            public static extern int CgesvdWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, System.IntPtr a, int lda, float* s, System.IntPtr u, int ldu,
                System.IntPtr vt, int ldvt, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgesvdx")]
            public static extern int Cgesvdx(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, System.IntPtr a, int lda, float vl, float vu, int il,
                int iu, int* ns, float* s, System.IntPtr u, int ldu, System.IntPtr vt, int ldvt, int* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgesvdx_work")]
            public static extern int CgesvdxWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, System.IntPtr a, int lda, float vl, float vu, int il,
                int iu, int* ns, float* s, System.IntPtr u, int ldu, System.IntPtr vt, int ldvt, System.IntPtr work, int lwork, float* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgesvj")]
            public static extern int Cgesvj(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, System.IntPtr a, int lda, float* sva, int mv,
                System.IntPtr v, int ldv, float* stat);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgesvj_work")]
            public static extern int CgesvjWork(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, System.IntPtr a, int lda, float* sva, int mv,
                System.IntPtr v, int ldv, System.IntPtr cwork, int lwork, float* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgesvx")]
            public static extern int Cgesvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                int* ipiv, sbyte* equed, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, float* rpivot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgesvx_work")]
            public static extern int CgesvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                int* ipiv, sbyte* equed, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, System.IntPtr work,
                float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgesvxx")]
            public static extern int Cgesvxx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                int* ipiv, sbyte* equed, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds,
                float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgesvxx_work")]
            public static extern int CgesvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                int* ipiv, sbyte* equed, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds,
                float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgetf2")]
            public static extern int Cgetf2(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgetf2_work")]
            public static extern int Cgetf2Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgetrf")]
            public static extern int Cgetrf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgetrf2")]
            public static extern int Cgetrf2(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgetrf2_work")]
            public static extern int Cgetrf2Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgetrf_work")]
            public static extern int CgetrfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgetri")]
            public static extern int Cgetri(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgetri_work")]
            public static extern int CgetriWork(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgetrs")]
            public static extern int Cgetrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgetrs_work")]
            public static extern int CgetrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggbak")]
            public static extern int Cggbak(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* lscale, float* rscale, int m, System.IntPtr v,
                int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggbak_work")]
            public static extern int CggbakWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* lscale, float* rscale, int m, System.IntPtr v,
                int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggbal")]
            public static extern int Cggbal(BLAS.LAYOUT matrixLayout, sbyte job, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* ilo, int* ihi, float* lscale,
                float* rscale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggbal_work")]
            public static extern int CggbalWork(BLAS.LAYOUT matrixLayout, sbyte job, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* ilo, int* ihi, float* lscale,
                float* rscale, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgges")]
            public static extern int Cgges(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, System.IntPtr a, int lda, System.IntPtr b,
                int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgges3")]
            public static extern int Cgges3(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, System.IntPtr a, int lda,
                System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgges3_work")]
            public static extern int Cgges3Work(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, System.IntPtr a, int lda,
                System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr, System.IntPtr work,
                int lwork, float* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgges_work")]
            public static extern int CggesWork(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, System.IntPtr a, int lda,
                System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr, System.IntPtr work,
                int lwork, float* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggesx")]
            public static extern int Cggesx(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, sbyte sense, int n, System.IntPtr a, int lda,
                System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr, float* rconde,
                float* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggesx_work")]
            public static extern int CggesxWork(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, sbyte sense, int n, System.IntPtr a,
                int lda, System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr, float* rconde,
                float* rcondv, System.IntPtr work, int lwork, float* rwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggev")]
            public static extern int Cggev(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha,
                System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggev3")]
            public static extern int Cggev3(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha,
                System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggev3_work")]
            public static extern int Cggev3Work(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha,
                System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggev_work")]
            public static extern int CggevWork(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha,
                System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggevx")]
            public static extern int Cggevx(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, System.IntPtr a, int lda, System.IntPtr b,
                int ldb, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int* ilo, int* ihi, float* lscale, float* rscale,
                float* abnrm, float* bbnrm, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggevx_work")]
            public static extern int CggevxWork(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, System.IntPtr a, int lda, System.IntPtr b,
                int ldb, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int* ilo, int* ihi, float* lscale, float* rscale,
                float* abnrm, float* bbnrm, float* rconde, float* rcondv, System.IntPtr work, int lwork, float* rwork, int* iwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggglm")]
            public static extern int Cggglm(BLAS.LAYOUT matrixLayout, int n, int m, int p, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr d, System.IntPtr x,
                System.IntPtr y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggglm_work")]
            public static extern int CggglmWork(BLAS.LAYOUT matrixLayout, int n, int m, int p, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr d, System.IntPtr x,
                System.IntPtr y, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgghd3")]
            public static extern int Cgghd3(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr q, int ldq, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgghd3_work")]
            public static extern int Cgghd3Work(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr q, int ldq, System.IntPtr z, int ldz, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgghrd")]
            public static extern int Cgghrd(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr q, int ldq, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgghrd_work")]
            public static extern int CgghrdWork(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr q, int ldq, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgglse")]
            public static extern int Cgglse(BLAS.LAYOUT matrixLayout, int m, int n, int p, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr c, System.IntPtr d,
                System.IntPtr x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgglse_work")]
            public static extern int CgglseWork(BLAS.LAYOUT matrixLayout, int m, int n, int p, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr c, System.IntPtr d,
                System.IntPtr x, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggqrf")]
            public static extern int Cggqrf(BLAS.LAYOUT matrixLayout, int n, int m, int p, System.IntPtr a, int lda, System.IntPtr taua, System.IntPtr b, int ldb,
                System.IntPtr taub);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggqrf_work")]
            public static extern int CggqrfWork(BLAS.LAYOUT matrixLayout, int n, int m, int p, System.IntPtr a, int lda, System.IntPtr taua, System.IntPtr b, int ldb,
                System.IntPtr taub, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggrqf")]
            public static extern int Cggrqf(BLAS.LAYOUT matrixLayout, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr taua, System.IntPtr b, int ldb,
                System.IntPtr taub);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggrqf_work")]
            public static extern int CggrqfWork(BLAS.LAYOUT matrixLayout, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr taua, System.IntPtr b, int ldb,
                System.IntPtr taub, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggsvd")]
            public static extern int Cggsvd(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, System.IntPtr a, int lda,
                System.IntPtr b, int ldb, float* alpha, float* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggsvd3")]
            public static extern int Cggsvd3(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, System.IntPtr a, int lda,
                System.IntPtr b, int ldb, float* alpha, float* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggsvd3_work")]
            public static extern int Cggsvd3Work(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, System.IntPtr a, int lda,
                System.IntPtr b, int ldb, float* alpha, float* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, System.IntPtr work, int lwork,
                float* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggsvd_work")]
            public static extern int CggsvdWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, System.IntPtr a, int lda,
                System.IntPtr b, int ldb, float* alpha, float* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, System.IntPtr work, float* rwork,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggsvp")]
            public static extern int Cggsvp(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                float tola, float tolb, int* k, int* l, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggsvp3")]
            public static extern int Cggsvp3(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                float tola, float tolb, int* k, int* l, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggsvp3_work")]
            public static extern int Cggsvp3Work(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr b,
                int ldb, float tola, float tolb, int* k, int* l, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, int* iwork, float* rwork,
                System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cggsvp_work")]
            public static extern int CggsvpWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr b,
                int ldb, float tola, float tolb, int* k, int* l, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, int* iwork, float* rwork,
                System.IntPtr tau, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgtcon")]
            public static extern int Cgtcon(sbyte norm, int n, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgtcon_work")]
            public static extern int CgtconWork(sbyte norm, int n, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2, int* ipiv, float anorm, float* rcond,
                System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgtrfs")]
            public static extern int Cgtrfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr dlf,
                System.IntPtr df, System.IntPtr duf, System.IntPtr du2, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgtrfs_work")]
            public static extern int CgtrfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr dlf,
                System.IntPtr df, System.IntPtr duf, System.IntPtr du2, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work,
                float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgtsv")]
            public static extern int Cgtsv(BLAS.LAYOUT matrixLayout, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgtsv_work")]
            public static extern int CgtsvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgtsvx")]
            public static extern int Cgtsvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du,
                System.IntPtr dlf, System.IntPtr df, System.IntPtr duf, System.IntPtr du2, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr,
                float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgtsvx_work")]
            public static extern int CgtsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du,
                System.IntPtr dlf, System.IntPtr df, System.IntPtr duf, System.IntPtr du2, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr,
                float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgttrf")]
            public static extern int Cgttrf(int n, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgttrf_work")]
            public static extern int CgttrfWork(int n, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgttrs")]
            public static extern int Cgttrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2,
                int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgttrs_work")]
            public static extern int CgttrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2,
                int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbev")]
            public static extern int Chbev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbev_work")]
            public static extern int ChbevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* w, System.IntPtr z, int ldz,
                System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbevd")]
            public static extern int Chbevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbevd_work")]
            public static extern int ChbevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* w, System.IntPtr z, int ldz,
                System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbevx")]
            public static extern int Chbevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, System.IntPtr q, int ldq,
                float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbevx_work")]
            public static extern int ChbevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, System.IntPtr q, int ldq,
                float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, System.IntPtr work, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbgst")]
            public static extern int Chbgst(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb,
                System.IntPtr x, int ldx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbgst_work")]
            public static extern int ChbgstWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb,
                System.IntPtr x, int ldx, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbgv")]
            public static extern int Chbgv(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb,
                float* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbgv_work")]
            public static extern int ChbgvWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb,
                float* w, System.IntPtr z, int ldz, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbgvd")]
            public static extern int Chbgvd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb,
                float* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbgvd_work")]
            public static extern int ChbgvdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb,
                float* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbgvx")]
            public static extern int Chbgvx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb,
                int ldbb, System.IntPtr q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbgvx_work")]
            public static extern int ChbgvxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb,
                int ldbb, System.IntPtr q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, System.IntPtr work, float* rwork,
                int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbtrd")]
            public static extern int Chbtrd(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* d, float* e, System.IntPtr q,
                int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbtrd_work")]
            public static extern int ChbtrdWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* d, float* e, System.IntPtr q,
                int ldq, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_checon")]
            public static extern int Checon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_checon_work")]
            public static extern int CheconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, float anorm, float* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cheequb")]
            public static extern int Cheequb(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cheequb_work")]
            public static extern int CheequbWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, float* s, float* scond, float* amax, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cheev")]
            public static extern int Cheev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cheev_work")]
            public static extern int CheevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, float* w, System.IntPtr work, int lwork,
                float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cheevd")]
            public static extern int Cheevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cheevd_work")]
            public static extern int CheevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, float* w, System.IntPtr work, int lwork,
                float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cheevr")]
            public static extern int Cheevr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, System.IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cheevr_work")]
            public static extern int CheevrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, System.IntPtr z, int ldz, int* isuppz, System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cheevx")]
            public static extern int Cheevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cheevx_work")]
            public static extern int CheevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chegst")]
            public static extern int Chegst(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chegst_work")]
            public static extern int ChegstWork(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chegv")]
            public static extern int Chegv(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chegv_work")]
            public static extern int ChegvWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* w,
                System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chegvd")]
            public static extern int Chegvd(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chegvd_work")]
            public static extern int ChegvdWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* w,
                System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chegvx")]
            public static extern int Chegvx(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chegvx_work")]
            public static extern int ChegvxWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cherfs")]
            public static extern int Cherfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cherfs_work")]
            public static extern int CherfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cherfsx")]
            public static extern int Cherfsx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams,
                float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cherfsx_work")]
            public static extern int CherfsxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                int* ipiv, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp,
                int nparams, float* @params, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chesv")]
            public static extern int Chesv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chesv_work")]
            public static extern int ChesvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chesvx")]
            public static extern int Chesvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chesvx_work")]
            public static extern int ChesvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chesvxx")]
            public static extern int Chesvxx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                sbyte* equed, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm,
                float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chesvxx_work")]
            public static extern int ChesvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                sbyte* equed, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm,
                float* err_bnds_comp, int nparams, float* @params, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cheswapr")]
            public static extern int Cheswapr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cheswapr_work")]
            public static extern int CheswaprWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrd")]
            public static extern int Chetrd(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, float* d, float* e, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrd_work")]
            public static extern int ChetrdWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, float* d, float* e, System.IntPtr tau, System.IntPtr work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrf")]
            public static extern int Chetrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrf_rook")]
            public static extern int ChetrfRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrf_rook_work")]
            public static extern int ChetrfRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrf_work")]
            public static extern int ChetrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetri")]
            public static extern int Chetri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetri2")]
            public static extern int Chetri2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetri2_work")]
            public static extern int Chetri2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetri2x")]
            public static extern int Chetri2x(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetri2x_work")]
            public static extern int Chetri2xWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetri_work")]
            public static extern int ChetriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrs")]
            public static extern int Chetrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrs2")]
            public static extern int Chetrs2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrs2_work")]
            public static extern int Chetrs2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrs_rook")]
            public static extern int ChetrsRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrs_rook_work")]
            public static extern int ChetrsRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrs_work")]
            public static extern int ChetrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chfrk")]
            public static extern int Chfrk(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, float alpha, System.IntPtr a, int lda, float beta,
                System.IntPtr c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chfrk_work")]
            public static extern int ChfrkWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, float alpha, System.IntPtr a, int lda,
                float beta, System.IntPtr c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chgeqz")]
            public static extern int Chgeqz(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr h, int ldh, System.IntPtr t,
                int ldt, System.IntPtr alpha, System.IntPtr beta, System.IntPtr q, int ldq, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chgeqz_work")]
            public static extern int ChgeqzWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr h, int ldh, System.IntPtr t,
                int ldt, System.IntPtr alpha, System.IntPtr beta, System.IntPtr q, int ldq, System.IntPtr z, int ldz, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chpcon")]
            public static extern int Chpcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chpcon_work")]
            public static extern int ChpconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, float anorm, float* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chpev")]
            public static extern int Chpev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, float* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chpev_work")]
            public static extern int ChpevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, float* w, System.IntPtr z, int ldz, System.IntPtr work,
                float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chpevd")]
            public static extern int Chpevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, float* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chpevd_work")]
            public static extern int ChpevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, float* w, System.IntPtr z, int ldz, System.IntPtr work,
                int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chpevx")]
            public static extern int Chpevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr ap, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chpevx_work")]
            public static extern int ChpevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr ap, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, System.IntPtr z, int ldz, System.IntPtr work, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chpgst")]
            public static extern int Chpgst(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chpgst_work")]
            public static extern int ChpgstWork(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chpgv")]
            public static extern int Chpgv(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, float* w, System.IntPtr z,
                int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chpgv_work")]
            public static extern int ChpgvWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, float* w, System.IntPtr z,
                int ldz, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chpgvd")]
            public static extern int Chpgvd(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, float* w, System.IntPtr z,
                int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chpgvd_work")]
            public static extern int ChpgvdWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, float* w, System.IntPtr z,
                int ldz, System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chpgvx")]
            public static extern int Chpgvx(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, float vl, float vu,
                int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chpgvx_work")]
            public static extern int ChpgvxWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, float vl,
                float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, System.IntPtr work, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chprfs")]
            public static extern int Chprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chprfs_work")]
            public static extern int ChprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chpsv")]
            public static extern int Chpsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chpsv_work")]
            public static extern int ChpsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chpsvx")]
            public static extern int Chpsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chpsvx_work")]
            public static extern int ChpsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chptrd")]
            public static extern int Chptrd(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, float* d, float* e, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chptrd_work")]
            public static extern int ChptrdWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, float* d, float* e, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chptrf")]
            public static extern int Chptrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chptrf_work")]
            public static extern int ChptrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chptri")]
            public static extern int Chptri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chptri_work")]
            public static extern int ChptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chptrs")]
            public static extern int Chptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chptrs_work")]
            public static extern int ChptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chsein")]
            public static extern int Chsein(BLAS.LAYOUT matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, System.IntPtr h, int ldh, System.IntPtr w,
                System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int mm, int* m, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chsein_work")]
            public static extern int ChseinWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, System.IntPtr h, int ldh, System.IntPtr w,
                System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int mm, int* m, System.IntPtr work, float* rwork, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chseqr")]
            public static extern int Chseqr(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, System.IntPtr h, int ldh, System.IntPtr w, System.IntPtr z,
                int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chseqr_work")]
            public static extern int ChseqrWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, System.IntPtr h, int ldh, System.IntPtr w,
                System.IntPtr z, int ldz, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clacgv")]
            public static extern int Clacgv(int n, System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clacgv_work")]
            public static extern int ClacgvWork(int n, System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clacn2")]
            public static extern int Clacn2(int n, System.IntPtr v, System.IntPtr x, float* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clacn2_work")]
            public static extern int Clacn2Work(int n, System.IntPtr v, System.IntPtr x, float* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clacp2")]
            public static extern int Clacp2(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, float* a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clacp2_work")]
            public static extern int Clacp2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, float* a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clacpy")]
            public static extern int Clacpy(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clacpy_work")]
            public static extern int ClacpyWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clag2z")]
            public static extern int Clag2z(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr sa, int ldsa, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clag2z_work")]
            public static extern int Clag2zWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr sa, int ldsa, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clagge")]
            public static extern int Clagge(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, float* d, System.IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clagge_work")]
            public static extern int ClaggeWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, float* d, System.IntPtr a, int lda, int* iseed, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_claghe")]
            public static extern int Claghe(BLAS.LAYOUT matrixLayout, int n, int k, float* d, System.IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_claghe_work")]
            public static extern int ClagheWork(BLAS.LAYOUT matrixLayout, int n, int k, float* d, System.IntPtr a, int lda, int* iseed, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clagsy")]
            public static extern int Clagsy(BLAS.LAYOUT matrixLayout, int n, int k, float* d, System.IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clagsy_work")]
            public static extern int ClagsyWork(BLAS.LAYOUT matrixLayout, int n, int k, float* d, System.IntPtr a, int lda, int* iseed, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clapmr")]
            public static extern int Clapmr(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, System.IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clapmr_work")]
            public static extern int ClapmrWork(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, System.IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clapmt")]
            public static extern int Clapmt(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, System.IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clapmt_work")]
            public static extern int ClapmtWork(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, System.IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clarfb")]
            public static extern int Clarfb(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, System.IntPtr v, int ldv,
                System.IntPtr t, int ldt, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clarfb_work")]
            public static extern int ClarfbWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, System.IntPtr v, int ldv,
                System.IntPtr t, int ldt, System.IntPtr c, int ldc, System.IntPtr work, int ldwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clarfg")]
            public static extern int Clarfg(int n, System.IntPtr alpha, System.IntPtr x, int incx, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clarfg_work")]
            public static extern int ClarfgWork(int n, System.IntPtr alpha, System.IntPtr x, int incx, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clarft")]
            public static extern int Clarft(BLAS.LAYOUT matrixLayout, sbyte direct, sbyte storev, int n, int k, System.IntPtr v, int ldv, System.IntPtr tau, System.IntPtr t,
                int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clarft_work")]
            public static extern int ClarftWork(BLAS.LAYOUT matrixLayout, sbyte direct, sbyte storev, int n, int k, System.IntPtr v, int ldv, System.IntPtr tau, System.IntPtr t,
                int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clarfx")]
            public static extern int Clarfx(BLAS.LAYOUT matrixLayout, sbyte side, int m, int n, System.IntPtr v, ComplexFloat tau, System.IntPtr c, int ldc, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clarfx_work")]
            public static extern int ClarfxWork(BLAS.LAYOUT matrixLayout, sbyte side, int m, int n, System.IntPtr v, ComplexFloat tau, System.IntPtr c, int ldc,
                System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clarnv")]
            public static extern int Clarnv(int idist, int* iseed, int n, System.IntPtr x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clarnv_work")]
            public static extern int ClarnvWork(int idist, int* iseed, int n, System.IntPtr x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clascl")]
            public static extern int Clascl(BLAS.LAYOUT matrixLayout, sbyte type, int kl, int ku, float cfrom, float cto, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clascl_work")]
            public static extern int ClasclWork(BLAS.LAYOUT matrixLayout, sbyte type, int kl, int ku, float cfrom, float cto, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_claset")]
            public static extern int Claset(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, ComplexFloat alpha, ComplexFloat beta, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_claset_work")]
            public static extern int ClasetWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, ComplexFloat alpha, ComplexFloat beta, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_claswp")]
            public static extern int Claswp(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_claswp_work")]
            public static extern int ClaswpWork(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clatms")]
            public static extern int Clatms(BLAS.LAYOUT matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, float* d, int mode, float cond, float dmax, int kl, int ku,
                sbyte pack, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clatms_work")]
            public static extern int ClatmsWork(BLAS.LAYOUT matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, float* d, int mode, float cond, float dmax, int kl,
                int ku, sbyte pack, System.IntPtr a, int lda, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clauum")]
            public static extern int Clauum(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_clauum_work")]
            public static extern int ClauumWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpbcon")]
            public static extern int Cpbcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpbcon_work")]
            public static extern int CpbconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float anorm, float* rcond, System.IntPtr work,
                float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpbequ")]
            public static extern int Cpbequ(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpbequ_work")]
            public static extern int CpbequWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpbrfs")]
            public static extern int Cpbrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpbrfs_work")]
            public static extern int CpbrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpbstf")]
            public static extern int Cpbstf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kb, System.IntPtr bb, int ldbb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpbstf_work")]
            public static extern int CpbstfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kb, System.IntPtr bb, int ldbb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpbsv")]
            public static extern int Cpbsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpbsv_work")]
            public static extern int CpbsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpbsvx")]
            public static extern int Cpbsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb,
                sbyte* equed, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpbsvx_work")]
            public static extern int CpbsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb,
                sbyte* equed, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpbtrf")]
            public static extern int Cpbtrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpbtrf_work")]
            public static extern int CpbtrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpbtrs")]
            public static extern int Cpbtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpbtrs_work")]
            public static extern int CpbtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpftrf")]
            public static extern int Cpftrf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpftrf_work")]
            public static extern int CpftrfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpftri")]
            public static extern int Cpftri(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpftri_work")]
            public static extern int CpftriWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpftrs")]
            public static extern int Cpftrs(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, System.IntPtr a, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpftrs_work")]
            public static extern int CpftrsWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, System.IntPtr a, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpocon")]
            public static extern int Cpocon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpocon_work")]
            public static extern int CpoconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, float anorm, float* rcond, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpoequ")]
            public static extern int Cpoequ(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpoequ_work")]
            public static extern int CpoequWork(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpoequb")]
            public static extern int Cpoequb(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpoequb_work")]
            public static extern int CpoequbWork(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cporfs")]
            public static extern int Cporfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, System.IntPtr b, int ldb,
                System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cporfs_work")]
            public static extern int CporfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cporfsx")]
            public static extern int Cporfsx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, float* s,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams,
                float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cporfsx_work")]
            public static extern int CporfsxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, float* s,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams,
                float* @params, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cposv")]
            public static extern int Cposv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cposv_work")]
            public static extern int CposvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cposvx")]
            public static extern int Cposvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, sbyte* equed,
                float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cposvx_work")]
            public static extern int CposvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                sbyte* equed, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cposvxx")]
            public static extern int Cposvxx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, sbyte* equed,
                float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp,
                int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cposvxx_work")]
            public static extern int CposvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                sbyte* equed, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm,
                float* err_bnds_comp, int nparams, float* @params, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpotrf")]
            public static extern int Cpotrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpotrf2")]
            public static extern int Cpotrf2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpotrf2_work")]
            public static extern int Cpotrf2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpotrf_work")]
            public static extern int CpotrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpotri")]
            public static extern int Cpotri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpotri_work")]
            public static extern int CpotriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpotrs")]
            public static extern int Cpotrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpotrs_work")]
            public static extern int CpotrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cppcon")]
            public static extern int Cppcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cppcon_work")]
            public static extern int CppconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, float anorm, float* rcond, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cppequ")]
            public static extern int Cppequ(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cppequ_work")]
            public static extern int CppequWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpprfs")]
            public static extern int Cpprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, System.IntPtr b, int ldb, System.IntPtr x,
                int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpprfs_work")]
            public static extern int CpprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, System.IntPtr b, int ldb,
                System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cppsv")]
            public static extern int Cppsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cppsv_work")]
            public static extern int CppsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cppsvx")]
            public static extern int Cppsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, sbyte* equed, float* s,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cppsvx_work")]
            public static extern int CppsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, sbyte* equed, float* s,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpptrf")]
            public static extern int Cpptrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpptrf_work")]
            public static extern int CpptrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpptri")]
            public static extern int Cpptri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpptri_work")]
            public static extern int CpptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpptrs")]
            public static extern int Cpptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpptrs_work")]
            public static extern int CpptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpstrf")]
            public static extern int Cpstrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* piv, int* rank, float tol);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpstrf_work")]
            public static extern int CpstrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* piv, int* rank, float tol, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cptcon")]
            public static extern int Cptcon(int n, float* d, System.IntPtr e, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cptcon_work")]
            public static extern int CptconWork(int n, float* d, System.IntPtr e, float anorm, float* rcond, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpteqr")]
            public static extern int Cpteqr(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpteqr_work")]
            public static extern int CpteqrWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, System.IntPtr z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cptrfs")]
            public static extern int Cptrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* d, System.IntPtr e, float* df, System.IntPtr ef, System.IntPtr b, int ldb,
                System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cptrfs_work")]
            public static extern int CptrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* d, System.IntPtr e, float* df, System.IntPtr ef, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cptsv")]
            public static extern int Cptsv(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* d, System.IntPtr e, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cptsv_work")]
            public static extern int CptsvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* d, System.IntPtr e, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cptsvx")]
            public static extern int Cptsvx(BLAS.LAYOUT matrixLayout, sbyte fact, int n, int nrhs, float* d, System.IntPtr e, float* df, System.IntPtr ef, System.IntPtr b, int ldb,
                System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cptsvx_work")]
            public static extern int CptsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, int n, int nrhs, float* d, System.IntPtr e, float* df, System.IntPtr ef, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpttrf")]
            public static extern int Cpttrf(int n, float* d, System.IntPtr e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpttrf_work")]
            public static extern int CpttrfWork(int n, float* d, System.IntPtr e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpttrs")]
            public static extern int Cpttrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* d, System.IntPtr e, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cpttrs_work")]
            public static extern int CpttrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* d, System.IntPtr e, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cspcon")]
            public static extern int Cspcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cspcon_work")]
            public static extern int CspconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, float anorm, float* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csprfs")]
            public static extern int Csprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csprfs_work")]
            public static extern int CsprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cspsv")]
            public static extern int Cspsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cspsv_work")]
            public static extern int CspsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cspsvx")]
            public static extern int Cspsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cspsvx_work")]
            public static extern int CspsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csptrf")]
            public static extern int Csptrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csptrf_work")]
            public static extern int CsptrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csptri")]
            public static extern int Csptri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csptri_work")]
            public static extern int CsptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csptrs")]
            public static extern int Csptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csptrs_work")]
            public static extern int CsptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cstedc")]
            public static extern int Cstedc(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cstedc_work")]
            public static extern int CstedcWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, System.IntPtr z, int ldz, System.IntPtr work, int lwork,
                float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cstegr")]
            public static extern int Cstegr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m,
                float* w, System.IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cstegr_work")]
            public static extern int CstegrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol,
                int* m, float* w, System.IntPtr z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cstein")]
            public static extern int Cstein(BLAS.LAYOUT matrixLayout, int n, float* d, float* e, int m, float* w, int* iblock, int* isplit, System.IntPtr z, int ldz, int* ifailv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cstein_work")]
            public static extern int CsteinWork(BLAS.LAYOUT matrixLayout, int n, float* d, float* e, int m, float* w, int* iblock, int* isplit, System.IntPtr z, int ldz,
                float* work, int* iwork, int* ifailv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cstemr")]
            public static extern int Cstemr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* m, float* w,
                System.IntPtr z, int ldz, int nzc, int* isuppz, int* tryrac);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cstemr_work")]
            public static extern int CstemrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* m, float* w,
                System.IntPtr z, int ldz, int nzc, int* isuppz, int* tryrac, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csteqr")]
            public static extern int Csteqr(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csteqr_work")]
            public static extern int CsteqrWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, System.IntPtr z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csycon")]
            public static extern int Csycon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csycon_work")]
            public static extern int CsyconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, float anorm, float* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csyconv")]
            public static extern int Csyconv(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte way, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csyconv_work")]
            public static extern int CsyconvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte way, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csyequb")]
            public static extern int Csyequb(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csyequb_work")]
            public static extern int CsyequbWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, float* s, float* scond, float* amax, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csyr")]
            public static extern int Csyr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, ComplexFloat alpha, System.IntPtr x, int incx, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csyr_work")]
            public static extern int CsyrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, ComplexFloat alpha, System.IntPtr x, int incx, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csyrfs")]
            public static extern int Csyrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csyrfs_work")]
            public static extern int CsyrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csyrfsx")]
            public static extern int Csyrfsx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams,
                float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csyrfsx_work")]
            public static extern int CsyrfsxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                int* ipiv, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp,
                int nparams, float* @params, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csysv")]
            public static extern int Csysv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csysv_rook")]
            public static extern int CsysvRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csysv_rook_work")]
            public static extern int CsysvRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csysv_work")]
            public static extern int CsysvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csysvx")]
            public static extern int Csysvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csysvx_work")]
            public static extern int CsysvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csysvxx")]
            public static extern int Csysvxx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                sbyte* equed, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm,
                float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csysvxx_work")]
            public static extern int CsysvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                sbyte* equed, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm,
                float* err_bnds_comp, int nparams, float* @params, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csyswapr")]
            public static extern int Csyswapr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csyswapr_work")]
            public static extern int CsyswaprWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrf")]
            public static extern int Csytrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrf_rook")]
            public static extern int CsytrfRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrf_rook_work")]
            public static extern int CsytrfRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrf_work")]
            public static extern int CsytrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytri")]
            public static extern int Csytri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytri2")]
            public static extern int Csytri2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytri2_work")]
            public static extern int Csytri2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytri2x")]
            public static extern int Csytri2x(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytri2x_work")]
            public static extern int Csytri2xWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytri_work")]
            public static extern int CsytriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrs")]
            public static extern int Csytrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrs2")]
            public static extern int Csytrs2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrs2_work")]
            public static extern int Csytrs2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrs_rook")]
            public static extern int CsytrsRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrs_rook_work")]
            public static extern int CsytrsRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrs_work")]
            public static extern int CsytrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctbcon")]
            public static extern int Ctbcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, System.IntPtr ab, int ldab, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctbcon_work")]
            public static extern int CtbconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, System.IntPtr ab, int ldab, float* rcond,
                System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctbrfs")]
            public static extern int Ctbrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, System.IntPtr ab, int ldab,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctbrfs_work")]
            public static extern int CtbrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, System.IntPtr ab, int ldab,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctbtrs")]
            public static extern int Ctbtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, System.IntPtr ab, int ldab,
                System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctbtrs_work")]
            public static extern int CtbtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, System.IntPtr ab, int ldab,
                System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctfsm")]
            public static extern int Ctfsm(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, ComplexFloat alpha,
                System.IntPtr a, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctfsm_work")]
            public static extern int CtfsmWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, ComplexFloat alpha,
                System.IntPtr a, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctftri")]
            public static extern int Ctftri(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctftri_work")]
            public static extern int CtftriWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctfttp")]
            public static extern int Ctfttp(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr arf, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctfttp_work")]
            public static extern int CtfttpWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr arf, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctfttr")]
            public static extern int Ctfttr(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr arf, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctfttr_work")]
            public static extern int CtfttrWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr arf, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctgevc")]
            public static extern int Ctgevc(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, System.IntPtr s, int lds, System.IntPtr p, int ldp,
                System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctgevc_work")]
            public static extern int CtgevcWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, System.IntPtr s, int lds, System.IntPtr p, int ldp,
                System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int mm, int* m, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctgexc")]
            public static extern int Ctgexc(BLAS.LAYOUT matrixLayout, int wantq, int wantz, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr q, int ldq,
                System.IntPtr z, int ldz, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctgexc_work")]
            public static extern int CtgexcWork(BLAS.LAYOUT matrixLayout, int wantq, int wantz, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr q, int ldq,
                System.IntPtr z, int ldz, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctgsen")]
            public static extern int Ctgsen(BLAS.LAYOUT matrixLayout, int ijob, int wantq, int wantz, int* select, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr alpha, System.IntPtr beta, System.IntPtr q, int ldq, System.IntPtr z, int ldz, int* m, float* pl, float* pr, float* dif);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctgsen_work")]
            public static extern int CtgsenWork(BLAS.LAYOUT matrixLayout, int ijob, int wantq, int wantz, int* select, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr alpha, System.IntPtr beta, System.IntPtr q, int ldq, System.IntPtr z, int ldz, int* m, float* pl, float* pr, float* dif, System.IntPtr work,
                int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctgsja")]
            public static extern int Ctgsja(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, System.IntPtr a, int lda,
                System.IntPtr b, int ldb, float tola, float tolb, float* alpha, float* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq,
                int* ncycle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctgsja_work")]
            public static extern int CtgsjaWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, System.IntPtr a, int lda,
                System.IntPtr b, int ldb, float tola, float tolb, float* alpha, float* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq,
                System.IntPtr work, int* ncycle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctgsna")]
            public static extern int Ctgsna(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, float* s, float* dif, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctgsna_work")]
            public static extern int CtgsnaWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, float* s, float* dif, int mm, int* m, System.IntPtr work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctgsyl")]
            public static extern int Ctgsyl(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr c,
                int ldc, System.IntPtr d, int ldd, System.IntPtr e, int lde, System.IntPtr f, int ldf, float* scale, float* dif);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctgsyl_work")]
            public static extern int CtgsylWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr c, int ldc, System.IntPtr d, int ldd, System.IntPtr e, int lde, System.IntPtr f, int ldf, float* scale, float* dif, System.IntPtr work, int lwork,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctpcon")]
            public static extern int Ctpcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, System.IntPtr ap, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctpcon_work")]
            public static extern int CtpconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, System.IntPtr ap, float* rcond, System.IntPtr work,
                float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctpmqrt")]
            public static extern int Ctpmqrt(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, System.IntPtr v, int ldv, System.IntPtr t,
                int ldt, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctpmqrt_work")]
            public static extern int CtpmqrtWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, System.IntPtr v, int ldv,
                System.IntPtr t, int ldt, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctpqrt")]
            public static extern int Ctpqrt(BLAS.LAYOUT matrixLayout, int m, int n, int l, int nb, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctpqrt2")]
            public static extern int Ctpqrt2(BLAS.LAYOUT matrixLayout, int m, int n, int l, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctpqrt2_work")]
            public static extern int Ctpqrt2Work(BLAS.LAYOUT matrixLayout, int m, int n, int l, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctpqrt_work")]
            public static extern int CtpqrtWork(BLAS.LAYOUT matrixLayout, int m, int n, int l, int nb, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr t, int ldt,
                System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctprfb")]
            public static extern int Ctprfb(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, System.IntPtr v,
                int ldv, System.IntPtr t, int ldt, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctprfb_work")]
            public static extern int CtprfbWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, System.IntPtr v,
                int ldv, System.IntPtr t, int ldt, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr work, int ldwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctprfs")]
            public static extern int Ctprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb,
                System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctprfs_work")]
            public static extern int CtprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb,
                System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctptri")]
            public static extern int Ctptri(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctptri_work")]
            public static extern int CtptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctptrs")]
            public static extern int Ctptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctptrs_work")]
            public static extern int CtptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctpttf")]
            public static extern int Ctpttf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr ap, System.IntPtr arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctpttf_work")]
            public static extern int CtpttfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr ap, System.IntPtr arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctpttr")]
            public static extern int Ctpttr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctpttr_work")]
            public static extern int CtpttrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrcon")]
            public static extern int Ctrcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, System.IntPtr a, int lda, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrcon_work")]
            public static extern int CtrconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, System.IntPtr a, int lda, float* rcond, System.IntPtr work,
                float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrevc")]
            public static extern int Ctrevc(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, System.IntPtr t, int ldt, System.IntPtr vl, int ldvl,
                System.IntPtr vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrevc_work")]
            public static extern int CtrevcWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, System.IntPtr t, int ldt, System.IntPtr vl, int ldvl,
                System.IntPtr vr, int ldvr, int mm, int* m, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrexc")]
            public static extern int Ctrexc(BLAS.LAYOUT matrixLayout, sbyte compq, int n, System.IntPtr t, int ldt, System.IntPtr q, int ldq, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrexc_work")]
            public static extern int CtrexcWork(BLAS.LAYOUT matrixLayout, sbyte compq, int n, System.IntPtr t, int ldt, System.IntPtr q, int ldq, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrrfs")]
            public static extern int Ctrrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrrfs_work")]
            public static extern int CtrrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrsen")]
            public static extern int Ctrsen(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, int* select, int n, System.IntPtr t, int ldt, System.IntPtr q, int ldq,
                System.IntPtr w, int* m, float* s, float* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrsen_work")]
            public static extern int CtrsenWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, int* select, int n, System.IntPtr t, int ldt, System.IntPtr q, int ldq,
                System.IntPtr w, int* m, float* s, float* sep, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrsna")]
            public static extern int Ctrsna(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, System.IntPtr t, int ldt, System.IntPtr vl, int ldvl,
                System.IntPtr vr, int ldvr, float* s, float* sep, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrsna_work")]
            public static extern int CtrsnaWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, System.IntPtr t, int ldt, System.IntPtr vl, int ldvl,
                System.IntPtr vr, int ldvr, float* s, float* sep, int mm, int* m, System.IntPtr work, int ldwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrsyl")]
            public static extern int Ctrsyl(BLAS.LAYOUT matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr c, int ldc, float* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrsyl_work")]
            public static extern int CtrsylWork(BLAS.LAYOUT matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr c, int ldc, float* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrtri")]
            public static extern int Ctrtri(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrtri_work")]
            public static extern int CtrtriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrtrs")]
            public static extern int Ctrtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrtrs_work")]
            public static extern int CtrtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrttf")]
            public static extern int Ctrttf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrttf_work")]
            public static extern int CtrttfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrttp")]
            public static extern int Ctrttp(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctrttp_work")]
            public static extern int CtrttpWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctzrzf")]
            public static extern int Ctzrzf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ctzrzf_work")]
            public static extern int CtzrzfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunbdb")]
            public static extern int Cunbdb(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, System.IntPtr x11, int ldx11, System.IntPtr x12,
                int ldx12, System.IntPtr x21, int ldx21, System.IntPtr x22, int ldx22, float* theta, float* phi, System.IntPtr taup1, System.IntPtr taup2, System.IntPtr tauq1,
                System.IntPtr tauq2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunbdb_work")]
            public static extern int CunbdbWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, System.IntPtr x11, int ldx11, System.IntPtr x12,
                int ldx12, System.IntPtr x21, int ldx21, System.IntPtr x22, int ldx22, float* theta, float* phi, System.IntPtr taup1, System.IntPtr taup2, System.IntPtr tauq1,
                System.IntPtr tauq2, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cuncsd")]
            public static extern int Cuncsd(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q,
                System.IntPtr x11, int ldx11, System.IntPtr x12, int ldx12, System.IntPtr x21, int ldx21, System.IntPtr x22, int ldx22, float* theta, System.IntPtr u1, int ldu1,
                System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t, System.IntPtr v2t, int ldv2t);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cuncsd2by1")]
            public static extern int Cuncsd2by1(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, System.IntPtr x11, int ldx11,
                System.IntPtr x21, int ldx21, float* theta, System.IntPtr u1, int ldu1, System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cuncsd2by1_work")]
            public static extern int Cuncsd2by1Work(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, System.IntPtr x11, int ldx11,
                System.IntPtr x21, int ldx21, float* theta, System.IntPtr u1, int ldu1, System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t, System.IntPtr work, int lwork,
                float* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cuncsd_work")]
            public static extern int CuncsdWork(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q,
                System.IntPtr x11, int ldx11, System.IntPtr x12, int ldx12, System.IntPtr x21, int ldx21, System.IntPtr x22, int ldx22, float* theta, System.IntPtr u1, int ldu1,
                System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t, System.IntPtr v2t, int ldv2t, System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cungbr")]
            public static extern int Cungbr(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cungbr_work")]
            public static extern int CungbrWork(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunghr")]
            public static extern int Cunghr(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunghr_work")]
            public static extern int CunghrWork(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunglq")]
            public static extern int Cunglq(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunglq_work")]
            public static extern int CunglqWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cungql")]
            public static extern int Cungql(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cungql_work")]
            public static extern int CungqlWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cungqr")]
            public static extern int Cungqr(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cungqr_work")]
            public static extern int CungqrWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cungrq")]
            public static extern int Cungrq(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cungrq_work")]
            public static extern int CungrqWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cungtr")]
            public static extern int Cungtr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cungtr_work")]
            public static extern int CungtrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunmbr")]
            public static extern int Cunmbr(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunmbr_work")]
            public static extern int CunmbrWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda,
                System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunmhr")]
            public static extern int Cunmhr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunmhr_work")]
            public static extern int CunmhrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunmlq")]
            public static extern int Cunmlq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunmlq_work")]
            public static extern int CunmlqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunmql")]
            public static extern int Cunmql(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunmql_work")]
            public static extern int CunmqlWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunmqr")]
            public static extern int Cunmqr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunmqr_work")]
            public static extern int CunmqrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunmrq")]
            public static extern int Cunmrq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunmrq_work")]
            public static extern int CunmrqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunmrz")]
            public static extern int Cunmrz(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunmrz_work")]
            public static extern int CunmrzWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunmtr")]
            public static extern int Cunmtr(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cunmtr_work")]
            public static extern int CunmtrWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cupgtr")]
            public static extern int Cupgtr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, System.IntPtr tau, System.IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cupgtr_work")]
            public static extern int CupgtrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, System.IntPtr tau, System.IntPtr q, int ldq, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cupmtr")]
            public static extern int Cupmtr(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, System.IntPtr ap, System.IntPtr tau, System.IntPtr c,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cupmtr_work")]
            public static extern int CupmtrWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, System.IntPtr ap, System.IntPtr tau,
                System.IntPtr c, int ldc, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dbbcsd")]
            public static extern int Dbbcsd(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, double* theta,
                double* phi, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* v2t, int ldv2t, double* b11d, double* b11e, double* b12d, double* b12e,
                double* b21d, double* b21e, double* b22d, double* b22e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dbbcsd_work")]
            public static extern int DbbcsdWork(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q,
                double* theta, double* phi, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* v2t, int ldv2t, double* b11d, double* b11e, double* b12d,
                double* b12e, double* b21d, double* b21e, double* b22d, double* b22e, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dbdsdc")]
            public static extern int Dbdsdc(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte compq, int n, double* d, double* e, double* u, int ldu, double* vt, int ldvt, double* q,
                int* iq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dbdsdc_work")]
            public static extern int DbdsdcWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte compq, int n, double* d, double* e, double* u, int ldu, double* vt, int ldvt, double* q,
                int* iq, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dbdsqr")]
            public static extern int Dbdsqr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, double* d, double* e, double* vt, int ldvt, double* u, int ldu,
                double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dbdsqr_work")]
            public static extern int DbdsqrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, double* d, double* e, double* vt, int ldvt, double* u,
                int ldu, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dbdsvdx")]
            public static extern int Dbdsvdx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu,
                int* ns, double* s, double* z, int ldz, int* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dbdsvdx_work")]
            public static extern int DbdsvdxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu,
                int* ns, double* s, double* z, int ldz, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ddisna")]
            public static extern int Ddisna(sbyte job, int m, int n, double* d, double* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ddisna_work")]
            public static extern int DdisnaWork(sbyte job, int m, int n, double* d, double* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbbrd")]
            public static extern int Dgbbrd(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, double* ab, int ldab, double* d, double* e, double* q,
                int ldq, double* pt, int ldpt, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbbrd_work")]
            public static extern int DgbbrdWork(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, double* ab, int ldab, double* d, double* e, double* q,
                int ldq, double* pt, int ldpt, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbcon")]
            public static extern int Dgbcon(BLAS.LAYOUT matrixLayout, sbyte norm, int n, int kl, int ku, double* ab, int ldab, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbcon_work")]
            public static extern int DgbconWork(BLAS.LAYOUT matrixLayout, sbyte norm, int n, int kl, int ku, double* ab, int ldab, int* ipiv, double anorm, double* rcond,
                double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbequ")]
            public static extern int Dgbequ(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd,
                double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbequ_work")]
            public static extern int DgbequWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd,
                double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbequb")]
            public static extern int Dgbequb(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd,
                double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbequb_work")]
            public static extern int DgbequbWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd,
                double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbrfs")]
            public static extern int Dgbrfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv,
                double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbrfs_work")]
            public static extern int DgbrfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb,
                int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbrfsx")]
            public static extern int Dgbrfsx(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb,
                int* ipiv, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp,
                int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbrfsx_work")]
            public static extern int DgbrfsxWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb,
                int ldafb, int* ipiv, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm,
                double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbsv")]
            public static extern int Dgbsv(BLAS.LAYOUT matrixLayout, int n, int kl, int ku, int nrhs, double* ab, int ldab, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbsv_work")]
            public static extern int DgbsvWork(BLAS.LAYOUT matrixLayout, int n, int kl, int ku, int nrhs, double* ab, int ldab, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbsvx")]
            public static extern int Dgbsvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb,
                int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* rpivot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbsvx_work")]
            public static extern int DgbsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb,
                int ldafb, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbsvxx")]
            public static extern int Dgbsvxx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb,
                int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds,
                double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbsvxx_work")]
            public static extern int DgbsvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb,
                int ldafb, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds,
                double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbtrf")]
            public static extern int Dgbtrf(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbtrf_work")]
            public static extern int DgbtrfWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbtrs")]
            public static extern int Dgbtrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbtrs_work")]
            public static extern int DgbtrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgebak")]
            public static extern int Dgebak(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* scale, int m, double* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgebak_work")]
            public static extern int DgebakWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* scale, int m, double* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgebal")]
            public static extern int Dgebal(BLAS.LAYOUT matrixLayout, sbyte job, int n, double* a, int lda, int* ilo, int* ihi, double* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgebal_work")]
            public static extern int DgebalWork(BLAS.LAYOUT matrixLayout, sbyte job, int n, double* a, int lda, int* ilo, int* ihi, double* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgebrd")]
            public static extern int Dgebrd(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* d, double* e, double* tauq, double* taup);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgebrd_work")]
            public static extern int DgebrdWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* d, double* e, double* tauq, double* taup, double* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgecon")]
            public static extern int Dgecon(BLAS.LAYOUT matrixLayout, sbyte norm, int n, double* a, int lda, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgecon_work")]
            public static extern int DgeconWork(BLAS.LAYOUT matrixLayout, sbyte norm, int n, double* a, int lda, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeequ")]
            public static extern int Dgeequ(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeequ_work")]
            public static extern int DgeequWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeequb")]
            public static extern int Dgeequb(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeequb_work")]
            public static extern int DgeequbWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgees")]
            public static extern int Dgees(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, int n, double* a, int lda, int* sdim, double* wr, double* wi,
                double* vs, int ldvs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgees_work")]
            public static extern int DgeesWork(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, int n, double* a, int lda, int* sdim, double* wr,
                double* wi, double* vs, int ldvs, double* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeesx")]
            public static extern int Dgeesx(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, sbyte sense, int n, double* a, int lda, int* sdim, double* wr,
                double* wi, double* vs, int ldvs, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeesx_work")]
            public static extern int DgeesxWork(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, sbyte sense, int n, double* a, int lda, int* sdim,
                double* wr, double* wi, double* vs, int ldvs, double* rconde, double* rcondv, double* work, int lwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeev")]
            public static extern int Dgeev(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* wr, double* wi, double* vl, int ldvl, double* vr,
                int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeev_work")]
            public static extern int DgeevWork(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* wr, double* wi, double* vl, int ldvl,
                double* vr, int ldvr, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeevx")]
            public static extern int Dgeevx(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, double* a, int lda, double* wr, double* wi,
                double* vl, int ldvl, double* vr, int ldvr, int* ilo, int* ihi, double* scale, double* abnrm, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeevx_work")]
            public static extern int DgeevxWork(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, double* a, int lda, double* wr, double* wi,
                double* vl, int ldvl, double* vr, int ldvr, int* ilo, int* ihi, double* scale, double* abnrm, double* rconde, double* rcondv, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgehrd")]
            public static extern int Dgehrd(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgehrd_work")]
            public static extern int DgehrdWork(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgejsv")]
            public static extern int Dgejsv(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, double* a, int lda,
                double* sva, double* u, int ldu, double* v, int ldv, double* stat, int* istat);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgejsv_work")]
            public static extern int DgejsvWork(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, double* a, int lda,
                double* sva, double* u, int ldu, double* v, int ldv, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelq2")]
            public static extern int Dgelq2(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelq2_work")]
            public static extern int Dgelq2Work(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelqf")]
            public static extern int Dgelqf(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelqf_work")]
            public static extern int DgelqfWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgels")]
            public static extern int Dgels(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgels_work")]
            public static extern int DgelsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelsd")]
            public static extern int Dgelsd(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* s, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelsd_work")]
            public static extern int DgelsdWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* s, double rcond, int* rank,
                double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelss")]
            public static extern int Dgelss(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* s, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelss_work")]
            public static extern int DgelssWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* s, double rcond, int* rank,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelsy")]
            public static extern int Dgelsy(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, int* jpvt, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelsy_work")]
            public static extern int DgelsyWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, int* jpvt, double rcond, int* rank,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgemqrt")]
            public static extern int Dgemqrt(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, double* v, int ldv, double* t, int ldt, double* c,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgemqrt_work")]
            public static extern int DgemqrtWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, double* v, int ldv, double* t, int ldt,
                double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqlf")]
            public static extern int Dgeqlf(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqlf_work")]
            public static extern int DgeqlfWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqp3")]
            public static extern int Dgeqp3(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, int* jpvt, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqp3_work")]
            public static extern int Dgeqp3Work(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, int* jpvt, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqpf")]
            public static extern int Dgeqpf(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, int* jpvt, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqpf_work")]
            public static extern int DgeqpfWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, int* jpvt, double* tau, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqr2")]
            public static extern int Dgeqr2(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqr2_work")]
            public static extern int Dgeqr2Work(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqrf")]
            public static extern int Dgeqrf(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqrf_work")]
            public static extern int DgeqrfWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqrfp")]
            public static extern int Dgeqrfp(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqrfp_work")]
            public static extern int DgeqrfpWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqrt")]
            public static extern int Dgeqrt(BLAS.LAYOUT matrixLayout, int m, int n, int nb, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqrt2")]
            public static extern int Dgeqrt2(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqrt2_work")]
            public static extern int Dgeqrt2Work(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqrt3")]
            public static extern int Dgeqrt3(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqrt3_work")]
            public static extern int Dgeqrt3Work(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqrt_work")]
            public static extern int DgeqrtWork(BLAS.LAYOUT matrixLayout, int m, int n, int nb, double* a, int lda, double* t, int ldt, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgerfs")]
            public static extern int Dgerfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb,
                double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgerfs_work")]
            public static extern int DgerfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b,
                int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgerfsx")]
            public static extern int Dgerfsx(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv,
                double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp,
                int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgerfsx_work")]
            public static extern int DgerfsxWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv,
                double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp,
                int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgerqf")]
            public static extern int Dgerqf(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgerqf_work")]
            public static extern int DgerqfWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesdd")]
            public static extern int Dgesdd(BLAS.LAYOUT matrixLayout, sbyte jobz, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* vt, int ldvt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesdd_work")]
            public static extern int DgesddWork(BLAS.LAYOUT matrixLayout, sbyte jobz, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* vt, int ldvt,
                double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesv")]
            public static extern int Dgesv(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesv_work")]
            public static extern int DgesvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvd")]
            public static extern int Dgesvd(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* vt,
                int ldvt, double* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvd_work")]
            public static extern int DgesvdWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* vt,
                int ldvt, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvdx")]
            public static extern int Dgesvdx(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, double* a, int lda, double vl, double vu, int il, int iu,
                int* ns, double* s, double* u, int ldu, double* vt, int ldvt, int* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvdx_work")]
            public static extern int DgesvdxWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, double* a, int lda, double vl, double vu, int il,
                int iu, int* ns, double* s, double* u, int ldu, double* vt, int ldvt, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvj")]
            public static extern int Dgesvj(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, double* a, int lda, double* sva, int mv, double* v, int ldv,
                double* stat);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvj_work")]
            public static extern int DgesvjWork(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, double* a, int lda, double* sva, int mv, double* v,
                int ldv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvx")]
            public static extern int Dgesvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv,
                sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* rpivot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvx_work")]
            public static extern int DgesvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv,
                sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvxx")]
            public static extern int Dgesvxx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv,
                sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm,
                double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvxx_work")]
            public static extern int DgesvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv,
                sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm,
                double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetf2")]
            public static extern int Dgetf2(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetf2_work")]
            public static extern int Dgetf2Work(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetrf")]
            public static extern int Dgetrf(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetrf2")]
            public static extern int Dgetrf2(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetrf2_work")]
            public static extern int Dgetrf2Work(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetrf_work")]
            public static extern int DgetrfWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetri")]
            public static extern int Dgetri(BLAS.LAYOUT matrixLayout, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetri_work")]
            public static extern int DgetriWork(BLAS.LAYOUT matrixLayout, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetrs")]
            public static extern int Dgetrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetrs_work")]
            public static extern int DgetrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggbak")]
            public static extern int Dggbak(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* lscale, double* rscale, int m, double* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggbak_work")]
            public static extern int DggbakWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* lscale, double* rscale, int m, double* v,
                int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggbal")]
            public static extern int Dggbal(BLAS.LAYOUT matrixLayout, sbyte job, int n, double* a, int lda, double* b, int ldb, int* ilo, int* ihi, double* lscale, double* rscale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggbal_work")]
            public static extern int DggbalWork(BLAS.LAYOUT matrixLayout, sbyte job, int n, double* a, int lda, double* b, int ldb, int* ilo, int* ihi, double* lscale,
                double* rscale, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgges")]
            public static extern int Dgges(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, double* a, int lda, double* b, int ldb,
                int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgges3")]
            public static extern int Dgges3(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, double* a, int lda, double* b, int ldb,
                int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgges3_work")]
            public static extern int Dgges3Work(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, double* a, int lda, double* b,
                int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr, double* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgges_work")]
            public static extern int DggesWork(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, double* a, int lda, double* b,
                int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr, double* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggesx")]
            public static extern int Dggesx(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, sbyte sense, int n, double* a, int lda,
                double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggesx_work")]
            public static extern int DggesxWork(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, sbyte sense, int n, double* a, int lda,
                double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr, double* rconde, double* rcondv,
                double* work, int lwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggev")]
            public static extern int Dggev(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai,
                double* beta, double* vl, int ldvl, double* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggev3")]
            public static extern int Dggev3(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai,
                double* beta, double* vl, int ldvl, double* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggev3_work")]
            public static extern int Dggev3Work(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai,
                double* beta, double* vl, int ldvl, double* vr, int ldvr, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggev_work")]
            public static extern int DggevWork(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai,
                double* beta, double* vl, int ldvl, double* vr, int ldvr, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggevx")]
            public static extern int Dggevx(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, double* a, int lda, double* b, int ldb,
                double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr, int* ilo, int* ihi, double* lscale, double* rscale, double* abnrm,
                double* bbnrm, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggevx_work")]
            public static extern int DggevxWork(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, double* a, int lda, double* b, int ldb,
                double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr, int* ilo, int* ihi, double* lscale, double* rscale, double* abnrm,
                double* bbnrm, double* rconde, double* rcondv, double* work, int lwork, int* iwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggglm")]
            public static extern int Dggglm(BLAS.LAYOUT matrixLayout, int n, int m, int p, double* a, int lda, double* b, int ldb, double* d, double* x, double* y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggglm_work")]
            public static extern int DggglmWork(BLAS.LAYOUT matrixLayout, int n, int m, int p, double* a, int lda, double* b, int ldb, double* d, double* x, double* y,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgghd3")]
            public static extern int Dgghd3(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* a, int lda, double* b, int ldb, double* q, int ldq,
                double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgghd3_work")]
            public static extern int Dgghd3Work(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* a, int lda, double* b, int ldb, double* q,
                int ldq, double* z, int ldz, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgghrd")]
            public static extern int Dgghrd(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* a, int lda, double* b, int ldb, double* q, int ldq,
                double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgghrd_work")]
            public static extern int DgghrdWork(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* a, int lda, double* b, int ldb, double* q,
                int ldq, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgglse")]
            public static extern int Dgglse(BLAS.LAYOUT matrixLayout, int m, int n, int p, double* a, int lda, double* b, int ldb, double* c, double* d, double* x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgglse_work")]
            public static extern int DgglseWork(BLAS.LAYOUT matrixLayout, int m, int n, int p, double* a, int lda, double* b, int ldb, double* c, double* d, double* x,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggqrf")]
            public static extern int Dggqrf(BLAS.LAYOUT matrixLayout, int n, int m, int p, double* a, int lda, double* taua, double* b, int ldb, double* taub);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggqrf_work")]
            public static extern int DggqrfWork(BLAS.LAYOUT matrixLayout, int n, int m, int p, double* a, int lda, double* taua, double* b, int ldb, double* taub, double* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggrqf")]
            public static extern int Dggrqf(BLAS.LAYOUT matrixLayout, int m, int p, int n, double* a, int lda, double* taua, double* b, int ldb, double* taub);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggrqf_work")]
            public static extern int DggrqfWork(BLAS.LAYOUT matrixLayout, int m, int p, int n, double* a, int lda, double* taua, double* b, int ldb, double* taub, double* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggsvd")]
            public static extern int Dggsvd(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, double* a, int lda, double* b,
                int ldb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggsvd3")]
            public static extern int Dggsvd3(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, double* a, int lda, double* b,
                int ldb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggsvd3_work")]
            public static extern int Dggsvd3Work(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, double* a, int lda, double* b,
                int ldb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggsvd_work")]
            public static extern int DggsvdWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, double* a, int lda, double* b,
                int ldb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggsvp")]
            public static extern int Dggsvp(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, double* a, int lda, double* b, int ldb, double tola,
                double tolb, int* k, int* l, double* u, int ldu, double* v, int ldv, double* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggsvp3")]
            public static extern int Dggsvp3(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, double* a, int lda, double* b, int ldb, double tola,
                double tolb, int* k, int* l, double* u, int ldu, double* v, int ldv, double* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggsvp3_work")]
            public static extern int Dggsvp3Work(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, double* a, int lda, double* b, int ldb,
                double tola, double tolb, int* k, int* l, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* iwork, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggsvp_work")]
            public static extern int DggsvpWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, double* a, int lda, double* b, int ldb,
                double tola, double tolb, int* k, int* l, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* iwork, double* tau, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgtcon")]
            public static extern int Dgtcon(sbyte norm, int n, double* dl, double* d, double* du, double* du2, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgtcon_work")]
            public static extern int DgtconWork(sbyte norm, int n, double* dl, double* d, double* du, double* du2, int* ipiv, double anorm, double* rcond, double* work,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgtrfs")]
            public static extern int Dgtrfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* dl, double* d, double* du, double* dlf, double* df, double* duf,
                double* du2, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgtrfs_work")]
            public static extern int DgtrfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* dl, double* d, double* du, double* dlf, double* df,
                double* duf, double* du2, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgtsv")]
            public static extern int Dgtsv(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* dl, double* d, double* du, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgtsv_work")]
            public static extern int DgtsvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* dl, double* d, double* du, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgtsvx")]
            public static extern int Dgtsvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, double* dl, double* d, double* du, double* dlf, double* df,
                double* duf, double* du2, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgtsvx_work")]
            public static extern int DgtsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, double* dl, double* d, double* du, double* dlf, double* df,
                double* duf, double* du2, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgttrf")]
            public static extern int Dgttrf(int n, double* dl, double* d, double* du, double* du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgttrf_work")]
            public static extern int DgttrfWork(int n, double* dl, double* d, double* du, double* du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgttrs")]
            public static extern int Dgttrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* dl, double* d, double* du, double* du2, int* ipiv, double* b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgttrs_work")]
            public static extern int DgttrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* dl, double* d, double* du, double* du2, int* ipiv, double* b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dhgeqz")]
            public static extern int Dhgeqz(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* h, int ldh, double* t, int ldt,
                double* alphar, double* alphai, double* beta, double* q, int ldq, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dhgeqz_work")]
            public static extern int DhgeqzWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* h, int ldh, double* t, int ldt,
                double* alphar, double* alphai, double* beta, double* q, int ldq, double* z, int ldz, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dhsein")]
            public static extern int Dhsein(BLAS.LAYOUT matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, double* h, int ldh, double* wr, double* wi,
                double* vl, int ldvl, double* vr, int ldvr, int mm, int* m, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dhsein_work")]
            public static extern int DhseinWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, double* h, int ldh, double* wr, double* wi,
                double* vl, int ldvl, double* vr, int ldvr, int mm, int* m, double* work, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dhseqr")]
            public static extern int Dhseqr(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, double* h, int ldh, double* wr, double* wi, double* z,
                int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dhseqr_work")]
            public static extern int DhseqrWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, double* h, int ldh, double* wr, double* wi, double* z,
                int ldz, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlacn2")]
            public static extern int Dlacn2(int n, double* v, double* x, int* isgn, double* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlacn2_work")]
            public static extern int Dlacn2Work(int n, double* v, double* x, int* isgn, double* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlacpy")]
            public static extern int Dlacpy(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlacpy_work")]
            public static extern int DlacpyWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlag2s")]
            public static extern int Dlag2s(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, float* sa, int ldsa);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlag2s_work")]
            public static extern int Dlag2sWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, float* sa, int ldsa);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlagge")]
            public static extern int Dlagge(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, double* d, double* a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlagge_work")]
            public static extern int DlaggeWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, double* d, double* a, int lda, int* iseed, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlagsy")]
            public static extern int Dlagsy(BLAS.LAYOUT matrixLayout, int n, int k, double* d, double* a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlagsy_work")]
            public static extern int DlagsyWork(BLAS.LAYOUT matrixLayout, int n, int k, double* d, double* a, int lda, int* iseed, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlapmr")]
            public static extern int Dlapmr(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, double* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlapmr_work")]
            public static extern int DlapmrWork(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, double* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlapmt")]
            public static extern int Dlapmt(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, double* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlapmt_work")]
            public static extern int DlapmtWork(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, double* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlarfb")]
            public static extern int Dlarfb(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, double* v, int ldv, double* t,
                int ldt, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlarfb_work")]
            public static extern int DlarfbWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, double* v, int ldv,
                double* t, int ldt, double* c, int ldc, double* work, int ldwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlarfg")]
            public static extern int Dlarfg(int n, double* alpha, double* x, int incx, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlarfg_work")]
            public static extern int DlarfgWork(int n, double* alpha, double* x, int incx, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlarft")]
            public static extern int Dlarft(BLAS.LAYOUT matrixLayout, sbyte direct, sbyte storev, int n, int k, double* v, int ldv, double* tau, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlarft_work")]
            public static extern int DlarftWork(BLAS.LAYOUT matrixLayout, sbyte direct, sbyte storev, int n, int k, double* v, int ldv, double* tau, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlarfx")]
            public static extern int Dlarfx(BLAS.LAYOUT matrixLayout, sbyte side, int m, int n, double* v, double tau, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlarfx_work")]
            public static extern int DlarfxWork(BLAS.LAYOUT matrixLayout, sbyte side, int m, int n, double* v, double tau, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlarnv")]
            public static extern int Dlarnv(int idist, int* iseed, int n, double* x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlarnv_work")]
            public static extern int DlarnvWork(int idist, int* iseed, int n, double* x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlartgp")]
            public static extern int Dlartgp(double f, double g, double* cs, double* sn, double* r);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlartgp_work")]
            public static extern int DlartgpWork(double f, double g, double* cs, double* sn, double* r);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlartgs")]
            public static extern int Dlartgs(double x, double y, double sigma, double* cs, double* sn);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlartgs_work")]
            public static extern int DlartgsWork(double x, double y, double sigma, double* cs, double* sn);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlascl")]
            public static extern int Dlascl(BLAS.LAYOUT matrixLayout, sbyte type, int kl, int ku, double cfrom, double cto, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlascl_work")]
            public static extern int DlasclWork(BLAS.LAYOUT matrixLayout, sbyte type, int kl, int ku, double cfrom, double cto, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlaset")]
            public static extern int Dlaset(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, double alpha, double beta, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlaset_work")]
            public static extern int DlasetWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, double alpha, double beta, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlasrt")]
            public static extern int Dlasrt(sbyte id, int n, double* d);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlasrt_work")]
            public static extern int DlasrtWork(sbyte id, int n, double* d);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlaswp")]
            public static extern int Dlaswp(BLAS.LAYOUT matrixLayout, int n, double* a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlaswp_work")]
            public static extern int DlaswpWork(BLAS.LAYOUT matrixLayout, int n, double* a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlatms")]
            public static extern int Dlatms(BLAS.LAYOUT matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, double* d, int mode, double cond, double dmax, int kl,
                int ku, sbyte pack, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlatms_work")]
            public static extern int DlatmsWork(BLAS.LAYOUT matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, double* d, int mode, double cond, double dmax, int kl,
                int ku, sbyte pack, double* a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlauum")]
            public static extern int Dlauum(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlauum_work")]
            public static extern int DlauumWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dopgtr")]
            public static extern int Dopgtr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, double* tau, double* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dopgtr_work")]
            public static extern int DopgtrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, double* tau, double* q, int ldq, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dopmtr")]
            public static extern int Dopmtr(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, double* ap, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dopmtr_work")]
            public static extern int DopmtrWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, double* ap, double* tau, double* c, int ldc,
                double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorbdb")]
            public static extern int Dorbdb(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, double* x11, int ldx11, double* x12, int ldx12,
                double* x21, int ldx21, double* x22, int ldx22, double* theta, double* phi, double* taup1, double* taup2, double* tauq1, double* tauq2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorbdb_work")]
            public static extern int DorbdbWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, double* x11, int ldx11, double* x12, int ldx12,
                double* x21, int ldx21, double* x22, int ldx22, double* theta, double* phi, double* taup1, double* taup2, double* tauq1, double* tauq2, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorcsd")]
            public static extern int Dorcsd(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q,
                double* x11, int ldx11, double* x12, int ldx12, double* x21, int ldx21, double* x22, int ldx22, double* theta, double* u1, int ldu1, double* u2, int ldu2,
                double* v1t, int ldv1t, double* v2t, int ldv2t);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorcsd2by1")]
            public static extern int Dorcsd2by1(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, double* x11, int ldx11, double* x21,
                int ldx21, double* theta, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorcsd2by1_work")]
            public static extern int Dorcsd2by1Work(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, double* x11, int ldx11, double* x21,
                int ldx21, double* theta, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorcsd_work")]
            public static extern int DorcsdWork(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q,
                double* x11, int ldx11, double* x12, int ldx12, double* x21, int ldx21, double* x22, int ldx22, double* theta, double* u1, int ldu1, double* u2, int ldu2,
                double* v1t, int ldv1t, double* v2t, int ldv2t, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorgbr")]
            public static extern int Dorgbr(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorgbr_work")]
            public static extern int DorgbrWork(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorghr")]
            public static extern int Dorghr(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorghr_work")]
            public static extern int DorghrWork(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorglq")]
            public static extern int Dorglq(BLAS.LAYOUT matrixLayout, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorglq_work")]
            public static extern int DorglqWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorgql")]
            public static extern int Dorgql(BLAS.LAYOUT matrixLayout, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorgql_work")]
            public static extern int DorgqlWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorgqr")]
            public static extern int Dorgqr(BLAS.LAYOUT matrixLayout, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorgqr_work")]
            public static extern int DorgqrWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorgrq")]
            public static extern int Dorgrq(BLAS.LAYOUT matrixLayout, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorgrq_work")]
            public static extern int DorgrqWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorgtr")]
            public static extern int Dorgtr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorgtr_work")]
            public static extern int DorgtrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormbr")]
            public static extern int Dormbr(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormbr_work")]
            public static extern int DormbrWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c,
                int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormhr")]
            public static extern int Dormhr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, double* a, int lda, double* tau, double* c,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormhr_work")]
            public static extern int DormhrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, double* a, int lda, double* tau, double* c,
                int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormlq")]
            public static extern int Dormlq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormlq_work")]
            public static extern int DormlqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormql")]
            public static extern int Dormql(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormql_work")]
            public static extern int DormqlWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormqr")]
            public static extern int Dormqr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormqr_work")]
            public static extern int DormqrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormrq")]
            public static extern int Dormrq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormrq_work")]
            public static extern int DormrqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormrz")]
            public static extern int Dormrz(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, double* a, int lda, double* tau, double* c,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormrz_work")]
            public static extern int DormrzWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, double* a, int lda, double* tau, double* c,
                int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormtr")]
            public static extern int Dormtr(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormtr_work")]
            public static extern int DormtrWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, double* a, int lda, double* tau, double* c,
                int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbcon")]
            public static extern int Dpbcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, double* ab, int ldab, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbcon_work")]
            public static extern int DpbconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, double* ab, int ldab, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbequ")]
            public static extern int Dpbequ(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, double* ab, int ldab, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbequ_work")]
            public static extern int DpbequWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, double* ab, int ldab, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbrfs")]
            public static extern int Dpbrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* afb, int ldafb, double* b, int ldb,
                double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbrfs_work")]
            public static extern int DpbrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* afb, int ldafb, double* b, int ldb,
                double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbstf")]
            public static extern int Dpbstf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kb, double* bb, int ldbb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbstf_work")]
            public static extern int DpbstfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kb, double* bb, int ldbb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbsv")]
            public static extern int Dpbsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbsv_work")]
            public static extern int DpbsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbsvx")]
            public static extern int Dpbsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* afb, int ldafb, sbyte* equed,
                double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbsvx_work")]
            public static extern int DpbsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* afb, int ldafb,
                sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbtrf")]
            public static extern int Dpbtrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, double* ab, int ldab);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbtrf_work")]
            public static extern int DpbtrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, double* ab, int ldab);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbtrs")]
            public static extern int Dpbtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbtrs_work")]
            public static extern int DpbtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpftrf")]
            public static extern int Dpftrf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpftrf_work")]
            public static extern int DpftrfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpftri")]
            public static extern int Dpftri(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpftri_work")]
            public static extern int DpftriWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpftrs")]
            public static extern int Dpftrs(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, double* a, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpftrs_work")]
            public static extern int DpftrsWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, double* a, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpocon")]
            public static extern int Dpocon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpocon_work")]
            public static extern int DpoconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpoequ")]
            public static extern int Dpoequ(BLAS.LAYOUT matrixLayout, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpoequ_work")]
            public static extern int DpoequWork(BLAS.LAYOUT matrixLayout, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpoequb")]
            public static extern int Dpoequb(BLAS.LAYOUT matrixLayout, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpoequb_work")]
            public static extern int DpoequbWork(BLAS.LAYOUT matrixLayout, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dporfs")]
            public static extern int Dporfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, double* b, int ldb, double* x, int ldx,
                double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dporfs_work")]
            public static extern int DporfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, double* b, int ldb, double* x,
                int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dporfsx")]
            public static extern int Dporfsx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, double* s, double* b,
                int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dporfsx_work")]
            public static extern int DporfsxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, double* s, double* b,
                int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dposv")]
            public static extern int Dposv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dposv_work")]
            public static extern int DposvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dposvx")]
            public static extern int Dposvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, sbyte* equed, double* s,
                double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dposvx_work")]
            public static extern int DposvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, sbyte* equed,
                double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dposvxx")]
            public static extern int Dposvxx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, sbyte* equed, double* s,
                double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams,
                double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dposvxx_work")]
            public static extern int DposvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, sbyte* equed,
                double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp,
                int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpotrf")]
            public static extern int Dpotrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpotrf2")]
            public static extern int Dpotrf2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpotrf2_work")]
            public static extern int Dpotrf2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpotrf_work")]
            public static extern int DpotrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpotri")]
            public static extern int Dpotri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpotri_work")]
            public static extern int DpotriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpotrs")]
            public static extern int Dpotrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpotrs_work")]
            public static extern int DpotrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dppcon")]
            public static extern int Dppcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dppcon_work")]
            public static extern int DppconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dppequ")]
            public static extern int Dppequ(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dppequ_work")]
            public static extern int DppequWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpprfs")]
            public static extern int Dpprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* afp, double* b, int ldb, double* x, int ldx, double* ferr,
                double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpprfs_work")]
            public static extern int DpprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* afp, double* b, int ldb, double* x, int ldx,
                double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dppsv")]
            public static extern int Dppsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dppsv_work")]
            public static extern int DppsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dppsvx")]
            public static extern int Dppsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* ap, double* afp, sbyte* equed, double* s, double* b, int ldb,
                double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dppsvx_work")]
            public static extern int DppsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* ap, double* afp, sbyte* equed, double* s, double* b,
                int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpptrf")]
            public static extern int Dpptrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpptrf_work")]
            public static extern int DpptrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpptri")]
            public static extern int Dpptri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpptri_work")]
            public static extern int DpptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpptrs")]
            public static extern int Dpptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpptrs_work")]
            public static extern int DpptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpstrf")]
            public static extern int Dpstrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* piv, int* rank, double tol);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpstrf_work")]
            public static extern int DpstrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* piv, int* rank, double tol, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dptcon")]
            public static extern int Dptcon(int n, double* d, double* e, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dptcon_work")]
            public static extern int DptconWork(int n, double* d, double* e, double anorm, double* rcond, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpteqr")]
            public static extern int Dpteqr(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpteqr_work")]
            public static extern int DpteqrWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dptrfs")]
            public static extern int Dptrfs(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* d, double* e, double* df, double* ef, double* b, int ldb, double* x, int ldx,
                double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dptrfs_work")]
            public static extern int DptrfsWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* d, double* e, double* df, double* ef, double* b, int ldb, double* x, int ldx,
                double* ferr, double* berr, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dptsv")]
            public static extern int Dptsv(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* d, double* e, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dptsv_work")]
            public static extern int DptsvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* d, double* e, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dptsvx")]
            public static extern int Dptsvx(BLAS.LAYOUT matrixLayout, sbyte fact, int n, int nrhs, double* d, double* e, double* df, double* ef, double* b, int ldb, double* x,
                int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dptsvx_work")]
            public static extern int DptsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, int n, int nrhs, double* d, double* e, double* df, double* ef, double* b, int ldb, double* x,
                int ldx, double* rcond, double* ferr, double* berr, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpttrf")]
            public static extern int Dpttrf(int n, double* d, double* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpttrf_work")]
            public static extern int DpttrfWork(int n, double* d, double* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpttrs")]
            public static extern int Dpttrs(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* d, double* e, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpttrs_work")]
            public static extern int DpttrsWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* d, double* e, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbev")]
            public static extern int Dsbev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbev_work")]
            public static extern int DsbevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbevd")]
            public static extern int Dsbevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbevd_work")]
            public static extern int DsbevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz, double* work,
                int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbevx")]
            public static extern int Dsbevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, double* ab, int ldab, double* q, int ldq, double vl,
                double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbevx_work")]
            public static extern int DsbevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, double* ab, int ldab, double* q, int ldq, double vl,
                double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbgst")]
            public static extern int Dsbgst(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* x,
                int ldx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbgst_work")]
            public static extern int DsbgstWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* x,
                int ldx, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbgv")]
            public static extern int Dsbgv(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* w,
                double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbgv_work")]
            public static extern int DsbgvWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* w,
                double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbgvd")]
            public static extern int Dsbgvd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* w,
                double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbgvd_work")]
            public static extern int DsbgvdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* w,
                double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbgvx")]
            public static extern int Dsbgvx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb,
                double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbgvx_work")]
            public static extern int DsbgvxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb,
                double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbtrd")]
            public static extern int Dsbtrd(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int kd, double* ab, int ldab, double* d, double* e, double* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbtrd_work")]
            public static extern int DsbtrdWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int kd, double* ab, int ldab, double* d, double* e, double* q, int ldq,
                double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsfrk")]
            public static extern int Dsfrk(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, double alpha, double* a, int lda, double beta,
                double* c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsfrk_work")]
            public static extern int DsfrkWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, double alpha, double* a, int lda, double beta,
                double* c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsgesv")]
            public static extern int Dsgesv(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* x, int ldx, int* iter);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsgesv_work")]
            public static extern int DsgesvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* x, int ldx, double* work,
                float* swork, int* iter);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspcon")]
            public static extern int Dspcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspcon_work")]
            public static extern int DspconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, int* ipiv, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspev")]
            public static extern int Dspev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* ap, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspev_work")]
            public static extern int DspevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* ap, double* w, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspevd")]
            public static extern int Dspevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* ap, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspevd_work")]
            public static extern int DspevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* ap, double* w, double* z, int ldz, double* work, int lwork,
                int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspevx")]
            public static extern int Dspevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* ap, double vl, double vu, int il, int iu, double abstol,
                int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspevx_work")]
            public static extern int DspevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* ap, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspgst")]
            public static extern int Dspgst(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, double* ap, double* bp);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspgst_work")]
            public static extern int DspgstWork(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, double* ap, double* bp);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspgv")]
            public static extern int Dspgv(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* ap, double* bp, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspgv_work")]
            public static extern int DspgvWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* ap, double* bp, double* w, double* z, int ldz,
                double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspgvd")]
            public static extern int Dspgvd(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* ap, double* bp, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspgvd_work")]
            public static extern int DspgvdWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* ap, double* bp, double* w, double* z, int ldz,
                double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspgvx")]
            public static extern int Dspgvx(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, double* ap, double* bp, double vl, double vu, int il,
                int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspgvx_work")]
            public static extern int DspgvxWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, double* ap, double* bp, double vl, double vu,
                int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsposv")]
            public static extern int Dsposv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb, double* x, int ldx, int* iter);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsposv_work")]
            public static extern int DsposvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb, double* x, int ldx, double* work,
                float* swork, int* iter);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsprfs")]
            public static extern int Dsprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* afp, int* ipiv, double* b, int ldb, double* x, int ldx,
                double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsprfs_work")]
            public static extern int DsprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* afp, int* ipiv, double* b, int ldb, double* x, int ldx,
                double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspsv")]
            public static extern int Dspsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspsv_work")]
            public static extern int DspsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspsvx")]
            public static extern int Dspsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* ap, double* afp, int* ipiv, double* b, int ldb, double* x,
                int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspsvx_work")]
            public static extern int DspsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* ap, double* afp, int* ipiv, double* b, int ldb,
                double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsptrd")]
            public static extern int Dsptrd(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, double* d, double* e, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsptrd_work")]
            public static extern int DsptrdWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, double* d, double* e, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsptrf")]
            public static extern int Dsptrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsptrf_work")]
            public static extern int DsptrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsptri")]
            public static extern int Dsptri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsptri_work")]
            public static extern int DsptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, int* ipiv, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsptrs")]
            public static extern int Dsptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsptrs_work")]
            public static extern int DsptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstebz")]
            public static extern int Dstebz(sbyte range, sbyte order, int n, double vl, double vu, int il, int iu, double abstol, double* d, double* e, int* m, int* nsplit,
                double* w, int* iblock, int* isplit);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstebz_work")]
            public static extern int DstebzWork(sbyte range, sbyte order, int n, double vl, double vu, int il, int iu, double abstol, double* d, double* e, int* m, int* nsplit,
                double* w, int* iblock, int* isplit, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstedc")]
            public static extern int Dstedc(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstedc_work")]
            public static extern int DstedcWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz, double* work, int lwork, int* iwork,
                int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstegr")]
            public static extern int Dstegr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol,
                int* m, double* w, double* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstegr_work")]
            public static extern int DstegrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol,
                int* m, double* w, double* z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstein")]
            public static extern int Dstein(BLAS.LAYOUT matrixLayout, int n, double* d, double* e, int m, double* w, int* iblock, int* isplit, double* z, int ldz, int* ifailv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstein_work")]
            public static extern int DsteinWork(BLAS.LAYOUT matrixLayout, int n, double* d, double* e, int m, double* w, int* iblock, int* isplit, double* z, int ldz, double* work,
                int* iwork, int* ifailv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstemr")]
            public static extern int Dstemr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* m, double* w,
                double* z, int ldz, int nzc, int* isuppz, int* tryrac);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstemr_work")]
            public static extern int DstemrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* m,
                double* w, double* z, int ldz, int nzc, int* isuppz, int* tryrac, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsteqr")]
            public static extern int Dsteqr(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsteqr_work")]
            public static extern int DsteqrWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsterf")]
            public static extern int Dsterf(int n, double* d, double* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsterf_work")]
            public static extern int DsterfWork(int n, double* d, double* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstev")]
            public static extern int Dstev(BLAS.LAYOUT matrixLayout, sbyte jobz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstev_work")]
            public static extern int DstevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, int n, double* d, double* e, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstevd")]
            public static extern int Dstevd(BLAS.LAYOUT matrixLayout, sbyte jobz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstevd_work")]
            public static extern int DstevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, int n, double* d, double* e, double* z, int ldz, double* work, int lwork, int* iwork,
                int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstevr")]
            public static extern int Dstevr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol,
                int* m, double* w, double* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstevr_work")]
            public static extern int DstevrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol,
                int* m, double* w, double* z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstevx")]
            public static extern int Dstevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol,
                int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstevx_work")]
            public static extern int DstevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol,
                int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsycon")]
            public static extern int Dsycon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsycon_work")]
            public static extern int DsyconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyconv")]
            public static extern int Dsyconv(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte way, int n, double* a, int lda, int* ipiv, double* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyconv_work")]
            public static extern int DsyconvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte way, int n, double* a, int lda, int* ipiv, double* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyequb")]
            public static extern int Dsyequb(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyequb_work")]
            public static extern int DsyequbWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* s, double* scond, double* amax, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyev")]
            public static extern int Dsyev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyev_work")]
            public static extern int DsyevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevd")]
            public static extern int Dsyevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevd_work")]
            public static extern int DsyevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w, double* work, int lwork, int* iwork,
                int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevr")]
            public static extern int Dsyevr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, double* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevr_work")]
            public static extern int DsyevrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, double* z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevx")]
            public static extern int Dsyevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevx_work")]
            public static extern int DsyevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsygst")]
            public static extern int Dsygst(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsygst_work")]
            public static extern int DsygstWork(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsygv")]
            public static extern int Dsygv(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsygv_work")]
            public static extern int DsygvWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w, double* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsygvd")]
            public static extern int Dsygvd(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsygvd_work")]
            public static extern int DsygvdWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w, double* work,
                int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsygvx")]
            public static extern int Dsygvx(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double vl,
                double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsygvx_work")]
            public static extern int DsygvxWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double vl,
                double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyrfs")]
            public static extern int Dsyrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb,
                double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyrfs_work")]
            public static extern int DsyrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb,
                double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyrfsx")]
            public static extern int Dsyrfsx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* s,
                double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyrfsx_work")]
            public static extern int DsyrfsxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* s,
                double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params,
                double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysv")]
            public static extern int Dsysv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysv_rook")]
            public static extern int DsysvRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysv_rook_work")]
            public static extern int DsysvRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysv_work")]
            public static extern int DsysvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysvx")]
            public static extern int Dsysvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b,
                int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysvx_work")]
            public static extern int DsysvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b,
                int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysvxx")]
            public static extern int Dsysvxx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, sbyte* equed,
                double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp,
                int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysvxx_work")]
            public static extern int DsysvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv,
                sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm,
                double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyswapr")]
            public static extern int Dsyswapr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyswapr_work")]
            public static extern int DsyswaprWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrd")]
            public static extern int Dsytrd(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* d, double* e, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrd_work")]
            public static extern int DsytrdWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* d, double* e, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrf")]
            public static extern int Dsytrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrf_rook")]
            public static extern int DsytrfRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrf_rook_work")]
            public static extern int DsytrfRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrf_work")]
            public static extern int DsytrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytri")]
            public static extern int Dsytri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytri2")]
            public static extern int Dsytri2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytri2_work")]
            public static extern int Dsytri2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytri2x")]
            public static extern int Dsytri2x(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytri2x_work")]
            public static extern int Dsytri2xWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytri_work")]
            public static extern int DsytriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs")]
            public static extern int Dsytrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs2")]
            public static extern int Dsytrs2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs2_work")]
            public static extern int Dsytrs2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs_rook")]
            public static extern int DsytrsRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs_rook_work")]
            public static extern int DsytrsRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs_work")]
            public static extern int DsytrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtbcon")]
            public static extern int Dtbcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, double* ab, int ldab, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtbcon_work")]
            public static extern int DtbconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, double* ab, int ldab, double* rcond, double* work,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtbrfs")]
            public static extern int Dtbrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb,
                double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtbrfs_work")]
            public static extern int DtbrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, double* ab, int ldab, double* b,
                int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtbtrs")]
            public static extern int Dtbtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtbtrs_work")]
            public static extern int DtbtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, double* ab, int ldab, double* b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtfsm")]
            public static extern int Dtfsm(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, double alpha, double* a,
                double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtfsm_work")]
            public static extern int DtfsmWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, double alpha, double* a,
                double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtftri")]
            public static extern int Dtftri(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, double* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtftri_work")]
            public static extern int DtftriWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, double* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtfttp")]
            public static extern int Dtfttp(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* arf, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtfttp_work")]
            public static extern int DtfttpWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* arf, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtfttr")]
            public static extern int Dtfttr(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* arf, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtfttr_work")]
            public static extern int DtfttrWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* arf, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgevc")]
            public static extern int Dtgevc(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, double* s, int lds, double* p, int ldp, double* vl, int ldvl,
                double* vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgevc_work")]
            public static extern int DtgevcWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, double* s, int lds, double* p, int ldp, double* vl,
                int ldvl, double* vr, int ldvr, int mm, int* m, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgexc")]
            public static extern int Dtgexc(BLAS.LAYOUT matrixLayout, int wantq, int wantz, int n, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z, int ldz,
                int* ifst, int* ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgexc_work")]
            public static extern int DtgexcWork(BLAS.LAYOUT matrixLayout, int wantq, int wantz, int n, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z,
                int ldz, int* ifst, int* ilst, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgsen")]
            public static extern int Dtgsen(BLAS.LAYOUT matrixLayout, int ijob, int wantq, int wantz, int* select, int n, double* a, int lda, double* b, int ldb, double* alphar,
                double* alphai, double* beta, double* q, int ldq, double* z, int ldz, int* m, double* pl, double* pr, double* dif);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgsen_work")]
            public static extern int DtgsenWork(BLAS.LAYOUT matrixLayout, int ijob, int wantq, int wantz, int* select, int n, double* a, int lda, double* b, int ldb,
                double* alphar, double* alphai, double* beta, double* q, int ldq, double* z, int ldz, int* m, double* pl, double* pr, double* dif, double* work, int lwork,
                int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgsja")]
            public static extern int Dtgsja(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, double* a, int lda, double* b, int ldb,
                double tola, double tolb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* ncycle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgsja_work")]
            public static extern int DtgsjaWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, double* a, int lda, double* b,
                int ldb, double tola, double tolb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, double* work, int* ncycle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgsna")]
            public static extern int Dtgsna(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, double* a, int lda, double* b, int ldb, double* vl, int ldvl,
                double* vr, int ldvr, double* s, double* dif, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgsna_work")]
            public static extern int DtgsnaWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, double* a, int lda, double* b, int ldb, double* vl, int ldvl,
                double* vr, int ldvr, double* s, double* dif, int mm, int* m, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgsyl")]
            public static extern int Dtgsyl(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, double* a, int lda, double* b, int ldb, double* c, int ldc,
                double* d, int ldd, double* e, int lde, double* f, int ldf, double* scale, double* dif);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgsyl_work")]
            public static extern int DtgsylWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, double* a, int lda, double* b, int ldb, double* c, int ldc,
                double* d, int ldd, double* e, int lde, double* f, int ldf, double* scale, double* dif, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpcon")]
            public static extern int Dtpcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, double* ap, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpcon_work")]
            public static extern int DtpconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, double* ap, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpmqrt")]
            public static extern int Dtpmqrt(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, double* v, int ldv, double* t, int ldt,
                double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpmqrt_work")]
            public static extern int DtpmqrtWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, double* v, int ldv, double* t, int ldt,
                double* a, int lda, double* b, int ldb, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpqrt")]
            public static extern int Dtpqrt(BLAS.LAYOUT matrixLayout, int m, int n, int l, int nb, double* a, int lda, double* b, int ldb, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpqrt2")]
            public static extern int Dtpqrt2(BLAS.LAYOUT matrixLayout, int m, int n, int l, double* a, int lda, double* b, int ldb, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpqrt2_work")]
            public static extern int Dtpqrt2Work(BLAS.LAYOUT matrixLayout, int m, int n, int l, double* a, int lda, double* b, int ldb, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpqrt_work")]
            public static extern int DtpqrtWork(BLAS.LAYOUT matrixLayout, int m, int n, int l, int nb, double* a, int lda, double* b, int ldb, double* t, int ldt, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtprfb")]
            public static extern int Dtprfb(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, double* v, int ldv,
                double* t, int ldt, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtprfb_work")]
            public static extern int DtprfbWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, double* v, int ldv,
                double* t, int ldt, double* a, int lda, double* b, int ldb, double* work, int ldwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtprfs")]
            public static extern int Dtprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* ap, double* b, int ldb, double* x, int ldx,
                double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtprfs_work")]
            public static extern int DtprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* ap, double* b, int ldb, double* x,
                int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtptri")]
            public static extern int Dtptri(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtptri_work")]
            public static extern int DtptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtptrs")]
            public static extern int Dtptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtptrs_work")]
            public static extern int DtptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpttf")]
            public static extern int Dtpttf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* ap, double* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpttf_work")]
            public static extern int DtpttfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* ap, double* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpttr")]
            public static extern int Dtpttr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpttr_work")]
            public static extern int DtpttrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrcon")]
            public static extern int Dtrcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, double* a, int lda, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrcon_work")]
            public static extern int DtrconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, double* a, int lda, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrevc")]
            public static extern int Dtrevc(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, double* t, int ldt, double* vl, int ldvl, double* vr, int ldvr,
                int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrevc_work")]
            public static extern int DtrevcWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, double* t, int ldt, double* vl, int ldvl, double* vr,
                int ldvr, int mm, int* m, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrexc")]
            public static extern int Dtrexc(BLAS.LAYOUT matrixLayout, sbyte compq, int n, double* t, int ldt, double* q, int ldq, int* ifst, int* ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrexc_work")]
            public static extern int DtrexcWork(BLAS.LAYOUT matrixLayout, sbyte compq, int n, double* t, int ldt, double* q, int ldq, int* ifst, int* ilst, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrrfs")]
            public static extern int Dtrrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* a, int lda, double* b, int ldb, double* x,
                int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrrfs_work")]
            public static extern int DtrrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* a, int lda, double* b, int ldb,
                double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrsen")]
            public static extern int Dtrsen(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, int* select, int n, double* t, int ldt, double* q, int ldq, double* wr, double* wi,
                int* m, double* s, double* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrsen_work")]
            public static extern int DtrsenWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, int* select, int n, double* t, int ldt, double* q, int ldq, double* wr,
                double* wi, int* m, double* s, double* sep, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrsna")]
            public static extern int Dtrsna(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, double* t, int ldt, double* vl, int ldvl, double* vr, int ldvr,
                double* s, double* sep, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrsna_work")]
            public static extern int DtrsnaWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, double* t, int ldt, double* vl, int ldvl, double* vr,
                int ldvr, double* s, double* sep, int mm, int* m, double* work, int ldwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrsyl")]
            public static extern int Dtrsyl(BLAS.LAYOUT matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, double* a, int lda, double* b, int ldb, double* c, int ldc,
                double* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrsyl_work")]
            public static extern int DtrsylWork(BLAS.LAYOUT matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, double* a, int lda, double* b, int ldb, double* c,
                int ldc, double* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrtri")]
            public static extern int Dtrtri(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrtri_work")]
            public static extern int DtrtriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrtrs")]
            public static extern int Dtrtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrtrs_work")]
            public static extern int DtrtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrttf")]
            public static extern int Dtrttf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* a, int lda, double* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrttf_work")]
            public static extern int DtrttfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* a, int lda, double* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrttp")]
            public static extern int Dtrttp(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrttp_work")]
            public static extern int DtrttpWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtzrzf")]
            public static extern int Dtzrzf(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtzrzf_work")]
            public static extern int DtzrzfWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_cgetrfnpi")]
            public static extern int MklCgetrfnpi(BLAS.LAYOUT matrixLayout, int m, int n, int nfact, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_cgetrfnpi_work")]
            public static extern int MklCgetrfnpiWork(BLAS.LAYOUT matrixLayout, int m, int n, int nfact, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_ctppack")]
            public static extern int MklCtppack(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, System.IntPtr ap, int i, int j, int rows, int cols, System.IntPtr a,
                int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_ctppack_work")]
            public static extern int MklCtppackWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, System.IntPtr ap, int i, int j, int rows, int cols,
                System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_ctpunpack")]
            public static extern int MklCtpunpack(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, System.IntPtr ap, int i, int j, int rows, int cols,
                System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_ctpunpack_work")]
            public static extern int MklCtpunpackWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, System.IntPtr ap, int i, int j, int rows, int cols,
                System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_dgetrfnpi")]
            public static extern int MklDgetrfnpi(BLAS.LAYOUT matrixLayout, int m, int n, int nfact, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_dgetrfnpi_work")]
            public static extern int MklDgetrfnpiWork(BLAS.LAYOUT matrixLayout, int m, int n, int nfact, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_dtppack")]
            public static extern int MklDtppack(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, double* ap, int i, int j, int rows, int cols, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_dtppack_work")]
            public static extern int MklDtppackWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, double* ap, int i, int j, int rows, int cols, double* a,
                int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_dtpunpack")]
            public static extern int MklDtpunpack(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, double* ap, int i, int j, int rows, int cols, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_dtpunpack_work")]
            public static extern int MklDtpunpackWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, double* ap, int i, int j, int rows, int cols, double* a,
                int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_sgetrfnpi")]
            public static extern int MklSgetrfnpi(BLAS.LAYOUT matrixLayout, int m, int n, int nfact, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_sgetrfnpi_work")]
            public static extern int MklSgetrfnpiWork(BLAS.LAYOUT matrixLayout, int m, int n, int nfact, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_stppack")]
            public static extern int MklStppack(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, float* ap, int i, int j, int rows, int cols, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_stppack_work")]
            public static extern int MklStppackWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, float* ap, int i, int j, int rows, int cols, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_stpunpack")]
            public static extern int MklStpunpack(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, float* ap, int i, int j, int rows, int cols, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_stpunpack_work")]
            public static extern int MklStpunpackWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, float* ap, int i, int j, int rows, int cols, float* a,
                int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_zgetrfnpi")]
            public static extern int MklZgetrfnpi(BLAS.LAYOUT matrixLayout, int m, int n, int nfact, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_zgetrfnpi_work")]
            public static extern int MklZgetrfnpiWork(BLAS.LAYOUT matrixLayout, int m, int n, int nfact, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_ztppack")]
            public static extern int MklZtppack(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, System.IntPtr ap, int i, int j, int rows, int cols, System.IntPtr a,
                int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_ztppack_work")]
            public static extern int MklZtppackWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, System.IntPtr ap, int i, int j, int rows, int cols,
                System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_ztpunpack")]
            public static extern int MklZtpunpack(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, System.IntPtr ap, int i, int j, int rows, int cols,
                System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_ztpunpack_work")]
            public static extern int MklZtpunpackWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, System.IntPtr ap, int i, int j, int rows, int cols,
                System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sbbcsd")]
            public static extern int Sbbcsd(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, float* theta,
                float* phi, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* v2t, int ldv2t, float* b11d, float* b11e, float* b12d, float* b12e, float* b21d,
                float* b21e, float* b22d, float* b22e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sbbcsd_work")]
            public static extern int SbbcsdWork(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, float* theta,
                float* phi, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* v2t, int ldv2t, float* b11d, float* b11e, float* b12d, float* b12e, float* b21d,
                float* b21e, float* b22d, float* b22e, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sbdsdc")]
            public static extern int Sbdsdc(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte compq, int n, float* d, float* e, float* u, int ldu, float* vt, int ldvt, float* q,
                int* iq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sbdsdc_work")]
            public static extern int SbdsdcWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte compq, int n, float* d, float* e, float* u, int ldu, float* vt, int ldvt, float* q,
                int* iq, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sbdsqr")]
            public static extern int Sbdsqr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, float* d, float* e, float* vt, int ldvt, float* u, int ldu,
                float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sbdsqr_work")]
            public static extern int SbdsqrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, float* d, float* e, float* vt, int ldvt, float* u, int ldu,
                float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sbdsvdx")]
            public static extern int Sbdsvdx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* ns,
                float* s, float* z, int ldz, int* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sbdsvdx_work")]
            public static extern int SbdsvdxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu,
                int* ns, float* s, float* z, int ldz, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sdisna")]
            public static extern int Sdisna(sbyte job, int m, int n, float* d, float* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sdisna_work")]
            public static extern int SdisnaWork(sbyte job, int m, int n, float* d, float* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbbrd")]
            public static extern int Sgbbrd(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, float* ab, int ldab, float* d, float* e, float* q, int ldq,
                float* pt, int ldpt, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbbrd_work")]
            public static extern int SgbbrdWork(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, float* ab, int ldab, float* d, float* e, float* q,
                int ldq, float* pt, int ldpt, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbcon")]
            public static extern int Sgbcon(BLAS.LAYOUT matrixLayout, sbyte norm, int n, int kl, int ku, float* ab, int ldab, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbcon_work")]
            public static extern int SgbconWork(BLAS.LAYOUT matrixLayout, sbyte norm, int n, int kl, int ku, float* ab, int ldab, int* ipiv, float anorm, float* rcond, float* work,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbequ")]
            public static extern int Sgbequ(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd,
                float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbequ_work")]
            public static extern int SgbequWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd,
                float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbequb")]
            public static extern int Sgbequb(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd,
                float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbequb_work")]
            public static extern int SgbequbWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd,
                float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbrfs")]
            public static extern int Sgbrfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv,
                float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbrfs_work")]
            public static extern int SgbrfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv,
                float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbrfsx")]
            public static extern int Sgbrfsx(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb,
                int* ipiv, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp,
                int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbrfsx_work")]
            public static extern int SgbrfsxWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb,
                int ldafb, int* ipiv, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm,
                float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbsv")]
            public static extern int Sgbsv(BLAS.LAYOUT matrixLayout, int n, int kl, int ku, int nrhs, float* ab, int ldab, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbsv_work")]
            public static extern int SgbsvWork(BLAS.LAYOUT matrixLayout, int n, int kl, int ku, int nrhs, float* ab, int ldab, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbsvx")]
            public static extern int Sgbsvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb,
                int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* rpivot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbsvx_work")]
            public static extern int SgbsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb,
                int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbsvxx")]
            public static extern int Sgbsvxx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb,
                int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm,
                float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbsvxx_work")]
            public static extern int SgbsvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb,
                int ldafb, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds,
                float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbtrf")]
            public static extern int Sgbtrf(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbtrf_work")]
            public static extern int SgbtrfWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbtrs")]
            public static extern int Sgbtrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbtrs_work")]
            public static extern int SgbtrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgebak")]
            public static extern int Sgebak(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* scale, int m, float* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgebak_work")]
            public static extern int SgebakWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* scale, int m, float* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgebal")]
            public static extern int Sgebal(BLAS.LAYOUT matrixLayout, sbyte job, int n, float* a, int lda, int* ilo, int* ihi, float* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgebal_work")]
            public static extern int SgebalWork(BLAS.LAYOUT matrixLayout, sbyte job, int n, float* a, int lda, int* ilo, int* ihi, float* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgebrd")]
            public static extern int Sgebrd(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* d, float* e, float* tauq, float* taup);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgebrd_work")]
            public static extern int SgebrdWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* d, float* e, float* tauq, float* taup, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgecon")]
            public static extern int Sgecon(BLAS.LAYOUT matrixLayout, sbyte norm, int n, float* a, int lda, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgecon_work")]
            public static extern int SgeconWork(BLAS.LAYOUT matrixLayout, sbyte norm, int n, float* a, int lda, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeequ")]
            public static extern int Sgeequ(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeequ_work")]
            public static extern int SgeequWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeequb")]
            public static extern int Sgeequb(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeequb_work")]
            public static extern int SgeequbWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgees")]
            public static extern int Sgees(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, int n, float* a, int lda, int* sdim, float* wr, float* wi,
                float* vs, int ldvs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgees_work")]
            public static extern int SgeesWork(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, int n, float* a, int lda, int* sdim, float* wr, float* wi,
                float* vs, int ldvs, float* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeesx")]
            public static extern int Sgeesx(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, sbyte sense, int n, float* a, int lda, int* sdim, float* wr,
                float* wi, float* vs, int ldvs, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeesx_work")]
            public static extern int SgeesxWork(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, sbyte sense, int n, float* a, int lda, int* sdim,
                float* wr, float* wi, float* vs, int ldvs, float* rconde, float* rcondv, float* work, int lwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeev")]
            public static extern int Sgeev(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* wr, float* wi, float* vl, int ldvl, float* vr,
                int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeev_work")]
            public static extern int SgeevWork(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* wr, float* wi, float* vl, int ldvl, float* vr,
                int ldvr, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeevx")]
            public static extern int Sgeevx(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, float* a, int lda, float* wr, float* wi,
                float* vl, int ldvl, float* vr, int ldvr, int* ilo, int* ihi, float* scale, float* abnrm, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeevx_work")]
            public static extern int SgeevxWork(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, float* a, int lda, float* wr, float* wi,
                float* vl, int ldvl, float* vr, int ldvr, int* ilo, int* ihi, float* scale, float* abnrm, float* rconde, float* rcondv, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgehrd")]
            public static extern int Sgehrd(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgehrd_work")]
            public static extern int SgehrdWork(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgejsv")]
            public static extern int Sgejsv(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, float* a, int lda,
                float* sva, float* u, int ldu, float* v, int ldv, float* stat, int* istat);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgejsv_work")]
            public static extern int SgejsvWork(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, float* a, int lda,
                float* sva, float* u, int ldu, float* v, int ldv, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelq2")]
            public static extern int Sgelq2(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelq2_work")]
            public static extern int Sgelq2Work(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelqf")]
            public static extern int Sgelqf(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelqf_work")]
            public static extern int SgelqfWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgels")]
            public static extern int Sgels(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgels_work")]
            public static extern int SgelsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelsd")]
            public static extern int Sgelsd(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* s, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelsd_work")]
            public static extern int SgelsdWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* s, float rcond, int* rank,
                float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelss")]
            public static extern int Sgelss(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* s, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelss_work")]
            public static extern int SgelssWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* s, float rcond, int* rank,
                float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelsy")]
            public static extern int Sgelsy(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, int* jpvt, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelsy_work")]
            public static extern int SgelsyWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, int* jpvt, float rcond, int* rank,
                float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgemqrt")]
            public static extern int Sgemqrt(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, float* v, int ldv, float* t, int ldt, float* c,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgemqrt_work")]
            public static extern int SgemqrtWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, float* v, int ldv, float* t, int ldt,
                float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqlf")]
            public static extern int Sgeqlf(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqlf_work")]
            public static extern int SgeqlfWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqp3")]
            public static extern int Sgeqp3(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, int* jpvt, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqp3_work")]
            public static extern int Sgeqp3Work(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, int* jpvt, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqpf")]
            public static extern int Sgeqpf(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, int* jpvt, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqpf_work")]
            public static extern int SgeqpfWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, int* jpvt, float* tau, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqr2")]
            public static extern int Sgeqr2(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqr2_work")]
            public static extern int Sgeqr2Work(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqrf")]
            public static extern int Sgeqrf(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqrf_work")]
            public static extern int SgeqrfWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqrfp")]
            public static extern int Sgeqrfp(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqrfp_work")]
            public static extern int SgeqrfpWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqrt")]
            public static extern int Sgeqrt(BLAS.LAYOUT matrixLayout, int m, int n, int nb, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqrt2")]
            public static extern int Sgeqrt2(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqrt2_work")]
            public static extern int Sgeqrt2Work(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqrt3")]
            public static extern int Sgeqrt3(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqrt3_work")]
            public static extern int Sgeqrt3Work(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqrt_work")]
            public static extern int SgeqrtWork(BLAS.LAYOUT matrixLayout, int m, int n, int nb, float* a, int lda, float* t, int ldt, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgerfs")]
            public static extern int Sgerfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb,
                float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgerfs_work")]
            public static extern int SgerfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb,
                float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgerfsx")]
            public static extern int Sgerfsx(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* r,
                float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgerfsx_work")]
            public static extern int SgerfsxWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv,
                float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams,
                float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgerqf")]
            public static extern int Sgerqf(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgerqf_work")]
            public static extern int SgerqfWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesdd")]
            public static extern int Sgesdd(BLAS.LAYOUT matrixLayout, sbyte jobz, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* vt, int ldvt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesdd_work")]
            public static extern int SgesddWork(BLAS.LAYOUT matrixLayout, sbyte jobz, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* vt, int ldvt,
                float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesv")]
            public static extern int Sgesv(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesv_work")]
            public static extern int SgesvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvd")]
            public static extern int Sgesvd(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* vt, int ldvt,
                float* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvd_work")]
            public static extern int SgesvdWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* vt,
                int ldvt, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvdx")]
            public static extern int Sgesvdx(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, float* a, int lda, float vl, float vu, int il, int iu,
                int* ns, float* s, float* u, int ldu, float* vt, int ldvt, int* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvdx_work")]
            public static extern int SgesvdxWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, float* a, int lda, float vl, float vu, int il,
                int iu, int* ns, float* s, float* u, int ldu, float* vt, int ldvt, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvj")]
            public static extern int Sgesvj(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, float* a, int lda, float* sva, int mv, float* v, int ldv,
                float* stat);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvj_work")]
            public static extern int SgesvjWork(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, float* a, int lda, float* sva, int mv, float* v,
                int ldv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvx")]
            public static extern int Sgesvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv,
                sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* rpivot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvx_work")]
            public static extern int SgesvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv,
                sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvxx")]
            public static extern int Sgesvxx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv,
                sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm,
                float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvxx_work")]
            public static extern int SgesvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv,
                sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm,
                float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetf2")]
            public static extern int Sgetf2(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetf2_work")]
            public static extern int Sgetf2Work(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetrf")]
            public static extern int Sgetrf(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetrf2")]
            public static extern int Sgetrf2(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetrf2_work")]
            public static extern int Sgetrf2Work(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetrf_work")]
            public static extern int SgetrfWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetri")]
            public static extern int Sgetri(BLAS.LAYOUT matrixLayout, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetri_work")]
            public static extern int SgetriWork(BLAS.LAYOUT matrixLayout, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetrs")]
            public static extern int Sgetrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetrs_work")]
            public static extern int SgetrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggbak")]
            public static extern int Sggbak(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* lscale, float* rscale, int m, float* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggbak_work")]
            public static extern int SggbakWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* lscale, float* rscale, int m, float* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggbal")]
            public static extern int Sggbal(BLAS.LAYOUT matrixLayout, sbyte job, int n, float* a, int lda, float* b, int ldb, int* ilo, int* ihi, float* lscale, float* rscale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggbal_work")]
            public static extern int SggbalWork(BLAS.LAYOUT matrixLayout, sbyte job, int n, float* a, int lda, float* b, int ldb, int* ilo, int* ihi, float* lscale, float* rscale,
                float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgges")]
            public static extern int Sgges(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, float* a, int lda, float* b, int ldb,
                int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgges3")]
            public static extern int Sgges3(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, float* a, int lda, float* b, int ldb,
                int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgges3_work")]
            public static extern int Sgges3Work(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, float* a, int lda, float* b, int ldb,
                int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr, float* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgges_work")]
            public static extern int SggesWork(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, float* a, int lda, float* b, int ldb,
                int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr, float* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggesx")]
            public static extern int Sggesx(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, sbyte sense, int n, float* a, int lda, float* b,
                int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggesx_work")]
            public static extern int SggesxWork(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, sbyte sense, int n, float* a, int lda,
                float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr, float* rconde, float* rcondv, float* work,
                int lwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggev")]
            public static extern int Sggev(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai,
                float* beta, float* vl, int ldvl, float* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggev3")]
            public static extern int Sggev3(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai,
                float* beta, float* vl, int ldvl, float* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggev3_work")]
            public static extern int Sggev3Work(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai,
                float* beta, float* vl, int ldvl, float* vr, int ldvr, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggev_work")]
            public static extern int SggevWork(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai,
                float* beta, float* vl, int ldvl, float* vr, int ldvr, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggevx")]
            public static extern int Sggevx(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, float* a, int lda, float* b, int ldb,
                float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr, int* ilo, int* ihi, float* lscale, float* rscale, float* abnrm, float* bbnrm,
                float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggevx_work")]
            public static extern int SggevxWork(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, float* a, int lda, float* b, int ldb,
                float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr, int* ilo, int* ihi, float* lscale, float* rscale, float* abnrm, float* bbnrm,
                float* rconde, float* rcondv, float* work, int lwork, int* iwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggglm")]
            public static extern int Sggglm(BLAS.LAYOUT matrixLayout, int n, int m, int p, float* a, int lda, float* b, int ldb, float* d, float* x, float* y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggglm_work")]
            public static extern int SggglmWork(BLAS.LAYOUT matrixLayout, int n, int m, int p, float* a, int lda, float* b, int ldb, float* d, float* x, float* y, float* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgghd3")]
            public static extern int Sgghd3(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* a, int lda, float* b, int ldb, float* q, int ldq,
                float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgghd3_work")]
            public static extern int Sgghd3Work(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* a, int lda, float* b, int ldb, float* q,
                int ldq, float* z, int ldz, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgghrd")]
            public static extern int Sgghrd(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* a, int lda, float* b, int ldb, float* q, int ldq,
                float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgghrd_work")]
            public static extern int SgghrdWork(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* a, int lda, float* b, int ldb, float* q,
                int ldq, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgglse")]
            public static extern int Sgglse(BLAS.LAYOUT matrixLayout, int m, int n, int p, float* a, int lda, float* b, int ldb, float* c, float* d, float* x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgglse_work")]
            public static extern int SgglseWork(BLAS.LAYOUT matrixLayout, int m, int n, int p, float* a, int lda, float* b, int ldb, float* c, float* d, float* x, float* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggqrf")]
            public static extern int Sggqrf(BLAS.LAYOUT matrixLayout, int n, int m, int p, float* a, int lda, float* taua, float* b, int ldb, float* taub);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggqrf_work")]
            public static extern int SggqrfWork(BLAS.LAYOUT matrixLayout, int n, int m, int p, float* a, int lda, float* taua, float* b, int ldb, float* taub, float* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggrqf")]
            public static extern int Sggrqf(BLAS.LAYOUT matrixLayout, int m, int p, int n, float* a, int lda, float* taua, float* b, int ldb, float* taub);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggrqf_work")]
            public static extern int SggrqfWork(BLAS.LAYOUT matrixLayout, int m, int p, int n, float* a, int lda, float* taua, float* b, int ldb, float* taub, float* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggsvd")]
            public static extern int Sggsvd(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, float* a, int lda, float* b, int ldb,
                float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggsvd3")]
            public static extern int Sggsvd3(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, float* a, int lda, float* b,
                int ldb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggsvd3_work")]
            public static extern int Sggsvd3Work(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, float* a, int lda, float* b,
                int ldb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggsvd_work")]
            public static extern int SggsvdWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, float* a, int lda, float* b,
                int ldb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggsvp")]
            public static extern int Sggsvp(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, float* a, int lda, float* b, int ldb, float tola,
                float tolb, int* k, int* l, float* u, int ldu, float* v, int ldv, float* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggsvp3")]
            public static extern int Sggsvp3(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, float* a, int lda, float* b, int ldb, float tola,
                float tolb, int* k, int* l, float* u, int ldu, float* v, int ldv, float* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggsvp3_work")]
            public static extern int Sggsvp3Work(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, float* a, int lda, float* b, int ldb,
                float tola, float tolb, int* k, int* l, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* iwork, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggsvp_work")]
            public static extern int SggsvpWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, float* a, int lda, float* b, int ldb, float tola,
                float tolb, int* k, int* l, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* iwork, float* tau, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgtcon")]
            public static extern int Sgtcon(sbyte norm, int n, float* dl, float* d, float* du, float* du2, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgtcon_work")]
            public static extern int SgtconWork(sbyte norm, int n, float* dl, float* d, float* du, float* du2, int* ipiv, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgtrfs")]
            public static extern int Sgtrfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* dl, float* d, float* du, float* dlf, float* df, float* duf,
                float* du2, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgtrfs_work")]
            public static extern int SgtrfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* dl, float* d, float* du, float* dlf, float* df, float* duf,
                float* du2, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgtsv")]
            public static extern int Sgtsv(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* dl, float* d, float* du, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgtsv_work")]
            public static extern int SgtsvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* dl, float* d, float* du, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgtsvx")]
            public static extern int Sgtsvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, float* dl, float* d, float* du, float* dlf, float* df,
                float* duf, float* du2, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgtsvx_work")]
            public static extern int SgtsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, float* dl, float* d, float* du, float* dlf, float* df,
                float* duf, float* du2, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgttrf")]
            public static extern int Sgttrf(int n, float* dl, float* d, float* du, float* du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgttrf_work")]
            public static extern int SgttrfWork(int n, float* dl, float* d, float* du, float* du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgttrs")]
            public static extern int Sgttrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* dl, float* d, float* du, float* du2, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgttrs_work")]
            public static extern int SgttrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* dl, float* d, float* du, float* du2, int* ipiv, float* b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_shgeqz")]
            public static extern int Shgeqz(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* h, int ldh, float* t, int ldt,
                float* alphar, float* alphai, float* beta, float* q, int ldq, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_shgeqz_work")]
            public static extern int ShgeqzWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* h, int ldh, float* t, int ldt,
                float* alphar, float* alphai, float* beta, float* q, int ldq, float* z, int ldz, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_shsein")]
            public static extern int Shsein(BLAS.LAYOUT matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, float* h, int ldh, float* wr, float* wi, float* vl,
                int ldvl, float* vr, int ldvr, int mm, int* m, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_shsein_work")]
            public static extern int ShseinWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, float* h, int ldh, float* wr, float* wi,
                float* vl, int ldvl, float* vr, int ldvr, int mm, int* m, float* work, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_shseqr")]
            public static extern int Shseqr(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, float* h, int ldh, float* wr, float* wi, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_shseqr_work")]
            public static extern int ShseqrWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, float* h, int ldh, float* wr, float* wi, float* z,
                int ldz, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slacn2")]
            public static extern int Slacn2(int n, float* v, float* x, int* isgn, float* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slacn2_work")]
            public static extern int Slacn2Work(int n, float* v, float* x, int* isgn, float* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slacpy")]
            public static extern int Slacpy(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slacpy_work")]
            public static extern int SlacpyWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slag2d")]
            public static extern int Slag2d(BLAS.LAYOUT matrixLayout, int m, int n, float* sa, int ldsa, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slag2d_work")]
            public static extern int Slag2dWork(BLAS.LAYOUT matrixLayout, int m, int n, float* sa, int ldsa, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slagge")]
            public static extern int Slagge(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, float* d, float* a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slagge_work")]
            public static extern int SlaggeWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, float* d, float* a, int lda, int* iseed, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slagsy")]
            public static extern int Slagsy(BLAS.LAYOUT matrixLayout, int n, int k, float* d, float* a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slagsy_work")]
            public static extern int SlagsyWork(BLAS.LAYOUT matrixLayout, int n, int k, float* d, float* a, int lda, int* iseed, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slapmr")]
            public static extern int Slapmr(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, float* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slapmr_work")]
            public static extern int SlapmrWork(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, float* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slapmt")]
            public static extern int Slapmt(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, float* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slapmt_work")]
            public static extern int SlapmtWork(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, float* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slarfb")]
            public static extern int Slarfb(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, float* v, int ldv, float* t,
                int ldt, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slarfb_work")]
            public static extern int SlarfbWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, float* v, int ldv,
                float* t, int ldt, float* c, int ldc, float* work, int ldwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slarfg")]
            public static extern int Slarfg(int n, float* alpha, float* x, int incx, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slarfg_work")]
            public static extern int SlarfgWork(int n, float* alpha, float* x, int incx, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slarft")]
            public static extern int Slarft(BLAS.LAYOUT matrixLayout, sbyte direct, sbyte storev, int n, int k, float* v, int ldv, float* tau, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slarft_work")]
            public static extern int SlarftWork(BLAS.LAYOUT matrixLayout, sbyte direct, sbyte storev, int n, int k, float* v, int ldv, float* tau, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slarfx")]
            public static extern int Slarfx(BLAS.LAYOUT matrixLayout, sbyte side, int m, int n, float* v, float tau, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slarfx_work")]
            public static extern int SlarfxWork(BLAS.LAYOUT matrixLayout, sbyte side, int m, int n, float* v, float tau, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slarnv")]
            public static extern int Slarnv(int idist, int* iseed, int n, float* x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slarnv_work")]
            public static extern int SlarnvWork(int idist, int* iseed, int n, float* x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slartgp")]
            public static extern int Slartgp(float f, float g, float* cs, float* sn, float* r);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slartgp_work")]
            public static extern int SlartgpWork(float f, float g, float* cs, float* sn, float* r);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slartgs")]
            public static extern int Slartgs(float x, float y, float sigma, float* cs, float* sn);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slartgs_work")]
            public static extern int SlartgsWork(float x, float y, float sigma, float* cs, float* sn);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slascl")]
            public static extern int Slascl(BLAS.LAYOUT matrixLayout, sbyte type, int kl, int ku, float cfrom, float cto, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slascl_work")]
            public static extern int SlasclWork(BLAS.LAYOUT matrixLayout, sbyte type, int kl, int ku, float cfrom, float cto, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slaset")]
            public static extern int Slaset(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, float alpha, float beta, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slaset_work")]
            public static extern int SlasetWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, float alpha, float beta, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slasrt")]
            public static extern int Slasrt(sbyte id, int n, float* d);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slasrt_work")]
            public static extern int SlasrtWork(sbyte id, int n, float* d);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slaswp")]
            public static extern int Slaswp(BLAS.LAYOUT matrixLayout, int n, float* a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slaswp_work")]
            public static extern int SlaswpWork(BLAS.LAYOUT matrixLayout, int n, float* a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slatms")]
            public static extern int Slatms(BLAS.LAYOUT matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, float* d, int mode, float cond, float dmax, int kl, int ku,
                sbyte pack, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slatms_work")]
            public static extern int SlatmsWork(BLAS.LAYOUT matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, float* d, int mode, float cond, float dmax, int kl,
                int ku, sbyte pack, float* a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slauum")]
            public static extern int Slauum(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slauum_work")]
            public static extern int SlauumWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sopgtr")]
            public static extern int Sopgtr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, float* tau, float* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sopgtr_work")]
            public static extern int SopgtrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, float* tau, float* q, int ldq, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sopmtr")]
            public static extern int Sopmtr(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, float* ap, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sopmtr_work")]
            public static extern int SopmtrWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, float* ap, float* tau, float* c, int ldc,
                float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorbdb")]
            public static extern int Sorbdb(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, float* x11, int ldx11, float* x12, int ldx12, float* x21,
                int ldx21, float* x22, int ldx22, float* theta, float* phi, float* taup1, float* taup2, float* tauq1, float* tauq2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorbdb_work")]
            public static extern int SorbdbWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, float* x11, int ldx11, float* x12, int ldx12,
                float* x21, int ldx21, float* x22, int ldx22, float* theta, float* phi, float* taup1, float* taup2, float* tauq1, float* tauq2, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorcsd")]
            public static extern int Sorcsd(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q,
                float* x11, int ldx11, float* x12, int ldx12, float* x21, int ldx21, float* x22, int ldx22, float* theta, float* u1, int ldu1, float* u2, int ldu2, float* v1t,
                int ldv1t, float* v2t, int ldv2t);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorcsd2by1")]
            public static extern int Sorcsd2by1(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, float* x11, int ldx11, float* x21, int ldx21,
                float* theta, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorcsd2by1_work")]
            public static extern int Sorcsd2by1Work(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, float* x11, int ldx11, float* x21,
                int ldx21, float* theta, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorcsd_work")]
            public static extern int SorcsdWork(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q,
                float* x11, int ldx11, float* x12, int ldx12, float* x21, int ldx21, float* x22, int ldx22, float* theta, float* u1, int ldu1, float* u2, int ldu2, float* v1t,
                int ldv1t, float* v2t, int ldv2t, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorgbr")]
            public static extern int Sorgbr(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorgbr_work")]
            public static extern int SorgbrWork(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorghr")]
            public static extern int Sorghr(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorghr_work")]
            public static extern int SorghrWork(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorglq")]
            public static extern int Sorglq(BLAS.LAYOUT matrixLayout, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorglq_work")]
            public static extern int SorglqWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorgql")]
            public static extern int Sorgql(BLAS.LAYOUT matrixLayout, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorgql_work")]
            public static extern int SorgqlWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorgqr")]
            public static extern int Sorgqr(BLAS.LAYOUT matrixLayout, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorgqr_work")]
            public static extern int SorgqrWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorgrq")]
            public static extern int Sorgrq(BLAS.LAYOUT matrixLayout, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorgrq_work")]
            public static extern int SorgrqWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorgtr")]
            public static extern int Sorgtr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorgtr_work")]
            public static extern int SorgtrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormbr")]
            public static extern int Sormbr(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormbr_work")]
            public static extern int SormbrWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c,
                int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormhr")]
            public static extern int Sormhr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, float* a, int lda, float* tau, float* c,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormhr_work")]
            public static extern int SormhrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, float* a, int lda, float* tau, float* c,
                int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormlq")]
            public static extern int Sormlq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormlq_work")]
            public static extern int SormlqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc,
                float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormql")]
            public static extern int Sormql(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormql_work")]
            public static extern int SormqlWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc,
                float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormqr")]
            public static extern int Sormqr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormqr_work")]
            public static extern int SormqrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc,
                float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormrq")]
            public static extern int Sormrq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormrq_work")]
            public static extern int SormrqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc,
                float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormrz")]
            public static extern int Sormrz(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormrz_work")]
            public static extern int SormrzWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, float* a, int lda, float* tau, float* c,
                int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormtr")]
            public static extern int Sormtr(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormtr_work")]
            public static extern int SormtrWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, float* a, int lda, float* tau, float* c, int ldc,
                float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbcon")]
            public static extern int Spbcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, float* ab, int ldab, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbcon_work")]
            public static extern int SpbconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, float* ab, int ldab, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbequ")]
            public static extern int Spbequ(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, float* ab, int ldab, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbequ_work")]
            public static extern int SpbequWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, float* ab, int ldab, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbrfs")]
            public static extern int Spbrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* afb, int ldafb, float* b, int ldb, float* x,
                int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbrfs_work")]
            public static extern int SpbrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* afb, int ldafb, float* b, int ldb,
                float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbstf")]
            public static extern int Spbstf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kb, float* bb, int ldbb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbstf_work")]
            public static extern int SpbstfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kb, float* bb, int ldbb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbsv")]
            public static extern int Spbsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbsv_work")]
            public static extern int SpbsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbsvx")]
            public static extern int Spbsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* afb, int ldafb, sbyte* equed,
                float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbsvx_work")]
            public static extern int SpbsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* afb, int ldafb, sbyte* equed,
                float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbtrf")]
            public static extern int Spbtrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, float* ab, int ldab);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbtrf_work")]
            public static extern int SpbtrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, float* ab, int ldab);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbtrs")]
            public static extern int Spbtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbtrs_work")]
            public static extern int SpbtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spftrf")]
            public static extern int Spftrf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spftrf_work")]
            public static extern int SpftrfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spftri")]
            public static extern int Spftri(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spftri_work")]
            public static extern int SpftriWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spftrs")]
            public static extern int Spftrs(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, float* a, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spftrs_work")]
            public static extern int SpftrsWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, float* a, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spocon")]
            public static extern int Spocon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spocon_work")]
            public static extern int SpoconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spoequ")]
            public static extern int Spoequ(BLAS.LAYOUT matrixLayout, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spoequ_work")]
            public static extern int SpoequWork(BLAS.LAYOUT matrixLayout, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spoequb")]
            public static extern int Spoequb(BLAS.LAYOUT matrixLayout, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spoequb_work")]
            public static extern int SpoequbWork(BLAS.LAYOUT matrixLayout, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sporfs")]
            public static extern int Sporfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, float* b, int ldb, float* x, int ldx,
                float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sporfs_work")]
            public static extern int SporfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, float* b, int ldb, float* x, int ldx,
                float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sporfsx")]
            public static extern int Sporfsx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, float* s, float* b,
                int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sporfsx_work")]
            public static extern int SporfsxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, float* s, float* b,
                int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sposv")]
            public static extern int Sposv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sposv_work")]
            public static extern int SposvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sposvx")]
            public static extern int Sposvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, sbyte* equed, float* s,
                float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sposvx_work")]
            public static extern int SposvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, sbyte* equed, float* s,
                float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sposvxx")]
            public static extern int Sposvxx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, sbyte* equed, float* s,
                float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams,
                float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sposvxx_work")]
            public static extern int SposvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, sbyte* equed, float* s,
                float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams,
                float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spotrf")]
            public static extern int Spotrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spotrf2")]
            public static extern int Spotrf2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spotrf2_work")]
            public static extern int Spotrf2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spotrf_work")]
            public static extern int SpotrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spotri")]
            public static extern int Spotri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spotri_work")]
            public static extern int SpotriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spotrs")]
            public static extern int Spotrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spotrs_work")]
            public static extern int SpotrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sppcon")]
            public static extern int Sppcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sppcon_work")]
            public static extern int SppconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sppequ")]
            public static extern int Sppequ(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sppequ_work")]
            public static extern int SppequWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spprfs")]
            public static extern int Spprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* afp, float* b, int ldb, float* x, int ldx, float* ferr,
                float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spprfs_work")]
            public static extern int SpprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* afp, float* b, int ldb, float* x, int ldx, float* ferr,
                float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sppsv")]
            public static extern int Sppsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sppsv_work")]
            public static extern int SppsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sppsvx")]
            public static extern int Sppsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* ap, float* afp, sbyte* equed, float* s, float* b, int ldb,
                float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sppsvx_work")]
            public static extern int SppsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* ap, float* afp, sbyte* equed, float* s, float* b, int ldb,
                float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spptrf")]
            public static extern int Spptrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spptrf_work")]
            public static extern int SpptrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spptri")]
            public static extern int Spptri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spptri_work")]
            public static extern int SpptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spptrs")]
            public static extern int Spptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spptrs_work")]
            public static extern int SpptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spstrf")]
            public static extern int Spstrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* piv, int* rank, float tol);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spstrf_work")]
            public static extern int SpstrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* piv, int* rank, float tol, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sptcon")]
            public static extern int Sptcon(int n, float* d, float* e, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sptcon_work")]
            public static extern int SptconWork(int n, float* d, float* e, float anorm, float* rcond, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spteqr")]
            public static extern int Spteqr(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spteqr_work")]
            public static extern int SpteqrWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sptrfs")]
            public static extern int Sptrfs(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* d, float* e, float* df, float* ef, float* b, int ldb, float* x, int ldx, float* ferr,
                float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sptrfs_work")]
            public static extern int SptrfsWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* d, float* e, float* df, float* ef, float* b, int ldb, float* x, int ldx,
                float* ferr, float* berr, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sptsv")]
            public static extern int Sptsv(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* d, float* e, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sptsv_work")]
            public static extern int SptsvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* d, float* e, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sptsvx")]
            public static extern int Sptsvx(BLAS.LAYOUT matrixLayout, sbyte fact, int n, int nrhs, float* d, float* e, float* df, float* ef, float* b, int ldb, float* x, int ldx,
                float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sptsvx_work")]
            public static extern int SptsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, int n, int nrhs, float* d, float* e, float* df, float* ef, float* b, int ldb, float* x,
                int ldx, float* rcond, float* ferr, float* berr, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spttrf")]
            public static extern int Spttrf(int n, float* d, float* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spttrf_work")]
            public static extern int SpttrfWork(int n, float* d, float* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spttrs")]
            public static extern int Spttrs(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* d, float* e, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spttrs_work")]
            public static extern int SpttrsWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* d, float* e, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbev")]
            public static extern int Ssbev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbev_work")]
            public static extern int SsbevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbevd")]
            public static extern int Ssbevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbevd_work")]
            public static extern int SsbevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz, float* work,
                int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbevx")]
            public static extern int Ssbevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, float* ab, int ldab, float* q, int ldq, float vl,
                float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbevx_work")]
            public static extern int SsbevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, float* ab, int ldab, float* q, int ldq, float vl,
                float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbgst")]
            public static extern int Ssbgst(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* x, int ldx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbgst_work")]
            public static extern int SsbgstWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* x,
                int ldx, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbgv")]
            public static extern int Ssbgv(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* w, float* z,
                int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbgv_work")]
            public static extern int SsbgvWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* w,
                float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbgvd")]
            public static extern int Ssbgvd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* w, float* z,
                int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbgvd_work")]
            public static extern int SsbgvdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* w,
                float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbgvx")]
            public static extern int Ssbgvx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb,
                float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbgvx_work")]
            public static extern int SsbgvxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb,
                float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbtrd")]
            public static extern int Ssbtrd(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int kd, float* ab, int ldab, float* d, float* e, float* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbtrd_work")]
            public static extern int SsbtrdWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int kd, float* ab, int ldab, float* d, float* e, float* q, int ldq,
                float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssfrk")]
            public static extern int Ssfrk(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, float alpha, float* a, int lda, float beta,
                float* c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssfrk_work")]
            public static extern int SsfrkWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, float alpha, float* a, int lda, float beta,
                float* c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspcon")]
            public static extern int Sspcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspcon_work")]
            public static extern int SspconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, int* ipiv, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspev")]
            public static extern int Sspev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* ap, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspev_work")]
            public static extern int SspevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* ap, float* w, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspevd")]
            public static extern int Sspevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* ap, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspevd_work")]
            public static extern int SspevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* ap, float* w, float* z, int ldz, float* work, int lwork, int* iwork,
                int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspevx")]
            public static extern int Sspevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* ap, float vl, float vu, int il, int iu, float abstol,
                int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspevx_work")]
            public static extern int SspevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* ap, float vl, float vu, int il, int iu, float abstol,
                int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspgst")]
            public static extern int Sspgst(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, float* ap, float* bp);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspgst_work")]
            public static extern int SspgstWork(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, float* ap, float* bp);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspgv")]
            public static extern int Sspgv(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* ap, float* bp, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspgv_work")]
            public static extern int SspgvWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* ap, float* bp, float* w, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspgvd")]
            public static extern int Sspgvd(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* ap, float* bp, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspgvd_work")]
            public static extern int SspgvdWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* ap, float* bp, float* w, float* z, int ldz, float* work,
                int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspgvx")]
            public static extern int Sspgvx(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, float* ap, float* bp, float vl, float vu, int il,
                int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspgvx_work")]
            public static extern int SspgvxWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, float* ap, float* bp, float vl, float vu, int il,
                int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssprfs")]
            public static extern int Ssprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* afp, int* ipiv, float* b, int ldb, float* x, int ldx,
                float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssprfs_work")]
            public static extern int SsprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* afp, int* ipiv, float* b, int ldb, float* x, int ldx,
                float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspsv")]
            public static extern int Sspsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspsv_work")]
            public static extern int SspsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspsvx")]
            public static extern int Sspsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* ap, float* afp, int* ipiv, float* b, int ldb, float* x,
                int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspsvx_work")]
            public static extern int SspsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* ap, float* afp, int* ipiv, float* b, int ldb, float* x,
                int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssptrd")]
            public static extern int Ssptrd(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, float* d, float* e, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssptrd_work")]
            public static extern int SsptrdWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, float* d, float* e, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssptrf")]
            public static extern int Ssptrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssptrf_work")]
            public static extern int SsptrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssptri")]
            public static extern int Ssptri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssptri_work")]
            public static extern int SsptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, int* ipiv, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssptrs")]
            public static extern int Ssptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssptrs_work")]
            public static extern int SsptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstebz")]
            public static extern int Sstebz(sbyte range, sbyte order, int n, float vl, float vu, int il, int iu, float abstol, float* d, float* e, int* m, int* nsplit, float* w,
                int* iblock, int* isplit);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstebz_work")]
            public static extern int SstebzWork(sbyte range, sbyte order, int n, float vl, float vu, int il, int iu, float abstol, float* d, float* e, int* m, int* nsplit,
                float* w, int* iblock, int* isplit, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstedc")]
            public static extern int Sstedc(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstedc_work")]
            public static extern int SstedcWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz, float* work, int lwork, int* iwork,
                int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstegr")]
            public static extern int Sstegr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m,
                float* w, float* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstegr_work")]
            public static extern int SstegrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol,
                int* m, float* w, float* z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstein")]
            public static extern int Sstein(BLAS.LAYOUT matrixLayout, int n, float* d, float* e, int m, float* w, int* iblock, int* isplit, float* z, int ldz, int* ifailv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstein_work")]
            public static extern int SsteinWork(BLAS.LAYOUT matrixLayout, int n, float* d, float* e, int m, float* w, int* iblock, int* isplit, float* z, int ldz, float* work,
                int* iwork, int* ifailv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstemr")]
            public static extern int Sstemr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* m, float* w,
                float* z, int ldz, int nzc, int* isuppz, int* tryrac);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstemr_work")]
            public static extern int SstemrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* m, float* w,
                float* z, int ldz, int nzc, int* isuppz, int* tryrac, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssteqr")]
            public static extern int Ssteqr(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssteqr_work")]
            public static extern int SsteqrWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssterf")]
            public static extern int Ssterf(int n, float* d, float* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssterf_work")]
            public static extern int SsterfWork(int n, float* d, float* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstev")]
            public static extern int Sstev(BLAS.LAYOUT matrixLayout, sbyte jobz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstev_work")]
            public static extern int SstevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, int n, float* d, float* e, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstevd")]
            public static extern int Sstevd(BLAS.LAYOUT matrixLayout, sbyte jobz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstevd_work")]
            public static extern int SstevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, int n, float* d, float* e, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstevr")]
            public static extern int Sstevr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m,
                float* w, float* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstevr_work")]
            public static extern int SstevrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol,
                int* m, float* w, float* z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstevx")]
            public static extern int Sstevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m,
                float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstevx_work")]
            public static extern int SstevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol,
                int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssycon")]
            public static extern int Ssycon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssycon_work")]
            public static extern int SsyconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyconv")]
            public static extern int Ssyconv(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte way, int n, float* a, int lda, int* ipiv, float* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyconv_work")]
            public static extern int SsyconvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte way, int n, float* a, int lda, int* ipiv, float* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyequb")]
            public static extern int Ssyequb(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyequb_work")]
            public static extern int SsyequbWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* s, float* scond, float* amax, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyev")]
            public static extern int Ssyev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyev_work")]
            public static extern int SsyevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevd")]
            public static extern int Ssyevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevd_work")]
            public static extern int SsyevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w, float* work, int lwork, int* iwork,
                int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevr")]
            public static extern int Ssyevr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, float* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevr_work")]
            public static extern int SsyevrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, float* z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevx")]
            public static extern int Ssyevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevx_work")]
            public static extern int SsyevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssygst")]
            public static extern int Ssygst(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssygst_work")]
            public static extern int SsygstWork(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssygv")]
            public static extern int Ssygv(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssygv_work")]
            public static extern int SsygvWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w, float* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssygvd")]
            public static extern int Ssygvd(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssygvd_work")]
            public static extern int SsygvdWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w, float* work,
                int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssygvx")]
            public static extern int Ssygvx(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float vl,
                float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssygvx_work")]
            public static extern int SsygvxWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float vl,
                float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyrfs")]
            public static extern int Ssyrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb, float* x,
                int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyrfs_work")]
            public static extern int SsyrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb,
                float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyrfsx")]
            public static extern int Ssyrfsx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* s,
                float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyrfsx_work")]
            public static extern int SsyrfsxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* s,
                float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params,
                float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysv")]
            public static extern int Ssysv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysv_rook")]
            public static extern int SsysvRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysv_rook_work")]
            public static extern int SsysvRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysv_work")]
            public static extern int SsysvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysvx")]
            public static extern int Ssysvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb,
                float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysvx_work")]
            public static extern int SsysvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b,
                int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysvxx")]
            public static extern int Ssysvxx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed,
                float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams,
                float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysvxx_work")]
            public static extern int SsysvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed,
                float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams,
                float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyswapr")]
            public static extern int Ssyswapr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyswapr_work")]
            public static extern int SsyswaprWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrd")]
            public static extern int Ssytrd(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* d, float* e, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrd_work")]
            public static extern int SsytrdWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* d, float* e, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrf")]
            public static extern int Ssytrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrf_rook")]
            public static extern int SsytrfRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrf_rook_work")]
            public static extern int SsytrfRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrf_work")]
            public static extern int SsytrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytri")]
            public static extern int Ssytri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytri2")]
            public static extern int Ssytri2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytri2_work")]
            public static extern int Ssytri2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytri2x")]
            public static extern int Ssytri2x(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytri2x_work")]
            public static extern int Ssytri2xWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytri_work")]
            public static extern int SsytriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs")]
            public static extern int Ssytrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs2")]
            public static extern int Ssytrs2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs2_work")]
            public static extern int Ssytrs2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs_rook")]
            public static extern int SsytrsRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs_rook_work")]
            public static extern int SsytrsRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs_work")]
            public static extern int SsytrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stbcon")]
            public static extern int Stbcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, float* ab, int ldab, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stbcon_work")]
            public static extern int StbconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, float* ab, int ldab, float* rcond, float* work,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stbrfs")]
            public static extern int Stbrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb,
                float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stbrfs_work")]
            public static extern int StbrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb,
                float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stbtrs")]
            public static extern int Stbtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stbtrs_work")]
            public static extern int StbtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, float* ab, int ldab, float* b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stfsm")]
            public static extern int Stfsm(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, float alpha, float* a,
                float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stfsm_work")]
            public static extern int StfsmWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, float alpha, float* a,
                float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stftri")]
            public static extern int Stftri(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, float* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stftri_work")]
            public static extern int StftriWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, float* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stfttp")]
            public static extern int Stfttp(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* arf, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stfttp_work")]
            public static extern int StfttpWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* arf, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stfttr")]
            public static extern int Stfttr(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* arf, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stfttr_work")]
            public static extern int StfttrWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* arf, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgevc")]
            public static extern int Stgevc(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, float* s, int lds, float* p, int ldp, float* vl, int ldvl,
                float* vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgevc_work")]
            public static extern int StgevcWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, float* s, int lds, float* p, int ldp, float* vl, int ldvl,
                float* vr, int ldvr, int mm, int* m, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgexc")]
            public static extern int Stgexc(BLAS.LAYOUT matrixLayout, int wantq, int wantz, int n, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz,
                int* ifst, int* ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgexc_work")]
            public static extern int StgexcWork(BLAS.LAYOUT matrixLayout, int wantq, int wantz, int n, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz,
                int* ifst, int* ilst, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgsen")]
            public static extern int Stgsen(BLAS.LAYOUT matrixLayout, int ijob, int wantq, int wantz, int* select, int n, float* a, int lda, float* b, int ldb, float* alphar,
                float* alphai, float* beta, float* q, int ldq, float* z, int ldz, int* m, float* pl, float* pr, float* dif);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgsen_work")]
            public static extern int StgsenWork(BLAS.LAYOUT matrixLayout, int ijob, int wantq, int wantz, int* select, int n, float* a, int lda, float* b, int ldb, float* alphar,
                float* alphai, float* beta, float* q, int ldq, float* z, int ldz, int* m, float* pl, float* pr, float* dif, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgsja")]
            public static extern int Stgsja(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, float* a, int lda, float* b, int ldb,
                float tola, float tolb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* ncycle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgsja_work")]
            public static extern int StgsjaWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, float* a, int lda, float* b,
                int ldb, float tola, float tolb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, float* work, int* ncycle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgsna")]
            public static extern int Stgsna(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, float* a, int lda, float* b, int ldb, float* vl, int ldvl,
                float* vr, int ldvr, float* s, float* dif, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgsna_work")]
            public static extern int StgsnaWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, float* a, int lda, float* b, int ldb, float* vl, int ldvl,
                float* vr, int ldvr, float* s, float* dif, int mm, int* m, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgsyl")]
            public static extern int Stgsyl(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, float* a, int lda, float* b, int ldb, float* c, int ldc, float* d,
                int ldd, float* e, int lde, float* f, int ldf, float* scale, float* dif);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgsyl_work")]
            public static extern int StgsylWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, float* a, int lda, float* b, int ldb, float* c, int ldc,
                float* d, int ldd, float* e, int lde, float* f, int ldf, float* scale, float* dif, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpcon")]
            public static extern int Stpcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, float* ap, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpcon_work")]
            public static extern int StpconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, float* ap, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpmqrt")]
            public static extern int Stpmqrt(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, float* v, int ldv, float* t, int ldt,
                float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpmqrt_work")]
            public static extern int StpmqrtWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, float* v, int ldv, float* t, int ldt,
                float* a, int lda, float* b, int ldb, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpqrt")]
            public static extern int Stpqrt(BLAS.LAYOUT matrixLayout, int m, int n, int l, int nb, float* a, int lda, float* b, int ldb, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpqrt2")]
            public static extern int Stpqrt2(BLAS.LAYOUT matrixLayout, int m, int n, int l, float* a, int lda, float* b, int ldb, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpqrt2_work")]
            public static extern int Stpqrt2Work(BLAS.LAYOUT matrixLayout, int m, int n, int l, float* a, int lda, float* b, int ldb, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpqrt_work")]
            public static extern int StpqrtWork(BLAS.LAYOUT matrixLayout, int m, int n, int l, int nb, float* a, int lda, float* b, int ldb, float* t, int ldt, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stprfb")]
            public static extern int Stprfb(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, float* v, int ldv,
                float* t, int ldt, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stprfb_work")]
            public static extern int StprfbWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, float* v, int ldv,
                float* t, int ldt, float* a, int lda, float* b, int ldb, float* work, int ldwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stprfs")]
            public static extern int Stprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* ap, float* b, int ldb, float* x, int ldx,
                float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stprfs_work")]
            public static extern int StprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* ap, float* b, int ldb, float* x,
                int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stptri")]
            public static extern int Stptri(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stptri_work")]
            public static extern int StptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stptrs")]
            public static extern int Stptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stptrs_work")]
            public static extern int StptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpttf")]
            public static extern int Stpttf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* ap, float* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpttf_work")]
            public static extern int StpttfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* ap, float* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpttr")]
            public static extern int Stpttr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpttr_work")]
            public static extern int StpttrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strcon")]
            public static extern int Strcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, float* a, int lda, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strcon_work")]
            public static extern int StrconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, float* a, int lda, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strevc")]
            public static extern int Strevc(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, float* t, int ldt, float* vl, int ldvl, float* vr, int ldvr,
                int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strevc_work")]
            public static extern int StrevcWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, float* t, int ldt, float* vl, int ldvl, float* vr, int ldvr,
                int mm, int* m, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strexc")]
            public static extern int Strexc(BLAS.LAYOUT matrixLayout, sbyte compq, int n, float* t, int ldt, float* q, int ldq, int* ifst, int* ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strexc_work")]
            public static extern int StrexcWork(BLAS.LAYOUT matrixLayout, sbyte compq, int n, float* t, int ldt, float* q, int ldq, int* ifst, int* ilst, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strrfs")]
            public static extern int Strrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* a, int lda, float* b, int ldb, float* x,
                int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strrfs_work")]
            public static extern int StrrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* a, int lda, float* b, int ldb, float* x,
                int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strsen")]
            public static extern int Strsen(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, int* select, int n, float* t, int ldt, float* q, int ldq, float* wr, float* wi,
                int* m, float* s, float* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strsen_work")]
            public static extern int StrsenWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, int* select, int n, float* t, int ldt, float* q, int ldq, float* wr, float* wi,
                int* m, float* s, float* sep, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strsna")]
            public static extern int Strsna(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, float* t, int ldt, float* vl, int ldvl, float* vr, int ldvr,
                float* s, float* sep, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strsna_work")]
            public static extern int StrsnaWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, float* t, int ldt, float* vl, int ldvl, float* vr, int ldvr,
                float* s, float* sep, int mm, int* m, float* work, int ldwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strsyl")]
            public static extern int Strsyl(BLAS.LAYOUT matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, float* a, int lda, float* b, int ldb, float* c, int ldc,
                float* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strsyl_work")]
            public static extern int StrsylWork(BLAS.LAYOUT matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, float* a, int lda, float* b, int ldb, float* c, int ldc,
                float* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strtri")]
            public static extern int Strtri(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strtri_work")]
            public static extern int StrtriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strtrs")]
            public static extern int Strtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strtrs_work")]
            public static extern int StrtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strttf")]
            public static extern int Strttf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* a, int lda, float* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strttf_work")]
            public static extern int StrttfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* a, int lda, float* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strttp")]
            public static extern int Strttp(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strttp_work")]
            public static extern int StrttpWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stzrzf")]
            public static extern int Stzrzf(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stzrzf_work")]
            public static extern int StzrzfWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zbbcsd")]
            public static extern int Zbbcsd(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, double* theta,
                double* phi, System.IntPtr u1, int ldu1, System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t, System.IntPtr v2t, int ldv2t, double* b11d, double* b11e,
                double* b12d, double* b12e, double* b21d, double* b21e, double* b22d, double* b22e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zbbcsd_work")]
            public static extern int ZbbcsdWork(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q,
                double* theta, double* phi, System.IntPtr u1, int ldu1, System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t, System.IntPtr v2t, int ldv2t, double* b11d,
                double* b11e, double* b12d, double* b12e, double* b21d, double* b21e, double* b22d, double* b22e, double* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zbdsqr")]
            public static extern int Zbdsqr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, double* d, double* e, System.IntPtr vt, int ldvt,
                System.IntPtr u, int ldu, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zbdsqr_work")]
            public static extern int ZbdsqrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, double* d, double* e, System.IntPtr vt, int ldvt,
                System.IntPtr u, int ldu, System.IntPtr c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zcgesv")]
            public static extern int Zcgesv(BLAS.LAYOUT matrixLayout, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx,
                int* iter);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zcgesv_work")]
            public static extern int ZcgesvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx,
                System.IntPtr work, System.IntPtr swork, double* rwork, int* iter);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zcposv")]
            public static extern int Zcposv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr x, int ldx,
                int* iter);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zcposv_work")]
            public static extern int ZcposvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr x, int ldx,
                System.IntPtr work, System.IntPtr swork, double* rwork, int* iter);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbbrd")]
            public static extern int Zgbbrd(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, System.IntPtr ab, int ldab, double* d, double* e,
                System.IntPtr q, int ldq, System.IntPtr pt, int ldpt, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbbrd_work")]
            public static extern int ZgbbrdWork(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, System.IntPtr ab, int ldab, double* d, double* e,
                System.IntPtr q, int ldq, System.IntPtr pt, int ldpt, System.IntPtr c, int ldc, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbcon")]
            public static extern int Zgbcon(BLAS.LAYOUT matrixLayout, sbyte norm, int n, int kl, int ku, System.IntPtr ab, int ldab, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbcon_work")]
            public static extern int ZgbconWork(BLAS.LAYOUT matrixLayout, sbyte norm, int n, int kl, int ku, System.IntPtr ab, int ldab, int* ipiv, double anorm, double* rcond,
                System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbequ")]
            public static extern int Zgbequ(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, double* r, double* c, double* rowcnd,
                double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbequ_work")]
            public static extern int ZgbequWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, double* r, double* c, double* rowcnd,
                double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbequb")]
            public static extern int Zgbequb(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, double* r, double* c, double* rowcnd,
                double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbequb_work")]
            public static extern int ZgbequbWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, double* r, double* c, double* rowcnd,
                double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbrfs")]
            public static extern int Zgbrfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb,
                int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbrfs_work")]
            public static extern int ZgbrfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb,
                int ldafb, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbrfsx")]
            public static extern int Zgbrfsx(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab,
                System.IntPtr afb, int ldafb, int* ipiv, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds,
                double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbrfsx_work")]
            public static extern int ZgbrfsxWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab,
                System.IntPtr afb, int ldafb, int* ipiv, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds,
                double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbsv")]
            public static extern int Zgbsv(BLAS.LAYOUT matrixLayout, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbsv_work")]
            public static extern int ZgbsvWork(BLAS.LAYOUT matrixLayout, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbsvx")]
            public static extern int Zgbsvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb,
                int ldafb, int* ipiv, sbyte* equed, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr,
                double* rpivot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbsvx_work")]
            public static extern int ZgbsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab,
                System.IntPtr afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr,
                double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbsvxx")]
            public static extern int Zgbsvxx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb,
                int ldafb, int* ipiv, sbyte* equed, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr,
                int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbsvxx_work")]
            public static extern int ZgbsvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab,
                System.IntPtr afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* rpvgrw,
                double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbtrf")]
            public static extern int Zgbtrf(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbtrf_work")]
            public static extern int ZgbtrfWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbtrs")]
            public static extern int Zgbtrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, int* ipiv, System.IntPtr b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgbtrs_work")]
            public static extern int ZgbtrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, int* ipiv, System.IntPtr b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgebak")]
            public static extern int Zgebak(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* scale, int m, System.IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgebak_work")]
            public static extern int ZgebakWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* scale, int m, System.IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgebal")]
            public static extern int Zgebal(BLAS.LAYOUT matrixLayout, sbyte job, int n, System.IntPtr a, int lda, int* ilo, int* ihi, double* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgebal_work")]
            public static extern int ZgebalWork(BLAS.LAYOUT matrixLayout, sbyte job, int n, System.IntPtr a, int lda, int* ilo, int* ihi, double* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgebrd")]
            public static extern int Zgebrd(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, double* d, double* e, System.IntPtr tauq, System.IntPtr taup);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgebrd_work")]
            public static extern int ZgebrdWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, double* d, double* e, System.IntPtr tauq, System.IntPtr taup,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgecon")]
            public static extern int Zgecon(BLAS.LAYOUT matrixLayout, sbyte norm, int n, System.IntPtr a, int lda, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgecon_work")]
            public static extern int ZgeconWork(BLAS.LAYOUT matrixLayout, sbyte norm, int n, System.IntPtr a, int lda, double anorm, double* rcond, System.IntPtr work,
                double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeequ")]
            public static extern int Zgeequ(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeequ_work")]
            public static extern int ZgeequWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, double* r, double* c, double* rowcnd, double* colcnd,
                double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeequb")]
            public static extern int Zgeequb(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeequb_work")]
            public static extern int ZgeequbWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, double* r, double* c, double* rowcnd, double* colcnd,
                double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgees")]
            public static extern int Zgees(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, int n, System.IntPtr a, int lda, int* sdim, System.IntPtr w,
                System.IntPtr vs, int ldvs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgees_work")]
            public static extern int ZgeesWork(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, int n, System.IntPtr a, int lda, int* sdim, System.IntPtr w,
                System.IntPtr vs, int ldvs, System.IntPtr work, int lwork, double* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeesx")]
            public static extern int Zgeesx(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, sbyte sense, int n, System.IntPtr a, int lda, int* sdim,
                System.IntPtr w, System.IntPtr vs, int ldvs, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeesx_work")]
            public static extern int ZgeesxWork(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, sbyte sense, int n, System.IntPtr a, int lda, int* sdim,
                System.IntPtr w, System.IntPtr vs, int ldvs, double* rconde, double* rcondv, System.IntPtr work, int lwork, double* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeev")]
            public static extern int Zgeev(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr w, System.IntPtr vl, int ldvl,
                System.IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeev_work")]
            public static extern int ZgeevWork(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr w, System.IntPtr vl, int ldvl,
                System.IntPtr vr, int ldvr, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeevx")]
            public static extern int Zgeevx(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, System.IntPtr a, int lda, System.IntPtr w,
                System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int* ilo, int* ihi, double* scale, double* abnrm, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeevx_work")]
            public static extern int ZgeevxWork(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, System.IntPtr a, int lda, System.IntPtr w,
                System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int* ilo, int* ihi, double* scale, double* abnrm, double* rconde, double* rcondv, System.IntPtr work,
                int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgehrd")]
            public static extern int Zgehrd(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgehrd_work")]
            public static extern int ZgehrdWork(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgejsv")]
            public static extern int Zgejsv(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, System.IntPtr a,
                int lda, double* sva, System.IntPtr u, int ldu, System.IntPtr v, int ldv, double* stat, int* istat);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgejsv_work")]
            public static extern int ZgejsvWork(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, System.IntPtr a,
                int lda, double* sva, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr cwork, int lwork, double* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgelq2")]
            public static extern int Zgelq2(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgelq2_work")]
            public static extern int Zgelq2Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgelqf")]
            public static extern int Zgelqf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgelqf_work")]
            public static extern int ZgelqfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgels")]
            public static extern int Zgels(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgels_work")]
            public static extern int ZgelsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgelsd")]
            public static extern int Zgelsd(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* s, double rcond,
                int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgelsd_work")]
            public static extern int ZgelsdWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* s, double rcond,
                int* rank, System.IntPtr work, int lwork, double* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgelss")]
            public static extern int Zgelss(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* s, double rcond,
                int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgelss_work")]
            public static extern int ZgelssWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* s, double rcond,
                int* rank, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgelsy")]
            public static extern int Zgelsy(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* jpvt, double rcond,
                int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgelsy_work")]
            public static extern int ZgelsyWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* jpvt, double rcond,
                int* rank, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgemqrt")]
            public static extern int Zgemqrt(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, System.IntPtr v, int ldv, System.IntPtr t,
                int ldt, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgemqrt_work")]
            public static extern int ZgemqrtWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, System.IntPtr v, int ldv, System.IntPtr t,
                int ldt, System.IntPtr c, int ldc, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeqlf")]
            public static extern int Zgeqlf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeqlf_work")]
            public static extern int ZgeqlfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeqp3")]
            public static extern int Zgeqp3(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* jpvt, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeqp3_work")]
            public static extern int Zgeqp3Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* jpvt, System.IntPtr tau, System.IntPtr work, int lwork,
                double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeqpf")]
            public static extern int Zgeqpf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* jpvt, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeqpf_work")]
            public static extern int ZgeqpfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* jpvt, System.IntPtr tau, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeqr2")]
            public static extern int Zgeqr2(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeqr2_work")]
            public static extern int Zgeqr2Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeqrf")]
            public static extern int Zgeqrf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeqrf_work")]
            public static extern int ZgeqrfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeqrfp")]
            public static extern int Zgeqrfp(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeqrfp_work")]
            public static extern int ZgeqrfpWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeqrt")]
            public static extern int Zgeqrt(BLAS.LAYOUT matrixLayout, int m, int n, int nb, System.IntPtr a, int lda, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeqrt2")]
            public static extern int Zgeqrt2(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeqrt2_work")]
            public static extern int Zgeqrt2Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeqrt3")]
            public static extern int Zgeqrt3(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeqrt3_work")]
            public static extern int Zgeqrt3Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeqrt_work")]
            public static extern int ZgeqrtWork(BLAS.LAYOUT matrixLayout, int m, int n, int nb, System.IntPtr a, int lda, System.IntPtr t, int ldt, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgerfs")]
            public static extern int Zgerfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgerfs_work")]
            public static extern int ZgerfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgerfsx")]
            public static extern int Zgerfsx(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                int* ipiv, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm,
                double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgerfsx_work")]
            public static extern int ZgerfsxWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                int* ipiv, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm,
                double* err_bnds_comp, int nparams, double* @params, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgerqf")]
            public static extern int Zgerqf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgerqf_work")]
            public static extern int ZgerqfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgesdd")]
            public static extern int Zgesdd(BLAS.LAYOUT matrixLayout, sbyte jobz, int m, int n, System.IntPtr a, int lda, double* s, System.IntPtr u, int ldu, System.IntPtr vt,
                int ldvt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgesdd_work")]
            public static extern int ZgesddWork(BLAS.LAYOUT matrixLayout, sbyte jobz, int m, int n, System.IntPtr a, int lda, double* s, System.IntPtr u, int ldu, System.IntPtr vt,
                int ldvt, System.IntPtr work, int lwork, double* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgesv")]
            public static extern int Zgesv(BLAS.LAYOUT matrixLayout, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgesv_work")]
            public static extern int ZgesvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgesvd")]
            public static extern int Zgesvd(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, System.IntPtr a, int lda, double* s, System.IntPtr u, int ldu,
                System.IntPtr vt, int ldvt, double* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgesvd_work")]
            public static extern int ZgesvdWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, System.IntPtr a, int lda, double* s, System.IntPtr u, int ldu,
                System.IntPtr vt, int ldvt, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgesvdx")]
            public static extern int Zgesvdx(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, System.IntPtr a, int lda, double vl, double vu, int il,
                int iu, int* ns, double* s, System.IntPtr u, int ldu, System.IntPtr vt, int ldvt, int* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgesvdx_work")]
            public static extern int ZgesvdxWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, System.IntPtr a, int lda, double vl, double vu,
                int il, int iu, int* ns, double* s, System.IntPtr u, int ldu, System.IntPtr vt, int ldvt, System.IntPtr work, int lwork, double* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgesvj")]
            public static extern int Zgesvj(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, System.IntPtr a, int lda, double* sva, int mv,
                System.IntPtr v, int ldv, double* stat);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgesvj_work")]
            public static extern int ZgesvjWork(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, System.IntPtr a, int lda, double* sva, int mv,
                System.IntPtr v, int ldv, System.IntPtr cwork, int lwork, double* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgesvx")]
            public static extern int Zgesvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                int* ipiv, sbyte* equed, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, double* rpivot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgesvx_work")]
            public static extern int ZgesvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                int* ipiv, sbyte* equed, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, System.IntPtr work,
                double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgesvxx")]
            public static extern int Zgesvxx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                int* ipiv, sbyte* equed, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds,
                double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgesvxx_work")]
            public static extern int ZgesvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                int* ipiv, sbyte* equed, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds,
                double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgetf2")]
            public static extern int Zgetf2(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgetf2_work")]
            public static extern int Zgetf2Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgetrf")]
            public static extern int Zgetrf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgetrf2")]
            public static extern int Zgetrf2(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgetrf2_work")]
            public static extern int Zgetrf2Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgetrf_work")]
            public static extern int ZgetrfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgetri")]
            public static extern int Zgetri(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgetri_work")]
            public static extern int ZgetriWork(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgetrs")]
            public static extern int Zgetrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgetrs_work")]
            public static extern int ZgetrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggbak")]
            public static extern int Zggbak(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* lscale, double* rscale, int m, System.IntPtr v,
                int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggbak_work")]
            public static extern int ZggbakWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* lscale, double* rscale, int m, System.IntPtr v,
                int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggbal")]
            public static extern int Zggbal(BLAS.LAYOUT matrixLayout, sbyte job, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* ilo, int* ihi, double* lscale,
                double* rscale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggbal_work")]
            public static extern int ZggbalWork(BLAS.LAYOUT matrixLayout, sbyte job, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* ilo, int* ihi, double* lscale,
                double* rscale, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgges")]
            public static extern int Zgges(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, System.IntPtr a, int lda, System.IntPtr b,
                int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgges3")]
            public static extern int Zgges3(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, System.IntPtr a, int lda,
                System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgges3_work")]
            public static extern int Zgges3Work(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, System.IntPtr a, int lda,
                System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr, System.IntPtr work,
                int lwork, double* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgges_work")]
            public static extern int ZggesWork(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, System.IntPtr a, int lda,
                System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr, System.IntPtr work,
                int lwork, double* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggesx")]
            public static extern int Zggesx(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, sbyte sense, int n, System.IntPtr a, int lda,
                System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr, double* rconde,
                double* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggesx_work")]
            public static extern int ZggesxWork(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, sbyte sense, int n, System.IntPtr a,
                int lda, System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr, double* rconde,
                double* rcondv, System.IntPtr work, int lwork, double* rwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggev")]
            public static extern int Zggev(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha,
                System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggev3")]
            public static extern int Zggev3(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha,
                System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggev3_work")]
            public static extern int Zggev3Work(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha,
                System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggev_work")]
            public static extern int ZggevWork(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha,
                System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggevx")]
            public static extern int Zggevx(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, System.IntPtr a, int lda, System.IntPtr b,
                int ldb, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int* ilo, int* ihi, double* lscale, double* rscale,
                double* abnrm, double* bbnrm, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggevx_work")]
            public static extern int ZggevxWork(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, System.IntPtr a, int lda, System.IntPtr b,
                int ldb, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int* ilo, int* ihi, double* lscale, double* rscale,
                double* abnrm, double* bbnrm, double* rconde, double* rcondv, System.IntPtr work, int lwork, double* rwork, int* iwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggglm")]
            public static extern int Zggglm(BLAS.LAYOUT matrixLayout, int n, int m, int p, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr d, System.IntPtr x,
                System.IntPtr y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggglm_work")]
            public static extern int ZggglmWork(BLAS.LAYOUT matrixLayout, int n, int m, int p, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr d, System.IntPtr x,
                System.IntPtr y, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgghd3")]
            public static extern int Zgghd3(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr q, int ldq, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgghd3_work")]
            public static extern int Zgghd3Work(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr q, int ldq, System.IntPtr z, int ldz, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgghrd")]
            public static extern int Zgghrd(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr q, int ldq, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgghrd_work")]
            public static extern int ZgghrdWork(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr q, int ldq, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgglse")]
            public static extern int Zgglse(BLAS.LAYOUT matrixLayout, int m, int n, int p, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr c, System.IntPtr d,
                System.IntPtr x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgglse_work")]
            public static extern int ZgglseWork(BLAS.LAYOUT matrixLayout, int m, int n, int p, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr c, System.IntPtr d,
                System.IntPtr x, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggqrf")]
            public static extern int Zggqrf(BLAS.LAYOUT matrixLayout, int n, int m, int p, System.IntPtr a, int lda, System.IntPtr taua, System.IntPtr b, int ldb,
                System.IntPtr taub);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggqrf_work")]
            public static extern int ZggqrfWork(BLAS.LAYOUT matrixLayout, int n, int m, int p, System.IntPtr a, int lda, System.IntPtr taua, System.IntPtr b, int ldb,
                System.IntPtr taub, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggrqf")]
            public static extern int Zggrqf(BLAS.LAYOUT matrixLayout, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr taua, System.IntPtr b, int ldb,
                System.IntPtr taub);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggrqf_work")]
            public static extern int ZggrqfWork(BLAS.LAYOUT matrixLayout, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr taua, System.IntPtr b, int ldb,
                System.IntPtr taub, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggsvd")]
            public static extern int Zggsvd(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, System.IntPtr a, int lda,
                System.IntPtr b, int ldb, double* alpha, double* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggsvd3")]
            public static extern int Zggsvd3(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, System.IntPtr a, int lda,
                System.IntPtr b, int ldb, double* alpha, double* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggsvd3_work")]
            public static extern int Zggsvd3Work(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, System.IntPtr a, int lda,
                System.IntPtr b, int ldb, double* alpha, double* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, System.IntPtr work, int lwork,
                double* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggsvd_work")]
            public static extern int ZggsvdWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, System.IntPtr a, int lda,
                System.IntPtr b, int ldb, double* alpha, double* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, System.IntPtr work,
                double* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggsvp")]
            public static extern int Zggsvp(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                double tola, double tolb, int* k, int* l, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggsvp3")]
            public static extern int Zggsvp3(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                double tola, double tolb, int* k, int* l, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggsvp3_work")]
            public static extern int Zggsvp3Work(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr b,
                int ldb, double tola, double tolb, int* k, int* l, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, int* iwork, double* rwork,
                System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zggsvp_work")]
            public static extern int ZggsvpWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr b,
                int ldb, double tola, double tolb, int* k, int* l, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, int* iwork, double* rwork,
                System.IntPtr tau, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgtcon")]
            public static extern int Zgtcon(sbyte norm, int n, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgtcon_work")]
            public static extern int ZgtconWork(sbyte norm, int n, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2, int* ipiv, double anorm, double* rcond,
                System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgtrfs")]
            public static extern int Zgtrfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr dlf,
                System.IntPtr df, System.IntPtr duf, System.IntPtr du2, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgtrfs_work")]
            public static extern int ZgtrfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr dlf,
                System.IntPtr df, System.IntPtr duf, System.IntPtr du2, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr,
                System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgtsv")]
            public static extern int Zgtsv(BLAS.LAYOUT matrixLayout, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgtsv_work")]
            public static extern int ZgtsvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgtsvx")]
            public static extern int Zgtsvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du,
                System.IntPtr dlf, System.IntPtr df, System.IntPtr duf, System.IntPtr du2, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond,
                double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgtsvx_work")]
            public static extern int ZgtsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du,
                System.IntPtr dlf, System.IntPtr df, System.IntPtr duf, System.IntPtr du2, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond,
                double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgttrf")]
            public static extern int Zgttrf(int n, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgttrf_work")]
            public static extern int ZgttrfWork(int n, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgttrs")]
            public static extern int Zgttrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2,
                int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgttrs_work")]
            public static extern int ZgttrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2,
                int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbev")]
            public static extern int Zhbev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbev_work")]
            public static extern int ZhbevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* w, System.IntPtr z, int ldz,
                System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbevd")]
            public static extern int Zhbevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbevd_work")]
            public static extern int ZhbevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* w, System.IntPtr z, int ldz,
                System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbevx")]
            public static extern int Zhbevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, System.IntPtr q, int ldq,
                double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbevx_work")]
            public static extern int ZhbevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, System.IntPtr q, int ldq,
                double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, System.IntPtr work, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbgst")]
            public static extern int Zhbgst(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb,
                System.IntPtr x, int ldx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbgst_work")]
            public static extern int ZhbgstWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb,
                System.IntPtr x, int ldx, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbgv")]
            public static extern int Zhbgv(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb,
                double* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbgv_work")]
            public static extern int ZhbgvWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb,
                double* w, System.IntPtr z, int ldz, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbgvd")]
            public static extern int Zhbgvd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb,
                double* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbgvd_work")]
            public static extern int ZhbgvdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb,
                double* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbgvx")]
            public static extern int Zhbgvx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb,
                int ldbb, System.IntPtr q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbgvx_work")]
            public static extern int ZhbgvxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb,
                int ldbb, System.IntPtr q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, System.IntPtr work,
                double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbtrd")]
            public static extern int Zhbtrd(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* d, double* e, System.IntPtr q,
                int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbtrd_work")]
            public static extern int ZhbtrdWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* d, double* e, System.IntPtr q,
                int ldq, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhecon")]
            public static extern int Zhecon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhecon_work")]
            public static extern int ZheconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, double anorm, double* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zheequb")]
            public static extern int Zheequb(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zheequb_work")]
            public static extern int ZheequbWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, double* s, double* scond, double* amax, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zheev")]
            public static extern int Zheev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zheev_work")]
            public static extern int ZheevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, double* w, System.IntPtr work, int lwork,
                double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zheevd")]
            public static extern int Zheevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zheevd_work")]
            public static extern int ZheevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, double* w, System.IntPtr work, int lwork,
                double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zheevr")]
            public static extern int Zheevr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, System.IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zheevr_work")]
            public static extern int ZheevrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, double vl, double vu, int il,
                int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* isuppz, System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zheevx")]
            public static extern int Zheevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zheevx_work")]
            public static extern int ZheevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, double vl, double vu, int il,
                int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhegst")]
            public static extern int Zhegst(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhegst_work")]
            public static extern int ZhegstWork(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhegv")]
            public static extern int Zhegv(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhegv_work")]
            public static extern int ZhegvWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* w,
                System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhegvd")]
            public static extern int Zhegvd(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhegvd_work")]
            public static extern int ZhegvdWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* w,
                System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhegvx")]
            public static extern int Zhegvx(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhegvx_work")]
            public static extern int ZhegvxWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, double* rwork, int* iwork,
                int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zherfs")]
            public static extern int Zherfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zherfs_work")]
            public static extern int ZherfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zherfsx")]
            public static extern int Zherfsx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp,
                int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zherfsx_work")]
            public static extern int ZherfsxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                int* ipiv, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp,
                int nparams, double* @params, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhesv")]
            public static extern int Zhesv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhesv_work")]
            public static extern int ZhesvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhesvx")]
            public static extern int Zhesvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhesvx_work")]
            public static extern int ZhesvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhesvxx")]
            public static extern int Zhesvxx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                sbyte* equed, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm,
                double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhesvxx_work")]
            public static extern int ZhesvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                sbyte* equed, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm,
                double* err_bnds_comp, int nparams, double* @params, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zheswapr")]
            public static extern int Zheswapr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zheswapr_work")]
            public static extern int ZheswaprWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrd")]
            public static extern int Zhetrd(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, double* d, double* e, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrd_work")]
            public static extern int ZhetrdWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, double* d, double* e, System.IntPtr tau, System.IntPtr work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrf")]
            public static extern int Zhetrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrf_rook")]
            public static extern int ZhetrfRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrf_rook_work")]
            public static extern int ZhetrfRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrf_work")]
            public static extern int ZhetrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetri")]
            public static extern int Zhetri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetri2")]
            public static extern int Zhetri2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetri2_work")]
            public static extern int Zhetri2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetri2x")]
            public static extern int Zhetri2x(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetri2x_work")]
            public static extern int Zhetri2xWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetri_work")]
            public static extern int ZhetriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrs")]
            public static extern int Zhetrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrs2")]
            public static extern int Zhetrs2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrs2_work")]
            public static extern int Zhetrs2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrs_rook")]
            public static extern int ZhetrsRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrs_rook_work")]
            public static extern int ZhetrsRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrs_work")]
            public static extern int ZhetrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhfrk")]
            public static extern int Zhfrk(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, double alpha, System.IntPtr a, int lda, double beta,
                System.IntPtr c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhfrk_work")]
            public static extern int ZhfrkWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, double alpha, System.IntPtr a, int lda,
                double beta, System.IntPtr c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhgeqz")]
            public static extern int Zhgeqz(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr h, int ldh, System.IntPtr t,
                int ldt, System.IntPtr alpha, System.IntPtr beta, System.IntPtr q, int ldq, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhgeqz_work")]
            public static extern int ZhgeqzWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr h, int ldh, System.IntPtr t,
                int ldt, System.IntPtr alpha, System.IntPtr beta, System.IntPtr q, int ldq, System.IntPtr z, int ldz, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhpcon")]
            public static extern int Zhpcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhpcon_work")]
            public static extern int ZhpconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, double anorm, double* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhpev")]
            public static extern int Zhpev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, double* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhpev_work")]
            public static extern int ZhpevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, double* w, System.IntPtr z, int ldz, System.IntPtr work,
                double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhpevd")]
            public static extern int Zhpevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, double* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhpevd_work")]
            public static extern int ZhpevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, double* w, System.IntPtr z, int ldz, System.IntPtr work,
                int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhpevx")]
            public static extern int Zhpevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr ap, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhpevx_work")]
            public static extern int ZhpevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr ap, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, System.IntPtr z, int ldz, System.IntPtr work, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhpgst")]
            public static extern int Zhpgst(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhpgst_work")]
            public static extern int ZhpgstWork(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhpgv")]
            public static extern int Zhpgv(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, double* w, System.IntPtr z,
                int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhpgv_work")]
            public static extern int ZhpgvWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, double* w, System.IntPtr z,
                int ldz, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhpgvd")]
            public static extern int Zhpgvd(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, double* w, System.IntPtr z,
                int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhpgvd_work")]
            public static extern int ZhpgvdWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, double* w, System.IntPtr z,
                int ldz, System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhpgvx")]
            public static extern int Zhpgvx(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, double vl,
                double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhpgvx_work")]
            public static extern int ZhpgvxWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, double vl,
                double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, System.IntPtr work, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhprfs")]
            public static extern int Zhprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhprfs_work")]
            public static extern int ZhprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhpsv")]
            public static extern int Zhpsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhpsv_work")]
            public static extern int ZhpsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhpsvx")]
            public static extern int Zhpsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhpsvx_work")]
            public static extern int ZhpsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhptrd")]
            public static extern int Zhptrd(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, double* d, double* e, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhptrd_work")]
            public static extern int ZhptrdWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, double* d, double* e, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhptrf")]
            public static extern int Zhptrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhptrf_work")]
            public static extern int ZhptrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhptri")]
            public static extern int Zhptri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhptri_work")]
            public static extern int ZhptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhptrs")]
            public static extern int Zhptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhptrs_work")]
            public static extern int ZhptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhsein")]
            public static extern int Zhsein(BLAS.LAYOUT matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, System.IntPtr h, int ldh, System.IntPtr w,
                System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int mm, int* m, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhsein_work")]
            public static extern int ZhseinWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, System.IntPtr h, int ldh, System.IntPtr w,
                System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int mm, int* m, System.IntPtr work, double* rwork, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhseqr")]
            public static extern int Zhseqr(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, System.IntPtr h, int ldh, System.IntPtr w, System.IntPtr z,
                int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhseqr_work")]
            public static extern int ZhseqrWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, System.IntPtr h, int ldh, System.IntPtr w,
                System.IntPtr z, int ldz, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlacgv")]
            public static extern int Zlacgv(int n, System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlacgv_work")]
            public static extern int ZlacgvWork(int n, System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlacn2")]
            public static extern int Zlacn2(int n, System.IntPtr v, System.IntPtr x, double* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlacn2_work")]
            public static extern int Zlacn2Work(int n, System.IntPtr v, System.IntPtr x, double* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlacp2")]
            public static extern int Zlacp2(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, double* a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlacp2_work")]
            public static extern int Zlacp2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, double* a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlacpy")]
            public static extern int Zlacpy(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlacpy_work")]
            public static extern int ZlacpyWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlag2c")]
            public static extern int Zlag2c(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr sa, int ldsa);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlag2c_work")]
            public static extern int Zlag2cWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr sa, int ldsa);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlagge")]
            public static extern int Zlagge(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, double* d, System.IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlagge_work")]
            public static extern int ZlaggeWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, double* d, System.IntPtr a, int lda, int* iseed, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlaghe")]
            public static extern int Zlaghe(BLAS.LAYOUT matrixLayout, int n, int k, double* d, System.IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlaghe_work")]
            public static extern int ZlagheWork(BLAS.LAYOUT matrixLayout, int n, int k, double* d, System.IntPtr a, int lda, int* iseed, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlagsy")]
            public static extern int Zlagsy(BLAS.LAYOUT matrixLayout, int n, int k, double* d, System.IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlagsy_work")]
            public static extern int ZlagsyWork(BLAS.LAYOUT matrixLayout, int n, int k, double* d, System.IntPtr a, int lda, int* iseed, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlapmr")]
            public static extern int Zlapmr(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, System.IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlapmr_work")]
            public static extern int ZlapmrWork(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, System.IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlapmt")]
            public static extern int Zlapmt(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, System.IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlapmt_work")]
            public static extern int ZlapmtWork(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, System.IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlarfb")]
            public static extern int Zlarfb(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, System.IntPtr v, int ldv,
                System.IntPtr t, int ldt, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlarfb_work")]
            public static extern int ZlarfbWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, System.IntPtr v, int ldv,
                System.IntPtr t, int ldt, System.IntPtr c, int ldc, System.IntPtr work, int ldwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlarfg")]
            public static extern int Zlarfg(int n, System.IntPtr alpha, System.IntPtr x, int incx, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlarfg_work")]
            public static extern int ZlarfgWork(int n, System.IntPtr alpha, System.IntPtr x, int incx, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlarft")]
            public static extern int Zlarft(BLAS.LAYOUT matrixLayout, sbyte direct, sbyte storev, int n, int k, System.IntPtr v, int ldv, System.IntPtr tau, System.IntPtr t,
                int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlarft_work")]
            public static extern int ZlarftWork(BLAS.LAYOUT matrixLayout, sbyte direct, sbyte storev, int n, int k, System.IntPtr v, int ldv, System.IntPtr tau, System.IntPtr t,
                int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlarfx")]
            public static extern int Zlarfx(BLAS.LAYOUT matrixLayout, sbyte side, int m, int n, System.IntPtr v, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlarfx_work")]
            public static extern int ZlarfxWork(BLAS.LAYOUT matrixLayout, sbyte side, int m, int n, System.IntPtr v, System.IntPtr tau, System.IntPtr c, int ldc,
                System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlarnv")]
            public static extern int Zlarnv(int idist, int* iseed, int n, System.IntPtr x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlarnv_work")]
            public static extern int ZlarnvWork(int idist, int* iseed, int n, System.IntPtr x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlascl")]
            public static extern int Zlascl(BLAS.LAYOUT matrixLayout, sbyte type, int kl, int ku, double cfrom, double cto, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlascl_work")]
            public static extern int ZlasclWork(BLAS.LAYOUT matrixLayout, sbyte type, int kl, int ku, double cfrom, double cto, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlaset")]
            public static extern int Zlaset(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, System.IntPtr alpha, System.IntPtr beta, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlaset_work")]
            public static extern int ZlasetWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, System.IntPtr alpha, System.IntPtr beta, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlaswp")]
            public static extern int Zlaswp(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlaswp_work")]
            public static extern int ZlaswpWork(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlatms")]
            public static extern int Zlatms(BLAS.LAYOUT matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, double* d, int mode, double cond, double dmax, int kl,
                int ku, sbyte pack, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlatms_work")]
            public static extern int ZlatmsWork(BLAS.LAYOUT matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, double* d, int mode, double cond, double dmax, int kl,
                int ku, sbyte pack, System.IntPtr a, int lda, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlauum")]
            public static extern int Zlauum(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zlauum_work")]
            public static extern int ZlauumWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpbcon")]
            public static extern int Zpbcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpbcon_work")]
            public static extern int ZpbconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double anorm, double* rcond, System.IntPtr work,
                double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpbequ")]
            public static extern int Zpbequ(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpbequ_work")]
            public static extern int ZpbequWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpbrfs")]
            public static extern int Zpbrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpbrfs_work")]
            public static extern int ZpbrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpbstf")]
            public static extern int Zpbstf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kb, System.IntPtr bb, int ldbb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpbstf_work")]
            public static extern int ZpbstfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kb, System.IntPtr bb, int ldbb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpbsv")]
            public static extern int Zpbsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpbsv_work")]
            public static extern int ZpbsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpbsvx")]
            public static extern int Zpbsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb,
                sbyte* equed, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpbsvx_work")]
            public static extern int ZpbsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb,
                sbyte* equed, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpbtrf")]
            public static extern int Zpbtrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpbtrf_work")]
            public static extern int ZpbtrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpbtrs")]
            public static extern int Zpbtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpbtrs_work")]
            public static extern int ZpbtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpftrf")]
            public static extern int Zpftrf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpftrf_work")]
            public static extern int ZpftrfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpftri")]
            public static extern int Zpftri(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpftri_work")]
            public static extern int ZpftriWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpftrs")]
            public static extern int Zpftrs(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, System.IntPtr a, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpftrs_work")]
            public static extern int ZpftrsWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, System.IntPtr a, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpocon")]
            public static extern int Zpocon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpocon_work")]
            public static extern int ZpoconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, double anorm, double* rcond, System.IntPtr work,
                double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpoequ")]
            public static extern int Zpoequ(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpoequ_work")]
            public static extern int ZpoequWork(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpoequb")]
            public static extern int Zpoequb(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpoequb_work")]
            public static extern int ZpoequbWork(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zporfs")]
            public static extern int Zporfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, System.IntPtr b, int ldb,
                System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zporfs_work")]
            public static extern int ZporfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zporfsx")]
            public static extern int Zporfsx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, double* s,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams,
                double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zporfsx_work")]
            public static extern int ZporfsxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp,
                int nparams, double* @params, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zposv")]
            public static extern int Zposv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zposv_work")]
            public static extern int ZposvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zposvx")]
            public static extern int Zposvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, sbyte* equed,
                double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zposvx_work")]
            public static extern int ZposvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                sbyte* equed, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zposvxx")]
            public static extern int Zposvxx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, sbyte* equed,
                double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm,
                double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zposvxx_work")]
            public static extern int ZposvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                sbyte* equed, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm,
                double* err_bnds_comp, int nparams, double* @params, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpotrf")]
            public static extern int Zpotrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpotrf2")]
            public static extern int Zpotrf2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpotrf2_work")]
            public static extern int Zpotrf2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpotrf_work")]
            public static extern int ZpotrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpotri")]
            public static extern int Zpotri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpotri_work")]
            public static extern int ZpotriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpotrs")]
            public static extern int Zpotrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpotrs_work")]
            public static extern int ZpotrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zppcon")]
            public static extern int Zppcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zppcon_work")]
            public static extern int ZppconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, double anorm, double* rcond, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zppequ")]
            public static extern int Zppequ(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zppequ_work")]
            public static extern int ZppequWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpprfs")]
            public static extern int Zpprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, System.IntPtr b, int ldb, System.IntPtr x,
                int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpprfs_work")]
            public static extern int ZpprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, System.IntPtr b, int ldb,
                System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zppsv")]
            public static extern int Zppsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zppsv_work")]
            public static extern int ZppsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zppsvx")]
            public static extern int Zppsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, sbyte* equed, double* s,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zppsvx_work")]
            public static extern int ZppsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, sbyte* equed, double* s,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpptrf")]
            public static extern int Zpptrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpptrf_work")]
            public static extern int ZpptrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpptri")]
            public static extern int Zpptri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpptri_work")]
            public static extern int ZpptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpptrs")]
            public static extern int Zpptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpptrs_work")]
            public static extern int ZpptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpstrf")]
            public static extern int Zpstrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* piv, int* rank, double tol);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpstrf_work")]
            public static extern int ZpstrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* piv, int* rank, double tol, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zptcon")]
            public static extern int Zptcon(int n, double* d, System.IntPtr e, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zptcon_work")]
            public static extern int ZptconWork(int n, double* d, System.IntPtr e, double anorm, double* rcond, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpteqr")]
            public static extern int Zpteqr(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpteqr_work")]
            public static extern int ZpteqrWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, System.IntPtr z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zptrfs")]
            public static extern int Zptrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* d, System.IntPtr e, double* df, System.IntPtr ef, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zptrfs_work")]
            public static extern int ZptrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* d, System.IntPtr e, double* df, System.IntPtr ef, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zptsv")]
            public static extern int Zptsv(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* d, System.IntPtr e, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zptsv_work")]
            public static extern int ZptsvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* d, System.IntPtr e, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zptsvx")]
            public static extern int Zptsvx(BLAS.LAYOUT matrixLayout, sbyte fact, int n, int nrhs, double* d, System.IntPtr e, double* df, System.IntPtr ef, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zptsvx_work")]
            public static extern int ZptsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, int n, int nrhs, double* d, System.IntPtr e, double* df, System.IntPtr ef, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpttrf")]
            public static extern int Zpttrf(int n, double* d, System.IntPtr e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpttrf_work")]
            public static extern int ZpttrfWork(int n, double* d, System.IntPtr e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpttrs")]
            public static extern int Zpttrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* d, System.IntPtr e, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zpttrs_work")]
            public static extern int ZpttrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* d, System.IntPtr e, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zspcon")]
            public static extern int Zspcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zspcon_work")]
            public static extern int ZspconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, double anorm, double* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsprfs")]
            public static extern int Zsprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsprfs_work")]
            public static extern int ZsprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zspsv")]
            public static extern int Zspsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zspsv_work")]
            public static extern int ZspsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zspsvx")]
            public static extern int Zspsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zspsvx_work")]
            public static extern int ZspsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsptrf")]
            public static extern int Zsptrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsptrf_work")]
            public static extern int ZsptrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsptri")]
            public static extern int Zsptri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsptri_work")]
            public static extern int ZsptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsptrs")]
            public static extern int Zsptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsptrs_work")]
            public static extern int ZsptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zstedc")]
            public static extern int Zstedc(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zstedc_work")]
            public static extern int ZstedcWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, System.IntPtr z, int ldz, System.IntPtr work, int lwork,
                double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zstegr")]
            public static extern int Zstegr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol,
                int* m, double* w, System.IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zstegr_work")]
            public static extern int ZstegrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol,
                int* m, double* w, System.IntPtr z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zstein")]
            public static extern int Zstein(BLAS.LAYOUT matrixLayout, int n, double* d, double* e, int m, double* w, int* iblock, int* isplit, System.IntPtr z, int ldz,
                int* ifailv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zstein_work")]
            public static extern int ZsteinWork(BLAS.LAYOUT matrixLayout, int n, double* d, double* e, int m, double* w, int* iblock, int* isplit, System.IntPtr z, int ldz,
                double* work, int* iwork, int* ifailv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zstemr")]
            public static extern int Zstemr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* m, double* w,
                System.IntPtr z, int ldz, int nzc, int* isuppz, int* tryrac);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zstemr_work")]
            public static extern int ZstemrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* m,
                double* w, System.IntPtr z, int ldz, int nzc, int* isuppz, int* tryrac, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsteqr")]
            public static extern int Zsteqr(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsteqr_work")]
            public static extern int ZsteqrWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, System.IntPtr z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsycon")]
            public static extern int Zsycon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsycon_work")]
            public static extern int ZsyconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, double anorm, double* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsyconv")]
            public static extern int Zsyconv(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte way, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsyconv_work")]
            public static extern int ZsyconvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte way, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsyequb")]
            public static extern int Zsyequb(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsyequb_work")]
            public static extern int ZsyequbWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, double* s, double* scond, double* amax, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsyr")]
            public static extern int Zsyr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr alpha, System.IntPtr x, int incx, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsyr_work")]
            public static extern int ZsyrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr alpha, System.IntPtr x, int incx, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsyrfs")]
            public static extern int Zsyrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsyrfs_work")]
            public static extern int ZsyrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsyrfsx")]
            public static extern int Zsyrfsx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp,
                int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsyrfsx_work")]
            public static extern int ZsyrfsxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf,
                int* ipiv, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp,
                int nparams, double* @params, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsysv")]
            public static extern int Zsysv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsysv_rook")]
            public static extern int ZsysvRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsysv_rook_work")]
            public static extern int ZsysvRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsysv_work")]
            public static extern int ZsysvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsysvx")]
            public static extern int Zsysvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsysvx_work")]
            public static extern int ZsysvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsysvxx")]
            public static extern int Zsysvxx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                sbyte* equed, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm,
                double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsysvxx_work")]
            public static extern int ZsysvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv,
                sbyte* equed, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm,
                double* err_bnds_comp, int nparams, double* @params, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsyswapr")]
            public static extern int Zsyswapr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsyswapr_work")]
            public static extern int ZsyswaprWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrf")]
            public static extern int Zsytrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrf_rook")]
            public static extern int ZsytrfRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrf_rook_work")]
            public static extern int ZsytrfRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrf_work")]
            public static extern int ZsytrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytri")]
            public static extern int Zsytri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytri2")]
            public static extern int Zsytri2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytri2_work")]
            public static extern int Zsytri2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytri2x")]
            public static extern int Zsytri2x(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytri2x_work")]
            public static extern int Zsytri2xWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytri_work")]
            public static extern int ZsytriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrs")]
            public static extern int Zsytrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrs2")]
            public static extern int Zsytrs2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrs2_work")]
            public static extern int Zsytrs2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrs_rook")]
            public static extern int ZsytrsRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrs_rook_work")]
            public static extern int ZsytrsRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrs_work")]
            public static extern int ZsytrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztbcon")]
            public static extern int Ztbcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, System.IntPtr ab, int ldab, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztbcon_work")]
            public static extern int ZtbconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, System.IntPtr ab, int ldab, double* rcond,
                System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztbrfs")]
            public static extern int Ztbrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, System.IntPtr ab, int ldab,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztbrfs_work")]
            public static extern int ZtbrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, System.IntPtr ab, int ldab,
                System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztbtrs")]
            public static extern int Ztbtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, System.IntPtr ab, int ldab,
                System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztbtrs_work")]
            public static extern int ZtbtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, System.IntPtr ab, int ldab,
                System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztfsm")]
            public static extern int Ztfsm(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, System.IntPtr alpha,
                System.IntPtr a, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztfsm_work")]
            public static extern int ZtfsmWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, System.IntPtr alpha,
                System.IntPtr a, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztftri")]
            public static extern int Ztftri(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztftri_work")]
            public static extern int ZtftriWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztfttp")]
            public static extern int Ztfttp(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr arf, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztfttp_work")]
            public static extern int ZtfttpWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr arf, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztfttr")]
            public static extern int Ztfttr(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr arf, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztfttr_work")]
            public static extern int ZtfttrWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr arf, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztgevc")]
            public static extern int Ztgevc(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, System.IntPtr s, int lds, System.IntPtr p, int ldp,
                System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztgevc_work")]
            public static extern int ZtgevcWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, System.IntPtr s, int lds, System.IntPtr p, int ldp,
                System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int mm, int* m, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztgexc")]
            public static extern int Ztgexc(BLAS.LAYOUT matrixLayout, int wantq, int wantz, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr q, int ldq,
                System.IntPtr z, int ldz, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztgexc_work")]
            public static extern int ZtgexcWork(BLAS.LAYOUT matrixLayout, int wantq, int wantz, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr q, int ldq,
                System.IntPtr z, int ldz, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztgsen")]
            public static extern int Ztgsen(BLAS.LAYOUT matrixLayout, int ijob, int wantq, int wantz, int* select, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr alpha, System.IntPtr beta, System.IntPtr q, int ldq, System.IntPtr z, int ldz, int* m, double* pl, double* pr, double* dif);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztgsen_work")]
            public static extern int ZtgsenWork(BLAS.LAYOUT matrixLayout, int ijob, int wantq, int wantz, int* select, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr alpha, System.IntPtr beta, System.IntPtr q, int ldq, System.IntPtr z, int ldz, int* m, double* pl, double* pr, double* dif, System.IntPtr work,
                int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztgsja")]
            public static extern int Ztgsja(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, System.IntPtr a, int lda,
                System.IntPtr b, int ldb, double tola, double tolb, double* alpha, double* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq,
                int* ncycle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztgsja_work")]
            public static extern int ZtgsjaWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, System.IntPtr a, int lda,
                System.IntPtr b, int ldb, double tola, double tolb, double* alpha, double* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq,
                System.IntPtr work, int* ncycle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztgsna")]
            public static extern int Ztgsna(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, double* s, double* dif, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztgsna_work")]
            public static extern int ZtgsnaWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, double* s, double* dif, int mm, int* m, System.IntPtr work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztgsyl")]
            public static extern int Ztgsyl(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr c,
                int ldc, System.IntPtr d, int ldd, System.IntPtr e, int lde, System.IntPtr f, int ldf, double* scale, double* dif);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztgsyl_work")]
            public static extern int ZtgsylWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr c, int ldc, System.IntPtr d, int ldd, System.IntPtr e, int lde, System.IntPtr f, int ldf, double* scale, double* dif, System.IntPtr work, int lwork,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztpcon")]
            public static extern int Ztpcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, System.IntPtr ap, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztpcon_work")]
            public static extern int ZtpconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, System.IntPtr ap, double* rcond, System.IntPtr work,
                double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztpmqrt")]
            public static extern int Ztpmqrt(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, System.IntPtr v, int ldv, System.IntPtr t,
                int ldt, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztpmqrt_work")]
            public static extern int ZtpmqrtWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, System.IntPtr v, int ldv,
                System.IntPtr t, int ldt, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztpqrt")]
            public static extern int Ztpqrt(BLAS.LAYOUT matrixLayout, int m, int n, int l, int nb, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztpqrt2")]
            public static extern int Ztpqrt2(BLAS.LAYOUT matrixLayout, int m, int n, int l, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztpqrt2_work")]
            public static extern int Ztpqrt2Work(BLAS.LAYOUT matrixLayout, int m, int n, int l, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztpqrt_work")]
            public static extern int ZtpqrtWork(BLAS.LAYOUT matrixLayout, int m, int n, int l, int nb, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr t, int ldt,
                System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztprfb")]
            public static extern int Ztprfb(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, System.IntPtr v,
                int ldv, System.IntPtr t, int ldt, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztprfb_work")]
            public static extern int ZtprfbWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, System.IntPtr v,
                int ldv, System.IntPtr t, int ldt, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr work, int ldwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztprfs")]
            public static extern int Ztprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb,
                System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztprfs_work")]
            public static extern int ZtprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb,
                System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztptri")]
            public static extern int Ztptri(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztptri_work")]
            public static extern int ZtptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztptrs")]
            public static extern int Ztptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztptrs_work")]
            public static extern int ZtptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztpttf")]
            public static extern int Ztpttf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr ap, System.IntPtr arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztpttf_work")]
            public static extern int ZtpttfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr ap, System.IntPtr arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztpttr")]
            public static extern int Ztpttr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztpttr_work")]
            public static extern int ZtpttrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrcon")]
            public static extern int Ztrcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, System.IntPtr a, int lda, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrcon_work")]
            public static extern int ZtrconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, System.IntPtr a, int lda, double* rcond, System.IntPtr work,
                double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrevc")]
            public static extern int Ztrevc(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, System.IntPtr t, int ldt, System.IntPtr vl, int ldvl,
                System.IntPtr vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrevc_work")]
            public static extern int ZtrevcWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, System.IntPtr t, int ldt, System.IntPtr vl, int ldvl,
                System.IntPtr vr, int ldvr, int mm, int* m, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrexc")]
            public static extern int Ztrexc(BLAS.LAYOUT matrixLayout, sbyte compq, int n, System.IntPtr t, int ldt, System.IntPtr q, int ldq, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrexc_work")]
            public static extern int ZtrexcWork(BLAS.LAYOUT matrixLayout, sbyte compq, int n, System.IntPtr t, int ldt, System.IntPtr q, int ldq, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrrfs")]
            public static extern int Ztrrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrrfs_work")]
            public static extern int ZtrrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b,
                int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrsen")]
            public static extern int Ztrsen(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, int* select, int n, System.IntPtr t, int ldt, System.IntPtr q, int ldq,
                System.IntPtr w, int* m, double* s, double* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrsen_work")]
            public static extern int ZtrsenWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, int* select, int n, System.IntPtr t, int ldt, System.IntPtr q, int ldq,
                System.IntPtr w, int* m, double* s, double* sep, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrsna")]
            public static extern int Ztrsna(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, System.IntPtr t, int ldt, System.IntPtr vl, int ldvl,
                System.IntPtr vr, int ldvr, double* s, double* sep, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrsna_work")]
            public static extern int ZtrsnaWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, System.IntPtr t, int ldt, System.IntPtr vl, int ldvl,
                System.IntPtr vr, int ldvr, double* s, double* sep, int mm, int* m, System.IntPtr work, int ldwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrsyl")]
            public static extern int Ztrsyl(BLAS.LAYOUT matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr c, int ldc, double* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrsyl_work")]
            public static extern int ZtrsylWork(BLAS.LAYOUT matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr c, int ldc, double* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrtri")]
            public static extern int Ztrtri(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrtri_work")]
            public static extern int ZtrtriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrtrs")]
            public static extern int Ztrtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrtrs_work")]
            public static extern int ZtrtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrttf")]
            public static extern int Ztrttf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrttf_work")]
            public static extern int ZtrttfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrttp")]
            public static extern int Ztrttp(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztrttp_work")]
            public static extern int ZtrttpWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztzrzf")]
            public static extern int Ztzrzf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ztzrzf_work")]
            public static extern int ZtzrzfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunbdb")]
            public static extern int Zunbdb(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, System.IntPtr x11, int ldx11, System.IntPtr x12,
                int ldx12, System.IntPtr x21, int ldx21, System.IntPtr x22, int ldx22, double* theta, double* phi, System.IntPtr taup1, System.IntPtr taup2, System.IntPtr tauq1,
                System.IntPtr tauq2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunbdb_work")]
            public static extern int ZunbdbWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, System.IntPtr x11, int ldx11, System.IntPtr x12,
                int ldx12, System.IntPtr x21, int ldx21, System.IntPtr x22, int ldx22, double* theta, double* phi, System.IntPtr taup1, System.IntPtr taup2, System.IntPtr tauq1,
                System.IntPtr tauq2, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zuncsd")]
            public static extern int Zuncsd(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q,
                System.IntPtr x11, int ldx11, System.IntPtr x12, int ldx12, System.IntPtr x21, int ldx21, System.IntPtr x22, int ldx22, double* theta, System.IntPtr u1, int ldu1,
                System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t, System.IntPtr v2t, int ldv2t);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zuncsd2by1")]
            public static extern int Zuncsd2by1(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, System.IntPtr x11, int ldx11,
                System.IntPtr x21, int ldx21, double* theta, System.IntPtr u1, int ldu1, System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zuncsd2by1_work")]
            public static extern int Zuncsd2by1Work(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, System.IntPtr x11, int ldx11,
                System.IntPtr x21, int ldx21, double* theta, System.IntPtr u1, int ldu1, System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t, System.IntPtr work, int lwork,
                double* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zuncsd_work")]
            public static extern int ZuncsdWork(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q,
                System.IntPtr x11, int ldx11, System.IntPtr x12, int ldx12, System.IntPtr x21, int ldx21, System.IntPtr x22, int ldx22, double* theta, System.IntPtr u1, int ldu1,
                System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t, System.IntPtr v2t, int ldv2t, System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zungbr")]
            public static extern int Zungbr(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zungbr_work")]
            public static extern int ZungbrWork(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunghr")]
            public static extern int Zunghr(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunghr_work")]
            public static extern int ZunghrWork(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunglq")]
            public static extern int Zunglq(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunglq_work")]
            public static extern int ZunglqWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zungql")]
            public static extern int Zungql(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zungql_work")]
            public static extern int ZungqlWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zungqr")]
            public static extern int Zungqr(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zungqr_work")]
            public static extern int ZungqrWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zungrq")]
            public static extern int Zungrq(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zungrq_work")]
            public static extern int ZungrqWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zungtr")]
            public static extern int Zungtr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zungtr_work")]
            public static extern int ZungtrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunmbr")]
            public static extern int Zunmbr(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunmbr_work")]
            public static extern int ZunmbrWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda,
                System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunmhr")]
            public static extern int Zunmhr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunmhr_work")]
            public static extern int ZunmhrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunmlq")]
            public static extern int Zunmlq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunmlq_work")]
            public static extern int ZunmlqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunmql")]
            public static extern int Zunmql(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunmql_work")]
            public static extern int ZunmqlWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunmqr")]
            public static extern int Zunmqr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunmqr_work")]
            public static extern int ZunmqrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunmrq")]
            public static extern int Zunmrq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunmrq_work")]
            public static extern int ZunmrqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunmrz")]
            public static extern int Zunmrz(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunmrz_work")]
            public static extern int ZunmrzWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunmtr")]
            public static extern int Zunmtr(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zunmtr_work")]
            public static extern int ZunmtrWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, System.IntPtr a, int lda, System.IntPtr tau,
                System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zupgtr")]
            public static extern int Zupgtr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, System.IntPtr tau, System.IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zupgtr_work")]
            public static extern int ZupgtrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, System.IntPtr tau, System.IntPtr q, int ldq, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zupmtr")]
            public static extern int Zupmtr(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, System.IntPtr ap, System.IntPtr tau, System.IntPtr c,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zupmtr_work")]
            public static extern int ZupmtrWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, System.IntPtr ap, System.IntPtr tau,
                System.IntPtr c, int ldc, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ilaver")]
            public static extern void Ilaver(int* vers_major, int* vers_minor, int* vers_patch);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chesv_aa")]
            public static extern int ChesvAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chesv_aa_work")]
            public static extern int ChesvAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrf_aa")]
            public static extern int ChetrfAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrf_aa_work")]
            public static extern int ChetrfAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrs_aa")]
            public static extern int ChetrsAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrs_aa_work")]
            public static extern int ChetrsAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysv_aa")]
            public static extern int DsysvAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysv_aa_work")]
            public static extern int DsysvAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrf_aa")]
            public static extern int DsytrfAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrf_aa_work")]
            public static extern int DsytrfAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs_aa")]
            public static extern int DsytrsAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs_aa_work")]
            public static extern int DsytrsAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysv_aa")]
            public static extern int SsysvAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysv_aa_work")]
            public static extern int SsysvAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrf_aa")]
            public static extern int SsytrfAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrf_aa_work")]
            public static extern int SsytrfAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs_aa")]
            public static extern int SsytrsAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs_aa_work")]
            public static extern int SsytrsAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhesv_aa")]
            public static extern int ZhesvAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhesv_aa_work")]
            public static extern int ZhesvAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrf_aa")]
            public static extern int ZhetrfAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrf_aa_work")]
            public static extern int ZhetrfAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrs_aa")]
            public static extern int ZhetrsAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrs_aa_work")]
            public static extern int ZhetrsAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgemqr")]
            public static extern int Cgemqr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr t, int tsize,
                System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgemqr_work")]
            public static extern int CgemqrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr t, int tsize,
                System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeqr")]
            public static extern int Cgeqr(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int tsize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgeqr_work")]
            public static extern int CgeqrWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int tsize, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgemqr")]
            public static extern int Dgemqr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* t, int tsize, double* c,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgemqr_work")]
            public static extern int DgemqrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* t, int tsize, double* c,
                int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqr")]
            public static extern int Dgeqr(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* t, int tsize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqr_work")]
            public static extern int DgeqrWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* t, int tsize, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgemqr")]
            public static extern int Sgemqr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* t, int tsize, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgemqr_work")]
            public static extern int SgemqrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* t, int tsize, float* c,
                int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqr")]
            public static extern int Sgeqr(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* t, int tsize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqr_work")]
            public static extern int SgeqrWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* t, int tsize, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgemqr")]
            public static extern int Zgemqr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr t, int tsize,
                System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgemqr_work")]
            public static extern int ZgemqrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr t, int tsize,
                System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeqr")]
            public static extern int Zgeqr(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int tsize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgeqr_work")]
            public static extern int ZgeqrWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int tsize, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgelq")]
            public static extern int Cgelq(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int tsize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgelq_work")]
            public static extern int CgelqWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int tsize, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgemlq")]
            public static extern int Cgemlq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr t, int tsize,
                System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgemlq_work")]
            public static extern int CgemlqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr t, int tsize,
                System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelq")]
            public static extern int Dgelq(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* t, int tsize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelq_work")]
            public static extern int DgelqWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* t, int tsize, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgemlq")]
            public static extern int Dgemlq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* t, int tsize, double* c,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgemlq_work")]
            public static extern int DgemlqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* t, int tsize, double* c,
                int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelq")]
            public static extern int Sgelq(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* t, int tsize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelq_work")]
            public static extern int SgelqWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* t, int tsize, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgemlq")]
            public static extern int Sgemlq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* t, int tsize, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgemlq_work")]
            public static extern int SgemlqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* t, int tsize, float* c,
                int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgelq")]
            public static extern int Zgelq(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int tsize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgelq_work")]
            public static extern int ZgelqWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int tsize, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgemlq")]
            public static extern int Zgemlq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr t, int tsize,
                System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgemlq_work")]
            public static extern int ZgemlqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr t, int tsize,
                System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgetsls")]
            public static extern int Cgetsls(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cgetsls_work")]
            public static extern int CgetslsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetsls")]
            public static extern int Dgetsls(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetsls_work")]
            public static extern int DgetslsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetsls")]
            public static extern int Sgetsls(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetsls_work")]
            public static extern int SgetslsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgetsls")]
            public static extern int Zgetsls(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zgetsls_work")]
            public static extern int ZgetslsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_checon_3")]
            public static extern int Checon3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_checon_3_work")]
            public static extern int Checon3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, float anorm, float* rcond,
                System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chesv_rk")]
            public static extern int ChesvRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chesv_rk_work")]
            public static extern int ChesvRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b,
                int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrf_rk")]
            public static extern int ChetrfRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrf_rk_work")]
            public static extern int ChetrfRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetri_3")]
            public static extern int Chetri3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetri_3_work")]
            public static extern int Chetri3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrs_3")]
            public static extern int Chetrs3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrs_3_work")]
            public static extern int Chetrs3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csycon_3")]
            public static extern int Csycon3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csycon_3_work")]
            public static extern int Csycon3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, float anorm, float* rcond,
                System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csysv_aa")]
            public static extern int CsysvAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csysv_aa_work")]
            public static extern int CsysvAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csysv_rk")]
            public static extern int CsysvRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csysv_rk_work")]
            public static extern int CsysvRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b,
                int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrf_aa")]
            public static extern int CsytrfAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrf_aa_work")]
            public static extern int CsytrfAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrf_rk")]
            public static extern int CsytrfRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrf_rk_work")]
            public static extern int CsytrfRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytri_3")]
            public static extern int Csytri3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytri_3_work")]
            public static extern int Csytri3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrs_3")]
            public static extern int Csytrs3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrs_3_work")]
            public static extern int Csytrs3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrs_aa")]
            public static extern int CsytrsAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrs_aa_work")]
            public static extern int CsytrsAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsycon_3")]
            public static extern int Dsycon3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsycon_3_work")]
            public static extern int Dsycon3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv, double anorm, double* rcond, double* work,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysv_rk")]
            public static extern int DsysvRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* e, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysv_rk_work")]
            public static extern int DsysvRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* e, int* ipiv, double* b, int ldb, double* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrf_rk")]
            public static extern int DsytrfRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrf_rk_work")]
            public static extern int DsytrfRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytri_3")]
            public static extern int Dsytri3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytri_3_work")]
            public static extern int Dsytri3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs_3")]
            public static extern int Dsytrs3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* e, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs_3_work")]
            public static extern int Dsytrs3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* e, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssycon_3")]
            public static extern int Ssycon3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssycon_3_work")]
            public static extern int Ssycon3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv, float anorm, float* rcond, float* work,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysv_rk")]
            public static extern int SsysvRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* e, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysv_rk_work")]
            public static extern int SsysvRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* e, int* ipiv, float* b, int ldb, float* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrf_rk")]
            public static extern int SsytrfRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrf_rk_work")]
            public static extern int SsytrfRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytri_3")]
            public static extern int Ssytri3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytri_3_work")]
            public static extern int Ssytri3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs_3")]
            public static extern int Ssytrs3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* e, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs_3_work")]
            public static extern int Ssytrs3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* e, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhecon_3")]
            public static extern int Zhecon3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhecon_3_work")]
            public static extern int Zhecon3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, double anorm, double* rcond,
                System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhesv_rk")]
            public static extern int ZhesvRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhesv_rk_work")]
            public static extern int ZhesvRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b,
                int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrf_rk")]
            public static extern int ZhetrfRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrf_rk_work")]
            public static extern int ZhetrfRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetri_3")]
            public static extern int Zhetri3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetri_3_work")]
            public static extern int Zhetri3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrs_3")]
            public static extern int Zhetrs3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrs_3_work")]
            public static extern int Zhetrs3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsycon_3")]
            public static extern int Zsycon3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsycon_3_work")]
            public static extern int Zsycon3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, double anorm, double* rcond,
                System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsysv_aa")]
            public static extern int ZsysvAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsysv_aa_work")]
            public static extern int ZsysvAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsysv_rk")]
            public static extern int ZsysvRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsysv_rk_work")]
            public static extern int ZsysvRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b,
                int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrf_aa")]
            public static extern int ZsytrfAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrf_aa_work")]
            public static extern int ZsytrfAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrf_rk")]
            public static extern int ZsytrfRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrf_rk_work")]
            public static extern int ZsytrfRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytri_3")]
            public static extern int Zsytri3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytri_3_work")]
            public static extern int Zsytri3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrs_3")]
            public static extern int Zsytrs3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrs_3_work")]
            public static extern int Zsytrs3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrs_aa")]
            public static extern int ZsytrsAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrs_aa_work")]
            public static extern int ZsytrsAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbev_2stage")]
            public static extern int Chbev2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbev_2stage_work")]
            public static extern int Chbev2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* w, System.IntPtr z,
                int ldz, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbevd_2stage")]
            public static extern int Chbevd2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbevd_2stage_work")]
            public static extern int Chbevd2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* w, System.IntPtr z,
                int ldz, System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbevx_2stage")]
            public static extern int Chbevx2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, System.IntPtr q,
                int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chbevx_2stage_work")]
            public static extern int Chbevx2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, System.IntPtr q,
                int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, float* rwork, int* iwork,
                int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cheev_2stage")]
            public static extern int Cheev2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cheev_2stage_work")]
            public static extern int Cheev2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, float* w, System.IntPtr work, int lwork,
                float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cheevd_2stage")]
            public static extern int Cheevd2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cheevd_2stage_work")]
            public static extern int Cheevd2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, float* w, System.IntPtr work, int lwork,
                float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cheevr_2stage")]
            public static extern int Cheevr2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, float vl, float vu, int il,
                int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cheevr_2stage_work")]
            public static extern int Cheevr2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, float vl, float vu, int il,
                int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* isuppz, System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cheevx_2stage")]
            public static extern int Cheevx2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, float vl, float vu, int il,
                int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_cheevx_2stage_work")]
            public static extern int Cheevx2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, float vl, float vu, int il,
                int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chegv_2stage")]
            public static extern int Chegv2stage(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chegv_2stage_work")]
            public static extern int Chegv2stageWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                float* w, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbev_2stage")]
            public static extern int Dsbev2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbev_2stage_work")]
            public static extern int Dsbev2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbevd_2stage")]
            public static extern int Dsbevd2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbevd_2stage_work")]
            public static extern int Dsbevd2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz,
                double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbevx_2stage")]
            public static extern int Dsbevx2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, double* ab, int ldab, double* q, int ldq, double vl,
                double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbevx_2stage_work")]
            public static extern int Dsbevx2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, double* ab, int ldab, double* q, int ldq,
                double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyev_2stage")]
            public static extern int Dsyev2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyev_2stage_work")]
            public static extern int Dsyev2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevd_2stage")]
            public static extern int Dsyevd2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevd_2stage_work")]
            public static extern int Dsyevd2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w, double* work, int lwork, int* iwork,
                int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevr_2stage")]
            public static extern int Dsyevr2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, double* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevr_2stage_work")]
            public static extern int Dsyevr2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il,
                int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevx_2stage")]
            public static extern int Dsyevx2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevx_2stage_work")]
            public static extern int Dsyevx2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il,
                int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsygv_2stage")]
            public static extern int Dsygv2stage(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsygv_2stage_work")]
            public static extern int Dsygv2stageWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbev_2stage")]
            public static extern int Ssbev2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbev_2stage_work")]
            public static extern int Ssbev2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz, float* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbevd_2stage")]
            public static extern int Ssbevd2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbevd_2stage_work")]
            public static extern int Ssbevd2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz,
                float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbevx_2stage")]
            public static extern int Ssbevx2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, float* ab, int ldab, float* q, int ldq, float vl,
                float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbevx_2stage_work")]
            public static extern int Ssbevx2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, float* ab, int ldab, float* q, int ldq,
                float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyev_2stage")]
            public static extern int Ssyev2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyev_2stage_work")]
            public static extern int Ssyev2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevd_2stage")]
            public static extern int Ssyevd2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevd_2stage_work")]
            public static extern int Ssyevd2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w, float* work, int lwork, int* iwork,
                int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevr_2stage")]
            public static extern int Ssyevr2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, float* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevr_2stage_work")]
            public static extern int Ssyevr2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, float* z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevx_2stage")]
            public static extern int Ssyevx2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevx_2stage_work")]
            public static extern int Ssyevx2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssygv_2stage")]
            public static extern int Ssygv2stage(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssygv_2stage_work")]
            public static extern int Ssygv2stageWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w,
                float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbev_2stage")]
            public static extern int Zhbev2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbev_2stage_work")]
            public static extern int Zhbev2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* w, System.IntPtr z,
                int ldz, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbevd_2stage")]
            public static extern int Zhbevd2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbevd_2stage_work")]
            public static extern int Zhbevd2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* w, System.IntPtr z,
                int ldz, System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbevx_2stage")]
            public static extern int Zhbevx2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, System.IntPtr q,
                int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhbevx_2stage_work")]
            public static extern int Zhbevx2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, System.IntPtr q,
                int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, double* rwork, int* iwork,
                int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zheev_2stage")]
            public static extern int Zheev2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zheev_2stage_work")]
            public static extern int Zheev2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, double* w, System.IntPtr work, int lwork,
                double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zheevd_2stage")]
            public static extern int Zheevd2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zheevd_2stage_work")]
            public static extern int Zheevd2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, double* w, System.IntPtr work, int lwork,
                double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zheevr_2stage")]
            public static extern int Zheevr2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, double vl, double vu, int il,
                int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zheevr_2stage_work")]
            public static extern int Zheevr2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, double vl, double vu, int il,
                int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* isuppz, System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zheevx_2stage")]
            public static extern int Zheevx2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, double vl, double vu, int il,
                int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zheevx_2stage_work")]
            public static extern int Zheevx2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, double vl, double vu, int il,
                int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhegv_2stage")]
            public static extern int Zhegv2stage(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhegv_2stage_work")]
            public static extern int Zhegv2stageWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb,
                double* w, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_cgetrfnp")]
            public static extern int MklCgetrfnp(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_cgetrfnp_work")]
            public static extern int MklCgetrfnpWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_dgetrfnp")]
            public static extern int MklDgetrfnp(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_dgetrfnp_work")]
            public static extern int MklDgetrfnpWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_sgetrfnp")]
            public static extern int MklSgetrfnp(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_sgetrfnp_work")]
            public static extern int MklSgetrfnpWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_zgetrfnp")]
            public static extern int MklZgetrfnp(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_zgetrfnp_work")]
            public static extern int MklZgetrfnpWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_cgetrinp")]
            public static extern int MklCgetrinp(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_cgetrinp_work")]
            public static extern int MklCgetrinpWork(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_dgetrinp")]
            public static extern int MklDgetrinp(BLAS.LAYOUT matrixLayout, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_dgetrinp_work")]
            public static extern int MklDgetrinpWork(BLAS.LAYOUT matrixLayout, int n, double* a, int lda, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_sgetrinp")]
            public static extern int MklSgetrinp(BLAS.LAYOUT matrixLayout, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_sgetrinp_work")]
            public static extern int MklSgetrinpWork(BLAS.LAYOUT matrixLayout, int n, float* a, int lda, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_zgetrinp")]
            public static extern int MklZgetrinp(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_mkl_zgetrinp_work")]
            public static extern int MklZgetrinpWork(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_set_nancheck")]
            public static extern void SetNancheck(int flag);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_get_nancheck")]
            public static extern int GetNancheck();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chesv_aa_2stage")]
            public static extern int ChesvAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv,
                int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrf_aa_2stage")]
            public static extern int ChetrfAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chesv_aa_2stage_work")]
            public static extern int ChesvAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv,
                int* ipiv2, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrf_aa_2stage_work")]
            public static extern int ChetrfAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrs_aa_2stage")]
            public static extern int ChetrsAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv,
                int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_chetrs_aa_2stage_work")]
            public static extern int ChetrsAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv,
                int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csysv_aa_2stage")]
            public static extern int CsysvAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv,
                int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csysv_aa_2stage_work")]
            public static extern int CsysvAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv,
                int* ipiv2, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrf_aa_2stage")]
            public static extern int CsytrfAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrf_aa_2stage_work")]
            public static extern int CsytrfAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrs_aa_2stage")]
            public static extern int CsytrsAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv,
                int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_csytrs_aa_2stage_work")]
            public static extern int CsytrsAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv,
                int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysv_aa_2stage")]
            public static extern int DsysvAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2, double* b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysv_aa_2stage_work")]
            public static extern int DsysvAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2,
                double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrf_aa_2stage")]
            public static extern int DsytrfAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrf_aa_2stage_work")]
            public static extern int DsytrfAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2, double* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs_aa_2stage")]
            public static extern int DsytrsAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2,
                double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs_aa_2stage_work")]
            public static extern int DsytrsAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2,
                double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsysv_aa_2stage")]
            public static extern int ZsysvAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv,
                int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsysv_aa_2stage_work")]
            public static extern int ZsysvAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv,
                int* ipiv2, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrf_aa_2stage")]
            public static extern int ZsytrfAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrf_aa_2stage_work")]
            public static extern int ZsytrfAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrs_aa_2stage")]
            public static extern int ZsytrsAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv,
                int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zsytrs_aa_2stage_work")]
            public static extern int ZsytrsAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv,
                int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysv_aa_2stage")]
            public static extern int SsysvAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2, float* b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysv_aa_2stage_work")]
            public static extern int SsysvAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2,
                float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrf_aa_2stage")]
            public static extern int SsytrfAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrf_aa_2stage_work")]
            public static extern int SsytrfAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2, float* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs_aa_2stage")]
            public static extern int SsytrsAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2, float* b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs_aa_2stage_work")]
            public static extern int SsytrsAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2,
                float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhesv_aa_2stage")]
            public static extern int ZhesvAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv,
                int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhesv_aa_2stage_work")]
            public static extern int ZhesvAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv,
                int* ipiv2, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrf_aa_2stage_work")]
            public static extern int ZhetrfAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2,
                System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrf_aa_2stage")]
            public static extern int ZhetrfAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrs_aa_2stage")]
            public static extern int ZhetrsAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv,
                int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_zhetrs_aa_2stage_work")]
            public static extern int ZhetrsAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv,
                int* ipiv2, System.IntPtr b, int ldb);
        }
    }
}