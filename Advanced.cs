using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Threading.Thread;
using System.Threading;
using System.Threading.Tasks;
using OfficeOpenXml.ConditionalFormatting.Contracts;
using System.Windows.Media.Animation;
using System.IO;

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
                Sleep(10);
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
        public static void Heart()
        {
            for(float x = 1.5f; x >= -1.5; x -= 0.1f)
            {
                for(float y = -1.5f; y <= 1.5; y += 0.1f)
                {
                    Sleep(10);
                    if(Math.Pow(y * y + x * x - 1,3) - Math.Pow(y,2) * Math.Pow(x,3) <= 0.0f)
                        Console.Write("+");
                    else
                        Console.Write("-");
                }
                Console.WriteLine();
            }
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
        public static void ScholarShip()
        {
            List<string> list = File.ReadAllLines(@"D:\Downloads\K21.22_ky-1_Lan-1_24-25-_1_ (1).csv").ToList();
            List<string> newList = new List<string>();
            foreach (var item in list)
            {
                if ((item.Contains("CNTT") || item.Contains("ATTT") || item.Contains("HTTT") || item.Contains("KTPM") || item.Contains("KHMT")))
                {

                    string[] temp = item.Split(',', '"');
                    string temp2 = string.Empty;
                    foreach (var item1 in temp)
                    {
                        if (item1 != "")
                        {
                            temp2 += item1;
                            temp2 += " ";
                        }
                    }
                    temp2 = temp2.TrimEnd();
                    newList.Add(temp2);

                }

            }
            int cnt = 0;

            foreach (var item in newList)
            {
                double score = 0;
                for (int i = item.Length - 1; i >= 0; i--)
                {
                    if (item[i] == ' ')
                    {
                        string s = item.Substring(i);
                        score = double.Parse(s);
                        break;
                    }
                }
                if (score >= 4.0)
                {
                    Console.WriteLine(item);
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
