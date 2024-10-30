using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
{
    public class ShoppingApp
    {
       private static ShoppingCart cart;
       private static Order order;
       private static ManageProduct manageProduct;

       public static void Init()
        {
            cart = new ShoppingCart();
            order = new Order();
            manageProduct = new ManageProduct();
        }
        public static void Start()
        {

            while (true)
            {
                Console.WriteLine("Enter Mode: ");
                try
                {
                    int command = int.Parse(Console.ReadLine());
                    switch (command)
                    {
                        case 1:
                            SellerMode();
                            Notification();
                            break;
                        case 2:
                            BuyerMode();
                            Notification();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private static void Notification()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Clear();
        }
        private static void BuyerMode()
        {
            while (true)
            {
                Console.WriteLine("1. Add Product Into Cart");
                Console.WriteLine("2. Remove From Cart");
                Console.WriteLine("3. Use Voucher");
                Console.WriteLine("4. Check Bill");
                Console.WriteLine("5. Order");
                Console.WriteLine("6. Display Shopping Cart");
                Console.WriteLine("0. Exit Mode");
                int command = int.Parse(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        cart.AddProduct(manageProduct);
                        Notification();
                        break;
                    case 2:
                        cart.RemoveProduct();
                        Notification();
                        break;
                    case 3:
                        cart.ApplyDiscount();
                        Notification();
                        break;
                    case 4:
                        Console.WriteLine($"Your Bill Is {cart.TotalPrice()} VND");
                        Notification();
                        break;
                    case 5:
                        order.FinalizeOrder(cart);
                        Notification();
                        break;
                    case 6:
                        cart.DisplayShoppingCart();
                        Notification();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
        }
        private static void SellerMode()
        {

            while (true)
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Remove Product");
                Console.WriteLine("3. Print Product List");
                Console.WriteLine("0. Exit Mode");
                int command = int.Parse(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        manageProduct.AddProduct();
                        Notification();
                        break;
                    case 2:
                        manageProduct.RemoveProduct();
                        Notification();
                        break;
                    case 3:
                        manageProduct.DisplayProductInformation();
                        Notification();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
        }
    }
}
