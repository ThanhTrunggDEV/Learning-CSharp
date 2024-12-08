using NAudio.MediaFoundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Struct_Exercises
{
            //    TestClass.AddClass();
            //TestClass.ClassWithTheMostStudent();    ////CODE FOR TEST
            //TestClass.ClassWithTheFewestStudent();
            //TestClass.StudentWithHigestAverage();
            //TestClass.ClassesWithMoreThanFiveGoodStudents();
            //TestClass.ClassWithTheHighestNumberOfStudentsWithGoodAveragePoint();
    public struct Class
    {
        public string ClassName;
        public List<Student> StudentList;
        public Class(string ClassName, List<Student> students)
        {
            this.ClassName = ClassName;
            StudentList = students;
        }
        public string GetInfo()
        {
            return $"Class Name: {ClassName} | Number Of Student: {StudentList.Count}";
        }
    }
    public struct TestClass
    {
        public static List<Class> ListClasses = new List<Class>();
        private static void AddStudent(List<Student> list, int numberOfStudent)
        {
            for (int i = 0; i < numberOfStudent; i++)
            {
                Console.Write($"Enter Name Of Student {i + 1}: ");
                string name = Console.ReadLine();
                Console.Write($"Enter ID Of Student {i + 1}: ");
                string id = Console.ReadLine();
                Console.Write($"Enter Date Of Birth Of Student {i + 1}: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write($"Enter Math Grade Of Student {i + 1}: ");
                double math = double.Parse(Console.ReadLine());
                Console.Write($"Enter Physics Grade Of Student {i + 1}: ");
                double physics = double.Parse(Console.ReadLine());
                Console.Write($"Enter Chemical Grade Of Student {i + 1}: ");
                double chemical = double.Parse(Console.ReadLine());
                list.Add(new Student(id, name, year, math, physics, chemical));

            }
        }
        public static void AddClass()
        {
            
            Console.Write("Enter Number Of Class: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter Class Name: ");
                string ClassName = Console.ReadLine();
                List<Student> list = new List<Student>();
                Console.Write($"Enter Number Student Class {ClassName}: ");
                int n2 = int.Parse(Console.ReadLine());
                AddStudent(list, n2);
                ListClasses.Add(new Class(ClassName, list));
            }
        }
        public static void ClassesWithMoreThanFiveGoodStudents()
        {
            foreach(Class clas in ListClasses)
            {
                int cnt = 0;
                foreach(Student student in clas.StudentList)
                {
                    if(student.GetAverageGrade() >= 5)
                    {
                        cnt++;
                    }
                }
                if(cnt > 5)
                    Console.WriteLine(clas.GetInfo() + $"And {cnt} Good Students");
            }
        }
        public static void ClassWithTheMostStudent()
        {
            Class result = ListClasses[0];
            foreach(Class clas in ListClasses)
            {
                if(clas.StudentList.Count >= result.StudentList.Count)
                    result = clas;
            }
            Console.WriteLine(result.GetInfo() + " Is the class with the most student");
        }
        public static void ClassWithTheFewestStudent()
        {
            Class result = ListClasses[0];
            foreach (Class clas in ListClasses)
            {
                if (clas.StudentList.Count <= result.StudentList.Count)
                    result = clas;
            }
            Console.WriteLine(result.GetInfo() + " Is the class with the fewest student");
        }
        public static void StudentWithHigestAverage()
        {
            Student result = ListClasses[0].StudentList[0];
            foreach (Class clas in ListClasses)
            {
                foreach (Student student in clas.StudentList)
                {
                    if (result.GetAverageGrade() <= student.GetAverageGrade())
                    {
                        result = student;
                    }
                }
            }
            Console.WriteLine("He/She is the student with higest average:\n" + result.GetInfor());
        }
        public static void ClassWithTheHighestNumberOfStudentsWithGoodAveragePoint()
        {
            Class result = new Class();
            int maxStudentWithGoodPoint = -1;
            foreach (Class clas in ListClasses)
            {
                int cnt = 0;
                foreach (Student student in clas.StudentList)
                {
                    if (student.GetAverageGrade() >= 5)
                    {
                        cnt++;
                    }
                }
                if (cnt > maxStudentWithGoodPoint)
                {
                    maxStudentWithGoodPoint = cnt;
                    result = clas;
                }
            }
            Console.WriteLine($"Class {result.ClassName} is the class with the highest number of students with a good grade point average with {maxStudentWithGoodPoint} students per {result.StudentList.Count}");
        }
    }
}
