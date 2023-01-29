using Application.Interfaces;
using Application.Mappings;
using Application.Services;
using Domain.Interfaces;
using Infra.Data.Context;
using Infra.Data.Repositories;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Infra.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection service, IConfiguration configuration)
    {
        service.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

        service.AddScoped<IStakeholderRepository, StakeholderRepository>();
        service.AddScoped<IInstitutionRepository, InstitutionRepository>();
        service.AddScoped<IPositionRepository, PositionRepository>();
        service.AddScoped<IThemeRepository, ThemeRepository>();

        service.AddScoped<IStakeholderService, StakeholderService>();
        service.AddScoped<IThemeService, ThemeService>();

        service.AddAutoMapper(typeof(StakeholderProfile));
        service.AddAutoMapper(typeof(ThemeProfile));

        var myHandlers = AppDomain.CurrentDomain.Load("Application");
        service.AddMediatR(myHandlers);

        return service;
    }
}
