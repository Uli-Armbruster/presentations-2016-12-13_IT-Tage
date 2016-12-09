using System.Collections.Generic;
using System.Linq;

using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

using SmartGateIn.Persistence.Contracts;

namespace SmartGateIn.Persistence
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
                .For<IASNRepository>()
                .ImplementedBy<ASNRepository>()
                .LifestyleSingleton();

            yield return
                Component
                    .For<IPartFamilyRepository>()
                    .ImplementedBy<PartFamiliesRepository>()
                    .LifestyleSingleton();

            yield return
                Component
                    .For<IAvailableTrailersRepository>()
                    .ImplementedBy<AvailableTrailersRepository>()
                    .LifestyleSingleton();

            yield return
                Component
                    .For<IAvailableSuperGroups>()
                    .ImplementedBy<AvailableSuperGroupsRepository>()
                    .LifestyleSingleton();

            yield return
                Component
                    .For<IConfirmationRepository>()
                    .ImplementedBy<ConfirmationRepository>()
                    .LifestyleSingleton();

            yield return
                Component
                    .For<ITalkToBackend, IListenToBackend>()
                    .ImplementedBy<ApplicationStateRepository>()
                    .LifestyleSingleton();
        }
    }
}
