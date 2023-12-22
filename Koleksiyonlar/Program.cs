using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        //string[] isimler = new string[] {"Merve", "Emirhan", "Gönül", "Ali" };

        //Console.WriteLine(isimler[0]);
        //Console.WriteLine(isimler[1]);
        //Console.WriteLine(isimler[2]);
        //Console.WriteLine(isimler[3]);

        //isimler[4] = "Ahmet";
        //Console.WriteLine(isimler[4]);
        //Console.WriteLine(isimler[0]);

        //Arrayda sabitlik var Örneğin 4 elemanlı bir array tanımladığımızda onu artık 5 elemanlı yapamayız.
        //Yaparsak ta eski elemanları kaybedersiniz. Çünkü new demek yeni referans adresi demektir.

        List<string> isimler2 = new List<string> { "Merve", "Emirhan", "Gönül", "Ali" };
        Console.WriteLine(isimler2[0]);
        Console.WriteLine(isimler2[1]);
        Console.WriteLine(isimler2[2]);
        Console.WriteLine(isimler2[3]);

        isimler2.Add("Ahmet");

        Console.WriteLine(isimler2[4]);
        Console.WriteLine(isimler2[0]);





    }
}