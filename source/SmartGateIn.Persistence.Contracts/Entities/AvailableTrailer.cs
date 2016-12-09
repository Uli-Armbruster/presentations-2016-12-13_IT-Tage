namespace SmartGateIn.Persistence.Contracts.Entities
{
    public class AvailableTrailer
    {
        public string ProcessType { get; set; }
        public string TerminalId { get; set; }
        public string SupplierNumber { get; set; }
        public string SuperGroup { get; set; }
        public string ContentCode { get; set; }
        public string ContentCodeDescription { get; set; }
        public string SupplierName { get; set; }
    }
}