using System;

namespace Video.Analyzer.Professional.Domain.Entities
{
    public class AnimalComportamento
    {
        public AnimalComportamento()
        {
            IdAnimalComportamento = Guid.NewGuid();
        }

        public virtual Animal.Animal Animal { get; set; }
        public virtual Comportamento.Comportamento Comportamento { get; set; }
        public DateTime DataAnalise { get; set; }
        public Guid IdAnimal { get; set; }
        public Guid IdAnimalComportamento { get; set; }
        public Guid IdComportamento { get; set; }

        public Guid IdUsuario { get; set; }
        public long Quantidade { get; set; }
        public double Tempo { get; set; }
        public virtual Usuario.Usuario Usuario { get; set; }
    }
}