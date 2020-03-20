namespace Video.Analyzer.Professional.Infra.Data.Interfaces
{
    public interface IUnitOfWork
    {
        void BeginTransaction();

        void SaveChanges();
    }
}