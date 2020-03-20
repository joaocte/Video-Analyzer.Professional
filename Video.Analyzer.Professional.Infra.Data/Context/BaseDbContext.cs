using System.Data.Entity;
using Video.Analyzer.Professional.Infra.Data.Interfaces;

namespace Video.Analyzer.Professional.Infra.Data.Context
{
    public class BaseDbContext : DbContext, IDbContext
    {
        public BaseDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}