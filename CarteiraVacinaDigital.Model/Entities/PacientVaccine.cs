using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarteiraVacinaDigital.Model.Entities
{
    public class PacientVaccine
    {
        public int ID { get; set; }
        public virtual int PacientID { get; set; }
        public virtual int VaccineID { get; set; }
        public DateTime DateVaccined { get; set; }
        public bool UniqueDose { get; set; }
        public int? Dose { get; set; }
        [NotMapped]
        public virtual Pacient Pacient { get; set; }
        [NotMapped]
        public virtual Vaccine Vaccine { get; set; }
    }
}
