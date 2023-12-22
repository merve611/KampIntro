using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Person[] persons = new Person[] {new Person { FirstName = "Merve"}, new Customer { FirstName = "Emirhan"}, new Student { FirstName = "Ahmet"} };

        foreach (var person in persons)
        {
            Console.WriteLine(person.FirstName);
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    interface IPerson2
    {

    }

    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Departman { get; set; }
    }
}