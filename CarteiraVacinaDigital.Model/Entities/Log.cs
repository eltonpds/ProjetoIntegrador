using System;
using System.Collections.Generic;

namespace CarteiraVacinaDigital.Model.Entities
{
    public class Log
    {
        public int Id { get; set; }
        public virtual int IdPacient { get; set; }
        public virtual ICollection<Pacient> Pacients { get; set; }
        public virtual int IdVaccine { get; set; }
        public virtual ICollection<Vaccine> Vaccines { get; set; }
        public virtual int IdEmployee { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual int IdHealthPost { get; set; }
        public virtual ICollection<HealthPost> HealthPosts { get; set; }
        public DateTime VaccineDate { get; set; }
    }
}
