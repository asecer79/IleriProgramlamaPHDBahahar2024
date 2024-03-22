using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W05.ExtensionMethods
{
    public class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
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
