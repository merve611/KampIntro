using System.Runtime.Versioning;

internal class Program
{
    private static void Main(string[] args)
    {
        //Çalışırken boş constructor kullanıldı - parametresi olmayan
        Customer customer1 = new Customer(){ Id = 1, FirstName ="Merve", LastName = "Trabzon", City = "Trabzon"};

        //Çalışırken paremetre isteyen constructor kullanıldı
        Customer customer2 = new Customer(2, "Emirhan", "Akkoyunlu", "Bayburt");

        Console.WriteLine(customer2.FirstName);

    }
   
}

class Customer
{
    //new lediğimizde her zaman çalışan default constructor;
    public Customer()
    {
        
    }
    public Customer(int ıd, string firstname, string lastname, string city)
    {
        Id = ıd;
        FirstName = firstname;
        LastName = lastname;
        City = city;

    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}