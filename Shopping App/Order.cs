using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
{
    public class Order
    {
        private string orderId;
        private List<Product> orderItems;
        private double totalPrice;
        public Order()
        {
            orderId = string.Empty;
            orderItems = new List<Product>();
            totalPrice = 0;
        }
        public Order(ShoppingCart shoppingCart)
        {

            orderId = string.Empty;
            orderItems = shoppingCart.Products.Keys.ToList();
            totalPrice = shoppingCart.TotalPrice();
        }
        public void FinalizeOrder(ShoppingCart shoppingCart)
        {
            Random random = new Random();
            orderId = random.Next(0, int.MaxValue).ToString();
            Console.WriteLine($"Order ID: {orderId} processed sucessfully");
            Console.WriteLine($"You have paid {shoppingCart.TotalPrice()} VND");
            shoppingCart.Products.Clear();
        }
    }
}
