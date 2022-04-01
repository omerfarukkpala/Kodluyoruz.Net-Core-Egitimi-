
//Örnek interface tanımı:

public interface ILogger{
    //sadece imzası
    void WriteLog();
}

//Implementasyon:

public class FileLogger : ILogger
{
    public void WriteLog()
    {
        Console.WriteLine("Dosyaya yazdım.");
    }
}

public class DatabaseLogger : ILogger
{
    public void WriteLog()
    {
        Console.WriteLine("Database'e yazdım.");
    }
}