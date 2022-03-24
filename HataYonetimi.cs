try
{
    Console.WriteLine("Bir sayı giriniz:");
    int sayi = Convert.ToInt32(Console.ReadLine()); //integer'a çeviremediği bir şeyle karşılaştığı zaman hata koduna geçer
    Console.WriteLine("Girmiş olduğunuz sayi :" + sayi);    
}
catch(Exception ex)
{
    Console.WriteLine("Hata: " + ex.Message.ToString());
}
finally
{
    Console.WriteLine("İşlem tamamlandı!");
} 
// Parse: String ifadeleri integer değerlere dönüştürür.
try
{
        // int a = int.Parse(null); // ArgumentNullException ex
        // int a = int.Parse("demo"); // FormatException ex
        int a = int.Parse("-200000000000"); // OverflowException ex
}
catch(ArgumentNullException ex)
{
    Console.WriteLine("Boş bir değer girdiniz.");
    Console.WriteLine(ex);
}
catch(FormatException ex)
{
    Console.WriteLine("Veri tipi uygun değil.");
    Console.WriteLine(ex);
}
catch(OverflowException ex)
{
    Console.WriteLine("Alabileceği aralığın dışında bir değer girdiniz.");
    Console.WriteLine(ex);
}