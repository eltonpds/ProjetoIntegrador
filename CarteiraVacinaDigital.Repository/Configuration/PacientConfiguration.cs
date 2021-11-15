using CarteiraVacinaDigital.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarteiraVacinaDigital.Repository.Configuration
{
    class PacientConfiguration : IEntityTypeConfiguration<Pacient>
    {
        public void Configure(EntityTypeBuilder<Pacient> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.Name)
                .IsRequired();

            builder
                .Property(p => p.Telefone)
                .IsRequired();

            builder
                .Property(p => p.Email)
                .IsRequired();

            builder
                .Property(p => p.Password)
                .IsRequired();

            builder
                .Property(p => p.MotherName)
                .IsRequired();

            builder
                .Property(p => p.FatherName);

            builder
                .Property(p => p.Cpf)
                .IsRequired();

            builder
                .Property(p => p.CartaoSus);

            builder
                .Property(p => p.Cep)
                .IsRequired();

            builder
                .Property(p => p.Adress)
                .IsRequired();

            builder
                .Property(p => p.District)
                .IsRequired();

            builder
                .Property(p => p.City)
                .IsRequired();

            builder
                .Property(p => p.State)
                .IsRequired();
        }
    }
}
