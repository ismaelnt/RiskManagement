using Application.CQRS.Stakeholders.Queries;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;

namespace Application.CQRS.Stakeholders.QueriesHandlers;

public class GetStakeholdersQueryHandler : IRequestHandler<GetStakeholdersQuery, IEnumerable<Stakeholder>>
{
    private readonly IStakeholderRepository _stakeholderRepository;

    public GetStakeholdersQueryHandler(IStakeholderRepository stakeholderRepository)
    {
        _stakeholderRepository = stakeholderRepository;
    }

    public async Task<IEnumerable<Stakeholder>> Handle(GetStakeholdersQuery request, CancellationToken cancellationToken)
    {
        var stakeholders = await _stakeholderRepository.GetAsync();

        return stakeholders;
    }
}
