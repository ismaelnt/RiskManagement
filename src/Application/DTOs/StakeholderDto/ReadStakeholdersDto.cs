using Application.DTOs.InstitutionDto;
using Application.DTOs.PositionDto;
using Domain.Entities;
using Domain.Enums;
using Domain.ValueObjects;

namespace Application.DTOs.StakeholderDto;

public class ReadStakeholdersDto
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string Name { get; set; }
    public Status Status { get; set; }
    public Email? Email { get; set; }
    public Phone? Phone { get; set; }
    public Website? Website { get; set; }
    public decimal AverageFavorability { get; set; }
    public Address Address { get; set; }
    public string Responsible { get; set; }
    public IEnumerable<Theme> Themes { get; set; }
    public ReadInstitutionDto Institution { get; set; }
    public ReadPositionDto Position { get; set; }
}
