using Domain.Entities;
using MediatR;

namespace Application.CQRS.Themes.Queries;

public class GetThemesQuery : IRequest<IEnumerable<Theme>>, IRequest<Theme>
{
}
