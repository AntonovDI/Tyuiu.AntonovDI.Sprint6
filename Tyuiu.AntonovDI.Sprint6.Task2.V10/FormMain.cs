using System;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.AntonovDI.Sprint6.Task2.V10.Lib;

namespace Tyuiu.AntonovDI.Sprint6.Task2.V10
{
    public partial class FormMain : Form
    {
        private DataService dataService_ADI = new DataService();
        private double[] functionValues_ADI = Array.Empty<double>();
        private int startX_ADI = -5;
        private int endX_ADI = 5;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            functionValues_ADI = dataService_ADI.GetMassFunction(startX_ADI, endX_ADI);

            dataGridViewResult_ADI.Rows.Clear();
            for (int i = 0; i < functionValues_ADI.Length; i++)
            {
                dataGridViewResult_ADI.Rows.Add(startX_ADI + i, functionValues_ADI[i]);
            }

            pictureBoxChart_ADI.Refresh();
        }

        private void pictureBoxChart_Paint(object sender, PaintEventArgs e)
        {
            if (functionValues_ADI.Length == 0) return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            int width = pictureBoxChart_ADI.Width - 40;
            int height = pictureBoxChart_ADI.Height - 40;

            using (Pen axisPen = new Pen(Color.Black, 2))
            {
                // Оси
                g.DrawLine(axisPen, 20, height / 2, width + 20, height / 2); // X
                g.DrawLine(axisPen, 20, 20, 20, height + 20); // Y
            }

            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (double v in functionValues_ADI)
            {
                if (v < min) min = v;
                if (v > max) max = v;
            }

            if (Math.Abs(max - min) < 0.0001)
            {
                max = min + 2;
                min = min - 2;
            }

            double dx = width / (double)(functionValues_ADI.Length - 1);
            double scaleY = height / (max - min);

            using (Pen graphPen = new Pen(Color.Blue, 2))
            {
                for (int i = 0; i < functionValues_ADI.Length - 1; i++)
                {
                    float x1 = (float)(20 + i * dx);
                    float x2 = (float)(20 + (i + 1) * dx);
                    float y1 = (float)(20 + height - (functionValues_ADI[i] - min) * scaleY);
                    float y2 = (float)(20 + height - (functionValues_ADI[i + 1] - min) * scaleY);
                    g.DrawLine(graphPen, x1, y1, x2, y2);
                }
            }

            using (Font labelFont = new Font("Arial", 8))
            {
                for (int i = 0; i < functionValues_ADI.Length; i++)
                {
                    float x = (float)(20 + i * dx);
                    float y = (float)(20 + height - (functionValues_ADI[i] - min) * scaleY);
                    g.FillEllipse(Brushes.Red, x - 3, y - 3, 6, 6);
                    g.DrawString($"({startX_ADI + i}, {functionValues_ADI[i]:F2})", labelFont, Brushes.DarkBlue, x + 5, y - 15);
                }
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                     "Таск 2 выполнил студент группы ИСТНб-25-1 Антонов Даниил Иванович",
                     "Сообщение"
                 );
        
}
    }
}