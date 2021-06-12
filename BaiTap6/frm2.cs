using System;
using System.Windows.Forms;

namespace BAIFORM
{
    public delegate void SendMessage(string value);

    public partial class BAI6 : Form
    {
        public BAI6()
        {
            InitializeComponent();
            txt_input.ScrollBars = ScrollBars.Vertical;
            txt_output.ScrollBars = ScrollBars.Vertical;
        }
        private void SetValue(string value)
        {
            txt_input.Text += value + ",";
        }
        private void btn_input_Click(object sender, EventArgs e)
        {
            InputDialog ip = new InputDialog(SetValue);
            ip.Show();
        }
        private Array ArrayToInt(string input)
        {
            string[] str = input.Trim().Split(',');
            int[] arr = new int[str.Length];
            for (int i = 0; i < str.Length - 1; i++)
            {
                arr[i] = int.Parse((str[i]).Trim().Replace(",", string.Empty));
            }
            return arr;
        }
        private void btn_sum_Click(object sender, EventArgs e)
        {
            int[] arr = new int[ArrayToInt(txt_input.Text).Length];
            (ArrayToInt(txt_input.Text)).CopyTo(arr, 0);
            int s = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                s += arr[i];
            }
            txt_output.Text = s.ToString();
        }

        private void btn_countEven_Click(object sender, EventArgs e)
        {
            int count = 0;
            int[] arr = new int[ArrayToInt(txt_input.Text).Length];
            //Console.WriteLine(ArrayToInt(txt_input.Text).Length);
            (ArrayToInt(txt_input.Text)).CopyTo(arr, 0);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                    if (arr[i] % 2 == 0)
                    {
                        count++;
                    }
            }
            txt_output.Text = count.ToString();
        }

        private void btn_countOdd_Click(object sender, EventArgs e)
        {
            int count = 0;
            int[] arr = new int[ArrayToInt(txt_input.Text).Length];
            //Console.WriteLine(ArrayToInt(txt_input.Text).Length);
            (ArrayToInt(txt_input.Text)).CopyTo(arr, 0);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                    if (arr[i] % 2 != 0)
                    {
                        count++;
                    }
            }
            txt_output.Text = count.ToString();
        }
        bool laSNT(int k)
        {
            int d = 0;
            for (int i = 1; i <= k; i++)
            {
                if (k % i == 0)
                    d++;
            }
            return (d == 2);
        }
        private void btn_Prime_Click(object sender, EventArgs e)
        {
            txt_output.Clear();
            int[] arr = new int[ArrayToInt(txt_input.Text).Length];
            //Console.WriteLine(ArrayToInt(txt_input.Text).Length);
            (ArrayToInt(txt_input.Text)).CopyTo(arr, 0);
            for (int i = 0; i < arr.Length; i++)
            {
                if (laSNT(arr[i]) && arr[i] > 0)
                {
                    //Console.WriteLine(arr[i]);
                    txt_output.Text += arr[i].ToString() + ", ";
                }
            }
        }

        private void btn_max_min_Click(object sender, EventArgs e)
        {
            txt_output.Clear();
            int[] arr = new int[ArrayToInt(txt_input.Text).Length];
            //Console.WriteLine(ArrayToInt(txt_input.Text).Length);
            int max = arr[0], min = arr[0];
            (ArrayToInt(txt_input.Text)).CopyTo(arr, 0);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }
            txt_output.Text = "Max:  " + max + " / Min:  " + min;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
