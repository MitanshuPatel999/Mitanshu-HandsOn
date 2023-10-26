using Microsoft.EntityFrameworkCore;
using CRUDWebApp.Models;

namespace CRUDWebApp.Data  
{
    public class MyDbContext : DbContext
    {
         public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     base.OnConfiguring(optionsBuilder);
        //     optionsBuilder.UseSqlServer("Server=PMCLAP1382;Database=CRUD;User Id=sa;Password=India@123;TrustServerCertificate=True;");
        // }
    }
}
