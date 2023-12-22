internal class Program
{
    private static void Main(string[] args)
    {
       
        List<string> sehirler = new List<string>();
        sehirler.Add("Ankara");
        sehirler.Add("Ankara");
        sehirler.Add("Ankara");
        sehirler.Add("Ankara");
        Console.WriteLine(sehirler.Count);
        

        MyList<string> sehirler2 = new MyList<string>();
        sehirler2.Add("Trabzon");
        sehirler2.Add("Trabzon");
        sehirler2.Add("Trabzon");
        Console.WriteLine(sehirler2.Count);
        
    }
}

class MyList<T>
{
    T[] _array;
    T[] _tempArray;
    public MyList()
    {
        _array = new T[0];

    }


    public void Add(T item) //Burdaki T hangi tip verirsek ona dönüşüyor. yukardaa string verdik stringe dönüştü
    {
        _tempArray = _array;
        _array = new T[_array.Length+1];

        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }
        _array[_array.Length - 1] = item;   

    }
   

    public int Count
    {
        get { return _array.Length; }
       
    }




}