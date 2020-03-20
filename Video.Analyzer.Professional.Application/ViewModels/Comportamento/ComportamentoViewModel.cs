using System;
using System.Diagnostics;
using Video.Analyzer.Professional.Application.ViewModels.Animal;

namespace Video.Analyzer.Professional.Application.ViewModels.Comportamento
{
    public class ComportamentoViewModel
    {
        public ComportamentoViewModel()
        {
            IdComportamento = Guid.NewGuid();
            BotaoPressionado = false;
            Cronometro = new Stopwatch();
        }

        public AnimalViewModel Animal { get; set; }
        public bool BotaoPressionado { get; set; }
        public Stopwatch Cronometro { get; set; }
        public Guid IdComportamento { get; set; }

        public Guid IdTipoComportamento { get; set; }
        public Guid IdUsuario { get; set; }
        public string LetraTeclado { get; set; }
        public string NomeComportamento { get; set; }
        public bool StatusComportamento { get; set; }
        //public long TempoTotal { get; set; }

        public virtual TipoComportamentoViewModel TipoComportamentoViewModel { get; set; }

        //public double Quantidade { get; set; }
        public virtual Usuario.UsuarioViewModel Usuario { get; set; }
    }
}