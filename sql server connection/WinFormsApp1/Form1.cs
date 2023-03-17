using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DEVIL\\SQLEXPRESS;Integrated Security=True");
            con.Open();
            getData();
        }
        public void getData()
        {
            SqlCommand getDataCmd = new SqlCommand("select std_no as Id,std_name as Name,std_mobile as Mobile ,std_city as City ,std_gender as Gender from std", con);
            SqlDataReader readGetData = getDataCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(readGetData);
            dataGridView1.DataSource = dt;
            readGetData.Close();
        }
        private void textBox2Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void textBox1No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 60 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122)
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void textBox3Mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 60 && e.KeyChar <= 90 || e.KeyChar >= 97 && e.KeyChar <= 122)
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void button1Insert_Click(object sender, EventArgs e)
        {
            if (textBox1No.Text == "" || textBox2Name.Text == "" || textBox3Mobile.Text == "" || comboBox1City.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter All Field", "Blank Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand checkDubCmd = new SqlCommand("select std_no from std where std_no =" + Convert.ToInt32(textBox1No.Text) + "", con);
                SqlDataReader readDub = checkDubCmd.ExecuteReader();
                if (readDub.Read())
                {
                    MessageBox.Show("This No Record is Already Exists", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox1No.Text = "";
                    textBox1No.Focus();
                    readDub.Close();
                }
                else
                {
                    readDub.Close();
                    SqlCommand insCmd = new SqlCommand("insert into std values('" + Convert.ToInt32(textBox1No.Text) + "','" + textBox2Name.Text + "','" + textBox3Mobile.Text + "','" + comboBox1City.Text + "','" + (radioButton1Male.Checked ? radioButton1Male.Text : radioButton1Female.Text) + "')", con);
                    int ans = insCmd.ExecuteNonQuery();
                    if (ans > 0)
                    {

                        MessageBox.Show("Record Inserted Successfully", "Record Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1No.Text = "";
                        textBox2Name.Text = "";
                        textBox3Mobile.Text = "";
                        comboBox1City.SelectedIndex = -1;
                        getData();
                    }
                    else
                    {
                        MessageBox.Show("Record Not Inserted", "Record Not Inserted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int stdId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
            if (e.ColumnIndex == 0)
            {
                SqlCommand getData = new SqlCommand("select * from std where std_no=" + stdId + "", con);
                SqlDataReader readData = getData.ExecuteReader();
                if (readData.Read())
                {

                    textBox1No.ReadOnly = true;
                    button1Insert.Visible = false;
                    button1Update.Visible = true;
                    textBox1No.Text = readData.GetValue(0).ToString();
                    textBox2Name.Text = readData[1].ToString();
                    textBox3Mobile.Text = readData[2].ToString();
                    comboBox1City.Text = readData[3].ToString();
                    if (readData[4].ToString() == "Male")
                        radioButton1Male.Checked = true;
                    else
                        radioButton1Female.Checked = true;
                    readData.Close();
                }

            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult res;
                res = MessageBox.Show("Are You Sure You Want To Delete This Record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    SqlCommand delCmd = new SqlCommand("delete from std where std_no=" + stdId + "", con);
                    delCmd.ExecuteNonQuery();
                    getData();
                }
            }
        }

        private void button1Update_Click(object sender, EventArgs e)
        {
            SqlCommand upCmd = new SqlCommand("update std set std_name='" + textBox2Name.Text + "',std_mobile='" + textBox3Mobile.Text + "',std_city='" + comboBox1City.Text + "',std_gender='" + (radioButton1Male.Checked ? radioButton1Male.Text : radioButton1Female.Text) + "' where std_no=" + Convert.ToInt32(textBox1No.Text) + "", con);
            int ans = upCmd.ExecuteNonQuery();
            if (ans > 0)
            {
                MessageBox.Show("Record Update Successfully", "Update Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1No.Text = "";
                textBox2Name.Text = "";
                textBox3Mobile.Text = "";
                comboBox1City.SelectedIndex = -1;
                textBox1No.ReadOnly = false;
                button1Update.Visible = false;
                button1Insert.Visible = true;
                getData();
            }
        }

        private void textBox4Search_TextChanged(object sender, EventArgs e)
        {
            SqlCommand getDataCmd = new SqlCommand("select std_no as Id,std_name as Name,std_mobile as Mobile ,std_city as City ,std_gender as Gender from std where std_name like '"+textBox4Search.Text+"%'", con);
            SqlDataReader readGetData = getDataCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(readGetData);
            dataGridView1.DataSource = dt;
            readGetData.Close();
        }
    }
}