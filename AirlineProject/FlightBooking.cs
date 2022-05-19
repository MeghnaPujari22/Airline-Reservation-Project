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
    public partial class FlightBooking : Form
    {
        public FlightBooking()
        {
            InitializeComponent();
            BindGrid();
        }
        private void FlightBooking_Load(object sender, EventArgs e)
        {
            Fillpassenger();
            Fillflight();
            
        }
        readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECT\FinalAirline\AIRLINEPROJECT\AIRLINEPROJECT\AirlineDatabase.mdf;Integrated Security=True;Connect Timeout=30");

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

        private void Populate()
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from BookFlightTicket", con);
            adapt.Fill(dt);
            FlightbookDGV.DataSource = dt;
            con.Close();
            MessageBox.Show("Your Data Recorded Successfully");
        }

        // fill the Flight information
        private void Fillflight()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Flight_Number from TblFlight", con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Flight_Number", typeof(int));
            dt.Load(sdr);
            Fidcb.ValueMember = "Flight_Number";
            Fidcb.DataSource = dt;
            con.Close();
        }

        //Fetch data from database
        private string Famt;
        private void FetchFlight()
        {
            con.Open();
            string qry = "select * from TblFlight where Flight_Number=" + Fidcb.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow sdr in dt.Rows)
            {
                Famt = sdr["Price"].ToString();
                AmtTb.Text = Famt;
            }
            con.Close();
        }

        //Fetch data from database
        private string Pname;
        private string Passport;
        private string PNat;
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
                Passport = sdr["PassPassport"].ToString();
                PNat = sdr["PassNat"].ToString();
                Passname.Text = Pname;
                passporttb.Text = Passport;
                Pnat.Text = PNat;
            }
            con.Close();
        }

        private void Passidcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchPassenger();
        }

        private void Fidcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchFlight();
        }
        //booking
        private void BookBtn_Click(object sender, EventArgs e)
        {
            if (Tidtb.Text != "")
            {
                string Tid = Tidtb.Text;
                string Flight_Number = Fidcb.Text;
                string PassId = Passidcb.Text;
                string PassName = Passname.Text;
                string PassPassport = passporttb.Text;
                string PassNat = Pnat.Text;
                string Price = AmtTb.Text;
                con.Open();
                string firstQuery = "INSERT INTO BookFlightTicket(Tid, Flight_Number, PassId, PassName,PassPassport,PassNat,Price) values(@tid,@fn, @pi, @pn, @passport,@passnat, @TPrice)";
                SqlCommand cmd = new SqlCommand(firstQuery, con);
                cmd.Parameters.AddWithValue("@tid", Tid);
                cmd.Parameters.AddWithValue("@fn", Flight_Number);
                cmd.Parameters.AddWithValue("@pi", PassId);
                cmd.Parameters.AddWithValue("@pn", PassName);
                cmd.Parameters.AddWithValue("@passport", PassPassport);
                cmd.Parameters.AddWithValue("@passnat", PassNat);
                cmd.Parameters.AddWithValue("@TPrice", Price);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Flight Booked Successfully ;) ");
                con.Close();
                Populate();
            }
            else
            {
                MessageBox.Show("Please enter mandatory details!");
            }
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            Tidtb.Text = "";
            Fidcb.Text = "";
            Passidcb.Text = "";
            Passname.Text = "";
            passporttb.Text = "";
            Pnat.Text = "";
            AmtTb.Text = "";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            BookingPage H = new BookingPage();
            H.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FlightbookDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Tidtb.Text = FlightbookDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            Fidcb.Text = FlightbookDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            Passidcb.Text = FlightbookDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            Passname.Text = FlightbookDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            passporttb.Text = FlightbookDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            Pnat.Text = FlightbookDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            AmtTb.Text = FlightbookDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
        private void BindGrid()
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\PROJECT\FinalAirline\AIRLINEPROJECT\AIRLINEPROJECT\AirlineDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM BookFlightTicket", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            FlightbookDGV.DataSource = ds.Tables[0];
                        }
                    }
                }
            }
        }
    } 
}
