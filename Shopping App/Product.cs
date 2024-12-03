//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Learning_CSharp
//{
//    public class Product
//    {
//        private int id;
//        private string name;
//        private double price;
//        private int stockQuantity;

//        public int Id
//        {
//            get { return id; }
//            set { id = value; }
//        }
//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }
//        public double Price
//        {
//            get { return price; }
//            set { price = value; }
//        }
//        public int StockQuantity
//        {
//            get { return stockQuantity; }
//            set { stockQuantity = value; }
//        }
//        public Product()
//        {
//            id = 0;
//            name = string.Empty;
//            price = 0;
//            stockQuantity = 0;
//        }
//        public Product(int id, string name, double price, int stockQuantity)
//        {
//            this.id = id;
//            this.name = name;
//            this.price = price;
//            this.stockQuantity = stockQuantity;
//        }
//        public virtual double CalculateTotalPrice(int quantity)
//        {
//            return price * quantity;
//        }
//        public override string ToString()
//        {
//            return $"Id: {id}\nName: {name}\nPrice: {price}\nRemaining Quantity: {stockQuantity}";
//        }
//    }
//}
