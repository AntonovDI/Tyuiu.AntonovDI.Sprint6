using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tyuiu.AntonovDI.Sprint6.Task7.V28.Lib;

namespace Tyuiu.AntonovDI.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        private string selectedFile_ADI = "";
        private DataService ds_ADI = new DataService();
        private int[,] matrix_ADI;

        public FormMain() => InitializeComponent();

        private void buttonOpen_ADI_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*",
                    Title = "Выберите файл с матрицей"
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFile_ADI = ofd.FileName;
                    matrix_ADI = ds_ADI.GetMatrix(selectedFile_ADI);
                    dataGridViewIn_ADI.DataSource = ToDataTable(matrix_ADI);
                    buttonProcess_ADI.Enabled = true;
                    labelFileInfo_ADI.Text = $"Выбран файл: {Path.GetFileName(selectedFile_ADI)} | Размер: {matrix_ADI.GetLength(0)}x{matrix_ADI.GetLength(1)}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файла:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonProcess_ADI_Click(object sender, EventArgs e)
        {
            try
            {
                if (matrix_ADI == null)
                {
                    MessageBox.Show("Сначала выберите файл!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int[,] resultMatrix_ADI = ds_ADI.ProcessMatrix(matrix_ADI);
                dataGridViewOut_ADI.DataSource = ToDataTable(resultMatrix_ADI);
                ConfigureDataGridView(dataGridViewOut_ADI);

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*",
                    FileName = "OutPutFileTask7V28.csv",
                    Title = "Сохранить результат"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ds_ADI.SaveMatrix(resultMatrix_ADI, sfd.FileName);
                    MessageBox.Show($"Файл успешно сохранен:\n{sfd.FileName}", "Сохранение завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обработке матрицы:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_ADI_Click(object sender, EventArgs e)
        {
            Form infoForm = new Form
            {
                Text = "О программе",
                Size = new Size(580, 320),
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            PictureBox pic_ADI = new PictureBox
            {
                ImageLocation = @"C:\AntonovDI\Tyuiu.AntonovDI.Sprint6\img\autor.jpg",
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(120, 160),
                Location = new Point(20, 20)
            };

            Label lbl_ADI = new Label
            {
                Text = "Разработчик: Антонов Даниил Иванович\n" +
                       "Группа: ИСТНб-25-1\n" +
                       "Программа разработана в рамках обучения языка C#\n" +
                       "Тюменский индустриальный университет (с) 2025\n" +
                       "Высшая школа цифровых технологий (с) 2025\n" +
                       "Внутреннее имя проекта: Tyuiu.Sprint6.Task7.V28",
                Location = new Point(160, 20),
                AutoSize = true
            };

            Button okBtn_ADI = new Button
            {
                Text = "OK",
                Size = new Size(80, 30),
                Location = new Point(380, 230),
                DialogResult = DialogResult.OK
            };

            infoForm.Controls.Add(pic_ADI);
            infoForm.Controls.Add(lbl_ADI);
            infoForm.Controls.Add(okBtn_ADI);
            infoForm.AcceptButton = okBtn_ADI;
            infoForm.ShowDialog();
        }

        private DataTable ToDataTable(int[,] array)
        {
            int rows = array.GetLength(0), cols = array.GetLength(1);
            DataTable dt = new DataTable();

            // Только числа: 1, 2, 3 ... без "Столбец"
            for (int c = 0; c < cols; c++) dt.Columns.Add((c + 1).ToString(), typeof(string));

            for (int r = 0; r < rows; r++)
            {
                DataRow dr = dt.NewRow();
                for (int c = 0; c < cols; c++) dr[c] = array[r, c].ToString();
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private void ConfigureDataGridView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = true;

            // Только числа для строк, без "Строка"
            for (int i = 0; i < dgv.Rows.Count; i++)
                dgv.Rows[i].HeaderCell.Value = (i + 1).ToString();

            dgv.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            if (dgv.Rows.Count > 6)
            {
                dgv.Rows[6].DefaultCellStyle.BackColor = Color.LightYellow;
                dgv.Rows[6].DefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
            }
        }
    }
}
