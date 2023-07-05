using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UOP_Task1
{
    public partial class Task1_Intro : Form
    {
        public Task1_Intro()
        {
            InitializeComponent();
        }

        private void nextForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Task1_IndTask().ShowDialog();
        }

        private void nextForm2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Task2_IndTask().ShowDialog();
        }

        private void nextForm3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Task3_IndTask().ShowDialog();
        }
    }
}
