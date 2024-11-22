using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Student_Management_System
{
    public class Class
    {
        private List<Student> students;
        public List<Student> Students { get { return students; } private set { students = value; } }
        public Class()
        {
            Students = new List<Student>();
        }
        public Class(List<Student> list)
        {
            Students = list;
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void RemoveStudent(string studentCode)
        {
           foreach (Student student in Students)
            {
                if(student.StudentCode == studentCode)
                {
                    Students.Remove(student);
                }
            }
            Console.WriteLine("Not Found");
        }
        public void AllStudent()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
