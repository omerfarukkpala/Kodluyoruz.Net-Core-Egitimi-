using System;

namespace Chapter12
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Out Parametreler
            string number_1 = "17";
            bool demo = int.TryParse(number_1, out int outnumber_1);
            if(demo)
            {
                Console.WriteLine("Başarıldı!");
                Console.WriteLine(outnumber_1); // 17
            }else{
                Console.WriteLine("Başarısız!");
            }

            Program_2 test = new Program_2();
            test.Topla(2,3, out int toplamınSonucu);
            Console.WriteLine(toplamınSonucu); // 5

            // Method Overloading

            int number_2 = 27;
            test.Write(number_2); //27
            // test.Write(Convert.ToString(number_2)); // overload etmeseydik ↓↑
            test.Write("Ömer Faruk ", "PALA");
        }
    }
    class Program_2
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void Write(string veri) // hem string ↓
        {
            Console.WriteLine(veri);
        }

        public void Write(int veri) // hem de integer ↑
        {
            Console.WriteLine(veri);
        }
        public void Write(string veri1, string veri2)                     // hem de integer ↑
        {
            Console.WriteLine(veri1 + veri2);
        }
        // metot imzası →   →   →       Write(string veri1, string veri2)
    }
}

/* Out Kullanımının Özellikleri:
     Out olarak kullanılmak istenen değişken önüne mutlaka "out" yazılmalıdır.
out değişkeninin bir ilk değeri olmak zorunda değildir.
   Hatırlarsanız bu ref kullanırken zorunluydu.*/