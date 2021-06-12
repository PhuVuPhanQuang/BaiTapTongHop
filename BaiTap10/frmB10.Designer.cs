namespace BaiTap10
{
    partial class frmB10
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
            this.txt_first = new System.Windows.Forms.TextBox();
            this.txt_second = new System.Windows.Forms.TextBox();
            this.txt_third = new System.Windows.Forms.TextBox();
            this.lbl_kq = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_turn = new System.Windows.Forms.Label();
            this.lbl_win1 = new System.Windows.Forms.Label();
            this.lbl_win2 = new System.Windows.Forms.Label();
            this.btn_number = new System.Windows.Forms.Button();
            this.btn_letter = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_first
            // 
            this.txt_first.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_first.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_first.Location = new System.Drawing.Point(55, 44);
            this.txt_first.Multiline = true;
            this.txt_first.Name = "txt_first";
            this.txt_first.ReadOnly = true;
            this.txt_first.Size = new System.Drawing.Size(179, 238);
            this.txt_first.TabIndex = 0;
            // 
            // txt_second
            // 
            this.txt_second.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_second.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_second.Location = new System.Drawing.Point(265, 44);
            this.txt_second.Multiline = true;
            this.txt_second.Name = "txt_second";
            this.txt_second.ReadOnly = true;
            this.txt_second.Size = new System.Drawing.Size(179, 238);
            this.txt_second.TabIndex = 1;
            // 
            // txt_third
            // 
            this.txt_third.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_third.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_third.Location = new System.Drawing.Point(472, 44);
            this.txt_third.Multiline = true;
            this.txt_third.Name = "txt_third";
            this.txt_third.ReadOnly = true;
            this.txt_third.Size = new System.Drawing.Size(179, 238);
            this.txt_third.TabIndex = 2;
            // 
            // lbl_kq
            // 
            this.lbl_kq.AutoSize = true;
            this.lbl_kq.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_kq.Location = new System.Drawing.Point(170, 302);
            this.lbl_kq.Name = "lbl_kq";
            this.lbl_kq.Size = new System.Drawing.Size(227, 35);
            this.lbl_kq.TabIndex = 3;
            this.lbl_kq.Text = "Mời bạn quay số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lần quay số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lần trúng giải 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lần trúng giải 2";
            // 
            // lbl_turn
            // 
            this.lbl_turn.AutoSize = true;
            this.lbl_turn.Location = new System.Drawing.Point(349, 419);
            this.lbl_turn.Name = "lbl_turn";
            this.lbl_turn.Size = new System.Drawing.Size(24, 27);
            this.lbl_turn.TabIndex = 7;
            this.lbl_turn.Text = "0";
            // 
            // lbl_win1
            // 
            this.lbl_win1.AutoSize = true;
            this.lbl_win1.Location = new System.Drawing.Point(349, 464);
            this.lbl_win1.Name = "lbl_win1";
            this.lbl_win1.Size = new System.Drawing.Size(24, 27);
            this.lbl_win1.TabIndex = 8;
            this.lbl_win1.Text = "0";
            this.lbl_win1.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_win2
            // 
            this.lbl_win2.AutoSize = true;
            this.lbl_win2.Location = new System.Drawing.Point(349, 502);
            this.lbl_win2.Name = "lbl_win2";
            this.lbl_win2.Size = new System.Drawing.Size(24, 27);
            this.lbl_win2.TabIndex = 9;
            this.lbl_win2.Text = "0";
            // 
            // btn_number
            // 
            this.btn_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_number.Location = new System.Drawing.Point(69, 340);
            this.btn_number.Name = "btn_number";
            this.btn_number.Size = new System.Drawing.Size(165, 59);
            this.btn_number.TabIndex = 10;
            this.btn_number.Text = "QUAY SỐ";
            this.btn_number.UseVisualStyleBackColor = false;
            this.btn_number.Click += new System.EventHandler(this.btn_number_Click);
            // 
            // btn_letter
            // 
            this.btn_letter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_letter.Location = new System.Drawing.Point(279, 340);
            this.btn_letter.Name = "btn_letter";
            this.btn_letter.Size = new System.Drawing.Size(165, 59);
            this.btn_letter.TabIndex = 11;
            this.btn_letter.Text = "QUAY CHỮ";
            this.btn_letter.UseVisualStyleBackColor = false;
            this.btn_letter.Click += new System.EventHandler(this.btn_letter_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.Location = new System.Drawing.Point(486, 340);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(165, 59);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "THOÁT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frmB10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(687, 544);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_letter);
            this.Controls.Add(this.btn_number);
            this.Controls.Add(this.lbl_win2);
            this.Controls.Add(this.lbl_win1);
            this.Controls.Add(this.lbl_turn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_kq);
            this.Controls.Add(this.txt_third);
            this.Controls.Add(this.txt_second);
            this.Controls.Add(this.txt_first);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmB10";
            this.Text = "frmB10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_first;
        private System.Windows.Forms.TextBox txt_second;
        private System.Windows.Forms.TextBox txt_third;
        private System.Windows.Forms.Label lbl_kq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_turn;
        private System.Windows.Forms.Label lbl_win1;
        private System.Windows.Forms.Label lbl_win2;
        private System.Windows.Forms.Button btn_number;
        private System.Windows.Forms.Button btn_letter;
        private System.Windows.Forms.Button btn_exit;
    }
}