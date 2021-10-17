using System.Collections.Generic;

namespace CarteiraVacinaDigital.Model.Entities
{
    public class HealthPost
    {
        public int Id { get; set; }
        public string HealthUnit { get; set; }
        public string SanitaryDistrict { get; set; }
        public string Address { get; set; }
        public virtual Log Logs { get; set; }
        public virtual int LogsID { get; set; }
        public virtual ICollection<VaccineHealthPost> VaccineHealthPosts { get; set; }
    }
}
