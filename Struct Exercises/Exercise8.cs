using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;

namespace Learning_CSharp.Struct_Exercises
{
    //List<Student> students = new List<Student>();
    //int n = int.Parse(Console.ReadLine());
    //Manage.AddStudent(students, n);
    //        Console.WriteLine();
    //        Manage.PrintStudent(students);
    //        Console.WriteLine();
    //        Manage.FindStudent(students);
    //        Console.WriteLine();
    //        Manage.SortAverage(students);
    //        Console.WriteLine("Sorted: ");           // CODE FOR TEST
    //        Manage.PrintStudent(students);
    //        Console.WriteLine();
    //        Manage.SortMathGrade(students);
    //        Console.WriteLine("Sorted: ");
    //        Manage.PrintStudent(students);
    //        Console.WriteLine();
    //        Manage.PrintStudent3_5(students);
    //        Console.WriteLine("Oldest: ");
    //        Manage.OldestStudent(students);
    //        Console.WriteLine();
    //        Console.WriteLine("Find by Name: ");
    //        Manage.FindStudentByName("Nguyen Thanh Trung", students);
    //        Manage.FindStudentByName("Jack", students);
    public struct Student
    {
        public string studentID;
        public string fullName;
        public int yearOfBirth;
        public double mathGrade;
        public double chemicalGrade;
        public double physicsGrade;

        public Student(string id, string fullName, int dateOfBirth, double math, double physics, double chemical)
        {
            this.studentID = id;
            this.fullName = fullName;
            this.yearOfBirth = dateOfBirth;
            this.mathGrade = math;
            this.physicsGrade = physics;
            this.chemicalGrade = chemical;
        }
        public double GetAverageGrade()
        {
            return (mathGrade + physicsGrade + chemicalGrade) / 3;
        }
        public string GetInfor()
        {
            return $"ID: {studentID} | Name: {fullName} | Date Of Birth: {yearOfBirth} | Math Score: {mathGrade} | Physics Score: {physicsGrade} | Chemical Score: {chemicalGrade} | Average Grade: {GetAverageGrade()}";
        }
    }
    public struct Manage
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
            foreach (var item in students)
                Console.WriteLine(item.GetInfor());
        }
        public static void FindStudent(List<Student> students)
        {
            Student student = students[0];
            foreach (var item in students)
            {
                if (item.GetAverageGrade() >= student.GetAverageGrade())
                {
                    student = item;
                }
            }
            Console.WriteLine("The best student is:");
            Console.WriteLine(student.GetInfor());
        }

        public static void SortMathGrade(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < students.Count; j++)
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
        public static void PrintStudent3_5(List<Student> students)
        {
            foreach(var student in students)
            {
                if(student.GetAverageGrade() > 5 && student.mathGrade >= 3 && student.chemicalGrade >= 3 && student.physicsGrade >= 3)
                {
                    Console.WriteLine(student.GetInfor());
                }
            }
        }
        public static void OldestStudent(List<Student> students)
        {
            Student oldestStudent = students[0];
            foreach (var student in students)
            {
                if(student.yearOfBirth <= oldestStudent.yearOfBirth)
                    oldestStudent = student;
            }
            Console.WriteLine(oldestStudent.GetInfor());
        }
        public static void FindStudentByName(string name, List<Student> students)
        {
            foreach(Student student in students)
            {
                if(student.fullName == name)
                {
                    Console.WriteLine(student.GetInfor());
                    return;
                }
            }
            Console.WriteLine($"Not Found Student Named {name}");
        }
    }
}
