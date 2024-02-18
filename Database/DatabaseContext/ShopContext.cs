using System.Data.Entity;
using Database.Tables;

namespace Database.DatabaseContext;

public class ShopContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        System.Data.Entity.Database.SetInitializer(new ProductInitializer());
    }
    public class ProductInitializer : DropCreateDatabaseIfModelChanges<ShopContext>
{

    protected override void Seed(ShopContext context)
    {
        var students = new List<Product>
        {
            new() {Id = 1, Name = "Laptop", Description     = "High-performance laptop", Price     = 1000, StockQuantity = 10},
            new() {Id = 2, Name = "Smartphone", Description = "Latest model smartphone", Price     = 800, StockQuantity  = 15},
            new() {Id = 3, Name = "Headphones", Description = "Noise-cancelling headphones", Price = 200, StockQuantity  = 20},
            new() {Id = 4, Name = "Tablet", Description     = "High-performance tablet", Price     = 600, StockQuantity = 25},
        };

        students.ForEach(p => context.Products.Add(p));
        context.SaveChanges();

    }
}
}