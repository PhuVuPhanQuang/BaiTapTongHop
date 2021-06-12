using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mua_sách
{
    public partial class frmsach : Form
    {
        public frmsach()
        {
            InitializeComponent();
        }
        void DefineListView()
        {

            lv_DonGia.View = View.Details;
            lv_DonGia.GridLines = true;
            lv_DonGia.FullRowSelect = true;
            lv_DonGia.Columns.Add("STT", 50);
            lv_DonGia.Columns.Add("Tên sách", 150);
            lv_DonGia.Columns.Add("Đơn giá", 85);
            lv_DonGia.Items.Add(new ListViewItem(new[] { lv_DonGia.Items.Count.ToString(), "Lập trình Windows", "15000" }));
            lv_DonGia.Items.Add(new ListViewItem(new[] { lv_DonGia.Items.Count.ToString(), "Nhập môn C++", "20000" }));
            lv_DonGia.Items.Add(new ListViewItem(new[] { lv_DonGia.Items.Count.ToString(), "Lập trình Java", "30000" }));

            lv_ThanhTien.View = View.Details;
            lv_ThanhTien.GridLines = true;
            lv_ThanhTien.FullRowSelect = true;
            lv_ThanhTien.Columns.Add("STT", 50);
            lv_ThanhTien.Columns.Add("Sách", 150);
            lv_ThanhTien.Columns.Add("Tiền", 85);
        }

        private void frmsach_Load(object sender, EventArgs e)
        {
            DefineListView();
            btn_Xoa.Enabled = true;
            btn_Mua.Enabled = true;
            txt_soluong.Enabled = true;

        }

        private void btn_Mua_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_DonGia.Items.Count; i++)
            {
                if (lv_DonGia.Items[i].Selected == true)
                {
                    string stt = lv_ThanhTien.Items.Count.ToString();

                    lv_ThanhTien.Items.Add(new ListViewItem(new[] { stt, lv_DonGia.Items[i].SubItems[1].Text, (int.Parse(txt_soluong.Text) * int.Parse(lv_DonGia.Items[i].SubItems[2].Text)).ToString() }));
                }

            }
            Tinhtien();
        }
        void Tinhtien()
        {
            int s = 0;
            for (int i = 0; i < lv_ThanhTien.Items.Count; i++)
                if (lv_ThanhTien.Items.Count > 0)
                {
                    s += (int.Parse(lv_ThanhTien.Items[i].SubItems[2].Text));
                }
            lv_ThanhTien.Text = s.ToString();
        }
        private void Lv_DonGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Mua.Enabled = true;
            txt_soluong.Enabled = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            btn_Xoa.Enabled = true;
            for (int i = 0; i < lv_ThanhTien.Items.Count; i++)
            {
                if (lv_ThanhTien.Items[i].Selected == true)
                {
                    lv_ThanhTien.Items.RemoveAt(i);                  
                }
            }
        }

        private void lv_ThanhTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int s = 0;
            for (int i = 0; i < lv_ThanhTien.Items.Count; i++)
                if (lv_ThanhTien.Items.Count > 0)
                {
                    s += (int.Parse(lv_ThanhTien.Items[i].SubItems[2].Text));
                }
            txt_TongTien.Text = s.ToString();
        }

        private void lv_DonGia_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
