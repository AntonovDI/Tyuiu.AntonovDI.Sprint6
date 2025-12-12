using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.AntonovDI.Sprint6.Task1.V11
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private GroupBox groupBoxTask_ADI;
        private PictureBox pictureTask_ADI;

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
            components = new System.ComponentModel.Container();

            groupBoxTask_ADI = new GroupBox();
            pictureTask_ADI = new PictureBox();

            groupBoxOutput_ADI = new GroupBox();
            textBoxResult_ADI = new TextBox();

            btnRun_ADI = new Button();
            btnInfo_ADI = new Button();

            SuspendLayout();

            // =======================
            // НАСТРОЙКИ ФОРМЫ
            // =======================
            this.ClientSize = new Size(900, 520);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 11 | Антонов Д.И.";



            // =======================
            // GROUPBOX УСЛОВИЕ
            // =======================
            groupBoxTask_ADI.Text = "Условие";
            groupBoxTask_ADI.Location = new Point(10, 10);
            groupBoxTask_ADI.Size = new Size(430, 500);

            // Картинка
            pictureTask_ADI.Dock = DockStyle.Fill;
            pictureTask_ADI.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTask_ADI.Image = Image.FromFile(@"C:\AntonovDI\Tyuiu.AntonovDI.Sprint6\img\task1.png");

            groupBoxTask_ADI.Controls.Add(pictureTask_ADI);

            // =======================
            // GROUPBOX ВЫВОД
            // =======================
            groupBoxOutput_ADI.Text = "Вывод данных";
            groupBoxOutput_ADI.Location = new Point(450, 10);
            groupBoxOutput_ADI.Size = new Size(430, 400);

            textBoxResult_ADI.Multiline = true;
            textBoxResult_ADI.ReadOnly = true;
            textBoxResult_ADI.ScrollBars = ScrollBars.Vertical;
            textBoxResult_ADI.Font = new Font("Consolas", 11f);
            textBoxResult_ADI.Dock = DockStyle.Fill;

            groupBoxOutput_ADI.Controls.Add(textBoxResult_ADI);

            // =======================
            // КНОПКА ВЫПОЛНИТЬ
            // =======================
            btnRun_ADI.Text = "Выполнить";
            btnRun_ADI.Size = new Size(200, 45);
            btnRun_ADI.Location = new Point(660, 430);
            btnRun_ADI.BackColor = Color.LightGreen;
            btnRun_ADI.Click += buttonExecute_Click;

            // =======================
            // КНОПКА СПРАВКА
            // =======================
            btnInfo_ADI.Text = "Справка";
            btnInfo_ADI.Size = new Size(150, 45);
            btnInfo_ADI.Location = new Point(450, 430);
            btnInfo_ADI.Click += buttonInfo_Click;

            // =======================
            // ДОБАВЛЕНИЕ НА ФОРМУ
            // =======================
            this.Controls.Add(groupBoxTask_ADI);
            this.Controls.Add(groupBoxOutput_ADI);
            this.Controls.Add(btnRun_ADI);
            this.Controls.Add(btnInfo_ADI);

            ResumeLayout(false);
        }
    }
}
