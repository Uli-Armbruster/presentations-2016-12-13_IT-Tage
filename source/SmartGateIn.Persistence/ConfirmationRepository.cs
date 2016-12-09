using System.Diagnostics;

using SmartGateIn.Persistence.Contracts;
using SmartGateIn.Persistence.Contracts.Entities;

namespace SmartGateIn.Persistence
{
    internal class ConfirmationRepository : IConfirmationRepository
    {
        public void AddConfirmation(Confirmation confirmation)
        {
            Debug.WriteLine("confirmation added");
        }
    }
}
