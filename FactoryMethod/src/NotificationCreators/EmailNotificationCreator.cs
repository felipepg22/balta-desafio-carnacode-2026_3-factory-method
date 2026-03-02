namespace FactoryMethod.NotificationCreators;

using FactoryMethod.Notifications;

public class EmailNotificationCreator : NotificationCreator
{
    private readonly string _recipient;
    private readonly string _subject;
    private readonly string _body;
    private readonly bool _isHtml;

    public EmailNotificationCreator(string recipient, string subject, string body, bool isHtml = false)
    {
        _recipient = recipient;
        _subject = subject;
        _body = body;
        _isHtml = isHtml;
    }

    public override INotification CreateNotification() =>
        new EmailNotification
        {
            Recipient = _recipient,
            Subject = _subject,
            Body = _body,
            IsHtml = _isHtml
        };
}
