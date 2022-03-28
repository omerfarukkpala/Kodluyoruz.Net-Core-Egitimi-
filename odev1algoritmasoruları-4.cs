using System;

namespace Task_4
{
    class Program
    {
        public static void Main(string[] args)
        { 
            /* Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
             Cümledeki toplam kelime ve harf sayısını console'a yazdırın.*/
            Console.WriteLine("Lütfen bir cümle yazınız: ");
            string sentence = Console.ReadLine();
            string letters_list = "c#.net Kodluyoruz" + "Patika.Dev";
            string[] words = sentence.Split(' ');
            Console.WriteLine($"Yazdığınız cümledeki kelime adedi: {words.Length}");

            int sayac = 0;
            for (int i = 0; i < sentence.Length; i++)
            if (letters_list.Contains(sentence[i]))
            sayac++;

            Console.WriteLine($"Yazdığınız cümledeki harf adedi: {sayac}");
        }
    }
}