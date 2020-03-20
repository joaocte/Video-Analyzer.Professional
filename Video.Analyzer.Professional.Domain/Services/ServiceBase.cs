using System;
using System.Collections.Generic;
using Video.Analyzer.Professional.Domain.Interfaces.Repository;
using Video.Analyzer.Professional.Domain.Interfaces.Services;

namespace Video.Analyzer.Professional.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual TEntity GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public virtual void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public virtual void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        //public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        //{
        //   return _repository.Find(predicate);
        //}
    }
}