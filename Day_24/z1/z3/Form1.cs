using System;
using System.Drawing;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Point(object sender, EventArgs e)
        {

        }

        private void Form_Point(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            string text = "Апельсин";
            g.Clear(Color.DarkSlateBlue);
            SolidBrush sB = new SolidBrush(Color.DarkOrange);
            g.FillEllipse(sB,20,20,200,190);
            SolidBrush sR = new SolidBrush(Color.Green);
            g.FillEllipse(sR, 5, 5, 100, 50);
            Pen pen = new Pen(Color.Black, 2);
            g.DrawLine(pen, 100, 25, 120, 38);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
