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
namespace Learning_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Console Configuration
            Title = "Written And Designed By ThanhTrung";
            Advanced.randomColor();
            OutputEncoding = Encoding.UTF8;
            #endregion
            ShoppingApp.Init();
            ShoppingApp.Start();
        }
    }
}

