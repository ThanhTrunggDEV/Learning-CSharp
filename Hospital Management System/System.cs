using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Hospital_Management_System
{
    public abstract class Person
    {
        public string Name { get; set; }
        public ushort Age { get; set; }
        public string Address { get; set; }
        public Person()
        {
            Name = string.Empty;
            Age = 0;
            Address = string.Empty;
        }
        public Person(string name, ushort age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
        public abstract void DisplayInfo();
    }
    public class Doctor : Person
    {
        public string Speciality { get; set; }
        public int YearsOfExperience {  get; set; }
        public Doctor(string speciality, int yearsOfExperience, string Name, ushort Age, string Address) : base(Name, Age, Address) 
        {
            Speciality = speciality;
            YearsOfExperience = yearsOfExperience;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} | Age: {Age} | Address: {Address} | Speciality {Speciality} | YearsOfExperience: {YearsOfExperience}");
        }
        public void TreatPatient(string patientName)
        {
            Console.WriteLine($"Doctor {Name} is treating {patientName}");
        }
    }
    public class Patient : Person
    {
        public string PatientID {  get; set; }
        public string MedicalHistory { get; set; }
        public Patient(string patientID, string medicalHistory, string Name, ushort Age, string Address) : base(Name, Age, Address)
        {
            PatientID = patientID;
            MedicalHistory = medicalHistory;
        }
        public void UpdateMedicalHistory(string newEntry)
        {
            MedicalHistory = newEntry;
            Console.WriteLine("Medical History Updated Successfully");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Patient ID: {PatientID} | Name: {Name} | Age: {Age} | Address: {Address} | Medical History: {MedicalHistory}");
        }
    }
    public class Nurse : Person
    {
        public int ShiftDuration {  get; set; }

        public Nurse(int shiftDuration, string Name, ushort Age, string Address) : base (Name, Age, Address)
        {
            ShiftDuration = shiftDuration;
        }
        

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} | Age: {Age} | Address: {Address} | ShiftDuration: {ShiftDuration}");
        }
    }
    public class Hospital
    {

    }
}
