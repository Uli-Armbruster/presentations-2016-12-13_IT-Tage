namespace SmartGateIn.UI.ProcessForms
{
    partial class FormSendConfirmation
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
            this.ControlPrintedSuccessfully = new System.Windows.Forms.Button();
            this.ControlPrintingFailed = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputInstruction
            // 
            this.outputInstruction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputInstruction.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputInstruction.Location = new System.Drawing.Point(0, 0);
            this.outputInstruction.Name = "outputInstruction";
            this.outputInstruction.Size = new System.Drawing.Size(686, 413);
            this.outputInstruction.TabIndex = 0;
            this.outputInstruction.Text = "label1";
            this.outputInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ControlPrintedSuccessfully
            // 
            this.ControlPrintedSuccessfully.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ControlPrintedSuccessfully.Location = new System.Drawing.Point(0, 2);
            this.ControlPrintedSuccessfully.Name = "ControlPrintedSuccessfully";
            this.ControlPrintedSuccessfully.Size = new System.Drawing.Size(686, 80);
            this.ControlPrintedSuccessfully.TabIndex = 1;
            this.ControlPrintedSuccessfully.Text = "button1";
            this.ControlPrintedSuccessfully.UseVisualStyleBackColor = true;
            this.ControlPrintedSuccessfully.Click += new System.EventHandler(this.bntYes_Click);
            // 
            // ControlPrintingFailed
            // 
            this.ControlPrintingFailed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ControlPrintingFailed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ControlPrintingFailed.Location = new System.Drawing.Point(0, 82);
            this.ControlPrintingFailed.Name = "ControlPrintingFailed";
            this.ControlPrintingFailed.Size = new System.Drawing.Size(686, 80);
            this.ControlPrintingFailed.TabIndex = 2;
            this.ControlPrintingFailed.Text = "button2";
            this.ControlPrintingFailed.UseVisualStyleBackColor = true;
            this.ControlPrintingFailed.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ControlPrintedSuccessfully);
            this.panel1.Controls.Add(this.ControlPrintingFailed);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 162);
            this.panel1.TabIndex = 3;
            // 
            // FormSendConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.outputInstruction);
            this.Name = "FormSendConfirmation";
            this.Text = "FormSendConfirmation";
            this.Load += new System.EventHandler(this.FormSendConfirmation_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputInstruction;
        private System.Windows.Forms.Button ControlPrintedSuccessfully;
        private System.Windows.Forms.Button ControlPrintingFailed;
        private System.Windows.Forms.Panel panel1;
    }
}