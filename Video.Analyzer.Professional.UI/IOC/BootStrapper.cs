using AutoMapper;
using SimpleInjector;
using System;
using System.Linq;
using Video.Analyzer.Professional.Application.AppServices;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Domain.Interfaces.Repository;
using Video.Analyzer.Professional.Domain.Interfaces.Services;
using Video.Analyzer.Professional.Domain.Services;
using Video.Analyzer.Professional.Infra.Data.Context;
using Video.Analyzer.Professional.Infra.Data.Interfaces;
using Video.Analyzer.Professional.Infra.Data.Repository;
using Video.Analyzer.Professional.Infra.Data.Repository.ReadOnly;
using Video.Analyzer.Professional.Infra.Data.UoW;
using AnimalComportamentoRepository = Video.Analyzer.Professional.Infra.Data.Repository.AnimalComportamentoRepository;

namespace Video.Analyzer.Professional.UI.IOC
{
    public class BootStrapper
    {
        public static void Register(Container container)
        {
            // Lifestyle.Transient => Uma instancia para cada solicitacao;
            // Lifestyle.Singleton => Uma instancia unica para a classe;
            // Lifestyle.Scoped => Uma instancia unica para o request;

            //container = new Container();
            container.Register<IDbContext>(() => new VideoAnalyzerContext(), Lifestyle.Singleton);

            //REGISTRO DOS APPSERVICES.
            container.Register(typeof(IAppServiceBase), typeof(AppServiceBase), Lifestyle.Singleton);
            container.Register<IAnimalAppService, AnimalAppService>(Lifestyle.Singleton);
            container.Register<ICaixaAppService, CaixaAppService>(Lifestyle.Singleton);
            container.Register<IComportamentoAppService, ComportamentoAppService>(Lifestyle.Singleton);
            container.Register<IGrupoAppService, GrupoAppService>(Lifestyle.Singleton);
            container.Register<IMenuAppService, MenuAppService>(Lifestyle.Singleton);
            container.Register<IPerfilAppService, PerfilAppService>(Lifestyle.Singleton);
            container.Register<ITipoAnimalAppService, TipoAnimalAppService>(Lifestyle.Singleton);
            container.Register<IUsuarioAppService, UsuarioAppService>(Lifestyle.Singleton);
            container.Register<IAnimalComportamentoAppService, AnimalComportamentoAppService>(Lifestyle.Singleton);
            container.Register<ITipoComportamentoAppService, TipoComportamentoAppService>(Lifestyle.Singleton);

            //REGISTRANDO OS SERVICOS
            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>), Lifestyle.Singleton);
            container.Register<IAnimalService, AnimalService>(Lifestyle.Singleton);
            container.Register<ICaixaService, CaixaService>(Lifestyle.Singleton);
            container.Register<IComportamentoService, ComportamentoService>(Lifestyle.Singleton);
            container.Register<IGrupoService, GrupoService>(Lifestyle.Singleton);
            container.Register<IMenuService, MenuService>(Lifestyle.Singleton);
            container.Register<IPerfilService, PerfilService>(Lifestyle.Singleton);
            container.Register<ITipoAnimalService, TipoAnimalService>(Lifestyle.Singleton);
            container.Register<IUsuarioService, UsuarioService>(Lifestyle.Singleton);
            container.Register<IAnimalComportamentoService, AnimalComportamentoService>(Lifestyle.Singleton);
            container.Register<ITipoComportamentoService, TipoComportamentoService>(Lifestyle.Singleton);

            // REGISTRANDO OS REPOSITORIOS.
            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>), Lifestyle.Singleton);
            container.Register<IAnimalRepository, AnimalRepository>(Lifestyle.Singleton);
            container.Register<IAnimalComportamentoRepository, AnimalComportamentoRepository>(Lifestyle.Singleton);
            container.Register<ICaixaRepository, CaixaRepository>(Lifestyle.Singleton);
            container.Register<IComportamentoRepository, ComportamentoRepository>(Lifestyle.Singleton);
            container.Register<IGrupoRepository, GrupoRepository>(Lifestyle.Singleton);
            container.Register<IMenuRepository, MenuRepository>(Lifestyle.Singleton);
            container.Register<IPerfilRepository, PerfilRepository>(Lifestyle.Singleton);
            container.Register<ITipoAnimalRepository, TipoAnimalRepository>(Lifestyle.Singleton);
            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Singleton);
            container.Register<ITipoComportamentoRepository, TipoComportamentoRepository>(Lifestyle.Singleton);

            // REGISTRANDO OS REPOSITORIIOS READONLY
            container.Register<Video.Analyzer.Professional.Domain.Interfaces.Repository.ReadyOnly.IAnimalComportamentoRepository, Infra.Data.Repository.ReadOnly.AnimalComportamentoRepository>(Lifestyle.Singleton);
            container.Register<Video.Analyzer.Professional.Domain.Interfaces.Repository.ReadyOnly.IAnimalRepository, AnimalRepositoryReadOnly>(Lifestyle.Singleton);

            //DATA CONFIGS
            container.Register(typeof(IUnitOfWork), typeof(UnitOfWork), Lifestyle.Singleton);

            //var profiles = Assembly.GetExecutingAssembly()
            //    .GetTypes()
            //    .Where(x => typeof(AutoMapper.Profile).IsAssignableFrom(x));

            var type = typeof(Profile);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => p.Namespace == "Video.Analyzer.Professional.Application.AutoMapper")
                .Where(p => type.IsAssignableFrom(p));

            var config = new MapperConfiguration(cfg =>
            {
                foreach (var profile in types)
                {
                    cfg.AddProfile(profile);
                }
            });

            container.RegisterSingleton(config);
            container.Register(() => config.CreateMapper(container.GetInstance), Lifestyle.Singleton);

            //container.Register<FormVideoAnalyzerPlayer>(Lifestyle.Singleton);
            container.Register<FrmCadastrarCaixa>(Lifestyle.Singleton);
            container.Register<FormVideoAnalyzerPrincipal>(Lifestyle.Singleton);
            container.Register<FormVideoAnalyzerLogin>(Lifestyle.Singleton);
            container.Register<FromVideoAnalyzerGrupo>(Lifestyle.Singleton);
            container.Register<FormVideoAnalyzerTipoAnimal>(Lifestyle.Singleton);
            container.Register<FormVideoAnalyzerAnimal>(Lifestyle.Singleton);
            container.Register<FormVideoAnalyzerComportamento>(Lifestyle.Singleton);
            container.Register<FormVideoAnalyzerSelecionaAnimal>(Lifestyle.Singleton);
            container.Register<FormVideoAnalyzerTipoComportamento>(Lifestyle.Singleton);
            container.Register<FormVideoAnalyzerPlayerWmp>(Lifestyle.Singleton);
            container.Register<FormVideoAnalyzerExtrairExcel>(Lifestyle.Singleton);
            container.Verify();
        }
    }
}