﻿namespace JASMINES__CONTACT_TRACING
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F6));
            this.lblFRBD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFRBD
            // 
            this.lblFRBD.AutoSize = true;
            this.lblFRBD.BackColor = System.Drawing.Color.Transparent;
            this.lblFRBD.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFRBD.Location = new System.Drawing.Point(12, 9);
            this.lblFRBD.Name = "lblFRBD";
            this.lblFRBD.Size = new System.Drawing.Size(0, 15);
            this.lblFRBD.TabIndex = 4;
            // 
            // F6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(515, 656);
            this.Controls.Add(this.lblFRBD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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