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
    public partial class Record_New_Flight : Form
    {
        public Record_New_Flight()
        {
            InitializeComponent();
            
        }

        readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECT\FinalAirline\AIRLINEPROJECT\AIRLINEPROJECT\AirlineDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void Record_New_Flight_Load(object sender, EventArgs e)
        {

        }

        //save (record) button
        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && textBox3.Text != "" && dateTimePicker1.Value.ToString()!="" && textBox4.Text != "" && textBox5.Text != "")
            {
                SqlCommand cmd = new SqlCommand("insert into TblFlight(Flight_Number,Airline_name,A_From,A_To,Fare,Arrival_Date,Seats,Price) values(@fid,@Airlname,@source,@dest,@fare,@Arridate,@seats,@price)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@fid", textBox1.Text);
                cmd.Parameters.AddWithValue("@Airlname", textBox2.Text);
                cmd.Parameters.AddWithValue("@source", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@dest", comboBox2.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@fare", textBox3.Text);
                cmd.Parameters.AddWithValue("@Arridate", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                cmd.Parameters.AddWithValue("@seats", textBox4.Text);
                cmd.Parameters.AddWithValue("@price", textBox5.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Flight Details Recorded Successfully");
                
            }
            else
            {
                MessageBox.Show("Please enter mandatory details!");
            }

        }
    //reset button
    private void Resetbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void Showbtn_Click(object sender, EventArgs e)
        {
            View_Scheduled_Flights VSF = new View_Scheduled_Flights();
            VSF.Show();
            this.Hide();
        }
        //back btn
        private void Button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        //exit btn
        private void Label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
