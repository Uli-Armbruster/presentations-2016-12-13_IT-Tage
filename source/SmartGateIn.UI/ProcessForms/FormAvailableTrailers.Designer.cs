namespace SmartGateIn.UI.ProcessForms
{
    partial class FormAvailableTrailers
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
            this.btnRETURNABLE = new System.Windows.Forms.Button();
            this.btnEMPTY = new System.Windows.Forms.Button();
            this.btnNONE = new System.Windows.Forms.Button();
            this.btnOTHER_RET = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ControlInstruction = new System.Windows.Forms.Label();
            this.outputList = new System.Windows.Forms.DataGridView();
            this.ControlNoResultsFound = new System.Windows.Forms.Label();
            this.ControlScrollUp = new System.Windows.Forms.Button();
            this.ControlScrollDown = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ControlConfirm = new System.Windows.Forms.Button();
            this.ControlStartOver = new System.Windows.Forms.Button();
            this.ControlBackwards = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputList)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRETURNABLE
            // 
            this.btnRETURNABLE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRETURNABLE.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRETURNABLE.Location = new System.Drawing.Point(0, 0);
            this.btnRETURNABLE.Margin = new System.Windows.Forms.Padding(5);
            this.btnRETURNABLE.MinimumSize = new System.Drawing.Size(300, 0);
            this.btnRETURNABLE.Name = "btnRETURNABLE";
            this.btnRETURNABLE.Size = new System.Drawing.Size(300, 74);
            this.btnRETURNABLE.TabIndex = 0;
            this.btnRETURNABLE.UseVisualStyleBackColor = true;
            this.btnRETURNABLE.Click += new System.EventHandler(this.btnReturnable_Click);
            // 
            // btnEMPTY
            // 
            this.btnEMPTY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEMPTY.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEMPTY.Location = new System.Drawing.Point(357, 0);
            this.btnEMPTY.Margin = new System.Windows.Forms.Padding(5);
            this.btnEMPTY.MinimumSize = new System.Drawing.Size(300, 0);
            this.btnEMPTY.Name = "btnEMPTY";
            this.btnEMPTY.Size = new System.Drawing.Size(300, 74);
            this.btnEMPTY.TabIndex = 1;
            this.btnEMPTY.UseVisualStyleBackColor = true;
            this.btnEMPTY.Visible = false;
            this.btnEMPTY.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // btnNONE
            // 
            this.btnNONE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNONE.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNONE.Location = new System.Drawing.Point(708, 0);
            this.btnNONE.Margin = new System.Windows.Forms.Padding(5);
            this.btnNONE.MinimumSize = new System.Drawing.Size(300, 0);
            this.btnNONE.Name = "btnNONE";
            this.btnNONE.Size = new System.Drawing.Size(300, 74);
            this.btnNONE.TabIndex = 2;
            this.btnNONE.UseVisualStyleBackColor = true;
            this.btnNONE.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // btnOTHER_RET
            // 
            this.btnOTHER_RET.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOTHER_RET.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOTHER_RET.Location = new System.Drawing.Point(357, 0);
            this.btnOTHER_RET.Margin = new System.Windows.Forms.Padding(5);
            this.btnOTHER_RET.MinimumSize = new System.Drawing.Size(300, 0);
            this.btnOTHER_RET.Name = "btnOTHER_RET";
            this.btnOTHER_RET.Size = new System.Drawing.Size(300, 74);
            this.btnOTHER_RET.TabIndex = 5;
            this.btnOTHER_RET.UseVisualStyleBackColor = true;
            this.btnOTHER_RET.Visible = false;
            this.btnOTHER_RET.Click += new System.EventHandler(this.btnOtherReturnables_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ControlInstruction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 74);
            this.panel1.TabIndex = 6;
            // 
            // ControlInstruction
            // 
            this.ControlInstruction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlInstruction.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlInstruction.Location = new System.Drawing.Point(0, 0);
            this.ControlInstruction.Name = "ControlInstruction";
            this.ControlInstruction.Size = new System.Drawing.Size(1008, 74);
            this.ControlInstruction.TabIndex = 6;
            this.ControlInstruction.Text = "label1";
            this.ControlInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.outputList.Name = "outputList";
            this.outputList.ReadOnly = true;
            this.outputList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.outputList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.outputList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.outputList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.outputList.ShowCellToolTips = false;
            this.outputList.ShowEditingIcon = false;
            this.outputList.Size = new System.Drawing.Size(1006, 209);
            this.outputList.TabIndex = 7;
            this.outputList.Visible = false;
            this.outputList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataBindingComplete);
            this.outputList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.RowEnter);
            // 
            // ControlNoResultsFound
            // 
            this.ControlNoResultsFound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlNoResultsFound.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlNoResultsFound.ForeColor = System.Drawing.Color.Red;
            this.ControlNoResultsFound.Location = new System.Drawing.Point(0, 0);
            this.ControlNoResultsFound.MinimumSize = new System.Drawing.Size(0, 50);
            this.ControlNoResultsFound.Name = "ControlNoResultsFound";
            this.ControlNoResultsFound.Size = new System.Drawing.Size(1008, 74);
            this.ControlNoResultsFound.TabIndex = 8;
            this.ControlNoResultsFound.Text = "space for error messages";
            this.ControlNoResultsFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ControlScrollUp
            // 
            this.ControlScrollUp.AutoSize = true;
            this.ControlScrollUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlScrollUp.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlScrollUp.Location = new System.Drawing.Point(0, 0);
            this.ControlScrollUp.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ControlScrollUp.Name = "ControlScrollUp";
            this.ControlScrollUp.Size = new System.Drawing.Size(1008, 74);
            this.ControlScrollUp.TabIndex = 9;
            this.ControlScrollUp.Text = "scroll up";
            this.ControlScrollUp.UseVisualStyleBackColor = true;
            this.ControlScrollUp.Visible = false;
            this.ControlScrollUp.Click += new System.EventHandler(this.ControlScrollUp_Click);
            // 
            // ControlScrollDown
            // 
            this.ControlScrollDown.AutoSize = true;
            this.ControlScrollDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlScrollDown.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlScrollDown.Location = new System.Drawing.Point(0, 0);
            this.ControlScrollDown.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ControlScrollDown.Name = "ControlScrollDown";
            this.ControlScrollDown.Size = new System.Drawing.Size(1008, 74);
            this.ControlScrollDown.TabIndex = 10;
            this.ControlScrollDown.Text = "scroll down";
            this.ControlScrollDown.UseVisualStyleBackColor = true;
            this.ControlScrollDown.Visible = false;
            this.ControlScrollDown.Click += new System.EventHandler(this.ControlScrollDown_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.outputList);
            this.panel3.Location = new System.Drawing.Point(1, 296);
            this.panel3.MinimumSize = new System.Drawing.Size(0, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1006, 209);
            this.panel3.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ControlConfirm);
            this.panel5.Controls.Add(this.ControlStartOver);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 581);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1008, 74);
            this.panel5.TabIndex = 15;
            // 
            // ControlConfirm
            // 
            this.ControlConfirm.AutoSize = true;
            this.ControlConfirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlConfirm.Location = new System.Drawing.Point(504, 0);
            this.ControlConfirm.Name = "ControlConfirm";
            this.ControlConfirm.Size = new System.Drawing.Size(504, 74);
            this.ControlConfirm.TabIndex = 1;
            this.ControlConfirm.Text = "Confirm";
            this.ControlConfirm.UseVisualStyleBackColor = true;
            this.ControlConfirm.Click += new System.EventHandler(this.ControlConfirm_Click);
            // 
            // ControlStartOver
            // 
            this.ControlStartOver.AutoSize = true;
            this.ControlStartOver.Dock = System.Windows.Forms.DockStyle.Left;
            this.ControlStartOver.Location = new System.Drawing.Point(0, 0);
            this.ControlStartOver.Name = "ControlStartOver";
            this.ControlStartOver.Size = new System.Drawing.Size(504, 74);
            this.ControlStartOver.TabIndex = 0;
            this.ControlStartOver.Text = "Start over";
            this.ControlStartOver.UseVisualStyleBackColor = true;
            this.ControlStartOver.Click += new System.EventHandler(this.ControlStartOver_Click);
            // 
            // ControlBackwards
            // 
            this.ControlBackwards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlBackwards.Location = new System.Drawing.Point(0, 0);
            this.ControlBackwards.MinimumSize = new System.Drawing.Size(0, 74);
            this.ControlBackwards.Name = "ControlBackwards";
            this.ControlBackwards.Size = new System.Drawing.Size(1008, 74);
            this.ControlBackwards.TabIndex = 15;
            this.ControlBackwards.Text = "back";
            this.ControlBackwards.UseVisualStyleBackColor = true;
            this.ControlBackwards.Click += new System.EventHandler(this.ControlBackwards_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ControlScrollDown);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 507);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1008, 74);
            this.panel4.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ControlBackwards);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 655);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1008, 74);
            this.panel6.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnOTHER_RET);
            this.panel7.Controls.Add(this.btnRETURNABLE);
            this.panel7.Controls.Add(this.btnNONE);
            this.panel7.Controls.Add(this.btnEMPTY);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 74);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1008, 74);
            this.panel7.TabIndex = 17;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.ControlNoResultsFound);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 148);
            this.panel8.MinimumSize = new System.Drawing.Size(0, 74);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1008, 74);
            this.panel8.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ControlScrollUp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 222);
            this.panel2.MinimumSize = new System.Drawing.Size(74, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 74);
            this.panel2.TabIndex = 19;
            // 
            // FormAvailableTrailers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormAvailableTrailers";
            this.Text = "Smart Gate In";
            this.Load += new System.EventHandler(this.FormTrailers_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outputList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRETURNABLE;
        private System.Windows.Forms.Button btnEMPTY;
        private System.Windows.Forms.Button btnNONE;
        private System.Windows.Forms.Button btnOTHER_RET;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ControlInstruction;
        private System.Windows.Forms.DataGridView outputList;
        private System.Windows.Forms.Label ControlNoResultsFound;
        private System.Windows.Forms.Button ControlScrollUp;
        private System.Windows.Forms.Button ControlScrollDown;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button ControlConfirm;
        private System.Windows.Forms.Button ControlStartOver;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ControlBackwards;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel2;
    }
}