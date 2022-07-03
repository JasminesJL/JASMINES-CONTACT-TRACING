namespace JASMINES__CONTACT_TRACING
{
    partial class F3
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
            this.lblLOGIN = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttLOGIN = new System.Windows.Forms.Button();
            this.lblEXIT = new System.Windows.Forms.Label();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.LblUSER = new System.Windows.Forms.Label();
            this.LblPASS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLOGIN
            // 
            this.lblLOGIN.AutoSize = true;
            this.lblLOGIN.BackColor = System.Drawing.Color.Transparent;
            this.lblLOGIN.Font = new System.Drawing.Font("Cooper Black", 26.25F);
            this.lblLOGIN.Location = new System.Drawing.Point(49, 92);
            this.lblLOGIN.Name = "lblLOGIN";
            this.lblLOGIN.Size = new System.Drawing.Size(286, 40);
            this.lblLOGIN.TabIndex = 0;
            this.lblLOGIN.Text = "ADMIN LOG IN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(87, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 2);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(87, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 2);
            this.panel2.TabIndex = 2;
            // 
            // buttLOGIN
            // 
            this.buttLOGIN.BackColor = System.Drawing.Color.Black;
            this.buttLOGIN.FlatAppearance.BorderSize = 0;
            this.buttLOGIN.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttLOGIN.ForeColor = System.Drawing.Color.White;
            this.buttLOGIN.Location = new System.Drawing.Point(81, 369);
            this.buttLOGIN.Name = "buttLOGIN";
            this.buttLOGIN.Size = new System.Drawing.Size(207, 29);
            this.buttLOGIN.TabIndex = 3;
            this.buttLOGIN.Text = "LOG IN";
            this.buttLOGIN.UseVisualStyleBackColor = false;
            this.buttLOGIN.Click += new System.EventHandler(this.ButtLOGIN_Click);
            // 
            // lblEXIT
            // 
            this.lblEXIT.AutoSize = true;
            this.lblEXIT.BackColor = System.Drawing.Color.Red;
            this.lblEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblEXIT.ForeColor = System.Drawing.Color.White;
            this.lblEXIT.Location = new System.Drawing.Point(163, 421);
            this.lblEXIT.Name = "lblEXIT";
            this.lblEXIT.Size = new System.Drawing.Size(49, 20);
            this.lblEXIT.TabIndex = 4;
            this.lblEXIT.Text = "EXIT";
            this.lblEXIT.Click += new System.EventHandler(this.LblEXIT_Click);
            // 
            // txtUN
            // 
            this.txtUN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtUN.ForeColor = System.Drawing.Color.Black;
            this.txtUN.Location = new System.Drawing.Point(119, 228);
            this.txtUN.Multiline = true;
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(170, 21);
            this.txtUN.TabIndex = 5;
            // 
            // txtPW
            // 
            this.txtPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtPW.ForeColor = System.Drawing.Color.Black;
            this.txtPW.Location = new System.Drawing.Point(117, 304);
            this.txtPW.Multiline = true;
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(170, 21);
            this.txtPW.TabIndex = 6;
            // 
            // LblUSER
            // 
            this.LblUSER.AutoSize = true;
            this.LblUSER.Location = new System.Drawing.Point(53, 232);
            this.LblUSER.Name = "LblUSER";
            this.LblUSER.Size = new System.Drawing.Size(60, 13);
            this.LblUSER.TabIndex = 7;
            this.LblUSER.Text = "UserName:";
            // 
            // LblPASS
            // 
            this.LblPASS.AutoSize = true;
            this.LblPASS.Location = new System.Drawing.Point(55, 308);
            this.LblPASS.Name = "LblPASS";
            this.LblPASS.Size = new System.Drawing.Size(56, 13);
            this.LblPASS.TabIndex = 8;
            this.LblPASS.Text = "Password:";
            // 
            // F3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(402, 509);
            this.Controls.Add(this.LblPASS);
            this.Controls.Add(this.LblUSER);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtUN);
            this.Controls.Add(this.lblEXIT);
            this.Controls.Add(this.buttLOGIN);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLOGIN);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "F3";
            this.Text = "LOG IN ";
            this.Load += new System.EventHandler(this.Loginform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLOGIN;
        private Panel panel1;
        private Panel panel2;
        private Button buttLOGIN;
        private Label lblEXIT;
        private TextBox txtUN;
        private TextBox txtPW;
        private Label LblUSER;
        private Label LblPASS;
    }
}