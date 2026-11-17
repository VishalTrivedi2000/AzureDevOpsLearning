namespace MyLogger;


public class AppLogger
{
    public void LogInformation(string message)
    {
        Console.WriteLine(
            $"[{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss}] INFO: {message}");
    }

    public void LogError(string message)
    {
        Console.WriteLine(
            $"[{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss}] ERROR: {message}");
    }

    public void LogWarning(string message)
    {
        Console.WriteLine(
            $"[{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss}] WARNING: {message}");
    }
      public void LogWarning2(string message)
    {
        Console.WriteLine(
            $"[{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss}] WARNING: {message}");
    }
}

