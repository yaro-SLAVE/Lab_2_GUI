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
    public partial class Work_1_Task_13 : Form
    {
        private Form form2;
        public Work_1_Task_13()
        {
            InitializeComponent();
            trainComingHours.Text = Properties.Settings.Default.trainComingHours;
            trainComingMinutes.Text = Properties.Settings.Default.trainComingMinutes;
            trainLeavingHours.Text = Properties.Settings.Default.trainLeavingHours;
            trainLeavingMinutes.Text = Properties.Settings.Default.trainLeavingMinutes;
            passengerComingHours.Text = Properties.Settings.Default.passengerComingHours;
            passengerComingMinutes.Text = Properties.Settings.Default.passengerComingMinutes;
        }

        private void Work_1_Task_13_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.trainComingHours = trainComingHours.Text;
            Properties.Settings.Default.trainComingMinutes = trainComingMinutes.Text;
            Properties.Settings.Default.trainLeavingHours = trainLeavingHours.Text;
            Properties.Settings.Default.trainLeavingMinutes = trainLeavingMinutes.Text;
            Properties.Settings.Default.passengerComingMinutes = passengerComingMinutes.Text;
            Properties.Settings.Default.passengerComingHours = passengerComingHours.Text;
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((int.Parse(trainComingHours.Text) <= 23 && int.Parse(trainComingHours.Text) >= 0) &&
                    (int.Parse(trainComingMinutes.Text) <= 59 && int.Parse(trainComingMinutes.Text) >= 0) &&
                    (int.Parse(trainLeavingHours.Text) <= 23 && int.Parse(trainLeavingHours.Text) >= 0) &&
                    (int.Parse(trainLeavingMinutes.Text) <= 59 && int.Parse(trainLeavingMinutes.Text) >= 0) &&
                    (int.Parse(passengerComingHours.Text) <= 23 && int.Parse(passengerComingHours.Text) >= 0) &&
                    (int.Parse(passengerComingMinutes.Text) <= 59 && int.Parse(passengerComingMinutes.Text) >= 0))
                {
                    resultLabel.ForeColor = Color.Blue;
                    resultLabel.Text = Logic.getTrain(int.Parse(trainComingHours.Text), int.Parse(trainComingMinutes.Text), int.Parse(trainLeavingHours.Text), int.Parse(trainLeavingMinutes.Text), int.Parse(passengerComingHours.Text), int.Parse(passengerComingMinutes.Text));

                }
                else
                {
                    resultLabel.ForeColor = System.Drawing.Color.Red;
                    resultLabel.Text = "Ошибка! Проверьте введённые данные!\n0 <= Часы <= 23\n0 <= Минуты <= 59";
                }
            } 
            catch (System.FormatException)
            {
                resultLabel.ForeColor = System.Drawing.Color.Red;
                resultLabel.Text = "Ошибка! Вы ввели не все данные!\nИли ввели символы!";
            }
        }

        private void thirdButton_Click(object sender, EventArgs e)
        {
            Program.goToWork(0, 2);
        }

        private void secondButton_Click(object sender, EventArgs e)
        {
            Program.goToWork(0, 1);
        }
    }
}

