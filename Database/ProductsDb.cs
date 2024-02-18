using Database.DatabaseContext;
using Database.Interfaces;
using Database.Tables;

namespace Database
{
    public class Products: IProducts
    {
        public IEnumerable<Product> GetProducts() {
            using var dbContext = new ShopContext();
            return dbContext.Products.ToList();
        }

        public Product? GetProduct(int id) {
            using var dbContext = new ShopContext();
            return dbContext.Products.Find(id);
        }

        public void AddProduct(Product product) {
            using var dbContext = new ShopContext();
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }

        public void UpdateProduct(Product product) {
            using var dbContext = new ShopContext();
            var       productDb = dbContext.Products.Find(product.Id);
            
            if(productDb == null) return;
            
            productDb.Name          = product.Name;
            productDb.Description   = product.Description;
            productDb.Price         = product.Price;
            productDb.StockQuantity = product.StockQuantity;
            dbContext.SaveChanges();

        }

        public void DeleteProduct(int id) {
            using var dbContext = new ShopContext();
            var       product   = dbContext.Products.Find(id);
            
            if(product == null) return;
            
            dbContext.Products.Remove(product);
            dbContext.SaveChanges();

        }
    }
}
