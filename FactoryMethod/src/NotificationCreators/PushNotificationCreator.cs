namespace FactoryMethod.NotificationCreators;

using FactoryMethod.Notifications;

public class PushNotificationCreator : NotificationCreator
{
    private readonly string _deviceToken;
    private readonly string _title;
    private readonly string _message;
    private readonly int _badge;

    public PushNotificationCreator(string deviceToken, string title, string message, int badge = 0)
    {
        _deviceToken = deviceToken;
        _title = title;
        _message = message;
        _badge = badge;
    }

    public override INotification CreateNotification() =>
        new PushNotification
        {
            DeviceToken = _deviceToken,
            Title = _title,
            Message = _message,
            Badge = _badge
        };
}
