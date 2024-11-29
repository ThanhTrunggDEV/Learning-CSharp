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
namespace Learning_CSharp
{

    internal class Program
    {
        struct Student
        {
            public int Id;
            public string Name;
            public float GPA;
            public Student(int id, string name, float gpa)
            {
                Id = id;
                Name = name;
                GPA = gpa;
            }
            
        }
        static void Main(string[] args)
        {
            #region Console Configuration
            Title = "Written And Designed By ThanhTrung";
            randomColor();
            OutputEncoding = Encoding.UTF8;
            #endregion
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Thanh Trung", 3.9f));
            students.Add(new Student(3, "Byan", 3.8f));
            students.Add(new Student(2, "Cack", 3.7f));
            students.Add(new Student(4, "Dra", 3.6f));
            students.Add(new Student(5, "Anh", 3.5f));
            for(int i = 0; i < students.Count; i++)
            {
                int minIndex = i;
                for(int j = i + 1; j < students.Count; j++)
                {
                    if (students[minIndex].Name[0] > students[j].Name[0])
                        minIndex = j;
                }
                Student temp = students[minIndex];
                students[minIndex] = students[i];
                students[i] = temp;
            }
            foreach (Student student in students)
            {
                Console.WriteLine($" ID: {student.Id} Name: {student.Name} GPA: {student.GPA}");
            }
        }
    }
}