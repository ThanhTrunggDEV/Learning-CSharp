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
            Bank bank = new Bank();
            Account account1 = new SavingAccount(10, "00co", 0, "ThanhTrung");
            Account account2 = new CheckingAccount(5, "6677", 0, "Ryan");
            bank.AddAccount(account1);
            bank.AddAccount(account2);
            bank.Deposit("6677",100000000);
        //    bank.FindAccount("00co");

            bank.ListBankAccounts();
        }
    }
}