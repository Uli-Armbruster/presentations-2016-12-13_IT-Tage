using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

using Castle.MicroKernel.Lifestyle;
using Castle.Windsor;

using SmartGateIn.Contracts.Common.Exceptions;
using SmartGateIn.UI.ProcessForms;
using SmartGateIn.UI.Resources;

namespace SmartGateIn.UI.SystemForms
{
    internal partial class FormInitialScreen : Form
    {
        private readonly IWindsorContainer _container;
        private Form _nextForm;

        public FormInitialScreen()
        {
            InitializeComponent();
        }

        public FormInitialScreen(IWindsorContainer container):this()
        {
            _container = container;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                btnStart.Enabled = false;
                EnsureValidContainer();

                //Entry point
                using (_container.BeginScope())
                {
                    Hide();

                    _nextForm = _container.Resolve<FormPackingSlip>();
                    var result = _nextForm.ShowDialog();

                    if (result == DialogResult.Abort)
                    {
                        ShowProcessErrorForm(new ExpectedProcessException(Resource.FormPackingSlip_NoAsnFound));
                    }
                }
            }
            // ReSharper disable once CatchAllClause
            catch (Exception ex)
            {
                //catch all since only the single check-in process could be corrupted
                //new check-ins are still possible
                ShowProcessErrorForm(ex);
            }
            finally
            {
                _nextForm = null;
                btnStart.Enabled = true;

                Show();
                BringToFront();
            }
        }



        /// <summary>
        /// This event allows your Windows Forms application to handle otherwise unhandled exceptions that 
        /// occur in Windows Forms threads. Attach your event handlers to the ThreadException event to deal
        /// with these exceptions, which will leave your application in an unknown state. Where possible, 
        /// exceptions should be handled by a structured exception handling block.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void UiThreadException(object sender, ThreadExceptionEventArgs e)
        {
            EnsureValidContainer();
            ShowProcessErrorForm(e.Exception);

            if (_nextForm != null && !_nextForm.IsDisposed)
            {
                _nextForm.Dispose();
            }
        }

        private void EnsureValidContainer()
        {
            if (_container != null)
            {
                return;
            }

            Environment.FailFast("container is no longer valid. application stopped.");
        }

        private void ShowProcessErrorForm(Exception ex)
        {
            using (var processErrorForm = _container.Resolve<FormProcessError>())
            {
                processErrorForm.UseException(ex);
                processErrorForm.ShowDialog();
            }
        }

        private void FormInitialScreen_Shown(object sender, EventArgs e)
        {
            btnStart.Text = Resource.FormInitialScreen_Continue;
            outputInstruction.Text = Resource.FormInitialScreen_Instruction;
        }

        private void FormInitialScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            _container?.Dispose();
        }
    }
}
