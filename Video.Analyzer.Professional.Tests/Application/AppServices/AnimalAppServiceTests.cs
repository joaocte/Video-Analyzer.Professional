using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Video.Analyzer.Professional.Application.AppServices;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Domain.Entities.Animal;
using Video.Analyzer.Professional.Domain.Interfaces.Services;
using Video.Analyzer.Professional.Infra.Data.Interfaces;
using Video.Analyzer.Professional.Tests.Factory.ViewModel;

namespace Video.Analyzer.Professional.Tests.Application.AppServices
{
    [TestClass]
    public class AnimalAppServiceTests
    {
        private readonly IAnimalService _animalService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        private readonly IAnimalAppService animalAppService;

        public AnimalAppServiceTests()
        {
            _animalService = Substitute.For<IAnimalService>();
            _mapper = Substitute.For<IMapper>();
            _uow = Substitute.For<IUnitOfWork>();
            animalAppService = new AnimalAppService(_animalService, _uow, _mapper);
        }

        [TestMethod]
        public void DeveAdicionarUmNovoAnimal()
        {
            var usuarioViewModel = UsuarioViewModelFactory.CriarUmUsuarioValido();
            var animalViewModel = AnimalViewModelFactory.CriarUmAnimal(usuarioViewModel);

            animalAppService.Add(animalViewModel);

            _uow.Received().BeginTransaction();
            _mapper.Received().Map<Animal>(animalViewModel);
            _animalService.Received().Add(Arg.Any<Animal>());
        }
    }
}