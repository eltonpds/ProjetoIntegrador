using CarteiraVacinaDigital.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace CarteiraVacinaDigital.Repository.Configuration
{
    public class HealthPostConfiguration : IEntityTypeConfiguration<HealthPost>
    {
        public void Configure(EntityTypeBuilder<HealthPost> builder)
        {
            builder.HasKey(h => h.Id);

            builder
                .Property(h => h.HealthUnit)
                .IsRequired();

            builder
                .Property(h => h.SanitaryDistrict)
                .IsRequired();

            builder
                .Property(h => h.Address)
                .IsRequired();
        }
    }
}
