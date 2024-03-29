﻿using CarteiraVacinaDigital.Model.Entities.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarteiraVacinaDigital.Model.Entities
{
    public class Pacient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Cpf { get; set; }
        public string CartaoSus { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public string Telefone { get; set; }
        public string Adress { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public StateEnum State { get; set; }
        public string Cep { get; set; }
        [NotMapped]
        [JsonIgnore]
        public virtual IEnumerable<PacientVaccine> PacientVaccines { get; set; }

    }
}
