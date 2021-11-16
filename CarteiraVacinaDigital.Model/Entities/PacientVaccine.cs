using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarteiraVacinaDigital.Model.Entities
{
    public class PacientVaccine
    {
        public int ID { get; set; }
        public int PacientID { get; set; }
        public int VaccineID { get; set; }
        [NotMapped]
        public virtual IEnumerable<Pacient> Pacient { get; set; }
        [NotMapped]
        public virtual IEnumerable<Vaccine> Vaccine { get; set; }
    }
}
