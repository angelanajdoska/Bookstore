using Bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Data
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Movie> Movie{ get; set; }
        public DbSet<Author> Author { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Book")
              .HasOne(b => b.Author)
            .WithMany(i => i.Book)
            .HasForeignKey(b => b.Authorid).OnDelete(DeleteBehavior.NoAction);
            
             modelBuilder.Entity<Author>().ToTable("Author");
             

            modelBuilder.Entity<Movie>().ToTable("Movie")
              .HasOne(b => b.Book)
            .WithMany(i => i.Movie)
            .HasForeignKey(b => b.BookId).OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);
        }
    }
}