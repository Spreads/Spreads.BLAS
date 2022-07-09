// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System;
using System.Runtime.InteropServices;
using System.Security;
using Spreads.DataTypes;

namespace Spreads.Native
{
    public static unsafe partial class OpenBLAS
    {
        public static class LAPACKE
        {
            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sbdsdc")]
            public static extern int Sbdsdc(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte compq, int n, float* d, float* e, float* u, int ldu, float* vt, int ldvt, float* q, int* iq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dbdsdc")]
            public static extern int Dbdsdc(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte compq, int n, double* d, double* e, double* u, int ldu, double* vt, int ldvt, double* q, int* iq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sbdsqr")]
            public static extern int Sbdsqr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, float* d, float* e, float* vt, int ldvt, float* u, int ldu, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dbdsqr")]
            public static extern int Dbdsqr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, double* d, double* e, double* vt, int ldvt, double* u, int ldu, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cbdsqr")]
            public static extern int Cbdsqr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, float* d, float* e, IntPtr vt, int ldvt, IntPtr u, int ldu, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zbdsqr")]
            public static extern int Zbdsqr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, double* d, double* e, IntPtr vt, int ldvt, IntPtr u, int ldu, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sbdsvdx")]
            public static extern int Sbdsvdx(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* ns, float* s, float* z, int ldz, int* superb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dbdsvdx")]
            public static extern int Dbdsvdx(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* ns, double* s, double* z, int ldz, int* superb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sdisna")]
            public static extern int Sdisna(sbyte job, int m, int n, float* d, float* sep);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ddisna")]
            public static extern int Ddisna(sbyte job, int m, int n, double* d, double* sep);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbbrd")]
            public static extern int Sgbbrd(BLAS.MatrixLayout matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, float* ab, int ldab, float* d, float* e, float* q, int ldq, float* pt, int ldpt, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbbrd")]
            public static extern int Dgbbrd(BLAS.MatrixLayout matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, double* ab, int ldab, double* d, double* e, double* q, int ldq, double* pt, int ldpt, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbbrd")]
            public static extern int Cgbbrd(BLAS.MatrixLayout matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, IntPtr ab, int ldab, float* d, float* e, IntPtr q, int ldq, IntPtr pt, int ldpt, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbbrd")]
            public static extern int Zgbbrd(BLAS.MatrixLayout matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, IntPtr ab, int ldab, double* d, double* e, IntPtr q, int ldq, IntPtr pt, int ldpt, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbcon")]
            public static extern int Sgbcon(BLAS.MatrixLayout matrixLayout, sbyte norm, int n, int kl, int ku, float* ab, int ldab, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbcon")]
            public static extern int Dgbcon(BLAS.MatrixLayout matrixLayout, sbyte norm, int n, int kl, int ku, double* ab, int ldab, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbcon")]
            public static extern int Cgbcon(BLAS.MatrixLayout matrixLayout, sbyte norm, int n, int kl, int ku, IntPtr ab, int ldab, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbcon")]
            public static extern int Zgbcon(BLAS.MatrixLayout matrixLayout, sbyte norm, int n, int kl, int ku, IntPtr ab, int ldab, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbequ")]
            public static extern int Sgbequ(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbequ")]
            public static extern int Dgbequ(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbequ")]
            public static extern int Cgbequ(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbequ")]
            public static extern int Zgbequ(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbequb")]
            public static extern int Sgbequb(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbequb")]
            public static extern int Dgbequb(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbequb")]
            public static extern int Cgbequb(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbequb")]
            public static extern int Zgbequb(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbrfs")]
            public static extern int Sgbrfs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbrfs")]
            public static extern int Dgbrfs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbrfs")]
            public static extern int Cgbrfs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbrfs")]
            public static extern int Zgbrfs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbrfsx")]
            public static extern int Sgbrfsx(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbrfsx")]
            public static extern int Dgbrfsx(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbrfsx")]
            public static extern int Cgbrfsx(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbrfsx")]
            public static extern int Zgbrfsx(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbsv")]
            public static extern int Sgbsv(BLAS.MatrixLayout matrixLayout, int n, int kl, int ku, int nrhs, float* ab, int ldab, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbsv")]
            public static extern int Dgbsv(BLAS.MatrixLayout matrixLayout, int n, int kl, int ku, int nrhs, double* ab, int ldab, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbsv")]
            public static extern int Cgbsv(BLAS.MatrixLayout matrixLayout, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbsv")]
            public static extern int Zgbsv(BLAS.MatrixLayout matrixLayout, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbsvx")]
            public static extern int Sgbsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* rpivot);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbsvx")]
            public static extern int Dgbsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* rpivot);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbsvx")]
            public static extern int Cgbsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, float* rpivot);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbsvx")]
            public static extern int Zgbsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, double* rpivot);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbsvxx")]
            public static extern int Sgbsvxx(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbsvxx")]
            public static extern int Dgbsvxx(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbsvxx")]
            public static extern int Cgbsvxx(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbsvxx")]
            public static extern int Zgbsvxx(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbtrf")]
            public static extern int Sgbtrf(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbtrf")]
            public static extern int Dgbtrf(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbtrf")]
            public static extern int Cgbtrf(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbtrf")]
            public static extern int Zgbtrf(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbtrs")]
            public static extern int Sgbtrs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbtrs")]
            public static extern int Dgbtrs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbtrs")]
            public static extern int Cgbtrs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbtrs")]
            public static extern int Zgbtrs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgebak")]
            public static extern int Sgebak(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* scale, int m, float* v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgebak")]
            public static extern int Dgebak(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* scale, int m, double* v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgebak")]
            public static extern int Cgebak(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* scale, int m, IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgebak")]
            public static extern int Zgebak(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* scale, int m, IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgebal")]
            public static extern int Sgebal(BLAS.MatrixLayout matrixLayout, sbyte job, int n, float* a, int lda, int* ilo, int* ihi, float* scale);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgebal")]
            public static extern int Dgebal(BLAS.MatrixLayout matrixLayout, sbyte job, int n, double* a, int lda, int* ilo, int* ihi, double* scale);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgebal")]
            public static extern int Cgebal(BLAS.MatrixLayout matrixLayout, sbyte job, int n, IntPtr a, int lda, int* ilo, int* ihi, float* scale);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgebal")]
            public static extern int Zgebal(BLAS.MatrixLayout matrixLayout, sbyte job, int n, IntPtr a, int lda, int* ilo, int* ihi, double* scale);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgebrd")]
            public static extern int Sgebrd(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* d, float* e, float* tauq, float* taup);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgebrd")]
            public static extern int Dgebrd(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* d, double* e, double* tauq, double* taup);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgebrd")]
            public static extern int Cgebrd(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, float* d, float* e, IntPtr tauq, IntPtr taup);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgebrd")]
            public static extern int Zgebrd(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, double* d, double* e, IntPtr tauq, IntPtr taup);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgecon")]
            public static extern int Sgecon(BLAS.MatrixLayout matrixLayout, sbyte norm, int n, float* a, int lda, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgecon")]
            public static extern int Dgecon(BLAS.MatrixLayout matrixLayout, sbyte norm, int n, double* a, int lda, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgecon")]
            public static extern int Cgecon(BLAS.MatrixLayout matrixLayout, sbyte norm, int n, IntPtr a, int lda, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgecon")]
            public static extern int Zgecon(BLAS.MatrixLayout matrixLayout, sbyte norm, int n, IntPtr a, int lda, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeequ")]
            public static extern int Sgeequ(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeequ")]
            public static extern int Dgeequ(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeequ")]
            public static extern int Cgeequ(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeequ")]
            public static extern int Zgeequ(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeequb")]
            public static extern int Sgeequb(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeequb")]
            public static extern int Dgeequb(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeequb")]
            public static extern int Cgeequb(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeequb")]
            public static extern int Zgeequb(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgees")]
            public static extern int Sgees(BLAS.MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, int n, float* a, int lda, int* sdim, float* wr, float* wi, float* vs, int ldvs);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgees")]
            public static extern int Dgees(BLAS.MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, int n, double* a, int lda, int* sdim, double* wr, double* wi, double* vs, int ldvs);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgees")]
            public static extern int Cgees(BLAS.MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, int n, IntPtr a, int lda, int* sdim, IntPtr w, IntPtr vs, int ldvs);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgees")]
            public static extern int Zgees(BLAS.MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, int n, IntPtr a, int lda, int* sdim, IntPtr w, IntPtr vs, int ldvs);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeesx")]
            public static extern int Sgeesx(BLAS.MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, sbyte sense, int n, float* a, int lda, int* sdim, float* wr, float* wi, float* vs, int ldvs, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeesx")]
            public static extern int Dgeesx(BLAS.MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, sbyte sense, int n, double* a, int lda, int* sdim, double* wr, double* wi, double* vs, int ldvs, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeesx")]
            public static extern int Cgeesx(BLAS.MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, sbyte sense, int n, IntPtr a, int lda, int* sdim, IntPtr w, IntPtr vs, int ldvs, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeesx")]
            public static extern int Zgeesx(BLAS.MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, sbyte sense, int n, IntPtr a, int lda, int* sdim, IntPtr w, IntPtr vs, int ldvs, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeev")]
            public static extern int Sgeev(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* wr, float* wi, float* vl, int ldvl, float* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeev")]
            public static extern int Dgeev(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* wr, double* wi, double* vl, int ldvl, double* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeev")]
            public static extern int Cgeev(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeev")]
            public static extern int Zgeev(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeevx")]
            public static extern int Sgeevx(BLAS.MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, float* a, int lda, float* wr, float* wi, float* vl, int ldvl, float* vr, int ldvr, int* ilo, int* ihi, float* scale, float* abnrm, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeevx")]
            public static extern int Dgeevx(BLAS.MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, double* a, int lda, double* wr, double* wi, double* vl, int ldvl, double* vr, int ldvr, int* ilo, int* ihi, double* scale, double* abnrm, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeevx")]
            public static extern int Cgeevx(BLAS.MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, IntPtr a, int lda, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int* ilo, int* ihi, float* scale, float* abnrm, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeevx")]
            public static extern int Zgeevx(BLAS.MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, IntPtr a, int lda, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int* ilo, int* ihi, double* scale, double* abnrm, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgehrd")]
            public static extern int Sgehrd(BLAS.MatrixLayout matrixLayout, int n, int ilo, int ihi, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgehrd")]
            public static extern int Dgehrd(BLAS.MatrixLayout matrixLayout, int n, int ilo, int ihi, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgehrd")]
            public static extern int Cgehrd(BLAS.MatrixLayout matrixLayout, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgehrd")]
            public static extern int Zgehrd(BLAS.MatrixLayout matrixLayout, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgejsv")]
            public static extern int Sgejsv(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, float* a, int lda, float* sva, float* u, int ldu, float* v, int ldv, float* stat, int* istat);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgejsv")]
            public static extern int Dgejsv(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, double* a, int lda, double* sva, double* u, int ldu, double* v, int ldv, double* stat, int* istat);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgejsv")]
            public static extern int Cgejsv(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, IntPtr a, int lda, float* sva, IntPtr u, int ldu, IntPtr v, int ldv, float* stat, int* istat);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgejsv")]
            public static extern int Zgejsv(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, IntPtr a, int lda, double* sva, IntPtr u, int ldu, IntPtr v, int ldv, double* stat, int* istat);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelq2")]
            public static extern int Sgelq2(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelq2")]
            public static extern int Dgelq2(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelq2")]
            public static extern int Cgelq2(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelq2")]
            public static extern int Zgelq2(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelqf")]
            public static extern int Sgelqf(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelqf")]
            public static extern int Dgelqf(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelqf")]
            public static extern int Cgelqf(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelqf")]
            public static extern int Zgelqf(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgels")]
            public static extern int Sgels(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgels")]
            public static extern int Dgels(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgels")]
            public static extern int Cgels(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgels")]
            public static extern int Zgels(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelsd")]
            public static extern int Sgelsd(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* s, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelsd")]
            public static extern int Dgelsd(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* s, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelsd")]
            public static extern int Cgelsd(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, float* s, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelsd")]
            public static extern int Zgelsd(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, double* s, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelss")]
            public static extern int Sgelss(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* s, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelss")]
            public static extern int Dgelss(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* s, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelss")]
            public static extern int Cgelss(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, float* s, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelss")]
            public static extern int Zgelss(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, double* s, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelsy")]
            public static extern int Sgelsy(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, int* jpvt, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelsy")]
            public static extern int Dgelsy(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, int* jpvt, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelsy")]
            public static extern int Cgelsy(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, int* jpvt, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelsy")]
            public static extern int Zgelsy(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, int* jpvt, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqlf")]
            public static extern int Sgeqlf(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqlf")]
            public static extern int Dgeqlf(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqlf")]
            public static extern int Cgeqlf(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqlf")]
            public static extern int Zgeqlf(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqp3")]
            public static extern int Sgeqp3(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, int* jpvt, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqp3")]
            public static extern int Dgeqp3(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, int* jpvt, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqp3")]
            public static extern int Cgeqp3(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* jpvt, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqp3")]
            public static extern int Zgeqp3(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* jpvt, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqpf")]
            public static extern int Sgeqpf(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, int* jpvt, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqpf")]
            public static extern int Dgeqpf(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, int* jpvt, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqpf")]
            public static extern int Cgeqpf(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* jpvt, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqpf")]
            public static extern int Zgeqpf(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* jpvt, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqr2")]
            public static extern int Sgeqr2(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqr2")]
            public static extern int Dgeqr2(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqr2")]
            public static extern int Cgeqr2(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqr2")]
            public static extern int Zgeqr2(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqrf")]
            public static extern int Sgeqrf(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqrf")]
            public static extern int Dgeqrf(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqrf")]
            public static extern int Cgeqrf(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqrf")]
            public static extern int Zgeqrf(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqrfp")]
            public static extern int Sgeqrfp(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqrfp")]
            public static extern int Dgeqrfp(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqrfp")]
            public static extern int Cgeqrfp(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqrfp")]
            public static extern int Zgeqrfp(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgerfs")]
            public static extern int Sgerfs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgerfs")]
            public static extern int Dgerfs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgerfs")]
            public static extern int Cgerfs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgerfs")]
            public static extern int Zgerfs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgerfsx")]
            public static extern int Sgerfsx(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgerfsx")]
            public static extern int Dgerfsx(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgerfsx")]
            public static extern int Cgerfsx(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgerfsx")]
            public static extern int Zgerfsx(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgerqf")]
            public static extern int Sgerqf(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgerqf")]
            public static extern int Dgerqf(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgerqf")]
            public static extern int Cgerqf(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgerqf")]
            public static extern int Zgerqf(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesdd")]
            public static extern int Sgesdd(BLAS.MatrixLayout matrixLayout, sbyte jobz, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* vt, int ldvt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesdd")]
            public static extern int Dgesdd(BLAS.MatrixLayout matrixLayout, sbyte jobz, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* vt, int ldvt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesdd")]
            public static extern int Cgesdd(BLAS.MatrixLayout matrixLayout, sbyte jobz, int m, int n, IntPtr a, int lda, float* s, IntPtr u, int ldu, IntPtr vt, int ldvt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesdd")]
            public static extern int Zgesdd(BLAS.MatrixLayout matrixLayout, sbyte jobz, int m, int n, IntPtr a, int lda, double* s, IntPtr u, int ldu, IntPtr vt, int ldvt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesv")]
            public static extern int Sgesv(BLAS.MatrixLayout matrixLayout, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesv")]
            public static extern int Dgesv(BLAS.MatrixLayout matrixLayout, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesv")]
            public static extern int Cgesv(BLAS.MatrixLayout matrixLayout, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesv")]
            public static extern int Zgesv(BLAS.MatrixLayout matrixLayout, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsgesv")]
            public static extern int Dsgesv(BLAS.MatrixLayout matrixLayout, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* x, int ldx, int* iter);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zcgesv")]
            public static extern int Zcgesv(BLAS.MatrixLayout matrixLayout, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, int* iter);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvd")]
            public static extern int Sgesvd(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* vt, int ldvt, float* superb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvd")]
            public static extern int Dgesvd(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* vt, int ldvt, double* superb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvd")]
            public static extern int Cgesvd(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, IntPtr a, int lda, float* s, IntPtr u, int ldu, IntPtr vt, int ldvt, float* superb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvd")]
            public static extern int Zgesvd(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, IntPtr a, int lda, double* s, IntPtr u, int ldu, IntPtr vt, int ldvt, double* superb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvdx")]
            public static extern int Sgesvdx(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, float* a, int lda, float vl, float vu, int il, int iu, int* ns, float* s, float* u, int ldu, float* vt, int ldvt, int* superb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvdx")]
            public static extern int Dgesvdx(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, double* a, int lda, double vl, double vu, int il, int iu, int* ns, double* s, double* u, int ldu, double* vt, int ldvt, int* superb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvdx")]
            public static extern int Cgesvdx(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, IntPtr a, int lda, float vl, float vu, int il, int iu, int* ns, float* s, IntPtr u, int ldu, IntPtr vt, int ldvt, int* superb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvdx")]
            public static extern int Zgesvdx(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, IntPtr a, int lda, double vl, double vu, int il, int iu, int* ns, double* s, IntPtr u, int ldu, IntPtr vt, int ldvt, int* superb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvdq")]
            public static extern int Sgesvdq(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobp, sbyte jobr, sbyte jobu, sbyte jobv, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* v, int ldv, int* numrank);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvdq")]
            public static extern int Dgesvdq(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobp, sbyte jobr, sbyte jobu, sbyte jobv, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* v, int ldv, int* numrank);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvdq")]
            public static extern int Cgesvdq(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobp, sbyte jobr, sbyte jobu, sbyte jobv, int m, int n, IntPtr a, int lda, float* s, IntPtr u, int ldu, IntPtr v, int ldv, int* numrank);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvdq")]
            public static extern int Zgesvdq(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobp, sbyte jobr, sbyte jobu, sbyte jobv, int m, int n, IntPtr a, int lda, double* s, IntPtr u, int ldu, IntPtr v, int ldv, int* numrank);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvj")]
            public static extern int Sgesvj(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, float* a, int lda, float* sva, int mv, float* v, int ldv, float* stat);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvj")]
            public static extern int Dgesvj(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, double* a, int lda, double* sva, int mv, double* v, int ldv, double* stat);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvj")]
            public static extern int Cgesvj(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, IntPtr a, int lda, float* sva, int mv, IntPtr v, int ldv, float* stat);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvj")]
            public static extern int Zgesvj(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, IntPtr a, int lda, double* sva, int mv, IntPtr v, int ldv, double* stat);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvx")]
            public static extern int Sgesvx(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* rpivot);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvx")]
            public static extern int Dgesvx(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* rpivot);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvx")]
            public static extern int Cgesvx(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, float* rpivot);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvx")]
            public static extern int Zgesvx(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, double* rpivot);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvxx")]
            public static extern int Sgesvxx(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvxx")]
            public static extern int Dgesvxx(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvxx")]
            public static extern int Cgesvxx(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvxx")]
            public static extern int Zgesvxx(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetf2")]
            public static extern int Sgetf2(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetf2")]
            public static extern int Dgetf2(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetf2")]
            public static extern int Cgetf2(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetf2")]
            public static extern int Zgetf2(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetrf")]
            public static extern int Sgetrf(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetrf")]
            public static extern int Dgetrf(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetrf")]
            public static extern int Cgetrf(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetrf")]
            public static extern int Zgetrf(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetrf2")]
            public static extern int Sgetrf2(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetrf2")]
            public static extern int Dgetrf2(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetrf2")]
            public static extern int Cgetrf2(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetrf2")]
            public static extern int Zgetrf2(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetri")]
            public static extern int Sgetri(BLAS.MatrixLayout matrixLayout, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetri")]
            public static extern int Dgetri(BLAS.MatrixLayout matrixLayout, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetri")]
            public static extern int Cgetri(BLAS.MatrixLayout matrixLayout, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetri")]
            public static extern int Zgetri(BLAS.MatrixLayout matrixLayout, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetrs")]
            public static extern int Sgetrs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetrs")]
            public static extern int Dgetrs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetrs")]
            public static extern int Cgetrs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetrs")]
            public static extern int Zgetrs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggbak")]
            public static extern int Sggbak(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* lscale, float* rscale, int m, float* v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggbak")]
            public static extern int Dggbak(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* lscale, double* rscale, int m, double* v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggbak")]
            public static extern int Cggbak(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* lscale, float* rscale, int m, IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggbak")]
            public static extern int Zggbak(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* lscale, double* rscale, int m, IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggbal")]
            public static extern int Sggbal(BLAS.MatrixLayout matrixLayout, sbyte job, int n, float* a, int lda, float* b, int ldb, int* ilo, int* ihi, float* lscale, float* rscale);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggbal")]
            public static extern int Dggbal(BLAS.MatrixLayout matrixLayout, sbyte job, int n, double* a, int lda, double* b, int ldb, int* ilo, int* ihi, double* lscale, double* rscale);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggbal")]
            public static extern int Cggbal(BLAS.MatrixLayout matrixLayout, sbyte job, int n, IntPtr a, int lda, IntPtr b, int ldb, int* ilo, int* ihi, float* lscale, float* rscale);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggbal")]
            public static extern int Zggbal(BLAS.MatrixLayout matrixLayout, sbyte job, int n, IntPtr a, int lda, IntPtr b, int ldb, int* ilo, int* ihi, double* lscale, double* rscale);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgges")]
            public static extern int Sgges(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, float* a, int lda, float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgges")]
            public static extern int Dgges(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, double* a, int lda, double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgges")]
            public static extern int Cgges(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgges")]
            public static extern int Zgges(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgges3")]
            public static extern int Sgges3(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, float* a, int lda, float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgges3")]
            public static extern int Dgges3(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, double* a, int lda, double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgges3")]
            public static extern int Cgges3(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgges3")]
            public static extern int Zgges3(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggesx")]
            public static extern int Sggesx(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, sbyte sense, int n, float* a, int lda, float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggesx")]
            public static extern int Dggesx(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, sbyte sense, int n, double* a, int lda, double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggesx")]
            public static extern int Cggesx(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, sbyte sense, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggesx")]
            public static extern int Zggesx(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, sbyte sense, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggev")]
            public static extern int Sggev(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggev")]
            public static extern int Dggev(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggev")]
            public static extern int Cggev(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggev")]
            public static extern int Zggev(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggev3")]
            public static extern int Sggev3(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggev3")]
            public static extern int Dggev3(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggev3")]
            public static extern int Cggev3(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggev3")]
            public static extern int Zggev3(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggevx")]
            public static extern int Sggevx(BLAS.MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr, int* ilo, int* ihi, float* lscale, float* rscale, float* abnrm, float* bbnrm, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggevx")]
            public static extern int Dggevx(BLAS.MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr, int* ilo, int* ihi, double* lscale, double* rscale, double* abnrm, double* bbnrm, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggevx")]
            public static extern int Cggevx(BLAS.MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int* ilo, int* ihi, float* lscale, float* rscale, float* abnrm, float* bbnrm, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggevx")]
            public static extern int Zggevx(BLAS.MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int* ilo, int* ihi, double* lscale, double* rscale, double* abnrm, double* bbnrm, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggglm")]
            public static extern int Sggglm(BLAS.MatrixLayout matrixLayout, int n, int m, int p, float* a, int lda, float* b, int ldb, float* d, float* x, float* y);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggglm")]
            public static extern int Dggglm(BLAS.MatrixLayout matrixLayout, int n, int m, int p, double* a, int lda, double* b, int ldb, double* d, double* x, double* y);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggglm")]
            public static extern int Cggglm(BLAS.MatrixLayout matrixLayout, int n, int m, int p, IntPtr a, int lda, IntPtr b, int ldb, IntPtr d, IntPtr x, IntPtr y);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggglm")]
            public static extern int Zggglm(BLAS.MatrixLayout matrixLayout, int n, int m, int p, IntPtr a, int lda, IntPtr b, int ldb, IntPtr d, IntPtr x, IntPtr y);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgghrd")]
            public static extern int Sgghrd(BLAS.MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgghrd")]
            public static extern int Dgghrd(BLAS.MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgghrd")]
            public static extern int Cgghrd(BLAS.MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgghrd")]
            public static extern int Zgghrd(BLAS.MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgghd3")]
            public static extern int Sgghd3(BLAS.MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgghd3")]
            public static extern int Dgghd3(BLAS.MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgghd3")]
            public static extern int Cgghd3(BLAS.MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgghd3")]
            public static extern int Zgghd3(BLAS.MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgglse")]
            public static extern int Sgglse(BLAS.MatrixLayout matrixLayout, int m, int n, int p, float* a, int lda, float* b, int ldb, float* c, float* d, float* x);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgglse")]
            public static extern int Dgglse(BLAS.MatrixLayout matrixLayout, int m, int n, int p, double* a, int lda, double* b, int ldb, double* c, double* d, double* x);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgglse")]
            public static extern int Cgglse(BLAS.MatrixLayout matrixLayout, int m, int n, int p, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, IntPtr d, IntPtr x);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgglse")]
            public static extern int Zgglse(BLAS.MatrixLayout matrixLayout, int m, int n, int p, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, IntPtr d, IntPtr x);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggqrf")]
            public static extern int Sggqrf(BLAS.MatrixLayout matrixLayout, int n, int m, int p, float* a, int lda, float* taua, float* b, int ldb, float* taub);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggqrf")]
            public static extern int Dggqrf(BLAS.MatrixLayout matrixLayout, int n, int m, int p, double* a, int lda, double* taua, double* b, int ldb, double* taub);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggqrf")]
            public static extern int Cggqrf(BLAS.MatrixLayout matrixLayout, int n, int m, int p, IntPtr a, int lda, IntPtr taua, IntPtr b, int ldb, IntPtr taub);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggqrf")]
            public static extern int Zggqrf(BLAS.MatrixLayout matrixLayout, int n, int m, int p, IntPtr a, int lda, IntPtr taua, IntPtr b, int ldb, IntPtr taub);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggrqf")]
            public static extern int Sggrqf(BLAS.MatrixLayout matrixLayout, int m, int p, int n, float* a, int lda, float* taua, float* b, int ldb, float* taub);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggrqf")]
            public static extern int Dggrqf(BLAS.MatrixLayout matrixLayout, int m, int p, int n, double* a, int lda, double* taua, double* b, int ldb, double* taub);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggrqf")]
            public static extern int Cggrqf(BLAS.MatrixLayout matrixLayout, int m, int p, int n, IntPtr a, int lda, IntPtr taua, IntPtr b, int ldb, IntPtr taub);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggrqf")]
            public static extern int Zggrqf(BLAS.MatrixLayout matrixLayout, int m, int p, int n, IntPtr a, int lda, IntPtr taua, IntPtr b, int ldb, IntPtr taub);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggsvd")]
            public static extern int Sggsvd(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, float* a, int lda, float* b, int ldb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggsvd")]
            public static extern int Dggsvd(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, double* a, int lda, double* b, int ldb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggsvd")]
            public static extern int Cggsvd(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, IntPtr a, int lda, IntPtr b, int ldb, float* alpha, float* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggsvd")]
            public static extern int Zggsvd(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, IntPtr a, int lda, IntPtr b, int ldb, double* alpha, double* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggsvd3")]
            public static extern int Sggsvd3(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, float* a, int lda, float* b, int ldb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggsvd3")]
            public static extern int Dggsvd3(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, double* a, int lda, double* b, int ldb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggsvd3")]
            public static extern int Cggsvd3(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, IntPtr a, int lda, IntPtr b, int ldb, float* alpha, float* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggsvd3")]
            public static extern int Zggsvd3(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, IntPtr a, int lda, IntPtr b, int ldb, double* alpha, double* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggsvp")]
            public static extern int Sggsvp(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, float* a, int lda, float* b, int ldb, float tola, float tolb, int* k, int* l, float* u, int ldu, float* v, int ldv, float* q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggsvp")]
            public static extern int Dggsvp(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, double* a, int lda, double* b, int ldb, double tola, double tolb, int* k, int* l, double* u, int ldu, double* v, int ldv, double* q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggsvp")]
            public static extern int Cggsvp(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, IntPtr a, int lda, IntPtr b, int ldb, float tola, float tolb, int* k, int* l, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggsvp")]
            public static extern int Zggsvp(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, IntPtr a, int lda, IntPtr b, int ldb, double tola, double tolb, int* k, int* l, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggsvp3")]
            public static extern int Sggsvp3(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, float* a, int lda, float* b, int ldb, float tola, float tolb, int* k, int* l, float* u, int ldu, float* v, int ldv, float* q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggsvp3")]
            public static extern int Dggsvp3(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, double* a, int lda, double* b, int ldb, double tola, double tolb, int* k, int* l, double* u, int ldu, double* v, int ldv, double* q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggsvp3")]
            public static extern int Cggsvp3(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, IntPtr a, int lda, IntPtr b, int ldb, float tola, float tolb, int* k, int* l, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggsvp3")]
            public static extern int Zggsvp3(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, IntPtr a, int lda, IntPtr b, int ldb, double tola, double tolb, int* k, int* l, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgtcon")]
            public static extern int Sgtcon(sbyte norm, int n, float* dl, float* d, float* du, float* du2, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgtcon")]
            public static extern int Dgtcon(sbyte norm, int n, double* dl, double* d, double* du, double* du2, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgtcon")]
            public static extern int Cgtcon(sbyte norm, int n, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgtcon")]
            public static extern int Zgtcon(sbyte norm, int n, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgtrfs")]
            public static extern int Sgtrfs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* dl, float* d, float* du, float* dlf, float* df, float* duf, float* du2, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgtrfs")]
            public static extern int Dgtrfs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* dl, double* d, double* du, double* dlf, double* df, double* duf, double* du2, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgtrfs")]
            public static extern int Cgtrfs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr dlf, IntPtr df, IntPtr duf, IntPtr du2, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgtrfs")]
            public static extern int Zgtrfs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr dlf, IntPtr df, IntPtr duf, IntPtr du2, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgtsv")]
            public static extern int Sgtsv(BLAS.MatrixLayout matrixLayout, int n, int nrhs, float* dl, float* d, float* du, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgtsv")]
            public static extern int Dgtsv(BLAS.MatrixLayout matrixLayout, int n, int nrhs, double* dl, double* d, double* du, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgtsv")]
            public static extern int Cgtsv(BLAS.MatrixLayout matrixLayout, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgtsv")]
            public static extern int Zgtsv(BLAS.MatrixLayout matrixLayout, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgtsvx")]
            public static extern int Sgtsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, float* dl, float* d, float* du, float* dlf, float* df, float* duf, float* du2, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgtsvx")]
            public static extern int Dgtsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, double* dl, double* d, double* du, double* dlf, double* df, double* duf, double* du2, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgtsvx")]
            public static extern int Cgtsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr dlf, IntPtr df, IntPtr duf, IntPtr du2, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgtsvx")]
            public static extern int Zgtsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr dlf, IntPtr df, IntPtr duf, IntPtr du2, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgttrf")]
            public static extern int Sgttrf(int n, float* dl, float* d, float* du, float* du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgttrf")]
            public static extern int Dgttrf(int n, double* dl, double* d, double* du, double* du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgttrf")]
            public static extern int Cgttrf(int n, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgttrf")]
            public static extern int Zgttrf(int n, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgttrs")]
            public static extern int Sgttrs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* dl, float* d, float* du, float* du2, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgttrs")]
            public static extern int Dgttrs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* dl, double* d, double* du, double* du2, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgttrs")]
            public static extern int Cgttrs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgttrs")]
            public static extern int Zgttrs(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbev")]
            public static extern int Chbev(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, IntPtr ab, int ldab, float* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbev")]
            public static extern int Zhbev(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, IntPtr ab, int ldab, double* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbevd")]
            public static extern int Chbevd(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, IntPtr ab, int ldab, float* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbevd")]
            public static extern int Zhbevd(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, IntPtr ab, int ldab, double* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbevx")]
            public static extern int Chbevx(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, IntPtr ab, int ldab, IntPtr q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbevx")]
            public static extern int Zhbevx(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, IntPtr ab, int ldab, IntPtr q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbgst")]
            public static extern int Chbgst(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, IntPtr x, int ldx);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbgst")]
            public static extern int Zhbgst(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, IntPtr x, int ldx);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbgv")]
            public static extern int Chbgv(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, float* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbgv")]
            public static extern int Zhbgv(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, double* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbgvd")]
            public static extern int Chbgvd(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, float* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbgvd")]
            public static extern int Zhbgvd(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, double* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbgvx")]
            public static extern int Chbgvx(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, IntPtr q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbgvx")]
            public static extern int Zhbgvx(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, IntPtr q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbtrd")]
            public static extern int Chbtrd(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte uplo, int n, int kd, IntPtr ab, int ldab, float* d, float* e, IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbtrd")]
            public static extern int Zhbtrd(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte uplo, int n, int kd, IntPtr ab, int ldab, double* d, double* e, IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_checon")]
            public static extern int Checon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhecon")]
            public static extern int Zhecon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheequb")]
            public static extern int Cheequb(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheequb")]
            public static extern int Zheequb(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheev")]
            public static extern int Cheev(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheev")]
            public static extern int Zheev(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevd")]
            public static extern int Cheevd(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevd")]
            public static extern int Zheevd(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevr")]
            public static extern int Cheevr(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevr")]
            public static extern int Zheevr(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevx")]
            public static extern int Cheevx(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevx")]
            public static extern int Zheevx(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chegst")]
            public static extern int Chegst(BLAS.MatrixLayout matrixLayout, int itype, sbyte uplo, int n, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhegst")]
            public static extern int Zhegst(BLAS.MatrixLayout matrixLayout, int itype, sbyte uplo, int n, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chegv")]
            public static extern int Chegv(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhegv")]
            public static extern int Zhegv(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chegvd")]
            public static extern int Chegvd(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhegvd")]
            public static extern int Zhegvd(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chegvx")]
            public static extern int Chegvx(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhegvx")]
            public static extern int Zhegvx(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cherfs")]
            public static extern int Cherfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zherfs")]
            public static extern int Zherfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cherfsx")]
            public static extern int Cherfsx(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zherfsx")]
            public static extern int Zherfsx(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesv")]
            public static extern int Chesv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesv")]
            public static extern int Zhesv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesvx")]
            public static extern int Chesvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesvx")]
            public static extern int Zhesvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesvxx")]
            public static extern int Chesvxx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesvxx")]
            public static extern int Zhesvxx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrd")]
            public static extern int Chetrd(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, float* d, float* e, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrd")]
            public static extern int Zhetrd(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, double* d, double* e, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrf")]
            public static extern int Chetrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrf")]
            public static extern int Zhetrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetri")]
            public static extern int Chetri(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetri")]
            public static extern int Zhetri(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs")]
            public static extern int Chetrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs")]
            public static extern int Zhetrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chfrk")]
            public static extern int Chfrk(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, float alpha, IntPtr a, int lda, float beta, IntPtr c);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhfrk")]
            public static extern int Zhfrk(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, double alpha, IntPtr a, int lda, double beta, IntPtr c);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_shgeqz")]
            public static extern int Shgeqz(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* h, int ldh, float* t, int ldt, float* alphar, float* alphai, float* beta, float* q, int ldq, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dhgeqz")]
            public static extern int Dhgeqz(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* h, int ldh, double* t, int ldt, double* alphar, double* alphai, double* beta, double* q, int ldq, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chgeqz")]
            public static extern int Chgeqz(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr h, int ldh, IntPtr t, int ldt, IntPtr alpha, IntPtr beta, IntPtr q, int ldq, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhgeqz")]
            public static extern int Zhgeqz(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr h, int ldh, IntPtr t, int ldt, IntPtr alpha, IntPtr beta, IntPtr q, int ldq, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpcon")]
            public static extern int Chpcon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpcon")]
            public static extern int Zhpcon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpev")]
            public static extern int Chpev(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr ap, float* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpev")]
            public static extern int Zhpev(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr ap, double* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpevd")]
            public static extern int Chpevd(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr ap, float* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpevd")]
            public static extern int Zhpevd(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr ap, double* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpevx")]
            public static extern int Chpevx(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr ap, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpevx")]
            public static extern int Zhpevx(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr ap, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpgst")]
            public static extern int Chpgst(BLAS.MatrixLayout matrixLayout, int itype, sbyte uplo, int n, IntPtr ap, IntPtr bp);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpgst")]
            public static extern int Zhpgst(BLAS.MatrixLayout matrixLayout, int itype, sbyte uplo, int n, IntPtr ap, IntPtr bp);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpgv")]
            public static extern int Chpgv(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, IntPtr ap, IntPtr bp, float* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpgv")]
            public static extern int Zhpgv(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, IntPtr ap, IntPtr bp, double* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpgvd")]
            public static extern int Chpgvd(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, IntPtr ap, IntPtr bp, float* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpgvd")]
            public static extern int Zhpgvd(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, IntPtr ap, IntPtr bp, double* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpgvx")]
            public static extern int Chpgvx(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr ap, IntPtr bp, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpgvx")]
            public static extern int Zhpgvx(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr ap, IntPtr bp, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chprfs")]
            public static extern int Chprfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhprfs")]
            public static extern int Zhprfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpsv")]
            public static extern int Chpsv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpsv")]
            public static extern int Zhpsv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpsvx")]
            public static extern int Chpsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpsvx")]
            public static extern int Zhpsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chptrd")]
            public static extern int Chptrd(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, float* d, float* e, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhptrd")]
            public static extern int Zhptrd(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, double* d, double* e, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chptrf")]
            public static extern int Chptrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhptrf")]
            public static extern int Zhptrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chptri")]
            public static extern int Chptri(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhptri")]
            public static extern int Zhptri(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chptrs")]
            public static extern int Chptrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhptrs")]
            public static extern int Zhptrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_shsein")]
            public static extern int Shsein(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, float* h, int ldh, float* wr, float* wi, float* vl, int ldvl, float* vr, int ldvr, int mm, int* m, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dhsein")]
            public static extern int Dhsein(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, double* h, int ldh, double* wr, double* wi, double* vl, int ldvl, double* vr, int ldvr, int mm, int* m, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chsein")]
            public static extern int Chsein(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, IntPtr h, int ldh, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhsein")]
            public static extern int Zhsein(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, IntPtr h, int ldh, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_shseqr")]
            public static extern int Shseqr(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, float* h, int ldh, float* wr, float* wi, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dhseqr")]
            public static extern int Dhseqr(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, double* h, int ldh, double* wr, double* wi, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chseqr")]
            public static extern int Chseqr(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, IntPtr h, int ldh, IntPtr w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhseqr")]
            public static extern int Zhseqr(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, IntPtr h, int ldh, IntPtr w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clacgv")]
            public static extern int Clacgv(int n, IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlacgv")]
            public static extern int Zlacgv(int n, IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slacn2")]
            public static extern int Slacn2(int n, float* v, float* x, int* isgn, float* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlacn2")]
            public static extern int Dlacn2(int n, double* v, double* x, int* isgn, double* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clacn2")]
            public static extern int Clacn2(int n, IntPtr v, IntPtr x, float* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlacn2")]
            public static extern int Zlacn2(int n, IntPtr v, IntPtr x, double* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slacpy")]
            public static extern int Slacpy(BLAS.MatrixLayout matrixLayout, sbyte uplo, int m, int n, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlacpy")]
            public static extern int Dlacpy(BLAS.MatrixLayout matrixLayout, sbyte uplo, int m, int n, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clacpy")]
            public static extern int Clacpy(BLAS.MatrixLayout matrixLayout, sbyte uplo, int m, int n, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlacpy")]
            public static extern int Zlacpy(BLAS.MatrixLayout matrixLayout, sbyte uplo, int m, int n, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clacp2")]
            public static extern int Clacp2(BLAS.MatrixLayout matrixLayout, sbyte uplo, int m, int n, float* a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlacp2")]
            public static extern int Zlacp2(BLAS.MatrixLayout matrixLayout, sbyte uplo, int m, int n, double* a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlag2c")]
            public static extern int Zlag2c(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr sa, int ldsa);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slag2d")]
            public static extern int Slag2d(BLAS.MatrixLayout matrixLayout, int m, int n, float* sa, int ldsa, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlag2s")]
            public static extern int Dlag2s(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, float* sa, int ldsa);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clag2z")]
            public static extern int Clag2z(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr sa, int ldsa, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slagge")]
            public static extern int Slagge(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, float* d, float* a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlagge")]
            public static extern int Dlagge(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, double* d, double* a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clagge")]
            public static extern int Clagge(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, float* d, IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlagge")]
            public static extern int Zlagge(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, double* d, IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slamch")]
            public static extern float Slamch(sbyte cmach);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlamch")]
            public static extern double Dlamch(sbyte cmach);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slange")]
            public static extern float Slange(BLAS.MatrixLayout matrixLayout, sbyte norm, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlange")]
            public static extern double Dlange(BLAS.MatrixLayout matrixLayout, sbyte norm, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clange")]
            public static extern float Clange(BLAS.MatrixLayout matrixLayout, sbyte norm, int m, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlange")]
            public static extern double Zlange(BLAS.MatrixLayout matrixLayout, sbyte norm, int m, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clanhe")]
            public static extern float Clanhe(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlanhe")]
            public static extern double Zlanhe(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clacrm")]
            public static extern int Clacrm(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, float* b, int ldb, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlacrm")]
            public static extern int Zlacrm(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, double* b, int ldb, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarcm")]
            public static extern int Clarcm(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, IntPtr b, int ldb, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarcm")]
            public static extern int Zlarcm(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, IntPtr b, int ldb, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slansy")]
            public static extern float Slansy(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlansy")]
            public static extern double Dlansy(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clansy")]
            public static extern float Clansy(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlansy")]
            public static extern double Zlansy(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slantr")]
            public static extern float Slantr(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlantr")]
            public static extern double Dlantr(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clantr")]
            public static extern float Clantr(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlantr")]
            public static extern double Zlantr(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slarfb")]
            public static extern int Slarfb(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, float* v, int ldv, float* t, int ldt, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlarfb")]
            public static extern int Dlarfb(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, double* v, int ldv, double* t, int ldt, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarfb")]
            public static extern int Clarfb(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarfb")]
            public static extern int Zlarfb(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slarfg")]
            public static extern int Slarfg(int n, float* alpha, float* x, int incx, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlarfg")]
            public static extern int Dlarfg(int n, double* alpha, double* x, int incx, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarfg")]
            public static extern int Clarfg(int n, IntPtr alpha, IntPtr x, int incx, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarfg")]
            public static extern int Zlarfg(int n, IntPtr alpha, IntPtr x, int incx, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slarft")]
            public static extern int Slarft(BLAS.MatrixLayout matrixLayout, sbyte direct, sbyte storev, int n, int k, float* v, int ldv, float* tau, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlarft")]
            public static extern int Dlarft(BLAS.MatrixLayout matrixLayout, sbyte direct, sbyte storev, int n, int k, double* v, int ldv, double* tau, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarft")]
            public static extern int Clarft(BLAS.MatrixLayout matrixLayout, sbyte direct, sbyte storev, int n, int k, IntPtr v, int ldv, IntPtr tau, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarft")]
            public static extern int Zlarft(BLAS.MatrixLayout matrixLayout, sbyte direct, sbyte storev, int n, int k, IntPtr v, int ldv, IntPtr tau, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slarfx")]
            public static extern int Slarfx(BLAS.MatrixLayout matrixLayout, sbyte side, int m, int n, float* v, float tau, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlarfx")]
            public static extern int Dlarfx(BLAS.MatrixLayout matrixLayout, sbyte side, int m, int n, double* v, double tau, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarfx")]
            public static extern int Clarfx(BLAS.MatrixLayout matrixLayout, sbyte side, int m, int n, IntPtr v, ComplexFloat tau, IntPtr c, int ldc, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarfx")]
            public static extern int Zlarfx(BLAS.MatrixLayout matrixLayout, sbyte side, int m, int n, IntPtr v, IntPtr tau, IntPtr c, int ldc, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slarnv")]
            public static extern int Slarnv(int idist, int* iseed, int n, float* x);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlarnv")]
            public static extern int Dlarnv(int idist, int* iseed, int n, double* x);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarnv")]
            public static extern int Clarnv(int idist, int* iseed, int n, IntPtr x);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarnv")]
            public static extern int Zlarnv(int idist, int* iseed, int n, IntPtr x);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slascl")]
            public static extern int Slascl(BLAS.MatrixLayout matrixLayout, sbyte type, int kl, int ku, float cfrom, float cto, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlascl")]
            public static extern int Dlascl(BLAS.MatrixLayout matrixLayout, sbyte type, int kl, int ku, double cfrom, double cto, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clascl")]
            public static extern int Clascl(BLAS.MatrixLayout matrixLayout, sbyte type, int kl, int ku, float cfrom, float cto, int m, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlascl")]
            public static extern int Zlascl(BLAS.MatrixLayout matrixLayout, sbyte type, int kl, int ku, double cfrom, double cto, int m, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slaset")]
            public static extern int Slaset(BLAS.MatrixLayout matrixLayout, sbyte uplo, int m, int n, float alpha, float beta, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlaset")]
            public static extern int Dlaset(BLAS.MatrixLayout matrixLayout, sbyte uplo, int m, int n, double alpha, double beta, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_claset")]
            public static extern int Claset(BLAS.MatrixLayout matrixLayout, sbyte uplo, int m, int n, ComplexFloat alpha, ComplexFloat beta, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlaset")]
            public static extern int Zlaset(BLAS.MatrixLayout matrixLayout, sbyte uplo, int m, int n, IntPtr alpha, IntPtr beta, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slasrt")]
            public static extern int Slasrt(sbyte id, int n, float* d);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlasrt")]
            public static extern int Dlasrt(sbyte id, int n, double* d);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slassq")]
            public static extern int Slassq(int n, float* x, int incx, float* scale, float* sumsq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlassq")]
            public static extern int Dlassq(int n, double* x, int incx, double* scale, double* sumsq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_classq")]
            public static extern int Classq(int n, IntPtr x, int incx, float* scale, float* sumsq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlassq")]
            public static extern int Zlassq(int n, IntPtr x, int incx, double* scale, double* sumsq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slaswp")]
            public static extern int Slaswp(BLAS.MatrixLayout matrixLayout, int n, float* a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlaswp")]
            public static extern int Dlaswp(BLAS.MatrixLayout matrixLayout, int n, double* a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_claswp")]
            public static extern int Claswp(BLAS.MatrixLayout matrixLayout, int n, IntPtr a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlaswp")]
            public static extern int Zlaswp(BLAS.MatrixLayout matrixLayout, int n, IntPtr a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slatms")]
            public static extern int Slatms(BLAS.MatrixLayout matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, float* d, int mode, float cond, float dmax, int kl, int ku, sbyte pack, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlatms")]
            public static extern int Dlatms(BLAS.MatrixLayout matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, double* d, int mode, double cond, double dmax, int kl, int ku, sbyte pack, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clatms")]
            public static extern int Clatms(BLAS.MatrixLayout matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, float* d, int mode, float cond, float dmax, int kl, int ku, sbyte pack, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlatms")]
            public static extern int Zlatms(BLAS.MatrixLayout matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, double* d, int mode, double cond, double dmax, int kl, int ku, sbyte pack, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slauum")]
            public static extern int Slauum(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlauum")]
            public static extern int Dlauum(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clauum")]
            public static extern int Clauum(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlauum")]
            public static extern int Zlauum(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sopgtr")]
            public static extern int Sopgtr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* ap, float* tau, float* q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dopgtr")]
            public static extern int Dopgtr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* ap, double* tau, double* q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sopmtr")]
            public static extern int Sopmtr(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, float* ap, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dopmtr")]
            public static extern int Dopmtr(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, double* ap, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorgbr")]
            public static extern int Sorgbr(BLAS.MatrixLayout matrixLayout, sbyte vect, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorgbr")]
            public static extern int Dorgbr(BLAS.MatrixLayout matrixLayout, sbyte vect, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorghr")]
            public static extern int Sorghr(BLAS.MatrixLayout matrixLayout, int n, int ilo, int ihi, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorghr")]
            public static extern int Dorghr(BLAS.MatrixLayout matrixLayout, int n, int ilo, int ihi, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorglq")]
            public static extern int Sorglq(BLAS.MatrixLayout matrixLayout, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorglq")]
            public static extern int Dorglq(BLAS.MatrixLayout matrixLayout, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorgql")]
            public static extern int Sorgql(BLAS.MatrixLayout matrixLayout, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorgql")]
            public static extern int Dorgql(BLAS.MatrixLayout matrixLayout, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorgqr")]
            public static extern int Sorgqr(BLAS.MatrixLayout matrixLayout, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorgqr")]
            public static extern int Dorgqr(BLAS.MatrixLayout matrixLayout, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorgrq")]
            public static extern int Sorgrq(BLAS.MatrixLayout matrixLayout, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorgrq")]
            public static extern int Dorgrq(BLAS.MatrixLayout matrixLayout, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorgtr")]
            public static extern int Sorgtr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorgtr")]
            public static extern int Dorgtr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormbr")]
            public static extern int Sormbr(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormbr")]
            public static extern int Dormbr(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormhr")]
            public static extern int Sormhr(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormhr")]
            public static extern int Dormhr(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormlq")]
            public static extern int Sormlq(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormlq")]
            public static extern int Dormlq(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormql")]
            public static extern int Sormql(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormql")]
            public static extern int Dormql(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormqr")]
            public static extern int Sormqr(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormqr")]
            public static extern int Dormqr(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormrq")]
            public static extern int Sormrq(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormrq")]
            public static extern int Dormrq(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormrz")]
            public static extern int Sormrz(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormrz")]
            public static extern int Dormrz(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormtr")]
            public static extern int Sormtr(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormtr")]
            public static extern int Dormtr(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbcon")]
            public static extern int Spbcon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, float* ab, int ldab, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbcon")]
            public static extern int Dpbcon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, double* ab, int ldab, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbcon")]
            public static extern int Cpbcon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, IntPtr ab, int ldab, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbcon")]
            public static extern int Zpbcon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, IntPtr ab, int ldab, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbequ")]
            public static extern int Spbequ(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, float* ab, int ldab, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbequ")]
            public static extern int Dpbequ(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, double* ab, int ldab, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbequ")]
            public static extern int Cpbequ(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, IntPtr ab, int ldab, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbequ")]
            public static extern int Zpbequ(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, IntPtr ab, int ldab, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbrfs")]
            public static extern int Spbrfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* afb, int ldafb, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbrfs")]
            public static extern int Dpbrfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* afb, int ldafb, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbrfs")]
            public static extern int Cpbrfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbrfs")]
            public static extern int Zpbrfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbstf")]
            public static extern int Spbstf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kb, float* bb, int ldbb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbstf")]
            public static extern int Dpbstf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kb, double* bb, int ldbb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbstf")]
            public static extern int Cpbstf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kb, IntPtr bb, int ldbb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbstf")]
            public static extern int Zpbstf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kb, IntPtr bb, int ldbb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbsv")]
            public static extern int Spbsv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbsv")]
            public static extern int Dpbsv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbsv")]
            public static extern int Cpbsv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbsv")]
            public static extern int Zpbsv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbsvx")]
            public static extern int Spbsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* afb, int ldafb, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbsvx")]
            public static extern int Dpbsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* afb, int ldafb, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbsvx")]
            public static extern int Cpbsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbsvx")]
            public static extern int Zpbsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbtrf")]
            public static extern int Spbtrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, float* ab, int ldab);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbtrf")]
            public static extern int Dpbtrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, double* ab, int ldab);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbtrf")]
            public static extern int Cpbtrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, IntPtr ab, int ldab);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbtrf")]
            public static extern int Zpbtrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, IntPtr ab, int ldab);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbtrs")]
            public static extern int Spbtrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbtrs")]
            public static extern int Dpbtrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbtrs")]
            public static extern int Cpbtrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbtrs")]
            public static extern int Zpbtrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spftrf")]
            public static extern int Spftrf(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, float* a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpftrf")]
            public static extern int Dpftrf(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, double* a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpftrf")]
            public static extern int Cpftrf(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpftrf")]
            public static extern int Zpftrf(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spftri")]
            public static extern int Spftri(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, float* a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpftri")]
            public static extern int Dpftri(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, double* a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpftri")]
            public static extern int Cpftri(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpftri")]
            public static extern int Zpftri(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spftrs")]
            public static extern int Spftrs(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, float* a, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpftrs")]
            public static extern int Dpftrs(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, double* a, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpftrs")]
            public static extern int Cpftrs(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, IntPtr a, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpftrs")]
            public static extern int Zpftrs(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, IntPtr a, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spocon")]
            public static extern int Spocon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpocon")]
            public static extern int Dpocon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpocon")]
            public static extern int Cpocon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpocon")]
            public static extern int Zpocon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spoequ")]
            public static extern int Spoequ(BLAS.MatrixLayout matrixLayout, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpoequ")]
            public static extern int Dpoequ(BLAS.MatrixLayout matrixLayout, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpoequ")]
            public static extern int Cpoequ(BLAS.MatrixLayout matrixLayout, int n, IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpoequ")]
            public static extern int Zpoequ(BLAS.MatrixLayout matrixLayout, int n, IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spoequb")]
            public static extern int Spoequb(BLAS.MatrixLayout matrixLayout, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpoequb")]
            public static extern int Dpoequb(BLAS.MatrixLayout matrixLayout, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpoequb")]
            public static extern int Cpoequb(BLAS.MatrixLayout matrixLayout, int n, IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpoequb")]
            public static extern int Zpoequb(BLAS.MatrixLayout matrixLayout, int n, IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sporfs")]
            public static extern int Sporfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dporfs")]
            public static extern int Dporfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cporfs")]
            public static extern int Cporfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zporfs")]
            public static extern int Zporfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sporfsx")]
            public static extern int Sporfsx(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dporfsx")]
            public static extern int Dporfsx(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cporfsx")]
            public static extern int Cporfsx(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zporfsx")]
            public static extern int Zporfsx(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sposv")]
            public static extern int Sposv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dposv")]
            public static extern int Dposv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cposv")]
            public static extern int Cposv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zposv")]
            public static extern int Zposv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsposv")]
            public static extern int Dsposv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb, double* x, int ldx, int* iter);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zcposv")]
            public static extern int Zcposv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, IntPtr x, int ldx, int* iter);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sposvx")]
            public static extern int Sposvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dposvx")]
            public static extern int Dposvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cposvx")]
            public static extern int Cposvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zposvx")]
            public static extern int Zposvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sposvxx")]
            public static extern int Sposvxx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dposvxx")]
            public static extern int Dposvxx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cposvxx")]
            public static extern int Cposvxx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zposvxx")]
            public static extern int Zposvxx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spotrf2")]
            public static extern int Spotrf2(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpotrf2")]
            public static extern int Dpotrf2(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpotrf2")]
            public static extern int Cpotrf2(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpotrf2")]
            public static extern int Zpotrf2(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spotrf")]
            public static extern int Spotrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpotrf")]
            public static extern int Dpotrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpotrf")]
            public static extern int Cpotrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpotrf")]
            public static extern int Zpotrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spotri")]
            public static extern int Spotri(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpotri")]
            public static extern int Dpotri(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpotri")]
            public static extern int Cpotri(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpotri")]
            public static extern int Zpotri(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spotrs")]
            public static extern int Spotrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpotrs")]
            public static extern int Dpotrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpotrs")]
            public static extern int Cpotrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpotrs")]
            public static extern int Zpotrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sppcon")]
            public static extern int Sppcon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* ap, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dppcon")]
            public static extern int Dppcon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* ap, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cppcon")]
            public static extern int Cppcon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zppcon")]
            public static extern int Zppcon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sppequ")]
            public static extern int Sppequ(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* ap, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dppequ")]
            public static extern int Dppequ(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* ap, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cppequ")]
            public static extern int Cppequ(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zppequ")]
            public static extern int Zppequ(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spprfs")]
            public static extern int Spprfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* afp, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpprfs")]
            public static extern int Dpprfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* afp, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpprfs")]
            public static extern int Cpprfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpprfs")]
            public static extern int Zpprfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sppsv")]
            public static extern int Sppsv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dppsv")]
            public static extern int Dppsv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cppsv")]
            public static extern int Cppsv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zppsv")]
            public static extern int Zppsv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sppsvx")]
            public static extern int Sppsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* ap, float* afp, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dppsvx")]
            public static extern int Dppsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* ap, double* afp, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cppsvx")]
            public static extern int Cppsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zppsvx")]
            public static extern int Zppsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spptrf")]
            public static extern int Spptrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpptrf")]
            public static extern int Dpptrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpptrf")]
            public static extern int Cpptrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpptrf")]
            public static extern int Zpptrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spptri")]
            public static extern int Spptri(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpptri")]
            public static extern int Dpptri(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpptri")]
            public static extern int Cpptri(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpptri")]
            public static extern int Zpptri(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spptrs")]
            public static extern int Spptrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpptrs")]
            public static extern int Dpptrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpptrs")]
            public static extern int Cpptrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpptrs")]
            public static extern int Zpptrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spstrf")]
            public static extern int Spstrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, int* piv, int* rank, float tol);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpstrf")]
            public static extern int Dpstrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, int* piv, int* rank, double tol);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpstrf")]
            public static extern int Cpstrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* piv, int* rank, float tol);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpstrf")]
            public static extern int Zpstrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* piv, int* rank, double tol);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sptcon")]
            public static extern int Sptcon(int n, float* d, float* e, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dptcon")]
            public static extern int Dptcon(int n, double* d, double* e, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cptcon")]
            public static extern int Cptcon(int n, float* d, IntPtr e, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zptcon")]
            public static extern int Zptcon(int n, double* d, IntPtr e, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spteqr")]
            public static extern int Spteqr(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpteqr")]
            public static extern int Dpteqr(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpteqr")]
            public static extern int Cpteqr(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpteqr")]
            public static extern int Zpteqr(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sptrfs")]
            public static extern int Sptrfs(BLAS.MatrixLayout matrixLayout, int n, int nrhs, float* d, float* e, float* df, float* ef, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dptrfs")]
            public static extern int Dptrfs(BLAS.MatrixLayout matrixLayout, int n, int nrhs, double* d, double* e, double* df, double* ef, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cptrfs")]
            public static extern int Cptrfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* d, IntPtr e, float* df, IntPtr ef, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zptrfs")]
            public static extern int Zptrfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* d, IntPtr e, double* df, IntPtr ef, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sptsv")]
            public static extern int Sptsv(BLAS.MatrixLayout matrixLayout, int n, int nrhs, float* d, float* e, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dptsv")]
            public static extern int Dptsv(BLAS.MatrixLayout matrixLayout, int n, int nrhs, double* d, double* e, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cptsv")]
            public static extern int Cptsv(BLAS.MatrixLayout matrixLayout, int n, int nrhs, float* d, IntPtr e, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zptsv")]
            public static extern int Zptsv(BLAS.MatrixLayout matrixLayout, int n, int nrhs, double* d, IntPtr e, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sptsvx")]
            public static extern int Sptsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, int n, int nrhs, float* d, float* e, float* df, float* ef, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dptsvx")]
            public static extern int Dptsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, int n, int nrhs, double* d, double* e, double* df, double* ef, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cptsvx")]
            public static extern int Cptsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, int n, int nrhs, float* d, IntPtr e, float* df, IntPtr ef, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zptsvx")]
            public static extern int Zptsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, int n, int nrhs, double* d, IntPtr e, double* df, IntPtr ef, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spttrf")]
            public static extern int Spttrf(int n, float* d, float* e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpttrf")]
            public static extern int Dpttrf(int n, double* d, double* e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpttrf")]
            public static extern int Cpttrf(int n, float* d, IntPtr e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpttrf")]
            public static extern int Zpttrf(int n, double* d, IntPtr e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spttrs")]
            public static extern int Spttrs(BLAS.MatrixLayout matrixLayout, int n, int nrhs, float* d, float* e, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpttrs")]
            public static extern int Dpttrs(BLAS.MatrixLayout matrixLayout, int n, int nrhs, double* d, double* e, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpttrs")]
            public static extern int Cpttrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* d, IntPtr e, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpttrs")]
            public static extern int Zpttrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* d, IntPtr e, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbev")]
            public static extern int Ssbev(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbev")]
            public static extern int Dsbev(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbevd")]
            public static extern int Ssbevd(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbevd")]
            public static extern int Dsbevd(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbevx")]
            public static extern int Ssbevx(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, float* ab, int ldab, float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbevx")]
            public static extern int Dsbevx(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, double* ab, int ldab, double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbgst")]
            public static extern int Ssbgst(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* x, int ldx);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbgst")]
            public static extern int Dsbgst(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* x, int ldx);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbgv")]
            public static extern int Ssbgv(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbgv")]
            public static extern int Dsbgv(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbgvd")]
            public static extern int Ssbgvd(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbgvd")]
            public static extern int Dsbgvd(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbgvx")]
            public static extern int Ssbgvx(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbgvx")]
            public static extern int Dsbgvx(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbtrd")]
            public static extern int Ssbtrd(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte uplo, int n, int kd, float* ab, int ldab, float* d, float* e, float* q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbtrd")]
            public static extern int Dsbtrd(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte uplo, int n, int kd, double* ab, int ldab, double* d, double* e, double* q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssfrk")]
            public static extern int Ssfrk(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, float alpha, float* a, int lda, float beta, float* c);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsfrk")]
            public static extern int Dsfrk(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, double alpha, double* a, int lda, double beta, double* c);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspcon")]
            public static extern int Sspcon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* ap, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspcon")]
            public static extern int Dspcon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* ap, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cspcon")]
            public static extern int Cspcon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zspcon")]
            public static extern int Zspcon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspev")]
            public static extern int Sspev(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, float* ap, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspev")]
            public static extern int Dspev(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, double* ap, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspevd")]
            public static extern int Sspevd(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, float* ap, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspevd")]
            public static extern int Dspevd(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, double* ap, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspevx")]
            public static extern int Sspevx(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* ap, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspevx")]
            public static extern int Dspevx(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* ap, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspgst")]
            public static extern int Sspgst(BLAS.MatrixLayout matrixLayout, int itype, sbyte uplo, int n, float* ap, float* bp);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspgst")]
            public static extern int Dspgst(BLAS.MatrixLayout matrixLayout, int itype, sbyte uplo, int n, double* ap, double* bp);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspgv")]
            public static extern int Sspgv(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* ap, float* bp, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspgv")]
            public static extern int Dspgv(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* ap, double* bp, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspgvd")]
            public static extern int Sspgvd(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* ap, float* bp, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspgvd")]
            public static extern int Dspgvd(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* ap, double* bp, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspgvx")]
            public static extern int Sspgvx(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, float* ap, float* bp, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspgvx")]
            public static extern int Dspgvx(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, double* ap, double* bp, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssprfs")]
            public static extern int Ssprfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* afp, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsprfs")]
            public static extern int Dsprfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* afp, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csprfs")]
            public static extern int Csprfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsprfs")]
            public static extern int Zsprfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspsv")]
            public static extern int Sspsv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* ap, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspsv")]
            public static extern int Dspsv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* ap, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cspsv")]
            public static extern int Cspsv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zspsv")]
            public static extern int Zspsv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspsvx")]
            public static extern int Sspsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* ap, float* afp, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspsvx")]
            public static extern int Dspsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* ap, double* afp, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cspsvx")]
            public static extern int Cspsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zspsvx")]
            public static extern int Zspsvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssptrd")]
            public static extern int Ssptrd(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* ap, float* d, float* e, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsptrd")]
            public static extern int Dsptrd(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* ap, double* d, double* e, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssptrf")]
            public static extern int Ssptrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsptrf")]
            public static extern int Dsptrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csptrf")]
            public static extern int Csptrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsptrf")]
            public static extern int Zsptrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssptri")]
            public static extern int Ssptri(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsptri")]
            public static extern int Dsptri(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csptri")]
            public static extern int Csptri(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsptri")]
            public static extern int Zsptri(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssptrs")]
            public static extern int Ssptrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* ap, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsptrs")]
            public static extern int Dsptrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* ap, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csptrs")]
            public static extern int Csptrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsptrs")]
            public static extern int Zsptrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstebz")]
            public static extern int Sstebz(sbyte range, sbyte order, int n, float vl, float vu, int il, int iu, float abstol, float* d, float* e, int* m, int* nsplit, float* w, int* iblock, int* isplit);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstebz")]
            public static extern int Dstebz(sbyte range, sbyte order, int n, double vl, double vu, int il, int iu, double abstol, double* d, double* e, int* m, int* nsplit, double* w, int* iblock, int* isplit);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstedc")]
            public static extern int Sstedc(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstedc")]
            public static extern int Dstedc(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cstedc")]
            public static extern int Cstedc(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zstedc")]
            public static extern int Zstedc(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstegr")]
            public static extern int Sstegr(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstegr")]
            public static extern int Dstegr(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cstegr")]
            public static extern int Cstegr(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zstegr")]
            public static extern int Zstegr(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstein")]
            public static extern int Sstein(BLAS.MatrixLayout matrixLayout, int n, float* d, float* e, int m, float* w, int* iblock, int* isplit, float* z, int ldz, int* ifailv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstein")]
            public static extern int Dstein(BLAS.MatrixLayout matrixLayout, int n, double* d, double* e, int m, double* w, int* iblock, int* isplit, double* z, int ldz, int* ifailv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cstein")]
            public static extern int Cstein(BLAS.MatrixLayout matrixLayout, int n, float* d, float* e, int m, float* w, int* iblock, int* isplit, IntPtr z, int ldz, int* ifailv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zstein")]
            public static extern int Zstein(BLAS.MatrixLayout matrixLayout, int n, double* d, double* e, int m, double* w, int* iblock, int* isplit, IntPtr z, int ldz, int* ifailv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstemr")]
            public static extern int Sstemr(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* m, float* w, float* z, int ldz, int nzc, int* isuppz, int* tryrac);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstemr")]
            public static extern int Dstemr(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* m, double* w, double* z, int ldz, int nzc, int* isuppz, int* tryrac);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cstemr")]
            public static extern int Cstemr(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* m, float* w, IntPtr z, int ldz, int nzc, int* isuppz, int* tryrac);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zstemr")]
            public static extern int Zstemr(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* m, double* w, IntPtr z, int ldz, int nzc, int* isuppz, int* tryrac);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssteqr")]
            public static extern int Ssteqr(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsteqr")]
            public static extern int Dsteqr(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csteqr")]
            public static extern int Csteqr(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsteqr")]
            public static extern int Zsteqr(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssterf")]
            public static extern int Ssterf(int n, float* d, float* e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsterf")]
            public static extern int Dsterf(int n, double* d, double* e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstev")]
            public static extern int Sstev(BLAS.MatrixLayout matrixLayout, sbyte jobz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstev")]
            public static extern int Dstev(BLAS.MatrixLayout matrixLayout, sbyte jobz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstevd")]
            public static extern int Sstevd(BLAS.MatrixLayout matrixLayout, sbyte jobz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstevd")]
            public static extern int Dstevd(BLAS.MatrixLayout matrixLayout, sbyte jobz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstevr")]
            public static extern int Sstevr(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstevr")]
            public static extern int Dstevr(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstevx")]
            public static extern int Sstevx(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstevx")]
            public static extern int Dstevx(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssycon")]
            public static extern int Ssycon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsycon")]
            public static extern int Dsycon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csycon")]
            public static extern int Csycon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsycon")]
            public static extern int Zsycon(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyequb")]
            public static extern int Ssyequb(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyequb")]
            public static extern int Dsyequb(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyequb")]
            public static extern int Csyequb(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyequb")]
            public static extern int Zsyequb(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyev")]
            public static extern int Ssyev(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyev")]
            public static extern int Dsyev(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevd")]
            public static extern int Ssyevd(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevd")]
            public static extern int Dsyevd(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevr")]
            public static extern int Ssyevr(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevr")]
            public static extern int Dsyevr(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevx")]
            public static extern int Ssyevx(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevx")]
            public static extern int Dsyevx(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssygst")]
            public static extern int Ssygst(BLAS.MatrixLayout matrixLayout, int itype, sbyte uplo, int n, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsygst")]
            public static extern int Dsygst(BLAS.MatrixLayout matrixLayout, int itype, sbyte uplo, int n, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssygv")]
            public static extern int Ssygv(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsygv")]
            public static extern int Dsygv(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssygvd")]
            public static extern int Ssygvd(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsygvd")]
            public static extern int Dsygvd(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssygvx")]
            public static extern int Ssygvx(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsygvx")]
            public static extern int Dsygvx(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyrfs")]
            public static extern int Ssyrfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyrfs")]
            public static extern int Dsyrfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyrfs")]
            public static extern int Csyrfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyrfs")]
            public static extern int Zsyrfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyrfsx")]
            public static extern int Ssyrfsx(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyrfsx")]
            public static extern int Dsyrfsx(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyrfsx")]
            public static extern int Csyrfsx(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyrfsx")]
            public static extern int Zsyrfsx(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysv")]
            public static extern int Ssysv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysv")]
            public static extern int Dsysv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysv")]
            public static extern int Csysv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysv")]
            public static extern int Zsysv(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysvx")]
            public static extern int Ssysvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysvx")]
            public static extern int Dsysvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysvx")]
            public static extern int Csysvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysvx")]
            public static extern int Zsysvx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysvxx")]
            public static extern int Ssysvxx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysvxx")]
            public static extern int Dsysvxx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysvxx")]
            public static extern int Csysvxx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysvxx")]
            public static extern int Zsysvxx(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrd")]
            public static extern int Ssytrd(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, float* d, float* e, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrd")]
            public static extern int Dsytrd(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, double* d, double* e, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrf")]
            public static extern int Ssytrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrf")]
            public static extern int Dsytrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrf")]
            public static extern int Csytrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrf")]
            public static extern int Zsytrf(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytri")]
            public static extern int Ssytri(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytri")]
            public static extern int Dsytri(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytri")]
            public static extern int Csytri(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytri")]
            public static extern int Zsytri(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs")]
            public static extern int Ssytrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs")]
            public static extern int Dsytrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs")]
            public static extern int Csytrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs")]
            public static extern int Zsytrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stbcon")]
            public static extern int Stbcon(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, float* ab, int ldab, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtbcon")]
            public static extern int Dtbcon(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, double* ab, int ldab, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctbcon")]
            public static extern int Ctbcon(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, IntPtr ab, int ldab, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztbcon")]
            public static extern int Ztbcon(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, IntPtr ab, int ldab, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stbrfs")]
            public static extern int Stbrfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtbrfs")]
            public static extern int Dtbrfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctbrfs")]
            public static extern int Ctbrfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztbrfs")]
            public static extern int Ztbrfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stbtrs")]
            public static extern int Stbtrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtbtrs")]
            public static extern int Dtbtrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctbtrs")]
            public static extern int Ctbtrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztbtrs")]
            public static extern int Ztbtrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stfsm")]
            public static extern int Stfsm(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, float alpha, float* a, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtfsm")]
            public static extern int Dtfsm(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, double alpha, double* a, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctfsm")]
            public static extern int Ctfsm(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, ComplexFloat alpha, IntPtr a, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztfsm")]
            public static extern int Ztfsm(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, IntPtr alpha, IntPtr a, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stftri")]
            public static extern int Stftri(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, float* a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtftri")]
            public static extern int Dtftri(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, double* a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctftri")]
            public static extern int Ctftri(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztftri")]
            public static extern int Ztftri(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stfttp")]
            public static extern int Stfttp(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, float* arf, float* ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtfttp")]
            public static extern int Dtfttp(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, double* arf, double* ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctfttp")]
            public static extern int Ctfttp(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr arf, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztfttp")]
            public static extern int Ztfttp(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr arf, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stfttr")]
            public static extern int Stfttr(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, float* arf, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtfttr")]
            public static extern int Dtfttr(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, double* arf, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctfttr")]
            public static extern int Ctfttr(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr arf, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztfttr")]
            public static extern int Ztfttr(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr arf, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgevc")]
            public static extern int Stgevc(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, float* s, int lds, float* p, int ldp, float* vl, int ldvl, float* vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgevc")]
            public static extern int Dtgevc(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, double* s, int lds, double* p, int ldp, double* vl, int ldvl, double* vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgevc")]
            public static extern int Ctgevc(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, IntPtr s, int lds, IntPtr p, int ldp, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgevc")]
            public static extern int Ztgevc(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, IntPtr s, int lds, IntPtr p, int ldp, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgexc")]
            public static extern int Stgexc(BLAS.MatrixLayout matrixLayout, int wantq, int wantz, int n, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz, int* ifst, int* ilst);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgexc")]
            public static extern int Dtgexc(BLAS.MatrixLayout matrixLayout, int wantq, int wantz, int n, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z, int ldz, int* ifst, int* ilst);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgexc")]
            public static extern int Ctgexc(BLAS.MatrixLayout matrixLayout, int wantq, int wantz, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgexc")]
            public static extern int Ztgexc(BLAS.MatrixLayout matrixLayout, int wantq, int wantz, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgsen")]
            public static extern int Stgsen(BLAS.MatrixLayout matrixLayout, int ijob, int wantq, int wantz, int* select, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* q, int ldq, float* z, int ldz, int* m, float* pl, float* pr, float* dif);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgsen")]
            public static extern int Dtgsen(BLAS.MatrixLayout matrixLayout, int ijob, int wantq, int wantz, int* select, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* q, int ldq, double* z, int ldz, int* m, double* pl, double* pr, double* dif);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgsen")]
            public static extern int Ctgsen(BLAS.MatrixLayout matrixLayout, int ijob, int wantq, int wantz, int* select, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr q, int ldq, IntPtr z, int ldz, int* m, float* pl, float* pr, float* dif);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgsen")]
            public static extern int Ztgsen(BLAS.MatrixLayout matrixLayout, int ijob, int wantq, int wantz, int* select, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr q, int ldq, IntPtr z, int ldz, int* m, double* pl, double* pr, double* dif);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgsja")]
            public static extern int Stgsja(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, float* a, int lda, float* b, int ldb, float tola, float tolb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* ncycle);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgsja")]
            public static extern int Dtgsja(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, double* a, int lda, double* b, int ldb, double tola, double tolb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* ncycle);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgsja")]
            public static extern int Ctgsja(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, IntPtr a, int lda, IntPtr b, int ldb, float tola, float tolb, float* alpha, float* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, int* ncycle);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgsja")]
            public static extern int Ztgsja(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, IntPtr a, int lda, IntPtr b, int ldb, double tola, double tolb, double* alpha, double* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, int* ncycle);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgsna")]
            public static extern int Stgsna(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, float* a, int lda, float* b, int ldb, float* vl, int ldvl, float* vr, int ldvr, float* s, float* dif, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgsna")]
            public static extern int Dtgsna(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, double* a, int lda, double* b, int ldb, double* vl, int ldvl, double* vr, int ldvr, double* s, double* dif, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgsna")]
            public static extern int Ctgsna(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr vl, int ldvl, IntPtr vr, int ldvr, float* s, float* dif, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgsna")]
            public static extern int Ztgsna(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr vl, int ldvl, IntPtr vr, int ldvr, double* s, double* dif, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgsyl")]
            public static extern int Stgsyl(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, float* a, int lda, float* b, int ldb, float* c, int ldc, float* d, int ldd, float* e, int lde, float* f, int ldf, float* scale, float* dif);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgsyl")]
            public static extern int Dtgsyl(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, double* a, int lda, double* b, int ldb, double* c, int ldc, double* d, int ldd, double* e, int lde, double* f, int ldf, double* scale, double* dif);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgsyl")]
            public static extern int Ctgsyl(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, int ldc, IntPtr d, int ldd, IntPtr e, int lde, IntPtr f, int ldf, float* scale, float* dif);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgsyl")]
            public static extern int Ztgsyl(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, int ldc, IntPtr d, int ldd, IntPtr e, int lde, IntPtr f, int ldf, double* scale, double* dif);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpcon")]
            public static extern int Stpcon(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, float* ap, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpcon")]
            public static extern int Dtpcon(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, double* ap, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpcon")]
            public static extern int Ctpcon(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, IntPtr ap, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpcon")]
            public static extern int Ztpcon(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, IntPtr ap, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stprfs")]
            public static extern int Stprfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* ap, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtprfs")]
            public static extern int Dtprfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* ap, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctprfs")]
            public static extern int Ctprfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, IntPtr ap, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztprfs")]
            public static extern int Ztprfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, IntPtr ap, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stptri")]
            public static extern int Stptri(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte diag, int n, float* ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtptri")]
            public static extern int Dtptri(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte diag, int n, double* ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctptri")]
            public static extern int Ctptri(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte diag, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztptri")]
            public static extern int Ztptri(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte diag, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stptrs")]
            public static extern int Stptrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtptrs")]
            public static extern int Dtptrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctptrs")]
            public static extern int Ctptrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztptrs")]
            public static extern int Ztptrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpttf")]
            public static extern int Stpttf(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, float* ap, float* arf);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpttf")]
            public static extern int Dtpttf(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, double* ap, double* arf);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpttf")]
            public static extern int Ctpttf(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr ap, IntPtr arf);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpttf")]
            public static extern int Ztpttf(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr ap, IntPtr arf);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpttr")]
            public static extern int Stpttr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* ap, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpttr")]
            public static extern int Dtpttr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* ap, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpttr")]
            public static extern int Ctpttr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpttr")]
            public static extern int Ztpttr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strcon")]
            public static extern int Strcon(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, float* a, int lda, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrcon")]
            public static extern int Dtrcon(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, double* a, int lda, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrcon")]
            public static extern int Ctrcon(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, IntPtr a, int lda, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrcon")]
            public static extern int Ztrcon(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, IntPtr a, int lda, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strevc")]
            public static extern int Strevc(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, float* t, int ldt, float* vl, int ldvl, float* vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrevc")]
            public static extern int Dtrevc(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, double* t, int ldt, double* vl, int ldvl, double* vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrevc")]
            public static extern int Ctrevc(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, IntPtr t, int ldt, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrevc")]
            public static extern int Ztrevc(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, IntPtr t, int ldt, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strexc")]
            public static extern int Strexc(BLAS.MatrixLayout matrixLayout, sbyte compq, int n, float* t, int ldt, float* q, int ldq, int* ifst, int* ilst);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrexc")]
            public static extern int Dtrexc(BLAS.MatrixLayout matrixLayout, sbyte compq, int n, double* t, int ldt, double* q, int ldq, int* ifst, int* ilst);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrexc")]
            public static extern int Ctrexc(BLAS.MatrixLayout matrixLayout, sbyte compq, int n, IntPtr t, int ldt, IntPtr q, int ldq, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrexc")]
            public static extern int Ztrexc(BLAS.MatrixLayout matrixLayout, sbyte compq, int n, IntPtr t, int ldt, IntPtr q, int ldq, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strrfs")]
            public static extern int Strrfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* a, int lda, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrrfs")]
            public static extern int Dtrrfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* a, int lda, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrrfs")]
            public static extern int Ctrrfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrrfs")]
            public static extern int Ztrrfs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strsen")]
            public static extern int Strsen(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compq, int* select, int n, float* t, int ldt, float* q, int ldq, float* wr, float* wi, int* m, float* s, float* sep);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrsen")]
            public static extern int Dtrsen(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compq, int* select, int n, double* t, int ldt, double* q, int ldq, double* wr, double* wi, int* m, double* s, double* sep);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrsen")]
            public static extern int Ctrsen(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compq, int* select, int n, IntPtr t, int ldt, IntPtr q, int ldq, IntPtr w, int* m, float* s, float* sep);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrsen")]
            public static extern int Ztrsen(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compq, int* select, int n, IntPtr t, int ldt, IntPtr q, int ldq, IntPtr w, int* m, double* s, double* sep);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strsna")]
            public static extern int Strsna(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, float* t, int ldt, float* vl, int ldvl, float* vr, int ldvr, float* s, float* sep, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrsna")]
            public static extern int Dtrsna(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, double* t, int ldt, double* vl, int ldvl, double* vr, int ldvr, double* s, double* sep, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrsna")]
            public static extern int Ctrsna(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, IntPtr t, int ldt, IntPtr vl, int ldvl, IntPtr vr, int ldvr, float* s, float* sep, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrsna")]
            public static extern int Ztrsna(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, IntPtr t, int ldt, IntPtr vl, int ldvl, IntPtr vr, int ldvr, double* s, double* sep, int mm, int* m);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strsyl")]
            public static extern int Strsyl(BLAS.MatrixLayout matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, float* a, int lda, float* b, int ldb, float* c, int ldc, float* scale);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrsyl")]
            public static extern int Dtrsyl(BLAS.MatrixLayout matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, double* a, int lda, double* b, int ldb, double* c, int ldc, double* scale);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrsyl")]
            public static extern int Ctrsyl(BLAS.MatrixLayout matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, int ldc, float* scale);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrsyl")]
            public static extern int Ztrsyl(BLAS.MatrixLayout matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, int ldc, double* scale);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strtri")]
            public static extern int Strtri(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte diag, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrtri")]
            public static extern int Dtrtri(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte diag, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrtri")]
            public static extern int Ctrtri(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte diag, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrtri")]
            public static extern int Ztrtri(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte diag, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strtrs")]
            public static extern int Strtrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrtrs")]
            public static extern int Dtrtrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrtrs")]
            public static extern int Ctrtrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrtrs")]
            public static extern int Ztrtrs(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strttf")]
            public static extern int Strttf(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, float* a, int lda, float* arf);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrttf")]
            public static extern int Dtrttf(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, double* a, int lda, double* arf);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrttf")]
            public static extern int Ctrttf(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr a, int lda, IntPtr arf);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrttf")]
            public static extern int Ztrttf(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr a, int lda, IntPtr arf);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strttp")]
            public static extern int Strttp(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, float* ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrttp")]
            public static extern int Dtrttp(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, double* ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrttp")]
            public static extern int Ctrttp(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrttp")]
            public static extern int Ztrttp(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stzrzf")]
            public static extern int Stzrzf(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtzrzf")]
            public static extern int Dtzrzf(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctzrzf")]
            public static extern int Ctzrzf(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztzrzf")]
            public static extern int Ztzrzf(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cungbr")]
            public static extern int Cungbr(BLAS.MatrixLayout matrixLayout, sbyte vect, int m, int n, int k, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zungbr")]
            public static extern int Zungbr(BLAS.MatrixLayout matrixLayout, sbyte vect, int m, int n, int k, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunghr")]
            public static extern int Cunghr(BLAS.MatrixLayout matrixLayout, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunghr")]
            public static extern int Zunghr(BLAS.MatrixLayout matrixLayout, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunglq")]
            public static extern int Cunglq(BLAS.MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunglq")]
            public static extern int Zunglq(BLAS.MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cungql")]
            public static extern int Cungql(BLAS.MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zungql")]
            public static extern int Zungql(BLAS.MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cungqr")]
            public static extern int Cungqr(BLAS.MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zungqr")]
            public static extern int Zungqr(BLAS.MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cungrq")]
            public static extern int Cungrq(BLAS.MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zungrq")]
            public static extern int Zungrq(BLAS.MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cungtr")]
            public static extern int Cungtr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zungtr")]
            public static extern int Zungtr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmbr")]
            public static extern int Cunmbr(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmbr")]
            public static extern int Zunmbr(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmhr")]
            public static extern int Cunmhr(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmhr")]
            public static extern int Zunmhr(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmlq")]
            public static extern int Cunmlq(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmlq")]
            public static extern int Zunmlq(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmql")]
            public static extern int Cunmql(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmql")]
            public static extern int Zunmql(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmqr")]
            public static extern int Cunmqr(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmqr")]
            public static extern int Zunmqr(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmrq")]
            public static extern int Cunmrq(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmrq")]
            public static extern int Zunmrq(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmrz")]
            public static extern int Cunmrz(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmrz")]
            public static extern int Zunmrz(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmtr")]
            public static extern int Cunmtr(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmtr")]
            public static extern int Zunmtr(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cupgtr")]
            public static extern int Cupgtr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, IntPtr tau, IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zupgtr")]
            public static extern int Zupgtr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, IntPtr tau, IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cupmtr")]
            public static extern int Cupmtr(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, IntPtr ap, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zupmtr")]
            public static extern int Zupmtr(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, IntPtr ap, IntPtr tau, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sbdsdc_work")]
            public static extern int SbdsdcWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte compq, int n, float* d, float* e, float* u, int ldu, float* vt, int ldvt, float* q, int* iq, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dbdsdc_work")]
            public static extern int DbdsdcWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte compq, int n, double* d, double* e, double* u, int ldu, double* vt, int ldvt, double* q, int* iq, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sbdsvdx_work")]
            public static extern int SbdsvdxWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* ns, float* s, float* z, int ldz, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dbdsvdx_work")]
            public static extern int DbdsvdxWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* ns, double* s, double* z, int ldz, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sbdsqr_work")]
            public static extern int SbdsqrWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, float* d, float* e, float* vt, int ldvt, float* u, int ldu, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dbdsqr_work")]
            public static extern int DbdsqrWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, double* d, double* e, double* vt, int ldvt, double* u, int ldu, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cbdsqr_work")]
            public static extern int CbdsqrWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, float* d, float* e, IntPtr vt, int ldvt, IntPtr u, int ldu, IntPtr c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zbdsqr_work")]
            public static extern int ZbdsqrWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, double* d, double* e, IntPtr vt, int ldvt, IntPtr u, int ldu, IntPtr c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sdisna_work")]
            public static extern int SdisnaWork(sbyte job, int m, int n, float* d, float* sep);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ddisna_work")]
            public static extern int DdisnaWork(sbyte job, int m, int n, double* d, double* sep);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbbrd_work")]
            public static extern int SgbbrdWork(BLAS.MatrixLayout matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, float* ab, int ldab, float* d, float* e, float* q, int ldq, float* pt, int ldpt, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbbrd_work")]
            public static extern int DgbbrdWork(BLAS.MatrixLayout matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, double* ab, int ldab, double* d, double* e, double* q, int ldq, double* pt, int ldpt, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbbrd_work")]
            public static extern int CgbbrdWork(BLAS.MatrixLayout matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, IntPtr ab, int ldab, float* d, float* e, IntPtr q, int ldq, IntPtr pt, int ldpt, IntPtr c, int ldc, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbbrd_work")]
            public static extern int ZgbbrdWork(BLAS.MatrixLayout matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, IntPtr ab, int ldab, double* d, double* e, IntPtr q, int ldq, IntPtr pt, int ldpt, IntPtr c, int ldc, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbcon_work")]
            public static extern int SgbconWork(BLAS.MatrixLayout matrixLayout, sbyte norm, int n, int kl, int ku, float* ab, int ldab, int* ipiv, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbcon_work")]
            public static extern int DgbconWork(BLAS.MatrixLayout matrixLayout, sbyte norm, int n, int kl, int ku, double* ab, int ldab, int* ipiv, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbcon_work")]
            public static extern int CgbconWork(BLAS.MatrixLayout matrixLayout, sbyte norm, int n, int kl, int ku, IntPtr ab, int ldab, int* ipiv, float anorm, float* rcond, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbcon_work")]
            public static extern int ZgbconWork(BLAS.MatrixLayout matrixLayout, sbyte norm, int n, int kl, int ku, IntPtr ab, int ldab, int* ipiv, double anorm, double* rcond, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbequ_work")]
            public static extern int SgbequWork(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbequ_work")]
            public static extern int DgbequWork(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbequ_work")]
            public static extern int CgbequWork(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbequ_work")]
            public static extern int ZgbequWork(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbequb_work")]
            public static extern int SgbequbWork(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbequb_work")]
            public static extern int DgbequbWork(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbequb_work")]
            public static extern int CgbequbWork(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbequb_work")]
            public static extern int ZgbequbWork(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbrfs_work")]
            public static extern int SgbrfsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbrfs_work")]
            public static extern int DgbrfsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbrfs_work")]
            public static extern int CgbrfsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbrfs_work")]
            public static extern int ZgbrfsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbrfsx_work")]
            public static extern int SgbrfsxWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbrfsx_work")]
            public static extern int DgbrfsxWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbrfsx_work")]
            public static extern int CgbrfsxWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbrfsx_work")]
            public static extern int ZgbrfsxWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbsv_work")]
            public static extern int SgbsvWork(BLAS.MatrixLayout matrixLayout, int n, int kl, int ku, int nrhs, float* ab, int ldab, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbsv_work")]
            public static extern int DgbsvWork(BLAS.MatrixLayout matrixLayout, int n, int kl, int ku, int nrhs, double* ab, int ldab, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbsv_work")]
            public static extern int CgbsvWork(BLAS.MatrixLayout matrixLayout, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbsv_work")]
            public static extern int ZgbsvWork(BLAS.MatrixLayout matrixLayout, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbsvx_work")]
            public static extern int SgbsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbsvx_work")]
            public static extern int DgbsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbsvx_work")]
            public static extern int CgbsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbsvx_work")]
            public static extern int ZgbsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbsvxx_work")]
            public static extern int SgbsvxxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbsvxx_work")]
            public static extern int DgbsvxxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbsvxx_work")]
            public static extern int CgbsvxxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbsvxx_work")]
            public static extern int ZgbsvxxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbtrf_work")]
            public static extern int SgbtrfWork(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbtrf_work")]
            public static extern int DgbtrfWork(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbtrf_work")]
            public static extern int CgbtrfWork(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbtrf_work")]
            public static extern int ZgbtrfWork(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, IntPtr ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgbtrs_work")]
            public static extern int SgbtrsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgbtrs_work")]
            public static extern int DgbtrsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgbtrs_work")]
            public static extern int CgbtrsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgbtrs_work")]
            public static extern int ZgbtrsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, IntPtr ab, int ldab, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgebak_work")]
            public static extern int SgebakWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* scale, int m, float* v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgebak_work")]
            public static extern int DgebakWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* scale, int m, double* v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgebak_work")]
            public static extern int CgebakWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* scale, int m, IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgebak_work")]
            public static extern int ZgebakWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* scale, int m, IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgebal_work")]
            public static extern int SgebalWork(BLAS.MatrixLayout matrixLayout, sbyte job, int n, float* a, int lda, int* ilo, int* ihi, float* scale);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgebal_work")]
            public static extern int DgebalWork(BLAS.MatrixLayout matrixLayout, sbyte job, int n, double* a, int lda, int* ilo, int* ihi, double* scale);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgebal_work")]
            public static extern int CgebalWork(BLAS.MatrixLayout matrixLayout, sbyte job, int n, IntPtr a, int lda, int* ilo, int* ihi, float* scale);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgebal_work")]
            public static extern int ZgebalWork(BLAS.MatrixLayout matrixLayout, sbyte job, int n, IntPtr a, int lda, int* ilo, int* ihi, double* scale);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgebrd_work")]
            public static extern int SgebrdWork(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* d, float* e, float* tauq, float* taup, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgebrd_work")]
            public static extern int DgebrdWork(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* d, double* e, double* tauq, double* taup, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgebrd_work")]
            public static extern int CgebrdWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, float* d, float* e, IntPtr tauq, IntPtr taup, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgebrd_work")]
            public static extern int ZgebrdWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, double* d, double* e, IntPtr tauq, IntPtr taup, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgecon_work")]
            public static extern int SgeconWork(BLAS.MatrixLayout matrixLayout, sbyte norm, int n, float* a, int lda, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgecon_work")]
            public static extern int DgeconWork(BLAS.MatrixLayout matrixLayout, sbyte norm, int n, double* a, int lda, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgecon_work")]
            public static extern int CgeconWork(BLAS.MatrixLayout matrixLayout, sbyte norm, int n, IntPtr a, int lda, float anorm, float* rcond, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgecon_work")]
            public static extern int ZgeconWork(BLAS.MatrixLayout matrixLayout, sbyte norm, int n, IntPtr a, int lda, double anorm, double* rcond, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeequ_work")]
            public static extern int SgeequWork(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeequ_work")]
            public static extern int DgeequWork(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeequ_work")]
            public static extern int CgeequWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeequ_work")]
            public static extern int ZgeequWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeequb_work")]
            public static extern int SgeequbWork(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeequb_work")]
            public static extern int DgeequbWork(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeequb_work")]
            public static extern int CgeequbWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeequb_work")]
            public static extern int ZgeequbWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgees_work")]
            public static extern int SgeesWork(BLAS.MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, int n, float* a, int lda, int* sdim, float* wr, float* wi, float* vs, int ldvs, float* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgees_work")]
            public static extern int DgeesWork(BLAS.MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, int n, double* a, int lda, int* sdim, double* wr, double* wi, double* vs, int ldvs, double* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgees_work")]
            public static extern int CgeesWork(BLAS.MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, int n, IntPtr a, int lda, int* sdim, IntPtr w, IntPtr vs, int ldvs, IntPtr work, int lwork, float* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgees_work")]
            public static extern int ZgeesWork(BLAS.MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, int n, IntPtr a, int lda, int* sdim, IntPtr w, IntPtr vs, int ldvs, IntPtr work, int lwork, double* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeesx_work")]
            public static extern int SgeesxWork(BLAS.MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, sbyte sense, int n, float* a, int lda, int* sdim, float* wr, float* wi, float* vs, int ldvs, float* rconde, float* rcondv, float* work, int lwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeesx_work")]
            public static extern int DgeesxWork(BLAS.MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, sbyte sense, int n, double* a, int lda, int* sdim, double* wr, double* wi, double* vs, int ldvs, double* rconde, double* rcondv, double* work, int lwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeesx_work")]
            public static extern int CgeesxWork(BLAS.MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, sbyte sense, int n, IntPtr a, int lda, int* sdim, IntPtr w, IntPtr vs, int ldvs, float* rconde, float* rcondv, IntPtr work, int lwork, float* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeesx_work")]
            public static extern int ZgeesxWork(BLAS.MatrixLayout matrixLayout, sbyte jobvs, sbyte sort, IntPtr select, sbyte sense, int n, IntPtr a, int lda, int* sdim, IntPtr w, IntPtr vs, int ldvs, double* rconde, double* rcondv, IntPtr work, int lwork, double* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeev_work")]
            public static extern int SgeevWork(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* wr, float* wi, float* vl, int ldvl, float* vr, int ldvr, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeev_work")]
            public static extern int DgeevWork(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* wr, double* wi, double* vl, int ldvl, double* vr, int ldvr, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeev_work")]
            public static extern int CgeevWork(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeev_work")]
            public static extern int ZgeevWork(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeevx_work")]
            public static extern int SgeevxWork(BLAS.MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, float* a, int lda, float* wr, float* wi, float* vl, int ldvl, float* vr, int ldvr, int* ilo, int* ihi, float* scale, float* abnrm, float* rconde, float* rcondv, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeevx_work")]
            public static extern int DgeevxWork(BLAS.MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, double* a, int lda, double* wr, double* wi, double* vl, int ldvl, double* vr, int ldvr, int* ilo, int* ihi, double* scale, double* abnrm, double* rconde, double* rcondv, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeevx_work")]
            public static extern int CgeevxWork(BLAS.MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, IntPtr a, int lda, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int* ilo, int* ihi, float* scale, float* abnrm, float* rconde, float* rcondv, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeevx_work")]
            public static extern int ZgeevxWork(BLAS.MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, IntPtr a, int lda, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int* ilo, int* ihi, double* scale, double* abnrm, double* rconde, double* rcondv, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgehrd_work")]
            public static extern int SgehrdWork(BLAS.MatrixLayout matrixLayout, int n, int ilo, int ihi, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgehrd_work")]
            public static extern int DgehrdWork(BLAS.MatrixLayout matrixLayout, int n, int ilo, int ihi, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgehrd_work")]
            public static extern int CgehrdWork(BLAS.MatrixLayout matrixLayout, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgehrd_work")]
            public static extern int ZgehrdWork(BLAS.MatrixLayout matrixLayout, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgejsv_work")]
            public static extern int SgejsvWork(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, float* a, int lda, float* sva, float* u, int ldu, float* v, int ldv, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgejsv_work")]
            public static extern int DgejsvWork(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, double* a, int lda, double* sva, double* u, int ldu, double* v, int ldv, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgejsv_work")]
            public static extern int CgejsvWork(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, IntPtr a, int lda, float* sva, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr cwork, int lwork, float* work, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgejsv_work")]
            public static extern int ZgejsvWork(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, IntPtr a, int lda, double* sva, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr cwork, int lwork, double* work, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelq2_work")]
            public static extern int Sgelq2Work(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelq2_work")]
            public static extern int Dgelq2Work(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelq2_work")]
            public static extern int Cgelq2Work(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelq2_work")]
            public static extern int Zgelq2Work(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelqf_work")]
            public static extern int SgelqfWork(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelqf_work")]
            public static extern int DgelqfWork(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelqf_work")]
            public static extern int CgelqfWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelqf_work")]
            public static extern int ZgelqfWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgels_work")]
            public static extern int SgelsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgels_work")]
            public static extern int DgelsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgels_work")]
            public static extern int CgelsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgels_work")]
            public static extern int ZgelsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelsd_work")]
            public static extern int SgelsdWork(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* s, float rcond, int* rank, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelsd_work")]
            public static extern int DgelsdWork(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* s, double rcond, int* rank, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelsd_work")]
            public static extern int CgelsdWork(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, float* s, float rcond, int* rank, IntPtr work, int lwork, float* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelsd_work")]
            public static extern int ZgelsdWork(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, double* s, double rcond, int* rank, IntPtr work, int lwork, double* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelss_work")]
            public static extern int SgelssWork(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* s, float rcond, int* rank, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelss_work")]
            public static extern int DgelssWork(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* s, double rcond, int* rank, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelss_work")]
            public static extern int CgelssWork(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, float* s, float rcond, int* rank, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelss_work")]
            public static extern int ZgelssWork(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, double* s, double rcond, int* rank, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelsy_work")]
            public static extern int SgelsyWork(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, int* jpvt, float rcond, int* rank, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelsy_work")]
            public static extern int DgelsyWork(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, int* jpvt, double rcond, int* rank, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelsy_work")]
            public static extern int CgelsyWork(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, int* jpvt, float rcond, int* rank, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelsy_work")]
            public static extern int ZgelsyWork(BLAS.MatrixLayout matrixLayout, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, int* jpvt, double rcond, int* rank, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqlf_work")]
            public static extern int SgeqlfWork(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqlf_work")]
            public static extern int DgeqlfWork(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqlf_work")]
            public static extern int CgeqlfWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqlf_work")]
            public static extern int ZgeqlfWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqp3_work")]
            public static extern int Sgeqp3Work(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, int* jpvt, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqp3_work")]
            public static extern int Dgeqp3Work(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, int* jpvt, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqp3_work")]
            public static extern int Cgeqp3Work(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* jpvt, IntPtr tau, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqp3_work")]
            public static extern int Zgeqp3Work(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* jpvt, IntPtr tau, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqpf_work")]
            public static extern int SgeqpfWork(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, int* jpvt, float* tau, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqpf_work")]
            public static extern int DgeqpfWork(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, int* jpvt, double* tau, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqpf_work")]
            public static extern int CgeqpfWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* jpvt, IntPtr tau, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqpf_work")]
            public static extern int ZgeqpfWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* jpvt, IntPtr tau, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqr2_work")]
            public static extern int Sgeqr2Work(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqr2_work")]
            public static extern int Dgeqr2Work(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqr2_work")]
            public static extern int Cgeqr2Work(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqr2_work")]
            public static extern int Zgeqr2Work(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqrf_work")]
            public static extern int SgeqrfWork(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqrf_work")]
            public static extern int DgeqrfWork(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqrf_work")]
            public static extern int CgeqrfWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqrf_work")]
            public static extern int ZgeqrfWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqrfp_work")]
            public static extern int SgeqrfpWork(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqrfp_work")]
            public static extern int DgeqrfpWork(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqrfp_work")]
            public static extern int CgeqrfpWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqrfp_work")]
            public static extern int ZgeqrfpWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgerfs_work")]
            public static extern int SgerfsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgerfs_work")]
            public static extern int DgerfsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgerfs_work")]
            public static extern int CgerfsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgerfs_work")]
            public static extern int ZgerfsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgerfsx_work")]
            public static extern int SgerfsxWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgerfsx_work")]
            public static extern int DgerfsxWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgerfsx_work")]
            public static extern int CgerfsxWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgerfsx_work")]
            public static extern int ZgerfsxWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgerqf_work")]
            public static extern int SgerqfWork(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgerqf_work")]
            public static extern int DgerqfWork(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgerqf_work")]
            public static extern int CgerqfWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgerqf_work")]
            public static extern int ZgerqfWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesdd_work")]
            public static extern int SgesddWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* vt, int ldvt, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesdd_work")]
            public static extern int DgesddWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* vt, int ldvt, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesdd_work")]
            public static extern int CgesddWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, int m, int n, IntPtr a, int lda, float* s, IntPtr u, int ldu, IntPtr vt, int ldvt, IntPtr work, int lwork, float* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesdd_work")]
            public static extern int ZgesddWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, int m, int n, IntPtr a, int lda, double* s, IntPtr u, int ldu, IntPtr vt, int ldvt, IntPtr work, int lwork, double* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesv_work")]
            public static extern int SgesvWork(BLAS.MatrixLayout matrixLayout, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesv_work")]
            public static extern int DgesvWork(BLAS.MatrixLayout matrixLayout, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesv_work")]
            public static extern int CgesvWork(BLAS.MatrixLayout matrixLayout, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesv_work")]
            public static extern int ZgesvWork(BLAS.MatrixLayout matrixLayout, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsgesv_work")]
            public static extern int DsgesvWork(BLAS.MatrixLayout matrixLayout, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* x, int ldx, double* work, float* swork, int* iter);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zcgesv_work")]
            public static extern int ZcgesvWork(BLAS.MatrixLayout matrixLayout, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, IntPtr work, IntPtr swork, double* rwork, int* iter);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvd_work")]
            public static extern int SgesvdWork(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* vt, int ldvt, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvd_work")]
            public static extern int DgesvdWork(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* vt, int ldvt, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvd_work")]
            public static extern int CgesvdWork(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, IntPtr a, int lda, float* s, IntPtr u, int ldu, IntPtr vt, int ldvt, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvd_work")]
            public static extern int ZgesvdWork(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, IntPtr a, int lda, double* s, IntPtr u, int ldu, IntPtr vt, int ldvt, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvdx_work")]
            public static extern int SgesvdxWork(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, float* a, int lda, float vl, float vu, int il, int iu, int* ns, float* s, float* u, int ldu, float* vt, int ldvt, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvdx_work")]
            public static extern int DgesvdxWork(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, double* a, int lda, double vl, double vu, int il, int iu, int* ns, double* s, double* u, int ldu, double* vt, int ldvt, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvdx_work")]
            public static extern int CgesvdxWork(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, IntPtr a, int lda, float vl, float vu, int il, int iu, int* ns, float* s, IntPtr u, int ldu, IntPtr vt, int ldvt, IntPtr work, int lwork, float* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvdx_work")]
            public static extern int ZgesvdxWork(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, IntPtr a, int lda, double vl, double vu, int il, int iu, int* ns, double* s, IntPtr u, int ldu, IntPtr vt, int ldvt, IntPtr work, int lwork, double* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvdq_work")]
            public static extern int SgesvdqWork(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobp, sbyte jobr, sbyte jobu, sbyte jobv, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* v, int ldv, int* numrank, int* iwork, int liwork, float* work, int lwork, float* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvdq_work")]
            public static extern int DgesvdqWork(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobp, sbyte jobr, sbyte jobu, sbyte jobv, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* v, int ldv, int* numrank, int* iwork, int liwork, double* work, int lwork, double* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvdq_work")]
            public static extern int CgesvdqWork(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobp, sbyte jobr, sbyte jobu, sbyte jobv, int m, int n, IntPtr a, int lda, float* s, IntPtr u, int ldu, IntPtr v, int ldv, int* numrank, int* iwork, int liwork, IntPtr cwork, int lcwork, float* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvdq_work")]
            public static extern int ZgesvdqWork(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobp, sbyte jobr, sbyte jobu, sbyte jobv, int m, int n, IntPtr a, int lda, double* s, IntPtr u, int ldu, IntPtr v, int ldv, int* numrank, int* iwork, int liwork, IntPtr cwork, int lcwork, double* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvj_work")]
            public static extern int SgesvjWork(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, float* a, int lda, float* sva, int mv, float* v, int ldv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvj_work")]
            public static extern int DgesvjWork(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, double* a, int lda, double* sva, int mv, double* v, int ldv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvj_work")]
            public static extern int CgesvjWork(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, IntPtr a, int lda, float* sva, int mv, IntPtr v, int ldv, IntPtr cwork, int lwork, float* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvj_work")]
            public static extern int ZgesvjWork(BLAS.MatrixLayout matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, IntPtr a, int lda, double* sva, int mv, IntPtr v, int ldv, IntPtr cwork, int lwork, double* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvx_work")]
            public static extern int SgesvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvx_work")]
            public static extern int DgesvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvx_work")]
            public static extern int CgesvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvx_work")]
            public static extern int ZgesvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgesvxx_work")]
            public static extern int SgesvxxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgesvxx_work")]
            public static extern int DgesvxxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgesvxx_work")]
            public static extern int CgesvxxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgesvxx_work")]
            public static extern int ZgesvxxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetf2_work")]
            public static extern int Sgetf2Work(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetf2_work")]
            public static extern int Dgetf2Work(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetf2_work")]
            public static extern int Cgetf2Work(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetf2_work")]
            public static extern int Zgetf2Work(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetrf_work")]
            public static extern int SgetrfWork(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetrf_work")]
            public static extern int DgetrfWork(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetrf_work")]
            public static extern int CgetrfWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetrf_work")]
            public static extern int ZgetrfWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetrf2_work")]
            public static extern int Sgetrf2Work(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetrf2_work")]
            public static extern int Dgetrf2Work(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetrf2_work")]
            public static extern int Cgetrf2Work(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetrf2_work")]
            public static extern int Zgetrf2Work(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetri_work")]
            public static extern int SgetriWork(BLAS.MatrixLayout matrixLayout, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetri_work")]
            public static extern int DgetriWork(BLAS.MatrixLayout matrixLayout, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetri_work")]
            public static extern int CgetriWork(BLAS.MatrixLayout matrixLayout, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetri_work")]
            public static extern int ZgetriWork(BLAS.MatrixLayout matrixLayout, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetrs_work")]
            public static extern int SgetrsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetrs_work")]
            public static extern int DgetrsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetrs_work")]
            public static extern int CgetrsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetrs_work")]
            public static extern int ZgetrsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggbak_work")]
            public static extern int SggbakWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* lscale, float* rscale, int m, float* v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggbak_work")]
            public static extern int DggbakWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* lscale, double* rscale, int m, double* v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggbak_work")]
            public static extern int CggbakWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* lscale, float* rscale, int m, IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggbak_work")]
            public static extern int ZggbakWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* lscale, double* rscale, int m, IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggbal_work")]
            public static extern int SggbalWork(BLAS.MatrixLayout matrixLayout, sbyte job, int n, float* a, int lda, float* b, int ldb, int* ilo, int* ihi, float* lscale, float* rscale, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggbal_work")]
            public static extern int DggbalWork(BLAS.MatrixLayout matrixLayout, sbyte job, int n, double* a, int lda, double* b, int ldb, int* ilo, int* ihi, double* lscale, double* rscale, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggbal_work")]
            public static extern int CggbalWork(BLAS.MatrixLayout matrixLayout, sbyte job, int n, IntPtr a, int lda, IntPtr b, int ldb, int* ilo, int* ihi, float* lscale, float* rscale, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggbal_work")]
            public static extern int ZggbalWork(BLAS.MatrixLayout matrixLayout, sbyte job, int n, IntPtr a, int lda, IntPtr b, int ldb, int* ilo, int* ihi, double* lscale, double* rscale, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgges_work")]
            public static extern int SggesWork(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, float* a, int lda, float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr, float* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgges_work")]
            public static extern int DggesWork(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, double* a, int lda, double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr, double* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgges_work")]
            public static extern int CggesWork(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr, IntPtr work, int lwork, float* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgges_work")]
            public static extern int ZggesWork(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr, IntPtr work, int lwork, double* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgges3_work")]
            public static extern int Sgges3Work(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, float* a, int lda, float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr, float* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgges3_work")]
            public static extern int Dgges3Work(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, double* a, int lda, double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr, double* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgges3_work")]
            public static extern int Cgges3Work(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr, IntPtr work, int lwork, float* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgges3_work")]
            public static extern int Zgges3Work(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr, IntPtr work, int lwork, double* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggesx_work")]
            public static extern int SggesxWork(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, sbyte sense, int n, float* a, int lda, float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr, float* rconde, float* rcondv, float* work, int lwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggesx_work")]
            public static extern int DggesxWork(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, sbyte sense, int n, double* a, int lda, double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr, double* rconde, double* rcondv, double* work, int lwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggesx_work")]
            public static extern int CggesxWork(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, sbyte sense, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr, float* rconde, float* rcondv, IntPtr work, int lwork, float* rwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggesx_work")]
            public static extern int ZggesxWork(BLAS.MatrixLayout matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, IntPtr selctg, sbyte sense, int n, IntPtr a, int lda, IntPtr b, int ldb, int* sdim, IntPtr alpha, IntPtr beta, IntPtr vsl, int ldvsl, IntPtr vsr, int ldvsr, double* rconde, double* rcondv, IntPtr work, int lwork, double* rwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggev_work")]
            public static extern int SggevWork(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggev_work")]
            public static extern int DggevWork(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggev_work")]
            public static extern int CggevWork(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggev_work")]
            public static extern int ZggevWork(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggev3_work")]
            public static extern int Sggev3Work(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggev3_work")]
            public static extern int Dggev3Work(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggev3_work")]
            public static extern int Cggev3Work(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggev3_work")]
            public static extern int Zggev3Work(BLAS.MatrixLayout matrixLayout, sbyte jobvl, sbyte jobvr, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggevx_work")]
            public static extern int SggevxWork(BLAS.MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr, int* ilo, int* ihi, float* lscale, float* rscale, float* abnrm, float* bbnrm, float* rconde, float* rcondv, float* work, int lwork, int* iwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggevx_work")]
            public static extern int DggevxWork(BLAS.MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr, int* ilo, int* ihi, double* lscale, double* rscale, double* abnrm, double* bbnrm, double* rconde, double* rcondv, double* work, int lwork, int* iwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggevx_work")]
            public static extern int CggevxWork(BLAS.MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int* ilo, int* ihi, float* lscale, float* rscale, float* abnrm, float* bbnrm, float* rconde, float* rcondv, IntPtr work, int lwork, float* rwork, int* iwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggevx_work")]
            public static extern int ZggevxWork(BLAS.MatrixLayout matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int* ilo, int* ihi, double* lscale, double* rscale, double* abnrm, double* bbnrm, double* rconde, double* rcondv, IntPtr work, int lwork, double* rwork, int* iwork, int* bwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggglm_work")]
            public static extern int SggglmWork(BLAS.MatrixLayout matrixLayout, int n, int m, int p, float* a, int lda, float* b, int ldb, float* d, float* x, float* y, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggglm_work")]
            public static extern int DggglmWork(BLAS.MatrixLayout matrixLayout, int n, int m, int p, double* a, int lda, double* b, int ldb, double* d, double* x, double* y, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggglm_work")]
            public static extern int CggglmWork(BLAS.MatrixLayout matrixLayout, int n, int m, int p, IntPtr a, int lda, IntPtr b, int ldb, IntPtr d, IntPtr x, IntPtr y, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggglm_work")]
            public static extern int ZggglmWork(BLAS.MatrixLayout matrixLayout, int n, int m, int p, IntPtr a, int lda, IntPtr b, int ldb, IntPtr d, IntPtr x, IntPtr y, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgghrd_work")]
            public static extern int SgghrdWork(BLAS.MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgghrd_work")]
            public static extern int DgghrdWork(BLAS.MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgghrd_work")]
            public static extern int CgghrdWork(BLAS.MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgghrd_work")]
            public static extern int ZgghrdWork(BLAS.MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgghd3_work")]
            public static extern int Sgghd3Work(BLAS.MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgghd3_work")]
            public static extern int Dgghd3Work(BLAS.MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z, int ldz, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgghd3_work")]
            public static extern int Cgghd3Work(BLAS.MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgghd3_work")]
            public static extern int Zgghd3Work(BLAS.MatrixLayout matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgglse_work")]
            public static extern int SgglseWork(BLAS.MatrixLayout matrixLayout, int m, int n, int p, float* a, int lda, float* b, int ldb, float* c, float* d, float* x, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgglse_work")]
            public static extern int DgglseWork(BLAS.MatrixLayout matrixLayout, int m, int n, int p, double* a, int lda, double* b, int ldb, double* c, double* d, double* x, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgglse_work")]
            public static extern int CgglseWork(BLAS.MatrixLayout matrixLayout, int m, int n, int p, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, IntPtr d, IntPtr x, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgglse_work")]
            public static extern int ZgglseWork(BLAS.MatrixLayout matrixLayout, int m, int n, int p, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, IntPtr d, IntPtr x, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggqrf_work")]
            public static extern int SggqrfWork(BLAS.MatrixLayout matrixLayout, int n, int m, int p, float* a, int lda, float* taua, float* b, int ldb, float* taub, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggqrf_work")]
            public static extern int DggqrfWork(BLAS.MatrixLayout matrixLayout, int n, int m, int p, double* a, int lda, double* taua, double* b, int ldb, double* taub, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggqrf_work")]
            public static extern int CggqrfWork(BLAS.MatrixLayout matrixLayout, int n, int m, int p, IntPtr a, int lda, IntPtr taua, IntPtr b, int ldb, IntPtr taub, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggqrf_work")]
            public static extern int ZggqrfWork(BLAS.MatrixLayout matrixLayout, int n, int m, int p, IntPtr a, int lda, IntPtr taua, IntPtr b, int ldb, IntPtr taub, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggrqf_work")]
            public static extern int SggrqfWork(BLAS.MatrixLayout matrixLayout, int m, int p, int n, float* a, int lda, float* taua, float* b, int ldb, float* taub, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggrqf_work")]
            public static extern int DggrqfWork(BLAS.MatrixLayout matrixLayout, int m, int p, int n, double* a, int lda, double* taua, double* b, int ldb, double* taub, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggrqf_work")]
            public static extern int CggrqfWork(BLAS.MatrixLayout matrixLayout, int m, int p, int n, IntPtr a, int lda, IntPtr taua, IntPtr b, int ldb, IntPtr taub, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggrqf_work")]
            public static extern int ZggrqfWork(BLAS.MatrixLayout matrixLayout, int m, int p, int n, IntPtr a, int lda, IntPtr taua, IntPtr b, int ldb, IntPtr taub, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggsvd_work")]
            public static extern int SggsvdWork(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, float* a, int lda, float* b, int ldb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggsvd_work")]
            public static extern int DggsvdWork(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, double* a, int lda, double* b, int ldb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggsvd_work")]
            public static extern int CggsvdWork(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, IntPtr a, int lda, IntPtr b, int ldb, float* alpha, float* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, IntPtr work, float* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggsvd_work")]
            public static extern int ZggsvdWork(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, IntPtr a, int lda, IntPtr b, int ldb, double* alpha, double* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, IntPtr work, double* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggsvd3_work")]
            public static extern int Sggsvd3Work(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, float* a, int lda, float* b, int ldb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggsvd3_work")]
            public static extern int Dggsvd3Work(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, double* a, int lda, double* b, int ldb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggsvd3_work")]
            public static extern int Cggsvd3Work(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, IntPtr a, int lda, IntPtr b, int ldb, float* alpha, float* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, IntPtr work, int lwork, float* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggsvd3_work")]
            public static extern int Zggsvd3Work(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, IntPtr a, int lda, IntPtr b, int ldb, double* alpha, double* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, IntPtr work, int lwork, double* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggsvp_work")]
            public static extern int SggsvpWork(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, float* a, int lda, float* b, int ldb, float tola, float tolb, int* k, int* l, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* iwork, float* tau, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggsvp_work")]
            public static extern int DggsvpWork(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, double* a, int lda, double* b, int ldb, double tola, double tolb, int* k, int* l, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* iwork, double* tau, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggsvp_work")]
            public static extern int CggsvpWork(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, IntPtr a, int lda, IntPtr b, int ldb, float tola, float tolb, int* k, int* l, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, int* iwork, float* rwork, IntPtr tau, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggsvp_work")]
            public static extern int ZggsvpWork(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, IntPtr a, int lda, IntPtr b, int ldb, double tola, double tolb, int* k, int* l, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, int* iwork, double* rwork, IntPtr tau, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sggsvp3_work")]
            public static extern int Sggsvp3Work(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, float* a, int lda, float* b, int ldb, float tola, float tolb, int* k, int* l, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* iwork, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dggsvp3_work")]
            public static extern int Dggsvp3Work(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, double* a, int lda, double* b, int ldb, double tola, double tolb, int* k, int* l, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* iwork, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cggsvp3_work")]
            public static extern int Cggsvp3Work(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, IntPtr a, int lda, IntPtr b, int ldb, float tola, float tolb, int* k, int* l, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, int* iwork, float* rwork, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zggsvp3_work")]
            public static extern int Zggsvp3Work(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, IntPtr a, int lda, IntPtr b, int ldb, double tola, double tolb, int* k, int* l, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, int* iwork, double* rwork, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgtcon_work")]
            public static extern int SgtconWork(sbyte norm, int n, float* dl, float* d, float* du, float* du2, int* ipiv, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgtcon_work")]
            public static extern int DgtconWork(sbyte norm, int n, double* dl, double* d, double* du, double* du2, int* ipiv, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgtcon_work")]
            public static extern int CgtconWork(sbyte norm, int n, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv, float anorm, float* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgtcon_work")]
            public static extern int ZgtconWork(sbyte norm, int n, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv, double anorm, double* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgtrfs_work")]
            public static extern int SgtrfsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* dl, float* d, float* du, float* dlf, float* df, float* duf, float* du2, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgtrfs_work")]
            public static extern int DgtrfsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* dl, double* d, double* du, double* dlf, double* df, double* duf, double* du2, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgtrfs_work")]
            public static extern int CgtrfsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr dlf, IntPtr df, IntPtr duf, IntPtr du2, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgtrfs_work")]
            public static extern int ZgtrfsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr dlf, IntPtr df, IntPtr duf, IntPtr du2, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgtsv_work")]
            public static extern int SgtsvWork(BLAS.MatrixLayout matrixLayout, int n, int nrhs, float* dl, float* d, float* du, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgtsv_work")]
            public static extern int DgtsvWork(BLAS.MatrixLayout matrixLayout, int n, int nrhs, double* dl, double* d, double* du, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgtsv_work")]
            public static extern int CgtsvWork(BLAS.MatrixLayout matrixLayout, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgtsv_work")]
            public static extern int ZgtsvWork(BLAS.MatrixLayout matrixLayout, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgtsvx_work")]
            public static extern int SgtsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, float* dl, float* d, float* du, float* dlf, float* df, float* duf, float* du2, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgtsvx_work")]
            public static extern int DgtsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, double* dl, double* d, double* du, double* dlf, double* df, double* duf, double* du2, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgtsvx_work")]
            public static extern int CgtsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr dlf, IntPtr df, IntPtr duf, IntPtr du2, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgtsvx_work")]
            public static extern int ZgtsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr dlf, IntPtr df, IntPtr duf, IntPtr du2, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgttrf_work")]
            public static extern int SgttrfWork(int n, float* dl, float* d, float* du, float* du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgttrf_work")]
            public static extern int DgttrfWork(int n, double* dl, double* d, double* du, double* du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgttrf_work")]
            public static extern int CgttrfWork(int n, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgttrf_work")]
            public static extern int ZgttrfWork(int n, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgttrs_work")]
            public static extern int SgttrsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* dl, float* d, float* du, float* du2, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgttrs_work")]
            public static extern int DgttrsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* dl, double* d, double* du, double* du2, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgttrs_work")]
            public static extern int CgttrsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgttrs_work")]
            public static extern int ZgttrsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int n, int nrhs, IntPtr dl, IntPtr d, IntPtr du, IntPtr du2, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbev_work")]
            public static extern int ChbevWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, IntPtr ab, int ldab, float* w, IntPtr z, int ldz, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbev_work")]
            public static extern int ZhbevWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, IntPtr ab, int ldab, double* w, IntPtr z, int ldz, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbevd_work")]
            public static extern int ChbevdWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, IntPtr ab, int ldab, float* w, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbevd_work")]
            public static extern int ZhbevdWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, IntPtr ab, int ldab, double* w, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbevx_work")]
            public static extern int ChbevxWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, IntPtr ab, int ldab, IntPtr q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, IntPtr work, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbevx_work")]
            public static extern int ZhbevxWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, IntPtr ab, int ldab, IntPtr q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, IntPtr work, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbgst_work")]
            public static extern int ChbgstWork(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, IntPtr x, int ldx, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbgst_work")]
            public static extern int ZhbgstWork(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, IntPtr x, int ldx, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbgv_work")]
            public static extern int ChbgvWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, float* w, IntPtr z, int ldz, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbgv_work")]
            public static extern int ZhbgvWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, double* w, IntPtr z, int ldz, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbgvd_work")]
            public static extern int ChbgvdWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, float* w, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbgvd_work")]
            public static extern int ZhbgvdWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, double* w, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbgvx_work")]
            public static extern int ChbgvxWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, IntPtr q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, IntPtr work, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbgvx_work")]
            public static extern int ZhbgvxWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, IntPtr ab, int ldab, IntPtr bb, int ldbb, IntPtr q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, IntPtr work, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbtrd_work")]
            public static extern int ChbtrdWork(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte uplo, int n, int kd, IntPtr ab, int ldab, float* d, float* e, IntPtr q, int ldq, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbtrd_work")]
            public static extern int ZhbtrdWork(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte uplo, int n, int kd, IntPtr ab, int ldab, double* d, double* e, IntPtr q, int ldq, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_checon_work")]
            public static extern int CheconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, float anorm, float* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhecon_work")]
            public static extern int ZheconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, double anorm, double* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheequb_work")]
            public static extern int CheequbWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, float* s, float* scond, float* amax, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheequb_work")]
            public static extern int ZheequbWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, double* s, double* scond, double* amax, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheev_work")]
            public static extern int CheevWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, float* w, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheev_work")]
            public static extern int ZheevWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, double* w, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevd_work")]
            public static extern int CheevdWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, float* w, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevd_work")]
            public static extern int ZheevdWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, double* w, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevr_work")]
            public static extern int CheevrWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* isuppz, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevr_work")]
            public static extern int ZheevrWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* isuppz, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevx_work")]
            public static extern int CheevxWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevx_work")]
            public static extern int ZheevxWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chegst_work")]
            public static extern int ChegstWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte uplo, int n, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhegst_work")]
            public static extern int ZhegstWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte uplo, int n, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chegv_work")]
            public static extern int ChegvWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, float* w, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhegv_work")]
            public static extern int ZhegvWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, double* w, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chegvd_work")]
            public static extern int ChegvdWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, float* w, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhegvd_work")]
            public static extern int ZhegvdWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, double* w, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chegvx_work")]
            public static extern int ChegvxWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhegvx_work")]
            public static extern int ZhegvxWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cherfs_work")]
            public static extern int CherfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zherfs_work")]
            public static extern int ZherfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cherfsx_work")]
            public static extern int CherfsxWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zherfsx_work")]
            public static extern int ZherfsxWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesv_work")]
            public static extern int ChesvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesv_work")]
            public static extern int ZhesvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesvx_work")]
            public static extern int ChesvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesvx_work")]
            public static extern int ZhesvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesvxx_work")]
            public static extern int ChesvxxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesvxx_work")]
            public static extern int ZhesvxxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrd_work")]
            public static extern int ChetrdWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, float* d, float* e, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrd_work")]
            public static extern int ZhetrdWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, double* d, double* e, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrf_work")]
            public static extern int ChetrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrf_work")]
            public static extern int ZhetrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetri_work")]
            public static extern int ChetriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetri_work")]
            public static extern int ZhetriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs_work")]
            public static extern int ChetrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs_work")]
            public static extern int ZhetrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chfrk_work")]
            public static extern int ChfrkWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, float alpha, IntPtr a, int lda, float beta, IntPtr c);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhfrk_work")]
            public static extern int ZhfrkWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, double alpha, IntPtr a, int lda, double beta, IntPtr c);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_shgeqz_work")]
            public static extern int ShgeqzWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* h, int ldh, float* t, int ldt, float* alphar, float* alphai, float* beta, float* q, int ldq, float* z, int ldz, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dhgeqz_work")]
            public static extern int DhgeqzWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* h, int ldh, double* t, int ldt, double* alphar, double* alphai, double* beta, double* q, int ldq, double* z, int ldz, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chgeqz_work")]
            public static extern int ChgeqzWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr h, int ldh, IntPtr t, int ldt, IntPtr alpha, IntPtr beta, IntPtr q, int ldq, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhgeqz_work")]
            public static extern int ZhgeqzWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, IntPtr h, int ldh, IntPtr t, int ldt, IntPtr alpha, IntPtr beta, IntPtr q, int ldq, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpcon_work")]
            public static extern int ChpconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv, float anorm, float* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpcon_work")]
            public static extern int ZhpconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv, double anorm, double* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpev_work")]
            public static extern int ChpevWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr ap, float* w, IntPtr z, int ldz, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpev_work")]
            public static extern int ZhpevWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr ap, double* w, IntPtr z, int ldz, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpevd_work")]
            public static extern int ChpevdWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr ap, float* w, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpevd_work")]
            public static extern int ZhpevdWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr ap, double* w, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpevx_work")]
            public static extern int ChpevxWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr ap, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, IntPtr work, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpevx_work")]
            public static extern int ZhpevxWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr ap, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, IntPtr work, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpgst_work")]
            public static extern int ChpgstWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte uplo, int n, IntPtr ap, IntPtr bp);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpgst_work")]
            public static extern int ZhpgstWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte uplo, int n, IntPtr ap, IntPtr bp);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpgv_work")]
            public static extern int ChpgvWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, IntPtr ap, IntPtr bp, float* w, IntPtr z, int ldz, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpgv_work")]
            public static extern int ZhpgvWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, IntPtr ap, IntPtr bp, double* w, IntPtr z, int ldz, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpgvd_work")]
            public static extern int ChpgvdWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, IntPtr ap, IntPtr bp, float* w, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpgvd_work")]
            public static extern int ZhpgvdWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, IntPtr ap, IntPtr bp, double* w, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpgvx_work")]
            public static extern int ChpgvxWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr ap, IntPtr bp, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, IntPtr work, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpgvx_work")]
            public static extern int ZhpgvxWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr ap, IntPtr bp, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, IntPtr work, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chprfs_work")]
            public static extern int ChprfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhprfs_work")]
            public static extern int ZhprfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpsv_work")]
            public static extern int ChpsvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpsv_work")]
            public static extern int ZhpsvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chpsvx_work")]
            public static extern int ChpsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhpsvx_work")]
            public static extern int ZhpsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chptrd_work")]
            public static extern int ChptrdWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, float* d, float* e, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhptrd_work")]
            public static extern int ZhptrdWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, double* d, double* e, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chptrf_work")]
            public static extern int ChptrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhptrf_work")]
            public static extern int ZhptrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chptri_work")]
            public static extern int ChptriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhptri_work")]
            public static extern int ZhptriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chptrs_work")]
            public static extern int ChptrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhptrs_work")]
            public static extern int ZhptrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_shsein_work")]
            public static extern int ShseinWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, float* h, int ldh, float* wr, float* wi, float* vl, int ldvl, float* vr, int ldvr, int mm, int* m, float* work, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dhsein_work")]
            public static extern int DhseinWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, double* h, int ldh, double* wr, double* wi, double* vl, int ldvl, double* vr, int ldvr, int mm, int* m, double* work, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chsein_work")]
            public static extern int ChseinWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, IntPtr h, int ldh, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m, IntPtr work, float* rwork, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhsein_work")]
            public static extern int ZhseinWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, IntPtr h, int ldh, IntPtr w, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m, IntPtr work, double* rwork, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_shseqr_work")]
            public static extern int ShseqrWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, float* h, int ldh, float* wr, float* wi, float* z, int ldz, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dhseqr_work")]
            public static extern int DhseqrWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, double* h, int ldh, double* wr, double* wi, double* z, int ldz, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chseqr_work")]
            public static extern int ChseqrWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, IntPtr h, int ldh, IntPtr w, IntPtr z, int ldz, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhseqr_work")]
            public static extern int ZhseqrWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, IntPtr h, int ldh, IntPtr w, IntPtr z, int ldz, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clacgv_work")]
            public static extern int ClacgvWork(int n, IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlacgv_work")]
            public static extern int ZlacgvWork(int n, IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slacn2_work")]
            public static extern int Slacn2Work(int n, float* v, float* x, int* isgn, float* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlacn2_work")]
            public static extern int Dlacn2Work(int n, double* v, double* x, int* isgn, double* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clacn2_work")]
            public static extern int Clacn2Work(int n, IntPtr v, IntPtr x, float* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlacn2_work")]
            public static extern int Zlacn2Work(int n, IntPtr v, IntPtr x, double* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slacpy_work")]
            public static extern int SlacpyWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int m, int n, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlacpy_work")]
            public static extern int DlacpyWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int m, int n, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clacpy_work")]
            public static extern int ClacpyWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int m, int n, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlacpy_work")]
            public static extern int ZlacpyWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int m, int n, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clacp2_work")]
            public static extern int Clacp2Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int m, int n, float* a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlacp2_work")]
            public static extern int Zlacp2Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int m, int n, double* a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlag2c_work")]
            public static extern int Zlag2cWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr sa, int ldsa);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slag2d_work")]
            public static extern int Slag2dWork(BLAS.MatrixLayout matrixLayout, int m, int n, float* sa, int ldsa, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlag2s_work")]
            public static extern int Dlag2sWork(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, float* sa, int ldsa);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clag2z_work")]
            public static extern int Clag2zWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr sa, int ldsa, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slagge_work")]
            public static extern int SlaggeWork(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, float* d, float* a, int lda, int* iseed, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlagge_work")]
            public static extern int DlaggeWork(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, double* d, double* a, int lda, int* iseed, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clagge_work")]
            public static extern int ClaggeWork(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, float* d, IntPtr a, int lda, int* iseed, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlagge_work")]
            public static extern int ZlaggeWork(BLAS.MatrixLayout matrixLayout, int m, int n, int kl, int ku, double* d, IntPtr a, int lda, int* iseed, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_claghe_work")]
            public static extern int ClagheWork(BLAS.MatrixLayout matrixLayout, int n, int k, float* d, IntPtr a, int lda, int* iseed, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlaghe_work")]
            public static extern int ZlagheWork(BLAS.MatrixLayout matrixLayout, int n, int k, double* d, IntPtr a, int lda, int* iseed, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slagsy_work")]
            public static extern int SlagsyWork(BLAS.MatrixLayout matrixLayout, int n, int k, float* d, float* a, int lda, int* iseed, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlagsy_work")]
            public static extern int DlagsyWork(BLAS.MatrixLayout matrixLayout, int n, int k, double* d, double* a, int lda, int* iseed, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clagsy_work")]
            public static extern int ClagsyWork(BLAS.MatrixLayout matrixLayout, int n, int k, float* d, IntPtr a, int lda, int* iseed, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlagsy_work")]
            public static extern int ZlagsyWork(BLAS.MatrixLayout matrixLayout, int n, int k, double* d, IntPtr a, int lda, int* iseed, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slapmr_work")]
            public static extern int SlapmrWork(BLAS.MatrixLayout matrixLayout, int forwrd, int m, int n, float* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlapmr_work")]
            public static extern int DlapmrWork(BLAS.MatrixLayout matrixLayout, int forwrd, int m, int n, double* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clapmr_work")]
            public static extern int ClapmrWork(BLAS.MatrixLayout matrixLayout, int forwrd, int m, int n, IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlapmr_work")]
            public static extern int ZlapmrWork(BLAS.MatrixLayout matrixLayout, int forwrd, int m, int n, IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slapmt_work")]
            public static extern int SlapmtWork(BLAS.MatrixLayout matrixLayout, int forwrd, int m, int n, float* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlapmt_work")]
            public static extern int DlapmtWork(BLAS.MatrixLayout matrixLayout, int forwrd, int m, int n, double* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clapmt_work")]
            public static extern int ClapmtWork(BLAS.MatrixLayout matrixLayout, int forwrd, int m, int n, IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlapmt_work")]
            public static extern int ZlapmtWork(BLAS.MatrixLayout matrixLayout, int forwrd, int m, int n, IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slartgp_work")]
            public static extern int SlartgpWork(float f, float g, float* cs, float* sn, float* r);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlartgp_work")]
            public static extern int DlartgpWork(double f, double g, double* cs, double* sn, double* r);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slartgs_work")]
            public static extern int SlartgsWork(float x, float y, float sigma, float* cs, float* sn);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlartgs_work")]
            public static extern int DlartgsWork(double x, double y, double sigma, double* cs, double* sn);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slapy2_work")]
            public static extern float Slapy2Work(float x, float y);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlapy2_work")]
            public static extern double Dlapy2Work(double x, double y);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slapy3_work")]
            public static extern float Slapy3Work(float x, float y, float z);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlapy3_work")]
            public static extern double Dlapy3Work(double x, double y, double z);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slamch_work")]
            public static extern float SlamchWork(sbyte cmach);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlamch_work")]
            public static extern double DlamchWork(sbyte cmach);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slange_work")]
            public static extern float SlangeWork(BLAS.MatrixLayout matrixLayout, sbyte norm, int m, int n, float* a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlange_work")]
            public static extern double DlangeWork(BLAS.MatrixLayout matrixLayout, sbyte norm, int m, int n, double* a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clange_work")]
            public static extern float ClangeWork(BLAS.MatrixLayout matrixLayout, sbyte norm, int m, int n, IntPtr a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlange_work")]
            public static extern double ZlangeWork(BLAS.MatrixLayout matrixLayout, sbyte norm, int m, int n, IntPtr a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clanhe_work")]
            public static extern float ClanheWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, int n, IntPtr a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlanhe_work")]
            public static extern double ZlanheWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, int n, IntPtr a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clacrm_work")]
            public static extern int ClacrmWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, float* b, int ldb, IntPtr c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlacrm_work")]
            public static extern int ZlacrmWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, double* b, int ldb, IntPtr c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarcm_work")]
            public static extern int ClarcmWork(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, IntPtr b, int ldb, IntPtr c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarcm_work")]
            public static extern int ZlarcmWork(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, IntPtr b, int ldb, IntPtr c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slansy_work")]
            public static extern float SlansyWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, int n, float* a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlansy_work")]
            public static extern double DlansyWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, int n, double* a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clansy_work")]
            public static extern float ClansyWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, int n, IntPtr a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlansy_work")]
            public static extern double ZlansyWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, int n, IntPtr a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slantr_work")]
            public static extern float SlantrWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, float* a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlantr_work")]
            public static extern double DlantrWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, double* a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clantr_work")]
            public static extern float ClantrWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, IntPtr a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlantr_work")]
            public static extern double ZlantrWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, IntPtr a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slarfb_work")]
            public static extern int SlarfbWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, float* v, int ldv, float* t, int ldt, float* c, int ldc, float* work, int ldwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlarfb_work")]
            public static extern int DlarfbWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, double* v, int ldv, double* t, int ldt, double* c, int ldc, double* work, int ldwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarfb_work")]
            public static extern int ClarfbWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr c, int ldc, IntPtr work, int ldwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarfb_work")]
            public static extern int ZlarfbWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr c, int ldc, IntPtr work, int ldwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slarfg_work")]
            public static extern int SlarfgWork(int n, float* alpha, float* x, int incx, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlarfg_work")]
            public static extern int DlarfgWork(int n, double* alpha, double* x, int incx, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarfg_work")]
            public static extern int ClarfgWork(int n, IntPtr alpha, IntPtr x, int incx, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarfg_work")]
            public static extern int ZlarfgWork(int n, IntPtr alpha, IntPtr x, int incx, IntPtr tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slarft_work")]
            public static extern int SlarftWork(BLAS.MatrixLayout matrixLayout, sbyte direct, sbyte storev, int n, int k, float* v, int ldv, float* tau, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlarft_work")]
            public static extern int DlarftWork(BLAS.MatrixLayout matrixLayout, sbyte direct, sbyte storev, int n, int k, double* v, int ldv, double* tau, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarft_work")]
            public static extern int ClarftWork(BLAS.MatrixLayout matrixLayout, sbyte direct, sbyte storev, int n, int k, IntPtr v, int ldv, IntPtr tau, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarft_work")]
            public static extern int ZlarftWork(BLAS.MatrixLayout matrixLayout, sbyte direct, sbyte storev, int n, int k, IntPtr v, int ldv, IntPtr tau, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slarfx_work")]
            public static extern int SlarfxWork(BLAS.MatrixLayout matrixLayout, sbyte side, int m, int n, float* v, float tau, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlarfx_work")]
            public static extern int DlarfxWork(BLAS.MatrixLayout matrixLayout, sbyte side, int m, int n, double* v, double tau, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarfx_work")]
            public static extern int ClarfxWork(BLAS.MatrixLayout matrixLayout, sbyte side, int m, int n, IntPtr v, ComplexFloat tau, IntPtr c, int ldc, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarfx_work")]
            public static extern int ZlarfxWork(BLAS.MatrixLayout matrixLayout, sbyte side, int m, int n, IntPtr v, IntPtr tau, IntPtr c, int ldc, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slarnv_work")]
            public static extern int SlarnvWork(int idist, int* iseed, int n, float* x);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlarnv_work")]
            public static extern int DlarnvWork(int idist, int* iseed, int n, double* x);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clarnv_work")]
            public static extern int ClarnvWork(int idist, int* iseed, int n, IntPtr x);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlarnv_work")]
            public static extern int ZlarnvWork(int idist, int* iseed, int n, IntPtr x);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slascl_work")]
            public static extern int SlasclWork(BLAS.MatrixLayout matrixLayout, sbyte type, int kl, int ku, float cfrom, float cto, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlascl_work")]
            public static extern int DlasclWork(BLAS.MatrixLayout matrixLayout, sbyte type, int kl, int ku, double cfrom, double cto, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clascl_work")]
            public static extern int ClasclWork(BLAS.MatrixLayout matrixLayout, sbyte type, int kl, int ku, float cfrom, float cto, int m, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlascl_work")]
            public static extern int ZlasclWork(BLAS.MatrixLayout matrixLayout, sbyte type, int kl, int ku, double cfrom, double cto, int m, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slaset_work")]
            public static extern int SlasetWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int m, int n, float alpha, float beta, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlaset_work")]
            public static extern int DlasetWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int m, int n, double alpha, double beta, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_claset_work")]
            public static extern int ClasetWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int m, int n, ComplexFloat alpha, ComplexFloat beta, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlaset_work")]
            public static extern int ZlasetWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int m, int n, IntPtr alpha, IntPtr beta, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slasrt_work")]
            public static extern int SlasrtWork(sbyte id, int n, float* d);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlasrt_work")]
            public static extern int DlasrtWork(sbyte id, int n, double* d);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slassq_work")]
            public static extern int SlassqWork(int n, float* x, int incx, float* scale, float* sumsq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlassq_work")]
            public static extern int DlassqWork(int n, double* x, int incx, double* scale, double* sumsq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_classq_work")]
            public static extern int ClassqWork(int n, IntPtr x, int incx, float* scale, float* sumsq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlassq_work")]
            public static extern int ZlassqWork(int n, IntPtr x, int incx, double* scale, double* sumsq);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slaswp_work")]
            public static extern int SlaswpWork(BLAS.MatrixLayout matrixLayout, int n, float* a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlaswp_work")]
            public static extern int DlaswpWork(BLAS.MatrixLayout matrixLayout, int n, double* a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_claswp_work")]
            public static extern int ClaswpWork(BLAS.MatrixLayout matrixLayout, int n, IntPtr a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlaswp_work")]
            public static extern int ZlaswpWork(BLAS.MatrixLayout matrixLayout, int n, IntPtr a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slatms_work")]
            public static extern int SlatmsWork(BLAS.MatrixLayout matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, float* d, int mode, float cond, float dmax, int kl, int ku, sbyte pack, float* a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlatms_work")]
            public static extern int DlatmsWork(BLAS.MatrixLayout matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, double* d, int mode, double cond, double dmax, int kl, int ku, sbyte pack, double* a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clatms_work")]
            public static extern int ClatmsWork(BLAS.MatrixLayout matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, float* d, int mode, float cond, float dmax, int kl, int ku, sbyte pack, IntPtr a, int lda, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlatms_work")]
            public static extern int ZlatmsWork(BLAS.MatrixLayout matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, double* d, int mode, double cond, double dmax, int kl, int ku, sbyte pack, IntPtr a, int lda, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slauum_work")]
            public static extern int SlauumWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlauum_work")]
            public static extern int DlauumWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clauum_work")]
            public static extern int ClauumWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlauum_work")]
            public static extern int ZlauumWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sopgtr_work")]
            public static extern int SopgtrWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* ap, float* tau, float* q, int ldq, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dopgtr_work")]
            public static extern int DopgtrWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* ap, double* tau, double* q, int ldq, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sopmtr_work")]
            public static extern int SopmtrWork(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, float* ap, float* tau, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dopmtr_work")]
            public static extern int DopmtrWork(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, double* ap, double* tau, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorgbr_work")]
            public static extern int SorgbrWork(BLAS.MatrixLayout matrixLayout, sbyte vect, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorgbr_work")]
            public static extern int DorgbrWork(BLAS.MatrixLayout matrixLayout, sbyte vect, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorghr_work")]
            public static extern int SorghrWork(BLAS.MatrixLayout matrixLayout, int n, int ilo, int ihi, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorghr_work")]
            public static extern int DorghrWork(BLAS.MatrixLayout matrixLayout, int n, int ilo, int ihi, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorglq_work")]
            public static extern int SorglqWork(BLAS.MatrixLayout matrixLayout, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorglq_work")]
            public static extern int DorglqWork(BLAS.MatrixLayout matrixLayout, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorgql_work")]
            public static extern int SorgqlWork(BLAS.MatrixLayout matrixLayout, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorgql_work")]
            public static extern int DorgqlWork(BLAS.MatrixLayout matrixLayout, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorgqr_work")]
            public static extern int SorgqrWork(BLAS.MatrixLayout matrixLayout, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorgqr_work")]
            public static extern int DorgqrWork(BLAS.MatrixLayout matrixLayout, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorgrq_work")]
            public static extern int SorgrqWork(BLAS.MatrixLayout matrixLayout, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorgrq_work")]
            public static extern int DorgrqWork(BLAS.MatrixLayout matrixLayout, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorgtr_work")]
            public static extern int SorgtrWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorgtr_work")]
            public static extern int DorgtrWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormbr_work")]
            public static extern int SormbrWork(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormbr_work")]
            public static extern int DormbrWork(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormhr_work")]
            public static extern int SormhrWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormhr_work")]
            public static extern int DormhrWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormlq_work")]
            public static extern int SormlqWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormlq_work")]
            public static extern int DormlqWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormql_work")]
            public static extern int SormqlWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormql_work")]
            public static extern int DormqlWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormqr_work")]
            public static extern int SormqrWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormqr_work")]
            public static extern int DormqrWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormrq_work")]
            public static extern int SormrqWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormrq_work")]
            public static extern int DormrqWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormrz_work")]
            public static extern int SormrzWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormrz_work")]
            public static extern int DormrzWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sormtr_work")]
            public static extern int SormtrWork(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dormtr_work")]
            public static extern int DormtrWork(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbcon_work")]
            public static extern int SpbconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, float* ab, int ldab, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbcon_work")]
            public static extern int DpbconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, double* ab, int ldab, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbcon_work")]
            public static extern int CpbconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, IntPtr ab, int ldab, float anorm, float* rcond, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbcon_work")]
            public static extern int ZpbconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, IntPtr ab, int ldab, double anorm, double* rcond, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbequ_work")]
            public static extern int SpbequWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, float* ab, int ldab, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbequ_work")]
            public static extern int DpbequWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, double* ab, int ldab, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbequ_work")]
            public static extern int CpbequWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, IntPtr ab, int ldab, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbequ_work")]
            public static extern int ZpbequWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, IntPtr ab, int ldab, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbrfs_work")]
            public static extern int SpbrfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* afb, int ldafb, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbrfs_work")]
            public static extern int DpbrfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* afb, int ldafb, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbrfs_work")]
            public static extern int CpbrfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbrfs_work")]
            public static extern int ZpbrfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbstf_work")]
            public static extern int SpbstfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kb, float* bb, int ldbb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbstf_work")]
            public static extern int DpbstfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kb, double* bb, int ldbb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbstf_work")]
            public static extern int CpbstfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kb, IntPtr bb, int ldbb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbstf_work")]
            public static extern int ZpbstfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kb, IntPtr bb, int ldbb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbsv_work")]
            public static extern int SpbsvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbsv_work")]
            public static extern int DpbsvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbsv_work")]
            public static extern int CpbsvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbsv_work")]
            public static extern int ZpbsvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbsvx_work")]
            public static extern int SpbsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* afb, int ldafb, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbsvx_work")]
            public static extern int DpbsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* afb, int ldafb, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbsvx_work")]
            public static extern int CpbsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbsvx_work")]
            public static extern int ZpbsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr afb, int ldafb, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbtrf_work")]
            public static extern int SpbtrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, float* ab, int ldab);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbtrf_work")]
            public static extern int DpbtrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, double* ab, int ldab);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbtrf_work")]
            public static extern int CpbtrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, IntPtr ab, int ldab);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbtrf_work")]
            public static extern int ZpbtrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, IntPtr ab, int ldab);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spbtrs_work")]
            public static extern int SpbtrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpbtrs_work")]
            public static extern int DpbtrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpbtrs_work")]
            public static extern int CpbtrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpbtrs_work")]
            public static extern int ZpbtrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spftrf_work")]
            public static extern int SpftrfWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, float* a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpftrf_work")]
            public static extern int DpftrfWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, double* a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpftrf_work")]
            public static extern int CpftrfWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpftrf_work")]
            public static extern int ZpftrfWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spftri_work")]
            public static extern int SpftriWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, float* a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpftri_work")]
            public static extern int DpftriWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, double* a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpftri_work")]
            public static extern int CpftriWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpftri_work")]
            public static extern int ZpftriWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spftrs_work")]
            public static extern int SpftrsWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, float* a, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpftrs_work")]
            public static extern int DpftrsWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, double* a, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpftrs_work")]
            public static extern int CpftrsWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, IntPtr a, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpftrs_work")]
            public static extern int ZpftrsWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, IntPtr a, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spocon_work")]
            public static extern int SpoconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpocon_work")]
            public static extern int DpoconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpocon_work")]
            public static extern int CpoconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, float anorm, float* rcond, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpocon_work")]
            public static extern int ZpoconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, double anorm, double* rcond, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spoequ_work")]
            public static extern int SpoequWork(BLAS.MatrixLayout matrixLayout, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpoequ_work")]
            public static extern int DpoequWork(BLAS.MatrixLayout matrixLayout, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpoequ_work")]
            public static extern int CpoequWork(BLAS.MatrixLayout matrixLayout, int n, IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpoequ_work")]
            public static extern int ZpoequWork(BLAS.MatrixLayout matrixLayout, int n, IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spoequb_work")]
            public static extern int SpoequbWork(BLAS.MatrixLayout matrixLayout, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpoequb_work")]
            public static extern int DpoequbWork(BLAS.MatrixLayout matrixLayout, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpoequb_work")]
            public static extern int CpoequbWork(BLAS.MatrixLayout matrixLayout, int n, IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpoequb_work")]
            public static extern int ZpoequbWork(BLAS.MatrixLayout matrixLayout, int n, IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sporfs_work")]
            public static extern int SporfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dporfs_work")]
            public static extern int DporfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cporfs_work")]
            public static extern int CporfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zporfs_work")]
            public static extern int ZporfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sporfsx_work")]
            public static extern int SporfsxWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dporfsx_work")]
            public static extern int DporfsxWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cporfsx_work")]
            public static extern int CporfsxWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zporfsx_work")]
            public static extern int ZporfsxWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sposv_work")]
            public static extern int SposvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dposv_work")]
            public static extern int DposvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cposv_work")]
            public static extern int CposvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zposv_work")]
            public static extern int ZposvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsposv_work")]
            public static extern int DsposvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb, double* x, int ldx, double* work, float* swork, int* iter);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zcposv_work")]
            public static extern int ZcposvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, IntPtr x, int ldx, IntPtr work, IntPtr swork, double* rwork, int* iter);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sposvx_work")]
            public static extern int SposvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dposvx_work")]
            public static extern int DposvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cposvx_work")]
            public static extern int CposvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zposvx_work")]
            public static extern int ZposvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sposvxx_work")]
            public static extern int SposvxxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dposvxx_work")]
            public static extern int DposvxxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cposvxx_work")]
            public static extern int CposvxxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zposvxx_work")]
            public static extern int ZposvxxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spotrf2_work")]
            public static extern int Spotrf2Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpotrf2_work")]
            public static extern int Dpotrf2Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpotrf2_work")]
            public static extern int Cpotrf2Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpotrf2_work")]
            public static extern int Zpotrf2Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spotrf_work")]
            public static extern int SpotrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpotrf_work")]
            public static extern int DpotrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpotrf_work")]
            public static extern int CpotrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpotrf_work")]
            public static extern int ZpotrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spotri_work")]
            public static extern int SpotriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpotri_work")]
            public static extern int DpotriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpotri_work")]
            public static extern int CpotriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpotri_work")]
            public static extern int ZpotriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spotrs_work")]
            public static extern int SpotrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpotrs_work")]
            public static extern int DpotrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpotrs_work")]
            public static extern int CpotrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpotrs_work")]
            public static extern int ZpotrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sppcon_work")]
            public static extern int SppconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* ap, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dppcon_work")]
            public static extern int DppconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* ap, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cppcon_work")]
            public static extern int CppconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, float anorm, float* rcond, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zppcon_work")]
            public static extern int ZppconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, double anorm, double* rcond, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sppequ_work")]
            public static extern int SppequWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* ap, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dppequ_work")]
            public static extern int DppequWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* ap, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cppequ_work")]
            public static extern int CppequWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zppequ_work")]
            public static extern int ZppequWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spprfs_work")]
            public static extern int SpprfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* afp, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpprfs_work")]
            public static extern int DpprfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* afp, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpprfs_work")]
            public static extern int CpprfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpprfs_work")]
            public static extern int ZpprfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sppsv_work")]
            public static extern int SppsvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dppsv_work")]
            public static extern int DppsvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cppsv_work")]
            public static extern int CppsvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zppsv_work")]
            public static extern int ZppsvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sppsvx_work")]
            public static extern int SppsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* ap, float* afp, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dppsvx_work")]
            public static extern int DppsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* ap, double* afp, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cppsvx_work")]
            public static extern int CppsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zppsvx_work")]
            public static extern int ZppsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spptrf_work")]
            public static extern int SpptrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpptrf_work")]
            public static extern int DpptrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpptrf_work")]
            public static extern int CpptrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpptrf_work")]
            public static extern int ZpptrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spptri_work")]
            public static extern int SpptriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpptri_work")]
            public static extern int DpptriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpptri_work")]
            public static extern int CpptriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpptri_work")]
            public static extern int ZpptriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spptrs_work")]
            public static extern int SpptrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpptrs_work")]
            public static extern int DpptrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpptrs_work")]
            public static extern int CpptrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpptrs_work")]
            public static extern int ZpptrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spstrf_work")]
            public static extern int SpstrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, int* piv, int* rank, float tol, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpstrf_work")]
            public static extern int DpstrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, int* piv, int* rank, double tol, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpstrf_work")]
            public static extern int CpstrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* piv, int* rank, float tol, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpstrf_work")]
            public static extern int ZpstrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* piv, int* rank, double tol, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sptcon_work")]
            public static extern int SptconWork(int n, float* d, float* e, float anorm, float* rcond, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dptcon_work")]
            public static extern int DptconWork(int n, double* d, double* e, double anorm, double* rcond, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cptcon_work")]
            public static extern int CptconWork(int n, float* d, IntPtr e, float anorm, float* rcond, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zptcon_work")]
            public static extern int ZptconWork(int n, double* d, IntPtr e, double anorm, double* rcond, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spteqr_work")]
            public static extern int SpteqrWork(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpteqr_work")]
            public static extern int DpteqrWork(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpteqr_work")]
            public static extern int CpteqrWork(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, IntPtr z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpteqr_work")]
            public static extern int ZpteqrWork(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, IntPtr z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sptrfs_work")]
            public static extern int SptrfsWork(BLAS.MatrixLayout matrixLayout, int n, int nrhs, float* d, float* e, float* df, float* ef, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dptrfs_work")]
            public static extern int DptrfsWork(BLAS.MatrixLayout matrixLayout, int n, int nrhs, double* d, double* e, double* df, double* ef, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cptrfs_work")]
            public static extern int CptrfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* d, IntPtr e, float* df, IntPtr ef, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zptrfs_work")]
            public static extern int ZptrfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* d, IntPtr e, double* df, IntPtr ef, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sptsv_work")]
            public static extern int SptsvWork(BLAS.MatrixLayout matrixLayout, int n, int nrhs, float* d, float* e, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dptsv_work")]
            public static extern int DptsvWork(BLAS.MatrixLayout matrixLayout, int n, int nrhs, double* d, double* e, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cptsv_work")]
            public static extern int CptsvWork(BLAS.MatrixLayout matrixLayout, int n, int nrhs, float* d, IntPtr e, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zptsv_work")]
            public static extern int ZptsvWork(BLAS.MatrixLayout matrixLayout, int n, int nrhs, double* d, IntPtr e, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sptsvx_work")]
            public static extern int SptsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, int n, int nrhs, float* d, float* e, float* df, float* ef, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dptsvx_work")]
            public static extern int DptsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, int n, int nrhs, double* d, double* e, double* df, double* ef, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cptsvx_work")]
            public static extern int CptsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, int n, int nrhs, float* d, IntPtr e, float* df, IntPtr ef, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zptsvx_work")]
            public static extern int ZptsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, int n, int nrhs, double* d, IntPtr e, double* df, IntPtr ef, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spttrf_work")]
            public static extern int SpttrfWork(int n, float* d, float* e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpttrf_work")]
            public static extern int DpttrfWork(int n, double* d, double* e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpttrf_work")]
            public static extern int CpttrfWork(int n, float* d, IntPtr e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpttrf_work")]
            public static extern int ZpttrfWork(int n, double* d, IntPtr e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_spttrs_work")]
            public static extern int SpttrsWork(BLAS.MatrixLayout matrixLayout, int n, int nrhs, float* d, float* e, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dpttrs_work")]
            public static extern int DpttrsWork(BLAS.MatrixLayout matrixLayout, int n, int nrhs, double* d, double* e, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cpttrs_work")]
            public static extern int CpttrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* d, IntPtr e, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zpttrs_work")]
            public static extern int ZpttrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* d, IntPtr e, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbev_work")]
            public static extern int SsbevWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbev_work")]
            public static extern int DsbevWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbevd_work")]
            public static extern int SsbevdWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbevd_work")]
            public static extern int DsbevdWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbevx_work")]
            public static extern int SsbevxWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, float* ab, int ldab, float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbevx_work")]
            public static extern int DsbevxWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, double* ab, int ldab, double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbgst_work")]
            public static extern int SsbgstWork(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* x, int ldx, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbgst_work")]
            public static extern int DsbgstWork(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* x, int ldx, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbgv_work")]
            public static extern int SsbgvWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* w, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbgv_work")]
            public static extern int DsbgvWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* w, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbgvd_work")]
            public static extern int SsbgvdWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbgvd_work")]
            public static extern int DsbgvdWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbgvx_work")]
            public static extern int SsbgvxWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbgvx_work")]
            public static extern int DsbgvxWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbtrd_work")]
            public static extern int SsbtrdWork(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte uplo, int n, int kd, float* ab, int ldab, float* d, float* e, float* q, int ldq, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbtrd_work")]
            public static extern int DsbtrdWork(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte uplo, int n, int kd, double* ab, int ldab, double* d, double* e, double* q, int ldq, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssfrk_work")]
            public static extern int SsfrkWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, float alpha, float* a, int lda, float beta, float* c);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsfrk_work")]
            public static extern int DsfrkWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, double alpha, double* a, int lda, double beta, double* c);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspcon_work")]
            public static extern int SspconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* ap, int* ipiv, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspcon_work")]
            public static extern int DspconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* ap, int* ipiv, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cspcon_work")]
            public static extern int CspconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv, float anorm, float* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zspcon_work")]
            public static extern int ZspconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv, double anorm, double* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspev_work")]
            public static extern int SspevWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, float* ap, float* w, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspev_work")]
            public static extern int DspevWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, double* ap, double* w, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspevd_work")]
            public static extern int SspevdWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, float* ap, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspevd_work")]
            public static extern int DspevdWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, double* ap, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspevx_work")]
            public static extern int SspevxWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* ap, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspevx_work")]
            public static extern int DspevxWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* ap, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspgst_work")]
            public static extern int SspgstWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte uplo, int n, float* ap, float* bp);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspgst_work")]
            public static extern int DspgstWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte uplo, int n, double* ap, double* bp);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspgv_work")]
            public static extern int SspgvWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* ap, float* bp, float* w, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspgv_work")]
            public static extern int DspgvWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* ap, double* bp, double* w, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspgvd_work")]
            public static extern int SspgvdWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* ap, float* bp, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspgvd_work")]
            public static extern int DspgvdWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* ap, double* bp, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspgvx_work")]
            public static extern int SspgvxWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, float* ap, float* bp, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspgvx_work")]
            public static extern int DspgvxWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, double* ap, double* bp, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssprfs_work")]
            public static extern int SsprfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* afp, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsprfs_work")]
            public static extern int DsprfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* afp, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csprfs_work")]
            public static extern int CsprfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsprfs_work")]
            public static extern int ZsprfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspsv_work")]
            public static extern int SspsvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* ap, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspsv_work")]
            public static extern int DspsvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* ap, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cspsv_work")]
            public static extern int CspsvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zspsv_work")]
            public static extern int ZspsvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sspsvx_work")]
            public static extern int SspsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* ap, float* afp, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dspsvx_work")]
            public static extern int DspsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* ap, double* afp, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cspsvx_work")]
            public static extern int CspsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zspsvx_work")]
            public static extern int ZspsvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr ap, IntPtr afp, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssptrd_work")]
            public static extern int SsptrdWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* ap, float* d, float* e, float* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsptrd_work")]
            public static extern int DsptrdWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* ap, double* d, double* e, double* tau);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssptrf_work")]
            public static extern int SsptrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsptrf_work")]
            public static extern int DsptrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csptrf_work")]
            public static extern int CsptrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsptrf_work")]
            public static extern int ZsptrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssptri_work")]
            public static extern int SsptriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* ap, int* ipiv, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsptri_work")]
            public static extern int DsptriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* ap, int* ipiv, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csptri_work")]
            public static extern int CsptriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsptri_work")]
            public static extern int ZsptriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, int* ipiv, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssptrs_work")]
            public static extern int SsptrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* ap, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsptrs_work")]
            public static extern int DsptrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* ap, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csptrs_work")]
            public static extern int CsptrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsptrs_work")]
            public static extern int ZsptrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr ap, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstebz_work")]
            public static extern int SstebzWork(sbyte range, sbyte order, int n, float vl, float vu, int il, int iu, float abstol, float* d, float* e, int* m, int* nsplit, float* w, int* iblock, int* isplit, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstebz_work")]
            public static extern int DstebzWork(sbyte range, sbyte order, int n, double vl, double vu, int il, int iu, double abstol, double* d, double* e, int* m, int* nsplit, double* w, int* iblock, int* isplit, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstedc_work")]
            public static extern int SstedcWork(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstedc_work")]
            public static extern int DstedcWork(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cstedc_work")]
            public static extern int CstedcWork(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zstedc_work")]
            public static extern int ZstedcWork(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstegr_work")]
            public static extern int SstegrWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstegr_work")]
            public static extern int DstegrWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cstegr_work")]
            public static extern int CstegrWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zstegr_work")]
            public static extern int ZstegrWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstein_work")]
            public static extern int SsteinWork(BLAS.MatrixLayout matrixLayout, int n, float* d, float* e, int m, float* w, int* iblock, int* isplit, float* z, int ldz, float* work, int* iwork, int* ifailv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstein_work")]
            public static extern int DsteinWork(BLAS.MatrixLayout matrixLayout, int n, double* d, double* e, int m, double* w, int* iblock, int* isplit, double* z, int ldz, double* work, int* iwork, int* ifailv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cstein_work")]
            public static extern int CsteinWork(BLAS.MatrixLayout matrixLayout, int n, float* d, float* e, int m, float* w, int* iblock, int* isplit, IntPtr z, int ldz, float* work, int* iwork, int* ifailv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zstein_work")]
            public static extern int ZsteinWork(BLAS.MatrixLayout matrixLayout, int n, double* d, double* e, int m, double* w, int* iblock, int* isplit, IntPtr z, int ldz, double* work, int* iwork, int* ifailv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstemr_work")]
            public static extern int SstemrWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* m, float* w, float* z, int ldz, int nzc, int* isuppz, int* tryrac, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstemr_work")]
            public static extern int DstemrWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* m, double* w, double* z, int ldz, int nzc, int* isuppz, int* tryrac, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cstemr_work")]
            public static extern int CstemrWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* m, float* w, IntPtr z, int ldz, int nzc, int* isuppz, int* tryrac, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zstemr_work")]
            public static extern int ZstemrWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* m, double* w, IntPtr z, int ldz, int nzc, int* isuppz, int* tryrac, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssteqr_work")]
            public static extern int SsteqrWork(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsteqr_work")]
            public static extern int DsteqrWork(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csteqr_work")]
            public static extern int CsteqrWork(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, float* d, float* e, IntPtr z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsteqr_work")]
            public static extern int ZsteqrWork(BLAS.MatrixLayout matrixLayout, sbyte compz, int n, double* d, double* e, IntPtr z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssterf_work")]
            public static extern int SsterfWork(int n, float* d, float* e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsterf_work")]
            public static extern int DsterfWork(int n, double* d, double* e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstev_work")]
            public static extern int SstevWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, int n, float* d, float* e, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstev_work")]
            public static extern int DstevWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, int n, double* d, double* e, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstevd_work")]
            public static extern int SstevdWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, int n, float* d, float* e, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstevd_work")]
            public static extern int DstevdWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, int n, double* d, double* e, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstevr_work")]
            public static extern int SstevrWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstevr_work")]
            public static extern int DstevrWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sstevx_work")]
            public static extern int SstevxWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dstevx_work")]
            public static extern int DstevxWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssycon_work")]
            public static extern int SsyconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsycon_work")]
            public static extern int DsyconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csycon_work")]
            public static extern int CsyconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, float anorm, float* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsycon_work")]
            public static extern int ZsyconWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, double anorm, double* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyequb_work")]
            public static extern int SsyequbWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, float* s, float* scond, float* amax, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyequb_work")]
            public static extern int DsyequbWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, double* s, double* scond, double* amax, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyequb_work")]
            public static extern int CsyequbWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, float* s, float* scond, float* amax, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyequb_work")]
            public static extern int ZsyequbWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, double* s, double* scond, double* amax, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyev_work")]
            public static extern int SsyevWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyev_work")]
            public static extern int DsyevWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevd_work")]
            public static extern int SsyevdWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevd_work")]
            public static extern int DsyevdWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevr_work")]
            public static extern int SsyevrWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevr_work")]
            public static extern int DsyevrWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevx_work")]
            public static extern int SsyevxWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevx_work")]
            public static extern int DsyevxWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssygst_work")]
            public static extern int SsygstWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte uplo, int n, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsygst_work")]
            public static extern int DsygstWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte uplo, int n, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssygv_work")]
            public static extern int SsygvWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsygv_work")]
            public static extern int DsygvWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssygvd_work")]
            public static extern int SsygvdWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsygvd_work")]
            public static extern int DsygvdWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssygvx_work")]
            public static extern int SsygvxWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsygvx_work")]
            public static extern int DsygvxWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyrfs_work")]
            public static extern int SsyrfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyrfs_work")]
            public static extern int DsyrfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyrfs_work")]
            public static extern int CsyrfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyrfs_work")]
            public static extern int ZsyrfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyrfsx_work")]
            public static extern int SsyrfsxWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyrfsx_work")]
            public static extern int DsyrfsxWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyrfsx_work")]
            public static extern int CsyrfsxWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyrfsx_work")]
            public static extern int ZsyrfsxWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysv_work")]
            public static extern int SsysvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysv_work")]
            public static extern int DsysvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysv_work")]
            public static extern int CsysvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysv_work")]
            public static extern int ZsysvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysvx_work")]
            public static extern int SsysvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysvx_work")]
            public static extern int DsysvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysvx_work")]
            public static extern int CsysvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* ferr, float* berr, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysvx_work")]
            public static extern int ZsysvxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* ferr, double* berr, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysvxx_work")]
            public static extern int SsysvxxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysvxx_work")]
            public static extern int DsysvxxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysvxx_work")]
            public static extern int CsysvxxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* s, IntPtr b, int ldb, IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysvxx_work")]
            public static extern int ZsysvxxWork(BLAS.MatrixLayout matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* s, IntPtr b, int ldb, IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrd_work")]
            public static extern int SsytrdWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, float* d, float* e, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrd_work")]
            public static extern int DsytrdWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, double* d, double* e, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrf_work")]
            public static extern int SsytrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrf_work")]
            public static extern int DsytrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrf_work")]
            public static extern int CsytrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrf_work")]
            public static extern int ZsytrfWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytri_work")]
            public static extern int SsytriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytri_work")]
            public static extern int DsytriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytri_work")]
            public static extern int CsytriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytri_work")]
            public static extern int ZsytriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs_work")]
            public static extern int SsytrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs_work")]
            public static extern int DsytrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs_work")]
            public static extern int CsytrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs_work")]
            public static extern int ZsytrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stbcon_work")]
            public static extern int StbconWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, float* ab, int ldab, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtbcon_work")]
            public static extern int DtbconWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, double* ab, int ldab, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctbcon_work")]
            public static extern int CtbconWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, IntPtr ab, int ldab, float* rcond, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztbcon_work")]
            public static extern int ZtbconWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, IntPtr ab, int ldab, double* rcond, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stbrfs_work")]
            public static extern int StbrfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtbrfs_work")]
            public static extern int DtbrfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctbrfs_work")]
            public static extern int CtbrfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztbrfs_work")]
            public static extern int ZtbrfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stbtrs_work")]
            public static extern int StbtrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtbtrs_work")]
            public static extern int DtbtrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctbtrs_work")]
            public static extern int CtbtrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztbtrs_work")]
            public static extern int ZtbtrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, IntPtr ab, int ldab, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stfsm_work")]
            public static extern int StfsmWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, float alpha, float* a, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtfsm_work")]
            public static extern int DtfsmWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, double alpha, double* a, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctfsm_work")]
            public static extern int CtfsmWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, ComplexFloat alpha, IntPtr a, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztfsm_work")]
            public static extern int ZtfsmWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, IntPtr alpha, IntPtr a, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stftri_work")]
            public static extern int StftriWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, float* a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtftri_work")]
            public static extern int DtftriWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, double* a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctftri_work")]
            public static extern int CtftriWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztftri_work")]
            public static extern int ZtftriWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, IntPtr a);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stfttp_work")]
            public static extern int StfttpWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, float* arf, float* ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtfttp_work")]
            public static extern int DtfttpWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, double* arf, double* ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctfttp_work")]
            public static extern int CtfttpWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr arf, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztfttp_work")]
            public static extern int ZtfttpWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr arf, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stfttr_work")]
            public static extern int StfttrWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, float* arf, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtfttr_work")]
            public static extern int DtfttrWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, double* arf, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctfttr_work")]
            public static extern int CtfttrWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr arf, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztfttr_work")]
            public static extern int ZtfttrWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr arf, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgevc_work")]
            public static extern int StgevcWork(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, float* s, int lds, float* p, int ldp, float* vl, int ldvl, float* vr, int ldvr, int mm, int* m, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgevc_work")]
            public static extern int DtgevcWork(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, double* s, int lds, double* p, int ldp, double* vl, int ldvl, double* vr, int ldvr, int mm, int* m, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgevc_work")]
            public static extern int CtgevcWork(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, IntPtr s, int lds, IntPtr p, int ldp, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgevc_work")]
            public static extern int ZtgevcWork(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, IntPtr s, int lds, IntPtr p, int ldp, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgexc_work")]
            public static extern int StgexcWork(BLAS.MatrixLayout matrixLayout, int wantq, int wantz, int n, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz, int* ifst, int* ilst, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgexc_work")]
            public static extern int DtgexcWork(BLAS.MatrixLayout matrixLayout, int wantq, int wantz, int n, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z, int ldz, int* ifst, int* ilst, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgexc_work")]
            public static extern int CtgexcWork(BLAS.MatrixLayout matrixLayout, int wantq, int wantz, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgexc_work")]
            public static extern int ZtgexcWork(BLAS.MatrixLayout matrixLayout, int wantq, int wantz, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr q, int ldq, IntPtr z, int ldz, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgsen_work")]
            public static extern int StgsenWork(BLAS.MatrixLayout matrixLayout, int ijob, int wantq, int wantz, int* select, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* q, int ldq, float* z, int ldz, int* m, float* pl, float* pr, float* dif, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgsen_work")]
            public static extern int DtgsenWork(BLAS.MatrixLayout matrixLayout, int ijob, int wantq, int wantz, int* select, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* q, int ldq, double* z, int ldz, int* m, double* pl, double* pr, double* dif, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgsen_work")]
            public static extern int CtgsenWork(BLAS.MatrixLayout matrixLayout, int ijob, int wantq, int wantz, int* select, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr q, int ldq, IntPtr z, int ldz, int* m, float* pl, float* pr, float* dif, IntPtr work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgsen_work")]
            public static extern int ZtgsenWork(BLAS.MatrixLayout matrixLayout, int ijob, int wantq, int wantz, int* select, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr alpha, IntPtr beta, IntPtr q, int ldq, IntPtr z, int ldz, int* m, double* pl, double* pr, double* dif, IntPtr work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgsja_work")]
            public static extern int StgsjaWork(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, float* a, int lda, float* b, int ldb, float tola, float tolb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, float* work, int* ncycle);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgsja_work")]
            public static extern int DtgsjaWork(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, double* a, int lda, double* b, int ldb, double tola, double tolb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, double* work, int* ncycle);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgsja_work")]
            public static extern int CtgsjaWork(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, IntPtr a, int lda, IntPtr b, int ldb, float tola, float tolb, float* alpha, float* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, IntPtr work, int* ncycle);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgsja_work")]
            public static extern int ZtgsjaWork(BLAS.MatrixLayout matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, IntPtr a, int lda, IntPtr b, int ldb, double tola, double tolb, double* alpha, double* beta, IntPtr u, int ldu, IntPtr v, int ldv, IntPtr q, int ldq, IntPtr work, int* ncycle);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgsna_work")]
            public static extern int StgsnaWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, float* a, int lda, float* b, int ldb, float* vl, int ldvl, float* vr, int ldvr, float* s, float* dif, int mm, int* m, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgsna_work")]
            public static extern int DtgsnaWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, double* a, int lda, double* b, int ldb, double* vl, int ldvl, double* vr, int ldvr, double* s, double* dif, int mm, int* m, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgsna_work")]
            public static extern int CtgsnaWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr vl, int ldvl, IntPtr vr, int ldvr, float* s, float* dif, int mm, int* m, IntPtr work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgsna_work")]
            public static extern int ZtgsnaWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr vl, int ldvl, IntPtr vr, int ldvr, double* s, double* dif, int mm, int* m, IntPtr work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stgsyl_work")]
            public static extern int StgsylWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, float* a, int lda, float* b, int ldb, float* c, int ldc, float* d, int ldd, float* e, int lde, float* f, int ldf, float* scale, float* dif, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtgsyl_work")]
            public static extern int DtgsylWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, double* a, int lda, double* b, int ldb, double* c, int ldc, double* d, int ldd, double* e, int lde, double* f, int ldf, double* scale, double* dif, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctgsyl_work")]
            public static extern int CtgsylWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, int ldc, IntPtr d, int ldd, IntPtr e, int lde, IntPtr f, int ldf, float* scale, float* dif, IntPtr work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztgsyl_work")]
            public static extern int ZtgsylWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, int ldc, IntPtr d, int ldd, IntPtr e, int lde, IntPtr f, int ldf, double* scale, double* dif, IntPtr work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpcon_work")]
            public static extern int StpconWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, float* ap, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpcon_work")]
            public static extern int DtpconWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, double* ap, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpcon_work")]
            public static extern int CtpconWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, IntPtr ap, float* rcond, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpcon_work")]
            public static extern int ZtpconWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, IntPtr ap, double* rcond, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stprfs_work")]
            public static extern int StprfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* ap, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtprfs_work")]
            public static extern int DtprfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* ap, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctprfs_work")]
            public static extern int CtprfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, IntPtr ap, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztprfs_work")]
            public static extern int ZtprfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, IntPtr ap, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stptri_work")]
            public static extern int StptriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte diag, int n, float* ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtptri_work")]
            public static extern int DtptriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte diag, int n, double* ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctptri_work")]
            public static extern int CtptriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte diag, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztptri_work")]
            public static extern int ZtptriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte diag, int n, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stptrs_work")]
            public static extern int StptrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtptrs_work")]
            public static extern int DtptrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctptrs_work")]
            public static extern int CtptrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztptrs_work")]
            public static extern int ZtptrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, IntPtr ap, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpttf_work")]
            public static extern int StpttfWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, float* ap, float* arf);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpttf_work")]
            public static extern int DtpttfWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, double* ap, double* arf);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpttf_work")]
            public static extern int CtpttfWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr ap, IntPtr arf);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpttf_work")]
            public static extern int ZtpttfWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr ap, IntPtr arf);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpttr_work")]
            public static extern int StpttrWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* ap, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpttr_work")]
            public static extern int DtpttrWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* ap, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpttr_work")]
            public static extern int CtpttrWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpttr_work")]
            public static extern int ZtpttrWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strcon_work")]
            public static extern int StrconWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, float* a, int lda, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrcon_work")]
            public static extern int DtrconWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, double* a, int lda, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrcon_work")]
            public static extern int CtrconWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, IntPtr a, int lda, float* rcond, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrcon_work")]
            public static extern int ZtrconWork(BLAS.MatrixLayout matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, IntPtr a, int lda, double* rcond, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strevc_work")]
            public static extern int StrevcWork(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, float* t, int ldt, float* vl, int ldvl, float* vr, int ldvr, int mm, int* m, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrevc_work")]
            public static extern int DtrevcWork(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, double* t, int ldt, double* vl, int ldvl, double* vr, int ldvr, int mm, int* m, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrevc_work")]
            public static extern int CtrevcWork(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, IntPtr t, int ldt, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrevc_work")]
            public static extern int ZtrevcWork(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte howmny, int* select, int n, IntPtr t, int ldt, IntPtr vl, int ldvl, IntPtr vr, int ldvr, int mm, int* m, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strexc_work")]
            public static extern int StrexcWork(BLAS.MatrixLayout matrixLayout, sbyte compq, int n, float* t, int ldt, float* q, int ldq, int* ifst, int* ilst, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrexc_work")]
            public static extern int DtrexcWork(BLAS.MatrixLayout matrixLayout, sbyte compq, int n, double* t, int ldt, double* q, int ldq, int* ifst, int* ilst, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrexc_work")]
            public static extern int CtrexcWork(BLAS.MatrixLayout matrixLayout, sbyte compq, int n, IntPtr t, int ldt, IntPtr q, int ldq, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrexc_work")]
            public static extern int ZtrexcWork(BLAS.MatrixLayout matrixLayout, sbyte compq, int n, IntPtr t, int ldt, IntPtr q, int ldq, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strrfs_work")]
            public static extern int StrrfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* a, int lda, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrrfs_work")]
            public static extern int DtrrfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* a, int lda, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrrfs_work")]
            public static extern int CtrrfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, IntPtr x, int ldx, float* ferr, float* berr, IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrrfs_work")]
            public static extern int ZtrrfsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, IntPtr x, int ldx, double* ferr, double* berr, IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strsen_work")]
            public static extern int StrsenWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compq, int* select, int n, float* t, int ldt, float* q, int ldq, float* wr, float* wi, int* m, float* s, float* sep, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrsen_work")]
            public static extern int DtrsenWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compq, int* select, int n, double* t, int ldt, double* q, int ldq, double* wr, double* wi, int* m, double* s, double* sep, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrsen_work")]
            public static extern int CtrsenWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compq, int* select, int n, IntPtr t, int ldt, IntPtr q, int ldq, IntPtr w, int* m, float* s, float* sep, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrsen_work")]
            public static extern int ZtrsenWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte compq, int* select, int n, IntPtr t, int ldt, IntPtr q, int ldq, IntPtr w, int* m, double* s, double* sep, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strsna_work")]
            public static extern int StrsnaWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, float* t, int ldt, float* vl, int ldvl, float* vr, int ldvr, float* s, float* sep, int mm, int* m, float* work, int ldwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrsna_work")]
            public static extern int DtrsnaWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, double* t, int ldt, double* vl, int ldvl, double* vr, int ldvr, double* s, double* sep, int mm, int* m, double* work, int ldwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrsna_work")]
            public static extern int CtrsnaWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, IntPtr t, int ldt, IntPtr vl, int ldvl, IntPtr vr, int ldvr, float* s, float* sep, int mm, int* m, IntPtr work, int ldwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrsna_work")]
            public static extern int ZtrsnaWork(BLAS.MatrixLayout matrixLayout, sbyte job, sbyte howmny, int* select, int n, IntPtr t, int ldt, IntPtr vl, int ldvl, IntPtr vr, int ldvr, double* s, double* sep, int mm, int* m, IntPtr work, int ldwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strsyl_work")]
            public static extern int StrsylWork(BLAS.MatrixLayout matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, float* a, int lda, float* b, int ldb, float* c, int ldc, float* scale);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrsyl_work")]
            public static extern int DtrsylWork(BLAS.MatrixLayout matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, double* a, int lda, double* b, int ldb, double* c, int ldc, double* scale);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrsyl_work")]
            public static extern int CtrsylWork(BLAS.MatrixLayout matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, int ldc, float* scale);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrsyl_work")]
            public static extern int ZtrsylWork(BLAS.MatrixLayout matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, IntPtr a, int lda, IntPtr b, int ldb, IntPtr c, int ldc, double* scale);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strtri_work")]
            public static extern int StrtriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte diag, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrtri_work")]
            public static extern int DtrtriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte diag, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrtri_work")]
            public static extern int CtrtriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte diag, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrtri_work")]
            public static extern int ZtrtriWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte diag, int n, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strtrs_work")]
            public static extern int StrtrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrtrs_work")]
            public static extern int DtrtrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrtrs_work")]
            public static extern int CtrtrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrtrs_work")]
            public static extern int ZtrtrsWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strttf_work")]
            public static extern int StrttfWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, float* a, int lda, float* arf);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrttf_work")]
            public static extern int DtrttfWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, double* a, int lda, double* arf);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrttf_work")]
            public static extern int CtrttfWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr a, int lda, IntPtr arf);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrttf_work")]
            public static extern int ZtrttfWork(BLAS.MatrixLayout matrixLayout, sbyte transr, sbyte uplo, int n, IntPtr a, int lda, IntPtr arf);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_strttp_work")]
            public static extern int StrttpWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, float* ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtrttp_work")]
            public static extern int DtrttpWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, double* ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctrttp_work")]
            public static extern int CtrttpWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztrttp_work")]
            public static extern int ZtrttpWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr ap);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stzrzf_work")]
            public static extern int StzrzfWork(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtzrzf_work")]
            public static extern int DtzrzfWork(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctzrzf_work")]
            public static extern int CtzrzfWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztzrzf_work")]
            public static extern int ZtzrzfWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cungbr_work")]
            public static extern int CungbrWork(BLAS.MatrixLayout matrixLayout, sbyte vect, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zungbr_work")]
            public static extern int ZungbrWork(BLAS.MatrixLayout matrixLayout, sbyte vect, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunghr_work")]
            public static extern int CunghrWork(BLAS.MatrixLayout matrixLayout, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunghr_work")]
            public static extern int ZunghrWork(BLAS.MatrixLayout matrixLayout, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunglq_work")]
            public static extern int CunglqWork(BLAS.MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunglq_work")]
            public static extern int ZunglqWork(BLAS.MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cungql_work")]
            public static extern int CungqlWork(BLAS.MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zungql_work")]
            public static extern int ZungqlWork(BLAS.MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cungqr_work")]
            public static extern int CungqrWork(BLAS.MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zungqr_work")]
            public static extern int ZungqrWork(BLAS.MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cungrq_work")]
            public static extern int CungrqWork(BLAS.MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zungrq_work")]
            public static extern int ZungrqWork(BLAS.MatrixLayout matrixLayout, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cungtr_work")]
            public static extern int CungtrWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zungtr_work")]
            public static extern int ZungtrWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr tau, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmbr_work")]
            public static extern int CunmbrWork(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmbr_work")]
            public static extern int ZunmbrWork(BLAS.MatrixLayout matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmhr_work")]
            public static extern int CunmhrWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmhr_work")]
            public static extern int ZunmhrWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmlq_work")]
            public static extern int CunmlqWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmlq_work")]
            public static extern int ZunmlqWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmql_work")]
            public static extern int CunmqlWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmql_work")]
            public static extern int ZunmqlWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmqr_work")]
            public static extern int CunmqrWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmqr_work")]
            public static extern int ZunmqrWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmrq_work")]
            public static extern int CunmrqWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmrq_work")]
            public static extern int ZunmrqWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmrz_work")]
            public static extern int CunmrzWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmrz_work")]
            public static extern int ZunmrzWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunmtr_work")]
            public static extern int CunmtrWork(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunmtr_work")]
            public static extern int ZunmtrWork(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, IntPtr a, int lda, IntPtr tau, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cupgtr_work")]
            public static extern int CupgtrWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, IntPtr tau, IntPtr q, int ldq, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zupgtr_work")]
            public static extern int ZupgtrWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr ap, IntPtr tau, IntPtr q, int ldq, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cupmtr_work")]
            public static extern int CupmtrWork(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, IntPtr ap, IntPtr tau, IntPtr c, int ldc, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zupmtr_work")]
            public static extern int ZupmtrWork(BLAS.MatrixLayout matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, IntPtr ap, IntPtr tau, IntPtr c, int ldc, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_claghe")]
            public static extern int Claghe(BLAS.MatrixLayout matrixLayout, int n, int k, float* d, IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlaghe")]
            public static extern int Zlaghe(BLAS.MatrixLayout matrixLayout, int n, int k, double* d, IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slagsy")]
            public static extern int Slagsy(BLAS.MatrixLayout matrixLayout, int n, int k, float* d, float* a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlagsy")]
            public static extern int Dlagsy(BLAS.MatrixLayout matrixLayout, int n, int k, double* d, double* a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clagsy")]
            public static extern int Clagsy(BLAS.MatrixLayout matrixLayout, int n, int k, float* d, IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlagsy")]
            public static extern int Zlagsy(BLAS.MatrixLayout matrixLayout, int n, int k, double* d, IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slapmr")]
            public static extern int Slapmr(BLAS.MatrixLayout matrixLayout, int forwrd, int m, int n, float* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlapmr")]
            public static extern int Dlapmr(BLAS.MatrixLayout matrixLayout, int forwrd, int m, int n, double* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clapmr")]
            public static extern int Clapmr(BLAS.MatrixLayout matrixLayout, int forwrd, int m, int n, IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlapmr")]
            public static extern int Zlapmr(BLAS.MatrixLayout matrixLayout, int forwrd, int m, int n, IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slapmt")]
            public static extern int Slapmt(BLAS.MatrixLayout matrixLayout, int forwrd, int m, int n, float* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlapmt")]
            public static extern int Dlapmt(BLAS.MatrixLayout matrixLayout, int forwrd, int m, int n, double* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_clapmt")]
            public static extern int Clapmt(BLAS.MatrixLayout matrixLayout, int forwrd, int m, int n, IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zlapmt")]
            public static extern int Zlapmt(BLAS.MatrixLayout matrixLayout, int forwrd, int m, int n, IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slapy2")]
            public static extern float Slapy2(float x, float y);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlapy2")]
            public static extern double Dlapy2(double x, double y);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slapy3")]
            public static extern float Slapy3(float x, float y, float z);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlapy3")]
            public static extern double Dlapy3(double x, double y, double z);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slartgp")]
            public static extern int Slartgp(float f, float g, float* cs, float* sn, float* r);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlartgp")]
            public static extern int Dlartgp(double f, double g, double* cs, double* sn, double* r);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_slartgs")]
            public static extern int Slartgs(float x, float y, float sigma, float* cs, float* sn);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dlartgs")]
            public static extern int Dlartgs(double x, double y, double sigma, double* cs, double* sn);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cbbcsd")]
            public static extern int Cbbcsd(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, float* theta, float* phi, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t, IntPtr v2t, int ldv2t, float* b11d, float* b11e, float* b12d, float* b12e, float* b21d, float* b21e, float* b22d, float* b22e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cbbcsd_work")]
            public static extern int CbbcsdWork(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, float* theta, float* phi, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t, IntPtr v2t, int ldv2t, float* b11d, float* b11e, float* b12d, float* b12e, float* b21d, float* b21e, float* b22d, float* b22e, float* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheswapr")]
            public static extern int Cheswapr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheswapr_work")]
            public static extern int CheswaprWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetri2")]
            public static extern int Chetri2(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetri2_work")]
            public static extern int Chetri2Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetri2x")]
            public static extern int Chetri2x(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetri2x_work")]
            public static extern int Chetri2xWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs2")]
            public static extern int Chetrs2(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs2_work")]
            public static extern int Chetrs2Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyconv")]
            public static extern int Csyconv(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte way, int n, IntPtr a, int lda, int* ipiv, IntPtr e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyconv_work")]
            public static extern int CsyconvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte way, int n, IntPtr a, int lda, int* ipiv, IntPtr e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyswapr")]
            public static extern int Csyswapr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyswapr_work")]
            public static extern int CsyswaprWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytri2")]
            public static extern int Csytri2(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytri2_work")]
            public static extern int Csytri2Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytri2x")]
            public static extern int Csytri2x(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytri2x_work")]
            public static extern int Csytri2xWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs2")]
            public static extern int Csytrs2(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs2_work")]
            public static extern int Csytrs2Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunbdb")]
            public static extern int Cunbdb(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x12, int ldx12, IntPtr x21, int ldx21, IntPtr x22, int ldx22, float* theta, float* phi, IntPtr taup1, IntPtr taup2, IntPtr tauq1, IntPtr tauq2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cunbdb_work")]
            public static extern int CunbdbWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x12, int ldx12, IntPtr x21, int ldx21, IntPtr x22, int ldx22, float* theta, float* phi, IntPtr taup1, IntPtr taup2, IntPtr tauq1, IntPtr tauq2, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cuncsd")]
            public static extern int Cuncsd(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x12, int ldx12, IntPtr x21, int ldx21, IntPtr x22, int ldx22, float* theta, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t, IntPtr v2t, int ldv2t);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cuncsd_work")]
            public static extern int CuncsdWork(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x12, int ldx12, IntPtr x21, int ldx21, IntPtr x22, int ldx22, float* theta, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t, IntPtr v2t, int ldv2t, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cuncsd2by1")]
            public static extern int Cuncsd2by1(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x21, int ldx21, float* theta, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cuncsd2by1_work")]
            public static extern int Cuncsd2by1Work(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x21, int ldx21, float* theta, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dbbcsd")]
            public static extern int Dbbcsd(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, double* theta, double* phi, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* v2t, int ldv2t, double* b11d, double* b11e, double* b12d, double* b12e, double* b21d, double* b21e, double* b22d, double* b22e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dbbcsd_work")]
            public static extern int DbbcsdWork(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, double* theta, double* phi, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* v2t, int ldv2t, double* b11d, double* b11e, double* b12d, double* b12e, double* b21d, double* b21e, double* b22d, double* b22e, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorbdb")]
            public static extern int Dorbdb(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, double* x11, int ldx11, double* x12, int ldx12, double* x21, int ldx21, double* x22, int ldx22, double* theta, double* phi, double* taup1, double* taup2, double* tauq1, double* tauq2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorbdb_work")]
            public static extern int DorbdbWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, double* x11, int ldx11, double* x12, int ldx12, double* x21, int ldx21, double* x22, int ldx22, double* theta, double* phi, double* taup1, double* taup2, double* tauq1, double* tauq2, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorcsd")]
            public static extern int Dorcsd(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q, double* x11, int ldx11, double* x12, int ldx12, double* x21, int ldx21, double* x22, int ldx22, double* theta, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* v2t, int ldv2t);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorcsd_work")]
            public static extern int DorcsdWork(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q, double* x11, int ldx11, double* x12, int ldx12, double* x21, int ldx21, double* x22, int ldx22, double* theta, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* v2t, int ldv2t, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorcsd2by1")]
            public static extern int Dorcsd2by1(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, double* x11, int ldx11, double* x21, int ldx21, double* theta, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dorcsd2by1_work")]
            public static extern int Dorcsd2by1Work(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, double* x11, int ldx11, double* x21, int ldx21, double* theta, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyconv")]
            public static extern int Dsyconv(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte way, int n, double* a, int lda, int* ipiv, double* e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyconv_work")]
            public static extern int DsyconvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte way, int n, double* a, int lda, int* ipiv, double* e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyswapr")]
            public static extern int Dsyswapr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyswapr_work")]
            public static extern int DsyswaprWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytri2")]
            public static extern int Dsytri2(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytri2_work")]
            public static extern int Dsytri2Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytri2x")]
            public static extern int Dsytri2x(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytri2x_work")]
            public static extern int Dsytri2xWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs2")]
            public static extern int Dsytrs2(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs2_work")]
            public static extern int Dsytrs2Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sbbcsd")]
            public static extern int Sbbcsd(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, float* theta, float* phi, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* v2t, int ldv2t, float* b11d, float* b11e, float* b12d, float* b12e, float* b21d, float* b21e, float* b22d, float* b22e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sbbcsd_work")]
            public static extern int SbbcsdWork(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, float* theta, float* phi, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* v2t, int ldv2t, float* b11d, float* b11e, float* b12d, float* b12e, float* b21d, float* b21e, float* b22d, float* b22e, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorbdb")]
            public static extern int Sorbdb(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, float* x11, int ldx11, float* x12, int ldx12, float* x21, int ldx21, float* x22, int ldx22, float* theta, float* phi, float* taup1, float* taup2, float* tauq1, float* tauq2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorbdb_work")]
            public static extern int SorbdbWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, float* x11, int ldx11, float* x12, int ldx12, float* x21, int ldx21, float* x22, int ldx22, float* theta, float* phi, float* taup1, float* taup2, float* tauq1, float* tauq2, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorcsd")]
            public static extern int Sorcsd(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q, float* x11, int ldx11, float* x12, int ldx12, float* x21, int ldx21, float* x22, int ldx22, float* theta, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* v2t, int ldv2t);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorcsd_work")]
            public static extern int SorcsdWork(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q, float* x11, int ldx11, float* x12, int ldx12, float* x21, int ldx21, float* x22, int ldx22, float* theta, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* v2t, int ldv2t, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorcsd2by1")]
            public static extern int Sorcsd2by1(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, float* x11, int ldx11, float* x21, int ldx21, float* theta, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sorcsd2by1_work")]
            public static extern int Sorcsd2by1Work(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, float* x11, int ldx11, float* x21, int ldx21, float* theta, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyconv")]
            public static extern int Ssyconv(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte way, int n, float* a, int lda, int* ipiv, float* e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyconv_work")]
            public static extern int SsyconvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte way, int n, float* a, int lda, int* ipiv, float* e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyswapr")]
            public static extern int Ssyswapr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyswapr_work")]
            public static extern int SsyswaprWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytri2")]
            public static extern int Ssytri2(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytri2_work")]
            public static extern int Ssytri2Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytri2x")]
            public static extern int Ssytri2x(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytri2x_work")]
            public static extern int Ssytri2xWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs2")]
            public static extern int Ssytrs2(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs2_work")]
            public static extern int Ssytrs2Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zbbcsd")]
            public static extern int Zbbcsd(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, double* theta, double* phi, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t, IntPtr v2t, int ldv2t, double* b11d, double* b11e, double* b12d, double* b12e, double* b21d, double* b21e, double* b22d, double* b22e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zbbcsd_work")]
            public static extern int ZbbcsdWork(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, double* theta, double* phi, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t, IntPtr v2t, int ldv2t, double* b11d, double* b11e, double* b12d, double* b12e, double* b21d, double* b21e, double* b22d, double* b22e, double* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheswapr")]
            public static extern int Zheswapr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheswapr_work")]
            public static extern int ZheswaprWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetri2")]
            public static extern int Zhetri2(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetri2_work")]
            public static extern int Zhetri2Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetri2x")]
            public static extern int Zhetri2x(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetri2x_work")]
            public static extern int Zhetri2xWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs2")]
            public static extern int Zhetrs2(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs2_work")]
            public static extern int Zhetrs2Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyconv")]
            public static extern int Zsyconv(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte way, int n, IntPtr a, int lda, int* ipiv, IntPtr e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyconv_work")]
            public static extern int ZsyconvWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, sbyte way, int n, IntPtr a, int lda, int* ipiv, IntPtr e);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyswapr")]
            public static extern int Zsyswapr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyswapr_work")]
            public static extern int ZsyswaprWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytri2")]
            public static extern int Zsytri2(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytri2_work")]
            public static extern int Zsytri2Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytri2x")]
            public static extern int Zsytri2x(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytri2x_work")]
            public static extern int Zsytri2xWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int nb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs2")]
            public static extern int Zsytrs2(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs2_work")]
            public static extern int Zsytrs2Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunbdb")]
            public static extern int Zunbdb(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x12, int ldx12, IntPtr x21, int ldx21, IntPtr x22, int ldx22, double* theta, double* phi, IntPtr taup1, IntPtr taup2, IntPtr tauq1, IntPtr tauq2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zunbdb_work")]
            public static extern int ZunbdbWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x12, int ldx12, IntPtr x21, int ldx21, IntPtr x22, int ldx22, double* theta, double* phi, IntPtr taup1, IntPtr taup2, IntPtr tauq1, IntPtr tauq2, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zuncsd")]
            public static extern int Zuncsd(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x12, int ldx12, IntPtr x21, int ldx21, IntPtr x22, int ldx22, double* theta, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t, IntPtr v2t, int ldv2t);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zuncsd_work")]
            public static extern int ZuncsdWork(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x12, int ldx12, IntPtr x21, int ldx21, IntPtr x22, int ldx22, double* theta, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t, IntPtr v2t, int ldv2t, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zuncsd2by1")]
            public static extern int Zuncsd2by1(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x21, int ldx21, double* theta, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zuncsd2by1_work")]
            public static extern int Zuncsd2by1Work(BLAS.MatrixLayout matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, IntPtr x11, int ldx11, IntPtr x21, int ldx21, double* theta, IntPtr u1, int ldu1, IntPtr u2, int ldu2, IntPtr v1t, int ldv1t, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgemqrt")]
            public static extern int Sgemqrt(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, float* v, int ldv, float* t, int ldt, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgemqrt")]
            public static extern int Dgemqrt(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, double* v, int ldv, double* t, int ldt, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgemqrt")]
            public static extern int Cgemqrt(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgemqrt")]
            public static extern int Zgemqrt(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqrt")]
            public static extern int Sgeqrt(BLAS.MatrixLayout matrixLayout, int m, int n, int nb, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqrt")]
            public static extern int Dgeqrt(BLAS.MatrixLayout matrixLayout, int m, int n, int nb, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqrt")]
            public static extern int Cgeqrt(BLAS.MatrixLayout matrixLayout, int m, int n, int nb, IntPtr a, int lda, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqrt")]
            public static extern int Zgeqrt(BLAS.MatrixLayout matrixLayout, int m, int n, int nb, IntPtr a, int lda, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqrt2")]
            public static extern int Sgeqrt2(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqrt2")]
            public static extern int Dgeqrt2(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqrt2")]
            public static extern int Cgeqrt2(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqrt2")]
            public static extern int Zgeqrt2(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqrt3")]
            public static extern int Sgeqrt3(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqrt3")]
            public static extern int Dgeqrt3(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqrt3")]
            public static extern int Cgeqrt3(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqrt3")]
            public static extern int Zgeqrt3(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpmqrt")]
            public static extern int Stpmqrt(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, float* v, int ldv, float* t, int ldt, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpmqrt")]
            public static extern int Dtpmqrt(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, double* v, int ldv, double* t, int ldt, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpmqrt")]
            public static extern int Ctpmqrt(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpmqrt")]
            public static extern int Ztpmqrt(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpqrt")]
            public static extern int Stpqrt(BLAS.MatrixLayout matrixLayout, int m, int n, int l, int nb, float* a, int lda, float* b, int ldb, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpqrt")]
            public static extern int Dtpqrt(BLAS.MatrixLayout matrixLayout, int m, int n, int l, int nb, double* a, int lda, double* b, int ldb, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpqrt")]
            public static extern int Ctpqrt(BLAS.MatrixLayout matrixLayout, int m, int n, int l, int nb, IntPtr a, int lda, IntPtr b, int ldb, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpqrt")]
            public static extern int Ztpqrt(BLAS.MatrixLayout matrixLayout, int m, int n, int l, int nb, IntPtr a, int lda, IntPtr b, int ldb, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpqrt2")]
            public static extern int Stpqrt2(BLAS.MatrixLayout matrixLayout, int m, int n, int l, float* a, int lda, float* b, int ldb, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpqrt2")]
            public static extern int Dtpqrt2(BLAS.MatrixLayout matrixLayout, int m, int n, int l, double* a, int lda, double* b, int ldb, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpqrt2")]
            public static extern int Ctpqrt2(BLAS.MatrixLayout matrixLayout, int m, int n, int l, IntPtr a, int lda, IntPtr b, int ldb, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpqrt2")]
            public static extern int Ztpqrt2(BLAS.MatrixLayout matrixLayout, int m, int n, int l, IntPtr a, int lda, IntPtr b, int ldb, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stprfb")]
            public static extern int Stprfb(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, float* v, int ldv, float* t, int ldt, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtprfb")]
            public static extern int Dtprfb(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, double* v, int ldv, double* t, int ldt, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctprfb")]
            public static extern int Ctprfb(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztprfb")]
            public static extern int Ztprfb(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgemqrt_work")]
            public static extern int SgemqrtWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, float* v, int ldv, float* t, int ldt, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgemqrt_work")]
            public static extern int DgemqrtWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, double* v, int ldv, double* t, int ldt, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgemqrt_work")]
            public static extern int CgemqrtWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr c, int ldc, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgemqrt_work")]
            public static extern int ZgemqrtWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr c, int ldc, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqrt_work")]
            public static extern int SgeqrtWork(BLAS.MatrixLayout matrixLayout, int m, int n, int nb, float* a, int lda, float* t, int ldt, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqrt_work")]
            public static extern int DgeqrtWork(BLAS.MatrixLayout matrixLayout, int m, int n, int nb, double* a, int lda, double* t, int ldt, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqrt_work")]
            public static extern int CgeqrtWork(BLAS.MatrixLayout matrixLayout, int m, int n, int nb, IntPtr a, int lda, IntPtr t, int ldt, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqrt_work")]
            public static extern int ZgeqrtWork(BLAS.MatrixLayout matrixLayout, int m, int n, int nb, IntPtr a, int lda, IntPtr t, int ldt, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqrt2_work")]
            public static extern int Sgeqrt2Work(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqrt2_work")]
            public static extern int Dgeqrt2Work(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqrt2_work")]
            public static extern int Cgeqrt2Work(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqrt2_work")]
            public static extern int Zgeqrt2Work(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqrt3_work")]
            public static extern int Sgeqrt3Work(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqrt3_work")]
            public static extern int Dgeqrt3Work(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqrt3_work")]
            public static extern int Cgeqrt3Work(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqrt3_work")]
            public static extern int Zgeqrt3Work(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpmqrt_work")]
            public static extern int StpmqrtWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, float* v, int ldv, float* t, int ldt, float* a, int lda, float* b, int ldb, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpmqrt_work")]
            public static extern int DtpmqrtWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, double* v, int ldv, double* t, int ldt, double* a, int lda, double* b, int ldb, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpmqrt_work")]
            public static extern int CtpmqrtWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr a, int lda, IntPtr b, int ldb, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpmqrt_work")]
            public static extern int ZtpmqrtWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr a, int lda, IntPtr b, int ldb, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpqrt_work")]
            public static extern int StpqrtWork(BLAS.MatrixLayout matrixLayout, int m, int n, int l, int nb, float* a, int lda, float* b, int ldb, float* t, int ldt, float* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpqrt_work")]
            public static extern int DtpqrtWork(BLAS.MatrixLayout matrixLayout, int m, int n, int l, int nb, double* a, int lda, double* b, int ldb, double* t, int ldt, double* work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpqrt_work")]
            public static extern int CtpqrtWork(BLAS.MatrixLayout matrixLayout, int m, int n, int l, int nb, IntPtr a, int lda, IntPtr b, int ldb, IntPtr t, int ldt, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpqrt_work")]
            public static extern int ZtpqrtWork(BLAS.MatrixLayout matrixLayout, int m, int n, int l, int nb, IntPtr a, int lda, IntPtr b, int ldb, IntPtr t, int ldt, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stpqrt2_work")]
            public static extern int Stpqrt2Work(BLAS.MatrixLayout matrixLayout, int m, int n, int l, float* a, int lda, float* b, int ldb, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtpqrt2_work")]
            public static extern int Dtpqrt2Work(BLAS.MatrixLayout matrixLayout, int m, int n, int l, double* a, int lda, double* b, int ldb, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctpqrt2_work")]
            public static extern int Ctpqrt2Work(BLAS.MatrixLayout matrixLayout, int m, int n, int l, IntPtr a, int lda, IntPtr b, int ldb, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztpqrt2_work")]
            public static extern int Ztpqrt2Work(BLAS.MatrixLayout matrixLayout, int m, int n, int l, IntPtr a, int lda, IntPtr b, int ldb, IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_stprfb_work")]
            public static extern int StprfbWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, float* v, int ldv, float* t, int ldt, float* a, int lda, float* b, int ldb, float* work, int ldwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dtprfb_work")]
            public static extern int DtprfbWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, double* v, int ldv, double* t, int ldt, double* a, int lda, double* b, int ldb, double* work, int ldwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ctprfb_work")]
            public static extern int CtprfbWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr a, int lda, IntPtr b, int ldb, IntPtr work, int ldwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ztprfb_work")]
            public static extern int ZtprfbWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, IntPtr v, int ldv, IntPtr t, int ldt, IntPtr a, int lda, IntPtr b, int ldb, IntPtr work, int ldwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysv_rook")]
            public static extern int SsysvRook(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysv_rook")]
            public static extern int DsysvRook(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysv_rook")]
            public static extern int CsysvRook(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysv_rook")]
            public static extern int ZsysvRook(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrf_rook")]
            public static extern int SsytrfRook(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrf_rook")]
            public static extern int DsytrfRook(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrf_rook")]
            public static extern int CsytrfRook(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrf_rook")]
            public static extern int ZsytrfRook(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs_rook")]
            public static extern int SsytrsRook(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs_rook")]
            public static extern int DsytrsRook(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs_rook")]
            public static extern int CsytrsRook(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs_rook")]
            public static extern int ZsytrsRook(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrf_rook")]
            public static extern int ChetrfRook(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrf_rook")]
            public static extern int ZhetrfRook(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs_rook")]
            public static extern int ChetrsRook(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs_rook")]
            public static extern int ZhetrsRook(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyr")]
            public static extern int Csyr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, ComplexFloat alpha, IntPtr x, int incx, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyr")]
            public static extern int Zsyr(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr alpha, IntPtr x, int incx, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysv_rook_work")]
            public static extern int SsysvRookWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysv_rook_work")]
            public static extern int DsysvRookWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysv_rook_work")]
            public static extern int CsysvRookWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysv_rook_work")]
            public static extern int ZsysvRookWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrf_rook_work")]
            public static extern int SsytrfRookWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrf_rook_work")]
            public static extern int DsytrfRookWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrf_rook_work")]
            public static extern int CsytrfRookWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrf_rook_work")]
            public static extern int ZsytrfRookWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs_rook_work")]
            public static extern int SsytrsRookWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs_rook_work")]
            public static extern int DsytrsRookWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs_rook_work")]
            public static extern int CsytrsRookWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs_rook_work")]
            public static extern int ZsytrsRookWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrf_rook_work")]
            public static extern int ChetrfRookWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrf_rook_work")]
            public static extern int ZhetrfRookWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs_rook_work")]
            public static extern int ChetrsRookWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs_rook_work")]
            public static extern int ZhetrsRookWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csyr_work")]
            public static extern int CsyrWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, ComplexFloat alpha, IntPtr x, int incx, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsyr_work")]
            public static extern int ZsyrWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr alpha, IntPtr x, int incx, IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ilaver")]
            public static extern void Ilaver(int* vers_major, int* vers_minor, int* vers_patch);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysv_aa")]
            public static extern int SsysvAa(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysv_aa_work")]
            public static extern int SsysvAaWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysv_aa")]
            public static extern int DsysvAa(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysv_aa_work")]
            public static extern int DsysvAaWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysv_aa")]
            public static extern int CsysvAa(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysv_aa_work")]
            public static extern int CsysvAaWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysv_aa")]
            public static extern int ZsysvAa(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysv_aa_work")]
            public static extern int ZsysvAaWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesv_aa")]
            public static extern int ChesvAa(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesv_aa_work")]
            public static extern int ChesvAaWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesv_aa")]
            public static extern int ZhesvAa(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesv_aa_work")]
            public static extern int ZhesvAaWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrf_aa")]
            public static extern int SsytrfAa(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrf_aa")]
            public static extern int DsytrfAa(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrf_aa")]
            public static extern int CsytrfAa(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrf_aa")]
            public static extern int ZsytrfAa(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrf_aa")]
            public static extern int ChetrfAa(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrf_aa")]
            public static extern int ZhetrfAa(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrf_aa_work")]
            public static extern int SsytrfAaWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrf_aa_work")]
            public static extern int DsytrfAaWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrf_aa_work")]
            public static extern int CsytrfAaWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrf_aa_work")]
            public static extern int ZsytrfAaWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrf_aa_work")]
            public static extern int ChetrfAaWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrf_aa_work")]
            public static extern int ZhetrfAaWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs_aa")]
            public static extern int CsytrsAa(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs_aa_work")]
            public static extern int CsytrsAaWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs_aa")]
            public static extern int ChetrsAa(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs_aa_work")]
            public static extern int ChetrsAaWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs_aa")]
            public static extern int DsytrsAa(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs_aa_work")]
            public static extern int DsytrsAaWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs_aa")]
            public static extern int SsytrsAa(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs_aa_work")]
            public static extern int SsytrsAaWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs_aa")]
            public static extern int ZsytrsAa(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs_aa_work")]
            public static extern int ZsytrsAaWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs_aa")]
            public static extern int ZhetrsAa(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs_aa_work")]
            public static extern int ZhetrsAaWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysv_rk")]
            public static extern int SsysvRk(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* e, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysv_rk_work")]
            public static extern int SsysvRkWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* e, int* ipiv, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysv_rk")]
            public static extern int DsysvRk(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* e, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysv_rk_work")]
            public static extern int DsysvRkWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* e, int* ipiv, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysv_rk")]
            public static extern int CsysvRk(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysv_rk_work")]
            public static extern int CsysvRkWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysv_rk")]
            public static extern int ZsysvRk(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysv_rk_work")]
            public static extern int ZsysvRkWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesv_rk")]
            public static extern int ChesvRk(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesv_rk_work")]
            public static extern int ChesvRkWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesv_rk")]
            public static extern int ZhesvRk(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesv_rk_work")]
            public static extern int ZhesvRkWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrf_rk")]
            public static extern int SsytrfRk(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrf_rk")]
            public static extern int DsytrfRk(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrf_rk")]
            public static extern int CsytrfRk(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrf_rk")]
            public static extern int ZsytrfRk(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrf_rk")]
            public static extern int ChetrfRk(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrf_rk")]
            public static extern int ZhetrfRk(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrf_rk_work")]
            public static extern int SsytrfRkWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrf_rk_work")]
            public static extern int DsytrfRkWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrf_rk_work")]
            public static extern int CsytrfRkWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrf_rk_work")]
            public static extern int ZsytrfRkWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrf_rk_work")]
            public static extern int ChetrfRkWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrf_rk_work")]
            public static extern int ZhetrfRkWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs_3")]
            public static extern int Csytrs3(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs_3_work")]
            public static extern int Csytrs3Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs_3")]
            public static extern int Chetrs3(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs_3_work")]
            public static extern int Chetrs3Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs_3")]
            public static extern int Dsytrs3(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* e, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs_3_work")]
            public static extern int Dsytrs3Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* e, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs_3")]
            public static extern int Ssytrs3(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* e, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs_3_work")]
            public static extern int Ssytrs3Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* e, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs_3")]
            public static extern int Zsytrs3(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs_3_work")]
            public static extern int Zsytrs3Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs_3")]
            public static extern int Zhetrs3(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs_3_work")]
            public static extern int Zhetrs3Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytri_3")]
            public static extern int Ssytri3(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytri_3")]
            public static extern int Dsytri3(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytri_3")]
            public static extern int Csytri3(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytri_3")]
            public static extern int Zsytri3(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetri_3")]
            public static extern int Chetri3(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetri_3")]
            public static extern int Zhetri3(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytri_3_work")]
            public static extern int Ssytri3Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytri_3_work")]
            public static extern int Dsytri3Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytri_3_work")]
            public static extern int Csytri3Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytri_3_work")]
            public static extern int Zsytri3Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetri_3_work")]
            public static extern int Chetri3Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetri_3_work")]
            public static extern int Zhetri3Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssycon_3")]
            public static extern int Ssycon3(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsycon_3")]
            public static extern int Dsycon3(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csycon_3")]
            public static extern int Csycon3(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsycon_3")]
            public static extern int Zsycon3(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_checon_3")]
            public static extern int Checon3(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhecon_3")]
            public static extern int Zhecon3(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssycon_3_work")]
            public static extern int Ssycon3Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsycon_3_work")]
            public static extern int Dsycon3Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csycon_3_work")]
            public static extern int Csycon3Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, float anorm, float* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsycon_3_work")]
            public static extern int Zsycon3Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, double anorm, double* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_checon_3_work")]
            public static extern int Checon3Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, float anorm, float* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhecon_3_work")]
            public static extern int Zhecon3Work(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr e, int* ipiv, double anorm, double* rcond, IntPtr work);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelq")]
            public static extern int Sgelq(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* t, int tsize);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelq")]
            public static extern int Dgelq(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* t, int tsize);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelq")]
            public static extern int Cgelq(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int tsize);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelq")]
            public static extern int Zgelq(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int tsize);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgelq_work")]
            public static extern int SgelqWork(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* t, int tsize, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgelq_work")]
            public static extern int DgelqWork(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* t, int tsize, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgelq_work")]
            public static extern int CgelqWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int tsize, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgelq_work")]
            public static extern int ZgelqWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int tsize, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgemlq")]
            public static extern int Sgemlq(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* t, int tsize, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgemlq")]
            public static extern int Dgemlq(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* t, int tsize, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgemlq")]
            public static extern int Cgemlq(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr t, int tsize, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgemlq")]
            public static extern int Zgemlq(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr t, int tsize, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgemlq_work")]
            public static extern int SgemlqWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* t, int tsize, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgemlq_work")]
            public static extern int DgemlqWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* t, int tsize, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgemlq_work")]
            public static extern int CgemlqWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr t, int tsize, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgemlq_work")]
            public static extern int ZgemlqWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr t, int tsize, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqr")]
            public static extern int Sgeqr(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* t, int tsize);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqr")]
            public static extern int Dgeqr(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* t, int tsize);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqr")]
            public static extern int Cgeqr(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int tsize);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqr")]
            public static extern int Zgeqr(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int tsize);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgeqr_work")]
            public static extern int SgeqrWork(BLAS.MatrixLayout matrixLayout, int m, int n, float* a, int lda, float* t, int tsize, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgeqr_work")]
            public static extern int DgeqrWork(BLAS.MatrixLayout matrixLayout, int m, int n, double* a, int lda, double* t, int tsize, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgeqr_work")]
            public static extern int CgeqrWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int tsize, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgeqr_work")]
            public static extern int ZgeqrWork(BLAS.MatrixLayout matrixLayout, int m, int n, IntPtr a, int lda, IntPtr t, int tsize, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgemqr")]
            public static extern int Sgemqr(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* t, int tsize, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgemqr")]
            public static extern int Dgemqr(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* t, int tsize, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgemqr")]
            public static extern int Cgemqr(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr t, int tsize, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgemqr")]
            public static extern int Zgemqr(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr t, int tsize, IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgemqr_work")]
            public static extern int SgemqrWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* t, int tsize, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgemqr_work")]
            public static extern int DgemqrWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* t, int tsize, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgemqr_work")]
            public static extern int CgemqrWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr t, int tsize, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgemqr_work")]
            public static extern int ZgemqrWork(BLAS.MatrixLayout matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, IntPtr a, int lda, IntPtr t, int tsize, IntPtr c, int ldc, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetsls")]
            public static extern int Sgetsls(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetsls")]
            public static extern int Dgetsls(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetsls")]
            public static extern int Cgetsls(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetsls")]
            public static extern int Zgetsls(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_sgetsls_work")]
            public static extern int SgetslsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dgetsls_work")]
            public static extern int DgetslsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cgetsls_work")]
            public static extern int CgetslsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zgetsls_work")]
            public static extern int ZgetslsWork(BLAS.MatrixLayout matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, IntPtr a, int lda, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyev_2stage")]
            public static extern int Ssyev2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyev_2stage")]
            public static extern int Dsyev2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevd_2stage")]
            public static extern int Ssyevd2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevd_2stage")]
            public static extern int Dsyevd2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevr_2stage")]
            public static extern int Ssyevr2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevr_2stage")]
            public static extern int Dsyevr2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevx_2stage")]
            public static extern int Ssyevx2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevx_2stage")]
            public static extern int Dsyevx2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyev_2stage_work")]
            public static extern int Ssyev2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyev_2stage_work")]
            public static extern int Dsyev2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevd_2stage_work")]
            public static extern int Ssyevd2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevd_2stage_work")]
            public static extern int Dsyevd2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevr_2stage_work")]
            public static extern int Ssyevr2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevr_2stage_work")]
            public static extern int Dsyevr2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssyevx_2stage_work")]
            public static extern int Ssyevx2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsyevx_2stage_work")]
            public static extern int Dsyevx2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheev_2stage")]
            public static extern int Cheev2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheev_2stage")]
            public static extern int Zheev2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevd_2stage")]
            public static extern int Cheevd2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevd_2stage")]
            public static extern int Zheevd2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevr_2stage")]
            public static extern int Cheevr2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevr_2stage")]
            public static extern int Zheevr2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevx_2stage")]
            public static extern int Cheevx2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevx_2stage")]
            public static extern int Zheevx2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheev_2stage_work")]
            public static extern int Cheev2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, float* w, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheev_2stage_work")]
            public static extern int Zheev2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, double* w, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevd_2stage_work")]
            public static extern int Cheevd2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, float* w, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevd_2stage_work")]
            public static extern int Zheevd2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, double* w, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevr_2stage_work")]
            public static extern int Cheevr2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* isuppz, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevr_2stage_work")]
            public static extern int Zheevr2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* isuppz, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_cheevx_2stage_work")]
            public static extern int Cheevx2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zheevx_2stage_work")]
            public static extern int Zheevx2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbev_2stage")]
            public static extern int Ssbev2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbev_2stage")]
            public static extern int Dsbev2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbevd_2stage")]
            public static extern int Ssbevd2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbevd_2stage")]
            public static extern int Dsbevd2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbevx_2stage")]
            public static extern int Ssbevx2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, float* ab, int ldab, float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbevx_2stage")]
            public static extern int Dsbevx2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, double* ab, int ldab, double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbev_2stage_work")]
            public static extern int Ssbev2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbev_2stage_work")]
            public static extern int Dsbev2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbevd_2stage_work")]
            public static extern int Ssbevd2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbevd_2stage_work")]
            public static extern int Dsbevd2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssbevx_2stage_work")]
            public static extern int Ssbevx2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, float* ab, int ldab, float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsbevx_2stage_work")]
            public static extern int Dsbevx2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, double* ab, int ldab, double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbev_2stage")]
            public static extern int Chbev2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, IntPtr ab, int ldab, float* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbev_2stage")]
            public static extern int Zhbev2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, IntPtr ab, int ldab, double* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbevd_2stage")]
            public static extern int Chbevd2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, IntPtr ab, int ldab, float* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbevd_2stage")]
            public static extern int Zhbevd2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, IntPtr ab, int ldab, double* w, IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbevx_2stage")]
            public static extern int Chbevx2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, IntPtr ab, int ldab, IntPtr q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbevx_2stage")]
            public static extern int Zhbevx2stage(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, IntPtr ab, int ldab, IntPtr q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbev_2stage_work")]
            public static extern int Chbev2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, IntPtr ab, int ldab, float* w, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbev_2stage_work")]
            public static extern int Zhbev2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, IntPtr ab, int ldab, double* w, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbevd_2stage_work")]
            public static extern int Chbevd2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, IntPtr ab, int ldab, float* w, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbevd_2stage_work")]
            public static extern int Zhbevd2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, IntPtr ab, int ldab, double* w, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chbevx_2stage_work")]
            public static extern int Chbevx2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, IntPtr ab, int ldab, IntPtr q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, IntPtr z, int ldz, IntPtr work, int lwork, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhbevx_2stage_work")]
            public static extern int Zhbevx2stageWork(BLAS.MatrixLayout matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, IntPtr ab, int ldab, IntPtr q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, IntPtr z, int ldz, IntPtr work, int lwork, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssygv_2stage")]
            public static extern int Ssygv2stage(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsygv_2stage")]
            public static extern int Dsygv2stage(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssygv_2stage_work")]
            public static extern int Ssygv2stageWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsygv_2stage_work")]
            public static extern int Dsygv2stageWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chegv_2stage")]
            public static extern int Chegv2stage(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhegv_2stage")]
            public static extern int Zhegv2stage(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chegv_2stage_work")]
            public static extern int Chegv2stageWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, float* w, IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhegv_2stage_work")]
            public static extern int Zhegv2stageWork(BLAS.MatrixLayout matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, IntPtr a, int lda, IntPtr b, int ldb, double* w, IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysv_aa_2stage")]
            public static extern int SsysvAa2stage(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssysv_aa_2stage_work")]
            public static extern int SsysvAa2stageWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysv_aa_2stage")]
            public static extern int DsysvAa2stage(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsysv_aa_2stage_work")]
            public static extern int DsysvAa2stageWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysv_aa_2stage")]
            public static extern int CsysvAa2stage(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csysv_aa_2stage_work")]
            public static extern int CsysvAa2stageWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysv_aa_2stage")]
            public static extern int ZsysvAa2stage(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsysv_aa_2stage_work")]
            public static extern int ZsysvAa2stageWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesv_aa_2stage")]
            public static extern int ChesvAa2stage(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chesv_aa_2stage_work")]
            public static extern int ChesvAa2stageWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesv_aa_2stage")]
            public static extern int ZhesvAa2stage(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhesv_aa_2stage_work")]
            public static extern int ZhesvAa2stageWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrf_aa_2stage")]
            public static extern int SsytrfAa2stage(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrf_aa_2stage_work")]
            public static extern int SsytrfAa2stageWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrf_aa_2stage")]
            public static extern int DsytrfAa2stage(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrf_aa_2stage_work")]
            public static extern int DsytrfAa2stageWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrf_aa_2stage")]
            public static extern int CsytrfAa2stage(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrf_aa_2stage_work")]
            public static extern int CsytrfAa2stageWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrf_aa_2stage")]
            public static extern int ZsytrfAa2stage(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrf_aa_2stage_work")]
            public static extern int ZsytrfAa2stageWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrf_aa_2stage")]
            public static extern int ChetrfAa2stage(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrf_aa_2stage_work")]
            public static extern int ChetrfAa2stageWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrf_aa_2stage")]
            public static extern int ZhetrfAa2stage(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrf_aa_2stage_work")]
            public static extern int ZhetrfAa2stageWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs_aa_2stage")]
            public static extern int SsytrsAa2stage(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_ssytrs_aa_2stage_work")]
            public static extern int SsytrsAa2stageWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs_aa_2stage")]
            public static extern int DsytrsAa2stage(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_dsytrs_aa_2stage_work")]
            public static extern int DsytrsAa2stageWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs_aa_2stage")]
            public static extern int CsytrsAa2stage(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_csytrs_aa_2stage_work")]
            public static extern int CsytrsAa2stageWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs_aa_2stage")]
            public static extern int ZsytrsAa2stage(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zsytrs_aa_2stage_work")]
            public static extern int ZsytrsAa2stageWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs_aa_2stage")]
            public static extern int ChetrsAa2stage(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_chetrs_aa_2stage_work")]
            public static extern int ChetrsAa2stageWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs_aa_2stage")]
            public static extern int ZhetrsAa2stage(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_zhetrs_aa_2stage_work")]
            public static extern int ZhetrsAa2stageWork(BLAS.MatrixLayout matrixLayout, sbyte uplo, int n, int nrhs, IntPtr a, int lda, IntPtr tb, int ltb, int* ipiv, int* ipiv2, IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_set_nancheck")]
            public static extern void SetNancheck(int flag);

            [SuppressUnmanagedCodeSecurity, DllImport("openblas", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LAPACKE_get_nancheck")]
            public static extern int GetNancheck();
        }
    }
}