namespace SmartGateIn.UI.ProcessForms
{
    partial class FormPackingSlip
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
            this.lbl_SupplierNumber = new System.Windows.Forms.Label();
            this.lbl_DeliveryNoteNumber = new System.Windows.Forms.Label();
            this.lbl_TrailerNumber = new System.Windows.Forms.Label();
            this.output_SupplierNumber = new System.Windows.Forms.TextBox();
            this.output_TrailerNumber = new System.Windows.Forms.TextBox();
            this.output_DeliveryNoteNumber = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputInstruction
            // 
            this.outputInstruction.Dock = System.Windows.Forms.DockStyle.Top;
            this.outputInstruction.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputInstruction.Location = new System.Drawing.Point(0, 0);
            this.outputInstruction.Name = "outputInstruction";
            this.outputInstruction.Size = new System.Drawing.Size(1008, 52);
            this.outputInstruction.TabIndex = 0;
            this.outputInstruction.Text = "label1";
            this.outputInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_SupplierNumber
            // 
            this.lbl_SupplierNumber.AutoSize = true;
            this.lbl_SupplierNumber.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SupplierNumber.Location = new System.Drawing.Point(12, 52);
            this.lbl_SupplierNumber.Name = "lbl_SupplierNumber";
            this.lbl_SupplierNumber.Size = new System.Drawing.Size(70, 22);
            this.lbl_SupplierNumber.TabIndex = 1;
            this.lbl_SupplierNumber.Text = "label2";
            // 
            // lbl_DeliveryNoteNumber
            // 
            this.lbl_DeliveryNoteNumber.AutoSize = true;
            this.lbl_DeliveryNoteNumber.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeliveryNoteNumber.Location = new System.Drawing.Point(12, 85);
            this.lbl_DeliveryNoteNumber.Name = "lbl_DeliveryNoteNumber";
            this.lbl_DeliveryNoteNumber.Size = new System.Drawing.Size(70, 22);
            this.lbl_DeliveryNoteNumber.TabIndex = 2;
            this.lbl_DeliveryNoteNumber.Text = "label3";
            // 
            // lbl_TrailerNumber
            // 
            this.lbl_TrailerNumber.AutoSize = true;
            this.lbl_TrailerNumber.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TrailerNumber.Location = new System.Drawing.Point(12, 118);
            this.lbl_TrailerNumber.Name = "lbl_TrailerNumber";
            this.lbl_TrailerNumber.Size = new System.Drawing.Size(70, 22);
            this.lbl_TrailerNumber.TabIndex = 3;
            this.lbl_TrailerNumber.Text = "label4";
            // 
            // output_SupplierNumber
            // 
            this.output_SupplierNumber.Enabled = false;
            this.output_SupplierNumber.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_SupplierNumber.Location = new System.Drawing.Point(233, 49);
            this.output_SupplierNumber.Name = "output_SupplierNumber";
            this.output_SupplierNumber.Size = new System.Drawing.Size(340, 29);
            this.output_SupplierNumber.TabIndex = 4;
            // 
            // output_TrailerNumber
            // 
            this.output_TrailerNumber.Enabled = false;
            this.output_TrailerNumber.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_TrailerNumber.Location = new System.Drawing.Point(233, 115);
            this.output_TrailerNumber.Name = "output_TrailerNumber";
            this.output_TrailerNumber.Size = new System.Drawing.Size(340, 29);
            this.output_TrailerNumber.TabIndex = 5;
            // 
            // output_DeliveryNoteNumber
            // 
            this.output_DeliveryNoteNumber.Enabled = false;
            this.output_DeliveryNoteNumber.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_DeliveryNoteNumber.Location = new System.Drawing.Point(233, 82);
            this.output_DeliveryNoteNumber.Name = "output_DeliveryNoteNumber";
            this.output_DeliveryNoteNumber.Size = new System.Drawing.Size(340, 29);
            this.output_DeliveryNoteNumber.TabIndex = 6;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Cancel.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(0, 664);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(1008, 65);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfirm.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(0, 599);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(1008, 65);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FormPackingSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.output_DeliveryNoteNumber);
            this.Controls.Add(this.output_TrailerNumber);
            this.Controls.Add(this.output_SupplierNumber);
            this.Controls.Add(this.lbl_TrailerNumber);
            this.Controls.Add(this.lbl_DeliveryNoteNumber);
            this.Controls.Add(this.lbl_SupplierNumber);
            this.Controls.Add(this.outputInstruction);
            this.Name = "FormPackingSlip";
            this.Text = "Smart Gate In";
            this.Shown += new System.EventHandler(this.FormPackingSlip_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputInstruction;
        private System.Windows.Forms.Label lbl_SupplierNumber;
        private System.Windows.Forms.Label lbl_DeliveryNoteNumber;
        private System.Windows.Forms.Label lbl_TrailerNumber;
        private System.Windows.Forms.TextBox output_SupplierNumber;
        private System.Windows.Forms.TextBox output_TrailerNumber;
        private System.Windows.Forms.TextBox output_DeliveryNoteNumber;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btnConfirm;
    }
}