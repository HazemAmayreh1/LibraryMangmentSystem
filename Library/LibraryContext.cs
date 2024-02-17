using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Library
{
    public class LibraryContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<Account> Accounts { get; set; }
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)


      => optionsBuilder.UseSqlServer("Server=DESKTOP-T3FV63J\\SQLEXPRESS;Database=news;Trusted_Connection=True; TrustServerCertificate=True");


    }

}
