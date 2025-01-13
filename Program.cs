using Assignment11._1._1;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Net;
using System.Reflection;

namespace Framework
{
    class Program
    {
        static IEnumerable<Author> CreateFakeData()
        {
            var authors = new List<Author>
            {
                new Author
                {
                    Name = "Jane Austen", Books = new List<Book>
                    {
                        new Book {Title = "Emma", YearOfPublication = 1815},
                        new Book {Title = "Persuasion", YearOfPublication = 1818 },
                        new Book {Title = "Mansfield Park", YearOfPublication = 1814}
                    }
                },
                new Author
                {
                    Name = "Ian Fleming", Books = new List<Book>
                    {
                        new Book {Title = "Dr No", YearOfPublication = 1958 },
                        new Book {Title = "Goldfinger", YearOfPublication = 1959},
                        new Book {Title = "From Russia with Love", YearOfPublication = 1957}
                    }
                }
            };
            return authors;
        }
        static void Main()
        {
            var options = new DbContextOptionsBuilder<BooksContext>()
                .UseSqlite("FileName = ../../../MyLocalLibrary.db")
                .Options;


            using var db = new BooksContext(options);

            db.Database.EnsureCreated();


            //var authors = CreateFakeData();
            //foreach(var author in authors)
            //{
            //    Console.WriteLine($"{author} wrote ...");

            //    foreach (var book in author.Books)
            //        Console.WriteLine($"{book}");

            //    Console.WriteLine();
            //}
        }
    }
}
