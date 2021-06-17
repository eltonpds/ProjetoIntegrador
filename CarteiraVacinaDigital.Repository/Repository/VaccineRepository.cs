using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Model.Entities;
using CarteiraVacinaDigital.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarteiraVacinaDigital.Repository.Repository
{
    public class VaccineRepository : BaseRepository<Vaccine>, IVaccineRepository
    {
        public VaccineRepository(CarteiraVacinaDigitalContext carteiraVacinaDigitalContext) : base(carteiraVacinaDigitalContext)
        {
        }
    }
}
