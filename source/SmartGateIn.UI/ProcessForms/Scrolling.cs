using System.Windows.Forms;

namespace SmartGateIn.UI.ProcessForms
{
    internal static class SmoothScrollingBehaviour
    {
        public static void ScrollUp(this DataGridView table)
        {
            if (table.RowCount < 1)
            {
                return;
            }

            var itemsPerPage = table.DisplayedRowCount(false);
            var currentLocation = table.FirstDisplayedScrollingRowIndex;
            var newLocation = currentLocation - itemsPerPage;

            if (newLocation >= 0)
            {
                table.FirstDisplayedScrollingRowIndex = newLocation;
                return;
            }

            if (currentLocation > 0)
            {
                //show the first table entries
                table.FirstDisplayedScrollingRowIndex = 0;
                return;
            }

            //show the las table entries
            table.FirstDisplayedScrollingRowIndex = table.RowCount - itemsPerPage;
        }
        public static void ScrollDown(this DataGridView table)
        {
            if (table.RowCount < 1)
            {
                return;
            }

            var totalNumber = table.RowCount - 1;
            var itemsPerPage = table.DisplayedRowCount(false);
            var currentLocation = table.FirstDisplayedScrollingRowIndex;
            var newLocation = currentLocation + itemsPerPage;

            if (newLocation < totalNumber)
            {
                table.FirstDisplayedScrollingRowIndex = newLocation;
                return;
            }


            if (currentLocation + itemsPerPage > totalNumber)
            {
                //current view shows the last table entries
                //so show the first table entries
                table.FirstDisplayedScrollingRowIndex = 0;
                return;
            }

            //show the last table entries
            table.FirstDisplayedScrollingRowIndex = table.RowCount - itemsPerPage;
        }
    }
}