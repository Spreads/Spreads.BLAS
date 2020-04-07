namespace Spreads.Native
{
    public static partial class OpenBLAS
    {
        public static readonly bool IsSupoprted = Init();

        private static bool Init()
        {
            try
            {
                return CBLAS.OpenblasGetNumProcs() > 0;
            }
            catch
            {
            }

            return false;
        }

        public enum CBLAS_ORDER
        {
            CblasRowMajor = 101,
            CblasColMajor = 102
        }

        public enum CBLAS_TRANSPOSE
        {
            CblasNoTrans = 111,
            CblasTrans = 112,
            CblasConjTrans = 113,
            CblasConjNoTrans = 114
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
    }
}