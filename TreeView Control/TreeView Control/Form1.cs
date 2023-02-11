namespace TreeView_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void root_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(textBox1.Text);
        }

        private void child_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Nodes.Add(textBox1.Text);
        }

        private void Count_Click(object sender, EventArgs e)
        {
            MessageBox.Show(treeView1.Nodes.Count.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }
    }
}