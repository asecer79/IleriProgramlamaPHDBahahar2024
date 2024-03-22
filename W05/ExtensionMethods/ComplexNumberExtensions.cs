using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace W05.ExtensionMethods
{
    public static class ComplexNumberExtensions
    {
        public static ComplexNumber Sum(this ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }

        public static ComplexNumber Subtract(this ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }

        public static ComplexNumber Multiply(this ComplexNumber a, ComplexNumber b)
        {
            double real = a.Real * b.Real + -a.Imaginary * b.Imaginary;
            double imaginary = a.Imaginary * b.Real + a.Real * b.Imaginary;

            return new ComplexNumber(real, imaginary);
        }

        public static ComplexNumber Divide(this ComplexNumber a, ComplexNumber b)
        {
            double denominator = b.Real * b.Real + b.Imaginary * b.Imaginary;
            double realPart = (a.Real * b.Real + a.Imaginary * b.Imaginary) / denominator;
            double imaginaryPart = (a.Imaginary * b.Real - a.Real * b.Imaginary) / denominator;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        public static double Modulus(this ComplexNumber a)
        {
            return Math.Sqrt(Math.Pow(a.Real, 2) + Math.Pow(a.Imaginary, 2));
        }

        public static ComplexNumber Power(this ComplexNumber a, int n)
        {
            if (n==0)
            {
              return  new ComplexNumber(1, 0);
            }

            ComplexNumber result = a;

            for (int i = 1; i < n ; i++)
            {
                result = result.Multiply(a);
            }

            return result;
        }

    }
}
