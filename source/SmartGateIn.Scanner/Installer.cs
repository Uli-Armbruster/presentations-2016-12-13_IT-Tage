using System.Collections.Generic;
using System.Linq;

using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

using SmartGateIn.Contracts.Scanner;

namespace SmartGateIn.Scanner
{
    public class Installer : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var components = Components().ToArray();
            container.Register(components);
        }

        private static IEnumerable<IRegistration> Components()
        {
            yield return Component
                .For<IScanPackingSlip, IScanSummarySheet>()
                .ImplementedBy<ZebraScanner>()
                .LifestyleSingleton();
        }
    }
}
