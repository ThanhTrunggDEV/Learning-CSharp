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
using Learning_CSharp.Student_Management_System;
namespace Learning_CSharp
{
    internal class Program
    {
        public static void AddStudent(List<Student> list, int numberOfStudent)
        {
            for (int i = 0; i < numberOfStudent; i++)
            {
                Console.Write($"Enter Name Of Student {i + 1}: ");
                string name = Console.ReadLine();
                Console.Write("$Enter ID Of Student {i + 1}: ");
                string id = Console.ReadLine();
                Console.Write("$Enter Date Of Birth Of Student {i + 1}: ");
                int year = int.Parse(ReadLine());
                Console.Write("$Enter Math Grade Of Student {i + 1}: ");
                double math = double.Parse(ReadLine());
                Console.Write("$Enter Physics Grade Of Student {i + 1}: ");
                double physics = double.Parse(ReadLine());
                Console.Write("$Enter Chemical Grade Of Student {i + 1}: ");
                double chemical = double.Parse(ReadLine());
                list.Add(new Student(id, name, year, math, physics, chemical));

            }
        }
        public static void PrintStudent(List<Student> students)
        {
            Console.WriteLine("Student List:");
            foreach(var item in students)
                Console.WriteLine(item.GetInfor());
        }
        public static void FindStudent(List<Student> students)
        {
            double maxScore = 0;
            Student student = new Student();
            foreach (var item in students)
            {
                if(item.GetAverageGrade() > maxScore)
                {
                    student = item;
                }
            }
            Console.WriteLine("The best student is:");
            Console.WriteLine(student.GetInfor());
        }

        public static void SortMathGrade(List<Student> students)
        {
            for(int i = 0; i <  students.Count; i++)
            {
                int minIndex = i;
                for(int j = i + 1; j < students.Count; j++)
                {
                    if (students[j].mathGrade > students[minIndex].mathGrade)
                        minIndex = j;
                }
                Student temp = students[i];
                students[i] = students[minIndex];
                students[minIndex] = temp;
            }
        }
        public static void SortAverage(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < students.Count; j++)
                {
                    if (students[j].GetAverageGrade() < students[minIndex].GetAverageGrade())
                        minIndex = j;
                }
                Student temp = students[i];
                students[i] = students[minIndex];
                students[minIndex] = temp;
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
            Console.Write("Enter Number of Student: ");
            int numberOfStudent = int.Parse(Console.ReadLine());
            AddStudent(students, numberOfStudent);
            PrintStudent(students);
            Console.WriteLine("Sorted Follow Math Grade:");
            SortMathGrade(students);
            PrintStudent(students);
            Console.WriteLine("Sorted Follow Average Grade: ");
            SortAverage(students);
            PrintStudent(students);
            FindStudent(students);
        }
    }
    
}