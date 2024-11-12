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
            Loading();
            int n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(ReadLine());
            }
            int length = 0;
            var rs = new int[n];
            for(int i = 0; i < n; i++)
            {
                if( arr[i] != 28)
                    rs[length++] = arr[i];
            }
            WriteLine();
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine(rs[i]);
            }
        }
    }
}