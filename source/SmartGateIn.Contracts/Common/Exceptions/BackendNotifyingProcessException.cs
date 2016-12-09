using System;

namespace SmartGateIn.Contracts.Common.Exceptions
{
    public class BackendNotifyingProcessException : ExpectedProcessException
    {
        public BackendNotifyingProcessException(string message) : base(true, message)
        {
        }

        public BackendNotifyingProcessException(string message, Exception innerException) : base(true, message, innerException)
        {
        }
    }
}