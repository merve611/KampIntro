using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        //product1 i gönderdim, onu product ismiyle tutuyor
        public void Add(Product product)
        {
            Console.WriteLine(product + "Eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product + "Güncellendi");
        }


       

    }
}
