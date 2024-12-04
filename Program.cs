using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static System.Console;
using System.Threading;
using static System.Math;
using static System.Threading.Thread;
using static ThanhTrung.Advanced;
using System.Globalization;
//using Learning_CSharp.Struct_Exercises;
using System.Data.Common;
using Learning_CSharp.Library_System;
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
            Library library = new Library();
            Student student = new Student("Trung");
            Student student1 = new Student("Ryan");
            Book book = new PrintedBook("Ky luat ban than", "Robin", "gr34t5", "Corner");
            Book book1 = new EBook("https://efdsertre.com","Ba nguoi thay vi dai", "Robin", "gr34grtt5");
            Book book2 = new EBook("http://trrgr.com","Chu nghia khac ky", "Robin", "gr34tgre5" );
            Book book3 = new PrintedBook("Don't sleep long", "Robin", "g546tre", "Corner");
            library.AddMember(student);
            library.AddMember(student1);
            library.AddBooks(book);
            library.AddBooks(book1);
            library.AddBooks(book2);
            library.AddBooks(book3);

            library.PrintMembers();
            library.PrintBooks();
            Console.WriteLine();
            library.SearchBook("Ky luat ban than");
            Console.WriteLine();
            library.Borrow("MB1", "Ba nguoi thay vi dai");
            library.PrintBooks();
            Console.WriteLine();
            library.Return("MB1", "Ba nguoi thay vi dai");
            library.PrintBooks();
        }
    }
    
}