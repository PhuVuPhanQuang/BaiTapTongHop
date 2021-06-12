namespace BAIFORM
{
    partial class BAI6
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
            this.txt_input = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.btn_input = new System.Windows.Forms.Button();
            this.btn_countEven = new System.Windows.Forms.Button();
            this.btn_countOdd = new System.Windows.Forms.Button();
            this.btn_max_min = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_Prime = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_input);
            this.groupBox1.Location = new System.Drawing.Point(26, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(336, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mảng nhập";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(12, 27);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(311, 101);
            this.txt_input.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_output);
            this.groupBox2.Location = new System.Drawing.Point(392, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(325, 138);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả tính toán";
            // 
            // txt_output
            // 
            this.txt_output.Enabled = false;
            this.txt_output.Location = new System.Drawing.Point(6, 27);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.Size = new System.Drawing.Size(311, 101);
            this.txt_output.TabIndex = 1;
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(26, 184);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(336, 38);
            this.btn_input.TabIndex = 2;
            this.btn_input.Text = "Nhập mảng";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // btn_countEven
            // 
            this.btn_countEven.Location = new System.Drawing.Point(392, 184);
            this.btn_countEven.Name = "btn_countEven";
            this.btn_countEven.Size = new System.Drawing.Size(325, 38);
            this.btn_countEven.TabIndex = 3;
            this.btn_countEven.Text = "Đếm phần tử chẵn";
            this.btn_countEven.UseVisualStyleBackColor = true;
            this.btn_countEven.Click += new System.EventHandler(this.btn_countEven_Click);
            // 
            // btn_countOdd
            // 
            this.btn_countOdd.Location = new System.Drawing.Point(392, 228);
            this.btn_countOdd.Name = "btn_countOdd";
            this.btn_countOdd.Size = new System.Drawing.Size(325, 38);
            this.btn_countOdd.TabIndex = 4;
            this.btn_countOdd.Text = "Đếm phần tử lẻ";
            this.btn_countOdd.UseVisualStyleBackColor = true;
            this.btn_countOdd.Click += new System.EventHandler(this.btn_countOdd_Click);
            // 
            // btn_max_min
            // 
            this.btn_max_min.Location = new System.Drawing.Point(26, 272);
            this.btn_max_min.Name = "btn_max_min";
            this.btn_max_min.Size = new System.Drawing.Size(336, 38);
            this.btn_max_min.TabIndex = 5;
            this.btn_max_min.Text = "Tìm Max - Min của mảng";
            this.btn_max_min.UseVisualStyleBackColor = true;
            this.btn_max_min.Click += new System.EventHandler(this.btn_max_min_Click);
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(26, 228);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(336, 38);
            this.btn_sum.TabIndex = 6;
            this.btn_sum.Text = "Tính tổng mảng";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // btn_Prime
            // 
            this.btn_Prime.Location = new System.Drawing.Point(392, 272);
            this.btn_Prime.Name = "btn_Prime";
            this.btn_Prime.Size = new System.Drawing.Size(325, 38);
            this.btn_Prime.TabIndex = 7;
            this.btn_Prime.Text = "Xuất các số nguyên tố";
            this.btn_Prime.UseVisualStyleBackColor = true;
            this.btn_Prime.Click += new System.EventHandler(this.btn_Prime_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(211, 332);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(336, 38);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Kết thúc";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // BAI6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 395);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Prime);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.btn_max_min);
            this.Controls.Add(this.btn_countOdd);
            this.Controls.Add(this.btn_countEven);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BAI6";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.Button btn_countEven;
        private System.Windows.Forms.Button btn_countOdd;
        private System.Windows.Forms.Button btn_max_min;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_Prime;
        private System.Windows.Forms.Button btn_Exit;
    }
}

