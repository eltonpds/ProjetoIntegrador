using CarteiraVacinaDigital.Model.Entities;
using CarteiraVacinaDigital.Repository.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CarteiraVacinaDigital.Repository.Context
{
    public class CarteiraVacinaDigitalContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Pacient> Pacients { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }

        public CarteiraVacinaDigitalContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new PacientConfiguration());
            modelBuilder.ApplyConfiguration(new VaccineConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }


}
