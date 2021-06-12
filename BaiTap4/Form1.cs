using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool Kiem_Tra_ListBox()
        {
            if (lbKhungKetQua.Items.Count > 0)
                return true;
            return false;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            Random rd = new Random();

            int n = rd.Next(-20, 20);
            lbKhungKetQua.Items.Add(n);
        }

        private void btn_Cong2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<lbKhungKetQua.Items.Count;i++)
            {
                lbKhungKetQua.Items[i] = int.Parse(lbKhungKetQua.Items[i].ToString()) + 2;
            }
        }

        private void btn_ChanDau_Click(object sender, EventArgs e)
        {
            int n = lbKhungKetQua.Items.Count;
            for(int i=0;i<n;i++)
            {
                if(Convert.ToInt32(lbKhungKetQua.Items[i])%2 ==0)
                {
                    lbKhungKetQua.SelectedIndex = 1;
                    return;
                }
            }
        }

        private void btn_LeCuoi_Click(object sender, EventArgs e)
        {
            int n = lbKhungKetQua.Items.Count;
            for (int i = n - 1; i >= 0; i--)
                if (Convert.ToInt32(lbKhungKetQua.Items[i]) % 2 != 0)
                    lbKhungKetQua.SelectedIndex = i;
            return;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (Kiem_Tra_ListBox())
                lbKhungKetQua.Items.Remove(lbKhungKetQua.SelectedItem);
            else
                MessageBox.Show("List trống, không xóa được!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void btn_XoaDau_Click(object sender, EventArgs e)
        {
            if (Kiem_Tra_ListBox())
                lbKhungKetQua.Items.RemoveAt(0);
            else
                MessageBox.Show("List trống, không xóa được !", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void btn_xoacuoi_Click(object sender, EventArgs e)
        {
            if (lbKhungKetQua.Items.Count <= 0)
            {
                btn_xoacuoi.Enabled = false;
            }
            else
            {
                lbKhungKetQua.Items.RemoveAt(lbKhungKetQua.Items.Count - 1);

            }
        }

        private void btn_KetThuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void lbKhungKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
