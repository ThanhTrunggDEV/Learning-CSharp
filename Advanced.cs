﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Threading.Thread;
using System.Threading;
using System.Threading.Tasks;
using OfficeOpenXml.ConditionalFormatting.Contracts;

namespace ThanhTrung
{
    public class Advanced
    {
       public static void randomColor()
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
       public static void Loading()
        {
            randomColor();
            Write("\rProcessing.");
            Sleep(1000);
            randomColor();
            Write("\rProcessing..");
            Sleep(1000);
            randomColor();
            Write("\rProcessing...");
            string process = ".....................................................................................................";
            var pr = process.ToCharArray();
            Sleep(500);
            for (int i = 0; i <= 100; i++)
            {
                Sleep(100);
                randomColor();
                Write($"\rLoading {i}% [{process}]");
                pr[i] = '#';
                process = string.Join("", pr);
                if (i == 100)
                {
                    Clear();
                    Write("\rCompleted");
                }
            }
            Thread.Sleep(500);
            Clear();
        }
        public static void Generate()
        {
            Console.Write("Enter a string: ");
            string input = ReadLine();
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
