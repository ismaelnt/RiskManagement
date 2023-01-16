using Domain.Exceptions;

namespace Domain.Entities;

public class Theme : Entity
{
    public Theme(string name)
    {
        Name = name;

        InvalidNameException.ThrowIfInvalid(name);
        InvalidNameException.ThrowIfIsTooShort(name);
        InvalidNameException.ThrowIfIsTooLong(name);
    }

    public string Name { get; }
}
