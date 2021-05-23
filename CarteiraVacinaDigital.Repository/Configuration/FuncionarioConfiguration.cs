using CarteiraVacinaDigital.Model_.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarteiraVacinaDigital.Repository.Configuration
{
    class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.HasKey(f => f.Id);

            builder
                .Property(f => f.Nome)
                .IsRequired();

            builder
                .Property(f => f.Email)
                .IsRequired();

            builder
                .Property(f => f.Senha)
                .IsRequired();

            builder
                .Property(f => f.Cpf)
                .IsRequired();

            builder
                .Property(f => f.Coren)
                .IsRequired();
        }
    }
}
