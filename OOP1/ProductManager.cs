using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {   //void türünde eklediğimiz metotları emir veriyormuş gibi git şunu yap vb. işlemler yaparken işlem sonucunun ne olduğu ile ilgili exsta bir bilgiye ihtiyacımız olmazsa void olarak tanımlarız.
        public void Add(Product product)            //Product türünde product adlı paramatre ver.
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }










        // Alttaki iki fonksiyonun farkı : void li olan da herhangi değer döndürmez iken int li olanda bir değer döndürüyor ve döndürülen bu değeri başka yerlerde de kullanmamıza olanak sağlıyor.
        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;

        //}
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);

        //}





    }
}
