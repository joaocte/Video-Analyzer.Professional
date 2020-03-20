using System.Collections.Generic;
using System.Linq;

namespace Video.Analyzer.Professional.Domain.ValueObjects
{
    public class ValidationResult
    {
        private readonly List<ValidationError> _errors = new List<ValidationError>();

        public IEnumerable<ValidationError> Erros => _errors;
        public bool IsValid => _errors.Count == 0;
        public string Mensagem { get; set; }

        public void AdicionarErro(ValidationError error)
        {
            _errors.Add(error);
        }

        public void AdicionarErro(params ValidationResult[] resultadoValidacao)
        {
            if (resultadoValidacao == null) return;

            foreach (var validationResult in resultadoValidacao.Where(result => result != null))
                _errors.AddRange(validationResult.Erros);
        }

        public void RemoverErro(ValidationError error)
        {
            if (_errors.Contains(error))
                _errors.Remove(error);
        }
    }
}