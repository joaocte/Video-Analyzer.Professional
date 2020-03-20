namespace Video.Analyzer.Professional.Infra.Data.Interfaces
{
    public interface IContextManager<TContext> where TContext : IDbContext, new()
    {
        IDbContext GetContext();
    }
}