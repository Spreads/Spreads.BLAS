// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Spreads.Native;

namespace Spreads
{
    public static partial class BLAS
    {
        /// <summary>
        /// If both MKL and OpenBlas are available then prefer MKL.
        /// </summary>
        public static bool MKLIsPreferred = true;

        /// <summary>
        /// Require MKL. Calling a shared method will throw even if OpenBlas is available and could perform the required call. 
        /// </summary>
        public static bool RequireMkl = true;

        public static readonly bool IsUsingMKL = MKLIsPreferred && MKL.IsSupoprted;
        public static readonly bool IsUsingOpenBlas = !RequireMkl && !IsUsingMKL && OpenBLAS.IsSupoprted;

        /// <summary>
        /// Not thread-safe, should be set at application startup.
        /// See details on threading (there are a lot of them) in OpenBLAS and MKL docs. 
        /// </summary>
        public static int BlasNumThreads
        {
            get
            {
                if (IsUsingMKL)
                    return MKL.GetMaxThreads();

                if (OpenBLAS.IsSupoprted)
                    return OpenBLAS.GetNumThreads();

                throw new InvalidOperationException("No native library is available");
            }

            set
            {
                var nt = Math.Max(1, Math.Min(Environment.ProcessorCount, value));

                if (IsUsingMKL)
                    MKL.SetNumThreads(nt);

                if (OpenBLAS.IsSupoprted)
                    OpenBLAS.SetNumThreads(nt);

                throw new InvalidOperationException("No native library is available");
            }
        }

        public static readonly MatrixLayout RowMajor = MatrixLayout.RowMajor;
        public static readonly MatrixLayout ColMajor = MatrixLayout.ColMajor;

        public static readonly Transpose NoTrans = Transpose.NoTrans;
        public static readonly Transpose Trans = Transpose.Trans;
        public static readonly Transpose ConjTrans = Transpose.ConjTrans;
        
        public static readonly UpLo Upper = UpLo.Upper;
        public static readonly UpLo Lower = UpLo.Lower;

        
    }
}