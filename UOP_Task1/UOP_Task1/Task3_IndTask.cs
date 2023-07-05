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
    public partial class Task3_IndTask : Form
    {
        public Task3_IndTask()
        {
            InitializeComponent();
        }

        private void prevForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Task1_Intro().ShowDialog();
        }

        private void nextForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Task3_Solve().ShowDialog();
        }
    }
}
