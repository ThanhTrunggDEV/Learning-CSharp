using NAudio.CoreAudioApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
{
    public class Student : IComparer<Student>
    {
        private string fullName;
        private int age;
        public string FullName { get { return fullName; } set { fullName = value; } }
        public int Age { get { return age; } set { age = value; } }
        public Student()
        {
            FullName = string.Empty;
            Age = 0;
        }
        public Student(string FullName, int Age)
        {
            this.Age = Age;
            this.FullName = FullName;
        }

        public int Compare(Student x, Student y)
        {
            if (x.FullName.CompareTo(y.FullName) == 1)
                return 1;
            return -1;

        }
        public override string ToString()
        {
            return $"Full Name: {FullName} Age: {Age}";
        }
    }
    public class Pro
    {
        private int val;

        public int Val { get { return val; } set { val = value; } }

        public Pro() { }
        public Pro(int val)
        {
            this.Val = val;
        }

        public static Pro operator +(Pro a, Pro b)
        {
            return new Pro(a.val + b.val);
        }

        public override string ToString()
        {
            return val.ToString();
        }
        public static Pro operator ++(Pro a)
        {
            return new Pro(a.val+1);
        }
    }
}
