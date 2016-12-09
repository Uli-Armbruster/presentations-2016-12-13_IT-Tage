using System.Collections.Generic;
using System.Linq;

using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

using SmartGateIn.UI.Logger;

namespace SmartGateIn.UI.Notifier
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
                .FromAssemblyContaining<INotifyAboutSuccess>()
                .IncludeNonPublicTypes()
                .BasedOn<INotifyAboutSuccess>()
                .WithServiceBase()
                .LifestyleScoped();
        }
    }
}
