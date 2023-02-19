using Domain.Entities;
using Domain.Enums;
using Domain.ValueObjects;
using MediatR;

namespace Application.CQRS.Stakeholders.Commands;

public abstract class StakeholderCommand : IRequest<Stakeholder>
{
    public StakeholderCommand(
        string name,
        Status status,
        Email? email,
        Phone? phone,
        Website? website,
        Address address,
        string responsible,
        IList<int> themes,
        Institution institution,
        Position position
    )
    {
        CreatedAt = DateTime.Now;
        Name = name;
        Status = status;
        Email = email;
        Phone = phone;
        Website = website;
        AverageFavorability = 0;
        Address = address;
        Responsible = responsible;
        Themes = themes;
        Institution = institution;
        Position = position;
    }

    public DateTime CreatedAt { get; }
    public string Name { get; }
    public Status Status { get; }
    public Email? Email { get; }
    public Phone? Phone { get; }
    public Website? Website { get; }
    public decimal AverageFavorability { get; }
    public Address Address { get; }
    public string Responsible { get; }
    public IList<int> Themes { get; }
    public Institution Institution { get; }
    public Position Position { get; }
}
