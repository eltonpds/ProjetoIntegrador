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
        public DbSet<Responsible> Responsibles { get; set; }
        public DbSet<HealthPost> HealthPosts { get; set; }
        public DbSet<VaccineHealthPost> VaccineHealthPosts { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<EmployeeLog> EmployeeLogs { get; set; }
        public DbSet<Calender> Calenders { get; set; }

        public CarteiraVacinaDigitalContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CalenderConfiguration());
            modelBuilder.ApplyConfiguration(new CampaignConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeLogConfiguration());
            modelBuilder.ApplyConfiguration(new HealthPostConfiguration());
            modelBuilder.ApplyConfiguration(new LogConfiguration());
            modelBuilder.ApplyConfiguration(new ResponsibleConfiguration());
            modelBuilder.ApplyConfiguration(new PacientConfiguration());
            modelBuilder.ApplyConfiguration(new VaccineConfiguration());
            modelBuilder.ApplyConfiguration(new VaccineHealthPostConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }


}
