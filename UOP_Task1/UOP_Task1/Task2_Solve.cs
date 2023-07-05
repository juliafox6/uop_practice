using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace UOP_Task1
{
    public partial class Task2_Solve : Form
    {
        public Task2_Solve()
        {
            InitializeComponent();
        }

        private void prevForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Task2_IndTask().ShowDialog();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void solveThis_Click(object sender, EventArgs e)
        {
            PracticeDLL.Class1.MainTask2(vvodX, vivodOut, vivodRef, errorProvider1);
            string[] lines = { DateTime.Now.ToString(), "Введённый X: " + vvodX.Text + "; полученный результат: " + vivodOut.Text };
            if (String.IsNullOrEmpty(outFilePath.Text))
            {
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                File.AppendAllLines(Path.Combine(docPath, "Session_Task2.txt"), lines);
                MessageBox.Show("Файл с текущей сессией сохранён на Ваш рабочий стол с названием 'Session_Task2.txt'", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string docPath = outFilePath.Text;
                File.AppendAllLines(docPath, lines);
            }
        }

        // Кнопка ниже - "Открыть", используется для выбора файла
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog outputFile = new SaveFileDialog();
            outputFile.Filter = "Файлы txt|*.txt";
            if (outputFile.ShowDialog() == DialogResult.OK)
            {
                outFilePath.Text = outputFile.FileName;
            }
        }

        private void vvodX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!(e.KeyChar.ToString() == "," && vvodX.Text.IndexOf(",") == -1) && !(e.KeyChar.ToString() == "-"))
                    e.Handled = true;
            }
            if (e.KeyChar.Equals((char)13))
                solveThis.Focus();
        }
    }
}
