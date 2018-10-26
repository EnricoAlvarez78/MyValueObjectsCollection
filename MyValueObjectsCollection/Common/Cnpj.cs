using DomainValidator.Validations;

namespace MyValueObjectsCollection.Common
{
    public class Cnpj : ValueObjectBase
    {
        public string Value { get; set; }

        public Cnpj() { }

        public Cnpj(string cnpjValue)
        {
            Value = cnpjValue;

            AddNotifications(new Validation().IsNotNullOrEmpty(Value, "Cnpj.Value"));
        }
    }
}
