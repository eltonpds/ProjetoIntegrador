using System;
using System.Collections.Generic;
using System.Text;

namespace CarteiraVacinaDigital.Model.Entities.ViewModel
{
    public class VaccineViewModel
    {
        public Vaccine Vaccine { get; set; }
        public ICollection<Campaign> Campaigns { get; set; }
    }
}
