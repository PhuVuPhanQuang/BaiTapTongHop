using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_01
{
    public partial class Bai14 : Form
    {
        public Bai14()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            pictureBox1.Left += rd.Next(0, 100);
            pictureBox2.Left += rd.Next(0, 100);
            if(pictureBox1.Left >= groupBox1.Width)
            {
                timer1.Stop();
                MessageBox.Show("1.Win");
            }

            if(pictureBox2.Left >= groupBox1.Width)
            {
                timer1.Stop();
                MessageBox.Show("2.Win");
            }
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            timer1.Interval = 400;
            timer1.Start();
        }
    }
}
