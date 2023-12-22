using Lesson5Homework1;

internal class Program
{
    private static void Main(string[] args)
    {

        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.Update();

        ProductManager productManager = new ProductManager();
        productManager.Add();
        productManager.Update();

        Customer customer1 = new Customer();
        customer1.Id = 1;
        customer1.FirstName = "Merve";
        customer1.LastName = "Çakıroğlu";
        customer1.City = "Trabzon";

        Customer customer2 = new Customer { Id = 2 , FirstName = "Emirhan", LastName = "Akkoyunlu", City = "Bayburt" };

        Console.WriteLine(customer2.FirstName);

    }
}
