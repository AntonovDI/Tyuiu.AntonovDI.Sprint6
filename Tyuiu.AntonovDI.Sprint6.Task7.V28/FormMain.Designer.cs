using System;
using System.Drawing;
using System.IO;
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
        private Button buttonSave_ADI;
        private Button buttonInfo_ADI;
        private Label labelFileInfo_ADI;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            groupBoxTask_ADI = new GroupBox();
            Label labelTask = new Label();
            panelButtons_ADI = new FlowLayoutPanel();
            buttonOpen_ADI = new Button();
            buttonProcess_ADI = new Button();
            buttonSave_ADI = new Button();
            buttonInfo_ADI = new Button();
            groupBoxIn_ADI = new GroupBox();
            dataGridViewIn_ADI = new DataGridView();
            groupBoxOut_ADI = new GroupBox();
            dataGridViewOut_ADI = new DataGridView();
            labelFileInfo_ADI = new Label();

            SuspendLayout();

            groupBoxTask_ADI.Text = "Условия задачи";
            groupBoxTask_ADI.Dock = DockStyle.Top;
            groupBoxTask_ADI.Height = 80;

            labelTask.Text = "Загрузка CSV и замена всех чисел в 7-й строке кроме 13 на 0.";
            labelTask.Dock = DockStyle.Fill;
            labelTask.Padding = new Padding(10);
            groupBoxTask_ADI.Controls.Add(labelTask);

            panelButtons_ADI.Dock = DockStyle.Top;
            panelButtons_ADI.Height = 50;
            panelButtons_ADI.Padding = new Padding(10);
            panelButtons_ADI.FlowDirection = FlowDirection.LeftToRight;

            buttonOpen_ADI.Size = new Size(40, 40);
            buttonProcess_ADI.Size = new Size(40, 40);
            buttonSave_ADI.Size = new Size(40, 40);
            buttonInfo_ADI.Size = new Size(40, 40);

            buttonOpen_ADI.BackgroundImage = Image.FromFile(@"C:\AntonovDI\Tyuiu.AntonovDI.Sprint6\img\folder_add.png");
            buttonProcess_ADI.BackgroundImage = Image.FromFile(@"C:\AntonovDI\Tyuiu.AntonovDI.Sprint6\img\page_white_go.png");
            buttonSave_ADI.BackgroundImage = Image.FromFile(@"C:\AntonovDI\Tyuiu.AntonovDI.Sprint6\img\save.png");
            buttonInfo_ADI.BackgroundImage = Image.FromFile(@"C:\AntonovDI\Tyuiu.AntonovDI.Sprint6\img\help.png");

            buttonOpen_ADI.BackgroundImageLayout = ImageLayout.Stretch;
            buttonProcess_ADI.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSave_ADI.BackgroundImageLayout = ImageLayout.Stretch;
            buttonInfo_ADI.BackgroundImageLayout = ImageLayout.Stretch;

            buttonProcess_ADI.Enabled = false;
            buttonSave_ADI.Enabled = false;

            buttonOpen_ADI.Click += buttonOpen_ADI_Click;
            buttonProcess_ADI.Click += buttonProcess_ADI_Click;
            buttonSave_ADI.Click += buttonSave_ADI_Click;
            buttonInfo_ADI.Click += buttonInfo_ADI_Click;

            panelButtons_ADI.Controls.Add(buttonOpen_ADI);
            panelButtons_ADI.Controls.Add(buttonProcess_ADI);
            panelButtons_ADI.Controls.Add(buttonSave_ADI);
            panelButtons_ADI.Controls.Add(buttonInfo_ADI);

            groupBoxIn_ADI.Text = "Исходная матрица";
            groupBoxIn_ADI.Dock = DockStyle.Left;
            groupBoxIn_ADI.Width = 480;

            dataGridViewIn_ADI.Dock = DockStyle.Fill;
            dataGridViewIn_ADI.ReadOnly = true;
            dataGridViewIn_ADI.RowHeadersWidth = 50;
            dataGridViewIn_ADI.AllowUserToAddRows = false;
            dataGridViewIn_ADI.AllowUserToDeleteRows = false;

            groupBoxIn_ADI.Controls.Add(dataGridViewIn_ADI);

            groupBoxOut_ADI.Text = "Обработанная матрица";
            groupBoxOut_ADI.Dock = DockStyle.Fill;

            dataGridViewOut_ADI.Dock = DockStyle.Fill;
            dataGridViewOut_ADI.ReadOnly = true;
            dataGridViewOut_ADI.RowHeadersWidth = 50;
            dataGridViewOut_ADI.AllowUserToAddRows = false;
            dataGridViewOut_ADI.AllowUserToDeleteRows = false;

            groupBoxOut_ADI.Controls.Add(dataGridViewOut_ADI);

            labelFileInfo_ADI.AutoSize = true;
            labelFileInfo_ADI.ForeColor = Color.DarkBlue;
            labelFileInfo_ADI.Location = new Point(10, 140);

            ClientSize = new Size(1000, 600);
            Controls.Add(groupBoxOut_ADI);
            Controls.Add(groupBoxIn_ADI);
            Controls.Add(labelFileInfo_ADI);
            Controls.Add(panelButtons_ADI);
            Controls.Add(groupBoxTask_ADI);

            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Task 7 | Вариант 28 | Антонов Д.И.";
            MinimumSize = new Size(1000, 600);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
