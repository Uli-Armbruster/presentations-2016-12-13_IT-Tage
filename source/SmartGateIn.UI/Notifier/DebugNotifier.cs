using System.Diagnostics;

namespace SmartGateIn.UI.Logger
{
    internal class DebugNotifier : INotifyAboutSuccess
    {
        public void Send(string message)
        {
            Debug.WriteLine(message);
        }
    }
}