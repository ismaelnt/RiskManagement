using Domain.Exceptions;

namespace Domain.ValueObjects;

public class Email : ValueObject
{
    public Email(string address)
    {
        Address = address;
        InvalidEmailException.ThrowIfInvalid(address);
    }

    public string Address { get; }
}
