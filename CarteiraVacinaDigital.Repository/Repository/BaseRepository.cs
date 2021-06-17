using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Repository.Context;
using System.Collections.Generic;
using System.Linq;

namespace CarteiraVacinaDigital.Repository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly CarteiraVacinaDigitalContext CarteiraVacinaDigitalContext;
        public BaseRepository(CarteiraVacinaDigitalContext carteiraVacinaDigitalContext)
        {
            CarteiraVacinaDigitalContext = carteiraVacinaDigitalContext;
        }

        public void Insert(TEntity entity)
        {
            CarteiraVacinaDigitalContext.Set<TEntity>().Add(entity);
            CarteiraVacinaDigitalContext.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            CarteiraVacinaDigitalContext.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return CarteiraVacinaDigitalContext.Set<TEntity>().ToList();
        }
    }
}
