// Console'da verilen sayıya kadar olan tek sayıları yazdır.

Console.WriteLine("Kaça kadar tek sayıları yazdırmak istiyorsunuz?");       //istem


    // int okual = Console.ReadLine(); // Console'da string ifadeler okunur, alınır.
    int okual = int.Parse(Console.ReadLine()); // Parse edilmesi gerek.


    for (int i = 1; i <= okual; i++)
    {
        if(i%2 == 1)
            Console.WriteLine(i);
    }

    // 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerindeki toplamını Console'a yazdır.

int tekToplam = 0;          int ciftToplam = 0;

for (int f = 1; f <= 1000; f++)
{
    if(f%2 == 1)
         tekToplam += f;
    else
        ciftToplam += f;
}
    Console.WriteLine("tek sayıların toplamı: " + tekToplam);
    Console.WriteLine("çift sayıların toplamı: " + ciftToplam);


// break, continue

// Not: İç içe döngüler kullanıldığında break ifadesi yalnızca içinde bulunduğu ilk döngüyü sonlandırır.


for (int n = 0; n <= 10; n++)
{
    if(n == 4)
        break; // 4 olunca döngüyü sonlandır.      
    Console.WriteLine(n); // 0, 1, 2, 3.  
}

for (int q = 1; q <= 7; q++)
{
    if(q == 4)
        continue; // 4'ü atlar! Döngü bir sonraki iterasyondan devam eder.      
    Console.WriteLine(q); // 1, 2, 3, 5, 6, 7.
}

for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0) // i çift sayıya eşit olduğunda döngünün o anki iterasyon sonlanacaktır.
        continue; // Bu durumda console'a 1 ile 10 arasındaki tek sayılar yazdırılacaktır.
    Console.WriteLine(i);
}


