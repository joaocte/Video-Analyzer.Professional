using AutoMapper;
using Video.Analyzer.Professional.Application.ViewModels;
using Video.Analyzer.Professional.Application.ViewModels.Animal;
using Video.Analyzer.Professional.Application.ViewModels.Caixa;
using Video.Analyzer.Professional.Application.ViewModels.Comportamento;
using Video.Analyzer.Professional.Application.ViewModels.Configuracao;
using Video.Analyzer.Professional.Application.ViewModels.Grupo;
using Video.Analyzer.Professional.Application.ViewModels.Usuario;
using Video.Analyzer.Professional.Domain.Entities;
using Video.Analyzer.Professional.Domain.Entities.Animal;
using Video.Analyzer.Professional.Domain.Entities.Caixa;
using Video.Analyzer.Professional.Domain.Entities.Comportamento;
using Video.Analyzer.Professional.Domain.Entities.Configuracao;
using Video.Analyzer.Professional.Domain.Entities.Grupo;
using Video.Analyzer.Professional.Domain.Entities.Usuario;

namespace Video.Analyzer.Professional.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Animal, AnimalViewModel>();
            CreateMap<Caixa, CaixaViewModel>();
            CreateMap<Comportamento, ComportamentoViewModel>();
            CreateMap<Grupo, GrupoViewModel>();
            CreateMap<Menu, MenuViewModel>();
            CreateMap<Perfil, PerfilViewModel>();
            CreateMap<TipoAnimal, TipoAnimalViewModel>();
            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<AnimalComportamento, AnimalComportamentoViewModel>();

            CreateMap<TipoComportamento, TipoComportamentoViewModel>();

            CreateMap<Usuario, RelatorioComportamentoLabirintoEmCruz>();
            CreateMap<Comportamento, RelatorioComportamentoLabirintoEmCruz>();
            CreateMap<Animal, RelatorioComportamentoLabirintoEmCruz>();
            CreateMap<AnimalComportamento, RelatorioComportamentoLabirintoEmCruz>();
            CreateMap<Caixa, RelatorioComportamentoLabirintoEmCruz>();
            CreateMap<Grupo, RelatorioComportamentoLabirintoEmCruz>();

            CreateMap<Grupo, GridAnimalViewModel>();
            CreateMap<Usuario, GridAnimalViewModel>();
            CreateMap<Animal, GridAnimalViewModel>();
            CreateMap<Caixa, GridAnimalViewModel>();
        }
    }
}