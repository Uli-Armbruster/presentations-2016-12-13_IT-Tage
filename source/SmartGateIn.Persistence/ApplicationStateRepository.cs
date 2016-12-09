using System.Diagnostics;

using SmartGateIn.Contracts;
using SmartGateIn.Persistence.Contracts;

namespace SmartGateIn.Persistence
{
    internal class ApplicationStateRepository : ITalkToBackend, IListenToBackend
    {
        public void NotifyAboutError(string message)
        {
            Debug.WriteLine("message sent");
        }

        public BackendError ListenToErrors()
        {
            var fakeState = DebugEnvironment.UseFakeBackgroundApplicationState();

            if (!fakeState.Item1 || string.IsNullOrWhiteSpace(fakeState.Item2) || fakeState.Item2 == "0")
            {
                return new BackendError { ErrorOccured = false, Message = string.Empty };
            }

            return new BackendError { ErrorOccured = true, Message = fakeState.Item2 };
        }
    }
}
