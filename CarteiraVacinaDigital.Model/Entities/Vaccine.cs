﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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
        public int? Dose { get; set; }
        public bool UniqueDose { get; set; }
        [NotMapped]
        [JsonIgnore]
        public virtual Calender Calender { get; set; }
        [NotMapped]
        public virtual ICollection<VaccineHealthPost> VaccineHealthPosts { get; set; }
        [NotMapped]
        [JsonIgnore]
        public virtual IEnumerable<PacientVaccine> PacientVaccines { get; set; }
    }
}
