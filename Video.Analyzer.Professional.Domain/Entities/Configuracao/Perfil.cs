using System;
using System.Collections.Generic;

namespace Video.Analyzer.Professional.Domain.Entities.Configuracao
{
    public class Perfil
    {
        public Perfil()
        {
            IdPerfil = Guid.NewGuid();
            Menus = new List<Menu>();
            Usuarios = new List<Usuario.Usuario>();
        }

        public Guid IdPerfil { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
        public string NomePerfil { get; set; }

        public bool StatusPerfil { get; set; }

        public virtual ICollection<Usuario.Usuario> Usuarios { get; set; }
    }
}