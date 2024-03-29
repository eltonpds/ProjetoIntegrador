﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarteiraVacinaDigital.Model.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public string Information { get; set; }
        public virtual Vaccine Vaccine { get; set; }
        public virtual int VaccineId { get; set; }
    }
}
