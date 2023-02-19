using Domain.Entities;
using Domain.Enums;
using Domain.ValueObjects;

namespace Application.CQRS.Stakeholders.Commands;

public class StakeholderCreateCommand : StakeholderCommand
{
    public StakeholderCreateCommand(
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
    ) : base(name, status, email, phone, website, address, responsible, themes, institution, position)
    {
    }

    public int Id { get; }
}
