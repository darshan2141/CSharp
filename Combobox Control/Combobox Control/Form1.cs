namespace Combobox_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Index Number is : " + comboBox1.SelectedIndex.ToString(), "Index",
                //MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            MessageBox.Show("Value is : " + comboBox1.SelectedItem.ToString(), "Value",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are You Sure You Want To Exit The Application?", "Exit Application",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}