using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Homework5.Entities
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public int Rate { get; set; }  //kampanya oranı
    }
}
