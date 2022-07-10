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

        // TODO Other static fields for high-level params
        public static MatrixLayout RowMajor = MatrixLayout.RowMajor;

        /// <summary>
        /// Matrix layout parameter for CBLAS and LAPACKE.
        /// </summary>
        public enum MatrixLayout
        {
            RowMajor = 101,
            ColMajor = 102
        }

        /// <summary>
        /// Transpose parameter for CBLAS and LAPACKE.
        /// </summary>
        [DebuggerDisplay("{ToString()}")]
        [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
        public readonly struct Transpose
        {
            public static readonly Transpose NoTrans = new Transpose((sbyte)'N');
            public static readonly Transpose Trans = new Transpose((sbyte)'T');
            public static readonly Transpose ConjTrans = new Transpose((sbyte)'C');

            [FieldOffset(0)]
            private readonly sbyte _value;

            private Transpose(sbyte value)
            {
                _value = value;
            }

            public static implicit operator TransLapack(Transpose transpose) => (TransLapack)transpose._value;

            public static implicit operator TransCblas(Transpose transpose)
            {
                if ((char)transpose._value == 'N' || (char)transpose._value == 'n')
                    return TransCblas.NoTrans;

                if ((char)transpose._value == 'T' || (char)transpose._value == 't')
                    return TransCblas.Trans;

                if ((char)transpose._value == 'C' || (char)transpose._value == 'c')
                    return TransCblas.ConjTrans;

                ThrowIndalidValue((char)transpose._value);
                return default;
            }

            public static implicit operator Transpose(char transposeChar)
            {
                if (transposeChar == 'N' || transposeChar == 'n')
                    return NoTrans;

                if (transposeChar == 'T' || transposeChar == 't')
                    return Trans;

                if (transposeChar == 'C' || transposeChar == 'c')
                    return ConjTrans;

                ThrowIndalidValue(transposeChar);
                return default;
            }

            public override string ToString()
            {
                switch ((char)_value)
                {
                    case 'N':
                    case 'n':
                        return nameof(NoTrans);
                    case 'T':
                    case 't':
                        return nameof(Trans);
                    case 'C':
                    case 'c':
                        return nameof(ConjTrans);
                    default:
                        return "<invalid>";
                }
            }

            [MethodImpl(MethodImplOptions.NoInlining)]
            private static void ThrowIndalidValue(char value) => throw new InvalidCastException($"Invalid transpose value {value}");
        }

        /// <summary>
        /// Transpose parameter for CBLAS and LAPACKE.
        /// </summary>
        [DebuggerDisplay("{ToString()}")]
        [StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1)]
        public readonly struct UpLo
        {
            public static readonly UpLo Upper = new UpLo((sbyte)'U');
            public static readonly UpLo Lower = new UpLo((sbyte)'L');

            [FieldOffset(0)]
            private readonly sbyte _value;

            private UpLo(sbyte value)
            {
                _value = value;
            }

            public static implicit operator UpLoLapack(UpLo upLo) => (UpLoLapack)upLo._value;

            public static implicit operator UpLoCblas(UpLo upLo)
            {
                if ((char)upLo._value == 'U' || (char)upLo._value == 'u')
                    return UpLoCblas.Upper;

                if ((char)upLo._value == 'L' || (char)upLo._value == 'l')
                    return UpLoCblas.Lower;

                ThrowIndalidValue((char)upLo._value);
                return default;
            }

            public static implicit operator UpLo(char upLoChar)
            {
                if (upLoChar == 'U' || upLoChar == 'u')
                    return Upper;

                if (upLoChar == 'T' || upLoChar == 't')
                    return Lower;

                ThrowIndalidValue(upLoChar);
                return default;
            }

            public override string ToString()
            {
                switch ((char)_value)
                {
                    case 'U':
                    case 'u':
                        return nameof(Upper);
                    case 'L':
                    case 'l':
                        return nameof(Lower);
                    default:
                        return "<invalid>";
                }
            }

            [MethodImpl(MethodImplOptions.NoInlining)]
            private static void ThrowIndalidValue(char value) => throw new InvalidCastException($"Invalid UpLo value {value}");
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