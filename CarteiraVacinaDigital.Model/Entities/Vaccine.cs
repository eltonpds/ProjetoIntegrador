using System;
using System.Collections.Generic;
using System.Text;

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
        public Campaign Campaign { get; set; }
        public int CampaignId { get; set; }
    }
}
