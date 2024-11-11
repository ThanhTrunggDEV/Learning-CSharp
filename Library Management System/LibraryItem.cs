using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Library_Management_System
{
    public abstract class LibraryItem
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }  
        public int Year { get; set; }
        public bool BorrowdStatus { get; set; }
        public LibraryItem()
        {
            Title = string.Empty;
            Publisher = string.Empty;
            ISBN = string.Empty;
            Year = 0;
            BorrowdStatus = false;
        }
        public LibraryItem(string title, string pulisher, string iSBN, int year, bool borrowdStatus)
        {
            Title = title;
            Publisher = pulisher;
            ISBN = iSBN;
            Year = year;
            BorrowdStatus = borrowdStatus;
        }

    }
}
