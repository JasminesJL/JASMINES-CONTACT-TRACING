namespace JASMINES__CONTACT_TRACING
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FillupButt = new System.Windows.Forms.Button();
            this.titlelabel = new System.Windows.Forms.Label();
            this.Title2label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FillupButt
            // 
            this.FillupButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FillupButt.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FillupButt.Location = new System.Drawing.Point(133, 374);
            this.FillupButt.Name = "FillupButt";
            this.FillupButt.Size = new System.Drawing.Size(259, 46);
            this.FillupButt.TabIndex = 0;
            this.FillupButt.Text = "Go to Fill up form --> ";
            this.FillupButt.UseVisualStyleBackColor = true;
            this.FillupButt.Click += new System.EventHandler(this.Subbutt_Click);
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.BackColor = System.Drawing.Color.Transparent;
            this.titlelabel.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titlelabel.Location = new System.Drawing.Point(12, 14);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(315, 79);
            this.titlelabel.TabIndex = 1;
            this.titlelabel.Text = "Contact";
            // 
            // Title2label
            // 
            this.Title2label.AutoSize = true;
            this.Title2label.BackColor = System.Drawing.Color.Transparent;
            this.Title2label.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title2label.Location = new System.Drawing.Point(193, 93);
            this.Title2label.Name = "Title2label";
            this.Title2label.Size = new System.Drawing.Size(305, 79);
            this.Title2label.TabIndex = 2;
            this.Title2label.Text = "TRACING";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(516, 604);
            this.Controls.Add(this.Title2label);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.FillupButt);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CONTACT TRACING";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button FillupButt;
        private Label titlelabel;
        private Label Title2label;
    }
}