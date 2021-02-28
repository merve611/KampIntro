using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // GenericsIntro yani bu dosyada bir önceki işlediğimiz koleksiyonlarda list i ben nasıl yazardım bunu yapacağız.


            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");

        }
    }
}
