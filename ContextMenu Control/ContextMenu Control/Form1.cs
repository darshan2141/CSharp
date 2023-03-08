namespace ContextMenu_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oddEvenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(textBox1.Text);
            if (val % 2 == 0)
            {
                MessageBox.Show("Enter Number is Even");
            }
            else
            {
                MessageBox.Show("Enter Number is Odd");
            }
        }

        private void positiveNegativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(textBox1.Text);
            if (val > 0)
            {
                MessageBox.Show("Enter Number is Positive");
            }
            else
            {
                MessageBox.Show("Enter Number is Negative");
            }
        }
    }
}