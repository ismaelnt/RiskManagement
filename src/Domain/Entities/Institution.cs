using Domain.Exceptions;

namespace Domain.Entities;

public class Institution : Entity
{
    public Institution(string name)
    {
        Name = name;

        InvalidNameException.ThrowIfInvalid(name);
        InvalidNameException.ThrowIfIsTooShort(name);
        InvalidNameException.ThrowIfIsTooLong(name);
    }

    public string Name { get; }
}