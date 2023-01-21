using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Institution> Institutions { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<Theme> Themes { get; set; }
    public DbSet<Stakeholder> Stakeholders { get; set; }
    public DbSet<StakeholderTheme> StakeholderThemes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
