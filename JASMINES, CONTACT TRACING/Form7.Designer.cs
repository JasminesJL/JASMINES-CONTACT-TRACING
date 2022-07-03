namespace JASMINES__CONTACT_TRACING
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
            this.buttREAD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCAM)).BeginInit();
            this.SuspendLayout();
            // 
            // buttSTART
            // 
            this.buttSTART.BackColor = System.Drawing.Color.Red;
            this.buttSTART.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttSTART.ForeColor = System.Drawing.Color.White;
            this.buttSTART.Location = new System.Drawing.Point(485, 74);
            this.buttSTART.Name = "buttSTART";
            this.buttSTART.Size = new System.Drawing.Size(83, 30);
            this.buttSTART.TabIndex = 0;
            this.buttSTART.Text = "&Start";
            this.buttSTART.UseVisualStyleBackColor = false;
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
            this.txtQRSCAN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQRSCAN.Location = new System.Drawing.Point(485, 110);
            this.txtQRSCAN.Multiline = true;
            this.txtQRSCAN.Name = "txtQRSCAN";
            this.txtQRSCAN.Size = new System.Drawing.Size(308, 268);
            this.txtQRSCAN.TabIndex = 4;
            // 
            // buttREAD
            // 
            this.buttREAD.BackColor = System.Drawing.Color.Red;
            this.buttREAD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttREAD.ForeColor = System.Drawing.Color.White;
            this.buttREAD.Location = new System.Drawing.Point(695, 74);
            this.buttREAD.Name = "buttREAD";
            this.buttREAD.Size = new System.Drawing.Size(83, 30);
            this.buttREAD.TabIndex = 5;
            this.buttREAD.Text = "Read";
            this.buttREAD.UseVisualStyleBackColor = false;
            // 
            // F7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(809, 417);
            this.Controls.Add(this.buttREAD);
            this.Controls.Add(this.txtQRSCAN);
            this.Controls.Add(this.pbxCAM);
            this.Controls.Add(this.cbxDEVICE);
            this.Controls.Add(this.LblCAM);
            this.Controls.Add(this.buttSTART);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
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
        private Button buttREAD;
    }
}