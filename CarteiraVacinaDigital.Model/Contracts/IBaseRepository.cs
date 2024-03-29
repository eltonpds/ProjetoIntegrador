﻿using System;
using System.Collections.Generic;

namespace CarteiraVacinaDigital.Model.Contracts
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void Insert(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
