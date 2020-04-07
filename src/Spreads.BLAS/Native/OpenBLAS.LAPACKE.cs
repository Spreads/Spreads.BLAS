using System.Runtime.InteropServices;
using System.Security;

namespace Spreads.Native
{
    public static unsafe partial class OpenBLAS
    {
        public static class LAPACKE
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sbdsdc")]
            internal static extern int LAPACKE_sbdsdc(int matrix_layout, sbyte uplo, sbyte compq, int n, float* d, float* e, float* u, int ldu, float* vt, int ldvt, float* q,
                int* iq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dbdsdc")]
            internal static extern int LAPACKE_dbdsdc(int matrix_layout, sbyte uplo, sbyte compq, int n, double* d, double* e, double* u, int ldu, double* vt, int ldvt, double* q,
                int* iq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sbdsqr")]
            internal static extern int LAPACKE_sbdsqr(int matrix_layout, sbyte uplo, int n, int ncvt, int nru, int ncc, float* d, float* e, float* vt, int ldvt, float* u, int ldu,
                float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dbdsqr")]
            internal static extern int LAPACKE_dbdsqr(int matrix_layout, sbyte uplo, int n, int ncvt, int nru, int ncc, double* d, double* e, double* vt, int ldvt, double* u,
                int ldu, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sbdsvdx")]
            internal static extern int LAPACKE_sbdsvdx(int matrix_layout, sbyte uplo, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu,
                int* ns, float* s, float* z, int ldz, int* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dbdsvdx")]
            internal static extern int LAPACKE_dbdsvdx(int matrix_layout, sbyte uplo, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu,
                int* ns, double* s, double* z, int ldz, int* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sdisna")]
            internal static extern int LAPACKE_sdisna(sbyte job, int m, int n, float* d, float* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ddisna")]
            internal static extern int LAPACKE_ddisna(sbyte job, int m, int n, double* d, double* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbbrd")]
            internal static extern int LAPACKE_sgbbrd(int matrix_layout, sbyte vect, int m, int n, int ncc, int kl, int ku, float* ab, int ldab, float* d, float* e, float* q,
                int ldq, float* pt, int ldpt, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbbrd")]
            internal static extern int LAPACKE_dgbbrd(int matrix_layout, sbyte vect, int m, int n, int ncc, int kl, int ku, double* ab, int ldab, double* d, double* e, double* q,
                int ldq, double* pt, int ldpt, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbcon")]
            internal static extern int LAPACKE_sgbcon(int matrix_layout, sbyte norm, int n, int kl, int ku, float* ab, int ldab, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbcon")]
            internal static extern int LAPACKE_dgbcon(int matrix_layout, sbyte norm, int n, int kl, int ku, double* ab, int ldab, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbequ")]
            internal static extern int LAPACKE_sgbequ(int matrix_layout, int m, int n, int kl, int ku, float* ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd,
                float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbequ")]
            internal static extern int LAPACKE_dgbequ(int matrix_layout, int m, int n, int kl, int ku, double* ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd,
                double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbequb")]
            internal static extern int LAPACKE_sgbequb(int matrix_layout, int m, int n, int kl, int ku, float* ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd,
                float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbequb")]
            internal static extern int LAPACKE_dgbequb(int matrix_layout, int m, int n, int kl, int ku, double* ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd,
                double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbrfs")]
            internal static extern int LAPACKE_sgbrfs(int matrix_layout, sbyte trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv,
                float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbrfs")]
            internal static extern int LAPACKE_dgbrfs(int matrix_layout, sbyte trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv,
                double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbrfsx")]
            internal static extern int LAPACKE_sgbrfsx(int matrix_layout, sbyte trans, sbyte equed, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb,
                int* ipiv, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp,
                int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbrfsx")]
            internal static extern int LAPACKE_dgbrfsx(int matrix_layout, sbyte trans, sbyte equed, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb,
                int* ipiv, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp,
                int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbsv")]
            internal static extern int LAPACKE_sgbsv(int matrix_layout, int n, int kl, int ku, int nrhs, float* ab, int ldab, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbsv")]
            internal static extern int LAPACKE_dgbsv(int matrix_layout, int n, int kl, int ku, int nrhs, double* ab, int ldab, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbsvx")]
            internal static extern int LAPACKE_sgbsvx(int matrix_layout, sbyte fact, sbyte trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb,
                int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* rpivot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbsvx")]
            internal static extern int LAPACKE_dgbsvx(int matrix_layout, sbyte fact, sbyte trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb,
                int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* rpivot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbsvxx")]
            internal static extern int LAPACKE_sgbsvxx(int matrix_layout, sbyte fact, sbyte trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb,
                int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm,
                float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbsvxx")]
            internal static extern int LAPACKE_dgbsvxx(int matrix_layout, sbyte fact, sbyte trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb,
                int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds,
                double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbtrf")]
            internal static extern int LAPACKE_sgbtrf(int matrix_layout, int m, int n, int kl, int ku, float* ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbtrf")]
            internal static extern int LAPACKE_dgbtrf(int matrix_layout, int m, int n, int kl, int ku, double* ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbtrs")]
            internal static extern int LAPACKE_sgbtrs(int matrix_layout, sbyte trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbtrs")]
            internal static extern int LAPACKE_dgbtrs(int matrix_layout, sbyte trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgebak")]
            internal static extern int LAPACKE_sgebak(int matrix_layout, sbyte job, sbyte side, int n, int ilo, int ihi, float* scale, int m, float* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgebak")]
            internal static extern int LAPACKE_dgebak(int matrix_layout, sbyte job, sbyte side, int n, int ilo, int ihi, double* scale, int m, double* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgebal")]
            internal static extern int LAPACKE_sgebal(int matrix_layout, sbyte job, int n, float* a, int lda, int* ilo, int* ihi, float* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgebal")]
            internal static extern int LAPACKE_dgebal(int matrix_layout, sbyte job, int n, double* a, int lda, int* ilo, int* ihi, double* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgebrd")]
            internal static extern int LAPACKE_sgebrd(int matrix_layout, int m, int n, float* a, int lda, float* d, float* e, float* tauq, float* taup);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgebrd")]
            internal static extern int LAPACKE_dgebrd(int matrix_layout, int m, int n, double* a, int lda, double* d, double* e, double* tauq, double* taup);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgecon")]
            internal static extern int LAPACKE_sgecon(int matrix_layout, sbyte norm, int n, float* a, int lda, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgecon")]
            internal static extern int LAPACKE_dgecon(int matrix_layout, sbyte norm, int n, double* a, int lda, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeequ")]
            internal static extern int LAPACKE_sgeequ(int matrix_layout, int m, int n, float* a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeequ")]
            internal static extern int LAPACKE_dgeequ(int matrix_layout, int m, int n, double* a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeequb")]
            internal static extern int LAPACKE_sgeequb(int matrix_layout, int m, int n, float* a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeequb")]
            internal static extern int LAPACKE_dgeequb(int matrix_layout, int m, int n, double* a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgees")]
            internal static extern int LAPACKE_sgees(int matrix_layout, sbyte jobvs, sbyte sort, global::System.IntPtr select, int n, float* a, int lda, int* sdim, float* wr,
                float* wi, float* vs, int ldvs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgees")]
            internal static extern int LAPACKE_dgees(int matrix_layout, sbyte jobvs, sbyte sort, global::System.IntPtr select, int n, double* a, int lda, int* sdim, double* wr,
                double* wi, double* vs, int ldvs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeesx")]
            internal static extern int LAPACKE_sgeesx(int matrix_layout, sbyte jobvs, sbyte sort, global::System.IntPtr select, sbyte sense, int n, float* a, int lda, int* sdim,
                float* wr, float* wi, float* vs, int ldvs, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeesx")]
            internal static extern int LAPACKE_dgeesx(int matrix_layout, sbyte jobvs, sbyte sort, global::System.IntPtr select, sbyte sense, int n, double* a, int lda, int* sdim,
                double* wr, double* wi, double* vs, int ldvs, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeev")]
            internal static extern int LAPACKE_sgeev(int matrix_layout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* wr, float* wi, float* vl, int ldvl, float* vr,
                int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeev")]
            internal static extern int LAPACKE_dgeev(int matrix_layout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* wr, double* wi, double* vl, int ldvl,
                double* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeevx")]
            internal static extern int LAPACKE_sgeevx(int matrix_layout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, float* a, int lda, float* wr, float* wi,
                float* vl, int ldvl, float* vr, int ldvr, int* ilo, int* ihi, float* scale, float* abnrm, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeevx")]
            internal static extern int LAPACKE_dgeevx(int matrix_layout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, double* a, int lda, double* wr, double* wi,
                double* vl, int ldvl, double* vr, int ldvr, int* ilo, int* ihi, double* scale, double* abnrm, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgehrd")]
            internal static extern int LAPACKE_sgehrd(int matrix_layout, int n, int ilo, int ihi, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgehrd")]
            internal static extern int LAPACKE_dgehrd(int matrix_layout, int n, int ilo, int ihi, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgejsv")]
            internal static extern int LAPACKE_sgejsv(int matrix_layout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, float* a, int lda,
                float* sva, float* u, int ldu, float* v, int ldv, float* stat, int* istat);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgejsv")]
            internal static extern int LAPACKE_dgejsv(int matrix_layout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, double* a, int lda,
                double* sva, double* u, int ldu, double* v, int ldv, double* stat, int* istat);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelq2")]
            internal static extern int LAPACKE_sgelq2(int matrix_layout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelq2")]
            internal static extern int LAPACKE_dgelq2(int matrix_layout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelqf")]
            internal static extern int LAPACKE_sgelqf(int matrix_layout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelqf")]
            internal static extern int LAPACKE_dgelqf(int matrix_layout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgels")]
            internal static extern int LAPACKE_sgels(int matrix_layout, sbyte trans, int m, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgels")]
            internal static extern int LAPACKE_dgels(int matrix_layout, sbyte trans, int m, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelsd")]
            internal static extern int LAPACKE_sgelsd(int matrix_layout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* s, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelsd")]
            internal static extern int LAPACKE_dgelsd(int matrix_layout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* s, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelss")]
            internal static extern int LAPACKE_sgelss(int matrix_layout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* s, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelss")]
            internal static extern int LAPACKE_dgelss(int matrix_layout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* s, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelsy")]
            internal static extern int LAPACKE_sgelsy(int matrix_layout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, int* jpvt, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelsy")]
            internal static extern int LAPACKE_dgelsy(int matrix_layout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, int* jpvt, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqlf")]
            internal static extern int LAPACKE_sgeqlf(int matrix_layout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqlf")]
            internal static extern int LAPACKE_dgeqlf(int matrix_layout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqp3")]
            internal static extern int LAPACKE_sgeqp3(int matrix_layout, int m, int n, float* a, int lda, int* jpvt, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqp3")]
            internal static extern int LAPACKE_dgeqp3(int matrix_layout, int m, int n, double* a, int lda, int* jpvt, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqpf")]
            internal static extern int LAPACKE_sgeqpf(int matrix_layout, int m, int n, float* a, int lda, int* jpvt, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqpf")]
            internal static extern int LAPACKE_dgeqpf(int matrix_layout, int m, int n, double* a, int lda, int* jpvt, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqr2")]
            internal static extern int LAPACKE_sgeqr2(int matrix_layout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqr2")]
            internal static extern int LAPACKE_dgeqr2(int matrix_layout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqrf")]
            internal static extern int LAPACKE_sgeqrf(int matrix_layout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqrf")]
            internal static extern int LAPACKE_dgeqrf(int matrix_layout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqrfp")]
            internal static extern int LAPACKE_sgeqrfp(int matrix_layout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqrfp")]
            internal static extern int LAPACKE_dgeqrfp(int matrix_layout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgerfs")]
            internal static extern int LAPACKE_sgerfs(int matrix_layout, sbyte trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb,
                float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgerfs")]
            internal static extern int LAPACKE_dgerfs(int matrix_layout, sbyte trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb,
                double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgerfsx")]
            internal static extern int LAPACKE_sgerfsx(int matrix_layout, sbyte trans, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* r,
                float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgerfsx")]
            internal static extern int LAPACKE_dgerfsx(int matrix_layout, sbyte trans, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* r,
                double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams,
                double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgerqf")]
            internal static extern int LAPACKE_sgerqf(int matrix_layout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgerqf")]
            internal static extern int LAPACKE_dgerqf(int matrix_layout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesdd")]
            internal static extern int LAPACKE_sgesdd(int matrix_layout, sbyte jobz, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* vt, int ldvt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesdd")]
            internal static extern int LAPACKE_dgesdd(int matrix_layout, sbyte jobz, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* vt, int ldvt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesv")]
            internal static extern int LAPACKE_sgesv(int matrix_layout, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesv")]
            internal static extern int LAPACKE_dgesv(int matrix_layout, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsgesv")]
            internal static extern int LAPACKE_dsgesv(int matrix_layout, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* x, int ldx, int* iter);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvd")]
            internal static extern int LAPACKE_sgesvd(int matrix_layout, sbyte jobu, sbyte jobvt, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* vt, int ldvt,
                float* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvd")]
            internal static extern int LAPACKE_dgesvd(int matrix_layout, sbyte jobu, sbyte jobvt, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* vt,
                int ldvt, double* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvdx")]
            internal static extern int LAPACKE_sgesvdx(int matrix_layout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, float* a, int lda, float vl, float vu, int il, int iu,
                int* ns, float* s, float* u, int ldu, float* vt, int ldvt, int* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvdx")]
            internal static extern int LAPACKE_dgesvdx(int matrix_layout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, double* a, int lda, double vl, double vu, int il,
                int iu, int* ns, double* s, double* u, int ldu, double* vt, int ldvt, int* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvdq")]
            internal static extern int LAPACKE_sgesvdq(int matrix_layout, sbyte joba, sbyte jobp, sbyte jobr, sbyte jobu, sbyte jobv, int m, int n, float* a, int lda, float* s,
                float* u, int ldu, float* v, int ldv, int* numrank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvdq")]
            internal static extern int LAPACKE_dgesvdq(int matrix_layout, sbyte joba, sbyte jobp, sbyte jobr, sbyte jobu, sbyte jobv, int m, int n, double* a, int lda, double* s,
                double* u, int ldu, double* v, int ldv, int* numrank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvj")]
            internal static extern int LAPACKE_sgesvj(int matrix_layout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, float* a, int lda, float* sva, int mv, float* v, int ldv,
                float* stat);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvj")]
            internal static extern int LAPACKE_dgesvj(int matrix_layout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, double* a, int lda, double* sva, int mv, double* v,
                int ldv, double* stat);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvx")]
            internal static extern int LAPACKE_sgesvx(int matrix_layout, sbyte fact, sbyte trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed,
                float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* rpivot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvx")]
            internal static extern int LAPACKE_dgesvx(int matrix_layout, sbyte fact, sbyte trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv,
                sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* rpivot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvxx")]
            internal static extern int LAPACKE_sgesvxx(int matrix_layout, sbyte fact, sbyte trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed,
                float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp,
                int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvxx")]
            internal static extern int LAPACKE_dgesvxx(int matrix_layout, sbyte fact, sbyte trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv,
                sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm,
                double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetf2")]
            internal static extern int LAPACKE_sgetf2(int matrix_layout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetf2")]
            internal static extern int LAPACKE_dgetf2(int matrix_layout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetrf")]
            internal static extern int LAPACKE_sgetrf(int matrix_layout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetrf")]
            internal static extern int LAPACKE_dgetrf(int matrix_layout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetrf2")]
            internal static extern int LAPACKE_sgetrf2(int matrix_layout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetrf2")]
            internal static extern int LAPACKE_dgetrf2(int matrix_layout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetri")]
            internal static extern int LAPACKE_sgetri(int matrix_layout, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetri")]
            internal static extern int LAPACKE_dgetri(int matrix_layout, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetrs")]
            internal static extern int LAPACKE_sgetrs(int matrix_layout, sbyte trans, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetrs")]
            internal static extern int LAPACKE_dgetrs(int matrix_layout, sbyte trans, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggbak")]
            internal static extern int LAPACKE_sggbak(int matrix_layout, sbyte job, sbyte side, int n, int ilo, int ihi, float* lscale, float* rscale, int m, float* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggbak")]
            internal static extern int LAPACKE_dggbak(int matrix_layout, sbyte job, sbyte side, int n, int ilo, int ihi, double* lscale, double* rscale, int m, double* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggbal")]
            internal static extern int LAPACKE_sggbal(int matrix_layout, sbyte job, int n, float* a, int lda, float* b, int ldb, int* ilo, int* ihi, float* lscale, float* rscale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggbal")]
            internal static extern int LAPACKE_dggbal(int matrix_layout, sbyte job, int n, double* a, int lda, double* b, int ldb, int* ilo, int* ihi, double* lscale,
                double* rscale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgges")]
            internal static extern int LAPACKE_sgges(int matrix_layout, sbyte jobvsl, sbyte jobvsr, sbyte sort, global::System.IntPtr selctg, int n, float* a, int lda, float* b,
                int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgges")]
            internal static extern int LAPACKE_dgges(int matrix_layout, sbyte jobvsl, sbyte jobvsr, sbyte sort, global::System.IntPtr selctg, int n, double* a, int lda, double* b,
                int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgges3")]
            internal static extern int LAPACKE_sgges3(int matrix_layout, sbyte jobvsl, sbyte jobvsr, sbyte sort, global::System.IntPtr selctg, int n, float* a, int lda, float* b,
                int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgges3")]
            internal static extern int LAPACKE_dgges3(int matrix_layout, sbyte jobvsl, sbyte jobvsr, sbyte sort, global::System.IntPtr selctg, int n, double* a, int lda, double* b,
                int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggesx")]
            internal static extern int LAPACKE_sggesx(int matrix_layout, sbyte jobvsl, sbyte jobvsr, sbyte sort, global::System.IntPtr selctg, sbyte sense, int n, float* a,
                int lda, float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggesx")]
            internal static extern int LAPACKE_dggesx(int matrix_layout, sbyte jobvsl, sbyte jobvsr, sbyte sort, global::System.IntPtr selctg, sbyte sense, int n, double* a,
                int lda, double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr, double* rconde,
                double* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggev")]
            internal static extern int LAPACKE_sggev(int matrix_layout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai,
                float* beta, float* vl, int ldvl, float* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggev")]
            internal static extern int LAPACKE_dggev(int matrix_layout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai,
                double* beta, double* vl, int ldvl, double* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggev3")]
            internal static extern int LAPACKE_sggev3(int matrix_layout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai,
                float* beta, float* vl, int ldvl, float* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggev3")]
            internal static extern int LAPACKE_dggev3(int matrix_layout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai,
                double* beta, double* vl, int ldvl, double* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggevx")]
            internal static extern int LAPACKE_sggevx(int matrix_layout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, float* a, int lda, float* b, int ldb,
                float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr, int* ilo, int* ihi, float* lscale, float* rscale, float* abnrm, float* bbnrm,
                float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggevx")]
            internal static extern int LAPACKE_dggevx(int matrix_layout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, double* a, int lda, double* b, int ldb,
                double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr, int* ilo, int* ihi, double* lscale, double* rscale, double* abnrm,
                double* bbnrm, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggglm")]
            internal static extern int LAPACKE_sggglm(int matrix_layout, int n, int m, int p, float* a, int lda, float* b, int ldb, float* d, float* x, float* y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggglm")]
            internal static extern int LAPACKE_dggglm(int matrix_layout, int n, int m, int p, double* a, int lda, double* b, int ldb, double* d, double* x, double* y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgghrd")]
            internal static extern int LAPACKE_sgghrd(int matrix_layout, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* a, int lda, float* b, int ldb, float* q, int ldq,
                float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgghrd")]
            internal static extern int LAPACKE_dgghrd(int matrix_layout, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* a, int lda, double* b, int ldb, double* q,
                int ldq, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgghd3")]
            internal static extern int LAPACKE_sgghd3(int matrix_layout, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* a, int lda, float* b, int ldb, float* q, int ldq,
                float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgghd3")]
            internal static extern int LAPACKE_dgghd3(int matrix_layout, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* a, int lda, double* b, int ldb, double* q,
                int ldq, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgglse")]
            internal static extern int LAPACKE_sgglse(int matrix_layout, int m, int n, int p, float* a, int lda, float* b, int ldb, float* c, float* d, float* x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgglse")]
            internal static extern int LAPACKE_dgglse(int matrix_layout, int m, int n, int p, double* a, int lda, double* b, int ldb, double* c, double* d, double* x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggqrf")]
            internal static extern int LAPACKE_sggqrf(int matrix_layout, int n, int m, int p, float* a, int lda, float* taua, float* b, int ldb, float* taub);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggqrf")]
            internal static extern int LAPACKE_dggqrf(int matrix_layout, int n, int m, int p, double* a, int lda, double* taua, double* b, int ldb, double* taub);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggrqf")]
            internal static extern int LAPACKE_sggrqf(int matrix_layout, int m, int p, int n, float* a, int lda, float* taua, float* b, int ldb, float* taub);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggrqf")]
            internal static extern int LAPACKE_dggrqf(int matrix_layout, int m, int p, int n, double* a, int lda, double* taua, double* b, int ldb, double* taub);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggsvd")]
            internal static extern int LAPACKE_sggsvd(int matrix_layout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, float* a, int lda, float* b,
                int ldb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggsvd")]
            internal static extern int LAPACKE_dggsvd(int matrix_layout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, double* a, int lda, double* b,
                int ldb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggsvd3")]
            internal static extern int LAPACKE_sggsvd3(int matrix_layout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, float* a, int lda, float* b,
                int ldb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggsvd3")]
            internal static extern int LAPACKE_dggsvd3(int matrix_layout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, double* a, int lda, double* b,
                int ldb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggsvp")]
            internal static extern int LAPACKE_sggsvp(int matrix_layout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, float* a, int lda, float* b, int ldb, float tola,
                float tolb, int* k, int* l, float* u, int ldu, float* v, int ldv, float* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggsvp")]
            internal static extern int LAPACKE_dggsvp(int matrix_layout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, double* a, int lda, double* b, int ldb,
                double tola, double tolb, int* k, int* l, double* u, int ldu, double* v, int ldv, double* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggsvp3")]
            internal static extern int LAPACKE_sggsvp3(int matrix_layout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, float* a, int lda, float* b, int ldb, float tola,
                float tolb, int* k, int* l, float* u, int ldu, float* v, int ldv, float* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggsvp3")]
            internal static extern int LAPACKE_dggsvp3(int matrix_layout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, double* a, int lda, double* b, int ldb,
                double tola, double tolb, int* k, int* l, double* u, int ldu, double* v, int ldv, double* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgtcon")]
            internal static extern int LAPACKE_sgtcon(sbyte norm, int n, float* dl, float* d, float* du, float* du2, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgtcon")]
            internal static extern int LAPACKE_dgtcon(sbyte norm, int n, double* dl, double* d, double* du, double* du2, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgtrfs")]
            internal static extern int LAPACKE_sgtrfs(int matrix_layout, sbyte trans, int n, int nrhs, float* dl, float* d, float* du, float* dlf, float* df, float* duf,
                float* du2, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgtrfs")]
            internal static extern int LAPACKE_dgtrfs(int matrix_layout, sbyte trans, int n, int nrhs, double* dl, double* d, double* du, double* dlf, double* df, double* duf,
                double* du2, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgtsv")]
            internal static extern int LAPACKE_sgtsv(int matrix_layout, int n, int nrhs, float* dl, float* d, float* du, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgtsv")]
            internal static extern int LAPACKE_dgtsv(int matrix_layout, int n, int nrhs, double* dl, double* d, double* du, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgtsvx")]
            internal static extern int LAPACKE_sgtsvx(int matrix_layout, sbyte fact, sbyte trans, int n, int nrhs, float* dl, float* d, float* du, float* dlf, float* df,
                float* duf, float* du2, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgtsvx")]
            internal static extern int LAPACKE_dgtsvx(int matrix_layout, sbyte fact, sbyte trans, int n, int nrhs, double* dl, double* d, double* du, double* dlf, double* df,
                double* duf, double* du2, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgttrf")]
            internal static extern int LAPACKE_sgttrf(int n, float* dl, float* d, float* du, float* du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgttrf")]
            internal static extern int LAPACKE_dgttrf(int n, double* dl, double* d, double* du, double* du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgttrs")]
            internal static extern int LAPACKE_sgttrs(int matrix_layout, sbyte trans, int n, int nrhs, float* dl, float* d, float* du, float* du2, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgttrs")]
            internal static extern int LAPACKE_dgttrs(int matrix_layout, sbyte trans, int n, int nrhs, double* dl, double* d, double* du, double* du2, int* ipiv, double* b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_shgeqz")]
            internal static extern int LAPACKE_shgeqz(int matrix_layout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* h, int ldh, float* t, int ldt,
                float* alphar, float* alphai, float* beta, float* q, int ldq, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dhgeqz")]
            internal static extern int LAPACKE_dhgeqz(int matrix_layout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* h, int ldh, double* t, int ldt,
                double* alphar, double* alphai, double* beta, double* q, int ldq, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_shsein")]
            internal static extern int LAPACKE_shsein(int matrix_layout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, float* h, int ldh, float* wr, float* wi,
                float* vl, int ldvl, float* vr, int ldvr, int mm, int* m, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dhsein")]
            internal static extern int LAPACKE_dhsein(int matrix_layout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, double* h, int ldh, double* wr, double* wi,
                double* vl, int ldvl, double* vr, int ldvr, int mm, int* m, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_shseqr")]
            internal static extern int LAPACKE_shseqr(int matrix_layout, sbyte job, sbyte compz, int n, int ilo, int ihi, float* h, int ldh, float* wr, float* wi, float* z,
                int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dhseqr")]
            internal static extern int LAPACKE_dhseqr(int matrix_layout, sbyte job, sbyte compz, int n, int ilo, int ihi, double* h, int ldh, double* wr, double* wi, double* z,
                int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slacn2")]
            internal static extern int LAPACKE_slacn2(int n, float* v, float* x, int* isgn, float* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlacn2")]
            internal static extern int LAPACKE_dlacn2(int n, double* v, double* x, int* isgn, double* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slacpy")]
            internal static extern int LAPACKE_slacpy(int matrix_layout, sbyte uplo, int m, int n, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlacpy")]
            internal static extern int LAPACKE_dlacpy(int matrix_layout, sbyte uplo, int m, int n, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slag2d")]
            internal static extern int LAPACKE_slag2d(int matrix_layout, int m, int n, float* sa, int ldsa, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlag2s")]
            internal static extern int LAPACKE_dlag2s(int matrix_layout, int m, int n, double* a, int lda, float* sa, int ldsa);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slagge")]
            internal static extern int LAPACKE_slagge(int matrix_layout, int m, int n, int kl, int ku, float* d, float* a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlagge")]
            internal static extern int LAPACKE_dlagge(int matrix_layout, int m, int n, int kl, int ku, double* d, double* a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slamch")]
            internal static extern float LAPACKE_slamch(sbyte cmach);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlamch")]
            internal static extern double LAPACKE_dlamch(sbyte cmach);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slange")]
            internal static extern float LAPACKE_slange(int matrix_layout, sbyte norm, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlange")]
            internal static extern double LAPACKE_dlange(int matrix_layout, sbyte norm, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slansy")]
            internal static extern float LAPACKE_slansy(int matrix_layout, sbyte norm, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlansy")]
            internal static extern double LAPACKE_dlansy(int matrix_layout, sbyte norm, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slantr")]
            internal static extern float LAPACKE_slantr(int matrix_layout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlantr")]
            internal static extern double LAPACKE_dlantr(int matrix_layout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slarfb")]
            internal static extern int LAPACKE_slarfb(int matrix_layout, sbyte side, sbyte trans, sbyte direct, sbyte storev, int m, int n, int k, float* v, int ldv, float* t,
                int ldt, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlarfb")]
            internal static extern int LAPACKE_dlarfb(int matrix_layout, sbyte side, sbyte trans, sbyte direct, sbyte storev, int m, int n, int k, double* v, int ldv, double* t,
                int ldt, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slarfg")]
            internal static extern int LAPACKE_slarfg(int n, float* alpha, float* x, int incx, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlarfg")]
            internal static extern int LAPACKE_dlarfg(int n, double* alpha, double* x, int incx, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slarft")]
            internal static extern int LAPACKE_slarft(int matrix_layout, sbyte direct, sbyte storev, int n, int k, float* v, int ldv, float* tau, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlarft")]
            internal static extern int LAPACKE_dlarft(int matrix_layout, sbyte direct, sbyte storev, int n, int k, double* v, int ldv, double* tau, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slarfx")]
            internal static extern int LAPACKE_slarfx(int matrix_layout, sbyte side, int m, int n, float* v, float tau, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlarfx")]
            internal static extern int LAPACKE_dlarfx(int matrix_layout, sbyte side, int m, int n, double* v, double tau, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slarnv")]
            internal static extern int LAPACKE_slarnv(int idist, int* iseed, int n, float* x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlarnv")]
            internal static extern int LAPACKE_dlarnv(int idist, int* iseed, int n, double* x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slascl")]
            internal static extern int LAPACKE_slascl(int matrix_layout, sbyte type, int kl, int ku, float cfrom, float cto, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlascl")]
            internal static extern int LAPACKE_dlascl(int matrix_layout, sbyte type, int kl, int ku, double cfrom, double cto, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slaset")]
            internal static extern int LAPACKE_slaset(int matrix_layout, sbyte uplo, int m, int n, float alpha, float beta, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlaset")]
            internal static extern int LAPACKE_dlaset(int matrix_layout, sbyte uplo, int m, int n, double alpha, double beta, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slasrt")]
            internal static extern int LAPACKE_slasrt(sbyte id, int n, float* d);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlasrt")]
            internal static extern int LAPACKE_dlasrt(sbyte id, int n, double* d);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slassq")]
            internal static extern int LAPACKE_slassq(int n, float* x, int incx, float* scale, float* sumsq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlassq")]
            internal static extern int LAPACKE_dlassq(int n, double* x, int incx, double* scale, double* sumsq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slaswp")]
            internal static extern int LAPACKE_slaswp(int matrix_layout, int n, float* a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlaswp")]
            internal static extern int LAPACKE_dlaswp(int matrix_layout, int n, double* a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slatms")]
            internal static extern int LAPACKE_slatms(int matrix_layout, int m, int n, sbyte dist, int* iseed, sbyte sym, float* d, int mode, float cond, float dmax, int kl,
                int ku, sbyte pack, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlatms")]
            internal static extern int LAPACKE_dlatms(int matrix_layout, int m, int n, sbyte dist, int* iseed, sbyte sym, double* d, int mode, double cond, double dmax, int kl,
                int ku, sbyte pack, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slauum")]
            internal static extern int LAPACKE_slauum(int matrix_layout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlauum")]
            internal static extern int LAPACKE_dlauum(int matrix_layout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sopgtr")]
            internal static extern int LAPACKE_sopgtr(int matrix_layout, sbyte uplo, int n, float* ap, float* tau, float* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dopgtr")]
            internal static extern int LAPACKE_dopgtr(int matrix_layout, sbyte uplo, int n, double* ap, double* tau, double* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sopmtr")]
            internal static extern int LAPACKE_sopmtr(int matrix_layout, sbyte side, sbyte uplo, sbyte trans, int m, int n, float* ap, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dopmtr")]
            internal static extern int LAPACKE_dopmtr(int matrix_layout, sbyte side, sbyte uplo, sbyte trans, int m, int n, double* ap, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorgbr")]
            internal static extern int LAPACKE_sorgbr(int matrix_layout, sbyte vect, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorgbr")]
            internal static extern int LAPACKE_dorgbr(int matrix_layout, sbyte vect, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorghr")]
            internal static extern int LAPACKE_sorghr(int matrix_layout, int n, int ilo, int ihi, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorghr")]
            internal static extern int LAPACKE_dorghr(int matrix_layout, int n, int ilo, int ihi, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorglq")]
            internal static extern int LAPACKE_sorglq(int matrix_layout, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorglq")]
            internal static extern int LAPACKE_dorglq(int matrix_layout, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorgql")]
            internal static extern int LAPACKE_sorgql(int matrix_layout, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorgql")]
            internal static extern int LAPACKE_dorgql(int matrix_layout, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorgqr")]
            internal static extern int LAPACKE_sorgqr(int matrix_layout, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorgqr")]
            internal static extern int LAPACKE_dorgqr(int matrix_layout, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorgrq")]
            internal static extern int LAPACKE_sorgrq(int matrix_layout, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorgrq")]
            internal static extern int LAPACKE_dorgrq(int matrix_layout, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorgtr")]
            internal static extern int LAPACKE_sorgtr(int matrix_layout, sbyte uplo, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorgtr")]
            internal static extern int LAPACKE_dorgtr(int matrix_layout, sbyte uplo, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormbr")]
            internal static extern int LAPACKE_sormbr(int matrix_layout, sbyte vect, sbyte side, sbyte trans, int m, int n, int k, float* a, int lda, float* tau, float* c,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormbr")]
            internal static extern int LAPACKE_dormbr(int matrix_layout, sbyte vect, sbyte side, sbyte trans, int m, int n, int k, double* a, int lda, double* tau, double* c,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormhr")]
            internal static extern int LAPACKE_sormhr(int matrix_layout, sbyte side, sbyte trans, int m, int n, int ilo, int ihi, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormhr")]
            internal static extern int LAPACKE_dormhr(int matrix_layout, sbyte side, sbyte trans, int m, int n, int ilo, int ihi, double* a, int lda, double* tau, double* c,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormlq")]
            internal static extern int LAPACKE_sormlq(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormlq")]
            internal static extern int LAPACKE_dormlq(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormql")]
            internal static extern int LAPACKE_sormql(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormql")]
            internal static extern int LAPACKE_dormql(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormqr")]
            internal static extern int LAPACKE_sormqr(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormqr")]
            internal static extern int LAPACKE_dormqr(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormrq")]
            internal static extern int LAPACKE_sormrq(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormrq")]
            internal static extern int LAPACKE_dormrq(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormrz")]
            internal static extern int LAPACKE_sormrz(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, int l, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormrz")]
            internal static extern int LAPACKE_dormrz(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, int l, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormtr")]
            internal static extern int LAPACKE_sormtr(int matrix_layout, sbyte side, sbyte uplo, sbyte trans, int m, int n, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormtr")]
            internal static extern int LAPACKE_dormtr(int matrix_layout, sbyte side, sbyte uplo, sbyte trans, int m, int n, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbcon")]
            internal static extern int LAPACKE_spbcon(int matrix_layout, sbyte uplo, int n, int kd, float* ab, int ldab, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbcon")]
            internal static extern int LAPACKE_dpbcon(int matrix_layout, sbyte uplo, int n, int kd, double* ab, int ldab, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbequ")]
            internal static extern int LAPACKE_spbequ(int matrix_layout, sbyte uplo, int n, int kd, float* ab, int ldab, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbequ")]
            internal static extern int LAPACKE_dpbequ(int matrix_layout, sbyte uplo, int n, int kd, double* ab, int ldab, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbrfs")]
            internal static extern int LAPACKE_spbrfs(int matrix_layout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* afb, int ldafb, float* b, int ldb,
                float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbrfs")]
            internal static extern int LAPACKE_dpbrfs(int matrix_layout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* afb, int ldafb, double* b, int ldb,
                double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbstf")]
            internal static extern int LAPACKE_spbstf(int matrix_layout, sbyte uplo, int n, int kb, float* bb, int ldbb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbstf")]
            internal static extern int LAPACKE_dpbstf(int matrix_layout, sbyte uplo, int n, int kb, double* bb, int ldbb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbsv")]
            internal static extern int LAPACKE_spbsv(int matrix_layout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbsv")]
            internal static extern int LAPACKE_dpbsv(int matrix_layout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbsvx")]
            internal static extern int LAPACKE_spbsvx(int matrix_layout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* afb, int ldafb, sbyte* equed,
                float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbsvx")]
            internal static extern int LAPACKE_dpbsvx(int matrix_layout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* afb, int ldafb,
                sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbtrf")]
            internal static extern int LAPACKE_spbtrf(int matrix_layout, sbyte uplo, int n, int kd, float* ab, int ldab);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbtrf")]
            internal static extern int LAPACKE_dpbtrf(int matrix_layout, sbyte uplo, int n, int kd, double* ab, int ldab);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbtrs")]
            internal static extern int LAPACKE_spbtrs(int matrix_layout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbtrs")]
            internal static extern int LAPACKE_dpbtrs(int matrix_layout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spftrf")]
            internal static extern int LAPACKE_spftrf(int matrix_layout, sbyte transr, sbyte uplo, int n, float* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpftrf")]
            internal static extern int LAPACKE_dpftrf(int matrix_layout, sbyte transr, sbyte uplo, int n, double* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spftri")]
            internal static extern int LAPACKE_spftri(int matrix_layout, sbyte transr, sbyte uplo, int n, float* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpftri")]
            internal static extern int LAPACKE_dpftri(int matrix_layout, sbyte transr, sbyte uplo, int n, double* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spftrs")]
            internal static extern int LAPACKE_spftrs(int matrix_layout, sbyte transr, sbyte uplo, int n, int nrhs, float* a, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpftrs")]
            internal static extern int LAPACKE_dpftrs(int matrix_layout, sbyte transr, sbyte uplo, int n, int nrhs, double* a, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spocon")]
            internal static extern int LAPACKE_spocon(int matrix_layout, sbyte uplo, int n, float* a, int lda, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpocon")]
            internal static extern int LAPACKE_dpocon(int matrix_layout, sbyte uplo, int n, double* a, int lda, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spoequ")]
            internal static extern int LAPACKE_spoequ(int matrix_layout, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpoequ")]
            internal static extern int LAPACKE_dpoequ(int matrix_layout, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spoequb")]
            internal static extern int LAPACKE_spoequb(int matrix_layout, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpoequb")]
            internal static extern int LAPACKE_dpoequb(int matrix_layout, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sporfs")]
            internal static extern int LAPACKE_sporfs(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, float* b, int ldb, float* x, int ldx,
                float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dporfs")]
            internal static extern int LAPACKE_dporfs(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, double* b, int ldb, double* x,
                int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sporfsx")]
            internal static extern int LAPACKE_sporfsx(int matrix_layout, sbyte uplo, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, float* s, float* b,
                int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dporfsx")]
            internal static extern int LAPACKE_dporfsx(int matrix_layout, sbyte uplo, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, double* s, double* b,
                int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sposv")]
            internal static extern int LAPACKE_sposv(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dposv")]
            internal static extern int LAPACKE_dposv(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsposv")]
            internal static extern int LAPACKE_dsposv(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb, double* x, int ldx, int* iter);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sposvx")]
            internal static extern int LAPACKE_sposvx(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, sbyte* equed, float* s,
                float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dposvx")]
            internal static extern int LAPACKE_dposvx(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, sbyte* equed, double* s,
                double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sposvxx")]
            internal static extern int LAPACKE_sposvxx(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, sbyte* equed, float* s,
                float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams,
                float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dposvxx")]
            internal static extern int LAPACKE_dposvxx(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, sbyte* equed,
                double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp,
                int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spotrf2")]
            internal static extern int LAPACKE_spotrf2(int matrix_layout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpotrf2")]
            internal static extern int LAPACKE_dpotrf2(int matrix_layout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spotrf")]
            internal static extern int LAPACKE_spotrf(int matrix_layout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpotrf")]
            internal static extern int LAPACKE_dpotrf(int matrix_layout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spotri")]
            internal static extern int LAPACKE_spotri(int matrix_layout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpotri")]
            internal static extern int LAPACKE_dpotri(int matrix_layout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spotrs")]
            internal static extern int LAPACKE_spotrs(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpotrs")]
            internal static extern int LAPACKE_dpotrs(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sppcon")]
            internal static extern int LAPACKE_sppcon(int matrix_layout, sbyte uplo, int n, float* ap, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dppcon")]
            internal static extern int LAPACKE_dppcon(int matrix_layout, sbyte uplo, int n, double* ap, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sppequ")]
            internal static extern int LAPACKE_sppequ(int matrix_layout, sbyte uplo, int n, float* ap, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dppequ")]
            internal static extern int LAPACKE_dppequ(int matrix_layout, sbyte uplo, int n, double* ap, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spprfs")]
            internal static extern int LAPACKE_spprfs(int matrix_layout, sbyte uplo, int n, int nrhs, float* ap, float* afp, float* b, int ldb, float* x, int ldx, float* ferr,
                float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpprfs")]
            internal static extern int LAPACKE_dpprfs(int matrix_layout, sbyte uplo, int n, int nrhs, double* ap, double* afp, double* b, int ldb, double* x, int ldx, double* ferr,
                double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sppsv")]
            internal static extern int LAPACKE_sppsv(int matrix_layout, sbyte uplo, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dppsv")]
            internal static extern int LAPACKE_dppsv(int matrix_layout, sbyte uplo, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sppsvx")]
            internal static extern int LAPACKE_sppsvx(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, float* ap, float* afp, sbyte* equed, float* s, float* b, int ldb,
                float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dppsvx")]
            internal static extern int LAPACKE_dppsvx(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, double* ap, double* afp, sbyte* equed, double* s, double* b,
                int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spptrf")]
            internal static extern int LAPACKE_spptrf(int matrix_layout, sbyte uplo, int n, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpptrf")]
            internal static extern int LAPACKE_dpptrf(int matrix_layout, sbyte uplo, int n, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spptri")]
            internal static extern int LAPACKE_spptri(int matrix_layout, sbyte uplo, int n, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpptri")]
            internal static extern int LAPACKE_dpptri(int matrix_layout, sbyte uplo, int n, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spptrs")]
            internal static extern int LAPACKE_spptrs(int matrix_layout, sbyte uplo, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpptrs")]
            internal static extern int LAPACKE_dpptrs(int matrix_layout, sbyte uplo, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spstrf")]
            internal static extern int LAPACKE_spstrf(int matrix_layout, sbyte uplo, int n, float* a, int lda, int* piv, int* rank, float tol);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpstrf")]
            internal static extern int LAPACKE_dpstrf(int matrix_layout, sbyte uplo, int n, double* a, int lda, int* piv, int* rank, double tol);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sptcon")]
            internal static extern int LAPACKE_sptcon(int n, float* d, float* e, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dptcon")]
            internal static extern int LAPACKE_dptcon(int n, double* d, double* e, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spteqr")]
            internal static extern int LAPACKE_spteqr(int matrix_layout, sbyte compz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpteqr")]
            internal static extern int LAPACKE_dpteqr(int matrix_layout, sbyte compz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sptrfs")]
            internal static extern int LAPACKE_sptrfs(int matrix_layout, int n, int nrhs, float* d, float* e, float* df, float* ef, float* b, int ldb, float* x, int ldx,
                float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dptrfs")]
            internal static extern int LAPACKE_dptrfs(int matrix_layout, int n, int nrhs, double* d, double* e, double* df, double* ef, double* b, int ldb, double* x, int ldx,
                double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sptsv")]
            internal static extern int LAPACKE_sptsv(int matrix_layout, int n, int nrhs, float* d, float* e, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dptsv")]
            internal static extern int LAPACKE_dptsv(int matrix_layout, int n, int nrhs, double* d, double* e, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sptsvx")]
            internal static extern int LAPACKE_sptsvx(int matrix_layout, sbyte fact, int n, int nrhs, float* d, float* e, float* df, float* ef, float* b, int ldb, float* x,
                int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dptsvx")]
            internal static extern int LAPACKE_dptsvx(int matrix_layout, sbyte fact, int n, int nrhs, double* d, double* e, double* df, double* ef, double* b, int ldb, double* x,
                int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spttrf")]
            internal static extern int LAPACKE_spttrf(int n, float* d, float* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpttrf")]
            internal static extern int LAPACKE_dpttrf(int n, double* d, double* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spttrs")]
            internal static extern int LAPACKE_spttrs(int matrix_layout, int n, int nrhs, float* d, float* e, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpttrs")]
            internal static extern int LAPACKE_dpttrs(int matrix_layout, int n, int nrhs, double* d, double* e, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbev")]
            internal static extern int LAPACKE_ssbev(int matrix_layout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbev")]
            internal static extern int LAPACKE_dsbev(int matrix_layout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbevd")]
            internal static extern int LAPACKE_ssbevd(int matrix_layout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbevd")]
            internal static extern int LAPACKE_dsbevd(int matrix_layout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbevx")]
            internal static extern int LAPACKE_ssbevx(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, float* ab, int ldab, float* q, int ldq, float vl,
                float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbevx")]
            internal static extern int LAPACKE_dsbevx(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, double* ab, int ldab, double* q, int ldq, double vl,
                double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbgst")]
            internal static extern int LAPACKE_ssbgst(int matrix_layout, sbyte vect, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* x,
                int ldx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbgst")]
            internal static extern int LAPACKE_dsbgst(int matrix_layout, sbyte vect, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* x,
                int ldx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbgv")]
            internal static extern int LAPACKE_ssbgv(int matrix_layout, sbyte jobz, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* w, float* z,
                int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbgv")]
            internal static extern int LAPACKE_dsbgv(int matrix_layout, sbyte jobz, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* w,
                double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbgvd")]
            internal static extern int LAPACKE_ssbgvd(int matrix_layout, sbyte jobz, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* w,
                float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbgvd")]
            internal static extern int LAPACKE_dsbgvd(int matrix_layout, sbyte jobz, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* w,
                double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbgvx")]
            internal static extern int LAPACKE_ssbgvx(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb,
                float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbgvx")]
            internal static extern int LAPACKE_dsbgvx(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb,
                double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbtrd")]
            internal static extern int LAPACKE_ssbtrd(int matrix_layout, sbyte vect, sbyte uplo, int n, int kd, float* ab, int ldab, float* d, float* e, float* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbtrd")]
            internal static extern int LAPACKE_dsbtrd(int matrix_layout, sbyte vect, sbyte uplo, int n, int kd, double* ab, int ldab, double* d, double* e, double* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssfrk")]
            internal static extern int LAPACKE_ssfrk(int matrix_layout, sbyte transr, sbyte uplo, sbyte trans, int n, int k, float alpha, float* a, int lda, float beta, float* c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsfrk")]
            internal static extern int LAPACKE_dsfrk(int matrix_layout, sbyte transr, sbyte uplo, sbyte trans, int n, int k, double alpha, double* a, int lda, double beta,
                double* c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspcon")]
            internal static extern int LAPACKE_sspcon(int matrix_layout, sbyte uplo, int n, float* ap, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspcon")]
            internal static extern int LAPACKE_dspcon(int matrix_layout, sbyte uplo, int n, double* ap, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspev")]
            internal static extern int LAPACKE_sspev(int matrix_layout, sbyte jobz, sbyte uplo, int n, float* ap, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspev")]
            internal static extern int LAPACKE_dspev(int matrix_layout, sbyte jobz, sbyte uplo, int n, double* ap, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspevd")]
            internal static extern int LAPACKE_sspevd(int matrix_layout, sbyte jobz, sbyte uplo, int n, float* ap, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspevd")]
            internal static extern int LAPACKE_dspevd(int matrix_layout, sbyte jobz, sbyte uplo, int n, double* ap, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspevx")]
            internal static extern int LAPACKE_sspevx(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, float* ap, float vl, float vu, int il, int iu, float abstol,
                int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspevx")]
            internal static extern int LAPACKE_dspevx(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, double* ap, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspgst")]
            internal static extern int LAPACKE_sspgst(int matrix_layout, int itype, sbyte uplo, int n, float* ap, float* bp);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspgst")]
            internal static extern int LAPACKE_dspgst(int matrix_layout, int itype, sbyte uplo, int n, double* ap, double* bp);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspgv")]
            internal static extern int LAPACKE_sspgv(int matrix_layout, int itype, sbyte jobz, sbyte uplo, int n, float* ap, float* bp, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspgv")]
            internal static extern int LAPACKE_dspgv(int matrix_layout, int itype, sbyte jobz, sbyte uplo, int n, double* ap, double* bp, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspgvd")]
            internal static extern int LAPACKE_sspgvd(int matrix_layout, int itype, sbyte jobz, sbyte uplo, int n, float* ap, float* bp, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspgvd")]
            internal static extern int LAPACKE_dspgvd(int matrix_layout, int itype, sbyte jobz, sbyte uplo, int n, double* ap, double* bp, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspgvx")]
            internal static extern int LAPACKE_sspgvx(int matrix_layout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, float* ap, float* bp, float vl, float vu, int il,
                int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspgvx")]
            internal static extern int LAPACKE_dspgvx(int matrix_layout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, double* ap, double* bp, double vl, double vu,
                int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssprfs")]
            internal static extern int LAPACKE_ssprfs(int matrix_layout, sbyte uplo, int n, int nrhs, float* ap, float* afp, int* ipiv, float* b, int ldb, float* x, int ldx,
                float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsprfs")]
            internal static extern int LAPACKE_dsprfs(int matrix_layout, sbyte uplo, int n, int nrhs, double* ap, double* afp, int* ipiv, double* b, int ldb, double* x, int ldx,
                double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspsv")]
            internal static extern int LAPACKE_sspsv(int matrix_layout, sbyte uplo, int n, int nrhs, float* ap, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspsv")]
            internal static extern int LAPACKE_dspsv(int matrix_layout, sbyte uplo, int n, int nrhs, double* ap, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspsvx")]
            internal static extern int LAPACKE_sspsvx(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, float* ap, float* afp, int* ipiv, float* b, int ldb, float* x,
                int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspsvx")]
            internal static extern int LAPACKE_dspsvx(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, double* ap, double* afp, int* ipiv, double* b, int ldb, double* x,
                int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssptrd")]
            internal static extern int LAPACKE_ssptrd(int matrix_layout, sbyte uplo, int n, float* ap, float* d, float* e, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsptrd")]
            internal static extern int LAPACKE_dsptrd(int matrix_layout, sbyte uplo, int n, double* ap, double* d, double* e, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssptrf")]
            internal static extern int LAPACKE_ssptrf(int matrix_layout, sbyte uplo, int n, float* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsptrf")]
            internal static extern int LAPACKE_dsptrf(int matrix_layout, sbyte uplo, int n, double* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssptri")]
            internal static extern int LAPACKE_ssptri(int matrix_layout, sbyte uplo, int n, float* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsptri")]
            internal static extern int LAPACKE_dsptri(int matrix_layout, sbyte uplo, int n, double* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssptrs")]
            internal static extern int LAPACKE_ssptrs(int matrix_layout, sbyte uplo, int n, int nrhs, float* ap, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsptrs")]
            internal static extern int LAPACKE_dsptrs(int matrix_layout, sbyte uplo, int n, int nrhs, double* ap, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstebz")]
            internal static extern int LAPACKE_sstebz(sbyte range, sbyte order, int n, float vl, float vu, int il, int iu, float abstol, float* d, float* e, int* m, int* nsplit,
                float* w, int* iblock, int* isplit);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstebz")]
            internal static extern int LAPACKE_dstebz(sbyte range, sbyte order, int n, double vl, double vu, int il, int iu, double abstol, double* d, double* e, int* m,
                int* nsplit, double* w, int* iblock, int* isplit);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstedc")]
            internal static extern int LAPACKE_sstedc(int matrix_layout, sbyte compz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstedc")]
            internal static extern int LAPACKE_dstedc(int matrix_layout, sbyte compz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstegr")]
            internal static extern int LAPACKE_sstegr(int matrix_layout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol,
                int* m, float* w, float* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstegr")]
            internal static extern int LAPACKE_dstegr(int matrix_layout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol,
                int* m, double* w, double* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstein")]
            internal static extern int LAPACKE_sstein(int matrix_layout, int n, float* d, float* e, int m, float* w, int* iblock, int* isplit, float* z, int ldz, int* ifailv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstein")]
            internal static extern int LAPACKE_dstein(int matrix_layout, int n, double* d, double* e, int m, double* w, int* iblock, int* isplit, double* z, int ldz, int* ifailv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstemr")]
            internal static extern int LAPACKE_sstemr(int matrix_layout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* m, float* w,
                float* z, int ldz, int nzc, int* isuppz, int* tryrac);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstemr")]
            internal static extern int LAPACKE_dstemr(int matrix_layout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* m,
                double* w, double* z, int ldz, int nzc, int* isuppz, int* tryrac);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssteqr")]
            internal static extern int LAPACKE_ssteqr(int matrix_layout, sbyte compz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsteqr")]
            internal static extern int LAPACKE_dsteqr(int matrix_layout, sbyte compz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssterf")]
            internal static extern int LAPACKE_ssterf(int n, float* d, float* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsterf")]
            internal static extern int LAPACKE_dsterf(int n, double* d, double* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstev")]
            internal static extern int LAPACKE_sstev(int matrix_layout, sbyte jobz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstev")]
            internal static extern int LAPACKE_dstev(int matrix_layout, sbyte jobz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstevd")]
            internal static extern int LAPACKE_sstevd(int matrix_layout, sbyte jobz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstevd")]
            internal static extern int LAPACKE_dstevd(int matrix_layout, sbyte jobz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstevr")]
            internal static extern int LAPACKE_sstevr(int matrix_layout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol,
                int* m, float* w, float* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstevr")]
            internal static extern int LAPACKE_dstevr(int matrix_layout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol,
                int* m, double* w, double* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstevx")]
            internal static extern int LAPACKE_sstevx(int matrix_layout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol,
                int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstevx")]
            internal static extern int LAPACKE_dstevx(int matrix_layout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol,
                int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssycon")]
            internal static extern int LAPACKE_ssycon(int matrix_layout, sbyte uplo, int n, float* a, int lda, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsycon")]
            internal static extern int LAPACKE_dsycon(int matrix_layout, sbyte uplo, int n, double* a, int lda, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyequb")]
            internal static extern int LAPACKE_ssyequb(int matrix_layout, sbyte uplo, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyequb")]
            internal static extern int LAPACKE_dsyequb(int matrix_layout, sbyte uplo, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyev")]
            internal static extern int LAPACKE_ssyev(int matrix_layout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyev")]
            internal static extern int LAPACKE_dsyev(int matrix_layout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevd")]
            internal static extern int LAPACKE_ssyevd(int matrix_layout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevd")]
            internal static extern int LAPACKE_dsyevd(int matrix_layout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevr")]
            internal static extern int LAPACKE_ssyevr(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, float* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevr")]
            internal static extern int LAPACKE_dsyevr(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, double* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevx")]
            internal static extern int LAPACKE_ssyevx(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevx")]
            internal static extern int LAPACKE_dsyevx(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssygst")]
            internal static extern int LAPACKE_ssygst(int matrix_layout, int itype, sbyte uplo, int n, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsygst")]
            internal static extern int LAPACKE_dsygst(int matrix_layout, int itype, sbyte uplo, int n, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssygv")]
            internal static extern int LAPACKE_ssygv(int matrix_layout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsygv")]
            internal static extern int LAPACKE_dsygv(int matrix_layout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssygvd")]
            internal static extern int LAPACKE_ssygvd(int matrix_layout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsygvd")]
            internal static extern int LAPACKE_dsygvd(int matrix_layout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssygvx")]
            internal static extern int LAPACKE_ssygvx(int matrix_layout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float vl,
                float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsygvx")]
            internal static extern int LAPACKE_dsygvx(int matrix_layout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double vl,
                double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyrfs")]
            internal static extern int LAPACKE_ssyrfs(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb,
                float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyrfs")]
            internal static extern int LAPACKE_dsyrfs(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb,
                double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyrfsx")]
            internal static extern int LAPACKE_ssyrfsx(int matrix_layout, sbyte uplo, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* s,
                float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyrfsx")]
            internal static extern int LAPACKE_dsyrfsx(int matrix_layout, sbyte uplo, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* s,
                double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysv")]
            internal static extern int LAPACKE_ssysv(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysv")]
            internal static extern int LAPACKE_dsysv(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysvx")]
            internal static extern int LAPACKE_ssysvx(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b,
                int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysvx")]
            internal static extern int LAPACKE_dsysvx(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b,
                int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysvxx")]
            internal static extern int LAPACKE_ssysvxx(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed,
                float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams,
                float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysvxx")]
            internal static extern int LAPACKE_dsysvxx(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv,
                sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm,
                double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrd")]
            internal static extern int LAPACKE_ssytrd(int matrix_layout, sbyte uplo, int n, float* a, int lda, float* d, float* e, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrd")]
            internal static extern int LAPACKE_dsytrd(int matrix_layout, sbyte uplo, int n, double* a, int lda, double* d, double* e, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrf")]
            internal static extern int LAPACKE_ssytrf(int matrix_layout, sbyte uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrf")]
            internal static extern int LAPACKE_dsytrf(int matrix_layout, sbyte uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytri")]
            internal static extern int LAPACKE_ssytri(int matrix_layout, sbyte uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytri")]
            internal static extern int LAPACKE_dsytri(int matrix_layout, sbyte uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs")]
            internal static extern int LAPACKE_ssytrs(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs")]
            internal static extern int LAPACKE_dsytrs(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stbcon")]
            internal static extern int LAPACKE_stbcon(int matrix_layout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, float* ab, int ldab, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtbcon")]
            internal static extern int LAPACKE_dtbcon(int matrix_layout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, double* ab, int ldab, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stbrfs")]
            internal static extern int LAPACKE_stbrfs(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb,
                float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtbrfs")]
            internal static extern int LAPACKE_dtbrfs(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb,
                double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stbtrs")]
            internal static extern int LAPACKE_stbtrs(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtbtrs")]
            internal static extern int LAPACKE_dtbtrs(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stfsm")]
            internal static extern int LAPACKE_stfsm(int matrix_layout, sbyte transr, sbyte side, sbyte uplo, sbyte trans, sbyte diag, int m, int n, float alpha, float* a,
                float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtfsm")]
            internal static extern int LAPACKE_dtfsm(int matrix_layout, sbyte transr, sbyte side, sbyte uplo, sbyte trans, sbyte diag, int m, int n, double alpha, double* a,
                double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stftri")]
            internal static extern int LAPACKE_stftri(int matrix_layout, sbyte transr, sbyte uplo, sbyte diag, int n, float* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtftri")]
            internal static extern int LAPACKE_dtftri(int matrix_layout, sbyte transr, sbyte uplo, sbyte diag, int n, double* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stfttp")]
            internal static extern int LAPACKE_stfttp(int matrix_layout, sbyte transr, sbyte uplo, int n, float* arf, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtfttp")]
            internal static extern int LAPACKE_dtfttp(int matrix_layout, sbyte transr, sbyte uplo, int n, double* arf, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stfttr")]
            internal static extern int LAPACKE_stfttr(int matrix_layout, sbyte transr, sbyte uplo, int n, float* arf, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtfttr")]
            internal static extern int LAPACKE_dtfttr(int matrix_layout, sbyte transr, sbyte uplo, int n, double* arf, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgevc")]
            internal static extern int LAPACKE_stgevc(int matrix_layout, sbyte side, sbyte howmny, int* select, int n, float* s, int lds, float* p, int ldp, float* vl, int ldvl,
                float* vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgevc")]
            internal static extern int LAPACKE_dtgevc(int matrix_layout, sbyte side, sbyte howmny, int* select, int n, double* s, int lds, double* p, int ldp, double* vl, int ldvl,
                double* vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgexc")]
            internal static extern int LAPACKE_stgexc(int matrix_layout, int wantq, int wantz, int n, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz,
                int* ifst, int* ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgexc")]
            internal static extern int LAPACKE_dtgexc(int matrix_layout, int wantq, int wantz, int n, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z,
                int ldz, int* ifst, int* ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgsen")]
            internal static extern int LAPACKE_stgsen(int matrix_layout, int ijob, int wantq, int wantz, int* select, int n, float* a, int lda, float* b, int ldb, float* alphar,
                float* alphai, float* beta, float* q, int ldq, float* z, int ldz, int* m, float* pl, float* pr, float* dif);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgsen")]
            internal static extern int LAPACKE_dtgsen(int matrix_layout, int ijob, int wantq, int wantz, int* select, int n, double* a, int lda, double* b, int ldb, double* alphar,
                double* alphai, double* beta, double* q, int ldq, double* z, int ldz, int* m, double* pl, double* pr, double* dif);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgsja")]
            internal static extern int LAPACKE_stgsja(int matrix_layout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, float* a, int lda, float* b,
                int ldb, float tola, float tolb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* ncycle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgsja")]
            internal static extern int LAPACKE_dtgsja(int matrix_layout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, double* a, int lda, double* b,
                int ldb, double tola, double tolb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* ncycle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgsna")]
            internal static extern int LAPACKE_stgsna(int matrix_layout, sbyte job, sbyte howmny, int* select, int n, float* a, int lda, float* b, int ldb, float* vl, int ldvl,
                float* vr, int ldvr, float* s, float* dif, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgsna")]
            internal static extern int LAPACKE_dtgsna(int matrix_layout, sbyte job, sbyte howmny, int* select, int n, double* a, int lda, double* b, int ldb, double* vl, int ldvl,
                double* vr, int ldvr, double* s, double* dif, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgsyl")]
            internal static extern int LAPACKE_stgsyl(int matrix_layout, sbyte trans, int ijob, int m, int n, float* a, int lda, float* b, int ldb, float* c, int ldc, float* d,
                int ldd, float* e, int lde, float* f, int ldf, float* scale, float* dif);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgsyl")]
            internal static extern int LAPACKE_dtgsyl(int matrix_layout, sbyte trans, int ijob, int m, int n, double* a, int lda, double* b, int ldb, double* c, int ldc, double* d,
                int ldd, double* e, int lde, double* f, int ldf, double* scale, double* dif);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpcon")]
            internal static extern int LAPACKE_stpcon(int matrix_layout, sbyte norm, sbyte uplo, sbyte diag, int n, float* ap, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpcon")]
            internal static extern int LAPACKE_dtpcon(int matrix_layout, sbyte norm, sbyte uplo, sbyte diag, int n, double* ap, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stprfs")]
            internal static extern int LAPACKE_stprfs(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int nrhs, float* ap, float* b, int ldb, float* x, int ldx,
                float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtprfs")]
            internal static extern int LAPACKE_dtprfs(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int nrhs, double* ap, double* b, int ldb, double* x, int ldx,
                double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stptri")]
            internal static extern int LAPACKE_stptri(int matrix_layout, sbyte uplo, sbyte diag, int n, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtptri")]
            internal static extern int LAPACKE_dtptri(int matrix_layout, sbyte uplo, sbyte diag, int n, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stptrs")]
            internal static extern int LAPACKE_stptrs(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtptrs")]
            internal static extern int LAPACKE_dtptrs(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpttf")]
            internal static extern int LAPACKE_stpttf(int matrix_layout, sbyte transr, sbyte uplo, int n, float* ap, float* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpttf")]
            internal static extern int LAPACKE_dtpttf(int matrix_layout, sbyte transr, sbyte uplo, int n, double* ap, double* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpttr")]
            internal static extern int LAPACKE_stpttr(int matrix_layout, sbyte uplo, int n, float* ap, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpttr")]
            internal static extern int LAPACKE_dtpttr(int matrix_layout, sbyte uplo, int n, double* ap, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strcon")]
            internal static extern int LAPACKE_strcon(int matrix_layout, sbyte norm, sbyte uplo, sbyte diag, int n, float* a, int lda, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrcon")]
            internal static extern int LAPACKE_dtrcon(int matrix_layout, sbyte norm, sbyte uplo, sbyte diag, int n, double* a, int lda, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strevc")]
            internal static extern int LAPACKE_strevc(int matrix_layout, sbyte side, sbyte howmny, int* select, int n, float* t, int ldt, float* vl, int ldvl, float* vr, int ldvr,
                int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrevc")]
            internal static extern int LAPACKE_dtrevc(int matrix_layout, sbyte side, sbyte howmny, int* select, int n, double* t, int ldt, double* vl, int ldvl, double* vr,
                int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strexc")]
            internal static extern int LAPACKE_strexc(int matrix_layout, sbyte compq, int n, float* t, int ldt, float* q, int ldq, int* ifst, int* ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrexc")]
            internal static extern int LAPACKE_dtrexc(int matrix_layout, sbyte compq, int n, double* t, int ldt, double* q, int ldq, int* ifst, int* ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strrfs")]
            internal static extern int LAPACKE_strrfs(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int nrhs, float* a, int lda, float* b, int ldb, float* x,
                int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrrfs")]
            internal static extern int LAPACKE_dtrrfs(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int nrhs, double* a, int lda, double* b, int ldb, double* x,
                int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strsen")]
            internal static extern int LAPACKE_strsen(int matrix_layout, sbyte job, sbyte compq, int* select, int n, float* t, int ldt, float* q, int ldq, float* wr, float* wi,
                int* m, float* s, float* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrsen")]
            internal static extern int LAPACKE_dtrsen(int matrix_layout, sbyte job, sbyte compq, int* select, int n, double* t, int ldt, double* q, int ldq, double* wr, double* wi,
                int* m, double* s, double* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strsna")]
            internal static extern int LAPACKE_strsna(int matrix_layout, sbyte job, sbyte howmny, int* select, int n, float* t, int ldt, float* vl, int ldvl, float* vr, int ldvr,
                float* s, float* sep, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrsna")]
            internal static extern int LAPACKE_dtrsna(int matrix_layout, sbyte job, sbyte howmny, int* select, int n, double* t, int ldt, double* vl, int ldvl, double* vr,
                int ldvr, double* s, double* sep, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strsyl")]
            internal static extern int LAPACKE_strsyl(int matrix_layout, sbyte trana, sbyte tranb, int isgn, int m, int n, float* a, int lda, float* b, int ldb, float* c, int ldc,
                float* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrsyl")]
            internal static extern int LAPACKE_dtrsyl(int matrix_layout, sbyte trana, sbyte tranb, int isgn, int m, int n, double* a, int lda, double* b, int ldb, double* c,
                int ldc, double* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strtri")]
            internal static extern int LAPACKE_strtri(int matrix_layout, sbyte uplo, sbyte diag, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrtri")]
            internal static extern int LAPACKE_dtrtri(int matrix_layout, sbyte uplo, sbyte diag, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strtrs")]
            internal static extern int LAPACKE_strtrs(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrtrs")]
            internal static extern int LAPACKE_dtrtrs(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strttf")]
            internal static extern int LAPACKE_strttf(int matrix_layout, sbyte transr, sbyte uplo, int n, float* a, int lda, float* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrttf")]
            internal static extern int LAPACKE_dtrttf(int matrix_layout, sbyte transr, sbyte uplo, int n, double* a, int lda, double* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strttp")]
            internal static extern int LAPACKE_strttp(int matrix_layout, sbyte uplo, int n, float* a, int lda, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrttp")]
            internal static extern int LAPACKE_dtrttp(int matrix_layout, sbyte uplo, int n, double* a, int lda, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stzrzf")]
            internal static extern int LAPACKE_stzrzf(int matrix_layout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtzrzf")]
            internal static extern int LAPACKE_dtzrzf(int matrix_layout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sbdsdc_work")]
            internal static extern int LAPACKE_sbdsdc_work(int matrix_layout, sbyte uplo, sbyte compq, int n, float* d, float* e, float* u, int ldu, float* vt, int ldvt, float* q,
                int* iq, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dbdsdc_work")]
            internal static extern int LAPACKE_dbdsdc_work(int matrix_layout, sbyte uplo, sbyte compq, int n, double* d, double* e, double* u, int ldu, double* vt, int ldvt,
                double* q, int* iq, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sbdsvdx_work")]
            internal static extern int LAPACKE_sbdsvdx_work(int matrix_layout, sbyte uplo, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu,
                int* ns, float* s, float* z, int ldz, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dbdsvdx_work")]
            internal static extern int LAPACKE_dbdsvdx_work(int matrix_layout, sbyte uplo, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il,
                int iu, int* ns, double* s, double* z, int ldz, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sbdsqr_work")]
            internal static extern int LAPACKE_sbdsqr_work(int matrix_layout, sbyte uplo, int n, int ncvt, int nru, int ncc, float* d, float* e, float* vt, int ldvt, float* u,
                int ldu, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dbdsqr_work")]
            internal static extern int LAPACKE_dbdsqr_work(int matrix_layout, sbyte uplo, int n, int ncvt, int nru, int ncc, double* d, double* e, double* vt, int ldvt, double* u,
                int ldu, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sdisna_work")]
            internal static extern int LAPACKE_sdisna_work(sbyte job, int m, int n, float* d, float* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ddisna_work")]
            internal static extern int LAPACKE_ddisna_work(sbyte job, int m, int n, double* d, double* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbbrd_work")]
            internal static extern int LAPACKE_sgbbrd_work(int matrix_layout, sbyte vect, int m, int n, int ncc, int kl, int ku, float* ab, int ldab, float* d, float* e, float* q,
                int ldq, float* pt, int ldpt, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbbrd_work")]
            internal static extern int LAPACKE_dgbbrd_work(int matrix_layout, sbyte vect, int m, int n, int ncc, int kl, int ku, double* ab, int ldab, double* d, double* e,
                double* q, int ldq, double* pt, int ldpt, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbcon_work")]
            internal static extern int LAPACKE_sgbcon_work(int matrix_layout, sbyte norm, int n, int kl, int ku, float* ab, int ldab, int* ipiv, float anorm, float* rcond,
                float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbcon_work")]
            internal static extern int LAPACKE_dgbcon_work(int matrix_layout, sbyte norm, int n, int kl, int ku, double* ab, int ldab, int* ipiv, double anorm, double* rcond,
                double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbequ_work")]
            internal static extern int LAPACKE_sgbequ_work(int matrix_layout, int m, int n, int kl, int ku, float* ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd,
                float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbequ_work")]
            internal static extern int LAPACKE_dgbequ_work(int matrix_layout, int m, int n, int kl, int ku, double* ab, int ldab, double* r, double* c, double* rowcnd,
                double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbequb_work")]
            internal static extern int LAPACKE_sgbequb_work(int matrix_layout, int m, int n, int kl, int ku, float* ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd,
                float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbequb_work")]
            internal static extern int LAPACKE_dgbequb_work(int matrix_layout, int m, int n, int kl, int ku, double* ab, int ldab, double* r, double* c, double* rowcnd,
                double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbrfs_work")]
            internal static extern int LAPACKE_sgbrfs_work(int matrix_layout, sbyte trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv,
                float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbrfs_work")]
            internal static extern int LAPACKE_dgbrfs_work(int matrix_layout, sbyte trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv,
                double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbrfsx_work")]
            internal static extern int LAPACKE_sgbrfsx_work(int matrix_layout, sbyte trans, sbyte equed, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb,
                int ldafb, int* ipiv, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm,
                float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbrfsx_work")]
            internal static extern int LAPACKE_dgbrfsx_work(int matrix_layout, sbyte trans, sbyte equed, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb,
                int ldafb, int* ipiv, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm,
                double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbsv_work")]
            internal static extern int LAPACKE_sgbsv_work(int matrix_layout, int n, int kl, int ku, int nrhs, float* ab, int ldab, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbsv_work")]
            internal static extern int LAPACKE_dgbsv_work(int matrix_layout, int n, int kl, int ku, int nrhs, double* ab, int ldab, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbsvx_work")]
            internal static extern int LAPACKE_sgbsvx_work(int matrix_layout, sbyte fact, sbyte trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb,
                int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbsvx_work")]
            internal static extern int LAPACKE_dgbsvx_work(int matrix_layout, sbyte fact, sbyte trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb,
                int ldafb, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbsvxx_work")]
            internal static extern int LAPACKE_sgbsvxx_work(int matrix_layout, sbyte fact, sbyte trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb,
                int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm,
                float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbsvxx_work")]
            internal static extern int LAPACKE_dgbsvxx_work(int matrix_layout, sbyte fact, sbyte trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb,
                int ldafb, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds,
                double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbtrf_work")]
            internal static extern int LAPACKE_sgbtrf_work(int matrix_layout, int m, int n, int kl, int ku, float* ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbtrf_work")]
            internal static extern int LAPACKE_dgbtrf_work(int matrix_layout, int m, int n, int kl, int ku, double* ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgbtrs_work")]
            internal static extern int LAPACKE_sgbtrs_work(int matrix_layout, sbyte trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgbtrs_work")]
            internal static extern int LAPACKE_dgbtrs_work(int matrix_layout, sbyte trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgebak_work")]
            internal static extern int LAPACKE_sgebak_work(int matrix_layout, sbyte job, sbyte side, int n, int ilo, int ihi, float* scale, int m, float* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgebak_work")]
            internal static extern int LAPACKE_dgebak_work(int matrix_layout, sbyte job, sbyte side, int n, int ilo, int ihi, double* scale, int m, double* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgebal_work")]
            internal static extern int LAPACKE_sgebal_work(int matrix_layout, sbyte job, int n, float* a, int lda, int* ilo, int* ihi, float* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgebal_work")]
            internal static extern int LAPACKE_dgebal_work(int matrix_layout, sbyte job, int n, double* a, int lda, int* ilo, int* ihi, double* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgebrd_work")]
            internal static extern int LAPACKE_sgebrd_work(int matrix_layout, int m, int n, float* a, int lda, float* d, float* e, float* tauq, float* taup, float* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgebrd_work")]
            internal static extern int LAPACKE_dgebrd_work(int matrix_layout, int m, int n, double* a, int lda, double* d, double* e, double* tauq, double* taup, double* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgecon_work")]
            internal static extern int LAPACKE_sgecon_work(int matrix_layout, sbyte norm, int n, float* a, int lda, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgecon_work")]
            internal static extern int LAPACKE_dgecon_work(int matrix_layout, sbyte norm, int n, double* a, int lda, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeequ_work")]
            internal static extern int LAPACKE_sgeequ_work(int matrix_layout, int m, int n, float* a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeequ_work")]
            internal static extern int LAPACKE_dgeequ_work(int matrix_layout, int m, int n, double* a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeequb_work")]
            internal static extern int LAPACKE_sgeequb_work(int matrix_layout, int m, int n, float* a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeequb_work")]
            internal static extern int LAPACKE_dgeequb_work(int matrix_layout, int m, int n, double* a, int lda, double* r, double* c, double* rowcnd, double* colcnd,
                double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgees_work")]
            internal static extern int LAPACKE_sgees_work(int matrix_layout, sbyte jobvs, sbyte sort, global::System.IntPtr select, int n, float* a, int lda, int* sdim, float* wr,
                float* wi, float* vs, int ldvs, float* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgees_work")]
            internal static extern int LAPACKE_dgees_work(int matrix_layout, sbyte jobvs, sbyte sort, global::System.IntPtr select, int n, double* a, int lda, int* sdim,
                double* wr, double* wi, double* vs, int ldvs, double* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeesx_work")]
            internal static extern int LAPACKE_sgeesx_work(int matrix_layout, sbyte jobvs, sbyte sort, global::System.IntPtr select, sbyte sense, int n, float* a, int lda,
                int* sdim, float* wr, float* wi, float* vs, int ldvs, float* rconde, float* rcondv, float* work, int lwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeesx_work")]
            internal static extern int LAPACKE_dgeesx_work(int matrix_layout, sbyte jobvs, sbyte sort, global::System.IntPtr select, sbyte sense, int n, double* a, int lda,
                int* sdim, double* wr, double* wi, double* vs, int ldvs, double* rconde, double* rcondv, double* work, int lwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeev_work")]
            internal static extern int LAPACKE_sgeev_work(int matrix_layout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* wr, float* wi, float* vl, int ldvl,
                float* vr, int ldvr, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeev_work")]
            internal static extern int LAPACKE_dgeev_work(int matrix_layout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* wr, double* wi, double* vl, int ldvl,
                double* vr, int ldvr, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeevx_work")]
            internal static extern int LAPACKE_sgeevx_work(int matrix_layout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, float* a, int lda, float* wr, float* wi,
                float* vl, int ldvl, float* vr, int ldvr, int* ilo, int* ihi, float* scale, float* abnrm, float* rconde, float* rcondv, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeevx_work")]
            internal static extern int LAPACKE_dgeevx_work(int matrix_layout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, double* a, int lda, double* wr,
                double* wi, double* vl, int ldvl, double* vr, int ldvr, int* ilo, int* ihi, double* scale, double* abnrm, double* rconde, double* rcondv, double* work, int lwork,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgehrd_work")]
            internal static extern int LAPACKE_sgehrd_work(int matrix_layout, int n, int ilo, int ihi, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgehrd_work")]
            internal static extern int LAPACKE_dgehrd_work(int matrix_layout, int n, int ilo, int ihi, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgejsv_work")]
            internal static extern int LAPACKE_sgejsv_work(int matrix_layout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, float* a,
                int lda, float* sva, float* u, int ldu, float* v, int ldv, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgejsv_work")]
            internal static extern int LAPACKE_dgejsv_work(int matrix_layout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, double* a,
                int lda, double* sva, double* u, int ldu, double* v, int ldv, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelq2_work")]
            internal static extern int LAPACKE_sgelq2_work(int matrix_layout, int m, int n, float* a, int lda, float* tau, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelq2_work")]
            internal static extern int LAPACKE_dgelq2_work(int matrix_layout, int m, int n, double* a, int lda, double* tau, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelqf_work")]
            internal static extern int LAPACKE_sgelqf_work(int matrix_layout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelqf_work")]
            internal static extern int LAPACKE_dgelqf_work(int matrix_layout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgels_work")]
            internal static extern int LAPACKE_sgels_work(int matrix_layout, sbyte trans, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgels_work")]
            internal static extern int LAPACKE_dgels_work(int matrix_layout, sbyte trans, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelsd_work")]
            internal static extern int LAPACKE_sgelsd_work(int matrix_layout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* s, float rcond, int* rank,
                float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelsd_work")]
            internal static extern int LAPACKE_dgelsd_work(int matrix_layout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* s, double rcond, int* rank,
                double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelss_work")]
            internal static extern int LAPACKE_sgelss_work(int matrix_layout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* s, float rcond, int* rank,
                float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelss_work")]
            internal static extern int LAPACKE_dgelss_work(int matrix_layout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* s, double rcond, int* rank,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelsy_work")]
            internal static extern int LAPACKE_sgelsy_work(int matrix_layout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, int* jpvt, float rcond, int* rank,
                float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelsy_work")]
            internal static extern int LAPACKE_dgelsy_work(int matrix_layout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, int* jpvt, double rcond, int* rank,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqlf_work")]
            internal static extern int LAPACKE_sgeqlf_work(int matrix_layout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqlf_work")]
            internal static extern int LAPACKE_dgeqlf_work(int matrix_layout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqp3_work")]
            internal static extern int LAPACKE_sgeqp3_work(int matrix_layout, int m, int n, float* a, int lda, int* jpvt, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqp3_work")]
            internal static extern int LAPACKE_dgeqp3_work(int matrix_layout, int m, int n, double* a, int lda, int* jpvt, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqpf_work")]
            internal static extern int LAPACKE_sgeqpf_work(int matrix_layout, int m, int n, float* a, int lda, int* jpvt, float* tau, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqpf_work")]
            internal static extern int LAPACKE_dgeqpf_work(int matrix_layout, int m, int n, double* a, int lda, int* jpvt, double* tau, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqr2_work")]
            internal static extern int LAPACKE_sgeqr2_work(int matrix_layout, int m, int n, float* a, int lda, float* tau, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqr2_work")]
            internal static extern int LAPACKE_dgeqr2_work(int matrix_layout, int m, int n, double* a, int lda, double* tau, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqrf_work")]
            internal static extern int LAPACKE_sgeqrf_work(int matrix_layout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqrf_work")]
            internal static extern int LAPACKE_dgeqrf_work(int matrix_layout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqrfp_work")]
            internal static extern int LAPACKE_sgeqrfp_work(int matrix_layout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqrfp_work")]
            internal static extern int LAPACKE_dgeqrfp_work(int matrix_layout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgerfs_work")]
            internal static extern int LAPACKE_sgerfs_work(int matrix_layout, sbyte trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb,
                float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgerfs_work")]
            internal static extern int LAPACKE_dgerfs_work(int matrix_layout, sbyte trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb,
                double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgerfsx_work")]
            internal static extern int LAPACKE_sgerfsx_work(int matrix_layout, sbyte trans, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv,
                float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams,
                float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgerfsx_work")]
            internal static extern int LAPACKE_dgerfsx_work(int matrix_layout, sbyte trans, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv,
                double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp,
                int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgerqf_work")]
            internal static extern int LAPACKE_sgerqf_work(int matrix_layout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgerqf_work")]
            internal static extern int LAPACKE_dgerqf_work(int matrix_layout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesdd_work")]
            internal static extern int LAPACKE_sgesdd_work(int matrix_layout, sbyte jobz, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* vt, int ldvt,
                float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesdd_work")]
            internal static extern int LAPACKE_dgesdd_work(int matrix_layout, sbyte jobz, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* vt, int ldvt,
                double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesv_work")]
            internal static extern int LAPACKE_sgesv_work(int matrix_layout, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesv_work")]
            internal static extern int LAPACKE_dgesv_work(int matrix_layout, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsgesv_work")]
            internal static extern int LAPACKE_dsgesv_work(int matrix_layout, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* x, int ldx, double* work,
                float* swork, int* iter);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvd_work")]
            internal static extern int LAPACKE_sgesvd_work(int matrix_layout, sbyte jobu, sbyte jobvt, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* vt,
                int ldvt, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvd_work")]
            internal static extern int LAPACKE_dgesvd_work(int matrix_layout, sbyte jobu, sbyte jobvt, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* vt,
                int ldvt, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvdx_work")]
            internal static extern int LAPACKE_sgesvdx_work(int matrix_layout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, float* a, int lda, float vl, float vu, int il,
                int iu, int* ns, float* s, float* u, int ldu, float* vt, int ldvt, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvdx_work")]
            internal static extern int LAPACKE_dgesvdx_work(int matrix_layout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, double* a, int lda, double vl, double vu, int il,
                int iu, int* ns, double* s, double* u, int ldu, double* vt, int ldvt, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvdq_work")]
            internal static extern int LAPACKE_sgesvdq_work(int matrix_layout, sbyte joba, sbyte jobp, sbyte jobr, sbyte jobu, sbyte jobv, int m, int n, float* a, int lda,
                float* s, float* u, int ldu, float* v, int ldv, int* numrank, int* iwork, int liwork, float* work, int lwork, float* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvdq_work")]
            internal static extern int LAPACKE_dgesvdq_work(int matrix_layout, sbyte joba, sbyte jobp, sbyte jobr, sbyte jobu, sbyte jobv, int m, int n, double* a, int lda,
                double* s, double* u, int ldu, double* v, int ldv, int* numrank, int* iwork, int liwork, double* work, int lwork, double* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvj_work")]
            internal static extern int LAPACKE_sgesvj_work(int matrix_layout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, float* a, int lda, float* sva, int mv, float* v,
                int ldv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvj_work")]
            internal static extern int LAPACKE_dgesvj_work(int matrix_layout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, double* a, int lda, double* sva, int mv, double* v,
                int ldv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvx_work")]
            internal static extern int LAPACKE_sgesvx_work(int matrix_layout, sbyte fact, sbyte trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv,
                sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvx_work")]
            internal static extern int LAPACKE_dgesvx_work(int matrix_layout, sbyte fact, sbyte trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv,
                sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgesvxx_work")]
            internal static extern int LAPACKE_sgesvxx_work(int matrix_layout, sbyte fact, sbyte trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv,
                sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm,
                float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgesvxx_work")]
            internal static extern int LAPACKE_dgesvxx_work(int matrix_layout, sbyte fact, sbyte trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv,
                sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm,
                double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetf2_work")]
            internal static extern int LAPACKE_sgetf2_work(int matrix_layout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetf2_work")]
            internal static extern int LAPACKE_dgetf2_work(int matrix_layout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetrf_work")]
            internal static extern int LAPACKE_sgetrf_work(int matrix_layout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetrf_work")]
            internal static extern int LAPACKE_dgetrf_work(int matrix_layout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetrf2_work")]
            internal static extern int LAPACKE_sgetrf2_work(int matrix_layout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetrf2_work")]
            internal static extern int LAPACKE_dgetrf2_work(int matrix_layout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetri_work")]
            internal static extern int LAPACKE_sgetri_work(int matrix_layout, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetri_work")]
            internal static extern int LAPACKE_dgetri_work(int matrix_layout, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetrs_work")]
            internal static extern int LAPACKE_sgetrs_work(int matrix_layout, sbyte trans, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetrs_work")]
            internal static extern int LAPACKE_dgetrs_work(int matrix_layout, sbyte trans, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggbak_work")]
            internal static extern int LAPACKE_sggbak_work(int matrix_layout, sbyte job, sbyte side, int n, int ilo, int ihi, float* lscale, float* rscale, int m, float* v,
                int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggbak_work")]
            internal static extern int LAPACKE_dggbak_work(int matrix_layout, sbyte job, sbyte side, int n, int ilo, int ihi, double* lscale, double* rscale, int m, double* v,
                int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggbal_work")]
            internal static extern int LAPACKE_sggbal_work(int matrix_layout, sbyte job, int n, float* a, int lda, float* b, int ldb, int* ilo, int* ihi, float* lscale,
                float* rscale, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggbal_work")]
            internal static extern int LAPACKE_dggbal_work(int matrix_layout, sbyte job, int n, double* a, int lda, double* b, int ldb, int* ilo, int* ihi, double* lscale,
                double* rscale, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgges_work")]
            internal static extern int LAPACKE_sgges_work(int matrix_layout, sbyte jobvsl, sbyte jobvsr, sbyte sort, global::System.IntPtr selctg, int n, float* a, int lda,
                float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr, float* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgges_work")]
            internal static extern int LAPACKE_dgges_work(int matrix_layout, sbyte jobvsl, sbyte jobvsr, sbyte sort, global::System.IntPtr selctg, int n, double* a, int lda,
                double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr, double* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgges3_work")]
            internal static extern int LAPACKE_sgges3_work(int matrix_layout, sbyte jobvsl, sbyte jobvsr, sbyte sort, global::System.IntPtr selctg, int n, float* a, int lda,
                float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr, float* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgges3_work")]
            internal static extern int LAPACKE_dgges3_work(int matrix_layout, sbyte jobvsl, sbyte jobvsr, sbyte sort, global::System.IntPtr selctg, int n, double* a, int lda,
                double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr, double* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggesx_work")]
            internal static extern int LAPACKE_sggesx_work(int matrix_layout, sbyte jobvsl, sbyte jobvsr, sbyte sort, global::System.IntPtr selctg, sbyte sense, int n, float* a,
                int lda, float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr, float* rconde, float* rcondv,
                float* work, int lwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggesx_work")]
            internal static extern int LAPACKE_dggesx_work(int matrix_layout, sbyte jobvsl, sbyte jobvsr, sbyte sort, global::System.IntPtr selctg, sbyte sense, int n, double* a,
                int lda, double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr, double* rconde,
                double* rcondv, double* work, int lwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggev_work")]
            internal static extern int LAPACKE_sggev_work(int matrix_layout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai,
                float* beta, float* vl, int ldvl, float* vr, int ldvr, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggev_work")]
            internal static extern int LAPACKE_dggev_work(int matrix_layout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* b, int ldb, double* alphar,
                double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggev3_work")]
            internal static extern int LAPACKE_sggev3_work(int matrix_layout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai,
                float* beta, float* vl, int ldvl, float* vr, int ldvr, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggev3_work")]
            internal static extern int LAPACKE_dggev3_work(int matrix_layout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* b, int ldb, double* alphar,
                double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggevx_work")]
            internal static extern int LAPACKE_sggevx_work(int matrix_layout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, float* a, int lda, float* b, int ldb,
                float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr, int* ilo, int* ihi, float* lscale, float* rscale, float* abnrm, float* bbnrm,
                float* rconde, float* rcondv, float* work, int lwork, int* iwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggevx_work")]
            internal static extern int LAPACKE_dggevx_work(int matrix_layout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, double* a, int lda, double* b, int ldb,
                double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr, int* ilo, int* ihi, double* lscale, double* rscale, double* abnrm,
                double* bbnrm, double* rconde, double* rcondv, double* work, int lwork, int* iwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggglm_work")]
            internal static extern int LAPACKE_sggglm_work(int matrix_layout, int n, int m, int p, float* a, int lda, float* b, int ldb, float* d, float* x, float* y, float* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggglm_work")]
            internal static extern int LAPACKE_dggglm_work(int matrix_layout, int n, int m, int p, double* a, int lda, double* b, int ldb, double* d, double* x, double* y,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgghrd_work")]
            internal static extern int LAPACKE_sgghrd_work(int matrix_layout, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* a, int lda, float* b, int ldb, float* q,
                int ldq, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgghrd_work")]
            internal static extern int LAPACKE_dgghrd_work(int matrix_layout, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* a, int lda, double* b, int ldb, double* q,
                int ldq, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgghd3_work")]
            internal static extern int LAPACKE_sgghd3_work(int matrix_layout, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* a, int lda, float* b, int ldb, float* q,
                int ldq, float* z, int ldz, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgghd3_work")]
            internal static extern int LAPACKE_dgghd3_work(int matrix_layout, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* a, int lda, double* b, int ldb, double* q,
                int ldq, double* z, int ldz, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgglse_work")]
            internal static extern int LAPACKE_sgglse_work(int matrix_layout, int m, int n, int p, float* a, int lda, float* b, int ldb, float* c, float* d, float* x, float* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgglse_work")]
            internal static extern int LAPACKE_dgglse_work(int matrix_layout, int m, int n, int p, double* a, int lda, double* b, int ldb, double* c, double* d, double* x,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggqrf_work")]
            internal static extern int LAPACKE_sggqrf_work(int matrix_layout, int n, int m, int p, float* a, int lda, float* taua, float* b, int ldb, float* taub, float* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggqrf_work")]
            internal static extern int LAPACKE_dggqrf_work(int matrix_layout, int n, int m, int p, double* a, int lda, double* taua, double* b, int ldb, double* taub, double* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggrqf_work")]
            internal static extern int LAPACKE_sggrqf_work(int matrix_layout, int m, int p, int n, float* a, int lda, float* taua, float* b, int ldb, float* taub, float* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggrqf_work")]
            internal static extern int LAPACKE_dggrqf_work(int matrix_layout, int m, int p, int n, double* a, int lda, double* taua, double* b, int ldb, double* taub, double* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggsvd_work")]
            internal static extern int LAPACKE_sggsvd_work(int matrix_layout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, float* a, int lda, float* b,
                int ldb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggsvd_work")]
            internal static extern int LAPACKE_dggsvd_work(int matrix_layout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, double* a, int lda,
                double* b, int ldb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggsvd3_work")]
            internal static extern int LAPACKE_sggsvd3_work(int matrix_layout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, float* a, int lda, float* b,
                int ldb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggsvd3_work")]
            internal static extern int LAPACKE_dggsvd3_work(int matrix_layout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, double* a, int lda,
                double* b, int ldb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggsvp_work")]
            internal static extern int LAPACKE_sggsvp_work(int matrix_layout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, float* a, int lda, float* b, int ldb,
                float tola, float tolb, int* k, int* l, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* iwork, float* tau, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggsvp_work")]
            internal static extern int LAPACKE_dggsvp_work(int matrix_layout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, double* a, int lda, double* b, int ldb,
                double tola, double tolb, int* k, int* l, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* iwork, double* tau, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sggsvp3_work")]
            internal static extern int LAPACKE_sggsvp3_work(int matrix_layout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, float* a, int lda, float* b, int ldb,
                float tola, float tolb, int* k, int* l, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* iwork, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dggsvp3_work")]
            internal static extern int LAPACKE_dggsvp3_work(int matrix_layout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, double* a, int lda, double* b, int ldb,
                double tola, double tolb, int* k, int* l, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* iwork, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgtcon_work")]
            internal static extern int LAPACKE_sgtcon_work(sbyte norm, int n, float* dl, float* d, float* du, float* du2, int* ipiv, float anorm, float* rcond, float* work,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgtcon_work")]
            internal static extern int LAPACKE_dgtcon_work(sbyte norm, int n, double* dl, double* d, double* du, double* du2, int* ipiv, double anorm, double* rcond, double* work,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgtrfs_work")]
            internal static extern int LAPACKE_sgtrfs_work(int matrix_layout, sbyte trans, int n, int nrhs, float* dl, float* d, float* du, float* dlf, float* df, float* duf,
                float* du2, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgtrfs_work")]
            internal static extern int LAPACKE_dgtrfs_work(int matrix_layout, sbyte trans, int n, int nrhs, double* dl, double* d, double* du, double* dlf, double* df, double* duf,
                double* du2, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgtsv_work")]
            internal static extern int LAPACKE_sgtsv_work(int matrix_layout, int n, int nrhs, float* dl, float* d, float* du, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgtsv_work")]
            internal static extern int LAPACKE_dgtsv_work(int matrix_layout, int n, int nrhs, double* dl, double* d, double* du, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgtsvx_work")]
            internal static extern int LAPACKE_sgtsvx_work(int matrix_layout, sbyte fact, sbyte trans, int n, int nrhs, float* dl, float* d, float* du, float* dlf, float* df,
                float* duf, float* du2, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgtsvx_work")]
            internal static extern int LAPACKE_dgtsvx_work(int matrix_layout, sbyte fact, sbyte trans, int n, int nrhs, double* dl, double* d, double* du, double* dlf, double* df,
                double* duf, double* du2, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgttrf_work")]
            internal static extern int LAPACKE_sgttrf_work(int n, float* dl, float* d, float* du, float* du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgttrf_work")]
            internal static extern int LAPACKE_dgttrf_work(int n, double* dl, double* d, double* du, double* du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgttrs_work")]
            internal static extern int LAPACKE_sgttrs_work(int matrix_layout, sbyte trans, int n, int nrhs, float* dl, float* d, float* du, float* du2, int* ipiv, float* b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgttrs_work")]
            internal static extern int LAPACKE_dgttrs_work(int matrix_layout, sbyte trans, int n, int nrhs, double* dl, double* d, double* du, double* du2, int* ipiv, double* b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_shgeqz_work")]
            internal static extern int LAPACKE_shgeqz_work(int matrix_layout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* h, int ldh, float* t, int ldt,
                float* alphar, float* alphai, float* beta, float* q, int ldq, float* z, int ldz, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dhgeqz_work")]
            internal static extern int LAPACKE_dhgeqz_work(int matrix_layout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* h, int ldh, double* t, int ldt,
                double* alphar, double* alphai, double* beta, double* q, int ldq, double* z, int ldz, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_shsein_work")]
            internal static extern int LAPACKE_shsein_work(int matrix_layout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, float* h, int ldh, float* wr, float* wi,
                float* vl, int ldvl, float* vr, int ldvr, int mm, int* m, float* work, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dhsein_work")]
            internal static extern int LAPACKE_dhsein_work(int matrix_layout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, double* h, int ldh, double* wr, double* wi,
                double* vl, int ldvl, double* vr, int ldvr, int mm, int* m, double* work, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_shseqr_work")]
            internal static extern int LAPACKE_shseqr_work(int matrix_layout, sbyte job, sbyte compz, int n, int ilo, int ihi, float* h, int ldh, float* wr, float* wi, float* z,
                int ldz, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dhseqr_work")]
            internal static extern int LAPACKE_dhseqr_work(int matrix_layout, sbyte job, sbyte compz, int n, int ilo, int ihi, double* h, int ldh, double* wr, double* wi,
                double* z, int ldz, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slacn2_work")]
            internal static extern int LAPACKE_slacn2_work(int n, float* v, float* x, int* isgn, float* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlacn2_work")]
            internal static extern int LAPACKE_dlacn2_work(int n, double* v, double* x, int* isgn, double* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slacpy_work")]
            internal static extern int LAPACKE_slacpy_work(int matrix_layout, sbyte uplo, int m, int n, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlacpy_work")]
            internal static extern int LAPACKE_dlacpy_work(int matrix_layout, sbyte uplo, int m, int n, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slag2d_work")]
            internal static extern int LAPACKE_slag2d_work(int matrix_layout, int m, int n, float* sa, int ldsa, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlag2s_work")]
            internal static extern int LAPACKE_dlag2s_work(int matrix_layout, int m, int n, double* a, int lda, float* sa, int ldsa);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slagge_work")]
            internal static extern int LAPACKE_slagge_work(int matrix_layout, int m, int n, int kl, int ku, float* d, float* a, int lda, int* iseed, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlagge_work")]
            internal static extern int LAPACKE_dlagge_work(int matrix_layout, int m, int n, int kl, int ku, double* d, double* a, int lda, int* iseed, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slagsy_work")]
            internal static extern int LAPACKE_slagsy_work(int matrix_layout, int n, int k, float* d, float* a, int lda, int* iseed, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlagsy_work")]
            internal static extern int LAPACKE_dlagsy_work(int matrix_layout, int n, int k, double* d, double* a, int lda, int* iseed, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slapmr_work")]
            internal static extern int LAPACKE_slapmr_work(int matrix_layout, int forwrd, int m, int n, float* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlapmr_work")]
            internal static extern int LAPACKE_dlapmr_work(int matrix_layout, int forwrd, int m, int n, double* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slapmt_work")]
            internal static extern int LAPACKE_slapmt_work(int matrix_layout, int forwrd, int m, int n, float* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlapmt_work")]
            internal static extern int LAPACKE_dlapmt_work(int matrix_layout, int forwrd, int m, int n, double* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slartgp_work")]
            internal static extern int LAPACKE_slartgp_work(float f, float g, float* cs, float* sn, float* r);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlartgp_work")]
            internal static extern int LAPACKE_dlartgp_work(double f, double g, double* cs, double* sn, double* r);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slartgs_work")]
            internal static extern int LAPACKE_slartgs_work(float x, float y, float sigma, float* cs, float* sn);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlartgs_work")]
            internal static extern int LAPACKE_dlartgs_work(double x, double y, double sigma, double* cs, double* sn);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slapy2_work")]
            internal static extern float LAPACKE_slapy2_work(float x, float y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlapy2_work")]
            internal static extern double LAPACKE_dlapy2_work(double x, double y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slapy3_work")]
            internal static extern float LAPACKE_slapy3_work(float x, float y, float z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlapy3_work")]
            internal static extern double LAPACKE_dlapy3_work(double x, double y, double z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slamch_work")]
            internal static extern float LAPACKE_slamch_work(sbyte cmach);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlamch_work")]
            internal static extern double LAPACKE_dlamch_work(sbyte cmach);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slange_work")]
            internal static extern float LAPACKE_slange_work(int matrix_layout, sbyte norm, int m, int n, float* a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlange_work")]
            internal static extern double LAPACKE_dlange_work(int matrix_layout, sbyte norm, int m, int n, double* a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slansy_work")]
            internal static extern float LAPACKE_slansy_work(int matrix_layout, sbyte norm, sbyte uplo, int n, float* a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlansy_work")]
            internal static extern double LAPACKE_dlansy_work(int matrix_layout, sbyte norm, sbyte uplo, int n, double* a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slantr_work")]
            internal static extern float LAPACKE_slantr_work(int matrix_layout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, float* a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlantr_work")]
            internal static extern double LAPACKE_dlantr_work(int matrix_layout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, double* a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slarfb_work")]
            internal static extern int LAPACKE_slarfb_work(int matrix_layout, sbyte side, sbyte trans, sbyte direct, sbyte storev, int m, int n, int k, float* v, int ldv, float* t,
                int ldt, float* c, int ldc, float* work, int ldwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlarfb_work")]
            internal static extern int LAPACKE_dlarfb_work(int matrix_layout, sbyte side, sbyte trans, sbyte direct, sbyte storev, int m, int n, int k, double* v, int ldv,
                double* t, int ldt, double* c, int ldc, double* work, int ldwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slarfg_work")]
            internal static extern int LAPACKE_slarfg_work(int n, float* alpha, float* x, int incx, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlarfg_work")]
            internal static extern int LAPACKE_dlarfg_work(int n, double* alpha, double* x, int incx, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slarft_work")]
            internal static extern int LAPACKE_slarft_work(int matrix_layout, sbyte direct, sbyte storev, int n, int k, float* v, int ldv, float* tau, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlarft_work")]
            internal static extern int LAPACKE_dlarft_work(int matrix_layout, sbyte direct, sbyte storev, int n, int k, double* v, int ldv, double* tau, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slarfx_work")]
            internal static extern int LAPACKE_slarfx_work(int matrix_layout, sbyte side, int m, int n, float* v, float tau, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlarfx_work")]
            internal static extern int LAPACKE_dlarfx_work(int matrix_layout, sbyte side, int m, int n, double* v, double tau, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slarnv_work")]
            internal static extern int LAPACKE_slarnv_work(int idist, int* iseed, int n, float* x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlarnv_work")]
            internal static extern int LAPACKE_dlarnv_work(int idist, int* iseed, int n, double* x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slascl_work")]
            internal static extern int LAPACKE_slascl_work(int matrix_layout, sbyte type, int kl, int ku, float cfrom, float cto, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlascl_work")]
            internal static extern int LAPACKE_dlascl_work(int matrix_layout, sbyte type, int kl, int ku, double cfrom, double cto, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slaset_work")]
            internal static extern int LAPACKE_slaset_work(int matrix_layout, sbyte uplo, int m, int n, float alpha, float beta, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlaset_work")]
            internal static extern int LAPACKE_dlaset_work(int matrix_layout, sbyte uplo, int m, int n, double alpha, double beta, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slasrt_work")]
            internal static extern int LAPACKE_slasrt_work(sbyte id, int n, float* d);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlasrt_work")]
            internal static extern int LAPACKE_dlasrt_work(sbyte id, int n, double* d);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slassq_work")]
            internal static extern int LAPACKE_slassq_work(int n, float* x, int incx, float* scale, float* sumsq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlassq_work")]
            internal static extern int LAPACKE_dlassq_work(int n, double* x, int incx, double* scale, double* sumsq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slaswp_work")]
            internal static extern int LAPACKE_slaswp_work(int matrix_layout, int n, float* a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlaswp_work")]
            internal static extern int LAPACKE_dlaswp_work(int matrix_layout, int n, double* a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slatms_work")]
            internal static extern int LAPACKE_slatms_work(int matrix_layout, int m, int n, sbyte dist, int* iseed, sbyte sym, float* d, int mode, float cond, float dmax, int kl,
                int ku, sbyte pack, float* a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlatms_work")]
            internal static extern int LAPACKE_dlatms_work(int matrix_layout, int m, int n, sbyte dist, int* iseed, sbyte sym, double* d, int mode, double cond, double dmax,
                int kl, int ku, sbyte pack, double* a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slauum_work")]
            internal static extern int LAPACKE_slauum_work(int matrix_layout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlauum_work")]
            internal static extern int LAPACKE_dlauum_work(int matrix_layout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sopgtr_work")]
            internal static extern int LAPACKE_sopgtr_work(int matrix_layout, sbyte uplo, int n, float* ap, float* tau, float* q, int ldq, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dopgtr_work")]
            internal static extern int LAPACKE_dopgtr_work(int matrix_layout, sbyte uplo, int n, double* ap, double* tau, double* q, int ldq, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sopmtr_work")]
            internal static extern int LAPACKE_sopmtr_work(int matrix_layout, sbyte side, sbyte uplo, sbyte trans, int m, int n, float* ap, float* tau, float* c, int ldc,
                float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dopmtr_work")]
            internal static extern int LAPACKE_dopmtr_work(int matrix_layout, sbyte side, sbyte uplo, sbyte trans, int m, int n, double* ap, double* tau, double* c, int ldc,
                double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorgbr_work")]
            internal static extern int LAPACKE_sorgbr_work(int matrix_layout, sbyte vect, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorgbr_work")]
            internal static extern int LAPACKE_dorgbr_work(int matrix_layout, sbyte vect, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorghr_work")]
            internal static extern int LAPACKE_sorghr_work(int matrix_layout, int n, int ilo, int ihi, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorghr_work")]
            internal static extern int LAPACKE_dorghr_work(int matrix_layout, int n, int ilo, int ihi, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorglq_work")]
            internal static extern int LAPACKE_sorglq_work(int matrix_layout, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorglq_work")]
            internal static extern int LAPACKE_dorglq_work(int matrix_layout, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorgql_work")]
            internal static extern int LAPACKE_sorgql_work(int matrix_layout, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorgql_work")]
            internal static extern int LAPACKE_dorgql_work(int matrix_layout, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorgqr_work")]
            internal static extern int LAPACKE_sorgqr_work(int matrix_layout, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorgqr_work")]
            internal static extern int LAPACKE_dorgqr_work(int matrix_layout, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorgrq_work")]
            internal static extern int LAPACKE_sorgrq_work(int matrix_layout, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorgrq_work")]
            internal static extern int LAPACKE_dorgrq_work(int matrix_layout, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorgtr_work")]
            internal static extern int LAPACKE_sorgtr_work(int matrix_layout, sbyte uplo, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorgtr_work")]
            internal static extern int LAPACKE_dorgtr_work(int matrix_layout, sbyte uplo, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormbr_work")]
            internal static extern int LAPACKE_sormbr_work(int matrix_layout, sbyte vect, sbyte side, sbyte trans, int m, int n, int k, float* a, int lda, float* tau, float* c,
                int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormbr_work")]
            internal static extern int LAPACKE_dormbr_work(int matrix_layout, sbyte vect, sbyte side, sbyte trans, int m, int n, int k, double* a, int lda, double* tau, double* c,
                int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormhr_work")]
            internal static extern int LAPACKE_sormhr_work(int matrix_layout, sbyte side, sbyte trans, int m, int n, int ilo, int ihi, float* a, int lda, float* tau, float* c,
                int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormhr_work")]
            internal static extern int LAPACKE_dormhr_work(int matrix_layout, sbyte side, sbyte trans, int m, int n, int ilo, int ihi, double* a, int lda, double* tau, double* c,
                int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormlq_work")]
            internal static extern int LAPACKE_sormlq_work(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc,
                float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormlq_work")]
            internal static extern int LAPACKE_dormlq_work(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormql_work")]
            internal static extern int LAPACKE_sormql_work(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc,
                float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormql_work")]
            internal static extern int LAPACKE_dormql_work(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormqr_work")]
            internal static extern int LAPACKE_sormqr_work(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc,
                float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormqr_work")]
            internal static extern int LAPACKE_dormqr_work(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormrq_work")]
            internal static extern int LAPACKE_sormrq_work(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc,
                float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormrq_work")]
            internal static extern int LAPACKE_dormrq_work(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormrz_work")]
            internal static extern int LAPACKE_sormrz_work(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, int l, float* a, int lda, float* tau, float* c, int ldc,
                float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormrz_work")]
            internal static extern int LAPACKE_dormrz_work(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, int l, double* a, int lda, double* tau, double* c,
                int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sormtr_work")]
            internal static extern int LAPACKE_sormtr_work(int matrix_layout, sbyte side, sbyte uplo, sbyte trans, int m, int n, float* a, int lda, float* tau, float* c, int ldc,
                float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dormtr_work")]
            internal static extern int LAPACKE_dormtr_work(int matrix_layout, sbyte side, sbyte uplo, sbyte trans, int m, int n, double* a, int lda, double* tau, double* c,
                int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbcon_work")]
            internal static extern int LAPACKE_spbcon_work(int matrix_layout, sbyte uplo, int n, int kd, float* ab, int ldab, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbcon_work")]
            internal static extern int LAPACKE_dpbcon_work(int matrix_layout, sbyte uplo, int n, int kd, double* ab, int ldab, double anorm, double* rcond, double* work,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbequ_work")]
            internal static extern int LAPACKE_spbequ_work(int matrix_layout, sbyte uplo, int n, int kd, float* ab, int ldab, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbequ_work")]
            internal static extern int LAPACKE_dpbequ_work(int matrix_layout, sbyte uplo, int n, int kd, double* ab, int ldab, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbrfs_work")]
            internal static extern int LAPACKE_spbrfs_work(int matrix_layout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* afb, int ldafb, float* b, int ldb,
                float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbrfs_work")]
            internal static extern int LAPACKE_dpbrfs_work(int matrix_layout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* afb, int ldafb, double* b, int ldb,
                double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbstf_work")]
            internal static extern int LAPACKE_spbstf_work(int matrix_layout, sbyte uplo, int n, int kb, float* bb, int ldbb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbstf_work")]
            internal static extern int LAPACKE_dpbstf_work(int matrix_layout, sbyte uplo, int n, int kb, double* bb, int ldbb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbsv_work")]
            internal static extern int LAPACKE_spbsv_work(int matrix_layout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbsv_work")]
            internal static extern int LAPACKE_dpbsv_work(int matrix_layout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbsvx_work")]
            internal static extern int LAPACKE_spbsvx_work(int matrix_layout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* afb, int ldafb,
                sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbsvx_work")]
            internal static extern int LAPACKE_dpbsvx_work(int matrix_layout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* afb, int ldafb,
                sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbtrf_work")]
            internal static extern int LAPACKE_spbtrf_work(int matrix_layout, sbyte uplo, int n, int kd, float* ab, int ldab);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbtrf_work")]
            internal static extern int LAPACKE_dpbtrf_work(int matrix_layout, sbyte uplo, int n, int kd, double* ab, int ldab);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spbtrs_work")]
            internal static extern int LAPACKE_spbtrs_work(int matrix_layout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpbtrs_work")]
            internal static extern int LAPACKE_dpbtrs_work(int matrix_layout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spftrf_work")]
            internal static extern int LAPACKE_spftrf_work(int matrix_layout, sbyte transr, sbyte uplo, int n, float* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpftrf_work")]
            internal static extern int LAPACKE_dpftrf_work(int matrix_layout, sbyte transr, sbyte uplo, int n, double* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spftri_work")]
            internal static extern int LAPACKE_spftri_work(int matrix_layout, sbyte transr, sbyte uplo, int n, float* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpftri_work")]
            internal static extern int LAPACKE_dpftri_work(int matrix_layout, sbyte transr, sbyte uplo, int n, double* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spftrs_work")]
            internal static extern int LAPACKE_spftrs_work(int matrix_layout, sbyte transr, sbyte uplo, int n, int nrhs, float* a, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpftrs_work")]
            internal static extern int LAPACKE_dpftrs_work(int matrix_layout, sbyte transr, sbyte uplo, int n, int nrhs, double* a, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spocon_work")]
            internal static extern int LAPACKE_spocon_work(int matrix_layout, sbyte uplo, int n, float* a, int lda, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpocon_work")]
            internal static extern int LAPACKE_dpocon_work(int matrix_layout, sbyte uplo, int n, double* a, int lda, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spoequ_work")]
            internal static extern int LAPACKE_spoequ_work(int matrix_layout, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpoequ_work")]
            internal static extern int LAPACKE_dpoequ_work(int matrix_layout, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spoequb_work")]
            internal static extern int LAPACKE_spoequb_work(int matrix_layout, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpoequb_work")]
            internal static extern int LAPACKE_dpoequb_work(int matrix_layout, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sporfs_work")]
            internal static extern int LAPACKE_sporfs_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, float* b, int ldb, float* x,
                int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dporfs_work")]
            internal static extern int LAPACKE_dporfs_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, double* b, int ldb, double* x,
                int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sporfsx_work")]
            internal static extern int LAPACKE_sporfsx_work(int matrix_layout, sbyte uplo, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, float* s, float* b,
                int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dporfsx_work")]
            internal static extern int LAPACKE_dporfsx_work(int matrix_layout, sbyte uplo, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, double* s,
                double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params,
                double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sposv_work")]
            internal static extern int LAPACKE_sposv_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dposv_work")]
            internal static extern int LAPACKE_dposv_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsposv_work")]
            internal static extern int LAPACKE_dsposv_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb, double* x, int ldx, double* work,
                float* swork, int* iter);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sposvx_work")]
            internal static extern int LAPACKE_sposvx_work(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, sbyte* equed,
                float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dposvx_work")]
            internal static extern int LAPACKE_dposvx_work(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, sbyte* equed,
                double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sposvxx_work")]
            internal static extern int LAPACKE_sposvxx_work(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, sbyte* equed,
                float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams,
                float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dposvxx_work")]
            internal static extern int LAPACKE_dposvxx_work(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, sbyte* equed,
                double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp,
                int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spotrf2_work")]
            internal static extern int LAPACKE_spotrf2_work(int matrix_layout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpotrf2_work")]
            internal static extern int LAPACKE_dpotrf2_work(int matrix_layout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spotrf_work")]
            internal static extern int LAPACKE_spotrf_work(int matrix_layout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpotrf_work")]
            internal static extern int LAPACKE_dpotrf_work(int matrix_layout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spotri_work")]
            internal static extern int LAPACKE_spotri_work(int matrix_layout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpotri_work")]
            internal static extern int LAPACKE_dpotri_work(int matrix_layout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spotrs_work")]
            internal static extern int LAPACKE_spotrs_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpotrs_work")]
            internal static extern int LAPACKE_dpotrs_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sppcon_work")]
            internal static extern int LAPACKE_sppcon_work(int matrix_layout, sbyte uplo, int n, float* ap, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dppcon_work")]
            internal static extern int LAPACKE_dppcon_work(int matrix_layout, sbyte uplo, int n, double* ap, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sppequ_work")]
            internal static extern int LAPACKE_sppequ_work(int matrix_layout, sbyte uplo, int n, float* ap, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dppequ_work")]
            internal static extern int LAPACKE_dppequ_work(int matrix_layout, sbyte uplo, int n, double* ap, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spprfs_work")]
            internal static extern int LAPACKE_spprfs_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* ap, float* afp, float* b, int ldb, float* x, int ldx, float* ferr,
                float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpprfs_work")]
            internal static extern int LAPACKE_dpprfs_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* ap, double* afp, double* b, int ldb, double* x, int ldx,
                double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sppsv_work")]
            internal static extern int LAPACKE_sppsv_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dppsv_work")]
            internal static extern int LAPACKE_dppsv_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sppsvx_work")]
            internal static extern int LAPACKE_sppsvx_work(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, float* ap, float* afp, sbyte* equed, float* s, float* b,
                int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dppsvx_work")]
            internal static extern int LAPACKE_dppsvx_work(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, double* ap, double* afp, sbyte* equed, double* s, double* b,
                int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spptrf_work")]
            internal static extern int LAPACKE_spptrf_work(int matrix_layout, sbyte uplo, int n, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpptrf_work")]
            internal static extern int LAPACKE_dpptrf_work(int matrix_layout, sbyte uplo, int n, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spptri_work")]
            internal static extern int LAPACKE_spptri_work(int matrix_layout, sbyte uplo, int n, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpptri_work")]
            internal static extern int LAPACKE_dpptri_work(int matrix_layout, sbyte uplo, int n, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spptrs_work")]
            internal static extern int LAPACKE_spptrs_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpptrs_work")]
            internal static extern int LAPACKE_dpptrs_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spstrf_work")]
            internal static extern int LAPACKE_spstrf_work(int matrix_layout, sbyte uplo, int n, float* a, int lda, int* piv, int* rank, float tol, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpstrf_work")]
            internal static extern int LAPACKE_dpstrf_work(int matrix_layout, sbyte uplo, int n, double* a, int lda, int* piv, int* rank, double tol, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sptcon_work")]
            internal static extern int LAPACKE_sptcon_work(int n, float* d, float* e, float anorm, float* rcond, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dptcon_work")]
            internal static extern int LAPACKE_dptcon_work(int n, double* d, double* e, double anorm, double* rcond, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spteqr_work")]
            internal static extern int LAPACKE_spteqr_work(int matrix_layout, sbyte compz, int n, float* d, float* e, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpteqr_work")]
            internal static extern int LAPACKE_dpteqr_work(int matrix_layout, sbyte compz, int n, double* d, double* e, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sptrfs_work")]
            internal static extern int LAPACKE_sptrfs_work(int matrix_layout, int n, int nrhs, float* d, float* e, float* df, float* ef, float* b, int ldb, float* x, int ldx,
                float* ferr, float* berr, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dptrfs_work")]
            internal static extern int LAPACKE_dptrfs_work(int matrix_layout, int n, int nrhs, double* d, double* e, double* df, double* ef, double* b, int ldb, double* x, int ldx,
                double* ferr, double* berr, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sptsv_work")]
            internal static extern int LAPACKE_sptsv_work(int matrix_layout, int n, int nrhs, float* d, float* e, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dptsv_work")]
            internal static extern int LAPACKE_dptsv_work(int matrix_layout, int n, int nrhs, double* d, double* e, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sptsvx_work")]
            internal static extern int LAPACKE_sptsvx_work(int matrix_layout, sbyte fact, int n, int nrhs, float* d, float* e, float* df, float* ef, float* b, int ldb, float* x,
                int ldx, float* rcond, float* ferr, float* berr, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dptsvx_work")]
            internal static extern int LAPACKE_dptsvx_work(int matrix_layout, sbyte fact, int n, int nrhs, double* d, double* e, double* df, double* ef, double* b, int ldb,
                double* x, int ldx, double* rcond, double* ferr, double* berr, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spttrf_work")]
            internal static extern int LAPACKE_spttrf_work(int n, float* d, float* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpttrf_work")]
            internal static extern int LAPACKE_dpttrf_work(int n, double* d, double* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_spttrs_work")]
            internal static extern int LAPACKE_spttrs_work(int matrix_layout, int n, int nrhs, float* d, float* e, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dpttrs_work")]
            internal static extern int LAPACKE_dpttrs_work(int matrix_layout, int n, int nrhs, double* d, double* e, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbev_work")]
            internal static extern int LAPACKE_ssbev_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbev_work")]
            internal static extern int LAPACKE_dsbev_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz,
                double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbevd_work")]
            internal static extern int LAPACKE_ssbevd_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz, float* work,
                int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbevd_work")]
            internal static extern int LAPACKE_dsbevd_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz,
                double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbevx_work")]
            internal static extern int LAPACKE_ssbevx_work(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, float* ab, int ldab, float* q, int ldq, float vl,
                float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbevx_work")]
            internal static extern int LAPACKE_dsbevx_work(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, double* ab, int ldab, double* q, int ldq,
                double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbgst_work")]
            internal static extern int LAPACKE_ssbgst_work(int matrix_layout, sbyte vect, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* x,
                int ldx, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbgst_work")]
            internal static extern int LAPACKE_dsbgst_work(int matrix_layout, sbyte vect, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* x,
                int ldx, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbgv_work")]
            internal static extern int LAPACKE_ssbgv_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* w,
                float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbgv_work")]
            internal static extern int LAPACKE_dsbgv_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* w,
                double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbgvd_work")]
            internal static extern int LAPACKE_ssbgvd_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* w,
                float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbgvd_work")]
            internal static extern int LAPACKE_dsbgvd_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* w,
                double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbgvx_work")]
            internal static extern int LAPACKE_ssbgvx_work(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb,
                float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbgvx_work")]
            internal static extern int LAPACKE_dsbgvx_work(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb,
                int ldbb, double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbtrd_work")]
            internal static extern int LAPACKE_ssbtrd_work(int matrix_layout, sbyte vect, sbyte uplo, int n, int kd, float* ab, int ldab, float* d, float* e, float* q, int ldq,
                float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbtrd_work")]
            internal static extern int LAPACKE_dsbtrd_work(int matrix_layout, sbyte vect, sbyte uplo, int n, int kd, double* ab, int ldab, double* d, double* e, double* q, int ldq,
                double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssfrk_work")]
            internal static extern int LAPACKE_ssfrk_work(int matrix_layout, sbyte transr, sbyte uplo, sbyte trans, int n, int k, float alpha, float* a, int lda, float beta,
                float* c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsfrk_work")]
            internal static extern int LAPACKE_dsfrk_work(int matrix_layout, sbyte transr, sbyte uplo, sbyte trans, int n, int k, double alpha, double* a, int lda, double beta,
                double* c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspcon_work")]
            internal static extern int LAPACKE_sspcon_work(int matrix_layout, sbyte uplo, int n, float* ap, int* ipiv, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspcon_work")]
            internal static extern int LAPACKE_dspcon_work(int matrix_layout, sbyte uplo, int n, double* ap, int* ipiv, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspev_work")]
            internal static extern int LAPACKE_sspev_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, float* ap, float* w, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspev_work")]
            internal static extern int LAPACKE_dspev_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, double* ap, double* w, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspevd_work")]
            internal static extern int LAPACKE_sspevd_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, float* ap, float* w, float* z, int ldz, float* work, int lwork,
                int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspevd_work")]
            internal static extern int LAPACKE_dspevd_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, double* ap, double* w, double* z, int ldz, double* work, int lwork,
                int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspevx_work")]
            internal static extern int LAPACKE_sspevx_work(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, float* ap, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspevx_work")]
            internal static extern int LAPACKE_dspevx_work(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, double* ap, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspgst_work")]
            internal static extern int LAPACKE_sspgst_work(int matrix_layout, int itype, sbyte uplo, int n, float* ap, float* bp);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspgst_work")]
            internal static extern int LAPACKE_dspgst_work(int matrix_layout, int itype, sbyte uplo, int n, double* ap, double* bp);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspgv_work")]
            internal static extern int LAPACKE_sspgv_work(int matrix_layout, int itype, sbyte jobz, sbyte uplo, int n, float* ap, float* bp, float* w, float* z, int ldz,
                float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspgv_work")]
            internal static extern int LAPACKE_dspgv_work(int matrix_layout, int itype, sbyte jobz, sbyte uplo, int n, double* ap, double* bp, double* w, double* z, int ldz,
                double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspgvd_work")]
            internal static extern int LAPACKE_sspgvd_work(int matrix_layout, int itype, sbyte jobz, sbyte uplo, int n, float* ap, float* bp, float* w, float* z, int ldz,
                float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspgvd_work")]
            internal static extern int LAPACKE_dspgvd_work(int matrix_layout, int itype, sbyte jobz, sbyte uplo, int n, double* ap, double* bp, double* w, double* z, int ldz,
                double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspgvx_work")]
            internal static extern int LAPACKE_sspgvx_work(int matrix_layout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, float* ap, float* bp, float vl, float vu,
                int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspgvx_work")]
            internal static extern int LAPACKE_dspgvx_work(int matrix_layout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, double* ap, double* bp, double vl, double vu,
                int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssprfs_work")]
            internal static extern int LAPACKE_ssprfs_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* ap, float* afp, int* ipiv, float* b, int ldb, float* x, int ldx,
                float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsprfs_work")]
            internal static extern int LAPACKE_dsprfs_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* ap, double* afp, int* ipiv, double* b, int ldb, double* x,
                int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspsv_work")]
            internal static extern int LAPACKE_sspsv_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* ap, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspsv_work")]
            internal static extern int LAPACKE_dspsv_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* ap, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sspsvx_work")]
            internal static extern int LAPACKE_sspsvx_work(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, float* ap, float* afp, int* ipiv, float* b, int ldb,
                float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dspsvx_work")]
            internal static extern int LAPACKE_dspsvx_work(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, double* ap, double* afp, int* ipiv, double* b, int ldb,
                double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssptrd_work")]
            internal static extern int LAPACKE_ssptrd_work(int matrix_layout, sbyte uplo, int n, float* ap, float* d, float* e, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsptrd_work")]
            internal static extern int LAPACKE_dsptrd_work(int matrix_layout, sbyte uplo, int n, double* ap, double* d, double* e, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssptrf_work")]
            internal static extern int LAPACKE_ssptrf_work(int matrix_layout, sbyte uplo, int n, float* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsptrf_work")]
            internal static extern int LAPACKE_dsptrf_work(int matrix_layout, sbyte uplo, int n, double* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssptri_work")]
            internal static extern int LAPACKE_ssptri_work(int matrix_layout, sbyte uplo, int n, float* ap, int* ipiv, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsptri_work")]
            internal static extern int LAPACKE_dsptri_work(int matrix_layout, sbyte uplo, int n, double* ap, int* ipiv, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssptrs_work")]
            internal static extern int LAPACKE_ssptrs_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* ap, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsptrs_work")]
            internal static extern int LAPACKE_dsptrs_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* ap, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstebz_work")]
            internal static extern int LAPACKE_sstebz_work(sbyte range, sbyte order, int n, float vl, float vu, int il, int iu, float abstol, float* d, float* e, int* m,
                int* nsplit, float* w, int* iblock, int* isplit, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstebz_work")]
            internal static extern int LAPACKE_dstebz_work(sbyte range, sbyte order, int n, double vl, double vu, int il, int iu, double abstol, double* d, double* e, int* m,
                int* nsplit, double* w, int* iblock, int* isplit, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstedc_work")]
            internal static extern int LAPACKE_sstedc_work(int matrix_layout, sbyte compz, int n, float* d, float* e, float* z, int ldz, float* work, int lwork, int* iwork,
                int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstedc_work")]
            internal static extern int LAPACKE_dstedc_work(int matrix_layout, sbyte compz, int n, double* d, double* e, double* z, int ldz, double* work, int lwork, int* iwork,
                int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstegr_work")]
            internal static extern int LAPACKE_sstegr_work(int matrix_layout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol,
                int* m, float* w, float* z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstegr_work")]
            internal static extern int LAPACKE_dstegr_work(int matrix_layout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, double* z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstein_work")]
            internal static extern int LAPACKE_sstein_work(int matrix_layout, int n, float* d, float* e, int m, float* w, int* iblock, int* isplit, float* z, int ldz, float* work,
                int* iwork, int* ifailv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstein_work")]
            internal static extern int LAPACKE_dstein_work(int matrix_layout, int n, double* d, double* e, int m, double* w, int* iblock, int* isplit, double* z, int ldz,
                double* work, int* iwork, int* ifailv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstemr_work")]
            internal static extern int LAPACKE_sstemr_work(int matrix_layout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* m,
                float* w, float* z, int ldz, int nzc, int* isuppz, int* tryrac, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstemr_work")]
            internal static extern int LAPACKE_dstemr_work(int matrix_layout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* m,
                double* w, double* z, int ldz, int nzc, int* isuppz, int* tryrac, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssteqr_work")]
            internal static extern int LAPACKE_ssteqr_work(int matrix_layout, sbyte compz, int n, float* d, float* e, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsteqr_work")]
            internal static extern int LAPACKE_dsteqr_work(int matrix_layout, sbyte compz, int n, double* d, double* e, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssterf_work")]
            internal static extern int LAPACKE_ssterf_work(int n, float* d, float* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsterf_work")]
            internal static extern int LAPACKE_dsterf_work(int n, double* d, double* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstev_work")]
            internal static extern int LAPACKE_sstev_work(int matrix_layout, sbyte jobz, int n, float* d, float* e, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstev_work")]
            internal static extern int LAPACKE_dstev_work(int matrix_layout, sbyte jobz, int n, double* d, double* e, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstevd_work")]
            internal static extern int LAPACKE_sstevd_work(int matrix_layout, sbyte jobz, int n, float* d, float* e, float* z, int ldz, float* work, int lwork, int* iwork,
                int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstevd_work")]
            internal static extern int LAPACKE_dstevd_work(int matrix_layout, sbyte jobz, int n, double* d, double* e, double* z, int ldz, double* work, int lwork, int* iwork,
                int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstevr_work")]
            internal static extern int LAPACKE_sstevr_work(int matrix_layout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol,
                int* m, float* w, float* z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstevr_work")]
            internal static extern int LAPACKE_dstevr_work(int matrix_layout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, double* z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sstevx_work")]
            internal static extern int LAPACKE_sstevx_work(int matrix_layout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol,
                int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dstevx_work")]
            internal static extern int LAPACKE_dstevx_work(int matrix_layout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssycon_work")]
            internal static extern int LAPACKE_ssycon_work(int matrix_layout, sbyte uplo, int n, float* a, int lda, int* ipiv, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsycon_work")]
            internal static extern int LAPACKE_dsycon_work(int matrix_layout, sbyte uplo, int n, double* a, int lda, int* ipiv, double anorm, double* rcond, double* work,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyequb_work")]
            internal static extern int LAPACKE_ssyequb_work(int matrix_layout, sbyte uplo, int n, float* a, int lda, float* s, float* scond, float* amax, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyequb_work")]
            internal static extern int LAPACKE_dsyequb_work(int matrix_layout, sbyte uplo, int n, double* a, int lda, double* s, double* scond, double* amax, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyev_work")]
            internal static extern int LAPACKE_ssyev_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyev_work")]
            internal static extern int LAPACKE_dsyev_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevd_work")]
            internal static extern int LAPACKE_ssyevd_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w, float* work, int lwork, int* iwork,
                int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevd_work")]
            internal static extern int LAPACKE_dsyevd_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w, double* work, int lwork, int* iwork,
                int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevr_work")]
            internal static extern int LAPACKE_ssyevr_work(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, float* z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevr_work")]
            internal static extern int LAPACKE_dsyevr_work(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, double* z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevx_work")]
            internal static extern int LAPACKE_ssyevx_work(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevx_work")]
            internal static extern int LAPACKE_dsyevx_work(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssygst_work")]
            internal static extern int LAPACKE_ssygst_work(int matrix_layout, int itype, sbyte uplo, int n, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsygst_work")]
            internal static extern int LAPACKE_dsygst_work(int matrix_layout, int itype, sbyte uplo, int n, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssygv_work")]
            internal static extern int LAPACKE_ssygv_work(int matrix_layout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w, float* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsygv_work")]
            internal static extern int LAPACKE_dsygv_work(int matrix_layout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssygvd_work")]
            internal static extern int LAPACKE_ssygvd_work(int matrix_layout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w, float* work,
                int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsygvd_work")]
            internal static extern int LAPACKE_dsygvd_work(int matrix_layout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w,
                double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssygvx_work")]
            internal static extern int LAPACKE_ssygvx_work(int matrix_layout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float vl,
                float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsygvx_work")]
            internal static extern int LAPACKE_dsygvx_work(int matrix_layout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double* b, int ldb,
                double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyrfs_work")]
            internal static extern int LAPACKE_ssyrfs_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb,
                float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyrfs_work")]
            internal static extern int LAPACKE_dsyrfs_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb,
                double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyrfsx_work")]
            internal static extern int LAPACKE_ssyrfsx_work(int matrix_layout, sbyte uplo, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv,
                float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params,
                float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyrfsx_work")]
            internal static extern int LAPACKE_dsyrfsx_work(int matrix_layout, sbyte uplo, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv,
                double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams,
                double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysv_work")]
            internal static extern int LAPACKE_ssysv_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysv_work")]
            internal static extern int LAPACKE_dsysv_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysvx_work")]
            internal static extern int LAPACKE_ssysvx_work(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b,
                int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysvx_work")]
            internal static extern int LAPACKE_dsysvx_work(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv,
                double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysvxx_work")]
            internal static extern int LAPACKE_ssysvxx_work(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv,
                sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp,
                int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysvxx_work")]
            internal static extern int LAPACKE_dsysvxx_work(int matrix_layout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv,
                sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm,
                double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrd_work")]
            internal static extern int LAPACKE_ssytrd_work(int matrix_layout, sbyte uplo, int n, float* a, int lda, float* d, float* e, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrd_work")]
            internal static extern int LAPACKE_dsytrd_work(int matrix_layout, sbyte uplo, int n, double* a, int lda, double* d, double* e, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrf_work")]
            internal static extern int LAPACKE_ssytrf_work(int matrix_layout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrf_work")]
            internal static extern int LAPACKE_dsytrf_work(int matrix_layout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytri_work")]
            internal static extern int LAPACKE_ssytri_work(int matrix_layout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytri_work")]
            internal static extern int LAPACKE_dsytri_work(int matrix_layout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs_work")]
            internal static extern int LAPACKE_ssytrs_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs_work")]
            internal static extern int LAPACKE_dsytrs_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stbcon_work")]
            internal static extern int LAPACKE_stbcon_work(int matrix_layout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, float* ab, int ldab, float* rcond, float* work,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtbcon_work")]
            internal static extern int LAPACKE_dtbcon_work(int matrix_layout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, double* ab, int ldab, double* rcond, double* work,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stbrfs_work")]
            internal static extern int LAPACKE_stbrfs_work(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb,
                float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtbrfs_work")]
            internal static extern int LAPACKE_dtbrfs_work(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int kd, int nrhs, double* ab, int ldab, double* b,
                int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stbtrs_work")]
            internal static extern int LAPACKE_stbtrs_work(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtbtrs_work")]
            internal static extern int LAPACKE_dtbtrs_work(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int kd, int nrhs, double* ab, int ldab, double* b,
                int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stfsm_work")]
            internal static extern int LAPACKE_stfsm_work(int matrix_layout, sbyte transr, sbyte side, sbyte uplo, sbyte trans, sbyte diag, int m, int n, float alpha, float* a,
                float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtfsm_work")]
            internal static extern int LAPACKE_dtfsm_work(int matrix_layout, sbyte transr, sbyte side, sbyte uplo, sbyte trans, sbyte diag, int m, int n, double alpha, double* a,
                double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stftri_work")]
            internal static extern int LAPACKE_stftri_work(int matrix_layout, sbyte transr, sbyte uplo, sbyte diag, int n, float* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtftri_work")]
            internal static extern int LAPACKE_dtftri_work(int matrix_layout, sbyte transr, sbyte uplo, sbyte diag, int n, double* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stfttp_work")]
            internal static extern int LAPACKE_stfttp_work(int matrix_layout, sbyte transr, sbyte uplo, int n, float* arf, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtfttp_work")]
            internal static extern int LAPACKE_dtfttp_work(int matrix_layout, sbyte transr, sbyte uplo, int n, double* arf, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stfttr_work")]
            internal static extern int LAPACKE_stfttr_work(int matrix_layout, sbyte transr, sbyte uplo, int n, float* arf, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtfttr_work")]
            internal static extern int LAPACKE_dtfttr_work(int matrix_layout, sbyte transr, sbyte uplo, int n, double* arf, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgevc_work")]
            internal static extern int LAPACKE_stgevc_work(int matrix_layout, sbyte side, sbyte howmny, int* select, int n, float* s, int lds, float* p, int ldp, float* vl,
                int ldvl, float* vr, int ldvr, int mm, int* m, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgevc_work")]
            internal static extern int LAPACKE_dtgevc_work(int matrix_layout, sbyte side, sbyte howmny, int* select, int n, double* s, int lds, double* p, int ldp, double* vl,
                int ldvl, double* vr, int ldvr, int mm, int* m, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgexc_work")]
            internal static extern int LAPACKE_stgexc_work(int matrix_layout, int wantq, int wantz, int n, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z,
                int ldz, int* ifst, int* ilst, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgexc_work")]
            internal static extern int LAPACKE_dtgexc_work(int matrix_layout, int wantq, int wantz, int n, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z,
                int ldz, int* ifst, int* ilst, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgsen_work")]
            internal static extern int LAPACKE_stgsen_work(int matrix_layout, int ijob, int wantq, int wantz, int* select, int n, float* a, int lda, float* b, int ldb,
                float* alphar, float* alphai, float* beta, float* q, int ldq, float* z, int ldz, int* m, float* pl, float* pr, float* dif, float* work, int lwork, int* iwork,
                int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgsen_work")]
            internal static extern int LAPACKE_dtgsen_work(int matrix_layout, int ijob, int wantq, int wantz, int* select, int n, double* a, int lda, double* b, int ldb,
                double* alphar, double* alphai, double* beta, double* q, int ldq, double* z, int ldz, int* m, double* pl, double* pr, double* dif, double* work, int lwork,
                int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgsja_work")]
            internal static extern int LAPACKE_stgsja_work(int matrix_layout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, float* a, int lda, float* b,
                int ldb, float tola, float tolb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, float* work, int* ncycle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgsja_work")]
            internal static extern int LAPACKE_dtgsja_work(int matrix_layout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, double* a, int lda, double* b,
                int ldb, double tola, double tolb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, double* work, int* ncycle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgsna_work")]
            internal static extern int LAPACKE_stgsna_work(int matrix_layout, sbyte job, sbyte howmny, int* select, int n, float* a, int lda, float* b, int ldb, float* vl,
                int ldvl, float* vr, int ldvr, float* s, float* dif, int mm, int* m, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgsna_work")]
            internal static extern int LAPACKE_dtgsna_work(int matrix_layout, sbyte job, sbyte howmny, int* select, int n, double* a, int lda, double* b, int ldb, double* vl,
                int ldvl, double* vr, int ldvr, double* s, double* dif, int mm, int* m, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stgsyl_work")]
            internal static extern int LAPACKE_stgsyl_work(int matrix_layout, sbyte trans, int ijob, int m, int n, float* a, int lda, float* b, int ldb, float* c, int ldc,
                float* d, int ldd, float* e, int lde, float* f, int ldf, float* scale, float* dif, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtgsyl_work")]
            internal static extern int LAPACKE_dtgsyl_work(int matrix_layout, sbyte trans, int ijob, int m, int n, double* a, int lda, double* b, int ldb, double* c, int ldc,
                double* d, int ldd, double* e, int lde, double* f, int ldf, double* scale, double* dif, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpcon_work")]
            internal static extern int LAPACKE_stpcon_work(int matrix_layout, sbyte norm, sbyte uplo, sbyte diag, int n, float* ap, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpcon_work")]
            internal static extern int LAPACKE_dtpcon_work(int matrix_layout, sbyte norm, sbyte uplo, sbyte diag, int n, double* ap, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stprfs_work")]
            internal static extern int LAPACKE_stprfs_work(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int nrhs, float* ap, float* b, int ldb, float* x, int ldx,
                float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtprfs_work")]
            internal static extern int LAPACKE_dtprfs_work(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int nrhs, double* ap, double* b, int ldb, double* x,
                int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stptri_work")]
            internal static extern int LAPACKE_stptri_work(int matrix_layout, sbyte uplo, sbyte diag, int n, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtptri_work")]
            internal static extern int LAPACKE_dtptri_work(int matrix_layout, sbyte uplo, sbyte diag, int n, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stptrs_work")]
            internal static extern int LAPACKE_stptrs_work(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtptrs_work")]
            internal static extern int LAPACKE_dtptrs_work(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpttf_work")]
            internal static extern int LAPACKE_stpttf_work(int matrix_layout, sbyte transr, sbyte uplo, int n, float* ap, float* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpttf_work")]
            internal static extern int LAPACKE_dtpttf_work(int matrix_layout, sbyte transr, sbyte uplo, int n, double* ap, double* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpttr_work")]
            internal static extern int LAPACKE_stpttr_work(int matrix_layout, sbyte uplo, int n, float* ap, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpttr_work")]
            internal static extern int LAPACKE_dtpttr_work(int matrix_layout, sbyte uplo, int n, double* ap, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strcon_work")]
            internal static extern int LAPACKE_strcon_work(int matrix_layout, sbyte norm, sbyte uplo, sbyte diag, int n, float* a, int lda, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrcon_work")]
            internal static extern int LAPACKE_dtrcon_work(int matrix_layout, sbyte norm, sbyte uplo, sbyte diag, int n, double* a, int lda, double* rcond, double* work,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strevc_work")]
            internal static extern int LAPACKE_strevc_work(int matrix_layout, sbyte side, sbyte howmny, int* select, int n, float* t, int ldt, float* vl, int ldvl, float* vr,
                int ldvr, int mm, int* m, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrevc_work")]
            internal static extern int LAPACKE_dtrevc_work(int matrix_layout, sbyte side, sbyte howmny, int* select, int n, double* t, int ldt, double* vl, int ldvl, double* vr,
                int ldvr, int mm, int* m, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strexc_work")]
            internal static extern int LAPACKE_strexc_work(int matrix_layout, sbyte compq, int n, float* t, int ldt, float* q, int ldq, int* ifst, int* ilst, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrexc_work")]
            internal static extern int LAPACKE_dtrexc_work(int matrix_layout, sbyte compq, int n, double* t, int ldt, double* q, int ldq, int* ifst, int* ilst, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strrfs_work")]
            internal static extern int LAPACKE_strrfs_work(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int nrhs, float* a, int lda, float* b, int ldb, float* x,
                int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrrfs_work")]
            internal static extern int LAPACKE_dtrrfs_work(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int nrhs, double* a, int lda, double* b, int ldb,
                double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strsen_work")]
            internal static extern int LAPACKE_strsen_work(int matrix_layout, sbyte job, sbyte compq, int* select, int n, float* t, int ldt, float* q, int ldq, float* wr,
                float* wi, int* m, float* s, float* sep, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrsen_work")]
            internal static extern int LAPACKE_dtrsen_work(int matrix_layout, sbyte job, sbyte compq, int* select, int n, double* t, int ldt, double* q, int ldq, double* wr,
                double* wi, int* m, double* s, double* sep, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strsna_work")]
            internal static extern int LAPACKE_strsna_work(int matrix_layout, sbyte job, sbyte howmny, int* select, int n, float* t, int ldt, float* vl, int ldvl, float* vr,
                int ldvr, float* s, float* sep, int mm, int* m, float* work, int ldwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrsna_work")]
            internal static extern int LAPACKE_dtrsna_work(int matrix_layout, sbyte job, sbyte howmny, int* select, int n, double* t, int ldt, double* vl, int ldvl, double* vr,
                int ldvr, double* s, double* sep, int mm, int* m, double* work, int ldwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strsyl_work")]
            internal static extern int LAPACKE_strsyl_work(int matrix_layout, sbyte trana, sbyte tranb, int isgn, int m, int n, float* a, int lda, float* b, int ldb, float* c,
                int ldc, float* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrsyl_work")]
            internal static extern int LAPACKE_dtrsyl_work(int matrix_layout, sbyte trana, sbyte tranb, int isgn, int m, int n, double* a, int lda, double* b, int ldb, double* c,
                int ldc, double* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strtri_work")]
            internal static extern int LAPACKE_strtri_work(int matrix_layout, sbyte uplo, sbyte diag, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrtri_work")]
            internal static extern int LAPACKE_dtrtri_work(int matrix_layout, sbyte uplo, sbyte diag, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strtrs_work")]
            internal static extern int LAPACKE_strtrs_work(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrtrs_work")]
            internal static extern int LAPACKE_dtrtrs_work(int matrix_layout, sbyte uplo, sbyte trans, sbyte diag, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strttf_work")]
            internal static extern int LAPACKE_strttf_work(int matrix_layout, sbyte transr, sbyte uplo, int n, float* a, int lda, float* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrttf_work")]
            internal static extern int LAPACKE_dtrttf_work(int matrix_layout, sbyte transr, sbyte uplo, int n, double* a, int lda, double* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_strttp_work")]
            internal static extern int LAPACKE_strttp_work(int matrix_layout, sbyte uplo, int n, float* a, int lda, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtrttp_work")]
            internal static extern int LAPACKE_dtrttp_work(int matrix_layout, sbyte uplo, int n, double* a, int lda, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stzrzf_work")]
            internal static extern int LAPACKE_stzrzf_work(int matrix_layout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtzrzf_work")]
            internal static extern int LAPACKE_dtzrzf_work(int matrix_layout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slagsy")]
            internal static extern int LAPACKE_slagsy(int matrix_layout, int n, int k, float* d, float* a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlagsy")]
            internal static extern int LAPACKE_dlagsy(int matrix_layout, int n, int k, double* d, double* a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slapmr")]
            internal static extern int LAPACKE_slapmr(int matrix_layout, int forwrd, int m, int n, float* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlapmr")]
            internal static extern int LAPACKE_dlapmr(int matrix_layout, int forwrd, int m, int n, double* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slapmt")]
            internal static extern int LAPACKE_slapmt(int matrix_layout, int forwrd, int m, int n, float* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlapmt")]
            internal static extern int LAPACKE_dlapmt(int matrix_layout, int forwrd, int m, int n, double* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slapy2")]
            internal static extern float LAPACKE_slapy2(float x, float y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlapy2")]
            internal static extern double LAPACKE_dlapy2(double x, double y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slapy3")]
            internal static extern float LAPACKE_slapy3(float x, float y, float z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlapy3")]
            internal static extern double LAPACKE_dlapy3(double x, double y, double z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slartgp")]
            internal static extern int LAPACKE_slartgp(float f, float g, float* cs, float* sn, float* r);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlartgp")]
            internal static extern int LAPACKE_dlartgp(double f, double g, double* cs, double* sn, double* r);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_slartgs")]
            internal static extern int LAPACKE_slartgs(float x, float y, float sigma, float* cs, float* sn);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dlartgs")]
            internal static extern int LAPACKE_dlartgs(double x, double y, double sigma, double* cs, double* sn);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dbbcsd")]
            internal static extern int LAPACKE_dbbcsd(int matrix_layout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, sbyte trans, int m, int p, int q, double* theta,
                double* phi, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* v2t, int ldv2t, double* b11d, double* b11e, double* b12d, double* b12e,
                double* b21d, double* b21e, double* b22d, double* b22e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dbbcsd_work")]
            internal static extern int LAPACKE_dbbcsd_work(int matrix_layout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, sbyte trans, int m, int p, int q, double* theta,
                double* phi, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* v2t, int ldv2t, double* b11d, double* b11e, double* b12d, double* b12e,
                double* b21d, double* b21e, double* b22d, double* b22e, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorbdb")]
            internal static extern int LAPACKE_dorbdb(int matrix_layout, sbyte trans, sbyte signs, int m, int p, int q, double* x11, int ldx11, double* x12, int ldx12, double* x21,
                int ldx21, double* x22, int ldx22, double* theta, double* phi, double* taup1, double* taup2, double* tauq1, double* tauq2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorbdb_work")]
            internal static extern int LAPACKE_dorbdb_work(int matrix_layout, sbyte trans, sbyte signs, int m, int p, int q, double* x11, int ldx11, double* x12, int ldx12,
                double* x21, int ldx21, double* x22, int ldx22, double* theta, double* phi, double* taup1, double* taup2, double* tauq1, double* tauq2, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorcsd")]
            internal static extern int LAPACKE_dorcsd(int matrix_layout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, sbyte trans, sbyte signs, int m, int p, int q,
                double* x11, int ldx11, double* x12, int ldx12, double* x21, int ldx21, double* x22, int ldx22, double* theta, double* u1, int ldu1, double* u2, int ldu2,
                double* v1t, int ldv1t, double* v2t, int ldv2t);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorcsd_work")]
            internal static extern int LAPACKE_dorcsd_work(int matrix_layout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, sbyte trans, sbyte signs, int m, int p, int q,
                double* x11, int ldx11, double* x12, int ldx12, double* x21, int ldx21, double* x22, int ldx22, double* theta, double* u1, int ldu1, double* u2, int ldu2,
                double* v1t, int ldv1t, double* v2t, int ldv2t, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorcsd2by1")]
            internal static extern int LAPACKE_dorcsd2by1(int matrix_layout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, double* x11, int ldx11, double* x21,
                int ldx21, double* theta, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dorcsd2by1_work")]
            internal static extern int LAPACKE_dorcsd2by1_work(int matrix_layout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, double* x11, int ldx11, double* x21,
                int ldx21, double* theta, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyconv")]
            internal static extern int LAPACKE_dsyconv(int matrix_layout, sbyte uplo, sbyte way, int n, double* a, int lda, int* ipiv, double* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyconv_work")]
            internal static extern int LAPACKE_dsyconv_work(int matrix_layout, sbyte uplo, sbyte way, int n, double* a, int lda, int* ipiv, double* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyswapr")]
            internal static extern int LAPACKE_dsyswapr(int matrix_layout, sbyte uplo, int n, double* a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyswapr_work")]
            internal static extern int LAPACKE_dsyswapr_work(int matrix_layout, sbyte uplo, int n, double* a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytri2")]
            internal static extern int LAPACKE_dsytri2(int matrix_layout, sbyte uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytri2_work")]
            internal static extern int LAPACKE_dsytri2_work(int matrix_layout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytri2x")]
            internal static extern int LAPACKE_dsytri2x(int matrix_layout, sbyte uplo, int n, double* a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytri2x_work")]
            internal static extern int LAPACKE_dsytri2x_work(int matrix_layout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs2")]
            internal static extern int LAPACKE_dsytrs2(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs2_work")]
            internal static extern int LAPACKE_dsytrs2_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sbbcsd")]
            internal static extern int LAPACKE_sbbcsd(int matrix_layout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, sbyte trans, int m, int p, int q, float* theta,
                float* phi, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* v2t, int ldv2t, float* b11d, float* b11e, float* b12d, float* b12e, float* b21d,
                float* b21e, float* b22d, float* b22e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sbbcsd_work")]
            internal static extern int LAPACKE_sbbcsd_work(int matrix_layout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, sbyte trans, int m, int p, int q, float* theta,
                float* phi, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* v2t, int ldv2t, float* b11d, float* b11e, float* b12d, float* b12e, float* b21d,
                float* b21e, float* b22d, float* b22e, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorbdb")]
            internal static extern int LAPACKE_sorbdb(int matrix_layout, sbyte trans, sbyte signs, int m, int p, int q, float* x11, int ldx11, float* x12, int ldx12, float* x21,
                int ldx21, float* x22, int ldx22, float* theta, float* phi, float* taup1, float* taup2, float* tauq1, float* tauq2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorbdb_work")]
            internal static extern int LAPACKE_sorbdb_work(int matrix_layout, sbyte trans, sbyte signs, int m, int p, int q, float* x11, int ldx11, float* x12, int ldx12,
                float* x21, int ldx21, float* x22, int ldx22, float* theta, float* phi, float* taup1, float* taup2, float* tauq1, float* tauq2, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorcsd")]
            internal static extern int LAPACKE_sorcsd(int matrix_layout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, sbyte trans, sbyte signs, int m, int p, int q,
                float* x11, int ldx11, float* x12, int ldx12, float* x21, int ldx21, float* x22, int ldx22, float* theta, float* u1, int ldu1, float* u2, int ldu2, float* v1t,
                int ldv1t, float* v2t, int ldv2t);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorcsd_work")]
            internal static extern int LAPACKE_sorcsd_work(int matrix_layout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, sbyte trans, sbyte signs, int m, int p, int q,
                float* x11, int ldx11, float* x12, int ldx12, float* x21, int ldx21, float* x22, int ldx22, float* theta, float* u1, int ldu1, float* u2, int ldu2, float* v1t,
                int ldv1t, float* v2t, int ldv2t, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorcsd2by1")]
            internal static extern int LAPACKE_sorcsd2by1(int matrix_layout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, float* x11, int ldx11, float* x21,
                int ldx21, float* theta, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sorcsd2by1_work")]
            internal static extern int LAPACKE_sorcsd2by1_work(int matrix_layout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, float* x11, int ldx11, float* x21,
                int ldx21, float* theta, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyconv")]
            internal static extern int LAPACKE_ssyconv(int matrix_layout, sbyte uplo, sbyte way, int n, float* a, int lda, int* ipiv, float* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyconv_work")]
            internal static extern int LAPACKE_ssyconv_work(int matrix_layout, sbyte uplo, sbyte way, int n, float* a, int lda, int* ipiv, float* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyswapr")]
            internal static extern int LAPACKE_ssyswapr(int matrix_layout, sbyte uplo, int n, float* a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyswapr_work")]
            internal static extern int LAPACKE_ssyswapr_work(int matrix_layout, sbyte uplo, int n, float* a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytri2")]
            internal static extern int LAPACKE_ssytri2(int matrix_layout, sbyte uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytri2_work")]
            internal static extern int LAPACKE_ssytri2_work(int matrix_layout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytri2x")]
            internal static extern int LAPACKE_ssytri2x(int matrix_layout, sbyte uplo, int n, float* a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytri2x_work")]
            internal static extern int LAPACKE_ssytri2x_work(int matrix_layout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs2")]
            internal static extern int LAPACKE_ssytrs2(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs2_work")]
            internal static extern int LAPACKE_ssytrs2_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgemqrt")]
            internal static extern int LAPACKE_sgemqrt(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, int nb, float* v, int ldv, float* t, int ldt, float* c,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgemqrt")]
            internal static extern int LAPACKE_dgemqrt(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, int nb, double* v, int ldv, double* t, int ldt, double* c,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqrt")]
            internal static extern int LAPACKE_sgeqrt(int matrix_layout, int m, int n, int nb, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqrt")]
            internal static extern int LAPACKE_dgeqrt(int matrix_layout, int m, int n, int nb, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqrt2")]
            internal static extern int LAPACKE_sgeqrt2(int matrix_layout, int m, int n, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqrt2")]
            internal static extern int LAPACKE_dgeqrt2(int matrix_layout, int m, int n, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqrt3")]
            internal static extern int LAPACKE_sgeqrt3(int matrix_layout, int m, int n, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqrt3")]
            internal static extern int LAPACKE_dgeqrt3(int matrix_layout, int m, int n, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpmqrt")]
            internal static extern int LAPACKE_stpmqrt(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, int l, int nb, float* v, int ldv, float* t, int ldt,
                float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpmqrt")]
            internal static extern int LAPACKE_dtpmqrt(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, int l, int nb, double* v, int ldv, double* t, int ldt,
                double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpqrt")]
            internal static extern int LAPACKE_stpqrt(int matrix_layout, int m, int n, int l, int nb, float* a, int lda, float* b, int ldb, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpqrt")]
            internal static extern int LAPACKE_dtpqrt(int matrix_layout, int m, int n, int l, int nb, double* a, int lda, double* b, int ldb, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpqrt2")]
            internal static extern int LAPACKE_stpqrt2(int matrix_layout, int m, int n, int l, float* a, int lda, float* b, int ldb, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpqrt2")]
            internal static extern int LAPACKE_dtpqrt2(int matrix_layout, int m, int n, int l, double* a, int lda, double* b, int ldb, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stprfb")]
            internal static extern int LAPACKE_stprfb(int matrix_layout, sbyte side, sbyte trans, sbyte direct, sbyte storev, int m, int n, int k, int l, float* v, int ldv,
                float* t, int ldt, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtprfb")]
            internal static extern int LAPACKE_dtprfb(int matrix_layout, sbyte side, sbyte trans, sbyte direct, sbyte storev, int m, int n, int k, int l, double* v, int ldv,
                double* t, int ldt, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgemqrt_work")]
            internal static extern int LAPACKE_sgemqrt_work(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, int nb, float* v, int ldv, float* t, int ldt, float* c,
                int ldc, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgemqrt_work")]
            internal static extern int LAPACKE_dgemqrt_work(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, int nb, double* v, int ldv, double* t, int ldt,
                double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqrt_work")]
            internal static extern int LAPACKE_sgeqrt_work(int matrix_layout, int m, int n, int nb, float* a, int lda, float* t, int ldt, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqrt_work")]
            internal static extern int LAPACKE_dgeqrt_work(int matrix_layout, int m, int n, int nb, double* a, int lda, double* t, int ldt, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqrt2_work")]
            internal static extern int LAPACKE_sgeqrt2_work(int matrix_layout, int m, int n, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqrt2_work")]
            internal static extern int LAPACKE_dgeqrt2_work(int matrix_layout, int m, int n, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqrt3_work")]
            internal static extern int LAPACKE_sgeqrt3_work(int matrix_layout, int m, int n, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqrt3_work")]
            internal static extern int LAPACKE_dgeqrt3_work(int matrix_layout, int m, int n, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpmqrt_work")]
            internal static extern int LAPACKE_stpmqrt_work(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, int l, int nb, float* v, int ldv, float* t, int ldt,
                float* a, int lda, float* b, int ldb, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpmqrt_work")]
            internal static extern int LAPACKE_dtpmqrt_work(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, int l, int nb, double* v, int ldv, double* t, int ldt,
                double* a, int lda, double* b, int ldb, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpqrt_work")]
            internal static extern int LAPACKE_stpqrt_work(int matrix_layout, int m, int n, int l, int nb, float* a, int lda, float* b, int ldb, float* t, int ldt, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpqrt_work")]
            internal static extern int LAPACKE_dtpqrt_work(int matrix_layout, int m, int n, int l, int nb, double* a, int lda, double* b, int ldb, double* t, int ldt,
                double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stpqrt2_work")]
            internal static extern int LAPACKE_stpqrt2_work(int matrix_layout, int m, int n, int l, float* a, int lda, float* b, int ldb, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtpqrt2_work")]
            internal static extern int LAPACKE_dtpqrt2_work(int matrix_layout, int m, int n, int l, double* a, int lda, double* b, int ldb, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_stprfb_work")]
            internal static extern int LAPACKE_stprfb_work(int matrix_layout, sbyte side, sbyte trans, sbyte direct, sbyte storev, int m, int n, int k, int l, float* v, int ldv,
                float* t, int ldt, float* a, int lda, float* b, int ldb, float* work, int ldwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dtprfb_work")]
            internal static extern int LAPACKE_dtprfb_work(int matrix_layout, sbyte side, sbyte trans, sbyte direct, sbyte storev, int m, int n, int k, int l, double* v, int ldv,
                double* t, int ldt, double* a, int lda, double* b, int ldb, double* work, int ldwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysv_rook")]
            internal static extern int LAPACKE_ssysv_rook(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysv_rook")]
            internal static extern int LAPACKE_dsysv_rook(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrf_rook")]
            internal static extern int LAPACKE_ssytrf_rook(int matrix_layout, sbyte uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrf_rook")]
            internal static extern int LAPACKE_dsytrf_rook(int matrix_layout, sbyte uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs_rook")]
            internal static extern int LAPACKE_ssytrs_rook(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs_rook")]
            internal static extern int LAPACKE_dsytrs_rook(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysv_rook_work")]
            internal static extern int LAPACKE_ssysv_rook_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysv_rook_work")]
            internal static extern int LAPACKE_dsysv_rook_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrf_rook_work")]
            internal static extern int LAPACKE_ssytrf_rook_work(int matrix_layout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrf_rook_work")]
            internal static extern int LAPACKE_dsytrf_rook_work(int matrix_layout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs_rook_work")]
            internal static extern int LAPACKE_ssytrs_rook_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs_rook_work")]
            internal static extern int LAPACKE_dsytrs_rook_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ilaver")]
            internal static extern void LAPACKE_ilaver(int* vers_major, int* vers_minor, int* vers_patch);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysv_aa")]
            internal static extern int LAPACKE_ssysv_aa(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysv_aa_work")]
            internal static extern int LAPACKE_ssysv_aa_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysv_aa")]
            internal static extern int LAPACKE_dsysv_aa(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysv_aa_work")]
            internal static extern int LAPACKE_dsysv_aa_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrf_aa")]
            internal static extern int LAPACKE_ssytrf_aa(int matrix_layout, sbyte uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrf_aa")]
            internal static extern int LAPACKE_dsytrf_aa(int matrix_layout, sbyte uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrf_aa_work")]
            internal static extern int LAPACKE_ssytrf_aa_work(int matrix_layout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrf_aa_work")]
            internal static extern int LAPACKE_dsytrf_aa_work(int matrix_layout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs_aa")]
            internal static extern int LAPACKE_dsytrs_aa(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs_aa_work")]
            internal static extern int LAPACKE_dsytrs_aa_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs_aa")]
            internal static extern int LAPACKE_ssytrs_aa(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs_aa_work")]
            internal static extern int LAPACKE_ssytrs_aa_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysv_rk")]
            internal static extern int LAPACKE_ssysv_rk(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, float* e, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysv_rk_work")]
            internal static extern int LAPACKE_ssysv_rk_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, float* e, int* ipiv, float* b, int ldb, float* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysv_rk")]
            internal static extern int LAPACKE_dsysv_rk(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, double* e, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysv_rk_work")]
            internal static extern int LAPACKE_dsysv_rk_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, double* e, int* ipiv, double* b, int ldb,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrf_rk")]
            internal static extern int LAPACKE_ssytrf_rk(int matrix_layout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrf_rk")]
            internal static extern int LAPACKE_dsytrf_rk(int matrix_layout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrf_rk_work")]
            internal static extern int LAPACKE_ssytrf_rk_work(int matrix_layout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrf_rk_work")]
            internal static extern int LAPACKE_dsytrf_rk_work(int matrix_layout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs_3")]
            internal static extern int LAPACKE_dsytrs3(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, double* e, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs_3_work")]
            internal static extern int LAPACKE_dsytrs3_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, double* e, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs_3")]
            internal static extern int LAPACKE_ssytrs3(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, float* e, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs_3_work")]
            internal static extern int LAPACKE_ssytrs3_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, float* e, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytri_3")]
            internal static extern int LAPACKE_ssytri3(int matrix_layout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytri_3")]
            internal static extern int LAPACKE_dsytri3(int matrix_layout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytri_3_work")]
            internal static extern int LAPACKE_ssytri3_work(int matrix_layout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytri_3_work")]
            internal static extern int LAPACKE_dsytri3_work(int matrix_layout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssycon_3")]
            internal static extern int LAPACKE_ssycon3(int matrix_layout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsycon_3")]
            internal static extern int LAPACKE_dsycon3(int matrix_layout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssycon_3_work")]
            internal static extern int LAPACKE_ssycon3_work(int matrix_layout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv, float anorm, float* rcond, float* work,
                int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsycon_3_work")]
            internal static extern int LAPACKE_dsycon3_work(int matrix_layout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv, double anorm, double* rcond,
                double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelq")]
            internal static extern int LAPACKE_sgelq(int matrix_layout, int m, int n, float* a, int lda, float* t, int tsize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelq")]
            internal static extern int LAPACKE_dgelq(int matrix_layout, int m, int n, double* a, int lda, double* t, int tsize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgelq_work")]
            internal static extern int LAPACKE_sgelq_work(int matrix_layout, int m, int n, float* a, int lda, float* t, int tsize, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgelq_work")]
            internal static extern int LAPACKE_dgelq_work(int matrix_layout, int m, int n, double* a, int lda, double* t, int tsize, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgemlq")]
            internal static extern int LAPACKE_sgemlq(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, float* a, int lda, float* t, int tsize, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgemlq")]
            internal static extern int LAPACKE_dgemlq(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, double* a, int lda, double* t, int tsize, double* c,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgemlq_work")]
            internal static extern int LAPACKE_sgemlq_work(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, float* a, int lda, float* t, int tsize, float* c,
                int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgemlq_work")]
            internal static extern int LAPACKE_dgemlq_work(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, double* a, int lda, double* t, int tsize, double* c,
                int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqr")]
            internal static extern int LAPACKE_sgeqr(int matrix_layout, int m, int n, float* a, int lda, float* t, int tsize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqr")]
            internal static extern int LAPACKE_dgeqr(int matrix_layout, int m, int n, double* a, int lda, double* t, int tsize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgeqr_work")]
            internal static extern int LAPACKE_sgeqr_work(int matrix_layout, int m, int n, float* a, int lda, float* t, int tsize, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgeqr_work")]
            internal static extern int LAPACKE_dgeqr_work(int matrix_layout, int m, int n, double* a, int lda, double* t, int tsize, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgemqr")]
            internal static extern int LAPACKE_sgemqr(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, float* a, int lda, float* t, int tsize, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgemqr")]
            internal static extern int LAPACKE_dgemqr(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, double* a, int lda, double* t, int tsize, double* c,
                int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgemqr_work")]
            internal static extern int LAPACKE_sgemqr_work(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, float* a, int lda, float* t, int tsize, float* c,
                int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgemqr_work")]
            internal static extern int LAPACKE_dgemqr_work(int matrix_layout, sbyte side, sbyte trans, int m, int n, int k, double* a, int lda, double* t, int tsize, double* c,
                int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetsls")]
            internal static extern int LAPACKE_sgetsls(int matrix_layout, sbyte trans, int m, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetsls")]
            internal static extern int LAPACKE_dgetsls(int matrix_layout, sbyte trans, int m, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_sgetsls_work")]
            internal static extern int LAPACKE_sgetsls_work(int matrix_layout, sbyte trans, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dgetsls_work")]
            internal static extern int LAPACKE_dgetsls_work(int matrix_layout, sbyte trans, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyev_2stage")]
            internal static extern int LAPACKE_ssyev2stage(int matrix_layout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyev_2stage")]
            internal static extern int LAPACKE_dsyev2stage(int matrix_layout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevd_2stage")]
            internal static extern int LAPACKE_ssyevd2stage(int matrix_layout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevd_2stage")]
            internal static extern int LAPACKE_dsyevd2stage(int matrix_layout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevr_2stage")]
            internal static extern int LAPACKE_ssyevr2stage(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, float* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevr_2stage")]
            internal static extern int LAPACKE_dsyevr2stage(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, double* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevx_2stage")]
            internal static extern int LAPACKE_ssyevx2stage(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu,
                float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevx_2stage")]
            internal static extern int LAPACKE_dsyevx2stage(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu,
                double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyev_2stage_work")]
            internal static extern int LAPACKE_ssyev2stage_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyev_2stage_work")]
            internal static extern int LAPACKE_dsyev2stage_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevd_2stage_work")]
            internal static extern int LAPACKE_ssyevd2stage_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w, float* work, int lwork, int* iwork,
                int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevd_2stage_work")]
            internal static extern int LAPACKE_dsyevd2stage_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w, double* work, int lwork,
                int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevr_2stage_work")]
            internal static extern int LAPACKE_ssyevr2stage_work(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il,
                int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevr_2stage_work")]
            internal static extern int LAPACKE_dsyevr2stage_work(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il,
                int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssyevx_2stage_work")]
            internal static extern int LAPACKE_ssyevx2stage_work(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il,
                int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsyevx_2stage_work")]
            internal static extern int LAPACKE_dsyevx2stage_work(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il,
                int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbev_2stage")]
            internal static extern int LAPACKE_ssbev2stage(int matrix_layout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbev_2stage")]
            internal static extern int LAPACKE_dsbev2stage(int matrix_layout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbevd_2stage")]
            internal static extern int LAPACKE_ssbevd2stage(int matrix_layout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbevd_2stage")]
            internal static extern int LAPACKE_dsbevd2stage(int matrix_layout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbevx_2stage")]
            internal static extern int LAPACKE_ssbevx2stage(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, float* ab, int ldab, float* q, int ldq, float vl,
                float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbevx_2stage")]
            internal static extern int LAPACKE_dsbevx2stage(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, double* ab, int ldab, double* q, int ldq,
                double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbev_2stage_work")]
            internal static extern int LAPACKE_ssbev2stage_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz,
                float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbev_2stage_work")]
            internal static extern int LAPACKE_dsbev2stage_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbevd_2stage_work")]
            internal static extern int LAPACKE_ssbevd2stage_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz,
                float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbevd_2stage_work")]
            internal static extern int LAPACKE_dsbevd2stage_work(int matrix_layout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz,
                double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssbevx_2stage_work")]
            internal static extern int LAPACKE_ssbevx2stage_work(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, float* ab, int ldab, float* q, int ldq,
                float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsbevx_2stage_work")]
            internal static extern int LAPACKE_dsbevx2stage_work(int matrix_layout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, double* ab, int ldab, double* q, int ldq,
                double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssygv_2stage")]
            internal static extern int LAPACKE_ssygv2stage(int matrix_layout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsygv_2stage")]
            internal static extern int LAPACKE_dsygv2stage(int matrix_layout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssygv_2stage_work")]
            internal static extern int LAPACKE_ssygv2stage_work(int matrix_layout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w,
                float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsygv_2stage_work")]
            internal static extern int LAPACKE_dsygv2stage_work(int matrix_layout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysv_aa_2stage")]
            internal static extern int LAPACKE_ssysv_aa2stage(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2,
                float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssysv_aa_2stage_work")]
            internal static extern int LAPACKE_ssysv_aa2stage_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2,
                float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysv_aa_2stage")]
            internal static extern int LAPACKE_dsysv_aa2stage(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2,
                double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsysv_aa_2stage_work")]
            internal static extern int LAPACKE_dsysv_aa2stage_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2,
                double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrf_aa_2stage")]
            internal static extern int LAPACKE_ssytrf_aa2stage(int matrix_layout, sbyte uplo, int n, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrf_aa_2stage_work")]
            internal static extern int LAPACKE_ssytrf_aa2stage_work(int matrix_layout, sbyte uplo, int n, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2, float* work,
                int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrf_aa_2stage")]
            internal static extern int LAPACKE_dsytrf_aa2stage(int matrix_layout, sbyte uplo, int n, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrf_aa_2stage_work")]
            internal static extern int LAPACKE_dsytrf_aa2stage_work(int matrix_layout, sbyte uplo, int n, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2,
                double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs_aa_2stage")]
            internal static extern int LAPACKE_ssytrs_aa2stage(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2,
                float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_ssytrs_aa_2stage_work")]
            internal static extern int LAPACKE_ssytrs_aa2stage_work(int matrix_layout, sbyte uplo, int n, int nrhs, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2,
                float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs_aa_2stage")]
            internal static extern int LAPACKE_dsytrs_aa2stage(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2,
                double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_dsytrs_aa_2stage_work")]
            internal static extern int LAPACKE_dsytrs_aa2stage_work(int matrix_layout, sbyte uplo, int n, int nrhs, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2,
                double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_set_nancheck")]
            internal static extern void LAPACKE_set_nancheck(int flag);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "LAPACKE_get_nancheck")]
            internal static extern int LAPACKE_get_nancheck();
        }
    }
}