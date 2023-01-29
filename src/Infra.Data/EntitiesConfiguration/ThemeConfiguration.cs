using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.EntitiesConfiguration;

public class ThemeConfiguration : IEntityTypeConfiguration<Theme>
{
    public void Configure(EntityTypeBuilder<Theme> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Name).IsRequired().HasMaxLength(50);
        builder.Property(t => t.CreatedAt).IsRequired();
        builder.Property(t => t.UpdatedAt);

        builder.HasData(
            new Theme(1, "Ambietal"),
            new Theme(2, "Financeiro"),
            new Theme(3, "Corporate Affairs"),
            new Theme(4, "Tributário e Fiscal"),
            new Theme(5, "Social"),
            new Theme(6, "Infraestrutura e Logística"),
            new Theme(7, "Outros")
        );
    }
}
