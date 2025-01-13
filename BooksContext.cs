using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11._1._1
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options)
            :base(options)
        {
        
        }
        public DbSet<Author> Auhthors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
