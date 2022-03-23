// Atama ve İşlemli Atama

        int x = 7;
        int y = 9;

        x *=2;          // x'i      2 ile çarp

        y = y+3;        // y'ye     üç ekle.
        y += 2;         // y'ye     2 ekle             işlemli atama
        y/=2;           // y'yi     2'ye böl


        Console.WriteLine(x);
        Console.WriteLine(y);

// Mantıksal Operatörler
// ve &&    veya ||     değil !

        bool isSucces = true;
        bool isComleted = false;

        if(isSucces && isComleted){
            Console.WriteLine("perfect!");          // çalıştırmaz.
        }

        if(isSucces || isComleted){                 // ikisinden biri true ise
            Console.WriteLine("justone!");
        }

        if(isSucces && !isComleted){                //ilki true, ikincisi true değil ise
            Console.WriteLine("Great!Perfect!");
        }

// İlişkisel Operatörler
// >, <, <=, >=, ==, !=

        int a = 3;
        int b = 4;
        bool sonuc = a<b;               // true
        Console.WriteLine(sonuc);

        sonuc = a>b;
        Console.WriteLine(sonuc);

        sonuc = a>=b;
        Console.WriteLine(sonuc);

        sonuc = a<=b;                   // true
        Console.WriteLine(sonuc);

        sonuc = a==b;
        Console.WriteLine(sonuc);

        sonuc = a!=b;                   // true
        Console.WriteLine(sonuc);

// Aritmetik Operatörler
// +, -, *, /,

        int sayi1 = 10;
        int sayi2 = 5;
        int sayi3 = 70;

        int  sonuc1 = sayi3/sayi1;       // 7
        Console.WriteLine(sonuc1);

        int sonuc2 = sayi2 - sayi1;     // -5
        Console.WriteLine(sonuc2);
        int sonuc3 = sayi2 * sayi1;     // 50
        Console.WriteLine(sonuc3);
        int sonuc4 = sayi2 + sayi1;     // 15
        Console.WriteLine(sonuc4);
        sayi3 += 1;                     // 71
        Console.WriteLine(sayi3);

        int sonuc5 = sayi3++;           // 72
        Console.WriteLine(sayi3);

        int sonuc17 = ++sayi3;          //73         arttırma yapıldıktan sonra yazdırılırsa artırma görülür
        Console.WriteLine(sonuc17);


    // % mod alma

        int sonuc6 = 25 % 5;                // 0
        Console.WriteLine(sonuc6);
        int sonuc7 = 19 % 3;                // 1
        Console.WriteLine(sonuc7);