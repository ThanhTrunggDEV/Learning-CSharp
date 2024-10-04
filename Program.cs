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
            ForegroundColor = ConsoleColor.Magenta;
            OutputEncoding = Encoding.UTF8;
            #endregion

            #region Loading Animation
            Write("Đang xử lý...");
            Thread.Sleep(1000);
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(1);
                //Console.Beep();
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
            string[] s = new string[100];
            string s1 = "";
            int id = 0;
            while (true)
            {
                for (char c = 'a'; c <= 'z'; c++)
                {
                    Sleep(5);
                    s[id] = c.ToString();
                    Write($"\r\n{s1}" + s[id]);
                    if (c == 'h' && id == 0)
                    {
                        s1 += c;
                        id++;
                       // Write("\n");
                    }
                    if (c == 'e' && id == 1)
                    {
                        s1 += c;
                        id++;
                       // Write("\n");
                    }
                    if (c == 'l' && id == 2 || c == 'l' && id == 3)
                    {
                        s1 += c;
                        id++;
                       // Write("\n");
                    }
                    if (c == 'o' && id == 4)
                    {
                        s1 += c + " ";
                        id+=2;
                       // Write("\n");
                    }
                    if (c == 'w' && id == 6)
                    {
                        s1 += c;
                        id++;
                       // Write("\n");
                    }
                    if (c == 'o' && id == 7)
                    {
                        s1 += c;
                        id++;
                       // Write("\n");
                    }
                    if (c == 'r' && id == 8)
                    {
                        s1 += c;
                        id++;
                       // Write("\n");
                    }
                    if (c == 'l' && id == 9)
                    {
                        s1 += c;
                        id++;
                        //Write("\n");
                    }
                    if (c == 'd' && id == 10)
                    {
                        s1 += c;
                        id++;
                        Write("\n");
                        return;
                    }
                }
            }
            
        }
       
    }
}
