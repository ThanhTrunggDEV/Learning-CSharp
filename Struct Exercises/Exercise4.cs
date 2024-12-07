using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Struct_Exercises
{
    public struct Student4
    {
        public string Name;
        public bool Gender;
        public float mathScore;
        public float physicsScore;
        public float chemicalScore;
        public Student4(string Name, bool Gender, float mathScore, float physicsScore, float chemicalScore)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.mathScore = mathScore;
            this.physicsScore = physicsScore;
             this.chemicalScore = chemicalScore; 
        }
        public float GetTotalScore()
        {
            return mathScore + physicsScore + chemicalScore;
        }
        public string GetInfo()
        {
            return $"Name: {Name} | Gender: {Gender : Male ? Female} | Total Score: {GetTotalScore()}";
        }
    }
    public struct Exercise4
    {
        public static List<Student4> ListStudents = new List<Student4>();
        public static void AddStudent()
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter Name Of Student {i + 1}: ");
                string Name = Console.ReadLine();
                Console.Write($"Enter Gender Of Student {i + 1}: ");
                bool gender = bool.Parse(Console.ReadLine());
                Console.Write($"Enter Math Score Of Student {i + 1}: ");
                float mathScore = float.Parse(Console.ReadLine());
                Console.Write($"Enter Physics Score Of Student {i + 1}: ");
                float physicsScore = float.Parse(Console.ReadLine());
                Console.Write($"Enter Chemical Score Of Student {i + 1}: ");
                float chemicalScore = float.Parse(Console.ReadLine());
                ListStudents.Add(new Student4(Name,gender, mathScore, physicsScore, chemicalScore));
            }
        }
        public static void PrintStudents()
        {
            for (int i = 0; i < ListStudents.Count; i++)
            {
                int minIndex = i;
                for (int j = 1 + i; j < ListStudents.Count; j++)
                {
                    if (ListStudents[minIndex].GetTotalScore() > ListStudents[j].GetTotalScore())
                    {
                        minIndex = j;
                    }
                }
                Student4 temp = ListStudents[minIndex];
                ListStudents[minIndex] = ListStudents[i];
                ListStudents[i] = temp;
            }
            
            int stt = 1;
            foreach (Student4 student in ListStudents)
            {
                
                Console.WriteLine($"STT: {stt++} " + student.GetInfo());
            }
        }

    }
}
