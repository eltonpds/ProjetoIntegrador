using CarteiraVacinaDigital.Model_.Entities;

using Microsoft.EntityFrameworkCore;

namespace CarteiraVacinaDigital.Repository.Context
{
    public class CarteiraVacinaDigitalContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }

        public CarteiraVacinaDigitalContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }


}
