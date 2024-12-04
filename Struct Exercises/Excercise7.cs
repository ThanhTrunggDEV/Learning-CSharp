using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Struct_Exercises
{
    //TestBill test = new TestBill();
    //test.Init();
    //test.AddBill();   ////CODE FOR TEST
    //test.CheckAllBill();
    public struct EBill
    {
        public string FullName;
        public int OldIndex;
        public int NewIndex;
        public int UnitPrice;
        public EBill(string fullname, int oldindex, int newindex, int unitprice)
        {
            FullName = fullname;
            OldIndex = oldindex;
            NewIndex = newindex;
            UnitPrice = unitprice;
        }
        public int GetAmountToBePaid()
        {
            return (NewIndex - OldIndex) * UnitPrice;
        }
        public string GetInfo()
        {
            return $"Customer Name: {FullName} | Consumption: {NewIndex - OldIndex} | Amount To Be Paid: {GetAmountToBePaid()}";
        }

    }
    public struct TestBill
    {
        private List<EBill> ListBills;
        public void Init()
        {
            ListBills = new List<EBill>();
        }
        public void AddBill()
        {
            Console.Write("Enter number of bill: ");
            int n = int.Parse(Console.ReadLine());
            for(int i =  0; i < n; i++)
            {
                Console.Write($"Enter Customer Name Of Bill {i + 1}: ");
                string name = Console.ReadLine();
                Console.Write($"Enter Customer Old Index Of Bill {i + 1}: ");
                int oldIndex = int.Parse(Console.ReadLine());
                Console.Write($"Enter Customer New Index Of Bill {i + 1}: ");
                int newIndex = int.Parse(Console.ReadLine());
                Console.Write($"Enter Customer Unit Price Of Bill {i + 1}: ");
                int unitPrice = int.Parse(Console.ReadLine());
                ListBills.Add(new EBill(name, oldIndex, newIndex, unitPrice));
            }
        }
        public void CheckAllBill()
        {
            foreach(var item in ListBills)
            {
                Console.WriteLine(item.GetInfo());
            }
        }
    }
}
