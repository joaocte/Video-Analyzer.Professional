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
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AnimalViewModel, Animal>();
            CreateMap<CaixaViewModel, Caixa>();
            CreateMap<ComportamentoViewModel, Comportamento>();
            CreateMap<GrupoViewModel, Grupo>();
            CreateMap<MenuViewModel, Menu>();
            CreateMap<PerfilViewModel, Perfil>();
            CreateMap<TipoAnimalViewModel, TipoAnimal>();
            CreateMap<UsuarioViewModel, Usuario>();
            CreateMap<AnimalComportamentoViewModel, AnimalComportamento>();
            CreateMap<TipoComportamentoViewModel, TipoComportamento>();
        }
    }
}