using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Struct_Exercises
{
    public struct Complex
    {
        public int real;
        public int imaginary;
        public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.real + b.real, a.imaginary + b.imaginary);
        }
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.real - b.real, a.imaginary - b.imaginary);
        }
        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex((a.real * b.real) - (a.imaginary * b.imaginary), (a.real * b.imaginary) + (b.real * a.imaginary));
        }
        public static Complex operator /(Complex a, Complex b)
        {
            Complex temp = b;
            b.imaginary *= -1;
            Complex temp2 = a * b;
            int temp3 = (temp * b).real;
            return new Complex(temp2.real / temp3, temp2.imaginary / temp3);

        }
        public string GetInfo()
        {
            if(imaginary < 0)
            return $"{real} {imaginary}i";
            else if(imaginary == 0)
            return $"{real}";
            else if (real == 0)
            return $"{imaginary}i";
            return $"{real} + {imaginary}i";
        }
    }
}
