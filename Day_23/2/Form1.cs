namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);

            textBox4.Text += Environment.NewLine +
            "x = " + x.ToString();


            double y = double.Parse(textBox2.Text);

            textBox4.Text += Environment.NewLine +
            "y = " + y.ToString();

            double z = double.Parse(textBox3.Text);

            textBox4.Text += Environment.NewLine +
            "z = " + z.ToString();

            double p = Math.Abs(Math.Min(Math.Pow(x, 2), y) - Math.Max(y, z)) / 2;
            textBox4.Text += Environment.NewLine + "p = " + p.ToString();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}