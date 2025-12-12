using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.AntonovDI.Sprint6.Task0.V2
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox groupBoxTask_ADI;
        private PictureBox picFormula_ADI;
        private Label labelTask_ADI;

        private GroupBox groupBoxOutput_ADI;
        private TextBox textBoxResult_ADI;

        private Button btnRun_ADI;
        private Button btnInfo_ADI;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBoxTask_ADI = new GroupBox();
            picFormula_ADI = new PictureBox();
            labelTask_ADI = new Label();

            groupBoxOutput_ADI = new GroupBox();
            textBoxResult_ADI = new TextBox();

            btnRun_ADI = new Button();
            btnInfo_ADI = new Button();

            ((System.ComponentModel.ISupportInitialize)picFormula_ADI).BeginInit();
            SuspendLayout();

            // 
            // groupBoxTask_ADI
            // 
            groupBoxTask_ADI.Controls.Add(picFormula_ADI);
            groupBoxTask_ADI.Controls.Add(labelTask_ADI);
            groupBoxTask_ADI.Location = new Point(10, 10);
            groupBoxTask_ADI.Name = "groupBoxTask_ADI";
            groupBoxTask_ADI.Size = new Size(430, 130);
            groupBoxTask_ADI.TabIndex = 0;
            groupBoxTask_ADI.TabStop = false;
            groupBoxTask_ADI.Text = "Условие задачи";

            // 
            // picFormula_ADI
            // 
            picFormula_ADI.ImageLocation = "C:\\AntonovDI\\Tyuiu.AntonovDI.Sprint6\\img\\task0.png";
            picFormula_ADI.Location = new Point(10, 20);
            picFormula_ADI.Name = "picFormula_ADI";
            picFormula_ADI.Size = new Size(400, 50);
            picFormula_ADI.SizeMode = PictureBoxSizeMode.Zoom;

            // 
            // labelTask_ADI
            // 
            labelTask_ADI.Location = new Point(10, 80);
            labelTask_ADI.Name = "labelTask_ADI";
            labelTask_ADI.Size = new Size(400, 40);
            labelTask_ADI.Text = "Вычислить значение функции по формуле при x = 3.";

            // 
            // groupBoxOutput_ADI
            // 
            groupBoxOutput_ADI.Controls.Add(textBoxResult_ADI);
            groupBoxOutput_ADI.Location = new Point(10, 145);
            groupBoxOutput_ADI.Name = "groupBoxOutput_ADI";
            groupBoxOutput_ADI.Size = new Size(430, 100);
            groupBoxOutput_ADI.TabIndex = 1;
            groupBoxOutput_ADI.TabStop = false;
            groupBoxOutput_ADI.Text = "Вывод данных";

            // 
            // textBoxResult_ADI
            // 
            textBoxResult_ADI.Location = new Point(10, 20);
            textBoxResult_ADI.Multiline = true;
            textBoxResult_ADI.ReadOnly = true;
            textBoxResult_ADI.ScrollBars = ScrollBars.Vertical;
            textBoxResult_ADI.Size = new Size(410, 70);
            textBoxResult_ADI.Name = "textBoxResult_ADI";

            // 
            // btnRun_ADI
            // 
            btnRun_ADI.Location = new Point(240, 255);
            btnRun_ADI.Name = "btnRun_ADI";
            btnRun_ADI.Size = new Size(100, 27);
            btnRun_ADI.Text = "Выполнить";
            btnRun_ADI.Click += buttonExecute_Click;

            // 
            // btnInfo_ADI
            // 
            btnInfo_ADI.Location = new Point(350, 255);
            btnInfo_ADI.Name = "btnInfo_ADI";
            btnInfo_ADI.Size = new Size(40, 27);
            btnInfo_ADI.Text = "?";
            btnInfo_ADI.Click += buttonInfo_Click;

            // 
            // FormMain
            // 
            ClientSize = new Size(455, 300);
            Controls.Add(groupBoxTask_ADI);
            Controls.Add(groupBoxOutput_ADI);
            Controls.Add(btnRun_ADI);
            Controls.Add(btnInfo_ADI);

            FormBorderStyle = FormBorderStyle.FixedDialog;  
            MaximizeBox = false;                             
            MinimizeBox = true;                              
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 2 | Антонов Д.И.";

            ((System.ComponentModel.ISupportInitialize)picFormula_ADI).EndInit();
            ResumeLayout(false);
        }
    }
}
