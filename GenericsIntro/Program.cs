using GenericsIntro;

internal class Program
{
    private static void Main(string[] args)
    {
        MyList<string> isimler = new MyList<string>();
        isimler.Add("Merve");

        Console.WriteLine(isimler.Length);

        isimler.Add("Emirhan");

        Console.WriteLine(isimler.Length);

        foreach (var isim in isimler.Items)
        {
            Console.WriteLine(isim);
        }
    }
}