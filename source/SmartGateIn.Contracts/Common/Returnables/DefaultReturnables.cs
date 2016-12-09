namespace SmartGateIn.Contracts.Common.Returnables
{
    internal class DefaultReturnables : CheckInProcessType
    {
        public DefaultReturnables() : base(3, Resource.Returnable, "RETURNABLE", false)
        {
        }
    }
}
