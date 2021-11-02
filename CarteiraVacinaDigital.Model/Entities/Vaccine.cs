using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CarteiraVacinaDigital.Model.Entities
{
    public class Vaccine
    {
        public int Id { get; set; }
        public string FactoryName { get; set; }
        public string VaccineName { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime Validate { get; set; }
        public string Lote { get; set; }
        public virtual ICollection<VaccineHealthPost> VaccineHealthPosts { get; set; }
    }
}
