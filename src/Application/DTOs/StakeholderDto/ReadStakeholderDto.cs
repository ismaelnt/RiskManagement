using Domain.Entities;
using Domain.Enums;
using Domain.ValueObjects;

namespace Application.DTOs.StakeholderDto;

public class ReadStakeholderDto
{
    public string Name { get; }
    public Status Status { get; }
    public Email? Email { get; }
    public Phone? Phone { get; }
    public Website? Website { get; }
    public decimal AverageFavorability { get; }
    public Address Address { get; }
    public string Responsible { get; }
    public IList<StakeholderTheme> StakeholderThemes { get; }
    public int InstitutionId { get; }
    public Institution Institution { get; }
    public int PositionId { get; set; }
    public Position Position { get; }
}
