using System;

namespace Video.Analyzer.Professional.Application.ViewModels
{
    public class AnimalComportamentoViewModel
    {
        public AnimalComportamentoViewModel()
        {
            IdAnimalComportamento = Guid.NewGuid();
        }

        public virtual Animal.AnimalViewModel Animal { get; set; }
        public virtual Comportamento.ComportamentoViewModel Comportamento { get; set; }
        public DateTime DataAnalise { get; set; }
        public Guid IdAnimal { get; set; }
        public Guid IdAnimalComportamento { get; set; }
        public Guid IdComportamento { get; set; }

        public Guid IdUsuario { get; set; }
        public long Quantidade { get; set; }
        public Double Tempo { get; set; }
        public virtual Usuario.UsuarioViewModel Usuario { get; set; }
    }
}