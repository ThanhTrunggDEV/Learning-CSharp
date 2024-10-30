using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp
{
    public class Electronics : Product
    {
        private int warrantyPeriod;
        public int WarrantyPeriod
        {
            get { return warrantyPeriod; }
            set { warrantyPeriod = value; }
        }
        public Electronics() : base() 
        {
                warrantyPeriod = 0;
        }
        public Electronics(int warantyPeriod, int id, string name, double price, int stockQuantity) : base(id, name, price, stockQuantity) 
        {
            this.warrantyPeriod = warantyPeriod;

        }
        public override double CalculateTotalPrice(int quantity)
        {
            if(quantity >= 3)
            {
                return (Price * quantity) - ((Price * quantity) * (10.0 / 100));
            }
            return base.CalculateTotalPrice(quantity);
        }
        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nPrice: {Price} VND\nStock Quantity: {StockQuantity}\nWarranty Period: {warrantyPeriod} months";
        }
    }
    public class Food : Product
    {
        private DateTime expireDate;
        
        public DateTime ExpireDate
        {
            get { return expireDate; }
            set { expireDate = value; }
        }
        public Food() : base()
        {
            ExpireDate = DateTime.Now;
        }
        public Food(DateTime expireDate, int id, string name, double price, int stockQuantity) : base(id, name, price, stockQuantity)
        {
            this.expireDate = expireDate;
        }

        public override double CalculateTotalPrice(int quantity)
        {
            if (DateTime.Now.Month - ExpireDate.Month < 2 && DateTime.Now.Year - ExpireDate.Year == 0)
                return (Price * quantity) - (Price * quantity * 0.5);
            return base.CalculateTotalPrice(quantity);
        }
        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nPrice: {Price} VND\nStock Quantity: {StockQuantity}\nExpire Date: {ExpireDate}";
        }
    }
    public class Clothing : Product
    {
        private Size size;

        public Size Size
        {
            get { return size; }
            set { size = value; }
        }
        public Clothing() : base()
        {
            size = 0;
        }
        public Clothing(Size size, int id, string name, double price, int stockQuatity): base(id, name, price, stockQuatity)
        {
            this.size = size;
        }
        public override double CalculateTotalPrice(int quantity)
        {

            if (size <= Size.L)
                return Price * quantity - (Price * quantity * 0.1); 
            return base.CalculateTotalPrice(quantity);
        }
        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nPrice: {Price} VND\nStock Quantity: {StockQuantity}\nSize: {size}";
        }
    }
}