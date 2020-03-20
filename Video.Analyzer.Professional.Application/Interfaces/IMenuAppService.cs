using System;
using System.Collections.Generic;
using MenuViewModel = Video.Analyzer.Professional.Application.ViewModels.Configuracao.MenuViewModel;

namespace Video.Analyzer.Professional.Application.Interfaces
{
    public interface IMenuAppService : IDisposable
    {
        void Add(MenuViewModel obj);

        IEnumerable<MenuViewModel> GetAll();

        MenuViewModel GetById(Guid id);

        void Remove(MenuViewModel obj);

        void Update(MenuViewModel obj);

        //IEnumerable<MenuViewModel> Find(Expression<Func<MenuViewModel, bool>> predicate);
    }
}