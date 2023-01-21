using Domain.Exceptions;

namespace Domain.Entities;

public class Position : Entity
{
    public Position(string name)
    {
        Name = name;

        InvalidNameException.ThrowIfInvalid(name);
        InvalidNameException.ThrowIfIsTooShort(name);
        InvalidNameException.ThrowIfIsTooLong(name);
    }

    public string Name { get; }
    public IEnumerable<Stakeholder> Stakeholders { get; } = new List<Stakeholder>();
}
