namespace FactoryMethod.Notifications;

public class PushNotification : INotification
{
    public string DeviceToken { get; set; }
    public string Title { get; set; }
    public string Message { get; set; }
    public int Badge { get; set; }

    public void Send()
    {
        Console.WriteLine($"🔔 Enviando Push para dispositivo {DeviceToken}");
        Console.WriteLine($"   Título: {Title}");
        Console.WriteLine($"   Mensagem: {Message}");
    }
}
