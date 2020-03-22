using System;
using System.Collections.Generic;

namespace Video.Analyzer.Professional.Domain.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(Guid id);

        void Remove(TEntity obj);

        void Update(TEntity obj);
    }
}