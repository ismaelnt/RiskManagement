using Application.CQRS.Themes.Queries;
using Application.DTOs.ThemeDto;
using Application.Interfaces;
using AutoMapper;
using MediatR;

namespace Application.Services;

public class ThemeService : IThemeService
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public ThemeService(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ReadThemesDto>> GetThemesAsync()
    {
        var themesQuery = new GetThemesQuery();
        var result = await _mediator.Send(themesQuery);
        var themes = _mapper.Map<IEnumerable<ReadThemesDto>>(result);

        return themes;
    }
}
