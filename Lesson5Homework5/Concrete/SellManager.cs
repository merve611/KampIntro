using Lesson5Homework5.Abstract;
using Lesson5Homework5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Homework5.Concrete
{
    public class SellManager
    {
        public void Sell(Gamer gamer, Game game, ICampaignService campaignService)
        {
            Console.WriteLine(gamer.FirstName + " Oyuncusuna " + game.GameName + " oyunu satıldı.");
            campaignService.Add(campaign);
        }

        
    }
}
