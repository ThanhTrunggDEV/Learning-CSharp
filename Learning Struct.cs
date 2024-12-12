using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
{
   public class Ex
    {
        public static void Exercise1()
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }
            Console.WriteLine();
        }
        public static void Exercise2()
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();
            for(int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
            Console.WriteLine();
        }
        public static void Exercise3()
        {
            Console.Write("Enter a string: ");
            int cnt = 1;
            string s = Console.ReadLine();
            for(int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == ' ' && s[i + 1] != ' ')
                    cnt++;
            }
            if (s[0] == ' ')
                Console.WriteLine($"{cnt - 1} word(s) in {s}");
            else
                Console.WriteLine($"{cnt} word(s) in {s}");
        }
        public static void Exercise4()
        {
            Console.Write("Enter the first string: ");
            string firstString = Console.ReadLine();
            Console.Write("Enter the second string: ");
            string secondString = Console.ReadLine();
            if(firstString.Length != secondString.Length)
            {
                Console.WriteLine("False");
                return;
            }
            else
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    if (firstString[i] != secondString[i])
                    {
                        Console.WriteLine("False");
                        return;
                    }
                }
                Console.WriteLine("True");
            }
        }
        public static void Exercise5()
        {
            int alphabet = 0;
            int digits = 0;
            int special = 0;
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A' && s[i] <= 'z')
                    alphabet++;
                else if (s[i] >= '0' && s[i] <= '9')
                    digits++;
                else
                    special++;
            }
            Console.WriteLine($"Number of alphabet: {alphabet}");
            Console.WriteLine($"Number of digits: {digits}");
            Console.WriteLine($"Number of special char: {special}");
        }
        public static void Exercise6()
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();
            int vowels = 0;
            int consonants = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'u' || s[i] == 'e' || s[i] == 'o' || s[i] == 'a' || s[i] == 'i'
                 || s[i] == 'U' || s[i] == 'E' || s[i] == 'O' || s[i] == 'A' || s[i] == 'I')
                    vowels++;
                else if (s[i] != ' ')
                    consonants++;
            }
            Console.WriteLine($"Number of vowels: {vowels}");
            Console.WriteLine($"Number of consonants: {consonants}");
        }
    }  
}
