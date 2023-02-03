using Domain.Entities;
using Domain.Enums;
using Domain.ValueObjects;

namespace Application.DTOs.StakeholderDto;

public class ReadStakeholdersDto
{
    public int Id { get; }
    public DateTime CreatedAt { get; }
    public DateTime UpdatedAt { get; }
    public string Name { get; }
    public Status Status { get; }
    public Email? Email { get; }
    public Phone? Phone { get; }
    public Website? Website { get; }
    public decimal AverageFavorability { get; }
    public Address Address { get; }
    public string Responsible { get; }
    public IList<StakeholderTheme> StakeholderThemes { get; }
    public Institution Institution { get; }
    public Position Position { get; }
}
