using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Learning_CSharp
{
    public class Extra_Homework
    {
        // Basic Declarations and Expressions
        public static void Exercise1()
        {
            int second = int.Parse(ReadLine());
            int hour = second / 3600;
            second = second - (hour * 3600);
            int minute = second / 60;
            second = second - (minute * 60);
            Console.WriteLine($"H:M:S - {hour}:{minute}:{second}");
        }
        public static void Exercise2()
        {
            int day = int.Parse(ReadLine());
            int year = day / 365;
            day = day - (year * 365);
            int month = day / 30;
            day = day - (month * 30);
            WriteLine($"{year} Year(s)\n{month} Months\n{day} Days");
        }
        public static void Exercise3()
        {
            int p, q, r, s;
            p = int.Parse(ReadLine());
            q = int.Parse(ReadLine());
            r = int.Parse(ReadLine());
            s = int.Parse(ReadLine());
            if (q > r && s > p && r + s > p + q)
                WriteLine("Correct values");
            else
                WriteLine("Wrong values");
        }
        public static void Exercise4()
        {
            double a, b, c;
            a = double.Parse(ReadLine());
            b = double.Parse(ReadLine());
            c = double.Parse(ReadLine());
            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                WriteLine($"Root 1: {(-b + Math.Sqrt(delta)) / (2 * a)}");
                WriteLine($"Root 2: {(-b - Math.Sqrt(delta)) / (2 * a)}");
            }
            if (delta < 0)
                WriteLine("No real roots");
            if (delta == 0)
            {
                WriteLine($"Roots: {(-b - Math.Sqrt(delta)) / (2 * a)}");
            }
        }
        public static void Exercise5()
        {
            //so confusing
        }
        public static void Exercise6()
        {
            int count = 0;
            int sum = 0;
            while (true)
            {
                int temp = int.Parse(ReadLine());
                if (temp % 2 != 0)
                    sum += temp;
                count++;
                if (count == 5)
                    break;
            }
            WriteLine(sum);
        }
        public static void Exercise7()
        {
            float a = float.Parse(ReadLine());
            float b = float.Parse(ReadLine());
            float c = float.Parse(ReadLine());
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                WriteLine("Invalid");
            }
            else
            {
                WriteLine($"Perimeter: {a + b + c}");
            }
        }
        public static void Exercise8()
        {
            int a = int.Parse(ReadLine());
            int b = int.Parse(ReadLine());
            if (a % b == 0 || b % a == 0)
                WriteLine("Multiplied");
            else
                WriteLine("Not Multiplied");
        }
        public static void Exercise9()
        {
            int a = int.Parse(ReadLine());
            switch (a)
            {
                case 1:
                    WriteLine("January");
                    break;
                case 2:
                    WriteLine("February");
                    break;
                case 3:
                    WriteLine("March");
                    break;
                case 4:
                    WriteLine("April");
                    break;
                case 5:
                    WriteLine("May");
                    break;
                case 6:
                    WriteLine("June");
                    break;
                case 7:
                    WriteLine("July");
                    break;
                case 8:
                    WriteLine("Agust");
                    break;
                case 9:
                    WriteLine("September");
                    break;
                case 10:
                    WriteLine("October");
                    break;
                case 11:
                    WriteLine("November");
                    break;
                case 12:
                    WriteLine("December");
                    break;
            }
        }
        public static void Exercise10()
        {
            for (int i = 2; i <= 50; i += 2)
                WriteLine(i);
        }
        public static void Exercise11()
        {
            int odd = 0;
            int even = 0;
            int cnt = 0;
            while (cnt < 5)
            {
                int temp = int.Parse(ReadLine());
                if (temp % 2 == 0)
                    even++;
                else
                    odd++;
                cnt++;
            }
            WriteLine($"There are {odd} odd(s) and {even} even(s)");
        }
        public static void Exercise12()
        {
            int positive = 0;
            int cnt = 0;
            int sum = 0;
            while (cnt < 5)
            {
                int temp = int.Parse(ReadLine());
                if (temp > 0)
                {
                    positive++;
                    sum += temp;
                }
                cnt++;
            }
            WriteLine($"Number of positive numbers: {positive}");
            WriteLine($"Average value of the said positive numbers: {sum / positive}");
        }
        public static void Exercise13()
        {
            int cnt = 0;
            int sum = 0;
            while (cnt < 5)
            {
                int temp = int.Parse(ReadLine());
                if (temp % 2 != 0)
                {
                    sum += temp;
                }
                cnt++;
            }
            WriteLine(sum);
        }
        public static void Exercise14()
        {
            int n = int.Parse(ReadLine());
            for (int i = 2; i <= n; i += 2)
            {
                WriteLine(i * i);
            }
        }
        public static void Exercise15()
        {
            int n = int.Parse(ReadLine());
            if (n % 2 == 0 && n > 0)
                WriteLine("Positive Even");
            else if (n % 2 == 0 && n < 0)
                WriteLine("Negative Even");
            else if (n % 2 != 0 && n > 0)
                WriteLine("Positive Odd");
            else if (n % 2 != 0 && n < 0)
                WriteLine("Negative Odd");
            else
                WriteLine("Even");
        }
        public static void Exercise16()
        {
            int n = int.Parse(ReadLine());
            for (int i = 1; i <= 100; i++)
            {
                if (i % n == 3)
                    WriteLine(i);
            }
        }
        public static void Exercise17()
        {
            int max = -100000;
            int position = -1;
            int cnt = 0;
            while (cnt < 5)
            {
                cnt++;
                int temp = int.Parse(ReadLine());
                if (temp >= max)
                {
                    position = cnt;
                    max = temp;
                }
            }
            WriteLine($"Max: {max} Position: {position}");
        }
        public static void Exercise18()
        {
            int a = int.Parse(ReadLine());
            int b = int.Parse(ReadLine());
            int start = b;
            int end = a;
            if (a <= b)
            {
                start = a;
                end = b;
            }
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                    WriteLine(i);
                }
            }
            WriteLine($"Sum: {sum}");
        }
        public static void Exercise19()
        {
            int a = int.Parse(ReadLine());
            int b = int.Parse(ReadLine());
            if (a <= b)
                WriteLine("The pair is in ascending order");
            else
                WriteLine("The pair is in descending order");
        }
        public static void Exercise20()
        {
            string passWord = ReadLine();
            if (passWord == "1234")
            {
                WriteLine("Correct Password");
            }
            else
                WriteLine("Wrong Password");
        }
        public static void Exercise21()
        {
            int a = int.Parse(ReadLine());
            int b = int.Parse(ReadLine());
            if (a > 0 && b > 0)
                WriteLine("Quadrant-I(+,+)");
            if (a < 0 && b > 0)
                WriteLine("Quadrant-II(-,+)");
            if (a < 0 && b < 0)
                WriteLine("Quadrant-III(-,-)");
            if (a > 0 && b < 0)
                WriteLine("Quadrant-IV(+,-)");
        }
        public static void Exercise22()
        {
            double a = double.Parse(ReadLine());
            double b = double.Parse(ReadLine());
            if (b != 0)
                WriteLine(a / b);
            else
                WriteLine("Division is not possible");
        }
        public static void Exercise23()
        {
            int a = int.Parse(ReadLine());
            int b = int.Parse(ReadLine());
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 17 != 0)
                {
                    sum += i;
                }
            }
            WriteLine(sum);
        }
        public static void Exercise24()
        {
            int a = int.Parse(ReadLine());
            int b = int.Parse(ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 2 || i % 7 == 3)
                {
                    WriteLine(i);
                }
            }
        }
        public static void Exercise25()
        {
            int a = int.Parse(ReadLine());
            for (int i = 1; i <= a * 3; i++)
            {
                Write(i + " ");
                if (i % 3 == 0)
                    WriteLine();
            }
        }
        public static void Exercise26()
        {
            int a = int.Parse(ReadLine());
            for (int i = 1; i <= a; i++)
            {
                WriteLine($"{i} {i * i} {i * i * i}");
            }
        }
        public static void Exercise27()
        {
            int p = int.Parse(ReadLine());
            int q = int.Parse(ReadLine());
            for (int i = 1; i <= p * q; i++)
            {
                Write(i + " ");
                if (i % q == 0)
                    WriteLine();
            }
        }
        public static void Exercise28()
        {
            float sum = 0;
            int count = 0;
            while (true)
            {
                float temp = float.Parse(ReadLine());
                if (temp <= 0)
                    break;
                sum += temp;
                count++;
            }
            WriteLine(sum / count);
        }
        public static void Exercise29()
        {
            double sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                sum += 1.0 / i;
            }
            WriteLine(Math.Round(sum, 1));
        }
        public static void Exercise30()
        {
            WriteLine(1.0 + 3.0 / 2.0 + 5.0 / 4.0 + 7.0 / 8.0);
        }
        public static void Exercise31()
        {
            int n = int.Parse(ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Write(i + " ");
            }
        }
        //Basic Algorithms
        public static void Ex1()
        {
            float a = float.Parse(ReadLine());
            float b = float.Parse(ReadLine());
            if (a == b)
                WriteLine((a + b) * 3);
            else
                WriteLine(a + b);
        }
        public static void Ex2()
        {
            int n = int.Parse(ReadLine());
            if (n > 51)
                WriteLine(Math.Abs(51 - n) * 3);
            else
                WriteLine(Math.Abs(51 - n));
        }
        public static void Ex3()
        {
            int a = int.Parse(ReadLine());
            int b = int.Parse(ReadLine());
            if (a == 30 || b == 30 || a + b == 30)
                WriteLine(true);
            else WriteLine(false);
        }
        public static void Ex4()
        {
            // extremely confusing --_-
        }
        public static void Ex5()
        {

        }
    }
}