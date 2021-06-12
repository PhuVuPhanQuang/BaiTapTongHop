using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b;
        private void btn_Tim_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txt_A.Text);
            b = Convert.ToInt32(txt_B.Text);
            txt_KetQua.Text = USCLN(a, b).ToString();
            txt_KetQua.Text = BSCNN(a, b).ToString();
        }

        private void btn_BoQua_Click(object sender, EventArgs e)
        {
            txt_A.Clear();
            txt_B.Clear();
            txt_KetQua.Clear();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát ? ", "Thông Báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void rb_USCLN_CheckedChanged(object sender, EventArgs e,int a,int b)
        {
            USCLN(a, b);

        }

        int USCLN(int a,int b)
        {
            if(a==0 || b==0)
            {
                return a + b;
            }
            while(a!=b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }

        private void rb_BSCNN_CheckedChanged(object sender, EventArgs e,int a,int b)
        {
            BSCNN(a, b);
        }

        int BSCNN(int a,int b)
        {
            return (a * b) / USCLN(a, b);
        }

        
    }
}















