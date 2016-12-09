using System;
using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using System.Threading;
using System.Windows.Forms;

using Castle.Core;

using SmartGateIn.Contracts;
using SmartGateIn.UI.Daemons;

namespace SmartGateIn.UI.SystemForms
{
    internal partial class FormSystemError : Form, IStartable
    {
        private readonly IMessageBroker _broker;
        private IDisposable _subscription;

        public FormSystemError()
        {
            InitializeComponent();
        }

        public FormSystemError(IMessageBroker broker) : this()
        {
            _broker = broker;
            ShowInTaskbar = false;
        }

        private void FormError_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;
            WindowState = FormWindowState.Maximized;
        }

        private void output_ErrorMessage_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            WindowState = FormWindowState.Normal;
        }

        public void Start()
        {
            Hide();

            _subscription = new CompositeDisposable(
                                                    RegisterLockEvent(),
                                                    RegisterUnlockEvent()
                                                   );
        }

        private IDisposable RegisterUnlockEvent()
        {
            return _broker.Register<LockSystemEvent>
                (
                 LockSystem,
                 new SynchronizationContextScheduler(SynchronizationContext.Current)
                );
        }

        private IDisposable RegisterLockEvent()
        {
            return _broker.Register<UnlockSystemEvent>
                (
                 UnlockSystem,
                 new SynchronizationContextScheduler(SynchronizationContext.Current)
                );
        }

        private void UnlockSystem(UnlockSystemEvent _)
        {
            Hide();
        }

        private void LockSystem(LockSystemEvent lockSystemEvent)
        {
            output_SystemDown.Text = lockSystemEvent.Headline;
            output_ErrorMessage.Text = lockSystemEvent.Message;

            Show();
        }

        public void Stop()
        {
            _subscription?.Dispose();
        }
    }
}
