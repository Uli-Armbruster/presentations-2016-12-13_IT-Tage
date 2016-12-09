using System.Collections.Generic;
using System.Linq;

using Castle.Core;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace SmartGateIn.UI.Daemons
{
    namespace SmartGateIn.UI.Daemons
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
                yield return Classes
                    .FromThisAssembly()
                    .IncludeNonPublicTypes()
                    .BasedOn<IStartable>()
                    .WithServiceAllInterfaces()
                    .LifestyleSingleton();
            }
        }
    }
}
