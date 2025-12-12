using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tyuiu.AntonovDI.Sprint6.Task5.V14.Lib;

namespace Tyuiu.AntonovDI.Sprint6.Task5.V14
{
    public partial class FormMain : Form
    {
        private DataService ds_ADI;
        private double[] allValues_ADI = Array.Empty<double>();
        private double[] filteredValues_ADI = Array.Empty<double>();

        private string textPath_ADI;
        private string imagePath_ADI;

        public FormMain()
        {
            InitializeComponent();
            ds_ADI = new DataService();

            // Пути к файлам
            textPath_ADI = Path.Combine(Directory.GetCurrentDirectory(), "Output_Task5_ADI.txt");
            imagePath_ADI = Path.Combine(Directory.GetCurrentDirectory(), "TempChart.png");
        }

        private void buttonExecute_ADI_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = @"C:\AntonovDI\Tyuiu.AntonovDI.Sprint6\Sprint6Task5\InPutFileTask5V14.txt";
                allValues_ADI = ds_ADI.LoadFromDataFile(filePath);
                filteredValues_ADI = allValues_ADI.Where(v => v >= 10).ToArray();

                dataGridViewValues_ADI.Rows.Clear();
                dataGridViewValues_ADI.Columns.Clear();

                dataGridViewValues_ADI.Columns.Add("colAll", "Все значения");
                dataGridViewValues_ADI.Columns.Add("colFiltered", "≥ 10");

                int rowCount = Math.Max(allValues_ADI.Length, filteredValues_ADI.Length);
                for (int i = 0; i < rowCount; i++)
                {
                    string allVal = i < allValues_ADI.Length ? allValues_ADI[i].ToString("0.###") : "";
                    string filteredVal = i < filteredValues_ADI.Length ? filteredValues_ADI[i].ToString("0.###") : "";
                    dataGridViewValues_ADI.Rows.Add(allVal, filteredVal);
                }

                pictureBoxChart_ADI.Refresh();

                // Сохраняем текст и график сразу
                File.WriteAllText(textPath_ADI, GenerateText_ADI(), Encoding.UTF8);

                Bitmap bmp = new Bitmap(pictureBoxChart_ADI.Width, pictureBoxChart_ADI.Height);
                pictureBoxChart_ADI.DrawToBitmap(bmp, pictureBoxChart_ADI.ClientRectangle);
                bmp.Save(imagePath_ADI, System.Drawing.Imaging.ImageFormat.Png);
                bmp.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateText_ADI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("************* Все значения *************");
            for (int i = 0; i < allValues_ADI.Length; i++)
                sb.AppendLine(allValues_ADI[i].ToString("0.###"));

            sb.AppendLine("\n************* Значения ≥ 10 *************");
            for (int i = 0; i < filteredValues_ADI.Length; i++)
                sb.AppendLine(filteredValues_ADI[i].ToString("0.###"));

            return sb.ToString();
        }

        private void pictureBoxChart_ADI_Paint(object sender, PaintEventArgs e)
        {
            if (filteredValues_ADI.Length == 0) return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            int margin = 40;
            int width = pictureBoxChart_ADI.Width - 2 * margin;
            int height = pictureBoxChart_ADI.Height - 2 * margin;

            Pen axis = new Pen(Color.Black, 2);
            g.DrawLine(axis, margin, margin, margin, margin + height);
            g.DrawLine(axis, margin, margin + height, margin + width, margin + height);

            Font font = new Font("Arial", 9);
            g.DrawString("≥ 10", font, Brushes.Black, 5, margin);
            g.DrawString("Значения", font, Brushes.Black, margin + width / 2 - 30, margin + height + 5);

            double maxVal = filteredValues_ADI.Max();
            if (maxVal == 0) maxVal = 1;

            int barWidth = Math.Min(40, width / Math.Max(1, filteredValues_ADI.Length) - 5);

            for (int i = 0; i < filteredValues_ADI.Length; i++)
            {
                double val = filteredValues_ADI[i];
                int barHeight = (int)((val / maxVal) * (height - 20));
                int x = margin + 10 + i * (barWidth + 10);
                int y = margin + height - barHeight;

                int red = Math.Clamp(100 + i * 15, 0, 255);
                int green = 100;
                int blue = Math.Clamp(150 + i * 5, 0, 255);
                Brush bar = new SolidBrush(Color.FromArgb(red, green, blue));

                g.FillRectangle(bar, x, y, barWidth, barHeight);
                g.DrawRectangle(Pens.DarkBlue, x, y, barWidth, barHeight);

                string label = val.ToString("0.###");
                SizeF size = g.MeasureString(label, font);
                if (y - size.Height - 2 > 0)
                    g.DrawString(label, font, Brushes.Black, x + barWidth / 2 - size.Width / 2, y - size.Height - 2);

                g.DrawString((i + 1).ToString(), font, Brushes.Black, x + barWidth / 2 - 5, margin + height + 2);

                bar.Dispose();
            }

            axis.Dispose();
            font.Dispose();
        }

        private void buttonOpen_ADI_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textPath_ADI) || !File.Exists(imagePath_ADI))
            {
                MessageBox.Show("Сначала выполните сохранение данных через кнопку «Выполнить».", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Модальное окно с информацией и кнопками
            Form infoForm = new Form
            {
                Text = "Файлы сохранены",
                Size = new Size(450, 220),
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

            TextBox infoBox = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Dock = DockStyle.Top,
                Height = 100,
                Text = $"Файлы сохранены:\r\nТекст: {textPath_ADI}\r\nГрафик: {imagePath_ADI}"
            };

            Button btnOpenText = new Button
            {
                Text = "Открыть текст",
                Width = 200,
                BackColor = Color.LightBlue,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            btnOpenText.Click += (_, __) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = textPath_ADI,
                    UseShellExecute = true
                });
            };

            Button btnOpenImage = new Button
            {
                Text = "Открыть график",
                Width = 200,
                BackColor = Color.LightGreen,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            btnOpenImage.Click += (_, __) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = imagePath_ADI,
                    UseShellExecute = true
                });
            };

            FlowLayoutPanel panelButtons = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = 50,
                FlowDirection = FlowDirection.LeftToRight
            };
            panelButtons.Controls.Add(btnOpenText);
            panelButtons.Controls.Add(btnOpenImage);

            infoForm.Controls.Add(infoBox);
            infoForm.Controls.Add(panelButtons);

            infoForm.ShowDialog();
        }

        private void buttonInfo_ADI_Click(object sender, EventArgs e)
        {
        
            MessageBox.Show(
               "Таск 5 выполнил студент группы ИСТНб-25-1 Антонов Даниил Иванович",
               "Сообщение"
           );
        }
    }
}
