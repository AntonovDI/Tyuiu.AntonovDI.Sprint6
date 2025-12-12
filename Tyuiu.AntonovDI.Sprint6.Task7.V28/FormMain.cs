using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.AntonovDI.Sprint6.Task7.V28.Lib;

namespace Tyuiu.AntonovDI.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        string selectedFile_ADI = "";
        int[,] matrix_ADI;
        int[,] resultMatrix_ADI;
        DataService ds_ADI = new DataService();

        public FormMain() => InitializeComponent();

        private void buttonOpen_ADI_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*",
                    Title = "Выберите файл"
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFile_ADI = ofd.FileName;
                    matrix_ADI = LoadMatrix(ofd.FileName);

                    dataGridViewIn_ADI.DataSource = ToDataTable(matrix_ADI);
                    ConfigureGrid(dataGridViewIn_ADI);

                    buttonProcess_ADI.Enabled = true;
                    buttonSave_ADI.Enabled = false;

                    labelFileInfo_ADI.Text = "Файл: " + Path.GetFileName(ofd.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки файла.");
            }
        }

        private int[,] LoadMatrix(string path)
        {
            var lines = File.ReadAllLines(path);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;
            int[,] m = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var values = lines[i].Split(';').Select(t => t.Trim()).ToArray();
                for (int j = 0; j < cols; j++)
                    m[i, j] = int.Parse(values[j]);
            }

            return m;
        }

        private void buttonProcess_ADI_Click(object sender, EventArgs e)
        {
            if (matrix_ADI == null)
            {
                MessageBox.Show("Сначала выберите файл.");
                return;
            }

            resultMatrix_ADI = ds_ADI.ProcessMatrix(matrix_ADI);

            dataGridViewOut_ADI.DataSource = ToDataTable(resultMatrix_ADI);
            ConfigureGrid(dataGridViewOut_ADI);

            buttonSave_ADI.Enabled = true;
        }

        private void buttonSave_ADI_Click(object sender, EventArgs e)
        {
            if (resultMatrix_ADI == null)
            {
                MessageBox.Show("Сначала выполните обработку.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*",
                FileName = "OutMatrixV28.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ds_ADI.SaveMatrix(resultMatrix_ADI, sfd.FileName);
                MessageBox.Show("Файл сохранён.");
            }
        }

        private void buttonInfo_ADI_Click(object sender, EventArgs e)
        {
            Form f = new Form
            {
                Text = "О программе",
                Size = new Size(580, 320),
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

            PictureBox pic = new PictureBox
            {
                Image = Image.FromFile(@"C:\AntonovDI\Tyuiu.AntonovDI.Sprint6\img\autor.jpg"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(120, 160),
                Location = new Point(20, 20)
            };

            Label lbl = new Label
            {
                Text = "Антонов Даниил Иванович\nИСТНб-25-1\nСпринт 6 — Задание 7\nТИУ 2025",
                Location = new Point(160, 20),
                AutoSize = true
            };

            Button ok = new Button
            {
                Text = "OK",
                Size = new Size(80, 30),
                Location = new Point(380, 230),
                DialogResult = DialogResult.OK
            };

            f.Controls.Add(pic);
            f.Controls.Add(lbl);
            f.Controls.Add(ok);
            f.AcceptButton = ok;
            f.ShowDialog();
        }

        private DataTable ToDataTable(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            DataTable dt = new DataTable();
            for (int i = 0; i < cols; i++)
                dt.Columns.Add((i + 1).ToString());

            for (int r = 0; r < rows; r++)
            {
                DataRow dr = dt.NewRow();
                for (int c = 0; c < cols; c++)
                    dr[c] = arr[r, c];
                dt.Rows.Add(dr);
            }

            return dt;
        }

        private void ConfigureGrid(DataGridView d)
        {
            d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            d.RowHeadersVisible = true;

            for (int i = 0; i < d.Rows.Count; i++)
                d.Rows[i].HeaderCell.Value = (i + 1).ToString();

            d.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
