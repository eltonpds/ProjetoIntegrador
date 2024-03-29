﻿using CarteiraVacinaDigital.Model.Entities;

namespace CarteiraVacinaDigital.Model.Contracts
{
    public interface IEmployeeRepository: IBaseRepository<Employee>
    {
        Employee GetByCpf(string cpf);
        Employee Login(string email, string password);
    }
}
