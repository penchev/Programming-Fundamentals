using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Library books = new Library();
            int number = int.Parse(Console.ReadLine());
            books.Books = new List<Book>();
            for (int i = 0; i < number; i++)
            {
                Book book = new Book();
                string[] inputArgs = Console.ReadLine().Split(' ');
                book.Title = inputArgs[0];
                book.Author = inputArgs[1];
                book.Publisher = inputArgs[2];
                book.ReleaseDate = DateTime.Parse(inputArgs[3]);
                book.ISBN = inputArgs[4];
                book.Price = double.Parse(inputArgs[5]);
                books.Books.Add(book);
            }

            Console.WriteLine(books.Books.Where(x => x.Author == x.Author).Sum(x => x.Price));
        }
    }

    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }


    }
}
