using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap11
{
    public partial class frmB11 : Form
    {
        public frmB11()
        {
            InitializeComponent();
            txt_input.Text = string.Empty;
        }
        private int count = 0;
        private float num1 = 0, ans = 0;

        private void btn_answer_Click(object sender, EventArgs e)
        {
            {
                compute(count,ans);
            }
        }
        public void compute(int count, float ans)
        {
            switch(count)
            {
                case 1:
                    ans = num1 - float.Parse(txt_input.Text);
                    txt_input.Clear();
                    txt_input.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(txt_input.Text);
                    txt_input.Clear();
                    txt_input.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(txt_input.Text);
                    txt_input.Clear();
                    txt_input.Text = ans.ToString();
                    break;
                case 4:
                    if(float.Parse(txt_input.Text)==0)
                    {
                        txt_input.Text = "Can't divide for zero!";
                    }
                    else
                    {
                        ans = num1 / float.Parse(txt_input.Text);
                        txt_input.Clear();
                        txt_input.Text = ans.ToString();
                    }    
                    break;
                default: break;
            }    
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_input.Text += btn_1.Text;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_input.Text += btn_2.Text;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_input.Text += btn_3.Text;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_input.Text += btn_4.Text;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_input.Text += btn_5.Text;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_input.Text += btn_6.Text;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_input.Text += btn_7.Text;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_input.Text += btn_8.Text;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_input.Text += btn_9.Text;
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string txt = txt_input.Text;
            for(int i=0;i<txt_input.Text.Length;i++)
            {
                if (txt[i] == '.')
                    flag = true;

            }
            if(flag==false)
                txt_input.Text += btn_dot.Text;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_input.Text += btn_0.Text;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_input.Clear();
            count = 0;
            ans = 0;
            num1 = 0;
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if(txt_input.Text!=string.Empty)
            {
                if (count != 0)
                {
                    compute(count,ans);
                }
                else
                {
                    num1 = float.Parse(txt_input.Text);
                    txt_input.Clear();
                    txt_input.Focus();
                    count = 1;
                }
            }    
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            if(count!=0)
            {
                compute(count,ans);
            }
            else
            {
                num1 = float.Parse(txt_input.Text);
                txt_input.Clear();
                txt_input.Focus();
                count = 3;
            }    
        }

        private void btn_divi_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                compute(count,ans);
            }
            else
            {
                num1 = float.Parse(txt_input.Text);
                txt_input.Clear();
                txt_input.Focus();
                count = 4;
            }
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                compute(count,ans);
            }
            else
            {
                num1 = float.Parse(txt_input.Text);
                txt_input.Clear();
                txt_input.Focus();
                count = 2;
            }
        }
    }
}
