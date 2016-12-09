using System;
using System.Drawing;
using System.Windows.Forms;

using SmartGateIn.UI.Resources;

namespace SmartGateIn.UI.ProcessForms
{
    internal static class UiFormatter
    {
        public static void ConfigureColumns(this DataGridView table)
        {
            var columnsCount = table.Columns.Count;
            for (var i = 0; i < columnsCount; i++)
            {
                var currentColumn = table.Columns[i];
                currentColumn.Visible = false;

                if (currentColumn.Name.Equals("suppliername", StringComparison.InvariantCultureIgnoreCase))
                {
                    currentColumn.HeaderText = Resource.Common_DisplayNameForSupplierNameInTables;
                    currentColumn.Visible = true;
                }

                if (!currentColumn.Name.Equals("contentcodedescription", StringComparison.InvariantCultureIgnoreCase))
                {
                    continue;
                }

                currentColumn.DisplayIndex = table.Columns.Count - 1;
                currentColumn.HeaderText = Resource.Common_DisplayNameForContentCodeDescriptionInTables;
                currentColumn.Visible = true;
            }
        }

        public static void SetDefaulValues(this Form form)
        {
            form.BackColor = Color.WhiteSmoke;
            form.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            form.FormBorderStyle = FormBorderStyle.Fixed3D;
            form.WindowState = FormWindowState.Maximized;
            form.Text = "Smart Gate In";
            form.ShowInTaskbar = false;
        }
    }
}