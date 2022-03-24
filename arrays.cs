using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
        //Dizi Tanımlama

            string[] fruits;                           // fruits adında string bir dizi.
            fruits = new string[3];                    // fruits adında 3 -string- elemanlı, string bir dizi.

            int[] numbers = new int[9];                // numbers adında 9 -integer- elemanlı, integer bir dizi.            

            string[] colours = new string[5];          // colours adında 5 -string- elemanlı, string bir dizi.

            string[] animals = {"cat", "dog", "lion", "monkey", "cow", "bear", "wolf"};
                                                       // animals adında 7 -string- elemanlı, string bir dizi.
            
        //Dizilere Değer Atama

            fruits[0] = "apple";             // fruits adında string dizinin ilk elemanına "apple" atandı.
            numbers[3] = 7;                  // numbers adında integer dizinin ilk elemanına 7 atandı.

        
        //Dizi Elemanlarına Erişme

            Console.WriteLine(fruits[0]);   
            Console.WriteLine(numbers[3]);  // numbers ismindeki integer dizinin üçüncü index'ini getir.
            Console.WriteLine(animals[6]);  // animals ismindeki string dizinin altıncı index'ini getir.

        //Döngülerle Dizi Kullanımı


            // Console'a girilen n tane sayının ortalamasını söyleyen program.    
            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz: ");
            int elemansayisi = int.Parse(Console.ReadLine());       // dizinin eleman sayısı alındı.
            
            int[] sayiDizisi = new int [elemansayisi];          // sayi Dizisi adında -elemansayisi- kadar elemanlı integer bir dizi.

            for (int i = 0; i < elemansayisi; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }


            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;  
            }
            Console.WriteLine("Ortalaması: " + toplam/elemansayisi);
            
        }
    }
}