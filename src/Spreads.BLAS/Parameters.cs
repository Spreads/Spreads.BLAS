﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Spreads.Native;

namespace Spreads
{
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
        public static readonly Transpose ConjNoTrans = new Transpose((sbyte)'R');

        [FieldOffset(0)]
        private readonly sbyte _value;

        private Transpose(sbyte value)
        {
            _value = value;
        }

        public static implicit operator TransChar(Transpose transpose) => (TransChar)transpose._value;

        public static implicit operator TransCblas(Transpose transpose)
        {
            if ((char)transpose._value == 'N' || (char)transpose._value == 'n')
                return TransCblas.NoTrans;

            if ((char)transpose._value == 'T' || (char)transpose._value == 't')
                return TransCblas.Trans;

            if ((char)transpose._value == 'C' || (char)transpose._value == 'c')
                return TransCblas.ConjTrans;
            
            if ((char)transpose._value == 'R' || (char)transpose._value == 'r')
                return TransCblas.ConjNoTrans;

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

            if (transposeChar == 'R' || transposeChar == 'r')
                return ConjNoTrans;
            
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

        public static implicit operator UpLoChar(UpLo upLo) => (UpLoChar)upLo._value;

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
    
    
}