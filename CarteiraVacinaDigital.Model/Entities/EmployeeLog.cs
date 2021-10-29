using CarteiraVacinaDigital.Model.Entities.Enums;
using System;

namespace CarteiraVacinaDigital.Model.Entities
{
    public class EmployeeLog
    {
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public string Information { get; set; }
        public EmployeeLogAction Action { get; set; }
        public DateTime DateTime { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
