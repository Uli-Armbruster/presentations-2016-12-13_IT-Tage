using SmartGateIn.UI.Logger;

namespace SmartGateIn.UI.Notifier
{
    internal class NullNotifier : INotifyAboutSuccess
    {
        public void Send(string message)
        {
        }
    }
}