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
            int temp = x.denominator;
            int temp2 = y.denominator;
            x.numerator *= temp2;
            x.denominator *= temp2;
            y.numerator *= temp;
            y.denominator *= temp;
            Fraction result = new Fraction(x.numerator - y.numerator, x.denominator);
           return result.Reduction();
            
        }
        public static Fraction operator +(Fraction x, Fraction y)
        {
                int temp = x.denominator;
                int temp2 = y.denominator;
                x.numerator *= temp2;
                x.denominator *= temp2;
                y.numerator *= temp;
                y.denominator *= temp;
                Fraction result = new Fraction(x.numerator + y.numerator, x.denominator);
                return result.Reduction();
      
        }
        public static Fraction operator *(Fraction x, Fraction y)
        {
            Fraction result = new Fraction(x.numerator * y.numerator, x.denominator * y.denominator);
            return result.Reduction();
            
        }
        public static Fraction operator /(Fraction x, Fraction y)
        {
            Fraction result = new Fraction(x.numerator * y.denominator, x.denominator * y.numerator);
            return result.Reduction();
            
        }
        public static bool operator >(Fraction x, Fraction y)
        {
            if(x.numerator * 1.0 / x.denominator * 1.0 > y.numerator * 1.0 / y.denominator * 1.0)
                return true;
            return false;
        }
        public static bool operator <(Fraction x, Fraction y)
        {
            if (x.numerator * 1.0 / x.denominator * 1.0 > y.numerator * 1.0 / y.denominator * 1.0)
                return false;
            return true;
        }
        public static bool operator >=(Fraction x, Fraction y)
        {
            if (x.numerator * 1.0 / x.denominator * 1.0 >= y.numerator * 1.0 / y.denominator * 1.0)
                return true;
            return false;
        }
        public static bool operator <=(Fraction x, Fraction y)
        {
            if (x.numerator * 1.0 / x.denominator * 1.0 >= y.numerator * 1.0 / y.denominator * 1.0)
                return false;
            return true;
        }
        public static bool operator ==(Fraction x, Fraction y)
        {
            if (x.numerator * 1.0 / x.denominator * 1.0 == y.numerator * 1.0 / y.denominator * 1.0)
                return true;
            return false;
        }
        public static bool operator !=(Fraction x, Fraction y)
        {
            if (x.numerator * 1.0 / x.denominator * 1.0 != y.numerator * 1.0 / y.denominator * 1.0)
                return true;
            return false;
        }
        public Fraction Reduction()
        {
            int gcd = GCD(numerator, denominator);
            return new Fraction(numerator / gcd, denominator/ gcd);
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
