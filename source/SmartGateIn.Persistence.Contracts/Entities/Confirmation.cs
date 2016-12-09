namespace SmartGateIn.Persistence.Contracts.Entities
{
    public class Confirmation
    {
        public string Ydid { get; set; }
        public string SupplierNumber { get; set; }
        public string TrailerNumber { get; set; }
        public string DeliveryNoteNumber { get; set; }
        public string ReturnProcessType { get; set; }
        public string ContentCode { get; set; }
        public string TripId { get; set; }
        public string TerminalId { get; set; }
        public string ReturnContentCode { get; set; }
        public string ReturnSupplierNumber { get; set; }
        public string ReturnSuperGroup { get; set; }
    }
}