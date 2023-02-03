using Domain.Exceptions;

namespace Domain.Entities;

public class Theme : Entity
{
    public Theme(int id, string name)
    {
        Id = id;
        Name = name;

        InvalidNameException.ThrowIfInvalid(name);
        InvalidNameException.ThrowIfIsTooShort(name);
        InvalidNameException.ThrowIfIsTooLong(name);
    }

    public Theme(string name)
    {
        Name = name;

        InvalidNameException.ThrowIfInvalid(name);
        InvalidNameException.ThrowIfIsTooShort(name);
        InvalidNameException.ThrowIfIsTooLong(name);
    }

    public string Name { get; }
    public IList<StakeholderTheme> StakeholderThemes { get; } = new List<StakeholderTheme>();
}
