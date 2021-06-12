namespace BaiTap2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_BoQua = new System.Windows.Forms.Button();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_KetQua = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_BSCNN = new System.Windows.Forms.RadioButton();
            this.rb_USCLN = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_B);
            this.groupBox1.Controls.Add(this.txt_A);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "A:";
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(115, 75);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(310, 22);
            this.txt_B.TabIndex = 1;
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(115, 22);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(310, 22);
            this.txt_A.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Thoat);
            this.groupBox2.Controls.Add(this.btn_BoQua);
            this.groupBox2.Controls.Add(this.btn_Tim);
            this.groupBox2.Controls.Add(this.txt_KetQua);
            this.groupBox2.Location = new System.Drawing.Point(12, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết Quả:";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(456, 105);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(105, 38);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_BoQua
            // 
            this.btn_BoQua.Location = new System.Drawing.Point(280, 105);
            this.btn_BoQua.Name = "btn_BoQua";
            this.btn_BoQua.Size = new System.Drawing.Size(104, 38);
            this.btn_BoQua.TabIndex = 4;
            this.btn_BoQua.Text = "Bỏ Qua";
            this.btn_BoQua.UseVisualStyleBackColor = true;
            this.btn_BoQua.Click += new System.EventHandler(this.btn_BoQua_Click);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(115, 105);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(100, 38);
            this.btn_Tim.TabIndex = 3;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_KetQua
            // 
            this.txt_KetQua.Location = new System.Drawing.Point(115, 40);
            this.txt_KetQua.Name = "txt_KetQua";
            this.txt_KetQua.Size = new System.Drawing.Size(316, 22);
            this.txt_KetQua.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_BSCNN);
            this.groupBox3.Controls.Add(this.rb_USCLN);
            this.groupBox3.Location = new System.Drawing.Point(449, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 122);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn tìm:";
            // 
            // rb_BSCNN
            // 
            this.rb_BSCNN.AutoSize = true;
            this.rb_BSCNN.Location = new System.Drawing.Point(61, 75);
            this.rb_BSCNN.Name = "rb_BSCNN";
            this.rb_BSCNN.Size = new System.Drawing.Size(76, 21);
            this.rb_BSCNN.TabIndex = 1;
            this.rb_BSCNN.Text = "BSCNN";
            this.rb_BSCNN.UseVisualStyleBackColor = true;
            // 
            // rb_USCLN
            // 
            this.rb_USCLN.AutoSize = true;
            this.rb_USCLN.Checked = true;
            this.rb_USCLN.Location = new System.Drawing.Point(61, 24);
            this.rb_USCLN.Name = "rb_USCLN";
            this.rb_USCLN.Size = new System.Drawing.Size(75, 21);
            this.rb_USCLN.TabIndex = 0;
            this.rb_USCLN.TabStop = true;
            this.rb_USCLN.Text = "USCLN";
            this.rb_USCLN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(763, 331);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tìm USCLN và BSCNN của A và B ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_BoQua;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_KetQua;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_BSCNN;
        private System.Windows.Forms.RadioButton rb_USCLN;
    }
}

