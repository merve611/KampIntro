using Metotlar;

internal class Program
{
    private static void Main(string[] args)
    {
                                        //class tan bir değişken tanımlayacağın zaman new lemen grekiyor.
        Urun urun1 = new Urun();        //Bir class tanımlamak için bunu yapman gerekiyor - classın örneği
        urun1.Adi = "Elma";
        urun1.Fiyati = 15;
        urun1.Aciklama = "Amasya elması";

        Urun urun2 = new Urun();        
        urun2.Adi = "Karpuz";
        urun2.Fiyati = 30;
        urun2.Aciklama = "Diyarbakır Karpuzu";

        Urun[] urunler = new Urun[] {urun1, urun2 };

        foreach (Urun urun in urunler)      //urunler- üstte yazdığın dizi - urun döngü dönerken kullanılan takma isim.
        {
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine("--------------");
        }

        Console.WriteLine("----------Metotlar------------");


        //Instance - örnek
        //Encapsulation

        SepetManager sepetManager = new SepetManager();     //Class örneği oluşturduk
        
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);

        sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 40);
        sepetManager.Ekle2("Elma", "Yeşil Elma", 10, 50);


        //Metotlar bana tekrar tekrar aynı şeyi kullanabilme imknaı verdi. 
    }
}

