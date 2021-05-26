using System;
using System.Collections.Generic;
using System.Text;

namespace CarteiraVacinaDigital.Model.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public string Information { get; set; }
        public ICollection<Vaccine> Vaccine { get; set; }
        public int VaccineId { get; set; }
    }
}
