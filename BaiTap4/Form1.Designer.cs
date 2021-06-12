namespace BaiTap4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.lbKhungKetQua = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_xoacuoi = new System.Windows.Forms.Button();
            this.btn_XoaDau = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_LeCuoi = new System.Windows.Forms.Button();
            this.btn_ChanDau = new System.Windows.Forms.Button();
            this.btn_Cong2 = new System.Windows.Forms.Button();
            this.btn_KetThuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số nguyên:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 27);
            this.textBox1.TabIndex = 1;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(406, 17);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(90, 27);
            this.btn_CapNhat.TabIndex = 2;
            this.btn_CapNhat.Text = "Cập Nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // lbKhungKetQualbKhungKetQua
            // 
            this.lbKhungKetQua.Location = new System.Drawing.Point(23, 68);
            this.lbKhungKetQua.Margin = new System.Windows.Forms.Padding(2);
            //this.lbKhungKetQua.Multiline = true;
            this.lbKhungKetQua.Name = "lbKhungKetQua";
            this.lbKhungKetQua.Size = new System.Drawing.Size(186, 333);
            this.lbKhungKetQua.TabIndex = 3;
            this.lbKhungKetQua.TextChanged += new System.EventHandler(this.lbKhungKetQua_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xoacuoi);
            this.groupBox1.Controls.Add(this.btn_XoaDau);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_LeCuoi);
            this.groupBox1.Controls.Add(this.btn_ChanDau);
            this.groupBox1.Controls.Add(this.btn_Cong2);
            this.groupBox1.Location = new System.Drawing.Point(225, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(270, 332);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btn_xoacuoi
            // 
            this.btn_xoacuoi.Location = new System.Drawing.Point(30, 265);
            this.btn_xoacuoi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoacuoi.Name = "btn_xoacuoi";
            this.btn_xoacuoi.Size = new System.Drawing.Size(224, 27);
            this.btn_xoacuoi.TabIndex = 0;
            this.btn_xoacuoi.Text = "xóa phần tử cuối";
            this.btn_xoacuoi.UseVisualStyleBackColor = true;
            this.btn_xoacuoi.Click += new System.EventHandler(this.btn_xoacuoi_Click);
            // 
            // btn_XoaDau
            // 
            this.btn_XoaDau.Location = new System.Drawing.Point(30, 218);
            this.btn_XoaDau.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XoaDau.Name = "btn_XoaDau";
            this.btn_XoaDau.Size = new System.Drawing.Size(224, 27);
            this.btn_XoaDau.TabIndex = 0;
            this.btn_XoaDau.Text = "xóa phần tử đầu";
            this.btn_XoaDau.UseVisualStyleBackColor = true;
            this.btn_XoaDau.Click += new System.EventHandler(this.btn_XoaDau_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(30, 169);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(224, 27);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "xóa phần tử đang chọn";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_LeCuoi
            // 
            this.btn_LeCuoi.Location = new System.Drawing.Point(30, 123);
            this.btn_LeCuoi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LeCuoi.Name = "btn_LeCuoi";
            this.btn_LeCuoi.Size = new System.Drawing.Size(224, 27);
            this.btn_LeCuoi.TabIndex = 0;
            this.btn_LeCuoi.Text = "chọn số lẻ cuối";
            this.btn_LeCuoi.UseVisualStyleBackColor = true;
            this.btn_LeCuoi.Click += new System.EventHandler(this.btn_LeCuoi_Click);
            // 
            // btn_ChanDau
            // 
            this.btn_ChanDau.Location = new System.Drawing.Point(30, 76);
            this.btn_ChanDau.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ChanDau.Name = "btn_ChanDau";
            this.btn_ChanDau.Size = new System.Drawing.Size(224, 27);
            this.btn_ChanDau.TabIndex = 0;
            this.btn_ChanDau.Text = "chọn số chẵn đầu";
            this.btn_ChanDau.UseVisualStyleBackColor = true;
            this.btn_ChanDau.Click += new System.EventHandler(this.btn_ChanDau_Click);
            // 
            // btn_Cong2
            // 
            this.btn_Cong2.Location = new System.Drawing.Point(30, 31);
            this.btn_Cong2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cong2.Name = "btn_Cong2";
            this.btn_Cong2.Size = new System.Drawing.Size(224, 27);
            this.btn_Cong2.TabIndex = 0;
            this.btn_Cong2.Text = "Tăng mỗi phần tử lên 2";
            this.btn_Cong2.UseVisualStyleBackColor = true;
            this.btn_Cong2.Click += new System.EventHandler(this.btn_Cong2_Click);
            // 
            // btn_KetThuc
            // 
            this.btn_KetThuc.Location = new System.Drawing.Point(23, 407);
            this.btn_KetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_KetThuc.Name = "btn_KetThuc";
            this.btn_KetThuc.Size = new System.Drawing.Size(472, 27);
            this.btn_KetThuc.TabIndex = 0;
            this.btn_KetThuc.Text = "Kết Thúc";
            this.btn_KetThuc.UseVisualStyleBackColor = true;
            this.btn_KetThuc.Click += new System.EventHandler(this.btn_KetThuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 444);
            this.Controls.Add(this.btn_KetThuc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbKhungKetQua);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form5";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.ListBox lbKhungKetQua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_xoacuoi;
        private System.Windows.Forms.Button btn_XoaDau;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_ChanDau;
        private System.Windows.Forms.Button btn_Cong2;
        private System.Windows.Forms.Button btn_KetThuc;
        private System.Windows.Forms.Button btn_LeCuoi;
    }
}

