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
            this.form2 = new Work_2_Task_16(this);
        }

        private void Work_1_Task_13_FormClosing(object sender, FormClosingEventArgs e)
        {
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
                    resultLabel.Text = getTrain(int.Parse(trainComingHours.Text), int.Parse(trainComingMinutes.Text), int.Parse(trainLeavingHours.Text), int.Parse(trainLeavingMinutes.Text), int.Parse(passengerComingHours.Text), int.Parse(passengerComingMinutes.Text));

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

        private static string getTrain(int a, int b, int c, int d, int n, int m)
        {
            string result;
            var timeRange = new int[4];
            timeRange[0] = a;
            timeRange[1] = c;
            timeRange[2] = b;
            timeRange[3] = d;
            var humanComing = new int[2] { n, m };

            bool flag = false;

            if (timeRange[0] == timeRange[1] && timeRange[2] == timeRange[3])
            {
                flag = false;
            }

            else
            {
                if (timeRange[0] < timeRange[1])
                {
                    if (humanComing[0] > timeRange[0] && humanComing[0] < timeRange[1])
                    {
                        flag = true;
                    }

                    else if (humanComing[0] == timeRange[0] && humanComing[1] >= timeRange[2])
                    {
                        flag = true;
                    }

                    else if (humanComing[0] == timeRange[1] && humanComing[1] <= timeRange[3])
                    {
                        flag = true;
                    }

                    else if (humanComing[0] < timeRange[0] && humanComing[0] != timeRange[1])
                    {
                        flag = true;
                    }
                }

                else if (timeRange[1] < timeRange[0])
                {
                    if (humanComing[0] <= timeRange[1] && (humanComing[0] >= timeRange[0] || humanComing[0] >= 0))
                    {
                        if (humanComing[0] == timeRange[0] && humanComing[1] >= timeRange[3])
                        {
                            flag = true;
                        }

                        else if (humanComing[0] == timeRange[1] && humanComing[1] <= timeRange[4])
                        {
                            flag = true;
                        }

                        else if (humanComing[0] < timeRange[1] && (humanComing[0] > timeRange[0] || humanComing[0] >= 0))
                        {
                            flag = true;
                        }
                    }
                }

                else if (timeRange[0] == timeRange[1])
                {
                    if (humanComing[1] >= timeRange[2] && humanComing[1] <= timeRange[3])
                    {
                        flag = true;
                    }
                }
            }

            if (flag)
            {
                result = "Поезд стоит на платформе";
            }
            else
            {
                result = "Поезд НЕ стоит на платформе";
            }

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }
    }
}

