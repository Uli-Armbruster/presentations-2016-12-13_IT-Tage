using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

using Castle.Core;
using Castle.Facilities.Startable;
using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace SmartGateIn.UI
{
    internal class IoCInitializer
    {
        private static DirectoryInfo _overridenRootFolder;

        private static DirectoryInfo RootFolder => _overridenRootFolder
                                                   ?? new FileInfo(Assembly.GetEntryAssembly().Location).Directory;

        private readonly IWindsorContainer _container;

        public IoCInitializer()
        {
            _container = new WindsorContainer();
        }

        public IoCInitializer(DirectoryInfo rootFolder) : this()
        {
            _overridenRootFolder = rootFolder;
        }


        public IoCInitializer RegisterComponents()
        {
            Debug.WriteLine("Root-Folder for initializing IoC container: {0}", RootFolder.FullName);

            AddFacilities();

            AddResolvers();

            InstallFromAssemblies(ScanAssemblies());

            InstallFromExecutables(ScanExecutables());

            return this;
        }

        public IoCInitializer RegisterComponents(IWindsorInstaller[] installerForTestings)
        {
            if (installerForTestings == null ||
                !installerForTestings.Any())
            {
                return this;
            }

            _container.Install(installerForTestings);

            return this;
        }

        public IWindsorContainer Instance()
        {
            return _container;
        }


        private void AddResolvers()
        {
            _container.Kernel.Resolver.AddSubResolver(new CollectionResolver(_container.Kernel));
        }

        private void AddFacilities()
        {
            _container.AddFacility<TypedFactoryFacility>();
            _container.AddFacility<StartableFacility>(f => f.DeferredStart());
        }

  
        private static IEnumerable<IWindsorInstaller> ScanAssemblies()
        {
            return ScanFiles(AssembliesFilterPattern());
        }

        private static IEnumerable<IWindsorInstaller> ScanExecutables()
        {
            return ScanFiles(ExecutablesFilterPattern());
        }

        private static IEnumerable<IWindsorInstaller> ScanFiles(Func<FileInfo, bool> fileFilter)
        {
            var files = new List<FileInfo>();

            FoldersToScan()
                .ToList()
                .ForEach(
                         folder =>
                             files.AddRange(
                                            folder
                                                .GetFiles()
                                                .Where(fileFilter)
                                           )
                        );

            return files.Select(executable => FromAssembly.Named(executable.FullName));
        }

        private static Func<FileInfo, bool> ExecutablesFilterPattern()
        {
            return e =>
                e.Name.ToLower().StartsWith("smart")
                && !e.Name.ToLower().Contains("vshost")
                && e.Name.ToLower().EndsWith(".exe");
        }

        private static Func<FileInfo, bool> AssembliesFilterPattern()
        {
            return e =>
                e.Name.ToLower().StartsWith("smart")
                && e.Name.ToLower().EndsWith(".dll");
        }

        private void InstallFromExecutables(IEnumerable<IWindsorInstaller> installer)
        {
            Install(installer);
        }

        private void InstallFromAssemblies(IEnumerable<IWindsorInstaller> installer)
        {
            Install(installer);
        }

        private void Install(IEnumerable<IWindsorInstaller> installer)
        {
            _container.Install(installer.ToArray());
        }

        private static IEnumerable<DirectoryInfo> FoldersToScan()
        {
            yield return RootFolder;
        }
    }
}
