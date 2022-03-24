/* Tanımlanan değişkene uygun olmayan veri tipinde bir değer atanması bellekte işlerin karışmasına neden olabilir.

 Implicit Conversion
     - Bir değişkenin kendinden daha yüksek kapasiteli bir değişkene atanmasıdır.
     - Hedef değişkenin veri tipi bellekte yeterli alana sahip olacağından, bu dönüşümde bir veri kaybı söz konusu olmayacaktır.
     - Float integer'a, integer da short veri tipine göre daha büyük sayıları saklayabilir. */


        sbyte bbb = 127;// 1 byte yer kaplar.
                        // -128 ile 127 arasındaki değerleri alabilir.

        byte aaa = 255; // 1 byte yer kaplar.
                        // 0 ile 255 arasındaki değerleri alabilir.

        short ccc = 32767;// 2 byte yer kaplar.     
                           // -32768 ile 32767 arasındaki değerleri alabilir.

        int intg1 = aaa + bbb + ccc; // 4 byte yer kaplar.
    Console.WriteLine("integer: " + intg1);  // -2.147.483.648 ile 2.147.483.647 arasındaki değerleri alabilir.

        long longg1 = intg1; // 8 byte yer kaplar
    Console.WriteLine("long: " + longg1); // –9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807 arasındaki değerleri alabilir.

        float floatt1 = longg1; // 4 byte yer kaplar.
    Console.WriteLine("float: " + floatt1); // reel sayıları tutar

        
    // string, char, integer, object

        string userName = "Faruk";
        char userCode = 'F';
        Object ooo = userName + userCode + intg1; // sorunsuz birleştirir.
    Console.WriteLine("Object: " + ooo);
    

// Explicit Conversion

        int A1 = 7;
        byte B1 = (byte)A1; // aşağıdan yukarıya bir dönüşüm.
     Console.WriteLine("1. byte: " + B1);

        float F1 = 10.3f;
        byte B2 = (byte)F1; // tam sayıya dönüştürmeye çalıştığı için veri kaybı yaşandı.
    Console.WriteLine("2. byte: " + B2);


    // ToString Metodu

        int A2 = 971;
        string ss1 = A2.ToString(); // string'e dönüştür
    Console.WriteLine("string ifade: " + ss1);

        string ss2 = 12.5f.ToString(); // float'ı string'e dönüştür
    Console.WriteLine("diğer string ifade: " + ss2);

    // System.Convert

        string ss3 = "11", ss4 = "12";
        int sayi1, sayi2;
        int toplam;

        sayi1 = Convert.ToInt32(ss3); //ss3'ü int32'ye çevirerek sayi1'e ata.
        sayi2 = Convert.ToInt32(ss4);
        toplam = sayi1 + sayi2;
    Console.WriteLine(toplam);

    // Parse

        string metin1 = "10";
        string metin2 = "10,25";
        int tamsayi1;
        double reel1;

        tamsayi1 = Int32.Parse(metin1); // tamsayi1 değişkenine, metin1 değişkeni Int32'ye dönüştürülerek atandı.
    Console.WriteLine(tamsayi1);  // Parse sadece string ifadeleri dönüştürür.
        reel1 = Double.Parse(metin2); // reel1 değişkenine, metin2 değişkeni Double'a dönüştürülerek atandı.
    Console.WriteLine(reel1);