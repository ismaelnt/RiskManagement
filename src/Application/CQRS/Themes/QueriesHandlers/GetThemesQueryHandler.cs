using Application.CQRS.Themes.Queries;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;

namespace Application.CQRS.Themes.QueriesHandlers;

public class GetThemesQueryHandler : IRequestHandler<GetThemesQuery, IEnumerable<Theme>>
{
    private readonly IThemeRepository _themeRepository;
    
    public GetThemesQueryHandler(IThemeRepository themeRepository)
    {
        _themeRepository = themeRepository;
    }
    
    public async Task<IEnumerable<Theme>> Handle(GetThemesQuery request, CancellationToken cancellationToken)
    {
        var themes = await _themeRepository.GetThemesAsync();
        
        return themes;
    }
}
