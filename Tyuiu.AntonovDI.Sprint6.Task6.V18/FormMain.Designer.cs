using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.AntonovDI.Sprint6.Task6.V18
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox groupBoxTask;
        private Label labelTask;

        private GroupBox groupBoxIn;
        private GroupBox groupBoxOut;

        private TextBox textBoxIn;
        private TextBox textBoxOut;

        private FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonInfo;

        private Label labelFileInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            groupBoxTask = new GroupBox();
            labelTask = new Label();

            groupBoxIn = new GroupBox();
            groupBoxOut = new GroupBox();

            textBoxIn = new TextBox();
            textBoxOut = new TextBox();

            panelButtons = new FlowLayoutPanel();

            buttonOpen = new System.Windows.Forms.Button();
            buttonProcess = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            buttonInfo = new System.Windows.Forms.Button();

            labelFileInfo = new Label();

            SuspendLayout();

            // groupBoxTask
            groupBoxTask.Text = "Условия задачи";
            groupBoxTask.Dock = DockStyle.Top;
            groupBoxTask.Height = 80;

            labelTask.Text = "Загрузить текстовый файл и вывести все слова, содержащие букву 'l'.";
            labelTask.Dock = DockStyle.Fill;
            labelTask.Padding = new Padding(10);

            groupBoxTask.Controls.Add(labelTask);

            // panelButtons
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Height = 50;
            panelButtons.Padding = new Padding(10);
            panelButtons.FlowDirection = FlowDirection.LeftToRight;

            // Buttons
            buttonOpen.Size = new Size(40, 40);
            buttonProcess.Size = new Size(40, 40);
            buttonSave.Size = new Size(40, 40);
            buttonInfo.Size = new Size(40, 40);

            buttonOpen.BackgroundImage = Image.FromFile(@"C:\AntonovDI\Tyuiu.AntonovDI.Sprint6\img\folder_add.png");
            buttonProcess.BackgroundImage = Image.FromFile(@"C:\AntonovDI\Tyuiu.AntonovDI.Sprint6\img\page_white_go.png");
            buttonSave.BackgroundImage = Image.FromFile(@"C:\AntonovDI\Tyuiu.AntonovDI.Sprint6\img\save.png");
            buttonInfo.BackgroundImage = Image.FromFile(@"C:\AntonovDI\Tyuiu.AntonovDI.Sprint6\img\help.png");

            buttonOpen.BackgroundImageLayout = ImageLayout.Stretch;
            buttonProcess.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSave.BackgroundImageLayout = ImageLayout.Stretch;
            buttonInfo.BackgroundImageLayout = ImageLayout.Stretch;

            // Disable initially
            buttonProcess.Enabled = false;
            buttonSave.Enabled = false;

            // events
            buttonOpen.Click += buttonOpen_Click;
            buttonProcess.Click += buttonProcess_Click;
            buttonSave.Click += buttonSave_Click;
            buttonInfo.Click += buttonInfo_Click;

            panelButtons.Controls.Add(buttonOpen);
            panelButtons.Controls.Add(buttonProcess);
            panelButtons.Controls.Add(buttonSave);
            panelButtons.Controls.Add(buttonInfo);

            // groupBoxIn
            groupBoxIn.Text = "Исходный текст";
            groupBoxIn.Dock = DockStyle.Left;
            groupBoxIn.Width = 480;

            textBoxIn.Multiline = true;
            textBoxIn.Dock = DockStyle.Fill;
            textBoxIn.ScrollBars = ScrollBars.Vertical;

            groupBoxIn.Controls.Add(textBoxIn);

            // groupBoxOut
            groupBoxOut.Text = "Результат";
            groupBoxOut.Dock = DockStyle.Fill;

            textBoxOut.Multiline = true;
            textBoxOut.Dock = DockStyle.Fill;
            textBoxOut.ScrollBars = ScrollBars.Vertical;

            groupBoxOut.Controls.Add(textBoxOut);

            // labelFileInfo
            labelFileInfo.AutoSize = true;
            labelFileInfo.ForeColor = Color.DarkBlue;
            labelFileInfo.Location = new Point(10, 140);

            // main form
            ClientSize = new Size(1000, 600);

            Controls.Add(groupBoxOut);
            Controls.Add(groupBoxIn);
            Controls.Add(labelFileInfo);
            Controls.Add(panelButtons);
            Controls.Add(groupBoxTask);

            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Task 6 | Вариант 19 | Антонов Д.И.";
            MinimumSize = new Size(1000, 600);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
