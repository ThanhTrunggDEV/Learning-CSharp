using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Numerics;
using System.Threading;
using static System.Console;
using static System.Math;
using static System.Threading.Thread;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Linq;
using System.IO;
using System.Data.Common;
using System.ComponentModel.Design;
using System.Runtime.Remoting.Messaging;
using System.ComponentModel;
using ThanhTrung;
using static ThanhTrung.Advanced;
using System.Globalization;
using System.Text.RegularExpressions;
using System.CodeDom.Compiler;
using Decode;
using OfficeOpenXml;
using System.Reflection;
using Learning_CSharp.Zoo_Management;
using Xunit;
using Learning_CSharp.Library_Management_System;
namespace Learning_CSharp
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            #region Console Configuration
            Title = "Written And Designed By ThanhTrung";
            randomColor();
            OutputEncoding = Encoding.UTF8;
            #endregion
            // Creating Authors
            var author1 = new Author("J.K. Rowling", 'F');
            var author2 = new Author("George Orwell", 'M');

            // Creating Books
            var book1 = new Book { Title = "Harry Potter and the Philosopher's Stone", Author = author1, Genre = "Fantasy", Year = 1997 };
            var book2 = new Book { Title = "1984", Author = author2, Genre = "Dystopian", Year = 1949 };

            // Creating Magazines
            var magazine1 = new Magazine { Title = "National Geographic", Publisher = "National Geographic Partners", Year = 2023, IssueNumber = "15", MonthlyIssue = "10" };
            var magazine2 = new Magazine { Title = "Time", Publisher = "Time USA, LLC", Year = 2022, IssueNumber = "15", MonthlyIssue = "10" };

            // Creating Newspapers
            var newspaper = new Newspaper { Title = "The New York Times", Publisher = "The New York Times Company", Year = 2023, Date = new DateTime(2023, 10, 20), DailyEdition = "50" };

            // Creating Library and Adding Items
            var library = new Library();
            library.AddItem(book1);
            library.AddItem(book2);
            library.AddItem(magazine1);
            library.AddItem(magazine2);
            library.AddItem(newspaper);

            // Borrowing Items
            library.Borrow("Harry Potter and the Philosopher's Stone", 14);  // Borrow Harry Potter for 2 weeks
            library.Borrow("National Geographic", 7); // Borrow National Geographic for 1 week

            // Display All Items
            Console.WriteLine("All Library Items:");
            library.ListItems();

            // Display Borrowed Items
            Console.WriteLine("\nBorrowed Items:");
            library.ListBorrowedItems();

            Console.WriteLine("\nBorrowable Items:");
            library.ListBorrowableItems();

            // Returning Items
            library.Return("Harry Potter and the Philosopher's Stone");   // Return Harry Potter
            library.Return("The New York Times");  // Attempt to return non-borrowable item (New York Times)
        }
    }
}

