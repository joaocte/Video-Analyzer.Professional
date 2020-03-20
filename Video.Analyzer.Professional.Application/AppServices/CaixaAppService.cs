using AutoMapper;
using System;
using System.Collections.Generic;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Domain.Entities.Caixa;
using Video.Analyzer.Professional.Domain.Interfaces.Services;
using Video.Analyzer.Professional.Infra.Data.Interfaces;
using CaixaViewModel = Video.Analyzer.Professional.Application.ViewModels.Caixa.CaixaViewModel;

namespace Video.Analyzer.Professional.Application.AppServices
{
    public class CaixaAppService : AppServiceBase, ICaixaAppService
    {
        private readonly ICaixaService _caixaService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CaixaAppService(ICaixaService caixaService, IUnitOfWork uow, IMapper mapper) : base(uow)
        {
            _caixaService = caixaService;
            _uow = uow;
            _mapper = mapper;
        }

        public void Add(CaixaViewModel obj)
        {
            _uow.BeginTransaction();
            var caixa = _mapper.Map<Caixa>(obj);
            _caixaService.Add(caixa);
            Commit();
        }

        public void Dispose()
        {
            _caixaService.Dispose();
        }

        public IEnumerable<CaixaViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<CaixaViewModel>>(_caixaService.GetAll());
        }

        public CaixaViewModel GetById(Guid id)
        {
            return _mapper.Map<CaixaViewModel>(_caixaService.GetById(id));
        }

        public void Remove(CaixaViewModel obj)
        {
            _uow.BeginTransaction();
            var caixa = _mapper.Map<Caixa>(obj);
            _caixaService.Remove(caixa);
            Commit();
        }

        public void Update(CaixaViewModel obj)
        {
            _uow.BeginTransaction();
            var caixa = _mapper.Map<Caixa>(obj);
            _caixaService.Update(caixa);
            Commit();
        }

        //public IEnumerable<CaixaViewModel> Find(Expression<Func<CaixaViewModel, bool>> predicate)
        //{
        //    return _caixaService.Find(predicate);
        //}
    }
}