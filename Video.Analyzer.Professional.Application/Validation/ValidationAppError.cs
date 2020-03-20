namespace Video.Analyzer.Professional.Application.Validation
{
    public class ValidationAppError
    {
        public ValidationAppError(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}