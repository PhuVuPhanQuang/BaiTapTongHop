using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap10
{
    public partial class frmB10 : Form
    {
        private bool flag = false;
        public frmB10()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }
        private int Quay(bool flag)
        {
            int kq = -1;
            Random rd = new Random();
            if(flag == false)
            {
                txt_first.Text = rd.Next(0, 9).ToString();
                txt_second.Text = rd.Next(0, 9).ToString();
                txt_third.Text = rd.Next(0, 9).ToString();
            }
            else
            {
                txt_first.Text = ((char)rd.Next(65, 90)).ToString();
                txt_second.Text = ((char)rd.Next(65, 90)).ToString();
                txt_third.Text = ((char)rd.Next(65, 90)).ToString();
            }
            if(txt_first.Text == txt_second.Text && txt_second.Text == txt_third.Text)
            {
                return 1;
            }
            if(txt_first.Text == txt_second.Text || txt_second.Text == txt_third.Text || txt_first.Text == txt_third.Text)
            {
                return 0;
            }    
            return kq;
        }
        private void Random(bool flag)
        {
            switch (Quay(flag))
            {
                case -1:
                    lbl_kq.Text = "Chúc bạn may mắn lần sau !";
                    break;
                case 0:
                    lbl_kq.Text = "Chúc mừng bạn trúng giải nhì !";
                    lbl_win2.Text = (int.Parse(lbl_win2.Text) + 1).ToString();
                    break;
                case 1:
                    lbl_kq.Text = "Chúc mừng bạn trúng giải nhất !";
                    lbl_win1.Text = (int.Parse(lbl_win1.Text) + 1).ToString();
                    break;
            }
            lbl_turn.Text = (int.Parse(lbl_turn.Text) + 1).ToString();
        }
        private void btn_number_Click(object sender, EventArgs e)
        {
            flag = false;
            Random(flag);
        }

        private void btn_letter_Click(object sender, EventArgs e)
        {
            flag = true;
            Random(flag);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
