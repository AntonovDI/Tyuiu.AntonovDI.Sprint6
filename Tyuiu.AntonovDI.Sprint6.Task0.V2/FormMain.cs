using System;
using System.Windows.Forms;
using Tyuiu.AntonovDI.Sprint6.Task0.V2.Lib;

namespace Tyuiu.AntonovDI.Sprint6.Task0.V2
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
                int xVal = 3;
                double res = calc.Calculate(xVal);

                textBoxResult_ADI.Text = $"Результат при x = {xVal}: {res:F3}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 0 выполнил студент группы ИСТНб-25-1 Антонов Даниил Иванович",
                "Сообщение"
            );
        }
    }
}
