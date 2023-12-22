using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Homework4.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService     //Bu bir abstract classtır kodun içi de aynı olacaksa abstract metot kulllanılır

    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
