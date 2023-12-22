using Lesson5Homework5.Abstract;
using Lesson5Homework5.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Homework5.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth.Year);
        }
    }
}
