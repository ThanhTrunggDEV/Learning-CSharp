using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;
using System.Threading.Tasks;

namespace Learning_CSharp
{

    public class Exercise1
    {
        public static void factors(uint n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
    public class Exercise2
    {
        public static int Sum(int n)
        {
            if (n < 1)
            {
                WriteLine("Invalid Input");
                return 0;
            }
            if (n == 1)
                return 1;
            return n + Sum(n - 1);
        }
    }
    public class Exercise3
    {
        public static double Solve(double n)
        {
            if (n <= 0)
                return 0;
            else if (n <= 2)
                return n * n - n;
            else if (n > 2)
                return n * n - Sin(PI * n * n);
            return 0;
        }
    }
    public class Exercise4
    {
        public static ulong Factorial(ulong n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * Factorial(n - 1);
        }
    }
    public class Exercise5
    {
        public static bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static void Prime(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (IsPrime(i))
                    WriteLine(i);
            }
        }
    }
    public class Exercise6
    {
        static bool IsSquare(int n)
        {
            if ((int)Sqrt(n) * (int)Sqrt(n) != n)
                return false;
            return true;
        }
        public static void Square(int n)
        {
            int count = 0;
            int i = 0;
            while (count < n)
            {
                if (IsSquare(i))
                {
                    count++;
                    WriteLine(i);
                }
                i++;
            }
        }
    }
    public class Exercise7
    {
        public static double S1(int n)
        {
            double result = 0;
            double temp = 0;
            for (int i = 1; i <= n; i++)
            {
                temp += i * i;
                if (i % 2 != 0)
                    result += 1 / temp;
                else result -= 1 / temp;
            }
            return result;
        }
        public static double S3(int n, int x)
        {
            double result = 0;
            double temp = 0;
            while (n > 0)
            {
                temp = x + result;
                result = Sqrt(temp);
                n--;
            }
            return result;
        }
        public static double S4(int n)
        {
            double result = 0;
            double temp = 0;
            for (int i = 1; i <= n; i++)
            {
                temp += i * i;
                result += 1 / temp;
            }
            return result;
        }
        public static double S5(int n)
        {
            double result = 0;
            int count = 1;
            for (int i = 2; i <= n * 2; i += 2)
            {
                if (count % 2 != 0)
                    result += 1.0 / i;
                else result -= 1.0 / i;
                count++;
            }
            return result;
        }
        public static double S6(int n)
        {
            double result = 0;
            double temp = 0;
            for (int i = 1; i <= n; i++)
            {
                temp += i;
                if (i % 2 != 0)
                    result += 1.0 / temp;
                else
                    result -= 1.0 / temp;
            }
            return result;
        }
        public static double S7(int n)
        {
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result += Pow(2, i) / Exercise4.Factorial((ulong)i);
            }
            return result;
        }
        public static double S8(int n)
        {
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                    result += 1.0 / Exercise4.Factorial((ulong)i);
                else
                    result -= 1.0 / Exercise4.Factorial((ulong)i);
            }
            return result;
        }
    }
    public class Exercise8
    {
        public static double Sin(int x, int n)
        {
            double result = 0;
            int count = 1;
            for (int i = 1; i <= 2 * n + 1; i += 2)
            {
                if (count % 2 != 0)
                    result += Pow(x, i) / Exercise4.Factorial((ulong)i);
                else
                    result -= Pow(x, i) / Exercise4.Factorial((ulong)i);
                count++;
            }
            return result;
        }
    }
    public class Exercise9
    {
        public static double Cos(int x, int n)
        {
            double result = 1;
            int count = 2;
            for (int i = 2; i <= 2 * n; i += 2)
            {
                if (count % 2 != 0)
                    result += Pow(x, i) / Exercise4.Factorial((ulong)i);
                else
                    result -= Pow(x, i) / Exercise4.Factorial((ulong)i);
                count++;
            }
            return result;
        }
    }
    public class Exercise10
    {
        public static double Ln(int x, int n)
        {
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                    result += Pow(x, i) / i;
                else
                    result -= Pow(x, i) / i;
            }
            return result;
        }
    }
    public class Exercise11
    {
        public static double Caculate(int n)
        {
            double result = 1;
            int count = 2;
            for (int i = 3; i <= 2 * n + 1; i += 2)
            {
                if (count % 2 != 0)
                    result += 1.0 / i;
                else
                    result -= 1.0 / i;
                count++;
            }
            return result;
        }
    }
    public class Exercise12
    {
        public static void Prime(int n)
        {
            for (int i = 2; i <= n; i++)
            {
                if (Exercise5.IsPrime(i))
                    WriteLine(i);
            }
        }
    }
    public class Exercise13
    {
        public static void GCD_LCM_OF(int a, int b)
        {
            int GCD = 0;
            int LCM = 0;
            for (int i = a; i >= 1; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    GCD = i;
                    break;
                }
            }
            LCM = a * b / GCD;
            WriteLine($"GCD of {a} and {b} is {GCD}");
            WriteLine($"LCM of {a} and {b} is {LCM}");
        }
    }
    public class Exercise14
    {
        public static bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
    public class Exercise15
    {
        public static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
    public class AdvancedExercise1
    {
        static int result = 0;
        static int f1 = 1;
        static int f2 = 1;
        static int count = 2;
        public static int Fibo(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            if (n == count)
                return result;
            result = f1 + f2;
            f1 = f2;
            f2 = result;
            count++;
            return Fibo(n);
        }
    }
    public class AdvancedExercise2
    {
        public static void CountOddAndEvenIn(int n)
        {
            int n1 = n;
            int odd = 0;
            int even = 0;
            while (n > 0)
            {
                int temp = n % 10;
                if (temp % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
                n /= 10;
            }
            WriteLine($"There are {odd} odd digits and {even} even digits in {n1}");
        }
    }
    public class AdvancedExercise3
    {
        public static void Find(int n, int x)
        {
            int count = 0;
            int position = 0;
            while (n > 0)
            {
                int temp = n % 10;
                if (temp == x)
                {
                    position = count;
                }
                count++;
                n /= 10;
            }
            WriteLine($"The digit {x} is at the {count - position} position");
        }
    }
}
