using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Homework4.Abstract
{
    public interface ICustomerCheckService      //kullanıcının bir kişi ile ilgili kontrolleri yaptığı servis
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
