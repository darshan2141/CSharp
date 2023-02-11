namespace ProgressBar_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            label1.Text = progressBar1.Value + "%";
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                Form2 f = new Form2();
                //f.Show();
                f.ShowDialog();
                this.Hide();
            }
        }

        
    }
}