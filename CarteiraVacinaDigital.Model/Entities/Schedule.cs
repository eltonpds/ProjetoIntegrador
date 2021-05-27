using System;
using System.Collections.Generic;
using System.Text;

namespace CarteiraVacinaDigital.Model.Entities
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateTime DateSchedule { get; set; }
        public ICollection<Pacient> Pacients { get; set; }
        public int PacientId { get; set; }
        public ICollection<Vaccine> Vaccines { get; set; }
        public int VaccineId { get; set; }
    }
}
