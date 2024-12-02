using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
{
    public struct Student
    {
        public string studentID;
        public string fullName;
        public int dateOfBirth;
        public double mathGrade;
        public double chemicalGrade;
        public double physicsGrade;

        public Student(string id, string fullName, int dateOfBirth, double math, double physics, double chemical)
        {
            this.studentID = id;
            this.fullName = fullName;
            this.dateOfBirth = dateOfBirth;
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
            return $"ID: {studentID} | Name: {fullName} | Date Of Birth: {dateOfBirth} | Average Grade: {GetAverageGrade()}";
        }

    }
}
