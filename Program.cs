using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Numerics;
using System.Threading;
using static System.Console;
using static System.Math;
using static System.Threading.Thread;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Linq;
using System.IO;
using System.Data.Common;
using System.ComponentModel.Design;
using System.Runtime.Remoting.Messaging;
using System.ComponentModel;
using ThanhTrung;
using static ThanhTrung.Advanced;
using System.Globalization;
using System.Text.RegularExpressions;
using System.CodeDom.Compiler;
using Decode;
using OfficeOpenXml;
using System.Reflection;
using Learning_CSharp.Zoo_Management;
using Xunit;
using Learning_CSharp.Library_Management_System;
using Learning_CSharp.Bank_Account_Management_System;
using Learning_CSharp.Student_Management_System;
using System.Xml.Schema;
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
            for (int i = 0; i < n; i++)
            {
                arr[i] = rd.Next(100);
            }
           
            Array.Sort(arr);
            Stopwatch sw = Stopwatch.StartNew();
            if(Array.BinarySearch(arr, 0, n, 10) >= 0)
                Console.WriteLine(arr[Array.BinarySearch(arr, 0, n, 10)]);
            else
                Console.WriteLine("Not Found");
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            Stopwatch sw2 = Stopwatch.StartNew();
            if (Algorithms.BinarySearch(arr, 0, n, 10) >= 0)
                Console.WriteLine(arr[Algorithms.BinarySearch(arr, 0, n, 10)]);
            else
                Console.WriteLine("Not Found");
            sw2.Stop();
            Console.WriteLine(sw2.ElapsedMilliseconds);
        }
    }
}