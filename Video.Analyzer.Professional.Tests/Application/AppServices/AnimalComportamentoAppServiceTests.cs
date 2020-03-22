using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video.Analyzer.Professional.Application.AppServices;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Application.ViewModels;
using Video.Analyzer.Professional.Domain.Entities;
using Video.Analyzer.Professional.Domain.Interfaces.Services;
using Video.Analyzer.Professional.Infra.Data.Interfaces;
using Video.Analyzer.Professional.Tests.Factory.Domain;
using Video.Analyzer.Professional.Tests.Factory.ViewModel;

namespace Video.Analyzer.Professional.Tests.Application.AppServices
{
    [TestClass]
    public class AnimalComportamentoAppServiceTests
    {
        private readonly IAnimalComportamentoService _animalComportamentoService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        private readonly IAnimalComportamentoAppService animalComportamentoAppService;

        public AnimalComportamentoAppServiceTests()
        {
            _animalComportamentoService = Substitute.For<IAnimalComportamentoService>();
            _mapper = Substitute.For<IMapper>();
            _uow = Substitute.For<IUnitOfWork>();
            animalComportamentoAppService = new AnimalComportamentoAppService(_uow, _mapper, _animalComportamentoService);
        }

        [TestMethod]
        public void DeveAdicionarUmNovoAnimalComportamento()
        {
            var idUsuario = Guid.NewGuid();
            var usuario = UsuarioFactory.CriarUmUsuarioValido(idUsuario);
            var usuarioViewModel = UsuarioViewModelFactory.CriarUmUsuarioValido(idUsuario);
            var animalComportamentoViewModel = AnimalComportamentoViewModelFactory.CriarUmAnimalComportamentoViewModel(usuarioViewModel);
            var animalComportamento = AnimalComportamentoFactory.CriarUmAnimalComportamento(usuario);

            _mapper.Map<AnimalComportamento>(animalComportamentoViewModel).Returns(animalComportamento);
            animalComportamentoAppService.Add(animalComportamentoViewModel);

            _animalComportamentoService.Received().Add(animalComportamento);
            _uow.Received().BeginTransaction();
        }

        [TestMethod]
        public void DeveDeletarComportamentoAnimal()
        {
            var idUsuario = Guid.NewGuid();
            var usuario = UsuarioFactory.CriarUmUsuarioValido(idUsuario);
            var usuarioViewModel = UsuarioViewModelFactory.CriarUmUsuarioValido(idUsuario);
            var animalComportamentoViewModel = AnimalComportamentoViewModelFactory.CriarUmAnimalComportamentoViewModel(usuarioViewModel);

            animalComportamentoAppService.DeleteComportamentoAnimal(animalComportamentoViewModel.IdAnimal);

            _animalComportamentoService.Received().DeleteComportamentoAnimal(animalComportamentoViewModel.IdAnimal);
            _uow.Received().BeginTransaction();
        }

        [TestMethod]
        public void DeveRealizarDispose()
        {
            animalComportamentoAppService.Dispose();
            _animalComportamentoService.Received().Dispose();
        }

        [TestMethod]
        public void DeveRetornarTodosOsRelatoriosComportamentaisLabirintoEmCruz_ReturnTodosOsRelatoriosDoUsuario()
        {
            var idUsuario = Guid.NewGuid();
            var idCaixa = Guid.NewGuid();
            var usuario = UsuarioFactory.CriarUmUsuarioValido(idUsuario);
            var usuarioViewModel = UsuarioViewModelFactory.CriarUmUsuarioValido(idUsuario);

            var listaAnimalComportamento = new List<AnimalComportamento> { AnimalComportamentoFactory.CriarUmAnimalComportamento(usuario) };
            var listaRelatorioComportamentoLabirintoEmCruz = new List<RelatorioComportamentoLabirintoEmCruz> { RelatorioComportamentoLabirintoEmCruzFactory.CriarUmRelatorioComportamentoLabirintoEmCruz() };

            _animalComportamentoService.GetAll(idCaixa, idUsuario, true).Returns(listaAnimalComportamento);
            _mapper.Map<IEnumerable<RelatorioComportamentoLabirintoEmCruz>>(listaAnimalComportamento).Returns(listaRelatorioComportamentoLabirintoEmCruz);
            var retorno = animalComportamentoAppService.GetAll(idCaixa, idUsuario, true);

            Assert.IsNotNull(retorno);
            Assert.AreEqual(listaRelatorioComportamentoLabirintoEmCruz, retorno);
            _mapper.Received().Map<IEnumerable<RelatorioComportamentoLabirintoEmCruz>>(listaAnimalComportamento);
            _animalComportamentoService.Received().GetAll(idCaixa, idUsuario, true);
        }

        [TestMethod]
        public void DeveRetornoarTodosAnimaisComportamentos_ReturnTodosAnimaisComportamentosEncontrados()
        {
            var idUsuario = Guid.NewGuid();
            var usuario = UsuarioFactory.CriarUmUsuarioValido(idUsuario);
            var usuarioViewModel = UsuarioViewModelFactory.CriarUmUsuarioValido(idUsuario);

            var listaAnimalComportamento = new List<AnimalComportamento> { AnimalComportamentoFactory.CriarUmAnimalComportamento(usuario) };
            var listaAnimalComportamentoViewModel = new List<AnimalComportamentoViewModel> { AnimalComportamentoViewModelFactory.CriarUmAnimalComportamentoViewModel(usuarioViewModel) };

            _animalComportamentoService.GetAll().Returns(listaAnimalComportamento);
            _mapper.Map<IEnumerable<AnimalComportamentoViewModel>>(listaAnimalComportamento).Returns(listaAnimalComportamentoViewModel);
            var retorno = animalComportamentoAppService.GetAll();

            Assert.IsNotNull(retorno);
            Assert.AreEqual(listaAnimalComportamentoViewModel, retorno);
            _mapper.Received().Map<IEnumerable<AnimalComportamentoViewModel>>(listaAnimalComportamento);
            _animalComportamentoService.Received().GetAll();
        }
    }
}