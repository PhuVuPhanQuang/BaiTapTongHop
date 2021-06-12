namespace BaiTap7
{
    partial class frmB7
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
            this.txt_input = new System.Windows.Forms.TextBox();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.txt_replace = new System.Windows.Forms.TextBox();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_replace = new System.Windows.Forms.Button();
            this.btn_upcase = new System.Windows.Forms.Button();
            this.btn_lowcase = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập:";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(161, 28);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_input.Size = new System.Drawing.Size(641, 152);
            this.txt_input.TabIndex = 1;
            this.txt_input.TextChanged += new System.EventHandler(this.txt_input_TextChanged);
            // 
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(242, 225);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(401, 38);
            this.txt_find.TabIndex = 2;
            // 
            // txt_replace
            // 
            this.txt_replace.Location = new System.Drawing.Point(242, 290);
            this.txt_replace.Name = "txt_replace";
            this.txt_replace.Size = new System.Drawing.Size(401, 38);
            this.txt_replace.TabIndex = 3;
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(53, 394);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_output.Size = new System.Drawing.Size(641, 152);
            this.txt_output.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chuỗi tìm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chuỗi thay thế:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kết quả:";
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(773, 279);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(130, 34);
            this.btn_find.TabIndex = 8;
            this.btn_find.Text = "Tìm";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_replace
            // 
            this.btn_replace.Location = new System.Drawing.Point(773, 331);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(130, 34);
            this.btn_replace.TabIndex = 9;
            this.btn_replace.Text = "Thay thế";
            this.btn_replace.UseVisualStyleBackColor = true;
            this.btn_replace.Click += new System.EventHandler(this.btn_replace_Click);
            // 
            // btn_upcase
            // 
            this.btn_upcase.Location = new System.Drawing.Point(773, 392);
            this.btn_upcase.Name = "btn_upcase";
            this.btn_upcase.Size = new System.Drawing.Size(130, 34);
            this.btn_upcase.TabIndex = 10;
            this.btn_upcase.Text = "In hoa";
            this.btn_upcase.UseVisualStyleBackColor = true;
            this.btn_upcase.Click += new System.EventHandler(this.btn_upcase_Click);
            // 
            // btn_lowcase
            // 
            this.btn_lowcase.Location = new System.Drawing.Point(773, 451);
            this.btn_lowcase.Name = "btn_lowcase";
            this.btn_lowcase.Size = new System.Drawing.Size(130, 34);
            this.btn_lowcase.TabIndex = 11;
            this.btn_lowcase.Text = "In thường";
            this.btn_lowcase.UseVisualStyleBackColor = true;
            this.btn_lowcase.Click += new System.EventHandler(this.btn_lowcase_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(773, 512);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(130, 34);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frmB7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(950, 560);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_lowcase);
            this.Controls.Add(this.btn_upcase);
            this.Controls.Add(this.btn_replace);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.txt_replace);
            this.Controls.Add(this.txt_find);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmB7";
            this.Text = "BAI7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.TextBox txt_replace;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_replace;
        private System.Windows.Forms.Button btn_upcase;
        private System.Windows.Forms.Button btn_lowcase;
        private System.Windows.Forms.Button btn_exit;
    }
}