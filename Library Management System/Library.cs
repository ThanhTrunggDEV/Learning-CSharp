using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Library_Management_System
{
    public class Library
    {
        private List<LibraryItem> items;
        public List<LibraryItem> Items { get { return items; } set { items = value; } }
        public Library()
        {
            items = new List<LibraryItem>();
        }
        public Library(List<LibraryItem> items)
        {
            this.items = items;
        }
        public void AddItem(LibraryItem item)
        {
            Items.Add(item);
        }
        public void ListItems()
        {
            foreach (LibraryItem item in Items)
            {
                Console.WriteLine(item);
            }
        }
        public void ListBorrowableItems()
        {
            foreach (var item in items)
            {
                if (!item.BorrowdStatus)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void ListBorrowedItems()
        {
            foreach(var item in items)
            {
                if (item.BorrowdStatus)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void Borrow(string nameOfItem, int borrowDay)
        {
            for(int i = 0; i < Items.Count; i++)
            {
                if (Items[i].Title == nameOfItem)
                {
                    if (Items[i] is IBorrowable item && Items[i].BorrowdStatus == false)
                    {
                        item.Borrow(borrowDay);
                        return;
                    }
                }
            }
            Console.WriteLine("This item isn't available or unborrowable");
        }
        public void Return(string name)
        {
            for(int i = 0;i < Items.Count; i++)
            {
                if(Items[i] is IBorrowable item && Items[i].Title == name)
                {
                    item.Return();
                    return;
                }
            }
            Console.WriteLine("Something Wrong!");
        }
    }
}
