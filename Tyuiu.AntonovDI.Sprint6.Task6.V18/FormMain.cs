using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Tyuiu.AntonovDI.Sprint6.Task6.V18
{
    public partial class FormMain : Form
    {
        private string? selectedFile;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                    Title = "Выберите текстовый файл"
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFile = ofd.FileName;
                    textBoxIn.Text = File.ReadAllText(selectedFile);

                    buttonProcess.Enabled = true;
                    buttonSave.Enabled = false;

                    labelFileInfo.Text = "Файл: " + Path.GetFileName(selectedFile);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки файла.");
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIn.Text))
            {
                MessageBox.Show("Нет данных. Сначала загрузите файл!");
                return;
            }

            var words = textBoxIn.Text
                .Split(new[] { ' ', '\n', '\r', '\t', ',', '.', ';', ':', '!', '?' },
                       StringSplitOptions.RemoveEmptyEntries);

            var result = words
                .Where(w => w.Contains("l"))
                .ToArray();

            textBoxOut.Text = string.Join(" ", result);

            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxOut.Text))
            {
                MessageBox.Show("Нет результата для сохранения.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                FileName = "OutPutTask6V19.txt"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, textBoxOut.Text);
                MessageBox.Show("Файл успешно сохранён!");
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
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
                Location = new Point(20, 20),
                Size = new Size(120, 160)
            };

            Label lbl = new Label
            {
                Text = "Антонов Даниил Иванович\nИСТНб-25-1\nСпринт 6 — Задание 6\nВариант 19\nТИУ 2025",
                Location = new Point(160, 20),
                AutoSize = true
            };

            System.Windows.Forms.Button ok = new System.Windows.Forms.Button
            {
                Text = "OK",
                Location = new Point(380, 230),
                Size = new Size(80, 30),
                DialogResult = DialogResult.OK
            };

            f.Controls.Add(pic);
            f.Controls.Add(lbl);
            f.Controls.Add(ok);
            f.AcceptButton = ok;

            f.ShowDialog();
        }
    }
}
