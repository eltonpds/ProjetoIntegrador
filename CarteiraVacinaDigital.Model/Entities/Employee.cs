using CarteiraVacinaDigital.Model.Entities.Enums;

namespace CarteiraVacinaDigital.Model.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Cpf { get; set; }
        public string Coren { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public StateEnum State { get; set; }
        public string Cep { get; set; }
        public OfficeEnum Perfil { get; set; }
        public virtual Log Logs { get; set; }
        public virtual int LogId { get; set; }

    }
}
