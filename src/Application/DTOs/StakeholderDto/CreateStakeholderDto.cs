using Domain.Entities;
using Domain.Enums;
using Domain.ValueObjects;

namespace Application.DTOs.StakeholderDto;

public class CreateStakeholderDto
{
    public string Name { get; set; }
    public Status Status { get; set; }
    public Email? Email { get; set; }
    public Phone? Phone { get; set; }
    public Website? Website { get; set; }
    public Address Address { get; set; }
    public string Responsible { get; set; }
    public IList<int> Themes { get; set; }
    public Institution Institution { get; set; }
    public Position Position { get; set; }
}
