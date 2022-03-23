using System;

namespace console_programlama
{

    class Program
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Hello, World!");  // " " İçindeki metni console'a yazdırır.
            Console.WriteLine("İsminizi Giriniz:");
            string name= Console.ReadLine(); // name değişkenini console'a yazılan bilgiden okur
             // ve okuduğunu name değişkenine atar 
            Console.WriteLine("soyadınızı giriniz:");
            string surname= Console.ReadLine(); // surname değişkenini console'a yazılan bilgiden okur
             // ve okuduğunu surname değişkenine atar
            Console.WriteLine("merhaba " + name + " " + surname);// console'da aldığı bilgileri yandaki şekilde bir kez daha console'a yazdırır


   
        
                                               
        }
    }
}