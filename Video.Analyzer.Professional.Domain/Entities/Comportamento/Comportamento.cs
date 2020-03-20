using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Video.Analyzer.Professional.Domain.Entities.Comportamento
{
    public class Comportamento
    {
        public Comportamento()
        {
            IdComportamento = Guid.NewGuid();
            //Animais = new List<Animal.Animal>();
            AnimaisComportamentos = new List<AnimalComportamento>();
        }

        //public virtual ICollection<Animal.Animal> Animais { get; set; }
        public virtual ICollection<AnimalComportamento> AnimaisComportamentos { get; set; }

        public bool BotaoPressionado { get; set; }
        public Stopwatch Cronometro { get; set; }
        public Guid IdComportamento { get; set; }

        public Guid IdTipoComportamento { get; set; }
        public Guid IdUsuario { get; set; }
        public string LetraTeclado { get; set; }
        public string NomeComportamento { get; set; }

        //public long TempoTotal { get; set; }

        //public double Quantidade { get; set; }
        //public Animal.Animal Animal { get; set; }
        public bool StatusComportamento { get; set; }

        public virtual TipoComportamento TipoComportamento { get; set; }
        public virtual Usuario.Usuario Usuario { get; set; }
    }
}