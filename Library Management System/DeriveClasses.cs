using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Library_Management_System
{
    public class Book : LibraryItem, IBorrowable
    {
        public Author Author { get; set; }
        public string Genre { get; set; }
        public DateTime DueDate { get; set; }

        public Book() : base()
        {
            Author = new Author();
            Genre = string.Empty;
        }
        public Book(Author author, string genre, string title, string publisher, string Isbn, int year)
            : base(title, publisher, Isbn, year, false)
        {
            Author = author;
            Genre = genre;
        }

        public void Borrow(int day)
        {
            BorrowdStatus = true;
            DueDate.AddDays(day);
        }

        public void Return()
        {
            BorrowdStatus = false;
        }
        public override string ToString()
        {
            return $"Book Information:\n" +
                   $"Written by {Author}\n" +
                   $"Genre: {Genre}\n" +
                   $"Title {Title}\n" +
                   $"Publisher {Publisher}\n" +
                   $"ISBN {ISBN}\n" +
                   $"Year {Year}\n" +
                   $"Is Borrowed {BorrowdStatus}";
        }
    }
    public class Magazine : LibraryItem, IBorrowable
    {
        public DateTime DueDate { get; set; }
        public string IssueNumber { get; set; }
        public string MonthlyIssue { get; set; }

        public Magazine() : base()
        {
            IssueNumber = string.Empty;
            MonthlyIssue = string.Empty;
        }
        public Magazine(string issueNumber, string monthlyIssue, string title, string publisher, string Isbn, int year)
            : base(title, publisher, Isbn, year, false)
        {
            IssueNumber = issueNumber;
            MonthlyIssue = monthlyIssue;
        }


        public void Borrow(int day)
        {
            BorrowdStatus = true;
            DueDate.AddDays(day);
        }

        public void Return()
        {
            BorrowdStatus = false;
        }
        public override string ToString()
        {
            return $"Magazine Information:\n" +
                   $"Issue Number {IssueNumber}\n" +
                   $"Monthly Issue {MonthlyIssue}\n" +
                   $"Title {Title}\n" +
                   $"Publisher {Publisher}\n" +
                   $"ISBN {ISBN}\n" +
                   $"Year {Year}\n" +
                   $"Is Borrowed {BorrowdStatus}";
        }
    }
    public class Newspaper : LibraryItem
    {
        public DateTime Date { get; set; }
        public string DailyEdition { get; set; }

        public Newspaper() : base()
        {
            Date = DateTime.Now;
            DailyEdition = string.Empty;
        }
        public Newspaper(string dailyEdition, string title, string publisher, string Isbn, int year)
            : base(title, publisher, Isbn, year, false)
        {
            Date = DateTime.Now;
            DailyEdition = dailyEdition;
        }
        public override string ToString()
        {
            return $"Newspaper Information:\n" +
                   $"Date {Date}\n" +
                   $"Daily Edition {DailyEdition}\n" +
                   $"Title {Title}\n" +
                   $"Publisher {Publisher}\n" +
                   $"ISBN {ISBN}\n" +
                   $"Year {Year}\n" +
                   $"Is Borrowed {BorrowdStatus}";
        }
    }
}

