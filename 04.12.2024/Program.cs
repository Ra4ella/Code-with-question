using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _04._12._2024
{
    internal class User
    {
        public int id { get; }
        public string name { get; set; }
        public List<Book> books = new List<Book>();

        public int takeBook(Book book)
        {
            if (book.id >= 0 && book.id < 21 && book.status == "Available")
            {
                books.Add(new Book(book.id - 1,
                    book.name,
                    book.author,
                    book.year,
                    "Taken",
                    "1"));
            }
            Console.WriteLine("You have taken book");
            return (0);
        }

        public int returnBook(Book book)
        {
            if (book.id >= 0 && book.id < 21)
            {
                books.Remove(book);
            }
            Console.WriteLine("You have returned book");
            return (0);
        }

        public int showUserBook()
        {
            for (int i = 0; i < books.LongCount(); i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Id: {books[i].id}");
                Console.WriteLine($"Name: {books[i].name}");
                Console.WriteLine($"Author: {books[i].author}");
                Console.WriteLine($"Year: {books[i].year}");
                Console.WriteLine($"Status: {books[i].status}");
                Console.WriteLine($"User: {books[i].user}");
                Console.WriteLine();
            }
            return (0);
        }
    }
    internal class Library
    {
        public List<Book> books = new List<Book>();
        public int bookCount;

        public Library()
        {
            books = new List<Book>() {
            new Book(0, "Clean Code: A Handbook of Agile Software Craftsmanship", "Robert C. Martin", 2008, "Available", "None"),
            new Book(1, "The Pragmatic Programmer: Your Journey to Mastery", "Andrew Hunt, David Thomas", 1999, "Available", "None"),
            new Book(2, "Design Patterns: Elements of Reusable Object-Oriented Software", "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides", 1994, "Available", "None"),
            new Book(3, "Structure and Interpretation of Computer Programs", "Harold Abelson, Gerald Jay Sussman, Julie Sussman", 1985, "Available", "None"),
            new Book(4, "Introduction to Algorithms", "Thomas H. Cormen, Charles E. Leiserson, Ronald L. Rivest, Clifford Stein", 2009, "Available", "None"),
            new Book(5, "The Clean Coder: A Code of Conduct for Professional Programmers", "Robert C. Martin", 2011, "Available", "None"),
            new Book(6, "Refactoring: Improving the Design of Existing Code", "Martin Fowler", 1999, "Available", "None"),
            new Book(7, "The Art of Computer Programming", "Donald E. Knuth", 1968, "Available", "None"),
            new Book(8, "Code Complete: A Practical Handbook of Software Construction", "Steve McConnell", 1993, "Available", "None"),
            new Book(9, "You Don't Know JS: Scope & Closures", "Kyle Simpson", 2014, "Available", "None"),
            new Book(10, "Effective Java", "Joshua Bloch", 2008, "Available", "None"),
            new Book(11, "Python Crash Course: A Hands-On, Project-Based Introduction to Programming", "Eric Matthes", 2015, "Available", "None"),
            new Book(12, "JavaScript: The Good Parts", "Douglas Crockford", 2008, "Available", "None"),
            new Book(13, "The Mythical Man-Month: Essays on Software Engineering", "Frederick P. Brooks Jr.", 1975, "Available", "None"),
            new Book(14, "Algorithms", "Robert Sedgewick, Kevin Wayne", 2011, "Available", "None"),
            new Book(15, "Clean Architecture: A Craftsman's Guide to Software Structure and Design", "Robert C. Martin", 2017, "Available", "None"),
            new Book(16, "Learn Python the Hard Way", "Zed A. Shaw", 2013, "Available", "None"),
            new Book(17, "Head First Design Patterns", "Eric Freeman, Elisabeth Robson", 2004, "Available", "None"),
            new Book(18, "The Complete Software Developer's Career Guide", "John Sonmez", 2017, "Available", "None"),
            new Book(19, "Building Microservices", "Sam Newman", 2015, "Available", "None")
            };
            bookCount = books.Count;
        }

        public int showAllbooks()
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Id: {books[i].id}");
                Console.WriteLine($"Name: {books[i].name}");
                Console.WriteLine($"Author: {books[i].author}");
                Console.WriteLine($"Year: {books[i].year}");
                Console.WriteLine($"Status: {books[i].status}");
                Console.WriteLine($"User: {books[i].user}");
                Console.WriteLine();
            }
            return (0);
        }

        public int showOneBook()
        {
            Console.WriteLine();
            Console.Write("Enter id's books: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Id: {books[id].id}");
            Console.WriteLine($"Name: {books[id].name}");
            Console.WriteLine($"Author: {books[id].author}");
            Console.WriteLine($"Year: {books[id].year}");
            Console.WriteLine($"Status: {books[id].status}");
            Console.WriteLine($"User: {books[id].user}");
            Console.WriteLine();
            return (0);
        }

        public void takeBook1(Book book)
        {
            if (book.id >= 0 && book.id < books.Count)
            {
                books.Remove(book);
            }
        }

        public int returnBook1(Book book)
        {
            if (book.id >= 0 && book.id < books.Count)
            {
                books.Add(new Book(book.id,
                    book.name,
                    book.author,
                    book.year,
                    "Available",
                    "None"));
                books.Remove(book);
            }
            return (0);
        }
    }
    internal class Book
    {
        public int id { get; }
        public string name { get; set; }
        public string author { get; set; }
        public int year { get; set; }
        public string status { get; set; }
        public string user { get; set; }
        public Book(int id, string name, string author, int year, string status, string user)
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.year = year;
            this.status = status;
            this.user = user;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            User user = new User();

            while (true)
            {
                Console.WriteLine("1. Take book");
                Console.WriteLine("2. Return book");
                Console.WriteLine("3. Show my books");
                Console.WriteLine("4. Show full books");
                Console.WriteLine("5. Show book");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");
                int choice1 = Convert.ToInt32(Console.ReadLine());
                if (choice1 > 0 && choice1 < 6)
                {
                    if (choice1 == 1)
                    {
                        Console.WriteLine();
                        Console.Write("Enter id's books: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        library.takeBook1(library.books[id]);
                        user.takeBook(library.books[id]);
                    }
                    if (choice1 == 2)
                    {
                        Console.WriteLine();
                        Console.Write("Enter id's books: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        library.returnBook1(library.books[id]);
                        user.returnBook(library.books[id]);
                    }
                    if (choice1 == 3)
                    {
                        user.showUserBook();
                    }
                    if (choice1 == 4)
                    {
                        library.showAllbooks();
                    }
                    if (choice1 == 5)
                    {
                        library.showOneBook();
                    }
                    if (choice1 == 6)
                    {
                        break;
                    }
                }
                else
                {
                    Console.Write("Error Type. Enter choice again: ");
                    choice1 = Convert.ToInt32(Console.ReadLine());
                }

                Console.ReadLine();
            }
        }
    }
}