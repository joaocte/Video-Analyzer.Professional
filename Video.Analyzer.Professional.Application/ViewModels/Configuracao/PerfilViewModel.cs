using System;

namespace Video.Analyzer.Professional.Application.ViewModels.Configuracao
{
    public class PerfilViewModel
    {
        public PerfilViewModel()
        {
            IdPerfil = Guid.NewGuid();
        }

        public Guid IdPerfil { get; set; }

        public string NomePerfil { get; set; }

        public bool StatusPerfil { get; set; }
    }
}