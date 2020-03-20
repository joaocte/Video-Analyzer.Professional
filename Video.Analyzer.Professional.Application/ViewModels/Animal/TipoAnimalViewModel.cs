using System;

namespace Video.Analyzer.Professional.Application.ViewModels.Animal
{
    public class TipoAnimalViewModel
    {
        public TipoAnimalViewModel()
        {
            IdTipoAnimal = Guid.NewGuid();
        }

        public virtual AnimalViewModel Animal { get; set; }
        public Guid IdTipoAnimal { get; set; }
        public Guid IdUsuario { get; set; }
        public string NomeTipoAnimal { get; set; }
        public bool StatusTipoAnimal { get; set; }
        public virtual Usuario.UsuarioViewModel Usuario { get; set; }
    }
}