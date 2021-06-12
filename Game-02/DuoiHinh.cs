using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_02
{
    public partial class DuoiHinh : Form
    {
        public DuoiHinh()
        {
            InitializeComponent();
            Init();
        }
        private int top;
        private int left;
        private int count = 0;
        public void Init()
        {
            resetpos();
            btn_start.Enabled = true;
            grb_speed.Enabled = true;
            panel1.Enabled = false;
            pictureBox1.Enabled = false;
            top = pictureBox1.Top;
            left = pictureBox1.Left;
            count = 0;
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = false;
            grb_speed.Enabled = false;
            pictureBox1.Enabled = true;
            panel1.Enabled = true;
            if(rad_normal.Checked == true)
            {
                timer1.Interval = 500;
            }
            else if(rad_fast.Checked == true)
            {
                timer1.Interval = 300;
            }
            else
            {
                timer1.Interval = 100;
            }    
            timer1.Start();  
        }

        public void resetpos()
        {
            pictureBox1.Left = left ;
            pictureBox1.Top = top;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            resetpos();
            Random rd = new Random();
            int pos = rd.Next(1, 16);
            switch(pos)
            {
                case 1:
                    pictureBox1.Left = pictureBox1.Left + (0 * pictureBox1.Width);
                    pictureBox1.Top = pictureBox1.Top + (0 * pictureBox1.Height);
                    break;
                case 2:
                    pictureBox1.Left = pictureBox1.Left + (1 * pictureBox1.Width);
                    pictureBox1.Top = pictureBox1.Top + (0 * pictureBox1.Height);
                    break;
                case 3:
                    pictureBox1.Left = pictureBox1.Left + (2 * pictureBox1.Width);
                    pictureBox1.Top = pictureBox1.Top + (0 * pictureBox1.Height);
                    break;
                case 4:
                    pictureBox1.Left = pictureBox1.Left + (3 * pictureBox1.Width);
                    pictureBox1.Top = pictureBox1.Top + (0 * pictureBox1.Height);
                    break;
                case 5:
                    pictureBox1.Left = pictureBox1.Left + (0 * pictureBox1.Width);
                    pictureBox1.Top = pictureBox1.Top + (1 * pictureBox1.Height);
                    break;
                case 6:
                    pictureBox1.Left = pictureBox1.Left + (1 * pictureBox1.Width);
                    pictureBox1.Top = pictureBox1.Top + (1 * pictureBox1.Height);
                    break;
                case 7:
                    pictureBox1.Left = pictureBox1.Left + (2 * pictureBox1.Width);
                    pictureBox1.Top = pictureBox1.Top + (1 * pictureBox1.Height);
                    break;
                case 8:
                    pictureBox1.Left = pictureBox1.Left + (3 * pictureBox1.Width);
                    pictureBox1.Top = pictureBox1.Top + (1 * pictureBox1.Height);
                    break;
                case 9:
                    pictureBox1.Left = pictureBox1.Left + (0 * pictureBox1.Width);
                    pictureBox1.Top = pictureBox1.Top + (2 * pictureBox1.Height);
                    break;
                case 10:
                    pictureBox1.Left = pictureBox1.Left + (1 * pictureBox1.Width);
                    pictureBox1.Top = pictureBox1.Top + (2 * pictureBox1.Height);
                    break;
                case 11:
                    pictureBox1.Left = pictureBox1.Left + (2 * pictureBox1.Width);
                    pictureBox1.Top = pictureBox1.Top + (2 * pictureBox1.Height);
                    break;
                case 12:
                    pictureBox1.Left = pictureBox1.Left + (3 * pictureBox1.Width);
                    pictureBox1.Top = pictureBox1.Top + (2 * pictureBox1.Height);
                    break;
                case 13:
                    pictureBox1.Left = pictureBox1.Left + (0 * pictureBox1.Width);
                    pictureBox1.Top = pictureBox1.Top + (3 * pictureBox1.Height);
                    break;
                case 14:
                    pictureBox1.Left = pictureBox1.Left + (1 * pictureBox1.Width);
                    pictureBox1.Top = pictureBox1.Top + (3 * pictureBox1.Height);
                    break;
                case 15:
                    pictureBox1.Left = pictureBox1.Left + (2 * pictureBox1.Width);
                    pictureBox1.Top = pictureBox1.Top + (3 * pictureBox1.Height);
                    break;
                case 16:
                    pictureBox1.Left = pictureBox1.Left + (3 * pictureBox1.Width);
                    pictureBox1.Top = pictureBox1.Top + (3 * pictureBox1.Height);
                    break;
            }    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("You win", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Init();
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            count += 1;
            if (count >= 10)
            {
                timer1.Stop();
                MessageBox.Show("You lose", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Init();
            }
        }

        private void DuoiHinh_Load(object sender, EventArgs e)
        {

        }
    }
}
