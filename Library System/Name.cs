using NAudio.MediaFoundation;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_CSharp.Library_System
{
    public abstract class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        protected static Dictionary<string, bool> used = new Dictionary<string, bool>();
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            if (!used.ContainsKey(isbn))
            {
                ISBN = isbn;
            }
            else
                Console.WriteLine($"ISBN {isbn} Existed");
            IsAvailable = true;
        }
        public abstract void Borrow();
        public abstract void Return();
        public override string ToString()
        {
            return $"Title: {Title} | Author: {Author} | Available Status: {IsAvailable}";
        }
    }
    public class PrintedBook : Book
    {
        public string ShelfLocation { get; set; }   
        public PrintedBook(string Title, string Author, string Isbn, string ShelfLocation) : base(Title, Author, Isbn)
        {
            this.ShelfLocation = ShelfLocation;
        }
        public override void Borrow()
        {
            IsAvailable = false;
        }

        public override void Return()
        {
            IsAvailable = true;
        }

    }
    public class EBook : Book
    {
        public string DownloadURL {  get; set; }
        public EBook(string DownloadURL, string Title, string Author, string Isbn) : base(Title, Author, Isbn)
        {
            this.DownloadURL = DownloadURL;
        }
        public override void Borrow()
        {
            IsAvailable = false;
        }

        public override void Return()
        {
            IsAvailable = true;
        }
    }
    public class Member
    {
        public string FullName {  get; set; }
        protected static int ID = 1;
        public string MemberID { get; protected set; }
        public List<Book> BorrowedBooks { get; protected set; }
        public Member(string FullName)
        {
            BorrowedBooks = new List<Book>();
            this.FullName = FullName;
            MemberID = $"MB{ID++}";
        }
        public virtual void BorrowBook(Book book)
        {
            BorrowedBooks.Add(book);
        }
        public virtual void ReturnBook(Book book)
        {
            BorrowedBooks.Remove(book);
        }
        public override string ToString()
        {
            return $"Name:{FullName} | Member ID {MemberID}";
        }
    }
    public class Student : Member
    {
        public Student(string name) : base(name) { }
        public new int BorrowedBooks { get; private set; } = 0;
        public override void BorrowBook(Book book)
        {
            if (BorrowedBooks < 3)
            {
                BorrowedBooks++;
                base.BorrowBook(book);
                book.Borrow();
            }
            else
                Console.WriteLine("Can't borrow more");
        }
        public override void ReturnBook(Book book)
        {
            base.ReturnBook(book);
            book.Return();
            BorrowedBooks--;
        }
    }
    public class Falculty : Member
    {
        public Falculty(string name) : base(name) { }
        public new int BorrowedBooks { get; private set; } = 0;
        public override void BorrowBook(Book book)
        {
            if (BorrowedBooks < 10)
            {
                BorrowedBooks++;
                base.BorrowBook(book);
                book.Borrow();
            }
            else
                Console.WriteLine("Can't borrow more");
        }
        public override void ReturnBook(Book book)
        {
            base.ReturnBook(book);
            book.Return();
            BorrowedBooks--;
        }
    }
    public class Library
    {
        public List<Book> ListBooks { get; private set; }
        public List<Member> ListMembers { get; private set; }
        public Library()
        {
            ListBooks = new List<Book>();
            ListMembers = new List<Member>();
        }
        public void AddBooks(Book book)
        {
            ListBooks.Add(book);
           
        }
        public void AddMember(Member member)
        {
            ListMembers.Add(member);
        }
        public void SearchBook(string title)
        {
            if(ListBooks.FirstOrDefault(item => item.Title == title) == null)
                Console.WriteLine($"Not Found Book Named {title}");
            else
                Console.WriteLine(ListBooks.FirstOrDefault(item => item.Title == title));
        }
        public void PrintMembers()
        {
            foreach (var item in ListMembers)
            {
                Console.WriteLine(item);
            }
        }
        public void PrintBooks()
        {
            foreach (var book in ListBooks)
            {
                Console.WriteLine(book);
            }
        }
        public void Borrow(string MemberID, string Title)
        {
            ListMembers.First(item => item.MemberID == MemberID).BorrowBook(ListBooks.First(item => item.Title == Title));
            
        }
        public void Return(string MemberID, string Title)
        {
            ListMembers.First(item => item.MemberID == MemberID).ReturnBook(ListBooks.First(item => item.Title == Title));
        }
    }
}
