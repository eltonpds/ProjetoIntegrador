using CarteiraVacinaDigital.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarteiraVacinaDigital.Repository.Configuration
{
    public class ResponsibleConfiguration : IEntityTypeConfiguration<Responsible>
    {
        public void Configure(EntityTypeBuilder<Responsible> builder)
        {
            builder.HasKey(r => r.Id);

            builder
                .Property(r => r.ResponsibleID)
                .IsRequired();

            builder
                .Property(r => r.ChildrenID)
                .IsRequired();
                
        }
    }
}
