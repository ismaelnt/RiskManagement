using Application.DTOs.InstitutionDto;
using Application.DTOs.PositionDto;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings;

public class PositionProfile : Profile
{
    public PositionProfile()
    {
        CreateMap<Position, ReadPositionDto>();
    }
}
