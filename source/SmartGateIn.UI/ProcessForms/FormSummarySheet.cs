using System;
using System.Reactive.Linq;
using System.Threading;
using System.Windows.Forms;

using SmartGateIn.Contracts;
using SmartGateIn.Contracts.Common.Exceptions;
using SmartGateIn.Contracts.Scanner;
using SmartGateIn.UI.Resources;

namespace SmartGateIn.UI.ProcessForms
{
    internal partial class FormSummarySheet : Form
    {
        private readonly CheckInContext _checkInContext;
        private readonly IScanSummarySheet _scanner;
        private readonly FormPartFamilies _nextForm;
        private IDisposable _scannerSubscription;

        public FormSummarySheet()
        {
            InitializeComponent();
            this.SetDefaulValues();
        }

        public FormSummarySheet(IScanSummarySheet scanner, FormPartFamilies nextForm, CheckInContext checkInContext)
            : this()
        {
            _scanner = scanner;
            _nextForm = nextForm;
            _checkInContext = checkInContext;
        }

        private void FormSummarySheet_Shown(object sender, EventArgs e)
        {
            LoadTranslationsForUI();

            var barcodeFound = _scanner.ScanBarcodeFromSummarySheet().Take(1);

            var timeoutOccured = Observable
                .Throw<string>(new ExpectedProcessException("Timeout", new TimeoutException("Scanner timeout")))
                .DelaySubscription(TimeSpan.FromSeconds(30));

            _scannerSubscription = barcodeFound
                .Amb(timeoutOccured)
                .ObserveOn(SynchronizationContext.Current)
                .Subscribe(found =>
                           {
                               _checkInContext.TripId = found;
                               UpdateUI();
                           },
                           ex => { throw ex; });
        }

        private void FormTripId_Load(object sender, EventArgs e)
        {
            output_DeliveryNoteNumber.Text = _checkInContext.ASN.DeliveryNoteNumber;
            output_SupplierNumber.Text = _checkInContext.ASN.SupplierNumber;
            output_TrailerNumber.Text = _checkInContext.ASN.TrailerNumber;
        }

        private void LoadTranslationsForUI()
        {
            btnConfirm.Text = Resource.Common_Confirm;
            btn_Cancel.Text = Resource.Common_StartOver;
            lbl_DeliveryNoteNumber.Text = Resource.Common_DeliveryNoteNumber;
            lbl_SupplierNumber.Text = Resource.Common_SupplierNumber;
            lbl_TrailerNumber.Text = Resource.Common_TrailerNumber;
            lbl_TripId.Text = Resource.Common_TripId;
            outputInstruction.Text = Resource.FormPackingSlip_AskUserToInsertTripSummarySheet;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            _scannerSubscription.Dispose();
            DialogResult = DialogResult.Cancel;
        }

        private void UpdateUI()
        {
            output_TripId.Text = _checkInContext.TripId;
            btnConfirm.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _scannerSubscription.Dispose();

            var result = _nextForm.ShowDialog();

            if (result == DialogResult.Retry)
            {
                output_TripId.Text = string.Empty;
                _checkInContext.TripId = string.Empty;
                FormSummarySheet_Shown(sender, e);
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
