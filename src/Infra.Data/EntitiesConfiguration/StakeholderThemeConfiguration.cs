using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.EntitiesConfiguration;

public class StakeholderThemeConfiguration : IEntityTypeConfiguration<StakeholderTheme>
{
    public void Configure(EntityTypeBuilder<StakeholderTheme> builder)
    {
        builder.HasKey(st => new { st.StakeholderId, st.ThemeId });

        builder.HasOne<Stakeholder>(st => st.Stakeholder)
            .WithMany(s => s.StakeholderThemes)
            .HasForeignKey(st => st.StakeholderId);

        builder.HasOne<Theme>(st => st.Theme)
            .WithMany(t => t.StakeholderThemes)
            .HasForeignKey(st => st.ThemeId);
    }
}
