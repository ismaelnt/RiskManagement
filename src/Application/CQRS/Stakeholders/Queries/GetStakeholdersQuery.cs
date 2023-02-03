using Domain.Entities;
using MediatR;

namespace Application.CQRS.Stakeholders.Queries;

public class GetStakeholdersQuery : IRequest<List<Stakeholder>>, IRequest<Stakeholder>
{
}
