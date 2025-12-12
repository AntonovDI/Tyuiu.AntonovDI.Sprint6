using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.AntonovDI.Sprint6.Task6.V18
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox groupBoxTask_ADI;
        private Label labelTask_ADI;
        private GroupBox groupBoxIn_ADI;
        private TextBox textBoxIn_ADI;
        private GroupBox groupBoxOut_ADI;
        private TextBox textBoxOut_ADI;
        private FlowLayoutPanel panelButtons_ADI;
        private Button buttonOpen_ADI;
        private Button buttonProcess_ADI;
        private Button buttonInfo_ADI;
        private Label labelFileInfo_ADI;
        private Label labelStats_ADI;

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

            groupBoxTask_ADI = new GroupBox
            {
                Text = "Условия задачи",
                Dock = DockStyle.Top,
                Height = 100
            };
            labelTask_ADI = new Label
            {
                Text = "Программа загружает текстовый файл и выводит слова, содержащие букву 'n'.",
                Dock = DockStyle.Fill,
                Padding = new Padding(10)
            };
            groupBoxTask_ADI.Controls.Add(labelTask_ADI);

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

            groupBoxIn_ADI = new GroupBox
            {
                Text = "Содержимое файла",
                Dock = DockStyle.Left,
                Width = 400
            };
            textBoxIn_ADI = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Fill,
                Font = new Font("Consolas", 10)
            };
            groupBoxIn_ADI.Controls.Add(textBoxIn_ADI);

            groupBoxOut_ADI = new GroupBox
            {
                Text = "Слова с буквой 'n'",
                Dock = DockStyle.Fill
            };
            textBoxOut_ADI = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Fill,
                Font = new Font("Consolas", 10)
            };
            groupBoxOut_ADI.Controls.Add(textBoxOut_ADI);

            labelFileInfo_ADI = new Label
            {
                AutoSize = true,
                ForeColor = Color.DarkBlue,
                Location = new Point(10, panelButtons_ADI.Bottom + 5)
            };

            labelStats_ADI = new Label
            {
                AutoSize = true,
                ForeColor = Color.DarkGreen,
                Location = new Point(10, labelFileInfo_ADI.Bottom + 5)
            };

            ClientSize = new Size(850, 500);
            Controls.Add(groupBoxOut_ADI);
            Controls.Add(groupBoxIn_ADI);
            Controls.Add(labelStats_ADI);
            Controls.Add(labelFileInfo_ADI);
            Controls.Add(panelButtons_ADI);
            Controls.Add(groupBoxTask_ADI);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 18 | Антонов Д.И.";
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimumSize = new Size(850, 500);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
