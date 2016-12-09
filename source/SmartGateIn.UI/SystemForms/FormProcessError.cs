using System;
using System.Reactive.Linq;
using System.Windows.Forms;

using SmartGateIn.Contracts.Common;
using SmartGateIn.Contracts.Common.Exceptions;
using SmartGateIn.Persistence.Contracts;
using SmartGateIn.UI.ProcessForms;
using SmartGateIn.UI.Resources;

namespace SmartGateIn.UI.SystemForms
{
    public partial class FormProcessError : Form
    {
        private Exception _ex;
        private readonly Config _config;
        private readonly ITalkToBackend _backend;
        private IDisposable _subscription;

        public FormProcessError()
        {
            InitializeComponent();
            this.SetDefaulValues();
        }

        public FormProcessError(Config config,
                                ITalkToBackend backend) : this()
        {
            _config = config;
            _backend = backend;
        }

        internal void UseException(Exception ex)
        {
            _ex = ex;
        }

        private void FormProcessError_Load(object sender, EventArgs e)
        {
            ControlConfirm.Text = Resource.Common_Confirm;
            ControlProcessErrorMessage.Text = _config.CheckInProcessType.ProcessErrorMessage;
            ControlExceptionMessage.Text = _ex.Message;
        }

        private void FormProcessError_Shown(object sender, EventArgs e)
        {
            NotifyBackendAboutError();
            ActivateTimeout();
        }

        private void NotifyBackendAboutError()
        {
            var handledException = _ex as ExpectedProcessException;

            if (handledException == null)
            {
                return;
            }

            if (!handledException.NotifyBackend)
            {
                return;
            }

            _backend.NotifyAboutError(_ex.Message);
        }

        private void ActivateTimeout()
        {
            _subscription = Observable.Timer(TimeSpan.FromSeconds(20)).Subscribe(_ => StopAndClose());
        }

        private void ControlConfirm_Click(object sender, EventArgs e)
        {
            StopAndClose();
        }

        private void StopAndClose()
        {
            _subscription?.Dispose();
            ControlConfirm.Enabled = false;
            DialogResult = DialogResult.OK;
        }
    }
}
