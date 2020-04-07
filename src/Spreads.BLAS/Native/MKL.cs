using System.Runtime.InteropServices;
using System.Security;

namespace Spreads.Native
{
    public static unsafe class MKL
    {
        public static readonly bool IsSupoprted = Init();

        private static bool Init()
        {
            try
            {
                return BLASSettings.UseMKLIfAvailable && MKL_GetMaxThreads() > 0;
            }
            catch
            {
            }

            return false;
        }
        
        public enum CBLAS_LAYOUT
        {
            CblasRowMajor = 101,
            CblasColMajor = 102
        }

        public enum CBLAS_TRANSPOSE
        {
            CblasNoTrans = 111,
            CblasTrans = 112,
            CblasConjTrans = 113
        }

        public enum CBLAS_UPLO
        {
            CblasUpper = 121,
            CblasLower = 122
        }

        public enum CBLAS_DIAG
        {
            CblasNonUnit = 131,
            CblasUnit = 132
        }

        public enum CBLAS_SIDE
        {
            CblasLeft = 141,
            CblasRight = 142
        }

        public enum CBLAS_STORAGE
        {
            CblasPacked = 151
        }

        public enum CBLAS_IDENTIFIER
        {
            CblasAMatrix = 161,
            CblasBMatrix = 162
        }

        public enum CBLAS_OFFSET
        {
            CblasRowOffset = 171,
            CblasColOffset = 172,
            CblasFixOffset = 173
        }

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dcabs1")]
        internal static extern double CblasDcabs1(global::System.IntPtr z);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_scabs1")]
        internal static extern float CblasScabs1(global::System.IntPtr c);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sdot")]
        internal static extern float CblasSdot(int N, float* X, int incX, float* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sdoti")]
        internal static extern float CblasSdoti(int N, float* X, int* indx, float* Y);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ddot")]
        internal static extern double CblasDdot(int N, double* X, int incX, double* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ddoti")]
        internal static extern double CblasDdoti(int N, double* X, int* indx, double* Y);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dsdot")]
        internal static extern double CblasDsdot(int N, float* X, int incX, float* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sdsdot")]
        internal static extern float CblasSdsdot(int N, float sb, float* X, int incX, float* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cdotu_sub")]
        internal static extern void CblasCdotuSub(int N, global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY, global::System.IntPtr dotu);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cdotui_sub")]
        internal static extern void CblasCdotuiSub(int N, global::System.IntPtr X, int* indx, global::System.IntPtr Y, global::System.IntPtr dotui);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cdotc_sub")]
        internal static extern void CblasCdotcSub(int N, global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY, global::System.IntPtr dotc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cdotci_sub")]
        internal static extern void CblasCdotciSub(int N, global::System.IntPtr X, int* indx, global::System.IntPtr Y, global::System.IntPtr dotui);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zdotu_sub")]
        internal static extern void CblasZdotuSub(int N, global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY, global::System.IntPtr dotu);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zdotui_sub")]
        internal static extern void CblasZdotuiSub(int N, global::System.IntPtr X, int* indx, global::System.IntPtr Y, global::System.IntPtr dotui);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zdotc_sub")]
        internal static extern void CblasZdotcSub(int N, global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY, global::System.IntPtr dotc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zdotci_sub")]
        internal static extern void CblasZdotciSub(int N, global::System.IntPtr X, int* indx, global::System.IntPtr Y, global::System.IntPtr dotui);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_snrm2")]
        internal static extern float CblasSnrm2(int N, float* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sasum")]
        internal static extern float CblasSasum(int N, float* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dnrm2")]
        internal static extern double CblasDnrm2(int N, double* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dasum")]
        internal static extern double CblasDasum(int N, double* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_scnrm2")]
        internal static extern float CblasScnrm2(int N, global::System.IntPtr X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_scasum")]
        internal static extern float CblasScasum(int N, global::System.IntPtr X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dznrm2")]
        internal static extern double CblasDznrm2(int N, global::System.IntPtr X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dzasum")]
        internal static extern double CblasDzasum(int N, global::System.IntPtr X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_isamax")]
        internal static extern ulong CblasIsamax(int N, float* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_idamax")]
        internal static extern ulong CblasIdamax(int N, double* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_icamax")]
        internal static extern ulong CblasIcamax(int N, global::System.IntPtr X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_izamax")]
        internal static extern ulong CblasIzamax(int N, global::System.IntPtr X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_isamin")]
        internal static extern ulong CblasIsamin(int N, float* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_idamin")]
        internal static extern ulong CblasIdamin(int N, double* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_icamin")]
        internal static extern ulong CblasIcamin(int N, global::System.IntPtr X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_izamin")]
        internal static extern ulong CblasIzamin(int N, global::System.IntPtr X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sswap")]
        internal static extern void CblasSswap(int N, float* X, int incX, float* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_scopy")]
        internal static extern void CblasScopy(int N, float* X, int incX, float* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_saxpy")]
        internal static extern void CblasSaxpy(int N, float alpha, float* X, int incX, float* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_saxpby")]
        internal static extern void CblasSaxpby(int N, float alpha, float* X, int incX, float beta, float* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_saxpyi")]
        internal static extern void CblasSaxpyi(int N, float alpha, float* X, int* indx, float* Y);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sgthr")]
        internal static extern void CblasSgthr(int N, float* Y, float* X, int* indx);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sgthrz")]
        internal static extern void CblasSgthrz(int N, float* Y, float* X, int* indx);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ssctr")]
        internal static extern void CblasSsctr(int N, float* X, int* indx, float* Y);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_srotg")]
        internal static extern void CblasSrotg(float* a, float* b, float* c, float* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dswap")]
        internal static extern void CblasDswap(int N, double* X, int incX, double* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dcopy")]
        internal static extern void CblasDcopy(int N, double* X, int incX, double* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_daxpy")]
        internal static extern void CblasDaxpy(int N, double alpha, double* X, int incX, double* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_daxpby")]
        internal static extern void CblasDaxpby(int N, double alpha, double* X, int incX, double beta, double* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_daxpyi")]
        internal static extern void CblasDaxpyi(int N, double alpha, double* X, int* indx, double* Y);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dgthr")]
        internal static extern void CblasDgthr(int N, double* Y, double* X, int* indx);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dgthrz")]
        internal static extern void CblasDgthrz(int N, double* Y, double* X, int* indx);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dsctr")]
        internal static extern void CblasDsctr(int N, double* X, int* indx, double* Y);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_drotg")]
        internal static extern void CblasDrotg(double* a, double* b, double* c, double* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cswap")]
        internal static extern void CblasCswap(int N, global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ccopy")]
        internal static extern void CblasCcopy(int N, global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_caxpy")]
        internal static extern void CblasCaxpy(int N, global::System.IntPtr alpha, global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_caxpby")]
        internal static extern void CblasCaxpby(int N, global::System.IntPtr alpha, global::System.IntPtr X, int incX, global::System.IntPtr beta, global::System.IntPtr Y,
            int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_caxpyi")]
        internal static extern void CblasCaxpyi(int N, global::System.IntPtr alpha, global::System.IntPtr X, int* indx, global::System.IntPtr Y);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cgthr")]
        internal static extern void CblasCgthr(int N, global::System.IntPtr Y, global::System.IntPtr X, int* indx);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cgthrz")]
        internal static extern void CblasCgthrz(int N, global::System.IntPtr Y, global::System.IntPtr X, int* indx);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_csctr")]
        internal static extern void CblasCsctr(int N, global::System.IntPtr X, int* indx, global::System.IntPtr Y);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_crotg")]
        internal static extern void CblasCrotg(global::System.IntPtr a, global::System.IntPtr b, float* c, global::System.IntPtr s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zswap")]
        internal static extern void CblasZswap(int N, global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zcopy")]
        internal static extern void CblasZcopy(int N, global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zaxpy")]
        internal static extern void CblasZaxpy(int N, global::System.IntPtr alpha, global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zaxpby")]
        internal static extern void CblasZaxpby(int N, global::System.IntPtr alpha, global::System.IntPtr X, int incX, global::System.IntPtr beta, global::System.IntPtr Y,
            int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zaxpyi")]
        internal static extern void CblasZaxpyi(int N, global::System.IntPtr alpha, global::System.IntPtr X, int* indx, global::System.IntPtr Y);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zgthr")]
        internal static extern void CblasZgthr(int N, global::System.IntPtr Y, global::System.IntPtr X, int* indx);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zgthrz")]
        internal static extern void CblasZgthrz(int N, global::System.IntPtr Y, global::System.IntPtr X, int* indx);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zsctr")]
        internal static extern void CblasZsctr(int N, global::System.IntPtr X, int* indx, global::System.IntPtr Y);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zrotg")]
        internal static extern void CblasZrotg(global::System.IntPtr a, global::System.IntPtr b, double* c, global::System.IntPtr s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_srotmg")]
        internal static extern void CblasSrotmg(float* d1, float* d2, float* b1, float b2, float* P);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_srot")]
        internal static extern void CblasSrot(int N, float* X, int incX, float* Y, int incY, float c, float s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sroti")]
        internal static extern void CblasSroti(int N, float* X, int* indx, float* Y, float c, float s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_srotm")]
        internal static extern void CblasSrotm(int N, float* X, int incX, float* Y, int incY, float* P);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_drotmg")]
        internal static extern void CblasDrotmg(double* d1, double* d2, double* b1, double b2, double* P);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_drot")]
        internal static extern void CblasDrot(int N, double* X, int incX, double* Y, int incY, double c, double s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_drotm")]
        internal static extern void CblasDrotm(int N, double* X, int incX, double* Y, int incY, double* P);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_droti")]
        internal static extern void CblasDroti(int N, double* X, int* indx, double* Y, double c, double s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_csrot")]
        internal static extern void CblasCsrot(int N, global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY, float c, float s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zdrot")]
        internal static extern void CblasZdrot(int N, global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY, double c, double s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sscal")]
        internal static extern void CblasSscal(int N, float alpha, float* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dscal")]
        internal static extern void CblasDscal(int N, double alpha, double* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cscal")]
        internal static extern void CblasCscal(int N, global::System.IntPtr alpha, global::System.IntPtr X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zscal")]
        internal static extern void CblasZscal(int N, global::System.IntPtr alpha, global::System.IntPtr X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_csscal")]
        internal static extern void CblasCsscal(int N, float alpha, global::System.IntPtr X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zdscal")]
        internal static extern void CblasZdscal(int N, double alpha, global::System.IntPtr X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sgemv")]
        internal static extern void CblasSgemv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, int M, int N, float alpha, float* A,
            int lda, float* X, int incX, float beta, float* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sgbmv")]
        internal static extern void CblasSgbmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, int M, int N, int KL, int KU,
            float alpha, float* A, int lda, float* X, int incX, float beta, float* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_strmv")]
        internal static extern void CblasStrmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, float* A, int lda, float* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_stbmv")]
        internal static extern void CblasStbmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, int K, float* A, int lda, float* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_stpmv")]
        internal static extern void CblasStpmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, float* Ap, float* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_strsv")]
        internal static extern void CblasStrsv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, float* A, int lda, float* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_stbsv")]
        internal static extern void CblasStbsv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, int K, float* A, int lda, float* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_stpsv")]
        internal static extern void CblasStpsv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, float* Ap, float* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dgemv")]
        internal static extern void CblasDgemv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, int M, int N, double alpha, double* A,
            int lda, double* X, int incX, double beta, double* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dgbmv")]
        internal static extern void CblasDgbmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, int M, int N, int KL, int KU,
            double alpha, double* A, int lda, double* X, int incX, double beta, double* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dtrmv")]
        internal static extern void CblasDtrmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, double* A, int lda, double* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dtbmv")]
        internal static extern void CblasDtbmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, int K, double* A, int lda, double* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dtpmv")]
        internal static extern void CblasDtpmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, double* Ap, double* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dtrsv")]
        internal static extern void CblasDtrsv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, double* A, int lda, double* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dtbsv")]
        internal static extern void CblasDtbsv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, int K, double* A, int lda, double* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dtpsv")]
        internal static extern void CblasDtpsv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, double* Ap, double* X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cgemv")]
        internal static extern void CblasCgemv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, int M, int N,
            global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX, global::System.IntPtr beta, global::System.IntPtr Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cgbmv")]
        internal static extern void CblasCgbmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, int M, int N, int KL, int KU,
            global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX, global::System.IntPtr beta, global::System.IntPtr Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ctrmv")]
        internal static extern void CblasCtrmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ctbmv")]
        internal static extern void CblasCtbmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, int K, global::System.IntPtr A, int lda, global::System.IntPtr X,
            int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ctpmv")]
        internal static extern void CblasCtpmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, global::System.IntPtr Ap, global::System.IntPtr X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ctrsv")]
        internal static extern void CblasCtrsv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ctbsv")]
        internal static extern void CblasCtbsv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, int K, global::System.IntPtr A, int lda, global::System.IntPtr X,
            int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ctpsv")]
        internal static extern void CblasCtpsv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, global::System.IntPtr Ap, global::System.IntPtr X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zgemv")]
        internal static extern void CblasZgemv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, int M, int N,
            global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX, global::System.IntPtr beta, global::System.IntPtr Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zgbmv")]
        internal static extern void CblasZgbmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, int M, int N, int KL, int KU,
            global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX, global::System.IntPtr beta, global::System.IntPtr Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ztrmv")]
        internal static extern void CblasZtrmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ztbmv")]
        internal static extern void CblasZtbmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, int K, global::System.IntPtr A, int lda, global::System.IntPtr X,
            int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ztpmv")]
        internal static extern void CblasZtpmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, global::System.IntPtr Ap, global::System.IntPtr X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ztrsv")]
        internal static extern void CblasZtrsv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, global::System.IntPtr A, int lda, global::System.IntPtr X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ztbsv")]
        internal static extern void CblasZtbsv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, int K, global::System.IntPtr A, int lda, global::System.IntPtr X,
            int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ztpsv")]
        internal static extern void CblasZtpsv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int N, global::System.IntPtr Ap, global::System.IntPtr X, int incX);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ssymv")]
        internal static extern void CblasSsymv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, float alpha, float* A, int lda,
            float* X, int incX, float beta, float* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ssbmv")]
        internal static extern void CblasSsbmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, int K, float alpha, float* A, int lda,
            float* X, int incX, float beta, float* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sspmv")]
        internal static extern void CblasSspmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, float alpha, float* Ap, float* X,
            int incX, float beta, float* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sger")]
        internal static extern void CblasSger(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, int M, int N, float alpha, float* X, int incX, float* Y, int incY, float* A, int lda);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ssyr")]
        internal static extern void CblasSsyr(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, float alpha, float* X, int incX,
            float* A, int lda);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sspr")]
        internal static extern void CblasSspr(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, float alpha, float* X, int incX,
            float* Ap);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ssyr2")]
        internal static extern void CblasSsyr2(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, float alpha, float* X, int incX,
            float* Y, int incY, float* A, int lda);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sspr2")]
        internal static extern void CblasSspr2(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, float alpha, float* X, int incX,
            float* Y, int incY, float* A);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dsymv")]
        internal static extern void CblasDsymv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, double alpha, double* A, int lda,
            double* X, int incX, double beta, double* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dsbmv")]
        internal static extern void CblasDsbmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, int K, double alpha, double* A,
            int lda, double* X, int incX, double beta, double* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dspmv")]
        internal static extern void CblasDspmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, double alpha, double* Ap, double* X,
            int incX, double beta, double* Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dger")]
        internal static extern void CblasDger(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, int M, int N, double alpha, double* X, int incX, double* Y, int incY, double* A,
            int lda);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dsyr")]
        internal static extern void CblasDsyr(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, double alpha, double* X, int incX,
            double* A, int lda);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dspr")]
        internal static extern void CblasDspr(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, double alpha, double* X, int incX,
            double* Ap);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dsyr2")]
        internal static extern void CblasDsyr2(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, double alpha, double* X, int incX,
            double* Y, int incY, double* A, int lda);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dspr2")]
        internal static extern void CblasDspr2(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, double alpha, double* X, int incX,
            double* Y, int incY, double* A);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_chemv")]
        internal static extern void CblasChemv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, global::System.IntPtr alpha,
            global::System.IntPtr A, int lda, global::System.IntPtr X, int incX, global::System.IntPtr beta, global::System.IntPtr Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_chbmv")]
        internal static extern void CblasChbmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, int K, global::System.IntPtr alpha,
            global::System.IntPtr A, int lda, global::System.IntPtr X, int incX, global::System.IntPtr beta, global::System.IntPtr Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_chpmv")]
        internal static extern void CblasChpmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, global::System.IntPtr alpha,
            global::System.IntPtr Ap, global::System.IntPtr X, int incX, global::System.IntPtr beta, global::System.IntPtr Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cgeru")]
        internal static extern void CblasCgeru(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, int M, int N, global::System.IntPtr alpha, global::System.IntPtr X, int incX,
            global::System.IntPtr Y, int incY, global::System.IntPtr A, int lda);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cgerc")]
        internal static extern void CblasCgerc(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, int M, int N, global::System.IntPtr alpha, global::System.IntPtr X, int incX,
            global::System.IntPtr Y, int incY, global::System.IntPtr A, int lda);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cher")]
        internal static extern void CblasCher(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, float alpha, global::System.IntPtr X,
            int incX, global::System.IntPtr A, int lda);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_chpr")]
        internal static extern void CblasChpr(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, float alpha, global::System.IntPtr X,
            int incX, global::System.IntPtr A);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cher2")]
        internal static extern void CblasCher2(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, global::System.IntPtr alpha,
            global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY, global::System.IntPtr A, int lda);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_chpr2")]
        internal static extern void CblasChpr2(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, global::System.IntPtr alpha,
            global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY, global::System.IntPtr Ap);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zhemv")]
        internal static extern void CblasZhemv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, global::System.IntPtr alpha,
            global::System.IntPtr A, int lda, global::System.IntPtr X, int incX, global::System.IntPtr beta, global::System.IntPtr Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zhbmv")]
        internal static extern void CblasZhbmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, int K, global::System.IntPtr alpha,
            global::System.IntPtr A, int lda, global::System.IntPtr X, int incX, global::System.IntPtr beta, global::System.IntPtr Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zhpmv")]
        internal static extern void CblasZhpmv(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, global::System.IntPtr alpha,
            global::System.IntPtr Ap, global::System.IntPtr X, int incX, global::System.IntPtr beta, global::System.IntPtr Y, int incY);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zgeru")]
        internal static extern void CblasZgeru(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, int M, int N, global::System.IntPtr alpha, global::System.IntPtr X, int incX,
            global::System.IntPtr Y, int incY, global::System.IntPtr A, int lda);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zgerc")]
        internal static extern void CblasZgerc(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, int M, int N, global::System.IntPtr alpha, global::System.IntPtr X, int incX,
            global::System.IntPtr Y, int incY, global::System.IntPtr A, int lda);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zher")]
        internal static extern void CblasZher(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, double alpha, global::System.IntPtr X,
            int incX, global::System.IntPtr A, int lda);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zhpr")]
        internal static extern void CblasZhpr(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, double alpha, global::System.IntPtr X,
            int incX, global::System.IntPtr A);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zher2")]
        internal static extern void CblasZher2(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, global::System.IntPtr alpha,
            global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY, global::System.IntPtr A, int lda);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zhpr2")]
        internal static extern void CblasZhpr2(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo, int N, global::System.IntPtr alpha,
            global::System.IntPtr X, int incX, global::System.IntPtr Y, int incY, global::System.IntPtr Ap);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sgemm")]
        internal static extern void CblasSgemm(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransB, int M, int N, int K, float alpha, float* A, int lda, float* B, int ldb, float beta, float* C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sgemm_batch")]
        internal static extern void CblasSgemmBatch(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE* TransA_Array,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE* TransB_Array, int* M_Array, int* N_Array, int* K_Array, float* alpha_Array, float** A_Array, int* lda_Array, float** B_Array,
            int* ldb_Array, float* beta_Array, float** C_Array, int* ldc_Array, int group_count, int* group_size);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sgemmt")]
        internal static extern void CblasSgemmt(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransB, int N, int K, float alpha, float* A, int lda, float* B, int ldb,
            float beta, float* C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ssymm")]
        internal static extern void CblasSsymm(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_SIDE Side, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            int M, int N, float alpha, float* A, int lda, float* B, int ldb, float beta, float* C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ssyrk")]
        internal static extern void CblasSsyrk(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE Trans, int N, int K, float alpha, float* A, int lda, float beta, float* C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ssyr2k")]
        internal static extern void CblasSsyr2k(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE Trans, int N, int K, float alpha, float* A, int lda, float* B, int ldb, float beta, float* C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_strmm")]
        internal static extern void CblasStrmm(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_SIDE Side, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int M, int N, float alpha, float* A, int lda, float* B, int ldb);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_strsm")]
        internal static extern void CblasStrsm(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_SIDE Side, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int M, int N, float alpha, float* A, int lda, float* B, int ldb);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_strsm_batch")]
        internal static extern void CblasStrsmBatch(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_SIDE* Side_Array,
            global::Spreads.Native.MKL.CBLAS_UPLO* Uplo_Array, global::Spreads.Native.MKL.CBLAS_TRANSPOSE* TransA_Array, global::Spreads.Native.MKL.CBLAS_DIAG* Diag_Array, int* M_Array,
            int* N_Array, float* alpha_Array, float** A_Array, int* lda_Array, float** B_Array, int* ldb_Array, int group_count, int* group_size);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dgemm")]
        internal static extern void CblasDgemm(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransB, int M, int N, int K, double alpha, double* A, int lda, double* B, int ldb, double beta, double* C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dgemm_batch")]
        internal static extern void CblasDgemmBatch(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE* TransA_Array,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE* TransB_Array, int* M_Array, int* N_Array, int* K_Array, double* alpha_Array, double** A_Array, int* lda_Array,
            double** B_Array, int* ldb_Array, double* beta_Array, double** C_Array, int* ldc_Array, int group_count, int* group_size);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dgemmt")]
        internal static extern void CblasDgemmt(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransB, int N, int K, double alpha, double* A, int lda, double* B, int ldb,
            double beta, double* C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dsymm")]
        internal static extern void CblasDsymm(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_SIDE Side, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            int M, int N, double alpha, double* A, int lda, double* B, int ldb, double beta, double* C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dsyrk")]
        internal static extern void CblasDsyrk(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE Trans, int N, int K, double alpha, double* A, int lda, double beta, double* C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dsyr2k")]
        internal static extern void CblasDsyr2k(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE Trans, int N, int K, double alpha, double* A, int lda, double* B, int ldb, double beta, double* C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dtrmm")]
        internal static extern void CblasDtrmm(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_SIDE Side, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int M, int N, double alpha, double* A, int lda, double* B, int ldb);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dtrsm")]
        internal static extern void CblasDtrsm(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_SIDE Side, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int M, int N, double alpha, double* A, int lda, double* B, int ldb);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dtrsm_batch")]
        internal static extern void CblasDtrsmBatch(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_SIDE* Side_Array,
            global::Spreads.Native.MKL.CBLAS_UPLO* Uplo_Array, global::Spreads.Native.MKL.CBLAS_TRANSPOSE* Transa_Array, global::Spreads.Native.MKL.CBLAS_DIAG* Diag_Array, int* M_Array,
            int* N_Array, double* alpha_Array, double** A_Array, int* lda_Array, double** B_Array, int* ldb_Array, int group_count, int* group_size);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cgemm")]
        internal static extern void CblasCgemm(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransB, int M, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb,
            global::System.IntPtr beta, global::System.IntPtr C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cgemm3m")]
        internal static extern void CblasCgemm3m(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransB, int M, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb,
            global::System.IntPtr beta, global::System.IntPtr C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cgemm_batch")]
        internal static extern void CblasCgemmBatch(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE* TransA_Array,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE* TransB_Array, int* M_Array, int* N_Array, int* K_Array, global::System.IntPtr alpha_Array, void** A_Array, int* lda_Array,
            void** B_Array, int* ldb_Array, global::System.IntPtr beta_Array, void** C_Array, int* ldc_Array, int group_count, int* group_size);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cgemm3m_batch")]
        internal static extern void CblasCgemm3mBatch(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE* TransA_Array,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE* TransB_Array, int* M_Array, int* N_Array, int* K_Array, global::System.IntPtr alpha_Array, void** A_Array, int* lda_Array,
            void** B_Array, int* ldb_Array, global::System.IntPtr beta_Array, void** C_Array, int* ldc_Array, int group_count, int* group_size);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cgemmt")]
        internal static extern void CblasCgemmt(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransB, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A,
            int lda, global::System.IntPtr B, int ldb, global::System.IntPtr beta, global::System.IntPtr C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_csymm")]
        internal static extern void CblasCsymm(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_SIDE Side, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            int M, int N, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb, global::System.IntPtr beta, global::System.IntPtr C,
            int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_csyrk")]
        internal static extern void CblasCsyrk(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE Trans, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr beta,
            global::System.IntPtr C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_csyr2k")]
        internal static extern void CblasCsyr2k(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE Trans, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb,
            global::System.IntPtr beta, global::System.IntPtr C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ctrmm")]
        internal static extern void CblasCtrmm(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_SIDE Side, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int M, int N, global::System.IntPtr alpha, global::System.IntPtr A, int lda,
            global::System.IntPtr B, int ldb);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ctrsm")]
        internal static extern void CblasCtrsm(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_SIDE Side, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int M, int N, global::System.IntPtr alpha, global::System.IntPtr A, int lda,
            global::System.IntPtr B, int ldb);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ctrsm_batch")]
        internal static extern void CblasCtrsmBatch(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_SIDE* Side_Array,
            global::Spreads.Native.MKL.CBLAS_UPLO* Uplo_Array, global::Spreads.Native.MKL.CBLAS_TRANSPOSE* Transa_Array, global::Spreads.Native.MKL.CBLAS_DIAG* Diag_Array, int* M_Array,
            int* N_Array, global::System.IntPtr alpha_Array, void** A_Array, int* lda_Array, void** B_Array, int* ldb_Array, int group_count, int* group_size);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zgemm")]
        internal static extern void CblasZgemm(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransB, int M, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb,
            global::System.IntPtr beta, global::System.IntPtr C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zgemm3m")]
        internal static extern void CblasZgemm3m(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransB, int M, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb,
            global::System.IntPtr beta, global::System.IntPtr C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zgemm_batch")]
        internal static extern void CblasZgemmBatch(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE* TransA_Array,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE* TransB_Array, int* M_Array, int* N_Array, int* K_Array, global::System.IntPtr alpha_Array, void** A_Array, int* lda_Array,
            void** B_Array, int* ldb_Array, global::System.IntPtr beta_Array, void** C_Array, int* ldc_Array, int group_count, int* group_size);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zgemm3m_batch")]
        internal static extern void CblasZgemm3mBatch(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE* TransA_Array,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE* TransB_Array, int* M_Array, int* N_Array, int* K_Array, global::System.IntPtr alpha_Array, void** A_Array, int* lda_Array,
            void** B_Array, int* ldb_Array, global::System.IntPtr beta_Array, void** C_Array, int* ldc_Array, int group_count, int* group_size);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zgemmt")]
        internal static extern void CblasZgemmt(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransB, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A,
            int lda, global::System.IntPtr B, int ldb, global::System.IntPtr beta, global::System.IntPtr C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zsymm")]
        internal static extern void CblasZsymm(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_SIDE Side, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            int M, int N, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb, global::System.IntPtr beta, global::System.IntPtr C,
            int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zsyrk")]
        internal static extern void CblasZsyrk(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE Trans, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr beta,
            global::System.IntPtr C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zsyr2k")]
        internal static extern void CblasZsyr2k(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE Trans, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb,
            global::System.IntPtr beta, global::System.IntPtr C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ztrmm")]
        internal static extern void CblasZtrmm(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_SIDE Side, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int M, int N, global::System.IntPtr alpha, global::System.IntPtr A, int lda,
            global::System.IntPtr B, int ldb);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ztrsm")]
        internal static extern void CblasZtrsm(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_SIDE Side, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA, global::Spreads.Native.MKL.CBLAS_DIAG Diag, int M, int N, global::System.IntPtr alpha, global::System.IntPtr A, int lda,
            global::System.IntPtr B, int ldb);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_ztrsm_batch")]
        internal static extern void CblasZtrsmBatch(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_SIDE* Side_Array,
            global::Spreads.Native.MKL.CBLAS_UPLO* Uplo_Array, global::Spreads.Native.MKL.CBLAS_TRANSPOSE* Transa_Array, global::Spreads.Native.MKL.CBLAS_DIAG* Diag_Array, int* M_Array,
            int* N_Array, global::System.IntPtr alpha_Array, void** A_Array, int* lda_Array, void** B_Array, int* ldb_Array, int group_count, int* group_size);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_chemm")]
        internal static extern void CblasChemm(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_SIDE Side, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            int M, int N, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb, global::System.IntPtr beta, global::System.IntPtr C,
            int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cherk")]
        internal static extern void CblasCherk(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE Trans, int N, int K, float alpha, global::System.IntPtr A, int lda, float beta, global::System.IntPtr C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_cher2k")]
        internal static extern void CblasCher2k(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE Trans, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb,
            float beta, global::System.IntPtr C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zhemm")]
        internal static extern void CblasZhemm(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_SIDE Side, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            int M, int N, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb, global::System.IntPtr beta, global::System.IntPtr C,
            int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zherk")]
        internal static extern void CblasZherk(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE Trans, int N, int K, double alpha, global::System.IntPtr A, int lda, double beta, global::System.IntPtr C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_zher2k")]
        internal static extern void CblasZher2k(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_UPLO Uplo,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE Trans, int N, int K, global::System.IntPtr alpha, global::System.IntPtr A, int lda, global::System.IntPtr B, int ldb,
            double beta, global::System.IntPtr C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sgemm_alloc")]
        internal static extern float* CblasSgemmAlloc(global::Spreads.Native.MKL.CBLAS_IDENTIFIER identifier, int M, int N, int K);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sgemm_pack_get_size")]
        internal static extern ulong CblasSgemmPackGetSize(global::Spreads.Native.MKL.CBLAS_IDENTIFIER identifier, int M, int N, int K);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sgemm_pack")]
        internal static extern void CblasSgemmPack(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_IDENTIFIER identifier,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE Trans, int M, int N, int K, float alpha, float* src, int ld, float* dest);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sgemm_compute")]
        internal static extern void CblasSgemmCompute(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, int TransA, int TransB, int M, int N, int K, float* A, int lda, float* B,
            int ldb, float beta, float* C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_sgemm_free")]
        internal static extern void CblasSgemmFree(float* dest);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dgemm_alloc")]
        internal static extern double* CblasDgemmAlloc(global::Spreads.Native.MKL.CBLAS_IDENTIFIER identifier, int M, int N, int K);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dgemm_pack_get_size")]
        internal static extern ulong CblasDgemmPackGetSize(global::Spreads.Native.MKL.CBLAS_IDENTIFIER identifier, int M, int N, int K);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dgemm_pack")]
        internal static extern void CblasDgemmPack(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_IDENTIFIER identifier,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE Trans, int M, int N, int K, double alpha, double* src, int ld, double* dest);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dgemm_compute")]
        internal static extern void CblasDgemmCompute(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, int TransA, int TransB, int M, int N, int K, double* A, int lda, double* B,
            int ldb, double beta, double* C, int ldc);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_dgemm_free")]
        internal static extern void CblasDgemmFree(double* dest);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_gemm_s16s16s32")]
        internal static extern void CblasGemmS16s16s32(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransB, global::Spreads.Native.MKL.CBLAS_OFFSET OffsetC, int M, int N, int K, float alpha, short* A, int lda, short ao, short* B,
            int ldb, short bo, float beta, int* C, int ldc, int* cb);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_gemm_s8u8s32")]
        internal static extern void CblasGemmS8u8s32(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransA,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE TransB, global::Spreads.Native.MKL.CBLAS_OFFSET OffsetC, int M, int N, int K, float alpha, global::System.IntPtr A, int lda,
            sbyte ao, global::System.IntPtr B, int ldb, sbyte bo, float beta, int* C, int ldc, int* cb);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_gemm_s8u8s32_pack_get_size")]
        internal static extern ulong CblasGemmS8u8s32PackGetSize(global::Spreads.Native.MKL.CBLAS_IDENTIFIER identifier, int M, int N, int K);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_gemm_s16s16s32_pack_get_size")]
        internal static extern ulong CblasGemmS16s16s32PackGetSize(global::Spreads.Native.MKL.CBLAS_IDENTIFIER identifier, int M, int N, int K);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_gemm_s8u8s32_pack")]
        internal static extern void CblasGemmS8u8s32Pack(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_IDENTIFIER identifier,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE Trans, int M, int N, int K, global::System.IntPtr src, int ld, global::System.IntPtr dest);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_gemm_s16s16s32_pack")]
        internal static extern void CblasGemmS16s16s32Pack(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, global::Spreads.Native.MKL.CBLAS_IDENTIFIER identifier,
            global::Spreads.Native.MKL.CBLAS_TRANSPOSE Trans, int M, int N, int K, short* src, int ld, short* dest);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_gemm_s8u8s32_compute")]
        internal static extern void CblasGemmS8u8s32Compute(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, int TransA, int TransB, global::Spreads.Native.MKL.CBLAS_OFFSET offsetc,
            int M, int N, int K, float alpha, global::System.IntPtr A, int lda, sbyte ao, global::System.IntPtr B, int ldb, sbyte bo, float beta, int* C, int ldc, int* co);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "cblas_gemm_s16s16s32_compute")]
        internal static extern void CblasGemmS16s16s32Compute(global::Spreads.Native.MKL.CBLAS_LAYOUT Layout, int TransA, int TransB, global::Spreads.Native.MKL.CBLAS_OFFSET offsetc,
            int M, int N, int K, float alpha, short* A, int lda, short ao, short* B, int ldb, short bo, float beta, int* C, int ldc, int* co);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "mkl_jit_get_dgemm_ptr")]
        internal static extern global::System.IntPtr MklJitGetDgemmPtr1(global::System.IntPtr jitter);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "mkl_jit_get_sgemm_ptr")]
        internal static extern global::System.IntPtr MklJitGetSgemmPtr1(global::System.IntPtr jitter);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "mkl_jit_get_cgemm_ptr")]
        internal static extern global::System.IntPtr MklJitGetCgemmPtr1(global::System.IntPtr jitter);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "mkl_jit_get_zgemm_ptr")]
        internal static extern global::System.IntPtr MklJitGetZgemmPtr1(global::System.IntPtr jitter);
        
        
        
        
        
        
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        
        [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Get_Version")]
            internal static extern void MKL_GetVersion(global::System.IntPtr ver);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Get_Version_String")]
            internal static extern void MKL_GetVersionString(sbyte* buffer, int len);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Free_Buffers")]
            internal static extern void MKL_FreeBuffers();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Thread_Free_Buffers")]
            internal static extern void MKL_ThreadFreeBuffers();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Mem_Stat")]
            internal static extern long MKL_MemStat(int* nbuffers);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Peak_Mem_Usage")]
            internal static extern long MKL_PeakMemUsage(int reset);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_malloc")]
            internal static extern global::System.IntPtr MKL_malloc(ulong size, int align);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_calloc")]
            internal static extern global::System.IntPtr MKL_calloc(ulong num, ulong size, int align);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_realloc")]
            internal static extern global::System.IntPtr MKL_realloc(global::System.IntPtr ptr, ulong size);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_free")]
            internal static extern void MKL_free(global::System.IntPtr ptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Disable_Fast_MM")]
            internal static extern int MKL_DisableFastMM();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Get_Cpu_Clocks")]
            internal static extern void MKL_GetCpuClocks(ulong* _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Get_Cpu_Frequency")]
            internal static extern double MKL_GetCpuFrequency();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Get_Max_Cpu_Frequency")]
            internal static extern double MKL_GetMaxCpuFrequency();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Get_Clocks_Frequency")]
            internal static extern double MKL_GetClocksFrequency();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Set_Num_Threads_Local")]
            internal static extern int MKL_SetNumThreadsLocal(int nth);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Set_Num_Threads")]
            internal static extern void MKL_SetNumThreads(int nth);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Get_Max_Threads")]
            internal static extern int MKL_GetMaxThreads();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Set_Num_Stripes")]
            internal static extern void MKL_SetNumStripes(int nstripes);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Get_Num_Stripes")]
            internal static extern int MKL_GetNumStripes();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Domain_Set_Num_Threads")]
            internal static extern int MKL_DomainSetNumThreads(int nth, int MKL_DOMAIN);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Domain_Get_Max_Threads")]
            internal static extern int MKL_DomainGetMaxThreads(int MKL_DOMAIN);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Set_Dynamic")]
            internal static extern void MKL_SetDynamic(int bool_MKL_DYNAMIC);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Get_Dynamic")]
            internal static extern int MKL_GetDynamic();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Enable_Instructions")]
            internal static extern int MKL_EnableInstructions(int _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Set_Interface_Layer")]
            internal static extern int MKL_SetInterfaceLayer(int code);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Set_Threading_Layer")]
            internal static extern int MKL_SetThreadingLayer(int code);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="mkl_set_xerbla")]
            internal static extern global::System.IntPtr MklSetXerbla(global::System.IntPtr xerbla);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="mkl_set_progress")]
            internal static extern global::System.IntPtr MklSetProgress(global::System.IntPtr progress);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_CBWR_Get")]
            internal static extern int MKL_CBWR_Get(int _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_CBWR_Set")]
            internal static extern int MKL_CBWR_Set(int _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_CBWR_Get_Auto_Branch")]
            internal static extern int MKL_CBWR_GetAutoBranch();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Set_Env_Mode")]
            internal static extern int MKL_SetEnvMode(int _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Verbose")]
            internal static extern int MKL_Verbose(int _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Verbose_Output_File")]
            internal static extern int MKL_VerboseOutputFile(sbyte* _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Set_Exit_Handler")]
            internal static extern void MKL_SetExitHandler(global::System.IntPtr h);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Set_Memory_Limit")]
            internal static extern int MKL_SetMemoryLimit(int mem_type, ulong limit);

                        [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="MKL_Finalize")]
            internal static extern void MKL_Finalize();
        
    }
}