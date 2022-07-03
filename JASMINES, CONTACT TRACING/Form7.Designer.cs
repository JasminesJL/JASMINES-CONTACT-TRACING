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
            this.components = new System.ComponentModel.Container();
            this.buttstart = new System.Windows.Forms.Button();
            this.LblCAM = new System.Windows.Forms.Label();
            this.cbxDEVICE = new System.Windows.Forms.ComboBox();
            this.pbxCAM = new System.Windows.Forms.PictureBox();
            this.txtQRSCAN = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCAM)).BeginInit();
            this.SuspendLayout();
            // 
            // buttstart
            // 
            this.buttstart.BackColor = System.Drawing.Color.Red;
            this.buttstart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttstart.ForeColor = System.Drawing.Color.White;
            this.buttstart.Location = new System.Drawing.Point(416, 64);
            this.buttstart.Name = "buttstart";
            this.buttstart.Size = new System.Drawing.Size(71, 26);
            this.buttstart.TabIndex = 0;
            this.buttstart.Text = "&Start";
            this.buttstart.UseVisualStyleBackColor = false;
            this.buttstart.Click += new System.EventHandler(this.BttSTART_Click);
            // 
            // LblCAM
            // 
            this.LblCAM.AutoSize = true;
            this.LblCAM.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LblCAM.Location = new System.Drawing.Point(32, 20);
            this.LblCAM.Name = "LblCAM";
            this.LblCAM.Size = new System.Drawing.Size(56, 17);
            this.LblCAM.TabIndex = 1;
            this.LblCAM.Text = "Camera:";
            // 
            // cbxDEVICE
            // 
            this.cbxDEVICE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDEVICE.FormattingEnabled = true;
            this.cbxDEVICE.Location = new System.Drawing.Point(85, 19);
            this.cbxDEVICE.Name = "cbxDEVICE";
            this.cbxDEVICE.Size = new System.Drawing.Size(197, 21);
            this.cbxDEVICE.TabIndex = 2;
            // 
            // pbxCAM
            // 
            this.pbxCAM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCAM.Location = new System.Drawing.Point(21, 52);
            this.pbxCAM.Name = "pbxCAM";
            this.pbxCAM.Size = new System.Drawing.Size(379, 287);
            this.pbxCAM.TabIndex = 3;
            this.pbxCAM.TabStop = false;
            // 
            // txtQRSCAN
            // 
            this.txtQRSCAN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtQRSCAN.Location = new System.Drawing.Point(416, 95);
            this.txtQRSCAN.Multiline = true;
            this.txtQRSCAN.Name = "txtQRSCAN";
            this.txtQRSCAN.Size = new System.Drawing.Size(265, 233);
            this.txtQRSCAN.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // F7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(693, 361);
            this.Controls.Add(this.txtQRSCAN);
            this.Controls.Add(this.pbxCAM);
            this.Controls.Add(this.cbxDEVICE);
            this.Controls.Add(this.LblCAM);
            this.Controls.Add(this.buttstart);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "F7";
            this.Text = "QR CODE SCANNER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F7_FormClosing);
            this.Load += new System.EventHandler(this.F7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttstart;
        private Label LblCAM;
        private ComboBox cbxDEVICE;
        private PictureBox pbxCAM;
        private TextBox txtQRSCAN;
        private System.Windows.Forms.Timer timer1;
    }
}