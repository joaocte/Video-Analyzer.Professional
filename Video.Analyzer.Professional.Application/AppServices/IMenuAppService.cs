using AutoMapper;
using System;
using System.Collections.Generic;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Domain.Entities.Configuracao;
using Video.Analyzer.Professional.Domain.Interfaces.Services;
using Video.Analyzer.Professional.Infra.Data.Interfaces;
using MenuViewModel = Video.Analyzer.Professional.Application.ViewModels.Configuracao.MenuViewModel;

namespace Video.Analyzer.Professional.Application.AppServices
{
    public class MenuAppService : AppServiceBase, IMenuAppService
    {
        private readonly IMapper _mapper;
        private readonly IMenuService _menuService;
        private readonly IUnitOfWork _uow;

        public MenuAppService(IMenuService menuService, IUnitOfWork uow, IMapper mapper) : base(uow)
        {
            _menuService = menuService;
            _uow = uow;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _menuService.Dispose();
        }
    }
}