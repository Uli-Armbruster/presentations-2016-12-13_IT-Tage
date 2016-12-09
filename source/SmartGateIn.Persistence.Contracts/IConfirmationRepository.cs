using SmartGateIn.Persistence.Contracts.Entities;

namespace SmartGateIn.Persistence.Contracts
{
    public interface IConfirmationRepository
    {
        void AddConfirmation(Confirmation confirmation);
    }
}
