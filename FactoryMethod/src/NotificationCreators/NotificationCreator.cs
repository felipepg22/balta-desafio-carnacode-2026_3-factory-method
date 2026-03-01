using FactoryMethod.Notifications;

namespace FactoryMethod.NotificationCreators;

public abstract class NotificationCreator
{
    public abstract INotification CreateNotification();

    public void Notify()
    {
        var notification = CreateNotification();
        notification.Send();
    }
}
