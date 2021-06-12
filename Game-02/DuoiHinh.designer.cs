namespace Game_02
{
    partial class DuoiHinh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuoiHinh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grb_speed = new System.Windows.Forms.GroupBox();
            this.rad_veryfast = new System.Windows.Forms.RadioButton();
            this.rad_fast = new System.Windows.Forms.RadioButton();
            this.rad_normal = new System.Windows.Forms.RadioButton();
            this.btn_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grb_speed.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(261, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 560);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // grb_speed
            // 
            this.grb_speed.Controls.Add(this.rad_veryfast);
            this.grb_speed.Controls.Add(this.rad_fast);
            this.grb_speed.Controls.Add(this.rad_normal);
            this.grb_speed.Location = new System.Drawing.Point(38, 108);
            this.grb_speed.Name = "grb_speed";
            this.grb_speed.Size = new System.Drawing.Size(166, 168);
            this.grb_speed.TabIndex = 1;
            this.grb_speed.TabStop = false;
            this.grb_speed.Text = "Tốc độ";
            // 
            // rad_veryfast
            // 
            this.rad_veryfast.AutoSize = true;
            this.rad_veryfast.Location = new System.Drawing.Point(7, 122);
            this.rad_veryfast.Name = "rad_veryfast";
            this.rad_veryfast.Size = new System.Drawing.Size(148, 35);
            this.rad_veryfast.TabIndex = 2;
            this.rad_veryfast.TabStop = true;
            this.rad_veryfast.Text = "Rất nhanh";
            this.rad_veryfast.UseVisualStyleBackColor = true;
            // 
            // rad_fast
            // 
            this.rad_fast.AutoSize = true;
            this.rad_fast.Location = new System.Drawing.Point(7, 86);
            this.rad_fast.Name = "rad_fast";
            this.rad_fast.Size = new System.Drawing.Size(108, 35);
            this.rad_fast.TabIndex = 1;
            this.rad_fast.TabStop = true;
            this.rad_fast.Text = "Nhanh";
            this.rad_fast.UseVisualStyleBackColor = true;
            // 
            // rad_normal
            // 
            this.rad_normal.AutoSize = true;
            this.rad_normal.Location = new System.Drawing.Point(7, 51);
            this.rad_normal.Name = "rad_normal";
            this.rad_normal.Size = new System.Drawing.Size(172, 35);
            this.rad_normal.TabIndex = 0;
            this.rad_normal.TabStop = true;
            this.rad_normal.Text = "Bình thường";
            this.rad_normal.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(38, 14);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(166, 46);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DuoiHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1151, 721);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.grb_speed);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DuoiHinh";
            this.Text = "DuoiHinh";
            this.Load += new System.EventHandler(this.DuoiHinh_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grb_speed.ResumeLayout(false);
            this.grb_speed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grb_speed;
        private System.Windows.Forms.RadioButton rad_veryfast;
        private System.Windows.Forms.RadioButton rad_fast;
        private System.Windows.Forms.RadioButton rad_normal;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Timer timer1;
    }
}