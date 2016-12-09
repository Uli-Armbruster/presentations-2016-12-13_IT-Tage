using Castle.Windsor;

namespace SmartGateIn.UI
{
    internal class Bootstrapper
    {
        public static IWindsorContainer Execute()
        {
            //do some pre-container bootstrapping stuff here

            var container = new IoCInitializer()
                .RegisterComponents()
                .Instance();
            
            //do some post-container bootstrapping stuff here

            return container;
        }


        //public class ClientBootstrapperWithDialogComposition : IAmABootstrapperComposition
        //{
        //    private readonly string _profile;

        //    public ClientBootstrapperWithDialogComposition(string profile)
        //    {
        //        _profile = profile;
        //    }

        //    public IEnumerable<IAmABootstrapperAction> Actions
        //    {
        //        get
        //        {
        //            yield return new LocalFolderAndFilesInitializer(_profile);
        //            yield return new LoggingInitializer();
        //            yield return new LoggingConfigObserver();
        //            yield return new CredentialFilesChecker();
        //            yield return new IoCLoader();
        //            yield return new DatabaseInitializer();
        //            yield return new GlobalConfigReader();
        //            yield return new DefaultStockReader();
        //            yield return new ServiceConfigReader();
        //            yield return new RemoteFolderAndFilesInitializer();
        //            yield return new ProgramVersionReader();
        //            yield return new TasksConfigReader();
        //            yield return new ClientUserConfigReader();
        //            yield return new ClientStageNotifier();
        //        }
        //    }
        //}
    }
}