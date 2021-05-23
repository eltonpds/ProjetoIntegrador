using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Repository.Context;
using System.Collections.Generic;

namespace CarteiraVacinaDigital.Repository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly CarteiraVacinaDigitalContext CarteiraVacinaDigitalContext;
        public BaseRepository(CarteiraVacinaDigitalContext carteiraVacinaDigitalContext)
        {
            CarteiraVacinaDigitalContext = carteiraVacinaDigitalContext;
        }

        public void Adicionar(TEntity entity)
        {
            CarteiraVacinaDigitalContext.Set<TEntity>().Add(entity);
            CarteiraVacinaDigitalContext.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            CarteiraVacinaDigitalContext.Dispose();
        }
    }
}
