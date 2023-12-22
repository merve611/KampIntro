using Lesson5Homework4.Abstract;
using Lesson5Homework4.Adapters;
using Lesson5Homework4.Concrete;

internal partial class Program
{
    public static void Main(string[] args)
    {
        BaseCustomerManager customerManager = new NeroCustomerManager();
        customerManager.Save(new Customer { DateOfBirth = new DateTime(1996,8,30), FirstName = "Merve",LastName = "Çakıroğlu", NationalityId = "49624749308" });

        Console.ReadLine();
        
    }
}