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

namespace BaiTap13
{
    public partial class frmB13 : Form
    {
        public frmB13()
        {
            InitializeComponent();
            hide();
            txt_KetQua.Enabled = false;
        }
        private void hide()
        {
            foreach(Control ctr in groupBox1.Controls)
            {
                if(ctr is TextBox)
                {
                    ctr.Visible = false;
                    ctr.Enabled = false;
                }    
            }    
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            hide();
            {
                for(int i=0;i<trackBar1.Value;i++)
                {
                    groupBox1.Controls[i].Visible = true;
                    Random rd = new Random();
                    groupBox1.Controls[i].Text = (rd.Next(-99, 99)).ToString();
                    Thread.Sleep(10);
                }    
            }
        }

        private void btn_tongduong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach(Control ctr in groupBox1.Controls)
            {
                if(ctr.Visible == true && int.Parse(ctr.Text)>0 && ctr is TextBox)
                {
                    sum += int.Parse(ctr.Text);
                }
            }
            txt_KetQua.Text = sum.ToString();
        }
        private bool laSNT(int k)
        {
            int d = 0;
            for (int i = 1; i <= k; i++)
            {
                if (k % i == 0)
                    d++;
            }
            return (d == 2);
        }
        private void btn_TBC_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int count = 0;
            float avg = 0;
            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr.Visible == true && ctr is TextBox)
                {
                    sum += int.Parse(ctr.Text);
                    count++;
                }
            }
            avg = (float)sum / count;
            txt_KetQua.Text = (Math.Round(avg,5)).ToString();
        }

        private void btn_TongSNT_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr.Visible == true && ctr is TextBox && laSNT(int.Parse(ctr.Text)))
                {
                    sum += int.Parse(ctr.Text);
                }
            }
            if (sum == 0)
            {
                txt_KetQua.Text = "0";
            }
            else
            {
                txt_KetQua.Text = sum.ToString();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoatá ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
