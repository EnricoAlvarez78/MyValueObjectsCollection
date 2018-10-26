using DomainValidator.Validations;

namespace MyValueObjectsCollection.Common
{
    public class Cpf : ValueObjectBase
    {
        public string Value { get; set; }

        public Cpf() { }

        public Cpf(string cpfValue)
        {
            Value = cpfValue;

            AddNotifications(
                new Validation().IsNotNullOrEmpty(Value, "Cpf.Value"),
                new Validation().IsBetween(Value.Length, 1, 11, "Cpf.Value", "O valor do parametro Cpf.Value deve possuir de 1(um) a 11(onze) caracteres."));
        }
    }
}
