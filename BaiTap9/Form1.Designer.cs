namespace BaiTap9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Tinh = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.txt_NhapSND = new System.Windows.Forms.TextBox();
            this.txt_KetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số nguyên dương:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kết quả:";
            // 
            // btn_Tinh
            // 
            this.btn_Tinh.BackColor = System.Drawing.Color.Lime;
            this.btn_Tinh.Location = new System.Drawing.Point(448, 21);
            this.btn_Tinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Tinh.Name = "btn_Tinh";
            this.btn_Tinh.Size = new System.Drawing.Size(86, 31);
            this.btn_Tinh.TabIndex = 1;
            this.btn_Tinh.Text = "Tính";
            this.btn_Tinh.UseVisualStyleBackColor = false;
            this.btn_Tinh.Click += new System.EventHandler(this.btn_Tinh_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Red;
            this.btn_Thoat.Location = new System.Drawing.Point(448, 77);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(86, 31);
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // txt_NhapSND
            // 
            this.txt_NhapSND.Location = new System.Drawing.Point(185, 28);
            this.txt_NhapSND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NhapSND.Name = "txt_NhapSND";
            this.txt_NhapSND.Size = new System.Drawing.Size(233, 27);
            this.txt_NhapSND.TabIndex = 2;
            // 
            // txt_KetQua
            // 
            this.txt_KetQua.Location = new System.Drawing.Point(14, 121);
            this.txt_KetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_KetQua.Multiline = true;
            this.txt_KetQua.Name = "txt_KetQua";
            this.txt_KetQua.Size = new System.Drawing.Size(534, 105);
            this.txt_KetQua.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(562, 244);
            this.Controls.Add(this.txt_KetQua);
            this.Controls.Add(this.txt_NhapSND);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Tinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Tìm số nguyên tố";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Tinh;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox txt_NhapSND;
        private System.Windows.Forms.TextBox txt_KetQua;
    }
}

