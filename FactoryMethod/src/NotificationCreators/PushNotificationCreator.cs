namespace FactoryMethod.NotificationCreators;

using FactoryMethod.Notifications;

public class PushNotificationCreator : NotificationCreator
{
    public override INotification CreateNotification() =>
         new PushNotification();
}
