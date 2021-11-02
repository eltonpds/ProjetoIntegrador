using CarteiraVacinaDigital.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarteiraVacinaDigital.Repository.Configuration
{
    public class CalenderConfiguration : IEntityTypeConfiguration<Calender>
    {
        public void Configure(EntityTypeBuilder<Calender> builder)
        {
            builder
                .HasKey(c => c.Id);

            builder
                .Property(c => c.Information)
                .IsRequired();

            builder
                .Property(c => c.AgeGroup)
                .IsRequired();

            builder
                .Property(c => c.VaccineId)
                .IsRequired();

        }
    }
}
