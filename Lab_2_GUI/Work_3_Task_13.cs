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
        public Work_3_Task_13()
        {
            InitializeComponent();
            lineBox.Text = Properties.Settings.Default.lineBox;
        }

        private void Work_3_Task_13_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.lineBox = lineBox.Text;
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            Program.goToWork(2, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int result = Logic.getSum(lineBox.Text);
                resultLabel.ForeColor = Color.Blue;
                resultLabel.Text = result.ToString();
            }
            catch (FormatException)
            {
                resultLabel.ForeColor = System.Drawing.Color.Red;
                resultLabel.Text = "Вы ввели недопустимые символы!\nИли оставили ячейку пустой!";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Program.goToWork(2, 1);
        }
    }
}
