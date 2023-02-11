namespace scrollbar_with_picturebox
{
    public partial class Form1 : Form
    {
        string[] pict_path = new string[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pict_path[0] = @"F:\BCA\Semester 4\C#\program\unit-3\scrollbar with picturebox\scrollbar with picturebox\images\1.jpg";
            pict_path[1] = @"F:\BCA\Semester 4\C#\program\unit-3\scrollbar with picturebox\scrollbar with picturebox\images\2.jpg";
            pict_path[2] = @"F:\BCA\Semester 4\C#\program\unit-3\scrollbar with picturebox\scrollbar with picturebox\images\3.jpg";
            pict_path[3] = @"F:\BCA\Semester 4\C#\program\unit-3\scrollbar with picturebox\scrollbar with picturebox\images\4.jpg";
            pict_path[4] = @"F:\BCA\Semester 4\C#\program\unit-3\scrollbar with picturebox\scrollbar with picturebox\images\6.jpg";

            var wi = hScrollBar1;
            wi.Minimum = 1;
            wi.Maximum = 6;
            wi.SmallChange = 1;
            wi.LargeChange = 2;
            wi.Value = 1;
            pictureBox1.Image = Image.FromFile(pict_path[2]);

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Image = Image.FromFile(pict_path[hScrollBar1.Value - 1]);
        }
    }
}