using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Tyuiu.AntonovDI.Sprint6.Task4.V13.Lib;

namespace Tyuiu.AntonovDI.Sprint6.Task4.V13
{
    public partial class FormMain : Form
    {
        private DataService ds_ADI = new DataService();
        private double[] functionValues_ADI = Array.Empty<double>();
        private int startX_ADI = -5;
        private int endX_ADI = 5;

        public FormMain()
        {
            InitializeComponent();
            buttonSave_ADI.Enabled = false;
        }

        private void buttonExecute_ADI_Click(object sender, EventArgs e)
        {
            functionValues_ADI = ds_ADI.GetMassFunction(startX_ADI, endX_ADI);
            UpdateTextResult_ADI();
            pictureBoxChart_ADI.Refresh();
            buttonSave_ADI.Enabled = true;
        }

        private void UpdateTextResult_ADI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*********************************");
            sb.AppendLine("*       x       *      f(x)     *");
            sb.AppendLine("*********************************");

            for (int i = 0; i < functionValues_ADI.Length; i++)
                sb.AppendLine($"*    {startX_ADI + i,4:F0}     *    {functionValues_ADI[i],8:F2}    *");

            sb.AppendLine("*********************************");
            textBoxResult_ADI.Text = sb.ToString();
        }

        private void pictureBoxChart_ADI_Paint(object sender, PaintEventArgs e)
        {
            if (functionValues_ADI.Length == 0) return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            int width = pictureBoxChart_ADI.Width - 40;
            int height = pictureBoxChart_ADI.Height - 40;

            Pen axisPen = new Pen(Color.Black, 2);
            g.DrawLine(axisPen, 20, height / 2, width + 20, height / 2);
            g.DrawLine(axisPen, 20, 20, 20, height + 20);

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

            Pen graphPen = new Pen(Color.Blue, 2);
            for (int i = 0; i < functionValues_ADI.Length - 1; i++)
            {
                float x1 = (float)(20 + i * dx);
                float x2 = (float)(20 + (i + 1) * dx);
                float y1 = (float)(20 + height - (functionValues_ADI[i] - min) * scaleY);
                float y2 = (float)(20 + height - (functionValues_ADI[i + 1] - min) * scaleY);
                g.DrawLine(graphPen, x1, y1, x2, y2);
            }

            Font labelFont = new Font("Arial", 8);
            for (int i = 0; i < functionValues_ADI.Length; i += 2)
            {
                float x = (float)(20 + i * dx);
                float y = (float)(20 + height - (functionValues_ADI[i] - min) * scaleY);
                g.FillEllipse(Brushes.Red, x - 3, y - 3, 6, 6);
                g.DrawString($"({startX_ADI + i}, {functionValues_ADI[i]:F2})", labelFont, Brushes.DarkBlue, x + 5, y - 15);
            }

            axisPen.Dispose();
            graphPen.Dispose();
            labelFont.Dispose();
        }

        private void buttonSave_ADI_Click(object sender, EventArgs e)
        {
            string textPath = Path.Combine(Directory.GetCurrentDirectory(), "Output_Task4_ADI.txt");
            File.WriteAllText(textPath, textBoxResult_ADI.Text, Encoding.UTF8);

            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "Output_Task4_ADI.png");
            Bitmap bmp = new Bitmap(pictureBoxChart_ADI.Width, pictureBoxChart_ADI.Height);
            pictureBoxChart_ADI.DrawToBitmap(bmp, pictureBoxChart_ADI.ClientRectangle);
            bmp.Save(imagePath, System.Drawing.Imaging.ImageFormat.Png);
            bmp.Dispose();

            Form saveForm = new Form
            {
                Text = "Файлы сохранены",
                Size = new Size(500, 250),
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.Sizable
            };

            TextBox infoBox = new TextBox()
            {
                Multiline = true,
                ReadOnly = true,
                Dock = DockStyle.Top,
                Height = 100,
                Text = $"Файлы сохранены:\r\nТекст: {textPath}\r\nГрафик: {imagePath}"
            };

            Button btnOpenText = new Button()
            {
                Text = "Открыть текст",
                BackColor = Color.LightSalmon,
                Font = new Font("Arial", 11, FontStyle.Bold),
                Dock = DockStyle.Left,
                Width = 200
            };
            btnOpenText.Click += (_, __) => System.Diagnostics.Process.Start("notepad.exe", textPath);

            Button btnOpenImage = new Button()
            {
                Text = "Открыть график",
                BackColor = Color.LightGreen,
                Font = new Font("Arial", 11, FontStyle.Bold),
                Dock = DockStyle.Right,
                Width = 200
            };
            btnOpenImage.Click += (_, __) => System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = imagePath,
                UseShellExecute = true
            });

            Panel panelButtons = new Panel() { Dock = DockStyle.Bottom, Height = 50 };
            panelButtons.Controls.Add(btnOpenText);
            panelButtons.Controls.Add(btnOpenImage);

            saveForm.Controls.Add(infoBox);
            saveForm.Controls.Add(panelButtons);

            saveForm.ShowDialog();
        }

        private void buttonInfo_ADI_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                 "Таск 4 выполнил студент группы ИСТНб-25-1 Антонов Даниил Иванович",
                 "Сообщение"
             );
        }
        
    }
}
