using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BaiTap15
{
    public partial class frmB15 : Form
    {
        public frmB15()
        {
            InitializeComponent();
            init();   
        }
        int[] arr;
        int[] tempArray;
        private void init()
        {
            for(int i=1;i<=15;i++)
            {
                cbo_value.Items.Add(i);
            }
            trb_value.Maximum = 15;
            trb_value.Minimum = 1;
            hidebase();
            hideequals();
        }
        private void hidebase()
        {
            foreach(Control ctr in grb_base.Controls)
            {
                if(ctr is TextBox)
                {
                    ctr.Visible = false;
                }   
            }
        }
        private void hideequals()
        {
            foreach (Control ctr in grb_equals.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Visible = false;
                }
            }
        }
        private void copyValueToControl(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                grb_equals.Controls[i].Visible = true;
                grb_equals.Controls[i].Text = arr[i].ToString();
            }    
        }
        private void random()
        {
            int n = 0;
            int count = 0;
            arr = new int[trb_value.Value];
            Random rd = new Random();
            foreach (Control ctr in grb_base.Controls)
            {
                if(ctr is TextBox)
                {
                    ctr.Visible = true;
                }    
                if(ctr.Visible == true && ctr is TextBox)
                {
                    ctr.Text = rd.Next(0, 99).ToString();
                    arr[count] = int.Parse(ctr.Text);
                    count++;
                }
                n++;
                if (n == trb_value.Value)
                    break;
            }
            tempArray = arr;
        }
        private void setUnCheck()
        {
            foreach(CheckBox chk in grb_option.Controls)
            {
                chk.Checked = false;
                chk.Enabled = true;
            }
        }
        private void setChecked()
        {
            foreach (CheckBox chk in grb_option.Controls)
            {
                if(chk.Checked == true)
                    chk.Enabled = false;
            }
        }
        private bool checkOdd(int value)
        {
            return (value % 2 == 0);
        }
        private void findOdd()
        {
            hideequals();
            int count = 0;
            int[] a = new int[tempArray.Length];
            for(int i =0; i<tempArray.Length;i++)
            {
                if(tempArray[i]!=0)
                {
                    if (checkOdd(tempArray[i]))
                    {
                        a[count++] = tempArray[i];
                    }
                }  
            }
            Array.Resize(ref a, count);
            if (a.Length != 0)
            {
                copyValueToControl(a);
            }
            else
            {
                MessageBox.Show("Không có số chẵn trong mảng", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void MainProgram()
        {
            hidebase();
            hideequals();
            random();
            setUnCheck();

        }
        private void cbo_value_SelectedIndexChanged(object sender, EventArgs e)
        {
            trb_value.Value = int.Parse(cbo_value.SelectedItem.ToString());
            MainProgram();
        }

        private void trb_value_Scroll(object sender, EventArgs e)
        {
            cbo_value.SelectedItem = trb_value.Value;
            MainProgram();
        }
        private void sort()
        {
            for(int i=0;i<tempArray.Length;i++)
            {
                for(int j = 0;j<tempArray.Length;j++)
                {
                    if(tempArray[i] < tempArray[j])
                    {
                        int temp = tempArray[i];
                        tempArray[i] = tempArray[j];
                        tempArray[j] = temp;
                    }    
                }    
            }
        }
        private bool checkBS(int value)
        {
            if (value % 3 == 0 && value % 5 == 0)
            {
                return true;
            }
            return false;
        }
        private void bs35()
        {
            hideequals();
            int count = 0;
            int[] temp = new int[tempArray.Length];
            for(int i = 0; i<tempArray.Length;i++)
            {
                    if (checkBS(tempArray[i]))
                    {
                        temp[count++] = tempArray[i];
                    }  
            }
            Array.Resize(ref temp, count);
            if(temp.Length!=0)
            {
                copyValueToControl(temp);
            }    
            else
            {
                MessageBox.Show("Không có bội số của 3 và 5 trong mảng", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }
        private bool laSNT(int k)
        {
            int d = 0;
            for (int i = 1; i <= k; i++)
            {
                if (k % i == 0)
                    d++;
            }
            return (d == 2);
        }
        private void Prime()
        {
            hideequals();
            int count = 0;
            int[] temp = new int[tempArray.Length];
            for(int i=0;i<tempArray.Length;i++)
            {
                if(laSNT(tempArray[i]))
                {
                    temp[count++] = tempArray[i];
                }    
            }
            Array.Resize(ref temp, count);
            if (temp.Length != 0)
            {
                copyValueToControl(temp);
            }
            else
            {
                MessageBox.Show("Không có số nguyên tố trong mảng", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        private void btn_sort_Click(object sender, EventArgs e)
        {
            sort();
            copyValueToControl(tempArray);
        }

        private void btn_odd_Click(object sender, EventArgs e)
        {
            findOdd();
        }
        private void btn_bs35_Click(object sender, EventArgs e)
        {
            bs35();
        }

        private void btn_prime_Click(object sender, EventArgs e)
        {
            Prime();
        }
        private int findMax()
        {
            int max = tempArray[0];
            for(int i = 1; i<tempArray.Length;i++)
            {
                if (max < tempArray[i])
                    max = tempArray[i];
            }
            return max;
        }
        private int findMin()
        {
            int min = arr[0];
            for (int i = 1; i < tempArray.Length; i++)
            {
                if (min > tempArray[i])
                    min = tempArray[i];
            }
            return min;
        }
        private void btn_maxLocation_Click(object sender, EventArgs e)
        {
            hideequals();
            int max = findMax();
            for(int i = 0; i< tempArray.Length;i++)
            {
                if(tempArray[i] == max)
                {
                    if(grb_equals.Controls[i] is TextBox)
                    {
                        grb_equals.Controls[i].Visible = true;
                        //grb_equals.Controls[i].Text = string.Empty;
                        grb_equals.Controls[i].Text = max.ToString();
                    }    
                }
            }    
        }
        private bool checkCP(int value)
        {
            for(int i = 0; i <= Math.Sqrt(value); i++)
            {
                if(Math.Pow(i,2)==value && value != 0)
                {
                    return true;
                }    
            }
            return false;
        }
        private void btn_cp_Click(object sender, EventArgs e)
        {
            hideequals();
            int sum = 0;
            for (int i = 0; i < tempArray.Length; i++)
            {
                if (checkCP(arr[i]))
                {
                    if (grb_equals.Controls[i] is TextBox)
                    {
                        grb_equals.Controls[i].Visible = true;
                        //grb_equals.Controls[i].Text = string.Empty;
                        grb_equals.Controls[i].Text = tempArray[i].ToString();
                        sum += tempArray[i];
                    }
                }
            }
            if (sum != 0)
            {
                MessageBox.Show("Tổng số chính phương: " + sum.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có số chính phương trong mảng", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chk_bs35_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_bs35.Checked)
            {
                hideequals();
                int count = 0;
                for (int i = 0; i < tempArray.Length; i++)
                {
                    if (checkBS(tempArray[i])==false)
                    {
                        tempArray[count++] = arr[i];
                    }
                }
                Array.Resize(ref tempArray, count);
                if (tempArray.Length != arr.Length)
                {
                    copyValueToControl(tempArray);
                }
                else
                {
                    MessageBox.Show("Không có bội số của 3 và 5 trong mảng", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                setChecked();
            }    
        }

        private void chk_odd_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_odd.Checked)
            {
                hideequals();
                int count = 0;
                for (int i = 0; i < tempArray.Length; i++)
                {
                    if (arr[i] != 0)
                    {
                        if (checkOdd(arr[i])==false)
                        {
                            tempArray[count++] = arr[i];
                        }
                    }
                }
                Array.Resize(ref tempArray, count);
                if (tempArray.Length != arr.Length)
                {
                    copyValueToControl(tempArray);
                }
                else
                {
                    MessageBox.Show("Không có số chẵn trong mảng", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                setChecked();
            }    
        }

        private void chk_max_CheckedChanged(object sender, EventArgs e)
        {
            hideequals();
            int max = findMax();
            int count = 0;
            for (int i = 0; i < tempArray.Length; i++)
            {
                if (arr[i] != 0)
                {
                    if (tempArray[i] != max)
                    {
                        tempArray[count++] = arr[i];
                    }
                }
            }
            Array.Resize(ref tempArray, count);
            setChecked();
            copyValueToControl(tempArray);
        }

        private void chk_min_CheckedChanged(object sender, EventArgs e)
        {
            hideequals();
            int min = findMin();
            int count = 0;
            for (int i = 0; i < tempArray.Length; i++)
            {
                if (arr[i] != 0)
                {
                    if (tempArray[i] != min)
                    {
                        tempArray[count++] = arr[i];
                    }
                }
            }
            Array.Resize(ref tempArray, count);
            if (tempArray.Length != 0)
            setChecked();
            copyValueToControl(tempArray);
        }

        private void chk_prime_CheckedChanged(object sender, EventArgs e)
        {
            hideequals();
            int count = 0;
            for (int i = 0; i < tempArray.Length; i++)
            {
                if (arr[i] != 0)
                {
                    if (laSNT(arr[i])==false)
                    {
                        tempArray[count++] = arr[i];
                    }
                }
            }
            Array.Resize(ref tempArray, count);
            if (tempArray.Length != arr.Length)
            {
                copyValueToControl(tempArray);
            }
            else
            {
                MessageBox.Show("Không có số nguyên tố trong mảng", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            setChecked();
        }

        private void chk_cp_CheckedChanged(object sender, EventArgs e)
        {
            hideequals();
            int count = 0;
            for (int i = 0; i < tempArray.Length; i++)
            {
                if (arr[i] != 0)
                {
                    if (checkCP(arr[i]) == false)
                    {
                        tempArray[count++] = arr[i];
                    }
                }
            }
            Array.Resize(ref tempArray, count);
            if (tempArray.Length != arr.Length)
            {
                copyValueToControl(tempArray);
            }
            else
            {
                MessageBox.Show("Không có số chính phương trong mảng", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            setChecked();
        }
    }
}
