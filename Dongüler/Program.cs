internal class Program
{
    private static void Main(string[] args)
    {
        string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
        string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
        string kurs3 = "Java";
        string kurs4 = "Python";


        //array - dizi

        string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç için Temel Kurs" , "Java" , "Python" , "C++"};
        

        for (int i = 0; i < kurslar.Length; i++)
        {
            Console.WriteLine(kurslar[i]);
        }
        Console.WriteLine(  "for bitti ");

        foreach (string kurs in kurslar)        // kurslar ı dolaş, her bir elemana kurs aliasını ver 
        {
            Console.WriteLine(kurs);
        }
        Console.WriteLine(  "foreach bitti");

        Console.WriteLine("--Sayfa Sonu--");
    }
}