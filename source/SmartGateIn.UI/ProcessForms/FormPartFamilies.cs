using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

using SmartGateIn.Persistence.Contracts;
using SmartGateIn.Persistence.Contracts.Entities;
using SmartGateIn.UI.Resources;

namespace SmartGateIn.UI.ProcessForms
{
    internal partial class FormPartFamilies : Form
    {
        private readonly CheckInContext _checkInContext;
        private readonly FormAvailableTrailers _nextForm;
        private readonly IPartFamilyRepository _repo;

        public FormPartFamilies()
        {
            InitializeComponent();
            this.SetDefaulValues();
        }

        public FormPartFamilies(FormAvailableTrailers nextForm,
                                IPartFamilyRepository repo,
                                CheckInContext checkInContext) : this()
        {
            Translate();

            _nextForm = nextForm;
            _repo = repo;
            _checkInContext = checkInContext;
        }

        private void Translate()
        {
            outputInstruction.Text = Resource.FormPartFamilies_Instruction;
            btnScrollUp.Text = Resource.Common_ScrollUp;
            ControlScrollDown.Text = Resource.Common_ScrollDown;
            ControlBackwards.Text = Resource.Common_Backwards;
        }

        private void RowEnter(object sender, DataGridViewCellEventArgs e)
        {
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
            var partFamily = (PartFamily) item;
            _checkInContext.PartFamily = partFamily;

            var result = _nextForm.ShowDialog();

            if (result != DialogResult.Retry)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            outputList.ConfigureColumns();
        }

        private void outputList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowEnter(sender, e);
        }

        private void FormPartFamilies_Shown(object sender, EventArgs e)
        {
            var choices = _repo.GetPartFamilyFromASN(_checkInContext.ASN).ToList();
            var bindingList = new BindingList<PartFamily>(choices);

            outputList.DataSource = new BindingSource(bindingList, null);
            outputList.ClearSelection();
        }

        private void ControlScrollDown_Click(object sender, EventArgs e)
        {
            outputList.ScrollDown();
        }

        private void btnScrollUp_Click(object sender, EventArgs e)
        {
            outputList.ScrollUp();
        }

        private void ControlBackwards_Click(object sender, EventArgs e)
        {
            /* 
             * simply closing the form does not quite fit to the current label, but the best solution right now
             * - As rescanning the Trip-ID without rescanning the ASN does not make any sense at all
             */
            DialogResult = DialogResult.Cancel;
        }
    }
}
