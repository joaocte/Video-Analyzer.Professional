using System;
using System.Collections.Generic;
using Video.Analyzer.Professional.Application.ViewModels;

namespace Video.Analyzer.Professional.Application.Interfaces
{
    public interface IAnimalComportamentoAppService : IDisposable
    {
        void Add(AnimalComportamentoViewModel obj);

        void DeleteComportamentoAnimal(Guid idAnimal);

        IEnumerable<AnimalComportamentoViewModel> GetAll();

        IEnumerable<RelatorioComportamentoLabirintoEmCruz> GetAll(Guid idCaixa, Guid idUsuario, bool agrupado);
    }
}