using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

using SmartGateIn.UI.SystemForms;

namespace SmartGateIn.UI
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // Set the unhandled exception mode to force all Windows Forms errors
            // to go through our handler.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add the event handler for handling non-UI thread exceptions to the event. 
            AppDomain.CurrentDomain.UnhandledException += NonUiThreadExceptions;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");

            var container = Bootstrapper.Execute();
            // Add the event handler for handling UI thread exceptions to the event.
            var initialForm = new FormInitialScreen(container);
            Application.ThreadException += initialForm.UiThreadException;
            
            Application.Run(initialForm);
        }

        /// <summary>
        /// This event provides notification of uncaught exceptions. It allows the application to log 
        /// information about the exception before the system default handler reports the exception to 
        /// the user and terminates the application. If sufficient information about the state of the 
        /// application is available, other actions may be undertaken — such as saving program data 
        /// for later recovery. Caution is advised, because program data can become corrupted when 
        /// exceptions are not handled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void NonUiThreadExceptions(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = (Exception) e.ExceptionObject;

            Environment.FailFast($"There was an unhandeled, non-UI-thread exception which terminated " +
                                 $"the CLR. Message:{Environment.NewLine}{ex.Message}",
                                 ex);
        }
    }
}
