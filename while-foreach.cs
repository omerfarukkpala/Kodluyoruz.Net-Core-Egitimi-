// while

    // 1'den başlayarak kendisi dahil olmak üzere Console'dan girilen sayıya kadar olan
    // sayıların aritmetik ortlamasını hesaplayan program

Console.Write("Lütfen bir sayı giriniz: ");
int okual = int.Parse(Console.ReadLine());
int demo = 1;      // 1'den başlasın istiyoruz.
int toplam = 0;

while (demo <= okual)           // demo < okual olsaydı     toplam/okual-1      yazardık.
{
    toplam+= demo;
    demo ++;         
}
Console.WriteLine(toplam/okual);


    // a'dan z'ye bütün harfleri Console'a yazdır.

char character = 'e';

while (character <= 'z')
{
    Console.Write(character);
    character++;
}


// ForEach

                //     foreach(değişkenTipi değişkenAdı in diziAdı)     { //Komutlar}

string[] cars = {"Seat", "Ford", "BMW", "Cadillac", "Audi", "Bentley"};

foreach (var car in cars)
{
    Console.WriteLine(car);

}