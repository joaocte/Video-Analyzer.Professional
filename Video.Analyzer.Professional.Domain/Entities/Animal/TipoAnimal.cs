using System;
using System.Collections.Generic;

namespace Video.Analyzer.Professional.Domain.Entities.Animal
{
    public class TipoAnimal
    {
        public TipoAnimal()
        {
            IdTipoAnimal = Guid.NewGuid();
            Animais = new List<Animal>();
        }

        public virtual ICollection<Animal> Animais { get; set; }
        public Guid IdTipoAnimal { get; set; }
        public Guid IdUsuario { get; set; }
        public string NomeTipoAnimal { get; set; }
        public bool StatusTipoAnimal { get; set; }
        public virtual Usuario.Usuario Usuario { get; set; }
    }
}