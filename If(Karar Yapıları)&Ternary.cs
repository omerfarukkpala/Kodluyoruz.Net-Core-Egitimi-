int time = DateTime.Now.Hour;               // saati aldık


if (time >= 6 && time < 10)                 // 06:00 ve 12:59 arası ise
    Console.WriteLine("Günaydın!");

else if (time<= 18)
    Console.WriteLine("İyi Günler!");

else
    Console.WriteLine("İyi Geceler!");


string demo1 = time<=18 ? "İyi Günler!" : "İyi Geceler!";
    Console.WriteLine(demo1);

string demo2 = time >= 12 && time < 14 ? "İyi öğlenler!" : time <= 18 ? "İyi Günler!" : "İyi Geceler!";
    Console.WriteLine(demo2);
