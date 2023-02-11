namespace Timer_Control
{
    public partial class Form1 : Form
    {
        int i = 0;
        int red = 0, green = 0, blue = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i = i + 1;
            label1.Text = i.ToString();
            if (i >= 20)
            {
                timer1.Stop();
                Environment.Exit(0);
            }
            Random r = new Random();
            red = r.Next(0, 256);
            green = r.Next(0, 256);
            blue = r.Next(0, 256);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = i.ToString();
            timer1.Start();
        }
    }
}