using LessonHomework1._3;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        //PersonManager personManager = new PersonManager();
        //personManager.Add(new Customer { Id = 1, FirstName = "Merve", LastName = "Çakıroğlu" });

        //Student student = new Student();
        //student.Id = 2;
        //student.FirstName = "Emirhan";
        //student.LastName = "Akkoyunlu";
        //personManager.Add(student);

        //CustomerManager customerManager = new CustomerManager();
        //customerManager.Add(new SqlServerCustomerDal());

        ICustomerDal[] customerDals = new ICustomerDal[3] { new SqlServerCustomerDal(), new OracleCustomerDal(), new MySqlCustomerDal()};
        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }

    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }


    }


    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address {  get; set; }
    }


    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departman {  get; set; }

    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }

    }

}    