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

        public void Add(MenuViewModel obj)
        {
            _uow.BeginTransaction();
            var menu = _mapper.Map<Menu>(obj);
            _menuService.Add(menu);
            Commit();
        }

        public void Dispose()
        {
            _menuService.Dispose();
        }

        public IEnumerable<MenuViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<MenuViewModel>>(_menuService.GetAll());
        }

        public MenuViewModel GetById(Guid id)
        {
            return _mapper.Map<MenuViewModel>(_menuService.GetById(id));
        }

        public void Remove(MenuViewModel obj)
        {
            _uow.BeginTransaction();
            var menu = _mapper.Map<Menu>(obj);
            _menuService.Remove(menu);
            Commit();
        }

        public void Update(MenuViewModel obj)
        {
            _uow.BeginTransaction();
            var menu = _mapper.Map<Menu>(obj);
            _menuService.Update(menu);
            Commit();
        }

        //public IEnumerable<MenuViewModel> Find(Expression<Func<MenuViewModel, bool>> predicate)
        //{
        //    return _menuService.Find(predicate);
        //}
    }
}