using CarteiraVacinaDigital.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarteiraVacinaDigital.Repository.Configuration
{
    public class VaccineHealthPostConfiguration : IEntityTypeConfiguration<VaccineHealthPost>
    {
        public void Configure(EntityTypeBuilder<VaccineHealthPost> builder)
        {
            builder.HasKey(vh => new { vh.VaccineID, vh.HealthPostID });

            builder
                .HasOne(vh => vh.Vaccine)
                .WithMany(h => h.VaccineHealthPosts)
                .HasForeignKey(vh => vh.VaccineID);

            builder
                .HasOne(vh => vh.HealthPost)
                .WithMany(v => v.VaccineHealthPosts)
                .HasForeignKey(vh => vh.HealthPostID);
        }
    }
}
