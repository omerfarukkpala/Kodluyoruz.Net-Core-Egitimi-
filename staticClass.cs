using System;

namespace Chapter21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir sınıfın static olmayan üyelerine nesneler aracılığıyla erişilir.
             Static olan metotlara ve özelliklere ise nesne oluşturmadan, o sınıfın ismi aracılığıyla erişilir.*/

            Console.WriteLine("Müşteri Sayısı     :{0}", Customer.NumberofCustomers);// static'e ulaşma

            Customer customer_1 = new Customer("Faruk", "Pala");

            Console.WriteLine("Müşteri Sayısı     :{0}", Customer.NumberofCustomers);


            // Static Class'a Ulaşma → → →    Islemler.Addition(100,200);

            Console.WriteLine("Toplama İşlemi Sonucu: {0}", Islemler.Addition(100,200));
            Console.WriteLine("Çıkarma İşlemi Sonucu: {0}", Islemler.Subtraction(600,300)); 
        }

    }
    class Customer
    {
        private static int numberofCustomers;// static   → kapsülle
        private string firstName;
        private string lastName;

        public static int NumberofCustomers { get => numberofCustomers; }
        /* public string FirstName { get => firstName; set => firstName = value; }
           public string LastName { get => lastName; set => lastName = value; } */

        static Customer()
        {
            numberofCustomers = 0;
        }
        public Customer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            numberofCustomers++;
        }
    }
    static class Islemler
    {
        public static long Addition(int number1, int number2)
        {
            return number1 + number2;
        }

        public static long Subtraction(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}