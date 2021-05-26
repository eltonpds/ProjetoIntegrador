namespace CarteiraVacinaDigital.Model_.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public string Coren { get; set; }
        public Cargo Perfil { get; set; }

    }
}
