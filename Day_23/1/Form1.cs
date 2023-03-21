namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

            double f = Math.Sqrt(y + Math.Sqrt(x - 1)) / (Math.Abs(x - y) * (Math.Pow(Math.Sin(z), 2) + Math.Tan(z)));

            textBox4.Text += Environment.NewLine +
            "f = " + f.ToString();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}