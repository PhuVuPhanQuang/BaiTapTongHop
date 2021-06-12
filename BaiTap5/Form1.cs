using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count > 0)
            {
                // di chuyển items từ listbox 1 sang listbox 2
                listBox2.Items.Add(listBox1.SelectedItem);
                // bỏ đi items đã add bên listbox1
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)
            {
                // di chuyển items từ listbox 1 sang listbox 2
                listBox1.Items.Add(listBox2.SelectedItem);
                // bỏ đi items đã add bên listbox1
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Add(listBox1.Items[i]);
            }
            // remove các items của listbox1
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox1.Items.Remove(listBox2.Items[i]);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox1.Items.Add(listBox2.Items[i]);
            }
            // remove các items của listbox1
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Remove(listBox1.Items[i]);
            }
        }
 

        private void btn_KetThuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn kết thúc không ?", "Thông Báo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        

    }
}
