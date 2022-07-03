namespace JASMINES__CONTACT_TRACING
{
    partial class F5
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
            this.LblSA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblSA
            // 
            this.LblSA.AutoSize = true;
            this.LblSA.BackColor = System.Drawing.Color.Transparent;
            this.LblSA.Font = new System.Drawing.Font("Cooper Black", 9.75F);
            this.LblSA.Location = new System.Drawing.Point(14, 12);
            this.LblSA.Name = "LblSA";
            this.LblSA.Size = new System.Drawing.Size(0, 15);
            this.LblSA.TabIndex = 1;
            // 
            // F5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(516, 653);
            this.Controls.Add(this.LblSA);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "F5";
            this.Text = "All Gathered Info";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblSA;
    }
}