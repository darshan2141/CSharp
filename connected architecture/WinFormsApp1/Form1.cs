using System.Data;
using System.Data.OleDb;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Data\\Std.accdb");
            con.Open();
            getData();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122)
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Enter All Field Value", "Blank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OleDbCommand checkCmd = new OleDbCommand("select std_no from std where std_no=" + Convert.ToInt32(textBox1.Text) + "", con);
                OleDbDataReader redCheckData = checkCmd.ExecuteReader();
                if (redCheckData.Read())
                {
                    MessageBox.Show("Record is Already Exists", "Dublicate Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                    textBox1.Focus();
                    redCheckData.Close();
                }
                else
                {
                    OleDbCommand insCmd = new OleDbCommand("insert into std values(" + Convert.ToInt32(textBox1.Text) + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + (radioButton1.Checked ? radioButton1.Text : radioButton2.Text) + "')", con);
                    int ans = insCmd.ExecuteNonQuery();

                    if (ans > 0)
                    {
                        MessageBox.Show("Record Inserted Successfully", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        comboBox1.SelectedIndex = -1;
                        getData();
                    }
                    else
                    {
                        MessageBox.Show("Record Not Inserted", "Not Inserted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void getData()
        {
            OleDbCommand getDataCmd = new OleDbCommand("select std_no as Id,std_name as Name,std_mobile as Mobile,std_city as City,std_gender as Gender from std", con);
            OleDbDataReader readGetData = getDataCmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(readGetData);
            dataGridView1.DataSource = dt;
            readGetData.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int stdId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
            if (e.ColumnIndex == 0)
            {
                OleDbCommand getDatFoupdate = new OleDbCommand("select * from std where std_no=" + stdId + "", con);
                OleDbDataReader readgetData = getDatFoupdate.ExecuteReader();

                if (readgetData.Read())
                {
                    textBox1.ReadOnly = true;
                    button1.Visible = false;
                    button2.Visible = true;
                    textBox1.Text = readgetData[0].ToString();
                    textBox2.Text = readgetData[1].ToString();
                    textBox3.Text = readgetData.GetValue(2).ToString();
                    comboBox1.Text = readgetData[3].ToString();
                    if (readgetData[4].ToString() == "Male")
                        radioButton1.Checked = true;
                    else
                        radioButton2.Checked = true;
                }

            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult res;
                res = MessageBox.Show("Are yout sure your want to delete record", "Delet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    OleDbCommand deleCmd = new OleDbCommand("delete from std where std_no=" + stdId + "", con);
                    deleCmd.ExecuteNonQuery();
                    MessageBox.Show("Record Delete Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getData();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand update = new OleDbCommand("update std set std_no=" + Convert.ToInt32(textBox1.Text) + ",std_name='" + textBox2.Text + "',std_mobile='" + textBox3.Text + "',std_city='" + comboBox1.Text + "',std_gender='" + (radioButton1.Checked ? radioButton1.Text : radioButton2.Text) + "' where std_no=" + Convert.ToInt32(textBox1.Text) + "", con);
            if (update.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Record Update Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.ReadOnly = false;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.SelectedIndex = -1;
                radioButton1.Checked = false;
                button1.Visible = true;
                button2.Visible = false;
                getData();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            OleDbCommand getDataCmd = new OleDbCommand("select std_no as Id,std_name as Name,std_mobile as Mobile,std_city as City,std_gender as Gender from std where std_name like '"+textBox4.Text+"%'", con);
            OleDbDataReader readGetData = getDataCmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(readGetData);
            dataGridView1.DataSource = dt;
            readGetData.Close();
        }
    }
}