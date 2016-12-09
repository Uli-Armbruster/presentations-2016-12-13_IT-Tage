using System.Collections.Generic;
using System.Linq;

using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace SmartGateIn.UI.ProcessForms
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
                .InSameNamespaceAs<FormPackingSlip>()
                .WithService
                .Self()
                .LifestyleScoped();
        }
    }
}