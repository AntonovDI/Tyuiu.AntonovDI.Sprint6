using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.AntonovDI.Sprint6.Task7.V28
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox groupBoxTask_ADI;
        private GroupBox groupBoxIn_ADI;
        private GroupBox groupBoxOut_ADI;
        private DataGridView dataGridViewIn_ADI;
        private DataGridView dataGridViewOut_ADI;
        private FlowLayoutPanel panelButtons_ADI;
        private Button buttonOpen_ADI;
        private Button buttonProcess_ADI;
        private Button buttonInfo_ADI;
        private Label labelFileInfo_ADI;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            SuspendLayout();

            // GroupBox с условиями задачи
            groupBoxTask_ADI = new GroupBox
            {
                Text = "Условия задачи",
                Dock = DockStyle.Top,
                Height = 80
            };
            Label labelTask = new Label
            {
                Text = "Программа загружает CSV файл с матрицей и в седьмой строке заменяет все числа, не равные 13, на 0.",
                Dock = DockStyle.Fill,
                Padding = new Padding(10)
            };
            groupBoxTask_ADI.Controls.Add(labelTask);

            // Панель кнопок
            panelButtons_ADI = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 50,
                Padding = new Padding(10),
                FlowDirection = FlowDirection.LeftToRight
            };

            buttonOpen_ADI = new Button
            {
                Size = new Size(40, 40),
                BackgroundImage = Image.FromFile(@"C:\AntonovDI\Tyuiu.AntonovDI.Sprint6\img\folder_add.png"),
                BackgroundImageLayout = ImageLayout.Stretch
            };
            buttonOpen_ADI.Click += buttonOpen_ADI_Click;

            buttonProcess_ADI = new Button
            {
                Size = new Size(40, 40),
                BackgroundImage = Image.FromFile(@"C:\AntonovDI\Tyuiu.AntonovDI.Sprint6\img\page_white_go.png"),
                BackgroundImageLayout = ImageLayout.Stretch,
                Enabled = false
            };
            buttonProcess_ADI.Click += buttonProcess_ADI_Click;

            buttonInfo_ADI = new Button
            {
                Size = new Size(40, 40),
                BackgroundImage = Image.FromFile(@"C:\AntonovDI\Tyuiu.AntonovDI.Sprint6\img\help.png"),
                BackgroundImageLayout = ImageLayout.Stretch
            };
            buttonInfo_ADI.Click += buttonInfo_ADI_Click;

            panelButtons_ADI.Controls.Add(buttonOpen_ADI);
            panelButtons_ADI.Controls.Add(buttonProcess_ADI);
            panelButtons_ADI.Controls.Add(buttonInfo_ADI);

            // Группбокс для исходной матрицы
            groupBoxIn_ADI = new GroupBox
            {
                Text = "Исходная матрица",
                Dock = DockStyle.Left,
                Width = 500
            };
            dataGridViewIn_ADI = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersWidth = 50,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false
            };
            groupBoxIn_ADI.Controls.Add(dataGridViewIn_ADI);

            // Группбокс для обработанной матрицы
            groupBoxOut_ADI = new GroupBox
            {
                Text = "Обработанная матрица",
                Dock = DockStyle.Fill
            };
            dataGridViewOut_ADI = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersWidth = 50,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false
            };
            groupBoxOut_ADI.Controls.Add(dataGridViewOut_ADI);

            // Лейбл информации о файле
            labelFileInfo_ADI = new Label
            {
                AutoSize = true,
                ForeColor = Color.DarkBlue,
                Location = new Point(10, panelButtons_ADI.Bottom + 5)
            };

            // Настройка формы
            ClientSize = new Size(1000, 600);
            Controls.Add(groupBoxOut_ADI);
            Controls.Add(groupBoxIn_ADI);
            Controls.Add(labelFileInfo_ADI);
            Controls.Add(panelButtons_ADI);
            Controls.Add(groupBoxTask_ADI);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 28 | Антонов Д.И.";
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimumSize = new Size(1000, 600);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
