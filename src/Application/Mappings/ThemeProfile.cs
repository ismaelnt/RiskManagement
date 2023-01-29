using Application.DTOs.ThemeDto;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings;

public class ThemeProfile : Profile
{
    public ThemeProfile()
    {
        CreateMap<Theme, ReadThemesDto>();
    }
}
