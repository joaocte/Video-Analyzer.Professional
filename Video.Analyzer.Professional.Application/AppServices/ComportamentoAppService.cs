using AutoMapper;
using System;
using System.Collections.Generic;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Domain.Entities.Comportamento;
using Video.Analyzer.Professional.Domain.Interfaces.Services;
using Video.Analyzer.Professional.Infra.Data.Interfaces;
using ComportamentoViewModel = Video.Analyzer.Professional.Application.ViewModels.Comportamento.ComportamentoViewModel;

namespace Video.Analyzer.Professional.Application.AppServices
{
    public class ComportamentoAppService : AppServiceBase, IComportamentoAppService
    {
        private readonly IComportamentoService _comportamentoService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public ComportamentoAppService(IComportamentoService comportamentoService, IUnitOfWork uow, IMapper mapper) : base(uow)
        {
            _uow = uow;
            _mapper = mapper;
            _comportamentoService = comportamentoService;
        }

        public void Add(ComportamentoViewModel obj)
        {
            _uow.BeginTransaction();
            var comportamento = _mapper.Map<Comportamento>(obj);
            _comportamentoService.Add(comportamento);
            Commit();
        }

        public void Dispose()
        {
            _comportamentoService.Dispose();
        }

        public IEnumerable<ComportamentoViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<ComportamentoViewModel>>(_comportamentoService.GetAll());
        }

        public ComportamentoViewModel GetById(Guid id)
        {
            return _mapper.Map<ComportamentoViewModel>(_comportamentoService.GetById(id));
        }

        public void Remove(ComportamentoViewModel obj)
        {
            _uow.BeginTransaction();
            var comportamento = _mapper.Map<Comportamento>(obj);
            _comportamentoService.Remove(comportamento);
            Commit();
        }

        public void Update(ComportamentoViewModel obj)
        {
            _uow.BeginTransaction();
            var comportamento = _mapper.Map<Comportamento>(obj);
            _comportamentoService.Update(comportamento);
            Commit();
        }

        //public IEnumerable<ComportamentoViewModel> Find(Expression<Func<ComportamentoViewModel, bool>> predicate)
        //{
        //    return _comportamentoService.Find(predicate);
        //}
    }
}