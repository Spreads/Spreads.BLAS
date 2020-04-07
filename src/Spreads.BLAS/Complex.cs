using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Spreads
{
    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 8)]
    public readonly struct ComplexDouble : IEquatable<ComplexDouble>
    {
        [FieldOffset(0)]
        public readonly double Real;

        [FieldOffset(8)]
        public readonly double Imaginary;

        public ComplexDouble(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public void Deconstruct(out double real, out double imaginary)
        {
            real = Real;
            imaginary = Imaginary;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(ComplexDouble other)
        {
            return Real.Equals(other.Real) && Imaginary.Equals(other.Imaginary);
        }

        public override bool Equals(object obj)
        {
            return obj is ComplexDouble other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Real.GetHashCode() * 397) ^ Imaginary.GetHashCode();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(ComplexDouble x, ComplexDouble y)
        {
            return x.Equals(y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(ComplexDouble x, ComplexDouble y)
        {
            return !x.Equals(y);
        }
    }

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
        public bool Equals(ComplexFloat other)
        {
            return Real.Equals(other.Real) && Imaginary.Equals(other.Imaginary);
        }

        public override bool Equals(object obj)
        {
            return obj is ComplexFloat other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Real.GetHashCode() * 397) ^ Imaginary.GetHashCode();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(ComplexFloat x, ComplexFloat y)
        {
            return x.Equals(y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(ComplexFloat x, ComplexFloat y)
        {
            return !x.Equals(y);
        }
    }
}