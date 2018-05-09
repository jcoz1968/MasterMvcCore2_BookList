using BookList.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookList.Data
{
    public class ApplicationDbContext : DbContext
    {
        private DbContextOptions<ApplicationDbContext> _options;
        public DbSet<Book> Books { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)  : base(options)
        {
            _options = options;
        }

        
    }
}
