using System;
/* Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu 
sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.*/
namespace Task_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter tuşunu kullanarak lütfen sırayla iki adet pozitif tam sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine($"Lütfen aralarında birer boşluk bırakarak {n} adet pozitif tam sayı giriniz: ");
            string[] numbers_space = new string[n];
            numbers_space = (Console.ReadLine().Split(" ")); // sayılar sırayla alındı.
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            numbers[i] = int.Parse(numbers_space[i]);

            foreach (int i in numbers)
            {
                if((i % m) ==0)
                System.Console.WriteLine($"{i} sayısı {m} sayısına tam bölünür.");
                if(i == m)
                System.Console.WriteLine($"{m} sayısı zaten {m} sayısına eşittir dolayısıyla birbirlerine tam bölünürler.");
            }
        }
    }
}