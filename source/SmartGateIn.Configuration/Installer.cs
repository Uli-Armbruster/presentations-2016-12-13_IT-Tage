using System.Collections.Generic;
using System.Linq;

using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

using SmartGateIn.Contracts;
using SmartGateIn.Contracts.Common;

namespace SmartGateIn.Configuration
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
                .For<Config>().
                Instance(new Reader().FromExistingFile())
                .LifestyleSingleton();
        }
    }
}
