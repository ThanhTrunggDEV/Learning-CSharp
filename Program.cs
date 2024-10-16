using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
//using  System.
using System.Threading;
using static System.Console;
using static System.Threading.Thread;
namespace Learning_CSharp
{
    internal class Program
    {
        static void randomColor()
        {
            Random random = new Random();
            int check = random.Next(0, 9);
            if (check == 0)
                ForegroundColor = ConsoleColor.Magenta;
            if (check == 1)
                ForegroundColor = ConsoleColor.DarkBlue;
            if (check == 2)
                ForegroundColor = ConsoleColor.DarkGray;
            if (check == 3)
                ForegroundColor = ConsoleColor.DarkGreen;
            if (check == 4)
                ForegroundColor = ConsoleColor.DarkCyan;
            if (check == 5)
                ForegroundColor = ConsoleColor.DarkRed;
            if (check == 6)
                ForegroundColor = ConsoleColor.DarkMagenta;
            if (check == 7)
                ForegroundColor = ConsoleColor.DarkYellow;
            if (check == 8)
                ForegroundColor = ConsoleColor.Cyan;
        }
        static void Loading()
        {
            randomColor();
            Write("\rProcessing.");
            Sleep(1000);
            randomColor();
            Write("\rProcessing..");
            Sleep(1000);
            randomColor();
            Write("\rProcessing...");
            Sleep(500);
            for (int i = 0; i <= 100; i++)
            {
                Sleep(10);
                randomColor();
                Write($"\rLoading {i}%...");
                if (i == 100)
                {
                    Clear();
                    Write("\rCompleted");
                }
            }
            Thread.Sleep(500);
            Clear();
        }
        static void Generate()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            Loading();
            string output = string.Empty;
            int position = 0;
            while (true)
            {
                for (char character = 'A'; character <= 'z'; character++)
                {
                    Sleep(50);
                    randomColor();
                    Write("\r" + output + character);
                    Title = output;
                    if (character == input[position])
                    {
                        output += input[position++];
                    }
                    else if (input[position] == ' ')
                    {
                        output += " ";
                        position++;
                    }
                    if (position == input.Length)
                    {
                        Write("\n");
                        return;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            #region Console Configuration
            Title = "Written And Designed By ThanhTrung";
            randomColor();
            OutputEncoding = Encoding.UTF8;
            #endregion
            #region Exercise1
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //if (a >= b)
            //{
            //    Console.WriteLine(a);
            //}
            //else {
            //    Console.WriteLine(b);
            //}
            #endregion
            #region Exercise2
            //back:
            //float a = float.Parse(Console.ReadLine());
            //float b = float.Parse(Console.ReadLine()); 
            //float c = float.Parse(Console.ReadLine());
            //if (a + b > c && a + c > b && c + b > a)
            //{
            //    float p = (a + b + c) / 2;
            //    float s = (float)Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            //    Console.WriteLine(s);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //    goto back;
            //}
            #endregion
            #region Exercise3
            //int oldIndex = int.Parse(Console.ReadLine());
            //int newIndex = int.Parse(Console.ReadLine());
            //int consumption = newIndex - oldIndex;
            //int payment = 0;
            //if(consumption <= 100 )
            //{
            //    payment = consumption * 1000;
            //}
            //else if( consumption <= 150)
            //{
            //    payment = 100 * 1000 + 50 * 1200;
            //}
            //else if( consumption <= 200)
            //{
            //    payment = 100 * 1000 + 50 * 1200 + 50 * 2000;
            //}
            //else if(consumption > 200)
            //{
            //    payment = 100 * 1000 + 50 * 1200 + 50 * 2000 + 2500 * (consumption - 200);
            //}
            //WriteLine(payment);
            #endregion
            #region Exercise4
            //back:
            //    int a = int.Parse(Console.ReadLine());
            //    if (a <= 0)
            //    {
            //        WriteLine("Please Enter Positive Number");
            //        goto back;
            //    }
            //    else
            //    {
            //        if (a % 2 == 0)
            //        {
            //            WriteLine("Even");
            //        }
            //        else
            //        {
            //            WriteLine("Odd");
            //        }
            //    }
            #endregion
            #region Exercise5
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //if (a >= b && a >= c)
            //{
            //    WriteLine(a);
            //}
            //else if (b >= c && b >= a)
            //{
            //    WriteLine(b);
            //}
            //else if (c >= a && c >= b)
            //{
            //    WriteLine(c);
            //}
            #endregion
            #region Exercise6
            // int a = int.Parse(Console.ReadLine());
            // int b = int.Parse(Console.ReadLine());
            // int c = int.Parse(Console.ReadLine());
            // int d = int.Parse(Console.ReadLine());
            // if(a >= b && a >= c && a >= d)
            // {
            //     Console.WriteLine(a);
            // }
            //else if(b >= a && b >= c && b >= d)
            // {
            //     Console.WriteLine(b);
            // }
            //else if(c >= a && c >= b && c >= d)
            // {
            //     Console.WriteLine(c);
            // }
            //else if(d >= a && d >= b && d >= c)
            // {
            //     Console.WriteLine(d);
            // }
            #endregion
            #region Exercise7
            // int a = int.Parse(Console.ReadLine());
            // int b = int.Parse(Console.ReadLine());
            // int c = int.Parse(Console.ReadLine());

            // if(a >= b && a >= c)
            // {
            //     if(b >= c)
            //         Write(c + " " + b + " " + a);
            //     else
            //         Write(b + " " + c + " " + a);

            // }
            //else if(b >= a && b >= c)
            // {
            //     if(a >= c)
            //     Write(c + " " + a + " " + b);
            //     else
            //         Write(a + " " + c + " " + b);
            // }
            //else if (c >= a && c >= b)
            // {
            //     if (a >= b)
            //         Write(b + " " + a + " " + c);
            //     else
            //         Write(a + " " + b + " " + c);
            // }
            // Console.WriteLine();
            #endregion
            #region Exercise8
            //int n = int.Parse(Console.ReadLine());
            //int lastIndex = n % 10;
            //n = n / 10;
            //int middleIndex = n % 10;
            //n = n / 10;
            //int firstIndex = n % 10;
            //if (lastIndex >= firstIndex && lastIndex >= middleIndex)
            //{
            //    Console.WriteLine("Last Index");
            //}
            //else if (middleIndex >= lastIndex && middleIndex >= firstIndex)
            //{
            //    Console.WriteLine("Middle Index");
            //}
            //else Console.WriteLine("First Index");
            #endregion
            #region Exercise9
            // int n = int.Parse(Console.ReadLine());
            // int lastDigit = n % 10;
            // n /= 10;
            // int middleDigit = n % 10;
            // n /= 10;
            // int firstDigit = n % 10;
            // if (lastDigit >= firstDigit && lastDigit >= middleDigit)
            // {
            //     if (firstDigit >= middleDigit)
            //         Write(middleDigit + "" + firstDigit + "" + lastDigit);
            //     else
            //         Write(firstDigit + "" + middleDigit + "" + lastDigit);

            // }
            //else if (middleDigit >= firstDigit && middleDigit >= lastDigit)
            // {
            //     if (firstDigit >= lastDigit)
            //         Write(lastDigit + "" + firstDigit + "" + middleDigit);
            //     else
            //         Write(firstDigit + "" + lastDigit + "" + middleDigit);

            // }
            //else if (firstDigit >= lastDigit && firstDigit >= middleDigit)
            // {
            //     if (lastDigit >= middleDigit)
            //         Write(middleDigit + "" + lastDigit + "" + firstDigit);
            //     else
            //         Write(lastDigit + "" + middleDigit + "" + firstDigit);

            // }
            // Console.WriteLine();
            #endregion
            #region Exercise10
            //back:
            //int day = int.Parse(Console.ReadLine());
            //int month = int.Parse(Console.ReadLine());
            //int year = int.Parse(Console.ReadLine());
            //if(day < 1 || day > 31 || month < 1 || month > 12 || year < 0)
            //{
            //    WriteLine("Invalid Input");
            //    goto back;
            //}
            //else
            //{
            //    bool isLeapYear = false;
            //    if(year % 4 == 0 && year % 100 != 0)
            //    {
            //        isLeapYear = true;
            //    }
            //    if(month == 2)
            //    {
            //        if (DateTime.IsLeapYear(year) && day > 29)
            //        {
            //            WriteLine("Invalid Input");
            //            goto back;
            //        }
            //       else if (!DateTime.IsLeapYear(year) && day > 28)
            //        {
            //            WriteLine("Invalid Input");
            //            goto back;
            //        }
            //        WriteLine($"{day}/{month}/{year}");
            //    }
            //   else if(month == 4 || month == 6 || month == 9 || month == 11)
            //    {
            //       if(day > 30)
            //        {
            //            WriteLine("Invalid Input");
            //            goto back;
            //        }
            //        WriteLine($"{day}/{month}/{year}");
            //    }
            //}
            #endregion
            #region Exercise11
            //back:
            //int hour = int.Parse(Console.ReadLine());
            //int minute = int.Parse(Console.ReadLine());
            //int second = int.Parse(Console.ReadLine());
            //if (hour < 0 || hour > 23 || minute < 0 || minute > 59 || second < 0 || second > 59)
            //{
            //    Console.WriteLine("Invalid Input");
            //    goto back;
            //}
            //else
            //{
            //    Console.WriteLine($"{hour}:{minute}:{second}");
            //}
            #endregion
            #region Exercise12
            //back:
            //int year = int.Parse(Console.ReadLine());
            //if(year < 1)
            //{
            //    WriteLine("Invalid Input");
            //    goto back;
            //}
            //else
            //{
            //    if(year % 4 == 0 && year % 100 != 0)
            //    {
            //            WriteLine("This is a leap year");
            //    }
            //   else if(year % 100 == 0 && year % 100 == 0 && year % 400 == 0)
            //    {
            //        WriteLine("This is a leap year");
            //    }
            //    else
            //    {
            //        WriteLine("This isn't a leap year");
            //    }

            //}
            #endregion
            #region Exercise13
            //int n = int.Parse(Console.ReadLine());
            //if (Math.Sqrt(n) * Math.Sqrt(n) == n)
            //{
            //    Console.WriteLine("This is a square number");
            //}
            //else Console.WriteLine("This isn't a square number");
            #endregion
            #region Exercise14
            //back:
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //if (a + b <= c || a + c <= b || b + c <= a)
            //{
            //    WriteLine("Invalid Input");
            //    goto back;
            //}
            //else
            //{
            //    if (a == b && a == c && b == c)
            //    {
            //        WriteLine("This is an equilateral triangle");
            //    }
            //    else
            //    {
            //        Console.WriteLine("This isn't an equilateral triangle");
            //    }
            //}
            #endregion
            #region Exercise15
            //back:
            //    int a = int.Parse(Console.ReadLine());
            //    int b = int.Parse(Console.ReadLine());
            //    int c = int.Parse(Console.ReadLine());
            //    if (a + b <= c || a + c <= b || b + c <= a)
            //    {
            //        WriteLine("Invalid Input");
            //        goto back;
            //    }
            //    else
            //    {
            //        if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
            //        {
            //            WriteLine("This is a right triangle");
            //        }
            //        else
            //        {
            //            Console.WriteLine("This isn't a right triangle");
            //        }
            //    }
            #endregion
            #region Exercise16
            //float math = float.Parse(Console.ReadLine());
            //float physics = float.Parse(Console.ReadLine());   
            //float chemistry = float.Parse(Console.ReadLine());
            //if (math + physics + chemistry >= 15)
            //{

            //     if (math > 5 && physics > 5 && chemistry > 5)
            //    {

            //        WriteLine("Good at all courses");

            //    }
            //    else if (math <= 5 || physics <= 5 || chemistry <= 5)
            //    {
            //        WriteLine("Not good at all courses");
            //    }
            //   else if (math > 3 && chemistry > 3 && physics > 3)
            //    {

            //        WriteLine("Passed");

            //    }
            //    else
            //        WriteLine("Fail");
            //}
            //else
            //    WriteLine("Fail");
            #endregion

            #region Advanced1
            //int second = int.Parse(Console.ReadLine());
            //int hour = second / 3600;
            //second = second - hour * 3600;
            //int minute = second / 60;
            //second = second - minute * 60;
            //WriteLine($"{hour}:{minute}:{second}");

            #endregion
            #region Advanced2
            //int month = int.Parse(Console.ReadLine());
            //const int year = 2024;
            //if (month < 1 || month > 12)
            //{
            //    WriteLine("Invalid Input");
            //}
            //else
            //{
            //    if (month == 2)
            //    {
            //        if (DateTime.IsLeapYear(year))
            //            WriteLine(29);
            //        else WriteLine(28);
            //    }
            //    if (month == 4 || month == 6 || month == 9 || month == 11)
            //    {
            //        WriteLine(30);
            //    }
            //    else
            //    {
            //        WriteLine(31);
            //    }
            //}
            #endregion
            #region Advanced3
            //float a = int.Parse(Console.ReadLine());
            //float b = int.Parse(Console.ReadLine());
            //char Operator = char.Parse(Console.ReadLine());
            //if( Operator == '-' )
            //{
            //    WriteLine(a - b);
            //}
            //if(Operator == '+')
            //{
            //    WriteLine(b + a);
            //}
            //if (Operator == '*')
            //{
            //    WriteLine(a * b);
            //}
            //if(Operator == '/' && b == 0)
            //{

            //    WriteLine("Error");
            //}
            //if(Operator == '/' && b != 0) WriteLine(a / b);
            #endregion
            #region Advanced4
            //int n = int.Parse(Console.ReadLine());
            //if(n == 0)
            //{
            //    WriteLine("Zero");
            //}
            //if (n == 1)
            //{
            //    WriteLine("One");
            //}
            //if (n == 2)
            //{
            //    WriteLine("Two");
            //}
            //if (n == 3)
            //{
            //    WriteLine("Three");
            //}
            //if (n == 4)
            //{
            //    WriteLine("Four");
            //}
            //if (n == 5)
            //{
            //    WriteLine("Five");
            //}
            //if (n == 6)
            //{
            //    WriteLine("Six");
            //}
            //if (n == 7)
            //{
            //    WriteLine("Seven");
            //}
            //if (n == 8)
            //{
            //    WriteLine("Eight");
            //}
            //if (n == 9)
            //{
            //    WriteLine("Nine");
            //}
            #endregion
            #region Advanced5
            //int workingHour = int.Parse(Console.ReadLine());
            //int paymentPerHour = int.Parse(Console.ReadLine());
            //double salary = 0;
            //if(workingHour <= 40)
            //{
            //    salary = workingHour * paymentPerHour;
            //}
            //else
            //{
            //    salary = 40 * paymentPerHour + (workingHour - 40) * (paymentPerHour * 1.5);
            //}
            //WriteLine(salary);
            #endregion

            #region Ex1_Loop
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for(int i = 1; i <= n; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            #endregion
            #region Ex2_Loop
            //int m = int.Parse(Console.ReadLine());
            //int n = int.Parse(Console.ReadLine());
            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < m; j++)
            //    {
            //        Write("* ");
            //    }
            //    WriteLine();
            //}
            #endregion
            #region Ex3_Loop
            //int n = int.Parse(Console.ReadLine());
            //int count = 0;
            //while (count != n)
            //{
            //    for (int i = 2; i <= 10000; i++)
            //    {
            //        bool isPrime = true;
            //        for (int j = 2; j < i; j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                isPrime = false;
            //            }
            //        }
            //        if (isPrime)
            //        {
            //            count++;
            //            Write(i + " ");
            //        }
            //        if (count == n)
            //        {
            //            Console.WriteLine();
            //            break;
            //        }
            //    }
            //}
            #endregion
            #region Ex4_Loop
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int GCD = 0;
            //int GCF = 0;
            //int LCM = 0;
            //for (int i = a; i >= 1; i--)
            //{
            //    if (a % i == 0 && b % i == 0)
            //    {
            //        GCD = i;
            //        break;
            //    }
            //}
            //LCM = a * b / GCD;
            //GCF = a * b / LCM;
            //WriteLine($"GCD = {GCD}");
            //WriteLine($"GCF = {GCF}");
            //WriteLine($"LCM = {LCM}");
            #endregion
            #region Ex5_Loop
            //int n = int.Parse(Console.ReadLine());
            //string binary = string.Empty;
            //while (n > 0)
            //{
            //    binary += (n % 2).ToString();
            //    n /= 2;
            //}
            //for (int i = binary.Length - 1; i >= 0; i--)
            //{
            //    Write(binary[i]);
            //}
            #endregion
            #region Ex6_Loop
            //int n = int.Parse(ReadLine());
            //int cnt = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //        cnt++;
            //}
            //Console.WriteLine(cnt);
            #endregion
            #region Ex7_Loop
            //int chicken = 35;
            //int dog = 1;
            //while(true) 
            //{
            //    if(chicken * 2 +  dog * 4 == 100)
            //    {
            //        Console.WriteLine($"dogs: {dog} \nchickens: {chicken}");
            //        break;
            //    }
            //    chicken--;
            //    dog++;
            //}
            #endregion
            #region Ex8_Loop

            //for (int i = 1; i < 100; i++)
            //{
            //    for (int j = 1; j < 100; j++)
            //    {
            //        for (int k = 1; k < 100; k++)
            //        {
            //            if (5 * i + 3 * j + (1.0/3)*k == 100 && i + j + k == 100)
            //            {
            //                WriteLine($"Stand Buffalo: {i}");
            //                WriteLine($"Lie Buffalo: {j}");
            //                WriteLine($"Old Buffalo: {k}");
            //                WriteLine();
            //                break;
            //            }
            //        }
            //    }
            //}
            #endregion
            #region Ex9_Loop
            //back:
            //int n = int.Parse(Console.ReadLine());
            //if(n <= 0)
            //{
            //    Console.WriteLine("Please re-enter");
            //    goto back;
            //}
            //else
            //{
            //    for(int i = 1; i <= n; i++)
            //    {
            //        if(i % 2 != 0)
            //        {
            //            Console.Write(i + " ");
            //        }
            //    }
            //}

            #endregion
            #region Ex10_Loop
            //int n = int.Parse(Console.ReadLine());
            //ulong rs = 1;
            //for(uint i = 1; i <= n; i++)
            //{
            //    rs *= i;
            //}
            //WriteLine(rs);
            #endregion
            #region Ex11_Loop
            //int sum = 0;
            //while(true)
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    sum += n;
            //    if(n == 0)
            //    {
            //        break;
            //    }
            //}
            //WriteLine(sum);
            #endregion
            #region Ex12_Loop
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //while (true)
            //{
            //    if (a % b == 0)
            //    {
            //        WriteLine(b);
            //        break;
            //    }
            //    else a = a % b;
            //    if (b % a == 0)
            //    {
            //        WriteLine(a);
            //        break;
            //    }
            //    else b = b % a;

            //}
            #endregion
            #region Ex13_Loop
            //int n = int.Parse(Console.ReadLine());
            //float sum = 0;
            //float temp = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    temp += i * i;
            //    if (i % 2 == 0)
            //    {
            //        sum -= 1 / temp;
            //    }
            //    else sum += 1 / temp;

            //}
            //WriteLine( sum);
            #endregion
            #region Ex14_Loop
            //int n = int.Parse(Console.ReadLine());
            //int cnt = 0;
            //for(int i = 1; i <= n; i++)
            //{
            //    if(i % 2 != 0)
            //    {
            //        cnt++;
            //        Console.Write(i + " ");
            //        if(cnt % 15 == 0) 
            //            Console.WriteLine();
            //    }
            //}
            #endregion
            #region Ex15_Loop
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //        Console.Write(i + " ");
            //}
            //Console.WriteLine();
            #endregion
            #region Ex16_Loop
            //int n = int.Parse(Console.ReadLine());
            //bool isPrime = true;
            //for(int i = 2; i < n; i++)
            //{
            //    if(n % i == 0)
            //    {
            //        isPrime = false;
            //        break;
            //    }
            //}
            //if(isPrime)
            //    Console.WriteLine($"{n} is a prime number");
            //else 
            //    Console.WriteLine($"{n} is not a prime number");
            #endregion
            #region Ex17_Loop
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //        Console.Write(i + " ");
            //}
            //Console.WriteLine();
            #endregion
            #region Ex18_Loop
            //int n = int.Parse(Console.ReadLine());
            //WriteLine($"The biggest factor is {n}");
            //WriteLine("The smallest factor is 1");
            #endregion

            #region Advanced 1
            //for (int i = 100; i <= 999; i++)
            //{
            //    int j = i;
            //    int a = j % 10;
            //    j /= 10;
            //    int b = j % 10;
            //    j /= 10;
            //    int c = j % 10;
            //    if (a + b + c == a * b * c)
            //    {
            //        WriteLine(i);
            //    }
            //}
            #endregion
            #region Advanced 2
            back:
            string time = Console.ReadLine();
            int hour = 0;
            int minute = 0;
            int second = 0;
            hour = int.Parse(time.Substring(0, 2));
            minute = int.Parse(time.Substring(3, 2));
            second = int.Parse(time.Substring(6, 2));
            if (hour < 1 || hour > 23 ||  minute < 0 || minute > 59 || second < 0 || second > 59)
            {
                Console.WriteLine("Invalid Input");
                goto back;
            }
            else
            {
                second += 1;
                if(second == 60)
                {
                    second = 0;
                    minute += 1;
                    if(minute == 60)
                    {
                        minute = 0;
                        hour += 1;
                        
                    }
                }
            }
            WriteLine($"{hour}:{minute}:{second}");
            #endregion
        }
    }
}
