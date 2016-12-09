namespace SmartGateIn.Contracts.Common.Returnables
{
    internal class OtherReturnables : CheckInProcessType
    {
        public OtherReturnables() : base(2, Resource.OtherReturnables, "OTHER_RET", true)
        {
            Description = Resource.OtherReturnables_Description;
            ProcessErrorMessage = Resource.OtherReturnables_ProcessErrorMessage;
            SystemErrorMessage = Resource.OtherReturnables_SystemErrorMessage;
        }
    }
}