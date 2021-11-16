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
                .HasKey(pv => pv.ID);

            builder
                .Property(pv => pv.PacientID)
                .IsRequired();

            builder
                .Property(pv => pv.VaccineID)
                .IsRequired();
        }
    }
}
