using Database.Tables;

namespace Database.Interfaces;

public interface IProducts
{
    IEnumerable<Product> GetProducts();
    Product?             GetProduct(int id);
    void                 AddProduct(Product product);
    void                 UpdateProduct(Product product);
    void                 DeleteProduct(int id);
}