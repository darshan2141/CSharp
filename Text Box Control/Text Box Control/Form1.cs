namespace Text_Box_Control
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Aqua;
            textBox1.Text = textBox1.Text.ToUpper();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "Enter Event Fired";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int Count = 0;
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Count++;
            label3.Text = Count.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        int enterPress = 0;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                enterPress++;
                label9.Text = enterPress.ToString();
                textBox2.Focus();
            }
        }
        int keyPress = 0;
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress++;
            label6.Text = keyPress.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        int keyUp = 0;
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            keyUp++;
            label5.Text = keyUp.ToString();
        }
    }
}