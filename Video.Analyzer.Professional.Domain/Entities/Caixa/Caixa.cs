using System;
using System.Collections.Generic;

namespace Video.Analyzer.Professional.Domain.Entities.Caixa
{
    public class Caixa
    {
        public Caixa()
        {
            IdCaixa = Guid.NewGuid();
            IdUsuario = Guid.NewGuid();
            Animais = new List<Animal.Animal>();
        }

        public virtual ICollection<Animal.Animal> Animais { get; set; }
        public Guid IdCaixa { get; set; }

        public Guid IdUsuario { get; set; }
        public string NomeCaixa { get; set; }

        public bool StatusCaixa { get; set; }
        public virtual Usuario.Usuario Usuario { get; set; }
    }
}