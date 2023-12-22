﻿internal class Program
{
    private static void Main(string[] args)
    {
        //Metotlar..


        //Add();
        //Add();
        //Add();

        //var result = Add2(20,30);
        //Console.WriteLine(result);

        //int number1 = 20;
        //int number2 = 100;
        //var result2  = Add3(ref number1, number2);
        //Console.WriteLine(number1);

        Console.WriteLine(Multiply(2,4));
        Console.WriteLine(Multiply(2,4,8));

        Console.WriteLine(Add4(2,4,5,6,9,8,7,3));

    }

    static void Add()
    {
        Console.WriteLine(  "Added ");
    }

    static int Add2(int number1 = 40, int number2 = 30)      //number2 verilmez ise default değeri 30 olarak alınır. Default değerler metodun herzaman sonunda olur
    {
        var result = number1 + number2;
        return result;
        
    }

    static int Add3(ref int number1, int number2)
    {
        number1 = 30;
        return number1 + number2;   
    }

    static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }
    static int Multiply(int number1, int number2, int number3)
    {
        return number1 * number2 * number3;
    }

    static int Add4(int number, params int[] numbers)       //params notasyonu ile kaç tane istiyorsak o kadar parametre gönderebiliyoruz.
    {
        return numbers.Sum();           //numbers dizisinde bütün sayıları birbiriyle topla demek - sum hazır fonksiyon
    }

    
}