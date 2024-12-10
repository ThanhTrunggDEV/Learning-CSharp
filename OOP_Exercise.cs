//using Learning_CSharp.Zoo_Management;
//using NAudio.CoreAudioApi.Interfaces;
//using OfficeOpenXml.Packaging.Ionic.Zlib;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Diagnostics.Contracts;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Learning_CSharp
//{
//    public abstract class Product
//    {
//        public string ProductID { get; protected set; }
//        private static int ID = 1;
//        public string ProductName { get; set; }
//        public decimal Price { get; set; }
//        public Product()
//        {
//            ProductID = string.Empty;
//            ProductName = string.Empty;
//            Price = 0;
//        }
//        public Product(string ProductName, decimal Price)
//        {
//            ProductID = $"PD{ID++}";
//            this.ProductName = ProductName;
//            this.Price = Price;
//        }
        
//        public abstract void DisplayInfo();

//    }
//    public class Customer
//    {
//        public string CustomerID { get; private set; }
//        private static int ID = 1;
//        public string CustomerName { get; set; }
//        public int Age {  get; set; }
//        public Customer()
//        {
//            CustomerID = string.Empty;
//            CustomerName = string.Empty;
//            Age = 0;
//        }
//        public Customer(string customerName, int age)
//        {
//            CustomerID = $"CS{ID++}";
//            CustomerName = customerName;
//            Age = age;
//        }
      
//    }
//    public class Order
//    {
//        public string OrderID { get; private set; }
//        public Customer Customer { get; set; }
//        public List<Product> Products { get; set; }
//        public decimal CalculateTotal()
//        {
//            decimal total = 0;
//            foreach (Product p in Products)
//            {
//                total += p.Price;
//            }
//            return total;
//        }
//    }
//    public class Electronic : Product
//    {
//        public int WarrantyInMonths {  get; set; }
//        public Electronic(int warrantyInMonths, string Name, decimal price) : base(Name, price)
//        {
//            WarrantyInMonths = warrantyInMonths;
//        }

//        public override void DisplayInfo()
//        {
//            Console.WriteLine($"Product ID: {ProductID} | Product Name: {ProductName} | Warranty: {WarrantyInMonths} Month(s)");
//        }

//    }
//    public class Clothing : Product
//    {
//        public string Size {  get; set; }
//        public string Material { get; set; }
//        public Clothing(string Size, string Material, string name, decimal price) : base(name, price)
//        {
//            this.Size = Size;
//            this.Material = Material;
//        }
//        public override void DisplayInfo()
//        {
//            Console.WriteLine($"Product ID: {ProductID} | Product Name: {ProductName} | Material: {Material} | Size: {Size}");
//        }
//    }
//    public class Grocery : Product
//    {
//        public DateTime ExpirationDate { get; set; }
//        public Grocery(DateTime expirationDate, string Name, decimal price) : base (Name, price)
//        {
//            ExpirationDate = expirationDate;
//        }

//        public override void DisplayInfo()
//        {
//            Console.WriteLine($"Product ID: {ProductID} | Product Name: {ProductName} | Expiration Date: {ExpirationDate}");
//        }
//    }
//}
