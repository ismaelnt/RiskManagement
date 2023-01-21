using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.EntitiesConfiguration;

public class StakeholderConfiguration : IEntityTypeConfiguration<Stakeholder>
{
    public void Configure(EntityTypeBuilder<Stakeholder> builder)
    {
        builder.HasKey(s => s.Id);
        
        builder.Property(s => s.CreatedAt).IsRequired();
        
        builder.Property(s => s.UpdatedAt);
        
        builder.Property(s => s.Name).HasColumnType("nvarchar(50)").IsRequired();
        
        builder.Property(s => s.Status).HasColumnType("tinyint").IsRequired();
        
        builder.OwnsOne(s => s.Address, a =>
        {
            a.Property(x => x.Country).HasColumnName("Country").HasColumnType("varchar(25)").IsRequired();
            a.Property(x => x.State).HasColumnName("State").HasColumnType("varchar(50)").IsRequired();
            a.Property(x => x.City).HasColumnName("City").HasColumnType("varchar(50)").IsRequired();
        });
        
        builder.OwnsOne(s => s.Email, e =>
        {
            e.Property(x => x.Address).HasColumnName("Email").HasColumnType("nvarchar(320)").IsRequired();
        });
        
        builder.OwnsOne(s => s.Phone, p =>
        {
            p.Property(x => x.Number).HasColumnName("Phone").HasColumnType("varchar(25)").IsRequired();
        });
        
        builder.OwnsOne(s => s.Website, w =>
        {
            w.Property(x => x.Url).HasColumnName("Website").HasColumnType("varchar(512)");
        });
        
        builder.Property(s => s.Responsible).HasColumnType("varchar(50)");
        
        builder.Property(s => s.AverageFavorability).HasColumnType("decimal(5,2)");

        builder.HasOne(s => s.Institution)
            .WithMany(i => i.Stakeholders)
            .HasForeignKey(s => s.InstitutionId);
        
        builder.HasOne(s => s.Position)
            .WithMany(p => p.Stakeholders)
            .HasForeignKey(s => s.PositionId);
    }
}
