using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //Bir classın içinde birden fazla metot olabilir.

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler ! Sepete Eklendi: " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdeti)
        {
            Console.WriteLine("Tebrikler ! Sepete Eklendi: " + urunAdi  );
        }
    }   
}
