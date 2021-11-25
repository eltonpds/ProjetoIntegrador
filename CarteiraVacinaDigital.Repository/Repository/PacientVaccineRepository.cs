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

        public PacientVaccine GetByPacientAndVaccine(int pacientId, int vaccineId, int? vaccineDose, bool uniqueDose)
        {
            return CarteiraVacinaDigitalContext.PacientVaccines.FirstOrDefault(pv => pv.Pacient.Id == pacientId && pv.Vaccine.Id == vaccineId && pv.Dose == vaccineDose && pv.UniqueDose == uniqueDose);
        }
    }
}
