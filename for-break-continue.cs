// Console'da verilen sayıya kadar olan tek sayıları yazdır.

Console.WriteLine("Kaça kadar tek sayıları yazdırmak istiyorsunuz?");       //istem


    // int okual = Console.ReadLine(); // Console'da string ifadeler okunur, alınır.
    int okual = int.Parse(Console.ReadLine()); // Parse edilmesi gerek.


    for (int i = 1; i <= okual; i++)
    {
        if(i%2 == 1)
            Console.WriteLine(i);
    }


