using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Struct_Exercises
{
            //    Excercise2.AddStudent();
            //Excercise2.PrintStudents();  ////CODE FOR TEST
            //Console.WriteLine("Promoted Student: " + Excercise2.PromotedStudent());
    public struct Excercise2
    {
        public static List<Student> ListStudents = new List<Student>();
        public static void AddStudent()
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Enter ID Of Student {i + 1}: ");
                string ID = Console.ReadLine();
                Console.Write($"Enter Name Of Student {i + 1}: ");
                string Name = Console.ReadLine();
                Console.Write($"Enter Year Of Birth Of Student {i + 1}: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write($"Enter Math Score Of Student {i + 1}: ");
                double mathScore = double.Parse(Console.ReadLine());
                Console.Write($"Enter Physics Score Of Student {i + 1}: ");
                double physicsScore = double.Parse(Console.ReadLine());
                Console.Write($"Enter Chemical Score Of Student {i + 1}: ");
                double chemicalScore = double.Parse(Console.ReadLine());
                ListStudents.Add(new Student(ID, Name, year, mathScore, physicsScore, chemicalScore));
            }
        }
        public static void PrintStudents()
        {
            foreach(Student student in ListStudents)
            {
                Console.WriteLine(student.GetInfor());
            }
        }
        public static int PromotedStudent()
        {
            int cnt = 0;
            foreach(Student student in ListStudents)
            {
                if(student.GetAverageGrade() >= 5)
                    cnt++;
            }
            return cnt;
        }
    }
}
