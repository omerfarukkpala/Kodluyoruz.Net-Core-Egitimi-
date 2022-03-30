using System;
using System.Collections;
using System.Collections.Generic;

namespace Chapter16
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class    T → object türündedir.

            List<int> numberList = new List<int>();

            numberList.Add(01);
            numberList.Add(02);
            numberList.Add(03);
            numberList.Add(04);
            numberList.Add(05);
            numberList.Add(06);
            numberList.Add(07);

            List<string> colorList = new List<string>();

            colorList.Add("yeşil");
            colorList.Add("siyah");
            colorList.Add("turkuaz");
            colorList.Add("turuncu");
            colorList.Add("turkuaz");
            colorList.Add("beyaz");

            // Count
            Console.WriteLine(numberList.Count);  //  7
            Console.WriteLine(colorList.Count);    //  6

            // // foreach
            // foreach (var number in numberList)
            //     Console.WriteLine(number);
            // foreach (var color in colorList)
            //     Console.WriteLine(color);

            // // ForEach
            // numberList.ForEach(number => Console.WriteLine(number));
            // numberList.ForEach(color => Console.WriteLine(color));

            // Remove → bulduğu ilk istemi kaldırır ve çalışmayı durdurur
            numberList.Remove(04);
            colorList.Remove("turkuaz");

            // RemoveAt → istenen index'i kaldırır.
            colorList.RemoveAt(3);

            //numberList.ForEach(number => Console.WriteLine(number));
            //colorList.ForEach(color => Console.WriteLine(color));

            // Contains → isteneni arar
            if(numberList.Contains(09))
                Console.WriteLine("09'u buldum");
            else
                Console.WriteLine("09'u bulamadım");
            // Diziyi List'e çevirme
            string[] animals = {"cat", "dog", "bear",};
            List<string> animalList = new List<string>(animals);

            // Clear → liste elemanlarının hepsini siler, temizler
            animalList.Clear();
            
            // List içerisinde Class tutmak
            List<Students> studentList = new List<Students>{
                new Students{ Id = 01, FirstName = "Ömer ",  LastName = "Pala"},
                new Students{ Id = 02, FirstName = "Faruk",   LastName = "Pala"},
                new Students{ Id = 03, FirstName = "Pala", LastName = "Pala"},
            };

            foreach (Students student in studentList) // Students tipinde
                Console.WriteLine(student.FirstName);
        }
    }
    public class Students  // List içerisinde Class tutmak için
    {
        private int id;
        private string firstName;
        private string lastName;
        private int age;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
    }
        /* Array'in elemanları aynı veri tipinde olmalıdır.
          Array'in boyutu önceden belirlenmelidir.
           Koleksiyonların elemanları object tipindedir.
           Değer tipleri belliğin stack bölgesinde,
           Referans tipleri belleğin heap bölgesinde tutulur.
           Bir değer tipinin referans tipine dönüştürülme boxing, tam tersine unboxing işlemi denir.
           Object de bir referans tipi. Bu demek oluyor ki, değer tipinde bir veriyi koleksiyona eklemek istediğimde bir boxing işlemi yapıyorum.
           Daha sonra elemanı okumak istediğimde de unboxing işlemi yapıyorum.
           Boxing ve unboxing işlemleri bilgisayar açısından maliyetli bir işlemdir. */
}