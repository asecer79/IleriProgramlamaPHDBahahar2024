using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using W05.ExtensionMethods;

namespace W05.OperatorOverloading
{
    public class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            double real = a.Real * b.Real + -a.Imaginary * b.Imaginary;
            double imaginary = a.Imaginary * b.Real + a.Real * b.Imaginary;

            return new Complex(real, imaginary);
        }

        public static Complex operator /(Complex a, Complex b)
        {
            double denominator = b.Real * b.Real + b.Imaginary * b.Imaginary;
            double realPart = (a.Real * b.Real + a.Imaginary * b.Imaginary) / denominator;
            double imaginaryPart = (a.Imaginary * b.Real - a.Real * b.Imaginary) / denominator;
            return new Complex(realPart, imaginaryPart);
        }

        public double Modulus()
        {
            return Math.Sqrt(Math.Pow(this.Real, 2) + Math.Pow(this.Imaginary, 2));
        }

        public  Complex Power(int n)
        {
            Complex result = new Complex(1, 0);

            for (int i = 1; i <= n; i++)
            {
                result *= this;
            }

            return result;
        }

        public override string ToString()
        {
            if (Real == 0 && Imaginary == 0)
            {
                return "0";
            }
            else if (Real == 0)
            {
                return Imaginary == 1 ? "i" : Imaginary == -1 ? "-i" : $"{Imaginary}i";
            }
            else if (Imaginary == 0)
            {
                return Real.ToString();
            }
            else
            {
                // Sanal kısmı tam olarak 1 ya da -1 olan durumlar için sadeleştirme
                if (Imaginary == 1)
                {
                    return $"{Real} + i";
                }
                else if (Imaginary == -1)
                {
                    return $"{Real} - i";
                }
                else
                {
                    return $"{Real} {(Imaginary > 0 ? "+" : "-")} {Math.Abs(Imaginary)}i";
                }
            }
        }
    }
}
