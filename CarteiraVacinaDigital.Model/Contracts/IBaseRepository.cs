using System;
using System.Collections.Generic;

namespace CarteiraVacinaDigital.Model_.Contracts
{
    interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
    }
}
