using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static System.Console;
using static ThanhTrung.Advanced;
namespace Learning_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Console Configuration
            Title = "Written And Designed By ThanhTrung";
            randomColor();
            OutputEncoding = Encoding.UTF8;
            #endregion
            int n = int.Parse(Console.ReadLine());
            Random rd = new Random();
            var arr = new int[n];
            var arr2 = new int[n];
            var arr3 = new int[n];
            var arr4 = new int[n]; 
            var arr5 = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rd.Next(1000);
                arr5[i] = rd.Next(1000);
                arr2[i] = rd.Next(1000);
                arr3[i] = rd.Next(200000000);
                //Console.Write(arr[i] +  " ");
            }


            Stopwatch sw6 = Stopwatch.StartNew();
            Algorithms.CountingSort(arr3);
            sw6.Stop();
            Console.WriteLine(sw6.ElapsedMilliseconds);

            Stopwatch sw4 = Stopwatch.StartNew();
            Array.Sort(arr);
            sw4.Stop();
            Console.WriteLine(sw4.ElapsedMilliseconds);
        }
    }
}