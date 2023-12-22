using Lesson5Homework4.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Homework4.Concrete
{
    public class StarbucksCustomerManager :BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }   

            
        

        
    }
}
