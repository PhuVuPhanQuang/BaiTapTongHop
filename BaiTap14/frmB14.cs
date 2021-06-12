using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap14
{
    public partial class frmB14 : Form
    {
        public frmB14()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=3;i<=10;i++)
            {
                cboSoCanh.Items.Add(i.ToString());
            }

        }

        private void cboSoCanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            int n = int.Parse(cboSoCanh.SelectedItem.ToString());
            int l = 10, t = 10;
            for(int i=0 ; i<n ; i++)
            {
                for(int j=0 ; j<n; j++)
                {
                    TextBox txt = new TextBox();
                    txt.Multiline = true;
                    txt.Width = 30;
                    txt.Height = 30;
                    txt.Left = l;
                    txt.Top = t;
                    l += 30;
                    if ((i + j) % 2 != 0)
                        txt.BackColor = Color.Black;
                    groupBox1.Controls.Add(txt);
                    groupBox1.Width = (n * 30) + 15;
                    groupBox1.Height = (n * 30) + 15;
                    this.Width = n;
                }
                l = 10; t += 30;
            }
        }

        
    }
}
