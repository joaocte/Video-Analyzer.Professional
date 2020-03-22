using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Application.Validation;
using Video.Analyzer.Professional.Domain.ValueObjects;
using Video.Analyzer.Professional.Infra.Data.Interfaces;

namespace Video.Analyzer.Professional.Application.AppServices
{
    public class AppServiceBase : IAppServiceBase
    {
        private readonly IUnitOfWork _uow;

        public AppServiceBase(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public virtual void BeginTransaction()
        {
            _uow.BeginTransaction();
        }

        public virtual void Commit()
        {
            _uow.SaveChanges();
        }
    }
}