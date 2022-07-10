// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System;
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
            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlamch")]
            public static extern double Dlamch(sbyte cmach);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlamch_work")]
            public static extern double DlamchWork(sbyte cmach);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlange")]
            public static extern double Dlange(MatrixLayout matrixLayout, sbyte norm, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlange_work")]
            public static extern double DlangeWork(MatrixLayout matrixLayout, sbyte norm, int m, int n, double* a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlansy")]
            public static extern double Dlansy(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlansy_work")]
            public static extern double DlansyWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, int n, double* a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlantr")]
            public static extern double Dlantr(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlantr_work")]
            public static extern double DlantrWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int m, int n, double* a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlapy2")]
            public static extern double Dlapy2(double x, double y);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlapy2_work")]
            public static extern double Dlapy2Work(double x, double y);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlapy3")]
            public static extern double Dlapy3(double x, double y, double z);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlapy3_work")]
            public static extern double Dlapy3Work(double x, double y, double z);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlange")]
            public static extern double Zlange(MatrixLayout matrixLayout, sbyte norm, int m, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlange_work")]
            public static extern double ZlangeWork(MatrixLayout matrixLayout, sbyte norm, int m, int n, IntPtr a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlanhe")]
            public static extern double Zlanhe(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlanhe_work")]
            public static extern double ZlanheWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, int n, IntPtr a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarcm")]
            public static extern int Zlarcm(MatrixLayout matrixLayout, int m, int n, double* a, int lda, IntPtr b, int ldb, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarcm_work")]
            public static extern int ZlarcmWork(MatrixLayout matrixLayout, int m, int n, double* a, int lda, IntPtr b, int ldb, IntPtr c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlacrm")]
            public static extern int Zlacrm(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, double* b, int ldb, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlacrm_work")]
            public static extern int ZlacrmWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, double* b, int ldb, IntPtr c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlansy")]
            public static extern double Zlansy(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlansy_work")]
            public static extern double ZlansyWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, int n, IntPtr a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlantr")]
            public static extern double Zlantr(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int m, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlantr_work")]
            public static extern double ZlantrWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int m, int n, IntPtr a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clange")]
            public static extern float Clange(MatrixLayout matrixLayout, sbyte norm, int m, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clange_work")]
            public static extern float ClangeWork(MatrixLayout matrixLayout, sbyte norm, int m, int n, IntPtr a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clanhe")]
            public static extern float Clanhe(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clanhe_work")]
            public static extern float ClanheWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, int n, IntPtr a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarcm")]
            public static extern int Clarcm(MatrixLayout matrixLayout, int m, int n, float* a, int lda, IntPtr b, int ldb, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarcm_work")]
            public static extern int ClarcmWork(MatrixLayout matrixLayout, int m, int n, float* a, int lda, IntPtr b, int ldb, IntPtr c, int ldc, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clacrm")]
            public static extern int Clacrm(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, float* b, int ldb, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clacrm_work")]
            public static extern int ClacrmWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, float* b, int ldb, IntPtr c, int ldc, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clansy")]
            public static extern float Clansy(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clansy_work")]
            public static extern float ClansyWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, int n, IntPtr a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clantr")]
            public static extern float Clantr(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int m, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clantr_work")]
            public static extern float ClantrWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int m, int n, IntPtr a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slamch")]
            public static extern float Slamch(sbyte cmach);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slamch_work")]
            public static extern float SlamchWork(sbyte cmach);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slange")]
            public static extern float Slange(MatrixLayout matrixLayout, sbyte norm, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slange_work")]
            public static extern float SlangeWork(MatrixLayout matrixLayout, sbyte norm, int m, int n, float* a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slansy")]
            public static extern float Slansy(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slansy_work")]
            public static extern float SlansyWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, int n, float* a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slantr")]
            public static extern float Slantr(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slantr_work")]
            public static extern float SlantrWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int m, int n, float* a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slapy2")]
            public static extern float Slapy2(float x, float y);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slapy2_work")]
            public static extern float Slapy2Work(float x, float y);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slapy3")]
            public static extern float Slapy3(float x, float y, float z);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slapy3_work")]
            public static extern float Slapy3Work(float x, float y, float z);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cbbcsd")]
            public static extern int Cbbcsd(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, TransLapack trans, int m, int p, int q, float* theta, float* phi, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t, IntPtr v2t, int ldv2t, float* b11d, float* b11e, float* b12d, float* b12e, float* b21d, float* b21e, float* b22d, float* b22e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cbbcsd_work")]
            public static extern int CbbcsdWork(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, TransLapack trans, int m, int p, int q, float* theta, float* phi, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t, IntPtr v2t, int ldv2t, float* b11d, float* b11e, float* b12d, float* b12e, float* b21d, float* b21e, float* b22d, float* b22e, float* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cbdsqr")]
            public static extern int Cbdsqr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int ncvt, int nru, int ncc, float* d, float* e, IntPtr vt, int ldvt, IntPtr u, int ldu, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cbdsqr_work")]
            public static extern int CbdsqrWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int ncvt, int nru, int ncc, float* d, float* e, IntPtr vt, int ldvt, IntPtr u, int ldu, IntPtr c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbbrd")]
            public static extern int Cgbbrd(MatrixLayout matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, IntPtr ab, int ldab, float* d, float* e, IntPtr q, int ldq, IntPtr pt, int ldpt, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbbrd_work")]
            public static extern int CgbbrdWork(MatrixLayout matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, IntPtr ab, int ldab, float* d, float* e, IntPtr q, int ldq, IntPtr pt, int ldpt, IntPtr c, int ldc, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbcon")]
            public static extern int Cgbcon(MatrixLayout matrixLayout, sbyte norm, int n, int kl, int ku, IntPtr ab, int ldab, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbcon_work")]
            public static extern int CgbconWork(MatrixLayout matrixLayout, sbyte norm, int n, int kl, int ku, IntPtr ab, int ldab, int* ipiv, float anorm, float* rcond, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbequ")]
            public static extern int Cgbequ(MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbequ_work")]
            public static extern int CgbequWork(MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbequb")]
            public static extern int Cgbequb(MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbequb_work")]
            public static extern int CgbequbWork(MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbrfs")]
            public static extern int Cgbrfs(MatrixLayout matrixLayout, TransLapack trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbrfs_work")]
            public static extern int CgbrfsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbrfsx")]
            public static extern int Cgbrfsx(MatrixLayout matrixLayout, TransLapack trans, sbyte equed, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbrfsx_work")]
            public static extern int CgbrfsxWork(MatrixLayout matrixLayout, TransLapack trans, sbyte equed, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbsv")]
            public static extern int Cgbsv(MatrixLayout matrixLayout, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbsv_work")]
            public static extern int CgbsvWork(MatrixLayout matrixLayout, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbsvx")]
            public static extern int Cgbsvx(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, float* rpivot);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbsvx_work")]
            public static extern int CgbsvxWork(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbsvxx")]
            public static extern int Cgbsvxx(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbsvxx_work")]
            public static extern int CgbsvxxWork(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbtrf")]
            public static extern int Cgbtrf(MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbtrf_work")]
            public static extern int CgbtrfWork(MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbtrs")]
            public static extern int Cgbtrs(MatrixLayout matrixLayout, TransLapack trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbtrs_work")]
            public static extern int CgbtrsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgebak")]
            public static extern int Cgebak(MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* scale, int m, IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgebak_work")]
            public static extern int CgebakWork(MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* scale, int m, IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgebal")]
            public static extern int Cgebal(MatrixLayout matrixLayout, sbyte job, int n, IntPtr a, int lda, int* ilo, int* ihi, float* scale);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgebal_work")]
            public static extern int CgebalWork(MatrixLayout matrixLayout, sbyte job, int n, IntPtr a, int lda, int* ilo, int* ihi, float* scale);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgebrd")]
            public static extern int Cgebrd(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, float* d, float* e, IntPtr tauq, IntPtr taup);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgebrd_work")]
            public static extern int CgebrdWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, float* d, float* e, IntPtr tauq, IntPtr taup, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgecon")]
            public static extern int Cgecon(MatrixLayout matrixLayout, sbyte norm, int n, IntPtr a, int lda, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgecon_work")]
            public static extern int CgeconWork(MatrixLayout matrixLayout, sbyte norm, int n, IntPtr a, int lda, float anorm, float* rcond, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeequ")]
            public static extern int Cgeequ(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeequ_work")]
            public static extern int CgeequWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeequb")]
            public static extern int Cgeequb(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeequb_work")]
            public static extern int CgeequbWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgees")]
            public static extern int Cgees(MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, int n, IntPtr a, int lda, int* sdim, IntPtr w, IntPtr vs, int ldvs);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgees_work")]
            public static extern int CgeesWork(MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, int n, IntPtr a, int lda, int* sdim, IntPtr w, IntPtr vs, int ldvs, IntPtr work, int lwork, float* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeesx")]
            public static extern int Cgeesx(MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, sbyte sense, int n, IntPtr a, int lda, int* sdim, IntPtr w, IntPtr vs, int ldvs, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeesx_work")]
            public static extern int CgeesxWork(MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, sbyte sense, int n, IntPtr a, int lda, int* sdim, IntPtr w, IntPtr vs, int ldvs, float* rconde, float* rcondv, IntPtr work, int lwork, float* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeev")]
            public static extern int Cgeev(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeev_work")]
            public static extern int CgeevWork(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeevx")]
            public static extern int Cgeevx(MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, IntPtr a, int lda, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int* ilo, int* ihi, float* scale, float* abnrm, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeevx_work")]
            public static extern int CgeevxWork(MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, IntPtr a, int lda, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int* ilo, int* ihi, float* scale, float* abnrm, float* rconde, float* rcondv, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgehrd")]
            public static extern int Cgehrd(MatrixLayout matrixLayout, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgehrd_work")]
            public static extern int CgehrdWork(MatrixLayout matrixLayout, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgejsv")]
            public static extern int Cgejsv(MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, IntPtr a, int lda, float* sva, IntPtr u, int ldu, IntPtr v, int ldv, float* stat, int* istat);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgejsv_work")]
            public static extern int CgejsvWork(MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, IntPtr a, int lda, float* sva, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr cwork, int lwork, float* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelq2")]
            public static extern int Cgelq2(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelq2_work")]
            public static extern int Cgelq2Work(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelqf")]
            public static extern int Cgelqf(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelqf_work")]
            public static extern int CgelqfWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgels")]
            public static extern int Cgels(MatrixLayout matrixLayout, TransLapack trans, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgels_work")]
            public static extern int CgelsWork(MatrixLayout matrixLayout, TransLapack trans, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelsd")]
            public static extern int Cgelsd(MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, float* s, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelsd_work")]
            public static extern int CgelsdWork(MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, float* s, float rcond, int* rank, IntPtr work, int lwork, float* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelss")]
            public static extern int Cgelss(MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, float* s, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelss_work")]
            public static extern int CgelssWork(MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, float* s, float rcond, int* rank, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelsy")]
            public static extern int Cgelsy(MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, int* jpvt, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelsy_work")]
            public static extern int CgelsyWork(MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, int* jpvt, float rcond, int* rank, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgemqrt")]
            public static extern int Cgemqrt(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int nb, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgemqrt_work")]
            public static extern int CgemqrtWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int nb, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr c, int ldc, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqlf")]
            public static extern int Cgeqlf(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqlf_work")]
            public static extern int CgeqlfWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqp3")]
            public static extern int Cgeqp3(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* jpvt, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqp3_work")]
            public static extern int Cgeqp3Work(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* jpvt, IntPtr tau, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqpf")]
            public static extern int Cgeqpf(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* jpvt, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqpf_work")]
            public static extern int CgeqpfWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* jpvt, IntPtr tau, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqr2")]
            public static extern int Cgeqr2(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqr2_work")]
            public static extern int Cgeqr2Work(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqrf")]
            public static extern int Cgeqrf(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqrf_work")]
            public static extern int CgeqrfWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqrfp")]
            public static extern int Cgeqrfp(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqrfp_work")]
            public static extern int CgeqrfpWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqrt")]
            public static extern int Cgeqrt(MatrixLayout matrixLayout, int m, int n, int nb, IntPtr a, int lda, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqrt2")]
            public static extern int Cgeqrt2(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqrt2_work")]
            public static extern int Cgeqrt2Work(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqrt3")]
            public static extern int Cgeqrt3(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqrt3_work")]
            public static extern int Cgeqrt3Work(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqrt_work")]
            public static extern int CgeqrtWork(MatrixLayout matrixLayout, int m, int n, int nb, IntPtr a, int lda, IntPtr t, int ldt, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgerfs")]
            public static extern int Cgerfs(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgerfs_work")]
            public static extern int CgerfsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgerfsx")]
            public static extern int Cgerfsx(MatrixLayout matrixLayout, TransLapack trans, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgerfsx_work")]
            public static extern int CgerfsxWork(MatrixLayout matrixLayout, TransLapack trans, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgerqf")]
            public static extern int Cgerqf(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgerqf_work")]
            public static extern int CgerqfWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesdd")]
            public static extern int Cgesdd(MatrixLayout matrixLayout, sbyte jobz, int m, int n, IntPtr a, int lda, float* s, IntPtr u, int ldu, IntPtr vt, int ldvt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesdd_work")]
            public static extern int CgesddWork(MatrixLayout matrixLayout, sbyte jobz, int m, int n, IntPtr a, int lda, float* s, IntPtr u, int ldu, IntPtr vt, int ldvt, IntPtr work, int lwork, float* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesv")]
            public static extern int Cgesv(MatrixLayout matrixLayout, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesv_work")]
            public static extern int CgesvWork(MatrixLayout matrixLayout, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvd")]
            public static extern int Cgesvd(MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, IntPtr a, int lda, float* s, IntPtr u, int ldu, IntPtr vt, int ldvt, float* superb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvd_work")]
            public static extern int CgesvdWork(MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, IntPtr a, int lda, float* s, IntPtr u, int ldu, IntPtr vt, int ldvt, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvdx")]
            public static extern int Cgesvdx(MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, IntPtr a, int lda, float vl, float vu, int il, int iu, int* ns, float* s, IntPtr u, int ldu, IntPtr vt, int ldvt, int* superb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvdx_work")]
            public static extern int CgesvdxWork(MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, IntPtr a, int lda, float vl, float vu, int il, int iu, int* ns, float* s, IntPtr u, int ldu, IntPtr vt, int ldvt, IntPtr work, int lwork, float* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvj")]
            public static extern int Cgesvj(MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, IntPtr a, int lda, float* sva, int mv, IntPtr v, int ldv, float* stat);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvj_work")]
            public static extern int CgesvjWork(MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, IntPtr a, int lda, float* sva, int mv, IntPtr v, int ldv, IntPtr cwork, int lwork, float* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvx")]
            public static extern int Cgesvx(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, float* rpivot);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvx_work")]
            public static extern int CgesvxWork(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvxx")]
            public static extern int Cgesvxx(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvxx_work")]
            public static extern int CgesvxxWork(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetf2")]
            public static extern int Cgetf2(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetf2_work")]
            public static extern int Cgetf2Work(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetrf")]
            public static extern int Cgetrf(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetrf2")]
            public static extern int Cgetrf2(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetrf2_work")]
            public static extern int Cgetrf2Work(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetrf_work")]
            public static extern int CgetrfWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetri")]
            public static extern int Cgetri(MatrixLayout matrixLayout, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetri_work")]
            public static extern int CgetriWork(MatrixLayout matrixLayout, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetrs")]
            public static extern int Cgetrs(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetrs_work")]
            public static extern int CgetrsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggbak")]
            public static extern int Cggbak(MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* lscale, float* rscale, int m, IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggbak_work")]
            public static extern int CggbakWork(MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* lscale, float* rscale, int m, IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggbal")]
            public static extern int Cggbal(MatrixLayout matrixLayout, sbyte job, int n, IntPtr a, int lda, IntPtr b, int ldb, int* ilo, int* ihi, float* lscale, float* rscale);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggbal_work")]
            public static extern int CggbalWork(MatrixLayout matrixLayout, sbyte job, int n, IntPtr a, int lda, IntPtr b, int ldb, int* ilo, int* ihi, float* lscale, float* rscale, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgges")]
            public static extern int Cgges(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgges3")]
            public static extern int Cgges3(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgges3_work")]
            public static extern int Cgges3Work(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr, IntPtr work, int lwork, float* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgges_work")]
            public static extern int CggesWork(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr, IntPtr work, int lwork, float* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggesx")]
            public static extern int Cggesx(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, sbyte sense, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggesx_work")]
            public static extern int CggesxWork(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, sbyte sense, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr, float* rconde, float* rcondv, IntPtr work, int lwork, float* rwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggev")]
            public static extern int Cggev(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggev3")]
            public static extern int Cggev3(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggev3_work")]
            public static extern int Cggev3Work(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggev_work")]
            public static extern int CggevWork(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggevx")]
            public static extern int Cggevx(MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int* ilo, int* ihi, float* lscale, float* rscale, float* abnrm, float* bbnrm, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggevx_work")]
            public static extern int CggevxWork(MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int* ilo, int* ihi, float* lscale, float* rscale, float* abnrm, float* bbnrm, float* rconde, float* rcondv, IntPtr work, int lwork, float* rwork, int* iwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggglm")]
            public static extern int Cggglm(MatrixLayout matrixLayout, int n, int m, int p, IntPtr a, int lda, IntPtr b, int ldb, IntPtr d, IntPtr x, IntPtr y);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggglm_work")]
            public static extern int CggglmWork(MatrixLayout matrixLayout, int n, int m, int p, IntPtr a, int lda, IntPtr b, int ldb, IntPtr d, IntPtr x, IntPtr y, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgghd3")]
            public static extern int Cgghd3(MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgghd3_work")]
            public static extern int Cgghd3Work(MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgghrd")]
            public static extern int Cgghrd(MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgghrd_work")]
            public static extern int CgghrdWork(MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgglse")]
            public static extern int Cgglse(MatrixLayout matrixLayout, int m, int n, int p, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, IntPtr d, IntPtr x);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgglse_work")]
            public static extern int CgglseWork(MatrixLayout matrixLayout, int m, int n, int p, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, IntPtr d, IntPtr x, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggqrf")]
            public static extern int Cggqrf(MatrixLayout matrixLayout, int n, int m, int p, IntPtr a, int lda, IntPtr taua, IntPtr b, int ldb, IntPtr taub);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggqrf_work")]
            public static extern int CggqrfWork(MatrixLayout matrixLayout, int n, int m, int p, IntPtr a, int lda, IntPtr taua, IntPtr b, int ldb, IntPtr taub, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggrqf")]
            public static extern int Cggrqf(MatrixLayout matrixLayout, int m, int p, int n, IntPtr a, int lda, IntPtr taua, IntPtr b, int ldb, IntPtr taub);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggrqf_work")]
            public static extern int CggrqfWork(MatrixLayout matrixLayout, int m, int p, int n, IntPtr a, int lda, IntPtr taua, IntPtr b, int ldb, IntPtr taub, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggsvd")]
            public static extern int Cggsvd(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, IntPtr a, int lda, IntPtr b, int ldb, float* alpha, float* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggsvd3")]
            public static extern int Cggsvd3(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, IntPtr a, int lda, IntPtr b, int ldb, float* alpha, float* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggsvd3_work")]
            public static extern int Cggsvd3Work(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, IntPtr a, int lda, IntPtr b, int ldb, float* alpha, float* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, IntPtr work, int lwork, float* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggsvd_work")]
            public static extern int CggsvdWork(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, IntPtr a, int lda, IntPtr b, int ldb, float* alpha, float* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, IntPtr work, float* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggsvp")]
            public static extern int Cggsvp(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, IntPtr a, int lda, IntPtr b, int ldb, float tola, float tolb, int* k, int* l, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggsvp3")]
            public static extern int Cggsvp3(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, IntPtr a, int lda, IntPtr b, int ldb, float tola, float tolb, int* k, int* l, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggsvp3_work")]
            public static extern int Cggsvp3Work(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, IntPtr a, int lda, IntPtr b, int ldb, float tola, float tolb, int* k, int* l, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, int* iwork, float* rwork, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggsvp_work")]
            public static extern int CggsvpWork(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, IntPtr a, int lda, IntPtr b, int ldb, float tola, float tolb, int* k, int* l, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, int* iwork, float* rwork, IntPtr tau, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgtcon")]
            public static extern int Cgtcon(sbyte norm, int n, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgtcon_work")]
            public static extern int CgtconWork(sbyte norm, int n, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv, float anorm, float* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgtrfs")]
            public static extern int Cgtrfs(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr dlf, IntPtr df, IntPtr duf, IntPtr du2, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgtrfs_work")]
            public static extern int CgtrfsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr dlf, IntPtr df, IntPtr duf, IntPtr du2, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgtsv")]
            public static extern int Cgtsv(MatrixLayout matrixLayout, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgtsv_work")]
            public static extern int CgtsvWork(MatrixLayout matrixLayout, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgtsvx")]
            public static extern int Cgtsvx(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr dlf, IntPtr df, IntPtr duf, IntPtr du2, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgtsvx_work")]
            public static extern int CgtsvxWork(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr dlf, IntPtr df, IntPtr duf, IntPtr du2, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgttrf")]
            public static extern int Cgttrf(int n, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgttrf_work")]
            public static extern int CgttrfWork(int n, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgttrs")]
            public static extern int Cgttrs(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgttrs_work")]
            public static extern int CgttrsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbev")]
            public static extern int Chbev(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, float* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbev_work")]
            public static extern int ChbevWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, float* w, IntPtr z, int ldz, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbevd")]
            public static extern int Chbevd(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, float* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbevd_work")]
            public static extern int ChbevdWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, float* w, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbevx")]
            public static extern int Chbevx(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, IntPtr q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbevx_work")]
            public static extern int ChbevxWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, IntPtr q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, IntPtr work, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbgst")]
            public static extern int Chbgst(MatrixLayout matrixLayout, sbyte vect, UpLoLapack uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, IntPtr x, int ldx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbgst_work")]
            public static extern int ChbgstWork(MatrixLayout matrixLayout, sbyte vect, UpLoLapack uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, IntPtr x, int ldx, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbgv")]
            public static extern int Chbgv(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, float* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbgv_work")]
            public static extern int ChbgvWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, float* w, IntPtr z, int ldz, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbgvd")]
            public static extern int Chbgvd(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, float* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbgvd_work")]
            public static extern int ChbgvdWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, float* w, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbgvx")]
            public static extern int Chbgvx(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, IntPtr q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbgvx_work")]
            public static extern int ChbgvxWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, IntPtr q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, IntPtr work, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbtrd")]
            public static extern int Chbtrd(MatrixLayout matrixLayout, sbyte vect, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, float* d, float* e, IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbtrd_work")]
            public static extern int ChbtrdWork(MatrixLayout matrixLayout, sbyte vect, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, float* d, float* e, IntPtr q, int ldq, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_checon")]
            public static extern int Checon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_checon_work")]
            public static extern int CheconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, float anorm, float* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheequb")]
            public static extern int Cheequb(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheequb_work")]
            public static extern int CheequbWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, float* s, float* scond, float* amax, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheev")]
            public static extern int Cheev(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheev_work")]
            public static extern int CheevWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, float* w, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevd")]
            public static extern int Cheevd(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevd_work")]
            public static extern int CheevdWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, float* w, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevr")]
            public static extern int Cheevr(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevr_work")]
            public static extern int CheevrWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* isuppz, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevx")]
            public static extern int Cheevx(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevx_work")]
            public static extern int CheevxWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chegst")]
            public static extern int Chegst(MatrixLayout matrixLayout, int itype, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chegst_work")]
            public static extern int ChegstWork(MatrixLayout matrixLayout, int itype, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chegv")]
            public static extern int Chegv(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chegv_work")]
            public static extern int ChegvWork(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, float* w, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chegvd")]
            public static extern int Chegvd(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chegvd_work")]
            public static extern int ChegvdWork(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, float* w, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chegvx")]
            public static extern int Chegvx(MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chegvx_work")]
            public static extern int ChegvxWork(MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cherfs")]
            public static extern int Cherfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cherfs_work")]
            public static extern int CherfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cherfsx")]
            public static extern int Cherfsx(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cherfsx_work")]
            public static extern int CherfsxWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesv")]
            public static extern int Chesv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesv_work")]
            public static extern int ChesvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesvx")]
            public static extern int Chesvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesvx_work")]
            public static extern int ChesvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesvxx")]
            public static extern int Chesvxx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesvxx_work")]
            public static extern int ChesvxxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheswapr")]
            public static extern int Cheswapr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheswapr_work")]
            public static extern int CheswaprWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrd")]
            public static extern int Chetrd(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, float* d, float* e, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrd_work")]
            public static extern int ChetrdWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, float* d, float* e, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrf")]
            public static extern int Chetrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrf_rook")]
            public static extern int ChetrfRook(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrf_rook_work")]
            public static extern int ChetrfRookWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrf_work")]
            public static extern int ChetrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetri")]
            public static extern int Chetri(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetri2")]
            public static extern int Chetri2(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetri2_work")]
            public static extern int Chetri2Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetri2x")]
            public static extern int Chetri2x(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetri2x_work")]
            public static extern int Chetri2xWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetri_work")]
            public static extern int ChetriWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs")]
            public static extern int Chetrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs2")]
            public static extern int Chetrs2(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs2_work")]
            public static extern int Chetrs2Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs_rook")]
            public static extern int ChetrsRook(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs_rook_work")]
            public static extern int ChetrsRookWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs_work")]
            public static extern int ChetrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chfrk")]
            public static extern int Chfrk(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, TransLapack trans, int n, int k, float alpha, IntPtr a, int lda, float beta, IntPtr c);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chfrk_work")]
            public static extern int ChfrkWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, TransLapack trans, int n, int k, float alpha, IntPtr a, int lda, float beta, IntPtr c);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chgeqz")]
            public static extern int Chgeqz(MatrixLayout matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr h, int ldh, IntPtr t, int ldt, IntPtr alpha, IntPtr beta, IntPtr q, int ldq, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chgeqz_work")]
            public static extern int ChgeqzWork(MatrixLayout matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr h, int ldh, IntPtr t, int ldt, IntPtr alpha, IntPtr beta, IntPtr q, int ldq, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpcon")]
            public static extern int Chpcon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpcon_work")]
            public static extern int ChpconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv, float anorm, float* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpev")]
            public static extern int Chpev(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr ap, float* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpev_work")]
            public static extern int ChpevWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr ap, float* w, IntPtr z, int ldz, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpevd")]
            public static extern int Chpevd(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr ap, float* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpevd_work")]
            public static extern int ChpevdWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr ap, float* w, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpevx")]
            public static extern int Chpevx(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr ap, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpevx_work")]
            public static extern int ChpevxWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr ap, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, IntPtr work, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpgst")]
            public static extern int Chpgst(MatrixLayout matrixLayout, int itype, UpLoLapack uplo, int n, IntPtr ap, IntPtr bp);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpgst_work")]
            public static extern int ChpgstWork(MatrixLayout matrixLayout, int itype, UpLoLapack uplo, int n, IntPtr ap, IntPtr bp);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpgv")]
            public static extern int Chpgv(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, IntPtr ap, IntPtr bp, float* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpgv_work")]
            public static extern int ChpgvWork(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, IntPtr ap, IntPtr bp, float* w, IntPtr z, int ldz, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpgvd")]
            public static extern int Chpgvd(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, IntPtr ap, IntPtr bp, float* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpgvd_work")]
            public static extern int ChpgvdWork(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, IntPtr ap, IntPtr bp, float* w, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpgvx")]
            public static extern int Chpgvx(MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr ap, IntPtr bp, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpgvx_work")]
            public static extern int ChpgvxWork(MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr ap, IntPtr bp, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, IntPtr work, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chprfs")]
            public static extern int Chprfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chprfs_work")]
            public static extern int ChprfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpsv")]
            public static extern int Chpsv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpsv_work")]
            public static extern int ChpsvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpsvx")]
            public static extern int Chpsvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpsvx_work")]
            public static extern int ChpsvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chptrd")]
            public static extern int Chptrd(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, float* d, float* e, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chptrd_work")]
            public static extern int ChptrdWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, float* d, float* e, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chptrf")]
            public static extern int Chptrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chptrf_work")]
            public static extern int ChptrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chptri")]
            public static extern int Chptri(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chptri_work")]
            public static extern int ChptriWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chptrs")]
            public static extern int Chptrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chptrs_work")]
            public static extern int ChptrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chsein")]
            public static extern int Chsein(MatrixLayout matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, IntPtr h, int ldh, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chsein_work")]
            public static extern int ChseinWork(MatrixLayout matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, IntPtr h, int ldh, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m, IntPtr work, float* rwork, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chseqr")]
            public static extern int Chseqr(MatrixLayout matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, IntPtr h, int ldh, IntPtr w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chseqr_work")]
            public static extern int ChseqrWork(MatrixLayout matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, IntPtr h, int ldh, IntPtr w, IntPtr z, int ldz, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clacgv")]
            public static extern int Clacgv(int n, IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clacgv_work")]
            public static extern int ClacgvWork(int n, IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clacn2")]
            public static extern int Clacn2(int n, IntPtr v, IntPtr x, float* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clacn2_work")]
            public static extern int Clacn2Work(int n, IntPtr v, IntPtr x, float* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clacp2")]
            public static extern int Clacp2(MatrixLayout matrixLayout, UpLoLapack uplo, int m, int n, float* a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clacp2_work")]
            public static extern int Clacp2Work(MatrixLayout matrixLayout, UpLoLapack uplo, int m, int n, float* a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clacpy")]
            public static extern int Clacpy(MatrixLayout matrixLayout, UpLoLapack uplo, int m, int n, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clacpy_work")]
            public static extern int ClacpyWork(MatrixLayout matrixLayout, UpLoLapack uplo, int m, int n, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clag2z")]
            public static extern int Clag2z(MatrixLayout matrixLayout, int m, int n, IntPtr sa, int ldsa, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clag2z_work")]
            public static extern int Clag2zWork(MatrixLayout matrixLayout, int m, int n, IntPtr sa, int ldsa, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clagge")]
            public static extern int Clagge(MatrixLayout matrixLayout, int m, int n, int kl, int ku, float* d, IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clagge_work")]
            public static extern int ClaggeWork(MatrixLayout matrixLayout, int m, int n, int kl, int ku, float* d, IntPtr a, int lda, int* iseed, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_claghe")]
            public static extern int Claghe(MatrixLayout matrixLayout, int n, int k, float* d, IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_claghe_work")]
            public static extern int ClagheWork(MatrixLayout matrixLayout, int n, int k, float* d, IntPtr a, int lda, int* iseed, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clagsy")]
            public static extern int Clagsy(MatrixLayout matrixLayout, int n, int k, float* d, IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clagsy_work")]
            public static extern int ClagsyWork(MatrixLayout matrixLayout, int n, int k, float* d, IntPtr a, int lda, int* iseed, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clapmr")]
            public static extern int Clapmr(MatrixLayout matrixLayout, int forwrd, int m, int n, IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clapmr_work")]
            public static extern int ClapmrWork(MatrixLayout matrixLayout, int forwrd, int m, int n, IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clapmt")]
            public static extern int Clapmt(MatrixLayout matrixLayout, int forwrd, int m, int n, IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clapmt_work")]
            public static extern int ClapmtWork(MatrixLayout matrixLayout, int forwrd, int m, int n, IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarfb")]
            public static extern int Clarfb(MatrixLayout matrixLayout, sbyte side, TransLapack trans, sbyte direct, sbyte storev, int m, int n, int k, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarfb_work")]
            public static extern int ClarfbWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, sbyte direct, sbyte storev, int m, int n, int k, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr c, int ldc, IntPtr work, int ldwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarfg")]
            public static extern int Clarfg(int n, IntPtr alpha, IntPtr x, int incx, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarfg_work")]
            public static extern int ClarfgWork(int n, IntPtr alpha, IntPtr x, int incx, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarft")]
            public static extern int Clarft(MatrixLayout matrixLayout, sbyte direct, sbyte storev, int n, int k, IntPtr v, int ldv, IntPtr tau, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarft_work")]
            public static extern int ClarftWork(MatrixLayout matrixLayout, sbyte direct, sbyte storev, int n, int k, IntPtr v, int ldv, IntPtr tau, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarfx")]
            public static extern int Clarfx(MatrixLayout matrixLayout, sbyte side, int m, int n, IntPtr v, ComplexFloat tau, IntPtr c, int ldc, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarfx_work")]
            public static extern int ClarfxWork(MatrixLayout matrixLayout, sbyte side, int m, int n, IntPtr v, ComplexFloat tau, IntPtr c, int ldc, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarnv")]
            public static extern int Clarnv(int idist, int* iseed, int n, IntPtr x);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarnv_work")]
            public static extern int ClarnvWork(int idist, int* iseed, int n, IntPtr x);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clascl")]
            public static extern int Clascl(MatrixLayout matrixLayout, sbyte type, int kl, int ku, float cfrom, float cto, int m, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clascl_work")]
            public static extern int ClasclWork(MatrixLayout matrixLayout, sbyte type, int kl, int ku, float cfrom, float cto, int m, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_claset")]
            public static extern int Claset(MatrixLayout matrixLayout, UpLoLapack uplo, int m, int n, ComplexFloat alpha, ComplexFloat beta, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_claset_work")]
            public static extern int ClasetWork(MatrixLayout matrixLayout, UpLoLapack uplo, int m, int n, ComplexFloat alpha, ComplexFloat beta, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_claswp")]
            public static extern int Claswp(MatrixLayout matrixLayout, int n, IntPtr a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_claswp_work")]
            public static extern int ClaswpWork(MatrixLayout matrixLayout, int n, IntPtr a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clatms")]
            public static extern int Clatms(MatrixLayout matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, float* d, int mode, float cond, float dmax, int kl, int ku, sbyte pack, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clatms_work")]
            public static extern int ClatmsWork(MatrixLayout matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, float* d, int mode, float cond, float dmax, int kl, int ku, sbyte pack, IntPtr a, int lda, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clauum")]
            public static extern int Clauum(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clauum_work")]
            public static extern int ClauumWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbcon")]
            public static extern int Cpbcon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbcon_work")]
            public static extern int CpbconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, float anorm, float* rcond, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbequ")]
            public static extern int Cpbequ(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbequ_work")]
            public static extern int CpbequWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbrfs")]
            public static extern int Cpbrfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbrfs_work")]
            public static extern int CpbrfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbstf")]
            public static extern int Cpbstf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kb, IntPtr bb, int ldbb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbstf_work")]
            public static extern int CpbstfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kb, IntPtr bb, int ldbb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbsv")]
            public static extern int Cpbsv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbsv_work")]
            public static extern int CpbsvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbsvx")]
            public static extern int Cpbsvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbsvx_work")]
            public static extern int CpbsvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbtrf")]
            public static extern int Cpbtrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbtrf_work")]
            public static extern int CpbtrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbtrs")]
            public static extern int Cpbtrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbtrs_work")]
            public static extern int CpbtrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpftrf")]
            public static extern int Cpftrf(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpftrf_work")]
            public static extern int CpftrfWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpftri")]
            public static extern int Cpftri(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpftri_work")]
            public static extern int CpftriWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpftrs")]
            public static extern int Cpftrs(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, int nrhs, IntPtr a, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpftrs_work")]
            public static extern int CpftrsWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, int nrhs, IntPtr a, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpocon")]
            public static extern int Cpocon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpocon_work")]
            public static extern int CpoconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, float anorm, float* rcond, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpoequ")]
            public static extern int Cpoequ(MatrixLayout matrixLayout, int n, IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpoequ_work")]
            public static extern int CpoequWork(MatrixLayout matrixLayout, int n, IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpoequb")]
            public static extern int Cpoequb(MatrixLayout matrixLayout, int n, IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpoequb_work")]
            public static extern int CpoequbWork(MatrixLayout matrixLayout, int n, IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cporfs")]
            public static extern int Cporfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cporfs_work")]
            public static extern int CporfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cporfsx")]
            public static extern int Cporfsx(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cporfsx_work")]
            public static extern int CporfsxWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cposv")]
            public static extern int Cposv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cposv_work")]
            public static extern int CposvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cposvx")]
            public static extern int Cposvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cposvx_work")]
            public static extern int CposvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cposvxx")]
            public static extern int Cposvxx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cposvxx_work")]
            public static extern int CposvxxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpotrf")]
            public static extern int Cpotrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpotrf2")]
            public static extern int Cpotrf2(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpotrf2_work")]
            public static extern int Cpotrf2Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpotrf_work")]
            public static extern int CpotrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpotri")]
            public static extern int Cpotri(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpotri_work")]
            public static extern int CpotriWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpotrs")]
            public static extern int Cpotrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpotrs_work")]
            public static extern int CpotrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cppcon")]
            public static extern int Cppcon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cppcon_work")]
            public static extern int CppconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, float anorm, float* rcond, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cppequ")]
            public static extern int Cppequ(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cppequ_work")]
            public static extern int CppequWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpprfs")]
            public static extern int Cpprfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpprfs_work")]
            public static extern int CpprfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cppsv")]
            public static extern int Cppsv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cppsv_work")]
            public static extern int CppsvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cppsvx")]
            public static extern int Cppsvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cppsvx_work")]
            public static extern int CppsvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpptrf")]
            public static extern int Cpptrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpptrf_work")]
            public static extern int CpptrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpptri")]
            public static extern int Cpptri(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpptri_work")]
            public static extern int CpptriWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpptrs")]
            public static extern int Cpptrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpptrs_work")]
            public static extern int CpptrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpstrf")]
            public static extern int Cpstrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* piv, int* rank, float tol);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpstrf_work")]
            public static extern int CpstrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* piv, int* rank, float tol, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cptcon")]
            public static extern int Cptcon(int n, float* d, IntPtr e, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cptcon_work")]
            public static extern int CptconWork(int n, float* d, IntPtr e, float anorm, float* rcond, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpteqr")]
            public static extern int Cpteqr(MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpteqr_work")]
            public static extern int CpteqrWork(MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, IntPtr z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cptrfs")]
            public static extern int Cptrfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* d, IntPtr e, float* df, IntPtr ef, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cptrfs_work")]
            public static extern int CptrfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* d, IntPtr e, float* df, IntPtr ef, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cptsv")]
            public static extern int Cptsv(MatrixLayout matrixLayout, int n, int nrhs, float* d, IntPtr e, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cptsv_work")]
            public static extern int CptsvWork(MatrixLayout matrixLayout, int n, int nrhs, float* d, IntPtr e, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cptsvx")]
            public static extern int Cptsvx(MatrixLayout matrixLayout, sbyte fact, int n, int nrhs, float* d, IntPtr e, float* df, IntPtr ef, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cptsvx_work")]
            public static extern int CptsvxWork(MatrixLayout matrixLayout, sbyte fact, int n, int nrhs, float* d, IntPtr e, float* df, IntPtr ef, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpttrf")]
            public static extern int Cpttrf(int n, float* d, IntPtr e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpttrf_work")]
            public static extern int CpttrfWork(int n, float* d, IntPtr e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpttrs")]
            public static extern int Cpttrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* d, IntPtr e, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpttrs_work")]
            public static extern int CpttrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* d, IntPtr e, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cspcon")]
            public static extern int Cspcon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cspcon_work")]
            public static extern int CspconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv, float anorm, float* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csprfs")]
            public static extern int Csprfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csprfs_work")]
            public static extern int CsprfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cspsv")]
            public static extern int Cspsv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cspsv_work")]
            public static extern int CspsvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cspsvx")]
            public static extern int Cspsvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cspsvx_work")]
            public static extern int CspsvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csptrf")]
            public static extern int Csptrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csptrf_work")]
            public static extern int CsptrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csptri")]
            public static extern int Csptri(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csptri_work")]
            public static extern int CsptriWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csptrs")]
            public static extern int Csptrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csptrs_work")]
            public static extern int CsptrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cstedc")]
            public static extern int Cstedc(MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cstedc_work")]
            public static extern int CstedcWork(MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cstegr")]
            public static extern int Cstegr(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cstegr_work")]
            public static extern int CstegrWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cstein")]
            public static extern int Cstein(MatrixLayout matrixLayout, int n, float* d, float* e, int m, float* w, int* iblock, int* isplit, IntPtr z, int ldz, int* ifailv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cstein_work")]
            public static extern int CsteinWork(MatrixLayout matrixLayout, int n, float* d, float* e, int m, float* w, int* iblock, int* isplit, IntPtr z, int ldz, float* work, int* iwork, int* ifailv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cstemr")]
            public static extern int Cstemr(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* m, float* w, IntPtr z, int ldz, int nzc, int* isuppz, int* tryrac);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cstemr_work")]
            public static extern int CstemrWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* m, float* w, IntPtr z, int ldz, int nzc, int* isuppz, int* tryrac, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csteqr")]
            public static extern int Csteqr(MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csteqr_work")]
            public static extern int CsteqrWork(MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, IntPtr z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csycon")]
            public static extern int Csycon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csycon_work")]
            public static extern int CsyconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, float anorm, float* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyconv")]
            public static extern int Csyconv(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte way, int n, IntPtr a, int lda, int* ipiv, IntPtr e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyconv_work")]
            public static extern int CsyconvWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte way, int n, IntPtr a, int lda, int* ipiv, IntPtr e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyequb")]
            public static extern int Csyequb(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyequb_work")]
            public static extern int CsyequbWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, float* s, float* scond, float* amax, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyr")]
            public static extern int Csyr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, ComplexFloat alpha, IntPtr x, int incx, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyr_work")]
            public static extern int CsyrWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, ComplexFloat alpha, IntPtr x, int incx, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyrfs")]
            public static extern int Csyrfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyrfs_work")]
            public static extern int CsyrfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyrfsx")]
            public static extern int Csyrfsx(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyrfsx_work")]
            public static extern int CsyrfsxWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysv")]
            public static extern int Csysv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysv_rook")]
            public static extern int CsysvRook(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysv_rook_work")]
            public static extern int CsysvRookWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysv_work")]
            public static extern int CsysvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysvx")]
            public static extern int Csysvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysvx_work")]
            public static extern int CsysvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysvxx")]
            public static extern int Csysvxx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysvxx_work")]
            public static extern int CsysvxxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyswapr")]
            public static extern int Csyswapr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyswapr_work")]
            public static extern int CsyswaprWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrf")]
            public static extern int Csytrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrf_rook")]
            public static extern int CsytrfRook(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrf_rook_work")]
            public static extern int CsytrfRookWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrf_work")]
            public static extern int CsytrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytri")]
            public static extern int Csytri(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytri2")]
            public static extern int Csytri2(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytri2_work")]
            public static extern int Csytri2Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytri2x")]
            public static extern int Csytri2x(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytri2x_work")]
            public static extern int Csytri2xWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytri_work")]
            public static extern int CsytriWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs")]
            public static extern int Csytrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs2")]
            public static extern int Csytrs2(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs2_work")]
            public static extern int Csytrs2Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs_rook")]
            public static extern int CsytrsRook(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs_rook_work")]
            public static extern int CsytrsRookWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs_work")]
            public static extern int CsytrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctbcon")]
            public static extern int Ctbcon(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, int kd, IntPtr ab, int ldab, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctbcon_work")]
            public static extern int CtbconWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, int kd, IntPtr ab, int ldab, float* rcond, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctbrfs")]
            public static extern int Ctbrfs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctbrfs_work")]
            public static extern int CtbrfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctbtrs")]
            public static extern int Ctbtrs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctbtrs_work")]
            public static extern int CtbtrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctfsm")]
            public static extern int Ctfsm(MatrixLayout matrixLayout, sbyte transr, sbyte side, UpLoLapack uplo, TransLapack trans, sbyte diag, int m, int n, ComplexFloat alpha, IntPtr a, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctfsm_work")]
            public static extern int CtfsmWork(MatrixLayout matrixLayout, sbyte transr, sbyte side, UpLoLapack uplo, TransLapack trans, sbyte diag, int m, int n, ComplexFloat alpha, IntPtr a, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctftri")]
            public static extern int Ctftri(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, sbyte diag, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctftri_work")]
            public static extern int CtftriWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, sbyte diag, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctfttp")]
            public static extern int Ctfttp(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr arf, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctfttp_work")]
            public static extern int CtfttpWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr arf, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctfttr")]
            public static extern int Ctfttr(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr arf, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctfttr_work")]
            public static extern int CtfttrWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr arf, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgevc")]
            public static extern int Ctgevc(MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, IntPtr s, int lds, IntPtr p, int ldp, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgevc_work")]
            public static extern int CtgevcWork(MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, IntPtr s, int lds, IntPtr p, int ldp, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgexc")]
            public static extern int Ctgexc(MatrixLayout matrixLayout, int wantq, int wantz, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgexc_work")]
            public static extern int CtgexcWork(MatrixLayout matrixLayout, int wantq, int wantz, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgsen")]
            public static extern int Ctgsen(MatrixLayout matrixLayout, int ijob, int wantq, int wantz, int* select, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr q, int ldq, IntPtr z, int ldz, int* m, float* pl, float* pr, float* dif);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgsen_work")]
            public static extern int CtgsenWork(MatrixLayout matrixLayout, int ijob, int wantq, int wantz, int* select, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr q, int ldq, IntPtr z, int ldz, int* m, float* pl, float* pr, float* dif, IntPtr work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgsja")]
            public static extern int Ctgsja(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, IntPtr a, int lda, IntPtr b, int ldb, float tola, float tolb, float* alpha, float* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, int* ncycle);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgsja_work")]
            public static extern int CtgsjaWork(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, IntPtr a, int lda, IntPtr b, int ldb, float tola, float tolb, float* alpha, float* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, IntPtr work, int* ncycle);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgsna")]
            public static extern int Ctgsna(MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr vl, int ldvl, IntPtr vr, int ldvr, float* s, float* dif, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgsna_work")]
            public static extern int CtgsnaWork(MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr vl, int ldvl, IntPtr vr, int ldvr, float* s, float* dif, int mm, int* m, IntPtr work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgsyl")]
            public static extern int Ctgsyl(MatrixLayout matrixLayout, TransLapack trans, int ijob, int m, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, int ldc, IntPtr d, int ldd, IntPtr e, int lde, IntPtr f, int ldf, float* scale, float* dif);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgsyl_work")]
            public static extern int CtgsylWork(MatrixLayout matrixLayout, TransLapack trans, int ijob, int m, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, int ldc, IntPtr d, int ldd, IntPtr e, int lde, IntPtr f, int ldf, float* scale, float* dif, IntPtr work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpcon")]
            public static extern int Ctpcon(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, IntPtr ap, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpcon_work")]
            public static extern int CtpconWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, IntPtr ap, float* rcond, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpmqrt")]
            public static extern int Ctpmqrt(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int l, int nb, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpmqrt_work")]
            public static extern int CtpmqrtWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int l, int nb, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr a, int lda, IntPtr b, int ldb, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpqrt")]
            public static extern int Ctpqrt(MatrixLayout matrixLayout, int m, int n, int l, int nb, IntPtr a, int lda, IntPtr b, int ldb, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpqrt2")]
            public static extern int Ctpqrt2(MatrixLayout matrixLayout, int m, int n, int l, IntPtr a, int lda, IntPtr b, int ldb, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpqrt2_work")]
            public static extern int Ctpqrt2Work(MatrixLayout matrixLayout, int m, int n, int l, IntPtr a, int lda, IntPtr b, int ldb, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpqrt_work")]
            public static extern int CtpqrtWork(MatrixLayout matrixLayout, int m, int n, int l, int nb, IntPtr a, int lda, IntPtr b, int ldb, IntPtr t, int ldt, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctprfb")]
            public static extern int Ctprfb(MatrixLayout matrixLayout, sbyte side, TransLapack trans, sbyte direct, sbyte storev, int m, int n, int k, int l, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctprfb_work")]
            public static extern int CtprfbWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, sbyte direct, sbyte storev, int m, int n, int k, int l, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr a, int lda, IntPtr b, int ldb, IntPtr work, int ldwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctprfs")]
            public static extern int Ctprfs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, IntPtr ap, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctprfs_work")]
            public static extern int CtprfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, IntPtr ap, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctptri")]
            public static extern int Ctptri(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte diag, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctptri_work")]
            public static extern int CtptriWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte diag, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctptrs")]
            public static extern int Ctptrs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctptrs_work")]
            public static extern int CtptrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpttf")]
            public static extern int Ctpttf(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr ap, IntPtr arf);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpttf_work")]
            public static extern int CtpttfWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr ap, IntPtr arf);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpttr")]
            public static extern int Ctpttr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpttr_work")]
            public static extern int CtpttrWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrcon")]
            public static extern int Ctrcon(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, IntPtr a, int lda, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrcon_work")]
            public static extern int CtrconWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, IntPtr a, int lda, float* rcond, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrevc")]
            public static extern int Ctrevc(MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, IntPtr t, int ldt, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrevc_work")]
            public static extern int CtrevcWork(MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, IntPtr t, int ldt, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrexc")]
            public static extern int Ctrexc(MatrixLayout matrixLayout, sbyte compq, int n, IntPtr t, int ldt, IntPtr q, int ldq, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrexc_work")]
            public static extern int CtrexcWork(MatrixLayout matrixLayout, sbyte compq, int n, IntPtr t, int ldt, IntPtr q, int ldq, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrrfs")]
            public static extern int Ctrrfs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrrfs_work")]
            public static extern int CtrrfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrsen")]
            public static extern int Ctrsen(MatrixLayout matrixLayout, sbyte job, sbyte compq, int* select, int n, IntPtr t, int ldt, IntPtr q, int ldq, IntPtr w, int* m, float* s, float* sep);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrsen_work")]
            public static extern int CtrsenWork(MatrixLayout matrixLayout, sbyte job, sbyte compq, int* select, int n, IntPtr t, int ldt, IntPtr q, int ldq, IntPtr w, int* m, float* s, float* sep, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrsna")]
            public static extern int Ctrsna(MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, IntPtr t, int ldt, IntPtr vl, int ldvl, IntPtr vr, int ldvr, float* s, float* sep, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrsna_work")]
            public static extern int CtrsnaWork(MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, IntPtr t, int ldt, IntPtr vl, int ldvl, IntPtr vr, int ldvr, float* s, float* sep, int mm, int* m, IntPtr work, int ldwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrsyl")]
            public static extern int Ctrsyl(MatrixLayout matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, int ldc, float* scale);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrsyl_work")]
            public static extern int CtrsylWork(MatrixLayout matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, int ldc, float* scale);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrtri")]
            public static extern int Ctrtri(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte diag, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrtri_work")]
            public static extern int CtrtriWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte diag, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrtrs")]
            public static extern int Ctrtrs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrtrs_work")]
            public static extern int CtrtrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrttf")]
            public static extern int Ctrttf(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr arf);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrttf_work")]
            public static extern int CtrttfWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr arf);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrttp")]
            public static extern int Ctrttp(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrttp_work")]
            public static extern int CtrttpWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctzrzf")]
            public static extern int Ctzrzf(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctzrzf_work")]
            public static extern int CtzrzfWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunbdb")]
            public static extern int Cunbdb(MatrixLayout matrixLayout, TransLapack trans, sbyte signs, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x12, int ldx12, IntPtr x21, int ldx21, IntPtr x22, int ldx22, float* theta, float* phi, IntPtr taup1, IntPtr taup2, IntPtr tauq1, IntPtr tauq2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunbdb_work")]
            public static extern int CunbdbWork(MatrixLayout matrixLayout, TransLapack trans, sbyte signs, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x12, int ldx12, IntPtr x21, int ldx21, IntPtr x22, int ldx22, float* theta, float* phi, IntPtr taup1, IntPtr taup2, IntPtr tauq1, IntPtr tauq2, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cuncsd")]
            public static extern int Cuncsd(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, TransLapack trans, sbyte signs, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x12, int ldx12, IntPtr x21, int ldx21, IntPtr x22, int ldx22, float* theta, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t, IntPtr v2t, int ldv2t);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cuncsd2by1")]
            public static extern int Cuncsd2by1(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x21, int ldx21, float* theta, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cuncsd2by1_work")]
            public static extern int Cuncsd2by1Work(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x21, int ldx21, float* theta, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cuncsd_work")]
            public static extern int CuncsdWork(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, TransLapack trans, sbyte signs, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x12, int ldx12, IntPtr x21, int ldx21, IntPtr x22, int ldx22, float* theta, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t, IntPtr v2t, int ldv2t, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cungbr")]
            public static extern int Cungbr(MatrixLayout matrixLayout, sbyte vect, int m, int n, int k, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cungbr_work")]
            public static extern int CungbrWork(MatrixLayout matrixLayout, sbyte vect, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunghr")]
            public static extern int Cunghr(MatrixLayout matrixLayout, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunghr_work")]
            public static extern int CunghrWork(MatrixLayout matrixLayout, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunglq")]
            public static extern int Cunglq(MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunglq_work")]
            public static extern int CunglqWork(MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cungql")]
            public static extern int Cungql(MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cungql_work")]
            public static extern int CungqlWork(MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cungqr")]
            public static extern int Cungqr(MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cungqr_work")]
            public static extern int CungqrWork(MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cungrq")]
            public static extern int Cungrq(MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cungrq_work")]
            public static extern int CungrqWork(MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cungtr")]
            public static extern int Cungtr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cungtr_work")]
            public static extern int CungtrWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmbr")]
            public static extern int Cunmbr(MatrixLayout matrixLayout, sbyte vect, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmbr_work")]
            public static extern int CunmbrWork(MatrixLayout matrixLayout, sbyte vect, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmhr")]
            public static extern int Cunmhr(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmhr_work")]
            public static extern int CunmhrWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmlq")]
            public static extern int Cunmlq(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmlq_work")]
            public static extern int CunmlqWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmql")]
            public static extern int Cunmql(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmql_work")]
            public static extern int CunmqlWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmqr")]
            public static extern int Cunmqr(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmqr_work")]
            public static extern int CunmqrWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmrq")]
            public static extern int Cunmrq(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmrq_work")]
            public static extern int CunmrqWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmrz")]
            public static extern int Cunmrz(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int l, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmrz_work")]
            public static extern int CunmrzWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int l, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmtr")]
            public static extern int Cunmtr(MatrixLayout matrixLayout, sbyte side, UpLoLapack uplo, TransLapack trans, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmtr_work")]
            public static extern int CunmtrWork(MatrixLayout matrixLayout, sbyte side, UpLoLapack uplo, TransLapack trans, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cupgtr")]
            public static extern int Cupgtr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, IntPtr tau, IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cupgtr_work")]
            public static extern int CupgtrWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, IntPtr tau, IntPtr q, int ldq, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cupmtr")]
            public static extern int Cupmtr(MatrixLayout matrixLayout, sbyte side, UpLoLapack uplo, TransLapack trans, int m, int n, IntPtr ap, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cupmtr_work")]
            public static extern int CupmtrWork(MatrixLayout matrixLayout, sbyte side, UpLoLapack uplo, TransLapack trans, int m, int n, IntPtr ap, IntPtr tau, IntPtr c, int ldc, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dbbcsd")]
            public static extern int Dbbcsd(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, TransLapack trans, int m, int p, int q, double* theta, double* phi, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* v2t, int ldv2t, double* b11d, double* b11e, double* b12d, double* b12e, double* b21d, double* b21e, double* b22d, double* b22e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dbbcsd_work")]
            public static extern int DbbcsdWork(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, TransLapack trans, int m, int p, int q, double* theta, double* phi, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* v2t, int ldv2t, double* b11d, double* b11e, double* b12d, double* b12e, double* b21d, double* b21e, double* b22d, double* b22e, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dbdsdc")]
            public static extern int Dbdsdc(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte compq, int n, double* d, double* e, double* u, int ldu, double* vt, int ldvt, double* q, int* iq);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dbdsdc_work")]
            public static extern int DbdsdcWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte compq, int n, double* d, double* e, double* u, int ldu, double* vt, int ldvt, double* q, int* iq, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dbdsqr")]
            public static extern int Dbdsqr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int ncvt, int nru, int ncc, double* d, double* e, double* vt, int ldvt, double* u, int ldu, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dbdsqr_work")]
            public static extern int DbdsqrWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int ncvt, int nru, int ncc, double* d, double* e, double* vt, int ldvt, double* u, int ldu, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dbdsvdx")]
            public static extern int Dbdsvdx(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* ns, double* s, double* z, int ldz, int* superb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dbdsvdx_work")]
            public static extern int DbdsvdxWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* ns, double* s, double* z, int ldz, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ddisna")]
            public static extern int Ddisna(sbyte job, int m, int n, double* d, double* sep);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ddisna_work")]
            public static extern int DdisnaWork(sbyte job, int m, int n, double* d, double* sep);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbbrd")]
            public static extern int Dgbbrd(MatrixLayout matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, double* ab, int ldab, double* d, double* e, double* q, int ldq, double* pt, int ldpt, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbbrd_work")]
            public static extern int DgbbrdWork(MatrixLayout matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, double* ab, int ldab, double* d, double* e, double* q, int ldq, double* pt, int ldpt, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbcon")]
            public static extern int Dgbcon(MatrixLayout matrixLayout, sbyte norm, int n, int kl, int ku, double* ab, int ldab, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbcon_work")]
            public static extern int DgbconWork(MatrixLayout matrixLayout, sbyte norm, int n, int kl, int ku, double* ab, int ldab, int* ipiv, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbequ")]
            public static extern int Dgbequ(MatrixLayout matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbequ_work")]
            public static extern int DgbequWork(MatrixLayout matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbequb")]
            public static extern int Dgbequb(MatrixLayout matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbequb_work")]
            public static extern int DgbequbWork(MatrixLayout matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbrfs")]
            public static extern int Dgbrfs(MatrixLayout matrixLayout, TransLapack trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbrfs_work")]
            public static extern int DgbrfsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbrfsx")]
            public static extern int Dgbrfsx(MatrixLayout matrixLayout, TransLapack trans, sbyte equed, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbrfsx_work")]
            public static extern int DgbrfsxWork(MatrixLayout matrixLayout, TransLapack trans, sbyte equed, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbsv")]
            public static extern int Dgbsv(MatrixLayout matrixLayout, int n, int kl, int ku, int nrhs, double* ab, int ldab, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbsv_work")]
            public static extern int DgbsvWork(MatrixLayout matrixLayout, int n, int kl, int ku, int nrhs, double* ab, int ldab, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbsvx")]
            public static extern int Dgbsvx(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* rpivot);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbsvx_work")]
            public static extern int DgbsvxWork(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbsvxx")]
            public static extern int Dgbsvxx(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbsvxx_work")]
            public static extern int DgbsvxxWork(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbtrf")]
            public static extern int Dgbtrf(MatrixLayout matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbtrf_work")]
            public static extern int DgbtrfWork(MatrixLayout matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbtrs")]
            public static extern int Dgbtrs(MatrixLayout matrixLayout, TransLapack trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbtrs_work")]
            public static extern int DgbtrsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgebak")]
            public static extern int Dgebak(MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* scale, int m, double* v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgebak_work")]
            public static extern int DgebakWork(MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* scale, int m, double* v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgebal")]
            public static extern int Dgebal(MatrixLayout matrixLayout, sbyte job, int n, double* a, int lda, int* ilo, int* ihi, double* scale);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgebal_work")]
            public static extern int DgebalWork(MatrixLayout matrixLayout, sbyte job, int n, double* a, int lda, int* ilo, int* ihi, double* scale);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgebrd")]
            public static extern int Dgebrd(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* d, double* e, double* tauq, double* taup);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgebrd_work")]
            public static extern int DgebrdWork(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* d, double* e, double* tauq, double* taup, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgecon")]
            public static extern int Dgecon(MatrixLayout matrixLayout, sbyte norm, int n, double* a, int lda, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgecon_work")]
            public static extern int DgeconWork(MatrixLayout matrixLayout, sbyte norm, int n, double* a, int lda, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeequ")]
            public static extern int Dgeequ(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeequ_work")]
            public static extern int DgeequWork(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeequb")]
            public static extern int Dgeequb(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeequb_work")]
            public static extern int DgeequbWork(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgees")]
            public static extern int Dgees(MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, int n, double* a, int lda, int* sdim, double* wr, double* wi, double* vs, int ldvs);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgees_work")]
            public static extern int DgeesWork(MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, int n, double* a, int lda, int* sdim, double* wr, double* wi, double* vs, int ldvs, double* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeesx")]
            public static extern int Dgeesx(MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, sbyte sense, int n, double* a, int lda, int* sdim, double* wr, double* wi, double* vs, int ldvs, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeesx_work")]
            public static extern int DgeesxWork(MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, sbyte sense, int n, double* a, int lda, int* sdim, double* wr, double* wi, double* vs, int ldvs, double* rconde, double* rcondv, double* work, int lwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeev")]
            public static extern int Dgeev(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* wr, double* wi, double* vl, int ldvl, double* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeev_work")]
            public static extern int DgeevWork(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* wr, double* wi, double* vl, int ldvl, double* vr, int ldvr, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeevx")]
            public static extern int Dgeevx(MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, double* a, int lda, double* wr, double* wi, double* vl, int ldvl, double* vr, int ldvr, int* ilo, int* ihi, double* scale, double* abnrm, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeevx_work")]
            public static extern int DgeevxWork(MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, double* a, int lda, double* wr, double* wi, double* vl, int ldvl, double* vr, int ldvr, int* ilo, int* ihi, double* scale, double* abnrm, double* rconde, double* rcondv, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgehrd")]
            public static extern int Dgehrd(MatrixLayout matrixLayout, int n, int ilo, int ihi, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgehrd_work")]
            public static extern int DgehrdWork(MatrixLayout matrixLayout, int n, int ilo, int ihi, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgejsv")]
            public static extern int Dgejsv(MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, double* a, int lda, double* sva, double* u, int ldu, double* v, int ldv, double* stat, int* istat);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgejsv_work")]
            public static extern int DgejsvWork(MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, double* a, int lda, double* sva, double* u, int ldu, double* v, int ldv, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelq2")]
            public static extern int Dgelq2(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelq2_work")]
            public static extern int Dgelq2Work(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelqf")]
            public static extern int Dgelqf(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelqf_work")]
            public static extern int DgelqfWork(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgels")]
            public static extern int Dgels(MatrixLayout matrixLayout, TransLapack trans, int m, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgels_work")]
            public static extern int DgelsWork(MatrixLayout matrixLayout, TransLapack trans, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelsd")]
            public static extern int Dgelsd(MatrixLayout matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* s, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelsd_work")]
            public static extern int DgelsdWork(MatrixLayout matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* s, double rcond, int* rank, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelss")]
            public static extern int Dgelss(MatrixLayout matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* s, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelss_work")]
            public static extern int DgelssWork(MatrixLayout matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* s, double rcond, int* rank, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelsy")]
            public static extern int Dgelsy(MatrixLayout matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, int* jpvt, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelsy_work")]
            public static extern int DgelsyWork(MatrixLayout matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, int* jpvt, double rcond, int* rank, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgemqrt")]
            public static extern int Dgemqrt(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int nb, double* v, int ldv, double* t, int ldt, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgemqrt_work")]
            public static extern int DgemqrtWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int nb, double* v, int ldv, double* t, int ldt, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqlf")]
            public static extern int Dgeqlf(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqlf_work")]
            public static extern int DgeqlfWork(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqp3")]
            public static extern int Dgeqp3(MatrixLayout matrixLayout, int m, int n, double* a, int lda, int* jpvt, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqp3_work")]
            public static extern int Dgeqp3Work(MatrixLayout matrixLayout, int m, int n, double* a, int lda, int* jpvt, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqpf")]
            public static extern int Dgeqpf(MatrixLayout matrixLayout, int m, int n, double* a, int lda, int* jpvt, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqpf_work")]
            public static extern int DgeqpfWork(MatrixLayout matrixLayout, int m, int n, double* a, int lda, int* jpvt, double* tau, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqr2")]
            public static extern int Dgeqr2(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqr2_work")]
            public static extern int Dgeqr2Work(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqrf")]
            public static extern int Dgeqrf(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqrf_work")]
            public static extern int DgeqrfWork(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqrfp")]
            public static extern int Dgeqrfp(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqrfp_work")]
            public static extern int DgeqrfpWork(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqrt")]
            public static extern int Dgeqrt(MatrixLayout matrixLayout, int m, int n, int nb, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqrt2")]
            public static extern int Dgeqrt2(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqrt2_work")]
            public static extern int Dgeqrt2Work(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqrt3")]
            public static extern int Dgeqrt3(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqrt3_work")]
            public static extern int Dgeqrt3Work(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqrt_work")]
            public static extern int DgeqrtWork(MatrixLayout matrixLayout, int m, int n, int nb, double* a, int lda, double* t, int ldt, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgerfs")]
            public static extern int Dgerfs(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgerfs_work")]
            public static extern int DgerfsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgerfsx")]
            public static extern int Dgerfsx(MatrixLayout matrixLayout, TransLapack trans, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgerfsx_work")]
            public static extern int DgerfsxWork(MatrixLayout matrixLayout, TransLapack trans, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgerqf")]
            public static extern int Dgerqf(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgerqf_work")]
            public static extern int DgerqfWork(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesdd")]
            public static extern int Dgesdd(MatrixLayout matrixLayout, sbyte jobz, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* vt, int ldvt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesdd_work")]
            public static extern int DgesddWork(MatrixLayout matrixLayout, sbyte jobz, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* vt, int ldvt, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesv")]
            public static extern int Dgesv(MatrixLayout matrixLayout, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesv_work")]
            public static extern int DgesvWork(MatrixLayout matrixLayout, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvd")]
            public static extern int Dgesvd(MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* vt, int ldvt, double* superb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvd_work")]
            public static extern int DgesvdWork(MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* vt, int ldvt, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvdx")]
            public static extern int Dgesvdx(MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, double* a, int lda, double vl, double vu, int il, int iu, int* ns, double* s, double* u, int ldu, double* vt, int ldvt, int* superb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvdx_work")]
            public static extern int DgesvdxWork(MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, double* a, int lda, double vl, double vu, int il, int iu, int* ns, double* s, double* u, int ldu, double* vt, int ldvt, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvj")]
            public static extern int Dgesvj(MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, double* a, int lda, double* sva, int mv, double* v, int ldv, double* stat);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvj_work")]
            public static extern int DgesvjWork(MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, double* a, int lda, double* sva, int mv, double* v, int ldv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvx")]
            public static extern int Dgesvx(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* rpivot);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvx_work")]
            public static extern int DgesvxWork(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvxx")]
            public static extern int Dgesvxx(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvxx_work")]
            public static extern int DgesvxxWork(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetf2")]
            public static extern int Dgetf2(MatrixLayout matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetf2_work")]
            public static extern int Dgetf2Work(MatrixLayout matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetrf")]
            public static extern int Dgetrf(MatrixLayout matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetrf2")]
            public static extern int Dgetrf2(MatrixLayout matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetrf2_work")]
            public static extern int Dgetrf2Work(MatrixLayout matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetrf_work")]
            public static extern int DgetrfWork(MatrixLayout matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetri")]
            public static extern int Dgetri(MatrixLayout matrixLayout, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetri_work")]
            public static extern int DgetriWork(MatrixLayout matrixLayout, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetrs")]
            public static extern int Dgetrs(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetrs_work")]
            public static extern int DgetrsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggbak")]
            public static extern int Dggbak(MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* lscale, double* rscale, int m, double* v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggbak_work")]
            public static extern int DggbakWork(MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* lscale, double* rscale, int m, double* v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggbal")]
            public static extern int Dggbal(MatrixLayout matrixLayout, sbyte job, int n, double* a, int lda, double* b, int ldb, int* ilo, int* ihi, double* lscale, double* rscale);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggbal_work")]
            public static extern int DggbalWork(MatrixLayout matrixLayout, sbyte job, int n, double* a, int lda, double* b, int ldb, int* ilo, int* ihi, double* lscale, double* rscale, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgges")]
            public static extern int Dgges(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, double* a, int lda, double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgges3")]
            public static extern int Dgges3(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, double* a, int lda, double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgges3_work")]
            public static extern int Dgges3Work(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, double* a, int lda, double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr, double* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgges_work")]
            public static extern int DggesWork(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, double* a, int lda, double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr, double* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggesx")]
            public static extern int Dggesx(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, sbyte sense, int n, double* a, int lda, double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggesx_work")]
            public static extern int DggesxWork(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, sbyte sense, int n, double* a, int lda, double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr, double* rconde, double* rcondv, double* work, int lwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggev")]
            public static extern int Dggev(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggev3")]
            public static extern int Dggev3(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggev3_work")]
            public static extern int Dggev3Work(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggev_work")]
            public static extern int DggevWork(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggevx")]
            public static extern int Dggevx(MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr, int* ilo, int* ihi, double* lscale, double* rscale, double* abnrm, double* bbnrm, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggevx_work")]
            public static extern int DggevxWork(MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr, int* ilo, int* ihi, double* lscale, double* rscale, double* abnrm, double* bbnrm, double* rconde, double* rcondv, double* work, int lwork, int* iwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggglm")]
            public static extern int Dggglm(MatrixLayout matrixLayout, int n, int m, int p, double* a, int lda, double* b, int ldb, double* d, double* x, double* y);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggglm_work")]
            public static extern int DggglmWork(MatrixLayout matrixLayout, int n, int m, int p, double* a, int lda, double* b, int ldb, double* d, double* x, double* y, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgghd3")]
            public static extern int Dgghd3(MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgghd3_work")]
            public static extern int Dgghd3Work(MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z, int ldz, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgghrd")]
            public static extern int Dgghrd(MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgghrd_work")]
            public static extern int DgghrdWork(MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgglse")]
            public static extern int Dgglse(MatrixLayout matrixLayout, int m, int n, int p, double* a, int lda, double* b, int ldb, double* c, double* d, double* x);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgglse_work")]
            public static extern int DgglseWork(MatrixLayout matrixLayout, int m, int n, int p, double* a, int lda, double* b, int ldb, double* c, double* d, double* x, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggqrf")]
            public static extern int Dggqrf(MatrixLayout matrixLayout, int n, int m, int p, double* a, int lda, double* taua, double* b, int ldb, double* taub);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggqrf_work")]
            public static extern int DggqrfWork(MatrixLayout matrixLayout, int n, int m, int p, double* a, int lda, double* taua, double* b, int ldb, double* taub, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggrqf")]
            public static extern int Dggrqf(MatrixLayout matrixLayout, int m, int p, int n, double* a, int lda, double* taua, double* b, int ldb, double* taub);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggrqf_work")]
            public static extern int DggrqfWork(MatrixLayout matrixLayout, int m, int p, int n, double* a, int lda, double* taua, double* b, int ldb, double* taub, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggsvd")]
            public static extern int Dggsvd(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, double* a, int lda, double* b, int ldb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggsvd3")]
            public static extern int Dggsvd3(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, double* a, int lda, double* b, int ldb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggsvd3_work")]
            public static extern int Dggsvd3Work(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, double* a, int lda, double* b, int ldb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggsvd_work")]
            public static extern int DggsvdWork(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, double* a, int lda, double* b, int ldb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggsvp")]
            public static extern int Dggsvp(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, double* a, int lda, double* b, int ldb, double tola, double tolb, int* k, int* l, double* u, int ldu, double* v, int ldv, double* q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggsvp3")]
            public static extern int Dggsvp3(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, double* a, int lda, double* b, int ldb, double tola, double tolb, int* k, int* l, double* u, int ldu, double* v, int ldv, double* q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggsvp3_work")]
            public static extern int Dggsvp3Work(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, double* a, int lda, double* b, int ldb, double tola, double tolb, int* k, int* l, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* iwork, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggsvp_work")]
            public static extern int DggsvpWork(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, double* a, int lda, double* b, int ldb, double tola, double tolb, int* k, int* l, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* iwork, double* tau, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgtcon")]
            public static extern int Dgtcon(sbyte norm, int n, double* dl, double* d, double* du, double* du2, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgtcon_work")]
            public static extern int DgtconWork(sbyte norm, int n, double* dl, double* d, double* du, double* du2, int* ipiv, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgtrfs")]
            public static extern int Dgtrfs(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, double* dl, double* d, double* du, double* dlf, double* df, double* duf, double* du2, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgtrfs_work")]
            public static extern int DgtrfsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, double* dl, double* d, double* du, double* dlf, double* df, double* duf, double* du2, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgtsv")]
            public static extern int Dgtsv(MatrixLayout matrixLayout, int n, int nrhs, double* dl, double* d, double* du, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgtsv_work")]
            public static extern int DgtsvWork(MatrixLayout matrixLayout, int n, int nrhs, double* dl, double* d, double* du, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgtsvx")]
            public static extern int Dgtsvx(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, double* dl, double* d, double* du, double* dlf, double* df, double* duf, double* du2, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgtsvx_work")]
            public static extern int DgtsvxWork(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, double* dl, double* d, double* du, double* dlf, double* df, double* duf, double* du2, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgttrf")]
            public static extern int Dgttrf(int n, double* dl, double* d, double* du, double* du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgttrf_work")]
            public static extern int DgttrfWork(int n, double* dl, double* d, double* du, double* du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgttrs")]
            public static extern int Dgttrs(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, double* dl, double* d, double* du, double* du2, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgttrs_work")]
            public static extern int DgttrsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, double* dl, double* d, double* du, double* du2, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dhgeqz")]
            public static extern int Dhgeqz(MatrixLayout matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* h, int ldh, double* t, int ldt, double* alphar, double* alphai, double* beta, double* q, int ldq, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dhgeqz_work")]
            public static extern int DhgeqzWork(MatrixLayout matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* h, int ldh, double* t, int ldt, double* alphar, double* alphai, double* beta, double* q, int ldq, double* z, int ldz, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dhsein")]
            public static extern int Dhsein(MatrixLayout matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, double* h, int ldh, double* wr, double* wi, double* vl, int ldvl, double* vr, int ldvr, int mm, int* m, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dhsein_work")]
            public static extern int DhseinWork(MatrixLayout matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, double* h, int ldh, double* wr, double* wi, double* vl, int ldvl, double* vr, int ldvr, int mm, int* m, double* work, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dhseqr")]
            public static extern int Dhseqr(MatrixLayout matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, double* h, int ldh, double* wr, double* wi, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dhseqr_work")]
            public static extern int DhseqrWork(MatrixLayout matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, double* h, int ldh, double* wr, double* wi, double* z, int ldz, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlacn2")]
            public static extern int Dlacn2(int n, double* v, double* x, int* isgn, double* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlacn2_work")]
            public static extern int Dlacn2Work(int n, double* v, double* x, int* isgn, double* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlacpy")]
            public static extern int Dlacpy(MatrixLayout matrixLayout, UpLoLapack uplo, int m, int n, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlacpy_work")]
            public static extern int DlacpyWork(MatrixLayout matrixLayout, UpLoLapack uplo, int m, int n, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlag2s")]
            public static extern int Dlag2s(MatrixLayout matrixLayout, int m, int n, double* a, int lda, float* sa, int ldsa);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlag2s_work")]
            public static extern int Dlag2sWork(MatrixLayout matrixLayout, int m, int n, double* a, int lda, float* sa, int ldsa);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlagge")]
            public static extern int Dlagge(MatrixLayout matrixLayout, int m, int n, int kl, int ku, double* d, double* a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlagge_work")]
            public static extern int DlaggeWork(MatrixLayout matrixLayout, int m, int n, int kl, int ku, double* d, double* a, int lda, int* iseed, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlagsy")]
            public static extern int Dlagsy(MatrixLayout matrixLayout, int n, int k, double* d, double* a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlagsy_work")]
            public static extern int DlagsyWork(MatrixLayout matrixLayout, int n, int k, double* d, double* a, int lda, int* iseed, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlapmr")]
            public static extern int Dlapmr(MatrixLayout matrixLayout, int forwrd, int m, int n, double* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlapmr_work")]
            public static extern int DlapmrWork(MatrixLayout matrixLayout, int forwrd, int m, int n, double* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlapmt")]
            public static extern int Dlapmt(MatrixLayout matrixLayout, int forwrd, int m, int n, double* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlapmt_work")]
            public static extern int DlapmtWork(MatrixLayout matrixLayout, int forwrd, int m, int n, double* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlarfb")]
            public static extern int Dlarfb(MatrixLayout matrixLayout, sbyte side, TransLapack trans, sbyte direct, sbyte storev, int m, int n, int k, double* v, int ldv, double* t, int ldt, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlarfb_work")]
            public static extern int DlarfbWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, sbyte direct, sbyte storev, int m, int n, int k, double* v, int ldv, double* t, int ldt, double* c, int ldc, double* work, int ldwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlarfg")]
            public static extern int Dlarfg(int n, double* alpha, double* x, int incx, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlarfg_work")]
            public static extern int DlarfgWork(int n, double* alpha, double* x, int incx, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlarft")]
            public static extern int Dlarft(MatrixLayout matrixLayout, sbyte direct, sbyte storev, int n, int k, double* v, int ldv, double* tau, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlarft_work")]
            public static extern int DlarftWork(MatrixLayout matrixLayout, sbyte direct, sbyte storev, int n, int k, double* v, int ldv, double* tau, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlarfx")]
            public static extern int Dlarfx(MatrixLayout matrixLayout, sbyte side, int m, int n, double* v, double tau, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlarfx_work")]
            public static extern int DlarfxWork(MatrixLayout matrixLayout, sbyte side, int m, int n, double* v, double tau, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlarnv")]
            public static extern int Dlarnv(int idist, int* iseed, int n, double* x);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlarnv_work")]
            public static extern int DlarnvWork(int idist, int* iseed, int n, double* x);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlartgp")]
            public static extern int Dlartgp(double f, double g, double* cs, double* sn, double* r);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlartgp_work")]
            public static extern int DlartgpWork(double f, double g, double* cs, double* sn, double* r);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlartgs")]
            public static extern int Dlartgs(double x, double y, double sigma, double* cs, double* sn);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlartgs_work")]
            public static extern int DlartgsWork(double x, double y, double sigma, double* cs, double* sn);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlascl")]
            public static extern int Dlascl(MatrixLayout matrixLayout, sbyte type, int kl, int ku, double cfrom, double cto, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlascl_work")]
            public static extern int DlasclWork(MatrixLayout matrixLayout, sbyte type, int kl, int ku, double cfrom, double cto, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlaset")]
            public static extern int Dlaset(MatrixLayout matrixLayout, UpLoLapack uplo, int m, int n, double alpha, double beta, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlaset_work")]
            public static extern int DlasetWork(MatrixLayout matrixLayout, UpLoLapack uplo, int m, int n, double alpha, double beta, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlasrt")]
            public static extern int Dlasrt(sbyte id, int n, double* d);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlasrt_work")]
            public static extern int DlasrtWork(sbyte id, int n, double* d);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlaswp")]
            public static extern int Dlaswp(MatrixLayout matrixLayout, int n, double* a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlaswp_work")]
            public static extern int DlaswpWork(MatrixLayout matrixLayout, int n, double* a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlatms")]
            public static extern int Dlatms(MatrixLayout matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, double* d, int mode, double cond, double dmax, int kl, int ku, sbyte pack, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlatms_work")]
            public static extern int DlatmsWork(MatrixLayout matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, double* d, int mode, double cond, double dmax, int kl, int ku, sbyte pack, double* a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlauum")]
            public static extern int Dlauum(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlauum_work")]
            public static extern int DlauumWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dopgtr")]
            public static extern int Dopgtr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* ap, double* tau, double* q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dopgtr_work")]
            public static extern int DopgtrWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* ap, double* tau, double* q, int ldq, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dopmtr")]
            public static extern int Dopmtr(MatrixLayout matrixLayout, sbyte side, UpLoLapack uplo, TransLapack trans, int m, int n, double* ap, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dopmtr_work")]
            public static extern int DopmtrWork(MatrixLayout matrixLayout, sbyte side, UpLoLapack uplo, TransLapack trans, int m, int n, double* ap, double* tau, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorbdb")]
            public static extern int Dorbdb(MatrixLayout matrixLayout, TransLapack trans, sbyte signs, int m, int p, int q, double* x11, int ldx11, double* x12, int ldx12, double* x21, int ldx21, double* x22, int ldx22, double* theta, double* phi, double* taup1, double* taup2, double* tauq1, double* tauq2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorbdb_work")]
            public static extern int DorbdbWork(MatrixLayout matrixLayout, TransLapack trans, sbyte signs, int m, int p, int q, double* x11, int ldx11, double* x12, int ldx12, double* x21, int ldx21, double* x22, int ldx22, double* theta, double* phi, double* taup1, double* taup2, double* tauq1, double* tauq2, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorcsd")]
            public static extern int Dorcsd(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, TransLapack trans, sbyte signs, int m, int p, int q, double* x11, int ldx11, double* x12, int ldx12, double* x21, int ldx21, double* x22, int ldx22, double* theta, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* v2t, int ldv2t);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorcsd2by1")]
            public static extern int Dorcsd2by1(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, double* x11, int ldx11, double* x21, int ldx21, double* theta, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorcsd2by1_work")]
            public static extern int Dorcsd2by1Work(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, double* x11, int ldx11, double* x21, int ldx21, double* theta, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorcsd_work")]
            public static extern int DorcsdWork(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, TransLapack trans, sbyte signs, int m, int p, int q, double* x11, int ldx11, double* x12, int ldx12, double* x21, int ldx21, double* x22, int ldx22, double* theta, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* v2t, int ldv2t, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorgbr")]
            public static extern int Dorgbr(MatrixLayout matrixLayout, sbyte vect, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorgbr_work")]
            public static extern int DorgbrWork(MatrixLayout matrixLayout, sbyte vect, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorghr")]
            public static extern int Dorghr(MatrixLayout matrixLayout, int n, int ilo, int ihi, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorghr_work")]
            public static extern int DorghrWork(MatrixLayout matrixLayout, int n, int ilo, int ihi, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorglq")]
            public static extern int Dorglq(MatrixLayout matrixLayout, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorglq_work")]
            public static extern int DorglqWork(MatrixLayout matrixLayout, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorgql")]
            public static extern int Dorgql(MatrixLayout matrixLayout, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorgql_work")]
            public static extern int DorgqlWork(MatrixLayout matrixLayout, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorgqr")]
            public static extern int Dorgqr(MatrixLayout matrixLayout, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorgqr_work")]
            public static extern int DorgqrWork(MatrixLayout matrixLayout, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorgrq")]
            public static extern int Dorgrq(MatrixLayout matrixLayout, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorgrq_work")]
            public static extern int DorgrqWork(MatrixLayout matrixLayout, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorgtr")]
            public static extern int Dorgtr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorgtr_work")]
            public static extern int DorgtrWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormbr")]
            public static extern int Dormbr(MatrixLayout matrixLayout, sbyte vect, sbyte side, TransLapack trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormbr_work")]
            public static extern int DormbrWork(MatrixLayout matrixLayout, sbyte vect, sbyte side, TransLapack trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormhr")]
            public static extern int Dormhr(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int ilo, int ihi, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormhr_work")]
            public static extern int DormhrWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int ilo, int ihi, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormlq")]
            public static extern int Dormlq(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormlq_work")]
            public static extern int DormlqWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormql")]
            public static extern int Dormql(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormql_work")]
            public static extern int DormqlWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormqr")]
            public static extern int Dormqr(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormqr_work")]
            public static extern int DormqrWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormrq")]
            public static extern int Dormrq(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormrq_work")]
            public static extern int DormrqWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormrz")]
            public static extern int Dormrz(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int l, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormrz_work")]
            public static extern int DormrzWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int l, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormtr")]
            public static extern int Dormtr(MatrixLayout matrixLayout, sbyte side, UpLoLapack uplo, TransLapack trans, int m, int n, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormtr_work")]
            public static extern int DormtrWork(MatrixLayout matrixLayout, sbyte side, UpLoLapack uplo, TransLapack trans, int m, int n, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbcon")]
            public static extern int Dpbcon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, double* ab, int ldab, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbcon_work")]
            public static extern int DpbconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, double* ab, int ldab, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbequ")]
            public static extern int Dpbequ(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, double* ab, int ldab, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbequ_work")]
            public static extern int DpbequWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, double* ab, int ldab, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbrfs")]
            public static extern int Dpbrfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, double* ab, int ldab, double* afb, int ldafb, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbrfs_work")]
            public static extern int DpbrfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, double* ab, int ldab, double* afb, int ldafb, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbstf")]
            public static extern int Dpbstf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kb, double* bb, int ldbb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbstf_work")]
            public static extern int DpbstfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kb, double* bb, int ldbb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbsv")]
            public static extern int Dpbsv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbsv_work")]
            public static extern int DpbsvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbsvx")]
            public static extern int Dpbsvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int kd, int nrhs, double* ab, int ldab, double* afb, int ldafb, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbsvx_work")]
            public static extern int DpbsvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int kd, int nrhs, double* ab, int ldab, double* afb, int ldafb, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbtrf")]
            public static extern int Dpbtrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, double* ab, int ldab);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbtrf_work")]
            public static extern int DpbtrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, double* ab, int ldab);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbtrs")]
            public static extern int Dpbtrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbtrs_work")]
            public static extern int DpbtrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpftrf")]
            public static extern int Dpftrf(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, double* a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpftrf_work")]
            public static extern int DpftrfWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, double* a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpftri")]
            public static extern int Dpftri(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, double* a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpftri_work")]
            public static extern int DpftriWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, double* a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpftrs")]
            public static extern int Dpftrs(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, int nrhs, double* a, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpftrs_work")]
            public static extern int DpftrsWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, int nrhs, double* a, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpocon")]
            public static extern int Dpocon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpocon_work")]
            public static extern int DpoconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpoequ")]
            public static extern int Dpoequ(MatrixLayout matrixLayout, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpoequ_work")]
            public static extern int DpoequWork(MatrixLayout matrixLayout, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpoequb")]
            public static extern int Dpoequb(MatrixLayout matrixLayout, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpoequb_work")]
            public static extern int DpoequbWork(MatrixLayout matrixLayout, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dporfs")]
            public static extern int Dporfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dporfs_work")]
            public static extern int DporfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dporfsx")]
            public static extern int Dporfsx(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dporfsx_work")]
            public static extern int DporfsxWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dposv")]
            public static extern int Dposv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dposv_work")]
            public static extern int DposvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dposvx")]
            public static extern int Dposvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dposvx_work")]
            public static extern int DposvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dposvxx")]
            public static extern int Dposvxx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dposvxx_work")]
            public static extern int DposvxxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpotrf")]
            public static extern int Dpotrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpotrf2")]
            public static extern int Dpotrf2(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpotrf2_work")]
            public static extern int Dpotrf2Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpotrf_work")]
            public static extern int DpotrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpotri")]
            public static extern int Dpotri(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpotri_work")]
            public static extern int DpotriWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpotrs")]
            public static extern int Dpotrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpotrs_work")]
            public static extern int DpotrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dppcon")]
            public static extern int Dppcon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* ap, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dppcon_work")]
            public static extern int DppconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* ap, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dppequ")]
            public static extern int Dppequ(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* ap, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dppequ_work")]
            public static extern int DppequWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* ap, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpprfs")]
            public static extern int Dpprfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* ap, double* afp, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpprfs_work")]
            public static extern int DpprfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* ap, double* afp, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dppsv")]
            public static extern int Dppsv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dppsv_work")]
            public static extern int DppsvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dppsvx")]
            public static extern int Dppsvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, double* ap, double* afp, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dppsvx_work")]
            public static extern int DppsvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, double* ap, double* afp, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpptrf")]
            public static extern int Dpptrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpptrf_work")]
            public static extern int DpptrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpptri")]
            public static extern int Dpptri(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpptri_work")]
            public static extern int DpptriWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpptrs")]
            public static extern int Dpptrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpptrs_work")]
            public static extern int DpptrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpstrf")]
            public static extern int Dpstrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, int* piv, int* rank, double tol);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpstrf_work")]
            public static extern int DpstrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, int* piv, int* rank, double tol, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dptcon")]
            public static extern int Dptcon(int n, double* d, double* e, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dptcon_work")]
            public static extern int DptconWork(int n, double* d, double* e, double anorm, double* rcond, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpteqr")]
            public static extern int Dpteqr(MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpteqr_work")]
            public static extern int DpteqrWork(MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dptrfs")]
            public static extern int Dptrfs(MatrixLayout matrixLayout, int n, int nrhs, double* d, double* e, double* df, double* ef, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dptrfs_work")]
            public static extern int DptrfsWork(MatrixLayout matrixLayout, int n, int nrhs, double* d, double* e, double* df, double* ef, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dptsv")]
            public static extern int Dptsv(MatrixLayout matrixLayout, int n, int nrhs, double* d, double* e, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dptsv_work")]
            public static extern int DptsvWork(MatrixLayout matrixLayout, int n, int nrhs, double* d, double* e, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dptsvx")]
            public static extern int Dptsvx(MatrixLayout matrixLayout, sbyte fact, int n, int nrhs, double* d, double* e, double* df, double* ef, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dptsvx_work")]
            public static extern int DptsvxWork(MatrixLayout matrixLayout, sbyte fact, int n, int nrhs, double* d, double* e, double* df, double* ef, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpttrf")]
            public static extern int Dpttrf(int n, double* d, double* e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpttrf_work")]
            public static extern int DpttrfWork(int n, double* d, double* e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpttrs")]
            public static extern int Dpttrs(MatrixLayout matrixLayout, int n, int nrhs, double* d, double* e, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpttrs_work")]
            public static extern int DpttrsWork(MatrixLayout matrixLayout, int n, int nrhs, double* d, double* e, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbev")]
            public static extern int Dsbev(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbev_work")]
            public static extern int DsbevWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbevd")]
            public static extern int Dsbevd(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbevd_work")]
            public static extern int DsbevdWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbevx")]
            public static extern int Dsbevx(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int kd, double* ab, int ldab, double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbevx_work")]
            public static extern int DsbevxWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int kd, double* ab, int ldab, double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbgst")]
            public static extern int Dsbgst(MatrixLayout matrixLayout, sbyte vect, UpLoLapack uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* x, int ldx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbgst_work")]
            public static extern int DsbgstWork(MatrixLayout matrixLayout, sbyte vect, UpLoLapack uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* x, int ldx, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbgv")]
            public static extern int Dsbgv(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbgv_work")]
            public static extern int DsbgvWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* w, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbgvd")]
            public static extern int Dsbgvd(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbgvd_work")]
            public static extern int DsbgvdWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbgvx")]
            public static extern int Dsbgvx(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbgvx_work")]
            public static extern int DsbgvxWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbtrd")]
            public static extern int Dsbtrd(MatrixLayout matrixLayout, sbyte vect, UpLoLapack uplo, int n, int kd, double* ab, int ldab, double* d, double* e, double* q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbtrd_work")]
            public static extern int DsbtrdWork(MatrixLayout matrixLayout, sbyte vect, UpLoLapack uplo, int n, int kd, double* ab, int ldab, double* d, double* e, double* q, int ldq, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsfrk")]
            public static extern int Dsfrk(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, TransLapack trans, int n, int k, double alpha, double* a, int lda, double beta, double* c);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsfrk_work")]
            public static extern int DsfrkWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, TransLapack trans, int n, int k, double alpha, double* a, int lda, double beta, double* c);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsgesv")]
            public static extern int Dsgesv(MatrixLayout matrixLayout, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* x, int ldx, int* iter);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsgesv_work")]
            public static extern int DsgesvWork(MatrixLayout matrixLayout, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* x, int ldx, double* work, float* swork, int* iter);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspcon")]
            public static extern int Dspcon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* ap, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspcon_work")]
            public static extern int DspconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* ap, int* ipiv, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspev")]
            public static extern int Dspev(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, double* ap, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspev_work")]
            public static extern int DspevWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, double* ap, double* w, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspevd")]
            public static extern int Dspevd(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, double* ap, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspevd_work")]
            public static extern int DspevdWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, double* ap, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspevx")]
            public static extern int Dspevx(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, double* ap, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspevx_work")]
            public static extern int DspevxWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, double* ap, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspgst")]
            public static extern int Dspgst(MatrixLayout matrixLayout, int itype, UpLoLapack uplo, int n, double* ap, double* bp);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspgst_work")]
            public static extern int DspgstWork(MatrixLayout matrixLayout, int itype, UpLoLapack uplo, int n, double* ap, double* bp);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspgv")]
            public static extern int Dspgv(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, double* ap, double* bp, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspgv_work")]
            public static extern int DspgvWork(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, double* ap, double* bp, double* w, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspgvd")]
            public static extern int Dspgvd(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, double* ap, double* bp, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspgvd_work")]
            public static extern int DspgvdWork(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, double* ap, double* bp, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspgvx")]
            public static extern int Dspgvx(MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, UpLoLapack uplo, int n, double* ap, double* bp, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspgvx_work")]
            public static extern int DspgvxWork(MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, UpLoLapack uplo, int n, double* ap, double* bp, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsposv")]
            public static extern int Dsposv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* b, int ldb, double* x, int ldx, int* iter);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsposv_work")]
            public static extern int DsposvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* b, int ldb, double* x, int ldx, double* work, float* swork, int* iter);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsprfs")]
            public static extern int Dsprfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* ap, double* afp, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsprfs_work")]
            public static extern int DsprfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* ap, double* afp, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspsv")]
            public static extern int Dspsv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* ap, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspsv_work")]
            public static extern int DspsvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* ap, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspsvx")]
            public static extern int Dspsvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, double* ap, double* afp, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspsvx_work")]
            public static extern int DspsvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, double* ap, double* afp, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsptrd")]
            public static extern int Dsptrd(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* ap, double* d, double* e, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsptrd_work")]
            public static extern int DsptrdWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* ap, double* d, double* e, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsptrf")]
            public static extern int Dsptrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsptrf_work")]
            public static extern int DsptrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsptri")]
            public static extern int Dsptri(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsptri_work")]
            public static extern int DsptriWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* ap, int* ipiv, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsptrs")]
            public static extern int Dsptrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* ap, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsptrs_work")]
            public static extern int DsptrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* ap, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstebz")]
            public static extern int Dstebz(sbyte range, sbyte order, int n, double vl, double vu, int il, int iu, double abstol, double* d, double* e, int* m, int* nsplit, double* w, int* iblock, int* isplit);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstebz_work")]
            public static extern int DstebzWork(sbyte range, sbyte order, int n, double vl, double vu, int il, int iu, double abstol, double* d, double* e, int* m, int* nsplit, double* w, int* iblock, int* isplit, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstedc")]
            public static extern int Dstedc(MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstedc_work")]
            public static extern int DstedcWork(MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstegr")]
            public static extern int Dstegr(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstegr_work")]
            public static extern int DstegrWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstein")]
            public static extern int Dstein(MatrixLayout matrixLayout, int n, double* d, double* e, int m, double* w, int* iblock, int* isplit, double* z, int ldz, int* ifailv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstein_work")]
            public static extern int DsteinWork(MatrixLayout matrixLayout, int n, double* d, double* e, int m, double* w, int* iblock, int* isplit, double* z, int ldz, double* work, int* iwork, int* ifailv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstemr")]
            public static extern int Dstemr(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* m, double* w, double* z, int ldz, int nzc, int* isuppz, int* tryrac);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstemr_work")]
            public static extern int DstemrWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* m, double* w, double* z, int ldz, int nzc, int* isuppz, int* tryrac, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsteqr")]
            public static extern int Dsteqr(MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsteqr_work")]
            public static extern int DsteqrWork(MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsterf")]
            public static extern int Dsterf(int n, double* d, double* e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsterf_work")]
            public static extern int DsterfWork(int n, double* d, double* e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstev")]
            public static extern int Dstev(MatrixLayout matrixLayout, sbyte jobz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstev_work")]
            public static extern int DstevWork(MatrixLayout matrixLayout, sbyte jobz, int n, double* d, double* e, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstevd")]
            public static extern int Dstevd(MatrixLayout matrixLayout, sbyte jobz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstevd_work")]
            public static extern int DstevdWork(MatrixLayout matrixLayout, sbyte jobz, int n, double* d, double* e, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstevr")]
            public static extern int Dstevr(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstevr_work")]
            public static extern int DstevrWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstevx")]
            public static extern int Dstevx(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstevx_work")]
            public static extern int DstevxWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsycon")]
            public static extern int Dsycon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsycon_work")]
            public static extern int DsyconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, int* ipiv, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyconv")]
            public static extern int Dsyconv(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte way, int n, double* a, int lda, int* ipiv, double* e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyconv_work")]
            public static extern int DsyconvWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte way, int n, double* a, int lda, int* ipiv, double* e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyequb")]
            public static extern int Dsyequb(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyequb_work")]
            public static extern int DsyequbWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, double* s, double* scond, double* amax, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyev")]
            public static extern int Dsyev(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, double* a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyev_work")]
            public static extern int DsyevWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, double* a, int lda, double* w, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevd")]
            public static extern int Dsyevd(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, double* a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevd_work")]
            public static extern int DsyevdWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, double* a, int lda, double* w, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevr")]
            public static extern int Dsyevr(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevr_work")]
            public static extern int DsyevrWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevx")]
            public static extern int Dsyevx(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevx_work")]
            public static extern int DsyevxWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsygst")]
            public static extern int Dsygst(MatrixLayout matrixLayout, int itype, UpLoLapack uplo, int n, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsygst_work")]
            public static extern int DsygstWork(MatrixLayout matrixLayout, int itype, UpLoLapack uplo, int n, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsygv")]
            public static extern int Dsygv(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, double* a, int lda, double* b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsygv_work")]
            public static extern int DsygvWork(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, double* a, int lda, double* b, int ldb, double* w, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsygvd")]
            public static extern int Dsygvd(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, double* a, int lda, double* b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsygvd_work")]
            public static extern int DsygvdWork(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, double* a, int lda, double* b, int ldb, double* w, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsygvx")]
            public static extern int Dsygvx(MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, UpLoLapack uplo, int n, double* a, int lda, double* b, int ldb, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsygvx_work")]
            public static extern int DsygvxWork(MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, UpLoLapack uplo, int n, double* a, int lda, double* b, int ldb, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyrfs")]
            public static extern int Dsyrfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyrfs_work")]
            public static extern int DsyrfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyrfsx")]
            public static extern int Dsyrfsx(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyrfsx_work")]
            public static extern int DsyrfsxWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysv")]
            public static extern int Dsysv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysv_rook")]
            public static extern int DsysvRook(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysv_rook_work")]
            public static extern int DsysvRookWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysv_work")]
            public static extern int DsysvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysvx")]
            public static extern int Dsysvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysvx_work")]
            public static extern int DsysvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysvxx")]
            public static extern int Dsysvxx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysvxx_work")]
            public static extern int DsysvxxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyswapr")]
            public static extern int Dsyswapr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyswapr_work")]
            public static extern int DsyswaprWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrd")]
            public static extern int Dsytrd(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, double* d, double* e, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrd_work")]
            public static extern int DsytrdWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, double* d, double* e, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrf")]
            public static extern int Dsytrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrf_rook")]
            public static extern int DsytrfRook(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrf_rook_work")]
            public static extern int DsytrfRookWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrf_work")]
            public static extern int DsytrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytri")]
            public static extern int Dsytri(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytri2")]
            public static extern int Dsytri2(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytri2_work")]
            public static extern int Dsytri2Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytri2x")]
            public static extern int Dsytri2x(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytri2x_work")]
            public static extern int Dsytri2xWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, int* ipiv, double* work, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytri_work")]
            public static extern int DsytriWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, int* ipiv, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs")]
            public static extern int Dsytrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs2")]
            public static extern int Dsytrs2(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs2_work")]
            public static extern int Dsytrs2Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs_rook")]
            public static extern int DsytrsRook(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs_rook_work")]
            public static extern int DsytrsRookWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs_work")]
            public static extern int DsytrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtbcon")]
            public static extern int Dtbcon(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, int kd, double* ab, int ldab, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtbcon_work")]
            public static extern int DtbconWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, int kd, double* ab, int ldab, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtbrfs")]
            public static extern int Dtbrfs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtbrfs_work")]
            public static extern int DtbrfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtbtrs")]
            public static extern int Dtbtrs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtbtrs_work")]
            public static extern int DtbtrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtfsm")]
            public static extern int Dtfsm(MatrixLayout matrixLayout, sbyte transr, sbyte side, UpLoLapack uplo, TransLapack trans, sbyte diag, int m, int n, double alpha, double* a, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtfsm_work")]
            public static extern int DtfsmWork(MatrixLayout matrixLayout, sbyte transr, sbyte side, UpLoLapack uplo, TransLapack trans, sbyte diag, int m, int n, double alpha, double* a, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtftri")]
            public static extern int Dtftri(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, sbyte diag, int n, double* a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtftri_work")]
            public static extern int DtftriWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, sbyte diag, int n, double* a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtfttp")]
            public static extern int Dtfttp(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, double* arf, double* ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtfttp_work")]
            public static extern int DtfttpWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, double* arf, double* ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtfttr")]
            public static extern int Dtfttr(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, double* arf, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtfttr_work")]
            public static extern int DtfttrWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, double* arf, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgevc")]
            public static extern int Dtgevc(MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, double* s, int lds, double* p, int ldp, double* vl, int ldvl, double* vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgevc_work")]
            public static extern int DtgevcWork(MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, double* s, int lds, double* p, int ldp, double* vl, int ldvl, double* vr, int ldvr, int mm, int* m, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgexc")]
            public static extern int Dtgexc(MatrixLayout matrixLayout, int wantq, int wantz, int n, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z, int ldz, int* ifst, int* ilst);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgexc_work")]
            public static extern int DtgexcWork(MatrixLayout matrixLayout, int wantq, int wantz, int n, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z, int ldz, int* ifst, int* ilst, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgsen")]
            public static extern int Dtgsen(MatrixLayout matrixLayout, int ijob, int wantq, int wantz, int* select, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* q, int ldq, double* z, int ldz, int* m, double* pl, double* pr, double* dif);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgsen_work")]
            public static extern int DtgsenWork(MatrixLayout matrixLayout, int ijob, int wantq, int wantz, int* select, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* q, int ldq, double* z, int ldz, int* m, double* pl, double* pr, double* dif, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgsja")]
            public static extern int Dtgsja(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, double* a, int lda, double* b, int ldb, double tola, double tolb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* ncycle);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgsja_work")]
            public static extern int DtgsjaWork(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, double* a, int lda, double* b, int ldb, double tola, double tolb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, double* work, int* ncycle);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgsna")]
            public static extern int Dtgsna(MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, double* a, int lda, double* b, int ldb, double* vl, int ldvl, double* vr, int ldvr, double* s, double* dif, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgsna_work")]
            public static extern int DtgsnaWork(MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, double* a, int lda, double* b, int ldb, double* vl, int ldvl, double* vr, int ldvr, double* s, double* dif, int mm, int* m, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgsyl")]
            public static extern int Dtgsyl(MatrixLayout matrixLayout, TransLapack trans, int ijob, int m, int n, double* a, int lda, double* b, int ldb, double* c, int ldc, double* d, int ldd, double* e, int lde, double* f, int ldf, double* scale, double* dif);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgsyl_work")]
            public static extern int DtgsylWork(MatrixLayout matrixLayout, TransLapack trans, int ijob, int m, int n, double* a, int lda, double* b, int ldb, double* c, int ldc, double* d, int ldd, double* e, int lde, double* f, int ldf, double* scale, double* dif, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpcon")]
            public static extern int Dtpcon(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, double* ap, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpcon_work")]
            public static extern int DtpconWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, double* ap, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpmqrt")]
            public static extern int Dtpmqrt(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int l, int nb, double* v, int ldv, double* t, int ldt, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpmqrt_work")]
            public static extern int DtpmqrtWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int l, int nb, double* v, int ldv, double* t, int ldt, double* a, int lda, double* b, int ldb, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpqrt")]
            public static extern int Dtpqrt(MatrixLayout matrixLayout, int m, int n, int l, int nb, double* a, int lda, double* b, int ldb, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpqrt2")]
            public static extern int Dtpqrt2(MatrixLayout matrixLayout, int m, int n, int l, double* a, int lda, double* b, int ldb, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpqrt2_work")]
            public static extern int Dtpqrt2Work(MatrixLayout matrixLayout, int m, int n, int l, double* a, int lda, double* b, int ldb, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpqrt_work")]
            public static extern int DtpqrtWork(MatrixLayout matrixLayout, int m, int n, int l, int nb, double* a, int lda, double* b, int ldb, double* t, int ldt, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtprfb")]
            public static extern int Dtprfb(MatrixLayout matrixLayout, sbyte side, TransLapack trans, sbyte direct, sbyte storev, int m, int n, int k, int l, double* v, int ldv, double* t, int ldt, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtprfb_work")]
            public static extern int DtprfbWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, sbyte direct, sbyte storev, int m, int n, int k, int l, double* v, int ldv, double* t, int ldt, double* a, int lda, double* b, int ldb, double* work, int ldwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtprfs")]
            public static extern int Dtprfs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, double* ap, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtprfs_work")]
            public static extern int DtprfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, double* ap, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtptri")]
            public static extern int Dtptri(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte diag, int n, double* ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtptri_work")]
            public static extern int DtptriWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte diag, int n, double* ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtptrs")]
            public static extern int Dtptrs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtptrs_work")]
            public static extern int DtptrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpttf")]
            public static extern int Dtpttf(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, double* ap, double* arf);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpttf_work")]
            public static extern int DtpttfWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, double* ap, double* arf);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpttr")]
            public static extern int Dtpttr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* ap, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpttr_work")]
            public static extern int DtpttrWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* ap, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrcon")]
            public static extern int Dtrcon(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, double* a, int lda, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrcon_work")]
            public static extern int DtrconWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, double* a, int lda, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrevc")]
            public static extern int Dtrevc(MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, double* t, int ldt, double* vl, int ldvl, double* vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrevc_work")]
            public static extern int DtrevcWork(MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, double* t, int ldt, double* vl, int ldvl, double* vr, int ldvr, int mm, int* m, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrexc")]
            public static extern int Dtrexc(MatrixLayout matrixLayout, sbyte compq, int n, double* t, int ldt, double* q, int ldq, int* ifst, int* ilst);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrexc_work")]
            public static extern int DtrexcWork(MatrixLayout matrixLayout, sbyte compq, int n, double* t, int ldt, double* q, int ldq, int* ifst, int* ilst, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrrfs")]
            public static extern int Dtrrfs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, double* a, int lda, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrrfs_work")]
            public static extern int DtrrfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, double* a, int lda, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrsen")]
            public static extern int Dtrsen(MatrixLayout matrixLayout, sbyte job, sbyte compq, int* select, int n, double* t, int ldt, double* q, int ldq, double* wr, double* wi, int* m, double* s, double* sep);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrsen_work")]
            public static extern int DtrsenWork(MatrixLayout matrixLayout, sbyte job, sbyte compq, int* select, int n, double* t, int ldt, double* q, int ldq, double* wr, double* wi, int* m, double* s, double* sep, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrsna")]
            public static extern int Dtrsna(MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, double* t, int ldt, double* vl, int ldvl, double* vr, int ldvr, double* s, double* sep, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrsna_work")]
            public static extern int DtrsnaWork(MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, double* t, int ldt, double* vl, int ldvl, double* vr, int ldvr, double* s, double* sep, int mm, int* m, double* work, int ldwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrsyl")]
            public static extern int Dtrsyl(MatrixLayout matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, double* a, int lda, double* b, int ldb, double* c, int ldc, double* scale);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrsyl_work")]
            public static extern int DtrsylWork(MatrixLayout matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, double* a, int lda, double* b, int ldb, double* c, int ldc, double* scale);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrtri")]
            public static extern int Dtrtri(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte diag, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrtri_work")]
            public static extern int DtrtriWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte diag, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrtrs")]
            public static extern int Dtrtrs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrtrs_work")]
            public static extern int DtrtrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrttf")]
            public static extern int Dtrttf(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, double* a, int lda, double* arf);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrttf_work")]
            public static extern int DtrttfWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, double* a, int lda, double* arf);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrttp")]
            public static extern int Dtrttp(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, double* ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrttp_work")]
            public static extern int DtrttpWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, double* ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtzrzf")]
            public static extern int Dtzrzf(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtzrzf_work")]
            public static extern int DtzrzfWork(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_cgetrfnpi")]
            public static extern int MklCgetrfnpi(MatrixLayout matrixLayout, int m, int n, int nfact, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_cgetrfnpi_work")]
            public static extern int MklCgetrfnpiWork(MatrixLayout matrixLayout, int m, int n, int nfact, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_ctppack")]
            public static extern int MklCtppack(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, int n, IntPtr ap, int i, int j, int rows, int cols, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_ctppack_work")]
            public static extern int MklCtppackWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, int n, IntPtr ap, int i, int j, int rows, int cols, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_ctpunpack")]
            public static extern int MklCtpunpack(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, int n, IntPtr ap, int i, int j, int rows, int cols, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_ctpunpack_work")]
            public static extern int MklCtpunpackWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, int n, IntPtr ap, int i, int j, int rows, int cols, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_dgetrfnpi")]
            public static extern int MklDgetrfnpi(MatrixLayout matrixLayout, int m, int n, int nfact, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_dgetrfnpi_work")]
            public static extern int MklDgetrfnpiWork(MatrixLayout matrixLayout, int m, int n, int nfact, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_dtppack")]
            public static extern int MklDtppack(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, int n, double* ap, int i, int j, int rows, int cols, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_dtppack_work")]
            public static extern int MklDtppackWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, int n, double* ap, int i, int j, int rows, int cols, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_dtpunpack")]
            public static extern int MklDtpunpack(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, int n, double* ap, int i, int j, int rows, int cols, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_dtpunpack_work")]
            public static extern int MklDtpunpackWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, int n, double* ap, int i, int j, int rows, int cols, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_sgetrfnpi")]
            public static extern int MklSgetrfnpi(MatrixLayout matrixLayout, int m, int n, int nfact, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_sgetrfnpi_work")]
            public static extern int MklSgetrfnpiWork(MatrixLayout matrixLayout, int m, int n, int nfact, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_stppack")]
            public static extern int MklStppack(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, int n, float* ap, int i, int j, int rows, int cols, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_stppack_work")]
            public static extern int MklStppackWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, int n, float* ap, int i, int j, int rows, int cols, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_stpunpack")]
            public static extern int MklStpunpack(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, int n, float* ap, int i, int j, int rows, int cols, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_stpunpack_work")]
            public static extern int MklStpunpackWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, int n, float* ap, int i, int j, int rows, int cols, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_zgetrfnpi")]
            public static extern int MklZgetrfnpi(MatrixLayout matrixLayout, int m, int n, int nfact, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_zgetrfnpi_work")]
            public static extern int MklZgetrfnpiWork(MatrixLayout matrixLayout, int m, int n, int nfact, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_ztppack")]
            public static extern int MklZtppack(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, int n, IntPtr ap, int i, int j, int rows, int cols, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_ztppack_work")]
            public static extern int MklZtppackWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, int n, IntPtr ap, int i, int j, int rows, int cols, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_ztpunpack")]
            public static extern int MklZtpunpack(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, int n, IntPtr ap, int i, int j, int rows, int cols, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_ztpunpack_work")]
            public static extern int MklZtpunpackWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, int n, IntPtr ap, int i, int j, int rows, int cols, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sbbcsd")]
            public static extern int Sbbcsd(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, TransLapack trans, int m, int p, int q, float* theta, float* phi, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* v2t, int ldv2t, float* b11d, float* b11e, float* b12d, float* b12e, float* b21d, float* b21e, float* b22d, float* b22e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sbbcsd_work")]
            public static extern int SbbcsdWork(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, TransLapack trans, int m, int p, int q, float* theta, float* phi, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* v2t, int ldv2t, float* b11d, float* b11e, float* b12d, float* b12e, float* b21d, float* b21e, float* b22d, float* b22e, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sbdsdc")]
            public static extern int Sbdsdc(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte compq, int n, float* d, float* e, float* u, int ldu, float* vt, int ldvt, float* q, int* iq);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sbdsdc_work")]
            public static extern int SbdsdcWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte compq, int n, float* d, float* e, float* u, int ldu, float* vt, int ldvt, float* q, int* iq, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sbdsqr")]
            public static extern int Sbdsqr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int ncvt, int nru, int ncc, float* d, float* e, float* vt, int ldvt, float* u, int ldu, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sbdsqr_work")]
            public static extern int SbdsqrWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int ncvt, int nru, int ncc, float* d, float* e, float* vt, int ldvt, float* u, int ldu, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sbdsvdx")]
            public static extern int Sbdsvdx(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* ns, float* s, float* z, int ldz, int* superb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sbdsvdx_work")]
            public static extern int SbdsvdxWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* ns, float* s, float* z, int ldz, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sdisna")]
            public static extern int Sdisna(sbyte job, int m, int n, float* d, float* sep);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sdisna_work")]
            public static extern int SdisnaWork(sbyte job, int m, int n, float* d, float* sep);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbbrd")]
            public static extern int Sgbbrd(MatrixLayout matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, float* ab, int ldab, float* d, float* e, float* q, int ldq, float* pt, int ldpt, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbbrd_work")]
            public static extern int SgbbrdWork(MatrixLayout matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, float* ab, int ldab, float* d, float* e, float* q, int ldq, float* pt, int ldpt, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbcon")]
            public static extern int Sgbcon(MatrixLayout matrixLayout, sbyte norm, int n, int kl, int ku, float* ab, int ldab, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbcon_work")]
            public static extern int SgbconWork(MatrixLayout matrixLayout, sbyte norm, int n, int kl, int ku, float* ab, int ldab, int* ipiv, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbequ")]
            public static extern int Sgbequ(MatrixLayout matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbequ_work")]
            public static extern int SgbequWork(MatrixLayout matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbequb")]
            public static extern int Sgbequb(MatrixLayout matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbequb_work")]
            public static extern int SgbequbWork(MatrixLayout matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbrfs")]
            public static extern int Sgbrfs(MatrixLayout matrixLayout, TransLapack trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbrfs_work")]
            public static extern int SgbrfsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbrfsx")]
            public static extern int Sgbrfsx(MatrixLayout matrixLayout, TransLapack trans, sbyte equed, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbrfsx_work")]
            public static extern int SgbrfsxWork(MatrixLayout matrixLayout, TransLapack trans, sbyte equed, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbsv")]
            public static extern int Sgbsv(MatrixLayout matrixLayout, int n, int kl, int ku, int nrhs, float* ab, int ldab, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbsv_work")]
            public static extern int SgbsvWork(MatrixLayout matrixLayout, int n, int kl, int ku, int nrhs, float* ab, int ldab, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbsvx")]
            public static extern int Sgbsvx(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* rpivot);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbsvx_work")]
            public static extern int SgbsvxWork(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbsvxx")]
            public static extern int Sgbsvxx(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbsvxx_work")]
            public static extern int SgbsvxxWork(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbtrf")]
            public static extern int Sgbtrf(MatrixLayout matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbtrf_work")]
            public static extern int SgbtrfWork(MatrixLayout matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbtrs")]
            public static extern int Sgbtrs(MatrixLayout matrixLayout, TransLapack trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbtrs_work")]
            public static extern int SgbtrsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgebak")]
            public static extern int Sgebak(MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* scale, int m, float* v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgebak_work")]
            public static extern int SgebakWork(MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* scale, int m, float* v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgebal")]
            public static extern int Sgebal(MatrixLayout matrixLayout, sbyte job, int n, float* a, int lda, int* ilo, int* ihi, float* scale);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgebal_work")]
            public static extern int SgebalWork(MatrixLayout matrixLayout, sbyte job, int n, float* a, int lda, int* ilo, int* ihi, float* scale);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgebrd")]
            public static extern int Sgebrd(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* d, float* e, float* tauq, float* taup);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgebrd_work")]
            public static extern int SgebrdWork(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* d, float* e, float* tauq, float* taup, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgecon")]
            public static extern int Sgecon(MatrixLayout matrixLayout, sbyte norm, int n, float* a, int lda, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgecon_work")]
            public static extern int SgeconWork(MatrixLayout matrixLayout, sbyte norm, int n, float* a, int lda, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeequ")]
            public static extern int Sgeequ(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeequ_work")]
            public static extern int SgeequWork(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeequb")]
            public static extern int Sgeequb(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeequb_work")]
            public static extern int SgeequbWork(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgees")]
            public static extern int Sgees(MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, int n, float* a, int lda, int* sdim, float* wr, float* wi, float* vs, int ldvs);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgees_work")]
            public static extern int SgeesWork(MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, int n, float* a, int lda, int* sdim, float* wr, float* wi, float* vs, int ldvs, float* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeesx")]
            public static extern int Sgeesx(MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, sbyte sense, int n, float* a, int lda, int* sdim, float* wr, float* wi, float* vs, int ldvs, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeesx_work")]
            public static extern int SgeesxWork(MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, sbyte sense, int n, float* a, int lda, int* sdim, float* wr, float* wi, float* vs, int ldvs, float* rconde, float* rcondv, float* work, int lwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeev")]
            public static extern int Sgeev(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* wr, float* wi, float* vl, int ldvl, float* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeev_work")]
            public static extern int SgeevWork(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* wr, float* wi, float* vl, int ldvl, float* vr, int ldvr, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeevx")]
            public static extern int Sgeevx(MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, float* a, int lda, float* wr, float* wi, float* vl, int ldvl, float* vr, int ldvr, int* ilo, int* ihi, float* scale, float* abnrm, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeevx_work")]
            public static extern int SgeevxWork(MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, float* a, int lda, float* wr, float* wi, float* vl, int ldvl, float* vr, int ldvr, int* ilo, int* ihi, float* scale, float* abnrm, float* rconde, float* rcondv, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgehrd")]
            public static extern int Sgehrd(MatrixLayout matrixLayout, int n, int ilo, int ihi, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgehrd_work")]
            public static extern int SgehrdWork(MatrixLayout matrixLayout, int n, int ilo, int ihi, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgejsv")]
            public static extern int Sgejsv(MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, float* a, int lda, float* sva, float* u, int ldu, float* v, int ldv, float* stat, int* istat);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgejsv_work")]
            public static extern int SgejsvWork(MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, float* a, int lda, float* sva, float* u, int ldu, float* v, int ldv, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelq2")]
            public static extern int Sgelq2(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelq2_work")]
            public static extern int Sgelq2Work(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelqf")]
            public static extern int Sgelqf(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelqf_work")]
            public static extern int SgelqfWork(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgels")]
            public static extern int Sgels(MatrixLayout matrixLayout, TransLapack trans, int m, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgels_work")]
            public static extern int SgelsWork(MatrixLayout matrixLayout, TransLapack trans, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelsd")]
            public static extern int Sgelsd(MatrixLayout matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* s, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelsd_work")]
            public static extern int SgelsdWork(MatrixLayout matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* s, float rcond, int* rank, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelss")]
            public static extern int Sgelss(MatrixLayout matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* s, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelss_work")]
            public static extern int SgelssWork(MatrixLayout matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* s, float rcond, int* rank, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelsy")]
            public static extern int Sgelsy(MatrixLayout matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, int* jpvt, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelsy_work")]
            public static extern int SgelsyWork(MatrixLayout matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, int* jpvt, float rcond, int* rank, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgemqrt")]
            public static extern int Sgemqrt(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int nb, float* v, int ldv, float* t, int ldt, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgemqrt_work")]
            public static extern int SgemqrtWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int nb, float* v, int ldv, float* t, int ldt, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqlf")]
            public static extern int Sgeqlf(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqlf_work")]
            public static extern int SgeqlfWork(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqp3")]
            public static extern int Sgeqp3(MatrixLayout matrixLayout, int m, int n, float* a, int lda, int* jpvt, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqp3_work")]
            public static extern int Sgeqp3Work(MatrixLayout matrixLayout, int m, int n, float* a, int lda, int* jpvt, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqpf")]
            public static extern int Sgeqpf(MatrixLayout matrixLayout, int m, int n, float* a, int lda, int* jpvt, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqpf_work")]
            public static extern int SgeqpfWork(MatrixLayout matrixLayout, int m, int n, float* a, int lda, int* jpvt, float* tau, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqr2")]
            public static extern int Sgeqr2(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqr2_work")]
            public static extern int Sgeqr2Work(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqrf")]
            public static extern int Sgeqrf(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqrf_work")]
            public static extern int SgeqrfWork(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqrfp")]
            public static extern int Sgeqrfp(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqrfp_work")]
            public static extern int SgeqrfpWork(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqrt")]
            public static extern int Sgeqrt(MatrixLayout matrixLayout, int m, int n, int nb, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqrt2")]
            public static extern int Sgeqrt2(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqrt2_work")]
            public static extern int Sgeqrt2Work(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqrt3")]
            public static extern int Sgeqrt3(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqrt3_work")]
            public static extern int Sgeqrt3Work(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqrt_work")]
            public static extern int SgeqrtWork(MatrixLayout matrixLayout, int m, int n, int nb, float* a, int lda, float* t, int ldt, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgerfs")]
            public static extern int Sgerfs(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgerfs_work")]
            public static extern int SgerfsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgerfsx")]
            public static extern int Sgerfsx(MatrixLayout matrixLayout, TransLapack trans, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgerfsx_work")]
            public static extern int SgerfsxWork(MatrixLayout matrixLayout, TransLapack trans, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgerqf")]
            public static extern int Sgerqf(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgerqf_work")]
            public static extern int SgerqfWork(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesdd")]
            public static extern int Sgesdd(MatrixLayout matrixLayout, sbyte jobz, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* vt, int ldvt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesdd_work")]
            public static extern int SgesddWork(MatrixLayout matrixLayout, sbyte jobz, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* vt, int ldvt, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesv")]
            public static extern int Sgesv(MatrixLayout matrixLayout, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesv_work")]
            public static extern int SgesvWork(MatrixLayout matrixLayout, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvd")]
            public static extern int Sgesvd(MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* vt, int ldvt, float* superb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvd_work")]
            public static extern int SgesvdWork(MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* vt, int ldvt, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvdx")]
            public static extern int Sgesvdx(MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, float* a, int lda, float vl, float vu, int il, int iu, int* ns, float* s, float* u, int ldu, float* vt, int ldvt, int* superb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvdx_work")]
            public static extern int SgesvdxWork(MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, float* a, int lda, float vl, float vu, int il, int iu, int* ns, float* s, float* u, int ldu, float* vt, int ldvt, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvj")]
            public static extern int Sgesvj(MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, float* a, int lda, float* sva, int mv, float* v, int ldv, float* stat);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvj_work")]
            public static extern int SgesvjWork(MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, float* a, int lda, float* sva, int mv, float* v, int ldv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvx")]
            public static extern int Sgesvx(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* rpivot);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvx_work")]
            public static extern int SgesvxWork(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvxx")]
            public static extern int Sgesvxx(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvxx_work")]
            public static extern int SgesvxxWork(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetf2")]
            public static extern int Sgetf2(MatrixLayout matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetf2_work")]
            public static extern int Sgetf2Work(MatrixLayout matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetrf")]
            public static extern int Sgetrf(MatrixLayout matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetrf2")]
            public static extern int Sgetrf2(MatrixLayout matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetrf2_work")]
            public static extern int Sgetrf2Work(MatrixLayout matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetrf_work")]
            public static extern int SgetrfWork(MatrixLayout matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetri")]
            public static extern int Sgetri(MatrixLayout matrixLayout, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetri_work")]
            public static extern int SgetriWork(MatrixLayout matrixLayout, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetrs")]
            public static extern int Sgetrs(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetrs_work")]
            public static extern int SgetrsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggbak")]
            public static extern int Sggbak(MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* lscale, float* rscale, int m, float* v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggbak_work")]
            public static extern int SggbakWork(MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* lscale, float* rscale, int m, float* v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggbal")]
            public static extern int Sggbal(MatrixLayout matrixLayout, sbyte job, int n, float* a, int lda, float* b, int ldb, int* ilo, int* ihi, float* lscale, float* rscale);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggbal_work")]
            public static extern int SggbalWork(MatrixLayout matrixLayout, sbyte job, int n, float* a, int lda, float* b, int ldb, int* ilo, int* ihi, float* lscale, float* rscale, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgges")]
            public static extern int Sgges(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, float* a, int lda, float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgges3")]
            public static extern int Sgges3(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, float* a, int lda, float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgges3_work")]
            public static extern int Sgges3Work(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, float* a, int lda, float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr, float* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgges_work")]
            public static extern int SggesWork(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, float* a, int lda, float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr, float* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggesx")]
            public static extern int Sggesx(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, sbyte sense, int n, float* a, int lda, float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggesx_work")]
            public static extern int SggesxWork(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, sbyte sense, int n, float* a, int lda, float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr, float* rconde, float* rcondv, float* work, int lwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggev")]
            public static extern int Sggev(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggev3")]
            public static extern int Sggev3(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggev3_work")]
            public static extern int Sggev3Work(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggev_work")]
            public static extern int SggevWork(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggevx")]
            public static extern int Sggevx(MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr, int* ilo, int* ihi, float* lscale, float* rscale, float* abnrm, float* bbnrm, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggevx_work")]
            public static extern int SggevxWork(MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr, int* ilo, int* ihi, float* lscale, float* rscale, float* abnrm, float* bbnrm, float* rconde, float* rcondv, float* work, int lwork, int* iwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggglm")]
            public static extern int Sggglm(MatrixLayout matrixLayout, int n, int m, int p, float* a, int lda, float* b, int ldb, float* d, float* x, float* y);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggglm_work")]
            public static extern int SggglmWork(MatrixLayout matrixLayout, int n, int m, int p, float* a, int lda, float* b, int ldb, float* d, float* x, float* y, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgghd3")]
            public static extern int Sgghd3(MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgghd3_work")]
            public static extern int Sgghd3Work(MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgghrd")]
            public static extern int Sgghrd(MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgghrd_work")]
            public static extern int SgghrdWork(MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgglse")]
            public static extern int Sgglse(MatrixLayout matrixLayout, int m, int n, int p, float* a, int lda, float* b, int ldb, float* c, float* d, float* x);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgglse_work")]
            public static extern int SgglseWork(MatrixLayout matrixLayout, int m, int n, int p, float* a, int lda, float* b, int ldb, float* c, float* d, float* x, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggqrf")]
            public static extern int Sggqrf(MatrixLayout matrixLayout, int n, int m, int p, float* a, int lda, float* taua, float* b, int ldb, float* taub);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggqrf_work")]
            public static extern int SggqrfWork(MatrixLayout matrixLayout, int n, int m, int p, float* a, int lda, float* taua, float* b, int ldb, float* taub, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggrqf")]
            public static extern int Sggrqf(MatrixLayout matrixLayout, int m, int p, int n, float* a, int lda, float* taua, float* b, int ldb, float* taub);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggrqf_work")]
            public static extern int SggrqfWork(MatrixLayout matrixLayout, int m, int p, int n, float* a, int lda, float* taua, float* b, int ldb, float* taub, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggsvd")]
            public static extern int Sggsvd(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, float* a, int lda, float* b, int ldb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggsvd3")]
            public static extern int Sggsvd3(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, float* a, int lda, float* b, int ldb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggsvd3_work")]
            public static extern int Sggsvd3Work(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, float* a, int lda, float* b, int ldb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggsvd_work")]
            public static extern int SggsvdWork(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, float* a, int lda, float* b, int ldb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggsvp")]
            public static extern int Sggsvp(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, float* a, int lda, float* b, int ldb, float tola, float tolb, int* k, int* l, float* u, int ldu, float* v, int ldv, float* q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggsvp3")]
            public static extern int Sggsvp3(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, float* a, int lda, float* b, int ldb, float tola, float tolb, int* k, int* l, float* u, int ldu, float* v, int ldv, float* q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggsvp3_work")]
            public static extern int Sggsvp3Work(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, float* a, int lda, float* b, int ldb, float tola, float tolb, int* k, int* l, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* iwork, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggsvp_work")]
            public static extern int SggsvpWork(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, float* a, int lda, float* b, int ldb, float tola, float tolb, int* k, int* l, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* iwork, float* tau, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgtcon")]
            public static extern int Sgtcon(sbyte norm, int n, float* dl, float* d, float* du, float* du2, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgtcon_work")]
            public static extern int SgtconWork(sbyte norm, int n, float* dl, float* d, float* du, float* du2, int* ipiv, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgtrfs")]
            public static extern int Sgtrfs(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, float* dl, float* d, float* du, float* dlf, float* df, float* duf, float* du2, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgtrfs_work")]
            public static extern int SgtrfsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, float* dl, float* d, float* du, float* dlf, float* df, float* duf, float* du2, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgtsv")]
            public static extern int Sgtsv(MatrixLayout matrixLayout, int n, int nrhs, float* dl, float* d, float* du, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgtsv_work")]
            public static extern int SgtsvWork(MatrixLayout matrixLayout, int n, int nrhs, float* dl, float* d, float* du, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgtsvx")]
            public static extern int Sgtsvx(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, float* dl, float* d, float* du, float* dlf, float* df, float* duf, float* du2, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgtsvx_work")]
            public static extern int SgtsvxWork(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, float* dl, float* d, float* du, float* dlf, float* df, float* duf, float* du2, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgttrf")]
            public static extern int Sgttrf(int n, float* dl, float* d, float* du, float* du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgttrf_work")]
            public static extern int SgttrfWork(int n, float* dl, float* d, float* du, float* du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgttrs")]
            public static extern int Sgttrs(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, float* dl, float* d, float* du, float* du2, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgttrs_work")]
            public static extern int SgttrsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, float* dl, float* d, float* du, float* du2, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_shgeqz")]
            public static extern int Shgeqz(MatrixLayout matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* h, int ldh, float* t, int ldt, float* alphar, float* alphai, float* beta, float* q, int ldq, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_shgeqz_work")]
            public static extern int ShgeqzWork(MatrixLayout matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* h, int ldh, float* t, int ldt, float* alphar, float* alphai, float* beta, float* q, int ldq, float* z, int ldz, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_shsein")]
            public static extern int Shsein(MatrixLayout matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, float* h, int ldh, float* wr, float* wi, float* vl, int ldvl, float* vr, int ldvr, int mm, int* m, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_shsein_work")]
            public static extern int ShseinWork(MatrixLayout matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, float* h, int ldh, float* wr, float* wi, float* vl, int ldvl, float* vr, int ldvr, int mm, int* m, float* work, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_shseqr")]
            public static extern int Shseqr(MatrixLayout matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, float* h, int ldh, float* wr, float* wi, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_shseqr_work")]
            public static extern int ShseqrWork(MatrixLayout matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, float* h, int ldh, float* wr, float* wi, float* z, int ldz, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slacn2")]
            public static extern int Slacn2(int n, float* v, float* x, int* isgn, float* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slacn2_work")]
            public static extern int Slacn2Work(int n, float* v, float* x, int* isgn, float* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slacpy")]
            public static extern int Slacpy(MatrixLayout matrixLayout, UpLoLapack uplo, int m, int n, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slacpy_work")]
            public static extern int SlacpyWork(MatrixLayout matrixLayout, UpLoLapack uplo, int m, int n, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slag2d")]
            public static extern int Slag2d(MatrixLayout matrixLayout, int m, int n, float* sa, int ldsa, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slag2d_work")]
            public static extern int Slag2dWork(MatrixLayout matrixLayout, int m, int n, float* sa, int ldsa, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slagge")]
            public static extern int Slagge(MatrixLayout matrixLayout, int m, int n, int kl, int ku, float* d, float* a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slagge_work")]
            public static extern int SlaggeWork(MatrixLayout matrixLayout, int m, int n, int kl, int ku, float* d, float* a, int lda, int* iseed, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slagsy")]
            public static extern int Slagsy(MatrixLayout matrixLayout, int n, int k, float* d, float* a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slagsy_work")]
            public static extern int SlagsyWork(MatrixLayout matrixLayout, int n, int k, float* d, float* a, int lda, int* iseed, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slapmr")]
            public static extern int Slapmr(MatrixLayout matrixLayout, int forwrd, int m, int n, float* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slapmr_work")]
            public static extern int SlapmrWork(MatrixLayout matrixLayout, int forwrd, int m, int n, float* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slapmt")]
            public static extern int Slapmt(MatrixLayout matrixLayout, int forwrd, int m, int n, float* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slapmt_work")]
            public static extern int SlapmtWork(MatrixLayout matrixLayout, int forwrd, int m, int n, float* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slarfb")]
            public static extern int Slarfb(MatrixLayout matrixLayout, sbyte side, TransLapack trans, sbyte direct, sbyte storev, int m, int n, int k, float* v, int ldv, float* t, int ldt, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slarfb_work")]
            public static extern int SlarfbWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, sbyte direct, sbyte storev, int m, int n, int k, float* v, int ldv, float* t, int ldt, float* c, int ldc, float* work, int ldwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slarfg")]
            public static extern int Slarfg(int n, float* alpha, float* x, int incx, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slarfg_work")]
            public static extern int SlarfgWork(int n, float* alpha, float* x, int incx, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slarft")]
            public static extern int Slarft(MatrixLayout matrixLayout, sbyte direct, sbyte storev, int n, int k, float* v, int ldv, float* tau, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slarft_work")]
            public static extern int SlarftWork(MatrixLayout matrixLayout, sbyte direct, sbyte storev, int n, int k, float* v, int ldv, float* tau, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slarfx")]
            public static extern int Slarfx(MatrixLayout matrixLayout, sbyte side, int m, int n, float* v, float tau, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slarfx_work")]
            public static extern int SlarfxWork(MatrixLayout matrixLayout, sbyte side, int m, int n, float* v, float tau, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slarnv")]
            public static extern int Slarnv(int idist, int* iseed, int n, float* x);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slarnv_work")]
            public static extern int SlarnvWork(int idist, int* iseed, int n, float* x);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slartgp")]
            public static extern int Slartgp(float f, float g, float* cs, float* sn, float* r);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slartgp_work")]
            public static extern int SlartgpWork(float f, float g, float* cs, float* sn, float* r);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slartgs")]
            public static extern int Slartgs(float x, float y, float sigma, float* cs, float* sn);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slartgs_work")]
            public static extern int SlartgsWork(float x, float y, float sigma, float* cs, float* sn);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slascl")]
            public static extern int Slascl(MatrixLayout matrixLayout, sbyte type, int kl, int ku, float cfrom, float cto, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slascl_work")]
            public static extern int SlasclWork(MatrixLayout matrixLayout, sbyte type, int kl, int ku, float cfrom, float cto, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slaset")]
            public static extern int Slaset(MatrixLayout matrixLayout, UpLoLapack uplo, int m, int n, float alpha, float beta, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slaset_work")]
            public static extern int SlasetWork(MatrixLayout matrixLayout, UpLoLapack uplo, int m, int n, float alpha, float beta, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slasrt")]
            public static extern int Slasrt(sbyte id, int n, float* d);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slasrt_work")]
            public static extern int SlasrtWork(sbyte id, int n, float* d);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slaswp")]
            public static extern int Slaswp(MatrixLayout matrixLayout, int n, float* a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slaswp_work")]
            public static extern int SlaswpWork(MatrixLayout matrixLayout, int n, float* a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slatms")]
            public static extern int Slatms(MatrixLayout matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, float* d, int mode, float cond, float dmax, int kl, int ku, sbyte pack, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slatms_work")]
            public static extern int SlatmsWork(MatrixLayout matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, float* d, int mode, float cond, float dmax, int kl, int ku, sbyte pack, float* a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slauum")]
            public static extern int Slauum(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slauum_work")]
            public static extern int SlauumWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sopgtr")]
            public static extern int Sopgtr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* ap, float* tau, float* q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sopgtr_work")]
            public static extern int SopgtrWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* ap, float* tau, float* q, int ldq, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sopmtr")]
            public static extern int Sopmtr(MatrixLayout matrixLayout, sbyte side, UpLoLapack uplo, TransLapack trans, int m, int n, float* ap, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sopmtr_work")]
            public static extern int SopmtrWork(MatrixLayout matrixLayout, sbyte side, UpLoLapack uplo, TransLapack trans, int m, int n, float* ap, float* tau, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorbdb")]
            public static extern int Sorbdb(MatrixLayout matrixLayout, TransLapack trans, sbyte signs, int m, int p, int q, float* x11, int ldx11, float* x12, int ldx12, float* x21, int ldx21, float* x22, int ldx22, float* theta, float* phi, float* taup1, float* taup2, float* tauq1, float* tauq2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorbdb_work")]
            public static extern int SorbdbWork(MatrixLayout matrixLayout, TransLapack trans, sbyte signs, int m, int p, int q, float* x11, int ldx11, float* x12, int ldx12, float* x21, int ldx21, float* x22, int ldx22, float* theta, float* phi, float* taup1, float* taup2, float* tauq1, float* tauq2, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorcsd")]
            public static extern int Sorcsd(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, TransLapack trans, sbyte signs, int m, int p, int q, float* x11, int ldx11, float* x12, int ldx12, float* x21, int ldx21, float* x22, int ldx22, float* theta, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* v2t, int ldv2t);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorcsd2by1")]
            public static extern int Sorcsd2by1(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, float* x11, int ldx11, float* x21, int ldx21, float* theta, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorcsd2by1_work")]
            public static extern int Sorcsd2by1Work(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, float* x11, int ldx11, float* x21, int ldx21, float* theta, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorcsd_work")]
            public static extern int SorcsdWork(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, TransLapack trans, sbyte signs, int m, int p, int q, float* x11, int ldx11, float* x12, int ldx12, float* x21, int ldx21, float* x22, int ldx22, float* theta, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* v2t, int ldv2t, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorgbr")]
            public static extern int Sorgbr(MatrixLayout matrixLayout, sbyte vect, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorgbr_work")]
            public static extern int SorgbrWork(MatrixLayout matrixLayout, sbyte vect, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorghr")]
            public static extern int Sorghr(MatrixLayout matrixLayout, int n, int ilo, int ihi, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorghr_work")]
            public static extern int SorghrWork(MatrixLayout matrixLayout, int n, int ilo, int ihi, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorglq")]
            public static extern int Sorglq(MatrixLayout matrixLayout, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorglq_work")]
            public static extern int SorglqWork(MatrixLayout matrixLayout, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorgql")]
            public static extern int Sorgql(MatrixLayout matrixLayout, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorgql_work")]
            public static extern int SorgqlWork(MatrixLayout matrixLayout, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorgqr")]
            public static extern int Sorgqr(MatrixLayout matrixLayout, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorgqr_work")]
            public static extern int SorgqrWork(MatrixLayout matrixLayout, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorgrq")]
            public static extern int Sorgrq(MatrixLayout matrixLayout, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorgrq_work")]
            public static extern int SorgrqWork(MatrixLayout matrixLayout, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorgtr")]
            public static extern int Sorgtr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorgtr_work")]
            public static extern int SorgtrWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormbr")]
            public static extern int Sormbr(MatrixLayout matrixLayout, sbyte vect, sbyte side, TransLapack trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormbr_work")]
            public static extern int SormbrWork(MatrixLayout matrixLayout, sbyte vect, sbyte side, TransLapack trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormhr")]
            public static extern int Sormhr(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int ilo, int ihi, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormhr_work")]
            public static extern int SormhrWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int ilo, int ihi, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormlq")]
            public static extern int Sormlq(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormlq_work")]
            public static extern int SormlqWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormql")]
            public static extern int Sormql(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormql_work")]
            public static extern int SormqlWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormqr")]
            public static extern int Sormqr(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormqr_work")]
            public static extern int SormqrWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormrq")]
            public static extern int Sormrq(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormrq_work")]
            public static extern int SormrqWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormrz")]
            public static extern int Sormrz(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int l, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormrz_work")]
            public static extern int SormrzWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int l, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormtr")]
            public static extern int Sormtr(MatrixLayout matrixLayout, sbyte side, UpLoLapack uplo, TransLapack trans, int m, int n, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormtr_work")]
            public static extern int SormtrWork(MatrixLayout matrixLayout, sbyte side, UpLoLapack uplo, TransLapack trans, int m, int n, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbcon")]
            public static extern int Spbcon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, float* ab, int ldab, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbcon_work")]
            public static extern int SpbconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, float* ab, int ldab, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbequ")]
            public static extern int Spbequ(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, float* ab, int ldab, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbequ_work")]
            public static extern int SpbequWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, float* ab, int ldab, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbrfs")]
            public static extern int Spbrfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, float* ab, int ldab, float* afb, int ldafb, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbrfs_work")]
            public static extern int SpbrfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, float* ab, int ldab, float* afb, int ldafb, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbstf")]
            public static extern int Spbstf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kb, float* bb, int ldbb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbstf_work")]
            public static extern int SpbstfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kb, float* bb, int ldbb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbsv")]
            public static extern int Spbsv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbsv_work")]
            public static extern int SpbsvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbsvx")]
            public static extern int Spbsvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int kd, int nrhs, float* ab, int ldab, float* afb, int ldafb, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbsvx_work")]
            public static extern int SpbsvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int kd, int nrhs, float* ab, int ldab, float* afb, int ldafb, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbtrf")]
            public static extern int Spbtrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, float* ab, int ldab);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbtrf_work")]
            public static extern int SpbtrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, float* ab, int ldab);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbtrs")]
            public static extern int Spbtrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbtrs_work")]
            public static extern int SpbtrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spftrf")]
            public static extern int Spftrf(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, float* a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spftrf_work")]
            public static extern int SpftrfWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, float* a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spftri")]
            public static extern int Spftri(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, float* a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spftri_work")]
            public static extern int SpftriWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, float* a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spftrs")]
            public static extern int Spftrs(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, int nrhs, float* a, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spftrs_work")]
            public static extern int SpftrsWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, int nrhs, float* a, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spocon")]
            public static extern int Spocon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spocon_work")]
            public static extern int SpoconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spoequ")]
            public static extern int Spoequ(MatrixLayout matrixLayout, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spoequ_work")]
            public static extern int SpoequWork(MatrixLayout matrixLayout, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spoequb")]
            public static extern int Spoequb(MatrixLayout matrixLayout, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spoequb_work")]
            public static extern int SpoequbWork(MatrixLayout matrixLayout, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sporfs")]
            public static extern int Sporfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sporfs_work")]
            public static extern int SporfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sporfsx")]
            public static extern int Sporfsx(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sporfsx_work")]
            public static extern int SporfsxWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sposv")]
            public static extern int Sposv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sposv_work")]
            public static extern int SposvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sposvx")]
            public static extern int Sposvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sposvx_work")]
            public static extern int SposvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sposvxx")]
            public static extern int Sposvxx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sposvxx_work")]
            public static extern int SposvxxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spotrf")]
            public static extern int Spotrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spotrf2")]
            public static extern int Spotrf2(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spotrf2_work")]
            public static extern int Spotrf2Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spotrf_work")]
            public static extern int SpotrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spotri")]
            public static extern int Spotri(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spotri_work")]
            public static extern int SpotriWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spotrs")]
            public static extern int Spotrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spotrs_work")]
            public static extern int SpotrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sppcon")]
            public static extern int Sppcon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* ap, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sppcon_work")]
            public static extern int SppconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* ap, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sppequ")]
            public static extern int Sppequ(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* ap, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sppequ_work")]
            public static extern int SppequWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* ap, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spprfs")]
            public static extern int Spprfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* ap, float* afp, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spprfs_work")]
            public static extern int SpprfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* ap, float* afp, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sppsv")]
            public static extern int Sppsv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sppsv_work")]
            public static extern int SppsvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sppsvx")]
            public static extern int Sppsvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, float* ap, float* afp, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sppsvx_work")]
            public static extern int SppsvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, float* ap, float* afp, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spptrf")]
            public static extern int Spptrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spptrf_work")]
            public static extern int SpptrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spptri")]
            public static extern int Spptri(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spptri_work")]
            public static extern int SpptriWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spptrs")]
            public static extern int Spptrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spptrs_work")]
            public static extern int SpptrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spstrf")]
            public static extern int Spstrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, int* piv, int* rank, float tol);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spstrf_work")]
            public static extern int SpstrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, int* piv, int* rank, float tol, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sptcon")]
            public static extern int Sptcon(int n, float* d, float* e, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sptcon_work")]
            public static extern int SptconWork(int n, float* d, float* e, float anorm, float* rcond, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spteqr")]
            public static extern int Spteqr(MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spteqr_work")]
            public static extern int SpteqrWork(MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sptrfs")]
            public static extern int Sptrfs(MatrixLayout matrixLayout, int n, int nrhs, float* d, float* e, float* df, float* ef, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sptrfs_work")]
            public static extern int SptrfsWork(MatrixLayout matrixLayout, int n, int nrhs, float* d, float* e, float* df, float* ef, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sptsv")]
            public static extern int Sptsv(MatrixLayout matrixLayout, int n, int nrhs, float* d, float* e, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sptsv_work")]
            public static extern int SptsvWork(MatrixLayout matrixLayout, int n, int nrhs, float* d, float* e, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sptsvx")]
            public static extern int Sptsvx(MatrixLayout matrixLayout, sbyte fact, int n, int nrhs, float* d, float* e, float* df, float* ef, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sptsvx_work")]
            public static extern int SptsvxWork(MatrixLayout matrixLayout, sbyte fact, int n, int nrhs, float* d, float* e, float* df, float* ef, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spttrf")]
            public static extern int Spttrf(int n, float* d, float* e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spttrf_work")]
            public static extern int SpttrfWork(int n, float* d, float* e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spttrs")]
            public static extern int Spttrs(MatrixLayout matrixLayout, int n, int nrhs, float* d, float* e, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spttrs_work")]
            public static extern int SpttrsWork(MatrixLayout matrixLayout, int n, int nrhs, float* d, float* e, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbev")]
            public static extern int Ssbev(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbev_work")]
            public static extern int SsbevWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbevd")]
            public static extern int Ssbevd(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbevd_work")]
            public static extern int SsbevdWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbevx")]
            public static extern int Ssbevx(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int kd, float* ab, int ldab, float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbevx_work")]
            public static extern int SsbevxWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int kd, float* ab, int ldab, float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbgst")]
            public static extern int Ssbgst(MatrixLayout matrixLayout, sbyte vect, UpLoLapack uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* x, int ldx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbgst_work")]
            public static extern int SsbgstWork(MatrixLayout matrixLayout, sbyte vect, UpLoLapack uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* x, int ldx, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbgv")]
            public static extern int Ssbgv(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbgv_work")]
            public static extern int SsbgvWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* w, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbgvd")]
            public static extern int Ssbgvd(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbgvd_work")]
            public static extern int SsbgvdWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbgvx")]
            public static extern int Ssbgvx(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbgvx_work")]
            public static extern int SsbgvxWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbtrd")]
            public static extern int Ssbtrd(MatrixLayout matrixLayout, sbyte vect, UpLoLapack uplo, int n, int kd, float* ab, int ldab, float* d, float* e, float* q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbtrd_work")]
            public static extern int SsbtrdWork(MatrixLayout matrixLayout, sbyte vect, UpLoLapack uplo, int n, int kd, float* ab, int ldab, float* d, float* e, float* q, int ldq, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssfrk")]
            public static extern int Ssfrk(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, TransLapack trans, int n, int k, float alpha, float* a, int lda, float beta, float* c);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssfrk_work")]
            public static extern int SsfrkWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, TransLapack trans, int n, int k, float alpha, float* a, int lda, float beta, float* c);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspcon")]
            public static extern int Sspcon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* ap, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspcon_work")]
            public static extern int SspconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* ap, int* ipiv, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspev")]
            public static extern int Sspev(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, float* ap, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspev_work")]
            public static extern int SspevWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, float* ap, float* w, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspevd")]
            public static extern int Sspevd(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, float* ap, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspevd_work")]
            public static extern int SspevdWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, float* ap, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspevx")]
            public static extern int Sspevx(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, float* ap, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspevx_work")]
            public static extern int SspevxWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, float* ap, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspgst")]
            public static extern int Sspgst(MatrixLayout matrixLayout, int itype, UpLoLapack uplo, int n, float* ap, float* bp);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspgst_work")]
            public static extern int SspgstWork(MatrixLayout matrixLayout, int itype, UpLoLapack uplo, int n, float* ap, float* bp);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspgv")]
            public static extern int Sspgv(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, float* ap, float* bp, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspgv_work")]
            public static extern int SspgvWork(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, float* ap, float* bp, float* w, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspgvd")]
            public static extern int Sspgvd(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, float* ap, float* bp, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspgvd_work")]
            public static extern int SspgvdWork(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, float* ap, float* bp, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspgvx")]
            public static extern int Sspgvx(MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, UpLoLapack uplo, int n, float* ap, float* bp, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspgvx_work")]
            public static extern int SspgvxWork(MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, UpLoLapack uplo, int n, float* ap, float* bp, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssprfs")]
            public static extern int Ssprfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* ap, float* afp, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssprfs_work")]
            public static extern int SsprfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* ap, float* afp, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspsv")]
            public static extern int Sspsv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* ap, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspsv_work")]
            public static extern int SspsvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* ap, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspsvx")]
            public static extern int Sspsvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, float* ap, float* afp, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspsvx_work")]
            public static extern int SspsvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, float* ap, float* afp, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssptrd")]
            public static extern int Ssptrd(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* ap, float* d, float* e, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssptrd_work")]
            public static extern int SsptrdWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* ap, float* d, float* e, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssptrf")]
            public static extern int Ssptrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssptrf_work")]
            public static extern int SsptrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssptri")]
            public static extern int Ssptri(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssptri_work")]
            public static extern int SsptriWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* ap, int* ipiv, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssptrs")]
            public static extern int Ssptrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* ap, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssptrs_work")]
            public static extern int SsptrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* ap, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstebz")]
            public static extern int Sstebz(sbyte range, sbyte order, int n, float vl, float vu, int il, int iu, float abstol, float* d, float* e, int* m, int* nsplit, float* w, int* iblock, int* isplit);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstebz_work")]
            public static extern int SstebzWork(sbyte range, sbyte order, int n, float vl, float vu, int il, int iu, float abstol, float* d, float* e, int* m, int* nsplit, float* w, int* iblock, int* isplit, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstedc")]
            public static extern int Sstedc(MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstedc_work")]
            public static extern int SstedcWork(MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstegr")]
            public static extern int Sstegr(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstegr_work")]
            public static extern int SstegrWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstein")]
            public static extern int Sstein(MatrixLayout matrixLayout, int n, float* d, float* e, int m, float* w, int* iblock, int* isplit, float* z, int ldz, int* ifailv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstein_work")]
            public static extern int SsteinWork(MatrixLayout matrixLayout, int n, float* d, float* e, int m, float* w, int* iblock, int* isplit, float* z, int ldz, float* work, int* iwork, int* ifailv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstemr")]
            public static extern int Sstemr(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* m, float* w, float* z, int ldz, int nzc, int* isuppz, int* tryrac);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstemr_work")]
            public static extern int SstemrWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* m, float* w, float* z, int ldz, int nzc, int* isuppz, int* tryrac, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssteqr")]
            public static extern int Ssteqr(MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssteqr_work")]
            public static extern int SsteqrWork(MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssterf")]
            public static extern int Ssterf(int n, float* d, float* e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssterf_work")]
            public static extern int SsterfWork(int n, float* d, float* e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstev")]
            public static extern int Sstev(MatrixLayout matrixLayout, sbyte jobz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstev_work")]
            public static extern int SstevWork(MatrixLayout matrixLayout, sbyte jobz, int n, float* d, float* e, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstevd")]
            public static extern int Sstevd(MatrixLayout matrixLayout, sbyte jobz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstevd_work")]
            public static extern int SstevdWork(MatrixLayout matrixLayout, sbyte jobz, int n, float* d, float* e, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstevr")]
            public static extern int Sstevr(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstevr_work")]
            public static extern int SstevrWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstevx")]
            public static extern int Sstevx(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstevx_work")]
            public static extern int SstevxWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssycon")]
            public static extern int Ssycon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssycon_work")]
            public static extern int SsyconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, int* ipiv, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyconv")]
            public static extern int Ssyconv(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte way, int n, float* a, int lda, int* ipiv, float* e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyconv_work")]
            public static extern int SsyconvWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte way, int n, float* a, int lda, int* ipiv, float* e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyequb")]
            public static extern int Ssyequb(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyequb_work")]
            public static extern int SsyequbWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, float* s, float* scond, float* amax, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyev")]
            public static extern int Ssyev(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, float* a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyev_work")]
            public static extern int SsyevWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, float* a, int lda, float* w, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevd")]
            public static extern int Ssyevd(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, float* a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevd_work")]
            public static extern int SsyevdWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, float* a, int lda, float* w, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevr")]
            public static extern int Ssyevr(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevr_work")]
            public static extern int SsyevrWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevx")]
            public static extern int Ssyevx(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevx_work")]
            public static extern int SsyevxWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssygst")]
            public static extern int Ssygst(MatrixLayout matrixLayout, int itype, UpLoLapack uplo, int n, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssygst_work")]
            public static extern int SsygstWork(MatrixLayout matrixLayout, int itype, UpLoLapack uplo, int n, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssygv")]
            public static extern int Ssygv(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, float* a, int lda, float* b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssygv_work")]
            public static extern int SsygvWork(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, float* a, int lda, float* b, int ldb, float* w, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssygvd")]
            public static extern int Ssygvd(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, float* a, int lda, float* b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssygvd_work")]
            public static extern int SsygvdWork(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, float* a, int lda, float* b, int ldb, float* w, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssygvx")]
            public static extern int Ssygvx(MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, UpLoLapack uplo, int n, float* a, int lda, float* b, int ldb, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssygvx_work")]
            public static extern int SsygvxWork(MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, UpLoLapack uplo, int n, float* a, int lda, float* b, int ldb, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyrfs")]
            public static extern int Ssyrfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyrfs_work")]
            public static extern int SsyrfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyrfsx")]
            public static extern int Ssyrfsx(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyrfsx_work")]
            public static extern int SsyrfsxWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysv")]
            public static extern int Ssysv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysv_rook")]
            public static extern int SsysvRook(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysv_rook_work")]
            public static extern int SsysvRookWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysv_work")]
            public static extern int SsysvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysvx")]
            public static extern int Ssysvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysvx_work")]
            public static extern int SsysvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysvxx")]
            public static extern int Ssysvxx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysvxx_work")]
            public static extern int SsysvxxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyswapr")]
            public static extern int Ssyswapr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyswapr_work")]
            public static extern int SsyswaprWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrd")]
            public static extern int Ssytrd(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, float* d, float* e, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrd_work")]
            public static extern int SsytrdWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, float* d, float* e, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrf")]
            public static extern int Ssytrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrf_rook")]
            public static extern int SsytrfRook(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrf_rook_work")]
            public static extern int SsytrfRookWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrf_work")]
            public static extern int SsytrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytri")]
            public static extern int Ssytri(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytri2")]
            public static extern int Ssytri2(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytri2_work")]
            public static extern int Ssytri2Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytri2x")]
            public static extern int Ssytri2x(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytri2x_work")]
            public static extern int Ssytri2xWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, int* ipiv, float* work, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytri_work")]
            public static extern int SsytriWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, int* ipiv, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs")]
            public static extern int Ssytrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs2")]
            public static extern int Ssytrs2(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs2_work")]
            public static extern int Ssytrs2Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs_rook")]
            public static extern int SsytrsRook(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs_rook_work")]
            public static extern int SsytrsRookWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs_work")]
            public static extern int SsytrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stbcon")]
            public static extern int Stbcon(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, int kd, float* ab, int ldab, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stbcon_work")]
            public static extern int StbconWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, int kd, float* ab, int ldab, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stbrfs")]
            public static extern int Stbrfs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stbrfs_work")]
            public static extern int StbrfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stbtrs")]
            public static extern int Stbtrs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stbtrs_work")]
            public static extern int StbtrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stfsm")]
            public static extern int Stfsm(MatrixLayout matrixLayout, sbyte transr, sbyte side, UpLoLapack uplo, TransLapack trans, sbyte diag, int m, int n, float alpha, float* a, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stfsm_work")]
            public static extern int StfsmWork(MatrixLayout matrixLayout, sbyte transr, sbyte side, UpLoLapack uplo, TransLapack trans, sbyte diag, int m, int n, float alpha, float* a, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stftri")]
            public static extern int Stftri(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, sbyte diag, int n, float* a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stftri_work")]
            public static extern int StftriWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, sbyte diag, int n, float* a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stfttp")]
            public static extern int Stfttp(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, float* arf, float* ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stfttp_work")]
            public static extern int StfttpWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, float* arf, float* ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stfttr")]
            public static extern int Stfttr(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, float* arf, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stfttr_work")]
            public static extern int StfttrWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, float* arf, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgevc")]
            public static extern int Stgevc(MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, float* s, int lds, float* p, int ldp, float* vl, int ldvl, float* vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgevc_work")]
            public static extern int StgevcWork(MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, float* s, int lds, float* p, int ldp, float* vl, int ldvl, float* vr, int ldvr, int mm, int* m, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgexc")]
            public static extern int Stgexc(MatrixLayout matrixLayout, int wantq, int wantz, int n, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz, int* ifst, int* ilst);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgexc_work")]
            public static extern int StgexcWork(MatrixLayout matrixLayout, int wantq, int wantz, int n, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz, int* ifst, int* ilst, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgsen")]
            public static extern int Stgsen(MatrixLayout matrixLayout, int ijob, int wantq, int wantz, int* select, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* q, int ldq, float* z, int ldz, int* m, float* pl, float* pr, float* dif);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgsen_work")]
            public static extern int StgsenWork(MatrixLayout matrixLayout, int ijob, int wantq, int wantz, int* select, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* q, int ldq, float* z, int ldz, int* m, float* pl, float* pr, float* dif, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgsja")]
            public static extern int Stgsja(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, float* a, int lda, float* b, int ldb, float tola, float tolb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* ncycle);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgsja_work")]
            public static extern int StgsjaWork(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, float* a, int lda, float* b, int ldb, float tola, float tolb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, float* work, int* ncycle);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgsna")]
            public static extern int Stgsna(MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, float* a, int lda, float* b, int ldb, float* vl, int ldvl, float* vr, int ldvr, float* s, float* dif, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgsna_work")]
            public static extern int StgsnaWork(MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, float* a, int lda, float* b, int ldb, float* vl, int ldvl, float* vr, int ldvr, float* s, float* dif, int mm, int* m, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgsyl")]
            public static extern int Stgsyl(MatrixLayout matrixLayout, TransLapack trans, int ijob, int m, int n, float* a, int lda, float* b, int ldb, float* c, int ldc, float* d, int ldd, float* e, int lde, float* f, int ldf, float* scale, float* dif);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgsyl_work")]
            public static extern int StgsylWork(MatrixLayout matrixLayout, TransLapack trans, int ijob, int m, int n, float* a, int lda, float* b, int ldb, float* c, int ldc, float* d, int ldd, float* e, int lde, float* f, int ldf, float* scale, float* dif, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpcon")]
            public static extern int Stpcon(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, float* ap, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpcon_work")]
            public static extern int StpconWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, float* ap, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpmqrt")]
            public static extern int Stpmqrt(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int l, int nb, float* v, int ldv, float* t, int ldt, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpmqrt_work")]
            public static extern int StpmqrtWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int l, int nb, float* v, int ldv, float* t, int ldt, float* a, int lda, float* b, int ldb, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpqrt")]
            public static extern int Stpqrt(MatrixLayout matrixLayout, int m, int n, int l, int nb, float* a, int lda, float* b, int ldb, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpqrt2")]
            public static extern int Stpqrt2(MatrixLayout matrixLayout, int m, int n, int l, float* a, int lda, float* b, int ldb, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpqrt2_work")]
            public static extern int Stpqrt2Work(MatrixLayout matrixLayout, int m, int n, int l, float* a, int lda, float* b, int ldb, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpqrt_work")]
            public static extern int StpqrtWork(MatrixLayout matrixLayout, int m, int n, int l, int nb, float* a, int lda, float* b, int ldb, float* t, int ldt, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stprfb")]
            public static extern int Stprfb(MatrixLayout matrixLayout, sbyte side, TransLapack trans, sbyte direct, sbyte storev, int m, int n, int k, int l, float* v, int ldv, float* t, int ldt, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stprfb_work")]
            public static extern int StprfbWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, sbyte direct, sbyte storev, int m, int n, int k, int l, float* v, int ldv, float* t, int ldt, float* a, int lda, float* b, int ldb, float* work, int ldwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stprfs")]
            public static extern int Stprfs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, float* ap, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stprfs_work")]
            public static extern int StprfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, float* ap, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stptri")]
            public static extern int Stptri(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte diag, int n, float* ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stptri_work")]
            public static extern int StptriWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte diag, int n, float* ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stptrs")]
            public static extern int Stptrs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stptrs_work")]
            public static extern int StptrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpttf")]
            public static extern int Stpttf(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, float* ap, float* arf);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpttf_work")]
            public static extern int StpttfWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, float* ap, float* arf);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpttr")]
            public static extern int Stpttr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* ap, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpttr_work")]
            public static extern int StpttrWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* ap, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strcon")]
            public static extern int Strcon(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, float* a, int lda, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strcon_work")]
            public static extern int StrconWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, float* a, int lda, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strevc")]
            public static extern int Strevc(MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, float* t, int ldt, float* vl, int ldvl, float* vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strevc_work")]
            public static extern int StrevcWork(MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, float* t, int ldt, float* vl, int ldvl, float* vr, int ldvr, int mm, int* m, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strexc")]
            public static extern int Strexc(MatrixLayout matrixLayout, sbyte compq, int n, float* t, int ldt, float* q, int ldq, int* ifst, int* ilst);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strexc_work")]
            public static extern int StrexcWork(MatrixLayout matrixLayout, sbyte compq, int n, float* t, int ldt, float* q, int ldq, int* ifst, int* ilst, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strrfs")]
            public static extern int Strrfs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, float* a, int lda, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strrfs_work")]
            public static extern int StrrfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, float* a, int lda, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strsen")]
            public static extern int Strsen(MatrixLayout matrixLayout, sbyte job, sbyte compq, int* select, int n, float* t, int ldt, float* q, int ldq, float* wr, float* wi, int* m, float* s, float* sep);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strsen_work")]
            public static extern int StrsenWork(MatrixLayout matrixLayout, sbyte job, sbyte compq, int* select, int n, float* t, int ldt, float* q, int ldq, float* wr, float* wi, int* m, float* s, float* sep, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strsna")]
            public static extern int Strsna(MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, float* t, int ldt, float* vl, int ldvl, float* vr, int ldvr, float* s, float* sep, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strsna_work")]
            public static extern int StrsnaWork(MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, float* t, int ldt, float* vl, int ldvl, float* vr, int ldvr, float* s, float* sep, int mm, int* m, float* work, int ldwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strsyl")]
            public static extern int Strsyl(MatrixLayout matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, float* a, int lda, float* b, int ldb, float* c, int ldc, float* scale);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strsyl_work")]
            public static extern int StrsylWork(MatrixLayout matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, float* a, int lda, float* b, int ldb, float* c, int ldc, float* scale);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strtri")]
            public static extern int Strtri(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte diag, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strtri_work")]
            public static extern int StrtriWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte diag, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strtrs")]
            public static extern int Strtrs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strtrs_work")]
            public static extern int StrtrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strttf")]
            public static extern int Strttf(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, float* a, int lda, float* arf);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strttf_work")]
            public static extern int StrttfWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, float* a, int lda, float* arf);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strttp")]
            public static extern int Strttp(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, float* ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strttp_work")]
            public static extern int StrttpWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, float* ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stzrzf")]
            public static extern int Stzrzf(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stzrzf_work")]
            public static extern int StzrzfWork(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zbbcsd")]
            public static extern int Zbbcsd(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, TransLapack trans, int m, int p, int q, double* theta, double* phi, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t, IntPtr v2t, int ldv2t, double* b11d, double* b11e, double* b12d, double* b12e, double* b21d, double* b21e, double* b22d, double* b22e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zbbcsd_work")]
            public static extern int ZbbcsdWork(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, TransLapack trans, int m, int p, int q, double* theta, double* phi, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t, IntPtr v2t, int ldv2t, double* b11d, double* b11e, double* b12d, double* b12e, double* b21d, double* b21e, double* b22d, double* b22e, double* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zbdsqr")]
            public static extern int Zbdsqr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int ncvt, int nru, int ncc, double* d, double* e, IntPtr vt, int ldvt, IntPtr u, int ldu, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zbdsqr_work")]
            public static extern int ZbdsqrWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int ncvt, int nru, int ncc, double* d, double* e, IntPtr vt, int ldvt, IntPtr u, int ldu, IntPtr c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zcgesv")]
            public static extern int Zcgesv(MatrixLayout matrixLayout, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, int* iter);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zcgesv_work")]
            public static extern int ZcgesvWork(MatrixLayout matrixLayout, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, IntPtr work, IntPtr swork, double* rwork, int* iter);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zcposv")]
            public static extern int Zcposv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, IntPtr x, int ldx, int* iter);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zcposv_work")]
            public static extern int ZcposvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, IntPtr x, int ldx, IntPtr work, IntPtr swork, double* rwork, int* iter);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbbrd")]
            public static extern int Zgbbrd(MatrixLayout matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, IntPtr ab, int ldab, double* d, double* e, IntPtr q, int ldq, IntPtr pt, int ldpt, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbbrd_work")]
            public static extern int ZgbbrdWork(MatrixLayout matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, IntPtr ab, int ldab, double* d, double* e, IntPtr q, int ldq, IntPtr pt, int ldpt, IntPtr c, int ldc, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbcon")]
            public static extern int Zgbcon(MatrixLayout matrixLayout, sbyte norm, int n, int kl, int ku, IntPtr ab, int ldab, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbcon_work")]
            public static extern int ZgbconWork(MatrixLayout matrixLayout, sbyte norm, int n, int kl, int ku, IntPtr ab, int ldab, int* ipiv, double anorm, double* rcond, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbequ")]
            public static extern int Zgbequ(MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbequ_work")]
            public static extern int ZgbequWork(MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbequb")]
            public static extern int Zgbequb(MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbequb_work")]
            public static extern int ZgbequbWork(MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbrfs")]
            public static extern int Zgbrfs(MatrixLayout matrixLayout, TransLapack trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbrfs_work")]
            public static extern int ZgbrfsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbrfsx")]
            public static extern int Zgbrfsx(MatrixLayout matrixLayout, TransLapack trans, sbyte equed, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbrfsx_work")]
            public static extern int ZgbrfsxWork(MatrixLayout matrixLayout, TransLapack trans, sbyte equed, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbsv")]
            public static extern int Zgbsv(MatrixLayout matrixLayout, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbsv_work")]
            public static extern int ZgbsvWork(MatrixLayout matrixLayout, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbsvx")]
            public static extern int Zgbsvx(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, double* rpivot);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbsvx_work")]
            public static extern int ZgbsvxWork(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbsvxx")]
            public static extern int Zgbsvxx(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbsvxx_work")]
            public static extern int ZgbsvxxWork(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbtrf")]
            public static extern int Zgbtrf(MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbtrf_work")]
            public static extern int ZgbtrfWork(MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbtrs")]
            public static extern int Zgbtrs(MatrixLayout matrixLayout, TransLapack trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbtrs_work")]
            public static extern int ZgbtrsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgebak")]
            public static extern int Zgebak(MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* scale, int m, IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgebak_work")]
            public static extern int ZgebakWork(MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* scale, int m, IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgebal")]
            public static extern int Zgebal(MatrixLayout matrixLayout, sbyte job, int n, IntPtr a, int lda, int* ilo, int* ihi, double* scale);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgebal_work")]
            public static extern int ZgebalWork(MatrixLayout matrixLayout, sbyte job, int n, IntPtr a, int lda, int* ilo, int* ihi, double* scale);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgebrd")]
            public static extern int Zgebrd(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, double* d, double* e, IntPtr tauq, IntPtr taup);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgebrd_work")]
            public static extern int ZgebrdWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, double* d, double* e, IntPtr tauq, IntPtr taup, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgecon")]
            public static extern int Zgecon(MatrixLayout matrixLayout, sbyte norm, int n, IntPtr a, int lda, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgecon_work")]
            public static extern int ZgeconWork(MatrixLayout matrixLayout, sbyte norm, int n, IntPtr a, int lda, double anorm, double* rcond, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeequ")]
            public static extern int Zgeequ(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeequ_work")]
            public static extern int ZgeequWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeequb")]
            public static extern int Zgeequb(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeequb_work")]
            public static extern int ZgeequbWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgees")]
            public static extern int Zgees(MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, int n, IntPtr a, int lda, int* sdim, IntPtr w, IntPtr vs, int ldvs);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgees_work")]
            public static extern int ZgeesWork(MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, int n, IntPtr a, int lda, int* sdim, IntPtr w, IntPtr vs, int ldvs, IntPtr work, int lwork, double* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeesx")]
            public static extern int Zgeesx(MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, sbyte sense, int n, IntPtr a, int lda, int* sdim, IntPtr w, IntPtr vs, int ldvs, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeesx_work")]
            public static extern int ZgeesxWork(MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, sbyte sense, int n, IntPtr a, int lda, int* sdim, IntPtr w, IntPtr vs, int ldvs, double* rconde, double* rcondv, IntPtr work, int lwork, double* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeev")]
            public static extern int Zgeev(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeev_work")]
            public static extern int ZgeevWork(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeevx")]
            public static extern int Zgeevx(MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, IntPtr a, int lda, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int* ilo, int* ihi, double* scale, double* abnrm, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeevx_work")]
            public static extern int ZgeevxWork(MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, IntPtr a, int lda, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int* ilo, int* ihi, double* scale, double* abnrm, double* rconde, double* rcondv, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgehrd")]
            public static extern int Zgehrd(MatrixLayout matrixLayout, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgehrd_work")]
            public static extern int ZgehrdWork(MatrixLayout matrixLayout, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgejsv")]
            public static extern int Zgejsv(MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, IntPtr a, int lda, double* sva, IntPtr u, int ldu, IntPtr v, int ldv, double* stat, int* istat);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgejsv_work")]
            public static extern int ZgejsvWork(MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, IntPtr a, int lda, double* sva, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr cwork, int lwork, double* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelq2")]
            public static extern int Zgelq2(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelq2_work")]
            public static extern int Zgelq2Work(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelqf")]
            public static extern int Zgelqf(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelqf_work")]
            public static extern int ZgelqfWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgels")]
            public static extern int Zgels(MatrixLayout matrixLayout, TransLapack trans, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgels_work")]
            public static extern int ZgelsWork(MatrixLayout matrixLayout, TransLapack trans, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelsd")]
            public static extern int Zgelsd(MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, double* s, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelsd_work")]
            public static extern int ZgelsdWork(MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, double* s, double rcond, int* rank, IntPtr work, int lwork, double* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelss")]
            public static extern int Zgelss(MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, double* s, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelss_work")]
            public static extern int ZgelssWork(MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, double* s, double rcond, int* rank, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelsy")]
            public static extern int Zgelsy(MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, int* jpvt, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelsy_work")]
            public static extern int ZgelsyWork(MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, int* jpvt, double rcond, int* rank, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgemqrt")]
            public static extern int Zgemqrt(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int nb, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgemqrt_work")]
            public static extern int ZgemqrtWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int nb, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr c, int ldc, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqlf")]
            public static extern int Zgeqlf(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqlf_work")]
            public static extern int ZgeqlfWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqp3")]
            public static extern int Zgeqp3(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* jpvt, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqp3_work")]
            public static extern int Zgeqp3Work(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* jpvt, IntPtr tau, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqpf")]
            public static extern int Zgeqpf(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* jpvt, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqpf_work")]
            public static extern int ZgeqpfWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* jpvt, IntPtr tau, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqr2")]
            public static extern int Zgeqr2(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqr2_work")]
            public static extern int Zgeqr2Work(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqrf")]
            public static extern int Zgeqrf(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqrf_work")]
            public static extern int ZgeqrfWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqrfp")]
            public static extern int Zgeqrfp(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqrfp_work")]
            public static extern int ZgeqrfpWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqrt")]
            public static extern int Zgeqrt(MatrixLayout matrixLayout, int m, int n, int nb, IntPtr a, int lda, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqrt2")]
            public static extern int Zgeqrt2(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqrt2_work")]
            public static extern int Zgeqrt2Work(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqrt3")]
            public static extern int Zgeqrt3(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqrt3_work")]
            public static extern int Zgeqrt3Work(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqrt_work")]
            public static extern int ZgeqrtWork(MatrixLayout matrixLayout, int m, int n, int nb, IntPtr a, int lda, IntPtr t, int ldt, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgerfs")]
            public static extern int Zgerfs(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgerfs_work")]
            public static extern int ZgerfsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgerfsx")]
            public static extern int Zgerfsx(MatrixLayout matrixLayout, TransLapack trans, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgerfsx_work")]
            public static extern int ZgerfsxWork(MatrixLayout matrixLayout, TransLapack trans, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgerqf")]
            public static extern int Zgerqf(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgerqf_work")]
            public static extern int ZgerqfWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesdd")]
            public static extern int Zgesdd(MatrixLayout matrixLayout, sbyte jobz, int m, int n, IntPtr a, int lda, double* s, IntPtr u, int ldu, IntPtr vt, int ldvt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesdd_work")]
            public static extern int ZgesddWork(MatrixLayout matrixLayout, sbyte jobz, int m, int n, IntPtr a, int lda, double* s, IntPtr u, int ldu, IntPtr vt, int ldvt, IntPtr work, int lwork, double* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesv")]
            public static extern int Zgesv(MatrixLayout matrixLayout, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesv_work")]
            public static extern int ZgesvWork(MatrixLayout matrixLayout, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvd")]
            public static extern int Zgesvd(MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, IntPtr a, int lda, double* s, IntPtr u, int ldu, IntPtr vt, int ldvt, double* superb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvd_work")]
            public static extern int ZgesvdWork(MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, IntPtr a, int lda, double* s, IntPtr u, int ldu, IntPtr vt, int ldvt, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvdx")]
            public static extern int Zgesvdx(MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, IntPtr a, int lda, double vl, double vu, int il, int iu, int* ns, double* s, IntPtr u, int ldu, IntPtr vt, int ldvt, int* superb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvdx_work")]
            public static extern int ZgesvdxWork(MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, IntPtr a, int lda, double vl, double vu, int il, int iu, int* ns, double* s, IntPtr u, int ldu, IntPtr vt, int ldvt, IntPtr work, int lwork, double* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvj")]
            public static extern int Zgesvj(MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, IntPtr a, int lda, double* sva, int mv, IntPtr v, int ldv, double* stat);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvj_work")]
            public static extern int ZgesvjWork(MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, IntPtr a, int lda, double* sva, int mv, IntPtr v, int ldv, IntPtr cwork, int lwork, double* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvx")]
            public static extern int Zgesvx(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, double* rpivot);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvx_work")]
            public static extern int ZgesvxWork(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvxx")]
            public static extern int Zgesvxx(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvxx_work")]
            public static extern int ZgesvxxWork(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetf2")]
            public static extern int Zgetf2(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetf2_work")]
            public static extern int Zgetf2Work(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetrf")]
            public static extern int Zgetrf(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetrf2")]
            public static extern int Zgetrf2(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetrf2_work")]
            public static extern int Zgetrf2Work(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetrf_work")]
            public static extern int ZgetrfWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetri")]
            public static extern int Zgetri(MatrixLayout matrixLayout, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetri_work")]
            public static extern int ZgetriWork(MatrixLayout matrixLayout, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetrs")]
            public static extern int Zgetrs(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetrs_work")]
            public static extern int ZgetrsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggbak")]
            public static extern int Zggbak(MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* lscale, double* rscale, int m, IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggbak_work")]
            public static extern int ZggbakWork(MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* lscale, double* rscale, int m, IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggbal")]
            public static extern int Zggbal(MatrixLayout matrixLayout, sbyte job, int n, IntPtr a, int lda, IntPtr b, int ldb, int* ilo, int* ihi, double* lscale, double* rscale);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggbal_work")]
            public static extern int ZggbalWork(MatrixLayout matrixLayout, sbyte job, int n, IntPtr a, int lda, IntPtr b, int ldb, int* ilo, int* ihi, double* lscale, double* rscale, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgges")]
            public static extern int Zgges(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgges3")]
            public static extern int Zgges3(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgges3_work")]
            public static extern int Zgges3Work(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr, IntPtr work, int lwork, double* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgges_work")]
            public static extern int ZggesWork(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr, IntPtr work, int lwork, double* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggesx")]
            public static extern int Zggesx(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, sbyte sense, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggesx_work")]
            public static extern int ZggesxWork(MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, sbyte sense, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr, double* rconde, double* rcondv, IntPtr work, int lwork, double* rwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggev")]
            public static extern int Zggev(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggev3")]
            public static extern int Zggev3(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggev3_work")]
            public static extern int Zggev3Work(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggev_work")]
            public static extern int ZggevWork(MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggevx")]
            public static extern int Zggevx(MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int* ilo, int* ihi, double* lscale, double* rscale, double* abnrm, double* bbnrm, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggevx_work")]
            public static extern int ZggevxWork(MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int* ilo, int* ihi, double* lscale, double* rscale, double* abnrm, double* bbnrm, double* rconde, double* rcondv, IntPtr work, int lwork, double* rwork, int* iwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggglm")]
            public static extern int Zggglm(MatrixLayout matrixLayout, int n, int m, int p, IntPtr a, int lda, IntPtr b, int ldb, IntPtr d, IntPtr x, IntPtr y);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggglm_work")]
            public static extern int ZggglmWork(MatrixLayout matrixLayout, int n, int m, int p, IntPtr a, int lda, IntPtr b, int ldb, IntPtr d, IntPtr x, IntPtr y, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgghd3")]
            public static extern int Zgghd3(MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgghd3_work")]
            public static extern int Zgghd3Work(MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgghrd")]
            public static extern int Zgghrd(MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgghrd_work")]
            public static extern int ZgghrdWork(MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgglse")]
            public static extern int Zgglse(MatrixLayout matrixLayout, int m, int n, int p, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, IntPtr d, IntPtr x);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgglse_work")]
            public static extern int ZgglseWork(MatrixLayout matrixLayout, int m, int n, int p, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, IntPtr d, IntPtr x, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggqrf")]
            public static extern int Zggqrf(MatrixLayout matrixLayout, int n, int m, int p, IntPtr a, int lda, IntPtr taua, IntPtr b, int ldb, IntPtr taub);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggqrf_work")]
            public static extern int ZggqrfWork(MatrixLayout matrixLayout, int n, int m, int p, IntPtr a, int lda, IntPtr taua, IntPtr b, int ldb, IntPtr taub, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggrqf")]
            public static extern int Zggrqf(MatrixLayout matrixLayout, int m, int p, int n, IntPtr a, int lda, IntPtr taua, IntPtr b, int ldb, IntPtr taub);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggrqf_work")]
            public static extern int ZggrqfWork(MatrixLayout matrixLayout, int m, int p, int n, IntPtr a, int lda, IntPtr taua, IntPtr b, int ldb, IntPtr taub, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggsvd")]
            public static extern int Zggsvd(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, IntPtr a, int lda, IntPtr b, int ldb, double* alpha, double* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggsvd3")]
            public static extern int Zggsvd3(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, IntPtr a, int lda, IntPtr b, int ldb, double* alpha, double* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggsvd3_work")]
            public static extern int Zggsvd3Work(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, IntPtr a, int lda, IntPtr b, int ldb, double* alpha, double* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, IntPtr work, int lwork, double* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggsvd_work")]
            public static extern int ZggsvdWork(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, IntPtr a, int lda, IntPtr b, int ldb, double* alpha, double* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, IntPtr work, double* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggsvp")]
            public static extern int Zggsvp(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, IntPtr a, int lda, IntPtr b, int ldb, double tola, double tolb, int* k, int* l, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggsvp3")]
            public static extern int Zggsvp3(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, IntPtr a, int lda, IntPtr b, int ldb, double tola, double tolb, int* k, int* l, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggsvp3_work")]
            public static extern int Zggsvp3Work(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, IntPtr a, int lda, IntPtr b, int ldb, double tola, double tolb, int* k, int* l, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, int* iwork, double* rwork, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggsvp_work")]
            public static extern int ZggsvpWork(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, IntPtr a, int lda, IntPtr b, int ldb, double tola, double tolb, int* k, int* l, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, int* iwork, double* rwork, IntPtr tau, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgtcon")]
            public static extern int Zgtcon(sbyte norm, int n, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgtcon_work")]
            public static extern int ZgtconWork(sbyte norm, int n, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv, double anorm, double* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgtrfs")]
            public static extern int Zgtrfs(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr dlf, IntPtr df, IntPtr duf, IntPtr du2, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgtrfs_work")]
            public static extern int ZgtrfsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr dlf, IntPtr df, IntPtr duf, IntPtr du2, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgtsv")]
            public static extern int Zgtsv(MatrixLayout matrixLayout, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgtsv_work")]
            public static extern int ZgtsvWork(MatrixLayout matrixLayout, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgtsvx")]
            public static extern int Zgtsvx(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr dlf, IntPtr df, IntPtr duf, IntPtr du2, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgtsvx_work")]
            public static extern int ZgtsvxWork(MatrixLayout matrixLayout, sbyte fact, TransLapack trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr dlf, IntPtr df, IntPtr duf, IntPtr du2, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgttrf")]
            public static extern int Zgttrf(int n, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgttrf_work")]
            public static extern int ZgttrfWork(int n, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgttrs")]
            public static extern int Zgttrs(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgttrs_work")]
            public static extern int ZgttrsWork(MatrixLayout matrixLayout, TransLapack trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbev")]
            public static extern int Zhbev(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, double* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbev_work")]
            public static extern int ZhbevWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, double* w, IntPtr z, int ldz, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbevd")]
            public static extern int Zhbevd(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, double* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbevd_work")]
            public static extern int ZhbevdWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, double* w, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbevx")]
            public static extern int Zhbevx(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, IntPtr q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbevx_work")]
            public static extern int ZhbevxWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, IntPtr q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, IntPtr work, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbgst")]
            public static extern int Zhbgst(MatrixLayout matrixLayout, sbyte vect, UpLoLapack uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, IntPtr x, int ldx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbgst_work")]
            public static extern int ZhbgstWork(MatrixLayout matrixLayout, sbyte vect, UpLoLapack uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, IntPtr x, int ldx, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbgv")]
            public static extern int Zhbgv(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, double* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbgv_work")]
            public static extern int ZhbgvWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, double* w, IntPtr z, int ldz, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbgvd")]
            public static extern int Zhbgvd(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, double* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbgvd_work")]
            public static extern int ZhbgvdWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, double* w, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbgvx")]
            public static extern int Zhbgvx(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, IntPtr q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbgvx_work")]
            public static extern int ZhbgvxWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, IntPtr q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, IntPtr work, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbtrd")]
            public static extern int Zhbtrd(MatrixLayout matrixLayout, sbyte vect, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, double* d, double* e, IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbtrd_work")]
            public static extern int ZhbtrdWork(MatrixLayout matrixLayout, sbyte vect, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, double* d, double* e, IntPtr q, int ldq, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhecon")]
            public static extern int Zhecon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhecon_work")]
            public static extern int ZheconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, double anorm, double* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheequb")]
            public static extern int Zheequb(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheequb_work")]
            public static extern int ZheequbWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, double* s, double* scond, double* amax, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheev")]
            public static extern int Zheev(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheev_work")]
            public static extern int ZheevWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, double* w, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevd")]
            public static extern int Zheevd(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevd_work")]
            public static extern int ZheevdWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, double* w, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevr")]
            public static extern int Zheevr(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevr_work")]
            public static extern int ZheevrWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* isuppz, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevx")]
            public static extern int Zheevx(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevx_work")]
            public static extern int ZheevxWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhegst")]
            public static extern int Zhegst(MatrixLayout matrixLayout, int itype, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhegst_work")]
            public static extern int ZhegstWork(MatrixLayout matrixLayout, int itype, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhegv")]
            public static extern int Zhegv(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhegv_work")]
            public static extern int ZhegvWork(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, double* w, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhegvd")]
            public static extern int Zhegvd(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhegvd_work")]
            public static extern int ZhegvdWork(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, double* w, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhegvx")]
            public static extern int Zhegvx(MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhegvx_work")]
            public static extern int ZhegvxWork(MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zherfs")]
            public static extern int Zherfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zherfs_work")]
            public static extern int ZherfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zherfsx")]
            public static extern int Zherfsx(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zherfsx_work")]
            public static extern int ZherfsxWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesv")]
            public static extern int Zhesv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesv_work")]
            public static extern int ZhesvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesvx")]
            public static extern int Zhesvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesvx_work")]
            public static extern int ZhesvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesvxx")]
            public static extern int Zhesvxx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesvxx_work")]
            public static extern int ZhesvxxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheswapr")]
            public static extern int Zheswapr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheswapr_work")]
            public static extern int ZheswaprWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrd")]
            public static extern int Zhetrd(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, double* d, double* e, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrd_work")]
            public static extern int ZhetrdWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, double* d, double* e, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrf")]
            public static extern int Zhetrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrf_rook")]
            public static extern int ZhetrfRook(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrf_rook_work")]
            public static extern int ZhetrfRookWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrf_work")]
            public static extern int ZhetrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetri")]
            public static extern int Zhetri(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetri2")]
            public static extern int Zhetri2(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetri2_work")]
            public static extern int Zhetri2Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetri2x")]
            public static extern int Zhetri2x(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetri2x_work")]
            public static extern int Zhetri2xWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetri_work")]
            public static extern int ZhetriWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs")]
            public static extern int Zhetrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs2")]
            public static extern int Zhetrs2(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs2_work")]
            public static extern int Zhetrs2Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs_rook")]
            public static extern int ZhetrsRook(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs_rook_work")]
            public static extern int ZhetrsRookWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs_work")]
            public static extern int ZhetrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhfrk")]
            public static extern int Zhfrk(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, TransLapack trans, int n, int k, double alpha, IntPtr a, int lda, double beta, IntPtr c);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhfrk_work")]
            public static extern int ZhfrkWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, TransLapack trans, int n, int k, double alpha, IntPtr a, int lda, double beta, IntPtr c);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhgeqz")]
            public static extern int Zhgeqz(MatrixLayout matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr h, int ldh, IntPtr t, int ldt, IntPtr alpha, IntPtr beta, IntPtr q, int ldq, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhgeqz_work")]
            public static extern int ZhgeqzWork(MatrixLayout matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr h, int ldh, IntPtr t, int ldt, IntPtr alpha, IntPtr beta, IntPtr q, int ldq, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpcon")]
            public static extern int Zhpcon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpcon_work")]
            public static extern int ZhpconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv, double anorm, double* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpev")]
            public static extern int Zhpev(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr ap, double* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpev_work")]
            public static extern int ZhpevWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr ap, double* w, IntPtr z, int ldz, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpevd")]
            public static extern int Zhpevd(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr ap, double* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpevd_work")]
            public static extern int ZhpevdWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr ap, double* w, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpevx")]
            public static extern int Zhpevx(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr ap, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpevx_work")]
            public static extern int ZhpevxWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr ap, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, IntPtr work, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpgst")]
            public static extern int Zhpgst(MatrixLayout matrixLayout, int itype, UpLoLapack uplo, int n, IntPtr ap, IntPtr bp);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpgst_work")]
            public static extern int ZhpgstWork(MatrixLayout matrixLayout, int itype, UpLoLapack uplo, int n, IntPtr ap, IntPtr bp);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpgv")]
            public static extern int Zhpgv(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, IntPtr ap, IntPtr bp, double* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpgv_work")]
            public static extern int ZhpgvWork(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, IntPtr ap, IntPtr bp, double* w, IntPtr z, int ldz, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpgvd")]
            public static extern int Zhpgvd(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, IntPtr ap, IntPtr bp, double* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpgvd_work")]
            public static extern int ZhpgvdWork(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, IntPtr ap, IntPtr bp, double* w, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpgvx")]
            public static extern int Zhpgvx(MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr ap, IntPtr bp, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpgvx_work")]
            public static extern int ZhpgvxWork(MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr ap, IntPtr bp, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, IntPtr work, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhprfs")]
            public static extern int Zhprfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhprfs_work")]
            public static extern int ZhprfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpsv")]
            public static extern int Zhpsv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpsv_work")]
            public static extern int ZhpsvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpsvx")]
            public static extern int Zhpsvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpsvx_work")]
            public static extern int ZhpsvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhptrd")]
            public static extern int Zhptrd(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, double* d, double* e, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhptrd_work")]
            public static extern int ZhptrdWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, double* d, double* e, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhptrf")]
            public static extern int Zhptrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhptrf_work")]
            public static extern int ZhptrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhptri")]
            public static extern int Zhptri(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhptri_work")]
            public static extern int ZhptriWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhptrs")]
            public static extern int Zhptrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhptrs_work")]
            public static extern int ZhptrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhsein")]
            public static extern int Zhsein(MatrixLayout matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, IntPtr h, int ldh, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhsein_work")]
            public static extern int ZhseinWork(MatrixLayout matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, IntPtr h, int ldh, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m, IntPtr work, double* rwork, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhseqr")]
            public static extern int Zhseqr(MatrixLayout matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, IntPtr h, int ldh, IntPtr w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhseqr_work")]
            public static extern int ZhseqrWork(MatrixLayout matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, IntPtr h, int ldh, IntPtr w, IntPtr z, int ldz, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlacgv")]
            public static extern int Zlacgv(int n, IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlacgv_work")]
            public static extern int ZlacgvWork(int n, IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlacn2")]
            public static extern int Zlacn2(int n, IntPtr v, IntPtr x, double* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlacn2_work")]
            public static extern int Zlacn2Work(int n, IntPtr v, IntPtr x, double* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlacp2")]
            public static extern int Zlacp2(MatrixLayout matrixLayout, UpLoLapack uplo, int m, int n, double* a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlacp2_work")]
            public static extern int Zlacp2Work(MatrixLayout matrixLayout, UpLoLapack uplo, int m, int n, double* a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlacpy")]
            public static extern int Zlacpy(MatrixLayout matrixLayout, UpLoLapack uplo, int m, int n, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlacpy_work")]
            public static extern int ZlacpyWork(MatrixLayout matrixLayout, UpLoLapack uplo, int m, int n, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlag2c")]
            public static extern int Zlag2c(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr sa, int ldsa);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlag2c_work")]
            public static extern int Zlag2cWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr sa, int ldsa);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlagge")]
            public static extern int Zlagge(MatrixLayout matrixLayout, int m, int n, int kl, int ku, double* d, IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlagge_work")]
            public static extern int ZlaggeWork(MatrixLayout matrixLayout, int m, int n, int kl, int ku, double* d, IntPtr a, int lda, int* iseed, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlaghe")]
            public static extern int Zlaghe(MatrixLayout matrixLayout, int n, int k, double* d, IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlaghe_work")]
            public static extern int ZlagheWork(MatrixLayout matrixLayout, int n, int k, double* d, IntPtr a, int lda, int* iseed, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlagsy")]
            public static extern int Zlagsy(MatrixLayout matrixLayout, int n, int k, double* d, IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlagsy_work")]
            public static extern int ZlagsyWork(MatrixLayout matrixLayout, int n, int k, double* d, IntPtr a, int lda, int* iseed, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlapmr")]
            public static extern int Zlapmr(MatrixLayout matrixLayout, int forwrd, int m, int n, IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlapmr_work")]
            public static extern int ZlapmrWork(MatrixLayout matrixLayout, int forwrd, int m, int n, IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlapmt")]
            public static extern int Zlapmt(MatrixLayout matrixLayout, int forwrd, int m, int n, IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlapmt_work")]
            public static extern int ZlapmtWork(MatrixLayout matrixLayout, int forwrd, int m, int n, IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarfb")]
            public static extern int Zlarfb(MatrixLayout matrixLayout, sbyte side, TransLapack trans, sbyte direct, sbyte storev, int m, int n, int k, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarfb_work")]
            public static extern int ZlarfbWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, sbyte direct, sbyte storev, int m, int n, int k, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr c, int ldc, IntPtr work, int ldwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarfg")]
            public static extern int Zlarfg(int n, IntPtr alpha, IntPtr x, int incx, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarfg_work")]
            public static extern int ZlarfgWork(int n, IntPtr alpha, IntPtr x, int incx, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarft")]
            public static extern int Zlarft(MatrixLayout matrixLayout, sbyte direct, sbyte storev, int n, int k, IntPtr v, int ldv, IntPtr tau, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarft_work")]
            public static extern int ZlarftWork(MatrixLayout matrixLayout, sbyte direct, sbyte storev, int n, int k, IntPtr v, int ldv, IntPtr tau, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarfx")]
            public static extern int Zlarfx(MatrixLayout matrixLayout, sbyte side, int m, int n, IntPtr v, IntPtr tau, IntPtr c, int ldc, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarfx_work")]
            public static extern int ZlarfxWork(MatrixLayout matrixLayout, sbyte side, int m, int n, IntPtr v, IntPtr tau, IntPtr c, int ldc, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarnv")]
            public static extern int Zlarnv(int idist, int* iseed, int n, IntPtr x);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarnv_work")]
            public static extern int ZlarnvWork(int idist, int* iseed, int n, IntPtr x);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlascl")]
            public static extern int Zlascl(MatrixLayout matrixLayout, sbyte type, int kl, int ku, double cfrom, double cto, int m, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlascl_work")]
            public static extern int ZlasclWork(MatrixLayout matrixLayout, sbyte type, int kl, int ku, double cfrom, double cto, int m, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlaset")]
            public static extern int Zlaset(MatrixLayout matrixLayout, UpLoLapack uplo, int m, int n, IntPtr alpha, IntPtr beta, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlaset_work")]
            public static extern int ZlasetWork(MatrixLayout matrixLayout, UpLoLapack uplo, int m, int n, IntPtr alpha, IntPtr beta, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlaswp")]
            public static extern int Zlaswp(MatrixLayout matrixLayout, int n, IntPtr a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlaswp_work")]
            public static extern int ZlaswpWork(MatrixLayout matrixLayout, int n, IntPtr a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlatms")]
            public static extern int Zlatms(MatrixLayout matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, double* d, int mode, double cond, double dmax, int kl, int ku, sbyte pack, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlatms_work")]
            public static extern int ZlatmsWork(MatrixLayout matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, double* d, int mode, double cond, double dmax, int kl, int ku, sbyte pack, IntPtr a, int lda, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlauum")]
            public static extern int Zlauum(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlauum_work")]
            public static extern int ZlauumWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbcon")]
            public static extern int Zpbcon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbcon_work")]
            public static extern int ZpbconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, double anorm, double* rcond, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbequ")]
            public static extern int Zpbequ(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbequ_work")]
            public static extern int ZpbequWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbrfs")]
            public static extern int Zpbrfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbrfs_work")]
            public static extern int ZpbrfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbstf")]
            public static extern int Zpbstf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kb, IntPtr bb, int ldbb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbstf_work")]
            public static extern int ZpbstfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kb, IntPtr bb, int ldbb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbsv")]
            public static extern int Zpbsv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbsv_work")]
            public static extern int ZpbsvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbsvx")]
            public static extern int Zpbsvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbsvx_work")]
            public static extern int ZpbsvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbtrf")]
            public static extern int Zpbtrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbtrf_work")]
            public static extern int ZpbtrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbtrs")]
            public static extern int Zpbtrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbtrs_work")]
            public static extern int ZpbtrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpftrf")]
            public static extern int Zpftrf(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpftrf_work")]
            public static extern int ZpftrfWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpftri")]
            public static extern int Zpftri(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpftri_work")]
            public static extern int ZpftriWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpftrs")]
            public static extern int Zpftrs(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, int nrhs, IntPtr a, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpftrs_work")]
            public static extern int ZpftrsWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, int nrhs, IntPtr a, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpocon")]
            public static extern int Zpocon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpocon_work")]
            public static extern int ZpoconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, double anorm, double* rcond, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpoequ")]
            public static extern int Zpoequ(MatrixLayout matrixLayout, int n, IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpoequ_work")]
            public static extern int ZpoequWork(MatrixLayout matrixLayout, int n, IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpoequb")]
            public static extern int Zpoequb(MatrixLayout matrixLayout, int n, IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpoequb_work")]
            public static extern int ZpoequbWork(MatrixLayout matrixLayout, int n, IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zporfs")]
            public static extern int Zporfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zporfs_work")]
            public static extern int ZporfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zporfsx")]
            public static extern int Zporfsx(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zporfsx_work")]
            public static extern int ZporfsxWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zposv")]
            public static extern int Zposv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zposv_work")]
            public static extern int ZposvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zposvx")]
            public static extern int Zposvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zposvx_work")]
            public static extern int ZposvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zposvxx")]
            public static extern int Zposvxx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zposvxx_work")]
            public static extern int ZposvxxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpotrf")]
            public static extern int Zpotrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpotrf2")]
            public static extern int Zpotrf2(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpotrf2_work")]
            public static extern int Zpotrf2Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpotrf_work")]
            public static extern int ZpotrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpotri")]
            public static extern int Zpotri(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpotri_work")]
            public static extern int ZpotriWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpotrs")]
            public static extern int Zpotrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpotrs_work")]
            public static extern int ZpotrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zppcon")]
            public static extern int Zppcon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zppcon_work")]
            public static extern int ZppconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, double anorm, double* rcond, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zppequ")]
            public static extern int Zppequ(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zppequ_work")]
            public static extern int ZppequWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpprfs")]
            public static extern int Zpprfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpprfs_work")]
            public static extern int ZpprfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zppsv")]
            public static extern int Zppsv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zppsv_work")]
            public static extern int ZppsvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zppsvx")]
            public static extern int Zppsvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zppsvx_work")]
            public static extern int ZppsvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpptrf")]
            public static extern int Zpptrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpptrf_work")]
            public static extern int ZpptrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpptri")]
            public static extern int Zpptri(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpptri_work")]
            public static extern int ZpptriWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpptrs")]
            public static extern int Zpptrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpptrs_work")]
            public static extern int ZpptrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpstrf")]
            public static extern int Zpstrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* piv, int* rank, double tol);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpstrf_work")]
            public static extern int ZpstrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* piv, int* rank, double tol, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zptcon")]
            public static extern int Zptcon(int n, double* d, IntPtr e, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zptcon_work")]
            public static extern int ZptconWork(int n, double* d, IntPtr e, double anorm, double* rcond, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpteqr")]
            public static extern int Zpteqr(MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpteqr_work")]
            public static extern int ZpteqrWork(MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, IntPtr z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zptrfs")]
            public static extern int Zptrfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* d, IntPtr e, double* df, IntPtr ef, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zptrfs_work")]
            public static extern int ZptrfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* d, IntPtr e, double* df, IntPtr ef, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zptsv")]
            public static extern int Zptsv(MatrixLayout matrixLayout, int n, int nrhs, double* d, IntPtr e, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zptsv_work")]
            public static extern int ZptsvWork(MatrixLayout matrixLayout, int n, int nrhs, double* d, IntPtr e, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zptsvx")]
            public static extern int Zptsvx(MatrixLayout matrixLayout, sbyte fact, int n, int nrhs, double* d, IntPtr e, double* df, IntPtr ef, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zptsvx_work")]
            public static extern int ZptsvxWork(MatrixLayout matrixLayout, sbyte fact, int n, int nrhs, double* d, IntPtr e, double* df, IntPtr ef, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpttrf")]
            public static extern int Zpttrf(int n, double* d, IntPtr e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpttrf_work")]
            public static extern int ZpttrfWork(int n, double* d, IntPtr e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpttrs")]
            public static extern int Zpttrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* d, IntPtr e, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpttrs_work")]
            public static extern int ZpttrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* d, IntPtr e, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zspcon")]
            public static extern int Zspcon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zspcon_work")]
            public static extern int ZspconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv, double anorm, double* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsprfs")]
            public static extern int Zsprfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsprfs_work")]
            public static extern int ZsprfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zspsv")]
            public static extern int Zspsv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zspsv_work")]
            public static extern int ZspsvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zspsvx")]
            public static extern int Zspsvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zspsvx_work")]
            public static extern int ZspsvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsptrf")]
            public static extern int Zsptrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsptrf_work")]
            public static extern int ZsptrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsptri")]
            public static extern int Zsptri(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsptri_work")]
            public static extern int ZsptriWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, int* ipiv, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsptrs")]
            public static extern int Zsptrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsptrs_work")]
            public static extern int ZsptrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zstedc")]
            public static extern int Zstedc(MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zstedc_work")]
            public static extern int ZstedcWork(MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zstegr")]
            public static extern int Zstegr(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zstegr_work")]
            public static extern int ZstegrWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zstein")]
            public static extern int Zstein(MatrixLayout matrixLayout, int n, double* d, double* e, int m, double* w, int* iblock, int* isplit, IntPtr z, int ldz, int* ifailv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zstein_work")]
            public static extern int ZsteinWork(MatrixLayout matrixLayout, int n, double* d, double* e, int m, double* w, int* iblock, int* isplit, IntPtr z, int ldz, double* work, int* iwork, int* ifailv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zstemr")]
            public static extern int Zstemr(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* m, double* w, IntPtr z, int ldz, int nzc, int* isuppz, int* tryrac);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zstemr_work")]
            public static extern int ZstemrWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* m, double* w, IntPtr z, int ldz, int nzc, int* isuppz, int* tryrac, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsteqr")]
            public static extern int Zsteqr(MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsteqr_work")]
            public static extern int ZsteqrWork(MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, IntPtr z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsycon")]
            public static extern int Zsycon(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsycon_work")]
            public static extern int ZsyconWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, double anorm, double* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyconv")]
            public static extern int Zsyconv(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte way, int n, IntPtr a, int lda, int* ipiv, IntPtr e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyconv_work")]
            public static extern int ZsyconvWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte way, int n, IntPtr a, int lda, int* ipiv, IntPtr e);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyequb")]
            public static extern int Zsyequb(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyequb_work")]
            public static extern int ZsyequbWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, double* s, double* scond, double* amax, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyr")]
            public static extern int Zsyr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr alpha, IntPtr x, int incx, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyr_work")]
            public static extern int ZsyrWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr alpha, IntPtr x, int incx, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyrfs")]
            public static extern int Zsyrfs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyrfs_work")]
            public static extern int ZsyrfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyrfsx")]
            public static extern int Zsyrfsx(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyrfsx_work")]
            public static extern int ZsyrfsxWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysv")]
            public static extern int Zsysv(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysv_rook")]
            public static extern int ZsysvRook(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysv_rook_work")]
            public static extern int ZsysvRookWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysv_work")]
            public static extern int ZsysvWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysvx")]
            public static extern int Zsysvx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysvx_work")]
            public static extern int ZsysvxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysvxx")]
            public static extern int Zsysvxx(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysvxx_work")]
            public static extern int ZsysvxxWork(MatrixLayout matrixLayout, sbyte fact, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyswapr")]
            public static extern int Zsyswapr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyswapr_work")]
            public static extern int ZsyswaprWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrf")]
            public static extern int Zsytrf(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrf_rook")]
            public static extern int ZsytrfRook(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrf_rook_work")]
            public static extern int ZsytrfRookWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrf_work")]
            public static extern int ZsytrfWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytri")]
            public static extern int Zsytri(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytri2")]
            public static extern int Zsytri2(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytri2_work")]
            public static extern int Zsytri2Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytri2x")]
            public static extern int Zsytri2x(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytri2x_work")]
            public static extern int Zsytri2xWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytri_work")]
            public static extern int ZsytriWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs")]
            public static extern int Zsytrs(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs2")]
            public static extern int Zsytrs2(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs2_work")]
            public static extern int Zsytrs2Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs_rook")]
            public static extern int ZsytrsRook(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs_rook_work")]
            public static extern int ZsytrsRookWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs_work")]
            public static extern int ZsytrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztbcon")]
            public static extern int Ztbcon(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, int kd, IntPtr ab, int ldab, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztbcon_work")]
            public static extern int ZtbconWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, int kd, IntPtr ab, int ldab, double* rcond, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztbrfs")]
            public static extern int Ztbrfs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztbrfs_work")]
            public static extern int ZtbrfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztbtrs")]
            public static extern int Ztbtrs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztbtrs_work")]
            public static extern int ZtbtrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztfsm")]
            public static extern int Ztfsm(MatrixLayout matrixLayout, sbyte transr, sbyte side, UpLoLapack uplo, TransLapack trans, sbyte diag, int m, int n, IntPtr alpha, IntPtr a, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztfsm_work")]
            public static extern int ZtfsmWork(MatrixLayout matrixLayout, sbyte transr, sbyte side, UpLoLapack uplo, TransLapack trans, sbyte diag, int m, int n, IntPtr alpha, IntPtr a, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztftri")]
            public static extern int Ztftri(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, sbyte diag, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztftri_work")]
            public static extern int ZtftriWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, sbyte diag, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztfttp")]
            public static extern int Ztfttp(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr arf, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztfttp_work")]
            public static extern int ZtfttpWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr arf, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztfttr")]
            public static extern int Ztfttr(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr arf, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztfttr_work")]
            public static extern int ZtfttrWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr arf, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgevc")]
            public static extern int Ztgevc(MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, IntPtr s, int lds, IntPtr p, int ldp, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgevc_work")]
            public static extern int ZtgevcWork(MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, IntPtr s, int lds, IntPtr p, int ldp, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgexc")]
            public static extern int Ztgexc(MatrixLayout matrixLayout, int wantq, int wantz, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgexc_work")]
            public static extern int ZtgexcWork(MatrixLayout matrixLayout, int wantq, int wantz, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgsen")]
            public static extern int Ztgsen(MatrixLayout matrixLayout, int ijob, int wantq, int wantz, int* select, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr q, int ldq, IntPtr z, int ldz, int* m, double* pl, double* pr, double* dif);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgsen_work")]
            public static extern int ZtgsenWork(MatrixLayout matrixLayout, int ijob, int wantq, int wantz, int* select, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr q, int ldq, IntPtr z, int ldz, int* m, double* pl, double* pr, double* dif, IntPtr work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgsja")]
            public static extern int Ztgsja(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, IntPtr a, int lda, IntPtr b, int ldb, double tola, double tolb, double* alpha, double* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, int* ncycle);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgsja_work")]
            public static extern int ZtgsjaWork(MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, IntPtr a, int lda, IntPtr b, int ldb, double tola, double tolb, double* alpha, double* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, IntPtr work, int* ncycle);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgsna")]
            public static extern int Ztgsna(MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr vl, int ldvl, IntPtr vr, int ldvr, double* s, double* dif, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgsna_work")]
            public static extern int ZtgsnaWork(MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr vl, int ldvl, IntPtr vr, int ldvr, double* s, double* dif, int mm, int* m, IntPtr work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgsyl")]
            public static extern int Ztgsyl(MatrixLayout matrixLayout, TransLapack trans, int ijob, int m, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, int ldc, IntPtr d, int ldd, IntPtr e, int lde, IntPtr f, int ldf, double* scale, double* dif);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgsyl_work")]
            public static extern int ZtgsylWork(MatrixLayout matrixLayout, TransLapack trans, int ijob, int m, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, int ldc, IntPtr d, int ldd, IntPtr e, int lde, IntPtr f, int ldf, double* scale, double* dif, IntPtr work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpcon")]
            public static extern int Ztpcon(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, IntPtr ap, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpcon_work")]
            public static extern int ZtpconWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, IntPtr ap, double* rcond, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpmqrt")]
            public static extern int Ztpmqrt(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int l, int nb, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpmqrt_work")]
            public static extern int ZtpmqrtWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int l, int nb, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr a, int lda, IntPtr b, int ldb, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpqrt")]
            public static extern int Ztpqrt(MatrixLayout matrixLayout, int m, int n, int l, int nb, IntPtr a, int lda, IntPtr b, int ldb, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpqrt2")]
            public static extern int Ztpqrt2(MatrixLayout matrixLayout, int m, int n, int l, IntPtr a, int lda, IntPtr b, int ldb, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpqrt2_work")]
            public static extern int Ztpqrt2Work(MatrixLayout matrixLayout, int m, int n, int l, IntPtr a, int lda, IntPtr b, int ldb, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpqrt_work")]
            public static extern int ZtpqrtWork(MatrixLayout matrixLayout, int m, int n, int l, int nb, IntPtr a, int lda, IntPtr b, int ldb, IntPtr t, int ldt, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztprfb")]
            public static extern int Ztprfb(MatrixLayout matrixLayout, sbyte side, TransLapack trans, sbyte direct, sbyte storev, int m, int n, int k, int l, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztprfb_work")]
            public static extern int ZtprfbWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, sbyte direct, sbyte storev, int m, int n, int k, int l, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr a, int lda, IntPtr b, int ldb, IntPtr work, int ldwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztprfs")]
            public static extern int Ztprfs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, IntPtr ap, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztprfs_work")]
            public static extern int ZtprfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, IntPtr ap, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztptri")]
            public static extern int Ztptri(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte diag, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztptri_work")]
            public static extern int ZtptriWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte diag, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztptrs")]
            public static extern int Ztptrs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztptrs_work")]
            public static extern int ZtptrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpttf")]
            public static extern int Ztpttf(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr ap, IntPtr arf);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpttf_work")]
            public static extern int ZtpttfWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr ap, IntPtr arf);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpttr")]
            public static extern int Ztpttr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpttr_work")]
            public static extern int ZtpttrWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrcon")]
            public static extern int Ztrcon(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, IntPtr a, int lda, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrcon_work")]
            public static extern int ZtrconWork(MatrixLayout matrixLayout, sbyte norm, UpLoLapack uplo, sbyte diag, int n, IntPtr a, int lda, double* rcond, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrevc")]
            public static extern int Ztrevc(MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, IntPtr t, int ldt, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrevc_work")]
            public static extern int ZtrevcWork(MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, IntPtr t, int ldt, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrexc")]
            public static extern int Ztrexc(MatrixLayout matrixLayout, sbyte compq, int n, IntPtr t, int ldt, IntPtr q, int ldq, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrexc_work")]
            public static extern int ZtrexcWork(MatrixLayout matrixLayout, sbyte compq, int n, IntPtr t, int ldt, IntPtr q, int ldq, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrrfs")]
            public static extern int Ztrrfs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrrfs_work")]
            public static extern int ZtrrfsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrsen")]
            public static extern int Ztrsen(MatrixLayout matrixLayout, sbyte job, sbyte compq, int* select, int n, IntPtr t, int ldt, IntPtr q, int ldq, IntPtr w, int* m, double* s, double* sep);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrsen_work")]
            public static extern int ZtrsenWork(MatrixLayout matrixLayout, sbyte job, sbyte compq, int* select, int n, IntPtr t, int ldt, IntPtr q, int ldq, IntPtr w, int* m, double* s, double* sep, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrsna")]
            public static extern int Ztrsna(MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, IntPtr t, int ldt, IntPtr vl, int ldvl, IntPtr vr, int ldvr, double* s, double* sep, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrsna_work")]
            public static extern int ZtrsnaWork(MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, IntPtr t, int ldt, IntPtr vl, int ldvl, IntPtr vr, int ldvr, double* s, double* sep, int mm, int* m, IntPtr work, int ldwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrsyl")]
            public static extern int Ztrsyl(MatrixLayout matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, int ldc, double* scale);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrsyl_work")]
            public static extern int ZtrsylWork(MatrixLayout matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, int ldc, double* scale);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrtri")]
            public static extern int Ztrtri(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte diag, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrtri_work")]
            public static extern int ZtrtriWork(MatrixLayout matrixLayout, UpLoLapack uplo, sbyte diag, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrtrs")]
            public static extern int Ztrtrs(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrtrs_work")]
            public static extern int ZtrtrsWork(MatrixLayout matrixLayout, UpLoLapack uplo, TransLapack trans, sbyte diag, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrttf")]
            public static extern int Ztrttf(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr arf);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrttf_work")]
            public static extern int ZtrttfWork(MatrixLayout matrixLayout, sbyte transr, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr arf);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrttp")]
            public static extern int Ztrttp(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrttp_work")]
            public static extern int ZtrttpWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztzrzf")]
            public static extern int Ztzrzf(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztzrzf_work")]
            public static extern int ZtzrzfWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunbdb")]
            public static extern int Zunbdb(MatrixLayout matrixLayout, TransLapack trans, sbyte signs, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x12, int ldx12, IntPtr x21, int ldx21, IntPtr x22, int ldx22, double* theta, double* phi, IntPtr taup1, IntPtr taup2, IntPtr tauq1, IntPtr tauq2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunbdb_work")]
            public static extern int ZunbdbWork(MatrixLayout matrixLayout, TransLapack trans, sbyte signs, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x12, int ldx12, IntPtr x21, int ldx21, IntPtr x22, int ldx22, double* theta, double* phi, IntPtr taup1, IntPtr taup2, IntPtr tauq1, IntPtr tauq2, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zuncsd")]
            public static extern int Zuncsd(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, TransLapack trans, sbyte signs, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x12, int ldx12, IntPtr x21, int ldx21, IntPtr x22, int ldx22, double* theta, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t, IntPtr v2t, int ldv2t);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zuncsd2by1")]
            public static extern int Zuncsd2by1(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x21, int ldx21, double* theta, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zuncsd2by1_work")]
            public static extern int Zuncsd2by1Work(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x21, int ldx21, double* theta, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zuncsd_work")]
            public static extern int ZuncsdWork(MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, TransLapack trans, sbyte signs, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x12, int ldx12, IntPtr x21, int ldx21, IntPtr x22, int ldx22, double* theta, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t, IntPtr v2t, int ldv2t, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zungbr")]
            public static extern int Zungbr(MatrixLayout matrixLayout, sbyte vect, int m, int n, int k, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zungbr_work")]
            public static extern int ZungbrWork(MatrixLayout matrixLayout, sbyte vect, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunghr")]
            public static extern int Zunghr(MatrixLayout matrixLayout, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunghr_work")]
            public static extern int ZunghrWork(MatrixLayout matrixLayout, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunglq")]
            public static extern int Zunglq(MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunglq_work")]
            public static extern int ZunglqWork(MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zungql")]
            public static extern int Zungql(MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zungql_work")]
            public static extern int ZungqlWork(MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zungqr")]
            public static extern int Zungqr(MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zungqr_work")]
            public static extern int ZungqrWork(MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zungrq")]
            public static extern int Zungrq(MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zungrq_work")]
            public static extern int ZungrqWork(MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zungtr")]
            public static extern int Zungtr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zungtr_work")]
            public static extern int ZungtrWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmbr")]
            public static extern int Zunmbr(MatrixLayout matrixLayout, sbyte vect, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmbr_work")]
            public static extern int ZunmbrWork(MatrixLayout matrixLayout, sbyte vect, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmhr")]
            public static extern int Zunmhr(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmhr_work")]
            public static extern int ZunmhrWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmlq")]
            public static extern int Zunmlq(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmlq_work")]
            public static extern int ZunmlqWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmql")]
            public static extern int Zunmql(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmql_work")]
            public static extern int ZunmqlWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmqr")]
            public static extern int Zunmqr(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmqr_work")]
            public static extern int ZunmqrWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmrq")]
            public static extern int Zunmrq(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmrq_work")]
            public static extern int ZunmrqWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmrz")]
            public static extern int Zunmrz(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int l, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmrz_work")]
            public static extern int ZunmrzWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, int l, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmtr")]
            public static extern int Zunmtr(MatrixLayout matrixLayout, sbyte side, UpLoLapack uplo, TransLapack trans, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmtr_work")]
            public static extern int ZunmtrWork(MatrixLayout matrixLayout, sbyte side, UpLoLapack uplo, TransLapack trans, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zupgtr")]
            public static extern int Zupgtr(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, IntPtr tau, IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zupgtr_work")]
            public static extern int ZupgtrWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr ap, IntPtr tau, IntPtr q, int ldq, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zupmtr")]
            public static extern int Zupmtr(MatrixLayout matrixLayout, sbyte side, UpLoLapack uplo, TransLapack trans, int m, int n, IntPtr ap, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zupmtr_work")]
            public static extern int ZupmtrWork(MatrixLayout matrixLayout, sbyte side, UpLoLapack uplo, TransLapack trans, int m, int n, IntPtr ap, IntPtr tau, IntPtr c, int ldc, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ilaver")]
            public static extern void Ilaver(int* vers_major, int* vers_minor, int* vers_patch);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesv_aa")]
            public static extern int ChesvAa(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesv_aa_work")]
            public static extern int ChesvAaWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrf_aa")]
            public static extern int ChetrfAa(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrf_aa_work")]
            public static extern int ChetrfAaWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs_aa")]
            public static extern int ChetrsAa(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs_aa_work")]
            public static extern int ChetrsAaWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysv_aa")]
            public static extern int DsysvAa(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysv_aa_work")]
            public static extern int DsysvAaWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrf_aa")]
            public static extern int DsytrfAa(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrf_aa_work")]
            public static extern int DsytrfAaWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs_aa")]
            public static extern int DsytrsAa(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs_aa_work")]
            public static extern int DsytrsAaWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysv_aa")]
            public static extern int SsysvAa(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysv_aa_work")]
            public static extern int SsysvAaWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrf_aa")]
            public static extern int SsytrfAa(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrf_aa_work")]
            public static extern int SsytrfAaWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs_aa")]
            public static extern int SsytrsAa(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs_aa_work")]
            public static extern int SsytrsAaWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesv_aa")]
            public static extern int ZhesvAa(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesv_aa_work")]
            public static extern int ZhesvAaWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrf_aa")]
            public static extern int ZhetrfAa(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrf_aa_work")]
            public static extern int ZhetrfAaWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs_aa")]
            public static extern int ZhetrsAa(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs_aa_work")]
            public static extern int ZhetrsAaWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgemqr")]
            public static extern int Cgemqr(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr t, int tsize, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgemqr_work")]
            public static extern int CgemqrWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr t, int tsize, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqr")]
            public static extern int Cgeqr(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int tsize);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqr_work")]
            public static extern int CgeqrWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int tsize, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgemqr")]
            public static extern int Dgemqr(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, double* a, int lda, double* t, int tsize, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgemqr_work")]
            public static extern int DgemqrWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, double* a, int lda, double* t, int tsize, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqr")]
            public static extern int Dgeqr(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* t, int tsize);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqr_work")]
            public static extern int DgeqrWork(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* t, int tsize, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgemqr")]
            public static extern int Sgemqr(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, float* a, int lda, float* t, int tsize, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgemqr_work")]
            public static extern int SgemqrWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, float* a, int lda, float* t, int tsize, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqr")]
            public static extern int Sgeqr(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* t, int tsize);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqr_work")]
            public static extern int SgeqrWork(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* t, int tsize, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgemqr")]
            public static extern int Zgemqr(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr t, int tsize, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgemqr_work")]
            public static extern int ZgemqrWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr t, int tsize, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqr")]
            public static extern int Zgeqr(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int tsize);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqr_work")]
            public static extern int ZgeqrWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int tsize, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelq")]
            public static extern int Cgelq(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int tsize);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelq_work")]
            public static extern int CgelqWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int tsize, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgemlq")]
            public static extern int Cgemlq(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr t, int tsize, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgemlq_work")]
            public static extern int CgemlqWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr t, int tsize, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelq")]
            public static extern int Dgelq(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* t, int tsize);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelq_work")]
            public static extern int DgelqWork(MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* t, int tsize, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgemlq")]
            public static extern int Dgemlq(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, double* a, int lda, double* t, int tsize, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgemlq_work")]
            public static extern int DgemlqWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, double* a, int lda, double* t, int tsize, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelq")]
            public static extern int Sgelq(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* t, int tsize);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelq_work")]
            public static extern int SgelqWork(MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* t, int tsize, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgemlq")]
            public static extern int Sgemlq(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, float* a, int lda, float* t, int tsize, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgemlq_work")]
            public static extern int SgemlqWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, float* a, int lda, float* t, int tsize, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelq")]
            public static extern int Zgelq(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int tsize);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelq_work")]
            public static extern int ZgelqWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int tsize, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgemlq")]
            public static extern int Zgemlq(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr t, int tsize, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgemlq_work")]
            public static extern int ZgemlqWork(MatrixLayout matrixLayout, sbyte side, TransLapack trans, int m, int n, int k, IntPtr a, int lda, IntPtr t, int tsize, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetsls")]
            public static extern int Cgetsls(MatrixLayout matrixLayout, TransLapack trans, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetsls_work")]
            public static extern int CgetslsWork(MatrixLayout matrixLayout, TransLapack trans, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetsls")]
            public static extern int Dgetsls(MatrixLayout matrixLayout, TransLapack trans, int m, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetsls_work")]
            public static extern int DgetslsWork(MatrixLayout matrixLayout, TransLapack trans, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetsls")]
            public static extern int Sgetsls(MatrixLayout matrixLayout, TransLapack trans, int m, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetsls_work")]
            public static extern int SgetslsWork(MatrixLayout matrixLayout, TransLapack trans, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetsls")]
            public static extern int Zgetsls(MatrixLayout matrixLayout, TransLapack trans, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetsls_work")]
            public static extern int ZgetslsWork(MatrixLayout matrixLayout, TransLapack trans, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_checon_3")]
            public static extern int Checon3(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_checon_3_work")]
            public static extern int Checon3Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, float anorm, float* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesv_rk")]
            public static extern int ChesvRk(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesv_rk_work")]
            public static extern int ChesvRkWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrf_rk")]
            public static extern int ChetrfRk(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrf_rk_work")]
            public static extern int ChetrfRkWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetri_3")]
            public static extern int Chetri3(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetri_3_work")]
            public static extern int Chetri3Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs_3")]
            public static extern int Chetrs3(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs_3_work")]
            public static extern int Chetrs3Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csycon_3")]
            public static extern int Csycon3(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csycon_3_work")]
            public static extern int Csycon3Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, float anorm, float* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysv_aa")]
            public static extern int CsysvAa(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysv_aa_work")]
            public static extern int CsysvAaWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysv_rk")]
            public static extern int CsysvRk(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysv_rk_work")]
            public static extern int CsysvRkWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrf_aa")]
            public static extern int CsytrfAa(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrf_aa_work")]
            public static extern int CsytrfAaWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrf_rk")]
            public static extern int CsytrfRk(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrf_rk_work")]
            public static extern int CsytrfRkWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytri_3")]
            public static extern int Csytri3(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytri_3_work")]
            public static extern int Csytri3Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs_3")]
            public static extern int Csytrs3(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs_3_work")]
            public static extern int Csytrs3Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs_aa")]
            public static extern int CsytrsAa(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs_aa_work")]
            public static extern int CsytrsAaWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsycon_3")]
            public static extern int Dsycon3(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, double* e, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsycon_3_work")]
            public static extern int Dsycon3Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, double* e, int* ipiv, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysv_rk")]
            public static extern int DsysvRk(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* e, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysv_rk_work")]
            public static extern int DsysvRkWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* e, int* ipiv, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrf_rk")]
            public static extern int DsytrfRk(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, double* e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrf_rk_work")]
            public static extern int DsytrfRkWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, double* e, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytri_3")]
            public static extern int Dsytri3(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, double* e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytri_3_work")]
            public static extern int Dsytri3Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, double* e, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs_3")]
            public static extern int Dsytrs3(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* e, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs_3_work")]
            public static extern int Dsytrs3Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* e, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssycon_3")]
            public static extern int Ssycon3(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, float* e, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssycon_3_work")]
            public static extern int Ssycon3Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, float* e, int* ipiv, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysv_rk")]
            public static extern int SsysvRk(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* e, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysv_rk_work")]
            public static extern int SsysvRkWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* e, int* ipiv, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrf_rk")]
            public static extern int SsytrfRk(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, float* e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrf_rk_work")]
            public static extern int SsytrfRkWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, float* e, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytri_3")]
            public static extern int Ssytri3(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, float* e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytri_3_work")]
            public static extern int Ssytri3Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, float* e, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs_3")]
            public static extern int Ssytrs3(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* e, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs_3_work")]
            public static extern int Ssytrs3Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* e, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhecon_3")]
            public static extern int Zhecon3(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhecon_3_work")]
            public static extern int Zhecon3Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, double anorm, double* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesv_rk")]
            public static extern int ZhesvRk(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesv_rk_work")]
            public static extern int ZhesvRkWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrf_rk")]
            public static extern int ZhetrfRk(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrf_rk_work")]
            public static extern int ZhetrfRkWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetri_3")]
            public static extern int Zhetri3(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetri_3_work")]
            public static extern int Zhetri3Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs_3")]
            public static extern int Zhetrs3(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs_3_work")]
            public static extern int Zhetrs3Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsycon_3")]
            public static extern int Zsycon3(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsycon_3_work")]
            public static extern int Zsycon3Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, double anorm, double* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysv_aa")]
            public static extern int ZsysvAa(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysv_aa_work")]
            public static extern int ZsysvAaWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysv_rk")]
            public static extern int ZsysvRk(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysv_rk_work")]
            public static extern int ZsysvRkWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrf_aa")]
            public static extern int ZsytrfAa(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrf_aa_work")]
            public static extern int ZsytrfAaWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrf_rk")]
            public static extern int ZsytrfRk(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrf_rk_work")]
            public static extern int ZsytrfRkWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytri_3")]
            public static extern int Zsytri3(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytri_3_work")]
            public static extern int Zsytri3Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs_3")]
            public static extern int Zsytrs3(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs_3_work")]
            public static extern int Zsytrs3Work(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs_aa")]
            public static extern int ZsytrsAa(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs_aa_work")]
            public static extern int ZsytrsAaWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbev_2stage")]
            public static extern int Chbev2stage(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, float* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbev_2stage_work")]
            public static extern int Chbev2stageWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, float* w, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbevd_2stage")]
            public static extern int Chbevd2stage(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, float* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbevd_2stage_work")]
            public static extern int Chbevd2stageWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, float* w, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbevx_2stage")]
            public static extern int Chbevx2stage(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, IntPtr q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbevx_2stage_work")]
            public static extern int Chbevx2stageWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, IntPtr q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheev_2stage")]
            public static extern int Cheev2stage(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheev_2stage_work")]
            public static extern int Cheev2stageWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, float* w, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevd_2stage")]
            public static extern int Cheevd2stage(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevd_2stage_work")]
            public static extern int Cheevd2stageWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, float* w, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevr_2stage")]
            public static extern int Cheevr2stage(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevr_2stage_work")]
            public static extern int Cheevr2stageWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* isuppz, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevx_2stage")]
            public static extern int Cheevx2stage(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevx_2stage_work")]
            public static extern int Cheevx2stageWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chegv_2stage")]
            public static extern int Chegv2stage(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chegv_2stage_work")]
            public static extern int Chegv2stageWork(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, float* w, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbev_2stage")]
            public static extern int Dsbev2stage(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbev_2stage_work")]
            public static extern int Dsbev2stageWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbevd_2stage")]
            public static extern int Dsbevd2stage(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbevd_2stage_work")]
            public static extern int Dsbevd2stageWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbevx_2stage")]
            public static extern int Dsbevx2stage(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int kd, double* ab, int ldab, double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbevx_2stage_work")]
            public static extern int Dsbevx2stageWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int kd, double* ab, int ldab, double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyev_2stage")]
            public static extern int Dsyev2stage(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, double* a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyev_2stage_work")]
            public static extern int Dsyev2stageWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, double* a, int lda, double* w, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevd_2stage")]
            public static extern int Dsyevd2stage(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, double* a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevd_2stage_work")]
            public static extern int Dsyevd2stageWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, double* a, int lda, double* w, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevr_2stage")]
            public static extern int Dsyevr2stage(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevr_2stage_work")]
            public static extern int Dsyevr2stageWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevx_2stage")]
            public static extern int Dsyevx2stage(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevx_2stage_work")]
            public static extern int Dsyevx2stageWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsygv_2stage")]
            public static extern int Dsygv2stage(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, double* a, int lda, double* b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsygv_2stage_work")]
            public static extern int Dsygv2stageWork(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, double* a, int lda, double* b, int ldb, double* w, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbev_2stage")]
            public static extern int Ssbev2stage(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbev_2stage_work")]
            public static extern int Ssbev2stageWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbevd_2stage")]
            public static extern int Ssbevd2stage(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbevd_2stage_work")]
            public static extern int Ssbevd2stageWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbevx_2stage")]
            public static extern int Ssbevx2stage(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int kd, float* ab, int ldab, float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbevx_2stage_work")]
            public static extern int Ssbevx2stageWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int kd, float* ab, int ldab, float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyev_2stage")]
            public static extern int Ssyev2stage(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, float* a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyev_2stage_work")]
            public static extern int Ssyev2stageWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, float* a, int lda, float* w, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevd_2stage")]
            public static extern int Ssyevd2stage(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, float* a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevd_2stage_work")]
            public static extern int Ssyevd2stageWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, float* a, int lda, float* w, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevr_2stage")]
            public static extern int Ssyevr2stage(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevr_2stage_work")]
            public static extern int Ssyevr2stageWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevx_2stage")]
            public static extern int Ssyevx2stage(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevx_2stage_work")]
            public static extern int Ssyevx2stageWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssygv_2stage")]
            public static extern int Ssygv2stage(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, float* a, int lda, float* b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssygv_2stage_work")]
            public static extern int Ssygv2stageWork(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, float* a, int lda, float* b, int ldb, float* w, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbev_2stage")]
            public static extern int Zhbev2stage(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, double* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbev_2stage_work")]
            public static extern int Zhbev2stageWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, double* w, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbevd_2stage")]
            public static extern int Zhbevd2stage(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, double* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbevd_2stage_work")]
            public static extern int Zhbevd2stageWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, double* w, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbevx_2stage")]
            public static extern int Zhbevx2stage(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, IntPtr q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbevx_2stage_work")]
            public static extern int Zhbevx2stageWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, int kd, IntPtr ab, int ldab, IntPtr q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheev_2stage")]
            public static extern int Zheev2stage(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheev_2stage_work")]
            public static extern int Zheev2stageWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, double* w, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevd_2stage")]
            public static extern int Zheevd2stage(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevd_2stage_work")]
            public static extern int Zheevd2stageWork(MatrixLayout matrixLayout, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, double* w, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevr_2stage")]
            public static extern int Zheevr2stage(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevr_2stage_work")]
            public static extern int Zheevr2stageWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* isuppz, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevx_2stage")]
            public static extern int Zheevx2stage(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevx_2stage_work")]
            public static extern int Zheevx2stageWork(MatrixLayout matrixLayout, sbyte jobz, sbyte range, UpLoLapack uplo, int n, IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhegv_2stage")]
            public static extern int Zhegv2stage(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhegv_2stage_work")]
            public static extern int Zhegv2stageWork(MatrixLayout matrixLayout, int itype, sbyte jobz, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, double* w, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_cgetrfnp")]
            public static extern int MklCgetrfnp(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_cgetrfnp_work")]
            public static extern int MklCgetrfnpWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_dgetrfnp")]
            public static extern int MklDgetrfnp(MatrixLayout matrixLayout, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_dgetrfnp_work")]
            public static extern int MklDgetrfnpWork(MatrixLayout matrixLayout, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_sgetrfnp")]
            public static extern int MklSgetrfnp(MatrixLayout matrixLayout, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_sgetrfnp_work")]
            public static extern int MklSgetrfnpWork(MatrixLayout matrixLayout, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_zgetrfnp")]
            public static extern int MklZgetrfnp(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_zgetrfnp_work")]
            public static extern int MklZgetrfnpWork(MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_cgetrinp")]
            public static extern int MklCgetrinp(MatrixLayout matrixLayout, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_cgetrinp_work")]
            public static extern int MklCgetrinpWork(MatrixLayout matrixLayout, int n, IntPtr a, int lda, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_dgetrinp")]
            public static extern int MklDgetrinp(MatrixLayout matrixLayout, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_dgetrinp_work")]
            public static extern int MklDgetrinpWork(MatrixLayout matrixLayout, int n, double* a, int lda, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_sgetrinp")]
            public static extern int MklSgetrinp(MatrixLayout matrixLayout, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_sgetrinp_work")]
            public static extern int MklSgetrinpWork(MatrixLayout matrixLayout, int n, float* a, int lda, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_zgetrinp")]
            public static extern int MklZgetrinp(MatrixLayout matrixLayout, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_mkl_zgetrinp_work")]
            public static extern int MklZgetrinpWork(MatrixLayout matrixLayout, int n, IntPtr a, int lda, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_set_nancheck")]
            public static extern void SetNancheck(int flag);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_get_nancheck")]
            public static extern int GetNancheck();

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesv_aa_2stage")]
            public static extern int ChesvAa2stage(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrf_aa_2stage")]
            public static extern int ChetrfAa2stage(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesv_aa_2stage_work")]
            public static extern int ChesvAa2stageWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrf_aa_2stage_work")]
            public static extern int ChetrfAa2stageWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs_aa_2stage")]
            public static extern int ChetrsAa2stage(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs_aa_2stage_work")]
            public static extern int ChetrsAa2stageWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysv_aa_2stage")]
            public static extern int CsysvAa2stage(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysv_aa_2stage_work")]
            public static extern int CsysvAa2stageWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrf_aa_2stage")]
            public static extern int CsytrfAa2stage(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrf_aa_2stage_work")]
            public static extern int CsytrfAa2stageWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs_aa_2stage")]
            public static extern int CsytrsAa2stage(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs_aa_2stage_work")]
            public static extern int CsytrsAa2stageWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysv_aa_2stage")]
            public static extern int DsysvAa2stage(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysv_aa_2stage_work")]
            public static extern int DsysvAa2stageWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrf_aa_2stage")]
            public static extern int DsytrfAa2stage(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrf_aa_2stage_work")]
            public static extern int DsytrfAa2stageWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs_aa_2stage")]
            public static extern int DsytrsAa2stage(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs_aa_2stage_work")]
            public static extern int DsytrsAa2stageWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysv_aa_2stage")]
            public static extern int ZsysvAa2stage(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysv_aa_2stage_work")]
            public static extern int ZsysvAa2stageWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrf_aa_2stage")]
            public static extern int ZsytrfAa2stage(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrf_aa_2stage_work")]
            public static extern int ZsytrfAa2stageWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs_aa_2stage")]
            public static extern int ZsytrsAa2stage(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs_aa_2stage_work")]
            public static extern int ZsytrsAa2stageWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysv_aa_2stage")]
            public static extern int SsysvAa2stage(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysv_aa_2stage_work")]
            public static extern int SsysvAa2stageWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrf_aa_2stage")]
            public static extern int SsytrfAa2stage(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrf_aa_2stage_work")]
            public static extern int SsytrfAa2stageWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs_aa_2stage")]
            public static extern int SsytrsAa2stage(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs_aa_2stage_work")]
            public static extern int SsytrsAa2stageWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesv_aa_2stage")]
            public static extern int ZhesvAa2stage(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesv_aa_2stage_work")]
            public static extern int ZhesvAa2stageWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrf_aa_2stage_work")]
            public static extern int ZhetrfAa2stageWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrf_aa_2stage")]
            public static extern int ZhetrfAa2stage(MatrixLayout matrixLayout, UpLoLapack uplo, int n, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs_aa_2stage")]
            public static extern int ZhetrsAa2stage(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs_aa_2stage_work")]
            public static extern int ZhetrsAa2stageWork(MatrixLayout matrixLayout, UpLoLapack uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);
        }
    }
}