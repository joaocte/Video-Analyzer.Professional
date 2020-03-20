using AutoMapper;
using MySql.Data.Entity;
using SimpleInjector;
using System;
using System.Data.Entity;
using Video.Analyzer.Professional.Application.AutoMapper;
using Video.Analyzer.Professional.UI.IOC;
using Video.Analyzer.Professional.UI.Properties;

namespace Video.Analyzer.Professional.UI
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Settings.Default.User = string.Empty;
            Settings.Default.Logado = string.Empty;
            Settings.Default.Save();
            Container container = new Container();
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            BootStrapper.Register(container);
            Mapper.Initialize(cfg => AutoMapperConfig.RegisterMappings());
            container.GetInstance<FormVideoAnalyzerLogin>().ShowDialog();
            if (container.GetInstance<FormVideoAnalyzerLogin>().Logado)
            {
                System.Windows.Forms.Application.Run(container.GetInstance<FormVideoAnalyzerPrincipal>());
            }
        }
    }
}