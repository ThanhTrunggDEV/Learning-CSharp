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
        static int Max(int a, int b)
        {
            if (a > b)
                return a;
            return b;
        }
        static void Main(string[] args)
        {
            #region Console Configuration
            Title = "Written And Designed By ThanhTrung";
            randomColor();
            OutputEncoding = Encoding.UTF8;
            #endregion
            int t = int.Parse(ReadLine());
            while(t > 0)
            {
                int n = int.Parse(ReadLine());
                var arr = new int[n];
                int maxl = 1;
                for(int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(ReadLine());
                }
                int maxtemp = 1;
                for(int j = 1; j < n; j++)
                {
                    if (arr[j - 1] < arr[j])
                    {
                        maxtemp++;
                    }
                    else
                    {
                        maxl = Max(maxl,maxtemp);
                        maxtemp = 1;
                    }
                }
                t--;
                WriteLine("\t" + maxl);
            }
        }
    }
}