
/*C# dilinde iki tür veri tipi mevcuttur.Bunlar değer ve referans tipleridir.
 Değer tipleri; veriyi taşıyan ve taşıdığı veriye göre bellek üzerinde yer dolduran değişken türleridir.
 Referans türleri ise, bellek bölgesinde veri yerine verinin bellekteki adresini tutarlar ve o adresin gösterdiği yerde de veri tutulur.
Değer tipleri:  "int", "long", "float", "double", "decimal", "char", "bool", "byte", "short", "struct", "enum"
 Referans tipleri:  "string", "object", "class", "interface", "array", "delegate", "pointer" */

            byte a = 5; // 1 byte yer kaplar.  0 ile 255 arasındaki değerleri alabilir.
            sbyte b = 6; // 1 byte yer kaplar.-128 ile 127 arasındaki değerleri alabilir.

            short c = 7;// 2 byte yer kaplar. -32768 ile 32767 arasındaki değerleri alabilir.
            ushort d = 8;// 2 byte yer kaplar.  0 ile 65365 arasındaki değerleri alabilir.

            // Integer
            Int16 ff = 1; // 2 byte yer kaplar.
            int aa = 2; // 4 byte yer kaplar. -2.147.483.648 ile 2.147.483.647 arasındaki değerleri alabilir.
            Int32 rr = 3; // 4 byte yer kaplar.
            Int64 uu = 4;  // 8 byte yer kaplar. int'ten daha geniş.
             

            // Reel Sayılar
            float degisken1 = 9;// 4 byte yer kaplar.
            double degisken2 = 22;// 8 byte yer kaplar.
            decimal degisken3 = 05; // 16 byte yer kaplar.

            //
            char degisken4 = 'F';// 2 byte yer kaplar.tek bir karakteri tutar
            

            //
            bool b1 = true;
            bool b2 = false;


            //
            object o1 = 'y';// char.
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            // string

            string st1 = "";
            string st2 = null;
            string st3 = string.Empty;
            st3 = "Ömer Faruk Pala";// st3 değişkenine yeni atma yapıldı.

            string degisken5 = "Ömer Faruk";  // sınırsızdır.
            string degisken6 = "Pala";
            string tamIsim = degisken5 + " " + degisken6;

            // Dönüştürme

            string degisken7 = "10";
            int degisken8 = 99;
            string yeniDeger = degisken7 + degisken8.ToString(); //1099  yan yana gelme durumu.
            Console.WriteLine(yeniDeger);

            // Dönüştürme
            int degisken9 = degisken8 + Convert.ToInt32(degisken7);
            Console.WriteLine(degisken9);  // 109 bildiğimiz toplama durumu.

            int degisken10 = degisken8 + int.Parse(degisken7);// 109 int.Parse, içinde string olmalı
            Console.WriteLine(degisken10);


            // Tarih ve Saat
            DateTime dt = DateTime.Now;
            string monthYear0 = DateTime.Now.ToString("dd.MM.yyyy"); // günü, ayı ve yılı aralarına nokta koyarak getir.
            Console.WriteLine(monthYear0); // 23.03.2022


            string monthYear1 = DateTime.Now.ToString("HH:mm");// saati ve dakikayı aralarına : koyarak getir.
            Console.WriteLine(monthYear1);


// Atama ve İşlemli Atama

        int x = 7;
        int y = 9;

        x *=2; // x'i      2 ile çarp

        y = y+3; // y'ye     üç ekle.
        y += 2; // y'ye     2 ekle             işlemli atama
        y/=2; // y'yi     2'ye böl


        Console.WriteLine(x);
        Console.WriteLine(y);

// Mantıksal Operatörler
// ve &&  veya || değil !

        bool isSucces = true;
        bool isComleted = false;

        if(isSucces && isComleted){
            Console.WriteLine("Harika!"); // çalıştırmaz.
        }

        if(isSucces || isComleted){  // ikisinden biri true ise
            Console.WriteLine("Müthiş!");
        }

        if(isSucces && !isComleted){  //ilki true, ikincisi true değil ise
            Console.WriteLine("Harika!Müthiş!");
        }

// İlişkisel Operatörler
// >, <, <=, >=, ==, !=

        int a = 3;
        int b = 4;
        bool sonuc = a<b;// true
        Console.WriteLine(sonuc);

        sonuc = a>b;
        Console.WriteLine(sonuc);

        sonuc = a>=b;
        Console.WriteLine(sonuc);

        sonuc = a<=b;  // true
        Console.WriteLine(sonuc);

        sonuc = a==b;
        Console.WriteLine(sonuc);

        sonuc = a!=b;  // true
        Console.WriteLine(sonuc);

// Aritmetik Operatörler
// +, -, *, /,

        int sayi1 = 10;
        int sayi2 = 5;
        int sayi3 = 70;

        int  sonuc1 = sayi3/sayi1; // 7
        Console.WriteLine(sonuc1);

        int sonuc2 = sayi2 - sayi1; // -5
        Console.WriteLine(sonuc2);
        int sonuc3 = sayi2 * sayi1;// 50
        Console.WriteLine(sonuc3);
        int sonuc4 = sayi2 + sayi1;// 15
        Console.WriteLine(sonuc4);
        sayi3 += 1;// 71
        Console.WriteLine(sayi3);

        int sonuc5 = sayi3++;  // 72
        Console.WriteLine(sayi3);

        int sonuc17 = ++sayi3;//73  arttırma yapıldıktan sonra yazdırılırsa artırma görülür
        Console.WriteLine(sonuc17);


    // % mod alma

        int sonuc6 = 25 % 5;  // 0
        Console.WriteLine(sonuc6);
        int sonuc7 = 19 % 3;// 1
        Console.WriteLine(sonuc7);