namespace Label_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.BurlyWood;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
           label1.ForeColor = Color.DarkBlue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
           label1.ForeColor = Color.Red;
        }
    }
}