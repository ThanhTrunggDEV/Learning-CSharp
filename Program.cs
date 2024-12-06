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

            Complex a = new Complex( 1,2);
            Complex b = new Complex(1, -2);
            
            Console.WriteLine((a+b).GetInfo());
            Console.WriteLine((a- b).GetInfo());
            Console.WriteLine((a*b).GetInfo());
            Console.WriteLine((a/b).GetInfo());
        }
    }
    
}