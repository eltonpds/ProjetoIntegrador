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
                .Property(p => p.Name);

            builder
                .Property(p => p.Email);

            builder
                .Property(p => p.Password);

            builder
                .Property(p => p.MotherName);

            builder
                .Property(p => p.FatherName);

            builder
                .Property(p => p.Cpf);

            builder
                .Property(p => p.CartaoSus);

            builder
                .Property(p => p.Adress);

            builder
                .Property(p => p.City);

            builder
                .Property(p => p.State);
        }
    }
}
