namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);
            textBox5.Text = "Работу выполнил ст. Иванов М.А." +
            Environment.NewLine;
            double x = x0;
            while (x <= (xk + dx / 2))
            {

                double y = (Math.Abs(x - Math.Pow(b, 1 / 2)) / Math.Pow(Math.Abs((Math.Pow(b, 3) - Math.Pow(x, 3))), 3 / 2) + Math.Log(Math.Abs(x - b)));
                textBox5.Text += "x=" + Convert.ToString(x) +
                "; \ny=" + Convert.ToString(y) +
                Environment.NewLine;

                x = x + dx;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}