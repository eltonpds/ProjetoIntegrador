using CarteiraVacinaDigital.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarteiraVacinaDigital.Repository.Configuration
{
    class PacientVaccineConfiguration : IEntityTypeConfiguration<PacientVaccine>
    {
        public void Configure(EntityTypeBuilder<PacientVaccine> builder)
        {
            builder
                .HasKey(pv => new { pv.PacientID, pv.VaccineID });

            builder
                .Property(pv => pv.PacientID)
                .IsRequired();

            builder
                .Property(pv => pv.VaccineID)
                .IsRequired();

            builder
                .Property(pv => pv.DateVaccined)
                .IsRequired();

            builder
                .Property(pv => pv.UniqueDose)
                .IsRequired();

            builder
                .Property(pv => pv.Dose);

            builder
                .HasOne(pv => pv.Pacient)
                .WithMany(p => p.PacientVaccines);

            builder
                .HasOne(pv => pv.Vaccine)
                .WithMany(v => v.PacientVaccines);
        }
    }
}
