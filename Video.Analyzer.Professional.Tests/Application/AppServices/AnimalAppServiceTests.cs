using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using NSubstitute.Exceptions;
using System;
using Video.Analyzer.Professional.Application.AppServices;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Domain.Entities.Animal;
using Video.Analyzer.Professional.Domain.Interfaces.Services;
using Video.Analyzer.Professional.Infra.Data.Interfaces;
using Video.Analyzer.Professional.Tests.Factory.Domain;
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
        [ExpectedException(typeof(Exception))]
        public void AoTentarAdicionarUmNovoAnimalThrowAnyExceptionBeginTransaction_ThrowException()
        {
            var idUsuario = Guid.NewGuid();
            var usuarioViewModel = UsuarioViewModelFactory.CriarUmUsuarioValido(idUsuario);
            var usuario = UsuarioFactory.CriarUmUsuarioValido(idUsuario);

            var animalViewModel = AnimalViewModelFactory.CriarUmAnimal(usuarioViewModel);
            var animal = AnimalFactory.CriarUmAnimal(usuario);

            _uow.When(x => x.BeginTransaction()).Do(x => { throw new Exception(); });
            _mapper.Map<Animal>(animalViewModel).Returns(animal);

            animalAppService.Add(animalViewModel);

            _uow.Received().BeginTransaction();
            _mapper.DidNotReceive().Map<Animal>(animalViewModel);
            _animalService.DidNotReceive().Add(Arg.Any<Animal>());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AoTentarAdicionarUmNovoAnimalThrowAnyExceptionMap_ThrowException()
        {
            var idUsuario = Guid.NewGuid();
            var usuarioViewModel = UsuarioViewModelFactory.CriarUmUsuarioValido(idUsuario);
            var usuario = UsuarioFactory.CriarUmUsuarioValido(idUsuario);

            var animalViewModel = AnimalViewModelFactory.CriarUmAnimal(usuarioViewModel);
            var animal = AnimalFactory.CriarUmAnimal(usuario);

            _mapper.Map<Animal>(animalViewModel).Returns(x => { throw new Exception(); });

            animalAppService.Add(animalViewModel);

            _uow.Received().BeginTransaction();
            _mapper.Received().Map<Animal>(animalViewModel);
            _animalService.DidNotReceive().Add(Arg.Any<Animal>());
        }

        [TestMethod]
        public void DeveAdicionarUmNovoAnimal()
        {
            var idUsuario = Guid.NewGuid();
            var usuarioViewModel = UsuarioViewModelFactory.CriarUmUsuarioValido(idUsuario);
            var usuario = UsuarioFactory.CriarUmUsuarioValido(idUsuario);

            var animalViewModel = AnimalViewModelFactory.CriarUmAnimal(usuarioViewModel);
            var animal = AnimalFactory.CriarUmAnimal(usuario);

            _mapper.Map<Animal>(animalViewModel).Returns(animal);

            animalAppService.Add(animalViewModel);

            _uow.Received().BeginTransaction();
            _mapper.Received().Map<Animal>(animalViewModel);
            _animalService.Received().Add(Arg.Any<Animal>());
        }
    }
}