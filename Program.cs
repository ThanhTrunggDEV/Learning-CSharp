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
using System.Data.Common;
using Learning_CSharp.Learning_At_School;
using System.IO;
using Microsoft.Win32.SafeHandles;
using System.Linq;
using OfficeOpenXml.LoadFunctions.Params;
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

            //HinhChuNhat hinhChuNhat = new HinhChuNhat();
            //hinhChuNhat.ChieuDai = float.Parse(Console.ReadLine());
            //hinhChuNhat.ChieuRong = float.Parse(Console.ReadLine());
            //hinhChuNhat.Cal_Perimeter();
            //hinhChuNhat.Cal_Area();
            Student student = new Student();
            Console.Write("Enter Name: ");
            student.FullName = Console.ReadLine();
            Console.Write("Enter Hometown: ");
            student.HomeTown = Console.ReadLine();
            Console.Write("Enter Age: ");
            student.Age = int.Parse(Console.ReadLine());
            Console.Write("Enter Math Score: ");
            student.MathScore = float.Parse(Console.ReadLine());
            Console.Write("Enter IT Score: ");
            student.ITScore = float.Parse(Console.ReadLine());
            Console.Write("Enter English Score: ");
            student.EnglishScore = float.Parse(Console.ReadLine());
            student.DisplayInfor();
            student.Cal_AverageScore();

            Console.WriteLine("Hello You Guys");

        }
    }
}