using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap7
{
    public partial class frmB7 : Form
    {
        public frmB7()
        {
            InitializeComponent();
            txt_input.Focus();
            btn_find.Enabled = false;
            btn_lowcase.Enabled = false;
            btn_replace.Enabled = false;
            btn_upcase.Enabled = false;
        }

        private void txt_input_TextChanged(object sender, EventArgs e)
        {
            if (txt_input.Text.Trim()!=string.Empty)
            {
                btn_find.Enabled = true;
                btn_lowcase.Enabled = true;
                btn_replace.Enabled = true;
                btn_upcase.Enabled = true;
            }
            else
            {
                btn_find.Enabled = false;
                btn_lowcase.Enabled = false;
                btn_replace.Enabled = false;
                btn_upcase.Enabled = false;
            }
            txt_output.Clear();
            txt_find.Clear();
            txt_replace.Clear();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string temp = string.Empty;
            int count = txt_input.Text.IndexOf(txt_find.Text);
            if (count == -1)
            {
                txt_output.Text = "Khong tim thay chuoi!";
            }
            else
            {
                while ((txt_input.Text.IndexOf(txt_find.Text, count)) != -1)
                {
                    temp += txt_input.Text.IndexOf(txt_find.Text, count).ToString() + ", ";
                    count = txt_input.Text.IndexOf(txt_find.Text, count) + txt_find.Text.Length;
                }
                txt_output.Text = "Vị trí: " + temp;
            }    

        }

        private void btn_replace_Click(object sender, EventArgs e)
        {
            if(txt_input.Text.Contains(txt_find.Text))
            {
                txt_output.Text = txt_input.Text.Replace(txt_find.Text, txt_replace.Text);
            }
            else
            {
                txt_output.Text = "Chuỗi tìm không tồn tại";
            }    
        }

        private void btn_upcase_Click(object sender, EventArgs e)
        {
            txt_output.Text = txt_input.Text.ToUpper();
        }

        private void btn_lowcase_Click(object sender, EventArgs e)
        {
            txt_output.Text = txt_input.Text.ToLower();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
