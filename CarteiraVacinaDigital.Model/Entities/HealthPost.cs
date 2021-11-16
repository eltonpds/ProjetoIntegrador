using CarteiraVacinaDigital.Model.Entities.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarteiraVacinaDigital.Model.Entities
{
    public class HealthPost
    {
        public int Id { get; set; }
        public string HealthUnit { get; set; }
        public string SanitaryDistrict { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public StateEnum State { get; set; }
        public virtual int LogsID { get; set; }
        [NotMapped]
        public virtual Log Logs { get; set; }
        [NotMapped]
        public virtual ICollection<VaccineHealthPost> VaccineHealthPosts { get; set; }
    }
}
