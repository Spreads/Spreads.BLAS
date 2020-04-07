using System.Runtime.InteropServices;

// ReSharper disable once CheckNamespace
namespace Spreads
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ComplexDouble
    {
        public double Real;
        public double Imaginary;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct ComplexFloat
    {
        public float Real;
        public float Imaginary;
    }
}