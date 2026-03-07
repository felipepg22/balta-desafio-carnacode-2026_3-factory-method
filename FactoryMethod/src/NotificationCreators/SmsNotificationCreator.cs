namespace FactoryMethod.NotificationCreators;

using FactoryMethod.Notifications;

public class SmsNotificationCreator : NotificationCreator
{
    private readonly string _phoneNumber;
    private readonly string _message;

    public SmsNotificationCreator(string phoneNumber, string message)
    {
        _phoneNumber = phoneNumber;
        _message = message;
    }

    public override INotification CreateNotification() =>
        new SmsNotification
        {
            PhoneNumber = _phoneNumber,
            Message = _message
        };
}
