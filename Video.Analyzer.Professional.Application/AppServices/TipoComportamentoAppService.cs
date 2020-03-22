using AutoMapper;
using System;
using System.Collections.Generic;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Application.ViewModels.Comportamento;
using Video.Analyzer.Professional.Domain.Entities.Comportamento;
using Video.Analyzer.Professional.Domain.Interfaces.Services;
using Video.Analyzer.Professional.Infra.Data.Interfaces;

namespace Video.Analyzer.Professional.Application.AppServices
{
    public class TipoComportamentoAppService : AppServiceBase, ITipoComportamentoAppService
    {
        private readonly IMapper _mapper;
        private readonly ITipoComportamentoService _tipoComportamentoService;
        private readonly IUnitOfWork _uow;

        public TipoComportamentoAppService(IMapper mapper, IUnitOfWork uow, ITipoComportamentoService tipoComportamentoService) : base(uow)
        {
            _mapper = mapper;
            _uow = uow;
            _tipoComportamentoService = tipoComportamentoService;
        }

        public void Add(TipoComportamentoViewModel obj)
        {
            var tipoComportamento = _mapper.Map<TipoComportamento>(obj);
            _uow.BeginTransaction();
            _tipoComportamentoService.Add(tipoComportamento);
            Commit();
        }

        public void Dispose()
        {
            _tipoComportamentoService.Dispose();
        }

        public IEnumerable<TipoComportamentoViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<TipoComportamentoViewModel>>(_tipoComportamentoService.GetAll());
        }
    }
}