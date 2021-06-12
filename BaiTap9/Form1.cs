using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt_NhapSND.Text.Trim());
            int s = 0;
            for (int i = 1; i < n; i++)
            {
                if (LaSNT(i))
                {
                    txt_KetQua.Text += i.ToString() + ",";
                    s += i;//s = s + i;
                }
            }
        }
        bool LaSNT(int k)
        {
            int d = 0;
            for (int i = 1; i <= k; i++)
            {
                if (k % i == 0)
                    d++;
            }
            return (d == 2);
        }
        private string NgtoGan()
        {
            int a = int.Parse(txt_KetQua.Text);
            while (LaSNT(a))
            {
                a++;
            }
            return "Số nguyên tố lớn hơn gần nhất là " + a.ToString();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có thực sự muốn thoát ? ", "Thông Báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
    }
}
