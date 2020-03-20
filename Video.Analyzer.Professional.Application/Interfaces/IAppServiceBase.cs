namespace Video.Analyzer.Professional.Application.Interfaces
{
    public interface IAppServiceBase
    {
        void BeginTransaction();

        void Commit();
    }
}