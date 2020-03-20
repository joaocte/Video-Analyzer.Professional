using System;

namespace Video.Analyzer.Professional.Application.ViewModels.Grupo
{
    public class GrupoViewModel
    {
        public GrupoViewModel()
        {
            IdGrupo = Guid.NewGuid();
        }

        public Guid IdGrupo { get; set; }

        public Guid IdUsuario { get; set; }
        public string NomeGrupo { get; set; }

        public bool StatusGrupo { get; set; }
        public virtual Usuario.UsuarioViewModel Usuario { get; set; }
    }
}