using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Model_.Entities;

namespace CarteiraVacinaDigital.Model_.Contracts
{
    public interface IEmployeeRepository: IBaseRepository<Employee>
    {
        Employee GetByCpf(string cpf);
    }
}
