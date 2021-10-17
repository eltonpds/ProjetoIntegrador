using CarteiraVacinaDigital.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarteiraVacinaDigital.Repository.Configuration
{
    public class LogConfiguration : IEntityTypeConfiguration<Log>
    {
        public void Configure(EntityTypeBuilder<Log> builder)
        {
            builder.HasKey(l => l.Id);

            builder
                .Property(l => l.VaccineDate)
                .IsRequired();

            //builder
            //    .HasMany(l => l.Employees)
            //    .WithOne(e => e.Logs);

            //builder
            //    .HasMany(l => l.HealthPosts)
            //    .WithOne(h => h.Logs);

            //builder
            //    .HasMany(l => l.Pacients)
            //    .WithOne(p => p.Log);

            //builder
            //    .HasMany(l => l.Vaccines)
            //    .WithOne(v => v.Logs);
        }
    }
}
