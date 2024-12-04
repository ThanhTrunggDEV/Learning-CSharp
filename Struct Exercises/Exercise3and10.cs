using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Struct_Exercises
{
    public struct Fraction
    {
        public int numerator;
        public int denominator;
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;

        }
        public string GetData()
        {
            return $"{numerator}/{denominator}";
        }
        private static int GCD(int a, int b)
        {
            for(int i = Math.Abs(a); i >= 1; i--)
            {
                if (a % i == 0 && b % i == 0)
                    return i;
            }
            return 0;
        }
        public static Fraction operator -(Fraction x, Fraction y)
        {
            if (x.denominator == y.denominator)
            {
                Fraction result = new Fraction(x.numerator - y.numerator, x.denominator);
                result.Reduction();
                return result;
            }
            int gcd = GCD(x.denominator, y.denominator);
            if (gcd == 1)
            {
                int temp = x.denominator;
                int temp2 = y.denominator;
                x.numerator *= temp2;
                x.denominator *= temp2;
                y.numerator *= temp;
                y.denominator *= temp;
                Fraction result = new Fraction(x.numerator - y.numerator, x.denominator);
                result.Reduction();
                return result;
            }
            if (x.denominator > y.denominator)
            {
                y.numerator *= gcd;
                y.denominator *= gcd;
            }
            else
            {
                x.numerator *= gcd;
                y.denominator *= gcd;
            }
            Fraction result2 = new Fraction(x.numerator - y.numerator, x.denominator);
            result2.Reduction();
            return result2;
        }
        public static Fraction operator +(Fraction x, Fraction y)
        {
            if(x.denominator == y.denominator)
            {
                Fraction result = new Fraction(x.numerator + y.numerator ,x.denominator);
                result.Reduction();
                return result;
            }
            int gcd = GCD(x.denominator, y.denominator);
            if(gcd == 1)
            {
                int temp = x.denominator;
                int temp2 = y.denominator;
                x.numerator *= temp2;
                x.denominator *= temp2;
                y.numerator *= temp;
                y.denominator *= temp;
                Fraction result = new Fraction(x.numerator + y.numerator, x.denominator);
                result.Reduction();
                return result;
            }
            if (x.denominator > y.denominator)
            {
                y.numerator *= gcd;
                y.denominator *= gcd;
            }
            else
            {
                x.numerator *= gcd;
                y.denominator *= gcd;
            }
            Fraction result2 = new Fraction(x.numerator + y.numerator, x.denominator);
            result2.Reduction();
            return result2;
        }
        public static Fraction operator *(Fraction x, Fraction y)
        {
            Fraction result = new Fraction(x.numerator * y.numerator, x.denominator * y.denominator);
            result.Reduction();
            return result;
        }
        public static Fraction operator /(Fraction x, Fraction y)
        {
            Fraction result = new Fraction(x.numerator * y.denominator, x.denominator * y.numerator);
            result.Reduction();
            return result;
        }
        public static bool operator >(Fraction x, Fraction y)
        {
            if(x.numerator / x.denominator > y.numerator / y.denominator)
                return true;
            return false;
        }
        public static bool operator <(Fraction x, Fraction y)
        {
            if (x.numerator / x.denominator > y.numerator / y.denominator)
                return false;
            return true;
        }
        public static bool operator >=(Fraction x, Fraction y)
        {
            if (x.numerator / x.denominator >= y.numerator / y.denominator)
                return true;
            return false;
        }
        public static bool operator <=(Fraction x, Fraction y)
        {
            if (x.numerator / x.denominator >= y.numerator / y.denominator)
                return false;
            return true;
        }
        public static bool operator ==(Fraction x, Fraction y)
        {
            if (x.numerator == y.numerator && x.denominator == y.denominator)
                return true;
            return false;
        }
        public static bool operator !=(Fraction x, Fraction y)
        {
            if (x.numerator != y.numerator || x.denominator == y.denominator)
                return true;
            return false;
        }
        public void Reduction()
        {
            int gcd = GCD(numerator, denominator);
            numerator = numerator / gcd;
            denominator = denominator / gcd;
            
        }
        public Fraction Inverse()
        {
            return new Fraction(denominator, numerator);
        }
    }
    public struct TestFraction
    {
        public List<Fraction> list;
        public void Init()
        {
            list = new List<Fraction>();
        }
        public void Input()
        {
            Console.Write("Enter number of fraction:");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Enter Numerator Of Fraction {i + 1}: ");
                int ne = int.Parse(Console.ReadLine());
                flag:
                Console.Write($"Enter Denominator Of Fraction {i + 1}: ");
                int d = int.Parse(Console.ReadLine());
                if (d == 0)
                    goto flag;
                else
                    list.Add(new Fraction(ne, d));
            }

        }
        public void OutPut()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.GetData());
            }
        }
        public void Total()
        {
            Fraction sum = list[0];
            for(int i = 1; i < list.Count; i++)
            {
                sum += list[i];
            }
            Console.WriteLine(sum.GetData());
        }
        public void Product()
        {
            Fraction product = new Fraction(1,1);
            foreach (var item in list)
            {
                product *= item;
            }
            Console.WriteLine(product.GetData());
        }
        public void Largerst()
        {
            Fraction result = list[0];
            foreach (var item in list)
            {
                if(item >=  result)
                    result = item;
            }
            Console.WriteLine(result.GetData());
        }
        public void Inverse()
        {
            for(int i = 0; i < list.Count; i++)
            {
               list[i] = list[i].Inverse();
            }
        }
    }
}
