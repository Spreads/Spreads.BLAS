// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Spreads.DataTypes
{
    [StructLayout(LayoutKind.Explicit, Size = 8, Pack = 4)]
    public readonly struct ComplexFloat : IEquatable<ComplexFloat>
    {
        [FieldOffset(0)]
        public readonly float Real;

        [FieldOffset(4)]
        public readonly float Imaginary;

        public ComplexFloat(float real, float imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public void Deconstruct(out float real, out float imaginary)
        {
            real = Real;
            imaginary = Imaginary;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(ComplexFloat other) => Real.Equals(other.Real) && Imaginary.Equals(other.Imaginary);

        public override bool Equals(object obj) => obj is ComplexFloat other && Equals(other);

        public override int GetHashCode()
        {
            unchecked
            {
                return (Real.GetHashCode() * 397) ^ Imaginary.GetHashCode();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(ComplexFloat x, ComplexFloat y) => x.Equals(y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(ComplexFloat x, ComplexFloat y) => !x.Equals(y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Complex(ComplexFloat value) => new Complex(value.Real, value.Imaginary);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ComplexFloat(Complex value) => new ComplexFloat((float)value.Real, (float)value.Imaginary);
    }
}