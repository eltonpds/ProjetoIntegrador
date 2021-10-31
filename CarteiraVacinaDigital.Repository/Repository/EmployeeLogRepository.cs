using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Model.Entities;
using CarteiraVacinaDigital.Repository.Context;
using System.Collections.Generic;

namespace CarteiraVacinaDigital.Repository.Repository
{
    public class EmployeeLogRepository : BaseRepository<EmployeeLog>, IEmployeeLogRepository
    {
        public EmployeeLogRepository(CarteiraVacinaDigitalContext carteiraVacinaDigitalContext) : base(carteiraVacinaDigitalContext)
        {
        }
    }
}
