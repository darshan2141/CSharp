namespace ListBox_Control
{
    public partial class Form1 : Form
    {
        int flag = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label2.Text = listBox1.SelectedIndex.ToString();
            //label4.Text = listBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "Total Item is = " + listBox1.Items.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                label6.Text = "Please Select Any Item";
            }
            else
            {
                label6.Text = "";
                //listBox1.Items.Remove(listBox1.SelectedItem.ToString());
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label6.ForeColor = Color.Red;
                label6.Text = "Please Enter Value into the Field";
                textBox1.Focus();
            }
            else
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (textBox1.Text == listBox1.Items[i].ToString())
                    {
                        flag = 1;
                        break;
                    }
                    else
                    {
                        flag = 0;
                    }
                }

                if (flag == 1)
                {
                    label6.ForeColor = Color.Red;
                    label6.Text = "Enter Item All-Ready Exists";
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                else
                {
                    label6.Text = "";
                    listBox1.Items.Add(textBox1.Text);
                    //insert in to Specific Index
                    //listBox1.Items.Insert(2, textBox1.Text);
                    textBox1.Text = "";
                    textBox1.Focus();
                }
            }
        }
    }
}