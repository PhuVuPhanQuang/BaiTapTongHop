namespace Mua_sách
{
    partial class frmsach
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
            this.lv_DonGia = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_ThanhTien = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Mua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_DonGia
            // 
            this.lv_DonGia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_DonGia.HideSelection = false;
            this.lv_DonGia.Location = new System.Drawing.Point(40, 71);
            this.lv_DonGia.Margin = new System.Windows.Forms.Padding(4);
            this.lv_DonGia.Name = "lv_DonGia";
            this.lv_DonGia.Size = new System.Drawing.Size(361, 406);
            this.lv_DonGia.TabIndex = 0;
            this.lv_DonGia.UseCompatibleStateImageBehavior = false;
            this.lv_DonGia.View = System.Windows.Forms.View.Details;
            this.lv_DonGia.SelectedIndexChanged += new System.EventHandler(this.lv_DonGia_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 42;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sách";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá bán";
            this.columnHeader3.Width = 98;
            // 
            // lv_ThanhTien
            // 
            this.lv_ThanhTien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_ThanhTien.HideSelection = false;
            this.lv_ThanhTien.Location = new System.Drawing.Point(667, 71);
            this.lv_ThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.lv_ThanhTien.Name = "lv_ThanhTien";
            this.lv_ThanhTien.Size = new System.Drawing.Size(361, 406);
            this.lv_ThanhTien.TabIndex = 1;
            this.lv_ThanhTien.UseCompatibleStateImageBehavior = false;
            this.lv_ThanhTien.View = System.Windows.Forms.View.Details;
            this.lv_ThanhTien.SelectedIndexChanged += new System.EventHandler(this.lv_ThanhTien_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "STT";
            this.columnHeader4.Width = 44;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên sách";
            this.columnHeader5.Width = 134;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thành tiền";
            this.columnHeader6.Width = 87;
            // 
            // btn_Mua
            // 
            this.btn_Mua.BackColor = System.Drawing.Color.Green;
            this.btn_Mua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mua.Location = new System.Drawing.Point(445, 153);
            this.btn_Mua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Mua.Name = "btn_Mua";
            this.btn_Mua.Size = new System.Drawing.Size(172, 47);
            this.btn_Mua.TabIndex = 2;
            this.btn_Mua.Text = "Mua";
            this.btn_Mua.UseVisualStyleBackColor = false;
            this.btn_Mua.Click += new System.EventHandler(this.btn_Mua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số lượng";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.Location = new System.Drawing.Point(445, 100);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soluong.Multiline = true;
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(171, 45);
            this.txt_soluong.TabIndex = 4;
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(445, 433);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TongTien.Multiline = true;
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(171, 45);
            this.txt_TongTien.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 405);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tổng tiền";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Green;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(445, 207);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(172, 47);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // frmsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1067, 507);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Mua);
            this.Controls.Add(this.lv_ThanhTien);
            this.Controls.Add(this.lv_DonGia);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmsach";
            this.Text = "Quản Lý Mua Sách";
            this.Load += new System.EventHandler(this.frmsach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_DonGia;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lv_ThanhTien;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btn_Mua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Xoa;
    }
}

