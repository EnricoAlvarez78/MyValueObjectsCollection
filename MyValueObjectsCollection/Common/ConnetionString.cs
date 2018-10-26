using DomainValidator.Validations;

namespace MyValueObjectsCollection.Common
{
    public class ConnetionString : ValueObjectBase
    {
        public string Value { get; set; }

        public ConnetionString(string value)
        {
            Value = value;

            AddNotifications(new Validation().IsNotNullOrEmpty(Value, "PeopleNetConnetionString.Value"));
        }
    }
}
