using DomainValidation.Validation;
using Video.Analyzer.Professional.Domain.Entities.Animal;
using Video.Analyzer.Professional.Domain.Specification;

namespace Video.Analyzer.Professional.Domain.Validation
{
    public class AnimalAptoParaCadastro : Validator<Animal>
    {
        public AnimalAptoParaCadastro()
        {
            var animalValido = new ValidaAnimalSpecification();

            Add("AnimalInvalido", new Rule<Animal>(animalValido, "Favor Verificar as informações Cadastradas."));
        }
    }
}