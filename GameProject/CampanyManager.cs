using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampanyManager : ICampanyService
    {
        public void Add(Campany campany)
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Delete(Campany campany)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Campany campany)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
