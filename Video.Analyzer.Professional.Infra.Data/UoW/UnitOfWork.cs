using System;
using Video.Analyzer.Professional.Infra.Data.Interfaces;

namespace Video.Analyzer.Professional.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContext _dbContext;

        private bool _disposed;

        public UnitOfWork(IDbContext context)
        {
            _dbContext = context;
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }
    }
}