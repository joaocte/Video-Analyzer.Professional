using System;
using System.Collections.Generic;

namespace Video.Analyzer.Professional.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        void Dispose();

        IEnumerable<TEntity> GetAll();

        TEntity GetById(Guid id);

        void Remove(TEntity obj);

        void Update(TEntity obj);

        //IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}