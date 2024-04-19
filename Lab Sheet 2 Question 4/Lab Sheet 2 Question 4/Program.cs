namespace Lab_Sheet_2_Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Laptop", 3199.99f);
            Product product2 = new Product("Smartphone", 1299.99f);
            Product product3 = new Product("Headphones", 399.99f);

            Console.WriteLine("Product Details:");
            Console.WriteLine("----------------");
            DisplayProductDetails(product1);
            DisplayProductDetails(product2);
            DisplayProductDetails(product3);
        }

        static void DisplayProductDetails(Product product)
        {
            Console.WriteLine($"Product Name: {product.ProductName}");
            Console.WriteLine($"Price: ${product.Price}");
            Console.WriteLine();
        }
    }

    class Product
    {
        public string ProductName { get; set; }
        public float Price { get; set; }

        public Product(string name, float price)
        {
            ProductName = name;
            Price = price;
        }
    }
}
