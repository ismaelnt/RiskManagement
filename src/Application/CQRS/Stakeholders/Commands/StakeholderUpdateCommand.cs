using Domain.Entities;
using Domain.Enums;
using Domain.ValueObjects;

namespace Application.CQRS.Stakeholders.Commands;

public class StakeholderUpdateCommand : StakeholderCommand
{
    public StakeholderUpdateCommand(int id, string name, Status status, Email? email, Phone? phone, Website? website,
        Address address, string responsible, IList<int> themes, Institution institution,
        Position position) : base(name, status, email, phone, website, address, responsible, themes, institution,
        position)
    {
        Id = id;
        UpdatedAt = DateTime.Now;
    }
    public int Id { get; }
    public DateTime UpdatedAt { get; }
}
