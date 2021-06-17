using CarteiraVacinaDigital.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarteiraVacinaDigital.Model.Contracts
{
    public interface IPacientRepository : IBaseRepository<Pacient>
    {
        Pacient GetByCpf(string cpf);
    }
}
