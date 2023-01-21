namespace Domain.ValueObjects;

public class Address : ValueObject
{
    public Address()
    {
    }

    public Address(string country, string state, string city)
    {
        Country = country;
        State = state;
        City = city;
    }

    public string Country { get; }
    public string State { get; }
    public string City { get; }
}
