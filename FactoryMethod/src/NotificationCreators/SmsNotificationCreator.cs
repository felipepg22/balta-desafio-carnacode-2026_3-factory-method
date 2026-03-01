namespace FactoryMethod.NotificationCreators;

using FactoryMethod.Notifications;

public class SmsNotificationCreator : NotificationCreator
{
    public override INotification CreateNotification() =>
         new SmsNotification();
}
