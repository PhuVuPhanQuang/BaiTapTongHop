namespace BaiTap8
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_SapXep = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(43, 50);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(344, 34);
            this.txtNhap.TabIndex = 0;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Enabled = false;
            this.txtKetQua.Location = new System.Drawing.Point(43, 155);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(344, 34);
            this.txtKetQua.TabIndex = 0;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Lime;
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Location = new System.Drawing.Point(439, 50);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(118, 43);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_SapXep
            // 
            this.btn_SapXep.BackColor = System.Drawing.Color.Lime;
            this.btn_SapXep.Enabled = false;
            this.btn_SapXep.Location = new System.Drawing.Point(439, 122);
            this.btn_SapXep.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_SapXep.Name = "btn_SapXep";
            this.btn_SapXep.Size = new System.Drawing.Size(118, 43);
            this.btn_SapXep.TabIndex = 2;
            this.btn_SapXep.Text = "Sắp xếp";
            this.btn_SapXep.UseVisualStyleBackColor = false;
            this.btn_SapXep.Click += new System.EventHandler(this.btn_SapXep_Click_1);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Red;
            this.btn_Thoat.Location = new System.Drawing.Point(439, 196);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(118, 43);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập các số cần sắp xếp ( cách nhau bởi khoảng trắng )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kết quả sau khi sắp xếp tăng:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(600, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_SapXep);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtNhap);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "Xử lý chuỗi & Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_SapXep;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

