using DomainValidator.Validations;

namespace MyValueObjectsCollection.Email
{
    public class SmtpClientSettings : ValueObjectBase
    {
        public string Host { get; private set; }
        public string Port { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }

        public SmtpClientSettings(string host, string port, string userName, string password)
        {
            Host = host;
            Port = port;
            UserName = userName;
            Password = password;

            AddNotifications(
                new Validation().IsNotNullOrEmpty(Host, "SmtpClientSettings.Host"),
                new Validation().IsNotNullOrEmpty(Port, "SmtpClientSettings.Port"),
                new Validation().IsNotNullOrEmpty(UserName, "SmtpClientSettings.UserName"),
                new Validation().IsNotNullOrEmpty(Password, "SmtpClientSettings.Password"));
        }
    }
}
