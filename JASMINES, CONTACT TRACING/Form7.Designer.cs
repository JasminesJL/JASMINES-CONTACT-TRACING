﻿namespace JASMINES__CONTACT_TRACING
{
    partial class F7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F7));
            this.buttSTART = new System.Windows.Forms.Button();
            this.LblCAM = new System.Windows.Forms.Label();
            this.cbxDEVICE = new System.Windows.Forms.ComboBox();
            this.pbxCAM = new System.Windows.Forms.PictureBox();
            this.txtQRSCAN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCAM)).BeginInit();
            this.SuspendLayout();
            // 
            // buttSTART
            // 
            this.buttSTART.Location = new System.Drawing.Point(485, 60);
            this.buttSTART.Name = "buttSTART";
            this.buttSTART.Size = new System.Drawing.Size(75, 23);
            this.buttSTART.TabIndex = 0;
            this.buttSTART.Text = "&Start";
            this.buttSTART.UseVisualStyleBackColor = true;
            // 
            // LblCAM
            // 
            this.LblCAM.AutoSize = true;
            this.LblCAM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCAM.Location = new System.Drawing.Point(37, 23);
            this.LblCAM.Name = "LblCAM";
            this.LblCAM.Size = new System.Drawing.Size(56, 17);
            this.LblCAM.TabIndex = 1;
            this.LblCAM.Text = "Camera:";
            // 
            // cbxDEVICE
            // 
            this.cbxDEVICE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDEVICE.FormattingEnabled = true;
            this.cbxDEVICE.Location = new System.Drawing.Point(99, 22);
            this.cbxDEVICE.Name = "cbxDEVICE";
            this.cbxDEVICE.Size = new System.Drawing.Size(229, 23);
            this.cbxDEVICE.TabIndex = 2;
            // 
            // pbxCAM
            // 
            this.pbxCAM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCAM.Location = new System.Drawing.Point(24, 60);
            this.pbxCAM.Name = "pbxCAM";
            this.pbxCAM.Size = new System.Drawing.Size(442, 331);
            this.pbxCAM.TabIndex = 3;
            this.pbxCAM.TabStop = false;
            // 
            // txtQRSCAN
            // 
            this.txtQRSCAN.Location = new System.Drawing.Point(485, 89);
            this.txtQRSCAN.Multiline = true;
            this.txtQRSCAN.Name = "txtQRSCAN";
            this.txtQRSCAN.Size = new System.Drawing.Size(308, 268);
            this.txtQRSCAN.TabIndex = 4;
            // 
            // F7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 417);
            this.Controls.Add(this.txtQRSCAN);
            this.Controls.Add(this.pbxCAM);
            this.Controls.Add(this.cbxDEVICE);
            this.Controls.Add(this.LblCAM);
            this.Controls.Add(this.buttSTART);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F7";
            this.Text = "QR CODE SCANNER";
            ((System.ComponentModel.ISupportInitialize)(this.pbxCAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttSTART;
        private Label LblCAM;
        private ComboBox cbxDEVICE;
        private PictureBox pbxCAM;
        private TextBox txtQRSCAN;
    }
}