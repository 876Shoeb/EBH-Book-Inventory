using BookInventory.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookInventory.Data
{
    public class BookInventoryDbContext : IdentityDbContext
    {
        public BookInventoryDbContext(DbContextOptions<BookInventoryDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book>Book { get; set; }
        public DbSet<BookCallNumber> BookCallNumber { get; set; }
        public DbSet<Condition> Condition { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Request> Request { get; set; }


    }
}