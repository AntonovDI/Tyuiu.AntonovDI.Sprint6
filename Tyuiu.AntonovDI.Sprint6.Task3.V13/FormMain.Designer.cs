using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.AntonovDI.Sprint6.Task3.V13
{
    partial class FormMain
    {
        private GroupBox groupBoxTask_ADI;
        private TextBox textBoxTask_ADI;
        private GroupBox groupBoxResult_ADI;
        private DataGridView dataGridViewResult_ADI;
        private Button buttonExecute_ADI;
        private Button buttonInfo_ADI;

        private void InitializeComponent()
        {
            groupBoxTask_ADI = new GroupBox();
            textBoxTask_ADI = new TextBox();
            groupBoxResult_ADI = new GroupBox();
            dataGridViewResult_ADI = new DataGridView();
            buttonExecute_ADI = new Button();
            buttonInfo_ADI = new Button();
            groupBoxTask_ADI.SuspendLayout();
            groupBoxResult_ADI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_ADI).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_ADI
            // 
            groupBoxTask_ADI.Controls.Add(textBoxTask_ADI);
            groupBoxTask_ADI.Location = new Point(20, 20);
            groupBoxTask_ADI.Name = "groupBoxTask_ADI";
            groupBoxTask_ADI.Size = new Size(550, 180);
            groupBoxTask_ADI.TabIndex = 0;
            groupBoxTask_ADI.TabStop = false;
            groupBoxTask_ADI.Text = "Условие задачи";
            // 
            // textBoxTask_ADI
            // 
            textBoxTask_ADI.Dock = DockStyle.Fill;
            textBoxTask_ADI.Location = new Point(3, 23);
            textBoxTask_ADI.Multiline = true;
            textBoxTask_ADI.Name = "textBoxTask_ADI";
            textBoxTask_ADI.ReadOnly = true;
            textBoxTask_ADI.ScrollBars = ScrollBars.Vertical;
            textBoxTask_ADI.Size = new Size(544, 154);
            textBoxTask_ADI.TabIndex = 0;
            textBoxTask_ADI.Text = "Дан массив 5 на 5 элементов.\r\nВыполнить сортировку по определенному условию.\r\nИсходный массив:\r\n12 -5 7 0 3\r\n-4 9 1 -2 8\r\n3 -6 4 2 -1\r\n0 7 -3 5 6\r\n-2 4 8 -1 9";
            // 
            // groupBoxResult_ADI
            // 
            groupBoxResult_ADI.Controls.Add(dataGridViewResult_ADI);
            groupBoxResult_ADI.Location = new Point(20, 220);
            groupBoxResult_ADI.Name = "groupBoxResult_ADI";
            groupBoxResult_ADI.Size = new Size(550, 300);
            groupBoxResult_ADI.TabIndex = 1;
            groupBoxResult_ADI.TabStop = false;
            groupBoxResult_ADI.Text = "Таблица результата";
            // 
            // dataGridViewResult_ADI
            // 
            dataGridViewResult_ADI.AllowUserToAddRows = false;
            dataGridViewResult_ADI.ColumnHeadersHeight = 29;
            dataGridViewResult_ADI.Dock = DockStyle.Fill;
            dataGridViewResult_ADI.Location = new Point(3, 23);
            dataGridViewResult_ADI.Name = "dataGridViewResult_ADI";
            dataGridViewResult_ADI.ReadOnly = true;
            dataGridViewResult_ADI.RowHeadersWidth = 51;
            dataGridViewResult_ADI.Size = new Size(544, 274);
            dataGridViewResult_ADI.TabIndex = 0;
            // 
            // buttonExecute_ADI
            // 
            buttonExecute_ADI.BackColor = Color.LightGreen;
            buttonExecute_ADI.Font = new Font("Arial", 11F, FontStyle.Bold);
            buttonExecute_ADI.Location = new Point(23, 540);
            buttonExecute_ADI.Name = "buttonExecute_ADI";
            buttonExecute_ADI.Size = new Size(140, 35);
            buttonExecute_ADI.TabIndex = 2;
            buttonExecute_ADI.Text = "Выполнить";
            buttonExecute_ADI.UseVisualStyleBackColor = false;
            buttonExecute_ADI.Click += buttonExecute_ADI_Click;
            // 
            // buttonInfo_ADI
            // 
            buttonInfo_ADI.BackColor = Color.LightSkyBlue;
            buttonInfo_ADI.Font = new Font("Arial", 11F, FontStyle.Bold);
            buttonInfo_ADI.Location = new Point(418, 540);
            buttonInfo_ADI.Name = "buttonInfo_ADI";
            buttonInfo_ADI.Size = new Size(132, 35);
            buttonInfo_ADI.TabIndex = 3;
            buttonInfo_ADI.Text = "Справка";
            buttonInfo_ADI.UseVisualStyleBackColor = false;
            buttonInfo_ADI.Click += buttonInfo_ADI_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(600, 600);
            Controls.Add(groupBoxTask_ADI);
            Controls.Add(groupBoxResult_ADI);
            Controls.Add(buttonExecute_ADI);
            Controls.Add(buttonInfo_ADI);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 13 | Антонов Д.И.";
            groupBoxTask_ADI.ResumeLayout(false);
            groupBoxTask_ADI.PerformLayout();
            groupBoxResult_ADI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_ADI).EndInit();
            ResumeLayout(false);
        }
    }
}
