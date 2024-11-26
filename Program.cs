using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static System.Console;
using System.Threading;
using static System.Math;
using static System.Threading.Thread;
using static ThanhTrung.Advanced;
namespace Learning_CSharp
{
    public struct StudenT
    {
        private string fullName;
        public string FullName { get { return fullName; } set { fullName = value; } }
        public int age;
        public StudenT(string s, int a)
        {
            age = a;
            fullName = s;
        }
        public override string ToString()
        {
            return $"{FullName} {age}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Console Configuration
            Title = "Written And Designed By ThanhTrung";
            randomColor();
            OutputEncoding = Encoding.UTF8;
            #endregion
            var listStudent = new List<StudenT>();
            
            listStudent.Add(new StudenT("Thanh Trung", 20));
            listStudent.Add(new StudenT("Ryan", 30));
            foreach (var item in listStudent)
            {
                Console.WriteLine(item);
            }
        }
    }
}