namespace SmartGateIn.Persistence.Contracts.Entities
{
    public class ServerState
    {
        public string TerminalId { get; set; }
        public bool ShowLockScreen { get; set; }
        public string Message { get; set; }
    }
}
