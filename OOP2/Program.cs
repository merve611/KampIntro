using OOP2;

internal class Program
{
    private static void Main(string[] args)
    {
        GercekMusteri musteri1 = new GercekMusteri();
        musteri1.Id = 1;
        musteri1.MusteriNo = "123456";
        musteri1.Adi = "Merve";
        musteri1.Soyadi = "Çakıroğlu";
        musteri1.TcNo = "456456789";
        
       
        TuzelMusteri musteri2 = new TuzelMusteri();
        musteri2.Id = 2;
        musteri2.MusteriNo = "74136";
        musteri2.SiketAdi = "Kodlama.io";
        musteri2.VerginNo = "7413245975";


        //Musteri classı hem gerçek müşterinin referansını tutabiliyor, hem de tüzel müşterinin referansını tutabiliyor;
        Musteri musteri3 = new GercekMusteri(); 
        Musteri musteri4 = new TuzelMusteri();

        MusteriManager musteriManager = new MusteriManager();
        musteriManager.Ekle(musteri1);
        musteriManager.Ekle(musteri2);

        //olay şu;Temel sınıfın onu inheritance eden tüzel müşteri gerçek müşteriyi onların referansını tutabilmesi
    }
}