using System;
using System.Collections;
using System.Collections.Generic;

namespace Chapter18
{
    class Program
    {
        static void Main(string[] args)
        {
            /* C# %100 nesne yönelimli bir dil olduğu için tüm metot ve özellikler sınıflar içerisinde yer alır.
             [Erişim Belirleyici]     [Veri Tipi] ÖzellikAdı;
             [Erişim Belirleyici]     [Geri Dönüş Değerinin Tipi]     MetotAdi([Parametreler])

             Erişim Belirleyiciler
             1.Public : Her yerden erişilebilir.

             2.Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.

             3.Internal : Sadece bulunduğu proje içerisinden erişilebilir

             4.Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.

             void    →       geri dönüşü olmayacaksa */

            Customer customer_1 = new Customer();

            customer_1.id = 01;
            customer_1.firstName = "Ömer";
            customer_1.lastName = "Pala";
            customer_1.CustomerManager();// çalıştır

            Customer customer_2 = new Customer();

            customer_2.id = 02;
            customer_2.firstName = "Faruk";
            customer_2.lastName = "Pala";
            customer_2.CustomerManager();// çalıştır
        }
    }
    class Customer
    {
        public int id;
        public string firstName;
        public string lastName;

        public void CustomerManager()
        {
            Console.WriteLine("Müşteri ID: {0}", id);
            Console.WriteLine("Müşteri adı: {0}", firstName);
            Console.WriteLine("Müşteri soyadı: {0}", lastName);
        }
    }
}