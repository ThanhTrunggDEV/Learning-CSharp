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
//using Learning_CSharp.Struct_Exercises;
using System.Data.Common;
using Learning_CSharp.Library_System;
using Learning_CSharp.Struct_Exercises;
using System.IO;
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

            Fraction a = new Fraction(1,2);
            Fraction b = new Fraction(2,3);
            Console.WriteLine((a - b).GetData());

        }
    }
    
}