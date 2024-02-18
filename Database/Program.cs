// See https://aka.ms/new-console-template for more information

using Database;

Console.WriteLine("Hello, World!");
var prod = new Products();
var       products  = prod.GetProducts().ToList();
foreach(var product in products) {
    Console.WriteLine(product.Name);
}
var product1 = prod.GetProduct(1);

