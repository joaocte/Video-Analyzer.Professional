using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Video.Analyzer.Professional.Application.AppServices;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Infra.Data.Interfaces;

namespace Video.Analyzer.Professional.Tests.Application.AppServices
{
    [TestClass]
    public class AppServiceBaseTests
    {
        private readonly IUnitOfWork _uow;
        private readonly IAppServiceBase appServiceBase;

        public AppServiceBaseTests()
        {
            _uow = Substitute.For<IUnitOfWork>();
            appServiceBase = new AppServiceBase(_uow);
        }

        [TestMethod]
        public void DeveRealizarAberturaDeTransacao()
        {
            appServiceBase.BeginTransaction();
            _uow.Received().BeginTransaction();
            _uow.DidNotReceive().SaveChanges();
        }

        [TestMethod]
        public void DeveRealizarCommit()
        {
            appServiceBase.Commit();
            _uow.DidNotReceive().BeginTransaction();
            _uow.Received().SaveChanges();
        }
    }
}