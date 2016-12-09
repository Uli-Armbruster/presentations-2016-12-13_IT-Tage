using SmartGateIn.Contracts;

namespace SmartGateIn.Persistence.Contracts
{
    public interface IListenToBackend
    {
        BackendError ListenToErrors();
    }
}