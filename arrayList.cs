using System;
using System.Collections;
using System.Collections.Generic;


namespace Chapter17
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList(); // string, integer ve bool.

            list.Add("Faruk");
            list.Add("Pala");
            list.Add(99);
            list.Add(true);
            list.Add('*');

            // Tek elemana erişme
            Console.WriteLine(list[1]);// Pala


            // AddRange → bİr tür çoklu ekleme
            Console.WriteLine("***** AddRange *****");
            string[] colors = { "Beyaz", "kırmızı", "Obsidyen", "gündüz  Yeşili" };
            List<int> numbers = new List<int>() { 1, 3, 9, 7, 4, 5 };
            list.AddRange(colors);
            list.AddRange(numbers);

            foreach (var item in list)
                Console.WriteLine(item);

            // Sort → sıralama  → sorunlu tarafı → farklı veri türleri!
            Console.WriteLine("***** Sort *****");
            // list.Sort();


            // Binary Search → kullanabilmek için önce elemanlar sıralanmalı
            Console.WriteLine("***** BinarySearch *****");
            // Console.WriteLine(list.BinarySearch(9)); // int → Sort → 5

            // Reverse → ters çevirir
            Console.WriteLine("***** Reverse *****");
            list.Reverse();
            foreach (var item in list)
                Console.WriteLine(item);


            // Clear →
            Console.WriteLine("***** Clear *****");
            // list.Clear();


            Console.WriteLine("***** Dictionary *****");
            Console.WriteLine("***** Dictionary *****");
            // Dictionary
            Dictionary<string, string> demo = new Dictionary<string, string>();
            demo.Add("book", "kitap");
            demo.Add("car", "araba");
            demo.Add("pen", "kalem");
            Dictionary<int, string> customers = new Dictionary<int, string>();
            customers.Add(1, "faruk");
            customers.Add(2, "ali");
            customers.Add(3, "ahmet");
            customers.Add(4, "hasan");

            Console.WriteLine(demo["book"]);// kitap
            Console.WriteLine(customers[3]);// ahmet

            // Keys and Values
            Console.WriteLine("***** Keys and Values *****");
            foreach (var demos in demo)
            {
                Console.WriteLine(demos);// [book, kitap]    [car, araba]    [pen, kalem]
                Console.WriteLine(demos.Key);// book     car     pen
                Console.WriteLine(demos.Value);// kitap    araba   kalem
            }

            // ContainsKey
            Console.WriteLine("***** ContainsKey *****");
            Console.WriteLine(demo.ContainsKey("book"));      // True
            Console.WriteLine(demo.ContainsKey("school"));    // False

            // Count
            Console.WriteLine("***** Count *****");
            Console.WriteLine(demo.Count);// 3
            Console.WriteLine(customers.Count);// 4

            // Remove
            Console.WriteLine("***** Remove *****");
            customers.Remove(4);// [4, hasan]   kaldırıldı.
            foreach (var customer in customers)
                Console.WriteLine(customer);
        }
    }
    /*  Farklı veri tipleri ArrayList içerisinde saklanabilir.
     Eleman eklenerek veya çıkarılarak ArrayList'in boyutu dinamik olarak değiştirilebilir.
      Varsayılan boyutu başlangıç olarak 4'tür. Aşıldığında otomatik olarak 2 katına çıkar.
      Yani bir ArrayList'e 5. eleman eklenmeye çalışıldığında arka planda boyutu 8'e çıkar. */
}