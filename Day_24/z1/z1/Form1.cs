namespace z1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputString = string.Empty;

            if (listBox1.SelectedItem != null)
            {
                inputString = listBox1.SelectedItem.ToString();
            }

              string outputString = inputString.Replace('À', '*');

              label1.Text = outputString;
        }


    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}