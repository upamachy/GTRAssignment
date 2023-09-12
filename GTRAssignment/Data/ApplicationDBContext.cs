using GTRAssignment.Models;
using Microsoft.EntityFrameworkCore;

namespace GTRAssignment.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
            
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
