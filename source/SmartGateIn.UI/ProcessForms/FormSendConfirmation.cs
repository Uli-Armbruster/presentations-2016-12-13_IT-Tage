using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using SmartGateIn.Contracts.Common.Exceptions;
using SmartGateIn.Contracts.Gate;
using SmartGateIn.Persistence.Contracts;
using SmartGateIn.UI.Logger;
using SmartGateIn.UI.Resources;

namespace SmartGateIn.UI.ProcessForms
{
    internal partial class FormSendConfirmation : Form
    {
        private readonly CheckInContext _context;
        private readonly IEnumerable<INotifyAboutSuccess> _notifier;
        private readonly IConfirmationRepository _repo;
        private readonly IOpenGate _gate;

        public FormSendConfirmation()
        {
            InitializeComponent();
            this.SetDefaulValues();

            outputInstruction.Text = Resource.FromSendConfirmation_Instruction;
            ControlPrintedSuccessfully.Text = Resource.FormSendConfirmation_PrintedSuccessfully;
            ControlPrintingFailed.Text = Resource.FormSendConfirmation_PrintingFailed;
        }

        public FormSendConfirmation(IEnumerable<INotifyAboutSuccess> notifier, IConfirmationRepository repo, 
            IOpenGate gate, CheckInContext context)
            : this()
        {
            _notifier = notifier;
            _repo = repo;
            _context = context;
            _gate = gate;
        }

        private void FormSendConfirmation_Load(object sender, EventArgs e)
        {
            _repo.AddConfirmation(_context.Confirmation);
        }

        private void bntYes_Click(object sender, EventArgs e)
        {
            try
            {
                _gate.Open();

                //Gutschriften
                //FizzBuzz
                //if-else / switch-case => Gift
                _notifier.ToList().ForEach(n => n.Send("wohoo"));

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                throw new BackendNotifyingProcessException("Gate could not be opened.", ex);
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            throw new BackendNotifyingProcessException("User reported that no ticket has been printed");
        }
    }
}
