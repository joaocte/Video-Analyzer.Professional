using AutoMapper;
using System;
using System.Collections.Generic;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Domain.Entities.Usuario;
using Video.Analyzer.Professional.Domain.Interfaces.Services;
using Video.Analyzer.Professional.Infra.Data.Interfaces;
using UsuarioViewModel = Video.Analyzer.Professional.Application.ViewModels.Usuario.UsuarioViewModel;

namespace Video.Analyzer.Professional.Application.AppServices
{
    public class UsuarioAppService : AppServiceBase, IUsuarioAppService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        private readonly IUsuarioService _usuarioService;

        public UsuarioAppService(IUsuarioService usuarioService, IUnitOfWork uow, IMapper mapper) : base(uow)
        {
            _usuarioService = usuarioService;
            _uow = uow;
            _mapper = mapper;
        }

        public void Add(UsuarioViewModel obj)
        {
            _uow.BeginTransaction();
            var usuario = _mapper.Map<Usuario>(obj);
            _usuarioService.Add(usuario);
            Commit();
        }

        public void Dispose()
        {
            _usuarioService.Dispose();
        }

        public IEnumerable<UsuarioViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<UsuarioViewModel>>(_usuarioService.GetAll());
        }

        public UsuarioViewModel GetById(Guid id)
        {
            return _mapper.Map<UsuarioViewModel>(_usuarioService.GetById(id));
        }

        public void Remove(UsuarioViewModel obj)
        {
            _uow.BeginTransaction();
            var usuario = _mapper.Map<Usuario>(obj);
            _usuarioService.Remove(usuario);
            Commit();
        }

        public void Update(UsuarioViewModel obj)
        {
            _uow.BeginTransaction();
            var usuario = _mapper.Map<Usuario>(obj);
            _usuarioService.Update(usuario);
            Commit();
        }

        //public IEnumerable<UsuarioViewModel> Find(Expression<Func<UsuarioViewModel, bool>> predicate)
        //{
        //    return _usuarioService.Find(predicate);
        //}
    }
}