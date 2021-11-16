using System.ComponentModel.DataAnnotations.Schema;

namespace CarteiraVacinaDigital.Model.Entities
{
    public class Calender
    {
        public int Id { get; set; }
        public string Information { get; set; }
        public string AgeGroup { get; set; }
        public virtual int VaccineId { get; set; }
        [NotMapped]
        public virtual Vaccine Vaccine { get; set; }
    }
}
