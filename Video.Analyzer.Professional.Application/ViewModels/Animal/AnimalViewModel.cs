using System;
using System.ComponentModel.DataAnnotations;
using Video.Analyzer.Professional.Application.ViewModels.Grupo;

namespace Video.Analyzer.Professional.Application.ViewModels.Animal
{
    public class AnimalViewModel
    {
        public AnimalViewModel()
        {
            IdAnimal = Guid.NewGuid();
        }

        public virtual Caixa.CaixaViewModel Caixa { get; set; }

        public virtual Comportamento.ComportamentoViewModel Comportamento { get; set; }

        public double Fezes { get; set; }

        public virtual GrupoViewModel Grupo { get; set; }

        [Key]
        public Guid IdAnimal { get; set; }

        [ScaffoldColumn(false)]
        public Guid IdCaixa { get; set; }

        [ScaffoldColumn(false)]
        public Guid IdComportamento { get; set; }

        [ScaffoldColumn(false)]
        public Guid IdGrupo { get; set; }

        [ScaffoldColumn(false)]
        public Guid IdTipoAnimal { get; set; }

        [ScaffoldColumn(false)]
        public Guid IdUsuario { get; set; }

        [Required(ErrorMessage = "Informe o campo nome!")]
        public string NomeAnimal { get; set; }

        public string Peso { get; set; }
        public string Sexo { get; set; }
        public bool StatusAnimal { get; set; }
        public virtual TipoAnimalViewModel TipoAnimal { get; set; }
        public virtual Usuario.UsuarioViewModel Usuario { get; set; }
    }
}