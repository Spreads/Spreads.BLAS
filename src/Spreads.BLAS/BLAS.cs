﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System;
using System.Runtime.InteropServices;
using Spreads.Native;

namespace Spreads
{
    public static partial class BLAS
    {
        public static readonly bool IsMKLSupported = Native.MKL.IsSupoprted;


        /// <summary>
        /// Not thread-safe, should be set at application startup.
        /// See details on threading (there are a lot of them!) in OpenBLAS and MKL docs. 
        /// </summary>
        public static int BlasNumThreads
        {
            get
            {
                if (MKL.IsSupoprted)
                    return MKL.MKL_GetMaxThreads();

                return OpenBLAS.OpenblasGetNumThreads();
            }

            set
            {
                var nt = Math.Max(1, Math.Min(Environment.ProcessorCount, value));

                if (MKL.IsSupoprted)
                    MKL.MKL_SetNumThreads(nt);

                OpenBLAS.OpenblasSetNumThreads(nt);
            }
        }

        public enum LAYOUT
        {
            RowMajor = 101,
            ColMajor = 102
        }

        public enum TRANSPOSE
        {
            NoTrans = 111,
            Trans = 112,
            ConjTrans = 113,
            ConjNoTrans = 114
        }

        /// <summary>
        /// Transpose parameter for LAPACKE
        /// </summary>
        [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
        public struct TRANS
        {
            public static readonly TRANS NoTrans = new TRANS((sbyte) 'N');
            public static readonly TRANS Trans = new TRANS((sbyte) 'T');
            public static readonly TRANS ConjTrans = new TRANS((sbyte) 'C');

            [FieldOffset(0)]
            private readonly sbyte _value;

            private TRANS(sbyte value)
            {
                _value = value;
            }
        }

        public enum UPLO
        {
            Upper = 121,
            Lower = 122
        }

        public enum DIAG
        {
            NonUnit = 131,
            Unit = 132
        }

        public enum SIDE
        {
            Left = 141,
            Right = 142
        }
    }
}