using System;
/*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
 Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. */
namespace Task_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lütfen pozitif bir tam sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Lütfen aralarında birer boşluk bırakarak {n} adet pozitif tam sayı giriniz: ");
            string[] numbers_space = new string[n];
            numbers_space = (Console.ReadLine().Split(" "));  // sayılar sırayla alındı.

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            numbers[i] = int.Parse(numbers_space[i]);

            foreach(int i in numbers)
            if(i % 2 ==0)
            System.Console.WriteLine(i + " sayısı bir çift tam sayıdır.");
        }
    }
}