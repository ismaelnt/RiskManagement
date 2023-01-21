using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities;

public class Stakeholder : Entity
{
    public Stakeholder()
    {
    }

    public Stakeholder(
        string name,
        Status status,
        Email? email,
        Phone? phone,
        Website? website,
        Address address,
        string responsible,
        IList<StakeholderTheme> stakeholderTheme,
        Institution institution,
        Position position
    )
    {
        Name = name;
        Status = status;
        Email = email;
        Phone = phone;
        Website = website;
        AverageFavorability = 0;
        Address = address;
        Responsible = responsible;
        StakeholderThemes = stakeholderTheme;
        Institution = institution;
        Position = position;
    }

    public string Name { get; }
    public Status Status { get; }
    public Email? Email { get; }
    public Phone? Phone { get; }
    public Website? Website { get; }
    public decimal AverageFavorability { get; }
    public Address Address { get; }
    public string Responsible { get; }
    public IList<StakeholderTheme> StakeholderThemes { get; }
    public int InstitutionId { get; set; }
    public Institution Institution { get; }
    public int PositionId { get; set; }
    public Position Position { get; }
}
