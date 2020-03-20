using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Video.Analyzer.Professional.Infra.Data.Interfaces
{
    public interface IDbContext
    {
        void Dispose();

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        int SaveChanges();

        IDbSet<T> Set<T>() where T : class;
    }
}