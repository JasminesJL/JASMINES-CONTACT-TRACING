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
            this.SuspendLayout();
            // 
            // LblSA
            // 
            this.LblSA.AutoSize = true;
            this.LblSA.BackColor = System.Drawing.Color.Transparent;
            this.LblSA.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSA.Location = new System.Drawing.Point(242, 46);
            this.LblSA.Name = "LblSA";
            this.LblSA.Size = new System.Drawing.Size(357, 27);
            this.LblSA.TabIndex = 0;
            this.LblSA.Text = "Show All Data from Contact";
            // 
            // ButtSADFC
            // 
            this.ButtSADFC.BackColor = System.Drawing.SystemColors.Info;
            this.ButtSADFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtSADFC.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtSADFC.Location = new System.Drawing.Point(367, 93);
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
            this.lblFRBD.Location = new System.Drawing.Point(284, 294);
            this.lblFRBD.Name = "lblFRBD";
            this.lblFRBD.Size = new System.Drawing.Size(276, 27);
            this.lblFRBD.TabIndex = 3;
            this.lblFRBD.Text = "Filter Record by Date";
            // 
            // txtDTF
            // 
            this.txtDTF.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDTF.Location = new System.Drawing.Point(300, 341);
            this.txtDTF.Name = "txtDTF";
            this.txtDTF.Size = new System.Drawing.Size(235, 27);
            this.txtDTF.TabIndex = 5;
            // 
            // ButtFRD
            // 
            this.ButtFRD.BackColor = System.Drawing.SystemColors.Info;
            this.ButtFRD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtFRD.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtFRD.Location = new System.Drawing.Point(359, 391);
            this.ButtFRD.Name = "ButtFRD";
            this.ButtFRD.Size = new System.Drawing.Size(113, 40);
            this.ButtFRD.TabIndex = 6;
            this.ButtFRD.Text = "Proceed";
            this.ButtFRD.UseVisualStyleBackColor = false;
            this.ButtFRD.Click += new System.EventHandler(this.ButtFRD_Click);
            // 
            // F4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(874, 506);
            this.Controls.Add(this.ButtFRD);
            this.Controls.Add(this.txtDTF);
            this.Controls.Add(this.lblFRBD);
            this.Controls.Add(this.ButtSADFC);
            this.Controls.Add(this.LblSA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F4";
            this.Text = "ADMIN ONLY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblSA;
        private Button ButtSADFC;
        private Label lblFRBD;
        private DateTimePicker txtDTF;
        private Button ButtFRD;
    }
}