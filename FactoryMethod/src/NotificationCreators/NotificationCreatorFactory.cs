namespace FactoryMethod.NotificationCreators;

public static class NotificationCreatorFactory
{
    public static NotificationCreator GetCreator(
        string notificationType,
        string recipient,
        string subject,
        string message,
        bool isHtml = true,
        bool useTemplate = true)
    {
        return notificationType.ToLower() switch
        {
            "email"     => new EmailNotificationCreator(recipient, subject, message, isHtml: isHtml),
            "sms"       => new SmsNotificationCreator(recipient, message),
            "push"      => new PushNotificationCreator(recipient, subject, message, badge: 1),
            "whatsapp"  => new WhatsAppNotificationCreator(recipient, message, useTemplate: useTemplate),
            _           => throw new ArgumentException($"Tipo de notificação '{notificationType}' não suportado")
        };
    }
}
