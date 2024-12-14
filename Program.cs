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
using Learning_CSharp.Hospital_Management_System;
using Microsoft.Win32.SafeHandles;
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
            Hospital hospital = new Hospital();
            hospital.AddPerson(new Doctor("Teeth", 10, "Jack", 30, "Ha Noi"));
            hospital.AddPerson(new Doctor(" ", 10, "Jack", 30, "Ha Noi"));
            hospital.AddPerson(new Doctor("Teeth", 10, "Jack", 30, "Ha Noi"));
            hospital.AddPerson(new Doctor("Teeth", 10, "Jack", 30, "Ha Noi"));

            hospital.AddPerson(new Nurse(10, "Lisa", 18, "Nam Dinh"));
            hospital.AddPerson(new Nurse(10, "Lisa", 18, "Nam Dinh"));
            hospital.AddPerson(new Nurse(10, "Lisa", 18, "Nam Dinh"));
            hospital.DisplayPeopleByType<Doctor>();
        }
    }
    
}