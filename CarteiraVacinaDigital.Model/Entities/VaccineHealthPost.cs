using System;
using System.Collections.Generic;
using System.Text;

namespace CarteiraVacinaDigital.Model.Entities
{
    public class VaccineHealthPost
    {
        public int VaccineID { get; set; }
        public virtual Vaccine Vaccine { get; set; }
        public int HealthPostID { get; set; }
        public virtual HealthPost HealthPost { get; set; }
    }
}
