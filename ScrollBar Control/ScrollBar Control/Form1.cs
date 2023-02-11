namespace ScrollBar_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hScrollBar1.Value > hScrollBar2.Value)
                MessageBox.Show("Scrollbar 1 is Max");
            else
                MessageBox.Show("Scrollbar 2 is Max");
        }

        void changecolor()
        {
            this.BackColor = Color.FromArgb(hScrollRed.Value,hScrollBarGreen.Value,hScrollBarBlue.Value);
        }
        private void hScrollRed_Scroll(object sender, ScrollEventArgs e)
        {
            changecolor();
        }

        private void hScrollBarGreen_Scroll(object sender, ScrollEventArgs e)
        {
            changecolor();
        }

        private void hScrollBarBlue_Scroll(object sender, ScrollEventArgs e)
        {
            changecolor();
        }
    }
}