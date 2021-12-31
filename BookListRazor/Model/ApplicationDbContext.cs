using Microsoft.EntityFrameworkCore;
using System;

namespace BookListRazor.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Book { get; set; }

        public static implicit operator int(ApplicationDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}
