using CarteiraVacinaDigital.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarteiraVacinaDigital.Repository.Configuration
{
    public class CampaignConfiguration : IEntityTypeConfiguration<Campaign>
    {
        public void Configure(EntityTypeBuilder<Campaign> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .Property(c => c.CampaignName)
                .IsRequired();

            builder
                .Property(c => c.Information)
                .IsRequired();

            builder
                .HasMany(c => c.Vaccine)
                .WithOne(v => v.Campaign);
        }
    }
}
