using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Student_Management_System
{
    public class Student
    {
        private string studentCode;
        private string fullName;
        private float gpa;

        public string FullName { get { return fullName; } set { fullName = value; } }
        public float Gpa { get { return gpa; } set { gpa = value; } }
        public string StudentCode { get { return studentCode; } set { studentCode = value; } }
        public Student()
        {
            studentCode = string.Empty;
            fullName = string.Empty;
            gpa = 0.0f;
        }
        public Student(string studentCode, string fullName, float gpa)
        {
            this.studentCode = studentCode;
            this.fullName = fullName;
            this.gpa = gpa;
        }
        public override string ToString()
        {
            return $"Student Code: {studentCode}\n" +
                   $"Full Name: {FullName}\n" +
                   $"GPA: {Gpa}";
        }
    }
}
