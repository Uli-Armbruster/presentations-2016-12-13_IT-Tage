using System.Drawing;
using System.Windows.Forms;

namespace SmartGateIn.UI.SystemForms
{
    partial class FormProcessError
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
        private void InitializeComponent()
        {
            ControlProcessErrorMessage = new Label();
            ControlConfirm = new Button();
            ControlExceptionMessage = new Label();
            SuspendLayout();

            // 
            // ControlProcessErrorMessage
            // 
            ControlProcessErrorMessage.Dock = DockStyle.Fill;
            ControlProcessErrorMessage.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ControlProcessErrorMessage.Location = new Point(0, 0);
            ControlProcessErrorMessage.Margin = new Padding(7, 0, 7, 0);
            ControlProcessErrorMessage.Name = "ControlProcessErrorMessage";
            ControlProcessErrorMessage.Size = new Size(1008, 729);
            ControlProcessErrorMessage.TabIndex = 0;
            ControlProcessErrorMessage.Text = "label1";
            ControlProcessErrorMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ControlConfirm
            // 
            ControlConfirm.Dock = DockStyle.Bottom;
            ControlConfirm.Location = new Point(0, 602);
            ControlConfirm.Margin = new Padding(7);
            ControlConfirm.Name = "ControlConfirm";
            ControlConfirm.Size = new Size(1008, 127);
            ControlConfirm.TabIndex = 1;
            ControlConfirm.Text = "button1";
            ControlConfirm.UseVisualStyleBackColor = true;
            ControlConfirm.Click += ControlConfirm_Click;
            // 
            // ControlExceptionMessage
            // 
            ControlExceptionMessage.Dock = DockStyle.Top;
            ControlExceptionMessage.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ControlExceptionMessage.Location = new Point(0, 0);
            ControlExceptionMessage.Margin = new Padding(7, 0, 7, 0);
            ControlExceptionMessage.Name = "ControlExceptionMessage";
            ControlExceptionMessage.Size = new Size(1008, 92);
            ControlExceptionMessage.TabIndex = 3;
            ControlExceptionMessage.Text = "label3";
            ControlExceptionMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormProcessError
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(ControlExceptionMessage);
            Controls.Add(ControlConfirm);
            Controls.Add(ControlProcessErrorMessage);
            Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7);
            Name = "FormProcessError";
            Text = "Process Error";
            Load += FormProcessError_Load;
            Shown += FormProcessError_Shown;
            ResumeLayout(false);
        }

        #endregion

        private Label ControlProcessErrorMessage;
        private Button ControlConfirm;
        private Label ControlExceptionMessage;
    }
}