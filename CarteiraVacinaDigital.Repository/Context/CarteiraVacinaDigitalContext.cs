using CarteiraVacinaDigital.Model_.Entities;
using CarteiraVacinaDigital.Repository.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CarteiraVacinaDigital.Repository.Context
{
    public class CarteiraVacinaDigitalContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public CarteiraVacinaDigitalContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }


}
