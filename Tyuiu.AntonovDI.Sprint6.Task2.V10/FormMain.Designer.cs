using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.AntonovDI.Sprint6.Task2.V10
{
    partial class FormMain
    {
        private GroupBox groupBox_Formula_ADI;
        private PictureBox pictureFormula_ADI;

        private GroupBox groupBox_Table_ADI;
        private DataGridView dataGridViewResult_ADI;

        private GroupBox groupBox_Chart_ADI;
        private PictureBox pictureBoxChart_ADI;

        private Button buttonExecute_ADI;
        private Button buttonInfo_ADI;

        private void InitializeComponent()
        {
            // === GroupBox с условием задачи ===
            groupBox_Formula_ADI = new GroupBox();
            pictureFormula_ADI = new PictureBox();
            groupBox_Formula_ADI.Text = "Условие задачи";
            groupBox_Formula_ADI.Location = new Point(10, 10);
            groupBox_Formula_ADI.Size = new Size(480, 240);

            pictureFormula_ADI.ImageLocation = @"C:\AntonovDI\Tyuiu.AntonovDI.Sprint6\img\task2.png";
            pictureFormula_ADI.SizeMode = PictureBoxSizeMode.Zoom;
            pictureFormula_ADI.Dock = DockStyle.Fill;

            groupBox_Formula_ADI.Controls.Add(pictureFormula_ADI);

            // === GroupBox с таблицей данных ===
            groupBox_Table_ADI = new GroupBox();
            dataGridViewResult_ADI = new DataGridView();
            groupBox_Table_ADI.Text = "Таблица значений";
            groupBox_Table_ADI.Location = new Point(10, 260);
            groupBox_Table_ADI.Size = new Size(480, 320);

            dataGridViewResult_ADI.Dock = DockStyle.Fill;
            dataGridViewResult_ADI.ReadOnly = true;
            dataGridViewResult_ADI.AllowUserToAddRows = false;
            dataGridViewResult_ADI.RowHeadersVisible = false;
            dataGridViewResult_ADI.ColumnCount = 2;
            dataGridViewResult_ADI.Columns[0].Name = "X";
            dataGridViewResult_ADI.Columns[1].Name = "f(X)";
            dataGridViewResult_ADI.Columns[0].Width = 80;
            dataGridViewResult_ADI.Columns[1].Width = 150;

            groupBox_Table_ADI.Controls.Add(dataGridViewResult_ADI);

            // === GroupBox с графиком ===
            groupBox_Chart_ADI = new GroupBox();
            pictureBoxChart_ADI = new PictureBox();
            groupBox_Chart_ADI.Text = "График функции";
            groupBox_Chart_ADI.Location = new Point(500, 10);
            groupBox_Chart_ADI.Size = new Size(780, 570);

            pictureBoxChart_ADI.Dock = DockStyle.Fill;
            pictureBoxChart_ADI.BackColor = Color.White;
            pictureBoxChart_ADI.Paint += pictureBoxChart_Paint;

            groupBox_Chart_ADI.Controls.Add(pictureBoxChart_ADI);

            // === Кнопки ===
            buttonExecute_ADI = new Button();
            buttonExecute_ADI.Text = "Выполнить";
            buttonExecute_ADI.BackColor = Color.LightGreen;
            buttonExecute_ADI.Font = new Font("Arial", 11, FontStyle.Bold);
            buttonExecute_ADI.Size = new Size(180, 35);
            buttonExecute_ADI.Location = new Point(500, 590);
            buttonExecute_ADI.Click += buttonExecute_Click;

            buttonInfo_ADI = new Button();
            buttonInfo_ADI.Text = "Справка";
            buttonInfo_ADI.BackColor = Color.LightSkyBlue;
            buttonInfo_ADI.Font = new Font("Arial", 11, FontStyle.Bold);
            buttonInfo_ADI.Size = new Size(180, 35);
            buttonInfo_ADI.Location = new Point(700, 590);
            buttonInfo_ADI.Click += buttonInfo_Click;

            // === Форма ===
            ClientSize = new Size(1300, 650);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

            Text = "Спринт 6 | Таск 2 | Вариант 10 | Антонов Д.И.";

            Controls.Add(groupBox_Formula_ADI);
            Controls.Add(groupBox_Table_ADI);
            Controls.Add(groupBox_Chart_ADI);
            Controls.Add(buttonExecute_ADI);
            Controls.Add(buttonInfo_ADI);
        }
    }
}
