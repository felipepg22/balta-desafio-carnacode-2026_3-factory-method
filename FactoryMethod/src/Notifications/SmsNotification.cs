namespace FactoryMethod;

public class SmsNotification : INotification
{
    public string PhoneNumber { get; set; }
    public string Message { get; set; }
    public void Send()
    {
        Console.WriteLine($"📱 Enviando SMS para {PhoneNumber}");
        Console.WriteLine($"   Mensagem: {Message}");
    }
}
