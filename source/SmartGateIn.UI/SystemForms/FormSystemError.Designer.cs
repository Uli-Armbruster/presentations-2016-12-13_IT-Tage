namespace SmartGateIn.UI.SystemForms
{
    partial class FormSystemError
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
            this.output_SystemDown = new System.Windows.Forms.Label();
            this.output_ErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // output_SystemDown
            // 
            this.output_SystemDown.AutoSize = true;
            this.output_SystemDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output_SystemDown.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_SystemDown.Location = new System.Drawing.Point(0, 0);
            this.output_SystemDown.Name = "output_SystemDown";
            this.output_SystemDown.Size = new System.Drawing.Size(131, 40);
            this.output_SystemDown.TabIndex = 0;
            this.output_SystemDown.Text = "label1";
            // 
            // output_ErrorMessage
            // 
            this.output_ErrorMessage.AutoSize = true;
            this.output_ErrorMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.output_ErrorMessage.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_ErrorMessage.Location = new System.Drawing.Point(0, 697);
            this.output_ErrorMessage.Name = "output_ErrorMessage";
            this.output_ErrorMessage.Size = new System.Drawing.Size(105, 32);
            this.output_ErrorMessage.TabIndex = 1;
            this.output_ErrorMessage.Text = "label2";
            this.output_ErrorMessage.Click += new System.EventHandler(this.output_ErrorMessage_Click);
            // 
            // FormSystemError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.output_ErrorMessage);
            this.Controls.Add(this.output_SystemDown);
            this.Name = "FormSystemError";
            this.Text = "System Error";
            this.Load += new System.EventHandler(this.FormError_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label output_SystemDown;
        private System.Windows.Forms.Label output_ErrorMessage;
    }
}