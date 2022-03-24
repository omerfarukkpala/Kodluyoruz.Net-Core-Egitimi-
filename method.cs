	/* erişim_belirteci geri_donus_tipi metot_adi(argüman/parametre)    {//komutlar;    //return;}

    erişim_belirteci → bu metotun nereden erişilebileceğini söyler.
    public → her yerden erişilebilir 
    private → sadece içinde bulunduğu class içinden erişilebilir

    void → geri dönüş istenmeyecekse yazılır */

namespace method 
{
    class Program
    {
        static void Main(string[] args)
        { // static metotlardan sadece static metotlara erişilebilir.
            int a = 3;
            int b = 7;
            int sonuc = Toplam(a,b); // a ve b'yi sonuc adıyla Toplam metodunun parametrelerine ata.
            Console.WriteLine(sonuc); // bunu yazdır  // 1. 10
 
            Easiness ornek = new Easiness();  // Easiness class'ına eriş!
            ornek.EkranaYazdir(Convert.ToString(a+b)); // a + b'yi string'e çevirerek veri parametresi olarak EkranaYazdir metoduna yolla!.
                                                            // 2. 10

            //int demo = ornek.ArttirVeTopla(a,b); // a ve b'yi demo adıyla ArttirVeTopla metodunun parametrelerine ata.
            int demo = ornek.ArttirVeTopla(ref a, ref b);
            Console.WriteLine(demo);   // 1. 12
              // ArttirVeTopla string olsaydı ↓
              // ornek.EkranaYazdir(Convert.ToString(demo));
            ornek.EkranaYazdir(Convert.ToString(a+b));      // ref ile a ve b global olarak değişti
            // 2. 12
        }
 
        static int Toplam(int number1, int number2)
        {
            return number1+number2;
        }
    }
////////////////////////////////////////////////////////////////////////////////////////////////////////   
    class Easiness
    {
        public void EkranaYazdir(string veri) // public → her yerden erişilebilsin.
        {
             Console.WriteLine(veri);
        }
 
        public int ArttirVeTopla(ref int number1, ref int number2)      // ref'ler sonradan eklenme.
        {
            number1+=1;
            number2+=1;
            return number1 + number2;
        }
    }
}