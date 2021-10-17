using Newtonsoft.Json;
using System.Collections.Generic;

namespace CarteiraVacinaDigital.Model.Entities
{
    public class Responsible
    {
        public int Id { get; set; }
        public int ResponsibleID { get; set; }
        public int ChildrenID { get; set; }
        [JsonIgnore]
        public virtual ICollection<Pacient> Pacients { get; set; }
    }
}
