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
            string[] letter = new string[100];
            string listLetter = "";
            int index = 0;
            while (true)
            {
                for (char character = 'A'; character <= 'z'; character++)
                {
                    Sleep(50);
                    letter[index] = character.ToString();
                    Write($"\r\n{listLetter}" + letter[index]);
                    if (character == 'H' && index == 0)
                    {
                        listLetter += character;
                        index++;
                       // Write("\n");
                    }
                    if (character == 'e' && index == 1)
                    {
                        listLetter += character;
                        index++;
                       // Write("\n");
                    }
                    if (character == 'l' && index == 2 || character == 'l' && index == 3)
                    {
                        listLetter += character;
                        index++;
                       // Write("\n");
                    }
                    if (character == 'o' && index == 4)
                    {
                        listLetter += character + " ";
                        index+=2;
                       // Write("\n");
                    }
                    if (character == 'W' && index == 6)
                    {
                        listLetter += character;
                        index++;
                       // Write("\n");
                    }
                    if (character == 'o' && index == 7)
                    {
                        listLetter += character;
                        index++;
                       // Write("\n");
                    }
                    if (character == 'r' && index == 8)
                    {
                        listLetter += character;
                        index++;
                       // Write("\n");
                    }
                    if (character == 'l' && index == 9)
                    {
                        listLetter += character;
                        index++;
                        //Write("\n");
                    }
                    if (character == 'd' && index == 10)
                    {
                        listLetter += character;
                        index++;
                        Write("\n");
                        return;
                    }
                }
            }
        }
    }
}
