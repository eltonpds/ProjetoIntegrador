using System;
using System.Collections.Generic;
using System.Text;

namespace CarteiraVacinaDigital.Model.Entities
{
    public class Calender
    {
        public int Id { get; set; }
        public string Information { get; set; }
        public Vaccine Vaccine { get; set; }
        public int VaccineId { get; set; }
    }
}
