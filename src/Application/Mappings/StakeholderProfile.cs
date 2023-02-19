using Application.CQRS.Stakeholders.Commands;
using Application.DTOs.StakeholderDto;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings;

public class StakeholderProfile : Profile
{
    public StakeholderProfile()
    {
        CreateMap<Stakeholder, ReadStakeholdersDto>();
        CreateMap<Stakeholder, ReadStakeholderDto>();
        CreateMap<CreateStakeholderDto, StakeholderCreateCommand>();
    }
}
