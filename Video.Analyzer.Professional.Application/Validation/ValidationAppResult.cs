using System.Collections.Generic;

namespace Video.Analyzer.Professional.Application.Validation
{
    public class ValidationAppResult
    {
        private readonly List<ValidationAppError> _errors = new List<ValidationAppError>();

        public ICollection<ValidationAppError> Erros => _errors;

        public bool IsValid
        {
            get => _errors.Count == 0;
            set
            {
                var b = value;
            }
        }

        public string Mensagem { get; set; }
    }
}