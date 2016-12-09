namespace SmartGateIn.Contracts.Common.Returnables
{
    internal class EmptyReturnables : CheckInProcessType
    {
        public EmptyReturnables() : base(1, Resource.Empty, "EMPTY", true)
        {
            Description = Resource.Empty_Description;
            ProcessErrorMessage = Resource.Empty_ProcessErrorMessage;
            SystemErrorMessage = Resource.Empty_SystemErrorMessage;
        }
    }
}