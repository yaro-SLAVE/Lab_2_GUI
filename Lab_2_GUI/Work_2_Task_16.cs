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
    public partial class Work_2_Task_16 : Form
    {
        private Form form1;
        private Form form3;
        public Work_2_Task_16(Form form1)
        {
            InitializeComponent();
            this.form1 = form1;
            form3 = new Work_3_Task_13(this);
        }

        private void Work_2_Task_16_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            form3.Show();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] result = getSquares(int.Parse(widthBox.Text), int.Parse(heightBox.Text));
                String text = "";
                for (int i = 0; i < result.Length / 2; ++i)
                {
                    text += "Квадрат " + result[i, 0] + " на " + result[i, 0] + " в количестве " + result[i, 1] + " штук\n";
                }
                resultLabel.ForeColor = Color.Blue;
                resultLabel.Text = text;
            } catch (FormatException)
            {
                resultLabel.ForeColor = System.Drawing.Color.Red;
                resultLabel.Text = "Вы ввели символы!\nИли оставили одну из ячеек пустой!";
            }
        }

        public static int[,] getSquares(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                var result = new int[1, 2] { { 0, 0 } };
                return result;
            }

            else
            {
                var arr = new List<int>();

                while (a > 0 && b > 0)
                {
                    if (a >= b)
                    {
                        a -= b;
                        arr.Add(b);
                    }
                    else
                    {
                        b -= a;
                        arr.Add(a);
                    }
                }

                int n = arr.Count;
                var result = new int[n, 2];
                var dop = new int[n];
                int k = 0;
                for (int i = 0; i < n; ++i)
                {
                    int c = arr[i];
                    if (!dop.Contains(c))
                    {
                        int g = 1;
                        result[k, 0] = c;
                        dop[k] = c;

                        for (int j = i + 1; j < n; ++j)
                        {
                            if (arr[j] == c)
                            {
                                ++g;
                            }
                        }

                        result[k, 1] = g;
                        ++k;
                    }
                }

                for (int i = 0; i < arr.Count; ++i)
                {
                    if (result[i, 0] == 0)
                    {
                        --n;
                    }
                }

                var result1 = new int[n, 2];

                for (int i = 0; i < n; ++i)
                {
                    result1[i, 0] = result[i, 0];
                    result1[i, 1] = result[i, 1];
                }

                return result1;
            }
        }
    }
}
