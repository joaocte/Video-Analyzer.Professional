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

        public void Dispose()
        {
            _usuarioService.Dispose();
        }

        public IEnumerable<UsuarioViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<UsuarioViewModel>>(_usuarioService.GetAll());
        }
    }
}