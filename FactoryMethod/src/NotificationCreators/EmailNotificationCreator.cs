namespace FactoryMethod.NotificationCreators;

using FactoryMethod.Notifications;

public class EmailNotificationCreator : NotificationCreator
{
    public override INotification CreateNotification() =>
         new EmailNotification();
}
