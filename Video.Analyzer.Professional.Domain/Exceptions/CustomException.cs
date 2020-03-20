using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security;

namespace Video.Analyzer.Professional.Domain.Exceptions
{
    [Serializable]
    public class CustomException : Exception
    {
        public CustomException()
        {
            InnerExceptions = new List<Exception>();
        }

        public CustomException(IEnumerable<Exception> innerExceptions)
            : this()
        {
            InnerExceptions.AddRange(innerExceptions);
        }

        public CustomException(string message)
            : base(message)
        {
        }

        public CustomException(string format, params object[] args)
            : this(string.Format(format, args))
        {
        }

        public CustomException(string message, Exception innerException)
            : base(message, innerException)
        {
            InnerExceptions = new List<Exception>();
        }

        [SecuritySafeCritical]
        protected CustomException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            InnerExceptions = new List<Exception>();
        }

        public List<Exception> InnerExceptions { private set; get; }
    }
}