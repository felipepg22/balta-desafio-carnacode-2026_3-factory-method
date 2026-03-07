using FactoryMethod.Notifications.Enums;

namespace FactoryMethod.NotificationCreators;

public static class NotificationCreatorFactory
{
    public static NotificationCreator GetCreator(
        NotificationType notificationType,
        string recipient,
        string subject,
        string message,
        bool isHtml = true,
        bool useTemplate = true)
    {
        return notificationType switch
        {
            NotificationType.Email    => new EmailNotificationCreator(recipient, subject, message, isHtml: isHtml),
            NotificationType.Sms      => new SmsNotificationCreator(recipient, message),
            NotificationType.Push     => new PushNotificationCreator(recipient, subject, message, badge: 1),
            NotificationType.WhatsApp => new WhatsAppNotificationCreator(recipient, message, useTemplate: useTemplate),
            _                         => throw new ArgumentException($"Tipo de notificação '{notificationType}' não suportado")
        };
    }
}
