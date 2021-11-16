using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Model.Entities;
using CarteiraVacinaDigital.Repository.Context;
using System.Collections.Generic;
using System.Linq;

namespace CarteiraVacinaDigital.Repository.Repository
{
    public class PacientVaccineRepository : BaseRepository<PacientVaccine>, IPacientVaccineRepository
    {
        public PacientVaccineRepository(CarteiraVacinaDigitalContext carteiraVacinaDigitalContext) : base(carteiraVacinaDigitalContext)
        {
        }
    }
}
