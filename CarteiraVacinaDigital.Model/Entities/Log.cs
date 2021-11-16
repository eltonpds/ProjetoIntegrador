using System;
using System.Collections.Generic;

namespace CarteiraVacinaDigital.Model.Entities
{
    public class Log
    {
        public int Id { get; set; }
        public virtual int IdPacient { get; set; }
        public virtual int IdVaccine { get; set; }
        public virtual int IdEmployee { get; set; }
        public virtual int IdHealthPost { get; set; }
        public DateTime VaccineDate { get; set; }
    }
}
