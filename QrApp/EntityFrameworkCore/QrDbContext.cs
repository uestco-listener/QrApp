using Microsoft.EntityFrameworkCore;
using QrApp.Concrete;
using QrApp.Resources;

namespace QrApp.EntityFrameworkCore
{
    public class QrDbContext : DbContext
    {
        DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(PostgreSql.connString);
        }
    }
}
