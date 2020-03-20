using System;
using System.Collections.Generic;

namespace Video.Analyzer.Professional.Domain.Entities.Grupo
{
    public class Grupo
    {
        public Grupo()
        {
            IdGrupo = Guid.NewGuid();
            Animais = new List<Animal.Animal>();
        }

        public virtual ICollection<Animal.Animal> Animais { get; set; }
        public Guid IdGrupo { get; set; }

        public Guid IdUsuario { get; set; }
        public string NomeGrupo { get; set; }

        public bool StatusGrupo { get; set; }
        public virtual Usuario.Usuario Usuario { get; set; }
    }
}