using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationSystemCollegeProject
{
    public partial class View_Passangers : Form
    {
        public View_Passangers()
        {
            InitializeComponent();
            BindGrid();
        }

        readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECT\FinalAirline\AIRLINEPROJECT\AIRLINEPROJECT\AirlineDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void Populate()
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from TblPassanger", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //update button
        private void Button1_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text!="" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && textBox6.Text != "")
            {
                SqlCommand cmd = new SqlCommand("update TblPassanger set PassId=@pid,PassName=@name,PassPassport=@passport,PassAd=@pad,PassNat=@pnat,PassGend=@pgend,PassPhone=@Phone where PassId=@pid", con);
                con.Open();
                cmd.Parameters.AddWithValue("@pid", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@passport", textBox3.Text);
                cmd.Parameters.AddWithValue("@pad", textBox4.Text);
                cmd.Parameters.AddWithValue("@pnat", comboBox1.Text);
                cmd.Parameters.AddWithValue("@pgend", comboBox2.Text);
                cmd.Parameters.AddWithValue("@phone", textBox6.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Data has been Updated");
                Populate();
            }
            else
            {
                MessageBox.Show("Please enter mandatory details!");
            }

        }

        private void View_Passangers_Load(object sender, EventArgs e)
        {

        }

        //Redirected to Passanger details page
        private void Button3_Click(object sender, EventArgs e)
        {
            Passanger_Details Pd = new Passanger_Details();
            Pd.Show();
            this.Hide();
        }

        //Reset btn
        private void Reset_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
        }

        //Delete btn
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter the Passenger id to Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from TblPassanger where PassId=" + textBox1.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger details Deleted Successfully");
                    con.Close();
                    Populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BindGrid()
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECT\FinalAirline\AIRLINEPROJECT\AIRLINEPROJECT\AirlineDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TblPassanger", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                    }
                }
            }
        }
    }
}
