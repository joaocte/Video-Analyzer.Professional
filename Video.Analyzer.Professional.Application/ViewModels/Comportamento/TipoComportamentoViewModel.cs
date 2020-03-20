using System;

namespace Video.Analyzer.Professional.Application.ViewModels.Comportamento
{
    public class TipoComportamentoViewModel
    {
        public TipoComportamentoViewModel()
        {
            IdTipoComportamento = Guid.NewGuid();
        }

        public Guid IdTipoComportamento { get; set; }

        public Guid IdUsuario { get; set; }
        public string NomeTipoComportamento { get; set; }

        public bool StatusTipoComportamento { get; set; }
        public virtual Usuario.UsuarioViewModel Usuario { get; set; }
    }
}