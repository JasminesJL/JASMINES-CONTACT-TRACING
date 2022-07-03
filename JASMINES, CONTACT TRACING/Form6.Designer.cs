namespace JASMINES__CONTACT_TRACING
{
    partial class F6
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
            this.lblFRBD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFRBD
            // 
            this.lblFRBD.AutoSize = true;
            this.lblFRBD.BackColor = System.Drawing.Color.Transparent;
            this.lblFRBD.Font = new System.Drawing.Font("Cooper Black", 9.75F);
            this.lblFRBD.Location = new System.Drawing.Point(10, 8);
            this.lblFRBD.Name = "lblFRBD";
            this.lblFRBD.Size = new System.Drawing.Size(0, 15);
            this.lblFRBD.TabIndex = 4;
            // 
            // F6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(441, 569);
            this.Controls.Add(this.lblFRBD);
            this.Name = "F6";
            this.Text = "Record by Dates";
            this.Load += new System.EventHandler(this.F6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFRBD;
    }
}