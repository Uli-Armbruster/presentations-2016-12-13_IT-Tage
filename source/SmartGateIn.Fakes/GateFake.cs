using System.Diagnostics;

using SmartGateIn.Contracts.Gate;

namespace SmartGateIn.Fakes
{
    internal class GateFake : IOpenGate
    {
        public void Open()
        {
           Debug.WriteLine("Fake scanner opened gate");
        }
    }
}
