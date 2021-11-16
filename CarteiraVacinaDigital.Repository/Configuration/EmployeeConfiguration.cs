using CarteiraVacinaDigital.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarteiraVacinaDigital.Repository.Configuration
{
    class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);

            builder
                .Property(e => e.Name)
                .IsRequired();

            builder
                .Property(e => e.Email)
                .IsRequired();

            builder
                .Property(e => e.Password)
                .IsRequired();

            builder
                .Property(e => e.Telefone)
                .IsRequired();

            builder
                .Property(e => e.Cpf)
                .IsRequired();

            builder
                .Property(e => e.Coren)
                .IsRequired();

            builder
                .Property(e => e.Adress)
                .IsRequired();

            builder
                .Property(e => e.District)
                .IsRequired();

            builder
                .Property(e => e.City)
                .IsRequired();

            builder
                .Property(e => e.State)
                .IsRequired();

            builder
                .Property(e => e.Cep)
                .IsRequired();

            builder
                .Property(e => e.Office)
                .IsRequired();
        }
    }
}
