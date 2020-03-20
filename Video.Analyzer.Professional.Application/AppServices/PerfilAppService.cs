using AutoMapper;
using System;
using System.Collections.Generic;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Domain.Entities.Configuracao;
using Video.Analyzer.Professional.Domain.Interfaces.Services;
using Video.Analyzer.Professional.Infra.Data.Interfaces;
using PerfilViewModel = Video.Analyzer.Professional.Application.ViewModels.Configuracao.PerfilViewModel;

namespace Video.Analyzer.Professional.Application.AppServices
{
    public class PerfilAppService : AppServiceBase, IPerfilAppService
    {
        private readonly IMapper _mapper;
        private readonly IPerfilService _perfilService;
        private readonly IUnitOfWork _uow;

        public PerfilAppService(IPerfilService perfilService, IUnitOfWork uow, IMapper mapper) : base(uow)
        {
            _perfilService = perfilService;
            _uow = uow;
            _mapper = mapper;
        }

        public void Add(PerfilViewModel obj)
        {
            _uow.BeginTransaction();
            var perfil = _mapper.Map<Perfil>(obj);
            _perfilService.Add(perfil);
            Commit();
        }

        public void Dispose()
        {
            _perfilService.Dispose();
        }

        public IEnumerable<PerfilViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<PerfilViewModel>>(_perfilService.GetAll());
        }

        public PerfilViewModel GetById(Guid id)
        {
            return _mapper.Map<PerfilViewModel>(_perfilService.GetById(id));
        }

        public void Remove(PerfilViewModel obj)
        {
            _uow.BeginTransaction();
            var perfil = _mapper.Map<Perfil>(obj);
            _perfilService.Remove(perfil);
            Commit();
        }

        public void Update(PerfilViewModel obj)
        {
            _uow.BeginTransaction();
            var perfil = _mapper.Map<Perfil>(obj);
            _perfilService.Update(perfil);
            Commit();
        }

        //public IEnumerable<PerfilViewModel> Find(Expression<Func<PerfilViewModel, bool>> predicate)
        //{
        //    return _perfilService.Find(predicate);
        //}
    }
}