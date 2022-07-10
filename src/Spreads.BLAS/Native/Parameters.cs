﻿using System;

namespace Spreads.Native
{
    /// <summary>
    /// Native transpose parameter for CBLAS.
    /// </summary>
    public enum TransCblas
    {
        NoTrans = 111,
        Trans = 112,
        ConjTrans = 113,
        ConjNoTrans = 114
    }

    /// <summary>
    /// Native transpose parameter for LAPACKE.
    /// </summary>
    public enum TransLapack : sbyte
    {
        NoTrans = (sbyte)'N',
        Trans = (sbyte)'T',
        ConjTrans = (sbyte)'C',
        ConjNoTrans = (sbyte)'R',
    }
    
    /// <summary>
    /// Native UpLo parameter for CBLAS.
    /// </summary>
    public enum UpLoCblas
    {
        Upper = 121,
        Lower = 122
    }
        
    /// <summary>
    /// Native UpLo parameter for LAPACKE.
    /// </summary>
    public enum UpLoLapack : sbyte
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