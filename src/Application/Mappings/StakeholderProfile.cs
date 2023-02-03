using Application.CQRS.Stakeholders.Commands;
using Application.DTOs.StakeholderDto;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings;

public class StakeholderProfile : Profile
{
    public StakeholderProfile()
    {
        CreateMap<ReadStakeholdersDto, Stakeholder>();
        CreateMap<ReadStakeholderDto, Stakeholder>();
        CreateMap<CreateStakeholderDto, StakeholderCreateCommand>();
    }
}
