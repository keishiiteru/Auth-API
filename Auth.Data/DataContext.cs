using Auth.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Auth.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Token> Tokens => Set<Token>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Token>()
               .HasOne(t => t.User)
               .WithMany(u => u.Tokens)
               .HasForeignKey(t => t.UserId);
        }
    }
}
