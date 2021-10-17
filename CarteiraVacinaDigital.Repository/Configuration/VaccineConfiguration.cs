using CarteiraVacinaDigital.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarteiraVacinaDigital.Repository.Configuration
{
    class VaccineConfiguration : IEntityTypeConfiguration<Vaccine>
    {
        public void Configure(EntityTypeBuilder<Vaccine> builder)
        {
            builder
                .Property(v => v.Id);

            builder
                .Property(v => v.VaccineName);

            builder
                .Property(v => v.FactoryName);

            builder
                .Property(v => v.Lote);

            builder
                .Property(v => v.Validate);

            builder
                .Property(v => v.ManufacturingDate);
        }
    }
}
