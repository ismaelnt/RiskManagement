using Domain.Entities;
using MediatR;

namespace Application.CQRS.Stakeholders.Queries;

public class GetStakeholdersQuery : IRequest<IEnumerable<Stakeholder>>, IRequest<Stakeholder>
{
}
