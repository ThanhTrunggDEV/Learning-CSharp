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
using Learning_CSharp.Student_Management_System;
using Learning_CSharp.Smart_Home_Management;
using Learning_CSharp.Struct_Exercises;
using System.Data.Common;
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

            TestFraction test = new TestFraction();
            test.Init();
            test.Input();
            Console.WriteLine("Before Operation:");
            test.OutPut();
            Console.WriteLine("Inversed: ");
            test.Inverse();
            test.OutPut();
            Console.WriteLine("Largest: ");
            test.Largerst();
        }
    }
    
}