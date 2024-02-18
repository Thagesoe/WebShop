using System.ComponentModel.DataAnnotations;

namespace Database.Tables;


public class Product {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int StockQuantity { get; set; }
}



