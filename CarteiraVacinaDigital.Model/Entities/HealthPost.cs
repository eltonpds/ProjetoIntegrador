using System;
using System.Collections.Generic;
using System.Text;

namespace CarteiraVacinaDigital.Model.Entities
{
    public class HealthPost
    {
        public int Id { get; set; }
        public string HealthUnit { get; set; }
        public string SanitaryDistrict { get; set; }
        public string Address { get; set; }
        public ICollection<Vaccine> Vaccines { get; set; }
    }
}
