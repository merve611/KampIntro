using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Inharitance'nin asıl olayı Musteride olan özellikler artık gerçek te de tuzelde de vardır.  
    class GercekMusteri: Musteri                 //Miras - inheritance (Gerçek müşteri bir müşteridir demek olur.) Geçek müşteri miras alır Müşteriden. (Gerçek müşterinin ebeveyni Müşteridir.) Müşteride olan herşey gerçek müşteride de kabul edilir.
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
