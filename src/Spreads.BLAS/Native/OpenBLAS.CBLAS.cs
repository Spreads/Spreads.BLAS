using System.Runtime.InteropServices;
using System.Security;

namespace Spreads.Native
{
    public static unsafe partial class OpenBLAS
    {
        public static class CBLAS
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="openblas_set_num_threads")]
            internal static extern void OpenblasSetNumThreads(int num_threads);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="goto_set_num_threads")]
            internal static extern void GotoSetNumThreads(int num_threads);
  
            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="openblas_get_num_threads")]
            internal static extern int OpenblasGetNumThreads();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="openblas_get_num_procs")]
            internal static extern int OpenblasGetNumProcs();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="openblas_get_config")]
            internal static extern sbyte* OpenblasGetConfig();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="openblas_get_corename")]
            internal static extern sbyte* OpenblasGetCorename();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="openblas_get_parallel")]
            internal static extern int OpenblasGetParallel();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_sdsdot")]
            internal static extern float CblasSdsdot(int n, float alpha, float* x, int incx, float* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dsdot")]
            internal static extern double CblasDsdot(int n, float* x, int incx, float* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_sdot")]
            internal static extern float CblasSdot(int n, float* x, int incx, float* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ddot")]
            internal static extern double CblasDdot(int n, double* x, int incx, double* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_cdotu")]
            internal static extern ComplexFloat CblasCdotu(int n, global::System.IntPtr x, int incx, global::System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_cdotc")]
            internal static extern ComplexFloat CblasCdotc(int n, global::System.IntPtr x, int incx, global::System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zdotu")]
            internal static extern ComplexDouble CblasZdotu(int n, global::System.IntPtr x, int incx, global::System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zdotc")]
            internal static extern ComplexDouble CblasZdotc(int n, global::System.IntPtr x, int incx, global::System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_cdotu_sub")]
            internal static extern void CblasCdotuSub(int n, global::System.IntPtr x, int incx, global::System.IntPtr y, int incy, global::System.IntPtr ret);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_cdotc_sub")]
            internal static extern void CblasCdotcSub(int n, global::System.IntPtr x, int incx, global::System.IntPtr y, int incy, global::System.IntPtr ret);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zdotu_sub")]
            internal static extern void CblasZdotuSub(int n, global::System.IntPtr x, int incx, global::System.IntPtr y, int incy, global::System.IntPtr ret);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zdotc_sub")]
            internal static extern void CblasZdotcSub(int n, global::System.IntPtr x, int incx, global::System.IntPtr y, int incy, global::System.IntPtr ret);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_sasum")]
            internal static extern float CblasSasum(int n, float* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dasum")]
            internal static extern double CblasDasum(int n, double* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_scasum")]
            internal static extern float CblasScasum(int n, global::System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dzasum")]
            internal static extern double CblasDzasum(int n, global::System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ssum")]
            internal static extern float CblasSsum(int n, float* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dsum")]
            internal static extern double CblasDsum(int n, double* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_scsum")]
            internal static extern float CblasScsum(int n, global::System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dzsum")]
            internal static extern double CblasDzsum(int n, global::System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_snrm2")]
            internal static extern float CblasSnrm2(int N, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dnrm2")]
            internal static extern double CblasDnrm2(int N, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_scnrm2")]
            internal static extern float CblasScnrm2(int N, global::System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dznrm2")]
            internal static extern double CblasDznrm2(int N, global::System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_isamax")]
            internal static extern ulong CblasIsamax(int n, float* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_idamax")]
            internal static extern ulong CblasIdamax(int n, double* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_icamax")]
            internal static extern ulong CblasIcamax(int n, global::System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_izamax")]
            internal static extern ulong CblasIzamax(int n, global::System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_isamin")]
            internal static extern ulong CblasIsamin(int n, float* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_idamin")]
            internal static extern ulong CblasIdamin(int n, double* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_icamin")]
            internal static extern ulong CblasIcamin(int n, global::System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_izamin")]
            internal static extern ulong CblasIzamin(int n, global::System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ismax")]
            internal static extern ulong CblasIsmax(int n, float* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_idmax")]
            internal static extern ulong CblasIdmax(int n, double* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_icmax")]
            internal static extern ulong CblasIcmax(int n, global::System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_izmax")]
            internal static extern ulong CblasIzmax(int n, global::System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ismin")]
            internal static extern ulong CblasIsmin(int n, float* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_idmin")]
            internal static extern ulong CblasIdmin(int n, double* x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_icmin")]
            internal static extern ulong CblasIcmin(int n, global::System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_izmin")]
            internal static extern ulong CblasIzmin(int n, global::System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_saxpy")]
            internal static extern void CblasSaxpy(int n, float alpha, float* x, int incx, float* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_daxpy")]
            internal static extern void CblasDaxpy(int n, double alpha, double* x, int incx, double* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_caxpy")]
            internal static extern void CblasCaxpy(int n, global::System.IntPtr alpha, global::System.IntPtr x, int incx, global::System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zaxpy")]
            internal static extern void CblasZaxpy(int n, global::System.IntPtr alpha, global::System.IntPtr x, int incx, global::System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_scopy")]
            internal static extern void CblasScopy(int n, float* x, int incx, float* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dcopy")]
            internal static extern void CblasDcopy(int n, double* x, int incx, double* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ccopy")]
            internal static extern void CblasCcopy(int n, global::System.IntPtr x, int incx, global::System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zcopy")]
            internal static extern void CblasZcopy(int n, global::System.IntPtr x, int incx, global::System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_sswap")]
            internal static extern void CblasSswap(int n, float* x, int incx, float* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dswap")]
            internal static extern void CblasDswap(int n, double* x, int incx, double* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_cswap")]
            internal static extern void CblasCswap(int n, global::System.IntPtr x, int incx, global::System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zswap")]
            internal static extern void CblasZswap(int n, global::System.IntPtr x, int incx, global::System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_srot")]
            internal static extern void CblasSrot(int N, float* X, int incX, float* Y, int incY, float c, float s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_drot")]
            internal static extern void CblasDrot(int N, double* X, int incX, double* Y, int incY, double c, double s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_srotg")]
            internal static extern void CblasSrotg(float* a, float* b, float* c, float* s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_drotg")]
            internal static extern void CblasDrotg(double* a, double* b, double* c, double* s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_srotm")]
            internal static extern void CblasSrotm(int N, float* X, int incX, float* Y, int incY, float* P);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_drotm")]
            internal static extern void CblasDrotm(int N, double* X, int incX, double* Y, int incY, double* P);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_srotmg")]
            internal static extern void CblasSrotmg(float* d1, float* d2, float* b1, float b2, float* P);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_drotmg")]
            internal static extern void CblasDrotmg(double* d1, double* d2, double* b1, double b2, double* P);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_sscal")]
            internal static extern void CblasSscal(int N, float alpha, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dscal")]
            internal static extern void CblasDscal(int N, double alpha, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_cscal")]
            internal static extern void CblasCscal(int N, global::System.IntPtr alpha, global::System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zscal")]
            internal static extern void CblasZscal(int N, global::System.IntPtr alpha, global::System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_csscal")]
            internal static extern void CblasCsscal(int N, float alpha, global::System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zdscal")]
            internal static extern void CblasZdscal(int N, double alpha, global::System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_sgemv")]
            internal static extern void CblasSgemv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE trans, int m, int n, float alpha, float* a, int lda, float* x, int incx, float beta, float* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dgemv")]
            internal static extern void CblasDgemv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE trans, int m, int n, double alpha, double* a, int lda, double* x, int incx, double beta, double* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_cgemv")]
            internal static extern void CblasCgemv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE trans, int m, int n, global::System.IntPtr alpha, global::System.IntPtr a, int lda, global::System.IntPtr x, int incx, global::System.IntPtr beta, global::System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zgemv")]
            internal static extern void CblasZgemv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE trans, int m, int n, global::System.IntPtr alpha, global::System.IntPtr a, int lda, global::System.IntPtr x, int incx, global::System.IntPtr beta, global::System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_sger")]
            internal static extern void CblasSger(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, int M, int N, float alpha, float* X, int incX, float* Y, int incY, float* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dger")]
            internal static extern void CblasDger(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, int M, int N, double alpha, double* X, int incX, double* Y, int incY, double* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_cgeru")]
            internal static extern void CblasCgeru(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, int M, int N, global::System.IntPtr alpha, global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY, global::System.IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_cgerc")]
            internal static extern void CblasCgerc(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, int M, int N, global::System.IntPtr alpha, global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY, global::System.IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zgeru")]
            internal static extern void CblasZgeru(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, int M, int N, global::System.IntPtr alpha, global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY, global::System.IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zgerc")]
            internal static extern void CblasZgerc(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, int M, int N, global::System.IntPtr alpha, global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY, global::System.IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_strsv")]
            internal static extern void CblasStrsv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dtrsv")]
            internal static extern void CblasDtrsv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ctrsv")]
            internal static extern void CblasCtrsv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ztrsv")]
            internal static extern void CblasZtrsv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_strmv")]
            internal static extern void CblasStrmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dtrmv")]
            internal static extern void CblasDtrmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ctrmv")]
            internal static extern void CblasCtrmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ztrmv")]
            internal static extern void CblasZtrmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ssyr")]
            internal static extern void CblasSsyr(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, float alpha, float* X, int incX, float* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dsyr")]
            internal static extern void CblasDsyr(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, double alpha, double* X, int incX, double* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_cher")]
            internal static extern void CblasCher(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, float alpha, global::System.IntPtr X, int incX, global::System.IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zher")]
            internal static extern void CblasZher(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, double alpha, global::System.IntPtr X, int incX, global::System.IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ssyr2")]
            internal static extern void CblasSsyr2(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, float alpha, float* X, int incX, float* Y, int incY, float* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dsyr2")]
            internal static extern void CblasDsyr2(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, double alpha, double* X, int incX, double* Y, int incY, double* A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_cher2")]
            internal static extern void CblasCher2(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, global::System.IntPtr alpha, global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY, global::System.IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zher2")]
            internal static extern void CblasZher2(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, global::System.IntPtr alpha, global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY, global::System.IntPtr A, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_sgbmv")]
            internal static extern void CblasSgbmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, int M, int N, int KL, int KU, float alpha, float* A, int lda, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dgbmv")]
            internal static extern void CblasDgbmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, int M, int N, int KL, int KU, double alpha, double* A, int lda, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_cgbmv")]
            internal static extern void CblasCgbmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, int M, int N, int KL, int KU, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX, global::System.IntPtr beta, global::System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zgbmv")]
            internal static extern void CblasZgbmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, int M, int N, int KL, int KU, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX, global::System.IntPtr beta, global::System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ssbmv")]
            internal static extern void CblasSsbmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, int K, float alpha, float* A, int lda, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dsbmv")]
            internal static extern void CblasDsbmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, int K, double alpha, double* A, int lda, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_stbmv")]
            internal static extern void CblasStbmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, int K, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dtbmv")]
            internal static extern void CblasDtbmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, int K, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ctbmv")]
            internal static extern void CblasCtbmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, int K, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ztbmv")]
            internal static extern void CblasZtbmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, int K, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_stbsv")]
            internal static extern void CblasStbsv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, int K, float* A, int lda, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dtbsv")]
            internal static extern void CblasDtbsv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, int K, double* A, int lda, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ctbsv")]
            internal static extern void CblasCtbsv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, int K, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ztbsv")]
            internal static extern void CblasZtbsv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, int K, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_stpmv")]
            internal static extern void CblasStpmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, float* Ap, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dtpmv")]
            internal static extern void CblasDtpmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, double* Ap, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ctpmv")]
            internal static extern void CblasCtpmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, global::System.IntPtr Ap, global::System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ztpmv")]
            internal static extern void CblasZtpmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, global::System.IntPtr Ap, global::System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_stpsv")]
            internal static extern void CblasStpsv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, float* Ap, float* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dtpsv")]
            internal static extern void CblasDtpsv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, double* Ap, double* X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ctpsv")]
            internal static extern void CblasCtpsv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, global::System.IntPtr Ap, global::System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ztpsv")]
            internal static extern void CblasZtpsv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int N, global::System.IntPtr Ap, global::System.IntPtr X, int incX);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ssymv")]
            internal static extern void CblasSsymv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, float alpha, float* A, int lda, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dsymv")]
            internal static extern void CblasDsymv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, double alpha, double* A, int lda, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_chemv")]
            internal static extern void CblasChemv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX, global::System.IntPtr beta, global::System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zhemv")]
            internal static extern void CblasZhemv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX, global::System.IntPtr beta, global::System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_sspmv")]
            internal static extern void CblasSspmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, float alpha, float* Ap, float* X, int incX, float beta, float* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dspmv")]
            internal static extern void CblasDspmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, double alpha, double* Ap, double* X, int incX, double beta, double* Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_sspr")]
            internal static extern void CblasSspr(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, float alpha, float* X, int incX, float* Ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dspr")]
            internal static extern void CblasDspr(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, double alpha, double* X, int incX, double* Ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_chpr")]
            internal static extern void CblasChpr(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, float alpha, global::System.IntPtr X, int incX, global::System.IntPtr A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zhpr")]
            internal static extern void CblasZhpr(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, double alpha, global::System.IntPtr X, int incX, global::System.IntPtr A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_sspr2")]
            internal static extern void CblasSspr2(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, float alpha, float* X, int incX, float* Y, int incY, float* A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dspr2")]
            internal static extern void CblasDspr2(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, double alpha, double* X, int incX, double* Y, int incY, double* A);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_chpr2")]
            internal static extern void CblasChpr2(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, global::System.IntPtr alpha, global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY, global::System.IntPtr Ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zhpr2")]
            internal static extern void CblasZhpr2(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, global::System.IntPtr alpha, global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY, global::System.IntPtr Ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_chbmv")]
            internal static extern void CblasChbmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX, global::System.IntPtr beta, global::System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zhbmv")]
            internal static extern void CblasZhbmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX, global::System.IntPtr beta, global::System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_chpmv")]
            internal static extern void CblasChpmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, global::System.IntPtr alpha, global::System.IntPtr Ap, global::System.IntPtr X, int incX, global::System.IntPtr beta, global::System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zhpmv")]
            internal static extern void CblasZhpmv(global::Spreads.Native.OpenBLAS.CBLAS_ORDER order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int N, global::System.IntPtr alpha, global::System.IntPtr Ap, global::System.IntPtr X, int incX, global::System.IntPtr beta, global::System.IntPtr Y, int incY);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_sgemm")]
            internal static extern void CblasSgemm(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransB, int M, int N, int K, float alpha, float* A, int lda, float* B, int ldb, float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dgemm")]
            internal static extern void CblasDgemm(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransB, int M, int N, int K, double alpha, double* A, int lda, double* B, int ldb, double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_cgemm")]
            internal static extern void CblasCgemm(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransB, int M, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb, global::System.IntPtr beta, global::System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_cgemm3m")]
            internal static extern void CblasCgemm3m(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransB, int M, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb, global::System.IntPtr beta, global::System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zgemm")]
            internal static extern void CblasZgemm(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransB, int M, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb, global::System.IntPtr beta, global::System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zgemm3m")]
            internal static extern void CblasZgemm3m(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransB, int M, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb, global::System.IntPtr beta, global::System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ssymm")]
            internal static extern void CblasSsymm(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_SIDE Side, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int M, int N, float alpha, float* A, int lda, float* B, int ldb, float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dsymm")]
            internal static extern void CblasDsymm(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_SIDE Side, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int M, int N, double alpha, double* A, int lda, double* B, int ldb, double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_csymm")]
            internal static extern void CblasCsymm(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_SIDE Side, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int M, int N, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb, global::System.IntPtr beta, global::System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zsymm")]
            internal static extern void CblasZsymm(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_SIDE Side, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int M, int N, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb, global::System.IntPtr beta, global::System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ssyrk")]
            internal static extern void CblasSsyrk(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE Trans, int N, int K, float alpha, float* A, int lda, float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dsyrk")]
            internal static extern void CblasDsyrk(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE Trans, int N, int K, double alpha, double* A, int lda, double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_csyrk")]
            internal static extern void CblasCsyrk(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE Trans, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr beta, global::System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zsyrk")]
            internal static extern void CblasZsyrk(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE Trans, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr beta, global::System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ssyr2k")]
            internal static extern void CblasSsyr2k(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE Trans, int N, int K, float alpha, float* A, int lda, float* B, int ldb, float beta, float* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dsyr2k")]
            internal static extern void CblasDsyr2k(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE Trans, int N, int K, double alpha, double* A, int lda, double* B, int ldb, double beta, double* C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_csyr2k")]
            internal static extern void CblasCsyr2k(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE Trans, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb, global::System.IntPtr beta, global::System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zsyr2k")]
            internal static extern void CblasZsyr2k(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE Trans, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb, global::System.IntPtr beta, global::System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_strmm")]
            internal static extern void CblasStrmm(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_SIDE Side, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int M, int N, float alpha, float* A, int lda, float* B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dtrmm")]
            internal static extern void CblasDtrmm(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_SIDE Side, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int M, int N, double alpha, double* A, int lda, double* B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ctrmm")]
            internal static extern void CblasCtrmm(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_SIDE Side, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int M, int N, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ztrmm")]
            internal static extern void CblasZtrmm(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_SIDE Side, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int M, int N, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_strsm")]
            internal static extern void CblasStrsm(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_SIDE Side, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int M, int N, float alpha, float* A, int lda, float* B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dtrsm")]
            internal static extern void CblasDtrsm(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_SIDE Side, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int M, int N, double alpha, double* A, int lda, double* B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ctrsm")]
            internal static extern void CblasCtrsm(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_SIDE Side, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int M, int N, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_ztrsm")]
            internal static extern void CblasZtrsm(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_SIDE Side, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE TransA, global::Spreads.Native.OpenBLAS.CBLAS_DIAG Diag, int M, int N, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_chemm")]
            internal static extern void CblasChemm(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_SIDE Side, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int M, int N, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb, global::System.IntPtr beta, global::System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zhemm")]
            internal static extern void CblasZhemm(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_SIDE Side, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, int M, int N, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb, global::System.IntPtr beta, global::System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_cherk")]
            internal static extern void CblasCherk(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE Trans, int N, int K, float alpha, global::System.IntPtr A, int lda, float beta, global::System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zherk")]
            internal static extern void CblasZherk(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE Trans, int N, int K, double alpha, global::System.IntPtr A, int lda, double beta, global::System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_cher2k")]
            internal static extern void CblasCher2k(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE Trans, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb, float beta, global::System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zher2k")]
            internal static extern void CblasZher2k(global::Spreads.Native.OpenBLAS.CBLAS_ORDER Order, global::Spreads.Native.OpenBLAS.CBLAS_UPLO Uplo, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE Trans, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb, double beta, global::System.IntPtr C, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_xerbla")]
            internal static extern void CblasXerbla(int p, sbyte* rout, sbyte* form);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_saxpby")]
            internal static extern void CblasSaxpby(int n, float alpha, float* x, int incx, float beta, float* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_daxpby")]
            internal static extern void CblasDaxpby(int n, double alpha, double* x, int incx, double beta, double* y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_caxpby")]
            internal static extern void CblasCaxpby(int n, global::System.IntPtr alpha, global::System.IntPtr x, int incx, global::System.IntPtr beta, global::System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zaxpby")]
            internal static extern void CblasZaxpby(int n, global::System.IntPtr alpha, global::System.IntPtr x, int incx, global::System.IntPtr beta, global::System.IntPtr y, int incy);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_somatcopy")]
            internal static extern void CblasSomatcopy(global::Spreads.Native.OpenBLAS.CBLAS_ORDER CORDER, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE CTRANS, int crows, int ccols, float calpha, float* a, int clda, float* b, int cldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_domatcopy")]
            internal static extern void CblasDomatcopy(global::Spreads.Native.OpenBLAS.CBLAS_ORDER CORDER, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE CTRANS, int crows, int ccols, double calpha, double* a, int clda, double* b, int cldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_comatcopy")]
            internal static extern void CblasComatcopy(global::Spreads.Native.OpenBLAS.CBLAS_ORDER CORDER, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE CTRANS, int crows, int ccols, float* calpha, float* a, int clda, float* b, int cldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zomatcopy")]
            internal static extern void CblasZomatcopy(global::Spreads.Native.OpenBLAS.CBLAS_ORDER CORDER, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE CTRANS, int crows, int ccols, double* calpha, double* a, int clda, double* b, int cldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_simatcopy")]
            internal static extern void CblasSimatcopy(global::Spreads.Native.OpenBLAS.CBLAS_ORDER CORDER, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE CTRANS, int crows, int ccols, float calpha, float* a, int clda, int cldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dimatcopy")]
            internal static extern void CblasDimatcopy(global::Spreads.Native.OpenBLAS.CBLAS_ORDER CORDER, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE CTRANS, int crows, int ccols, double calpha, double* a, int clda, int cldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_cimatcopy")]
            internal static extern void CblasCimatcopy(global::Spreads.Native.OpenBLAS.CBLAS_ORDER CORDER, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE CTRANS, int crows, int ccols, float* calpha, float* a, int clda, int cldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zimatcopy")]
            internal static extern void CblasZimatcopy(global::Spreads.Native.OpenBLAS.CBLAS_ORDER CORDER, global::Spreads.Native.OpenBLAS.CBLAS_TRANSPOSE CTRANS, int crows, int ccols, double* calpha, double* a, int clda, int cldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_sgeadd")]
            internal static extern void CblasSgeadd(global::Spreads.Native.OpenBLAS.CBLAS_ORDER CORDER, int crows, int ccols, float calpha, float* a, int clda, float cbeta, float* c, int cldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_dgeadd")]
            internal static extern void CblasDgeadd(global::Spreads.Native.OpenBLAS.CBLAS_ORDER CORDER, int crows, int ccols, double calpha, double* a, int clda, double cbeta, double* c, int cldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_cgeadd")]
            internal static extern void CblasCgeadd(global::Spreads.Native.OpenBLAS.CBLAS_ORDER CORDER, int crows, int ccols, float* calpha, float* a, int clda, float* cbeta, float* c, int cldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="cblas_zgeadd")]
            internal static extern void CblasZgeadd(global::Spreads.Native.OpenBLAS.CBLAS_ORDER CORDER, int crows, int ccols, double* calpha, double* a, int clda, double* cbeta, double* c, int cldc);
        
        }
    }
}