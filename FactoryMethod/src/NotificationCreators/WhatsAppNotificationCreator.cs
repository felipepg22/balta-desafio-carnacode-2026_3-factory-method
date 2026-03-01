namespace FactoryMethod.NotificationCreators;

using FactoryMethod.Notifications;

public class WhatsAppNotificationCreator : NotificationCreator
{
    public override INotification CreateNotification() =>
         new WhatsAppNotification();
}
