using System;
using System.Collections.Generic;
using System.Text;

namespace CarteiraVacinaDigital.Model.Entities.ViewModel
{
    public class ScheduleViewModel
    {
        public Schedule Schedule { get; set; }
        public Vaccine Vaccine { get; set; }
        public Pacient Pacient { get; set; }
    }
}
