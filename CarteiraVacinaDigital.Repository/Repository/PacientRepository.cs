using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Model.Entities;
using CarteiraVacinaDigital.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarteiraVacinaDigital.Repository.Repository
{
    public class PacientRepository : BaseRepository<Pacient>, IPacientRepository
    {
        public PacientRepository(CarteiraVacinaDigitalContext carteiraVacinaDigitalContext) : base(carteiraVacinaDigitalContext)
        {
        }
    }
}
