using Application.CQRS.Stakeholders.Commands;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;

namespace Application.CQRS.Stakeholders.CommandsHandlers;

public class StakeholderCreateCommandHandler : IRequestHandler<StakeholderCreateCommand, Stakeholder>
{
    private readonly IStakeholderRepository _stakeholderRepository;
    private readonly IInstitutionRepository _institutionRepository;
    private readonly IPositionRepository _positionRepository;

    public StakeholderCreateCommandHandler(
        IStakeholderRepository stakeholderRepository,
        IInstitutionRepository institutionRepository,
        IPositionRepository positionRepository
    )
    {
        _stakeholderRepository = stakeholderRepository;
        _institutionRepository = institutionRepository;
        _positionRepository = positionRepository;
    }

    public async Task<Stakeholder> Handle(StakeholderCreateCommand request, CancellationToken cancellationToken)
    {
        var stakeholder = new Stakeholder(
            request.Name,
            request.Status,
            request.Email,
            request.Phone,
            request.Website,
            request.Address,
            request.Responsible
        );

        if (stakeholder is null)
            throw new ApplicationException("Error creating stakeholder");

        var institution = await _institutionRepository.CreateIfNotExistsAsync(request.Institution);
        stakeholder.InstitutionId = institution.Id;

        var position = await _positionRepository.CreateIfNotExistsAsync(request.Position);
        stakeholder.PositionId = position.Id;

        stakeholder.StakeholderThemes = new List<StakeholderTheme>();
        foreach (var theme in request.Themes)
        {
            var stakeholderTheme = new StakeholderTheme
            {
                Stakeholder = stakeholder,
                Theme = theme
            };

            stakeholder.StakeholderThemes.Add(stakeholderTheme);
        }

        return await _stakeholderRepository.CreateAsync(stakeholder);
    }
}
