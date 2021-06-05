using CarteiraVacinaDigital.Model_.Contracts;
using CarteiraVacinaDigital.Model_.Entities;
using CarteiraVacinaDigital.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarteiraVacinaDigital.Repository.Repository
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(CarteiraVacinaDigitalContext carteiraVacinaDigitalContext) : base(carteiraVacinaDigitalContext)
        {
        }
    }
}
