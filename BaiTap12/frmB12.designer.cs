namespace BaiTap12
{
    partial class frmB12
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
            this.txt_so = new System.Windows.Forms.TextBox();
            this.btn_Random = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Max = new System.Windows.Forms.Button();
            this.btn_RemoveMax = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvw_List = new System.Windows.Forms.ListView();
            this.lb_Max = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_count = new System.Windows.Forms.Label();
            this.lb_location = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_so
            // 
            this.txt_so.Location = new System.Drawing.Point(132, 34);
            this.txt_so.Name = "txt_so";
            this.txt_so.Size = new System.Drawing.Size(177, 38);
            this.txt_so.TabIndex = 0;
            // 
            // btn_Random
            // 
            this.btn_Random.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Random.Location = new System.Drawing.Point(31, 98);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(365, 39);
            this.btn_Random.TabIndex = 1;
            this.btn_Random.Text = "Phát sinh số ngẫu nhiên";
            this.btn_Random.UseVisualStyleBackColor = false;
            this.btn_Random.Click += new System.EventHandler(this.btn_Random_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Add.Location = new System.Drawing.Point(31, 168);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(365, 39);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Thêm vào danh sách";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Remove.Location = new System.Drawing.Point(31, 231);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(365, 39);
            this.btn_Remove.TabIndex = 3;
            this.btn_Remove.Text = "Xoá số đang chọn";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Max
            // 
            this.btn_Max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Max.Location = new System.Drawing.Point(31, 294);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(365, 39);
            this.btn_Max.TabIndex = 4;
            this.btn_Max.Text = "Tìm số lớn nhất";
            this.btn_Max.UseVisualStyleBackColor = false;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            // 
            // btn_RemoveMax
            // 
            this.btn_RemoveMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_RemoveMax.Location = new System.Drawing.Point(31, 354);
            this.btn_RemoveMax.Name = "btn_RemoveMax";
            this.btn_RemoveMax.Size = new System.Drawing.Size(365, 39);
            this.btn_RemoveMax.TabIndex = 5;
            this.btn_RemoveMax.Text = "Xoá số lớn nhất";
            this.btn_RemoveMax.UseVisualStyleBackColor = false;
            this.btn_RemoveMax.Click += new System.EventHandler(this.btn_RemoveMax_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số lượng số có trong danh sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số lớn nhất trong danh sách";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lvw_List
            // 
            this.lvw_List.GridLines = true;
            this.lvw_List.HideSelection = false;
            this.lvw_List.Location = new System.Drawing.Point(445, 77);
            this.lvw_List.Name = "lvw_List";
            this.lvw_List.Size = new System.Drawing.Size(461, 275);
            this.lvw_List.TabIndex = 8;
            this.lvw_List.UseCompatibleStateImageBehavior = false;
            this.lvw_List.SelectedIndexChanged += new System.EventHandler(this.lvw_List_SelectedIndexChanged);
            // 
            // lb_Max
            // 
            this.lb_Max.AutoSize = true;
            this.lb_Max.Location = new System.Drawing.Point(798, 374);
            this.lb_Max.Name = "lb_Max";
            this.lb_Max.Size = new System.Drawing.Size(28, 31);
            this.lb_Max.TabIndex = 9;
            this.lb_Max.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vị trí số lớn nhất";
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Location = new System.Drawing.Point(766, 22);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(0, 31);
            this.lb_count.TabIndex = 11;
            // 
            // lb_location
            // 
            this.lb_location.AutoSize = true;
            this.lb_location.Location = new System.Drawing.Point(719, 419);
            this.lb_location.Name = "lb_location";
            this.lb_location.Size = new System.Drawing.Size(0, 31);
            this.lb_location.TabIndex = 12;
            // 
            // frmB12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1002, 471);
            this.Controls.Add(this.lb_location);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_Max);
            this.Controls.Add(this.lvw_List);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_RemoveMax);
            this.Controls.Add(this.btn_Max);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Random);
            this.Controls.Add(this.txt_so);
            this.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmB12";
            this.Text = "frmB12";
            this.Load += new System.EventHandler(this.bai12_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_so;
        private System.Windows.Forms.Button btn_Random;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Max;
        private System.Windows.Forms.Button btn_RemoveMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvw_List;
        private System.Windows.Forms.Label lb_Max;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Label lb_location;
    }
}

