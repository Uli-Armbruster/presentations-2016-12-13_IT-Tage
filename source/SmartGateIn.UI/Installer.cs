using System.Collections.Generic;
using System.Linq;

using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

using SmartGateIn.Contracts;
using SmartGateIn.UI.SystemForms;

namespace SmartGateIn.UI
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
                .For<CheckInContext>()
                .ImplementedBy<CheckInContext>()
                .LifestyleScoped();

            yield return Component
                .For<FormProcessError>()
                .LifestyleTransient();

            yield return Component
                .For<IMessageBroker>()
                .Instance(RxMessageBrokerMinimod.Default);
        }
    }
}
