using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>     //MyList te T tipi ile çalışacağım
    {
        T[] items;
        //costructor -  classın ismi ile aynıdır - MyList classını bir yerde new lersen contructor otomatik çalışır
        public MyList()
        {
            items = new T[0];

        }
        public void Add(T item) 
        {
            T[] tempArray = items;      //items dizisinde bulunan elemanları geçici bir diziye attım, elemanlar uçmasın diye
            items = new T[items.Length +1];

            //geçici dizideki elemanları sırasıyla tekrar items dizisine atıyorum
            for (int i = 0; i < tempArray.Length; i++)  
            {
                items[i] = tempArray[i];

            }
            //Başta eklenmek istenen elemanı yani T türünde itemi, items dizisinin son eleman yerine koyuyorum
            items[items.Length-1] = item;
        }
        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }


    }
}
