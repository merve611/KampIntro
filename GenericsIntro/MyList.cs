using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //Generic class demek çalışacağınız özel bir tip olacağı demektir.
    class MyList<T>                 //Ben MyList te T tipi ile çalışacağım anlamına geliyor
    {
        T[] items;                  //Bu değişkeni metodun içinde tanımlamamamın sebebi başka oluşturacağımız metotlar da erişebilsin diye.Classın bütün operasyonlarının erişebileceği bir dizi tanımladık.
        //constructur;
        public MyList()             //ctor yazıp iki kere tab yapar isek constructor metodunu oluştururuz. MyList classını new lersek otomatik çalışır.Bir class newlendiğinde çalışan bloğa constructor deniyor.
        {
            items = new T[0];       //array oluşturduk, 0 elemanlı olarak. Array referans tip olduğu için new lenmek zorundadır.
        }
        public void Add(T item)                         //item eleman demektir.
        {
            T[] tempArray = items;                      //Geçici dizinin referansı items ın referansı oldu. Bunu yapma sebebimiz elemanlarımız kaybolmasın diye Dolayısıyla geçici dizi ile tamamen önceki değerleeri korumak için tutuyoruz.
                                                        //Koleksiyonlar dosyasında da yazdığımız gibi diziyi new lediğimiz an referans numarası alır. Yeni referans demek önceki elemanların uçması demek. Uçmasın diye o referans nosunu başkasına tutturuyorum, Sonra kendime başka referans alıyorum;    
            items = new T[items.Length + 1];            //Dizinin eleman sayısını 1 artırdım.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];                //tempArraye emanet ettiğimiz değerleri sırasıyla items'a geri alıyorum.
            }

            items[items.Length - 1] = item;             //items.lenght-1 demek items'ın son elemanı demektir. Yukardaki ıtem ı yani eklemek istediğimiz elemanı da son boşluğa ekledik.
        }
    }
}
