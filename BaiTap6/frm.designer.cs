namespace BT6
{
    partial class frm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNhapMang = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btn_NhapN = new System.Windows.Forms.Button();
            this.btn_tinhtong = new System.Windows.Forms.Button();
            this.btn_MinMax = new System.Windows.Forms.Button();
            this.btn_DemChan = new System.Windows.Forms.Button();
            this.btn_DemLe = new System.Windows.Forms.Button();
            this.btn_XuatSNT = new System.Windows.Forms.Button();
            this.btn_KetThuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhapMang);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mảng nhập:";
            // 
            // txtNhapMang
            // 
            this.txtNhapMang.Enabled = false;
            this.txtNhapMang.Location = new System.Drawing.Point(9, 31);
            this.txtNhapMang.Multiline = true;
            this.txtNhapMang.Name = "txtNhapMang";
            this.txtNhapMang.Size = new System.Drawing.Size(453, 116);
            this.txtNhapMang.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKetQua);
            this.groupBox2.Location = new System.Drawing.Point(492, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 153);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả tính toán:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Enabled = false;
            this.txtKetQua.Location = new System.Drawing.Point(6, 30);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(439, 116);
            this.txtKetQua.TabIndex = 0;
            // 
            // btn_NhapN
            // 
            this.btn_NhapN.BackColor = System.Drawing.Color.Aqua;
            this.btn_NhapN.Location = new System.Drawing.Point(24, 195);
            this.btn_NhapN.Name = "btn_NhapN";
            this.btn_NhapN.Size = new System.Drawing.Size(453, 35);
            this.btn_NhapN.TabIndex = 1;
            this.btn_NhapN.Text = "Nhập mảng";
            this.btn_NhapN.UseVisualStyleBackColor = false;
            this.btn_NhapN.Click += new System.EventHandler(this.btn_NhapN_Click);
            // 
            // btn_tinhtong
            // 
            this.btn_tinhtong.BackColor = System.Drawing.Color.Aqua;
            this.btn_tinhtong.Location = new System.Drawing.Point(24, 263);
            this.btn_tinhtong.Name = "btn_tinhtong";
            this.btn_tinhtong.Size = new System.Drawing.Size(453, 35);
            this.btn_tinhtong.TabIndex = 1;
            this.btn_tinhtong.Text = "Tính tổng mảng";
            this.btn_tinhtong.UseVisualStyleBackColor = false;
            this.btn_tinhtong.Click += new System.EventHandler(this.btn_tinhtong_Click);
            // 
            // btn_MinMax
            // 
            this.btn_MinMax.BackColor = System.Drawing.Color.Aqua;
            this.btn_MinMax.Location = new System.Drawing.Point(24, 333);
            this.btn_MinMax.Name = "btn_MinMax";
            this.btn_MinMax.Size = new System.Drawing.Size(453, 35);
            this.btn_MinMax.TabIndex = 1;
            this.btn_MinMax.Text = "Tìm Max-Min của mảng";
            this.btn_MinMax.UseVisualStyleBackColor = false;
            this.btn_MinMax.Click += new System.EventHandler(this.btn_MinMax_Click);
            // 
            // btn_DemChan
            // 
            this.btn_DemChan.BackColor = System.Drawing.Color.Aqua;
            this.btn_DemChan.Location = new System.Drawing.Point(492, 195);
            this.btn_DemChan.Name = "btn_DemChan";
            this.btn_DemChan.Size = new System.Drawing.Size(453, 35);
            this.btn_DemChan.TabIndex = 1;
            this.btn_DemChan.Text = "Đếm phần tử chẵn";
            this.btn_DemChan.UseVisualStyleBackColor = false;
            this.btn_DemChan.Click += new System.EventHandler(this.btn_DemChan_Click);
            // 
            // btn_DemLe
            // 
            this.btn_DemLe.BackColor = System.Drawing.Color.Aqua;
            this.btn_DemLe.Location = new System.Drawing.Point(492, 263);
            this.btn_DemLe.Name = "btn_DemLe";
            this.btn_DemLe.Size = new System.Drawing.Size(453, 35);
            this.btn_DemLe.TabIndex = 1;
            this.btn_DemLe.Text = "Xuất các phần tủ lẻ";
            this.btn_DemLe.UseVisualStyleBackColor = false;
            this.btn_DemLe.Click += new System.EventHandler(this.btn_DemLe_Click);
            // 
            // btn_XuatSNT
            // 
            this.btn_XuatSNT.BackColor = System.Drawing.Color.Aqua;
            this.btn_XuatSNT.Location = new System.Drawing.Point(492, 333);
            this.btn_XuatSNT.Name = "btn_XuatSNT";
            this.btn_XuatSNT.Size = new System.Drawing.Size(453, 35);
            this.btn_XuatSNT.TabIndex = 1;
            this.btn_XuatSNT.Text = "Xuất các số nguyên tố";
            this.btn_XuatSNT.UseVisualStyleBackColor = false;
            this.btn_XuatSNT.Click += new System.EventHandler(this.btn_XuatSNT_Click);
            // 
            // btn_KetThuc
            // 
            this.btn_KetThuc.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_KetThuc.Location = new System.Drawing.Point(387, 393);
            this.btn_KetThuc.Name = "btn_KetThuc";
            this.btn_KetThuc.Size = new System.Drawing.Size(192, 35);
            this.btn_KetThuc.TabIndex = 1;
            this.btn_KetThuc.Text = "Kết Thúc";
            this.btn_KetThuc.UseVisualStyleBackColor = false;
            this.btn_KetThuc.Click += new System.EventHandler(this.btn_KetThuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.btn_KetThuc);
            this.Controls.Add(this.btn_XuatSNT);
            this.Controls.Add(this.btn_DemLe);
            this.Controls.Add(this.btn_DemChan);
            this.Controls.Add(this.btn_MinMax);
            this.Controls.Add(this.btn_tinhtong);
            this.Controls.Add(this.btn_NhapN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "Form1";
            this.Text = "Xử lý mảng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNhapMang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btn_NhapN;
        private System.Windows.Forms.Button btn_tinhtong;
        private System.Windows.Forms.Button btn_MinMax;
        private System.Windows.Forms.Button btn_DemChan;
        private System.Windows.Forms.Button btn_DemLe;
        private System.Windows.Forms.Button btn_XuatSNT;
        private System.Windows.Forms.Button btn_KetThuc;
    }
}

