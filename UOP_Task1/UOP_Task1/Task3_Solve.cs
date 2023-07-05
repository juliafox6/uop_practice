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
    public partial class Task3_Solve : Form
    {
        public Task3_Solve()
        {
            InitializeComponent();
        }

        private void prevForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Task3_IndTask().ShowDialog();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void solveThis_Click(object sender, EventArgs e)
        {
            PracticeDLL.Class1.MainTask3(vvodX, vvodY, vvodA, vvodB, vvodC, vivodRet, errorProvider1);
            string[] lines = { DateTime.Now.ToString(), "Введённый X: " + vvodX.Text + "; введённый Y: " + vvodY.Text + "; введённый A: " + vvodA.Text + "; введённый B: " + vvodB.Text + "; введённый C: " + vvodC.Text + "; полученный результат: " + vivodRet.Text };
            if (String.IsNullOrEmpty(outFilePath.Text))
            {
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                File.AppendAllLines(Path.Combine(docPath, "Session_Task3.txt"), lines);
                MessageBox.Show("Файл с текущей сессией сохранён на Ваш рабочий стол с названием 'Session_Task3.txt'", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                vvodA.Focus();
        }

        private void vvodA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!(e.KeyChar.ToString() == "," && vvodA.Text.IndexOf(",") == -1) && !(e.KeyChar.ToString() == "-"))
                    e.Handled = true;
            }
            if (e.KeyChar.Equals((char)13))
                vvodB.Focus();
        }

        private void vvodB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!(e.KeyChar.ToString() == "," && vvodB.Text.IndexOf(",") == -1) && !(e.KeyChar.ToString() == "-"))
                    e.Handled = true;
            }
            if (e.KeyChar.Equals((char)13))
                vvodC.Focus();
        }

        private void vvodC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!(e.KeyChar.ToString() == "," && vvodC.Text.IndexOf(",") == -1) && !(e.KeyChar.ToString() == "-"))
                    e.Handled = true;
            }
            if (e.KeyChar.Equals((char)13))
                solveThis.Focus();
        }
    }
}
