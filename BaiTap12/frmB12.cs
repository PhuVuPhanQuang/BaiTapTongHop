using System;
using System.Windows.Forms;

namespace BaiTap12
{
    public partial class frmB12 : Form
    {
        public frmB12()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Random_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            txt_so.Text = rd.Next(0, 1000).ToString();
        }
        private void resetSTT()
        {
            for (int i = 0; i < lvw_List.Items.Count; i++)
            {
                lvw_List.Items[i].SubItems[0].Text = i.ToString();
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            ListViewItem lwi = new ListViewItem(lvw_List.Items.Count.ToString());
            ListViewItem.ListViewSubItem sub = new ListViewItem.ListViewSubItem(lwi, txt_so.Text);
            lwi.SubItems.Add(sub);
            lvw_List.Items.Add(lwi);
            lb_count.Text = lvw_List.Items.Count.ToString();
        }

        private void bai12_Load(object sender, EventArgs e)
        {
            lvw_List.View = View.Details;
            lvw_List.FullRowSelect = true;
            lvw_List.GridLines = true;
            lvw_List.Columns.Add("STT", 150);
            lvw_List.Columns.Add("Number", 350);
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvw_List.Items.Count; i++)
            {
                if (lvw_List.Items[i].Selected == true)
                    lvw_List.Items.RemoveAt(i);
            }
            resetSTT();
            lb_count.Text = lvw_List.Items.Count.ToString();
        }
        private int findMax()
        {
            int max = int.Parse(lvw_List.Items[0].SubItems[1].Text);
            for (int i = 0; i < lvw_List.Items.Count; i++)
            {
                if (int.Parse(lvw_List.Items[i].SubItems[1].Text) > max)
                {
                    max = int.Parse(lvw_List.Items[i].SubItems[1].Text);
                }
            }
            return max;
        }
        private int[] findLocationMax()
        {
            int[] ArrLocation = new int[byte.MaxValue];
            int max = findMax();
            int count = 0;
            for (int i = 0; i < lvw_List.Items.Count; i++)
            {
                if (max == int.Parse(lvw_List.Items[i].SubItems[1].Text))
                {
                    ArrLocation[count++] = i;
                }
            }
            return ArrLocation;
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            if (lvw_List.Items.Count == 0)
            {
                MessageBox.Show("This list is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int max = findMax();
                lb_Max.Text = max.ToString();
                int[] loca = findLocationMax();
                lb_location.Text = string.Empty;
                if (int.Parse(lvw_List.Items[0].SubItems[1].Text) == max)
                    lb_location.Text = "0,";
                for (int i = 0; i < loca.Length; i++)
                {
                    if (loca[i] != 0)
                    {
                        lb_location.Text += (loca[i].ToString() + ", ");
                    }
                }
            }
        }

        private void btn_RemoveMax_Click(object sender, EventArgs e)
        {
            if (lvw_List.Items.Count == 0)
            {
                MessageBox.Show("This list is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int max = findMax();
                for (int i = lvw_List.Items.Count - 1; i >= 0; i--)
                {
                    if (lvw_List.Items[i].SubItems[1].Text == max.ToString())
                    {
                        lvw_List.Items.RemoveAt(i);
                    }
                }
                resetSTT();
            }
            lb_count.Text = lvw_List.Items.Count.ToString();
        }

        private void lvw_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
