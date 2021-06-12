using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            if (txtNhap.Text.Trim() != "")
                btn_Xoa.Enabled = true;
            else
                btn_Xoa.Enabled = false;

            if (txtNhap.Text.Trim() != "")
                btn_SapXep.Enabled = true;
            else
                btn_SapXep.Enabled = false;
        }


        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            txtKetQua.Clear();
        }

        private void btn_SapXep_Click_1(object sender, EventArgs e)
        {
            string s = txtNhap.Text;
            string[] sn = new string[100];
            sn = s.Split(' ');
            for (int i = 0; i < sn.Length - 1; i++)
            {
                for (int j = i + 1; j < sn.Length; j++)
                {
                    if (Convert.ToInt32(sn[i]) > Convert.ToInt32(sn[j]))
                    {
                        string tam;
                        tam = sn[i];
                        sn[i] = sn[j];
                        sn[j] = tam;
                    }
                }
            }
            StringBuilder output = new StringBuilder();
            foreach (string c in sn)
            {
                output.AppendFormat("{0} ", c);
            }
            txtKetQua.Text = output.ToString();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát ? ", "Thông Báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

       
    }
}
