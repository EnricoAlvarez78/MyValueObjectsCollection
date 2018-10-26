using DomainValidator.Notifications;
using DomainValidator.Validations;
using System.Linq;

namespace MyValueObjectsCollection.Email
{
    public class EmailSettings : ValueObjectBase
    {

        public string From { get; private set; }

        public string[] To { get; private set; }

        public string Subject { get; private set; }

        public string Body { get; private set; }

        public EmailSettings(string from, string[] to, string subject, string body)
        {
            From = from;
            To = to;
            Subject = subject;
            Body = body;

            AddNotifications(
                new Validation().IsNotNull(To, "EmailSettings.To"),
                new Validation().IsNotNullOrEmpty(From, "EmailSettings.From"),
                new Validation().IsNotNullOrEmpty(Subject, "EmailSettings.Subject"),
                new Validation().IsNotNullOrEmpty(Body, "EmailSettings.Body"));

            if (To != null && !To.Any())
                AddNotification(new Notification("EmailSettings.To", "O valor do parametro To não pode ser vazio"));
        }
    }
}
