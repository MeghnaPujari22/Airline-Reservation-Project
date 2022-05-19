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
    public partial class HotelBooking : Form
    {
        public HotelBooking()
        {
            InitializeComponent();
            BindGrid();
        }

        readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECT\FinalAirline\AIRLINEPROJECT\AIRLINEPROJECT\AirlineDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void Populate()
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from TblBookHotelRoom", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            MessageBox.Show("Your Data Recorded Successfully");
        
        }

        // fill the passenger information
        private void Fillpassenger()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select PassId from TblPassanger", con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassId", typeof(int));
            dt.Load(sdr);
            Passidcb.ValueMember = "PassId";
            Passidcb.DataSource = dt;
            con.Close();
        }

        // fill the Hotel information
        private void Fillhotel()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Hotel_Id from TblHotel", con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Hotel_Id", typeof(int));
            dt.Load(sdr);
            hidcb.ValueMember = "Hotel_Id";
            hidcb.DataSource = dt;
            con.Close();
        }

        //Fetch data from database
        private string Hrate;
        private void FetchHotel()
        {
            con.Open();
            string qry = "select * from TblHotel where Hotel_Id=" + hidcb.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow sdr in dt.Rows)
            {
                Hrate = sdr["Rate"].ToString();
                Ratetb.Text = Hrate;
            }
            con.Close();
        }

        //Fetch data from database
        private string Pname;
        private void FetchPassenger()
        {
            con.Open();
            string qry = "select * from TblPassanger where PassId=" + Passidcb.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow sdr in dt.Rows)
            {
                Pname = sdr["PassName"].ToString();
                Passname.Text = Pname;
            }
            con.Close();
        }


        private void BookBtn_Click(object sender, EventArgs e)
        {
            if (ridtb.Text != "")
            {
                string Rid = ridtb.Text;
                string Hotel_Id = hidcb.Text;
                string PassId = Passidcb.Text;
                string PassName = Passname.Text;
                string Checkin = dateTimePicker1.Value.ToString();
                string Checkout = dateTimePicker2.Value.ToString();
                string Rate = Ratetb.Text;
                con.Open();
                string firstQuery = "INSERT INTO TblBookHotelRoom(Rid, Hotel_Id, PassId, PassName, Checkin, Checkout, rate) values(@rid, @hid, @pi, @pn, @CI,@CO, @rate)";
                SqlCommand cmd = new SqlCommand(firstQuery, con);
                cmd.Parameters.AddWithValue("@rid", Rid);
                cmd.Parameters.AddWithValue("@hid", Hotel_Id);
                cmd.Parameters.AddWithValue("@pi", PassId);
                cmd.Parameters.AddWithValue("@pn", PassName);
                cmd.Parameters.AddWithValue("@CI", Checkin);
                cmd.Parameters.AddWithValue("@CO", Checkout);
                cmd.Parameters.AddWithValue("@rate", Rate);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hotel Room Booked Successfully ;) ");
                con.Close();
                Populate();
            }
            else
            {
                MessageBox.Show("Please enter mandatory details!");
            }
        }

        private void HotelBooking_Load(object sender, EventArgs e)
        {
            
            Fillpassenger();
            Fillhotel();
        }

        private void Hidcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchHotel();
        }

        private void Passidcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchPassenger();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            ridtb.Text = "";
            hidcb.Text = "";
            Passidcb.Text = "";
            Passname.Text = "";
            Ratetb.Text = "";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            BookingPage bp = new BookingPage();
            bp.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ridtb.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            hidcb.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Passidcb.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Passname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Ratetb.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
        private void BindGrid()
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECT\FinalAirline\AIRLINEPROJECT\AIRLINEPROJECT\AirlineDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TblBookHotelRoom", con))
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

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
