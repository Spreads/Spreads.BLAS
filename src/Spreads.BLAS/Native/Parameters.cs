using System;

namespace Spreads.Native
{
    /// <summary>
    /// Matrix layout parameter for MKL trans APIs.
    /// </summary>
    public enum MatrixLayoutChar : sbyte
    {
        RowMajor = (sbyte)'R',
        ColMajor = (sbyte)'C'
    }
    
    /// <summary>
    /// Native transpose CBLAS parameter.
    /// </summary>
    public enum TransCblas
    {
        NoTrans = 111,
        Trans = 112,
        ConjTrans = 113,
        ConjNoTrans = 114
    }

    /// <summary>
    /// Native transpose char parameter .
    /// </summary>
    public enum TransChar : sbyte
    {
        NoTrans = (sbyte)'N',
        Trans = (sbyte)'T',
        ConjTrans = (sbyte)'C',
        ConjNoTrans = (sbyte)'R',
    }
    
    /// <summary>
    /// Native UpLo CBLAS parameter.
    /// </summary>
    public enum UpLoCblas
    {
        Upper = 121,
        Lower = 122
    }
        
    /// <summary>
    /// Native UpLo char parameter.
    /// </summary>
    public enum UpLoChar : sbyte
    {
        Upper = (sbyte)'U',
        Lower = (sbyte)'L'
    }
    
    public enum DiagCblas
    {
        NonUnit = 131,
        Unit = 132
    }

    public enum SideCblas
    {
        Left = 141,
        Right = 142
    }
}