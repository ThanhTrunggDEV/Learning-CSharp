using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace Learning_CSharp
{
    public class StringExercise
    {
        public static void Exercise1()
        {
            string s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
            Console.WriteLine();
        }

        public static void Exercise2()
        {
            string s = Console.ReadLine();
            char rs = 'a';
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int temp = 1;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                        temp++;
                }
                if (max < temp)
                {
                    max = temp;
                    rs = s[i];
                }
            }
            Console.WriteLine(rs);
        }
        public static void Exercise3()
        {
            string s = Console.ReadLine();
            s = " " + s;
            string rs = "a";
            for (int i = 0; i < s.Length - 1; i++)
            {
                string temp = string.Empty;
                if (s[i] == ' ' && s[i + 1] != ' ')
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[j] != ' ')
                            temp += s[j];
                        else break;
                    }
                    if (temp.Length > rs.Length)
                        rs = temp;
                }
            }
            Console.WriteLine(rs);
        }

        public static class Exercise4
        {
            public static string input;
            public static void Input()
            {
                input = Console.ReadLine();
            }
            public static int GetLength()
            {
                return input.Length;
            }
            public static void GetLowerCase()
            {
                Console.WriteLine(input.ToLower());
            }
            public static void GetUpperCase()
            {
                Console.WriteLine(input.ToUpper());
            }
            public static void EraseLeftSpace()
            {
                int i = 0;
                while (input[i] == ' ')
                {
                    i++;
                }
                input = input.Remove(0, i);
            }
            public static void EraseRightSpace()
            {
                int i = input.Length - 1;

                while (input[i] == ' ')
                {
                    i--;
                }
                if (i != input.Length - 1)
                    input = input.Remove(i + 1);
            }
            public static void EraseMiddleSpace()
            {
                for (int i = 0; i < input.Length - 1; i++)
                {
                    while (input[i] == ' ' && input[i + 1] == ' ')
                    {
                        input = input.Remove(i, 1);
                    }
                }
            }
            public static void CountWord()
            {
                string temp = " " + input;
                int cnt = 0;
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] == ' ' && temp[i + 1] != ' ')
                        cnt++;
                }
                Console.WriteLine($"There are {cnt} word(s) in {input}");
            }
            public static void isToanSo()
            {
                bool isOk = true;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] < '0' || input[i] > '9')
                    {
                        isOk = false;
                        break;
                    }
                }
                if(isOk)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
        }
    }
}
