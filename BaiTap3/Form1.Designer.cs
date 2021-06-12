namespace BaiTap3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_BoQua = new System.Windows.Forms.Button();
            this.btn_LietKe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NhapN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_danhsach = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.btn_BoQua);
            this.panel1.Controls.Add(this.btn_LietKe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_NhapN);
            this.panel1.Location = new System.Drawing.Point(19, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 86);
            this.panel1.TabIndex = 0;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Thoat.Location = new System.Drawing.Point(373, 46);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(90, 27);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_BoQua
            // 
            this.btn_BoQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_BoQua.Location = new System.Drawing.Point(262, 46);
            this.btn_BoQua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_BoQua.Name = "btn_BoQua";
            this.btn_BoQua.Size = new System.Drawing.Size(90, 27);
            this.btn_BoQua.TabIndex = 2;
            this.btn_BoQua.Text = "Bỏ Qua";
            this.btn_BoQua.UseVisualStyleBackColor = false;
            this.btn_BoQua.Click += new System.EventHandler(this.btn_BoQua_Click);
            // 
            // btn_LietKe
            // 
            this.btn_LietKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_LietKe.Location = new System.Drawing.Point(147, 48);
            this.btn_LietKe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_LietKe.Name = "btn_LietKe";
            this.btn_LietKe.Size = new System.Drawing.Size(90, 27);
            this.btn_LietKe.TabIndex = 2;
            this.btn_LietKe.Text = "Liệt Kê";
            this.btn_LietKe.UseVisualStyleBackColor = false;
            this.btn_LietKe.Click += new System.EventHandler(this.btn_LietKe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập N:";
            // 
            // txt_NhapN
            // 
            this.txt_NhapN.Location = new System.Drawing.Point(21, 48);
            this.txt_NhapN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_NhapN.Name = "txt_NhapN";
            this.txt_NhapN.Size = new System.Drawing.Size(107, 27);
            this.txt_NhapN.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_danhsach);
            this.groupBox1.Location = new System.Drawing.Point(19, 111);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(602, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các số nguyên tố:";
            // 
            // txt_tong
            // 
            this.txt_tong.Location = new System.Drawing.Point(521, 210);
            this.txt_tong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tong.Name = "txt_tong";
            this.txt_tong.Size = new System.Drawing.Size(77, 27);
            this.txt_tong.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng Cộng:";
            // 
            // txt_danhsach
            // 
            this.txt_danhsach.Location = new System.Drawing.Point(12, 24);
            this.txt_danhsach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_danhsach.Multiline = true;
            this.txt_danhsach.Name = "txt_danhsach";
            this.txt_danhsach.Size = new System.Drawing.Size(586, 178);
            this.txt_danhsach.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Liệt kê danh sách nguyên tố";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_BoQua;
        private System.Windows.Forms.Button btn_LietKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NhapN;
        private System.Windows.Forms.TextBox txt_tong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_danhsach;
    }
}

