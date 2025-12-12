using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.AntonovDI.Sprint6.Task5.V14
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox groupBoxTask_ADI;
        private Label labelTask_ADI;
        private TableLayoutPanel mainLayout_ADI;
        private GroupBox groupBoxFile_ADI;
        private DataGridView dataGridViewValues_ADI;
        private PictureBox pictureBoxChart_ADI;
        private FlowLayoutPanel panelButtons_ADI;
        private Button buttonExecute_ADI;
        private Button buttonOpen_ADI;
        private Button buttonInfo_ADI;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBoxTask_ADI = new GroupBox();
            labelTask_ADI = new Label();
            mainLayout_ADI = new TableLayoutPanel();
            groupBoxFile_ADI = new GroupBox();
            dataGridViewValues_ADI = new DataGridView();
            pictureBoxChart_ADI = new PictureBox();
            panelButtons_ADI = new FlowLayoutPanel();
            buttonExecute_ADI = new Button();
            buttonOpen_ADI = new Button();
            buttonInfo_ADI = new Button();
            groupBoxTask_ADI.SuspendLayout();
            mainLayout_ADI.SuspendLayout();
            groupBoxFile_ADI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewValues_ADI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChart_ADI).BeginInit();
            panelButtons_ADI.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_ADI
            // 
            groupBoxTask_ADI.Controls.Add(labelTask_ADI);
            groupBoxTask_ADI.Dock = DockStyle.Top;
            groupBoxTask_ADI.Location = new Point(0, 0);
            groupBoxTask_ADI.Name = "groupBoxTask_ADI";
            groupBoxTask_ADI.Size = new Size(1553, 120);
            groupBoxTask_ADI.TabIndex = 2;
            groupBoxTask_ADI.TabStop = false;
            groupBoxTask_ADI.Text = "Условие задачи";
            // 
            // labelTask_ADI
            // 
            labelTask_ADI.Dock = DockStyle.Fill;
            labelTask_ADI.Location = new Point(3, 23);
            labelTask_ADI.Name = "labelTask_ADI";
            labelTask_ADI.Padding = new Padding(10);
            labelTask_ADI.Size = new Size(1547, 94);
            labelTask_ADI.TabIndex = 0;
            labelTask_ADI.Text = "Прочитать данные из файла InPutFileTask5V14.txt.\nВывести все числа ≥ 10 и построить диаграмму.\nВещественные значения округлить до 3 знаков.";
            labelTask_ADI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mainLayout_ADI
            // 
            mainLayout_ADI.ColumnCount = 2;
            mainLayout_ADI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainLayout_ADI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainLayout_ADI.Controls.Add(groupBoxFile_ADI, 0, 0);
            mainLayout_ADI.Controls.Add(pictureBoxChart_ADI, 1, 0);
            mainLayout_ADI.Dock = DockStyle.Fill;
            mainLayout_ADI.Location = new Point(0, 170);
            mainLayout_ADI.Name = "mainLayout_ADI";
            mainLayout_ADI.RowCount = 1;
            mainLayout_ADI.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainLayout_ADI.Size = new Size(1553, 430);
            mainLayout_ADI.TabIndex = 0;
            // 
            // groupBoxFile_ADI
            // 
            groupBoxFile_ADI.Controls.Add(dataGridViewValues_ADI);
            groupBoxFile_ADI.Dock = DockStyle.Fill;
            groupBoxFile_ADI.Location = new Point(3, 3);
            groupBoxFile_ADI.Name = "groupBoxFile_ADI";
            groupBoxFile_ADI.Size = new Size(770, 424);
            groupBoxFile_ADI.TabIndex = 0;
            groupBoxFile_ADI.TabStop = false;
            groupBoxFile_ADI.Text = "Содержимое файла";
            // 
            // dataGridViewValues_ADI
            // 
            dataGridViewValues_ADI.AllowUserToAddRows = false;
            dataGridViewValues_ADI.ColumnHeadersHeight = 29;
            dataGridViewValues_ADI.Dock = DockStyle.Fill;
            dataGridViewValues_ADI.Location = new Point(3, 23);
            dataGridViewValues_ADI.Name = "dataGridViewValues_ADI";
            dataGridViewValues_ADI.ReadOnly = true;
            dataGridViewValues_ADI.RowHeadersVisible = false;
            dataGridViewValues_ADI.RowHeadersWidth = 51;
            dataGridViewValues_ADI.Size = new Size(764, 398);
            dataGridViewValues_ADI.TabIndex = 0;
            // 
            // pictureBoxChart_ADI
            // 
            pictureBoxChart_ADI.BackColor = Color.White;
            pictureBoxChart_ADI.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxChart_ADI.Dock = DockStyle.Fill;
            pictureBoxChart_ADI.Location = new Point(779, 3);
            pictureBoxChart_ADI.Name = "pictureBoxChart_ADI";
            pictureBoxChart_ADI.Size = new Size(771, 424);
            pictureBoxChart_ADI.TabIndex = 1;
            pictureBoxChart_ADI.TabStop = false;
            pictureBoxChart_ADI.Paint += pictureBoxChart_ADI_Paint;
            // 
            // panelButtons_ADI
            // 
            panelButtons_ADI.Controls.Add(buttonExecute_ADI);
            panelButtons_ADI.Controls.Add(buttonOpen_ADI);
            panelButtons_ADI.Controls.Add(buttonInfo_ADI);
            panelButtons_ADI.Dock = DockStyle.Top;
            panelButtons_ADI.Location = new Point(0, 120);
            panelButtons_ADI.Name = "panelButtons_ADI";
            panelButtons_ADI.Padding = new Padding(10);
            panelButtons_ADI.Size = new Size(1553, 50);
            panelButtons_ADI.TabIndex = 1;
            // 
            // buttonExecute_ADI
            // 
            buttonExecute_ADI.BackColor = Color.LightGreen;
            buttonExecute_ADI.FlatStyle = FlatStyle.Flat;
            buttonExecute_ADI.Font = new Font("Arial", 10F, FontStyle.Bold);
            buttonExecute_ADI.Location = new Point(13, 13);
            buttonExecute_ADI.Name = "buttonExecute_ADI";
            buttonExecute_ADI.Size = new Size(120, 35);
            buttonExecute_ADI.TabIndex = 0;
            buttonExecute_ADI.Text = "Выполнить";
            buttonExecute_ADI.UseVisualStyleBackColor = false;
            buttonExecute_ADI.Click += buttonExecute_ADI_Click;
            // 
            // buttonOpen_ADI
            // 
            buttonOpen_ADI.BackColor = Color.LightBlue;
            buttonOpen_ADI.FlatStyle = FlatStyle.Flat;
            buttonOpen_ADI.Font = new Font("Arial", 10F, FontStyle.Bold);
            buttonOpen_ADI.Location = new Point(139, 13);
            buttonOpen_ADI.Name = "buttonOpen_ADI";
            buttonOpen_ADI.Size = new Size(120, 35);
            buttonOpen_ADI.TabIndex = 1;
            buttonOpen_ADI.Text = "Открыть";
            buttonOpen_ADI.UseVisualStyleBackColor = false;
            buttonOpen_ADI.Click += buttonOpen_ADI_Click;
            // 
            // buttonInfo_ADI
            // 
            buttonInfo_ADI.BackColor = Color.DeepSkyBlue;
            buttonInfo_ADI.FlatStyle = FlatStyle.Flat;
            buttonInfo_ADI.Font = new Font("Arial", 10F, FontStyle.Bold);
            buttonInfo_ADI.Location = new Point(265, 13);
            buttonInfo_ADI.Name = "buttonInfo_ADI";
            buttonInfo_ADI.Size = new Size(120, 35);
            buttonInfo_ADI.TabIndex = 2;
            buttonInfo_ADI.Text = "Справка";
            buttonInfo_ADI.UseVisualStyleBackColor = false;
            buttonInfo_ADI.Click += buttonInfo_ADI_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(1553, 600);
            Controls.Add(mainLayout_ADI);
            Controls.Add(panelButtons_ADI);
            Controls.Add(groupBoxTask_ADI);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 14 | Антонов Д.И.";
            groupBoxTask_ADI.ResumeLayout(false);
            mainLayout_ADI.ResumeLayout(false);
            groupBoxFile_ADI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewValues_ADI).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChart_ADI).EndInit();
            panelButtons_ADI.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
