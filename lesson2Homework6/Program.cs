internal class Program
{
    private static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.Id = 1;
        product1.ProductName = "Computer";
        product1.CategoryName = "Electronic";
        product1.UnitPrice = 2000;

        Product product2 = new Product();
        product2.Id = 2;
        product2.ProductName = "Phone";
        product2.CategoryName = "Electronic";
        product2.UnitPrice = 500;

        Product product3 = new Product();
        product3.Id = 3;
        product3.ProductName = "Tablet";
        product3.CategoryName = "Electronic";
        product3.UnitPrice = 1000;

        Product[] products = new Product[] { product1, product2, product3};

        foreach(Product product in products )
        {
            Console.WriteLine(product.ProductName);
        }

        Console.WriteLine(" Foreach Bitti  ");

        for (int i = 0; i <products.Length; i++)
        {
            Console.WriteLine(products[i].ProductName);
        }

        Console.WriteLine(" For Bitti  ");

        int j = 0;
        while (j < products.Length)
        {
            Console.WriteLine(products[j].ProductName);
            j++;
        }

        Console.WriteLine(" While Bitti  ");
    }

    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public int UnitPrice { get; set; }
    }
}