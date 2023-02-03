using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities;

public class Stakeholder : Entity
{
    public Stakeholder()
    {
    }

    public Stakeholder(
        string requestName,
        Status requestStatus,
        Email? requestEmail,
        Phone? requestPhone,
        Website? requestWebsite,
        Address requestAddress,
        string requestResponsible
    )
    {
        Name = requestName;
        Status = requestStatus;
        Email = requestEmail;
        Phone = requestPhone;
        Website = requestWebsite;
        AverageFavorability = 0;
        Address = requestAddress;
        Responsible = requestResponsible;
    }

    public string Name { get; }
    public Status Status { get; }
    public Email? Email { get; }
    public Phone? Phone { get; }
    public Website? Website { get; }
    public decimal AverageFavorability { get; }
    public Address Address { get; }
    public string Responsible { get; }
    public IList<StakeholderTheme> StakeholderThemes { get; set; }
    public int InstitutionId { get; set; }
    public Institution Institution { get; }
    public int PositionId { get; set; }
    public Position Position { get; }
}
