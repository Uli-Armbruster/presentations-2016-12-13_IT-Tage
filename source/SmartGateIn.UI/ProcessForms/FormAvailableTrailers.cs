using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using SmartGateIn.Contracts.Common.Returnables;
using SmartGateIn.Persistence.Contracts;
using SmartGateIn.Persistence.Contracts.Entities;
using SmartGateIn.Persistence.Contracts.Filter;
using SmartGateIn.UI.Resources;

namespace SmartGateIn.UI.ProcessForms
{
    internal partial class FormAvailableTrailers : Form
    {
        private readonly CheckInContext _checkInContext;
        private readonly FormSendConfirmation _nextForm;
        private readonly IAvailableTrailersRepository _availableTrailers;
        private readonly IAvailableSuperGroups _availableSuperGroups;

        public FormAvailableTrailers()
        {
            InitializeComponent();
            this.SetDefaulValues();
        }

        public FormAvailableTrailers(
            FormSendConfirmation nextForm,
            CheckInContext checkInContext,
            IAvailableTrailersRepository availableTrailers,
            IAvailableSuperGroups availableSuperGroups)
            : this()
        {
            _nextForm = nextForm;
            _checkInContext = checkInContext;
            _availableTrailers = availableTrailers;
            _availableSuperGroups = availableSuperGroups;
        }

        private void FormTrailers_Load(object sender, EventArgs e)
        {
            ControlConfirm.Enabled = false;
            outputList.Visible = false;
            btnEMPTY.Visible = false;
            btnOTHER_RET.Visible = false;
            ControlScrollUp.Visible = false;
            ControlScrollDown.Visible = false;
            ControlBackwards.Visible = true;
            ControlNoResultsFound.Text = string.Empty;

            Translate();
            ShowGateDependingControls();
        }

        private void Translate()
        {
            btnEMPTY.Text = CheckInProcessType.Empty.ActionText;
            btnRETURNABLE.Text = CheckInProcessType.DefaultReturnables.ActionText;
            btnOTHER_RET.Text = CheckInProcessType.OtherReturnables.ActionText;
            btnNONE.Text = CheckInProcessType.None.ActionText;
            ControlConfirm.Text = Resource.Common_Confirm;
            ControlBackwards.Text = Resource.Common_Backwards;
            ControlStartOver.Text = Resource.Common_StartOver;
            ControlScrollDown.Text = Resource.Common_ScrollDown;
            ControlScrollUp.Text = Resource.Common_ScrollUp;
            ControlInstruction.Text = string.Format(Resource.FormAvailableTrailers_Instruction,
                                                    CheckInProcessType.DefaultReturnables.ActionText,
                                                    _checkInContext.ConfiguredProcessType.ActionText,
                                                    CheckInProcessType.None.ActionText
                                                   );
        }

        private void ShowGateDependingControls()
        {
            btnEMPTY.Visible = IsProcessAllowed(btnEMPTY);
            btnOTHER_RET.Visible = IsProcessAllowed(btnOTHER_RET);
        }

        private bool IsProcessAllowed(Control button)
        {
            return button.Text.Equals(_checkInContext.ConfiguredProcessType.ActionText,
                                      StringComparison.InvariantCultureIgnoreCase);
        }

        private void DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            outputList.ConfigureColumns();
        }

        private void RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ControlConfirm.Enabled = false;

            var grid = (DataGridView) sender;
            if (grid.SelectedRows.Count != 1)
            {
                return;
            }

            var row = grid.SelectedRows[0];

            if (row == null)
            {
                return;
            }

            var item = row.DataBoundItem;
            var selectedTrailer = (AvailableTrailer) item;
            _checkInContext.Trailer = selectedTrailer;

            ControlConfirm.Enabled = true;
        }

        private void ControlScrollUp_Click(object sender, EventArgs e)
        {
            outputList.ScrollUp();
        }

        private void ControlScrollDown_Click(object sender, EventArgs e)
        {
            outputList.ScrollDown();
        }

        private void ControlStartOver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ControlConfirm_Click(object sender, EventArgs e)
        {
            _nextForm.ShowDialog();
            DialogResult = DialogResult.OK;
        }

        private void ControlBackwards_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            _checkInContext.Trailer = null;
            _checkInContext.SelectedProcessType = CheckInProcessType.None;

            ControlConfirm_Click(sender, e);
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            ShowChoicesForProcessType(CheckInProcessType.Empty);
        }

        private void btnReturnable_Click(object sender, EventArgs e)
        {
            ShowChoicesForProcessType(CheckInProcessType.DefaultReturnables);
        }

        private void btnOtherReturnables_Click(object sender, EventArgs e)
        {
            var selectedSuperGroup = LetUserChooseSuperGroup(CheckInProcessType.OtherReturnables);
            ShowChoicesForProcessType(CheckInProcessType.OtherReturnables, selectedSuperGroup);
        }

        private void ShowChoicesForProcessType(CheckInProcessType processType, string superGroup = "")
        {
            var filter = new AvailableTrailerFilter
            {
                TerminalId = _checkInContext.TerminalId,
                ProcessType = processType.Literal,
                SupplierNumber = _checkInContext.ASN.SupplierNumber,
                SuperGroup = superGroup
            };

            var availableTrailers = _availableTrailers.FilterBy(filter).ToList();

            _checkInContext.SuperGroup = superGroup;
            _checkInContext.SelectedProcessType = processType;
            LetUserChooseAvailableTrailers(availableTrailers);
        }

        private void LetUserChooseAvailableTrailers(IList<AvailableTrailer> list)
        {
            var bindingList = new BindingList<AvailableTrailer>(list);
            outputList.DataSource = new BindingSource(bindingList, null);
            outputList.Visible = true;
            ControlScrollDown.Visible = true;
            ControlScrollUp.Visible = true;

            if (list.Count > 0)
            {
                ControlScrollDown.Enabled = true;
                ControlScrollUp.Enabled = true;
                ControlNoResultsFound.Text = string.Empty;
                outputList.ClearSelection();

                return;
            }

            ControlScrollDown.Enabled = false;
            ControlScrollUp.Enabled = false;
            ControlConfirm.Enabled = false;

            ShowUserHintWhenNoResultsFound();
        }

        private void ShowUserHintWhenNoResultsFound()
        {
            var usedOption = _checkInContext.SelectedProcessType;
            var option2 = CheckInProcessType.None;
            var option1 = _checkInContext.ConfiguredProcessType == usedOption
                              ? CheckInProcessType.DefaultReturnables
                              : _checkInContext.ConfiguredProcessType;

            ControlNoResultsFound.Text = string.Format(Resource.FormAvailableTrailers_NoResultsFound,
                                                       usedOption.ActionText,
                                                       option1.ActionText,
                                                       option2.ActionText);
            outputList.ClearSelection();
        }

        private string LetUserChooseSuperGroup(CheckInProcessType processType)
        {
            var filter = new AvailableSuperGroupFilter
            {
                TerminalId = _checkInContext.TerminalId,
                ProcessType = processType.Literal,
                SupplierNumber = _checkInContext.ASN.SupplierNumber
            };

            var availableSuperGroups = _availableSuperGroups.FilterBy(filter);

            using (var superGroupsForm = new FormAvailableSuperGroups(availableSuperGroups))
            {
                var result = superGroupsForm.ShowDialog();
                if (result != DialogResult.OK || string.IsNullOrWhiteSpace(superGroupsForm.Choice))
                {
                    throw new IOException("No super group was chosen");
                }

                return superGroupsForm.Choice;
            }
        }
    }
}
