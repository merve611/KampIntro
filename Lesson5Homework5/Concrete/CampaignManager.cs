using Lesson5Homework5.Abstract;
using Lesson5Homework5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Homework5.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silinid");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
