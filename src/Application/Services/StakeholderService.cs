using Application.CQRS.Stakeholders.Commands;
using Application.CQRS.Stakeholders.Queries;
using Application.DTOs.StakeholderDto;
using Application.Interfaces;
using AutoMapper;
using MediatR;

namespace Application.Services;

public class StakeholderService : IStakeholderService
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public StakeholderService(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ReadStakeholdersDto>> GetStakeholdersAsync()
    {
        var stakeholdersQuery = new GetStakeholdersQuery();
        var result = await _mediator.Send(stakeholdersQuery);
        var stakeholders = _mapper.Map<IEnumerable<ReadStakeholdersDto>>(result);

        return stakeholders;
    }

    public async Task<ReadStakeholderDto> GetStakeholderByIdAsync(int id)
    {
        var stakeholderQuery = new GetStakeholderByIdQuery(id);
        var result = await _mediator.Send(stakeholderQuery);
        var stakeholder = _mapper.Map<ReadStakeholderDto>(result);

        return stakeholder;
    }

    public async Task<ResponseStakeholderDto> CreateStakeholderAsync(CreateStakeholderDto stakeholderDto)
    {
        var stakeholderCommand = _mapper.Map<StakeholderCreateCommand>(stakeholderDto);
        await _mediator.Send(stakeholderCommand);

        var stakeholderResponse = new ResponseStakeholderDto(stakeholderCommand.Id, stakeholderCommand.Name);

        return stakeholderResponse;
    }
}
