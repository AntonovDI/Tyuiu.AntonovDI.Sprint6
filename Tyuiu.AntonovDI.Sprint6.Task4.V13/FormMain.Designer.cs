using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.AntonovDI.Sprint6.Task4.V13
{
    partial class FormMain
    {
        private GroupBox groupBoxTask_ADI;
        private TextBox textBoxTask_ADI;
        private PictureBox pictureBoxTask_ADI;
        private GroupBox groupBoxChart_ADI;
        private PictureBox pictureBoxChart_ADI;
        private GroupBox groupBoxResult_ADI;
        private TextBox textBoxResult_ADI;
        private Button buttonExecute_ADI;
        private Button buttonSave_ADI;
        private Button buttonInfo_ADI;

        private void InitializeComponent()
        {
            groupBoxTask_ADI = new GroupBox();
            textBoxTask_ADI = new TextBox();
            pictureBoxTask_ADI = new PictureBox();
            groupBoxChart_ADI = new GroupBox();
            pictureBoxChart_ADI = new PictureBox();
            groupBoxResult_ADI = new GroupBox();
            textBoxResult_ADI = new TextBox();
            buttonExecute_ADI = new Button();
            buttonSave_ADI = new Button();
            buttonInfo_ADI = new Button();

            // groupBoxTask_ADI
            groupBoxTask_ADI.Text = "Условие задачи";
            groupBoxTask_ADI.Dock = DockStyle.Top;
            groupBoxTask_ADI.Height = 220;

            textBoxTask_ADI.Multiline = true;
            textBoxTask_ADI.ReadOnly = true;
            textBoxTask_ADI.ScrollBars = ScrollBars.Vertical;
            textBoxTask_ADI.Dock = DockStyle.Top;
            textBoxTask_ADI.Height = 80;
            textBoxTask_ADI.Text = "Дан массив для вычисления f(x).\r\nФормула: f(x) = x + 2 + x/(cos(x)+1)";

            pictureBoxTask_ADI.Image = Image.FromFile(@"C:\AntonovDI\Tyuiu.AntonovDI.Sprint6\img\task4.png");
            pictureBoxTask_ADI.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTask_ADI.Dock = DockStyle.Fill;

            groupBoxTask_ADI.Controls.Add(pictureBoxTask_ADI);
            groupBoxTask_ADI.Controls.Add(textBoxTask_ADI);

            // groupBoxChart_ADI
            groupBoxChart_ADI.Text = "График";
            groupBoxChart_ADI.Dock = DockStyle.Right;
            groupBoxChart_ADI.Width = 500;

            pictureBoxChart_ADI.Dock = DockStyle.Fill;
            pictureBoxChart_ADI.BackColor = Color.White;
            pictureBoxChart_ADI.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxChart_ADI.Paint += pictureBoxChart_ADI_Paint;

            groupBoxChart_ADI.Controls.Add(pictureBoxChart_ADI);

            // groupBoxResult_ADI
            groupBoxResult_ADI.Text = "Содержимое файла";
            groupBoxResult_ADI.Dock = DockStyle.Fill;

            textBoxResult_ADI.Dock = DockStyle.Fill;
            textBoxResult_ADI.Multiline = true;
            textBoxResult_ADI.ReadOnly = true;
            textBoxResult_ADI.ScrollBars = ScrollBars.Vertical;

            groupBoxResult_ADI.Controls.Add(textBoxResult_ADI);

            // Buttons
            buttonExecute_ADI.Text = "Выполнить";
            buttonExecute_ADI.BackColor = Color.LightGreen;
            buttonExecute_ADI.Font = new Font("Arial", 11, FontStyle.Bold);
            buttonExecute_ADI.Dock = DockStyle.Left;
            buttonExecute_ADI.Width = 150;
            buttonExecute_ADI.Click += buttonExecute_ADI_Click;

            buttonSave_ADI.Text = "Сохранить";
            buttonSave_ADI.BackColor = Color.LightSalmon;
            buttonSave_ADI.Font = new Font("Arial", 11, FontStyle.Bold);
            buttonSave_ADI.Dock = DockStyle.Left;
            buttonSave_ADI.Width = 150;
            buttonSave_ADI.Click += buttonSave_ADI_Click;

            buttonInfo_ADI.Text = "Инфо";
            buttonInfo_ADI.BackColor = Color.LightSkyBlue;
            buttonInfo_ADI.Font = new Font("Arial", 11, FontStyle.Bold);
            buttonInfo_ADI.Dock = DockStyle.Right;
            buttonInfo_ADI.Width = 150;
            buttonInfo_ADI.Click += buttonInfo_ADI_Click;

            Panel panelButtons = new Panel();
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Height = 50;
            panelButtons.Controls.Add(buttonExecute_ADI);
            panelButtons.Controls.Add(buttonSave_ADI);
            panelButtons.Controls.Add(buttonInfo_ADI);

            // Form
            ClientSize = new Size(1000, 600);
            Text = "Спринт 6 | Таск 4 | Вариант 13 | Антонов Д.И.";
            FormBorderStyle = FormBorderStyle.Sizable;
            StartPosition = FormStartPosition.CenterScreen;

            Controls.Add(groupBoxResult_ADI);
            Controls.Add(groupBoxChart_ADI);
            Controls.Add(groupBoxTask_ADI);
            Controls.Add(panelButtons);
        }
    }
}
