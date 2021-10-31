using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Model.Entities;
using CarteiraVacinaDigital.Repository.Context;

namespace CarteiraVacinaDigital.Repository.Repository
{
    public class CalenderRepository : BaseRepository<Calender>, ICalenderRepository
    {
        public CalenderRepository(CarteiraVacinaDigitalContext carteiraVacinaDigitalContext) : base(carteiraVacinaDigitalContext)
        {
        }
    }
}
