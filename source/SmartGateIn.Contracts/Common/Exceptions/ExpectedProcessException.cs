using System;

namespace SmartGateIn.Contracts.Common.Exceptions
{
    public class ExpectedProcessException : Exception
    {
        public bool NotifyBackend { get; private set; }

        public ExpectedProcessException(string message) : this(false, message)
        {
        }

        public ExpectedProcessException(string message, Exception innerException) : this(false, message, innerException)
        {
        }

        protected ExpectedProcessException(bool notifyBackend, string message) : base(message)
        {
            NotifyBackend = notifyBackend;
        }

        protected ExpectedProcessException(bool notifyBackend, string message, Exception innerException)
            : base(message, innerException)
        {
            NotifyBackend = notifyBackend;
        }
    }
}
