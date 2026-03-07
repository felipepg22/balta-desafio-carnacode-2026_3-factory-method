namespace FactoryMethod.NotificationCreators;

using FactoryMethod.Notifications;

public class WhatsAppNotificationCreator : NotificationCreator
{
    private readonly string _phoneNumber;
    private readonly string _message;
    private readonly bool _useTemplate;

    public WhatsAppNotificationCreator(string phoneNumber, string message, bool useTemplate = false)
    {
        _phoneNumber = phoneNumber;
        _message = message;
        _useTemplate = useTemplate;
    }

    public override INotification CreateNotification() =>
        new WhatsAppNotification
        {
            PhoneNumber = _phoneNumber,
            Message = _message,
            UseTemplate = _useTemplate
        };
}
