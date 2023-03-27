using System;
using System.Windows.Forms;
using System.Threading;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void commandOneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void commandTwoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
