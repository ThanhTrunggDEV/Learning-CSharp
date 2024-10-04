using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Threading;
using System.Runtime.ExceptionServices;
using System.Reflection;
using static System.Console;
using static System.Threading.Thread;
namespace Learning_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Console Figuration
            Title = "This is a console =))";
            ForegroundColor = ConsoleColor.Green;
            OutputEncoding = Encoding.UTF8;
            #endregion
            Write("Enter What You Wanna Say (number and special character are invalid): ");
            string input = ReadLine();
            #region Loading Animation
            Write("\rProcessing.");
            Sleep(1000);
            Write("\rProcessing..");
            Sleep(1000);
            Write("\rProcessing...");
            Sleep(500);
            for (int i = 0; i <= 100; i++)
            {
                Sleep(10);
                Write($"\rLoading {i}%...");
                if (i == 100)
                {
                    Clear();
                    Write("\rCompleted");
                }
            }
            Thread.Sleep(500);
            Clear();
            #endregion
            string output = string.Empty;
            int position = 0;
            while (true)
            {
                for (char character = 'A'; character <= 'z'; character++)
                {
                    Sleep(50);
                    Write("\r\n" + output + character);
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
    }
}
