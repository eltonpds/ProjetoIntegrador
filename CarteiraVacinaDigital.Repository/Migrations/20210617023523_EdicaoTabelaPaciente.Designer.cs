﻿// <auto-generated />
using System;
using CarteiraVacinaDigital.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarteiraVacinaDigital.Repository.Migrations
{
    [DbContext(typeof(CarteiraVacinaDigitalContext))]
    [Migration("20210617023523_EdicaoTabelaPaciente")]
    partial class EdicaoTabelaPaciente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CarteiraVacinaDigital.Model.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress");

                    b.Property<string>("Cep");

                    b.Property<string>("City");

                    b.Property<string>("Coren")
                        .IsRequired();

                    b.Property<string>("Cpf")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int>("Perfil");

                    b.Property<int>("State");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CarteiraVacinaDigital.Model.Entities.Pacient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress");

                    b.Property<string>("CartaoSus");

                    b.Property<string>("Cep");

                    b.Property<string>("City");

                    b.Property<string>("Cpf");

                    b.Property<string>("Email");

                    b.Property<string>("FatherName");

                    b.Property<string>("MotherName");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<int>("ScheduleId");

                    b.Property<int>("State");

                    b.HasKey("Id");

                    b.ToTable("Pacients");
                });

            modelBuilder.Entity("CarteiraVacinaDigital.Model.Entities.Vaccine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FactoryName");

                    b.Property<string>("Lote");

                    b.Property<DateTime>("ManufacturingDate");

                    b.Property<string>("VaccineName");

                    b.Property<DateTime>("Validate");

                    b.HasKey("Id");

                    b.ToTable("Vaccines");
                });
#pragma warning restore 612, 618
        }
    }
}
