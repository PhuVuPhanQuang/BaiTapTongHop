namespace BaiTap14
{
    partial class frmB14
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboSoCanh = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số ô/ 1 cạnh(3-10)";
            // 
            // cboSoCanh
            // 
            this.cboSoCanh.FormattingEnabled = true;
            this.cboSoCanh.Location = new System.Drawing.Point(36, 59);
            this.cboSoCanh.Name = "cboSoCanh";
            this.cboSoCanh.Size = new System.Drawing.Size(172, 24);
            this.cboSoCanh.TabIndex = 1;
            this.cboSoCanh.SelectedIndexChanged += new System.EventHandler(this.cboSoCanh_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(36, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 454);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(650, 577);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboSoCanh);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Phat sinh dong cac TextBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSoCanh;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

