using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

using SmartGateIn.Contracts.Gate;

namespace SmartGateIn.Fakes
{
    public class Installer : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var components = Components().ToArray();

            if (components.Any())
            {
                return;
            }

            container.Register(components);
        }

        private static IEnumerable<IRegistration> Components()
        {
#if !DEBUG
            yield break;
#else
            Debug.WriteLine("Making use of Fake Gate");
            yield return Component
                .For<IOpenGate>()
                .Instance(new GateFake())
                .IsDefault();
#endif
        }
    }
}
