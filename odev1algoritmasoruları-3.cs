﻿using System;
/*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
 Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
 */
namespace Task_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lütfen pozitif bir tam sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Lütfen aralarında birer boşluk bırakarak {n} adet kelime giriniz: ");
            string[] words = new string[n];
            words = (Console.ReadLine().Split(" ")); // kelimeler sırayla alındı.

            for(int i=(n-1) ; i>=0 ; i--)
            Console.Write(words[i] + " ");
        }
    }
}