using Application.DTOs.InstitutionDto;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings;

public class InstitutionProfile : Profile
{
    public InstitutionProfile()
    {
        CreateMap<Institution, ReadInstitutionDto>();
    }
}
