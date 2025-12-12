using System;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.AntonovDI.Sprint6.Task3.V13.Lib;

namespace Tyuiu.AntonovDI.Sprint6.Task3.V13
{
    public partial class FormMain : Form
    {
        private DataService ds_ADI = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_ADI_Click(object sender, EventArgs e)
        {
            int[,] matrix_ADI = {
                { 12, -5, 7, 0, 3 },
                { -4, 9, 1, -2, 8 },
                { 3, -6, 4, 2, -1 },
                { 0, 7, -3, 5, 6 },
                { -2, 4, 8, -1, 9 }
            };

            int[,] sorted_ADI = ds_ADI.Calculate(matrix_ADI);

            dataGridViewResult_ADI.ColumnCount = 5;
            dataGridViewResult_ADI.RowCount = 5;
            dataGridViewResult_ADI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < 5; i++)
            {
                dataGridViewResult_ADI.Columns[i].HeaderText = $"Col {i + 1}";
                for (int j = 0; j < 5; j++)
                    dataGridViewResult_ADI.Rows[i].Cells[j].Value = sorted_ADI[i, j];
            }
        }

        private void buttonInfo_ADI_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Таск 3 выполнил студент группы ИСТНб-25-1 Антонов Даниил Иванович",
               "Сообщение"
           );
        }
    }
}
