using Domain.Entities;
using MediatR;

namespace Application.CQRS.Stakeholders.Queries;

public class GetStakeholderByIdQuery : IRequest<Stakeholder>
{
    public int Id { get; }

    public GetStakeholderByIdQuery(int id)
    {
        Id = id;
    }
}
