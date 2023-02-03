using Application.CQRS.Stakeholders.Queries;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;

namespace Application.CQRS.Stakeholders.QueriesHandlers;

public class GetStakeholderByIdQueryHandler : IRequestHandler<GetStakeholderByIdQuery, Stakeholder>
{
    private readonly IStakeholderRepository _stakeholderRepository;

    public GetStakeholderByIdQueryHandler(IStakeholderRepository stakeholderRepository)
    {
        _stakeholderRepository = stakeholderRepository;
    }

    public async Task<Stakeholder> Handle(GetStakeholderByIdQuery request, CancellationToken cancellationToken)
    {
        var stakeholder = await _stakeholderRepository.GetByIdAsync(request.Id);
        if (stakeholder is null)
            throw new ApplicationException("Stakeholder not found");

        return stakeholder;
    }
}
