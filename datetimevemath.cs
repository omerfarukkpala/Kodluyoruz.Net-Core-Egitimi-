using System;

namespace Chapter15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());  //  dd.mm.yyyy
            Console.WriteLine(DateTime.Now.ToLongTimeString());  //  HH.MM.SS
            Console.WriteLine(DateTime.Now.ToShortTimeString());//  HH.MM
            Console.WriteLine(DateTime.Now);                   //  dd.mm.yyyy → HH.MM.SS
            Console.WriteLine(DateTime.Now.ToLongDateString());//  29 Mart 2022 Perşembe

            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek); // haftanın günü
            Console.WriteLine(DateTime.Now.DayOfYear); // yılın kaçıncı günü

            Console.WriteLine("***** --Eklemeler-- ***** ");
            // Eklemeler
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMonths(1));
            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMilliseconds(30000));


            // DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); // 29   → gün
            Console.WriteLine(DateTime.Now.ToString("ddd")); // Pzt, Per, Cmt
            Console.WriteLine(DateTime.Now.ToString("dddd")); // Pazartesi, Perşembe, Cuma

            Console.WriteLine(DateTime.Now.ToString("MM"));  // 12   → ay
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Ara, Oca, Şub  
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // Aralık, Mart, Nisan

            Console.WriteLine(DateTime.Now.ToString("yy")); // 21   → yıl
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2021


            Console.WriteLine("***** --Math-- ***** ");
            // Math
            Console.WriteLine(Math.Abs(-25)); // pozitife çevirir
            // Console.WriteLine(Math.Sin(60)); // sin-cos-tan
            // Console.WriteLine(Math.Cos(10));
            // Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3)); // yukarıya doğru yuvarlar
            Console.WriteLine(Math.Floor(22.7)); // aşağıya doğru yuvarlar
            Console.WriteLine(Math.Round(10.3));
            Console.WriteLine(Math.Round(10.7));
            

            Console.WriteLine(Math.Max(2, 6));
            Console.WriteLine(Math.Min(2, 6));

            Console.WriteLine("***** --Math_2-- ***** ");

            Console.WriteLine(Math.Pow(3, 4)); // 3⁴
            Console.WriteLine(Math.Sqrt(9)); // √9       
            Console.WriteLine(Math.Log(9)); // 9'un e tabanındaki logoritmik karşılığı
            Console.WriteLine(Math.Exp(3));  // e³
            Console.WriteLine(Math.Log10(10)); // 10'un log10 tabanındaki logoritmik karşılığı
        }
    }

}
