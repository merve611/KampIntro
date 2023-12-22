using OOP1;

internal class Program
{
    private static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.Id = 1;
        product1.CategoryId = 2;            //örneğin 2 bizim için arka planda mobilya ya karşılık gelsin
        product1.ProductName = "Masa";
        product1.UnitPrice = 500;
        product1.UnitsInStock = 3;

        //Yukardakinin kısa hali;
        Product product2 = new Product {Id = 2, CategoryId = 5, UnitPrice =5, UnitsInStock = 5, ProductName ="Kalem"  };

        //ProductManager türündeki productManager yeni bir referans numarası almış
        ProductManager productManager = new ProductManager();          //Instance - örnek oluştruma
        productManager.Add(product1);
        Console.WriteLine( product1.ProductName);







    }
}   