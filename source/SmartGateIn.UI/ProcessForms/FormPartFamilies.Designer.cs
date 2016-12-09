namespace SmartGateIn.UI.ProcessForms
{
    partial class FormPartFamilies
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
            this.btnScrollUp = new System.Windows.Forms.Button();
            this.outputList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.outputInstruction = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ControlScrollDown = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ControlBackwards = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outputList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScrollUp
            // 
            this.btnScrollUp.AutoSize = true;
            this.btnScrollUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnScrollUp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnScrollUp.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScrollUp.Location = new System.Drawing.Point(0, 67);
            this.btnScrollUp.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnScrollUp.MinimumSize = new System.Drawing.Size(0, 75);
            this.btnScrollUp.Name = "btnScrollUp";
            this.btnScrollUp.Size = new System.Drawing.Size(1107, 75);
            this.btnScrollUp.TabIndex = 1;
            this.btnScrollUp.Text = "scroll up";
            this.btnScrollUp.UseVisualStyleBackColor = true;
            this.btnScrollUp.Click += new System.EventHandler(this.btnScrollUp_Click);
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
            this.outputList.Location = new System.Drawing.Point(0, 0);
            this.outputList.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.outputList.MultiSelect = false;
            this.outputList.Name = "outputList";
            this.outputList.ReadOnly = true;
            this.outputList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.outputList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputList.RowTemplate.ReadOnly = true;
            this.outputList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.outputList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.outputList.ShowCellToolTips = false;
            this.outputList.ShowEditingIcon = false;
            this.outputList.Size = new System.Drawing.Size(1107, 526);
            this.outputList.TabIndex = 3;
            this.outputList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.outputList_CellClick);
            this.outputList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataBindingComplete);
            this.outputList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.RowEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.outputInstruction);
            this.panel1.Controls.Add(this.btnScrollUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 142);
            this.panel1.TabIndex = 4;
            // 
            // outputInstruction
            // 
            this.outputInstruction.Dock = System.Windows.Forms.DockStyle.Top;
            this.outputInstruction.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputInstruction.Location = new System.Drawing.Point(0, 0);
            this.outputInstruction.MinimumSize = new System.Drawing.Size(0, 60);
            this.outputInstruction.Name = "outputInstruction";
            this.outputInstruction.Size = new System.Drawing.Size(1107, 60);
            this.outputInstruction.TabIndex = 2;
            this.outputInstruction.Text = "label1";
            this.outputInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.outputList);
            this.panel2.Location = new System.Drawing.Point(0, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 526);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ControlScrollDown);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 661);
            this.panel4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1107, 74);
            this.panel4.TabIndex = 7;
            // 
            // ControlScrollDown
            // 
            this.ControlScrollDown.AutoSize = true;
            this.ControlScrollDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlScrollDown.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlScrollDown.Location = new System.Drawing.Point(0, 0);
            this.ControlScrollDown.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.ControlScrollDown.Name = "ControlScrollDown";
            this.ControlScrollDown.Size = new System.Drawing.Size(1107, 74);
            this.ControlScrollDown.TabIndex = 2;
            this.ControlScrollDown.Text = "scroll down";
            this.ControlScrollDown.UseVisualStyleBackColor = true;
            this.ControlScrollDown.Click += new System.EventHandler(this.ControlScrollDown_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ControlBackwards);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 735);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1107, 74);
            this.panel3.TabIndex = 8;
            // 
            // ControlBackwards
            // 
            this.ControlBackwards.AutoSize = true;
            this.ControlBackwards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlBackwards.Location = new System.Drawing.Point(0, 0);
            this.ControlBackwards.MinimumSize = new System.Drawing.Size(0, 74);
            this.ControlBackwards.Name = "ControlBackwards";
            this.ControlBackwards.Size = new System.Drawing.Size(1107, 74);
            this.ControlBackwards.TabIndex = 16;
            this.ControlBackwards.Text = "back";
            this.ControlBackwards.UseVisualStyleBackColor = true;
            this.ControlBackwards.Click += new System.EventHandler(this.ControlBackwards_Click);
            // 
            // FormPartFamilies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 809);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormPartFamilies";
            this.Text = "FormPartFamilies";
            this.Shown += new System.EventHandler(this.FormPartFamilies_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.outputList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnScrollUp;
        private System.Windows.Forms.DataGridView outputList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label outputInstruction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ControlScrollDown;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ControlBackwards;
    }
}