using Domain.Exceptions;

namespace Domain.ValueObjects;

public class Phone : ValueObject
{
    public Phone(string number)
    {
        Number = number;
        InvalidPhoneException.ThrowIfInvalid(number);
    }

    public string Number { get; }
}
