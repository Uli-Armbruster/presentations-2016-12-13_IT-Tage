using System;
using System.Reactive.Linq;
using System.Threading;
using System.Windows.Forms;

using SmartGateIn.Contracts.Common.Exceptions;
using SmartGateIn.Contracts.Scanner;
using SmartGateIn.Persistence.Contracts;
using SmartGateIn.Persistence.Contracts.Entities;
using SmartGateIn.UI.Resources;

namespace SmartGateIn.UI.ProcessForms
{
    internal partial class FormPackingSlip : Form
    {
        private readonly CheckInContext _checkInContext;
        private readonly IASNRepository _repo;
        private readonly IScanPackingSlip _scanner;
        private readonly FormSummarySheet _nextForm;
        private IDisposable _scannerSubscription;

        public FormPackingSlip()
        {
            InitializeComponent();
            this.SetDefaulValues();
        }

        public FormPackingSlip(IASNRepository repo,
                               IScanPackingSlip scanner,
                               FormSummarySheet nextForm,
                               CheckInContext checkInContext) : this()
        {
            _repo = repo;
            _scanner = scanner;
            _nextForm = nextForm;
            _checkInContext = checkInContext;
        }

        private void LoadTranslationsForUI()
        {
            btn_Cancel.Text = Resource.Common_StartOver;
            btnConfirm.Text = Resource.Common_Confirm;
            lbl_DeliveryNoteNumber.Text = Resource.Common_DeliveryNoteNumber;
            lbl_SupplierNumber.Text = Resource.Common_SupplierNumber;
            lbl_TrailerNumber.Text = Resource.Common_TrailerNumber;
            outputInstruction.Text = Resource.FormPackingSlip_Instruction;
        }

        private void FormPackingSlip_Shown(object sender, EventArgs e)
        {
            LoadTranslationsForUI();

            var barcodesFound = _scanner
                .ScanBarcodesFromPackingSlip()
                .Select(FoundInBackend)
                .Where(x => x != null)
                .Take(1);

            var timeoutOccured = Observable
                .Throw<ASN>(new ExpectedProcessException("Timeout", new TimeoutException("Scanner timeout")))
                .DelaySubscription(TimeSpan.FromSeconds(30));

            _scannerSubscription = barcodesFound
                .Amb(timeoutOccured)
                .ObserveOn(SynchronizationContext.Current)
                .Subscribe(found =>
                           {
                               _checkInContext.ASN = found;
                               UpdateUI();
                           },
                           ex => { throw ex; });
        }

        private ASN FoundInBackend(ValidPackingSlipBarcodes barcodes)
        {
            var found = _repo.FindAsnWithPackingSlipDetails(barcodes);

            if (found == null && barcodes.MaximumReached())
            {
                throw new ExpectedProcessException(Resource.FormPackingSlip_NoAsnFound);
            }

            return found;
        }

        private void UpdateUI()
        {
            output_TrailerNumber.Text = _checkInContext.ASN.TrailerNumber;
            output_DeliveryNoteNumber.Text = _checkInContext.ASN.DeliveryNoteNumber;
            output_SupplierNumber.Text = _checkInContext.ASN.SupplierNumber;
            btnConfirm.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _scannerSubscription?.Dispose();
            _nextForm.ShowDialog();

            //Dispose is called from caller
            //so you don't need to do this here
            DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //Dispose is called from caller
            //so you don't need to do this here
            _scannerSubscription?.Dispose();
            DialogResult = DialogResult.Cancel;
        }
    }
}
