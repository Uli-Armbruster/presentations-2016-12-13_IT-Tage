using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SmartGateIn.UI.SystemForms
{
    partial class FormInitialScreen
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
            this.btnStart = new System.Windows.Forms.Button();
            this.outputInstruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStart.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(0, 618);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(1008, 111);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "press to continue";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // outputInstruction
            // 
            this.outputInstruction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputInstruction.Font = new System.Drawing.Font("Consolas", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputInstruction.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.outputInstruction.Location = new System.Drawing.Point(0, 0);
            this.outputInstruction.Name = "outputInstruction";
            this.outputInstruction.Size = new System.Drawing.Size(1008, 618);
            this.outputInstruction.TabIndex = 1;
            this.outputInstruction.Text = "label1";
            this.outputInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInitialScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.outputInstruction);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormInitialScreen";
            this.Text = "Smart Gate In";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInitialScreen_FormClosing);
            this.Shown += new System.EventHandler(this.FormInitialScreen_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnStart;
        private Label outputInstruction;
    }
}