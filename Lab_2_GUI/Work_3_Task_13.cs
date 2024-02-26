using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_GUI
{
    public partial class Work_3_Task_13 : Form
    {
        private Form form2;
        public Work_3_Task_13(Form form2)
        {
            InitializeComponent();
            this.form2 = form2;
        }

        private void Work_3_Task_13_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int result = getSum(lineBox.Text);
                resultLabel.ForeColor = Color.Blue;
                resultLabel.Text = result.ToString();
            }
            catch (FormatException)
            {
                resultLabel.ForeColor = System.Drawing.Color.Red;
                resultLabel.Text = "Вы ввели недопустимые символы!\nИли оставили ячейку пустой!";
            }
        }

        private static int getSum(string str)
        {
            int sum = 0;
            int n = 0;
            try
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '+' || str[i] == '-')
                    {
                        ++n;
                    }
                }

                int[] nums = new int[n + 1];
                char[] syms = new char[n];
                string dop = "";
                int k = 0;
                int g = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != '+' && str[i] != '-')
                    {
                        dop += str[i];
                    }

                    else
                    {
                        nums[k] = int.Parse(dop);
                        syms[g] = str[i];
                        ++k;
                        ++g;
                        dop = "";
                    }
                }

                nums[k] = int.Parse(dop);

                sum = nums[0];

                for (int i = 0; i < n; ++i)
                {
                    if (syms[i] == '+')
                    {
                        sum += nums[i + 1];
                    }
                    else
                    {
                        sum -= nums[i + 1];
                    }
                }
            } catch (FormatException)
            {
                throw;
            }

            return sum;
        }
    }
}
