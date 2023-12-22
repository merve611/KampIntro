using Lesson5Homework5.Abstract;
using Lesson5Homework5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Homework5.Concrete
{
    public class GamerManager : BaseGamerManager
    {
        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
;            _gamerCheckService = gamerCheckService;
        }   

        public override void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                Console.WriteLine("Geçerli bir kişi değil");
            }
            
        }

        
    }
}
