using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace BT6
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void btn_NhapN_Click(object sender, EventArgs e)
        {
            string value = Interaction.InputBox("Nhập giá trị phần tử:", "Nhập Mảng", "", -1, -1);
            int res;
            if (int.TryParse(value, out res))
            {
                txtNhapMang.Text += res.ToString() + " ";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập vào số!", "Nhắc nhở", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void btn_tinhtong_Click(object sender, EventArgs e)
        {
            if (txtNhapMang.Text.Length > 0)
            {
                //Tien hanh cat mang
                String[] result = catMang();
                int sum = 0;
                foreach (string i in result)
                {
                    sum += int.Parse(i);
                }
                txtKetQua.Text = sum.ToString();
            }
        }
        public string[] catMang()
        {
            string subs = txtKetQua.Text.Substring(0, txtNhapMang.Text.Length - 1);
            string[] result = subs.Split(' ');
            return result;
        }

        private void btn_MinMax_Click(object sender, EventArgs e)
        {
            if (txtNhapMang.Text.Length > 0)
            {
                String[] result = catMang();
                int[] numbs = new int[result.Length];

                for (int i = 0; i < result.Length; i++)
                {
                    numbs[i] = int.Parse(result[i]);
                }

                Array.Sort(numbs);
                txtKetQua.Clear();
                txtKetQua.Text = "Min :" + numbs[0].ToString() + " Max: " + numbs[numbs.Length - 1].ToString();
            }
        }

        private void btn_DemChan_Click(object sender, EventArgs e)
        {
            if (txtNhapMang.Text.Length > 0)
            {
                txtKetQua.Clear();
                txtKetQua.Text = Demchan().ToString();
            }
        }

        public int Demchan()
        {
            String[] result = catMang();
            int[] numbs = new int[result.Length];
            int dem = 0;

            for (int i = 0; i < result.Length; i++)
            {
                ;
                if (int.Parse(result[i]) % 2 == 0 && int.Parse(result[i]) > 0)
                {
                    dem++;
                }
            }
            return dem;
        }

        private void btn_DemLe_Click(object sender, EventArgs e)
        {
            if (txtNhapMang.Text.Length > 0)
            {
                String[] result = catMang();
                int[] numbs = new int[result.Length];
                txtKetQua.Clear();
                for (int i = 0; i < result.Length; i++)
                {
                    if (int.Parse(result[i]) % 2 != 0 && int.Parse(result[i]) > 0)
                    {
                        txtKetQua.Text += result[i].ToString() + " ";
                    }
                }
            }
        }

        public Boolean isPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            else if (n == 2)
            {
                return true;
            }
            else
            {
                for (int i = 3; i < n; i++)
                {
                    if (n % i == 0 || n % 2 == 0) return false;
                }
            }

            return true;
        }

        private void btn_XuatSNT_Click(object sender, EventArgs e)
        {
            if (txtNhapMang.Text.Length > 0)
            {
                String[] result = catMang();
                int[] numbs = new int[result.Length];
                txtKetQua.Clear();
                for (int i = 0; i < result.Length; i++)
                {
                    if (isPrime(int.Parse(result[i])))
                    {
                        txtKetQua.Text += result[i].ToString() + " ";
                    }
                }
            }
        }
        private void btn_KetThuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn kết thúc ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        
    }
}
