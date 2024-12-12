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
            StringExercise.Exercise4.Input();
            //StringExercise.Exercise4.EraseLeftSpace();
            //StringExercise.Exercise4.EraseRightSpace();
            //StringExercise.Exercise4.EraseMiddleSpace();
            //Console.WriteLine(StringExercise.Exercise4.input);
            StringExercise.Exercise4.isToanSo();
        }
    }
    
}