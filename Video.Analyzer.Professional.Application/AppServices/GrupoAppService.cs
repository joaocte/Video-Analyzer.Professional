using AutoMapper;
using System;
using System.Collections.Generic;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Domain.Entities.Grupo;
using Video.Analyzer.Professional.Domain.Interfaces.Services;
using Video.Analyzer.Professional.Infra.Data.Interfaces;
using GrupoViewModel = Video.Analyzer.Professional.Application.ViewModels.Grupo.GrupoViewModel;

namespace Video.Analyzer.Professional.Application.AppServices
{
    public class GrupoAppService : AppServiceBase, IGrupoAppService
    {
        private readonly IGrupoService _grupoService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public GrupoAppService(IGrupoService grupoService, IUnitOfWork uow, IMapper mapper) : base(uow)
        {
            _grupoService = grupoService;
            _uow = uow;
            _mapper = mapper;
        }

        public void Add(GrupoViewModel obj)
        {
            _uow.BeginTransaction();
            var grupo = _mapper.Map<Grupo>(obj);
            _grupoService.Add(grupo);
            Commit();
        }

        public void Dispose()
        {
            _grupoService.Dispose();
        }

        public IEnumerable<GrupoViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<GrupoViewModel>>(_grupoService.GetAll());
        }

        public GrupoViewModel GetById(Guid id)
        {
            return _mapper.Map<GrupoViewModel>(_grupoService.GetById(id));
        }

        public void Remove(GrupoViewModel obj)
        {
            _uow.BeginTransaction();
            var grupo = _mapper.Map<Grupo>(obj);
            _grupoService.Remove(grupo);
            Commit();
        }

        public void Update(GrupoViewModel obj)
        {
            _uow.BeginTransaction();
            var grupo = _mapper.Map<Grupo>(obj);
            _grupoService.Update(grupo);
            Commit();
        }

        //public IEnumerable<GrupoViewModel> Find(Expression<Func<Grupo, bool>> predicate)
        //{
        //    return _grupoService.Find(predicate).ProjectTo<GrupoViewModel>();
        //}
    }
}