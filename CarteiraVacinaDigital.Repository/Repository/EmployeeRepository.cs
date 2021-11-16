using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Model.Entities;
using CarteiraVacinaDigital.Repository.Context;
using System.Linq;

namespace CarteiraVacinaDigital.Repository.Repository
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(CarteiraVacinaDigitalContext carteiraVacinaDigitalContext) : base(carteiraVacinaDigitalContext)
        {
        }

        public Employee GetByCpf(string cpf)
        {
            return CarteiraVacinaDigitalContext.Employees.FirstOrDefault(e => e.Cpf == cpf);
        }

        public Employee Login(string email, string password)
        {
            return CarteiraVacinaDigitalContext.Employees.FirstOrDefault(e => e.Email == email && e.Password == password);
        }
    }
}
