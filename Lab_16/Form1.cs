namespace Lab_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }
    }
}