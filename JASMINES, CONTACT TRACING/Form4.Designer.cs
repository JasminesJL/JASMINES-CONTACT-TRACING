namespace JASMINES__CONTACT_TRACING
{
    partial class F4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F4));
            this.LblSA = new System.Windows.Forms.Label();
            this.ButtSADFC = new System.Windows.Forms.Button();
            this.lblFRBD = new System.Windows.Forms.Label();
            this.txtDTF = new System.Windows.Forms.DateTimePicker();
            this.ButtFRD = new System.Windows.Forms.Button();
            this.ButtSCANQR = new System.Windows.Forms.Button();
            this.ButtGENERATE = new System.Windows.Forms.Button();
            this.LblQC = new System.Windows.Forms.Label();
            this.PBqr = new System.Windows.Forms.PictureBox();
            this.txtQRCODE = new System.Windows.Forms.TextBox();
            this.ButtSQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBqr)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSA
            // 
            this.LblSA.AutoSize = true;
            this.LblSA.BackColor = System.Drawing.Color.Transparent;
            this.LblSA.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSA.Location = new System.Drawing.Point(12, 9);
            this.LblSA.Name = "LblSA";
            this.LblSA.Size = new System.Drawing.Size(357, 27);
            this.LblSA.TabIndex = 0;
            this.LblSA.Text = "Show All Data from Contact";
            // 
            // ButtSADFC
            // 
            this.ButtSADFC.BackColor = System.Drawing.Color.Red;
            this.ButtSADFC.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtSADFC.ForeColor = System.Drawing.Color.White;
            this.ButtSADFC.Location = new System.Drawing.Point(112, 48);
            this.ButtSADFC.Name = "ButtSADFC";
            this.ButtSADFC.Size = new System.Drawing.Size(113, 40);
            this.ButtSADFC.TabIndex = 2;
            this.ButtSADFC.Text = "Proceed";
            this.ButtSADFC.UseVisualStyleBackColor = false;
            this.ButtSADFC.Click += new System.EventHandler(this.ButtSADFC_Click);
            // 
            // lblFRBD
            // 
            this.lblFRBD.AutoSize = true;
            this.lblFRBD.BackColor = System.Drawing.Color.Transparent;
            this.lblFRBD.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFRBD.Location = new System.Drawing.Point(35, 292);
            this.lblFRBD.Name = "lblFRBD";
            this.lblFRBD.Size = new System.Drawing.Size(276, 27);
            this.lblFRBD.TabIndex = 3;
            this.lblFRBD.Text = "Filter Record by Date";
            // 
            // txtDTF
            // 
            this.txtDTF.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDTF.Location = new System.Drawing.Point(53, 341);
            this.txtDTF.Name = "txtDTF";
            this.txtDTF.Size = new System.Drawing.Size(235, 27);
            this.txtDTF.TabIndex = 5;
            // 
            // ButtFRD
            // 
            this.ButtFRD.BackColor = System.Drawing.Color.Red;
            this.ButtFRD.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtFRD.ForeColor = System.Drawing.Color.White;
            this.ButtFRD.Location = new System.Drawing.Point(112, 384);
            this.ButtFRD.Name = "ButtFRD";
            this.ButtFRD.Size = new System.Drawing.Size(113, 40);
            this.ButtFRD.TabIndex = 6;
            this.ButtFRD.Text = "Proceed";
            this.ButtFRD.UseVisualStyleBackColor = false;
            this.ButtFRD.Click += new System.EventHandler(this.ButtFRD_Click);
            // 
            // ButtSCANQR
            // 
            this.ButtSCANQR.BackColor = System.Drawing.Color.Black;
            this.ButtSCANQR.ForeColor = System.Drawing.Color.White;
            this.ButtSCANQR.Location = new System.Drawing.Point(767, 446);
            this.ButtSCANQR.Name = "ButtSCANQR";
            this.ButtSCANQR.Size = new System.Drawing.Size(95, 48);
            this.ButtSCANQR.TabIndex = 7;
            this.ButtSCANQR.Text = "Scan QR Code";
            this.ButtSCANQR.UseVisualStyleBackColor = false;
            this.ButtSCANQR.Click += new System.EventHandler(this.ButtQR_Click);
            // 
            // ButtGENERATE
            // 
            this.ButtGENERATE.BackColor = System.Drawing.Color.Red;
            this.ButtGENERATE.ForeColor = System.Drawing.Color.White;
            this.ButtGENERATE.Location = new System.Drawing.Point(538, 384);
            this.ButtGENERATE.Name = "ButtGENERATE";
            this.ButtGENERATE.Size = new System.Drawing.Size(102, 36);
            this.ButtGENERATE.TabIndex = 8;
            this.ButtGENERATE.Text = "GENERATE";
            this.ButtGENERATE.UseVisualStyleBackColor = false;
            this.ButtGENERATE.Click += new System.EventHandler(this.ButtGENERATE_Click);
            // 
            // LblQC
            // 
            this.LblQC.AutoSize = true;
            this.LblQC.BackColor = System.Drawing.Color.Transparent;
            this.LblQC.Font = new System.Drawing.Font("Cooper Black", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LblQC.Location = new System.Drawing.Point(538, 30);
            this.LblQC.Name = "LblQC";
            this.LblQC.Size = new System.Drawing.Size(77, 20);
            this.LblQC.TabIndex = 9;
            this.LblQC.Text = "Qr Code";
            // 
            // PBqr
            // 
            this.PBqr.BackColor = System.Drawing.Color.White;
            this.PBqr.Location = new System.Drawing.Point(538, 62);
            this.PBqr.Name = "PBqr";
            this.PBqr.Size = new System.Drawing.Size(259, 224);
            this.PBqr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBqr.TabIndex = 10;
            this.PBqr.TabStop = false;
            // 
            // txtQRCODE
            // 
            this.txtQRCODE.Location = new System.Drawing.Point(538, 299);
            this.txtQRCODE.Multiline = true;
            this.txtQRCODE.Name = "txtQRCODE";
            this.txtQRCODE.Size = new System.Drawing.Size(259, 62);
            this.txtQRCODE.TabIndex = 11;
            // 
            // ButtSQR
            // 
            this.ButtSQR.BackColor = System.Drawing.Color.Black;
            this.ButtSQR.ForeColor = System.Drawing.Color.White;
            this.ButtSQR.Location = new System.Drawing.Point(695, 384);
            this.ButtSQR.Name = "ButtSQR";
            this.ButtSQR.Size = new System.Drawing.Size(102, 36);
            this.ButtSQR.TabIndex = 12;
            this.ButtSQR.Text = "Save QR";
            this.ButtSQR.UseVisualStyleBackColor = false;
            this.ButtSQR.Click += new System.EventHandler(this.ButtSQR_Click);
            // 
            // F4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(874, 506);
            this.Controls.Add(this.ButtSQR);
            this.Controls.Add(this.txtQRCODE);
            this.Controls.Add(this.PBqr);
            this.Controls.Add(this.LblQC);
            this.Controls.Add(this.ButtGENERATE);
            this.Controls.Add(this.ButtSCANQR);
            this.Controls.Add(this.ButtFRD);
            this.Controls.Add(this.txtDTF);
            this.Controls.Add(this.lblFRBD);
            this.Controls.Add(this.ButtSADFC);
            this.Controls.Add(this.LblSA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F4";
            this.Text = "ADMIN ONLY";
            ((System.ComponentModel.ISupportInitialize)(this.PBqr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblSA;
        private Button ButtSADFC;
        private Label lblFRBD;
        private DateTimePicker txtDTF;
        private Button ButtFRD;
        private Button ButtSCANQR;
        private Button ButtGENERATE;
        private Label LblQC;
        private PictureBox PBqr;
        private TextBox txtQRCODE;
        private Button ButtSQR;
    }
}