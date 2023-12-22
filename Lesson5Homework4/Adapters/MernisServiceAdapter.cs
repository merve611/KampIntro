using Lesson5Homework4.Abstract;
using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MernisServiceReference1.KPSPublicSoapClient;

namespace Lesson5Homework4.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
            
        }    
    }
}
