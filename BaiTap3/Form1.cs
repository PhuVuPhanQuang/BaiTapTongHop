using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_LietKe_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt_NhapN.Text.Trim());
            int s = 0;
            for (int i = 1; i < n; i++)
            {
                if (laSNT(i))
                {
                    txt_danhsach.Text += i.ToString() + ',';
                    s += i; // s = s + i;
                }
            }
            txt_tong.Text = s.ToString();
        }
        bool laSNT(int k)
        {
            int d = 0;
            for (int i = 1; i <= k; i++)
            {
                if (k % i == 0)
                    d++;
            }
            return (d == 2);
        }

        private void btn_BoQua_Click(object sender, EventArgs e)
        {
            txt_NhapN.Clear();
            txt_danhsach.Clear();
            txt_tong.Clear();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
    }
}
