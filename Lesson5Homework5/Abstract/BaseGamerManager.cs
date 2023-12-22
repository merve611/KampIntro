using Lesson5Homework5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5Homework5.Abstract
{
    public class BaseGamerManager : IGamerService
    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+ "oyuncusu silindi");
        }

        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "oyuncusu kaydedildi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "oyuncusu güncellendi");
        }
    }
}
