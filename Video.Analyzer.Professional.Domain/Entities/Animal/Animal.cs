using System;
using System.Collections.Generic;
using Video.Analyzer.Professional.Domain.Validation;
using ValidationResult = DomainValidation.Validation.ValidationResult;

namespace Video.Analyzer.Professional.Domain.Entities.Animal
{
    public class Animal
    {
        public Animal()
        {
            IdAnimal = Guid.NewGuid();
            AnimaisComportamentos = new List<AnimalComportamento>();
        }

        public virtual ICollection<AnimalComportamento> AnimaisComportamentos { get; set; }
        public virtual Caixa.Caixa Caixa { get; set; }
        public double Fezes { get; set; }
        public virtual Grupo.Grupo Grupo { get; set; }
        public Guid IdAnimal { get; set; }

        public Guid IdCaixa { get; set; }
        public Guid IdGrupo { get; set; }
        public Guid IdTipoAnimal { get; set; }
        public Guid IdUsuario { get; set; }
        public string NomeAnimal { get; set; }
        public string Peso { get; set; }
        public string Sexo { get; set; }
        public bool StatusAnimal { get; set; }
        public virtual TipoAnimal TipoAnimal { get; set; }
        public virtual Usuario.Usuario Usuario { get; set; }
        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            ValidationResult = new AnimalAptoParaCadastro().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}