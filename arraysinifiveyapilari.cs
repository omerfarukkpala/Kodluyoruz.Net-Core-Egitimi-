using System;

namespace array_metotları
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int [] sayiDizisi = {23,12,15,8,74,96,94,14,47,13,100};

            Console.WriteLine("****Sırasız Dizi****");
            foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);
            
            Console.WriteLine("****Sıralı Dizi****");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

            //Clear
            Console.WriteLine("****Array Clear****");
            Array.Clear(sayiDizisi,0,4);                    // dört adet sıfır.
            foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

            //Reverse
            Console.WriteLine("****Array Reverse****");
            Array.Reverse(sayiDizisi);                      // tersine çevirdi.
            foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

            //IndexOf
            Console.WriteLine("****Array IndexOf****");
            Console.WriteLine(Array.IndexOf(sayiDizisi,94));
            
            //Resize
            Console.WriteLine("****Array Resize****");
            Array.Resize<int>(ref sayiDizisi,12);           // 11 elemanlı olan diziyi 12 elemanlı yap.
            sayiDizisi[11] = 1;
            foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

        }
    }
    
}