﻿internal class Program
{
    private static void Main(string[] args)
    {
        //type safety - tip güvenliği

        string kategoriEtiketi = "Kategori";
        int ogrenciSayisi = 32000;
        double faizOrani = 1.45;
        bool sistemeGirisYapmismi = true;
        double dolarDun = 7.55;
        double dolarBugun = 7.55;


        if (dolarDun > dolarBugun)
        {
            Console.WriteLine("Azalış Butonu");
        }
        else if (dolarDun < dolarBugun)
        {
            Console.WriteLine("Artış Butonu");
        }
        else 
        {
            Console.WriteLine("Değişmedi Butonu");
        }



        if (sistemeGirisYapmismi == true)
        {
            Console.WriteLine("Kullanıcı ayarları butonu");
        }
        else
        {
            Console.WriteLine("Giriş yap butonu");
        }
        

        Console.WriteLine(kategoriEtiketi);


    }
}