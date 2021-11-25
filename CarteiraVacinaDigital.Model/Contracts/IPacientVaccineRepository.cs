using CarteiraVacinaDigital.Model.Entities;

namespace CarteiraVacinaDigital.Model.Contracts
{
    public interface IPacientVaccineRepository : IBaseRepository<PacientVaccine>
    {
        PacientVaccine GetByPacientAndVaccine(int pacientId, int vaccineId, int? dose, bool uniqueDose);
    }
}
