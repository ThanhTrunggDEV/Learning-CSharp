using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
{
    public class ManageProduct // for seller
    {
        private List<Product> products;
        public ManageProduct()
        {
            products = new List<Product>();
        }
        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
        private void Option(ref Type type)
        {

            Console.WriteLine("Choose manageProduct type:\n1.Electronics\n2.Food\n3.Clothing\n4.Other ");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
                type = Type.Electronics;
            if (option == 2)
                type = Type.Food;
            if (option == 3)
                type = Type.Clothing;
            if (option == 4)
                type = Type.Other;
        }
        public void AddProduct()
        {
            int id = -1;
            string name = string.Empty;
            double price = -1;
            int stockQuantity = -1;
            Type type = 0;
            Option(ref type);
            if (type == Type.Electronics)
            {
                int warrantyPeriod = -1;
                while (id <= 0)
                {
                    Console.WriteLine("Enter Id: ");
                    id = int.Parse(Console.ReadLine());
                }
                while (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Enter Name: ");
                    name = Console.ReadLine();
                }
                while (price < 0)
                {
                    Console.WriteLine("Enter Price: ");
                    price = double.Parse(Console.ReadLine());
                }
                while (stockQuantity <= 0)
                {
                    Console.WriteLine("Enter Stock Quantity: ");
                    stockQuantity = int.Parse(Console.ReadLine());
                }
                while (warrantyPeriod < 0)
                {
                    Console.WriteLine("Enter Warranty Period: ");
                    warrantyPeriod = int.Parse(Console.ReadLine());
                }
                products.Add(new Electronics(warrantyPeriod, id, name, price, stockQuantity));
                Console.WriteLine("Add Successfully");
            }
            if(type == Type.Food)
            {
                DateTime expireDate = new DateTime();
                while (id <= 0)
                {
                    Console.WriteLine("Enter Id: ");
                    id = int.Parse(Console.ReadLine());
                }
                while (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Enter Name: ");
                    name = Console.ReadLine();
                }
                while (price < 0)
                {
                    Console.WriteLine("Enter Price: ");
                    price = double.Parse(Console.ReadLine());
                }
                while (stockQuantity <= 0)
                {
                    Console.WriteLine("Enter Stock Quantity: ");
                    stockQuantity = int.Parse(Console.ReadLine());
                }
                while (expireDate == DateTime.MinValue)
                {
                    Console.WriteLine("Enter Expire Date (YYYY/MM/dd: ");
                    try
                    {
                        expireDate = DateTime.Parse(Console.ReadLine());
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                products.Add(new Food(expireDate, id, name, price, stockQuantity));
                Console.WriteLine("Add Successfully");
            }
            if(type == Type.Clothing)
            {
                bool check = true;
                Size size = Size.S;
                while (id <= 0)
                {
                    Console.WriteLine("Enter Id: ");
                    id = int.Parse(Console.ReadLine());
                }
                while (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Enter Name: ");
                    name = Console.ReadLine();
                }
                while (price < 0)
                {
                    Console.WriteLine("Enter Price: ");
                    price = double.Parse(Console.ReadLine());
                }
                while (stockQuantity <= 0)
                {
                    Console.WriteLine("Enter Stock Quantity: ");
                    stockQuantity = int.Parse(Console.ReadLine());
                }
                while (check)
                {
                    Console.WriteLine("Enter Size:");
                    Console.WriteLine("1. S");
                    Console.WriteLine("2. M");
                    Console.WriteLine("3. L");
                    Console.WriteLine("4. XL");
                    Console.WriteLine("5. XXL");
                    try
                    {
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                check = false;
                                break;
                            case 2:
                                size = Size.M;
                                check = false;
                                break;
                            case 3:
                                size = Size.L;
                                check = false;
                                break;
                            case 4:
                                size = Size.XL;
                                check = false;
                                break;
                            case 5:
                                size = Size.XXL;
                                check = false;
                                break;
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                products.Add(new Clothing(size, id, name, price, stockQuantity));
                Console.WriteLine("Add Successfully");
            }
            if(type == Type.Other)
            {
                while (id <= 0)
                {
                    Console.WriteLine("Enter Id: ");
                    id = int.Parse(Console.ReadLine());
                }
                while (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Enter Name: ");
                    name = Console.ReadLine();
                }
                while (price < 0)
                {
                    Console.WriteLine("Enter Price: ");
                    price = double.Parse(Console.ReadLine());
                }
                while (stockQuantity <= 0)
                {
                    Console.WriteLine("Enter Stock Quantity: ");
                    stockQuantity = int.Parse(Console.ReadLine());
                }
                products.Add(new Product(id, name, price, stockQuantity));
                Console.WriteLine("Add Successfully");
            }
        }
        public void RemoveProduct()
        {
            Console.WriteLine("Enter manageProduct name to remove: ");
            string name = Console.ReadLine();
            foreach (Product product in products)
            {
                if (product.Name == name)
                {
                    products.Remove(product);
                    Console.WriteLine("Successfully");
                    return;
                }
            }
            Console.WriteLine("Not Found");
        }
        public void DisplayProductInformation()
        {
            if (products.Count > 0)
            {
                foreach (Product product in products)
                {
                    Console.WriteLine(product);
                }
            }
            else Console.WriteLine("There is no manageProduct in the stock");
        }
    }
}
