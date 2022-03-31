using System;
namespace Chapter22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Pazartesi);
            Console.WriteLine((int)Days.Salı);//  integer

            int temperature = 23;
            if (temperature <= (int)Weather.Normal)//  integer
            {
                Console.WriteLine("Hava dışarı çıkmak için soğuk.");
            }
            else if (temperature >= (int)Weather.Sıcak)
            {
                Console.WriteLine("Hava dışarı çıkmak için çok sıcak.");
            }
            else if (temperature >= (int)Weather.Normal && temperature < (int)Weather.Sıcak)
            {
                Console.WriteLine("Haydi dışarı çıkalım.");
            }
        }

    }

    enum Days
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum Weather
    {
        ÇokSıcak = 30,
        Sıcak = 25,
        Normal = 20,
        Soğuk = 5,
    }
}