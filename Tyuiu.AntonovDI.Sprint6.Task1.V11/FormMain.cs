using System;
using System.Text;
using System.Windows.Forms;
using Tyuiu.AntonovDI.Sprint6.Task1.V11.Lib;

namespace Tyuiu.AntonovDI.Sprint6.Task1.V11
{
    public partial class FormMain : Form
    {
        private DataService calc = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int xStart = -5;
                int xStop = 5;

                var vals = calc.GetMassFunction(xStart, xStop);

                var sb = new StringBuilder();

                sb.AppendLine("****************************");
                sb.AppendLine("*   x    |     f(x)        *");
                sb.AppendLine("****************************");

                for (int i = 0; i < vals.Length; i++)
                {
                    int x = xStart + i;
                    sb.AppendLine(
                        $"*  {x,4}  |  {vals[i],10:F2}  *"
                    );
                }

                sb.AppendLine("****************************");

                textBoxResult_ADI.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 1 выполнил студент группы ИСТНб-25-1 Антонов Даниил Иванович",
                "Сообщение"
            );
        }
    }
}
