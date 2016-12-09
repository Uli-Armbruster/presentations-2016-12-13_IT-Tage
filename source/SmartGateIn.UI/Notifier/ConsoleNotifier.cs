using System;

namespace SmartGateIn.UI.Logger
{
    internal class ConsoleNotifier : INotifyAboutSuccess
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }
}
