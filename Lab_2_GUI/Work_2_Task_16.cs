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
        public Work_2_Task_16()
        {
            InitializeComponent();
            widthBox.Text = Properties.Settings.Default.widthBox;
            heightBox.Text = Properties.Settings.Default.heightBox;
        }

        private void Work_2_Task_16_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.widthBox = widthBox.Text;
            Properties.Settings.Default.heightBox = heightBox.Text;
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            Program.goToWork(1, 0);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Program.goToWork(1, 2);
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] result = Logic.getSquares(int.Parse(widthBox.Text), int.Parse(heightBox.Text));
                String text = "";
                for (int i = 0; i < result.Length / 2; ++i)
                {
                    text += "Квадрат " + result[i, 0] + " на " + result[i, 0] + " в количестве " + result[i, 1] + " штук\n";
                }
                resultLabel.ForeColor = Color.Blue;
                resultLabel.Text = text;
            }
            catch (FormatException)
            {
                resultLabel.ForeColor = System.Drawing.Color.Red;
                resultLabel.Text = "Вы ввели символы!\nИли оставили одну из ячеек пустой!";
            }
        }
    }
}
