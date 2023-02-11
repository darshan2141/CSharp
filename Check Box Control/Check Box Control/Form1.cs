namespace Check_Box_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.Text = checkBox1.Text;
            }
            else
            {
                label1.Text = "";
            }
        }
    }
}