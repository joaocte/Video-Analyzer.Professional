using System;

namespace Video.Analyzer.Professional.Application.ViewModels.Caixa
{
    public class CaixaViewModel
    {
        public CaixaViewModel()
        {
            IdCaixa = Guid.NewGuid();
        }

        public Guid IdCaixa { get; set; }

        public Guid IdUsuario { get; set; }
        public string NomeCaixa { get; set; }

        public bool StatusCaixa { get; set; }
        public virtual Usuario.UsuarioViewModel Usuario { get; set; }
    }
}