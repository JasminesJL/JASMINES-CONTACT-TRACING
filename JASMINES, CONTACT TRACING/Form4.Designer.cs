namespace JASMINES__CONTACT_TRACING
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.lblShow = new System.Windows.Forms.Label();
            this.lblFC = new System.Windows.Forms.Label();
            this.ButtSADFC = new System.Windows.Forms.Button();
            this.lblFR = new System.Windows.Forms.Label();
            this.lblBDT = new System.Windows.Forms.Label();
            this.txtDT = new System.Windows.Forms.DateTimePicker();
            this.ButtFRD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.BackColor = System.Drawing.Color.Transparent;
            this.lblShow.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShow.Location = new System.Drawing.Point(335, 26);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(189, 27);
            this.lblShow.TabIndex = 0;
            this.lblShow.Text = "Show All Data";
            // 
            // lblFC
            // 
            this.lblFC.AutoSize = true;
            this.lblFC.BackColor = System.Drawing.Color.Transparent;
            this.lblFC.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFC.Location = new System.Drawing.Point(335, 53);
            this.lblFC.Name = "lblFC";
            this.lblFC.Size = new System.Drawing.Size(186, 27);
            this.lblFC.TabIndex = 1;
            this.lblFC.Text = "From  Contact";
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
            // lblFR
            // 
            this.lblFR.AutoSize = true;
            this.lblFR.BackColor = System.Drawing.Color.Transparent;
            this.lblFR.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFR.Location = new System.Drawing.Point(335, 278);
            this.lblFR.Name = "lblFR";
            this.lblFR.Size = new System.Drawing.Size(177, 27);
            this.lblFR.TabIndex = 3;
            this.lblFR.Text = "Filter Record";
            // 
            // lblBDT
            // 
            this.lblBDT.AutoSize = true;
            this.lblBDT.BackColor = System.Drawing.Color.Transparent;
            this.lblBDT.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBDT.Location = new System.Drawing.Point(367, 305);
            this.lblBDT.Name = "lblBDT";
            this.lblBDT.Size = new System.Drawing.Size(105, 27);
            this.lblBDT.TabIndex = 4;
            this.lblBDT.Text = "by Date";
            // 
            // txtDT
            // 
            this.txtDT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDT.Location = new System.Drawing.Point(294, 346);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(250, 27);
            this.txtDT.TabIndex = 5;
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(874, 506);
            this.Controls.Add(this.ButtFRD);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.lblBDT);
            this.Controls.Add(this.lblFR);
            this.Controls.Add(this.ButtSADFC);
            this.Controls.Add(this.lblFC);
            this.Controls.Add(this.lblShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "INFO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblShow;
        private Label lblFC;
        private Button ButtSADFC;
        private Label lblFR;
        private Label lblBDT;
        private DateTimePicker txtDT;
        private Button ButtFRD;
    }
}