using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3Homework3
{
    class CustomerManager
    {


        List<Customer> customerList = new List<Customer>();
        public void CustomerAdd(Customer customer)
        {
            customerList.Add(customer);
            Console.WriteLine(customer.Firstname + "  isimli müşteri eklendi.");
        }

        public void CustomerList(List<Customer> customer)
        {
            foreach (Customer customerr in customer)
            {
                Console.WriteLine(customerr.Firstname + " " + customerr.Lastname + " " + customerr.Address);
            }
        }

        public void CustomerDelete(Customer customer)
        {
            customerList.Remove(customer);
            Console.WriteLine(customer.Firstname + " Silindi.");
        }


    }
}
