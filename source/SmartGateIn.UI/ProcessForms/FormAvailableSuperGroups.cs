using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

using SmartGateIn.UI.Resources;

namespace SmartGateIn.UI.ProcessForms
{
    public partial class FormAvailableSuperGroups : Form
    {
        internal string Choice { get; private set; }

        public FormAvailableSuperGroups()
        {
            InitializeComponent();
        }

        public FormAvailableSuperGroups(IEnumerable<string> availableSuperGroups)
        {
            InitializeComponent();

            //Todo: Replace dummy class
            var list = availableSuperGroups
                .Where(nameOfHall => !string.IsNullOrWhiteSpace(nameOfHall) )
                .Select(nameOfHall => new Hall { Name = nameOfHall })
                .ToList();

            var bindingList = new BindingList<Hall>(list);
            outputList.DataSource = new BindingSource(bindingList, null);
            outputList.ClearSelection();

            outputInstruction.Text = Resource.FormAvailableSuperGroups_Instruction;
        }

        private void DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            outputList.ClearSelection();
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
            Choice = ((Hall) item).Name;

            DialogResult = DialogResult.OK;
            Close();
        }

        private class Hall
        {
            public string Name { get; set; }
        }

        private void outputList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowEnter(sender, e);
        }
    }
}
