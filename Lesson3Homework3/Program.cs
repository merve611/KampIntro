using Lesson3Homework3;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Customer> customerList  = new List<Customer>();
        
        Customer customer1 = new Customer();
        customer1.Id = 1;
        customer1.Firstname = "Merve";
        customer1.Lastname = "Çakıroğlu";
        customer1.Address = "Trabzon";

        customerList.Add(customer1);

        Customer customer2 = new Customer();
        customer2.Id = 2;
        customer2.Firstname = "Emirhan";
        customer2.Lastname = "Akkoyunlu";
        customer2.Address = "Bayburt";

        customerList.Add(customer2);


        

        CustomerManager customerManager = new CustomerManager();
        customerManager.CustomerList(customerList);

        customerManager.CustomerAdd(customer1); 

        customerManager.CustomerDelete(customer1);
        customerManager.CustomerDelete(customer2);  
       
    }
}