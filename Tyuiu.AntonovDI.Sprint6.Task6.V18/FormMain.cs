using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.AntonovDI.Sprint6.Task6.V18.Lib;

namespace Tyuiu.AntonovDI.Sprint6.Task6.V18
{
    public partial class FormMain : Form
    {
        private string selectedFile_ADI = "";
        private DataService ds_ADI = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpen_ADI_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                    Title = "Выберите файл для обработки"
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFile_ADI = ofd.FileName;
                    textBoxIn_ADI.Text = File.ReadAllText(selectedFile_ADI);
                    buttonProcess_ADI.Enabled = true;
                    labelFileInfo_ADI.Text = $"Выбран файл: {Path.GetFileName(selectedFile_ADI)}";
                    labelFileInfo_ADI.Left = 10; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии файла:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonProcess_ADI_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(selectedFile_ADI))
                {
                    MessageBox.Show("Сначала выберите файл!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                textBoxOut_ADI.Text = ds_ADI.CollectTextFromFile(selectedFile_ADI);
                int wordCount = textBoxOut_ADI.Text.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
                labelStats_ADI.Text = $"Найдено слов с 'n': {wordCount}";
                labelStats_ADI.Left = 10; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обработке файла:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                       "Внутреннее имя проекта: Tyuiu.Sprint6.Task6.V18",
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
    }
}
