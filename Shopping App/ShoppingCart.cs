using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
{

    public class ShoppingCart // for buyer
    {
        private Dictionary<Product, int> products;
        private double discountPercentage;
        public double DiscountPercentage
        {
            get { return discountPercentage; }
            set { discountPercentage = value; }
        }
        public ShoppingCart()
        {
            products = new Dictionary<Product, int>();
            discountPercentage = 0;
        }
        public ShoppingCart(Dictionary<Product, int> listProducts)
        {
            products = listProducts;
        }
        public Dictionary<Product, int> Products
        {
            get { return products; }
        }
        public void AddProduct(ManageProduct manage)
        {
            string name = string.Empty;
            int quantity = 0;
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Enter Name: ");
                name = Console.ReadLine();
            }
            while (quantity <= 0)
            {
                Console.WriteLine("Enter quantity: ");
                quantity = int.Parse(Console.ReadLine());
            }

            foreach (var product in manage.Products)
            {
                if (name == product.Name && product.StockQuantity >= quantity)
                {
                    if (products.ContainsKey(product))
                    {
                        products[product] += quantity;
                    }
                    else
                    { 
                        products.Add(product, quantity);
                    }
                    Console.WriteLine($"Successfully Add {quantity} {name} into cart");
                    return;
                }
            }
            Console.WriteLine("This manageProduct is sold out");
        }

        public void RemoveProduct()
        {
            Console.WriteLine("Enter manageProduct name to remove: ");
            string name = Console.ReadLine();
            foreach (var product in products)
            {
                if (product.Key.Name == name)
                {
                    products.Remove(product.Key);
                    Console.WriteLine("Successfully");
                    return;
                }
            }
            Console.WriteLine("Not Found");
        }
        public void ApplyDiscount()
        {
            Console.WriteLine("Enter your voucher(percent): ");
            discountPercentage = double.Parse(Console.ReadLine());
            if (discountPercentage <= 0 || discountPercentage > 100)
            {
                Console.WriteLine("Invalid");
                discountPercentage = 0;
                return;
            }
            discountPercentage /= 100;
        }
        public double TotalPrice() 
        {
            double price = 0;
            foreach (var product in products)
            {
                price += product.Key.CalculateTotalPrice(product.Value);
            }
            return price - (price * discountPercentage);
        }
        public void DisplayShoppingCart()
        {
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key}\nQuantity: {item.Value}");
            }
        }
    }


}
