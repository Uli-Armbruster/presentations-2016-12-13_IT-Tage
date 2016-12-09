namespace SmartGateIn.Persistence.Contracts
{
    public interface ITalkToBackend
    {
        void NotifyAboutError(string message);
    }
}
