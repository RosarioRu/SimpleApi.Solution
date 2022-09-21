using Microsoft.EntityFrameworkCore;

namespace SimpleApi.Models
{
    public class SimpleApiContext : DbContext
    {
        public SimpleApiContext(DbContextOptions<SimpleApiContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}