using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static System.Console;
using System.Threading;
using static System.Math;
using static System.Threading.Thread;
using static ThanhTrung.Advanced;
using System.Globalization;
namespace Learning_CSharp
{

    internal class Program
    {
        public static void InputRandom(int[] arr)
        {
            Random rd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(101);
            }
        }
        public static void Input(int[] arr)
        {
            Random rd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(ReadLine());
            }
        }
        public static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region Console Configuration
            Title = "Written And Designed By ThanhTrung";
            randomColor();
            OutputEncoding = Encoding.UTF8;
            #endregion
            int row = int.Parse(ReadLine());
            int col = int.Parse(ReadLine());
            int[,] arr = new int[col, row];
            int ip = 1;
            for(int i = 0; i < col; i++)
            {
                for(int j = 0; j < row; j++)
                {
                    arr[i, j] = ip;
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
            int k = int.Parse(ReadLine());
            int t = row - k + 1;
            if(t > row)
                t/=row;
            if (t == row)
                t = 0;
            for(int i = 0; i < col;i++)
            {
                Console.WriteLine(arr[i, row - k]);
            }
            for(int i = 0; i < col; i++)
            {
                for(int j = t; j < row; j++)
                {
                    Console.WriteLine(arr[j,i]);
                }

            }

        }
    }
}