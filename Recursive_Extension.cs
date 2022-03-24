namespace Chapter13
{
    class Program
    {
        static void Main(string[] args)
        {

        // 3⁴ = 3*3*3*3

            int demo = 1;
            Console.WriteLine(demo);

            for (int i = 0; i < 4; i++)         // 0 1 2 3  → 4 kere
            {
                demo = demo * 3;
            }
            Console.WriteLine(demo);


        // Program_1

            Program_1 program_1 = new Program_1();
            Console.WriteLine(program_1.Remo(3,5));          //  → 3⁵


        // Extension

            string demo_2 = "Taşıt Tanıma Sistemi";

                Console.WriteLine(demo_2.RemoveSpaces());
                Console.WriteLine(demo_2.MakeUpper());
                Console.WriteLine(demo_2.MakeLower());


        // Extension İnteger Example
            int[] array_1 = {13,9,8,7,5,6,7,8,9};
            array_1.felipe();                              // 1. çalıştırdık, ekrana yazdırmadık.
            array_1.Write_2();                             // 3. yazdırdığımızı çalıştırdık.


        // çift mi değil mi ?
        int number_2 = 5;
        Console.WriteLine(number_2.IsEvenNumber());         // false


        // ilk karakterini al ve getir
        Console.WriteLine(demo_2.GetFirstCharacter());      // T

        }
    }
    public class Program_1
    {
        public int Remo(int number_1, int üs_1)
        {
            if(üs_1 < 2)
            return number_1;
            return Remo(number_1, üs_1-1) * number_1;
        }
            // Remo (3,5)                   atandı.
            // Remo (3,5) * 3
            // Remo (3,3) * 3 * 3           -1
            // Remo (3,2) * 3 * 3 * 3       -1
            // Remo (3,1) * 3 * 3 * 3 * 3   -1     →   (3,2) çağrıldığında (3,1) döner.
            // 3          * 3 * 3 * 3 * 3          →   (3,1) çağrıldığında → return number_1; → 3 döner.  
    }

    public static class Program_2                               // --- önemli! --- → static olmalı.
    {
        public static string RemoveSpaces(this string param)        // --- önemli! --- → static olmalı.
        {                                                           // --- önemli! --- → this olmalı.
            string[] dizi = param.Split(" ");                       // boşluklarından ayır ve dizi yaz
            return string.Join("-", dizi);                          // birleştir        "", → aralardaki boşukları kaldır
        }
        public static string MakeUpper(this string param)
        {
            return param.ToUpper();                                 // Büyük harf yap
        }
        public static string MakeLower(this string param)
        {
            return param.ToLower();                                 // Küçük harf yap
        }


        // Extension İnteger Example

        public static int[] felipe(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void Write_2(this int[] param)
        {
            foreach (int item in param)
            Console.WriteLine(item);                    // 2. yazdırdık ama çalıştırmadık.
        }

        // çift mi değil mi ?

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }

        // ilk karakterini al ve getir

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);            // 0'dan başla ve bir karakter getir
        }
    }
}