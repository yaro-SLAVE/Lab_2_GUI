using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_GUI
{
    internal static class Program
    {
        private static Work_1_Task_13 form1;
        private static Work_2_Task_16 form2;
        private static Work_3_Task_13 form3;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form1 = new Work_1_Task_13();
            form2 = new Work_2_Task_16();
            form3 = new Work_3_Task_13();
            Application.Run(form1);
        }

        public static void goToWork(int start, int finish)
        {
            switch (start)
            {
                case 0:
                    form1.Hide();
                    break;
                case 1:
                    form2.Hide();
                    break;
                case 2:
                    form3.Hide();
                    break;
            }

            switch (finish)
            {
                case 0:
                    form1.Show();
                    break;
                case 1:
                    form2.Show();
                    break;
                case 2:
                    form3.Show();
                    break;
            }
        }
    }

    public class Logic
    {
        public static string getTrain(int a, int b, int c, int d, int n, int m)
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

        public static int getSum(string str)
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
            }
            catch (FormatException)
            {
                throw;
            }

            return sum;
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
