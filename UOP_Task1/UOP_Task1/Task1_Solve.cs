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

namespace UOP_Task1
{
    public partial class Task1_Solve : Form
    {
        public Task1_Solve()
        {
            InitializeComponent();
        }

        private void prevForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Task1_IndTask().ShowDialog();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void solveThis_Click(object sender, EventArgs e)
        {
            PracticeDLL.Class1.Main(vvodX, vvodY, vivodD, vivodE, vivodF, errorProvider1);
            string[] lines = { DateTime.Now.ToString(), "Введённый X: " + vvodX.Text + "; введённый Y: " + vvodY.Text + "; полученный результат: " + vivodD.Text };
            if (String.IsNullOrEmpty(outFilePath.Text)) 
            {
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                File.AppendAllLines(Path.Combine(docPath, "Session_Task1.txt"), lines);
                MessageBox.Show("Файл с текущей сессией сохранён на Ваш рабочий стол с названием 'Session_Task1.txt'", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string docPath = outFilePath.Text;
                File.AppendAllLines(docPath, lines);
            }
        }

        private void openOutFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog outputFile = new SaveFileDialog();
            outputFile.Filter = "Файлы txt|*.txt";
            if (outputFile.ShowDialog()  == DialogResult.OK)
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
                vvodY.Focus();
        }

        private void vvodY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!(e.KeyChar.ToString() == "," && vvodY.Text.IndexOf(",") == -1) && !(e.KeyChar.ToString() == "-"))
                    e.Handled = true;
            }
            if (e.KeyChar.Equals((char)13))
                solveThis.Focus();
        }
    }
}
