using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Model.Entities;
using CarteiraVacinaDigital.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
