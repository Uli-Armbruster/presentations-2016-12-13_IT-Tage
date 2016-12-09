namespace SmartGateIn.UI.ProcessForms
{
    partial class FormAvailableSuperGroups
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputInstruction = new System.Windows.Forms.Label();
            this.outputList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.outputList)).BeginInit();
            this.SuspendLayout();
            // 
            // outputInstruction
            // 
            this.outputInstruction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputInstruction.Dock = System.Windows.Forms.DockStyle.Top;
            this.outputInstruction.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputInstruction.Location = new System.Drawing.Point(0, 0);
            this.outputInstruction.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.outputInstruction.Name = "outputInstruction";
            this.outputInstruction.Size = new System.Drawing.Size(650, 36);
            this.outputInstruction.TabIndex = 0;
            this.outputInstruction.Text = "Choose hall";
            this.outputInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputList
            // 
            this.outputList.AllowUserToAddRows = false;
            this.outputList.AllowUserToDeleteRows = false;
            this.outputList.AllowUserToResizeColumns = false;
            this.outputList.AllowUserToResizeRows = false;
            this.outputList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.outputList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.outputList.Location = new System.Drawing.Point(0, 36);
            this.outputList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputList.MultiSelect = false;
            this.outputList.Name = "outputList";
            this.outputList.ReadOnly = true;
            this.outputList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.outputList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputList.RowTemplate.ReadOnly = true;
            this.outputList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.outputList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.outputList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.outputList.ShowCellToolTips = false;
            this.outputList.ShowEditingIcon = false;
            this.outputList.Size = new System.Drawing.Size(650, 464);
            this.outputList.TabIndex = 1;
            this.outputList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.outputList_CellClick);
            this.outputList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataBindingComplete);
            this.outputList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.RowEnter);
            // 
            // FormAvailableSuperGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.outputList);
            this.Controls.Add(this.outputInstruction);
            this.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAvailableSuperGroups";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Gate In";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.outputList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputInstruction;
        private System.Windows.Forms.DataGridView outputList;
    }
}