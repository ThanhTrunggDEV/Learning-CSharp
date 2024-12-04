using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Struct_Exercises
{
    //SubcriberManagement management = new SubcriberManagement();
    //management.Init();
    //        management.AddSubcriber();      ////Code FOr test
    //        Console.WriteLine();
    //        management.PrintSubcriber();
    public struct Subcriber
    {
        string phoneNumber;
        string fullName;
        double amountToBePaid;
        public Subcriber(string pn, string fn, double money)
        {
            phoneNumber = pn;
            fullName = fn;
            amountToBePaid = money;
        }
        public string GetInfo()
        {
            return $"Full Name: {fullName} | Phone Number: {phoneNumber} | Amount To Be Paid {amountToBePaid}";
        }
    }
    public struct SubcriberManagement
    {
        public List<Subcriber> Subcribers;
        public void Init()
        {
            Subcribers = new List<Subcriber>();
        }
        public SubcriberManagement(List<Subcriber> subcribers)
        {
            this.Subcribers = subcribers;
        }
        public void AddSubcriber()
        {
            Console.Write("Enter number of subcribers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter Name of subcriber {i + 1}: ");
                string name = Console.ReadLine();
                Console.WriteLine($"Enter phone number of subcriber {i + 1}: ");
                string phone = Console.ReadLine();
                Console.WriteLine($"Enter amount to be paid of subcriber {i + 1}: ");
                double amount = double.Parse(Console.ReadLine());
                Subcribers.Add(new Subcriber(phone, name, amount));
            }
        }
        public void PrintSubcriber()
        {
            
            foreach(var item in Subcribers)
            {
                Console.WriteLine(item.GetInfo());
            }
        }
    }
}
